﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ABM_TiposDocumentos
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
        Me.cmd_registrar = New System.Windows.Forms.Button()
        Me.cmd_cancelar = New System.Windows.Forms.Button()
        Me.grid_tipoDoc = New System.Windows.Forms.DataGridView()
        Me.lbl_tipoDocumento = New System.Windows.Forms.Label()
        Me.lbl_nombre = New System.Windows.Forms.Label()
        Me.lbl_descripcion = New System.Windows.Forms.Label()
        Me.txt_idDoc = New System.Windows.Forms.TextBox()
        Me.txt_nombre = New System.Windows.Forms.TextBox()
        Me.txt_descripcion = New System.Windows.Forms.TextBox()
        Me.cmd_limpiar = New System.Windows.Forms.Button()
        Me.c_idDoc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.c_nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.c_descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.grid_tipoDoc, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmd_registrar
        '
        Me.cmd_registrar.Location = New System.Drawing.Point(198, 322)
        Me.cmd_registrar.Name = "cmd_registrar"
        Me.cmd_registrar.Size = New System.Drawing.Size(75, 23)
        Me.cmd_registrar.TabIndex = 20
        Me.cmd_registrar.Text = "Registrar"
        Me.cmd_registrar.UseVisualStyleBackColor = True
        '
        'cmd_cancelar
        '
        Me.cmd_cancelar.Location = New System.Drawing.Point(279, 322)
        Me.cmd_cancelar.Name = "cmd_cancelar"
        Me.cmd_cancelar.Size = New System.Drawing.Size(75, 23)
        Me.cmd_cancelar.TabIndex = 21
        Me.cmd_cancelar.Text = "Cancelar"
        Me.cmd_cancelar.UseVisualStyleBackColor = True
        '
        'grid_tipoDoc
        '
        Me.grid_tipoDoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grid_tipoDoc.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.c_idDoc, Me.c_nombre, Me.c_descripcion})
        Me.grid_tipoDoc.Location = New System.Drawing.Point(12, 100)
        Me.grid_tipoDoc.Name = "grid_tipoDoc"
        Me.grid_tipoDoc.Size = New System.Drawing.Size(365, 216)
        Me.grid_tipoDoc.TabIndex = 23
        '
        'lbl_tipoDocumento
        '
        Me.lbl_tipoDocumento.AutoSize = True
        Me.lbl_tipoDocumento.Location = New System.Drawing.Point(24, 9)
        Me.lbl_tipoDocumento.Name = "lbl_tipoDocumento"
        Me.lbl_tipoDocumento.Size = New System.Drawing.Size(98, 13)
        Me.lbl_tipoDocumento.TabIndex = 24
        Me.lbl_tipoDocumento.Text = "Id Tipo Documento"
        '
        'lbl_nombre
        '
        Me.lbl_nombre.AutoSize = True
        Me.lbl_nombre.Location = New System.Drawing.Point(78, 36)
        Me.lbl_nombre.Name = "lbl_nombre"
        Me.lbl_nombre.Size = New System.Drawing.Size(44, 13)
        Me.lbl_nombre.TabIndex = 25
        Me.lbl_nombre.Text = "Nombre"
        '
        'lbl_descripcion
        '
        Me.lbl_descripcion.AutoSize = True
        Me.lbl_descripcion.Location = New System.Drawing.Point(59, 63)
        Me.lbl_descripcion.Name = "lbl_descripcion"
        Me.lbl_descripcion.Size = New System.Drawing.Size(63, 13)
        Me.lbl_descripcion.TabIndex = 26
        Me.lbl_descripcion.Text = "Descripcion"
        '
        'txt_idDoc
        '
        Me.txt_idDoc.Location = New System.Drawing.Point(127, 6)
        Me.txt_idDoc.Name = "txt_idDoc"
        Me.txt_idDoc.Size = New System.Drawing.Size(250, 20)
        Me.txt_idDoc.TabIndex = 27
        '
        'txt_nombre
        '
        Me.txt_nombre.Location = New System.Drawing.Point(128, 33)
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Size = New System.Drawing.Size(249, 20)
        Me.txt_nombre.TabIndex = 28
        '
        'txt_descripcion
        '
        Me.txt_descripcion.Location = New System.Drawing.Point(128, 60)
        Me.txt_descripcion.Name = "txt_descripcion"
        Me.txt_descripcion.Size = New System.Drawing.Size(249, 20)
        Me.txt_descripcion.TabIndex = 29
        '
        'cmd_limpiar
        '
        Me.cmd_limpiar.Location = New System.Drawing.Point(117, 322)
        Me.cmd_limpiar.Name = "cmd_limpiar"
        Me.cmd_limpiar.Size = New System.Drawing.Size(75, 23)
        Me.cmd_limpiar.TabIndex = 30
        Me.cmd_limpiar.Text = "Limpiar"
        Me.cmd_limpiar.UseVisualStyleBackColor = True
        '
        'c_idDoc
        '
        Me.c_idDoc.HeaderText = "ID Documento"
        Me.c_idDoc.Name = "c_idDoc"
        Me.c_idDoc.Width = 50
        '
        'c_nombre
        '
        Me.c_nombre.HeaderText = "Nombre"
        Me.c_nombre.Name = "c_nombre"
        Me.c_nombre.Width = 70
        '
        'c_descripcion
        '
        Me.c_descripcion.HeaderText = "Descripcion"
        Me.c_descripcion.Name = "c_descripcion"
        Me.c_descripcion.Width = 200
        '
        'ABM_TiposDocumentos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(389, 352)
        Me.Controls.Add(Me.cmd_limpiar)
        Me.Controls.Add(Me.txt_descripcion)
        Me.Controls.Add(Me.txt_nombre)
        Me.Controls.Add(Me.txt_idDoc)
        Me.Controls.Add(Me.lbl_descripcion)
        Me.Controls.Add(Me.lbl_nombre)
        Me.Controls.Add(Me.lbl_tipoDocumento)
        Me.Controls.Add(Me.grid_tipoDoc)
        Me.Controls.Add(Me.cmd_cancelar)
        Me.Controls.Add(Me.cmd_registrar)
        Me.Name = "ABM_TiposDocumentos"
        Me.Text = "Tipos Documentos"
        CType(Me.grid_tipoDoc, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmd_registrar As System.Windows.Forms.Button
    Friend WithEvents cmd_cancelar As System.Windows.Forms.Button
    Friend WithEvents grid_tipoDoc As System.Windows.Forms.DataGridView
    Friend WithEvents lbl_tipoDocumento As System.Windows.Forms.Label
    Friend WithEvents lbl_nombre As System.Windows.Forms.Label
    Friend WithEvents lbl_descripcion As System.Windows.Forms.Label
    Friend WithEvents txt_idDoc As System.Windows.Forms.TextBox
    Friend WithEvents txt_nombre As System.Windows.Forms.TextBox
    Friend WithEvents txt_descripcion As System.Windows.Forms.TextBox
    Friend WithEvents cmd_limpiar As System.Windows.Forms.Button
    Friend WithEvents c_idDoc As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents c_nombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents c_descripcion As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
