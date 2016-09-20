<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ABM_ServiciosXAlojamiento
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
        Me.lbl_nroHabitacion = New System.Windows.Forms.Label()
        Me.btnBuscarAloj = New System.Windows.Forms.Button()
        Me.dgvServiciosXAloj = New System.Windows.Forms.DataGridView()
        Me.Alojamiento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Servicio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idServicio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cmbServicios = New System.Windows.Forms.ComboBox()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.lbl_servicios = New System.Windows.Forms.Label()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.btnBorrar = New System.Windows.Forms.Button()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.txt_nroHabitacion = New System.Windows.Forms.MaskedTextBox()
        Me.pnl_cliente = New System.Windows.Forms.Panel()
        Me.txt_apellido = New System.Windows.Forms.TextBox()
        Me.txt_nombre = New System.Windows.Forms.TextBox()
        Me.txt_documento = New System.Windows.Forms.TextBox()
        Me.txt_tipoDocumento = New System.Windows.Forms.TextBox()
        Me.lbl_apellido = New System.Windows.Forms.Label()
        Me.lbl_nombre = New System.Windows.Forms.Label()
        Me.lbl_documento = New System.Windows.Forms.Label()
        Me.lnl_tipoDocumento = New System.Windows.Forms.Label()
        Me.lbl_clienteAsociado = New System.Windows.Forms.Label()
        Me.lbl_servicioSeleccionado = New System.Windows.Forms.Label()
        Me.txt_servicioSeleccionado = New System.Windows.Forms.TextBox()
        CType(Me.dgvServiciosXAloj, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_cliente.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbl_nroHabitacion
        '
        Me.lbl_nroHabitacion.AutoSize = True
        Me.lbl_nroHabitacion.Location = New System.Drawing.Point(12, 15)
        Me.lbl_nroHabitacion.Name = "lbl_nroHabitacion"
        Me.lbl_nroHabitacion.Size = New System.Drawing.Size(93, 13)
        Me.lbl_nroHabitacion.TabIndex = 0
        Me.lbl_nroHabitacion.Text = "Nro de Habitación"
        '
        'btnBuscarAloj
        '
        Me.btnBuscarAloj.Location = New System.Drawing.Point(157, 10)
        Me.btnBuscarAloj.Name = "btnBuscarAloj"
        Me.btnBuscarAloj.Size = New System.Drawing.Size(75, 23)
        Me.btnBuscarAloj.TabIndex = 2
        Me.btnBuscarAloj.Text = "Buscar"
        Me.btnBuscarAloj.UseVisualStyleBackColor = True
        '
        'dgvServiciosXAloj
        '
        Me.dgvServiciosXAloj.AllowUserToAddRows = False
        Me.dgvServiciosXAloj.AllowUserToDeleteRows = False
        Me.dgvServiciosXAloj.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvServiciosXAloj.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Alojamiento, Me.Servicio, Me.idServicio})
        Me.dgvServiciosXAloj.Location = New System.Drawing.Point(12, 172)
        Me.dgvServiciosXAloj.MultiSelect = False
        Me.dgvServiciosXAloj.Name = "dgvServiciosXAloj"
        Me.dgvServiciosXAloj.ReadOnly = True
        Me.dgvServiciosXAloj.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvServiciosXAloj.Size = New System.Drawing.Size(341, 191)
        Me.dgvServiciosXAloj.TabIndex = 4
        '
        'Alojamiento
        '
        Me.Alojamiento.HeaderText = "ID Alojamiento"
        Me.Alojamiento.Name = "Alojamiento"
        Me.Alojamiento.ReadOnly = True
        '
        'Servicio
        '
        Me.Servicio.HeaderText = "Servicio ya contratado"
        Me.Servicio.Name = "Servicio"
        Me.Servicio.ReadOnly = True
        Me.Servicio.Width = 150
        '
        'idServicio
        '
        Me.idServicio.HeaderText = "ID Servicio"
        Me.idServicio.Name = "idServicio"
        Me.idServicio.ReadOnly = True
        Me.idServicio.Visible = False
        '
        'cmbServicios
        '
        Me.cmbServicios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbServicios.FormattingEnabled = True
        Me.cmbServicios.Location = New System.Drawing.Point(68, 145)
        Me.cmbServicios.Name = "cmbServicios"
        Me.cmbServicios.Size = New System.Drawing.Size(160, 21)
        Me.cmbServicios.TabIndex = 7
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(234, 145)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(75, 21)
        Me.btnAgregar.TabIndex = 8
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'lbl_servicios
        '
        Me.lbl_servicios.AutoSize = True
        Me.lbl_servicios.Location = New System.Drawing.Point(12, 148)
        Me.lbl_servicios.Name = "lbl_servicios"
        Me.lbl_servicios.Size = New System.Drawing.Size(50, 13)
        Me.lbl_servicios.TabIndex = 6
        Me.lbl_servicios.Text = "Servicios"
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Location = New System.Drawing.Point(12, 369)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(75, 23)
        Me.btnLimpiar.TabIndex = 9
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'btnBorrar
        '
        Me.btnBorrar.Location = New System.Drawing.Point(122, 409)
        Me.btnBorrar.Name = "btnBorrar"
        Me.btnBorrar.Size = New System.Drawing.Size(75, 23)
        Me.btnBorrar.TabIndex = 12
        Me.btnBorrar.Text = "Borrar"
        Me.btnBorrar.UseVisualStyleBackColor = True
        '
        'btnCerrar
        '
        Me.btnCerrar.Location = New System.Drawing.Point(278, 369)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(75, 23)
        Me.btnCerrar.TabIndex = 10
        Me.btnCerrar.Text = "Cerrar"
        Me.btnCerrar.UseVisualStyleBackColor = True
        '
        'txt_nroHabitacion
        '
        Me.txt_nroHabitacion.Location = New System.Drawing.Point(111, 12)
        Me.txt_nroHabitacion.Mask = "99999"
        Me.txt_nroHabitacion.Name = "txt_nroHabitacion"
        Me.txt_nroHabitacion.Size = New System.Drawing.Size(40, 20)
        Me.txt_nroHabitacion.TabIndex = 1
        Me.txt_nroHabitacion.ValidatingType = GetType(Integer)
        '
        'pnl_cliente
        '
        Me.pnl_cliente.BackColor = System.Drawing.Color.White
        Me.pnl_cliente.Controls.Add(Me.txt_apellido)
        Me.pnl_cliente.Controls.Add(Me.txt_nombre)
        Me.pnl_cliente.Controls.Add(Me.txt_documento)
        Me.pnl_cliente.Controls.Add(Me.txt_tipoDocumento)
        Me.pnl_cliente.Controls.Add(Me.lbl_apellido)
        Me.pnl_cliente.Controls.Add(Me.lbl_nombre)
        Me.pnl_cliente.Controls.Add(Me.lbl_documento)
        Me.pnl_cliente.Controls.Add(Me.lnl_tipoDocumento)
        Me.pnl_cliente.Controls.Add(Me.lbl_clienteAsociado)
        Me.pnl_cliente.Location = New System.Drawing.Point(12, 39)
        Me.pnl_cliente.Name = "pnl_cliente"
        Me.pnl_cliente.Size = New System.Drawing.Size(341, 98)
        Me.pnl_cliente.TabIndex = 9
        '
        'txt_apellido
        '
        Me.txt_apellido.Location = New System.Drawing.Point(95, 43)
        Me.txt_apellido.Name = "txt_apellido"
        Me.txt_apellido.ReadOnly = True
        Me.txt_apellido.Size = New System.Drawing.Size(239, 20)
        Me.txt_apellido.TabIndex = 5
        '
        'txt_nombre
        '
        Me.txt_nombre.Location = New System.Drawing.Point(95, 69)
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.ReadOnly = True
        Me.txt_nombre.Size = New System.Drawing.Size(239, 20)
        Me.txt_nombre.TabIndex = 6
        '
        'txt_documento
        '
        Me.txt_documento.Location = New System.Drawing.Point(269, 17)
        Me.txt_documento.Name = "txt_documento"
        Me.txt_documento.ReadOnly = True
        Me.txt_documento.Size = New System.Drawing.Size(65, 20)
        Me.txt_documento.TabIndex = 4
        '
        'txt_tipoDocumento
        '
        Me.txt_tipoDocumento.Location = New System.Drawing.Point(95, 17)
        Me.txt_tipoDocumento.Name = "txt_tipoDocumento"
        Me.txt_tipoDocumento.ReadOnly = True
        Me.txt_tipoDocumento.Size = New System.Drawing.Size(100, 20)
        Me.txt_tipoDocumento.TabIndex = 3
        '
        'lbl_apellido
        '
        Me.lbl_apellido.AutoSize = True
        Me.lbl_apellido.Location = New System.Drawing.Point(44, 46)
        Me.lbl_apellido.Name = "lbl_apellido"
        Me.lbl_apellido.Size = New System.Drawing.Size(44, 13)
        Me.lbl_apellido.TabIndex = 4
        Me.lbl_apellido.Text = "Apellido"
        '
        'lbl_nombre
        '
        Me.lbl_nombre.AutoSize = True
        Me.lbl_nombre.Location = New System.Drawing.Point(44, 72)
        Me.lbl_nombre.Name = "lbl_nombre"
        Me.lbl_nombre.Size = New System.Drawing.Size(44, 13)
        Me.lbl_nombre.TabIndex = 3
        Me.lbl_nombre.Text = "Nombre"
        '
        'lbl_documento
        '
        Me.lbl_documento.AutoSize = True
        Me.lbl_documento.Location = New System.Drawing.Point(201, 20)
        Me.lbl_documento.Name = "lbl_documento"
        Me.lbl_documento.Size = New System.Drawing.Size(62, 13)
        Me.lbl_documento.TabIndex = 2
        Me.lbl_documento.Text = "Documento"
        '
        'lnl_tipoDocumento
        '
        Me.lnl_tipoDocumento.AutoSize = True
        Me.lnl_tipoDocumento.Location = New System.Drawing.Point(3, 20)
        Me.lnl_tipoDocumento.Name = "lnl_tipoDocumento"
        Me.lnl_tipoDocumento.Size = New System.Drawing.Size(86, 13)
        Me.lnl_tipoDocumento.TabIndex = 1
        Me.lnl_tipoDocumento.Text = "Tipo Documento"
        '
        'lbl_clienteAsociado
        '
        Me.lbl_clienteAsociado.AutoSize = True
        Me.lbl_clienteAsociado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_clienteAsociado.Location = New System.Drawing.Point(3, 3)
        Me.lbl_clienteAsociado.Name = "lbl_clienteAsociado"
        Me.lbl_clienteAsociado.Size = New System.Drawing.Size(85, 13)
        Me.lbl_clienteAsociado.TabIndex = 0
        Me.lbl_clienteAsociado.Text = "Cliente asociado"
        '
        'lbl_servicioSeleccionado
        '
        Me.lbl_servicioSeleccionado.AutoSize = True
        Me.lbl_servicioSeleccionado.Location = New System.Drawing.Point(9, 395)
        Me.lbl_servicioSeleccionado.Name = "lbl_servicioSeleccionado"
        Me.lbl_servicioSeleccionado.Size = New System.Drawing.Size(113, 13)
        Me.lbl_servicioSeleccionado.TabIndex = 10
        Me.lbl_servicioSeleccionado.Text = "Servicio Seleccionado"
        '
        'txt_servicioSeleccionado
        '
        Me.txt_servicioSeleccionado.Location = New System.Drawing.Point(15, 411)
        Me.txt_servicioSeleccionado.Name = "txt_servicioSeleccionado"
        Me.txt_servicioSeleccionado.Size = New System.Drawing.Size(101, 20)
        Me.txt_servicioSeleccionado.TabIndex = 11
        '
        'ABM_ServiciosXAlojamiento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(367, 437)
        Me.Controls.Add(Me.txt_servicioSeleccionado)
        Me.Controls.Add(Me.lbl_servicioSeleccionado)
        Me.Controls.Add(Me.pnl_cliente)
        Me.Controls.Add(Me.txt_nroHabitacion)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.btnBorrar)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.lbl_servicios)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.cmbServicios)
        Me.Controls.Add(Me.dgvServiciosXAloj)
        Me.Controls.Add(Me.btnBuscarAloj)
        Me.Controls.Add(Me.lbl_nroHabitacion)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.Name = "ABM_ServiciosXAlojamiento"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "ABM ServiciosXAlojamiento"
        CType(Me.dgvServiciosXAloj, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_cliente.ResumeLayout(False)
        Me.pnl_cliente.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_nroHabitacion As System.Windows.Forms.Label
    Friend WithEvents btnBuscarAloj As System.Windows.Forms.Button
    Friend WithEvents dgvServiciosXAloj As System.Windows.Forms.DataGridView
    Friend WithEvents cmbServicios As System.Windows.Forms.ComboBox
    Friend WithEvents btnAgregar As System.Windows.Forms.Button
    Friend WithEvents lbl_servicios As System.Windows.Forms.Label
    Friend WithEvents btnLimpiar As System.Windows.Forms.Button
    Friend WithEvents btnBorrar As System.Windows.Forms.Button
    Friend WithEvents btnCerrar As System.Windows.Forms.Button
    Friend WithEvents txt_nroHabitacion As System.Windows.Forms.MaskedTextBox
    Friend WithEvents pnl_cliente As System.Windows.Forms.Panel
    Friend WithEvents txt_apellido As System.Windows.Forms.TextBox
    Friend WithEvents txt_nombre As System.Windows.Forms.TextBox
    Friend WithEvents txt_documento As System.Windows.Forms.TextBox
    Friend WithEvents txt_tipoDocumento As System.Windows.Forms.TextBox
    Friend WithEvents lbl_apellido As System.Windows.Forms.Label
    Friend WithEvents lbl_nombre As System.Windows.Forms.Label
    Friend WithEvents lbl_documento As System.Windows.Forms.Label
    Friend WithEvents lnl_tipoDocumento As System.Windows.Forms.Label
    Friend WithEvents lbl_clienteAsociado As System.Windows.Forms.Label
    Friend WithEvents Alojamiento As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Servicio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lbl_servicioSeleccionado As System.Windows.Forms.Label
    Friend WithEvents txt_servicioSeleccionado As System.Windows.Forms.TextBox
    Friend WithEvents idServicio As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
