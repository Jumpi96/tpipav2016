<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ABM_Consumicion
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
        Me.txt_articuloSeleccionado = New System.Windows.Forms.TextBox()
        Me.lbl_articuloSeleccionado = New System.Windows.Forms.Label()
        Me.pnl_cliente = New System.Windows.Forms.Panel()
        Me.txt_apellido = New System.Windows.Forms.TextBox()
        Me.txt_nombre = New System.Windows.Forms.TextBox()
        Me.txt_documento = New System.Windows.Forms.TextBox()
        Me.txt_tipoDocumento = New System.Windows.Forms.TextBox()
        Me.lbl_apellido = New System.Windows.Forms.Label()
        Me.lbl_nombre = New System.Windows.Forms.Label()
        Me.lbl_documento = New System.Windows.Forms.Label()
        Me.lnl_tipoDocumento = New System.Windows.Forms.Label()
        Me.lbl_clienteAsociado = New System.Windows.Forms.Label()
        Me.txt_nroHabitacion = New System.Windows.Forms.MaskedTextBox()
        Me.cmd_cerrar = New System.Windows.Forms.Button()
        Me.cmd_borrar = New System.Windows.Forms.Button()
        Me.cmd_limpiar = New System.Windows.Forms.Button()
        Me.lbl_articulos = New System.Windows.Forms.Label()
        Me.cmd_agregar = New System.Windows.Forms.Button()
        Me.cmb_articulos = New System.Windows.Forms.ComboBox()
        Me.grid_articulos = New System.Windows.Forms.DataGridView()
        Me.clm_idAlojamiento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clm_articulo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clm_Cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clm_idArticulo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cln_frigobar = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cmd_buscar = New System.Windows.Forms.Button()
        Me.lbl_nroHabitacion = New System.Windows.Forms.Label()
        Me.txt_cantidad = New System.Windows.Forms.MaskedTextBox()
        Me.lbl_cantidad = New System.Windows.Forms.Label()
        Me.chb_frigobar = New System.Windows.Forms.CheckBox()
        Me.lbl_cantidadBorrar = New System.Windows.Forms.Label()
        Me.txt_cantidadBorrar = New System.Windows.Forms.MaskedTextBox()
        Me.pnl_cliente.SuspendLayout()
        CType(Me.grid_articulos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txt_articuloSeleccionado
        '
        Me.txt_articuloSeleccionado.Location = New System.Drawing.Point(130, 413)
        Me.txt_articuloSeleccionado.Name = "txt_articuloSeleccionado"
        Me.txt_articuloSeleccionado.ReadOnly = True
        Me.txt_articuloSeleccionado.Size = New System.Drawing.Size(101, 20)
        Me.txt_articuloSeleccionado.TabIndex = 24
        '
        'lbl_articuloSeleccionado
        '
        Me.lbl_articuloSeleccionado.AutoSize = True
        Me.lbl_articuloSeleccionado.Location = New System.Drawing.Point(12, 416)
        Me.lbl_articuloSeleccionado.Name = "lbl_articuloSeleccionado"
        Me.lbl_articuloSeleccionado.Size = New System.Drawing.Size(112, 13)
        Me.lbl_articuloSeleccionado.TabIndex = 22
        Me.lbl_articuloSeleccionado.Text = "Artículo Seleccionado"
        '
        'pnl_cliente
        '
        Me.pnl_cliente.BackColor = System.Drawing.Color.White
        Me.pnl_cliente.Controls.Add(Me.txt_apellido)
        Me.pnl_cliente.Controls.Add(Me.txt_nombre)
        Me.pnl_cliente.Controls.Add(Me.txt_documento)
        Me.pnl_cliente.Controls.Add(Me.txt_tipoDocumento)
        Me.pnl_cliente.Controls.Add(Me.lbl_apellido)
        Me.pnl_cliente.Controls.Add(Me.lbl_nombre)
        Me.pnl_cliente.Controls.Add(Me.lbl_documento)
        Me.pnl_cliente.Controls.Add(Me.lnl_tipoDocumento)
        Me.pnl_cliente.Controls.Add(Me.lbl_clienteAsociado)
        Me.pnl_cliente.Location = New System.Drawing.Point(12, 33)
        Me.pnl_cliente.Name = "pnl_cliente"
        Me.pnl_cliente.Size = New System.Drawing.Size(341, 98)
        Me.pnl_cliente.TabIndex = 20
        '
        'txt_apellido
        '
        Me.txt_apellido.Location = New System.Drawing.Point(95, 43)
        Me.txt_apellido.Name = "txt_apellido"
        Me.txt_apellido.ReadOnly = True
        Me.txt_apellido.Size = New System.Drawing.Size(239, 20)
        Me.txt_apellido.TabIndex = 5
        '
        'txt_nombre
        '
        Me.txt_nombre.Location = New System.Drawing.Point(95, 69)
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.ReadOnly = True
        Me.txt_nombre.Size = New System.Drawing.Size(239, 20)
        Me.txt_nombre.TabIndex = 6
        '
        'txt_documento
        '
        Me.txt_documento.Location = New System.Drawing.Point(269, 17)
        Me.txt_documento.Name = "txt_documento"
        Me.txt_documento.ReadOnly = True
        Me.txt_documento.Size = New System.Drawing.Size(65, 20)
        Me.txt_documento.TabIndex = 4
        '
        'txt_tipoDocumento
        '
        Me.txt_tipoDocumento.Location = New System.Drawing.Point(95, 17)
        Me.txt_tipoDocumento.Name = "txt_tipoDocumento"
        Me.txt_tipoDocumento.ReadOnly = True
        Me.txt_tipoDocumento.Size = New System.Drawing.Size(100, 20)
        Me.txt_tipoDocumento.TabIndex = 3
        '
        'lbl_apellido
        '
        Me.lbl_apellido.AutoSize = True
        Me.lbl_apellido.Location = New System.Drawing.Point(44, 46)
        Me.lbl_apellido.Name = "lbl_apellido"
        Me.lbl_apellido.Size = New System.Drawing.Size(44, 13)
        Me.lbl_apellido.TabIndex = 4
        Me.lbl_apellido.Text = "Apellido"
        '
        'lbl_nombre
        '
        Me.lbl_nombre.AutoSize = True
        Me.lbl_nombre.Location = New System.Drawing.Point(44, 72)
        Me.lbl_nombre.Name = "lbl_nombre"
        Me.lbl_nombre.Size = New System.Drawing.Size(44, 13)
        Me.lbl_nombre.TabIndex = 3
        Me.lbl_nombre.Text = "Nombre"
        '
        'lbl_documento
        '
        Me.lbl_documento.AutoSize = True
        Me.lbl_documento.Location = New System.Drawing.Point(201, 20)
        Me.lbl_documento.Name = "lbl_documento"
        Me.lbl_documento.Size = New System.Drawing.Size(62, 13)
        Me.lbl_documento.TabIndex = 2
        Me.lbl_documento.Text = "Documento"
        '
        'lnl_tipoDocumento
        '
        Me.lnl_tipoDocumento.AutoSize = True
        Me.lnl_tipoDocumento.Location = New System.Drawing.Point(3, 20)
        Me.lnl_tipoDocumento.Name = "lnl_tipoDocumento"
        Me.lnl_tipoDocumento.Size = New System.Drawing.Size(86, 13)
        Me.lnl_tipoDocumento.TabIndex = 1
        Me.lnl_tipoDocumento.Text = "Tipo Documento"
        '
        'lbl_clienteAsociado
        '
        Me.lbl_clienteAsociado.AutoSize = True
        Me.lbl_clienteAsociado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_clienteAsociado.Location = New System.Drawing.Point(3, 3)
        Me.lbl_clienteAsociado.Name = "lbl_clienteAsociado"
        Me.lbl_clienteAsociado.Size = New System.Drawing.Size(85, 13)
        Me.lbl_clienteAsociado.TabIndex = 0
        Me.lbl_clienteAsociado.Text = "Cliente asociado"
        '
        'txt_nroHabitacion
        '
        Me.txt_nroHabitacion.Location = New System.Drawing.Point(111, 6)
        Me.txt_nroHabitacion.Mask = "99999"
        Me.txt_nroHabitacion.Name = "txt_nroHabitacion"
        Me.txt_nroHabitacion.Size = New System.Drawing.Size(40, 20)
        Me.txt_nroHabitacion.TabIndex = 14
        Me.txt_nroHabitacion.ValidatingType = GetType(Integer)
        '
        'cmd_cerrar
        '
        Me.cmd_cerrar.Location = New System.Drawing.Point(278, 390)
        Me.cmd_cerrar.Name = "cmd_cerrar"
        Me.cmd_cerrar.Size = New System.Drawing.Size(75, 23)
        Me.cmd_cerrar.TabIndex = 23
        Me.cmd_cerrar.Text = "Cerrar"
        Me.cmd_cerrar.UseVisualStyleBackColor = True
        '
        'cmd_borrar
        '
        Me.cmd_borrar.Location = New System.Drawing.Point(159, 437)
        Me.cmd_borrar.Name = "cmd_borrar"
        Me.cmd_borrar.Size = New System.Drawing.Size(75, 23)
        Me.cmd_borrar.TabIndex = 25
        Me.cmd_borrar.Text = "Borrar"
        Me.cmd_borrar.UseVisualStyleBackColor = True
        '
        'cmd_limpiar
        '
        Me.cmd_limpiar.Location = New System.Drawing.Point(12, 390)
        Me.cmd_limpiar.Name = "cmd_limpiar"
        Me.cmd_limpiar.Size = New System.Drawing.Size(75, 23)
        Me.cmd_limpiar.TabIndex = 21
        Me.cmd_limpiar.Text = "Limpiar"
        Me.cmd_limpiar.UseVisualStyleBackColor = True
        '
        'lbl_articulos
        '
        Me.lbl_articulos.AutoSize = True
        Me.lbl_articulos.Location = New System.Drawing.Point(12, 142)
        Me.lbl_articulos.Name = "lbl_articulos"
        Me.lbl_articulos.Size = New System.Drawing.Size(47, 13)
        Me.lbl_articulos.TabIndex = 17
        Me.lbl_articulos.Text = "Articulos"
        '
        'cmd_agregar
        '
        Me.cmd_agregar.Location = New System.Drawing.Point(237, 165)
        Me.cmd_agregar.Name = "cmd_agregar"
        Me.cmd_agregar.Size = New System.Drawing.Size(75, 21)
        Me.cmd_agregar.TabIndex = 19
        Me.cmd_agregar.Text = "Agregar"
        Me.cmd_agregar.UseVisualStyleBackColor = True
        '
        'cmb_articulos
        '
        Me.cmb_articulos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_articulos.FormattingEnabled = True
        Me.cmb_articulos.Location = New System.Drawing.Point(68, 139)
        Me.cmb_articulos.Name = "cmb_articulos"
        Me.cmb_articulos.Size = New System.Drawing.Size(160, 21)
        Me.cmb_articulos.TabIndex = 18
        '
        'grid_articulos
        '
        Me.grid_articulos.AllowUserToAddRows = False
        Me.grid_articulos.AllowUserToDeleteRows = False
        Me.grid_articulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grid_articulos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.clm_idAlojamiento, Me.clm_articulo, Me.clm_Cantidad, Me.clm_idArticulo, Me.cln_frigobar})
        Me.grid_articulos.Location = New System.Drawing.Point(12, 193)
        Me.grid_articulos.MultiSelect = False
        Me.grid_articulos.Name = "grid_articulos"
        Me.grid_articulos.ReadOnly = True
        Me.grid_articulos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.grid_articulos.Size = New System.Drawing.Size(341, 191)
        Me.grid_articulos.TabIndex = 16
        '
        'clm_idAlojamiento
        '
        Me.clm_idAlojamiento.HeaderText = "ID Alojamiento"
        Me.clm_idAlojamiento.Name = "clm_idAlojamiento"
        Me.clm_idAlojamiento.ReadOnly = True
        Me.clm_idAlojamiento.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'clm_articulo
        '
        Me.clm_articulo.FillWeight = 60.0!
        Me.clm_articulo.HeaderText = "Artículo"
        Me.clm_articulo.Name = "clm_articulo"
        Me.clm_articulo.ReadOnly = True
        Me.clm_articulo.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.clm_articulo.Width = 60
        '
        'clm_Cantidad
        '
        Me.clm_Cantidad.HeaderText = "Cantidad"
        Me.clm_Cantidad.Name = "clm_Cantidad"
        Me.clm_Cantidad.ReadOnly = True
        Me.clm_Cantidad.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.clm_Cantidad.Width = 75
        '
        'clm_idArticulo
        '
        Me.clm_idArticulo.HeaderText = "ID Artículo"
        Me.clm_idArticulo.Name = "clm_idArticulo"
        Me.clm_idArticulo.ReadOnly = True
        Me.clm_idArticulo.Visible = False
        '
        'cln_frigobar
        '
        Me.cln_frigobar.HeaderText = "Frigobar"
        Me.cln_frigobar.Name = "cln_frigobar"
        Me.cln_frigobar.ReadOnly = True
        Me.cln_frigobar.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.cln_frigobar.Width = 60
        '
        'cmd_buscar
        '
        Me.cmd_buscar.Location = New System.Drawing.Point(157, 4)
        Me.cmd_buscar.Name = "cmd_buscar"
        Me.cmd_buscar.Size = New System.Drawing.Size(75, 23)
        Me.cmd_buscar.TabIndex = 15
        Me.cmd_buscar.Text = "Buscar"
        Me.cmd_buscar.UseVisualStyleBackColor = True
        '
        'lbl_nroHabitacion
        '
        Me.lbl_nroHabitacion.AutoSize = True
        Me.lbl_nroHabitacion.Location = New System.Drawing.Point(12, 9)
        Me.lbl_nroHabitacion.Name = "lbl_nroHabitacion"
        Me.lbl_nroHabitacion.Size = New System.Drawing.Size(93, 13)
        Me.lbl_nroHabitacion.TabIndex = 13
        Me.lbl_nroHabitacion.Text = "Nro de Habitación"
        '
        'txt_cantidad
        '
        Me.txt_cantidad.Location = New System.Drawing.Point(289, 139)
        Me.txt_cantidad.Mask = "99"
        Me.txt_cantidad.Name = "txt_cantidad"
        Me.txt_cantidad.Size = New System.Drawing.Size(23, 20)
        Me.txt_cantidad.TabIndex = 26
        '
        'lbl_cantidad
        '
        Me.lbl_cantidad.AutoSize = True
        Me.lbl_cantidad.Location = New System.Drawing.Point(234, 142)
        Me.lbl_cantidad.Name = "lbl_cantidad"
        Me.lbl_cantidad.Size = New System.Drawing.Size(49, 13)
        Me.lbl_cantidad.TabIndex = 27
        Me.lbl_cantidad.Text = "Cantidad"
        '
        'chb_frigobar
        '
        Me.chb_frigobar.AutoSize = True
        Me.chb_frigobar.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chb_frigobar.Location = New System.Drawing.Point(164, 170)
        Me.chb_frigobar.Name = "chb_frigobar"
        Me.chb_frigobar.Size = New System.Drawing.Size(64, 17)
        Me.chb_frigobar.TabIndex = 28
        Me.chb_frigobar.Text = "Frigobar"
        Me.chb_frigobar.UseVisualStyleBackColor = True
        '
        'lbl_cantidadBorrar
        '
        Me.lbl_cantidadBorrar.AutoSize = True
        Me.lbl_cantidadBorrar.Location = New System.Drawing.Point(75, 442)
        Me.lbl_cantidadBorrar.Name = "lbl_cantidadBorrar"
        Me.lbl_cantidadBorrar.Size = New System.Drawing.Size(49, 13)
        Me.lbl_cantidadBorrar.TabIndex = 30
        Me.lbl_cantidadBorrar.Text = "Cantidad"
        '
        'txt_cantidadBorrar
        '
        Me.txt_cantidadBorrar.Location = New System.Drawing.Point(130, 439)
        Me.txt_cantidadBorrar.Mask = "99"
        Me.txt_cantidadBorrar.Name = "txt_cantidadBorrar"
        Me.txt_cantidadBorrar.Size = New System.Drawing.Size(23, 20)
        Me.txt_cantidadBorrar.TabIndex = 29
        '
        'ABM_Consumicion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(367, 462)
        Me.Controls.Add(Me.lbl_cantidadBorrar)
        Me.Controls.Add(Me.txt_cantidadBorrar)
        Me.Controls.Add(Me.chb_frigobar)
        Me.Controls.Add(Me.lbl_cantidad)
        Me.Controls.Add(Me.txt_cantidad)
        Me.Controls.Add(Me.txt_articuloSeleccionado)
        Me.Controls.Add(Me.lbl_articuloSeleccionado)
        Me.Controls.Add(Me.pnl_cliente)
        Me.Controls.Add(Me.txt_nroHabitacion)
        Me.Controls.Add(Me.cmd_cerrar)
        Me.Controls.Add(Me.cmd_borrar)
        Me.Controls.Add(Me.cmd_limpiar)
        Me.Controls.Add(Me.lbl_articulos)
        Me.Controls.Add(Me.cmd_agregar)
        Me.Controls.Add(Me.cmb_articulos)
        Me.Controls.Add(Me.grid_articulos)
        Me.Controls.Add(Me.cmd_buscar)
        Me.Controls.Add(Me.lbl_nroHabitacion)
        Me.Name = "ABM_Consumicion"
        Me.Text = "ABM_Consumicion"
        Me.pnl_cliente.ResumeLayout(False)
        Me.pnl_cliente.PerformLayout()
        CType(Me.grid_articulos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt_articuloSeleccionado As System.Windows.Forms.TextBox
    Friend WithEvents lbl_articuloSeleccionado As System.Windows.Forms.Label
    Friend WithEvents pnl_cliente As System.Windows.Forms.Panel
    Friend WithEvents txt_apellido As System.Windows.Forms.TextBox
    Friend WithEvents txt_nombre As System.Windows.Forms.TextBox
    Friend WithEvents txt_documento As System.Windows.Forms.TextBox
    Friend WithEvents txt_tipoDocumento As System.Windows.Forms.TextBox
    Friend WithEvents lbl_apellido As System.Windows.Forms.Label
    Friend WithEvents lbl_nombre As System.Windows.Forms.Label
    Friend WithEvents lbl_documento As System.Windows.Forms.Label
    Friend WithEvents lnl_tipoDocumento As System.Windows.Forms.Label
    Friend WithEvents lbl_clienteAsociado As System.Windows.Forms.Label
    Friend WithEvents txt_nroHabitacion As System.Windows.Forms.MaskedTextBox
    Friend WithEvents cmd_cerrar As System.Windows.Forms.Button
    Friend WithEvents cmd_borrar As System.Windows.Forms.Button
    Friend WithEvents cmd_limpiar As System.Windows.Forms.Button
    Friend WithEvents lbl_articulos As System.Windows.Forms.Label
    Friend WithEvents cmd_agregar As System.Windows.Forms.Button
    Friend WithEvents cmb_articulos As System.Windows.Forms.ComboBox
    Friend WithEvents grid_articulos As System.Windows.Forms.DataGridView
    Friend WithEvents cmd_buscar As System.Windows.Forms.Button
    Friend WithEvents lbl_nroHabitacion As System.Windows.Forms.Label
    Friend WithEvents txt_cantidad As System.Windows.Forms.MaskedTextBox
    Friend WithEvents lbl_cantidad As System.Windows.Forms.Label
    Friend WithEvents chb_frigobar As System.Windows.Forms.CheckBox
    Friend WithEvents clm_idAlojamiento As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clm_articulo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clm_Cantidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clm_idArticulo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cln_frigobar As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lbl_cantidadBorrar As System.Windows.Forms.Label
    Friend WithEvents txt_cantidadBorrar As System.Windows.Forms.MaskedTextBox
End Class
