Imports Microsoft.Reporting.WinForms

Public Class FormListadoClientes

    Private Sub FormListadoClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet.ListadoClientes' table. You can move, or remove it, as needed.
        Me.ListadoClientesTableAdapter.Fill(Me.DataSet.ListadoClientes)

        Me.ReportViewer1.RefreshReport()
        Me.ReportViewer1.SetDisplayMode(DisplayMode.PrintLayout)
    End Sub
End Class