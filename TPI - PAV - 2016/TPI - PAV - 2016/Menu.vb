Public Class menu

    Private Sub NuevoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevoToolStripMenuItem.Click
        Me.menu_Menu.Enabled = False

        Me.pnl_busAlo.Visible = False
        Me.pnl_busAlo.Enabled = False
        Me.pnl_busAlo.SendToBack()

        Me.pnl_nueOrdCom.Visible = False
        Me.pnl_nueOrdCom.Enabled = False
        Me.pnl_nueOrdCom.SendToBack()

        Me.pnl_busOrdCom.Visible = False
        Me.pnl_busOrdCom.Enabled = False
        Me.pnl_busOrdCom.SendToBack()

        Me.tab_aloNue.SelectedTab = tab_aloNueDatCli
        Me.pnl_nueAlo.Visible = True
        Me.pnl_nueAlo.Enabled = True
        Me.cmb_tipoDoc.Focus()
        Me.pnl_nueAlo.BringToFront()

    End Sub

    Private Sub txt_doc_Click(sender As Object, e As EventArgs) Handles txt_doc.Click
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

        Me.pnl_nueOrdCom.Visible = False
        Me.pnl_nueOrdCom.Enabled = False
        Me.pnl_nueOrdCom.SendToBack()

        Me.pnl_busOrdCom.Visible = False
        Me.pnl_busOrdCom.Enabled = False
        Me.pnl_busOrdCom.SendToBack()

        Me.tab_busAlo.SelectedTab = tab_busAloDatCli
        Me.pnl_busAlo.Visible = True
        Me.pnl_busAlo.Enabled = True
        Me.cmb_tipDocBusAlo.Focus()
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

        Me.txt_fecDes.Text = ""
        Me.txt_fecHas.Text = ""
        Me.cmb_canPer.Text = ""
        Me.cmb_tipHab.Text = ""
        Me.txt_ape.Text = ""
        Me.txt_doc.Text = ""
        Me.txt_fecNac.Text = ""
        Me.txt_nom.Text = ""
        Me.txt_tel.Text = ""
        Me.cmb_tipoDoc.Text = ""

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

    Private Sub cmd_busAloDatCliSig_Click(sender As Object, e As EventArgs) Handles cmd_busAloDatCliSig.Click
        Me.tab_busAlo.SelectedTab = tab_busAloAlo
    End Sub

    Private Sub cmd_busAloCan_Click(sender As Object, e As EventArgs) Handles cmd_busAloCan.Click
        Me.txt_docBusAlo.Text = ""
        Me.txt_apeBusAlo.Text = ""
        Me.txt_nomBusAlo.Text = ""
        Me.cmb_tipDocBusAlo.Text = ""

        Me.pnl_busAlo.Visible = False
        Me.pnl_busAlo.Enabled = False
        Me.pnl_busAlo.SendToBack()

        Me.menu_Menu.Enabled = True
    End Sub

    Private Sub txt_docBusAlo_Click(sender As Object, e As EventArgs) Handles txt_docBusAlo.Click
        If Me.txt_docBusAlo.Text = "" Then
            Me.txt_docBusAlo.SelectionStart = 0
        End If
    End Sub

    Private Sub cmd_busAloAtr_Click(sender As Object, e As EventArgs) Handles cmd_busAloAtr.Click
        Me.tab_busAlo.SelectedTab = tab_busAloDatCli
    End Sub

    Private Sub cmd_busAloFin_Click(sender As Object, e As EventArgs) Handles cmd_busAloFin.Click
        Me.txt_docBusAlo.Text = ""
        Me.txt_apeBusAlo.Text = ""
        Me.txt_nomBusAlo.Text = ""
        Me.cmb_tipDocBusAlo.Text = ""

        Me.menu_Menu.Enabled = True
        Me.pnl_busAlo.Visible = False
        Me.pnl_busAlo.Enabled = False
        Me.pnl_busAlo.SendToBack()
    End Sub

    Private Sub cmd_nueOrdComCan_Click(sender As Object, e As EventArgs) Handles cmd_nueOrdComCan.Click
        Me.cmb_IDPro.Text = ""
        Me.txt_nomPro.Text = ""
        Me.txt_telPro.Text = ""
        Me.txt_corPro.Text = ""

        Me.pnl_nueOrdCom.Visible = False
        Me.pnl_nueOrdCom.Enabled = False
        Me.pnl_nueOrdCom.SendToBack()

        Me.menu_Menu.Enabled = True
    End Sub

    Private Sub cmd_nueOrdComSig_Click(sender As Object, e As EventArgs) Handles cmd_nueOrdComSig.Click
        tab_nueOrdCom.SelectedTab = tab_nueOrdComArt
    End Sub

    Private Sub NuevaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevaToolStripMenuItem.Click
        Me.menu_Menu.Enabled = False

        Me.pnl_busAlo.Visible = False
        Me.pnl_busAlo.Enabled = False
        Me.pnl_busAlo.SendToBack()

        Me.pnl_nueAlo.Visible = False
        Me.pnl_nueAlo.Enabled = False
        Me.pnl_nueAlo.SendToBack()

        Me.pnl_busOrdCom.Visible = False
        Me.pnl_busOrdCom.Enabled = False
        Me.pnl_busOrdCom.SendToBack()

        Me.tab_nueOrdCom.SelectedTab = tab_nueOrdComDatPro
        Me.pnl_nueOrdCom.Visible = True
        Me.pnl_nueOrdCom.Enabled = True
        Me.cmb_IDPro.Focus()
        Me.pnl_nueOrdCom.BringToFront()
    End Sub

    Private Sub cmd_nueOrdComAtr_Click(sender As Object, e As EventArgs) Handles cmd_nueOrdComAtr.Click
        Me.tab_nueOrdCom.SelectedTab = tab_nueOrdComDatPro
    End Sub

    Private Sub cmd_nueOrdComFin_Click(sender As Object, e As EventArgs) Handles cmd_nueOrdComFin.Click
        Me.cmb_IDPro.Text = ""
        Me.txt_nomPro.Text = ""
        Me.txt_telPro.Text = ""
        Me.txt_corPro.Text = ""

        Me.pnl_nueOrdCom.Visible = False
        Me.pnl_nueOrdCom.Enabled = False

        Me.menu_Menu.Enabled = True
    End Sub

    Private Sub DataGridView1_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentDoubleClick

    End Sub

    Private Sub BuscarToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles BuscarToolStripMenuItem1.Click
        Me.menu_Menu.Enabled = False

        Me.pnl_busAlo.Visible = False
        Me.pnl_busAlo.Enabled = False
        Me.pnl_busAlo.SendToBack()

        Me.pnl_nueAlo.Visible = False
        Me.pnl_nueAlo.Enabled = False
        Me.pnl_nueAlo.SendToBack()

        Me.pnl_nueOrdCom.Visible = False
        Me.pnl_nueOrdCom.Enabled = False
        Me.pnl_nueOrdCom.SendToBack()

        Me.tab_busOrdCom.SelectedTab = tab_busOrdComDatPro
        Me.pnl_busOrdCom.Visible = True
        Me.pnl_busOrdCom.Enabled = True
        Me.cmb_IDProBusOrdCom.Focus()
        Me.pnl_busOrdCom.BringToFront()
    End Sub

    Private Sub cmd_busOrdComCan_Click(sender As Object, e As EventArgs) Handles cmd_busOrdComCan.Click
        Me.cmb_IDProBusOrdCom.Text = ""
        Me.txt_corProBusOrdCom.Text = ""
        Me.txt_telProBusOrdCom.Text = ""
        Me.txt_nomProBusOrdCom.Text = ""

        Me.pnl_busOrdCom.Visible = False
        Me.pnl_busOrdCom.Enabled = False
        Me.menu_Menu.Enabled = True
    End Sub
End Class