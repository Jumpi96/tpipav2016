<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ABM_Articulos
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
        Me.lbl_nombre = New System.Windows.Forms.Label()
        Me.lbl_descripcion = New System.Windows.Forms.Label()
        Me.lbl_precioUnitario = New System.Windows.Forms.Label()
        Me.lbl_stock = New System.Windows.Forms.Label()
        Me.lbl_proveedor = New System.Windows.Forms.Label()
        Me.txt_nombre = New System.Windows.Forms.TextBox()
        Me.txt_descripcion = New System.Windows.Forms.TextBox()
        Me.txt_stock = New System.Windows.Forms.TextBox()
        Me.txt_precioUnitario = New System.Windows.Forms.MaskedTextBox()
        Me.cmb_proveedor = New System.Windows.Forms.ComboBox()
        Me.grid_grilla = New System.Windows.Forms.DataGridView()
        Me.cmd_cancelar = New System.Windows.Forms.Button()
        Me.cmd_registrar = New System.Windows.Forms.Button()
        Me.cmd_limpiar = New System.Windows.Forms.Button()
        Me.cmd_borrar = New System.Windows.Forms.Button()
        Me.idArticulo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.precioUnitario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.stock = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idProveedor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.grid_grilla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_nombre
        '
        Me.lbl_nombre.AutoSize = True
        Me.lbl_nombre.Location = New System.Drawing.Point(78, 14)
        Me.lbl_nombre.Name = "lbl_nombre"
        Me.lbl_nombre.Size = New System.Drawing.Size(44, 13)
        Me.lbl_nombre.TabIndex = 11
        Me.lbl_nombre.Text = "Nombre"
        '
        'lbl_descripcion
        '
        Me.lbl_descripcion.AutoSize = True
        Me.lbl_descripcion.Location = New System.Drawing.Point(59, 41)
        Me.lbl_descripcion.Name = "lbl_descripcion"
        Me.lbl_descripcion.Size = New System.Drawing.Size(63, 13)
        Me.lbl_descripcion.TabIndex = 1
        Me.lbl_descripcion.Text = "Descripcion"
        '
        'lbl_precioUnitario
        '
        Me.lbl_precioUnitario.AutoSize = True
        Me.lbl_precioUnitario.Location = New System.Drawing.Point(46, 67)
        Me.lbl_precioUnitario.Name = "lbl_precioUnitario"
        Me.lbl_precioUnitario.Size = New System.Drawing.Size(76, 13)
        Me.lbl_precioUnitario.TabIndex = 2
        Me.lbl_precioUnitario.Text = "Precio Unitario"
        '
        'lbl_stock
        '
        Me.lbl_stock.AutoSize = True
        Me.lbl_stock.Location = New System.Drawing.Point(87, 93)
        Me.lbl_stock.Name = "lbl_stock"
        Me.lbl_stock.Size = New System.Drawing.Size(35, 13)
        Me.lbl_stock.TabIndex = 3
        Me.lbl_stock.Text = "Stock"
        '
        'lbl_proveedor
        '
        Me.lbl_proveedor.AutoSize = True
        Me.lbl_proveedor.Location = New System.Drawing.Point(66, 119)
        Me.lbl_proveedor.Name = "lbl_proveedor"
        Me.lbl_proveedor.Size = New System.Drawing.Size(56, 13)
        Me.lbl_proveedor.TabIndex = 4
        Me.lbl_proveedor.Text = "Proveedor"
        '
        'txt_nombre
        '
        Me.txt_nombre.Location = New System.Drawing.Point(128, 11)
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Size = New System.Drawing.Size(249, 20)
        Me.txt_nombre.TabIndex = 0
        '
        'txt_descripcion
        '
        Me.txt_descripcion.Location = New System.Drawing.Point(128, 38)
        Me.txt_descripcion.Name = "txt_descripcion"
        Me.txt_descripcion.Size = New System.Drawing.Size(248, 20)
        Me.txt_descripcion.TabIndex = 1
        '
        'txt_stock
        '
        Me.txt_stock.Location = New System.Drawing.Point(128, 90)
        Me.txt_stock.Name = "txt_stock"
        Me.txt_stock.Size = New System.Drawing.Size(248, 20)
        Me.txt_stock.TabIndex = 3
        '
        'txt_precioUnitario
        '
        Me.txt_precioUnitario.Location = New System.Drawing.Point(128, 64)
        Me.txt_precioUnitario.Mask = "99999"
        Me.txt_precioUnitario.Name = "txt_precioUnitario"
        Me.txt_precioUnitario.Size = New System.Drawing.Size(45, 20)
        Me.txt_precioUnitario.TabIndex = 2
        '
        'cmb_proveedor
        '
        Me.cmb_proveedor.FormattingEnabled = True
        Me.cmb_proveedor.Location = New System.Drawing.Point(128, 116)
        Me.cmb_proveedor.Name = "cmb_proveedor"
        Me.cmb_proveedor.Size = New System.Drawing.Size(121, 21)
        Me.cmb_proveedor.TabIndex = 4
        '
        'grid_grilla
        '
        Me.grid_grilla.AllowUserToAddRows = False
        Me.grid_grilla.AllowUserToDeleteRows = False
        Me.grid_grilla.AllowUserToResizeColumns = False
        Me.grid_grilla.AllowUserToResizeRows = False
        Me.grid_grilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grid_grilla.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idArticulo, Me.nombre, Me.descripcion, Me.precioUnitario, Me.stock, Me.idProveedor})
        Me.grid_grilla.Location = New System.Drawing.Point(11, 143)
        Me.grid_grilla.Name = "grid_grilla"
        Me.grid_grilla.Size = New System.Drawing.Size(365, 216)
        Me.grid_grilla.TabIndex = 9
        '
        'cmd_cancelar
        '
        Me.cmd_cancelar.Location = New System.Drawing.Point(302, 371)
        Me.cmd_cancelar.Name = "cmd_cancelar"
        Me.cmd_cancelar.Size = New System.Drawing.Size(75, 23)
        Me.cmd_cancelar.TabIndex = 8
        Me.cmd_cancelar.Text = "Cancelar"
        Me.cmd_cancelar.UseVisualStyleBackColor = True
        '
        'cmd_registrar
        '
        Me.cmd_registrar.Location = New System.Drawing.Point(221, 371)
        Me.cmd_registrar.Name = "cmd_registrar"
        Me.cmd_registrar.Size = New System.Drawing.Size(75, 23)
        Me.cmd_registrar.TabIndex = 7
        Me.cmd_registrar.Text = "Registrar"
        Me.cmd_registrar.UseVisualStyleBackColor = True
        '
        'cmd_limpiar
        '
        Me.cmd_limpiar.Location = New System.Drawing.Point(140, 371)
        Me.cmd_limpiar.Name = "cmd_limpiar"
        Me.cmd_limpiar.Size = New System.Drawing.Size(75, 23)
        Me.cmd_limpiar.TabIndex = 6
        Me.cmd_limpiar.Text = "Limpiar"
        Me.cmd_limpiar.UseVisualStyleBackColor = True
        '
        'cmd_borrar
        '
        Me.cmd_borrar.Location = New System.Drawing.Point(12, 371)
        Me.cmd_borrar.Name = "cmd_borrar"
        Me.cmd_borrar.Size = New System.Drawing.Size(75, 23)
        Me.cmd_borrar.TabIndex = 5
        Me.cmd_borrar.Text = "Borrar"
        Me.cmd_borrar.UseVisualStyleBackColor = True
        '
        'idArticulo
        '
        Me.idArticulo.HeaderText = "Id"
        Me.idArticulo.Name = "idArticulo"
        Me.idArticulo.ReadOnly = True
        Me.idArticulo.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.idArticulo.Width = 25
        '
        'nombre
        '
        Me.nombre.HeaderText = "Nombre"
        Me.nombre.Name = "nombre"
        Me.nombre.ReadOnly = True
        Me.nombre.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'descripcion
        '
        Me.descripcion.HeaderText = "Descripcion"
        Me.descripcion.Name = "descripcion"
        Me.descripcion.ReadOnly = True
        Me.descripcion.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'precioUnitario
        '
        Me.precioUnitario.HeaderText = "Precio Unitario"
        Me.precioUnitario.Name = "precioUnitario"
        Me.precioUnitario.ReadOnly = True
        Me.precioUnitario.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'stock
        '
        Me.stock.HeaderText = "Stock"
        Me.stock.Name = "stock"
        Me.stock.ReadOnly = True
        Me.stock.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.stock.Width = 30
        '
        'idProveedor
        '
        Me.idProveedor.HeaderText = "Proveedor"
        Me.idProveedor.Name = "idProveedor"
        Me.idProveedor.ReadOnly = True
        Me.idProveedor.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'ABM_Articulos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(388, 406)
        Me.Controls.Add(Me.cmd_borrar)
        Me.Controls.Add(Me.cmd_limpiar)
        Me.Controls.Add(Me.cmd_registrar)
        Me.Controls.Add(Me.cmd_cancelar)
        Me.Controls.Add(Me.grid_grilla)
        Me.Controls.Add(Me.cmb_proveedor)
        Me.Controls.Add(Me.txt_precioUnitario)
        Me.Controls.Add(Me.txt_stock)
        Me.Controls.Add(Me.txt_descripcion)
        Me.Controls.Add(Me.txt_nombre)
        Me.Controls.Add(Me.lbl_proveedor)
        Me.Controls.Add(Me.lbl_stock)
        Me.Controls.Add(Me.lbl_precioUnitario)
        Me.Controls.Add(Me.lbl_descripcion)
        Me.Controls.Add(Me.lbl_nombre)
        Me.Name = "ABM_Articulos"
        Me.Text = "Articulos"
        CType(Me.grid_grilla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_nombre As System.Windows.Forms.Label
    Friend WithEvents lbl_descripcion As System.Windows.Forms.Label
    Friend WithEvents lbl_precioUnitario As System.Windows.Forms.Label
    Friend WithEvents lbl_stock As System.Windows.Forms.Label
    Friend WithEvents lbl_proveedor As System.Windows.Forms.Label
    Friend WithEvents txt_nombre As System.Windows.Forms.TextBox
    Friend WithEvents txt_descripcion As System.Windows.Forms.TextBox
    Friend WithEvents txt_stock As System.Windows.Forms.TextBox
    Friend WithEvents txt_precioUnitario As System.Windows.Forms.MaskedTextBox
    Friend WithEvents cmb_proveedor As System.Windows.Forms.ComboBox
    Friend WithEvents grid_grilla As System.Windows.Forms.DataGridView
    Friend WithEvents cmd_cancelar As System.Windows.Forms.Button
    Friend WithEvents cmd_registrar As System.Windows.Forms.Button
    Friend WithEvents cmd_limpiar As System.Windows.Forms.Button
    Friend WithEvents cmd_borrar As System.Windows.Forms.Button
    Friend WithEvents idArticulo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents descripcion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents precioUnitario As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents stock As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents idProveedor As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
