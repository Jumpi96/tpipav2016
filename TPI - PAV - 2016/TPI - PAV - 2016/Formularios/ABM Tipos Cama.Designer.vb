<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ABM_Tipos_Cama
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
        Me.grid_grilla = New System.Windows.Forms.DataGridView()
        Me.idTipoCama = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cmd_cancelar = New System.Windows.Forms.Button()
        Me.cmd_registrar = New System.Windows.Forms.Button()
        Me.cmd_limpiar = New System.Windows.Forms.Button()
        Me.cmd_borrar = New System.Windows.Forms.Button()
        CType(Me.grid_grilla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_nombre
        '
        Me.lbl_nombre.AutoSize = True
        Me.lbl_nombre.Location = New System.Drawing.Point(78, 14)
        Me.lbl_nombre.Name = "lbl_nombre"
        Me.lbl_nombre.Size = New System.Drawing.Size(44, 13)
        Me.lbl_nombre.TabIndex = 0
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
        'grid_grilla
        '
        Me.grid_grilla.AllowUserToAddRows = False
        Me.grid_grilla.AllowUserToDeleteRows = False
        Me.grid_grilla.AllowUserToOrderColumns = True
        Me.grid_grilla.AllowUserToResizeColumns = False
        Me.grid_grilla.AllowUserToResizeRows = False
        Me.grid_grilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grid_grilla.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idTipoCama, Me.nombre, Me.descripcion})
        Me.grid_grilla.Location = New System.Drawing.Point(12, 71)
        Me.grid_grilla.Name = "grid_grilla"
        Me.grid_grilla.Size = New System.Drawing.Size(365, 216)
        Me.grid_grilla.TabIndex = 4
        '
        'idTipoCama
        '
        Me.idTipoCama.HeaderText = "ID Tipo"
        Me.idTipoCama.Name = "idTipoCama"
        '
        'nombre
        '
        Me.nombre.HeaderText = "Nombre"
        Me.nombre.Name = "nombre"
        '
        'descripcion
        '
        Me.descripcion.HeaderText = "Descripcion"
        Me.descripcion.Name = "descripcion"
        '
        'cmd_cancelar
        '
        Me.cmd_cancelar.Location = New System.Drawing.Point(302, 294)
        Me.cmd_cancelar.Name = "cmd_cancelar"
        Me.cmd_cancelar.Size = New System.Drawing.Size(75, 23)
        Me.cmd_cancelar.TabIndex = 5
        Me.cmd_cancelar.Text = "Cancelar"
        Me.cmd_cancelar.UseVisualStyleBackColor = True
        '
        'cmd_registrar
        '
        Me.cmd_registrar.Location = New System.Drawing.Point(221, 293)
        Me.cmd_registrar.Name = "cmd_registrar"
        Me.cmd_registrar.Size = New System.Drawing.Size(75, 23)
        Me.cmd_registrar.TabIndex = 4
        Me.cmd_registrar.Text = "Registrar"
        Me.cmd_registrar.UseVisualStyleBackColor = True
        '
        'cmd_limpiar
        '
        Me.cmd_limpiar.Location = New System.Drawing.Point(140, 293)
        Me.cmd_limpiar.Name = "cmd_limpiar"
        Me.cmd_limpiar.Size = New System.Drawing.Size(75, 23)
        Me.cmd_limpiar.TabIndex = 3
        Me.cmd_limpiar.Text = "Limpiar"
        Me.cmd_limpiar.UseVisualStyleBackColor = True
        '
        'cmd_borrar
        '
        Me.cmd_borrar.Location = New System.Drawing.Point(12, 293)
        Me.cmd_borrar.Name = "cmd_borrar"
        Me.cmd_borrar.Size = New System.Drawing.Size(75, 23)
        Me.cmd_borrar.TabIndex = 2
        Me.cmd_borrar.Text = "Borrar"
        Me.cmd_borrar.UseVisualStyleBackColor = True
        '
        'ABM_Tipos_Cama
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(389, 329)
        Me.Controls.Add(Me.cmd_borrar)
        Me.Controls.Add(Me.cmd_limpiar)
        Me.Controls.Add(Me.cmd_registrar)
        Me.Controls.Add(Me.cmd_cancelar)
        Me.Controls.Add(Me.grid_grilla)
        Me.Controls.Add(Me.txt_descripcion)
        Me.Controls.Add(Me.txt_nombre)
        Me.Controls.Add(Me.lbl_descripcion)
        Me.Controls.Add(Me.lbl_nombre)
        Me.Name = "ABM_Tipos_Cama"
        Me.Text = "ABM Tipos Cama"
        CType(Me.grid_grilla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_nombre As System.Windows.Forms.Label
    Friend WithEvents lbl_descripcion As System.Windows.Forms.Label
    Friend WithEvents txt_nombre As System.Windows.Forms.TextBox
    Friend WithEvents txt_descripcion As System.Windows.Forms.TextBox
    Friend WithEvents grid_grilla As System.Windows.Forms.DataGridView
    Friend WithEvents cmd_cancelar As System.Windows.Forms.Button
    Friend WithEvents cmd_registrar As System.Windows.Forms.Button
    Friend WithEvents cmd_limpiar As System.Windows.Forms.Button
    Friend WithEvents cmd_borrar As System.Windows.Forms.Button
    Friend WithEvents idTipoCama As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents descripcion As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
