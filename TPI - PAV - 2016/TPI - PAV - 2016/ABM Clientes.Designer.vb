<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ABMClientes
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
        Me.lbl_apellido = New System.Windows.Forms.Label()
        Me.lbl_nroDoc = New System.Windows.Forms.Label()
        Me.lbl_tipoDoc = New System.Windows.Forms.Label()
        Me.lbl_fechaNac = New System.Windows.Forms.Label()
        Me.lbl_telefono = New System.Windows.Forms.Label()
        Me.txt_telefono = New System.Windows.Forms.TextBox()
        Me.txt_nombre = New System.Windows.Forms.TextBox()
        Me.txt_apellido = New System.Windows.Forms.TextBox()
        Me.cmb_tipoDoc = New System.Windows.Forms.ComboBox()
        Me.dtp_fecha = New System.Windows.Forms.DateTimePicker()
        Me.txt_nroDoc = New System.Windows.Forms.MaskedTextBox()
        Me.grid_clientes = New System.Windows.Forms.DataGridView()
        Me.cmd_buscar = New System.Windows.Forms.Button()
        Me.cmd_limpiar = New System.Windows.Forms.Button()
        Me.cmd_cancelar = New System.Windows.Forms.Button()
        Me.cmd_registrar = New System.Windows.Forms.Button()
        Me.c_apellido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.c_nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.c_tipoDoc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.c_nroDoc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.c_fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.c_telefono = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.grid_clientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_nombre
        '
        Me.lbl_nombre.AutoSize = True
        Me.lbl_nombre.Location = New System.Drawing.Point(76, 76)
        Me.lbl_nombre.Name = "lbl_nombre"
        Me.lbl_nombre.Size = New System.Drawing.Size(44, 13)
        Me.lbl_nombre.TabIndex = 0
        Me.lbl_nombre.Text = "Nombre"
        '
        'lbl_apellido
        '
        Me.lbl_apellido.AutoSize = True
        Me.lbl_apellido.Location = New System.Drawing.Point(76, 50)
        Me.lbl_apellido.Name = "lbl_apellido"
        Me.lbl_apellido.Size = New System.Drawing.Size(44, 13)
        Me.lbl_apellido.TabIndex = 1
        Me.lbl_apellido.Text = "Apellido"
        '
        'lbl_nroDoc
        '
        Me.lbl_nroDoc.AutoSize = True
        Me.lbl_nroDoc.Location = New System.Drawing.Point(253, 23)
        Me.lbl_nroDoc.Name = "lbl_nroDoc"
        Me.lbl_nroDoc.Size = New System.Drawing.Size(97, 13)
        Me.lbl_nroDoc.TabIndex = 2
        Me.lbl_nroDoc.Text = "Nro de Documento"
        '
        'lbl_tipoDoc
        '
        Me.lbl_tipoDoc.AutoSize = True
        Me.lbl_tipoDoc.Location = New System.Drawing.Point(19, 22)
        Me.lbl_tipoDoc.Name = "lbl_tipoDoc"
        Me.lbl_tipoDoc.Size = New System.Drawing.Size(101, 13)
        Me.lbl_tipoDoc.TabIndex = 3
        Me.lbl_tipoDoc.Text = "Tipo de Documento"
        '
        'lbl_fechaNac
        '
        Me.lbl_fechaNac.AutoSize = True
        Me.lbl_fechaNac.Location = New System.Drawing.Point(12, 99)
        Me.lbl_fechaNac.Name = "lbl_fechaNac"
        Me.lbl_fechaNac.Size = New System.Drawing.Size(108, 13)
        Me.lbl_fechaNac.TabIndex = 4
        Me.lbl_fechaNac.Text = "Fecha de Nacimiento"
        '
        'lbl_telefono
        '
        Me.lbl_telefono.AutoSize = True
        Me.lbl_telefono.Location = New System.Drawing.Point(71, 128)
        Me.lbl_telefono.Name = "lbl_telefono"
        Me.lbl_telefono.Size = New System.Drawing.Size(49, 13)
        Me.lbl_telefono.TabIndex = 5
        Me.lbl_telefono.Text = "Telefono"
        '
        'txt_telefono
        '
        Me.txt_telefono.Location = New System.Drawing.Point(126, 125)
        Me.txt_telefono.Name = "txt_telefono"
        Me.txt_telefono.Size = New System.Drawing.Size(100, 20)
        Me.txt_telefono.TabIndex = 6
        '
        'txt_nombre
        '
        Me.txt_nombre.Location = New System.Drawing.Point(126, 73)
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Size = New System.Drawing.Size(377, 20)
        Me.txt_nombre.TabIndex = 7
        '
        'txt_apellido
        '
        Me.txt_apellido.Location = New System.Drawing.Point(127, 47)
        Me.txt_apellido.Name = "txt_apellido"
        Me.txt_apellido.Size = New System.Drawing.Size(377, 20)
        Me.txt_apellido.TabIndex = 8
        '
        'cmb_tipoDoc
        '
        Me.cmb_tipoDoc.FormattingEnabled = True
        Me.cmb_tipoDoc.Location = New System.Drawing.Point(126, 20)
        Me.cmb_tipoDoc.Name = "cmb_tipoDoc"
        Me.cmb_tipoDoc.Size = New System.Drawing.Size(121, 21)
        Me.cmb_tipoDoc.TabIndex = 9
        '
        'dtp_fecha
        '
        Me.dtp_fecha.Location = New System.Drawing.Point(126, 99)
        Me.dtp_fecha.Name = "dtp_fecha"
        Me.dtp_fecha.Size = New System.Drawing.Size(217, 20)
        Me.dtp_fecha.TabIndex = 16
        '
        'txt_nroDoc
        '
        Me.txt_nroDoc.Location = New System.Drawing.Point(356, 20)
        Me.txt_nroDoc.Mask = "999999999"
        Me.txt_nroDoc.Name = "txt_nroDoc"
        Me.txt_nroDoc.Size = New System.Drawing.Size(66, 20)
        Me.txt_nroDoc.TabIndex = 17
        '
        'grid_clientes
        '
        Me.grid_clientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grid_clientes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.c_apellido, Me.c_nombre, Me.c_tipoDoc, Me.c_nroDoc, Me.c_fecha, Me.c_telefono})
        Me.grid_clientes.Location = New System.Drawing.Point(12, 180)
        Me.grid_clientes.Name = "grid_clientes"
        Me.grid_clientes.Size = New System.Drawing.Size(491, 297)
        Me.grid_clientes.TabIndex = 18
        '
        'cmd_buscar
        '
        Me.cmd_buscar.Location = New System.Drawing.Point(428, 17)
        Me.cmd_buscar.Name = "cmd_buscar"
        Me.cmd_buscar.Size = New System.Drawing.Size(75, 23)
        Me.cmd_buscar.TabIndex = 19
        Me.cmd_buscar.Text = "Buscar"
        Me.cmd_buscar.UseVisualStyleBackColor = True
        '
        'cmd_limpiar
        '
        Me.cmd_limpiar.Location = New System.Drawing.Point(266, 483)
        Me.cmd_limpiar.Name = "cmd_limpiar"
        Me.cmd_limpiar.Size = New System.Drawing.Size(75, 23)
        Me.cmd_limpiar.TabIndex = 22
        Me.cmd_limpiar.Text = "Limpiar"
        Me.cmd_limpiar.UseVisualStyleBackColor = True
        '
        'cmd_cancelar
        '
        Me.cmd_cancelar.Location = New System.Drawing.Point(428, 483)
        Me.cmd_cancelar.Name = "cmd_cancelar"
        Me.cmd_cancelar.Size = New System.Drawing.Size(75, 23)
        Me.cmd_cancelar.TabIndex = 21
        Me.cmd_cancelar.Text = "Cancelar"
        Me.cmd_cancelar.UseVisualStyleBackColor = True
        '
        'cmd_registrar
        '
        Me.cmd_registrar.Location = New System.Drawing.Point(347, 483)
        Me.cmd_registrar.Name = "cmd_registrar"
        Me.cmd_registrar.Size = New System.Drawing.Size(75, 23)
        Me.cmd_registrar.TabIndex = 20
        Me.cmd_registrar.Text = "Registrar"
        Me.cmd_registrar.UseVisualStyleBackColor = True
        '
        'c_apellido
        '
        Me.c_apellido.HeaderText = "Apellido"
        Me.c_apellido.Name = "c_apellido"
        '
        'c_nombre
        '
        Me.c_nombre.HeaderText = "Nombre"
        Me.c_nombre.Name = "c_nombre"
        '
        'c_tipoDoc
        '
        Me.c_tipoDoc.HeaderText = "Tipo Doc."
        Me.c_tipoDoc.Name = "c_tipoDoc"
        Me.c_tipoDoc.Width = 40
        '
        'c_nroDoc
        '
        Me.c_nroDoc.HeaderText = "Nro Documento"
        Me.c_nroDoc.Name = "c_nroDoc"
        Me.c_nroDoc.Width = 70
        '
        'c_fecha
        '
        Me.c_fecha.HeaderText = "Fecha de Nacimiento"
        Me.c_fecha.Name = "c_fecha"
        Me.c_fecha.Width = 70
        '
        'c_telefono
        '
        Me.c_telefono.HeaderText = "Telefono"
        Me.c_telefono.Name = "c_telefono"
        Me.c_telefono.Width = 70
        '
        'ABMClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(516, 511)
        Me.Controls.Add(Me.cmd_limpiar)
        Me.Controls.Add(Me.cmd_cancelar)
        Me.Controls.Add(Me.cmd_registrar)
        Me.Controls.Add(Me.cmd_buscar)
        Me.Controls.Add(Me.grid_clientes)
        Me.Controls.Add(Me.txt_nroDoc)
        Me.Controls.Add(Me.dtp_fecha)
        Me.Controls.Add(Me.cmb_tipoDoc)
        Me.Controls.Add(Me.txt_apellido)
        Me.Controls.Add(Me.txt_nombre)
        Me.Controls.Add(Me.txt_telefono)
        Me.Controls.Add(Me.lbl_telefono)
        Me.Controls.Add(Me.lbl_fechaNac)
        Me.Controls.Add(Me.lbl_tipoDoc)
        Me.Controls.Add(Me.lbl_nroDoc)
        Me.Controls.Add(Me.lbl_apellido)
        Me.Controls.Add(Me.lbl_nombre)
        Me.Name = "ABMClientes"
        Me.Text = "Clientes"
        CType(Me.grid_clientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_nombre As System.Windows.Forms.Label
    Friend WithEvents lbl_apellido As System.Windows.Forms.Label
    Friend WithEvents lbl_nroDoc As System.Windows.Forms.Label
    Friend WithEvents lbl_tipoDoc As System.Windows.Forms.Label
    Friend WithEvents lbl_fechaNac As System.Windows.Forms.Label
    Friend WithEvents lbl_telefono As System.Windows.Forms.Label
    Friend WithEvents txt_telefono As System.Windows.Forms.TextBox
    Friend WithEvents txt_nombre As System.Windows.Forms.TextBox
    Friend WithEvents txt_apellido As System.Windows.Forms.TextBox
    Friend WithEvents cmb_tipoDoc As System.Windows.Forms.ComboBox
    Friend WithEvents dtp_fecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents txt_nroDoc As System.Windows.Forms.MaskedTextBox
    Friend WithEvents grid_clientes As System.Windows.Forms.DataGridView
    Friend WithEvents cmd_buscar As System.Windows.Forms.Button
    Friend WithEvents cmd_limpiar As System.Windows.Forms.Button
    Friend WithEvents cmd_cancelar As System.Windows.Forms.Button
    Friend WithEvents cmd_registrar As System.Windows.Forms.Button
    Friend WithEvents c_apellido As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents c_nombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents c_tipoDoc As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents c_nroDoc As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents c_fecha As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents c_telefono As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
