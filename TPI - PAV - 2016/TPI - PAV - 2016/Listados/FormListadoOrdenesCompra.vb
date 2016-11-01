Public Class FormListadoOrdenesCompra

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet.OrdenesCompra1' table. You can move, or remove it, as needed.
        Me.OrdenesCompra1TableAdapter.Fill(Me.DataSet.OrdenesCompra1)


        Me.ReportViewer1.RefreshReport()
        Me.ReportViewer1.RefreshReport()
    End Sub

End Class