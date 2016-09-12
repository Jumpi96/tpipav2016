Public Class Inicio

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim aloj As ABM_Alojamientos = New ABM_Alojamientos
        aloj.ShowDialog()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ABM_Clientes.Show()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ABM_TiposDocumentos.Show()
    End Sub
End Class
