Public Class ABM_TiposDocumentos

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles cmd_registrar.Click
        Me.validar()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles cmd_cancelar.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)

    End Sub
    Private Function validar() As Boolean
        If txt_idDoc.Text = "" Then
            MessageBox.Show("Debe completar el campo Id Tipo de Documento", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            txt_idDoc.Focus()
            Return False
        End If
        If txt_nombre.Text = "" Then
            MessageBox.Show("Debe completar el campo Nombre", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            txt_nombre.Focus()
            Return False
        End If
        If txt_descripcion.Text = "" Then
            MessageBox.Show("Debe completar el campo Descripcion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            txt_descripcion.Focus()
            Return False
        End If
        Return True
    End Function
    Private Sub ABM_TiposDocumentos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
