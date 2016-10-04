Public Class ABM_Articulos
    Dim accesoBD As AccesoBD = accesoBD.instancia
    Enum estado
        insertar
        modificar
    End Enum
    Dim condicion_estado As estado = estado.insertar

    Private Sub ABM_Articulos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.cmd_borrar.Enabled = False
        Me.cmd_borrar.Visible = False
        Me.cargar_combo()
        Me.cargar_grilla()
    End Sub

#Region "SUBRUTINAS"

    'CARGAR COMBO
    Private Sub cargar_combo()
        Dim sentenciaSQL As String = "SELECT * FROM Proveedores"
        Dim tabla As DataTable = accesoBD.query(sentenciaSQL)

        cmb_proveedor.DataSource = tabla
        cmb_proveedor.DisplayMember = "nombre"
        cmb_proveedor.ValueMember = "idProveedor"

    End Sub

    'CARGAR GRILLA
    Private Sub cargar_grilla()

        Me.grid_grilla.Rows.Clear()

        Dim sentenciaSQL As String = "SELECT A.*, P.nombre as nombreProveedor FROM Articulos A JOIN Proveedores P ON A.idProveedor=P.idProveedor"
        Dim tabla As DataTable = accesoBD.query(sentenciaSQL)

        Dim c As Integer = 0
        For c = 0 To tabla.Rows.Count() - 1
            Me.grid_grilla.Rows.Add()
            Me.grid_grilla.Rows(c).Cells("idArticulo").Value = tabla.Rows(c)("idArticulo")
            Me.grid_grilla.Rows(c).Cells("nombre").Value = tabla.Rows(c)("nombre")
            Me.grid_grilla.Rows(c).Cells("descripcion").Value = tabla.Rows(c)("descripcion")
            Me.grid_grilla.Rows(c).Cells("precioUnitario").Value = tabla.Rows(c)("precioUnitario")
            Me.grid_grilla.Rows(c).Cells("stock").Value = tabla.Rows(c)("stock")
            Me.grid_grilla.Rows(c).Cells("idProveedor").Value = tabla.Rows(c)("nombreProveedor")
        Next
    End Sub


    'INSERTAR
    Private Sub insertar()

        Dim sentenciaSQL As String = ""
        sentenciaSQL &= "INSERT INTO Articulos (nombre,descripcion,precioUnitario,stock,idProveedor) VALUES (' " & Me.txt_nombre.Text & "','" & Me.txt_descripcion.Text & "'," & Me.txt_precioUnitario.Text & "," & Me.txt_stock.Text & "," & Me.cmb_proveedor.SelectedValue & " )"

        accesoBD.nonQuery(sentenciaSQL)

        MessageBox.Show("Se guardó exitosamente")
        Me.cargar_grilla()
    End Sub

    'MODIFICAR
    Private Sub modificar()
        Dim sentenciaSQL As String = ""
        sentenciaSQL &= "UPDATE Articulos SET descripcion= '" & Me.txt_descripcion.Text & "',"
        sentenciaSQL &= "precioUnitario= " & Me.txt_precioUnitario.Text & ", stock= " & Me.txt_stock.Text & ", idProveedor= " & Me.cmb_proveedor.SelectedValue
        sentenciaSQL &= "WHERE nombre= '" & Me.txt_nombre.Text & "'"

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
        If Me.txt_stock.Text = "" Then
            MessageBox.Show("Debe completar el campo Stock", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Me.txt_stock.Focus()
            Return False
        Else
            If Me.txt_stock.Text < 0 Then
                MessageBox.Show("El Stock no puede ser negativo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                Me.txt_stock.Focus()
                Return False
            End If
        End If
        If Me.cmb_proveedor.SelectedIndex = -1 Then
            MessageBox.Show("El Proveedor esta sin seleccion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Me.cmb_proveedor.Focus()
            Return False
        End If
        Return True
    End Function

    'VALIDAR EXISTENCIA ELEMENTO
    Private Function validar_existencia() As Boolean
        Dim sentenciaSQL As String = "SELECT * FROM Articulos WHERE nombre= ' " & Me.txt_nombre.Text & " '"
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
                    Me.insertar()
                Else
                    MessageBox.Show("Ya existe este Articulo")
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
        Me.txt_stock.Text = ""
        Me.cmb_proveedor.SelectedValue = 1

        Me.cargar_grilla()
        Me.cmd_registrar.Text = "Registrar"
    End Sub

    'DOBLE CLICK GRILLA
    Private Sub grid_grilla_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles grid_grilla.CellDoubleClick
        Dim sentenciaSQL As String = ""
        sentenciaSQL &= "SELECT A.*, P.nombre as nombreProveedor FROM Articulos A JOIN Proveedores P ON A.idProveedor=P.idProveedor WHERE idArticulo = " & Me.grid_grilla.CurrentRow.Cells(0).Value
        Dim tabla As DataTable = accesoBD.query(sentenciaSQL)

        If tabla.Rows.Count = 0 Then
            MessageBox.Show("Este Articulo fue eliminado")
            Exit Sub
        End If

        Me.cmd_borrar.Enabled = True
        Me.cmd_borrar.Visible = True

        Me.txt_nombre.Text = tabla.Rows(0)("nombre")
        Me.txt_descripcion.Text = tabla.Rows(0)("descripcion")
        Me.txt_precioUnitario.Text = tabla.Rows(0)("precioUnitario")
        Me.txt_stock.Text = tabla.Rows(0)("stock")
        Me.cmb_proveedor.SelectedValue = tabla.Rows(0)("idProveedor")

        Me.txt_nombre.Enabled = False
        Me.condicion_estado = estado.modificar
        Me.cmd_registrar.Text = "Modificar"
        Me.grid_grilla.Rows.Clear()

        Dim c As Integer = 0
        For c = 0 To tabla.Rows.Count - 1
            Me.grid_grilla.Rows.Add()
            Me.grid_grilla.Rows(c).Cells("idArticulo").Value = tabla.Rows(c)("idArticulo")
            Me.grid_grilla.Rows(c).Cells("nombre").Value = tabla.Rows(c)("nombre")
            Me.grid_grilla.Rows(c).Cells("descripcion").Value = tabla.Rows(c)("descripcion")
            Me.grid_grilla.Rows(c).Cells("precioUnitario").Value = tabla.Rows(c)("precioUnitario")
            Me.grid_grilla.Rows(c).Cells("stock").Value = tabla.Rows(c)("stock")
            Me.grid_grilla.Rows(c).Cells("idProveedor").Value = tabla.Rows(c)("nombreProveedor")
        Next
    End Sub

    'CLICK BORRAR
    Private Sub cmd_borrar_Click(sender As Object, e As EventArgs) Handles cmd_borrar.Click
        Try

            Dim sentenciaSQL As String = "DELETE FROM Articulos WHERE idArticulo= " & Me.grid_grilla.Rows(0).Cells("idArticulo").Value

            accesoBD.nonQuery(sentenciaSQL)

            MessageBox.Show("Se ha eliminado el Articulo satisfactoriamente")
            Me.cargar_grilla()
            Me.cmd_limpiar.PerformClick()


        Catch ex As OleDb.OleDbException

            MessageBox.Show("El registro no puede eliminarse por tener otros registros relacionados.")
            accesoBD.cerrar()
        End Try
    End Sub

    'CLICK PRECIO UNITARIO
    Private Sub txt_precioUnitario_MouseClick(sender As Object, e As MouseEventArgs) Handles txt_precioUnitario.MouseClick
        If Me.txt_precioUnitario.Text = "" Then
            Me.txt_precioUnitario.SelectionStart = 0
        End If
    End Sub
#End Region
End Class