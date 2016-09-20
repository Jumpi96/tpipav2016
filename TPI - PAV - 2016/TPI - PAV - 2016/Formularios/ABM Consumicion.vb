Public Class ABM_Consumicion
    Dim acceso As AccesoBD = AccesoBD.instancia
    Dim idAlojamiento As Integer
    Dim idArticulo As Integer
    Private Sub ABM_Consumicion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarGrilla()
        cargarCombo()

    End Sub

#Region "Subrutinas"
    Private Sub cargarCombo()
        cmb_frigobar.DisplayMember = "No es de frigobar"
        cmb_frigobar.ValueMember = 0
        cmb_frigobar.DisplayMember = "Es de frigobar"
        cmb_frigobar.ValueMember = 1
    End Sub
    Private Sub cargarGrilla()
        Dim sql As String = "SELECT C.idConsumicion, C.idArticulo, C.idAlojamiento, C.cantidad, C.Frigobar FROM Consumicion C "
        sql &= "JOIN Alojamientos A ON A.idAlojamiento=C.idAlojamiento JOIN Articulos AR ON AR.idArticulo=C.idArticulo "
        sql &= "WHERE C.idAlojamiento = " & txt_idAlojamiento.Text

        Dim tabla As New DataTable

        tabla = acceso.query(sql)
        grid_consumiciones.Rows.Clear()
        For Each row As DataRow In tabla.Rows
            grid_consumiciones.Rows.Add(row(0), row(1), row(2), row(3), row(4))
        Next row

    End Sub
#End Region
#Region "Funciones"
    Private Function Validar() As Boolean
        If txt_idAlojamiento.Text = "" Then
            MessageBox.Show("Debe cargar el campo Alojamiento", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            txt_idAlojamiento.Focus()
            Return False
        End If
        If txt_articulo.Text = "" Then
            MessageBox.Show("Debe cargar el campo articulo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            txt_articulo.Focus()
            Return False
        End If
        If txt_cantidad.Text = "" Then
            MessageBox.Show("Debe cargar el campo cantidad", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            txt_cantidad.Focus()
            Return False
        End If
        If cmb_frigobar.SelectedIndex = -1 Then
            MessageBox.Show("Debe cargar el seleccionar un tipo de consumicion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            cmb_frigobar.Focus()
            Return False
        End If
        Return True
    End Function

#End Region
#Region "Click"

    Private Sub cmd_buscar_Click_1(sender As Object, e As EventArgs) Handles cmd_buscar.Click

        Dim tabla As New Data.DataTable
        If txt_idAlojamiento.Text <> "" Then
            Dim sql As String = "SELECT * FROM Alojamientos WHERE idAlojamiento = " & txt_idAlojamiento.Text
            tabla = acceso.query(sql)
        End If

        If (tabla.Rows.Count = 0) Then
            MessageBox.Show("El alojamiento ingresado no existe.")
        Else
            idAlojamiento = txt_idAlojamiento.Text
            Me.txt_articulo.Enabled = True
            Me.grid_consumiciones.Enabled = True
            cargarGrilla()
        End If
    End Sub

    Private Sub cmd_agregar_Click(sender As Object, e As EventArgs) Handles cmd_agregar.Click
        If Validar() Then
            Dim sql As String
            Dim tabla As New DataTable
            sql = "INSERT INTO Consumicion VALUES(" & idArticulo & "," & idAlojamiento & "," & txt_cantidad.Text & "," & cmb_frigobar.SelectedIndex & ")"
            acceso.nonQuery(sql)
            cargarGrilla()
            MessageBox.Show("Se agrego una nueva consumicion")
        End If

    End Sub
   

    Private Sub cmd_limpiar_Click(sender As Object, e As EventArgs) Handles cmd_limpiar.Click
        txt_idAlojamiento.Text = ""
        txt_articulo.Text = ""
        txt_cantidad.Text = ""
        Me.cmb_frigobar.SelectedIndex = -1
        Me.cmb_frigobar.Enabled = True
        Me.grid_consumiciones.Rows.Clear()
        Me.grid_consumiciones.Enabled = False
        idAlojamiento = 0
    End Sub
    Private Sub cmd_cerrar_Click(sender As Object, e As EventArgs) Handles cmd_cerrar.Click
        Me.Close()
    End Sub
#End Region

   
   
End Class