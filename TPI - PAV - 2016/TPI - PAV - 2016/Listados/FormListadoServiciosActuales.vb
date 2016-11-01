Imports Microsoft.Reporting.WinForms

Public Class FormListadoServiciosActuales

    Private Sub FormListadoServiciosActuales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet.ServiciosActuales' table. You can move, or remove it, as needed.
        Me.ServiciosActualesTableAdapter.Fill(Me.DataSet.ServiciosActuales)

        Me.ReportViewer1.RefreshReport()
        Me.ReportViewer1.SetDisplayMode(DisplayMode.PrintLayout)
    End Sub
End Class