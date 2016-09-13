Public Class ABM_Clientes
    Dim cadena_conexion As String = "Provider=SQLNCLI11;Data Source=LAWEBSTORE-PC\SQLSERVER2014;Integrated Security=SSPI;Initial Catalog=hotelShaky"
    Enum estado
        insertar
        modificar
    End Enum
    Dim condicion_estado As estado = estado.insertar

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
                    Me.limpiar()
                Else
                    MessageBox.Show("Ya existe este Cliente")
                    Exit Sub
                End If
            Else
                'Me.modificar()
            End If
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles cmd_buscar.Click

    End Sub

    Private Sub lbl_telefono_Click(sender As Object, e As EventArgs) Handles lbl_telefono.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.cargar_combo("TiposDocumento", "idTipoDocumento", "nombre", Me.cmb_tipoDoc)
        Me.cargar_grilla()

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

    Private Sub cargar_grilla()
        Me.grid_clientes.Rows.Clear()
        Dim conexion As New Data.OleDb.OleDbConnection
        Dim comando As New Data.OleDb.OleDbCommand
        Dim tabla As New Data.DataTable

        Dim sql As String = "SELECT * FROM Clientes C JOIN TiposDocumento T ON  C.tipoDocumento = T.idTipoDocumento"


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
        MessageBox.Show("Se guardó exitosamente")
        Me.cargar_grilla()
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
        Me.limpiar()
    End Sub

    Private Sub limpiar()
        Me.condicion_estado = estado.insertar
        Me.txt_apellido.Text = ""
        Me.txt_nombre.Text = ""
        Me.txt_nroDoc.Text = ""
        Me.txt_telefono.Text = ""
    End Sub
End Class