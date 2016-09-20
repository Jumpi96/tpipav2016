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
        Me.cmd_cerrar = New System.Windows.Forms.Button()
        Me.cmd_limpiar = New System.Windows.Forms.Button()
        Me.lbl_articulo = New System.Windows.Forms.Label()
        Me.cmd_agregar = New System.Windows.Forms.Button()
        Me.grid_consumiciones = New System.Windows.Forms.DataGridView()
        Me.c_idConsumicion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.c_articulo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.c_idAlojamiento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.c_cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.c_frigobar = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cmd_buscar = New System.Windows.Forms.Button()
        Me.txt_idAlojamiento = New System.Windows.Forms.TextBox()
        Me.lbl_idAlojamiento = New System.Windows.Forms.Label()
        Me.lbl_cantidad = New System.Windows.Forms.Label()
        Me.txt_articulo = New System.Windows.Forms.MaskedTextBox()
        Me.txt_cantidad = New System.Windows.Forms.MaskedTextBox()
        Me.cmb_frigobar = New System.Windows.Forms.ComboBox()
        CType(Me.grid_consumiciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmd_cerrar
        '
        Me.cmd_cerrar.Location = New System.Drawing.Point(316, 314)
        Me.cmd_cerrar.Name = "cmd_cerrar"
        Me.cmd_cerrar.Size = New System.Drawing.Size(75, 23)
        Me.cmd_cerrar.TabIndex = 17
        Me.cmd_cerrar.Text = "Cerrar"
        Me.cmd_cerrar.UseVisualStyleBackColor = True
        '
        'cmd_limpiar
        '
        Me.cmd_limpiar.Location = New System.Drawing.Point(27, 314)
        Me.cmd_limpiar.Name = "cmd_limpiar"
        Me.cmd_limpiar.Size = New System.Drawing.Size(75, 23)
        Me.cmd_limpiar.TabIndex = 14
        Me.cmd_limpiar.Text = "Limpiar"
        Me.cmd_limpiar.UseVisualStyleBackColor = True
        '
        'lbl_articulo
        '
        Me.lbl_articulo.AutoSize = True
        Me.lbl_articulo.Location = New System.Drawing.Point(59, 52)
        Me.lbl_articulo.Name = "lbl_articulo"
        Me.lbl_articulo.Size = New System.Drawing.Size(42, 13)
        Me.lbl_articulo.TabIndex = 16
        Me.lbl_articulo.Text = "Articulo"
        '
        'cmd_agregar
        '
        Me.cmd_agregar.Location = New System.Drawing.Point(320, 48)
        Me.cmd_agregar.Name = "cmd_agregar"
        Me.cmd_agregar.Size = New System.Drawing.Size(75, 23)
        Me.cmd_agregar.TabIndex = 12
        Me.cmd_agregar.Text = "Agregar"
        Me.cmd_agregar.UseVisualStyleBackColor = True
        '
        'grid_consumiciones
        '
        Me.grid_consumiciones.AllowUserToAddRows = False
        Me.grid_consumiciones.AllowUserToDeleteRows = False
        Me.grid_consumiciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grid_consumiciones.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.c_idConsumicion, Me.c_articulo, Me.c_idAlojamiento, Me.c_cantidad, Me.c_frigobar})
        Me.grid_consumiciones.Location = New System.Drawing.Point(12, 87)
        Me.grid_consumiciones.MultiSelect = False
        Me.grid_consumiciones.Name = "grid_consumiciones"
        Me.grid_consumiciones.ReadOnly = True
        Me.grid_consumiciones.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.grid_consumiciones.Size = New System.Drawing.Size(384, 221)
        Me.grid_consumiciones.TabIndex = 13
        '
        'c_idConsumicion
        '
        Me.c_idConsumicion.HeaderText = "ID"
        Me.c_idConsumicion.Name = "c_idConsumicion"
        Me.c_idConsumicion.ReadOnly = True
        Me.c_idConsumicion.Width = 50
        '
        'c_articulo
        '
        Me.c_articulo.HeaderText = "Articulo"
        Me.c_articulo.Name = "c_articulo"
        Me.c_articulo.ReadOnly = True
        '
        'c_idAlojamiento
        '
        Me.c_idAlojamiento.HeaderText = "Alojamiento"
        Me.c_idAlojamiento.Name = "c_idAlojamiento"
        Me.c_idAlojamiento.ReadOnly = True
        Me.c_idAlojamiento.Width = 70
        '
        'c_cantidad
        '
        Me.c_cantidad.HeaderText = "Cantidad"
        Me.c_cantidad.Name = "c_cantidad"
        Me.c_cantidad.ReadOnly = True
        Me.c_cantidad.Width = 70
        '
        'c_frigobar
        '
        Me.c_frigobar.HeaderText = "Frigobar"
        Me.c_frigobar.Name = "c_frigobar"
        Me.c_frigobar.ReadOnly = True
        Me.c_frigobar.Width = 50
        '
        'cmd_buscar
        '
        Me.cmd_buscar.Location = New System.Drawing.Point(320, 19)
        Me.cmd_buscar.Name = "cmd_buscar"
        Me.cmd_buscar.Size = New System.Drawing.Size(75, 23)
        Me.cmd_buscar.TabIndex = 10
        Me.cmd_buscar.Text = "Buscar"
        Me.cmd_buscar.UseVisualStyleBackColor = True
        '
        'txt_idAlojamiento
        '
        Me.txt_idAlojamiento.Location = New System.Drawing.Point(105, 23)
        Me.txt_idAlojamiento.Name = "txt_idAlojamiento"
        Me.txt_idAlojamiento.Size = New System.Drawing.Size(127, 20)
        Me.txt_idAlojamiento.TabIndex = 8
        '
        'lbl_idAlojamiento
        '
        Me.lbl_idAlojamiento.AutoSize = True
        Me.lbl_idAlojamiento.Location = New System.Drawing.Point(11, 26)
        Me.lbl_idAlojamiento.Name = "lbl_idAlojamiento"
        Me.lbl_idAlojamiento.Size = New System.Drawing.Size(90, 13)
        Me.lbl_idAlojamiento.TabIndex = 9
        Me.lbl_idAlojamiento.Text = "Id. de alojamiento"
        '
        'lbl_cantidad
        '
        Me.lbl_cantidad.AutoSize = True
        Me.lbl_cantidad.Location = New System.Drawing.Point(156, 52)
        Me.lbl_cantidad.Name = "lbl_cantidad"
        Me.lbl_cantidad.Size = New System.Drawing.Size(49, 13)
        Me.lbl_cantidad.TabIndex = 18
        Me.lbl_cantidad.Text = "Cantidad"
        '
        'txt_articulo
        '
        Me.txt_articulo.Location = New System.Drawing.Point(107, 49)
        Me.txt_articulo.Mask = "99999"
        Me.txt_articulo.Name = "txt_articulo"
        Me.txt_articulo.Size = New System.Drawing.Size(41, 20)
        Me.txt_articulo.TabIndex = 19
        Me.txt_articulo.ValidatingType = GetType(Integer)
        '
        'txt_cantidad
        '
        Me.txt_cantidad.Location = New System.Drawing.Point(211, 49)
        Me.txt_cantidad.Mask = "99"
        Me.txt_cantidad.Name = "txt_cantidad"
        Me.txt_cantidad.Size = New System.Drawing.Size(21, 20)
        Me.txt_cantidad.TabIndex = 20
        '
        'cmb_frigobar
        '
        Me.cmb_frigobar.FormattingEnabled = True
        Me.cmb_frigobar.Items.AddRange(New Object() {"No es Frigobar", "Es Frigobar"})
        Me.cmb_frigobar.Location = New System.Drawing.Point(238, 48)
        Me.cmb_frigobar.Name = "cmb_frigobar"
        Me.cmb_frigobar.Size = New System.Drawing.Size(76, 21)
        Me.cmb_frigobar.TabIndex = 21
        '
        'ABM_Consumicion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(403, 348)
        Me.Controls.Add(Me.cmb_frigobar)
        Me.Controls.Add(Me.txt_cantidad)
        Me.Controls.Add(Me.txt_articulo)
        Me.Controls.Add(Me.lbl_cantidad)
        Me.Controls.Add(Me.cmd_cerrar)
        Me.Controls.Add(Me.cmd_limpiar)
        Me.Controls.Add(Me.lbl_articulo)
        Me.Controls.Add(Me.cmd_agregar)
        Me.Controls.Add(Me.grid_consumiciones)
        Me.Controls.Add(Me.cmd_buscar)
        Me.Controls.Add(Me.txt_idAlojamiento)
        Me.Controls.Add(Me.lbl_idAlojamiento)
        Me.Name = "ABM_Consumicion"
        Me.Text = "ABM_Consumicion"
        CType(Me.grid_consumiciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmd_cerrar As System.Windows.Forms.Button
    Friend WithEvents cmd_limpiar As System.Windows.Forms.Button
    Friend WithEvents lbl_articulo As System.Windows.Forms.Label
    Friend WithEvents cmd_agregar As System.Windows.Forms.Button
    Friend WithEvents grid_consumiciones As System.Windows.Forms.DataGridView
    Friend WithEvents cmd_buscar As System.Windows.Forms.Button
    Friend WithEvents txt_idAlojamiento As System.Windows.Forms.TextBox
    Friend WithEvents lbl_idAlojamiento As System.Windows.Forms.Label
    Friend WithEvents c_idConsumicion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents c_articulo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents c_idAlojamiento As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents c_cantidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents c_frigobar As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lbl_cantidad As System.Windows.Forms.Label
    Friend WithEvents txt_articulo As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txt_cantidad As System.Windows.Forms.MaskedTextBox
    Friend WithEvents cmb_frigobar As System.Windows.Forms.ComboBox
End Class
