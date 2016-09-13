Public Class ABM_Clientes
    Dim cadena_conexion As String = "Provider=SQLNCLI11;Data Source=LAWEBSTORE-PC\SQLSERVER2014;Integrated Security=SSPI;Initial Catalog=hotelShaky"
    Enum estado
        insertar
        modificar
    End Enum
    Dim condicion_estado As estado = estado.insertar

    Enum estadoBusqueda
        todo
        tipoDocumento
        nroDocumento
    End Enum



    Private Function Validar() As Boolean
        If txt_apellido.Text = "" Then
            MessageBox.Show("Debe completar el campo Apellido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            txt_apellido.Focus()
            Return False
        End If
        If txt_nombre.Text = "" Then
            MessageBox.Show("Debe completar el campo Nombre", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            txt_nombre.Focus()
            Return False
        End If
        If txt_nroDoc.Text = "" Then
            MessageBox.Show("Debe completar el campo Nro de Documento", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            txt_nroDoc.Focus()
            Return False
        End If
        If txt_telefono.Text = "" Then
            MessageBox.Show("Debe completar el campo Telefono", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            txt_telefono.Focus()
            Return False
        End If
        If cmb_tipoDoc.SelectedIndex = -1 Then
            MessageBox.Show("Debe completar el campo Tipo de Documento", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            cmb_tipoDoc.Focus()
            Return False
        End If
        Return True
    End Function
    Private Sub cmd_registrar_Click(sender As Object, e As EventArgs) Handles cmd_registrar.Click

        If Me.Validar = True Then
            If condicion_estado = estado.insertar Then
                If Me.validar_existencia() = False Then
                    Me.insertar()
                Else
                    MessageBox.Show("Ya existe este Cliente")
                    Exit Sub
                End If
            Else
                Me.modificar()

            End If
            Me.cmd_limpiar.PerformClick()
        End If


    End Sub


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.cargar_combo("TiposDocumento", "idTipoDocumento", "nombre", Me.cmb_tipoDoc)
        Me.cargar_grilla(estadoBusqueda.todo)

    End Sub

    Private Sub cargar_combo(ByVal nombre_tabla As String, ByVal pk As String, ByVal descripcion As String, ByRef combo As ComboBox)
        Dim conexion As New Data.OleDb.OleDbConnection
        Dim cmd As New Data.OleDb.OleDbCommand
        Dim tabla As New Data.DataTable

        Dim sql As String = "SELECT * FROM " + nombre_tabla
        conexion.ConnectionString = cadena_conexion
        conexion.Open()
        cmd.Connection = conexion
        cmd.CommandType = CommandType.Text
        cmd.CommandText = sql
        tabla.Load(cmd.ExecuteReader)
        conexion.Close()

        combo.DataSource = tabla
        combo.DisplayMember = descripcion
        combo.ValueMember = pk
    End Sub

    Private Sub cargar_grilla(ByVal buscarEn As estadoBusqueda)
        Me.grid_clientes.Rows.Clear()
        Dim conexion As New Data.OleDb.OleDbConnection
        Dim comando As New Data.OleDb.OleDbCommand
        Dim tabla As New Data.DataTable

        Dim sql As String = "SELECT * FROM Clientes C JOIN TiposDocumento T ON  C.tipoDocumento = T.idTipoDocumento "

        If buscarEn = estadoBusqueda.tipoDocumento Then
            sql = sql & " WHERE tipoDocumento = " & Me.cmb_tipoDoc.SelectedValue

        ElseIf buscarEn = estadoBusqueda.nroDocumento Then
            sql = sql & " WHERE nroDocumento = " & Me.txt_nroDoc.Text & " AND tipoDocumento = " & Me.cmb_tipoDoc.SelectedValue
        End If



        conexion.ConnectionString = cadena_conexion
        conexion.Open()
        comando.Connection = conexion
        comando.CommandType = CommandType.Text
        comando.CommandText = sql
        tabla.Load(comando.ExecuteReader)
        conexion.Close()

        Dim i As Integer

        For i = 0 To tabla.Rows.Count() - 1

            Me.grid_clientes.Rows.Add() 'current row es la fila actual y cell es la celda de esa fila
            Me.grid_clientes.Rows(i).Cells("col_nombre").Value = tabla.Rows(i)("nombre")
            Me.grid_clientes.Rows(i).Cells("col_apellido").Value = tabla.Rows(i)("apellido")
            Me.grid_clientes.Rows(i).Cells("col_tipoDocumento").Value = tabla.Rows(i)(7)
            Me.grid_clientes.Rows(i).Cells("col_nroDocumento").Value = tabla.Rows(i)("nroDocumento")
        Next

    End Sub

    Private Sub insertar()
        Dim conexion As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim sql As String = "INSERT INTO Clientes (apellido, nombre, nroDocumento, tipoDocumento, fechaNacimiento, telefono) " _
           & "VALUES ('" & txt_apellido.Text & "', '" & txt_nombre.Text & "', " & txt_nroDoc.Text & ", '" & cmb_tipoDoc.SelectedValue & "',  getDate() , " & txt_telefono.Text & ")"


        conexion.ConnectionString = cadena_conexion
        conexion.Open()
        cmd.Connection = conexion
        cmd.CommandType = CommandType.Text
        cmd.CommandText = sql
        cmd.ExecuteNonQuery()
        conexion.Close()
        MessageBox.Show("Se registró exitosamente.")
        Me.cargar_grilla(estadoBusqueda.todo)
    End Sub

    Private Function validar_existencia() As Boolean
        Dim conexion As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim tabla As New DataTable
        Dim sql As String = ""
        sql = "SELECT * FROM Clientes " _
            & "WHERE tipoDocumento = " & Me.cmb_tipoDoc.SelectedValue & " AND nroDocumento = " & txt_nroDoc.Text

        conexion.ConnectionString = cadena_conexion
        conexion.Open()
        cmd.Connection = conexion
        cmd.CommandType = CommandType.Text
        cmd.CommandText = sql

        tabla.Load(cmd.ExecuteReader())
        conexion.Close()

        If tabla.Rows.Count() = 0 Then
            Return False
        Else
            Return True
        End If
    End Function

    Private Sub cmd_limpiar_Click(sender As Object, e As EventArgs) Handles cmd_limpiar.Click
        Me.condicion_estado = estado.insertar
        Me.txt_apellido.Text = ""
        Me.txt_nombre.Text = ""
        Me.txt_nroDoc.Text = ""
        Me.txt_telefono.Text = ""
        Me.txt_nroDoc.Enabled = True
        Me.cmb_tipoDoc.Enabled = True
        Me.cargar_grilla(estadoBusqueda.todo)
        Me.cmd_registrar.Text = "Registrar"
        Me.cmd_borrar.Enabled = False
        Me.cmd_borrar.Visible = False

    End Sub

    Private Sub cmd_buscar_Click(sender As Object, e As EventArgs) Handles cmd_buscar.Click
        If Me.txt_nroDoc.Text = "" Then
            Me.cargar_grilla(estadoBusqueda.tipoDocumento)
        Else
            Me.cargar_grilla(estadoBusqueda.nroDocumento)
        End If

    End Sub

    Private Sub grid_clientes_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles grid_clientes.CellContentDoubleClick
        Dim conexion As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim tabla As New DataTable
        Dim sql As String = ""

        sql = "SELECT * FROM Clientes C JOIN TiposDocumento T ON  C.tipoDocumento = T.idTipoDocumento " _
            & "WHERE T.nombre = '" & Me.grid_clientes.CurrentRow.Cells("col_tipoDocumento").Value & "' AND C.nroDocumento = " & Me.grid_clientes.CurrentRow.Cells("col_nroDocumento").Value


        conexion.ConnectionString = cadena_conexion
        conexion.Open()
        cmd.Connection = conexion
        cmd.CommandType = CommandType.Text
        cmd.CommandText = sql
        tabla.Load(cmd.ExecuteReader())
        conexion.Close()
        If tabla.Rows.Count() = 0 Then
            MessageBox.Show("El cliente requerido no existe.")
            Exit Sub
        End If

        Me.cmd_borrar.Enabled = True
        Me.cmd_borrar.Visible = True
        Me.cmd_registrar.Text = "Modificar"


        Me.txt_nroDoc.Text = tabla.Rows(0)("nroDocumento")
        Me.txt_apellido.Text = tabla.Rows(0)("apellido")
        Me.txt_nombre.Text = tabla.Rows(0)("nombre")
        Me.cmb_tipoDoc.SelectedValue = tabla.Rows(0)("idTipoDocumento")
        Me.txt_telefono.Text = tabla.Rows(0)("telefono")


        Me.cmb_tipoDoc.Enabled = False
        Me.txt_nroDoc.Enabled = False
        Me.condicion_estado = estado.modificar
        Me.cmd_buscar.PerformClick()
    End Sub

    Private Sub modificar()

        Dim conexion As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim sql As String = ""

        sql &= "UPDATE Clientes "
        sql &= "SET nombre = '" & Me.txt_nombre.Text & "'"
        sql &= " , apellido = '" & Me.txt_apellido.Text & "'"
        sql &= " , telefono = '" & Me.txt_telefono.Text & "'"
        sql &= " WHERE nroDocumento = " & Me.txt_nroDoc.Text
        sql &= " AND tipoDocumento = " & Me.cmb_tipoDoc.SelectedValue

        conexion.ConnectionString = cadena_conexion
        conexion.Open()
        cmd.Connection = conexion
        cmd.CommandType = CommandType.Text
        cmd.CommandText = sql

        cmd.ExecuteNonQuery()

        conexion.Close()
        MessageBox.Show("Se modificó correctamente.")
        Me.cargar_grilla(estadoBusqueda.todo)

    End Sub



    Private Sub cmd_cancelar_Click(sender As Object, e As EventArgs) Handles cmd_cancelar.Click
        Me.Close()
    End Sub

    Private Sub cmd_borrar_Click(sender As Object, e As EventArgs) Handles cmd_borrar.Click
        Dim conexion As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim tabla As New DataTable
        Dim sql As String = "DELETE FROM Clientes WHERE nroDocumento = " & Me.txt_nroDoc.Text
        sql &= " AND tipoDocumento = " & Me.cmb_tipoDoc.SelectedValue

        conexion.ConnectionString = cadena_conexion
        conexion.Open()
        cmd.Connection = conexion
        cmd.CommandType = CommandType.Text
        cmd.CommandText = sql
        tabla.Load(cmd.ExecuteReader())
        conexion.Close()
        Me.cargar_grilla(estadoBusqueda.todo)
        Me.cmd_limpiar.PerformClick()

        MessageBox.Show("Se ha eliminado el tipo de Documento Satisfactoriamente")
    End Sub
End Class