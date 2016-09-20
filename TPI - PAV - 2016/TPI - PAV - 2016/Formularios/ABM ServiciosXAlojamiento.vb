Public Class ABM_ServiciosXAlojamiento
    Dim acceso As AccesoBD = AccesoBD.instancia
    Dim idAlojamientoSub As Integer
    Dim idServicioSub As Integer

    Private Sub ABM_ServiciosXAlojamiento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.cargarCombo("Servicios", "idServicio", "nombre", Me.cmbServicios)
        Me.cmbServicios.Enabled = False
        Me.dgvServiciosXAloj.Enabled = False
        Me.btnBorrar.Enabled = False
        idAlojamientoSub = -1
        idServicioSub = -1
        MessageBox.Show(Today.Date)
    End Sub

    Private Sub cargarCombo(ByVal nombre_tabla As String, ByVal pk As String, ByVal descripcion As String, ByRef combo As ComboBox)
        Dim tabla As Data.DataTable = acceso.query("SELECT * FROM " + nombre_tabla)

        combo.DataSource = tabla
        combo.DisplayMember = descripcion
        combo.ValueMember = pk
    End Sub

    Private Sub cargarGrilla()
        Dim sentencia As String = "SELECT A.idAlojamiento, S.nombre, S.idServicio FROM ServiciosXAlojamiento SA "
        sentencia &= "JOIN Alojamientos A ON A.idAlojamiento = SA.idAlojamiento JOIN Servicios S ON S.idServicio=SA.idServicio "
        sentencia &= "WHERE A.nroHabitacion = '" & txt_nroHabitacion.Text & "'"

        Dim tabla As New DataTable

        tabla = acceso.query(sentencia)
        dgvServiciosXAloj.Rows.Clear()

        If tabla.Rows.Count() <> 0 Then
            Dim i As Integer
            For i = 0 To tabla.Rows.Count() - 1
                Me.dgvServiciosXAloj.Rows.Add()
                Me.dgvServiciosXAloj.Rows(i).Cells("Alojamiento").Value = tabla.Rows(i)("idAlojamiento")
                Me.dgvServiciosXAloj.Rows(i).Cells("Servicio").Value = tabla.Rows(i)("nombre")
                Me.dgvServiciosXAloj.Rows(i).Cells("idServicio").Value = tabla.Rows(i)("idServicio")
            Next
        End If
    End Sub

    Private Function validarCampos() As Boolean
        If Me.txt_nroHabitacion.Text = "" Then
            MessageBox.Show("Número de habitación no ingresado", "Error", MessageBoxButtons.OK)
            Me.txt_nroHabitacion.Focus()
            Return False
        End If
        Return True
    End Function

    Private Function validarNroHabitacion() As Boolean
        Dim sql As String = ""
        Dim tabla As New Data.DataTable

        sql &= "SELECT * FROM HabitacionesXPiso JOIN Alojamientos "
        sql &= "ON HabitacionesXPiso.nroHabitacion = Alojamientos.nroHabitacion "
        sql &= "WHERE CONVERT(date,GETDATE()) BETWEEN fechaInicioAlojamiento AND fechaFinEstimadaAlojamiento "
        sql &= "AND HabitacionesXPiso.nroHabitacion = '" & Me.txt_nroHabitacion.Text & "'"

        tabla = acceso.query(sql)

        If tabla.Rows.Count() = 0 Then
            MessageBox.Show("Esa habitación no esta asociada a un alojamiento en proceso actualmente", "Error", MessageBoxButtons.OK)
            Return False
        End If

        Return True
    End Function

    Private Sub cargarDatosCliente()
        Dim sql As String = ""
        Dim tabla As New Data.DataTable

        sql &= "SELECT * FROM HabitacionesXPiso JOIN Alojamientos "
        sql &= "ON Alojamientos.nroHabitacion = HabitacionesXPiso.nroHabitacion "
        sql &= "JOIN Clientes ON Clientes.nroDocumento = Alojamientos.nroDoc AND clientes.tipoDocumento = Alojamientos.tipoDoc "
        sql &= "WHERE CONVERT(date,GETDATE()) BETWEEN fechaInicioAlojamiento AND fechaFinEstimadaAlojamiento "
        sql &= "AND HabitacionesXPiso.nroHabitacion = '" & Me.txt_nroHabitacion.Text & "'"

        tabla = acceso.query(sql)

        Me.txt_tipoDocumento.Text = tabla.Rows(0)("tipoDocumento")
        Me.txt_documento.Text = tabla.Rows(0)("nroDoc")
        Me.txt_apellido.Text = tabla.Rows(0)("apellido")
        Me.txt_nombre.Text = tabla.Rows(0)("nombre")
        idAlojamientoSub = tabla.Rows(0)("idAlojamiento")
    End Sub

    Private Sub btnBuscarAloj_Click(sender As Object, e As EventArgs) Handles btnBuscarAloj.Click
        If Me.validarCampos() = True Then
            If Me.validarNroHabitacion() = True Then
                Me.txt_nroHabitacion.ReadOnly = True
                Me.dgvServiciosXAloj.Enabled = True
                Me.cmbServicios.Enabled = True
                Me.btnAgregar.Enabled = True
                Me.btnLimpiar.Enabled = True
                Me.cargarDatosCliente()
                Me.cargarCombo("Servicios", "idServicio", "nombre", Me.cmbServicios)
                Me.cargarGrilla()
            End If
        End If
    End Sub

    Private Function validarAgregar() As Boolean
        Dim sql As String = ""
        Dim tabla As New Data.DataTable

        sql &= "SELECT * FROM ServiciosXAlojamiento JOIN Alojamientos "
        sql &= "ON ServiciosXAlojamiento.idAlojamiento = Alojamientos.idAlojamiento "
        sql &= "WHERE Alojamientos.nroHabitacion = " & Me.txt_nroHabitacion.Text & " "
        sql &= "AND ServiciosXAlojamiento.idServicio = '" & cmbServicios.SelectedValue & "'"

        tabla = acceso.query(sql)

        If tabla.Rows.Count() <> 0 Then
            MessageBox.Show("El servicio ya se ha agregado", "Error", MessageBoxButtons.OK)
            Return False
        End If

        Return True
    End Function

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Dim sql As String = ""

        If validarAgregar() = True Then
            sql &= "INSERT INTO ServiciosXAlojamiento (idAlojamiento,idServicio) "
            sql &= "VALUES ('" & idAlojamientoSub & "','" & cmbServicios.SelectedValue & "')"

            acceso.nonQuery(sql)

            MessageBox.Show("El servicio se agrego exitosamente")

            Me.cargarGrilla()
        End If
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        txt_nroHabitacion.Text = ""
        Me.txt_apellido.Text = ""
        Me.txt_nombre.Text = ""
        Me.txt_documento.Text = ""
        Me.txt_tipoDocumento.Text = ""
        Me.cmbServicios.Enabled = False
        Me.dgvServiciosXAloj.Rows.Clear()
        Me.dgvServiciosXAloj.Enabled = False
        Me.dgvServiciosXAloj.Rows.Clear()
        Me.btnBorrar.Enabled = False
        Me.txt_nroHabitacion.ReadOnly = False
        idAlojamientoSub = -1
        idServicioSub = -1
    End Sub

    Private Function validarBorrado() As Boolean
        If Me.txt_servicioSeleccionado.Text = "" Then
            MessageBox.Show("No se ha seleccionado ningún servicio", "Error", MessageBoxButtons.OK)
            Return False
        End If
        If idAlojamientoSub < 0 Then
            MessageBox.Show("No hay un idAlojamiento asociado. Consultar al programador", "Error", MessageBoxButtons.OK)
            Return False
        End If
        If idServicioSub < 0 Then
            MessageBox.Show("No hay un idServicio asociado. Consultar al programador", "Error", MessageBoxButtons.OK)
            Return False
        End If
        Return True
    End Function

    Private Sub btnBorrar_Click(sender As Object, e As EventArgs) Handles btnBorrar.Click
        Dim sql As String = ""

        If Me.validarBorrado() = True Then
            sql &= "DELETE FROM ServiciosXAlojamiento "
            sql &= "WHERE idServicio = '" & idServicioSub & "' "
            sql &= "AND idAlojamiento = '" & idAlojamientoSub & "'"

            acceso.nonQuery(sql)

            MessageBox.Show("Serviocio eliminado con éxito")

            Me.txt_servicioSeleccionado.Text = ""
            idAlojamientoSub = -1
            idServicioSub = -1

            Me.cargarGrilla()
        End If
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub txt_nroHabitacion_MouseClick(sender As Object, e As MouseEventArgs) Handles txt_nroHabitacion.MouseClick
        If Me.txt_nroHabitacion.Text = "" Then
            Me.txt_nroHabitacion.SelectionStart = 0
        End If
    End Sub

    Private Sub dgvServiciosXAloj_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvServiciosXAloj.CellContentDoubleClick
        Me.txt_servicioSeleccionado.Text = dgvServiciosXAloj.CurrentRow.Cells("Servicio").Value
        idServicioSub = dgvServiciosXAloj.CurrentRow.Cells("idServicio").Value
        Me.btnBorrar.Enabled = True
    End Sub
End Class