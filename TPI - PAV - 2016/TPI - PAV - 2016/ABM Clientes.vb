Public Class ABM_Clientes
    Private Function Validar() As Boolean
        If txt_apellido.Text = "" Then
            MessageBox.Show("Debe completar el campo Apellido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            txt_apellido.Focus()
            Return False
        End If
        If txt_nombre.Text = "" Then
            MessageBox.Show("Debe completar el campo Nombre", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            txt_nombre.Focus()
            Return False
        End If
        If txt_nroDoc.Text = "" Then
            MessageBox.Show("Debe completar el campo Nro de Documento", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            txt_nroDoc.Focus()
            Return False
        End If
        If txt_telefono.Text = "" Then
            MessageBox.Show("Debe completar el campo Telefono", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            txt_telefono.Focus()
            Return False
        End If
        If cmb_tipoDoc.SelectedIndex = -1 Then
            MessageBox.Show("Debe completar el campo Tipo de Documento", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            cmb_tipoDoc.Focus()
            Return False
        End If
        Return True
    End Function
    Private Sub cmd_registrar_Click(sender As Object, e As EventArgs) Handles cmd_registrar.Click
        Me.Validar()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles cmd_buscar.Click

    End Sub

    Private Sub lbl_telefono_Click(sender As Object, e As EventArgs) Handles lbl_telefono.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class