Public Class ABM_TiposDocumentos

    Dim accesoBD As AccesoBD = AccesoBD.instancia

    Enum estado
        insertar
        modificar
    End Enum
    Dim condicion_estado As estado = estado.insertar

    'LOAD FORM
    Private Sub ABM_TiposDocumentos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.cmd_borrar.Enabled = False
        Me.cmd_borrar.Visible = False
        Me.cargar_grilla()
        Me.txt_nombre.Focus()

    End Sub


#Region "SUBRUTINAS"

    'CARGAR GRILLA
    Private Sub cargar_grilla()
        Me.grid_tipoDoc.Rows.Clear()

        Dim sentenciaSQL As String = "SELECT * FROM TiposDocumento "

        Dim tabla As DataTable = accesoBD.query(sentenciaSQL)

        Dim c As Integer = 0
        For c = 0 To tabla.Rows.Count() - 1
            Me.grid_tipoDoc.Rows.Add()
            Me.grid_tipoDoc.Rows(c).Cells("c_idDoc").Value = tabla.Rows(c)("idTipoDocumento")
            Me.grid_tipoDoc.Rows(c).Cells("c_nombre").Value = tabla.Rows(c)("nombre")
            Me.grid_tipoDoc.Rows(c).Cells("c_descripcion").Value = tabla.Rows(c)("descripcion")
        Next
    End Sub

    'INSERTAR TIPO DOCUMENTO
    Private Sub insertar()
        Dim sentenciaSQL As String = "INSERT INTO TiposDocumento (nombre, descripcion) " _
                          & "VALUES ('" & txt_nombre.Text & "', '" & txt_descripcion.Text & "')"

        accesoBD.nonQuery(sentenciaSQL)

        MessageBox.Show("Se guardó exitosamente")
        Me.cargar_grilla()
    End Sub


    'MODIFICAR TIPO DOCUMENTO
    Private Sub modificar()

        Dim sentenciaSQL As String = ""
        sentenciaSQL &= "UPDATE TiposDocumento "
        sentenciaSQL &= "SET descripcion = '" & Me.txt_descripcion.Text & "'"
        sentenciaSQL &= " WHERE nombre = '" & Me.txt_nombre.Text & "'"

        accesoBD.nonQuery(sentenciaSQL)

        MessageBox.Show("Se modifico correctamente")
        Me.cargar_grilla()
    End Sub

#End Region

#Region "FUNCIONES"

    'VALIDAR CAMPOS
    Private Function validar() As Boolean

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

    'VALIDAR EXISTENCIA DE ELEMENTO
    Private Function validarExistencia() As Boolean
        Dim sentenciaSQL As String = ""
        sentenciaSQL = "SELECT * FROM TiposDocumento " _
            & "WHERE nombre = '" & Me.txt_nombre.Text & "'"

        Dim tabla As DataTable = accesoBD.query(sentenciaSQL)

        If tabla.Rows.Count() = 0 Then
            Return False
        Else
            Return True
        End If
    End Function

#End Region

#Region "BOTONES"

    'CLICK EN GUARDAR
    Private Sub cmd_guardar_Click(sender As Object, e As EventArgs) Handles cmd_guardar.Click
        If Me.validar = True Then
            If condicion_estado = estado.insertar Then
                If Me.validarExistencia() = False Then
                    Me.insertar()
                Else
                    MessageBox.Show("Ya existe este Tipo de Documento")
                    Exit Sub
                End If
            Else
                Me.modificar()
            End If

            Me.cmd_limpiar.PerformClick()
        End If
    End Sub

    'CLICK EN LIMPIAR
    Private Sub cmd_limpiar_Click(sender As Object, e As EventArgs) Handles cmd_limpiar.Click
        Me.cmd_borrar.Enabled = False
        Me.cmd_borrar.Visible = False

        Me.condicion_estado = estado.insertar
        Me.txt_descripcion.Text = ""
        Me.txt_nombre.Text = ""
        Me.txt_nombre.Enabled = True
        Me.txt_nombre.Focus()

        Me.cargar_grilla()
        Me.cmd_guardar.Text = "Registrar"
    End Sub

    'DOBLECLICK EN GRILLA
    Private Sub grid_tipoDoc_CellDoubleClick1(sender As Object, e As DataGridViewCellEventArgs) Handles grid_tipoDoc.CellDoubleClick
        Dim sentenciaSQL As String = ""

        sentenciaSQL = "SELECT * FROM TiposDocumento " _
            & "WHERE idTipoDocumento = " & Me.grid_tipoDoc.CurrentRow.Cells(0).Value

        Dim tabla As DataTable = accesoBD.query(sentenciaSQL)

        If tabla.Rows.Count() = 0 Then
            MessageBox.Show("Este tipo de Documento fue eliminado.")
            Exit Sub
        End If

        Me.cmd_borrar.Enabled = True
        Me.cmd_borrar.Visible = True

        Me.txt_nombre.Text = tabla.Rows(0)("nombre")
        Me.txt_descripcion.Text = tabla.Rows(0)("descripcion")

        Me.txt_nombre.Enabled = False
        Me.condicion_estado = estado.modificar
        Me.cmd_guardar.Text = "Modificar"
        Me.grid_tipoDoc.Rows.Clear()

        Dim c As Integer = 0
        For c = 0 To tabla.Rows.Count() - 1
            Me.grid_tipoDoc.Rows.Add()
            Me.grid_tipoDoc.Rows(c).Cells("c_idDoc").Value = tabla.Rows(c)("idTipoDocumento")
            Me.grid_tipoDoc.Rows(c).Cells("c_nombre").Value = tabla.Rows(c)("nombre")
            Me.grid_tipoDoc.Rows(c).Cells("c_descripcion").Value = tabla.Rows(c)("descripcion")
        Next
    End Sub

    'CLICK EN CANCELAR
    Private Sub cmd_cancelar_Click(sender As Object, e As EventArgs) Handles cmd_cancelar.Click
        Me.Close()
    End Sub

#End Region





    Private Sub cmd_borrar_Click(sender As Object, e As EventArgs) Handles cmd_borrar.Click
        Try
            Dim sentenciaSQL As String = "DELETE FROM TiposDocumento WHERE idTipoDocumento = " & Me.grid_tipoDoc.Rows(0).Cells("c_idDoc").Value()

            accesoBD.nonQuery(sentenciaSQL)

            MessageBox.Show("Se ha eliminado el tipo de documento satisfactoriamente")

            Me.cargar_grilla()
            Me.cmd_limpiar.PerformClick()
        Catch ex As OleDb.OleDbException
            MessageBox.Show("El registro no puede eliminarse por tener otros registros relacionados.")
            accesoBD.cerrar()
        End Try
    End Sub
End Class
