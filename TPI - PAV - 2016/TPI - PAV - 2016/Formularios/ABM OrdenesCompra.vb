Public Class ABM_OrdenesCompra
    Dim acceso As New AccesoBD
    Dim primerCambio As Boolean = True

    Private Sub cargarCombo()
        Dim tabla As New Data.DataTable
        Dim sql As String = ""

        sql = "SELECT idProveedor,nombre FROM Proveedores"

        tabla = acceso.query(sql)

        cmbProveedor.DataSource = tabla
        primerCambio = True
        cmbProveedor.ValueMember = "idProveedor"
        cmbProveedor.DisplayMember = "nombre"
    End Sub


    Private Sub cargarGrilla()
        Dim tabla As New Data.DataTable
        Dim sql As String = "SELECT a.IdArticulo, A.nombre, A.precioUnitario FROM Articulos A WHERE A.idProveedor=" & cmbProveedor.SelectedValue

        tabla = acceso.query(sql)

        For i = 0 To tabla.Rows.Count() - 1
            DataGridView1.Rows.Add(tabla.Rows(i)(0), tabla.Rows(i)(1), 0, tabla.Rows(i)(2), 0)
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
        primerCambio = True
        cmbProveedor.SelectedIndex = -1
        btnEmitir.Enabled = False
        DataGridView1.Rows.Clear()
    End Sub

    Private Sub DataGridView1_CellValidated(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellValidated
        If (e.RowIndex > -1) Then
            Dim row As DataGridViewRow = DataGridView1.Rows(e.RowIndex)
            If row.Cells(2).Value <> "0" Then
                Dim cant As Integer
                If Int32.TryParse(row.Cells(2).Value, cant) And cant >= 0 Then
                    row.Cells(4).Value = cant * row.Cells(3).Value
                Else
                    MessageBox.Show("El valor ingresado no es válido.", "Error")
                    DataGridView1.Rows(e.RowIndex).Cells(2).Value = 0
                    DataGridView1.Rows(e.RowIndex).Cells(4).Value = 0
                End If
            Else
                DataGridView1.Rows(e.RowIndex).Cells(4).Value = 0
            End If
            calcularTotal()
        End If
    End Sub

    Private Function calcularTotal() As Double
        Dim suma As Double = 0
        For i = 0 To DataGridView1.Rows.Count() - 1
            suma = suma + DataGridView1.Rows(i).Cells(4).Value
        Next
        txtTotal.Text = "$ " & suma
        Return suma
    End Function

    Private Function validar() As Boolean
        If calcularTotal() > 0 Then
            Return True
        Else
            MessageBox.Show("No se puede emitir una orden de compra vacía.")
            Return False
        End If
    End Function

    Private Sub emitir()
        If validar() Then
            Dim table As New DataTable
            table.Columns.Add("Producto", Type.GetType("System.Int32"))
            table.Columns.Add("Cantidad", Type.GetType("System.Int32"))
            table.Columns.Add("Subtotal", Type.GetType("System.Double"))
            Dim pr As Integer
            Dim ca As Integer
            Dim pu As Integer
            Dim st As Integer

            For i = 0 To DataGridView1.Rows.Count() - 1
                If DataGridView1.Rows(i).Cells(2).Value <> "0" Then
                    pr = DataGridView1.Rows(i).Cells(0).Value
                    ca = DataGridView1.Rows(i).Cells(2).Value
                    st = DataGridView1.Rows(i).Cells(4).Value
                    table.Rows.Add(pr, ca, st)
                End If
            Next

            Dim ge As New GestorOrden(table, cmbProveedor.SelectedValue, calcularTotal())
            ge.ordenar()
            Me.Close()
        End If
        
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub btnEmitir_Click(sender As Object, e As EventArgs) Handles btnEmitir.Click
        Me.emitir()
    End Sub
End Class