﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ABM_Habitación_X_Piso
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
        Me.lbl_nroHabitacion = New System.Windows.Forms.Label()
        Me.lbl_camas = New System.Windows.Forms.Label()
        Me.lbl_baños = New System.Windows.Forms.Label()
        Me.lbl_fechaEmision = New System.Windows.Forms.Label()
        Me.lbl_tipoHabitacion = New System.Windows.Forms.Label()
        Me.lbl_personas = New System.Windows.Forms.Label()
        Me.cmb_tipoHabitacion = New System.Windows.Forms.ComboBox()
        Me.dtp_fechaEmision = New System.Windows.Forms.DateTimePicker()
        Me.chb_frigoBar = New System.Windows.Forms.CheckBox()
        Me.chb_aireAcondicionado = New System.Windows.Forms.CheckBox()
        Me.grid_habitacionPiso = New System.Windows.Forms.DataGridView()
        Me.clm_nroHabitacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clm_tipoHabitacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clm_fechaEmision = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cmd_registrar = New System.Windows.Forms.Button()
        Me.txt_personas = New System.Windows.Forms.MaskedTextBox()
        Me.txt_baños = New System.Windows.Forms.MaskedTextBox()
        Me.txt_camas = New System.Windows.Forms.MaskedTextBox()
        Me.txt_nroHabitacion = New System.Windows.Forms.MaskedTextBox()
        Me.cmd_cancelar = New System.Windows.Forms.Button()
        Me.cmd_limpiar = New System.Windows.Forms.Button()
        Me.cmd_actualizarGrilla = New System.Windows.Forms.Button()
        Me.cmd_modificarTiposCama = New System.Windows.Forms.Button()
        Me.pnl_tipoCama = New System.Windows.Forms.Panel()
        Me.cmd_aceptar = New System.Windows.Forms.Button()
        Me.cmd_atras = New System.Windows.Forms.Button()
        Me.cmb_tipoCama4 = New System.Windows.Forms.ComboBox()
        Me.cmb_tipoCama3 = New System.Windows.Forms.ComboBox()
        Me.cmb_tipoCama2 = New System.Windows.Forms.ComboBox()
        Me.cmb_tipoCama1 = New System.Windows.Forms.ComboBox()
        Me.lbl_tiposCamas = New System.Windows.Forms.Label()
        Me.lbl_listaCama4 = New System.Windows.Forms.Label()
        Me.lbl_listaCama3 = New System.Windows.Forms.Label()
        Me.lbl_listaCama2 = New System.Windows.Forms.Label()
        Me.lbl_listaCama1 = New System.Windows.Forms.Label()
        Me.lbl_listaCamas = New System.Windows.Forms.Label()
        CType(Me.grid_habitacionPiso, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_tipoCama.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbl_nroHabitacion
        '
        Me.lbl_nroHabitacion.AutoSize = True
        Me.lbl_nroHabitacion.Location = New System.Drawing.Point(16, 15)
        Me.lbl_nroHabitacion.Name = "lbl_nroHabitacion"
        Me.lbl_nroHabitacion.Size = New System.Drawing.Size(93, 13)
        Me.lbl_nroHabitacion.TabIndex = 1
        Me.lbl_nroHabitacion.Text = "Nro de Habitación"
        '
        'lbl_camas
        '
        Me.lbl_camas.AutoSize = True
        Me.lbl_camas.Location = New System.Drawing.Point(10, 41)
        Me.lbl_camas.Name = "lbl_camas"
        Me.lbl_camas.Size = New System.Drawing.Size(99, 13)
        Me.lbl_camas.TabIndex = 2
        Me.lbl_camas.Text = "Cantidad de Camas"
        '
        'lbl_baños
        '
        Me.lbl_baños.AutoSize = True
        Me.lbl_baños.Location = New System.Drawing.Point(13, 67)
        Me.lbl_baños.Name = "lbl_baños"
        Me.lbl_baños.Size = New System.Drawing.Size(96, 13)
        Me.lbl_baños.TabIndex = 3
        Me.lbl_baños.Text = "Cantidad de baños"
        '
        'lbl_fechaEmision
        '
        Me.lbl_fechaEmision.AutoSize = True
        Me.lbl_fechaEmision.Location = New System.Drawing.Point(152, 41)
        Me.lbl_fechaEmision.Name = "lbl_fechaEmision"
        Me.lbl_fechaEmision.Size = New System.Drawing.Size(91, 13)
        Me.lbl_fechaEmision.TabIndex = 6
        Me.lbl_fechaEmision.Text = "Fecha de Emisión"
        '
        'lbl_tipoHabitacion
        '
        Me.lbl_tipoHabitacion.AutoSize = True
        Me.lbl_tipoHabitacion.Location = New System.Drawing.Point(152, 15)
        Me.lbl_tipoHabitacion.Name = "lbl_tipoHabitacion"
        Me.lbl_tipoHabitacion.Size = New System.Drawing.Size(97, 13)
        Me.lbl_tipoHabitacion.TabIndex = 7
        Me.lbl_tipoHabitacion.Text = "Tipo de Habitación"
        '
        'lbl_personas
        '
        Me.lbl_personas.AutoSize = True
        Me.lbl_personas.Location = New System.Drawing.Point(152, 67)
        Me.lbl_personas.Name = "lbl_personas"
        Me.lbl_personas.Size = New System.Drawing.Size(149, 13)
        Me.lbl_personas.TabIndex = 8
        Me.lbl_personas.Text = "Cantidad máxima de Personas"
        '
        'cmb_tipoHabitacion
        '
        Me.cmb_tipoHabitacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_tipoHabitacion.FormattingEnabled = True
        Me.cmb_tipoHabitacion.Location = New System.Drawing.Point(255, 12)
        Me.cmb_tipoHabitacion.Name = "cmb_tipoHabitacion"
        Me.cmb_tipoHabitacion.Size = New System.Drawing.Size(121, 21)
        Me.cmb_tipoHabitacion.TabIndex = 4
        '
        'dtp_fechaEmision
        '
        Me.dtp_fechaEmision.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_fechaEmision.Location = New System.Drawing.Point(255, 38)
        Me.dtp_fechaEmision.Name = "dtp_fechaEmision"
        Me.dtp_fechaEmision.Size = New System.Drawing.Size(80, 20)
        Me.dtp_fechaEmision.TabIndex = 5
        '
        'chb_frigoBar
        '
        Me.chb_frigoBar.AutoSize = True
        Me.chb_frigoBar.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chb_frigoBar.Location = New System.Drawing.Point(155, 92)
        Me.chb_frigoBar.Name = "chb_frigoBar"
        Me.chb_frigoBar.Size = New System.Drawing.Size(64, 17)
        Me.chb_frigoBar.TabIndex = 7
        Me.chb_frigoBar.Text = "Frigobar"
        Me.chb_frigoBar.UseVisualStyleBackColor = True
        '
        'chb_aireAcondicionado
        '
        Me.chb_aireAcondicionado.AutoSize = True
        Me.chb_aireAcondicionado.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chb_aireAcondicionado.Location = New System.Drawing.Point(225, 92)
        Me.chb_aireAcondicionado.Name = "chb_aireAcondicionado"
        Me.chb_aireAcondicionado.Size = New System.Drawing.Size(121, 17)
        Me.chb_aireAcondicionado.TabIndex = 8
        Me.chb_aireAcondicionado.Text = "Arire Acondicionado"
        Me.chb_aireAcondicionado.UseVisualStyleBackColor = True
        '
        'grid_habitacionPiso
        '
        Me.grid_habitacionPiso.AllowUserToAddRows = False
        Me.grid_habitacionPiso.AllowUserToDeleteRows = False
        Me.grid_habitacionPiso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grid_habitacionPiso.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.clm_nroHabitacion, Me.clm_tipoHabitacion, Me.clm_fechaEmision})
        Me.grid_habitacionPiso.Location = New System.Drawing.Point(12, 116)
        Me.grid_habitacionPiso.MultiSelect = False
        Me.grid_habitacionPiso.Name = "grid_habitacionPiso"
        Me.grid_habitacionPiso.ReadOnly = True
        Me.grid_habitacionPiso.Size = New System.Drawing.Size(462, 274)
        Me.grid_habitacionPiso.TabIndex = 10
        '
        'clm_nroHabitacion
        '
        Me.clm_nroHabitacion.HeaderText = "Nro de Habitación"
        Me.clm_nroHabitacion.Name = "clm_nroHabitacion"
        Me.clm_nroHabitacion.ReadOnly = True
        Me.clm_nroHabitacion.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.clm_nroHabitacion.Width = 125
        '
        'clm_tipoHabitacion
        '
        Me.clm_tipoHabitacion.HeaderText = "Tipo de Habitación"
        Me.clm_tipoHabitacion.Name = "clm_tipoHabitacion"
        Me.clm_tipoHabitacion.ReadOnly = True
        Me.clm_tipoHabitacion.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.clm_tipoHabitacion.Width = 125
        '
        'clm_fechaEmision
        '
        Me.clm_fechaEmision.HeaderText = "Fecha de Emisión"
        Me.clm_fechaEmision.Name = "clm_fechaEmision"
        Me.clm_fechaEmision.ReadOnly = True
        Me.clm_fechaEmision.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.clm_fechaEmision.Width = 150
        '
        'cmd_registrar
        '
        Me.cmd_registrar.Location = New System.Drawing.Point(318, 396)
        Me.cmd_registrar.Name = "cmd_registrar"
        Me.cmd_registrar.Size = New System.Drawing.Size(75, 23)
        Me.cmd_registrar.TabIndex = 11
        Me.cmd_registrar.Text = "Registrar"
        Me.cmd_registrar.UseVisualStyleBackColor = True
        '
        'txt_personas
        '
        Me.txt_personas.Location = New System.Drawing.Point(303, 64)
        Me.txt_personas.Mask = "99"
        Me.txt_personas.Name = "txt_personas"
        Me.txt_personas.Size = New System.Drawing.Size(32, 20)
        Me.txt_personas.TabIndex = 6
        '
        'txt_baños
        '
        Me.txt_baños.Location = New System.Drawing.Point(114, 64)
        Me.txt_baños.Mask = "9999"
        Me.txt_baños.Name = "txt_baños"
        Me.txt_baños.Size = New System.Drawing.Size(32, 20)
        Me.txt_baños.TabIndex = 3
        '
        'txt_camas
        '
        Me.txt_camas.Location = New System.Drawing.Point(114, 38)
        Me.txt_camas.Mask = "9"
        Me.txt_camas.Name = "txt_camas"
        Me.txt_camas.Size = New System.Drawing.Size(32, 20)
        Me.txt_camas.TabIndex = 2
        '
        'txt_nroHabitacion
        '
        Me.txt_nroHabitacion.Location = New System.Drawing.Point(114, 12)
        Me.txt_nroHabitacion.Mask = "9999"
        Me.txt_nroHabitacion.Name = "txt_nroHabitacion"
        Me.txt_nroHabitacion.Size = New System.Drawing.Size(32, 20)
        Me.txt_nroHabitacion.TabIndex = 1
        '
        'cmd_cancelar
        '
        Me.cmd_cancelar.Location = New System.Drawing.Point(399, 396)
        Me.cmd_cancelar.Name = "cmd_cancelar"
        Me.cmd_cancelar.Size = New System.Drawing.Size(75, 23)
        Me.cmd_cancelar.TabIndex = 12
        Me.cmd_cancelar.Text = "Cancelar"
        Me.cmd_cancelar.UseVisualStyleBackColor = True
        '
        'cmd_limpiar
        '
        Me.cmd_limpiar.Location = New System.Drawing.Point(12, 396)
        Me.cmd_limpiar.Name = "cmd_limpiar"
        Me.cmd_limpiar.Size = New System.Drawing.Size(75, 23)
        Me.cmd_limpiar.TabIndex = 9
        Me.cmd_limpiar.Text = "Limpiar"
        Me.cmd_limpiar.UseVisualStyleBackColor = True
        '
        'cmd_actualizarGrilla
        '
        Me.cmd_actualizarGrilla.Location = New System.Drawing.Point(12, 90)
        Me.cmd_actualizarGrilla.Name = "cmd_actualizarGrilla"
        Me.cmd_actualizarGrilla.Size = New System.Drawing.Size(87, 23)
        Me.cmd_actualizarGrilla.TabIndex = 14
        Me.cmd_actualizarGrilla.Text = "Actualizar Grilla"
        Me.cmd_actualizarGrilla.UseVisualStyleBackColor = True
        Me.cmd_actualizarGrilla.Visible = False
        '
        'cmd_modificarTiposCama
        '
        Me.cmd_modificarTiposCama.Location = New System.Drawing.Point(341, 62)
        Me.cmd_modificarTiposCama.Name = "cmd_modificarTiposCama"
        Me.cmd_modificarTiposCama.Size = New System.Drawing.Size(133, 23)
        Me.cmd_modificarTiposCama.TabIndex = 15
        Me.cmd_modificarTiposCama.Text = "Modificar tipos de cama"
        Me.cmd_modificarTiposCama.UseVisualStyleBackColor = True
        '
        'pnl_tipoCama
        '
        Me.pnl_tipoCama.BackColor = System.Drawing.Color.White
        Me.pnl_tipoCama.Controls.Add(Me.cmd_aceptar)
        Me.pnl_tipoCama.Controls.Add(Me.cmd_atras)
        Me.pnl_tipoCama.Controls.Add(Me.cmb_tipoCama4)
        Me.pnl_tipoCama.Controls.Add(Me.cmb_tipoCama3)
        Me.pnl_tipoCama.Controls.Add(Me.cmb_tipoCama2)
        Me.pnl_tipoCama.Controls.Add(Me.cmb_tipoCama1)
        Me.pnl_tipoCama.Controls.Add(Me.lbl_tiposCamas)
        Me.pnl_tipoCama.Controls.Add(Me.lbl_listaCama4)
        Me.pnl_tipoCama.Controls.Add(Me.lbl_listaCama3)
        Me.pnl_tipoCama.Controls.Add(Me.lbl_listaCama2)
        Me.pnl_tipoCama.Controls.Add(Me.lbl_listaCama1)
        Me.pnl_tipoCama.Controls.Add(Me.lbl_listaCamas)
        Me.pnl_tipoCama.Location = New System.Drawing.Point(254, 92)
        Me.pnl_tipoCama.Name = "pnl_tipoCama"
        Me.pnl_tipoCama.Size = New System.Drawing.Size(220, 165)
        Me.pnl_tipoCama.TabIndex = 16
        Me.pnl_tipoCama.Visible = False
        '
        'cmd_aceptar
        '
        Me.cmd_aceptar.Location = New System.Drawing.Point(140, 130)
        Me.cmd_aceptar.Name = "cmd_aceptar"
        Me.cmd_aceptar.Size = New System.Drawing.Size(75, 23)
        Me.cmd_aceptar.TabIndex = 11
        Me.cmd_aceptar.Text = "Aceptar"
        Me.cmd_aceptar.UseVisualStyleBackColor = True
        '
        'cmd_atras
        '
        Me.cmd_atras.Location = New System.Drawing.Point(4, 130)
        Me.cmd_atras.Name = "cmd_atras"
        Me.cmd_atras.Size = New System.Drawing.Size(75, 23)
        Me.cmd_atras.TabIndex = 10
        Me.cmd_atras.Text = "Atrás"
        Me.cmd_atras.UseVisualStyleBackColor = True
        '
        'cmb_tipoCama4
        '
        Me.cmb_tipoCama4.FormattingEnabled = True
        Me.cmb_tipoCama4.Location = New System.Drawing.Point(82, 103)
        Me.cmb_tipoCama4.Name = "cmb_tipoCama4"
        Me.cmb_tipoCama4.Size = New System.Drawing.Size(121, 21)
        Me.cmb_tipoCama4.TabIndex = 9
        '
        'cmb_tipoCama3
        '
        Me.cmb_tipoCama3.FormattingEnabled = True
        Me.cmb_tipoCama3.Location = New System.Drawing.Point(81, 76)
        Me.cmb_tipoCama3.Name = "cmb_tipoCama3"
        Me.cmb_tipoCama3.Size = New System.Drawing.Size(121, 21)
        Me.cmb_tipoCama3.TabIndex = 8
        '
        'cmb_tipoCama2
        '
        Me.cmb_tipoCama2.FormattingEnabled = True
        Me.cmb_tipoCama2.Location = New System.Drawing.Point(81, 49)
        Me.cmb_tipoCama2.Name = "cmb_tipoCama2"
        Me.cmb_tipoCama2.Size = New System.Drawing.Size(121, 21)
        Me.cmb_tipoCama2.TabIndex = 7
        '
        'cmb_tipoCama1
        '
        Me.cmb_tipoCama1.FormattingEnabled = True
        Me.cmb_tipoCama1.Location = New System.Drawing.Point(81, 22)
        Me.cmb_tipoCama1.Name = "cmb_tipoCama1"
        Me.cmb_tipoCama1.Size = New System.Drawing.Size(121, 21)
        Me.cmb_tipoCama1.TabIndex = 6
        '
        'lbl_tiposCamas
        '
        Me.lbl_tiposCamas.AutoSize = True
        Me.lbl_tiposCamas.Location = New System.Drawing.Point(67, 3)
        Me.lbl_tiposCamas.Name = "lbl_tiposCamas"
        Me.lbl_tiposCamas.Size = New System.Drawing.Size(58, 13)
        Me.lbl_tiposCamas.TabIndex = 5
        Me.lbl_tiposCamas.Text = "Tipo Cama"
        '
        'lbl_listaCama4
        '
        Me.lbl_listaCama4.AutoSize = True
        Me.lbl_listaCama4.Location = New System.Drawing.Point(16, 106)
        Me.lbl_listaCama4.Name = "lbl_listaCama4"
        Me.lbl_listaCama4.Size = New System.Drawing.Size(43, 13)
        Me.lbl_listaCama4.TabIndex = 4
        Me.lbl_listaCama4.Text = "Cama 4"
        '
        'lbl_listaCama3
        '
        Me.lbl_listaCama3.AutoSize = True
        Me.lbl_listaCama3.Location = New System.Drawing.Point(16, 79)
        Me.lbl_listaCama3.Name = "lbl_listaCama3"
        Me.lbl_listaCama3.Size = New System.Drawing.Size(43, 13)
        Me.lbl_listaCama3.TabIndex = 3
        Me.lbl_listaCama3.Text = "Cama 3"
        '
        'lbl_listaCama2
        '
        Me.lbl_listaCama2.AutoSize = True
        Me.lbl_listaCama2.Location = New System.Drawing.Point(16, 52)
        Me.lbl_listaCama2.Name = "lbl_listaCama2"
        Me.lbl_listaCama2.Size = New System.Drawing.Size(43, 13)
        Me.lbl_listaCama2.TabIndex = 2
        Me.lbl_listaCama2.Text = "Cama 2"
        '
        'lbl_listaCama1
        '
        Me.lbl_listaCama1.AutoSize = True
        Me.lbl_listaCama1.Location = New System.Drawing.Point(16, 25)
        Me.lbl_listaCama1.Name = "lbl_listaCama1"
        Me.lbl_listaCama1.Size = New System.Drawing.Size(43, 13)
        Me.lbl_listaCama1.TabIndex = 1
        Me.lbl_listaCama1.Text = "Cama 1"
        '
        'lbl_listaCamas
        '
        Me.lbl_listaCamas.AutoSize = True
        Me.lbl_listaCamas.Location = New System.Drawing.Point(3, 3)
        Me.lbl_listaCamas.Name = "lbl_listaCamas"
        Me.lbl_listaCamas.Size = New System.Drawing.Size(39, 13)
        Me.lbl_listaCamas.TabIndex = 0
        Me.lbl_listaCamas.Text = "Camas"
        '
        'ABM_Habitación_X_Piso
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(486, 427)
        Me.Controls.Add(Me.pnl_tipoCama)
        Me.Controls.Add(Me.cmd_modificarTiposCama)
        Me.Controls.Add(Me.cmd_actualizarGrilla)
        Me.Controls.Add(Me.cmd_limpiar)
        Me.Controls.Add(Me.cmd_cancelar)
        Me.Controls.Add(Me.txt_nroHabitacion)
        Me.Controls.Add(Me.txt_camas)
        Me.Controls.Add(Me.txt_baños)
        Me.Controls.Add(Me.txt_personas)
        Me.Controls.Add(Me.cmd_registrar)
        Me.Controls.Add(Me.grid_habitacionPiso)
        Me.Controls.Add(Me.chb_aireAcondicionado)
        Me.Controls.Add(Me.chb_frigoBar)
        Me.Controls.Add(Me.dtp_fechaEmision)
        Me.Controls.Add(Me.lbl_personas)
        Me.Controls.Add(Me.lbl_tipoHabitacion)
        Me.Controls.Add(Me.lbl_fechaEmision)
        Me.Controls.Add(Me.lbl_baños)
        Me.Controls.Add(Me.lbl_camas)
        Me.Controls.Add(Me.lbl_nroHabitacion)
        Me.Controls.Add(Me.cmb_tipoHabitacion)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(502, 466)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(502, 466)
        Me.Name = "ABM_Habitación_X_Piso"
        Me.Text = "ABM Habitación X Piso"
        CType(Me.grid_habitacionPiso, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_tipoCama.ResumeLayout(False)
        Me.pnl_tipoCama.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_nroHabitacion As System.Windows.Forms.Label
    Friend WithEvents lbl_camas As System.Windows.Forms.Label
    Friend WithEvents lbl_baños As System.Windows.Forms.Label
    Friend WithEvents lbl_fechaEmision As System.Windows.Forms.Label
    Friend WithEvents lbl_tipoHabitacion As System.Windows.Forms.Label
    Friend WithEvents lbl_personas As System.Windows.Forms.Label
    Friend WithEvents cmb_tipoHabitacion As System.Windows.Forms.ComboBox
    Friend WithEvents dtp_fechaEmision As System.Windows.Forms.DateTimePicker
    Friend WithEvents chb_frigoBar As System.Windows.Forms.CheckBox
    Friend WithEvents chb_aireAcondicionado As System.Windows.Forms.CheckBox
    Friend WithEvents grid_habitacionPiso As System.Windows.Forms.DataGridView
    Friend WithEvents cmd_registrar As System.Windows.Forms.Button
    Friend WithEvents txt_personas As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txt_baños As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txt_camas As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txt_nroHabitacion As System.Windows.Forms.MaskedTextBox
    Friend WithEvents cmd_cancelar As System.Windows.Forms.Button
    Friend WithEvents cmd_limpiar As System.Windows.Forms.Button
    Friend WithEvents clm_nroHabitacion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clm_tipoHabitacion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clm_fechaEmision As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cmd_actualizarGrilla As System.Windows.Forms.Button
    Friend WithEvents cmd_modificarTiposCama As System.Windows.Forms.Button
    Friend WithEvents pnl_tipoCama As System.Windows.Forms.Panel
    Friend WithEvents cmd_atras As System.Windows.Forms.Button
    Friend WithEvents cmb_tipoCama4 As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_tipoCama3 As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_tipoCama2 As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_tipoCama1 As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_tiposCamas As System.Windows.Forms.Label
    Friend WithEvents lbl_listaCama4 As System.Windows.Forms.Label
    Friend WithEvents lbl_listaCama3 As System.Windows.Forms.Label
    Friend WithEvents lbl_listaCama2 As System.Windows.Forms.Label
    Friend WithEvents lbl_listaCama1 As System.Windows.Forms.Label
    Friend WithEvents lbl_listaCamas As System.Windows.Forms.Label
    Friend WithEvents cmd_aceptar As System.Windows.Forms.Button
End Class
