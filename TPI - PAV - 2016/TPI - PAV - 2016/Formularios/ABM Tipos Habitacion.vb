Public Class ABM_TiposHabitacion

    Dim accesoBD As AccesoBD = accesoBD.instancia

    Enum estado
        insertar
        modificar
    End Enum
    Dim condicion_estado As estado = estado.insertar

    'LOAD
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

        Dim sentenciaSQL As String = "SELECT * FROM TiposHabitacion "
        Dim tabla As DataTable = accesoBD.query(sentenciaSQL)

        Dim c As Integer = 0
        For c = 0 To tabla.Rows.Count() - 1
            Me.grid_tipoDoc.Rows.Add()
            Me.grid_tipoDoc.Rows(c).Cells("c_idHab").Value = tabla.Rows(c)("idTipoHabitacion")
            Me.grid_tipoDoc.Rows(c).Cells("c_nombre").Value = tabla.Rows(c)("nombre")
            Me.grid_tipoDoc.Rows(c).Cells("c_descripcion").Value = tabla.Rows(c)("descripcion")
        Next
    End Sub

    'INSERTAR TIPO HABITACION
    Private Sub insertar()
        Dim sentenciaSQL As String = "INSERT INTO TiposHabitacion (nombre, descripcion) " _
                          & "VALUES ('" & txt_nombre.Text & "', '" & txt_descripcion.Text & "')"

        accesoBD.nonQuery(sentenciaSQL)

        MessageBox.Show("Se guardó exitosamente")
        Me.cargar_grilla()
    End Sub


    'MODIFICAR TIPO HABITACION
    Private Sub modificar()
        Dim sentenciaSQL As String = ""
        sentenciaSQL &= "UPDATE TiposHabitacion "
        sentenciaSQL &= "SET descripcion = '" & Me.txt_descripcion.Text & "'"
        sentenciaSQL &= " WHERE nombre = '" & Me.txt_nombre.Text & "'"

        accesoBD.nonQuery(sentenciaSQL)

        MessageBox.Show("Se modificó correctamente.")
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

    'VALIDAR EXISTENCIA ELEMENTO
    Private Function validarExistencia() As Boolean
        Dim sentenciaSQL As String = ""
        sentenciaSQL = "SELECT * FROM TiposHabitacion " _
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

    'CLICK GUARDAR
    Private Sub cmd_guardar_Click(sender As Object, e As EventArgs) Handles cmd_guardar.Click
        If Me.validar = True Then
            If condicion_estado = estado.insertar Then
                If Me.validarExistencia() = False Then
                    Me.insertar()
                Else
                    MessageBox.Show("Ya existe este tipo de habitación.")
                    Exit Sub
                End If
            Else
                Me.modificar()
            End If

            Me.cmd_limpiar.PerformClick()
        End If
    End Sub

    'CLICK LIMPIAR
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

    'DOBLE CLICK GRILLA
    Private Sub grid_tipoDoc_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles grid_tipoDoc.CellContentDoubleClick
        Dim sentenciaSQL As String = ""

        sentenciaSQL = "SELECT * FROM TiposHabitacion " _
            & "WHERE idTipoHabitacion = " & Me.grid_tipoDoc.CurrentRow.Cells(0).Value

        Dim tabla As DataTable = accesoBD.query(sentenciaSQL)

        If tabla.Rows.Count() = 0 Then
            MessageBox.Show("Este tipo de habitación fue eliminado.")
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
            Me.grid_tipoDoc.Rows(c).Cells("c_idHab").Value = tabla.Rows(c)("idTipoHabitacion")
            Me.grid_tipoDoc.Rows(c).Cells("c_nombre").Value = tabla.Rows(c)("nombre")
            Me.grid_tipoDoc.Rows(c).Cells("c_descripcion").Value = tabla.Rows(c)("descripcion")
        Next
    End Sub

    'CLICK CANCELAR
    Private Sub cmd_cancelar_Click(sender As Object, e As EventArgs) Handles cmd_cancelar.Click
        Me.Close()
    End Sub


    'CLICK BORRAR
    Private Sub cmd_borrar_Click(sender As Object, e As EventArgs) Handles cmd_borrar.Click
        Try
            Dim sentenciaSQL As String = "DELETE FROM TiposHabitacion WHERE idTipoHabitacion = " & Me.grid_tipoDoc.Rows(0).Cells("c_idHab").Value()

            accesoBD.nonQuery(sentenciaSQL)

            MessageBox.Show("Se ha eliminado el tipo de habitación satisfactoriamente")

            Me.cargar_grilla()
            Me.cmd_limpiar.PerformClick()
        Catch ex As OleDb.OleDbException
            MessageBox.Show("El registro no puede eliminarse por tener otros registros relacionados.")
        End Try

    End Sub

#End Region

End Class
