Public Class FormCantidadMaxima
    Private accesoBD As New AccesoBD
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        imprimir()
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub imprimir()
        Dim sql As String = ""
        sql = "SELECT cantMaxPersonas AS CANTIDADMAX, COUNT(nroHabitacion) AS TOTAL FROM HabitacionesXPiso  GROUP BY cantMaxPersonas "
        Dim tabla As DataTable = accesoBD.query(sql)
        Me.EstadisticaMaximaBindingSource.DataSource = tabla
    End Sub

End Class