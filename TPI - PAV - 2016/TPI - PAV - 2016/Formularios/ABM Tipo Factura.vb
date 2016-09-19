Public Class ABM_Tipo_Factura
    Dim acceso As AccesoBD = AccesoBD.instancia
    Enum estado
        insertar
        modificar
    End Enum
    Dim condicion_estado As estado = estado.insertar
#Region "Subrutinas"
    Private Sub cargarGrilla()
        Me.grid_tiposFactura.Rows.Clear()
        Dim sql As String = "SELECT * FROM TipoFactura"
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
        Dim sql As String = "INSERT INTO TipoFactura (nombre, descripcion) " _
                            & "VALUES ( '" & txt_nombre.Text & "', '" & txt_descripcion.Text & "')"
        acceso.nonQuery(sql)
        MessageBox.Show("Se cargo exitosamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        Me.cargarGrilla()

    End Sub
    Private Sub Modificar()
        Dim sql As String = "UPDATE CLIENTES SET nombre = '" & txt_nombre.Text & "', Descripcion = '" & txt_descripcion.Text & "'"
        acceso.nonQuery(sql)
        MessageBox.Show("Se modifico exitodamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
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
        Dim sql As String = "SELECT * FROM TipoFactura WHERE nombre='" & txt_nombre.Text & "'"
        Dim tabla As DataTable = acceso.query(sql)
        If tabla.Rows.Count() = 0 Then
            Return False
        Else
            Return True
        End If
    End Function
#End Region
#Region "Click"
    Private Sub ABM_Tipo_Factura_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub cmd_guardar_Click(sender As Object, e As EventArgs) Handles cmd_guardar.Click
        If Me.Validar() = False Then
            If condicion_estado = estado.insertar Then
                If Validar_existencia() = True Then
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
    End Sub
    Private Sub cmd_cancelar_Click(sender As Object, e As EventArgs) Handles cmd_cancelar.Click
        Me.Close()

    End Sub
    Private Sub cmd_borrar_Click(sender As Object, e As EventArgs) Handles cmd_borrar.Click
        Dim sql As String = "DELET * FROM TipoDocumento WHERE nombre= '" & txt_nombre.Text & "'"
        Dim tabla As DataTable = acceso.query(sql)
        MessageBox.Show("Se ha eliminado el tipo de Factura exitosamente")
        Me.cmd_limpiar.PerformClick()
    End Sub
    Private Sub grid_tipoFactura_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles grid_clientes.CellContentDoubleClick
        Dim sql As String = ""

        sql = "SELECT * FROM TipoFactura WHERE idTipoFactura = '" & Me.grid_tiposFactura.CurrentRow.Cells("c_idTipoFactura").Value & "'"

        Dim tabla As DataTable = acceso.query(sql)

        If tabla.Rows.Count() = 0 Then
            MessageBox.Show("La tipo de factura requerido no existe.")
            Exit Sub
        End If

        Me.cmd_borrar.Enabled = True
        'Me.cmd_borrar.Visible = True
        Me.cmd_guardar.Text = "Modificar"


        Me.txt_nombre.Text = tabla.Rows(0)("nombre")
        Me.txt_descripcion.Text = tabla.Rows(0)("descripcion")


        Me.condicion_estado = estado.modificar

    End Sub
#End Region

   


    
    
End Class