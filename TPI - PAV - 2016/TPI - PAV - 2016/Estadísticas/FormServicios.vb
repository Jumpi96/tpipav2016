Public Class FormServicios
    Private accesoBD As New AccesoBD
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        imprimir()
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub imprimir()

        Dim sql As String = ""
        sql = "SELECT S.nombre AS NOMBRE, COUNT(*) AS TOTAL FROM Servicios S INNER JOIN ServiciosXAlojamiento SA ON S.idServicio = SA.idServicio GROUP BY S.nombre "
        Dim tabla As DataTable = accesoBD.query(sql)
        Me.EstadisiticaServiciosBindingSource.DataSource = tabla

    End Sub


End Class