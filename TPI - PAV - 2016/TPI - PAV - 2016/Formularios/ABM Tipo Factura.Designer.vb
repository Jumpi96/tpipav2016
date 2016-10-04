<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ABM_Tipo_Factura
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
        Me.txt_nombre = New System.Windows.Forms.TextBox()
        Me.txt_descripcion = New System.Windows.Forms.TextBox()
        Me.grid_tiposFactura = New System.Windows.Forms.DataGridView()
        Me.cmd_borrar = New System.Windows.Forms.Button()
        Me.cmd_limpiar = New System.Windows.Forms.Button()
        Me.cmd_cancelar = New System.Windows.Forms.Button()
        Me.cmd_guardar = New System.Windows.Forms.Button()
        Me.c_idTipoFactura = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.c_nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.c_descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.grid_tiposFactura, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_nombre
        '
        Me.lbl_nombre.AutoSize = True
        Me.lbl_nombre.Location = New System.Drawing.Point(36, 19)
        Me.lbl_nombre.Name = "lbl_nombre"
        Me.lbl_nombre.Size = New System.Drawing.Size(44, 13)
        Me.lbl_nombre.TabIndex = 0
        Me.lbl_nombre.Text = "Nombre"
        '
        'lbl_descripcion
        '
        Me.lbl_descripcion.AutoSize = True
        Me.lbl_descripcion.Location = New System.Drawing.Point(17, 48)
        Me.lbl_descripcion.Name = "lbl_descripcion"
        Me.lbl_descripcion.Size = New System.Drawing.Size(63, 13)
        Me.lbl_descripcion.TabIndex = 1
        Me.lbl_descripcion.Text = "Descripcion"
        '
        'txt_nombre
        '
        Me.txt_nombre.Location = New System.Drawing.Point(86, 16)
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Size = New System.Drawing.Size(280, 20)
        Me.txt_nombre.TabIndex = 2
        '
        'txt_descripcion
        '
        Me.txt_descripcion.Location = New System.Drawing.Point(86, 45)
        Me.txt_descripcion.Name = "txt_descripcion"
        Me.txt_descripcion.Size = New System.Drawing.Size(280, 20)
        Me.txt_descripcion.TabIndex = 3
        '
        'grid_tiposFactura
        '
        Me.grid_tiposFactura.AllowUserToAddRows = False
        Me.grid_tiposFactura.AllowUserToDeleteRows = False
        Me.grid_tiposFactura.AllowUserToResizeColumns = False
        Me.grid_tiposFactura.AllowUserToResizeRows = False
        Me.grid_tiposFactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grid_tiposFactura.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.c_idTipoFactura, Me.c_nombre, Me.c_descripcion})
        Me.grid_tiposFactura.Location = New System.Drawing.Point(12, 84)
        Me.grid_tiposFactura.MultiSelect = False
        Me.grid_tiposFactura.Name = "grid_tiposFactura"
        Me.grid_tiposFactura.ReadOnly = True
        Me.grid_tiposFactura.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grid_tiposFactura.Size = New System.Drawing.Size(354, 246)
        Me.grid_tiposFactura.TabIndex = 4
        '
        'cmd_borrar
        '
        Me.cmd_borrar.Location = New System.Drawing.Point(12, 336)
        Me.cmd_borrar.Name = "cmd_borrar"
        Me.cmd_borrar.Size = New System.Drawing.Size(75, 23)
        Me.cmd_borrar.TabIndex = 35
        Me.cmd_borrar.Text = "Borrar"
        Me.cmd_borrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cmd_borrar.UseVisualStyleBackColor = True
        '
        'cmd_limpiar
        '
        Me.cmd_limpiar.Location = New System.Drawing.Point(140, 336)
        Me.cmd_limpiar.Name = "cmd_limpiar"
        Me.cmd_limpiar.Size = New System.Drawing.Size(75, 23)
        Me.cmd_limpiar.TabIndex = 32
        Me.cmd_limpiar.Text = "Limpiar"
        Me.cmd_limpiar.UseVisualStyleBackColor = True
        '
        'cmd_cancelar
        '
        Me.cmd_cancelar.Location = New System.Drawing.Point(302, 336)
        Me.cmd_cancelar.Name = "cmd_cancelar"
        Me.cmd_cancelar.Size = New System.Drawing.Size(75, 23)
        Me.cmd_cancelar.TabIndex = 34
        Me.cmd_cancelar.Text = "Cancelar"
        Me.cmd_cancelar.UseVisualStyleBackColor = True
        '
        'cmd_guardar
        '
        Me.cmd_guardar.Location = New System.Drawing.Point(221, 336)
        Me.cmd_guardar.Name = "cmd_guardar"
        Me.cmd_guardar.Size = New System.Drawing.Size(75, 23)
        Me.cmd_guardar.TabIndex = 33
        Me.cmd_guardar.Text = "Registrar"
        Me.cmd_guardar.UseVisualStyleBackColor = True
        '
        'c_idTipoFactura
        '
        Me.c_idTipoFactura.HeaderText = "ID "
        Me.c_idTipoFactura.Name = "c_idTipoFactura"
        Me.c_idTipoFactura.ReadOnly = True
        Me.c_idTipoFactura.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.c_idTipoFactura.Width = 50
        '
        'c_nombre
        '
        Me.c_nombre.HeaderText = "Nombre"
        Me.c_nombre.Name = "c_nombre"
        Me.c_nombre.ReadOnly = True
        Me.c_nombre.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.c_nombre.Width = 130
        '
        'c_descripcion
        '
        Me.c_descripcion.HeaderText = "Descripcion"
        Me.c_descripcion.Name = "c_descripcion"
        Me.c_descripcion.ReadOnly = True
        Me.c_descripcion.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.c_descripcion.Width = 130
        '
        'ABM_Tipo_Factura
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(383, 365)
        Me.Controls.Add(Me.cmd_borrar)
        Me.Controls.Add(Me.cmd_limpiar)
        Me.Controls.Add(Me.cmd_cancelar)
        Me.Controls.Add(Me.cmd_guardar)
        Me.Controls.Add(Me.grid_tiposFactura)
        Me.Controls.Add(Me.txt_descripcion)
        Me.Controls.Add(Me.txt_nombre)
        Me.Controls.Add(Me.lbl_descripcion)
        Me.Controls.Add(Me.lbl_nombre)
        Me.Name = "ABM_Tipo_Factura"
        Me.Text = "ABM Tipos Factura"
        CType(Me.grid_tiposFactura, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_nombre As System.Windows.Forms.Label
    Friend WithEvents lbl_descripcion As System.Windows.Forms.Label
    Friend WithEvents txt_nombre As System.Windows.Forms.TextBox
    Friend WithEvents txt_descripcion As System.Windows.Forms.TextBox
    Friend WithEvents grid_tiposFactura As System.Windows.Forms.DataGridView
    Friend WithEvents cmd_borrar As System.Windows.Forms.Button
    Friend WithEvents cmd_limpiar As System.Windows.Forms.Button
    Friend WithEvents cmd_cancelar As System.Windows.Forms.Button
    Friend WithEvents cmd_guardar As System.Windows.Forms.Button
    Friend WithEvents c_idTipoFactura As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents c_nombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents c_descripcion As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
