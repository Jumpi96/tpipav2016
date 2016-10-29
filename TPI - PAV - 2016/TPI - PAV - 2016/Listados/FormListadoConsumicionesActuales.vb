Public Class FormListadoConsumicionesActuales

    Private Sub FormListadoConsumicionesActuales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet.ListadoConsumicionesActuales' table. You can move, or remove it, as needed.
        Me.ListadoConsumicionesActualesTableAdapter.Fill(Me.DataSet.ListadoConsumicionesActuales)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class