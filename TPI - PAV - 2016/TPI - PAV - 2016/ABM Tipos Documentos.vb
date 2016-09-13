Public Class ABM_TiposDocumentos

    Dim cadena_conexion As String = "Provider=SQLNCLI11;Data Source=LAWEBSTORE-PC\SQLSERVER2014;Integrated Security=SSPI;Initial Catalog=hotelShaky"
    Enum analizar_existencia
        existe
        no_existe
    End Enum
    Enum estado
        insertar
        modificar
    End Enum
    Dim condicion_estado As estado = estado.insertar

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles cmd_guardar.Click
        If Me.validar = True Then
            If condicion_estado = estado.insertar Then
                If Me.validar_existencia() = analizar_existencia.no_existe Then
                    Me.insertar()
                Else
                    MessageBox.Show("Ya existe este Tipo de Documento")
                    Exit Sub
                End If
            Else
                Me.modificar()
            End If
        End If
    End Sub
    Private Sub modificar()

        Dim conexion As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim sql As String = ""

        sql &= "UPDATE TiposDocumento "
        sql &= "SET nombre = '" & Me.txt_nombre.Text & "'"
        sql &= ", descripcion = '" & Me.txt_descripcion.Text & "'"
        sql &= " WHERE idTipoDocumento = " & Me.txt_idDoc.Text

        conexion.ConnectionString = cadena_conexion
        conexion.Open()
        cmd.Connection = conexion
        cmd.CommandType = CommandType.Text
        cmd.CommandText = sql

        cmd.ExecuteNonQuery()

        conexion.Close()
        MessageBox.Show("Se modifico correctamente")
        Me.cargar_grilla()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles cmd_cancelar.Click
        Me.Close()

    End Sub

    Private Sub cargar_grilla()
        Dim conexion As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim tabla As New DataTable
        Dim sql As String = "SELECT * FROM TiposDocumento "

        conexion.ConnectionString = cadena_conexion
        conexion.Open()
        cmd.Connection = conexion
        cmd.CommandType = CommandType.Text
        cmd.CommandText = sql

        tabla.Load(cmd.ExecuteReader)
        conexion.Close()

        Me.grid_tipoDoc.Rows.Clear()


        Dim c As Integer = 0
        For c = 0 To tabla.Rows.Count() - 1
            Me.grid_tipoDoc.Rows.Add()
            Me.grid_tipoDoc.Rows(c).Cells("c_idDoc").Value = tabla.Rows(c)("idTipoDocumento")
            Me.grid_tipoDoc.Rows(c).Cells("c_nombre").Value = tabla.Rows(c)("nombre")
            Me.grid_tipoDoc.Rows(c).Cells("c_descripcion").Value = tabla.Rows(c)("descripcion")
        Next
    End Sub

    Private Function validar_existencia() As analizar_existencia

        Dim conexion As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim tabla As New DataTable
        Dim sql As String = ""
        sql = "SELECT * FROM TIPOSDOCUMENTO " _
            & "WHERE idTipoDocumento = " & Me.txt_idDoc.Text


        conexion.ConnectionString = cadena_conexion
        conexion.Open()
        cmd.Connection = conexion
        cmd.CommandType = CommandType.Text
        cmd.CommandText = sql

        tabla.Load(cmd.ExecuteReader())
        conexion.Close()

        If tabla.Rows.Count() = 0 Then
            Return analizar_existencia.no_existe
        Else
            Return analizar_existencia.existe
        End If
    End Function

    Private Sub insertar()
        Dim conexion As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand

        Dim sql As String = ""
        sql = "SET IDENTITY_INSERT TiposDocumento ON INSERT INTO TiposDocumento (idTipoDocumento, nombre, descripcion) " _
            & "VALUES (" & txt_idDoc.Text & ", '" & txt_nombre.Text & "', '" & txt_descripcion.Text & "')"


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

    Private Function validar() As Boolean
        If txt_idDoc.Text = "" Then
            MessageBox.Show("Debe completar el campo Id Tipo de Documento", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            txt_idDoc.Focus()
            Return False
        End If
        If txt_nombre.Text = "" Then
            MessageBox.Show("Debe completar el campo Nombre", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            txt_nombre.Focus()
            Return False
        End If
        If txt_descripcion.Text = "" Then
            MessageBox.Show("Debe completar el campo Descripcion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            txt_descripcion.Focus()
            Return False
        End If
        Return True
    End Function
    Private Sub ABM_TiposDocumentos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.cargar_grilla()
        Me.txt_idDoc.Focus()

    End Sub

    Private Sub cmd_limpiar_Click(sender As Object, e As EventArgs) Handles cmd_limpiar.Click
        Me.condicion_estado = estado.insertar
        Me.txt_idDoc.Text = ""
        Me.txt_nombre.Text = ""
        Me.txt_descripcion.Text = ""

        Me.txt_idDoc.Enabled = True
        Me.txt_idDoc.Focus()
    End Sub



    Private Sub grid_tipoDoc_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles grid_tipoDoc.CellContentDoubleClick
        Dim conexion As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim tabla As New DataTable
        Dim sql As String = ""

        sql = "SELECT * FROM TiposDdocumento " _
            & "WHERE idTipoDocumento = " & Me.grid_tipoDoc.CurrentRow.Cells(0).Value & "'"

        conexion.ConnectionString = cadena_conexion
        conexion.Open()
        cmd.Connection = conexion
        cmd.CommandType = CommandType.Text
        cmd.CommandText = sql
        tabla.Load(cmd.ExecuteReader())
        conexion.Close()
        If tabla.Rows.Count() = 0 Then
            MessageBox.Show("Se eliminó el tipo")
            Exit Sub
        End If

        Me.txt_idDoc.Text = tabla.Rows(0)("idTipoDocumento")
        Me.txt_nombre.Text = tabla.Rows(0)("nombre")
        Me.txt_descripcion.Text = tabla.Rows(0)("descripcion")

        Me.txt_idDoc.Enabled = False
        Me.condicion_estado = estado.modificar
    End Sub
End Class
