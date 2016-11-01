Public Class FormListadoHabitaciones

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet.HabitacionesXPiso' table. You can move, or remove it, as needed.
        Me.HabitacionesXPisoTableAdapter.Fill(Me.DataSet.HabitacionesXPiso)
        Me.ReportViewer1.RefreshReport()
    End Sub

End Class