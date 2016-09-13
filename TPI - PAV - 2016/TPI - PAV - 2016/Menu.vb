Public Class cmd_modOrdComSel

    Private Sub ocultarNuevoAlojamiento()
        Me.pnl_nueAlo.Visible = False
        Me.pnl_nueAlo.Enabled = False
        Me.pnl_nueAlo.SendToBack()
    End Sub

    Private Sub mostrarNuevoAlojamiento()
        Me.pnl_nueAlo.Visible = True
        Me.pnl_nueAlo.Enabled = True
        Me.tab_aloNue.SelectedTab = tab_aloNueDatCli
        Me.cmb_tipoDoc.Focus()
        Me.pnl_nueAlo.BringToFront()
    End Sub

    Private Sub ocultarBuscarAlojamiento()
        Me.pnl_busAlo.Visible = False
        Me.pnl_busAlo.Enabled = False
        Me.pnl_busAlo.SendToBack()
    End Sub

    Private Sub mostrarBuscarAlojamiento()
        Me.pnl_busAlo.Visible = True
        Me.pnl_busAlo.Enabled = True
        Me.tab_busAlo.SelectedTab = tab_busAloDatCli
        Me.cmb_tipDocBusAlo.Focus()
        Me.pnl_busAlo.BringToFront()
    End Sub

    Private Sub ocultarNuevaOrdenCompra()
        Me.pnl_nueOrdCom.Visible = False
        Me.pnl_nueOrdCom.Enabled = False
        Me.pnl_nueOrdCom.SendToBack()
    End Sub

    Private Sub mostrarNuevaOrdenCompra()
        Me.pnl_nueOrdCom.Visible = True
        Me.pnl_nueOrdCom.Enabled = True
        Me.tab_nueOrdCom.SelectedTab = tab_nueOrdComDatPro
        Me.cmb_IDPro.Focus()
        Me.pnl_nueOrdCom.BringToFront()
    End Sub

    Private Sub ocultarBuscarOrdenCompra()
        Me.pnl_busOrdCom.Visible = False
        Me.pnl_busOrdCom.Enabled = False
        Me.pnl_busOrdCom.SendToBack()
    End Sub

    Private Sub mostrarBuscarOrdenCompra()
        Me.pnl_busOrdCom.Visible = True
        Me.pnl_busOrdCom.Enabled = True
        Me.tab_busOrdCom.SelectedTab = tab_busOrdComDatPro
        Me.cmb_IDProBusOrdCom.Focus()
        Me.pnl_busOrdCom.BringToFront()
    End Sub

    Private Sub ocultarAgregarArticulo()
        Me.pnl_agrArt.Visible = False
        Me.pnl_agrArt.Enabled = False
        Me.pnl_agrArt.SendToBack()
    End Sub

    Private Sub mostrarAgregarArticulo()
        Me.pnl_agrArt.Visible = True
        Me.pnl_agrArt.Enabled = True
        Me.tab_carArt.SelectedTab = tab_carArtHab
        Me.cmb_nroPisoCarArt.Focus()
        Me.pnl_agrArt.BringToFront()
    End Sub

    Private Sub ocultarAgregarServicio()
        Me.pnl_agrServ.Visible = False
        Me.pnl_agrServ.Enabled = False
        Me.pnl_agrServ.SendToBack()
    End Sub

    Private Sub mostrarAgregarServicio()
        Me.pnl_agrServ.Visible = True
        Me.pnl_agrServ.Enabled = True
        Me.tab_carServ.SelectedTab = tab_carServHab
        Me.cmb_nroPiso.Focus()
        Me.pnl_agrServ.BringToFront()
    End Sub

    Private Sub NuevoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevoToolStripMenuItem.Click
        Me.menu_Menu.Enabled = False
        Me.ocultarBuscarAlojamiento()
        Me.ocultarNuevaOrdenCompra()
        Me.ocultarBuscarOrdenCompra()
        Me.ocultarAgregarArticulo()
        Me.ocultarAgregarServicio()
        Me.mostrarNuevoAlojamiento()
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
        Me.ocultarNuevoAlojamiento()
        Me.ocultarNuevaOrdenCompra()
        Me.ocultarBuscarOrdenCompra()
        Me.ocultarAgregarServicio()
        Me.ocultarAgregarArticulo()
        Me.mostrarBuscarAlojamiento()
    End Sub

    Private Sub cmd_canCli_Click(sender As Object, e As EventArgs) Handles cmd_canCli.Click
        Me.ocultarNuevoAlojamiento()
        Me.menu_Menu.Enabled = True
        Me.txt_ape.Text = ""
        Me.txt_doc.Text = ""
        Me.txt_fecNac.Text = ""
        Me.txt_nom.Text = ""
        Me.txt_tel.Text = ""
        Me.cmb_tipoDoc.Text = ""
        Me.txt_fecDes.Text = ""
        Me.txt_fecHas.Text = ""
        Me.cmb_canPer.Text = ""
        Me.cmb_tipHab.Text = ""
        Me.chx_airAco.Checked = False
        Me.chx_airAco.CheckState = CheckState.Unchecked
        Me.chx_frigobar.Checked = False
        Me.chx_frigobar.CheckState = CheckState.Unchecked
    End Sub

    Private Sub cmd_atrHos_Click(sender As Object, e As EventArgs) Handles cmd_atrHos.Click
        Me.tab_aloNue.SelectedTab = tab_aloNueDatCli
        Me.txt_fecDes.Text = ""
        Me.txt_fecHas.Text = ""
        Me.cmb_canPer.Text = ""
        Me.cmb_tipHab.Text = ""
    End Sub

    Private Sub cmd_aceHab_Click(sender As Object, e As EventArgs) Handles cmd_aceHab.Click
        Me.ocultarNuevoAlojamiento()
        Me.menu_Menu.Enabled = True
        Me.txt_ape.Text = ""
        Me.txt_doc.Text = ""
        Me.txt_fecNac.Text = ""
        Me.txt_nom.Text = ""
        Me.txt_tel.Text = ""
        Me.cmb_tipoDoc.Text = ""
        Me.txt_fecDes.Text = ""
        Me.txt_fecHas.Text = ""
        Me.cmb_canPer.Text = ""
        Me.cmb_tipHab.Text = ""
        Me.chx_airAco.Checked = False
        Me.chx_airAco.CheckState = CheckState.Unchecked
        Me.chx_frigobar.Checked = False
        Me.chx_frigobar.CheckState = CheckState.Unchecked
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
        Me.ocultarBuscarAlojamiento()
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
        Me.ocultarBuscarAlojamiento()
        Me.menu_Menu.Enabled = True
    End Sub

    Private Sub cmd_nueOrdComCan_Click(sender As Object, e As EventArgs) Handles cmd_nueOrdComCan.Click
        Me.cmb_IDPro.Text = ""
        Me.txt_nomPro.Text = ""
        Me.txt_telPro.Text = ""
        Me.txt_corPro.Text = ""
        Me.ocultarNuevaOrdenCompra()
        Me.menu_Menu.Enabled = True
    End Sub

    Private Sub cmd_nueOrdComSig_Click(sender As Object, e As EventArgs) Handles cmd_nueOrdComSig.Click
        tab_nueOrdCom.SelectedTab = tab_nueOrdComArt
    End Sub

    Private Sub NuevaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevaToolStripMenuItem.Click
        Me.menu_Menu.Enabled = False
        Me.ocultarNuevoAlojamiento()
        Me.ocultarBuscarAlojamiento()
        Me.ocultarBuscarOrdenCompra()
        Me.ocultarAgregarServicio()
        Me.ocultarAgregarArticulo()
        Me.mostrarNuevaOrdenCompra()
    End Sub

    Private Sub cmd_nueOrdComAtr_Click(sender As Object, e As EventArgs) Handles cmd_nueOrdComAtr.Click
        Me.tab_nueOrdCom.SelectedTab = tab_nueOrdComDatPro
    End Sub

    Private Sub cmd_nueOrdComFin_Click(sender As Object, e As EventArgs) Handles cmd_nueOrdComArtSig.Click
        Me.tab_nueOrdCom.SelectedTab = tab_nueOrdComRes
    End Sub

    Private Sub BuscarToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles BuscarToolStripMenuItem1.Click
        Me.menu_Menu.Enabled = False
        Me.ocultarNuevoAlojamiento()
        Me.ocultarBuscarAlojamiento()
        Me.ocultarNuevaOrdenCompra()
        Me.ocultarAgregarArticulo()
        Me.ocultarAgregarServicio()
        Me.mostrarBuscarOrdenCompra()
    End Sub

    Private Sub cmd_busOrdComCan_Click(sender As Object, e As EventArgs) Handles cmd_busOrdComCan.Click
        Me.cmb_IDProBusOrdCom.Text = ""
        Me.txt_corProBusOrdCom.Text = ""
        Me.txt_telProBusOrdCom.Text = ""
        Me.txt_nomProBusOrdCom.Text = ""
        Me.ocultarBuscarOrdenCompra()
        Me.menu_Menu.Enabled = True
    End Sub

    Private Sub cmd_busOrdComSig_Click(sender As Object, e As EventArgs) Handles cmd_busOrdComSig.Click
        Me.tab_busOrdCom.SelectedTab = tab_busOrdComOrdCom
    End Sub

    Private Sub cmd_busOrdComAtr_Click(sender As Object, e As EventArgs) Handles cmd_busOrdComAtr.Click
        Me.tab_busOrdCom.SelectedTab = Me.tab_busOrdComDatPro
    End Sub

    Private Sub cmd_busOrdComFin_Click(sender As Object, e As EventArgs) Handles cmd_busOrdComFin.Click
        Me.cmb_IDProBusOrdCom.Text = ""
        Me.txt_corProBusOrdCom.Text = ""
        Me.txt_telProBusOrdCom.Text = ""
        Me.txt_nomProBusOrdCom.Text = ""
        Me.ocultarBuscarOrdenCompra()
        Me.menu_Menu.Enabled = True
    End Sub

    Private Sub AgrearArtículoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AgrearArtículoToolStripMenuItem.Click
        Me.menu_Menu.Enabled = False
        Me.ocultarNuevoAlojamiento()
        Me.ocultarBuscarAlojamiento()
        Me.ocultarNuevaOrdenCompra()
        Me.ocultarBuscarOrdenCompra()
        Me.ocultarAgregarServicio()
        Me.mostrarAgregarArticulo()
    End Sub

    Private Sub AgregarServicioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AgregarServicioToolStripMenuItem.Click
        Me.menu_Menu.Enabled = False
        Me.ocultarNuevoAlojamiento()
        Me.ocultarBuscarAlojamiento()
        Me.ocultarNuevaOrdenCompra()
        Me.ocultarBuscarOrdenCompra()
        Me.ocultarAgregarArticulo()
        Me.mostrarAgregarServicio()
    End Sub

    Private Sub cmd_carServCan_Click(sender As Object, e As EventArgs) Handles cmd_carServCan.Click
        Me.cmb_nroHab.Text = ""
        Me.cmb_nroPiso.Text = ""
        Me.txt_cliAso.Text = ""
        Me.ocultarAgregarServicio()
        Me.menu_Menu.Enabled = True
    End Sub

    Private Sub cmd_carServSig_Click(sender As Object, e As EventArgs) Handles cmd_carServSig.Click
        Me.tab_carServ.SelectedTab = tab_carServServ
    End Sub

    Private Sub cmd_carSerFin_Click(sender As Object, e As EventArgs) Handles cmd_carSerFin.Click
        Me.cmb_nroHab.Text = ""
        Me.cmb_nroPiso.Text = ""
        Me.txt_cliAso.Text = ""
        Me.ocultarAgregarServicio()
        Me.menu_Menu.Enabled = True
    End Sub

    Private Sub cmd_carServAtr_Click(sender As Object, e As EventArgs) Handles cmd_carServAtr.Click
        Me.tab_carServ.SelectedTab = tab_carServHab
    End Sub

    Private Sub cmd_carArtCan_Click(sender As Object, e As EventArgs) Handles cmd_carArtCan.Click
        Me.cmb_nroHabCarArt.Text = ""
        Me.cmb_nroPisoCarArt.Text = ""
        Me.txt_cliAsoCarArt.Text = ""
        Me.ocultarAgregarArticulo()
        Me.menu_Menu.Enabled = True
    End Sub

    Private Sub cmd_carArtSig_Click(sender As Object, e As EventArgs) Handles cmd_carArtSig.Click
        Me.tab_carArt.SelectedTab = tab_carArtArt
    End Sub

    Private Sub cmd_carArtAtr_Click(sender As Object, e As EventArgs) Handles cmd_carArtAtr.Click
        Me.tab_carArt.SelectedTab = tab_carArtHab
    End Sub

    Private Sub cmd_carArtFin_Click(sender As Object, e As EventArgs) Handles cmd_carArtFin.Click
        Me.cmb_nroHabCarArt.Text = ""
        Me.cmb_nroPisoCarArt.Text = ""
        Me.txt_cliAsoCarArt.Text = ""
        Me.ocultarAgregarArticulo()
        Me.menu_Menu.Enabled = True
    End Sub

    Private Sub cmd_carSerHabLim_Click(sender As Object, e As EventArgs) Handles cmd_carSerHabLim.Click
        Me.cmb_nroPiso.Text = ""
        Me.cmb_nroHab.Text = ""
        Me.txt_cliAso.Text = ""
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.cmb_nroHabCarArt.Text = ""
        Me.cmb_nroPisoCarArt.Text = ""
        Me.txt_cliAsoCarArt.Text = ""
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.cmb_IDProBusOrdCom.Text = ""
        Me.txt_corProBusOrdCom.Text = ""
        Me.txt_nomProBusOrdCom.Text = ""
        Me.txt_telProBusOrdCom.Text = ""
    End Sub

    Private Sub cmd_nueOrdComLim_Click(sender As Object, e As EventArgs) Handles cmd_nueOrdComLim.Click
        Me.cmb_IDPro.Text = ""
        Me.txt_nomPro.Text = ""
        Me.txt_corPro.Text = ""
        Me.txt_telPro.Text = ""
    End Sub

    Private Sub cmd_nueAloDatCliLim_Click(sender As Object, e As EventArgs) Handles cmd_nueAloDatCliLim.Click
        Me.cmb_tipoDoc.Text = ""
        Me.txt_doc.Text = ""
        Me.txt_ape.Text = ""
        Me.txt_nom.Text = ""
        Me.txt_fecNac.Text = ""
        Me.txt_tel.Text = ""
    End Sub

    Private Sub cmd_nueAloDatHosLim_Click(sender As Object, e As EventArgs) Handles cmd_nueAloDatHosLim.Click
        Me.txt_fecDes.Text = ""
        Me.txt_fecHas.Text = ""
        Me.cmb_canPer.Text = ""
        Me.cmb_tipHab.Text = ""
        Me.chx_airAco.Checked = False
        Me.chx_airAco.CheckState = CheckState.Unchecked
        Me.chx_frigobar.Checked = False
        Me.chx_frigobar.CheckState = CheckState.Unchecked
    End Sub

    Private Sub cmd_busAloLim_Click(sender As Object, e As EventArgs) Handles cmd_busAloLim.Click
        Me.cmb_tipDocBusAlo.Text = ""
        Me.txt_docBusAlo.Text = ""
        Me.txt_apeBusAlo.Text = ""
        Me.txt_nomBusAlo.Text = ""
    End Sub

    Private Sub cmd_atrAloSel_Click(sender As Object, e As EventArgs) Handles cmd_atrAloSel.Click
        pnl_busAloSel.Enabled = False
        pnl_busAloSel.Visible = False
        pnl_busAloSel.SendToBack()
    End Sub

    Private Sub cmd_clickEnGrilla_Click(sender As Object, e As EventArgs) Handles cmd_clickEnGrilla.Click
        pnl_busAloSel.Enabled = True
        pnl_busAloSel.Visible = True
        pnl_busAloSel.BringToFront()
    End Sub

    Private Sub cmd_atrOrdComSel_Click(sender As Object, e As EventArgs) Handles cmd_atrOrdComSel.Click
        pnl_ordComSel.Enabled = False
        pnl_ordComSel.Visible = False
        pnl_ordComSel.SendToBack()
    End Sub

    Private Sub cmd_clickEnGrillaOrdenDeCompra_Click(sender As Object, e As EventArgs) Handles cmd_clickEnGrillaOrdenDeCompra.Click
        pnl_ordComSel.Enabled = True
        pnl_ordComSel.Visible = True
        pnl_ordComSel.BringToFront()
    End Sub

    Private Sub ABMAlojamientosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ABMAlojamientosToolStripMenuItem.Click
        ABM_Alojamientos.Show()
    End Sub

    Private Sub ABMClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ABMClientesToolStripMenuItem.Click
        ABM_Clientes.Show()
    End Sub

    Private Sub ABMTiposDocumentosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ABMTiposDocumentosToolStripMenuItem.Click
        ABM_TiposDocumentos.Show()
    End Sub

    Private Sub cmd_nueOrdComFin_Click_1(sender As Object, e As EventArgs) Handles cmd_nueOrdComFin.Click
        Me.cmb_IDPro.Text = ""
        Me.txt_nomPro.Text = ""
        Me.txt_telPro.Text = ""
        Me.txt_corPro.Text = ""
        Me.txt_nueOrdComArtFilDes.Text = ""
        Me.txt_nueOrdComArtFilID.Text = ""
        Me.ocultarNuevaOrdenCompra()
        Me.menu_Menu.Enabled = True
    End Sub

    Private Sub cmd_nueOrdComResAtr_Click(sender As Object, e As EventArgs) Handles cmd_nueOrdComResAtr.Click
        Me.tab_nueOrdCom.SelectedTab = tab_nueOrdComArt
    End Sub

    Private Sub cmd_modOrdComSel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.lbl_fechahora.Text = Today.Day & "/" & Today.Month & "/" & Today.Year
    End Sub
End Class