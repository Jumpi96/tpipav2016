Public Class FormListadoOrdenesCompra

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet.OrdenesCompra' table. You can move, or remove it, as needed.
        Me.OrdenesCompraTableAdapter.Fill(Me.DataSet.OrdenesCompra)

        Me.ReportViewer1.RefreshReport()
    End Sub

End Class