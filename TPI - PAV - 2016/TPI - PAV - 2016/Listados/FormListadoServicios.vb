Public Class FormListadoServicios
    Dim accesoBD As AccesoBD = AccesoBD.instancia
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.impresion()

        Me.ReportViewer1.RefreshReport()
    End Sub
    Private Sub impresion()

        Dim sql As String = ""
        sql = "SELECT * FROM SERVICIOS"
        Dim tabla As DataTable = accesoBD.query(sql)
        Me.ServiciosBindingSource.DataSource = tabla
    End Sub

    Private Sub ReportViewer1_Load(sender As Object, e As EventArgs) Handles ReportViewer1.Load

    End Sub
End Class