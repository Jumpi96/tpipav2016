<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ABM_TiposHabitacion
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.cmd_guardar = New System.Windows.Forms.Button()
        Me.cmd_cancelar = New System.Windows.Forms.Button()
        Me.grid_tipoDoc = New System.Windows.Forms.DataGridView()
        Me.c_idHab = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.c_nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.c_descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lbl_nombre = New System.Windows.Forms.Label()
        Me.lbl_descripcion = New System.Windows.Forms.Label()
        Me.txt_nombre = New System.Windows.Forms.TextBox()
        Me.txt_descripcion = New System.Windows.Forms.TextBox()
        Me.cmd_limpiar = New System.Windows.Forms.Button()
        Me.cmd_borrar = New System.Windows.Forms.Button()
        CType(Me.grid_tipoDoc, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmd_guardar
        '
        Me.cmd_guardar.Location = New System.Drawing.Point(221, 293)
        Me.cmd_guardar.Name = "cmd_guardar"
        Me.cmd_guardar.Size = New System.Drawing.Size(75, 23)
        Me.cmd_guardar.TabIndex = 3
        Me.cmd_guardar.Text = "Registrar"
        Me.cmd_guardar.UseVisualStyleBackColor = True
        '
        'cmd_cancelar
        '
        Me.cmd_cancelar.Location = New System.Drawing.Point(302, 293)
        Me.cmd_cancelar.Name = "cmd_cancelar"
        Me.cmd_cancelar.Size = New System.Drawing.Size(75, 23)
        Me.cmd_cancelar.TabIndex = 4
        Me.cmd_cancelar.Text = "Cancelar"
        Me.cmd_cancelar.UseVisualStyleBackColor = True
        '
        'grid_tipoDoc
        '
        Me.grid_tipoDoc.AllowUserToAddRows = False
        Me.grid_tipoDoc.AllowUserToDeleteRows = False
        Me.grid_tipoDoc.AllowUserToResizeColumns = False
        Me.grid_tipoDoc.AllowUserToResizeRows = False
        Me.grid_tipoDoc.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.c_idHab, Me.c_nombre, Me.c_descripcion})
        Me.grid_tipoDoc.Location = New System.Drawing.Point(12, 71)
        Me.grid_tipoDoc.Name = "grid_tipoDoc"
        Me.grid_tipoDoc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grid_tipoDoc.Size = New System.Drawing.Size(365, 216)
        Me.grid_tipoDoc.TabIndex = 6
        '
        'c_idHab
        '
        Me.c_idHab.FillWeight = 200.0!
        Me.c_idHab.HeaderText = "ID Tipo"
        Me.c_idHab.Name = "c_idHab"
        Me.c_idHab.Width = 50
        '
        'c_nombre
        '
        Me.c_nombre.HeaderText = "Nombre"
        Me.c_nombre.Name = "c_nombre"
        '
        'c_descripcion
        '
        Me.c_descripcion.FillWeight = 90.0!
        Me.c_descripcion.HeaderText = "Descripcion"
        Me.c_descripcion.Name = "c_descripcion"
        Me.c_descripcion.Width = 150
        '
        'lbl_nombre
        '
        Me.lbl_nombre.AutoSize = True
        Me.lbl_nombre.Location = New System.Drawing.Point(78, 14)
        Me.lbl_nombre.Name = "lbl_nombre"
        Me.lbl_nombre.Size = New System.Drawing.Size(44, 13)
        Me.lbl_nombre.TabIndex = 25
        Me.lbl_nombre.Text = "Nombre"
        '
        'lbl_descripcion
        '
        Me.lbl_descripcion.AutoSize = True
        Me.lbl_descripcion.Location = New System.Drawing.Point(59, 41)
        Me.lbl_descripcion.Name = "lbl_descripcion"
        Me.lbl_descripcion.Size = New System.Drawing.Size(63, 13)
        Me.lbl_descripcion.TabIndex = 26
        Me.lbl_descripcion.Text = "Descripcion"
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
        Me.txt_descripcion.Size = New System.Drawing.Size(249, 20)
        Me.txt_descripcion.TabIndex = 1
        '
        'cmd_limpiar
        '
        Me.cmd_limpiar.Location = New System.Drawing.Point(140, 293)
        Me.cmd_limpiar.Name = "cmd_limpiar"
        Me.cmd_limpiar.Size = New System.Drawing.Size(75, 23)
        Me.cmd_limpiar.TabIndex = 2
        Me.cmd_limpiar.Text = "Limpiar"
        Me.cmd_limpiar.UseVisualStyleBackColor = True
        '
        'cmd_borrar
        '
        Me.cmd_borrar.Location = New System.Drawing.Point(12, 293)
        Me.cmd_borrar.Name = "cmd_borrar"
        Me.cmd_borrar.Size = New System.Drawing.Size(75, 23)
        Me.cmd_borrar.TabIndex = 27
        Me.cmd_borrar.Text = "Borrar"
        Me.cmd_borrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cmd_borrar.UseVisualStyleBackColor = True
        '
        'ABM_TiposHabitacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(389, 329)
        Me.Controls.Add(Me.cmd_borrar)
        Me.Controls.Add(Me.cmd_limpiar)
        Me.Controls.Add(Me.txt_descripcion)
        Me.Controls.Add(Me.txt_nombre)
        Me.Controls.Add(Me.lbl_descripcion)
        Me.Controls.Add(Me.lbl_nombre)
        Me.Controls.Add(Me.grid_tipoDoc)
        Me.Controls.Add(Me.cmd_cancelar)
        Me.Controls.Add(Me.cmd_guardar)
        Me.Name = "ABM_TiposHabitacion"
        Me.Text = "ABM Tipos Habitación"
        CType(Me.grid_tipoDoc, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmd_guardar As System.Windows.Forms.Button
    Friend WithEvents cmd_cancelar As System.Windows.Forms.Button
    Friend WithEvents grid_tipoDoc As System.Windows.Forms.DataGridView
    Friend WithEvents lbl_nombre As System.Windows.Forms.Label
    Friend WithEvents lbl_descripcion As System.Windows.Forms.Label
    Friend WithEvents txt_nombre As System.Windows.Forms.TextBox
    Friend WithEvents txt_descripcion As System.Windows.Forms.TextBox
    Friend WithEvents cmd_limpiar As System.Windows.Forms.Button
    Friend WithEvents cmd_borrar As System.Windows.Forms.Button
    Friend WithEvents c_idHab As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents c_nombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents c_descripcion As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
