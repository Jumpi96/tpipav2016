Public Class Inicio

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim aloj As ABM_Alojamientos = New ABM_Alojamientos
        aloj.ShowDialog()
    End Sub
End Class
