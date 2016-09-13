<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ABM_Clientes
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
        Me.lbl_tipoDoc = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmb_tipoDoc = New System.Windows.Forms.ComboBox()
        Me.txt_nroDoc = New System.Windows.Forms.MaskedTextBox()
        Me.cmd_buscar = New System.Windows.Forms.Button()
        Me.lbl_apellido = New System.Windows.Forms.Label()
        Me.lbl_nombre = New System.Windows.Forms.Label()
        Me.txt_apellido = New System.Windows.Forms.TextBox()
        Me.lbl_fecha = New System.Windows.Forms.Label()
        Me.txt_nombre = New System.Windows.Forms.TextBox()
        Me.dtpEstimada = New System.Windows.Forms.DateTimePicker()
        Me.lbl_telefono = New System.Windows.Forms.Label()
        Me.txt_telefono = New System.Windows.Forms.TextBox()
        Me.cmd_limpiar = New System.Windows.Forms.Button()
        Me.cmd_cancelar = New System.Windows.Forms.Button()
        Me.cmd_registrar = New System.Windows.Forms.Button()
        Me.grid_clientes = New System.Windows.Forms.DataGridView()
        Me.col_apellido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_tipoDocumento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_nroDocumento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.grid_clientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_tipoDoc
        '
        Me.lbl_tipoDoc.AutoSize = True
        Me.lbl_tipoDoc.Location = New System.Drawing.Point(13, 13)
        Me.lbl_tipoDoc.Name = "lbl_tipoDoc"
        Me.lbl_tipoDoc.Size = New System.Drawing.Size(101, 13)
        Me.lbl_tipoDoc.TabIndex = 0
        Me.lbl_tipoDoc.Text = "Tipo de Documento"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(219, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Nro de Documento"
        '
        'cmb_tipoDoc
        '
        Me.cmb_tipoDoc.FormattingEnabled = True
        Me.cmb_tipoDoc.Location = New System.Drawing.Point(120, 10)
        Me.cmb_tipoDoc.Name = "cmb_tipoDoc"
        Me.cmb_tipoDoc.Size = New System.Drawing.Size(93, 21)
        Me.cmb_tipoDoc.TabIndex = 3
        '
        'txt_nroDoc
        '
        Me.txt_nroDoc.Location = New System.Drawing.Point(322, 10)
        Me.txt_nroDoc.Mask = "999999999"
        Me.txt_nroDoc.Name = "txt_nroDoc"
        Me.txt_nroDoc.Size = New System.Drawing.Size(64, 20)
        Me.txt_nroDoc.TabIndex = 4
        '
        'cmd_buscar
        '
        Me.cmd_buscar.Location = New System.Drawing.Point(396, 8)
        Me.cmd_buscar.Name = "cmd_buscar"
        Me.cmd_buscar.Size = New System.Drawing.Size(75, 23)
        Me.cmd_buscar.TabIndex = 5
        Me.cmd_buscar.Text = "Buscar"
        Me.cmd_buscar.UseVisualStyleBackColor = True
        '
        'lbl_apellido
        '
        Me.lbl_apellido.AutoSize = True
        Me.lbl_apellido.Location = New System.Drawing.Point(70, 39)
        Me.lbl_apellido.Name = "lbl_apellido"
        Me.lbl_apellido.Size = New System.Drawing.Size(44, 13)
        Me.lbl_apellido.TabIndex = 6
        Me.lbl_apellido.Text = "Apellido"
        '
        'lbl_nombre
        '
        Me.lbl_nombre.AutoSize = True
        Me.lbl_nombre.Location = New System.Drawing.Point(70, 65)
        Me.lbl_nombre.Name = "lbl_nombre"
        Me.lbl_nombre.Size = New System.Drawing.Size(44, 13)
        Me.lbl_nombre.TabIndex = 7
        Me.lbl_nombre.Text = "Nombre"
        '
        'txt_apellido
        '
        Me.txt_apellido.Location = New System.Drawing.Point(120, 36)
        Me.txt_apellido.Name = "txt_apellido"
        Me.txt_apellido.Size = New System.Drawing.Size(352, 20)
        Me.txt_apellido.TabIndex = 8
        '
        'lbl_fecha
        '
        Me.lbl_fecha.AutoSize = True
        Me.lbl_fecha.Location = New System.Drawing.Point(6, 91)
        Me.lbl_fecha.Name = "lbl_fecha"
        Me.lbl_fecha.Size = New System.Drawing.Size(108, 13)
        Me.lbl_fecha.TabIndex = 9
        Me.lbl_fecha.Text = "Fecha de Nacimiento"
        '
        'txt_nombre
        '
        Me.txt_nombre.Location = New System.Drawing.Point(120, 62)
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Size = New System.Drawing.Size(351, 20)
        Me.txt_nombre.TabIndex = 10
        '
        'dtpEstimada
        '
        Me.dtpEstimada.Location = New System.Drawing.Point(120, 88)
        Me.dtpEstimada.Name = "dtpEstimada"
        Me.dtpEstimada.Size = New System.Drawing.Size(200, 20)
        Me.dtpEstimada.TabIndex = 17
        '
        'lbl_telefono
        '
        Me.lbl_telefono.AutoSize = True
        Me.lbl_telefono.Location = New System.Drawing.Point(65, 115)
        Me.lbl_telefono.Name = "lbl_telefono"
        Me.lbl_telefono.Size = New System.Drawing.Size(49, 13)
        Me.lbl_telefono.TabIndex = 18
        Me.lbl_telefono.Text = "Telefono"
        '
        'txt_telefono
        '
        Me.txt_telefono.Location = New System.Drawing.Point(120, 112)
        Me.txt_telefono.Name = "txt_telefono"
        Me.txt_telefono.Size = New System.Drawing.Size(100, 20)
        Me.txt_telefono.TabIndex = 19
        '
        'cmd_limpiar
        '
        Me.cmd_limpiar.Location = New System.Drawing.Point(236, 411)
        Me.cmd_limpiar.Name = "cmd_limpiar"
        Me.cmd_limpiar.Size = New System.Drawing.Size(75, 23)
        Me.cmd_limpiar.TabIndex = 23
        Me.cmd_limpiar.Text = "Limpiar"
        Me.cmd_limpiar.UseVisualStyleBackColor = True
        '
        'cmd_cancelar
        '
        Me.cmd_cancelar.Location = New System.Drawing.Point(398, 411)
        Me.cmd_cancelar.Name = "cmd_cancelar"
        Me.cmd_cancelar.Size = New System.Drawing.Size(75, 23)
        Me.cmd_cancelar.TabIndex = 22
        Me.cmd_cancelar.Text = "Cancelar"
        Me.cmd_cancelar.UseVisualStyleBackColor = True
        '
        'cmd_registrar
        '
        Me.cmd_registrar.Location = New System.Drawing.Point(317, 411)
        Me.cmd_registrar.Name = "cmd_registrar"
        Me.cmd_registrar.Size = New System.Drawing.Size(75, 23)
        Me.cmd_registrar.TabIndex = 21
        Me.cmd_registrar.Text = "Registrar"
        Me.cmd_registrar.UseVisualStyleBackColor = True
        '
        'grid_clientes
        '
        Me.grid_clientes.AllowUserToOrderColumns = True
        Me.grid_clientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grid_clientes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_apellido, Me.col_nombre, Me.col_tipoDocumento, Me.col_nroDocumento})
        Me.grid_clientes.Location = New System.Drawing.Point(9, 140)
        Me.grid_clientes.Name = "grid_clientes"
        Me.grid_clientes.Size = New System.Drawing.Size(463, 265)
        Me.grid_clientes.TabIndex = 24
        '
        'col_apellido
        '
        Me.col_apellido.HeaderText = "Apellido"
        Me.col_apellido.Name = "col_apellido"
        Me.col_apellido.ReadOnly = True
        '
        'col_nombre
        '
        Me.col_nombre.HeaderText = "Nombre"
        Me.col_nombre.Name = "col_nombre"
        Me.col_nombre.ReadOnly = True
        '
        'col_tipoDocumento
        '
        Me.col_tipoDocumento.HeaderText = "Tipo Documento"
        Me.col_tipoDocumento.Name = "col_tipoDocumento"
        Me.col_tipoDocumento.ReadOnly = True
        '
        'col_nroDocumento
        '
        Me.col_nroDocumento.HeaderText = "Número Documento"
        Me.col_nroDocumento.Name = "col_nroDocumento"
        Me.col_nroDocumento.ReadOnly = True
        '
        'ABM_Clientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(484, 439)
        Me.Controls.Add(Me.grid_clientes)
        Me.Controls.Add(Me.cmd_limpiar)
        Me.Controls.Add(Me.cmd_cancelar)
        Me.Controls.Add(Me.cmd_registrar)
        Me.Controls.Add(Me.txt_telefono)
        Me.Controls.Add(Me.lbl_telefono)
        Me.Controls.Add(Me.dtpEstimada)
        Me.Controls.Add(Me.txt_nombre)
        Me.Controls.Add(Me.lbl_fecha)
        Me.Controls.Add(Me.txt_apellido)
        Me.Controls.Add(Me.lbl_nombre)
        Me.Controls.Add(Me.lbl_apellido)
        Me.Controls.Add(Me.cmd_buscar)
        Me.Controls.Add(Me.txt_nroDoc)
        Me.Controls.Add(Me.cmb_tipoDoc)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbl_tipoDoc)
        Me.Name = "ABM_Clientes"
        Me.Text = "Clientes"
        CType(Me.grid_clientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_tipoDoc As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmb_tipoDoc As System.Windows.Forms.ComboBox
    Friend WithEvents txt_nroDoc As System.Windows.Forms.MaskedTextBox
    Friend WithEvents cmd_buscar As System.Windows.Forms.Button
    Friend WithEvents lbl_apellido As System.Windows.Forms.Label
    Friend WithEvents lbl_nombre As System.Windows.Forms.Label
    Friend WithEvents txt_apellido As System.Windows.Forms.TextBox
    Friend WithEvents lbl_fecha As System.Windows.Forms.Label
    Friend WithEvents txt_nombre As System.Windows.Forms.TextBox
    Friend WithEvents dtpEstimada As System.Windows.Forms.DateTimePicker
    Friend WithEvents lbl_telefono As System.Windows.Forms.Label
    Friend WithEvents txt_telefono As System.Windows.Forms.TextBox
    Friend WithEvents cmd_limpiar As System.Windows.Forms.Button
    Friend WithEvents cmd_cancelar As System.Windows.Forms.Button
    Friend WithEvents cmd_registrar As System.Windows.Forms.Button
    Friend WithEvents grid_clientes As System.Windows.Forms.DataGridView
    Friend WithEvents col_apellido As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_nombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_tipoDocumento As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_nroDocumento As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
