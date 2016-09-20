Public Class ABM_Tipos_Cama

    Dim accesoBD As AccesoBD = accesoBD.instancia

    Enum estado
        insertar
        modificar
    End Enum
    Dim condicion_estado As estado = estado.insertar

    Private Sub ABM_Tipos_Cama_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.cmd_borrar.Enabled = False
        Me.cmd_borrar.Visible = False
        Me.cargarGrilla()

    End Sub

#Region "SUBRUTINAS"

    'CARGAR GRILLA
    Private Sub cargarGrilla()

        Me.grid_grilla.Rows.Clear()

        Dim sentenciaSQL As String = "SELECT * FROM TiposCama "
        Dim tabla As DataTable = accesoBD.query(sentenciaSQL)

        Dim c As Integer = 0
        For c = 0 To tabla.Rows.Count() - 1
            Me.grid_grilla.Rows.Add()
            Me.grid_grilla.Rows(c).Cells("idTipoCama").Value = tabla.Rows(c)("idTipoCama")
            Me.grid_grilla.Rows(c).Cells("nombre").Value = tabla.Rows(c)("nombre")
            Me.grid_grilla.Rows(c).Cells("descripcion").Value = tabla.Rows(c)("descripcion")
        Next

    End Sub

    'INSERTAR TIPO CAMA
    Private Sub insertar()
        Dim sentenciaSQL As String = "INSERT INTO TiposCama (nombre, descripcion) VALUES (' " & Me.txt_nombre.Text & "', '" & Me.txt_descripcion.Text & "')"

        accesoBD.nonQuery(sentenciaSQL)
        MessageBox.Show("Se guardó exitosamente")
        Me.cargarGrilla()
    End Sub

    Private Sub modificar()
        Dim sentenciaSQL As String = ""
        sentenciaSQL = "UPDATE TiposCama SET descripcion=' " & Me.txt_descripcion.Text & " '"
        sentenciaSQL &= "WHERE nombre= '" & Me.txt_nombre.Text & "'"

        accesoBD.nonQuery(sentenciaSQL)

        MessageBox.Show("Se modificó correctamente")
        Me.cargarGrilla()
    End Sub

#End Region

#Region "FUNCIONES"

    'VALIDAR CAMPOS
    Private Function validar() As Boolean
        If Me.txt_nombre.Text = "" Then
            MessageBox.Show("Debe completar el campo Nombre", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Me.txt_nombre.Focus()
            Return False
        End If

        If Me.txt_descripcion.Text = "" Then
            MessageBox.Show("Debe completar el campo Descripcion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Me.txt_descripcion.Focus()
            Return False
        End If
        Return True
    End Function

    'VALIDAR EXISTENCIA ELEMENTO
    Private Function validar_existencia() As Boolean
        Dim sentenciaSQL As String = "SELECT * FROM TiposCama WHERE nombre=' " & Me.txt_nombre.Text & "' "
        Dim tabla As DataTable = accesoBD.query(sentenciaSQL)

        If tabla.Rows.Count() = 0 Then
            Return False
        Else
            Return True
        End If
    End Function


#End Region

#Region "BOTONES"

    'CLICK REGISTRAR
    Private Sub cmd_registrar_Click(sender As Object, e As EventArgs) Handles cmd_registrar.Click
        If Me.validar Then
            If condicion_estado = estado.insertar Then
                If Me.validar_existencia = False Then
                    Me.insertar()
                Else
                    MessageBox.Show("Ya existe este tipo de cama")
                    Exit Sub
                End If
            Else
                Me.modificar()
            End If
            Me.cmd_limpiar.PerformClick()
        End If
    End Sub

    'CLICK CANCELAR
    Private Sub cmd_cancelar_Click(sender As Object, e As EventArgs) Handles cmd_cancelar.Click
        Me.Close()
    End Sub

    'DOBLE CLICK GRILLA

    Private Sub grid_grilla_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles grid_grilla.CellContentClick
        Dim sentenciaSQL As String = "SELECT * FROM TiposCama WHERE idTipoCama= " & Me.grid_grilla.CurrentRow.Cells(0).Value
        Dim tabla As DataTable = accesoBD.query(sentenciaSQL)

        If tabla.Rows.Count() = 0 Then
            MessageBox.Show("Este tipo de cama fue eliminado")
            Exit Sub
        End If

        Me.cmd_borrar.Enabled = True
        Me.cmd_borrar.Visible = True

        Me.txt_nombre.Text = tabla.Rows(0)("nombre")
        Me.txt_descripcion.Text = tabla.Rows(0)("descripcion")

        Me.txt_nombre.Enabled = False
        Me.condicion_estado = estado.modificar
        Me.cmd_registrar.Text = "Modificar"
        Me.grid_grilla.Rows.Clear()

        Dim c As Integer = 0
        For c = 0 To tabla.Rows.Count() - 1
            Me.grid_grilla.Rows.Add()
            Me.grid_grilla.Rows(c).Cells("idTipoCama").Value = tabla.Rows(c)("idTipoCama")
            Me.grid_grilla.Rows(c).Cells("nombre").Value = tabla.Rows(c)("nombre")
            Me.grid_grilla.Rows(c).Cells("descripcion").Value = tabla.Rows(c)("descripcion")
        Next
    End Sub
    'CLICK LIMPIAR
    Private Sub cmd_limpiar_Click(sender As Object, e As EventArgs) Handles cmd_limpiar.Click
        Me.cmd_borrar.Enabled = False
        Me.cmd_borrar.Visible = False

        Me.condicion_estado = estado.insertar

        Me.txt_nombre.Text = ""
        Me.txt_descripcion.Text = ""
        Me.txt_nombre.Enabled = True
        Me.txt_nombre.Focus()
        Me.cargarGrilla()

        Me.cmd_registrar.Text = "Registrar"
    End Sub

    'CLICK BORRAR
    Private Sub cmd_borrar_Click(sender As Object, e As EventArgs) Handles cmd_borrar.Click
        Try
            Dim sentenciaSQL As String = "DELETE FROM TiposCama WHERE idTipoCama= " & Me.grid_grilla.Rows(0).Cells("idTipoCama").Value
            accesoBD.nonQuery(sentenciaSQL)

            MessageBox.Show("Se ha eliminado el tipo de cama satisfactoriamente")

            Me.cargarGrilla()
            Me.cmd_limpiar.PerformClick()
        Catch ex As Exception
            MessageBox.Show("No se puede eliminar por tener registros relacionados.")
            accesoBD.cerrar()
        End Try
        
    End Sub
#End Region

    
End Class