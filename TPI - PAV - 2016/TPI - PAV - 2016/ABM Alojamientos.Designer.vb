<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ABM_Alojamientos
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
        Me.dgvAlojamientos = New System.Windows.Forms.DataGridView()
        Me.fechaIngreso = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fechaFin = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Habitacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnRegistrar = New System.Windows.Forms.Button()
        Me.cmbTipoDoc = New System.Windows.Forms.ComboBox()
        Me.txtNroDoc = New System.Windows.Forms.TextBox()
        Me.txtHabitacion = New System.Windows.Forms.MaskedTextBox()
        Me.txtAlojados = New System.Windows.Forms.TextBox()
        Me.dtpIngreso = New System.Windows.Forms.DateTimePicker()
        Me.dtpEstimada = New System.Windows.Forms.DateTimePicker()
        Me.dtpSalida = New System.Windows.Forms.DateTimePicker()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.btnBuscarPorDoc = New System.Windows.Forms.Button()
        Me.txtPrecio = New System.Windows.Forms.MaskedTextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        CType(Me.dgvAlojamientos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvAlojamientos
        '
        Me.dgvAlojamientos.AllowUserToAddRows = False
        Me.dgvAlojamientos.AllowUserToDeleteRows = False
        Me.dgvAlojamientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAlojamientos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.fechaIngreso, Me.fechaFin, Me.Habitacion})
        Me.dgvAlojamientos.Location = New System.Drawing.Point(11, 204)
        Me.dgvAlojamientos.Name = "dgvAlojamientos"
        Me.dgvAlojamientos.ReadOnly = True
        Me.dgvAlojamientos.Size = New System.Drawing.Size(350, 186)
        Me.dgvAlojamientos.TabIndex = 11
        '
        'fechaIngreso
        '
        Me.fechaIngreso.HeaderText = "Ingreso"
        Me.fechaIngreso.Name = "fechaIngreso"
        Me.fechaIngreso.ReadOnly = True
        '
        'fechaFin
        '
        Me.fechaFin.HeaderText = "Salida"
        Me.fechaFin.Name = "fechaFin"
        Me.fechaFin.ReadOnly = True
        '
        'Habitacion
        '
        Me.Habitacion.HeaderText = "Habitación"
        Me.Habitacion.Name = "Habitacion"
        Me.Habitacion.ReadOnly = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Tipo Doc."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(11, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nro. Doc."
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(11, 75)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Habitación"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 88)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(0, 13)
        Me.Label4.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(162, 75)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(101, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Número de alojados"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(11, 104)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(89, 13)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Fecha de ingreso"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(11, 127)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(127, 13)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Fecha estimada de salida"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(11, 152)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(82, 13)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Fecha de salida"
        '
        'btnRegistrar
        '
        Me.btnRegistrar.Location = New System.Drawing.Point(205, 396)
        Me.btnRegistrar.Name = "btnRegistrar"
        Me.btnRegistrar.Size = New System.Drawing.Size(75, 23)
        Me.btnRegistrar.TabIndex = 7
        Me.btnRegistrar.Text = "Registrar"
        Me.btnRegistrar.UseVisualStyleBackColor = True
        '
        'cmbTipoDoc
        '
        Me.cmbTipoDoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTipoDoc.FormattingEnabled = True
        Me.cmbTipoDoc.Location = New System.Drawing.Point(69, 19)
        Me.cmbTipoDoc.Name = "cmbTipoDoc"
        Me.cmbTipoDoc.Size = New System.Drawing.Size(139, 21)
        Me.cmbTipoDoc.TabIndex = 0
        '
        'txtNroDoc
        '
        Me.txtNroDoc.Location = New System.Drawing.Point(70, 46)
        Me.txtNroDoc.Name = "txtNroDoc"
        Me.txtNroDoc.Size = New System.Drawing.Size(138, 20)
        Me.txtNroDoc.TabIndex = 1
        '
        'txtHabitacion
        '
        Me.txtHabitacion.Location = New System.Drawing.Point(75, 72)
        Me.txtHabitacion.Mask = "999"
        Me.txtHabitacion.Name = "txtHabitacion"
        Me.txtHabitacion.Size = New System.Drawing.Size(30, 20)
        Me.txtHabitacion.TabIndex = 2
        '
        'txtAlojados
        '
        Me.txtAlojados.Location = New System.Drawing.Point(269, 72)
        Me.txtAlojados.Name = "txtAlojados"
        Me.txtAlojados.Size = New System.Drawing.Size(30, 20)
        Me.txtAlojados.TabIndex = 3
        '
        'dtpIngreso
        '
        Me.dtpIngreso.Location = New System.Drawing.Point(145, 100)
        Me.dtpIngreso.Name = "dtpIngreso"
        Me.dtpIngreso.Size = New System.Drawing.Size(200, 20)
        Me.dtpIngreso.TabIndex = 4
        '
        'dtpEstimada
        '
        Me.dtpEstimada.Location = New System.Drawing.Point(145, 127)
        Me.dtpEstimada.Name = "dtpEstimada"
        Me.dtpEstimada.Size = New System.Drawing.Size(200, 20)
        Me.dtpEstimada.TabIndex = 5
        '
        'dtpSalida
        '
        Me.dtpSalida.Location = New System.Drawing.Point(145, 152)
        Me.dtpSalida.Name = "dtpSalida"
        Me.dtpSalida.Size = New System.Drawing.Size(200, 20)
        Me.dtpSalida.TabIndex = 6
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(286, 396)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 8
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Location = New System.Drawing.Point(11, 420)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(75, 23)
        Me.btnLimpiar.TabIndex = 10
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'btnBuscarPorDoc
        '
        Me.btnBuscarPorDoc.Location = New System.Drawing.Point(234, 22)
        Me.btnBuscarPorDoc.Name = "btnBuscarPorDoc"
        Me.btnBuscarPorDoc.Size = New System.Drawing.Size(111, 37)
        Me.btnBuscarPorDoc.TabIndex = 9
        Me.btnBuscarPorDoc.Text = "Buscar por Documento"
        Me.btnBuscarPorDoc.UseVisualStyleBackColor = True
        '
        'txtPrecio
        '
        Me.txtPrecio.Location = New System.Drawing.Point(104, 178)
        Me.txtPrecio.Mask = "9999,99"
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.Size = New System.Drawing.Size(100, 20)
        Me.txtPrecio.TabIndex = 12
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(12, 181)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(74, 13)
        Me.Label9.TabIndex = 13
        Me.Label9.Text = "Precio por día"
        '
        'ABM_Alojamientos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(373, 455)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtPrecio)
        Me.Controls.Add(Me.btnBuscarPorDoc)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.dtpSalida)
        Me.Controls.Add(Me.dtpEstimada)
        Me.Controls.Add(Me.dtpIngreso)
        Me.Controls.Add(Me.txtAlojados)
        Me.Controls.Add(Me.txtHabitacion)
        Me.Controls.Add(Me.txtNroDoc)
        Me.Controls.Add(Me.cmbTipoDoc)
        Me.Controls.Add(Me.btnRegistrar)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgvAlojamientos)
        Me.Name = "ABM_Alojamientos"
        Me.Text = "Alojamientos"
        CType(Me.dgvAlojamientos,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents dgvAlojamientos As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btnRegistrar As System.Windows.Forms.Button
    Friend WithEvents cmbTipoDoc As System.Windows.Forms.ComboBox
    Friend WithEvents txtNroDoc As System.Windows.Forms.TextBox
    Friend WithEvents txtHabitacion As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtAlojados As System.Windows.Forms.TextBox
    Friend WithEvents dtpIngreso As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpEstimada As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpSalida As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnLimpiar As System.Windows.Forms.Button
    Friend WithEvents btnBuscarPorDoc As System.Windows.Forms.Button
    Friend WithEvents txtPrecio As System.Windows.Forms.MaskedTextBox
    Friend WithEvents fechaIngreso As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents fechaFin As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Habitacion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label9 As System.Windows.Forms.Label
End Class
