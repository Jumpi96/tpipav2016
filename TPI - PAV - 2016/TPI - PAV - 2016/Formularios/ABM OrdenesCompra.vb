Public Class ABM_OrdenesCompra
    Dim acceso As New AccesoBD
    Dim primerCambio As Boolean = True

    Private Sub cargarCombo()
        Dim tabla As New Data.DataTable
        Dim sql As String = ""

        sql = "SELECT idProveedor,nombre FROM Proveedores"

        tabla = acceso.query(sql)

        cmbProveedor.DataSource = tabla
        cmbProveedor.ValueMember = "idProveedor"
        cmbProveedor.DisplayMember = "nombre"
    End Sub


    Private Sub cargarGrilla()
        Dim tabla As New Data.DataTable
        Dim sql As String = "SELECT A.nombre, A.precioUnitario FROM Articulos A WHERE idProveedor=" + cmbProveedor.SelectedValue

        tabla = acceso.query(sql)

        For i = 0 To tabla.Rows.Count()
            DataGridView1.Rows.Add(tabla.Rows(i)(0), 0, tabla.Rows(i)(1))
        Next
    End Sub

    Private Sub cmbProveedor_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmbProveedor.SelectedValueChanged
        If primerCambio = False Then
            txtTotal.Text = 0
            cmbProveedor.Enabled = False
            btnEmitir.Enabled = True
            cargarGrilla()
        Else
            primerCambio = False
        End If
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        txtTotal.Text = ""
        cmbProveedor.Enabled = True
        cmbProveedor.Focus()
        btnEmitir.Enabled = False
        DataGridView1.Rows.Clear()
    End Sub

    Private Sub DataGridView1_CellValidated(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellValidated
        If (e.RowIndex > -1) Then
            Dim row As DataGridViewRow = DataGridView1.Rows(e.RowIndex)
            If row.Cells(1).GetType() = GetType(Integer) And row.Cells(1).Value >= 0 Then
                row.Cells(3).Value = row.Cells(1).Value * row.Cells(2).Value
                calcularTotal()
            Else
                MessageBox.Show("El valor ingresado no es válido.", "Error")
                DataGridView1.Rows(e.RowIndex).Cells(1).Value = ""
            End If
        End If
    End Sub

    Private Sub calcularTotal()
        Dim suma As Double = 0
        For i = 0 To DataGridView1.Rows.Count()
            suma = suma + DataGridView1.Rows(i).Cells(3).Value
        Next
        txtTotal.Text = suma
    End Sub

    Private Function validar() As Boolean
        If txtTotal.Text > 0 Then
            Return True
        Else
            MessageBox.Show("No se puede emitir una orden de compra vacía.")
            Return False
        End If
    End Function

    Private Sub emitir()
        If validar() Then
            Dim table As DataTable = DirectCast(DataGridView1.DataSource, DataTable)
            Dim ge As New GestorOrden(table, cmbProveedor.SelectedValue)
            ge.ordenar()
            Me.Close()
        End If
        
    End Sub
End Class