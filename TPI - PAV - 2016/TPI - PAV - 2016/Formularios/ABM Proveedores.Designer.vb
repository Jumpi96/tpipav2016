<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ABM_Proveedores
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
        Me.lbl_telefono = New System.Windows.Forms.Label()
        Me.lbl_correo = New System.Windows.Forms.Label()
        Me.txt_nombre = New System.Windows.Forms.TextBox()
        Me.txt_correo = New System.Windows.Forms.TextBox()
        Me.txt_telefono = New System.Windows.Forms.TextBox()
        Me.cmd_borrar = New System.Windows.Forms.Button()
        Me.cmd_limpiar = New System.Windows.Forms.Button()
        Me.cmd_cancelar = New System.Windows.Forms.Button()
        Me.cmd_guardar = New System.Windows.Forms.Button()
        Me.grid_proveedores = New System.Windows.Forms.DataGridView()
        Me.c_idProveedor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.c_nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.c_correo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.c_telefono = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.grid_proveedores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_nombre
        '
        Me.lbl_nombre.AutoSize = True
        Me.lbl_nombre.Location = New System.Drawing.Point(22, 20)
        Me.lbl_nombre.Name = "lbl_nombre"
        Me.lbl_nombre.Size = New System.Drawing.Size(44, 13)
        Me.lbl_nombre.TabIndex = 0
        Me.lbl_nombre.Text = "Nombre"
        '
        'lbl_telefono
        '
        Me.lbl_telefono.AutoSize = True
        Me.lbl_telefono.Location = New System.Drawing.Point(17, 68)
        Me.lbl_telefono.Name = "lbl_telefono"
        Me.lbl_telefono.Size = New System.Drawing.Size(49, 13)
        Me.lbl_telefono.TabIndex = 1
        Me.lbl_telefono.Text = "Teléfono"
        '
        'lbl_correo
        '
        Me.lbl_correo.AutoSize = True
        Me.lbl_correo.Location = New System.Drawing.Point(28, 45)
        Me.lbl_correo.Name = "lbl_correo"
        Me.lbl_correo.Size = New System.Drawing.Size(38, 13)
        Me.lbl_correo.TabIndex = 2
        Me.lbl_correo.Text = "Correo"
        '
        'txt_nombre
        '
        Me.txt_nombre.Location = New System.Drawing.Point(72, 16)
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Size = New System.Drawing.Size(301, 20)
        Me.txt_nombre.TabIndex = 3
        '
        'txt_correo
        '
        Me.txt_correo.Location = New System.Drawing.Point(72, 42)
        Me.txt_correo.Name = "txt_correo"
        Me.txt_correo.Size = New System.Drawing.Size(301, 20)
        Me.txt_correo.TabIndex = 4
        '
        'txt_telefono
        '
        Me.txt_telefono.Location = New System.Drawing.Point(72, 68)
        Me.txt_telefono.Name = "txt_telefono"
        Me.txt_telefono.Size = New System.Drawing.Size(301, 20)
        Me.txt_telefono.TabIndex = 5
        '
        'cmd_borrar
        '
        Me.cmd_borrar.Location = New System.Drawing.Point(12, 312)
        Me.cmd_borrar.Name = "cmd_borrar"
        Me.cmd_borrar.Size = New System.Drawing.Size(75, 23)
        Me.cmd_borrar.TabIndex = 31
        Me.cmd_borrar.Text = "Borrar"
        Me.cmd_borrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cmd_borrar.UseVisualStyleBackColor = True
        '
        'cmd_limpiar
        '
        Me.cmd_limpiar.Location = New System.Drawing.Point(140, 312)
        Me.cmd_limpiar.Name = "cmd_limpiar"
        Me.cmd_limpiar.Size = New System.Drawing.Size(75, 23)
        Me.cmd_limpiar.TabIndex = 28
        Me.cmd_limpiar.Text = "Limpiar"
        Me.cmd_limpiar.UseVisualStyleBackColor = True
        '
        'cmd_cancelar
        '
        Me.cmd_cancelar.Location = New System.Drawing.Point(302, 312)
        Me.cmd_cancelar.Name = "cmd_cancelar"
        Me.cmd_cancelar.Size = New System.Drawing.Size(75, 23)
        Me.cmd_cancelar.TabIndex = 30
        Me.cmd_cancelar.Text = "Cancelar"
        Me.cmd_cancelar.UseVisualStyleBackColor = True
        '
        'cmd_guardar
        '
        Me.cmd_guardar.Location = New System.Drawing.Point(221, 312)
        Me.cmd_guardar.Name = "cmd_guardar"
        Me.cmd_guardar.Size = New System.Drawing.Size(75, 23)
        Me.cmd_guardar.TabIndex = 29
        Me.cmd_guardar.Text = "Registrar"
        Me.cmd_guardar.UseVisualStyleBackColor = True
        '
        'grid_proveedores
        '
        Me.grid_proveedores.AllowUserToAddRows = False
        Me.grid_proveedores.AllowUserToDeleteRows = False
        Me.grid_proveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grid_proveedores.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.c_idProveedor, Me.c_nombre, Me.c_correo, Me.c_telefono})
        Me.grid_proveedores.Location = New System.Drawing.Point(12, 94)
        Me.grid_proveedores.Name = "grid_proveedores"
        Me.grid_proveedores.ReadOnly = True
        Me.grid_proveedores.Size = New System.Drawing.Size(365, 212)
        Me.grid_proveedores.TabIndex = 32
        '
        'c_idProveedor
        '
        Me.c_idProveedor.HeaderText = "ID"
        Me.c_idProveedor.Name = "c_idProveedor"
        Me.c_idProveedor.Width = 50
        '
        'c_nombre
        '
        Me.c_nombre.HeaderText = "Nombre"
        Me.c_nombre.Name = "c_nombre"
        '
        'c_correo
        '
        Me.c_correo.HeaderText = "Correo"
        Me.c_correo.Name = "c_correo"
        '
        'c_telefono
        '
        Me.c_telefono.HeaderText = "Telefono"
        Me.c_telefono.Name = "c_telefono"
        Me.c_telefono.Width = 70
        '
        'ABM_Proveedores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(388, 338)
        Me.Controls.Add(Me.grid_proveedores)
        Me.Controls.Add(Me.cmd_borrar)
        Me.Controls.Add(Me.cmd_limpiar)
        Me.Controls.Add(Me.cmd_cancelar)
        Me.Controls.Add(Me.cmd_guardar)
        Me.Controls.Add(Me.txt_telefono)
        Me.Controls.Add(Me.txt_correo)
        Me.Controls.Add(Me.txt_nombre)
        Me.Controls.Add(Me.lbl_correo)
        Me.Controls.Add(Me.lbl_telefono)
        Me.Controls.Add(Me.lbl_nombre)
        Me.Name = "ABM_Proveedores"
        Me.Text = "ABM_Proveedores"
        CType(Me.grid_proveedores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_nombre As System.Windows.Forms.Label
    Friend WithEvents lbl_telefono As System.Windows.Forms.Label
    Friend WithEvents lbl_correo As System.Windows.Forms.Label
    Friend WithEvents txt_nombre As System.Windows.Forms.TextBox
    Friend WithEvents txt_correo As System.Windows.Forms.TextBox
    Friend WithEvents txt_telefono As System.Windows.Forms.TextBox
    Friend WithEvents cmd_borrar As System.Windows.Forms.Button
    Friend WithEvents cmd_limpiar As System.Windows.Forms.Button
    Friend WithEvents cmd_cancelar As System.Windows.Forms.Button
    Friend WithEvents cmd_guardar As System.Windows.Forms.Button
    Friend WithEvents grid_proveedores As System.Windows.Forms.DataGridView
    Friend WithEvents c_idProveedor As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents c_nombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents c_correo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents c_telefono As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
