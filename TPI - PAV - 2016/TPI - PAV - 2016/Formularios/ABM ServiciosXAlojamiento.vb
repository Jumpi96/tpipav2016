Public Class ABM_ServiciosXAlojamiento
    Dim acceso As AccesoBD = AccesoBD.instancia
    Dim idAlojamiento As Integer
    Dim idServicio As Integer

    Private Sub ABM_ServiciosXAlojamiento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.cargarCombo("Servicios", "idServicio", "nombre", Me.cmbServicios)
        Me.cmbServicios.Enabled = False
        Me.dgvServiciosXAloj.Enabled = False
        Me.btnBorrar.Enabled = False
    End Sub

    Private Sub cargarCombo(ByVal nombre_tabla As String, ByVal pk As String, ByVal descripcion As String, ByRef combo As ComboBox)
        Dim tabla As Data.DataTable = acceso.query("SELECT * FROM " + nombre_tabla)

        combo.DataSource = tabla
        combo.DisplayMember = descripcion
        combo.ValueMember = pk
    End Sub
    Private Sub cargarAlojamiento()
        Dim sentencia As String = "SELECT SA.IdServXAlojamiento, SA.idAlojamiento, S.nombre FROM ServiciosXAlojamiento SA "
        sentencia &= "JOIN Alojamientos A ON A.idAlojamiento=SA.idAlojamiento JOIN Servicios S ON S.idServicio=SA.idServicio "
        sentencia &= "WHERE SA.idAlojamiento = " & txtIdAloj.Text

        Dim tabla As New DataTable

        tabla = acceso.query(sentencia)
        dgvServiciosXAloj.Rows.Clear()
        For Each row As DataRow In tabla.Rows
            dgvServiciosXAloj.Rows.Add(row(0), row(1), row(2))
        Next row

    End Sub

    Private Sub btnBuscarAloj_Click(sender As Object, e As EventArgs) Handles btnBuscarAloj.Click

        Dim tabla As New Data.DataTable
        If txtIdAloj.Text <> "" Then
            Dim sentencia As String = "SELECT * FROM Alojamientos WHERE idAlojamiento = " & txtIdAloj.Text
            tabla = acceso.query(sentencia)
        End If

        If (tabla.Rows.Count = 0) Then
            MessageBox.Show("El alojamiento ingresado no existe.")
        Else
            idAlojamiento = txtIdAloj.Text
            Me.cmbServicios.Enabled = True
            Me.dgvServiciosXAloj.Enabled = True
            cargarAlojamiento()
        End If
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Dim sentencia As String = "SELECT * FROM ServiciosXAlojamiento WHERE idAlojamiento=" & idAlojamiento & "AND idServicio=" & cmbServicios.SelectedValue
        Dim tabla As New DataTable
        tabla = acceso.query(sentencia)
        If tabla.Rows.Count = 0 Then
            sentencia = "INSERT INTO ServiciosXAlojamiento VALUES(" & idAlojamiento & "," & cmbServicios.SelectedValue & ")"
            acceso.nonQuery(sentencia)
            cargarAlojamiento()
        Else
            MessageBox.Show("El servicio ya se encuentra asociado al alojamiento.")
        End If
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        txtIdAloj.Text = ""
        Me.cmbServicios.Enabled = False
        Me.dgvServiciosXAloj.Rows.Clear()
        Me.dgvServiciosXAloj.Enabled = False
        Me.btnBorrar.Enabled = False
        idAlojamiento = 0
    End Sub

    Private Sub btnBorrar_Click(sender As Object, e As EventArgs) Handles btnBorrar.Click
        Dim sentencia As String = "DELETE FROM ServiciosXAlojamiento WHERE idAlojamiento= " & idAlojamiento & "AND idServicio= " & idServicio
        acceso.query(sentencia)
        cargarAlojamiento()
        MessageBox.Show("El servicio fue eliminado correctamente.")
    End Sub

    Private Sub dgvServiciosXAloj_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvServiciosXAloj.CellClick
        Dim a As String = dgvServiciosXAloj.Rows(dgvServiciosXAloj.CurrentRow.Index).Cells(2).Value
        Dim sentencia As String = "SELECT idServicio FROM Servicios WHERE nombre LIKE '" & a & "'"

        Dim tabla As New DataTable
        tabla = acceso.query(sentencia)
        idServicio = tabla.Rows(0)(0)

        btnBorrar.Enabled = True
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub
End Class