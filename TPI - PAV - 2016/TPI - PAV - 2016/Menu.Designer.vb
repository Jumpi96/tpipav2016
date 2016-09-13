<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class cmd_modOrdComSel
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.menu_Menu = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.NuevoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BuscarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ArtículosServiciosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AgrearArtículoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AgregarServicioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ÓrdenesDeComprasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NuevaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BuscarToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.FuncionesAdministrativasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ABMsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ABMAlojamientosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ABMClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ABMTiposDocumentosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InformesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EstadísticasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.pnl_nueAlo = New System.Windows.Forms.Panel()
        Me.lbl_nueAlo = New System.Windows.Forms.Label()
        Me.tab_aloNue = New System.Windows.Forms.TabControl()
        Me.tab_aloNueDatCli = New System.Windows.Forms.TabPage()
        Me.cmd_nueAloDatCliLim = New System.Windows.Forms.Button()
        Me.txt_tel = New System.Windows.Forms.TextBox()
        Me.cmd_canCli = New System.Windows.Forms.Button()
        Me.cmd_sigCli = New System.Windows.Forms.Button()
        Me.cmd_busCli = New System.Windows.Forms.Button()
        Me.txt_fecNac = New System.Windows.Forms.MaskedTextBox()
        Me.txt_nom = New System.Windows.Forms.TextBox()
        Me.txt_ape = New System.Windows.Forms.TextBox()
        Me.txt_doc = New System.Windows.Forms.MaskedTextBox()
        Me.lbl_fecNac = New System.Windows.Forms.Label()
        Me.lbl_sexo = New System.Windows.Forms.Label()
        Me.lbl_ape = New System.Windows.Forms.Label()
        Me.lbl_nom = New System.Windows.Forms.Label()
        Me.lbl_doc = New System.Windows.Forms.Label()
        Me.lbl_tipoDoc = New System.Windows.Forms.Label()
        Me.cmb_tipoDoc = New System.Windows.Forms.ComboBox()
        Me.tab_aloNueDatHos = New System.Windows.Forms.TabPage()
        Me.cmd_nueAloDatHosLim = New System.Windows.Forms.Button()
        Me.cmd_atrHos = New System.Windows.Forms.Button()
        Me.cmd_sigHos = New System.Windows.Forms.Button()
        Me.cmb_tipHab = New System.Windows.Forms.ComboBox()
        Me.cmb_canPer = New System.Windows.Forms.ComboBox()
        Me.txt_fecHas = New System.Windows.Forms.MaskedTextBox()
        Me.txt_fecDes = New System.Windows.Forms.MaskedTextBox()
        Me.lbl_tipHab = New System.Windows.Forms.Label()
        Me.lbl_canPer = New System.Windows.Forms.Label()
        Me.lbl_fecHas = New System.Windows.Forms.Label()
        Me.lbl_fecDes = New System.Windows.Forms.Label()
        Me.tab_aloNueSelHab = New System.Windows.Forms.TabPage()
        Me.cam_atrHab = New System.Windows.Forms.Button()
        Me.cmd_aceHab = New System.Windows.Forms.Button()
        Me.pnl_busAlo = New System.Windows.Forms.Panel()
        Me.lbl_busAlo = New System.Windows.Forms.Label()
        Me.tab_busAlo = New System.Windows.Forms.TabControl()
        Me.tab_busAloDatCli = New System.Windows.Forms.TabPage()
        Me.cmd_busAloLim = New System.Windows.Forms.Button()
        Me.cmd_busAloCan = New System.Windows.Forms.Button()
        Me.cmd_busAloDatCliSig = New System.Windows.Forms.Button()
        Me.cmd_busCliBusAlo = New System.Windows.Forms.Button()
        Me.txt_nomBusAlo = New System.Windows.Forms.TextBox()
        Me.txt_apeBusAlo = New System.Windows.Forms.TextBox()
        Me.txt_docBusAlo = New System.Windows.Forms.MaskedTextBox()
        Me.lbl_apeBusAlo = New System.Windows.Forms.Label()
        Me.lbl_nomBusAlo = New System.Windows.Forms.Label()
        Me.lbl_docBusAlo = New System.Windows.Forms.Label()
        Me.lbl_tipDocBusAlo = New System.Windows.Forms.Label()
        Me.cmb_tipDocBusAlo = New System.Windows.Forms.ComboBox()
        Me.tab_busAloAlo = New System.Windows.Forms.TabPage()
        Me.cmd_clickEnGrilla = New System.Windows.Forms.Button()
        Me.cmd_busAloAtr = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.clm_piso = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clm_hab = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clm_fecIni = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clm_fecHas = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cmd_busAloFin = New System.Windows.Forms.Button()
        Me.pnl_busAloSel = New System.Windows.Forms.Panel()
        Me.cmd_atrAloSel = New System.Windows.Forms.Button()
        Me.cmd_anuAloSel = New System.Windows.Forms.Button()
        Me.cmd_modAloSel = New System.Windows.Forms.Button()
        Me.txt_tipoDocAloSel = New System.Windows.Forms.TextBox()
        Me.txt_apeAloSel = New System.Windows.Forms.TextBox()
        Me.txt_nomAloSel = New System.Windows.Forms.TextBox()
        Me.txt_docAloSel = New System.Windows.Forms.MaskedTextBox()
        Me.lbl_nomAloSel = New System.Windows.Forms.Label()
        Me.lbl_apeAloSel = New System.Windows.Forms.Label()
        Me.lbl_docAloSel = New System.Windows.Forms.Label()
        Me.lbl_tipoDocAloSel = New System.Windows.Forms.Label()
        Me.pnl_sepAloSel = New System.Windows.Forms.Panel()
        Me.lbl_cliAsoAloSel = New System.Windows.Forms.Label()
        Me.txt_fecHasAloSel = New System.Windows.Forms.MaskedTextBox()
        Me.txt_fecDesAloSel = New System.Windows.Forms.MaskedTextBox()
        Me.txt_IDAloSel = New System.Windows.Forms.TextBox()
        Me.txt_preDiaAloSel = New System.Windows.Forms.TextBox()
        Me.txt_nroHabAloSel = New System.Windows.Forms.TextBox()
        Me.txt_canPerAloSel = New System.Windows.Forms.TextBox()
        Me.txt_nroPisoAloSel = New System.Windows.Forms.TextBox()
        Me.lbl_preDiaAloSel = New System.Windows.Forms.Label()
        Me.lbl_fecHasAloSel = New System.Windows.Forms.Label()
        Me.lbl_fecDesAloSel = New System.Windows.Forms.Label()
        Me.lbl_canPerAloSel = New System.Windows.Forms.Label()
        Me.lbl_nroHabAloSel = New System.Windows.Forms.Label()
        Me.lbl_nroPisoAloSel = New System.Windows.Forms.Label()
        Me.lbl_IDAloSel = New System.Windows.Forms.Label()
        Me.lbl_aloSel = New System.Windows.Forms.Label()
        Me.pnl_nueOrdCom = New System.Windows.Forms.Panel()
        Me.lbl_ordCom = New System.Windows.Forms.Label()
        Me.tab_nueOrdCom = New System.Windows.Forms.TabControl()
        Me.tab_nueOrdComDatPro = New System.Windows.Forms.TabPage()
        Me.cmd_nueOrdComLim = New System.Windows.Forms.Button()
        Me.cmd_busPro = New System.Windows.Forms.Button()
        Me.cmd_nueOrdComSig = New System.Windows.Forms.Button()
        Me.cmd_nueOrdComCan = New System.Windows.Forms.Button()
        Me.txt_telPro = New System.Windows.Forms.TextBox()
        Me.txt_corPro = New System.Windows.Forms.TextBox()
        Me.txt_nomPro = New System.Windows.Forms.TextBox()
        Me.cmb_IDPro = New System.Windows.Forms.ComboBox()
        Me.lbl_telPro = New System.Windows.Forms.Label()
        Me.lbl_corPro = New System.Windows.Forms.Label()
        Me.lbl_nomPro = New System.Windows.Forms.Label()
        Me.lbl_IDPro = New System.Windows.Forms.Label()
        Me.tab_nueOrdComArt = New System.Windows.Forms.TabPage()
        Me.cmd_nueOrdComAgr = New System.Windows.Forms.Button()
        Me.txt_nueOrdComArtFilDes = New System.Windows.Forms.TextBox()
        Me.lbl_nueOrdComArtFilDes = New System.Windows.Forms.Label()
        Me.txt_nueOrdComArtFilID = New System.Windows.Forms.TextBox()
        Me.lbl_nueOrdComArtFilID = New System.Windows.Forms.Label()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.clm_ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clm_des = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clm_preUni = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clm_cant = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clm_preTot = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cmd_nueOrdComAtr = New System.Windows.Forms.Button()
        Me.cmd_nueOrdComArtSig = New System.Windows.Forms.Button()
        Me.tab_nueOrdComRes = New System.Windows.Forms.TabPage()
        Me.cmd_nueOrdComResAtr = New System.Windows.Forms.Button()
        Me.cmd_nueOrdComFin = New System.Windows.Forms.Button()
        Me.pnl_busOrdCom = New System.Windows.Forms.Panel()
        Me.tab_busOrdCom = New System.Windows.Forms.TabControl()
        Me.tab_busOrdComDatPro = New System.Windows.Forms.TabPage()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.cmd_busOrdComSig = New System.Windows.Forms.Button()
        Me.cmd_busOrdComCan = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txt_telProBusOrdCom = New System.Windows.Forms.TextBox()
        Me.txt_corProBusOrdCom = New System.Windows.Forms.TextBox()
        Me.txt_nomProBusOrdCom = New System.Windows.Forms.TextBox()
        Me.cmb_IDProBusOrdCom = New System.Windows.Forms.ComboBox()
        Me.lbl_telProBusOrdCom = New System.Windows.Forms.Label()
        Me.lbl_corProBusOrdCom = New System.Windows.Forms.Label()
        Me.lbl_nomProBusOrdCom = New System.Windows.Forms.Label()
        Me.lbl_IDProBusOrdCom = New System.Windows.Forms.Label()
        Me.tab_busOrdComOrdCom = New System.Windows.Forms.TabPage()
        Me.cmd_clickEnGrillaOrdenDeCompra = New System.Windows.Forms.Button()
        Me.DataGridView3 = New System.Windows.Forms.DataGridView()
        Me.clm_IDOrdCom = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clm_IDPro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clm_fecEmi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clm_fecRec = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cmd_busOrdComAtr = New System.Windows.Forms.Button()
        Me.cmd_busOrdComFin = New System.Windows.Forms.Button()
        Me.lbl_busOrdCom = New System.Windows.Forms.Label()
        Me.pnl_ordComSel = New System.Windows.Forms.Panel()
        Me.cmd_atrOrdComSel = New System.Windows.Forms.Button()
        Me.cmd_anuOrdComSel = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.MaskedTextBox1 = New System.Windows.Forms.MaskedTextBox()
        Me.lbl_nomProAsoOrdComSel = New System.Windows.Forms.Label()
        Me.lbl_corProAsoOrdComSel = New System.Windows.Forms.Label()
        Me.lbl_telProAsoOrdComSel = New System.Windows.Forms.Label()
        Me.lbl_IDProAsoOrdComSel = New System.Windows.Forms.Label()
        Me.pnl_sepOrdComSel = New System.Windows.Forms.Panel()
        Me.lbl_proAsoOrdComSel = New System.Windows.Forms.Label()
        Me.MaskedTextBox2 = New System.Windows.Forms.MaskedTextBox()
        Me.MaskedTextBox3 = New System.Windows.Forms.MaskedTextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.TextBox9 = New System.Windows.Forms.TextBox()
        Me.TextBox10 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lbl_ordComSel = New System.Windows.Forms.Label()
        Me.pnl_agrArt = New System.Windows.Forms.Panel()
        Me.tab_carArt = New System.Windows.Forms.TabControl()
        Me.tab_carArtHab = New System.Windows.Forms.TabPage()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.cmd_carArtCan = New System.Windows.Forms.Button()
        Me.cmd_carArtSig = New System.Windows.Forms.Button()
        Me.txt_cliAsoCarArt = New System.Windows.Forms.TextBox()
        Me.cmb_nroHabCarArt = New System.Windows.Forms.ComboBox()
        Me.cmb_nroPisoCarArt = New System.Windows.Forms.ComboBox()
        Me.lbl_cliAsoCarArt = New System.Windows.Forms.Label()
        Me.lbl_nroHabCarArt = New System.Windows.Forms.Label()
        Me.lbl_nroPisoCarArt = New System.Windows.Forms.Label()
        Me.tab_carArtArt = New System.Windows.Forms.TabPage()
        Me.cmd_carArtFin = New System.Windows.Forms.Button()
        Me.cmd_carArtAtr = New System.Windows.Forms.Button()
        Me.lbl_agrArt = New System.Windows.Forms.Label()
        Me.pnl_agrServ = New System.Windows.Forms.Panel()
        Me.tab_carServ = New System.Windows.Forms.TabControl()
        Me.tab_carServHab = New System.Windows.Forms.TabPage()
        Me.cmd_carSerHabLim = New System.Windows.Forms.Button()
        Me.cmd_carServCan = New System.Windows.Forms.Button()
        Me.cmd_carServSig = New System.Windows.Forms.Button()
        Me.txt_cliAso = New System.Windows.Forms.TextBox()
        Me.cmb_nroHab = New System.Windows.Forms.ComboBox()
        Me.cmb_nroPiso = New System.Windows.Forms.ComboBox()
        Me.lbl_cliAso = New System.Windows.Forms.Label()
        Me.lbl_nroHab = New System.Windows.Forms.Label()
        Me.lbl_nroPiso = New System.Windows.Forms.Label()
        Me.tab_carServServ = New System.Windows.Forms.TabPage()
        Me.cmd_carServAtr = New System.Windows.Forms.Button()
        Me.cmd_carSerFin = New System.Windows.Forms.Button()
        Me.lbl_agrSer = New System.Windows.Forms.Label()
        Me.lbl_concha = New System.Windows.Forms.Label()
        Me.menu_Menu.SuspendLayout()
        Me.pnl_nueAlo.SuspendLayout()
        Me.tab_aloNue.SuspendLayout()
        Me.tab_aloNueDatCli.SuspendLayout()
        Me.tab_aloNueDatHos.SuspendLayout()
        Me.tab_aloNueSelHab.SuspendLayout()
        Me.pnl_busAlo.SuspendLayout()
        Me.tab_busAlo.SuspendLayout()
        Me.tab_busAloDatCli.SuspendLayout()
        Me.tab_busAloAlo.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_busAloSel.SuspendLayout()
        Me.pnl_nueOrdCom.SuspendLayout()
        Me.tab_nueOrdCom.SuspendLayout()
        Me.tab_nueOrdComDatPro.SuspendLayout()
        Me.tab_nueOrdComArt.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tab_nueOrdComRes.SuspendLayout()
        Me.pnl_busOrdCom.SuspendLayout()
        Me.tab_busOrdCom.SuspendLayout()
        Me.tab_busOrdComDatPro.SuspendLayout()
        Me.tab_busOrdComOrdCom.SuspendLayout()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_ordComSel.SuspendLayout()
        Me.pnl_agrArt.SuspendLayout()
        Me.tab_carArt.SuspendLayout()
        Me.tab_carArtHab.SuspendLayout()
        Me.tab_carArtArt.SuspendLayout()
        Me.pnl_agrServ.SuspendLayout()
        Me.tab_carServ.SuspendLayout()
        Me.tab_carServHab.SuspendLayout()
        Me.tab_carServServ.SuspendLayout()
        Me.SuspendLayout()
        '
        'menu_Menu
        '
        Me.menu_Menu.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.menu_Menu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.ArtículosServiciosToolStripMenuItem, Me.ÓrdenesDeComprasToolStripMenuItem, Me.FuncionesAdministrativasToolStripMenuItem})
        Me.menu_Menu.Location = New System.Drawing.Point(0, 0)
        Me.menu_Menu.Name = "menu_Menu"
        Me.menu_Menu.Size = New System.Drawing.Size(546, 25)
        Me.menu_Menu.TabIndex = 0
        Me.menu_Menu.Text = "menu"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoToolStripMenuItem, Me.BuscarToolStripMenuItem})
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(95, 21)
        Me.ToolStripMenuItem1.Text = "Alojamientos"
        '
        'NuevoToolStripMenuItem
        '
        Me.NuevoToolStripMenuItem.Name = "NuevoToolStripMenuItem"
        Me.NuevoToolStripMenuItem.Size = New System.Drawing.Size(114, 22)
        Me.NuevoToolStripMenuItem.Text = "Nuevo"
        '
        'BuscarToolStripMenuItem
        '
        Me.BuscarToolStripMenuItem.Name = "BuscarToolStripMenuItem"
        Me.BuscarToolStripMenuItem.Size = New System.Drawing.Size(114, 22)
        Me.BuscarToolStripMenuItem.Text = "Buscar"
        '
        'ArtículosServiciosToolStripMenuItem
        '
        Me.ArtículosServiciosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AgrearArtículoToolStripMenuItem, Me.AgregarServicioToolStripMenuItem})
        Me.ArtículosServiciosToolStripMenuItem.Name = "ArtículosServiciosToolStripMenuItem"
        Me.ArtículosServiciosToolStripMenuItem.Size = New System.Drawing.Size(126, 21)
        Me.ArtículosServiciosToolStripMenuItem.Text = "Artículos/Servicios"
        '
        'AgrearArtículoToolStripMenuItem
        '
        Me.AgrearArtículoToolStripMenuItem.Name = "AgrearArtículoToolStripMenuItem"
        Me.AgrearArtículoToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.AgrearArtículoToolStripMenuItem.Text = "Cargar Artículo"
        '
        'AgregarServicioToolStripMenuItem
        '
        Me.AgregarServicioToolStripMenuItem.Name = "AgregarServicioToolStripMenuItem"
        Me.AgregarServicioToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.AgregarServicioToolStripMenuItem.Text = "Cargar Servicio"
        '
        'ÓrdenesDeComprasToolStripMenuItem
        '
        Me.ÓrdenesDeComprasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevaToolStripMenuItem, Me.BuscarToolStripMenuItem1})
        Me.ÓrdenesDeComprasToolStripMenuItem.Name = "ÓrdenesDeComprasToolStripMenuItem"
        Me.ÓrdenesDeComprasToolStripMenuItem.Size = New System.Drawing.Size(146, 21)
        Me.ÓrdenesDeComprasToolStripMenuItem.Text = "Órdenes de Compras"
        '
        'NuevaToolStripMenuItem
        '
        Me.NuevaToolStripMenuItem.Name = "NuevaToolStripMenuItem"
        Me.NuevaToolStripMenuItem.Size = New System.Drawing.Size(114, 22)
        Me.NuevaToolStripMenuItem.Text = "Nueva"
        '
        'BuscarToolStripMenuItem1
        '
        Me.BuscarToolStripMenuItem1.Name = "BuscarToolStripMenuItem1"
        Me.BuscarToolStripMenuItem1.Size = New System.Drawing.Size(114, 22)
        Me.BuscarToolStripMenuItem1.Text = "Buscar"
        '
        'FuncionesAdministrativasToolStripMenuItem
        '
        Me.FuncionesAdministrativasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ABMsToolStripMenuItem, Me.InformesToolStripMenuItem, Me.EstadísticasToolStripMenuItem})
        Me.FuncionesAdministrativasToolStripMenuItem.Name = "FuncionesAdministrativasToolStripMenuItem"
        Me.FuncionesAdministrativasToolStripMenuItem.Size = New System.Drawing.Size(169, 21)
        Me.FuncionesAdministrativasToolStripMenuItem.Text = "Funciones Administrativas"
        '
        'ABMsToolStripMenuItem
        '
        Me.ABMsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ABMAlojamientosToolStripMenuItem, Me.ABMClientesToolStripMenuItem, Me.ABMTiposDocumentosToolStripMenuItem})
        Me.ABMsToolStripMenuItem.Name = "ABMsToolStripMenuItem"
        Me.ABMsToolStripMenuItem.Size = New System.Drawing.Size(143, 22)
        Me.ABMsToolStripMenuItem.Text = "ABMs"
        '
        'ABMAlojamientosToolStripMenuItem
        '
        Me.ABMAlojamientosToolStripMenuItem.Name = "ABMAlojamientosToolStripMenuItem"
        Me.ABMAlojamientosToolStripMenuItem.Size = New System.Drawing.Size(216, 22)
        Me.ABMAlojamientosToolStripMenuItem.Text = "ABM Alojamientos"
        '
        'ABMClientesToolStripMenuItem
        '
        Me.ABMClientesToolStripMenuItem.Name = "ABMClientesToolStripMenuItem"
        Me.ABMClientesToolStripMenuItem.Size = New System.Drawing.Size(216, 22)
        Me.ABMClientesToolStripMenuItem.Text = "ABM Clientes"
        '
        'ABMTiposDocumentosToolStripMenuItem
        '
        Me.ABMTiposDocumentosToolStripMenuItem.Name = "ABMTiposDocumentosToolStripMenuItem"
        Me.ABMTiposDocumentosToolStripMenuItem.Size = New System.Drawing.Size(216, 22)
        Me.ABMTiposDocumentosToolStripMenuItem.Text = "ABM Tipos Documentos"
        '
        'InformesToolStripMenuItem
        '
        Me.InformesToolStripMenuItem.Name = "InformesToolStripMenuItem"
        Me.InformesToolStripMenuItem.Size = New System.Drawing.Size(143, 22)
        Me.InformesToolStripMenuItem.Text = "Informes"
        '
        'EstadísticasToolStripMenuItem
        '
        Me.EstadísticasToolStripMenuItem.Name = "EstadísticasToolStripMenuItem"
        Me.EstadísticasToolStripMenuItem.Size = New System.Drawing.Size(143, 22)
        Me.EstadísticasToolStripMenuItem.Text = "Estadísticas"
        '
        'pnl_nueAlo
        '
        Me.pnl_nueAlo.Controls.Add(Me.lbl_nueAlo)
        Me.pnl_nueAlo.Controls.Add(Me.tab_aloNue)
        Me.pnl_nueAlo.Enabled = False
        Me.pnl_nueAlo.Location = New System.Drawing.Point(12, 28)
        Me.pnl_nueAlo.Name = "pnl_nueAlo"
        Me.pnl_nueAlo.Size = New System.Drawing.Size(532, 240)
        Me.pnl_nueAlo.TabIndex = 0
        Me.pnl_nueAlo.Visible = False
        '
        'lbl_nueAlo
        '
        Me.lbl_nueAlo.AutoSize = True
        Me.lbl_nueAlo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_nueAlo.Location = New System.Drawing.Point(3, 3)
        Me.lbl_nueAlo.Name = "lbl_nueAlo"
        Me.lbl_nueAlo.Size = New System.Drawing.Size(139, 16)
        Me.lbl_nueAlo.TabIndex = 0
        Me.lbl_nueAlo.Text = "Nuevo Alojamiento"
        '
        'tab_aloNue
        '
        Me.tab_aloNue.Controls.Add(Me.tab_aloNueDatCli)
        Me.tab_aloNue.Controls.Add(Me.tab_aloNueDatHos)
        Me.tab_aloNue.Controls.Add(Me.tab_aloNueSelHab)
        Me.tab_aloNue.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab_aloNue.Location = New System.Drawing.Point(6, 22)
        Me.tab_aloNue.Name = "tab_aloNue"
        Me.tab_aloNue.SelectedIndex = 0
        Me.tab_aloNue.Size = New System.Drawing.Size(522, 214)
        Me.tab_aloNue.TabIndex = 0
        '
        'tab_aloNueDatCli
        '
        Me.tab_aloNueDatCli.Controls.Add(Me.cmd_nueAloDatCliLim)
        Me.tab_aloNueDatCli.Controls.Add(Me.txt_tel)
        Me.tab_aloNueDatCli.Controls.Add(Me.cmd_canCli)
        Me.tab_aloNueDatCli.Controls.Add(Me.cmd_sigCli)
        Me.tab_aloNueDatCli.Controls.Add(Me.cmd_busCli)
        Me.tab_aloNueDatCli.Controls.Add(Me.txt_fecNac)
        Me.tab_aloNueDatCli.Controls.Add(Me.txt_nom)
        Me.tab_aloNueDatCli.Controls.Add(Me.txt_ape)
        Me.tab_aloNueDatCli.Controls.Add(Me.txt_doc)
        Me.tab_aloNueDatCli.Controls.Add(Me.lbl_fecNac)
        Me.tab_aloNueDatCli.Controls.Add(Me.lbl_sexo)
        Me.tab_aloNueDatCli.Controls.Add(Me.lbl_ape)
        Me.tab_aloNueDatCli.Controls.Add(Me.lbl_nom)
        Me.tab_aloNueDatCli.Controls.Add(Me.lbl_doc)
        Me.tab_aloNueDatCli.Controls.Add(Me.lbl_tipoDoc)
        Me.tab_aloNueDatCli.Controls.Add(Me.cmb_tipoDoc)
        Me.tab_aloNueDatCli.Location = New System.Drawing.Point(4, 25)
        Me.tab_aloNueDatCli.Name = "tab_aloNueDatCli"
        Me.tab_aloNueDatCli.Padding = New System.Windows.Forms.Padding(3)
        Me.tab_aloNueDatCli.Size = New System.Drawing.Size(514, 185)
        Me.tab_aloNueDatCli.TabIndex = 0
        Me.tab_aloNueDatCli.Text = "Datos del Cliente"
        Me.tab_aloNueDatCli.UseVisualStyleBackColor = True
        '
        'cmd_nueAloDatCliLim
        '
        Me.cmd_nueAloDatCliLim.Location = New System.Drawing.Point(9, 146)
        Me.cmd_nueAloDatCliLim.Name = "cmd_nueAloDatCliLim"
        Me.cmd_nueAloDatCliLim.Size = New System.Drawing.Size(72, 28)
        Me.cmd_nueAloDatCliLim.TabIndex = 8
        Me.cmd_nueAloDatCliLim.Text = "Limpiar"
        Me.cmd_nueAloDatCliLim.UseVisualStyleBackColor = True
        '
        'txt_tel
        '
        Me.txt_tel.Location = New System.Drawing.Point(145, 120)
        Me.txt_tel.Name = "txt_tel"
        Me.txt_tel.Size = New System.Drawing.Size(100, 22)
        Me.txt_tel.TabIndex = 7
        '
        'cmd_canCli
        '
        Me.cmd_canCli.Location = New System.Drawing.Point(331, 146)
        Me.cmd_canCli.Name = "cmd_canCli"
        Me.cmd_canCli.Size = New System.Drawing.Size(72, 28)
        Me.cmd_canCli.TabIndex = 9
        Me.cmd_canCli.Text = "Cancelar"
        Me.cmd_canCli.UseVisualStyleBackColor = True
        '
        'cmd_sigCli
        '
        Me.cmd_sigCli.Location = New System.Drawing.Point(409, 146)
        Me.cmd_sigCli.Name = "cmd_sigCli"
        Me.cmd_sigCli.Size = New System.Drawing.Size(72, 28)
        Me.cmd_sigCli.TabIndex = 10
        Me.cmd_sigCli.Text = "Siguiente"
        Me.cmd_sigCli.UseVisualStyleBackColor = True
        '
        'cmd_busCli
        '
        Me.cmd_busCli.Location = New System.Drawing.Point(423, 6)
        Me.cmd_busCli.Name = "cmd_busCli"
        Me.cmd_busCli.Size = New System.Drawing.Size(58, 22)
        Me.cmd_busCli.TabIndex = 3
        Me.cmd_busCli.Text = "Buscar"
        Me.cmd_busCli.UseVisualStyleBackColor = True
        '
        'txt_fecNac
        '
        Me.txt_fecNac.Location = New System.Drawing.Point(145, 92)
        Me.txt_fecNac.Mask = "00/00/0000"
        Me.txt_fecNac.Name = "txt_fecNac"
        Me.txt_fecNac.Size = New System.Drawing.Size(66, 22)
        Me.txt_fecNac.TabIndex = 6
        Me.txt_fecNac.ValidatingType = GetType(Date)
        '
        'txt_nom
        '
        Me.txt_nom.Location = New System.Drawing.Point(145, 64)
        Me.txt_nom.Name = "txt_nom"
        Me.txt_nom.Size = New System.Drawing.Size(272, 22)
        Me.txt_nom.TabIndex = 5
        '
        'txt_ape
        '
        Me.txt_ape.Location = New System.Drawing.Point(145, 36)
        Me.txt_ape.Name = "txt_ape"
        Me.txt_ape.Size = New System.Drawing.Size(272, 22)
        Me.txt_ape.TabIndex = 4
        '
        'txt_doc
        '
        Me.txt_doc.Location = New System.Drawing.Point(355, 6)
        Me.txt_doc.Mask = "99999999"
        Me.txt_doc.Name = "txt_doc"
        Me.txt_doc.Size = New System.Drawing.Size(62, 22)
        Me.txt_doc.TabIndex = 2
        '
        'lbl_fecNac
        '
        Me.lbl_fecNac.AutoSize = True
        Me.lbl_fecNac.Location = New System.Drawing.Point(6, 95)
        Me.lbl_fecNac.Name = "lbl_fecNac"
        Me.lbl_fecNac.Size = New System.Drawing.Size(133, 16)
        Me.lbl_fecNac.TabIndex = 35
        Me.lbl_fecNac.Text = "Fecha de nacimiento"
        '
        'lbl_sexo
        '
        Me.lbl_sexo.AutoSize = True
        Me.lbl_sexo.Location = New System.Drawing.Point(77, 123)
        Me.lbl_sexo.Name = "lbl_sexo"
        Me.lbl_sexo.Size = New System.Drawing.Size(62, 16)
        Me.lbl_sexo.TabIndex = 34
        Me.lbl_sexo.Text = "Teléfono"
        '
        'lbl_ape
        '
        Me.lbl_ape.AutoSize = True
        Me.lbl_ape.Location = New System.Drawing.Point(81, 39)
        Me.lbl_ape.Name = "lbl_ape"
        Me.lbl_ape.Size = New System.Drawing.Size(58, 16)
        Me.lbl_ape.TabIndex = 33
        Me.lbl_ape.Text = "Apellido"
        '
        'lbl_nom
        '
        Me.lbl_nom.AutoSize = True
        Me.lbl_nom.Location = New System.Drawing.Point(82, 67)
        Me.lbl_nom.Name = "lbl_nom"
        Me.lbl_nom.Size = New System.Drawing.Size(57, 16)
        Me.lbl_nom.TabIndex = 32
        Me.lbl_nom.Text = "Nombre"
        '
        'lbl_doc
        '
        Me.lbl_doc.AutoSize = True
        Me.lbl_doc.Location = New System.Drawing.Point(272, 9)
        Me.lbl_doc.Name = "lbl_doc"
        Me.lbl_doc.Size = New System.Drawing.Size(77, 16)
        Me.lbl_doc.TabIndex = 31
        Me.lbl_doc.Text = "Documento"
        '
        'lbl_tipoDoc
        '
        Me.lbl_tipoDoc.AutoSize = True
        Me.lbl_tipoDoc.Location = New System.Drawing.Point(33, 9)
        Me.lbl_tipoDoc.Name = "lbl_tipoDoc"
        Me.lbl_tipoDoc.Size = New System.Drawing.Size(106, 16)
        Me.lbl_tipoDoc.TabIndex = 30
        Me.lbl_tipoDoc.Text = "Tipo documento"
        '
        'cmb_tipoDoc
        '
        Me.cmb_tipoDoc.FormattingEnabled = True
        Me.cmb_tipoDoc.Location = New System.Drawing.Point(145, 6)
        Me.cmb_tipoDoc.Name = "cmb_tipoDoc"
        Me.cmb_tipoDoc.Size = New System.Drawing.Size(121, 24)
        Me.cmb_tipoDoc.TabIndex = 1
        '
        'tab_aloNueDatHos
        '
        Me.tab_aloNueDatHos.Controls.Add(Me.cmd_nueAloDatHosLim)
        Me.tab_aloNueDatHos.Controls.Add(Me.cmd_atrHos)
        Me.tab_aloNueDatHos.Controls.Add(Me.cmd_sigHos)
        Me.tab_aloNueDatHos.Controls.Add(Me.cmb_tipHab)
        Me.tab_aloNueDatHos.Controls.Add(Me.cmb_canPer)
        Me.tab_aloNueDatHos.Controls.Add(Me.txt_fecHas)
        Me.tab_aloNueDatHos.Controls.Add(Me.txt_fecDes)
        Me.tab_aloNueDatHos.Controls.Add(Me.lbl_tipHab)
        Me.tab_aloNueDatHos.Controls.Add(Me.lbl_canPer)
        Me.tab_aloNueDatHos.Controls.Add(Me.lbl_fecHas)
        Me.tab_aloNueDatHos.Controls.Add(Me.lbl_fecDes)
        Me.tab_aloNueDatHos.Location = New System.Drawing.Point(4, 25)
        Me.tab_aloNueDatHos.Name = "tab_aloNueDatHos"
        Me.tab_aloNueDatHos.Padding = New System.Windows.Forms.Padding(3)
        Me.tab_aloNueDatHos.Size = New System.Drawing.Size(514, 185)
        Me.tab_aloNueDatHos.TabIndex = 1
        Me.tab_aloNueDatHos.Text = "Datos del Hospedaje"
        Me.tab_aloNueDatHos.UseVisualStyleBackColor = True
        '
        'cmd_nueAloDatHosLim
        '
        Me.cmd_nueAloDatHosLim.Location = New System.Drawing.Point(9, 146)
        Me.cmd_nueAloDatHosLim.Name = "cmd_nueAloDatHosLim"
        Me.cmd_nueAloDatHosLim.Size = New System.Drawing.Size(72, 28)
        Me.cmd_nueAloDatHosLim.TabIndex = 5
        Me.cmd_nueAloDatHosLim.Text = "Limpiar"
        Me.cmd_nueAloDatHosLim.UseVisualStyleBackColor = True
        '
        'cmd_atrHos
        '
        Me.cmd_atrHos.Location = New System.Drawing.Point(331, 146)
        Me.cmd_atrHos.Name = "cmd_atrHos"
        Me.cmd_atrHos.Size = New System.Drawing.Size(72, 28)
        Me.cmd_atrHos.TabIndex = 6
        Me.cmd_atrHos.Text = "Atrás"
        Me.cmd_atrHos.UseVisualStyleBackColor = True
        '
        'cmd_sigHos
        '
        Me.cmd_sigHos.Location = New System.Drawing.Point(409, 146)
        Me.cmd_sigHos.Name = "cmd_sigHos"
        Me.cmd_sigHos.Size = New System.Drawing.Size(72, 28)
        Me.cmd_sigHos.TabIndex = 7
        Me.cmd_sigHos.Text = "Siguiente"
        Me.cmd_sigHos.UseVisualStyleBackColor = True
        '
        'cmb_tipHab
        '
        Me.cmb_tipHab.FormattingEnabled = True
        Me.cmb_tipHab.Location = New System.Drawing.Point(153, 92)
        Me.cmb_tipHab.Name = "cmb_tipHab"
        Me.cmb_tipHab.Size = New System.Drawing.Size(111, 24)
        Me.cmb_tipHab.TabIndex = 4
        '
        'cmb_canPer
        '
        Me.cmb_canPer.FormattingEnabled = True
        Me.cmb_canPer.Location = New System.Drawing.Point(153, 62)
        Me.cmb_canPer.Name = "cmb_canPer"
        Me.cmb_canPer.Size = New System.Drawing.Size(40, 24)
        Me.cmb_canPer.TabIndex = 3
        '
        'txt_fecHas
        '
        Me.txt_fecHas.Location = New System.Drawing.Point(153, 34)
        Me.txt_fecHas.Mask = "00/00/0000"
        Me.txt_fecHas.Name = "txt_fecHas"
        Me.txt_fecHas.Size = New System.Drawing.Size(71, 22)
        Me.txt_fecHas.TabIndex = 2
        Me.txt_fecHas.ValidatingType = GetType(Date)
        '
        'txt_fecDes
        '
        Me.txt_fecDes.Location = New System.Drawing.Point(153, 6)
        Me.txt_fecDes.Mask = "00/00/0000"
        Me.txt_fecDes.Name = "txt_fecDes"
        Me.txt_fecDes.Size = New System.Drawing.Size(71, 22)
        Me.txt_fecDes.TabIndex = 1
        Me.txt_fecDes.ValidatingType = GetType(Date)
        '
        'lbl_tipHab
        '
        Me.lbl_tipHab.AutoSize = True
        Me.lbl_tipHab.Location = New System.Drawing.Point(24, 95)
        Me.lbl_tipHab.Name = "lbl_tipHab"
        Me.lbl_tipHab.Size = New System.Drawing.Size(123, 16)
        Me.lbl_tipHab.TabIndex = 13
        Me.lbl_tipHab.Text = "Tipo de Habitación"
        '
        'lbl_canPer
        '
        Me.lbl_canPer.AutoSize = True
        Me.lbl_canPer.Location = New System.Drawing.Point(6, 65)
        Me.lbl_canPer.Name = "lbl_canPer"
        Me.lbl_canPer.Size = New System.Drawing.Size(141, 16)
        Me.lbl_canPer.TabIndex = 11
        Me.lbl_canPer.Text = "Cantidad de personas"
        '
        'lbl_fecHas
        '
        Me.lbl_fecHas.AutoSize = True
        Me.lbl_fecHas.Location = New System.Drawing.Point(65, 37)
        Me.lbl_fecHas.Name = "lbl_fecHas"
        Me.lbl_fecHas.Size = New System.Drawing.Size(82, 16)
        Me.lbl_fecHas.TabIndex = 9
        Me.lbl_fecHas.Text = "Fecha hasta"
        '
        'lbl_fecDes
        '
        Me.lbl_fecDes.AutoSize = True
        Me.lbl_fecDes.Location = New System.Drawing.Point(59, 9)
        Me.lbl_fecDes.Name = "lbl_fecDes"
        Me.lbl_fecDes.Size = New System.Drawing.Size(88, 16)
        Me.lbl_fecDes.TabIndex = 8
        Me.lbl_fecDes.Text = "Fecha desde"
        '
        'tab_aloNueSelHab
        '
        Me.tab_aloNueSelHab.Controls.Add(Me.cam_atrHab)
        Me.tab_aloNueSelHab.Controls.Add(Me.cmd_aceHab)
        Me.tab_aloNueSelHab.Location = New System.Drawing.Point(4, 25)
        Me.tab_aloNueSelHab.Name = "tab_aloNueSelHab"
        Me.tab_aloNueSelHab.Padding = New System.Windows.Forms.Padding(3)
        Me.tab_aloNueSelHab.Size = New System.Drawing.Size(514, 185)
        Me.tab_aloNueSelHab.TabIndex = 2
        Me.tab_aloNueSelHab.Text = "Selección de Habitación"
        Me.tab_aloNueSelHab.UseVisualStyleBackColor = True
        '
        'cam_atrHab
        '
        Me.cam_atrHab.Location = New System.Drawing.Point(331, 146)
        Me.cam_atrHab.Name = "cam_atrHab"
        Me.cam_atrHab.Size = New System.Drawing.Size(72, 28)
        Me.cam_atrHab.TabIndex = 1
        Me.cam_atrHab.Text = "Atrás"
        Me.cam_atrHab.UseVisualStyleBackColor = True
        '
        'cmd_aceHab
        '
        Me.cmd_aceHab.Location = New System.Drawing.Point(409, 146)
        Me.cmd_aceHab.Name = "cmd_aceHab"
        Me.cmd_aceHab.Size = New System.Drawing.Size(72, 28)
        Me.cmd_aceHab.TabIndex = 2
        Me.cmd_aceHab.Text = "Aceptar"
        Me.cmd_aceHab.UseVisualStyleBackColor = True
        '
        'pnl_busAlo
        '
        Me.pnl_busAlo.Controls.Add(Me.lbl_busAlo)
        Me.pnl_busAlo.Controls.Add(Me.tab_busAlo)
        Me.pnl_busAlo.Controls.Add(Me.pnl_busAloSel)
        Me.pnl_busAlo.Enabled = False
        Me.pnl_busAlo.Location = New System.Drawing.Point(12, 28)
        Me.pnl_busAlo.Name = "pnl_busAlo"
        Me.pnl_busAlo.Size = New System.Drawing.Size(532, 240)
        Me.pnl_busAlo.TabIndex = 0
        Me.pnl_busAlo.Visible = False
        '
        'lbl_busAlo
        '
        Me.lbl_busAlo.AutoSize = True
        Me.lbl_busAlo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_busAlo.Location = New System.Drawing.Point(3, 3)
        Me.lbl_busAlo.Name = "lbl_busAlo"
        Me.lbl_busAlo.Size = New System.Drawing.Size(142, 16)
        Me.lbl_busAlo.TabIndex = 0
        Me.lbl_busAlo.Text = "Buscar Alojamiento"
        '
        'tab_busAlo
        '
        Me.tab_busAlo.Controls.Add(Me.tab_busAloDatCli)
        Me.tab_busAlo.Controls.Add(Me.tab_busAloAlo)
        Me.tab_busAlo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab_busAlo.Location = New System.Drawing.Point(6, 22)
        Me.tab_busAlo.Name = "tab_busAlo"
        Me.tab_busAlo.SelectedIndex = 0
        Me.tab_busAlo.Size = New System.Drawing.Size(522, 214)
        Me.tab_busAlo.TabIndex = 0
        '
        'tab_busAloDatCli
        '
        Me.tab_busAloDatCli.Controls.Add(Me.cmd_busAloLim)
        Me.tab_busAloDatCli.Controls.Add(Me.cmd_busAloCan)
        Me.tab_busAloDatCli.Controls.Add(Me.cmd_busAloDatCliSig)
        Me.tab_busAloDatCli.Controls.Add(Me.cmd_busCliBusAlo)
        Me.tab_busAloDatCli.Controls.Add(Me.txt_nomBusAlo)
        Me.tab_busAloDatCli.Controls.Add(Me.txt_apeBusAlo)
        Me.tab_busAloDatCli.Controls.Add(Me.txt_docBusAlo)
        Me.tab_busAloDatCli.Controls.Add(Me.lbl_apeBusAlo)
        Me.tab_busAloDatCli.Controls.Add(Me.lbl_nomBusAlo)
        Me.tab_busAloDatCli.Controls.Add(Me.lbl_docBusAlo)
        Me.tab_busAloDatCli.Controls.Add(Me.lbl_tipDocBusAlo)
        Me.tab_busAloDatCli.Controls.Add(Me.cmb_tipDocBusAlo)
        Me.tab_busAloDatCli.Location = New System.Drawing.Point(4, 25)
        Me.tab_busAloDatCli.Name = "tab_busAloDatCli"
        Me.tab_busAloDatCli.Padding = New System.Windows.Forms.Padding(3)
        Me.tab_busAloDatCli.Size = New System.Drawing.Size(514, 185)
        Me.tab_busAloDatCli.TabIndex = 0
        Me.tab_busAloDatCli.Text = "Datos del Cliente"
        Me.tab_busAloDatCli.UseVisualStyleBackColor = True
        '
        'cmd_busAloLim
        '
        Me.cmd_busAloLim.Location = New System.Drawing.Point(9, 146)
        Me.cmd_busAloLim.Name = "cmd_busAloLim"
        Me.cmd_busAloLim.Size = New System.Drawing.Size(72, 28)
        Me.cmd_busAloLim.TabIndex = 6
        Me.cmd_busAloLim.Text = "Limpiar"
        Me.cmd_busAloLim.UseVisualStyleBackColor = True
        '
        'cmd_busAloCan
        '
        Me.cmd_busAloCan.Location = New System.Drawing.Point(331, 146)
        Me.cmd_busAloCan.Name = "cmd_busAloCan"
        Me.cmd_busAloCan.Size = New System.Drawing.Size(72, 28)
        Me.cmd_busAloCan.TabIndex = 7
        Me.cmd_busAloCan.Text = "Cancelar"
        Me.cmd_busAloCan.UseVisualStyleBackColor = True
        '
        'cmd_busAloDatCliSig
        '
        Me.cmd_busAloDatCliSig.Location = New System.Drawing.Point(409, 146)
        Me.cmd_busAloDatCliSig.Name = "cmd_busAloDatCliSig"
        Me.cmd_busAloDatCliSig.Size = New System.Drawing.Size(72, 28)
        Me.cmd_busAloDatCliSig.TabIndex = 8
        Me.cmd_busAloDatCliSig.Text = "Siguiente"
        Me.cmd_busAloDatCliSig.UseVisualStyleBackColor = True
        '
        'cmd_busCliBusAlo
        '
        Me.cmd_busCliBusAlo.Location = New System.Drawing.Point(423, 6)
        Me.cmd_busCliBusAlo.Name = "cmd_busCliBusAlo"
        Me.cmd_busCliBusAlo.Size = New System.Drawing.Size(58, 22)
        Me.cmd_busCliBusAlo.TabIndex = 3
        Me.cmd_busCliBusAlo.Text = "Buscar"
        Me.cmd_busCliBusAlo.UseVisualStyleBackColor = True
        '
        'txt_nomBusAlo
        '
        Me.txt_nomBusAlo.Location = New System.Drawing.Point(145, 64)
        Me.txt_nomBusAlo.Name = "txt_nomBusAlo"
        Me.txt_nomBusAlo.ReadOnly = True
        Me.txt_nomBusAlo.Size = New System.Drawing.Size(272, 22)
        Me.txt_nomBusAlo.TabIndex = 5
        '
        'txt_apeBusAlo
        '
        Me.txt_apeBusAlo.Location = New System.Drawing.Point(145, 36)
        Me.txt_apeBusAlo.Name = "txt_apeBusAlo"
        Me.txt_apeBusAlo.ReadOnly = True
        Me.txt_apeBusAlo.Size = New System.Drawing.Size(272, 22)
        Me.txt_apeBusAlo.TabIndex = 4
        '
        'txt_docBusAlo
        '
        Me.txt_docBusAlo.Location = New System.Drawing.Point(355, 6)
        Me.txt_docBusAlo.Mask = "99999999"
        Me.txt_docBusAlo.Name = "txt_docBusAlo"
        Me.txt_docBusAlo.Size = New System.Drawing.Size(62, 22)
        Me.txt_docBusAlo.TabIndex = 2
        '
        'lbl_apeBusAlo
        '
        Me.lbl_apeBusAlo.AutoSize = True
        Me.lbl_apeBusAlo.Location = New System.Drawing.Point(81, 39)
        Me.lbl_apeBusAlo.Name = "lbl_apeBusAlo"
        Me.lbl_apeBusAlo.Size = New System.Drawing.Size(58, 16)
        Me.lbl_apeBusAlo.TabIndex = 42
        Me.lbl_apeBusAlo.Text = "Apellido"
        '
        'lbl_nomBusAlo
        '
        Me.lbl_nomBusAlo.AutoSize = True
        Me.lbl_nomBusAlo.Location = New System.Drawing.Point(77, 67)
        Me.lbl_nomBusAlo.Name = "lbl_nomBusAlo"
        Me.lbl_nomBusAlo.Size = New System.Drawing.Size(57, 16)
        Me.lbl_nomBusAlo.TabIndex = 41
        Me.lbl_nomBusAlo.Text = "Nombre"
        '
        'lbl_docBusAlo
        '
        Me.lbl_docBusAlo.AutoSize = True
        Me.lbl_docBusAlo.Location = New System.Drawing.Point(272, 9)
        Me.lbl_docBusAlo.Name = "lbl_docBusAlo"
        Me.lbl_docBusAlo.Size = New System.Drawing.Size(77, 16)
        Me.lbl_docBusAlo.TabIndex = 40
        Me.lbl_docBusAlo.Text = "Documento"
        '
        'lbl_tipDocBusAlo
        '
        Me.lbl_tipDocBusAlo.AutoSize = True
        Me.lbl_tipDocBusAlo.Location = New System.Drawing.Point(33, 9)
        Me.lbl_tipDocBusAlo.Name = "lbl_tipDocBusAlo"
        Me.lbl_tipDocBusAlo.Size = New System.Drawing.Size(106, 16)
        Me.lbl_tipDocBusAlo.TabIndex = 39
        Me.lbl_tipDocBusAlo.Text = "Tipo documento"
        '
        'cmb_tipDocBusAlo
        '
        Me.cmb_tipDocBusAlo.FormattingEnabled = True
        Me.cmb_tipDocBusAlo.Location = New System.Drawing.Point(145, 6)
        Me.cmb_tipDocBusAlo.Name = "cmb_tipDocBusAlo"
        Me.cmb_tipDocBusAlo.Size = New System.Drawing.Size(121, 24)
        Me.cmb_tipDocBusAlo.TabIndex = 1
        '
        'tab_busAloAlo
        '
        Me.tab_busAloAlo.Controls.Add(Me.cmd_clickEnGrilla)
        Me.tab_busAloAlo.Controls.Add(Me.cmd_busAloAtr)
        Me.tab_busAloAlo.Controls.Add(Me.DataGridView1)
        Me.tab_busAloAlo.Controls.Add(Me.cmd_busAloFin)
        Me.tab_busAloAlo.Location = New System.Drawing.Point(4, 25)
        Me.tab_busAloAlo.Name = "tab_busAloAlo"
        Me.tab_busAloAlo.Padding = New System.Windows.Forms.Padding(3)
        Me.tab_busAloAlo.Size = New System.Drawing.Size(514, 185)
        Me.tab_busAloAlo.TabIndex = 1
        Me.tab_busAloAlo.Text = "Alojamientos"
        Me.tab_busAloAlo.UseVisualStyleBackColor = True
        '
        'cmd_clickEnGrilla
        '
        Me.cmd_clickEnGrilla.Location = New System.Drawing.Point(7, 151)
        Me.cmd_clickEnGrilla.Name = "cmd_clickEnGrilla"
        Me.cmd_clickEnGrilla.Size = New System.Drawing.Size(115, 23)
        Me.cmd_clickEnGrilla.TabIndex = 51
        Me.cmd_clickEnGrilla.Text = "Click en Grilla"
        Me.cmd_clickEnGrilla.UseVisualStyleBackColor = True
        '
        'cmd_busAloAtr
        '
        Me.cmd_busAloAtr.Location = New System.Drawing.Point(331, 146)
        Me.cmd_busAloAtr.Name = "cmd_busAloAtr"
        Me.cmd_busAloAtr.Size = New System.Drawing.Size(72, 28)
        Me.cmd_busAloAtr.TabIndex = 1
        Me.cmd_busAloAtr.Text = "Atrás"
        Me.cmd_busAloAtr.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.clm_piso, Me.clm_hab, Me.clm_fecIni, Me.clm_fecHas})
        Me.DataGridView1.Location = New System.Drawing.Point(7, 6)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(501, 136)
        Me.DataGridView1.TabIndex = 0
        '
        'clm_piso
        '
        Me.clm_piso.HeaderText = "Piso"
        Me.clm_piso.Name = "clm_piso"
        Me.clm_piso.ReadOnly = True
        Me.clm_piso.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.clm_piso.Width = 50
        '
        'clm_hab
        '
        Me.clm_hab.HeaderText = "Habitación"
        Me.clm_hab.Name = "clm_hab"
        Me.clm_hab.ReadOnly = True
        Me.clm_hab.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.clm_hab.Width = 80
        '
        'clm_fecIni
        '
        Me.clm_fecIni.HeaderText = "Fecha inicio"
        Me.clm_fecIni.Name = "clm_fecIni"
        Me.clm_fecIni.ReadOnly = True
        Me.clm_fecIni.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.clm_fecIni.Width = 110
        '
        'clm_fecHas
        '
        Me.clm_fecHas.HeaderText = "Fecha fin"
        Me.clm_fecHas.Name = "clm_fecHas"
        Me.clm_fecHas.ReadOnly = True
        Me.clm_fecHas.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.clm_fecHas.Width = 110
        '
        'cmd_busAloFin
        '
        Me.cmd_busAloFin.Location = New System.Drawing.Point(409, 146)
        Me.cmd_busAloFin.Name = "cmd_busAloFin"
        Me.cmd_busAloFin.Size = New System.Drawing.Size(72, 28)
        Me.cmd_busAloFin.TabIndex = 2
        Me.cmd_busAloFin.Text = "Finalizar"
        Me.cmd_busAloFin.UseVisualStyleBackColor = True
        '
        'pnl_busAloSel
        '
        Me.pnl_busAloSel.BackColor = System.Drawing.Color.White
        Me.pnl_busAloSel.Controls.Add(Me.cmd_atrAloSel)
        Me.pnl_busAloSel.Controls.Add(Me.cmd_anuAloSel)
        Me.pnl_busAloSel.Controls.Add(Me.cmd_modAloSel)
        Me.pnl_busAloSel.Controls.Add(Me.txt_tipoDocAloSel)
        Me.pnl_busAloSel.Controls.Add(Me.txt_apeAloSel)
        Me.pnl_busAloSel.Controls.Add(Me.txt_nomAloSel)
        Me.pnl_busAloSel.Controls.Add(Me.txt_docAloSel)
        Me.pnl_busAloSel.Controls.Add(Me.lbl_nomAloSel)
        Me.pnl_busAloSel.Controls.Add(Me.lbl_apeAloSel)
        Me.pnl_busAloSel.Controls.Add(Me.lbl_docAloSel)
        Me.pnl_busAloSel.Controls.Add(Me.lbl_tipoDocAloSel)
        Me.pnl_busAloSel.Controls.Add(Me.pnl_sepAloSel)
        Me.pnl_busAloSel.Controls.Add(Me.lbl_cliAsoAloSel)
        Me.pnl_busAloSel.Controls.Add(Me.txt_fecHasAloSel)
        Me.pnl_busAloSel.Controls.Add(Me.txt_fecDesAloSel)
        Me.pnl_busAloSel.Controls.Add(Me.txt_IDAloSel)
        Me.pnl_busAloSel.Controls.Add(Me.txt_preDiaAloSel)
        Me.pnl_busAloSel.Controls.Add(Me.txt_nroHabAloSel)
        Me.pnl_busAloSel.Controls.Add(Me.txt_canPerAloSel)
        Me.pnl_busAloSel.Controls.Add(Me.txt_nroPisoAloSel)
        Me.pnl_busAloSel.Controls.Add(Me.lbl_preDiaAloSel)
        Me.pnl_busAloSel.Controls.Add(Me.lbl_fecHasAloSel)
        Me.pnl_busAloSel.Controls.Add(Me.lbl_fecDesAloSel)
        Me.pnl_busAloSel.Controls.Add(Me.lbl_canPerAloSel)
        Me.pnl_busAloSel.Controls.Add(Me.lbl_nroHabAloSel)
        Me.pnl_busAloSel.Controls.Add(Me.lbl_nroPisoAloSel)
        Me.pnl_busAloSel.Controls.Add(Me.lbl_IDAloSel)
        Me.pnl_busAloSel.Controls.Add(Me.lbl_aloSel)
        Me.pnl_busAloSel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnl_busAloSel.Location = New System.Drawing.Point(6, 22)
        Me.pnl_busAloSel.Name = "pnl_busAloSel"
        Me.pnl_busAloSel.Size = New System.Drawing.Size(522, 218)
        Me.pnl_busAloSel.TabIndex = 1
        '
        'cmd_atrAloSel
        '
        Me.cmd_atrAloSel.Location = New System.Drawing.Point(427, 91)
        Me.cmd_atrAloSel.Name = "cmd_atrAloSel"
        Me.cmd_atrAloSel.Size = New System.Drawing.Size(72, 28)
        Me.cmd_atrAloSel.TabIndex = 10
        Me.cmd_atrAloSel.Text = "Atrás"
        Me.cmd_atrAloSel.UseVisualStyleBackColor = True
        '
        'cmd_anuAloSel
        '
        Me.cmd_anuAloSel.Location = New System.Drawing.Point(427, 57)
        Me.cmd_anuAloSel.Name = "cmd_anuAloSel"
        Me.cmd_anuAloSel.Size = New System.Drawing.Size(72, 28)
        Me.cmd_anuAloSel.TabIndex = 9
        Me.cmd_anuAloSel.Text = "Anular"
        Me.cmd_anuAloSel.UseVisualStyleBackColor = True
        '
        'cmd_modAloSel
        '
        Me.cmd_modAloSel.Location = New System.Drawing.Point(427, 23)
        Me.cmd_modAloSel.Name = "cmd_modAloSel"
        Me.cmd_modAloSel.Size = New System.Drawing.Size(72, 28)
        Me.cmd_modAloSel.TabIndex = 8
        Me.cmd_modAloSel.Text = "Modificar"
        Me.cmd_modAloSel.UseVisualStyleBackColor = True
        '
        'txt_tipoDocAloSel
        '
        Me.txt_tipoDocAloSel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_tipoDocAloSel.Location = New System.Drawing.Point(102, 168)
        Me.txt_tipoDocAloSel.Name = "txt_tipoDocAloSel"
        Me.txt_tipoDocAloSel.ReadOnly = True
        Me.txt_tipoDocAloSel.Size = New System.Drawing.Size(95, 20)
        Me.txt_tipoDocAloSel.TabIndex = 11
        '
        'txt_apeAloSel
        '
        Me.txt_apeAloSel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_apeAloSel.Location = New System.Drawing.Point(253, 195)
        Me.txt_apeAloSel.Name = "txt_apeAloSel"
        Me.txt_apeAloSel.ReadOnly = True
        Me.txt_apeAloSel.Size = New System.Drawing.Size(259, 20)
        Me.txt_apeAloSel.TabIndex = 14
        '
        'txt_nomAloSel
        '
        Me.txt_nomAloSel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_nomAloSel.Location = New System.Drawing.Point(253, 168)
        Me.txt_nomAloSel.Name = "txt_nomAloSel"
        Me.txt_nomAloSel.ReadOnly = True
        Me.txt_nomAloSel.Size = New System.Drawing.Size(259, 20)
        Me.txt_nomAloSel.TabIndex = 13
        '
        'txt_docAloSel
        '
        Me.txt_docAloSel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_docAloSel.Location = New System.Drawing.Point(102, 195)
        Me.txt_docAloSel.Mask = "99999999"
        Me.txt_docAloSel.Name = "txt_docAloSel"
        Me.txt_docAloSel.ReadOnly = True
        Me.txt_docAloSel.Size = New System.Drawing.Size(65, 20)
        Me.txt_docAloSel.TabIndex = 12
        '
        'lbl_nomAloSel
        '
        Me.lbl_nomAloSel.AutoSize = True
        Me.lbl_nomAloSel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_nomAloSel.Location = New System.Drawing.Point(203, 171)
        Me.lbl_nomAloSel.Name = "lbl_nomAloSel"
        Me.lbl_nomAloSel.Size = New System.Drawing.Size(44, 13)
        Me.lbl_nomAloSel.TabIndex = 22
        Me.lbl_nomAloSel.Text = "Nombre"
        '
        'lbl_apeAloSel
        '
        Me.lbl_apeAloSel.AutoSize = True
        Me.lbl_apeAloSel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_apeAloSel.Location = New System.Drawing.Point(203, 197)
        Me.lbl_apeAloSel.Name = "lbl_apeAloSel"
        Me.lbl_apeAloSel.Size = New System.Drawing.Size(44, 13)
        Me.lbl_apeAloSel.TabIndex = 21
        Me.lbl_apeAloSel.Text = "Apellido"
        '
        'lbl_docAloSel
        '
        Me.lbl_docAloSel.AutoSize = True
        Me.lbl_docAloSel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_docAloSel.Location = New System.Drawing.Point(34, 198)
        Me.lbl_docAloSel.Name = "lbl_docAloSel"
        Me.lbl_docAloSel.Size = New System.Drawing.Size(62, 13)
        Me.lbl_docAloSel.TabIndex = 20
        Me.lbl_docAloSel.Text = "Documento"
        '
        'lbl_tipoDocAloSel
        '
        Me.lbl_tipoDocAloSel.AutoSize = True
        Me.lbl_tipoDocAloSel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_tipoDocAloSel.Location = New System.Drawing.Point(10, 171)
        Me.lbl_tipoDocAloSel.Name = "lbl_tipoDocAloSel"
        Me.lbl_tipoDocAloSel.Size = New System.Drawing.Size(86, 13)
        Me.lbl_tipoDocAloSel.TabIndex = 19
        Me.lbl_tipoDocAloSel.Text = "Tipo Documento"
        '
        'pnl_sepAloSel
        '
        Me.pnl_sepAloSel.BackColor = System.Drawing.Color.DimGray
        Me.pnl_sepAloSel.Location = New System.Drawing.Point(0, 135)
        Me.pnl_sepAloSel.Name = "pnl_sepAloSel"
        Me.pnl_sepAloSel.Size = New System.Drawing.Size(522, 10)
        Me.pnl_sepAloSel.TabIndex = 18
        '
        'lbl_cliAsoAloSel
        '
        Me.lbl_cliAsoAloSel.AutoSize = True
        Me.lbl_cliAsoAloSel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_cliAsoAloSel.Location = New System.Drawing.Point(3, 148)
        Me.lbl_cliAsoAloSel.Name = "lbl_cliAsoAloSel"
        Me.lbl_cliAsoAloSel.Size = New System.Drawing.Size(110, 16)
        Me.lbl_cliAsoAloSel.TabIndex = 17
        Me.lbl_cliAsoAloSel.Text = "Cliente Asociado"
        '
        'txt_fecHasAloSel
        '
        Me.txt_fecHasAloSel.Location = New System.Drawing.Point(311, 51)
        Me.txt_fecHasAloSel.Mask = "00/00/0000"
        Me.txt_fecHasAloSel.Name = "txt_fecHasAloSel"
        Me.txt_fecHasAloSel.ReadOnly = True
        Me.txt_fecHasAloSel.Size = New System.Drawing.Size(70, 22)
        Me.txt_fecHasAloSel.TabIndex = 6
        Me.txt_fecHasAloSel.ValidatingType = GetType(Date)
        '
        'txt_fecDesAloSel
        '
        Me.txt_fecDesAloSel.Location = New System.Drawing.Point(311, 23)
        Me.txt_fecDesAloSel.Mask = "00/00/0000"
        Me.txt_fecDesAloSel.Name = "txt_fecDesAloSel"
        Me.txt_fecDesAloSel.ReadOnly = True
        Me.txt_fecDesAloSel.Size = New System.Drawing.Size(70, 22)
        Me.txt_fecDesAloSel.TabIndex = 5
        Me.txt_fecDesAloSel.ValidatingType = GetType(Date)
        '
        'txt_IDAloSel
        '
        Me.txt_IDAloSel.Location = New System.Drawing.Point(158, 23)
        Me.txt_IDAloSel.Name = "txt_IDAloSel"
        Me.txt_IDAloSel.ReadOnly = True
        Me.txt_IDAloSel.Size = New System.Drawing.Size(51, 22)
        Me.txt_IDAloSel.TabIndex = 1
        '
        'txt_preDiaAloSel
        '
        Me.txt_preDiaAloSel.Location = New System.Drawing.Point(311, 79)
        Me.txt_preDiaAloSel.Name = "txt_preDiaAloSel"
        Me.txt_preDiaAloSel.ReadOnly = True
        Me.txt_preDiaAloSel.Size = New System.Drawing.Size(70, 22)
        Me.txt_preDiaAloSel.TabIndex = 7
        '
        'txt_nroHabAloSel
        '
        Me.txt_nroHabAloSel.Location = New System.Drawing.Point(158, 79)
        Me.txt_nroHabAloSel.Name = "txt_nroHabAloSel"
        Me.txt_nroHabAloSel.ReadOnly = True
        Me.txt_nroHabAloSel.Size = New System.Drawing.Size(51, 22)
        Me.txt_nroHabAloSel.TabIndex = 3
        '
        'txt_canPerAloSel
        '
        Me.txt_canPerAloSel.Location = New System.Drawing.Point(158, 107)
        Me.txt_canPerAloSel.Name = "txt_canPerAloSel"
        Me.txt_canPerAloSel.ReadOnly = True
        Me.txt_canPerAloSel.Size = New System.Drawing.Size(51, 22)
        Me.txt_canPerAloSel.TabIndex = 4
        '
        'txt_nroPisoAloSel
        '
        Me.txt_nroPisoAloSel.Location = New System.Drawing.Point(158, 51)
        Me.txt_nroPisoAloSel.Name = "txt_nroPisoAloSel"
        Me.txt_nroPisoAloSel.ReadOnly = True
        Me.txt_nroPisoAloSel.Size = New System.Drawing.Size(51, 22)
        Me.txt_nroPisoAloSel.TabIndex = 2
        '
        'lbl_preDiaAloSel
        '
        Me.lbl_preDiaAloSel.AutoSize = True
        Me.lbl_preDiaAloSel.Location = New System.Drawing.Point(215, 82)
        Me.lbl_preDiaAloSel.Name = "lbl_preDiaAloSel"
        Me.lbl_preDiaAloSel.Size = New System.Drawing.Size(91, 16)
        Me.lbl_preDiaAloSel.TabIndex = 7
        Me.lbl_preDiaAloSel.Text = "Precio porDía"
        '
        'lbl_fecHasAloSel
        '
        Me.lbl_fecHasAloSel.AutoSize = True
        Me.lbl_fecHasAloSel.Location = New System.Drawing.Point(220, 54)
        Me.lbl_fecHasAloSel.Name = "lbl_fecHasAloSel"
        Me.lbl_fecHasAloSel.Size = New System.Drawing.Size(85, 16)
        Me.lbl_fecHasAloSel.TabIndex = 6
        Me.lbl_fecHasAloSel.Text = "Fecha Hasta"
        '
        'lbl_fecDesAloSel
        '
        Me.lbl_fecDesAloSel.AutoSize = True
        Me.lbl_fecDesAloSel.Location = New System.Drawing.Point(215, 26)
        Me.lbl_fecDesAloSel.Name = "lbl_fecDesAloSel"
        Me.lbl_fecDesAloSel.Size = New System.Drawing.Size(90, 16)
        Me.lbl_fecDesAloSel.TabIndex = 5
        Me.lbl_fecDesAloSel.Text = "Fecha Desde"
        '
        'lbl_canPerAloSel
        '
        Me.lbl_canPerAloSel.AutoSize = True
        Me.lbl_canPerAloSel.Location = New System.Drawing.Point(10, 110)
        Me.lbl_canPerAloSel.Name = "lbl_canPerAloSel"
        Me.lbl_canPerAloSel.Size = New System.Drawing.Size(142, 16)
        Me.lbl_canPerAloSel.TabIndex = 4
        Me.lbl_canPerAloSel.Text = "Cantidad de Personas"
        '
        'lbl_nroHabAloSel
        '
        Me.lbl_nroHabAloSel.AutoSize = True
        Me.lbl_nroHabAloSel.Location = New System.Drawing.Point(35, 82)
        Me.lbl_nroHabAloSel.Name = "lbl_nroHabAloSel"
        Me.lbl_nroHabAloSel.Size = New System.Drawing.Size(117, 16)
        Me.lbl_nroHabAloSel.TabIndex = 3
        Me.lbl_nroHabAloSel.Text = "Nro de Habitación"
        '
        'lbl_nroPisoAloSel
        '
        Me.lbl_nroPisoAloSel.AutoSize = True
        Me.lbl_nroPisoAloSel.Location = New System.Drawing.Point(73, 54)
        Me.lbl_nroPisoAloSel.Name = "lbl_nroPisoAloSel"
        Me.lbl_nroPisoAloSel.Size = New System.Drawing.Size(79, 16)
        Me.lbl_nroPisoAloSel.TabIndex = 2
        Me.lbl_nroPisoAloSel.Text = "Nro de Piso"
        '
        'lbl_IDAloSel
        '
        Me.lbl_IDAloSel.AutoSize = True
        Me.lbl_IDAloSel.Location = New System.Drawing.Point(131, 26)
        Me.lbl_IDAloSel.Name = "lbl_IDAloSel"
        Me.lbl_IDAloSel.Size = New System.Drawing.Size(21, 16)
        Me.lbl_IDAloSel.TabIndex = 1
        Me.lbl_IDAloSel.Text = "ID"
        '
        'lbl_aloSel
        '
        Me.lbl_aloSel.AutoSize = True
        Me.lbl_aloSel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_aloSel.Location = New System.Drawing.Point(3, 3)
        Me.lbl_aloSel.Name = "lbl_aloSel"
        Me.lbl_aloSel.Size = New System.Drawing.Size(164, 16)
        Me.lbl_aloSel.TabIndex = 0
        Me.lbl_aloSel.Text = "Alojamiento seleccionado"
        '
        'pnl_nueOrdCom
        '
        Me.pnl_nueOrdCom.Controls.Add(Me.lbl_ordCom)
        Me.pnl_nueOrdCom.Controls.Add(Me.tab_nueOrdCom)
        Me.pnl_nueOrdCom.Enabled = False
        Me.pnl_nueOrdCom.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnl_nueOrdCom.Location = New System.Drawing.Point(12, 28)
        Me.pnl_nueOrdCom.Name = "pnl_nueOrdCom"
        Me.pnl_nueOrdCom.Size = New System.Drawing.Size(532, 240)
        Me.pnl_nueOrdCom.TabIndex = 0
        Me.pnl_nueOrdCom.Visible = False
        '
        'lbl_ordCom
        '
        Me.lbl_ordCom.AutoSize = True
        Me.lbl_ordCom.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_ordCom.Location = New System.Drawing.Point(3, 3)
        Me.lbl_ordCom.Name = "lbl_ordCom"
        Me.lbl_ordCom.Size = New System.Drawing.Size(179, 16)
        Me.lbl_ordCom.TabIndex = 0
        Me.lbl_ordCom.Text = "Nueva Orden de Compra"
        '
        'tab_nueOrdCom
        '
        Me.tab_nueOrdCom.Controls.Add(Me.tab_nueOrdComDatPro)
        Me.tab_nueOrdCom.Controls.Add(Me.tab_nueOrdComArt)
        Me.tab_nueOrdCom.Controls.Add(Me.tab_nueOrdComRes)
        Me.tab_nueOrdCom.Location = New System.Drawing.Point(6, 22)
        Me.tab_nueOrdCom.Name = "tab_nueOrdCom"
        Me.tab_nueOrdCom.SelectedIndex = 0
        Me.tab_nueOrdCom.Size = New System.Drawing.Size(522, 214)
        Me.tab_nueOrdCom.TabIndex = 0
        '
        'tab_nueOrdComDatPro
        '
        Me.tab_nueOrdComDatPro.Controls.Add(Me.cmd_nueOrdComLim)
        Me.tab_nueOrdComDatPro.Controls.Add(Me.cmd_busPro)
        Me.tab_nueOrdComDatPro.Controls.Add(Me.cmd_nueOrdComSig)
        Me.tab_nueOrdComDatPro.Controls.Add(Me.cmd_nueOrdComCan)
        Me.tab_nueOrdComDatPro.Controls.Add(Me.txt_telPro)
        Me.tab_nueOrdComDatPro.Controls.Add(Me.txt_corPro)
        Me.tab_nueOrdComDatPro.Controls.Add(Me.txt_nomPro)
        Me.tab_nueOrdComDatPro.Controls.Add(Me.cmb_IDPro)
        Me.tab_nueOrdComDatPro.Controls.Add(Me.lbl_telPro)
        Me.tab_nueOrdComDatPro.Controls.Add(Me.lbl_corPro)
        Me.tab_nueOrdComDatPro.Controls.Add(Me.lbl_nomPro)
        Me.tab_nueOrdComDatPro.Controls.Add(Me.lbl_IDPro)
        Me.tab_nueOrdComDatPro.Location = New System.Drawing.Point(4, 25)
        Me.tab_nueOrdComDatPro.Name = "tab_nueOrdComDatPro"
        Me.tab_nueOrdComDatPro.Padding = New System.Windows.Forms.Padding(3)
        Me.tab_nueOrdComDatPro.Size = New System.Drawing.Size(514, 185)
        Me.tab_nueOrdComDatPro.TabIndex = 0
        Me.tab_nueOrdComDatPro.Text = "Datos del Proveedor"
        Me.tab_nueOrdComDatPro.UseVisualStyleBackColor = True
        '
        'cmd_nueOrdComLim
        '
        Me.cmd_nueOrdComLim.Location = New System.Drawing.Point(9, 146)
        Me.cmd_nueOrdComLim.Name = "cmd_nueOrdComLim"
        Me.cmd_nueOrdComLim.Size = New System.Drawing.Size(72, 28)
        Me.cmd_nueOrdComLim.TabIndex = 3
        Me.cmd_nueOrdComLim.Text = "Limpiar"
        Me.cmd_nueOrdComLim.UseVisualStyleBackColor = True
        '
        'cmd_busPro
        '
        Me.cmd_busPro.Location = New System.Drawing.Point(178, 6)
        Me.cmd_busPro.Name = "cmd_busPro"
        Me.cmd_busPro.Size = New System.Drawing.Size(58, 22)
        Me.cmd_busPro.TabIndex = 2
        Me.cmd_busPro.Text = "Buscar"
        Me.cmd_busPro.UseVisualStyleBackColor = True
        '
        'cmd_nueOrdComSig
        '
        Me.cmd_nueOrdComSig.Location = New System.Drawing.Point(409, 146)
        Me.cmd_nueOrdComSig.Name = "cmd_nueOrdComSig"
        Me.cmd_nueOrdComSig.Size = New System.Drawing.Size(72, 28)
        Me.cmd_nueOrdComSig.TabIndex = 7
        Me.cmd_nueOrdComSig.Text = "Siguiente"
        Me.cmd_nueOrdComSig.UseVisualStyleBackColor = True
        '
        'cmd_nueOrdComCan
        '
        Me.cmd_nueOrdComCan.Location = New System.Drawing.Point(331, 146)
        Me.cmd_nueOrdComCan.Name = "cmd_nueOrdComCan"
        Me.cmd_nueOrdComCan.Size = New System.Drawing.Size(72, 28)
        Me.cmd_nueOrdComCan.TabIndex = 6
        Me.cmd_nueOrdComCan.Text = "Cancelar"
        Me.cmd_nueOrdComCan.UseVisualStyleBackColor = True
        '
        'txt_telPro
        '
        Me.txt_telPro.Location = New System.Drawing.Point(100, 92)
        Me.txt_telPro.Name = "txt_telPro"
        Me.txt_telPro.ReadOnly = True
        Me.txt_telPro.Size = New System.Drawing.Size(100, 22)
        Me.txt_telPro.TabIndex = 5
        '
        'txt_corPro
        '
        Me.txt_corPro.Location = New System.Drawing.Point(100, 64)
        Me.txt_corPro.Name = "txt_corPro"
        Me.txt_corPro.ReadOnly = True
        Me.txt_corPro.Size = New System.Drawing.Size(180, 22)
        Me.txt_corPro.TabIndex = 4
        '
        'txt_nomPro
        '
        Me.txt_nomPro.Location = New System.Drawing.Point(100, 36)
        Me.txt_nomPro.Name = "txt_nomPro"
        Me.txt_nomPro.ReadOnly = True
        Me.txt_nomPro.Size = New System.Drawing.Size(272, 22)
        Me.txt_nomPro.TabIndex = 3
        '
        'cmb_IDPro
        '
        Me.cmb_IDPro.FormattingEnabled = True
        Me.cmb_IDPro.Location = New System.Drawing.Point(100, 6)
        Me.cmb_IDPro.Name = "cmb_IDPro"
        Me.cmb_IDPro.Size = New System.Drawing.Size(72, 24)
        Me.cmb_IDPro.TabIndex = 1
        '
        'lbl_telPro
        '
        Me.lbl_telPro.AutoSize = True
        Me.lbl_telPro.Location = New System.Drawing.Point(32, 95)
        Me.lbl_telPro.Name = "lbl_telPro"
        Me.lbl_telPro.Size = New System.Drawing.Size(62, 16)
        Me.lbl_telPro.TabIndex = 3
        Me.lbl_telPro.Text = "Teléfono"
        '
        'lbl_corPro
        '
        Me.lbl_corPro.AutoSize = True
        Me.lbl_corPro.Location = New System.Drawing.Point(45, 67)
        Me.lbl_corPro.Name = "lbl_corPro"
        Me.lbl_corPro.Size = New System.Drawing.Size(49, 16)
        Me.lbl_corPro.TabIndex = 2
        Me.lbl_corPro.Text = "Correo"
        '
        'lbl_nomPro
        '
        Me.lbl_nomPro.AutoSize = True
        Me.lbl_nomPro.Location = New System.Drawing.Point(6, 39)
        Me.lbl_nomPro.Name = "lbl_nomPro"
        Me.lbl_nomPro.Size = New System.Drawing.Size(88, 16)
        Me.lbl_nomPro.TabIndex = 1
        Me.lbl_nomPro.Text = "Razón Social"
        '
        'lbl_IDPro
        '
        Me.lbl_IDPro.AutoSize = True
        Me.lbl_IDPro.Location = New System.Drawing.Point(73, 9)
        Me.lbl_IDPro.Name = "lbl_IDPro"
        Me.lbl_IDPro.Size = New System.Drawing.Size(21, 16)
        Me.lbl_IDPro.TabIndex = 0
        Me.lbl_IDPro.Text = "ID"
        '
        'tab_nueOrdComArt
        '
        Me.tab_nueOrdComArt.Controls.Add(Me.cmd_nueOrdComAgr)
        Me.tab_nueOrdComArt.Controls.Add(Me.txt_nueOrdComArtFilDes)
        Me.tab_nueOrdComArt.Controls.Add(Me.lbl_nueOrdComArtFilDes)
        Me.tab_nueOrdComArt.Controls.Add(Me.txt_nueOrdComArtFilID)
        Me.tab_nueOrdComArt.Controls.Add(Me.lbl_nueOrdComArtFilID)
        Me.tab_nueOrdComArt.Controls.Add(Me.DataGridView2)
        Me.tab_nueOrdComArt.Controls.Add(Me.cmd_nueOrdComAtr)
        Me.tab_nueOrdComArt.Controls.Add(Me.cmd_nueOrdComArtSig)
        Me.tab_nueOrdComArt.Location = New System.Drawing.Point(4, 25)
        Me.tab_nueOrdComArt.Name = "tab_nueOrdComArt"
        Me.tab_nueOrdComArt.Padding = New System.Windows.Forms.Padding(3)
        Me.tab_nueOrdComArt.Size = New System.Drawing.Size(514, 185)
        Me.tab_nueOrdComArt.TabIndex = 1
        Me.tab_nueOrdComArt.Text = "Selección de Artículos"
        Me.tab_nueOrdComArt.UseVisualStyleBackColor = True
        '
        'cmd_nueOrdComAgr
        '
        Me.cmd_nueOrdComAgr.Location = New System.Drawing.Point(331, 146)
        Me.cmd_nueOrdComAgr.Name = "cmd_nueOrdComAgr"
        Me.cmd_nueOrdComAgr.Size = New System.Drawing.Size(72, 28)
        Me.cmd_nueOrdComAgr.TabIndex = 4
        Me.cmd_nueOrdComAgr.Text = "Agregar"
        Me.cmd_nueOrdComAgr.UseVisualStyleBackColor = True
        '
        'txt_nueOrdComArtFilDes
        '
        Me.txt_nueOrdComArtFilDes.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_nueOrdComArtFilDes.Location = New System.Drawing.Point(121, 158)
        Me.txt_nueOrdComArtFilDes.Name = "txt_nueOrdComArtFilDes"
        Me.txt_nueOrdComArtFilDes.Size = New System.Drawing.Size(105, 20)
        Me.txt_nueOrdComArtFilDes.TabIndex = 2
        '
        'lbl_nueOrdComArtFilDes
        '
        Me.lbl_nueOrdComArtFilDes.AutoSize = True
        Me.lbl_nueOrdComArtFilDes.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_nueOrdComArtFilDes.Location = New System.Drawing.Point(6, 161)
        Me.lbl_nueOrdComArtFilDes.Name = "lbl_nueOrdComArtFilDes"
        Me.lbl_nueOrdComArtFilDes.Size = New System.Drawing.Size(109, 13)
        Me.lbl_nueOrdComArtFilDes.TabIndex = 22
        Me.lbl_nueOrdComArtFilDes.Text = "Filtrar por Descripción"
        '
        'txt_nueOrdComArtFilID
        '
        Me.txt_nueOrdComArtFilID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_nueOrdComArtFilID.Location = New System.Drawing.Point(121, 132)
        Me.txt_nueOrdComArtFilID.Name = "txt_nueOrdComArtFilID"
        Me.txt_nueOrdComArtFilID.Size = New System.Drawing.Size(50, 20)
        Me.txt_nueOrdComArtFilID.TabIndex = 1
        '
        'lbl_nueOrdComArtFilID
        '
        Me.lbl_nueOrdComArtFilID.AutoSize = True
        Me.lbl_nueOrdComArtFilID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_nueOrdComArtFilID.Location = New System.Drawing.Point(51, 135)
        Me.lbl_nueOrdComArtFilID.Name = "lbl_nueOrdComArtFilID"
        Me.lbl_nueOrdComArtFilID.Size = New System.Drawing.Size(64, 13)
        Me.lbl_nueOrdComArtFilID.TabIndex = 20
        Me.lbl_nueOrdComArtFilID.Text = "Filtrar por ID"
        '
        'DataGridView2
        '
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.clm_ID, Me.clm_des, Me.clm_preUni, Me.clm_cant, Me.clm_preTot})
        Me.DataGridView2.Location = New System.Drawing.Point(7, 6)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(501, 121)
        Me.DataGridView2.TabIndex = 2
        '
        'clm_ID
        '
        Me.clm_ID.HeaderText = "ID"
        Me.clm_ID.Name = "clm_ID"
        Me.clm_ID.ReadOnly = True
        Me.clm_ID.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.clm_ID.Width = 50
        '
        'clm_des
        '
        Me.clm_des.HeaderText = "Descripción"
        Me.clm_des.Name = "clm_des"
        Me.clm_des.ReadOnly = True
        Me.clm_des.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.clm_des.Width = 105
        '
        'clm_preUni
        '
        Me.clm_preUni.HeaderText = "Precio unitario"
        Me.clm_preUni.Name = "clm_preUni"
        Me.clm_preUni.ReadOnly = True
        Me.clm_preUni.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.clm_preUni.Width = 120
        '
        'clm_cant
        '
        Me.clm_cant.HeaderText = "Cantidad"
        Me.clm_cant.Name = "clm_cant"
        Me.clm_cant.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.clm_cant.Width = 80
        '
        'clm_preTot
        '
        Me.clm_preTot.HeaderText = "Precio total"
        Me.clm_preTot.Name = "clm_preTot"
        Me.clm_preTot.ReadOnly = True
        Me.clm_preTot.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'cmd_nueOrdComAtr
        '
        Me.cmd_nueOrdComAtr.Location = New System.Drawing.Point(253, 146)
        Me.cmd_nueOrdComAtr.Name = "cmd_nueOrdComAtr"
        Me.cmd_nueOrdComAtr.Size = New System.Drawing.Size(72, 28)
        Me.cmd_nueOrdComAtr.TabIndex = 3
        Me.cmd_nueOrdComAtr.Text = "Atrás"
        Me.cmd_nueOrdComAtr.UseVisualStyleBackColor = True
        '
        'cmd_nueOrdComArtSig
        '
        Me.cmd_nueOrdComArtSig.Location = New System.Drawing.Point(409, 146)
        Me.cmd_nueOrdComArtSig.Name = "cmd_nueOrdComArtSig"
        Me.cmd_nueOrdComArtSig.Size = New System.Drawing.Size(72, 28)
        Me.cmd_nueOrdComArtSig.TabIndex = 5
        Me.cmd_nueOrdComArtSig.Text = "Siguiente"
        Me.cmd_nueOrdComArtSig.UseVisualStyleBackColor = True
        '
        'tab_nueOrdComRes
        '
        Me.tab_nueOrdComRes.Controls.Add(Me.cmd_nueOrdComResAtr)
        Me.tab_nueOrdComRes.Controls.Add(Me.cmd_nueOrdComFin)
        Me.tab_nueOrdComRes.Location = New System.Drawing.Point(4, 25)
        Me.tab_nueOrdComRes.Name = "tab_nueOrdComRes"
        Me.tab_nueOrdComRes.Padding = New System.Windows.Forms.Padding(3)
        Me.tab_nueOrdComRes.Size = New System.Drawing.Size(514, 185)
        Me.tab_nueOrdComRes.TabIndex = 2
        Me.tab_nueOrdComRes.Text = "Resumen"
        Me.tab_nueOrdComRes.UseVisualStyleBackColor = True
        '
        'cmd_nueOrdComResAtr
        '
        Me.cmd_nueOrdComResAtr.Location = New System.Drawing.Point(331, 146)
        Me.cmd_nueOrdComResAtr.Name = "cmd_nueOrdComResAtr"
        Me.cmd_nueOrdComResAtr.Size = New System.Drawing.Size(72, 28)
        Me.cmd_nueOrdComResAtr.TabIndex = 1
        Me.cmd_nueOrdComResAtr.Text = "Atrás"
        Me.cmd_nueOrdComResAtr.UseVisualStyleBackColor = True
        '
        'cmd_nueOrdComFin
        '
        Me.cmd_nueOrdComFin.Location = New System.Drawing.Point(409, 146)
        Me.cmd_nueOrdComFin.Name = "cmd_nueOrdComFin"
        Me.cmd_nueOrdComFin.Size = New System.Drawing.Size(72, 28)
        Me.cmd_nueOrdComFin.TabIndex = 2
        Me.cmd_nueOrdComFin.Text = "Finalizar"
        Me.cmd_nueOrdComFin.UseVisualStyleBackColor = True
        '
        'pnl_busOrdCom
        '
        Me.pnl_busOrdCom.Controls.Add(Me.tab_busOrdCom)
        Me.pnl_busOrdCom.Controls.Add(Me.lbl_busOrdCom)
        Me.pnl_busOrdCom.Controls.Add(Me.pnl_ordComSel)
        Me.pnl_busOrdCom.Enabled = False
        Me.pnl_busOrdCom.Location = New System.Drawing.Point(12, 28)
        Me.pnl_busOrdCom.Name = "pnl_busOrdCom"
        Me.pnl_busOrdCom.Size = New System.Drawing.Size(532, 240)
        Me.pnl_busOrdCom.TabIndex = 0
        Me.pnl_busOrdCom.Visible = False
        '
        'tab_busOrdCom
        '
        Me.tab_busOrdCom.Controls.Add(Me.tab_busOrdComDatPro)
        Me.tab_busOrdCom.Controls.Add(Me.tab_busOrdComOrdCom)
        Me.tab_busOrdCom.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab_busOrdCom.Location = New System.Drawing.Point(6, 22)
        Me.tab_busOrdCom.Name = "tab_busOrdCom"
        Me.tab_busOrdCom.SelectedIndex = 0
        Me.tab_busOrdCom.Size = New System.Drawing.Size(522, 214)
        Me.tab_busOrdCom.TabIndex = 0
        '
        'tab_busOrdComDatPro
        '
        Me.tab_busOrdComDatPro.Controls.Add(Me.Button3)
        Me.tab_busOrdComDatPro.Controls.Add(Me.cmd_busOrdComSig)
        Me.tab_busOrdComDatPro.Controls.Add(Me.cmd_busOrdComCan)
        Me.tab_busOrdComDatPro.Controls.Add(Me.Button1)
        Me.tab_busOrdComDatPro.Controls.Add(Me.txt_telProBusOrdCom)
        Me.tab_busOrdComDatPro.Controls.Add(Me.txt_corProBusOrdCom)
        Me.tab_busOrdComDatPro.Controls.Add(Me.txt_nomProBusOrdCom)
        Me.tab_busOrdComDatPro.Controls.Add(Me.cmb_IDProBusOrdCom)
        Me.tab_busOrdComDatPro.Controls.Add(Me.lbl_telProBusOrdCom)
        Me.tab_busOrdComDatPro.Controls.Add(Me.lbl_corProBusOrdCom)
        Me.tab_busOrdComDatPro.Controls.Add(Me.lbl_nomProBusOrdCom)
        Me.tab_busOrdComDatPro.Controls.Add(Me.lbl_IDProBusOrdCom)
        Me.tab_busOrdComDatPro.Location = New System.Drawing.Point(4, 25)
        Me.tab_busOrdComDatPro.Name = "tab_busOrdComDatPro"
        Me.tab_busOrdComDatPro.Padding = New System.Windows.Forms.Padding(3)
        Me.tab_busOrdComDatPro.Size = New System.Drawing.Size(514, 185)
        Me.tab_busOrdComDatPro.TabIndex = 0
        Me.tab_busOrdComDatPro.Text = "Datos del Proveedor"
        Me.tab_busOrdComDatPro.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(9, 146)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(72, 28)
        Me.Button3.TabIndex = 6
        Me.Button3.Text = "Limpiar"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'cmd_busOrdComSig
        '
        Me.cmd_busOrdComSig.Location = New System.Drawing.Point(409, 146)
        Me.cmd_busOrdComSig.Name = "cmd_busOrdComSig"
        Me.cmd_busOrdComSig.Size = New System.Drawing.Size(72, 28)
        Me.cmd_busOrdComSig.TabIndex = 8
        Me.cmd_busOrdComSig.Text = "Siguiente"
        Me.cmd_busOrdComSig.UseVisualStyleBackColor = True
        '
        'cmd_busOrdComCan
        '
        Me.cmd_busOrdComCan.Location = New System.Drawing.Point(331, 146)
        Me.cmd_busOrdComCan.Name = "cmd_busOrdComCan"
        Me.cmd_busOrdComCan.Size = New System.Drawing.Size(72, 28)
        Me.cmd_busOrdComCan.TabIndex = 7
        Me.cmd_busOrdComCan.Text = "Cancelar"
        Me.cmd_busOrdComCan.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(178, 6)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(58, 22)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Buscar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txt_telProBusOrdCom
        '
        Me.txt_telProBusOrdCom.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_telProBusOrdCom.Location = New System.Drawing.Point(100, 92)
        Me.txt_telProBusOrdCom.Name = "txt_telProBusOrdCom"
        Me.txt_telProBusOrdCom.ReadOnly = True
        Me.txt_telProBusOrdCom.Size = New System.Drawing.Size(100, 22)
        Me.txt_telProBusOrdCom.TabIndex = 5
        '
        'txt_corProBusOrdCom
        '
        Me.txt_corProBusOrdCom.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_corProBusOrdCom.Location = New System.Drawing.Point(100, 64)
        Me.txt_corProBusOrdCom.Name = "txt_corProBusOrdCom"
        Me.txt_corProBusOrdCom.ReadOnly = True
        Me.txt_corProBusOrdCom.Size = New System.Drawing.Size(180, 22)
        Me.txt_corProBusOrdCom.TabIndex = 4
        '
        'txt_nomProBusOrdCom
        '
        Me.txt_nomProBusOrdCom.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_nomProBusOrdCom.Location = New System.Drawing.Point(100, 36)
        Me.txt_nomProBusOrdCom.Name = "txt_nomProBusOrdCom"
        Me.txt_nomProBusOrdCom.ReadOnly = True
        Me.txt_nomProBusOrdCom.Size = New System.Drawing.Size(272, 22)
        Me.txt_nomProBusOrdCom.TabIndex = 3
        '
        'cmb_IDProBusOrdCom
        '
        Me.cmb_IDProBusOrdCom.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_IDProBusOrdCom.FormattingEnabled = True
        Me.cmb_IDProBusOrdCom.Location = New System.Drawing.Point(100, 6)
        Me.cmb_IDProBusOrdCom.Name = "cmb_IDProBusOrdCom"
        Me.cmb_IDProBusOrdCom.Size = New System.Drawing.Size(72, 24)
        Me.cmb_IDProBusOrdCom.TabIndex = 1
        '
        'lbl_telProBusOrdCom
        '
        Me.lbl_telProBusOrdCom.AutoSize = True
        Me.lbl_telProBusOrdCom.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_telProBusOrdCom.Location = New System.Drawing.Point(32, 95)
        Me.lbl_telProBusOrdCom.Name = "lbl_telProBusOrdCom"
        Me.lbl_telProBusOrdCom.Size = New System.Drawing.Size(62, 16)
        Me.lbl_telProBusOrdCom.TabIndex = 30
        Me.lbl_telProBusOrdCom.Text = "Teléfono"
        '
        'lbl_corProBusOrdCom
        '
        Me.lbl_corProBusOrdCom.AutoSize = True
        Me.lbl_corProBusOrdCom.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_corProBusOrdCom.Location = New System.Drawing.Point(45, 67)
        Me.lbl_corProBusOrdCom.Name = "lbl_corProBusOrdCom"
        Me.lbl_corProBusOrdCom.Size = New System.Drawing.Size(49, 16)
        Me.lbl_corProBusOrdCom.TabIndex = 30
        Me.lbl_corProBusOrdCom.Text = "Correo"
        '
        'lbl_nomProBusOrdCom
        '
        Me.lbl_nomProBusOrdCom.AutoSize = True
        Me.lbl_nomProBusOrdCom.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_nomProBusOrdCom.Location = New System.Drawing.Point(6, 39)
        Me.lbl_nomProBusOrdCom.Name = "lbl_nomProBusOrdCom"
        Me.lbl_nomProBusOrdCom.Size = New System.Drawing.Size(88, 16)
        Me.lbl_nomProBusOrdCom.TabIndex = 30
        Me.lbl_nomProBusOrdCom.Text = "Razón Social"
        '
        'lbl_IDProBusOrdCom
        '
        Me.lbl_IDProBusOrdCom.AutoSize = True
        Me.lbl_IDProBusOrdCom.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_IDProBusOrdCom.Location = New System.Drawing.Point(73, 9)
        Me.lbl_IDProBusOrdCom.Name = "lbl_IDProBusOrdCom"
        Me.lbl_IDProBusOrdCom.Size = New System.Drawing.Size(21, 16)
        Me.lbl_IDProBusOrdCom.TabIndex = 30
        Me.lbl_IDProBusOrdCom.Text = "ID"
        '
        'tab_busOrdComOrdCom
        '
        Me.tab_busOrdComOrdCom.Controls.Add(Me.cmd_clickEnGrillaOrdenDeCompra)
        Me.tab_busOrdComOrdCom.Controls.Add(Me.DataGridView3)
        Me.tab_busOrdComOrdCom.Controls.Add(Me.cmd_busOrdComAtr)
        Me.tab_busOrdComOrdCom.Controls.Add(Me.cmd_busOrdComFin)
        Me.tab_busOrdComOrdCom.Location = New System.Drawing.Point(4, 25)
        Me.tab_busOrdComOrdCom.Name = "tab_busOrdComOrdCom"
        Me.tab_busOrdComOrdCom.Padding = New System.Windows.Forms.Padding(3)
        Me.tab_busOrdComOrdCom.Size = New System.Drawing.Size(514, 185)
        Me.tab_busOrdComOrdCom.TabIndex = 1
        Me.tab_busOrdComOrdCom.Text = "Ordenes de Compra"
        Me.tab_busOrdComOrdCom.UseVisualStyleBackColor = True
        '
        'cmd_clickEnGrillaOrdenDeCompra
        '
        Me.cmd_clickEnGrillaOrdenDeCompra.Location = New System.Drawing.Point(7, 151)
        Me.cmd_clickEnGrillaOrdenDeCompra.Name = "cmd_clickEnGrillaOrdenDeCompra"
        Me.cmd_clickEnGrillaOrdenDeCompra.Size = New System.Drawing.Size(115, 23)
        Me.cmd_clickEnGrillaOrdenDeCompra.TabIndex = 3
        Me.cmd_clickEnGrillaOrdenDeCompra.Text = "Click en grilla"
        Me.cmd_clickEnGrillaOrdenDeCompra.UseVisualStyleBackColor = True
        '
        'DataGridView3
        '
        Me.DataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView3.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.clm_IDOrdCom, Me.clm_IDPro, Me.clm_fecEmi, Me.clm_fecRec})
        Me.DataGridView3.Location = New System.Drawing.Point(7, 6)
        Me.DataGridView3.Name = "DataGridView3"
        Me.DataGridView3.Size = New System.Drawing.Size(501, 136)
        Me.DataGridView3.TabIndex = 0
        '
        'clm_IDOrdCom
        '
        Me.clm_IDOrdCom.HeaderText = "ID"
        Me.clm_IDOrdCom.Name = "clm_IDOrdCom"
        Me.clm_IDOrdCom.ReadOnly = True
        Me.clm_IDOrdCom.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.clm_IDOrdCom.Width = 60
        '
        'clm_IDPro
        '
        Me.clm_IDPro.HeaderText = "ID Proveedor"
        Me.clm_IDPro.Name = "clm_IDPro"
        Me.clm_IDPro.ReadOnly = True
        Me.clm_IDPro.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.clm_IDPro.Width = 115
        '
        'clm_fecEmi
        '
        Me.clm_fecEmi.HeaderText = "Fecha Emisión"
        Me.clm_fecEmi.Name = "clm_fecEmi"
        Me.clm_fecEmi.ReadOnly = True
        Me.clm_fecEmi.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.clm_fecEmi.Width = 140
        '
        'clm_fecRec
        '
        Me.clm_fecRec.HeaderText = "Fecha Recepción"
        Me.clm_fecRec.Name = "clm_fecRec"
        Me.clm_fecRec.ReadOnly = True
        Me.clm_fecRec.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.clm_fecRec.Width = 140
        '
        'cmd_busOrdComAtr
        '
        Me.cmd_busOrdComAtr.Location = New System.Drawing.Point(331, 146)
        Me.cmd_busOrdComAtr.Name = "cmd_busOrdComAtr"
        Me.cmd_busOrdComAtr.Size = New System.Drawing.Size(72, 28)
        Me.cmd_busOrdComAtr.TabIndex = 1
        Me.cmd_busOrdComAtr.Text = "Atrás"
        Me.cmd_busOrdComAtr.UseVisualStyleBackColor = True
        '
        'cmd_busOrdComFin
        '
        Me.cmd_busOrdComFin.Location = New System.Drawing.Point(409, 146)
        Me.cmd_busOrdComFin.Name = "cmd_busOrdComFin"
        Me.cmd_busOrdComFin.Size = New System.Drawing.Size(72, 28)
        Me.cmd_busOrdComFin.TabIndex = 2
        Me.cmd_busOrdComFin.Text = "Finalizar"
        Me.cmd_busOrdComFin.UseVisualStyleBackColor = True
        '
        'lbl_busOrdCom
        '
        Me.lbl_busOrdCom.AutoSize = True
        Me.lbl_busOrdCom.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_busOrdCom.Location = New System.Drawing.Point(3, 3)
        Me.lbl_busOrdCom.Name = "lbl_busOrdCom"
        Me.lbl_busOrdCom.Size = New System.Drawing.Size(182, 16)
        Me.lbl_busOrdCom.TabIndex = 0
        Me.lbl_busOrdCom.Text = "Buscar Orden de Compra"
        '
        'pnl_ordComSel
        '
        Me.pnl_ordComSel.BackColor = System.Drawing.Color.White
        Me.pnl_ordComSel.Controls.Add(Me.cmd_atrOrdComSel)
        Me.pnl_ordComSel.Controls.Add(Me.cmd_anuOrdComSel)
        Me.pnl_ordComSel.Controls.Add(Me.Button6)
        Me.pnl_ordComSel.Controls.Add(Me.TextBox3)
        Me.pnl_ordComSel.Controls.Add(Me.TextBox4)
        Me.pnl_ordComSel.Controls.Add(Me.TextBox5)
        Me.pnl_ordComSel.Controls.Add(Me.MaskedTextBox1)
        Me.pnl_ordComSel.Controls.Add(Me.lbl_nomProAsoOrdComSel)
        Me.pnl_ordComSel.Controls.Add(Me.lbl_corProAsoOrdComSel)
        Me.pnl_ordComSel.Controls.Add(Me.lbl_telProAsoOrdComSel)
        Me.pnl_ordComSel.Controls.Add(Me.lbl_IDProAsoOrdComSel)
        Me.pnl_ordComSel.Controls.Add(Me.pnl_sepOrdComSel)
        Me.pnl_ordComSel.Controls.Add(Me.lbl_proAsoOrdComSel)
        Me.pnl_ordComSel.Controls.Add(Me.MaskedTextBox2)
        Me.pnl_ordComSel.Controls.Add(Me.MaskedTextBox3)
        Me.pnl_ordComSel.Controls.Add(Me.TextBox6)
        Me.pnl_ordComSel.Controls.Add(Me.TextBox7)
        Me.pnl_ordComSel.Controls.Add(Me.TextBox8)
        Me.pnl_ordComSel.Controls.Add(Me.TextBox9)
        Me.pnl_ordComSel.Controls.Add(Me.TextBox10)
        Me.pnl_ordComSel.Controls.Add(Me.Label6)
        Me.pnl_ordComSel.Controls.Add(Me.Label7)
        Me.pnl_ordComSel.Controls.Add(Me.Label8)
        Me.pnl_ordComSel.Controls.Add(Me.Label9)
        Me.pnl_ordComSel.Controls.Add(Me.Label10)
        Me.pnl_ordComSel.Controls.Add(Me.Label11)
        Me.pnl_ordComSel.Controls.Add(Me.Label12)
        Me.pnl_ordComSel.Controls.Add(Me.lbl_ordComSel)
        Me.pnl_ordComSel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnl_ordComSel.Location = New System.Drawing.Point(6, 22)
        Me.pnl_ordComSel.Name = "pnl_ordComSel"
        Me.pnl_ordComSel.Size = New System.Drawing.Size(522, 218)
        Me.pnl_ordComSel.TabIndex = 2
        '
        'cmd_atrOrdComSel
        '
        Me.cmd_atrOrdComSel.Location = New System.Drawing.Point(427, 91)
        Me.cmd_atrOrdComSel.Name = "cmd_atrOrdComSel"
        Me.cmd_atrOrdComSel.Size = New System.Drawing.Size(72, 28)
        Me.cmd_atrOrdComSel.TabIndex = 10
        Me.cmd_atrOrdComSel.Text = "Atrás"
        Me.cmd_atrOrdComSel.UseVisualStyleBackColor = True
        '
        'cmd_anuOrdComSel
        '
        Me.cmd_anuOrdComSel.Location = New System.Drawing.Point(427, 57)
        Me.cmd_anuOrdComSel.Name = "cmd_anuOrdComSel"
        Me.cmd_anuOrdComSel.Size = New System.Drawing.Size(72, 28)
        Me.cmd_anuOrdComSel.TabIndex = 9
        Me.cmd_anuOrdComSel.Text = "Anular"
        Me.cmd_anuOrdComSel.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(427, 23)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(72, 28)
        Me.Button6.TabIndex = 8
        Me.Button6.Text = "Modificar"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'TextBox3
        '
        Me.TextBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(65, 168)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.ReadOnly = True
        Me.TextBox3.Size = New System.Drawing.Size(87, 20)
        Me.TextBox3.TabIndex = 11
        '
        'TextBox4
        '
        Me.TextBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox4.Location = New System.Drawing.Point(240, 194)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.ReadOnly = True
        Me.TextBox4.Size = New System.Drawing.Size(140, 20)
        Me.TextBox4.TabIndex = 14
        '
        'TextBox5
        '
        Me.TextBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox5.Location = New System.Drawing.Point(240, 168)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.ReadOnly = True
        Me.TextBox5.Size = New System.Drawing.Size(259, 20)
        Me.TextBox5.TabIndex = 13
        '
        'MaskedTextBox1
        '
        Me.MaskedTextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaskedTextBox1.Location = New System.Drawing.Point(65, 194)
        Me.MaskedTextBox1.Mask = "99999999"
        Me.MaskedTextBox1.Name = "MaskedTextBox1"
        Me.MaskedTextBox1.ReadOnly = True
        Me.MaskedTextBox1.Size = New System.Drawing.Size(87, 20)
        Me.MaskedTextBox1.TabIndex = 12
        '
        'lbl_nomProAsoOrdComSel
        '
        Me.lbl_nomProAsoOrdComSel.AutoSize = True
        Me.lbl_nomProAsoOrdComSel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_nomProAsoOrdComSel.Location = New System.Drawing.Point(164, 171)
        Me.lbl_nomProAsoOrdComSel.Name = "lbl_nomProAsoOrdComSel"
        Me.lbl_nomProAsoOrdComSel.Size = New System.Drawing.Size(70, 13)
        Me.lbl_nomProAsoOrdComSel.TabIndex = 22
        Me.lbl_nomProAsoOrdComSel.Text = "Razón Social"
        '
        'lbl_corProAsoOrdComSel
        '
        Me.lbl_corProAsoOrdComSel.AutoSize = True
        Me.lbl_corProAsoOrdComSel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_corProAsoOrdComSel.Location = New System.Drawing.Point(196, 198)
        Me.lbl_corProAsoOrdComSel.Name = "lbl_corProAsoOrdComSel"
        Me.lbl_corProAsoOrdComSel.Size = New System.Drawing.Size(38, 13)
        Me.lbl_corProAsoOrdComSel.TabIndex = 21
        Me.lbl_corProAsoOrdComSel.Text = "Correo"
        '
        'lbl_telProAsoOrdComSel
        '
        Me.lbl_telProAsoOrdComSel.AutoSize = True
        Me.lbl_telProAsoOrdComSel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_telProAsoOrdComSel.Location = New System.Drawing.Point(10, 198)
        Me.lbl_telProAsoOrdComSel.Name = "lbl_telProAsoOrdComSel"
        Me.lbl_telProAsoOrdComSel.Size = New System.Drawing.Size(49, 13)
        Me.lbl_telProAsoOrdComSel.TabIndex = 20
        Me.lbl_telProAsoOrdComSel.Text = "Teléfono"
        '
        'lbl_IDProAsoOrdComSel
        '
        Me.lbl_IDProAsoOrdComSel.AutoSize = True
        Me.lbl_IDProAsoOrdComSel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_IDProAsoOrdComSel.Location = New System.Drawing.Point(41, 171)
        Me.lbl_IDProAsoOrdComSel.Name = "lbl_IDProAsoOrdComSel"
        Me.lbl_IDProAsoOrdComSel.Size = New System.Drawing.Size(18, 13)
        Me.lbl_IDProAsoOrdComSel.TabIndex = 19
        Me.lbl_IDProAsoOrdComSel.Text = "ID"
        '
        'pnl_sepOrdComSel
        '
        Me.pnl_sepOrdComSel.BackColor = System.Drawing.Color.DimGray
        Me.pnl_sepOrdComSel.Location = New System.Drawing.Point(0, 135)
        Me.pnl_sepOrdComSel.Name = "pnl_sepOrdComSel"
        Me.pnl_sepOrdComSel.Size = New System.Drawing.Size(522, 10)
        Me.pnl_sepOrdComSel.TabIndex = 18
        '
        'lbl_proAsoOrdComSel
        '
        Me.lbl_proAsoOrdComSel.AutoSize = True
        Me.lbl_proAsoOrdComSel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_proAsoOrdComSel.Location = New System.Drawing.Point(3, 148)
        Me.lbl_proAsoOrdComSel.Name = "lbl_proAsoOrdComSel"
        Me.lbl_proAsoOrdComSel.Size = New System.Drawing.Size(133, 16)
        Me.lbl_proAsoOrdComSel.TabIndex = 17
        Me.lbl_proAsoOrdComSel.Text = "Proveedor Asociado"
        '
        'MaskedTextBox2
        '
        Me.MaskedTextBox2.Location = New System.Drawing.Point(311, 51)
        Me.MaskedTextBox2.Mask = "00/00/0000"
        Me.MaskedTextBox2.Name = "MaskedTextBox2"
        Me.MaskedTextBox2.ReadOnly = True
        Me.MaskedTextBox2.Size = New System.Drawing.Size(70, 22)
        Me.MaskedTextBox2.TabIndex = 6
        Me.MaskedTextBox2.ValidatingType = GetType(Date)
        '
        'MaskedTextBox3
        '
        Me.MaskedTextBox3.Location = New System.Drawing.Point(311, 23)
        Me.MaskedTextBox3.Mask = "00/00/0000"
        Me.MaskedTextBox3.Name = "MaskedTextBox3"
        Me.MaskedTextBox3.ReadOnly = True
        Me.MaskedTextBox3.Size = New System.Drawing.Size(70, 22)
        Me.MaskedTextBox3.TabIndex = 5
        Me.MaskedTextBox3.ValidatingType = GetType(Date)
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(158, 23)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.ReadOnly = True
        Me.TextBox6.Size = New System.Drawing.Size(51, 22)
        Me.TextBox6.TabIndex = 1
        '
        'TextBox7
        '
        Me.TextBox7.Location = New System.Drawing.Point(311, 79)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.ReadOnly = True
        Me.TextBox7.Size = New System.Drawing.Size(70, 22)
        Me.TextBox7.TabIndex = 7
        '
        'TextBox8
        '
        Me.TextBox8.Location = New System.Drawing.Point(158, 79)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.ReadOnly = True
        Me.TextBox8.Size = New System.Drawing.Size(51, 22)
        Me.TextBox8.TabIndex = 3
        '
        'TextBox9
        '
        Me.TextBox9.Location = New System.Drawing.Point(158, 107)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.ReadOnly = True
        Me.TextBox9.Size = New System.Drawing.Size(51, 22)
        Me.TextBox9.TabIndex = 4
        '
        'TextBox10
        '
        Me.TextBox10.Location = New System.Drawing.Point(158, 51)
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.ReadOnly = True
        Me.TextBox10.Size = New System.Drawing.Size(51, 22)
        Me.TextBox10.TabIndex = 2
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(215, 82)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(91, 16)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Precio porDía"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(220, 54)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(85, 16)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Fecha Hasta"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(215, 26)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(90, 16)
        Me.Label8.TabIndex = 5
        Me.Label8.Text = "Fecha Desde"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(10, 110)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(142, 16)
        Me.Label9.TabIndex = 4
        Me.Label9.Text = "Cantidad de Personas"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(35, 82)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(117, 16)
        Me.Label10.TabIndex = 3
        Me.Label10.Text = "Nro de Habitación"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(73, 54)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(79, 16)
        Me.Label11.TabIndex = 2
        Me.Label11.Text = "Nro de Piso"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(131, 26)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(21, 16)
        Me.Label12.TabIndex = 1
        Me.Label12.Text = "ID"
        '
        'lbl_ordComSel
        '
        Me.lbl_ordComSel.AutoSize = True
        Me.lbl_ordComSel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_ordComSel.Location = New System.Drawing.Point(3, 3)
        Me.lbl_ordComSel.Name = "lbl_ordComSel"
        Me.lbl_ordComSel.Size = New System.Drawing.Size(200, 16)
        Me.lbl_ordComSel.TabIndex = 0
        Me.lbl_ordComSel.Text = "Orden de compra Seleccionada"
        '
        'pnl_agrArt
        '
        Me.pnl_agrArt.Controls.Add(Me.tab_carArt)
        Me.pnl_agrArt.Controls.Add(Me.lbl_agrArt)
        Me.pnl_agrArt.Enabled = False
        Me.pnl_agrArt.Location = New System.Drawing.Point(12, 28)
        Me.pnl_agrArt.Name = "pnl_agrArt"
        Me.pnl_agrArt.Size = New System.Drawing.Size(532, 240)
        Me.pnl_agrArt.TabIndex = 0
        Me.pnl_agrArt.Visible = False
        '
        'tab_carArt
        '
        Me.tab_carArt.Controls.Add(Me.tab_carArtHab)
        Me.tab_carArt.Controls.Add(Me.tab_carArtArt)
        Me.tab_carArt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab_carArt.Location = New System.Drawing.Point(6, 22)
        Me.tab_carArt.Name = "tab_carArt"
        Me.tab_carArt.SelectedIndex = 0
        Me.tab_carArt.Size = New System.Drawing.Size(522, 214)
        Me.tab_carArt.TabIndex = 1
        '
        'tab_carArtHab
        '
        Me.tab_carArtHab.Controls.Add(Me.Button2)
        Me.tab_carArtHab.Controls.Add(Me.cmd_carArtCan)
        Me.tab_carArtHab.Controls.Add(Me.cmd_carArtSig)
        Me.tab_carArtHab.Controls.Add(Me.txt_cliAsoCarArt)
        Me.tab_carArtHab.Controls.Add(Me.cmb_nroHabCarArt)
        Me.tab_carArtHab.Controls.Add(Me.cmb_nroPisoCarArt)
        Me.tab_carArtHab.Controls.Add(Me.lbl_cliAsoCarArt)
        Me.tab_carArtHab.Controls.Add(Me.lbl_nroHabCarArt)
        Me.tab_carArtHab.Controls.Add(Me.lbl_nroPisoCarArt)
        Me.tab_carArtHab.Location = New System.Drawing.Point(4, 25)
        Me.tab_carArtHab.Name = "tab_carArtHab"
        Me.tab_carArtHab.Padding = New System.Windows.Forms.Padding(3)
        Me.tab_carArtHab.Size = New System.Drawing.Size(514, 185)
        Me.tab_carArtHab.TabIndex = 0
        Me.tab_carArtHab.Text = "Habitación"
        Me.tab_carArtHab.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(9, 146)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(72, 28)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "Limpiar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'cmd_carArtCan
        '
        Me.cmd_carArtCan.Location = New System.Drawing.Point(331, 146)
        Me.cmd_carArtCan.Name = "cmd_carArtCan"
        Me.cmd_carArtCan.Size = New System.Drawing.Size(72, 28)
        Me.cmd_carArtCan.TabIndex = 5
        Me.cmd_carArtCan.Text = "Cancelar"
        Me.cmd_carArtCan.UseVisualStyleBackColor = True
        '
        'cmd_carArtSig
        '
        Me.cmd_carArtSig.Location = New System.Drawing.Point(409, 146)
        Me.cmd_carArtSig.Name = "cmd_carArtSig"
        Me.cmd_carArtSig.Size = New System.Drawing.Size(72, 28)
        Me.cmd_carArtSig.TabIndex = 6
        Me.cmd_carArtSig.Text = "Siguiente"
        Me.cmd_carArtSig.UseVisualStyleBackColor = True
        '
        'txt_cliAsoCarArt
        '
        Me.txt_cliAsoCarArt.Location = New System.Drawing.Point(129, 66)
        Me.txt_cliAsoCarArt.Name = "txt_cliAsoCarArt"
        Me.txt_cliAsoCarArt.ReadOnly = True
        Me.txt_cliAsoCarArt.Size = New System.Drawing.Size(272, 22)
        Me.txt_cliAsoCarArt.TabIndex = 3
        '
        'cmb_nroHabCarArt
        '
        Me.cmb_nroHabCarArt.FormattingEnabled = True
        Me.cmb_nroHabCarArt.Location = New System.Drawing.Point(129, 36)
        Me.cmb_nroHabCarArt.Name = "cmb_nroHabCarArt"
        Me.cmb_nroHabCarArt.Size = New System.Drawing.Size(61, 24)
        Me.cmb_nroHabCarArt.TabIndex = 2
        '
        'cmb_nroPisoCarArt
        '
        Me.cmb_nroPisoCarArt.FormattingEnabled = True
        Me.cmb_nroPisoCarArt.Location = New System.Drawing.Point(129, 6)
        Me.cmb_nroPisoCarArt.Name = "cmb_nroPisoCarArt"
        Me.cmb_nroPisoCarArt.Size = New System.Drawing.Size(61, 24)
        Me.cmb_nroPisoCarArt.TabIndex = 1
        '
        'lbl_cliAsoCarArt
        '
        Me.lbl_cliAsoCarArt.AutoSize = True
        Me.lbl_cliAsoCarArt.Location = New System.Drawing.Point(13, 69)
        Me.lbl_cliAsoCarArt.Name = "lbl_cliAsoCarArt"
        Me.lbl_cliAsoCarArt.Size = New System.Drawing.Size(110, 16)
        Me.lbl_cliAsoCarArt.TabIndex = 45
        Me.lbl_cliAsoCarArt.Text = "Cliente Asociado"
        '
        'lbl_nroHabCarArt
        '
        Me.lbl_nroHabCarArt.AutoSize = True
        Me.lbl_nroHabCarArt.Location = New System.Drawing.Point(6, 39)
        Me.lbl_nroHabCarArt.Name = "lbl_nroHabCarArt"
        Me.lbl_nroHabCarArt.Size = New System.Drawing.Size(117, 16)
        Me.lbl_nroHabCarArt.TabIndex = 43
        Me.lbl_nroHabCarArt.Text = "Nro de Habitación"
        '
        'lbl_nroPisoCarArt
        '
        Me.lbl_nroPisoCarArt.AutoSize = True
        Me.lbl_nroPisoCarArt.Location = New System.Drawing.Point(44, 9)
        Me.lbl_nroPisoCarArt.Name = "lbl_nroPisoCarArt"
        Me.lbl_nroPisoCarArt.Size = New System.Drawing.Size(79, 16)
        Me.lbl_nroPisoCarArt.TabIndex = 41
        Me.lbl_nroPisoCarArt.Text = "Nro de Piso"
        '
        'tab_carArtArt
        '
        Me.tab_carArtArt.Controls.Add(Me.cmd_carArtFin)
        Me.tab_carArtArt.Controls.Add(Me.cmd_carArtAtr)
        Me.tab_carArtArt.Location = New System.Drawing.Point(4, 25)
        Me.tab_carArtArt.Name = "tab_carArtArt"
        Me.tab_carArtArt.Padding = New System.Windows.Forms.Padding(3)
        Me.tab_carArtArt.Size = New System.Drawing.Size(514, 185)
        Me.tab_carArtArt.TabIndex = 1
        Me.tab_carArtArt.Text = "Artículos"
        Me.tab_carArtArt.UseVisualStyleBackColor = True
        '
        'cmd_carArtFin
        '
        Me.cmd_carArtFin.Location = New System.Drawing.Point(409, 146)
        Me.cmd_carArtFin.Name = "cmd_carArtFin"
        Me.cmd_carArtFin.Size = New System.Drawing.Size(72, 28)
        Me.cmd_carArtFin.TabIndex = 2
        Me.cmd_carArtFin.Text = "Finalizar"
        Me.cmd_carArtFin.UseVisualStyleBackColor = True
        '
        'cmd_carArtAtr
        '
        Me.cmd_carArtAtr.Location = New System.Drawing.Point(331, 146)
        Me.cmd_carArtAtr.Name = "cmd_carArtAtr"
        Me.cmd_carArtAtr.Size = New System.Drawing.Size(72, 28)
        Me.cmd_carArtAtr.TabIndex = 1
        Me.cmd_carArtAtr.Text = "Atrás"
        Me.cmd_carArtAtr.UseVisualStyleBackColor = True
        '
        'lbl_agrArt
        '
        Me.lbl_agrArt.AutoSize = True
        Me.lbl_agrArt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_agrArt.Location = New System.Drawing.Point(3, 3)
        Me.lbl_agrArt.Name = "lbl_agrArt"
        Me.lbl_agrArt.Size = New System.Drawing.Size(111, 16)
        Me.lbl_agrArt.TabIndex = 0
        Me.lbl_agrArt.Text = "Cargar Artículo"
        '
        'pnl_agrServ
        '
        Me.pnl_agrServ.Controls.Add(Me.tab_carServ)
        Me.pnl_agrServ.Controls.Add(Me.lbl_agrSer)
        Me.pnl_agrServ.Enabled = False
        Me.pnl_agrServ.Location = New System.Drawing.Point(12, 28)
        Me.pnl_agrServ.Name = "pnl_agrServ"
        Me.pnl_agrServ.Size = New System.Drawing.Size(532, 240)
        Me.pnl_agrServ.TabIndex = 0
        Me.pnl_agrServ.Visible = False
        '
        'tab_carServ
        '
        Me.tab_carServ.Controls.Add(Me.tab_carServHab)
        Me.tab_carServ.Controls.Add(Me.tab_carServServ)
        Me.tab_carServ.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab_carServ.Location = New System.Drawing.Point(6, 22)
        Me.tab_carServ.Name = "tab_carServ"
        Me.tab_carServ.SelectedIndex = 0
        Me.tab_carServ.Size = New System.Drawing.Size(522, 214)
        Me.tab_carServ.TabIndex = 0
        '
        'tab_carServHab
        '
        Me.tab_carServHab.Controls.Add(Me.cmd_carSerHabLim)
        Me.tab_carServHab.Controls.Add(Me.cmd_carServCan)
        Me.tab_carServHab.Controls.Add(Me.cmd_carServSig)
        Me.tab_carServHab.Controls.Add(Me.txt_cliAso)
        Me.tab_carServHab.Controls.Add(Me.cmb_nroHab)
        Me.tab_carServHab.Controls.Add(Me.cmb_nroPiso)
        Me.tab_carServHab.Controls.Add(Me.lbl_cliAso)
        Me.tab_carServHab.Controls.Add(Me.lbl_nroHab)
        Me.tab_carServHab.Controls.Add(Me.lbl_nroPiso)
        Me.tab_carServHab.Location = New System.Drawing.Point(4, 25)
        Me.tab_carServHab.Name = "tab_carServHab"
        Me.tab_carServHab.Padding = New System.Windows.Forms.Padding(3)
        Me.tab_carServHab.Size = New System.Drawing.Size(514, 185)
        Me.tab_carServHab.TabIndex = 0
        Me.tab_carServHab.Text = "Habitación"
        Me.tab_carServHab.UseVisualStyleBackColor = True
        '
        'cmd_carSerHabLim
        '
        Me.cmd_carSerHabLim.Location = New System.Drawing.Point(9, 146)
        Me.cmd_carSerHabLim.Name = "cmd_carSerHabLim"
        Me.cmd_carSerHabLim.Size = New System.Drawing.Size(72, 28)
        Me.cmd_carSerHabLim.TabIndex = 4
        Me.cmd_carSerHabLim.Text = "Limpiar"
        Me.cmd_carSerHabLim.UseVisualStyleBackColor = True
        '
        'cmd_carServCan
        '
        Me.cmd_carServCan.Location = New System.Drawing.Point(331, 146)
        Me.cmd_carServCan.Name = "cmd_carServCan"
        Me.cmd_carServCan.Size = New System.Drawing.Size(72, 28)
        Me.cmd_carServCan.TabIndex = 5
        Me.cmd_carServCan.Text = "Cancelar"
        Me.cmd_carServCan.UseVisualStyleBackColor = True
        '
        'cmd_carServSig
        '
        Me.cmd_carServSig.Location = New System.Drawing.Point(409, 146)
        Me.cmd_carServSig.Name = "cmd_carServSig"
        Me.cmd_carServSig.Size = New System.Drawing.Size(72, 28)
        Me.cmd_carServSig.TabIndex = 6
        Me.cmd_carServSig.Text = "Siguiente"
        Me.cmd_carServSig.UseVisualStyleBackColor = True
        '
        'txt_cliAso
        '
        Me.txt_cliAso.Location = New System.Drawing.Point(129, 66)
        Me.txt_cliAso.Name = "txt_cliAso"
        Me.txt_cliAso.ReadOnly = True
        Me.txt_cliAso.Size = New System.Drawing.Size(272, 22)
        Me.txt_cliAso.TabIndex = 3
        '
        'cmb_nroHab
        '
        Me.cmb_nroHab.FormattingEnabled = True
        Me.cmb_nroHab.Location = New System.Drawing.Point(129, 36)
        Me.cmb_nroHab.Name = "cmb_nroHab"
        Me.cmb_nroHab.Size = New System.Drawing.Size(61, 24)
        Me.cmb_nroHab.TabIndex = 2
        '
        'cmb_nroPiso
        '
        Me.cmb_nroPiso.FormattingEnabled = True
        Me.cmb_nroPiso.Location = New System.Drawing.Point(129, 6)
        Me.cmb_nroPiso.Name = "cmb_nroPiso"
        Me.cmb_nroPiso.Size = New System.Drawing.Size(61, 24)
        Me.cmb_nroPiso.TabIndex = 1
        '
        'lbl_cliAso
        '
        Me.lbl_cliAso.AutoSize = True
        Me.lbl_cliAso.Location = New System.Drawing.Point(13, 69)
        Me.lbl_cliAso.Name = "lbl_cliAso"
        Me.lbl_cliAso.Size = New System.Drawing.Size(110, 16)
        Me.lbl_cliAso.TabIndex = 2
        Me.lbl_cliAso.Text = "Cliente Asociado"
        '
        'lbl_nroHab
        '
        Me.lbl_nroHab.AutoSize = True
        Me.lbl_nroHab.Location = New System.Drawing.Point(6, 39)
        Me.lbl_nroHab.Name = "lbl_nroHab"
        Me.lbl_nroHab.Size = New System.Drawing.Size(117, 16)
        Me.lbl_nroHab.TabIndex = 1
        Me.lbl_nroHab.Text = "Nro de Habitación"
        '
        'lbl_nroPiso
        '
        Me.lbl_nroPiso.AutoSize = True
        Me.lbl_nroPiso.Location = New System.Drawing.Point(44, 9)
        Me.lbl_nroPiso.Name = "lbl_nroPiso"
        Me.lbl_nroPiso.Size = New System.Drawing.Size(79, 16)
        Me.lbl_nroPiso.TabIndex = 0
        Me.lbl_nroPiso.Text = "Nro de Piso"
        '
        'tab_carServServ
        '
        Me.tab_carServServ.Controls.Add(Me.cmd_carServAtr)
        Me.tab_carServServ.Controls.Add(Me.cmd_carSerFin)
        Me.tab_carServServ.Location = New System.Drawing.Point(4, 25)
        Me.tab_carServServ.Name = "tab_carServServ"
        Me.tab_carServServ.Padding = New System.Windows.Forms.Padding(3)
        Me.tab_carServServ.Size = New System.Drawing.Size(514, 185)
        Me.tab_carServServ.TabIndex = 1
        Me.tab_carServServ.Text = "Servicios"
        Me.tab_carServServ.UseVisualStyleBackColor = True
        '
        'cmd_carServAtr
        '
        Me.cmd_carServAtr.Location = New System.Drawing.Point(331, 146)
        Me.cmd_carServAtr.Name = "cmd_carServAtr"
        Me.cmd_carServAtr.Size = New System.Drawing.Size(72, 28)
        Me.cmd_carServAtr.TabIndex = 1
        Me.cmd_carServAtr.Text = "Atrás"
        Me.cmd_carServAtr.UseVisualStyleBackColor = True
        '
        'cmd_carSerFin
        '
        Me.cmd_carSerFin.Location = New System.Drawing.Point(409, 146)
        Me.cmd_carSerFin.Name = "cmd_carSerFin"
        Me.cmd_carSerFin.Size = New System.Drawing.Size(72, 28)
        Me.cmd_carSerFin.TabIndex = 2
        Me.cmd_carSerFin.Text = "Finalizar"
        Me.cmd_carSerFin.UseVisualStyleBackColor = True
        '
        'lbl_agrSer
        '
        Me.lbl_agrSer.AutoSize = True
        Me.lbl_agrSer.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_agrSer.Location = New System.Drawing.Point(3, 3)
        Me.lbl_agrSer.Name = "lbl_agrSer"
        Me.lbl_agrSer.Size = New System.Drawing.Size(116, 16)
        Me.lbl_agrSer.TabIndex = 0
        Me.lbl_agrSer.Text = "Cargar Servicio"
        '
        'lbl_concha
        '
        Me.lbl_concha.AutoSize = True
        Me.lbl_concha.Location = New System.Drawing.Point(351, 271)
        Me.lbl_concha.Name = "lbl_concha"
        Me.lbl_concha.Size = New System.Drawing.Size(195, 13)
        Me.lbl_concha.TabIndex = 1
        Me.lbl_concha.Text = "Fecha, Hora y la concha de tu hermana"
        '
        'cmd_modOrdComSel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(546, 287)
        Me.Controls.Add(Me.lbl_concha)
        Me.Controls.Add(Me.menu_Menu)
        Me.Controls.Add(Me.pnl_nueOrdCom)
        Me.Controls.Add(Me.pnl_nueAlo)
        Me.Controls.Add(Me.pnl_busAlo)
        Me.Controls.Add(Me.pnl_agrServ)
        Me.Controls.Add(Me.pnl_agrArt)
        Me.Controls.Add(Me.pnl_busOrdCom)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MainMenuStrip = Me.menu_Menu
        Me.Name = "cmd_modOrdComSel"
        Me.Text = "Menu"
        Me.menu_Menu.ResumeLayout(False)
        Me.menu_Menu.PerformLayout()
        Me.pnl_nueAlo.ResumeLayout(False)
        Me.pnl_nueAlo.PerformLayout()
        Me.tab_aloNue.ResumeLayout(False)
        Me.tab_aloNueDatCli.ResumeLayout(False)
        Me.tab_aloNueDatCli.PerformLayout()
        Me.tab_aloNueDatHos.ResumeLayout(False)
        Me.tab_aloNueDatHos.PerformLayout()
        Me.tab_aloNueSelHab.ResumeLayout(False)
        Me.pnl_busAlo.ResumeLayout(False)
        Me.pnl_busAlo.PerformLayout()
        Me.tab_busAlo.ResumeLayout(False)
        Me.tab_busAloDatCli.ResumeLayout(False)
        Me.tab_busAloDatCli.PerformLayout()
        Me.tab_busAloAlo.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_busAloSel.ResumeLayout(False)
        Me.pnl_busAloSel.PerformLayout()
        Me.pnl_nueOrdCom.ResumeLayout(False)
        Me.pnl_nueOrdCom.PerformLayout()
        Me.tab_nueOrdCom.ResumeLayout(False)
        Me.tab_nueOrdComDatPro.ResumeLayout(False)
        Me.tab_nueOrdComDatPro.PerformLayout()
        Me.tab_nueOrdComArt.ResumeLayout(False)
        Me.tab_nueOrdComArt.PerformLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tab_nueOrdComRes.ResumeLayout(False)
        Me.pnl_busOrdCom.ResumeLayout(False)
        Me.pnl_busOrdCom.PerformLayout()
        Me.tab_busOrdCom.ResumeLayout(False)
        Me.tab_busOrdComDatPro.ResumeLayout(False)
        Me.tab_busOrdComDatPro.PerformLayout()
        Me.tab_busOrdComOrdCom.ResumeLayout(False)
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_ordComSel.ResumeLayout(False)
        Me.pnl_ordComSel.PerformLayout()
        Me.pnl_agrArt.ResumeLayout(False)
        Me.pnl_agrArt.PerformLayout()
        Me.tab_carArt.ResumeLayout(False)
        Me.tab_carArtHab.ResumeLayout(False)
        Me.tab_carArtHab.PerformLayout()
        Me.tab_carArtArt.ResumeLayout(False)
        Me.pnl_agrServ.ResumeLayout(False)
        Me.pnl_agrServ.PerformLayout()
        Me.tab_carServ.ResumeLayout(False)
        Me.tab_carServHab.ResumeLayout(False)
        Me.tab_carServHab.PerformLayout()
        Me.tab_carServServ.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents menu_Menu As System.Windows.Forms.MenuStrip
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NuevoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BuscarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ArtículosServiciosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ÓrdenesDeComprasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FuncionesAdministrativasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents pnl_nueAlo As System.Windows.Forms.Panel
    Friend WithEvents tab_aloNue As System.Windows.Forms.TabControl
    Friend WithEvents tab_aloNueDatCli As System.Windows.Forms.TabPage
    Friend WithEvents tab_aloNueDatHos As System.Windows.Forms.TabPage
    Friend WithEvents tab_aloNueSelHab As System.Windows.Forms.TabPage
    Friend WithEvents txt_tel As System.Windows.Forms.TextBox
    Friend WithEvents cmd_canCli As System.Windows.Forms.Button
    Friend WithEvents cmd_sigCli As System.Windows.Forms.Button
    Friend WithEvents cmd_busCli As System.Windows.Forms.Button
    Friend WithEvents txt_fecNac As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txt_nom As System.Windows.Forms.TextBox
    Friend WithEvents txt_ape As System.Windows.Forms.TextBox
    Friend WithEvents txt_doc As System.Windows.Forms.MaskedTextBox
    Friend WithEvents cmb_tipoDoc As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_fecNac As System.Windows.Forms.Label
    Friend WithEvents lbl_sexo As System.Windows.Forms.Label
    Friend WithEvents lbl_ape As System.Windows.Forms.Label
    Friend WithEvents lbl_nom As System.Windows.Forms.Label
    Friend WithEvents lbl_doc As System.Windows.Forms.Label
    Friend WithEvents lbl_tipoDoc As System.Windows.Forms.Label
    Friend WithEvents lbl_nueAlo As System.Windows.Forms.Label
    Friend WithEvents cmd_atrHos As System.Windows.Forms.Button
    Friend WithEvents cmd_sigHos As System.Windows.Forms.Button
    Friend WithEvents cmb_tipHab As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_canPer As System.Windows.Forms.ComboBox
    Friend WithEvents txt_fecHas As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txt_fecDes As System.Windows.Forms.MaskedTextBox
    Friend WithEvents lbl_tipHab As System.Windows.Forms.Label
    Friend WithEvents lbl_canPer As System.Windows.Forms.Label
    Friend WithEvents lbl_fecHas As System.Windows.Forms.Label
    Friend WithEvents lbl_fecDes As System.Windows.Forms.Label
    Friend WithEvents cam_atrHab As System.Windows.Forms.Button
    Friend WithEvents cmd_aceHab As System.Windows.Forms.Button
    Friend WithEvents pnl_busAlo As System.Windows.Forms.Panel
    Friend WithEvents lbl_busAlo As System.Windows.Forms.Label
    Friend WithEvents tab_busAlo As System.Windows.Forms.TabControl
    Friend WithEvents tab_busAloDatCli As System.Windows.Forms.TabPage
    Friend WithEvents cmd_busCliBusAlo As System.Windows.Forms.Button
    Friend WithEvents txt_nomBusAlo As System.Windows.Forms.TextBox
    Friend WithEvents txt_apeBusAlo As System.Windows.Forms.TextBox
    Friend WithEvents txt_docBusAlo As System.Windows.Forms.MaskedTextBox
    Friend WithEvents lbl_apeBusAlo As System.Windows.Forms.Label
    Friend WithEvents lbl_nomBusAlo As System.Windows.Forms.Label
    Friend WithEvents lbl_docBusAlo As System.Windows.Forms.Label
    Friend WithEvents lbl_tipDocBusAlo As System.Windows.Forms.Label
    Friend WithEvents cmb_tipDocBusAlo As System.Windows.Forms.ComboBox
    Friend WithEvents tab_busAloAlo As System.Windows.Forms.TabPage
    Friend WithEvents cmd_busAloCan As System.Windows.Forms.Button
    Friend WithEvents cmd_busAloDatCliSig As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents cmd_busAloFin As System.Windows.Forms.Button
    Friend WithEvents cmd_busAloAtr As System.Windows.Forms.Button
    Friend WithEvents NuevaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BuscarToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents pnl_nueOrdCom As System.Windows.Forms.Panel
    Friend WithEvents lbl_ordCom As System.Windows.Forms.Label
    Friend WithEvents tab_nueOrdCom As System.Windows.Forms.TabControl
    Friend WithEvents tab_nueOrdComDatPro As System.Windows.Forms.TabPage
    Friend WithEvents tab_nueOrdComArt As System.Windows.Forms.TabPage
    Friend WithEvents cmd_nueOrdComSig As System.Windows.Forms.Button
    Friend WithEvents cmd_nueOrdComCan As System.Windows.Forms.Button
    Friend WithEvents txt_telPro As System.Windows.Forms.TextBox
    Friend WithEvents txt_corPro As System.Windows.Forms.TextBox
    Friend WithEvents txt_nomPro As System.Windows.Forms.TextBox
    Friend WithEvents cmb_IDPro As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_telPro As System.Windows.Forms.Label
    Friend WithEvents lbl_corPro As System.Windows.Forms.Label
    Friend WithEvents lbl_nomPro As System.Windows.Forms.Label
    Friend WithEvents lbl_IDPro As System.Windows.Forms.Label
    Friend WithEvents cmd_nueOrdComAtr As System.Windows.Forms.Button
    Friend WithEvents cmd_nueOrdComArtSig As System.Windows.Forms.Button
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents cmd_busPro As System.Windows.Forms.Button


    Friend WithEvents pnl_busOrdCom As System.Windows.Forms.Panel
    Friend WithEvents lbl_busOrdCom As System.Windows.Forms.Label
    Friend WithEvents tab_busOrdCom As System.Windows.Forms.TabControl
    Friend WithEvents tab_busOrdComDatPro As System.Windows.Forms.TabPage
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txt_telProBusOrdCom As System.Windows.Forms.TextBox
    Friend WithEvents txt_corProBusOrdCom As System.Windows.Forms.TextBox
    Friend WithEvents txt_nomProBusOrdCom As System.Windows.Forms.TextBox
    Friend WithEvents cmb_IDProBusOrdCom As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_telProBusOrdCom As System.Windows.Forms.Label
    Friend WithEvents lbl_corProBusOrdCom As System.Windows.Forms.Label
    Friend WithEvents lbl_nomProBusOrdCom As System.Windows.Forms.Label
    Friend WithEvents lbl_IDProBusOrdCom As System.Windows.Forms.Label
    Friend WithEvents tab_busOrdComOrdCom As System.Windows.Forms.TabPage
    Friend WithEvents cmd_busOrdComSig As System.Windows.Forms.Button
    Friend WithEvents cmd_busOrdComCan As System.Windows.Forms.Button
    Friend WithEvents cmd_busOrdComAtr As System.Windows.Forms.Button
    Friend WithEvents cmd_busOrdComFin As System.Windows.Forms.Button
    Friend WithEvents DataGridView3 As System.Windows.Forms.DataGridView
    Friend WithEvents AgrearArtículoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AgregarServicioToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents pnl_agrArt As System.Windows.Forms.Panel
    Friend WithEvents lbl_agrArt As System.Windows.Forms.Label
    Friend WithEvents pnl_agrServ As System.Windows.Forms.Panel
    Friend WithEvents lbl_agrSer As System.Windows.Forms.Label
    Friend WithEvents tab_carServ As System.Windows.Forms.TabControl
    Friend WithEvents tab_carServHab As System.Windows.Forms.TabPage
    Friend WithEvents txt_cliAso As System.Windows.Forms.TextBox
    Friend WithEvents cmb_nroHab As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_nroPiso As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_cliAso As System.Windows.Forms.Label
    Friend WithEvents lbl_nroHab As System.Windows.Forms.Label
    Friend WithEvents lbl_nroPiso As System.Windows.Forms.Label
    Friend WithEvents tab_carServServ As System.Windows.Forms.TabPage
    Friend WithEvents cmd_carServCan As System.Windows.Forms.Button
    Friend WithEvents cmd_carServSig As System.Windows.Forms.Button
    Friend WithEvents cmd_carServAtr As System.Windows.Forms.Button
    Friend WithEvents cmd_carSerFin As System.Windows.Forms.Button
    Friend WithEvents tab_carArt As System.Windows.Forms.TabControl
    Friend WithEvents tab_carArtHab As System.Windows.Forms.TabPage
    Friend WithEvents cmd_carArtCan As System.Windows.Forms.Button
    Friend WithEvents cmd_carArtSig As System.Windows.Forms.Button
    Friend WithEvents txt_cliAsoCarArt As System.Windows.Forms.TextBox
    Friend WithEvents cmb_nroHabCarArt As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_nroPisoCarArt As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_cliAsoCarArt As System.Windows.Forms.Label
    Friend WithEvents lbl_nroHabCarArt As System.Windows.Forms.Label
    Friend WithEvents lbl_nroPisoCarArt As System.Windows.Forms.Label
    Friend WithEvents tab_carArtArt As System.Windows.Forms.TabPage
    Friend WithEvents cmd_carArtFin As System.Windows.Forms.Button
    Friend WithEvents cmd_carArtAtr As System.Windows.Forms.Button
    Friend WithEvents cmd_carSerHabLim As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents cmd_nueOrdComLim As System.Windows.Forms.Button
    Friend WithEvents cmd_nueAloDatCliLim As System.Windows.Forms.Button
    Friend WithEvents cmd_nueAloDatHosLim As System.Windows.Forms.Button
    Friend WithEvents cmd_busAloLim As System.Windows.Forms.Button
    Friend WithEvents txt_nueOrdComArtFilDes As System.Windows.Forms.TextBox
    Friend WithEvents lbl_nueOrdComArtFilDes As System.Windows.Forms.Label
    Friend WithEvents txt_nueOrdComArtFilID As System.Windows.Forms.TextBox
    Friend WithEvents lbl_nueOrdComArtFilID As System.Windows.Forms.Label
    Friend WithEvents pnl_busAloSel As System.Windows.Forms.Panel
    Friend WithEvents txt_IDAloSel As System.Windows.Forms.TextBox
    Friend WithEvents txt_preDiaAloSel As System.Windows.Forms.TextBox
    Friend WithEvents txt_nroHabAloSel As System.Windows.Forms.TextBox
    Friend WithEvents txt_canPerAloSel As System.Windows.Forms.TextBox
    Friend WithEvents txt_nroPisoAloSel As System.Windows.Forms.TextBox
    Friend WithEvents lbl_preDiaAloSel As System.Windows.Forms.Label
    Friend WithEvents lbl_fecHasAloSel As System.Windows.Forms.Label
    Friend WithEvents lbl_fecDesAloSel As System.Windows.Forms.Label
    Friend WithEvents lbl_canPerAloSel As System.Windows.Forms.Label
    Friend WithEvents lbl_nroHabAloSel As System.Windows.Forms.Label
    Friend WithEvents lbl_nroPisoAloSel As System.Windows.Forms.Label
    Friend WithEvents lbl_IDAloSel As System.Windows.Forms.Label
    Friend WithEvents lbl_aloSel As System.Windows.Forms.Label
    Friend WithEvents txt_fecHasAloSel As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txt_fecDesAloSel As System.Windows.Forms.MaskedTextBox
    Friend WithEvents pnl_sepAloSel As System.Windows.Forms.Panel
    Friend WithEvents lbl_cliAsoAloSel As System.Windows.Forms.Label
    Friend WithEvents cmd_anuAloSel As System.Windows.Forms.Button
    Friend WithEvents cmd_modAloSel As System.Windows.Forms.Button
    Friend WithEvents txt_tipoDocAloSel As System.Windows.Forms.TextBox
    Friend WithEvents txt_apeAloSel As System.Windows.Forms.TextBox
    Friend WithEvents txt_nomAloSel As System.Windows.Forms.TextBox
    Friend WithEvents txt_docAloSel As System.Windows.Forms.MaskedTextBox
    Friend WithEvents lbl_nomAloSel As System.Windows.Forms.Label
    Friend WithEvents lbl_apeAloSel As System.Windows.Forms.Label
    Friend WithEvents lbl_docAloSel As System.Windows.Forms.Label
    Friend WithEvents lbl_tipoDocAloSel As System.Windows.Forms.Label
    Friend WithEvents cmd_atrAloSel As System.Windows.Forms.Button
    Friend WithEvents cmd_clickEnGrilla As System.Windows.Forms.Button
    Friend WithEvents pnl_ordComSel As System.Windows.Forms.Panel
    Friend WithEvents cmd_atrOrdComSel As System.Windows.Forms.Button
    Friend WithEvents cmd_anuOrdComSel As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents MaskedTextBox1 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents lbl_nomProAsoOrdComSel As System.Windows.Forms.Label
    Friend WithEvents lbl_corProAsoOrdComSel As System.Windows.Forms.Label
    Friend WithEvents lbl_telProAsoOrdComSel As System.Windows.Forms.Label
    Friend WithEvents lbl_IDProAsoOrdComSel As System.Windows.Forms.Label
    Friend WithEvents pnl_sepOrdComSel As System.Windows.Forms.Panel
    Friend WithEvents lbl_proAsoOrdComSel As System.Windows.Forms.Label
    Friend WithEvents MaskedTextBox2 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents MaskedTextBox3 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox7 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox8 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox9 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox10 As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents lbl_ordComSel As System.Windows.Forms.Label
    Friend WithEvents cmd_clickEnGrillaOrdenDeCompra As System.Windows.Forms.Button
    Friend WithEvents ABMsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ABMAlojamientosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ABMClientesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ABMTiposDocumentosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InformesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EstadísticasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents clm_piso As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clm_hab As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clm_fecIni As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clm_fecHas As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cmd_nueOrdComAgr As System.Windows.Forms.Button
    Friend WithEvents clm_ID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clm_des As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clm_preUni As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clm_cant As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clm_preTot As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tab_nueOrdComRes As System.Windows.Forms.TabPage
    Friend WithEvents clm_IDOrdCom As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clm_IDPro As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clm_fecEmi As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clm_fecRec As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cmd_nueOrdComFin As System.Windows.Forms.Button
    Friend WithEvents cmd_nueOrdComResAtr As System.Windows.Forms.Button
    Friend WithEvents lbl_concha As System.Windows.Forms.Label

End Class
