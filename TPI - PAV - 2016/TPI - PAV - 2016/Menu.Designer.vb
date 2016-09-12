<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Menu
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
        Me.ÓrdenesDeComprasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NuevaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BuscarToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.FuncionesAdministrativasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.pnl_nueAlo = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tab_aloNue = New System.Windows.Forms.TabControl()
        Me.tab_aloNueDatCli = New System.Windows.Forms.TabPage()
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
        Me.tab_busAlo = New System.Windows.Forms.TabControl()
        Me.tab_busAloDatCli = New System.Windows.Forms.TabPage()
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
        Me.cmd_busAloAtr = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.clm_piso = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clm_hab = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clm_fecIni = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clm_fecHas = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cmd_busAloFin = New System.Windows.Forms.Button()
        Me.lbl_busAlo = New System.Windows.Forms.Label()
        Me.pnl_nueOrdCom = New System.Windows.Forms.Panel()
        Me.lbl_ordCom = New System.Windows.Forms.Label()
        Me.tab_nueOrdCom = New System.Windows.Forms.TabControl()
        Me.tab_nueOrdComDatPro = New System.Windows.Forms.TabPage()
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
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.clm_ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clm_des = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clm_preUni = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clm_cant = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clm_preTot = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cmd_nueOrdComAtr = New System.Windows.Forms.Button()
        Me.cmd_nueOrdComFin = New System.Windows.Forms.Button()
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
        Me.pnl_nueOrdCom.SuspendLayout()
        Me.tab_nueOrdCom.SuspendLayout()
        Me.tab_nueOrdComDatPro.SuspendLayout()
        Me.tab_nueOrdComArt.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'menu_Menu
        '
        Me.menu_Menu.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.menu_Menu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.ArtículosServiciosToolStripMenuItem, Me.ÓrdenesDeComprasToolStripMenuItem, Me.FuncionesAdministrativasToolStripMenuItem})
        Me.menu_Menu.Location = New System.Drawing.Point(0, 0)
        Me.menu_Menu.Name = "menu_Menu"
        Me.menu_Menu.Size = New System.Drawing.Size(581, 25)
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
        Me.NuevoToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.NuevoToolStripMenuItem.Text = "Nuevo"
        '
        'BuscarToolStripMenuItem
        '
        Me.BuscarToolStripMenuItem.Name = "BuscarToolStripMenuItem"
        Me.BuscarToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.BuscarToolStripMenuItem.Text = "Buscar"
        '
        'ArtículosServiciosToolStripMenuItem
        '
        Me.ArtículosServiciosToolStripMenuItem.Name = "ArtículosServiciosToolStripMenuItem"
        Me.ArtículosServiciosToolStripMenuItem.Size = New System.Drawing.Size(126, 21)
        Me.ArtículosServiciosToolStripMenuItem.Text = "Artículos/Servicios"
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
        Me.NuevaToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.NuevaToolStripMenuItem.Text = "Nueva"
        '
        'BuscarToolStripMenuItem1
        '
        Me.BuscarToolStripMenuItem1.Name = "BuscarToolStripMenuItem1"
        Me.BuscarToolStripMenuItem1.Size = New System.Drawing.Size(152, 22)
        Me.BuscarToolStripMenuItem1.Text = "Buscar"
        '
        'FuncionesAdministrativasToolStripMenuItem
        '
        Me.FuncionesAdministrativasToolStripMenuItem.Name = "FuncionesAdministrativasToolStripMenuItem"
        Me.FuncionesAdministrativasToolStripMenuItem.Size = New System.Drawing.Size(169, 21)
        Me.FuncionesAdministrativasToolStripMenuItem.Text = "Funciones Administrativas"
        '
        'pnl_nueAlo
        '
        Me.pnl_nueAlo.Controls.Add(Me.Label1)
        Me.pnl_nueAlo.Controls.Add(Me.tab_aloNue)
        Me.pnl_nueAlo.Enabled = False
        Me.pnl_nueAlo.Location = New System.Drawing.Point(12, 28)
        Me.pnl_nueAlo.Name = "pnl_nueAlo"
        Me.pnl_nueAlo.Size = New System.Drawing.Size(532, 240)
        Me.pnl_nueAlo.TabIndex = 0
        Me.pnl_nueAlo.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(139, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nuevo Alojamiento"
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
        Me.cmd_canCli.TabIndex = 8
        Me.cmd_canCli.Text = "Cancelar"
        Me.cmd_canCli.UseVisualStyleBackColor = True
        '
        'cmd_sigCli
        '
        Me.cmd_sigCli.Location = New System.Drawing.Point(409, 146)
        Me.cmd_sigCli.Name = "cmd_sigCli"
        Me.cmd_sigCli.Size = New System.Drawing.Size(72, 28)
        Me.cmd_sigCli.TabIndex = 9
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
        'cmd_atrHos
        '
        Me.cmd_atrHos.Location = New System.Drawing.Point(331, 146)
        Me.cmd_atrHos.Name = "cmd_atrHos"
        Me.cmd_atrHos.Size = New System.Drawing.Size(72, 28)
        Me.cmd_atrHos.TabIndex = 5
        Me.cmd_atrHos.Text = "Atrás"
        Me.cmd_atrHos.UseVisualStyleBackColor = True
        '
        'cmd_sigHos
        '
        Me.cmd_sigHos.Location = New System.Drawing.Point(409, 146)
        Me.cmd_sigHos.Name = "cmd_sigHos"
        Me.cmd_sigHos.Size = New System.Drawing.Size(72, 28)
        Me.cmd_sigHos.TabIndex = 6
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
        Me.pnl_busAlo.Controls.Add(Me.tab_busAlo)
        Me.pnl_busAlo.Controls.Add(Me.lbl_busAlo)
        Me.pnl_busAlo.Enabled = False
        Me.pnl_busAlo.Location = New System.Drawing.Point(12, 28)
        Me.pnl_busAlo.Name = "pnl_busAlo"
        Me.pnl_busAlo.Size = New System.Drawing.Size(532, 240)
        Me.pnl_busAlo.TabIndex = 0
        Me.pnl_busAlo.Visible = False
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
        'cmd_busAloCan
        '
        Me.cmd_busAloCan.Location = New System.Drawing.Point(331, 146)
        Me.cmd_busAloCan.Name = "cmd_busAloCan"
        Me.cmd_busAloCan.Size = New System.Drawing.Size(72, 28)
        Me.cmd_busAloCan.TabIndex = 6
        Me.cmd_busAloCan.Text = "Cancelar"
        Me.cmd_busAloCan.UseVisualStyleBackColor = True
        '
        'cmd_busAloDatCliSig
        '
        Me.cmd_busAloDatCliSig.Location = New System.Drawing.Point(409, 146)
        Me.cmd_busAloDatCliSig.Name = "cmd_busAloDatCliSig"
        Me.cmd_busAloDatCliSig.Size = New System.Drawing.Size(72, 28)
        Me.cmd_busAloDatCliSig.TabIndex = 7
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
        Me.txt_nomBusAlo.Enabled = False
        Me.txt_nomBusAlo.Location = New System.Drawing.Point(145, 64)
        Me.txt_nomBusAlo.Name = "txt_nomBusAlo"
        Me.txt_nomBusAlo.Size = New System.Drawing.Size(272, 22)
        Me.txt_nomBusAlo.TabIndex = 5
        '
        'txt_apeBusAlo
        '
        Me.txt_apeBusAlo.Enabled = False
        Me.txt_apeBusAlo.Location = New System.Drawing.Point(145, 36)
        Me.txt_apeBusAlo.Name = "txt_apeBusAlo"
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
        Me.DataGridView1.TabIndex = 1
        '
        'clm_piso
        '
        Me.clm_piso.HeaderText = "Piso"
        Me.clm_piso.Name = "clm_piso"
        Me.clm_piso.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.clm_piso.Width = 50
        '
        'clm_hab
        '
        Me.clm_hab.HeaderText = "Habitación"
        Me.clm_hab.Name = "clm_hab"
        Me.clm_hab.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.clm_hab.Width = 80
        '
        'clm_fecIni
        '
        Me.clm_fecIni.HeaderText = "Fecha inicio"
        Me.clm_fecIni.Name = "clm_fecIni"
        Me.clm_fecIni.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.clm_fecIni.Width = 110
        '
        'clm_fecHas
        '
        Me.clm_fecHas.HeaderText = "Fecha fin"
        Me.clm_fecHas.Name = "clm_fecHas"
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
        Me.tab_nueOrdCom.Location = New System.Drawing.Point(6, 22)
        Me.tab_nueOrdCom.Name = "tab_nueOrdCom"
        Me.tab_nueOrdCom.SelectedIndex = 0
        Me.tab_nueOrdCom.Size = New System.Drawing.Size(522, 214)
        Me.tab_nueOrdCom.TabIndex = 0
        '
        'tab_nueOrdComDatPro
        '
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
        Me.txt_telPro.Enabled = False
        Me.txt_telPro.Location = New System.Drawing.Point(100, 92)
        Me.txt_telPro.Name = "txt_telPro"
        Me.txt_telPro.Size = New System.Drawing.Size(100, 22)
        Me.txt_telPro.TabIndex = 5
        '
        'txt_corPro
        '
        Me.txt_corPro.Enabled = False
        Me.txt_corPro.Location = New System.Drawing.Point(100, 64)
        Me.txt_corPro.Name = "txt_corPro"
        Me.txt_corPro.Size = New System.Drawing.Size(180, 22)
        Me.txt_corPro.TabIndex = 4
        '
        'txt_nomPro
        '
        Me.txt_nomPro.Enabled = False
        Me.txt_nomPro.Location = New System.Drawing.Point(100, 36)
        Me.txt_nomPro.Name = "txt_nomPro"
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
        Me.tab_nueOrdComArt.Controls.Add(Me.DataGridView2)
        Me.tab_nueOrdComArt.Controls.Add(Me.cmd_nueOrdComAtr)
        Me.tab_nueOrdComArt.Controls.Add(Me.cmd_nueOrdComFin)
        Me.tab_nueOrdComArt.Location = New System.Drawing.Point(4, 25)
        Me.tab_nueOrdComArt.Name = "tab_nueOrdComArt"
        Me.tab_nueOrdComArt.Padding = New System.Windows.Forms.Padding(3)
        Me.tab_nueOrdComArt.Size = New System.Drawing.Size(514, 185)
        Me.tab_nueOrdComArt.TabIndex = 1
        Me.tab_nueOrdComArt.Text = "Artículos"
        Me.tab_nueOrdComArt.UseVisualStyleBackColor = True
        '
        'DataGridView2
        '
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.clm_ID, Me.clm_des, Me.clm_preUni, Me.clm_cant, Me.clm_preTot})
        Me.DataGridView2.Location = New System.Drawing.Point(7, 6)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(501, 136)
        Me.DataGridView2.TabIndex = 2
        '
        'clm_ID
        '
        Me.clm_ID.HeaderText = "ID"
        Me.clm_ID.Name = "clm_ID"
        Me.clm_ID.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.clm_ID.Width = 50
        '
        'clm_des
        '
        Me.clm_des.HeaderText = "Descripción"
        Me.clm_des.Name = "clm_des"
        Me.clm_des.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.clm_des.Width = 105
        '
        'clm_preUni
        '
        Me.clm_preUni.HeaderText = "Precio unitario"
        Me.clm_preUni.Name = "clm_preUni"
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
        Me.clm_preTot.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'cmd_nueOrdComAtr
        '
        Me.cmd_nueOrdComAtr.Location = New System.Drawing.Point(331, 146)
        Me.cmd_nueOrdComAtr.Name = "cmd_nueOrdComAtr"
        Me.cmd_nueOrdComAtr.Size = New System.Drawing.Size(72, 28)
        Me.cmd_nueOrdComAtr.TabIndex = 1
        Me.cmd_nueOrdComAtr.Text = "Atrás"
        Me.cmd_nueOrdComAtr.UseVisualStyleBackColor = True
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
        'Menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(581, 308)
        Me.Controls.Add(Me.menu_Menu)
        Me.Controls.Add(Me.pnl_nueOrdCom)
        Me.Controls.Add(Me.pnl_nueAlo)
        Me.Controls.Add(Me.pnl_busAlo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MainMenuStrip = Me.menu_Menu
        Me.Name = "Menu"
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
        Me.pnl_nueOrdCom.ResumeLayout(False)
        Me.pnl_nueOrdCom.PerformLayout()
        Me.tab_nueOrdCom.ResumeLayout(False)
        Me.tab_nueOrdComDatPro.ResumeLayout(False)
        Me.tab_nueOrdComDatPro.PerformLayout()
        Me.tab_nueOrdComArt.ResumeLayout(False)
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents Label1 As System.Windows.Forms.Label
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
    Friend WithEvents clm_piso As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clm_hab As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clm_fecIni As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clm_fecHas As System.Windows.Forms.DataGridViewTextBoxColumn
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
    Friend WithEvents cmd_nueOrdComFin As System.Windows.Forms.Button
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents clm_ID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clm_des As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clm_preUni As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clm_cant As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clm_preTot As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cmd_busPro As System.Windows.Forms.Button
End Class
