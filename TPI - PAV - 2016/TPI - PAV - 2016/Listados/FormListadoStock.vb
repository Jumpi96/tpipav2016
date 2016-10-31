Public Class FormListadoStock

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.impresion()
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub impresion()
        Throw New NotImplementedException
    End Sub


End Class