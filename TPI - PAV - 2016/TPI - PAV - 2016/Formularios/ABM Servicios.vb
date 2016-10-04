Public Class ABM_Servicios

    Dim accesoBD As AccesoBD = AccesoBD.instancia
    Enum estado
        insertar
        modificar
    End Enum
    Dim condicion_estado As estado = estado.insertar

    Private Sub ABM_Servicios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.cmd_borrar.Enabled = False
        Me.cmd_borrar.Visible = False
        Me.cargar_grilla()
    End Sub

#Region "SUBCONSULTAS"

    'CARGAR GRILLA
    Private Sub cargar_grilla()

        Me.grid_grilla.Rows.Clear()

        Dim sentenciaSQL As String = "SELECT * FROM Servicios"
        Dim tabla As DataTable = accesoBD.query(sentenciaSQL)

        Dim c As Integer = 0
        For c = 0 To tabla.Rows.Count() - 1
            Me.grid_grilla.Rows.Add()
            Me.grid_grilla.Rows(c).Cells("idServicio").Value = tabla.Rows(c)("idServicio")
            Me.grid_grilla.Rows(c).Cells("nombre").Value = tabla.Rows(c)("nombre")
            Me.grid_grilla.Rows(c).Cells("descripcion").Value = tabla.Rows(c)("descripcion")
            Me.grid_grilla.Rows(c).Cells("precioUnitario").Value = tabla.Rows(c)("precioUnitario")
        Next
    End Sub

    'INSERTAR
    Private Sub insertar()

        Dim sentenciaSQL As String = ""
        sentenciaSQL &= "INSERT INTO Servicios (nombre , descripcion , precioUnitario) VALUES (' " & Me.txt_nombre.Text
        sentenciaSQL &= "',' " & Me.txt_descripcion.Text & " '," & Me.txt_precioUnitario.Text & ")"

        accesoBD.nonQuery(sentenciaSQL)

        MessageBox.Show("Se guardó exitosamente")
        Me.cargar_grilla()
    End Sub

    'MODIFICAR
    Private Sub modificar()
        Dim sentenciaSQL As String = ""
        sentenciaSQL &= "UPDATE Servicios SET descripcion= '" & Me.txt_descripcion.Text & "',"
        sentenciaSQL &= "precioUnitario= " & Me.txt_precioUnitario.Text & " WHERE nombre= '" & Me.txt_nombre.Text & "'"

        accesoBD.nonQuery(sentenciaSQL)
        MessageBox.Show("Se modificó exitosamente")
        Me.cargar_grilla()
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
        If Me.txt_precioUnitario.Text = "" Then
            MessageBox.Show("Debe completar el campo Precio Unitario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Me.txt_precioUnitario.Focus()
            Return False
        Else
            If Me.txt_precioUnitario.Text < 0 Then
                MessageBox.Show("El Precio Unitario no puede ser negativo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                Me.txt_precioUnitario.Focus()
                Return False
            End If
        End If
        Return True
    End Function

    'VALIDAR EXISTENCIA ELEMENTO
    Private Function validar_existencia() As Boolean
        Dim sentenciaSQL As String = "SELECT * FROM Servicios WHERE nombre= ' " & Me.txt_nombre.Text & " '"
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
        If validar() = True Then
            If condicion_estado = estado.insertar Then
                If validar_existencia() = False Then
                    insertar()
                Else
                    MessageBox.Show("Ya existe este Servicio")
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
    Private Sub grid_grilla_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles grid_grilla.CellDoubleClick

        Dim sentenciaSQL As String = ""
        sentenciaSQL &= "SELECT * FROM Servicios WHERE idServicio = " & Me.grid_grilla.CurrentRow.Cells(0).Value
        Dim tabla As DataTable = accesoBD.query(sentenciaSQL)

        If tabla.Rows.Count = 0 Then
            MessageBox.Show("Este servicio fue eliminado")
            Exit Sub
        End If

        Me.cmd_borrar.Enabled = True
        Me.cmd_borrar.Visible = True

        Me.txt_nombre.Text = tabla.Rows(0)("nombre")
        Me.txt_descripcion.Text = tabla.Rows(0)("descripcion")
        Me.txt_precioUnitario.Text = tabla.Rows(0)("precioUnitario")

        Me.txt_nombre.Enabled = False
        Me.condicion_estado = estado.modificar
        Me.cmd_registrar.Text = "Modificar"
        Me.grid_grilla.Rows.Clear()

        Dim c As Integer = 0
        For c = 0 To tabla.Rows.Count - 1
            Me.grid_grilla.Rows.Add()
            Me.grid_grilla.Rows(c).Cells("idServicio").Value = tabla.Rows(c)("idServicio")
            Me.grid_grilla.Rows(c).Cells("nombre").Value = tabla.Rows(c)("nombre")
            Me.grid_grilla.Rows(c).Cells("descripcion").Value = tabla.Rows(c)("descripcion")
            Me.grid_grilla.Rows(c).Cells("precioUnitario").Value = tabla.Rows(c)("precioUnitario")
        Next

    End Sub

    'CLICK LIMPIAR
    Private Sub cmd_limpiar_Click(sender As Object, e As EventArgs) Handles cmd_limpiar.Click
        Me.cmd_borrar.Enabled = False
        Me.cmd_borrar.Visible = False

        Me.condicion_estado = estado.insertar
        Me.txt_nombre.Text = ""
        Me.txt_nombre.Enabled = True
        Me.txt_nombre.Focus()
        Me.txt_descripcion.Text = ""
        Me.txt_precioUnitario.Text = ""

        Me.cargar_grilla()
        Me.cmd_registrar.Text = "Registrar"

    End Sub

    'CLICK BORRAR

    Private Sub cmd_borrar_Click(sender As Object, e As EventArgs) Handles cmd_borrar.Click
        Try
            Dim sentenciaSQL As String = "DELETE FROM Servicios WHERE idServicio= " & Me.grid_grilla.Rows(0).Cells("idServicio").Value

            accesoBD.nonQuery(sentenciaSQL)

            MessageBox.Show("Se ha eliminado el servicio satisfactoriamente")
            Me.cargar_grilla()
            Me.cmd_limpiar.PerformClick()
        Catch ex As OleDb.OleDbException
            MessageBox.Show("No se puede eliminar por tener registros relacionados.", "Error")
            accesoBD.cerrar()
        End Try
        
    End Sub
#End Region



    Private Sub txt_precioUnitario_MouseClick(sender As Object, e As MouseEventArgs) Handles txt_precioUnitario.MouseClick
        If txt_precioUnitario.Text = "" Then
            txt_precioUnitario.SelectionStart = 0
        End If
    End Sub


End Class