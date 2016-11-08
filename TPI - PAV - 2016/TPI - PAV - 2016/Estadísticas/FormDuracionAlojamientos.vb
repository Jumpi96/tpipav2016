Public Class FormDuracionAlojamientos

    Private Sub FormDuracionAlojamientos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet.EstadisticaDuracion' table. You can move, or remove it, as needed.
        Me.EstadisticaDuracionTableAdapter.Fill(Me.DataSet.EstadisticaDuracion)

        Me.ReportViewer1.RefreshReport()
        Me.ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
    End Sub
End Class