Public Class FormListadoHabitacionesConFrigo
    Dim accesoBD As AccesoBD = AccesoBD.instancia
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.impresion()
        Me.ReportViewer1.RefreshReport()
    End Sub
    Private Sub impresion()

        Dim sql As String = ""
        sql = "SELECT * FROM HABITACIONESXPISO WHERE FRIGOBAR=1"
        Dim tabla As DataTable = accesoBD.query(sql)
        Me.HabitacionesXPisoBindingSource.DataSource = tabla

    End Sub
End Class