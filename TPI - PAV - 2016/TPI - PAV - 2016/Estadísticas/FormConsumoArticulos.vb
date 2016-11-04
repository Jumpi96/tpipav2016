Public Class FormConsumoArticulos

    Private Sub FormConsumoArticulos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet.ArticulosConsumo' table. You can move, or remove it, as needed.
        Me.ArticulosConsumoTableAdapter.Fill(Me.DataSet.ArticulosConsumo)

        Me.ReportViewer1.RefreshReport()
        Me.ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
    End Sub
End Class