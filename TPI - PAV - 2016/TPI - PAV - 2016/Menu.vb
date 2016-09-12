Public Class Menu

    Private Sub NuevoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevoToolStripMenuItem.Click
        Me.pnl_busAlo.Visible = False
        Me.pnl_busAlo.Enabled = False
        Me.pnl_busAlo.SendToBack()
        Me.pnl_nueAlo.Visible = True
        Me.pnl_nueAlo.Enabled = True
        Me.pnl_nueAlo.BringToFront()
        Me.menu_Menu.Enabled = False
    End Sub

    Private Sub txt_doc_Click(sender As Object, e As EventArgs) Handles txt_doc.Click

    End Sub

    Private Sub txt_doc_MouseClick(sender As Object, e As MouseEventArgs) Handles txt_doc.MouseClick, txt_docBusAlo.MouseClick
        If Me.txt_doc.Text = "" Then
            Me.txt_doc.SelectionStart = 0
        End If
    End Sub

    Private Sub txt_fecDes_MouseClick(sender As Object, e As MouseEventArgs) Handles txt_fecDes.MouseClick
        If Me.txt_fecDes.Text = "  /  /" Then
            Me.txt_fecDes.SelectionStart = 0
        End If
    End Sub

    Private Sub txt_fecHas_MouseClick(sender As Object, e As MouseEventArgs) Handles txt_fecHas.MouseClick
        If Me.txt_fecHas.Text = "  /  /" Then
            Me.txt_fecHas.SelectionStart = 0
        End If
    End Sub

    Private Sub txt_fecNac_MouseClick(sender As Object, e As MouseEventArgs) Handles txt_fecNac.MouseClick
        If Me.txt_fecNac.Text = "  /  /" Then
            Me.txt_fecNac.SelectionStart = 0
        End If
    End Sub

    Private Sub BuscarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BuscarToolStripMenuItem.Click
        Me.menu_Menu.Enabled = False
        Me.pnl_nueAlo.Visible = False
        Me.pnl_nueAlo.Enabled = False
        Me.pnl_nueAlo.SendToBack()
        Me.pnl_busAlo.Visible = True
        Me.pnl_busAlo.Enabled = True
        Me.pnl_busAlo.BringToFront()
    End Sub

    Private Sub cmd_canCli_Click(sender As Object, e As EventArgs) Handles cmd_canCli.Click
        Me.pnl_nueAlo.Visible = False
        Me.pnl_nueAlo.Enabled = False
        Me.menu_Menu.Enabled = True
        Me.txt_ape.Text = ""
        Me.txt_doc.Text = ""
        Me.txt_fecNac.Text = ""
        Me.txt_nom.Text = ""
        Me.txt_tel.Text = ""
        Me.cmb_tipoDoc.Text = ""
    End Sub

    Private Sub cmd_atrHos_Click(sender As Object, e As EventArgs) Handles cmd_atrHos.Click
        Me.tab_aloNue.SelectedTab = tab_aloNueDatCli
        Me.txt_fecDes.Text = ""
        Me.txt_fecHas.Text = ""
        Me.cmb_canPer.Text = ""
        Me.cmb_tipHab.Text = ""
    End Sub

    Private Sub cmd_aceHab_Click(sender As Object, e As EventArgs) Handles cmd_aceHab.Click
        Me.pnl_nueAlo.Visible = False
        Me.pnl_nueAlo.Enabled = False
        Me.menu_Menu.Enabled = True
    End Sub

    Private Sub cmd_sigHos_Click(sender As Object, e As EventArgs) Handles cmd_sigHos.Click
        Me.tab_aloNue.SelectedTab = tab_aloNueSelHab
    End Sub

    Private Sub cmd_sigCli_Click(sender As Object, e As EventArgs) Handles cmd_sigCli.Click
        Me.tab_aloNue.SelectedTab = tab_aloNueDatHos
    End Sub

    Private Sub cam_atrHab_Click(sender As Object, e As EventArgs) Handles cam_atrHab.Click
        Me.tab_aloNue.SelectedTab = tab_aloNueDatHos
    End Sub

    Private Sub txt_doc_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles txt_doc.MaskInputRejected

    End Sub

    Private Sub cmb_tipoDoc_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_tipoDoc.SelectedIndexChanged

    End Sub

    Private Sub cmd_busAloDatCliSig_Click(sender As Object, e As EventArgs) Handles cmd_busAloDatCliSig.Click
        Me.tab_busAlo.SelectedTab = tab_busAloAlo
    End Sub

    Private Sub cmd_busAloCan_Click(sender As Object, e As EventArgs) Handles cmd_busAloCan.Click
        Me.txt_docBusAlo.Text = ""
        Me.txt_apeBusAlo.Text = ""
        Me.txt_nomBusAlo.Text = ""
        Me.cmb_tipDocBusAlo.Text = ""
        Me.menu_Menu.Enabled = True
    End Sub
End Class