Public Class FormTipoHabitacion

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        imprimir()
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub imprimir()
        Dim sql As String = ""
        sql = "SELECT TH.nombre AS NOMBRE, COUNT(*) AS TOTAL  FROM HabitacionesXPiso HP INNER JOIN TiposHabitacion TH ON HP.idTipoHabitacion = TH.idTipoHabitacion GROUP BY TH.nombre "
        Dim tabla As DataTable = accesoBD.query(sql)
        Me.EstadisticaTipoHabitacionesBindingSource.DataSource = tabla
    End Sub
    Private accesoBD As New AccesoBD

End Class