Public Class ABM_Tipo_Factura
    Dim acceso As AccesoBD = AccesoBD.instancia
    Enum estado
        insertar
        modificar
    End Enum
    Dim condicion_estado As estado = estado.insertar

    Private Sub ABM_Tipo_Factura_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarGrilla()
        cmd_borrar.Enabled = False
    End Sub

#Region "Subrutinas"
    Private Sub cargarGrilla()
        Me.grid_tiposFactura.Rows.Clear()
        Dim sql As String = "SELECT * FROM TiposFactura"
        Dim tabla As DataTable = acceso.query(sql)

        Dim i As Integer
        For i = 0 To tabla.Rows.Count() - 1

            Me.grid_tiposFactura.Rows.Add() 'current row es la fila actual y cell es la celda de esa fila
            Me.grid_tiposFactura.Rows(i).Cells("c_nombre").Value = tabla.Rows(i)("nombre")
            Me.grid_tiposFactura.Rows(i).Cells("c_descripcion").Value = tabla.Rows(i)("descripcion")
            Me.grid_tiposFactura.Rows(i).Cells("c_idTipoFactura").Value = tabla.Rows(i)("idTipoFactura")
        Next

    End Sub
    Private Sub Insertar()
        Dim sql As String = "INSERT INTO TiposFactura (nombre, descripcion) " _
                            & "VALUES ( '" & txt_nombre.Text & "', '" & txt_descripcion.Text & "')"
        acceso.nonQuery(sql)
        MessageBox.Show("Se cargó exitosamente.")
        Me.cargarGrilla()

    End Sub
    Private Sub Modificar()

        Dim sentenciaSQL As String = ""
        sentenciaSQL &= "UPDATE TiposFactura "
        sentenciaSQL &= "SET descripcion = '" & Me.txt_descripcion.Text & "'"
        sentenciaSQL &= " WHERE nombre = '" & Me.txt_nombre.Text & "'"

        acceso.nonQuery(sentenciaSQL)
        MessageBox.Show("Se modificó exitodamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
    End Sub
#End Region


#Region "Funciones"
    Private Function Validar() As Boolean
        If txt_nombre.Text = "" Then
            MessageBox.Show("Debe Completar el campo Nombre", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            txt_nombre.Focus()
            Return False
        End If
        If txt_descripcion.Text = "" Then
            MessageBox.Show("Debe Completar el campo Descripcion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            txt_descripcion.Focus()
            Return False
        End If
        Return True
    End Function
    Private Function Validar_existencia() As Boolean
        Dim sql As String = "SELECT * FROM TiposFactura WHERE nombre='" & txt_nombre.Text & "'"
        Dim tabla As DataTable = acceso.query(sql)
        If tabla.Rows.Count() = 0 Then
            Return False
        Else
            Return True
        End If
    End Function
#End Region


#Region "Click"


    Private Sub cmd_guardar_Click(sender As Object, e As EventArgs) Handles cmd_guardar.Click
        If Me.Validar() Then
            If condicion_estado = estado.insertar Then
                If Validar_existencia() = False Then
                    Me.Insertar()
                Else
                    MessageBox.Show("Ya existe este tipo de factura")
                End If
            Else
                Me.Modificar()
            End If
            Me.cmd_limpiar.PerformClick()
        End If
    End Sub

    Private Sub cmd_limpiar_Click(sender As Object, e As EventArgs) Handles cmd_limpiar.Click
        txt_descripcion.Text = ""
        txt_nombre.Text = ""
        cmd_borrar.Enabled = False
        condicion_estado = estado.insertar
        cmd_guardar.Text = "Registrar"
        txt_nombre.Enabled = True

    End Sub
    Private Sub cmd_cancelar_Click(sender As Object, e As EventArgs) Handles cmd_cancelar.Click
        Me.Close()

    End Sub
    Private Sub cmd_borrar_Click(sender As Object, e As EventArgs) Handles cmd_borrar.Click
        Try
            Dim id As Integer = grid_tiposFactura.Rows(grid_tiposFactura.CurrentRow.Index).Cells(0).Value
            Dim sql As String = "DELETE FROM TiposFactura WHERE idTipoFactura= " & id
            acceso.nonQuery(sql)
            MessageBox.Show("Se ha eliminado el tipo de Factura exitosamente")
            Me.cmd_limpiar.PerformClick()
            cargarGrilla()
        Catch ex As OleDb.OleDbException
            MessageBox.Show("No se puede eliminar por tener registros relacionados.", "Error")
        End Try

    End Sub
    Private Sub grid_tipoFactura_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles grid_tiposFactura.CellContentDoubleClick

        Dim sql As String = ""

        sql = "SELECT * FROM TiposFactura WHERE idTipoFactura = '" & Me.grid_tiposFactura.CurrentRow.Cells("c_idTipoFactura").Value & "'"

        Dim tabla As DataTable = acceso.query(sql)

        If tabla.Rows.Count() = 0 Then
            MessageBox.Show("El tipo de factura requerido no existe.")
            Exit Sub
        End If

        Me.cmd_borrar.Enabled = True
        Me.cmd_borrar.Visible = True
        Me.cmd_guardar.Text = "Modificar"
        txt_nombre.Enabled = False

        Me.txt_nombre.Text = tabla.Rows(0)("nombre")
        Me.txt_descripcion.Text = tabla.Rows(0)("descripcion")


        Me.condicion_estado = estado.modificar
    End Sub
#End Region

   


    
    
End Class