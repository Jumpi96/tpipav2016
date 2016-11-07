<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormClientesRecurrentes
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
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.TablaEstadisticaClientesRecurrentesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSetMarcelo = New TPI___PAV___2016.DataSetMarcelo()
        Me.lbl_filtros = New System.Windows.Forms.Label()
        Me.lbl_cantidad = New System.Windows.Forms.Label()
        Me.lbl_tipoDocumento = New System.Windows.Forms.Label()
        Me.lbl_numeroDocumento = New System.Windows.Forms.Label()
        Me.lbl_apellido = New System.Windows.Forms.Label()
        Me.lbl_nombre = New System.Windows.Forms.Label()
        Me.cmb_tipoDocumento = New System.Windows.Forms.ComboBox()
        Me.txt_cantidadAlojamientos = New System.Windows.Forms.MaskedTextBox()
        Me.txt_numeroDocumento = New System.Windows.Forms.MaskedTextBox()
        Me.txt_apellido = New System.Windows.Forms.TextBox()
        Me.txt_nombre = New System.Windows.Forms.TextBox()
        Me.rp_clientesRecurrentes = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.lbl_desSeleccionarTipoDocumento = New System.Windows.Forms.Button()
        Me.btn_aplicarFiltros = New System.Windows.Forms.Button()
        Me.btn_limpiar = New System.Windows.Forms.Button()
        Me.TablaEstadisticaClientesRecurrentesTableAdapter = New TPI___PAV___2016.DataSetMarceloTableAdapters.TablaEstadisticaClientesRecurrentesTableAdapter()
        CType(Me.TablaEstadisticaClientesRecurrentesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetMarcelo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TablaEstadisticaClientesRecurrentesBindingSource
        '
        Me.TablaEstadisticaClientesRecurrentesBindingSource.DataMember = "TablaEstadisticaClientesRecurrentes"
        Me.TablaEstadisticaClientesRecurrentesBindingSource.DataSource = Me.DataSetMarcelo
        '
        'DataSetMarcelo
        '
        Me.DataSetMarcelo.DataSetName = "DataSetMarcelo"
        Me.DataSetMarcelo.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'lbl_filtros
        '
        Me.lbl_filtros.AutoSize = True
        Me.lbl_filtros.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_filtros.Location = New System.Drawing.Point(12, 9)
        Me.lbl_filtros.Name = "lbl_filtros"
        Me.lbl_filtros.Size = New System.Drawing.Size(51, 16)
        Me.lbl_filtros.TabIndex = 0
        Me.lbl_filtros.Text = "Filtros"
        '
        'lbl_cantidad
        '
        Me.lbl_cantidad.AutoSize = True
        Me.lbl_cantidad.Location = New System.Drawing.Point(59, 34)
        Me.lbl_cantidad.Name = "lbl_cantidad"
        Me.lbl_cantidad.Size = New System.Drawing.Size(49, 13)
        Me.lbl_cantidad.TabIndex = 1
        Me.lbl_cantidad.Text = "Cantidad"
        '
        'lbl_tipoDocumento
        '
        Me.lbl_tipoDocumento.AutoSize = True
        Me.lbl_tipoDocumento.Location = New System.Drawing.Point(24, 60)
        Me.lbl_tipoDocumento.Name = "lbl_tipoDocumento"
        Me.lbl_tipoDocumento.Size = New System.Drawing.Size(84, 13)
        Me.lbl_tipoDocumento.TabIndex = 2
        Me.lbl_tipoDocumento.Text = "Tipo documento"
        '
        'lbl_numeroDocumento
        '
        Me.lbl_numeroDocumento.AutoSize = True
        Me.lbl_numeroDocumento.Location = New System.Drawing.Point(8, 87)
        Me.lbl_numeroDocumento.Name = "lbl_numeroDocumento"
        Me.lbl_numeroDocumento.Size = New System.Drawing.Size(100, 13)
        Me.lbl_numeroDocumento.TabIndex = 3
        Me.lbl_numeroDocumento.Text = "Número documento"
        '
        'lbl_apellido
        '
        Me.lbl_apellido.AutoSize = True
        Me.lbl_apellido.Location = New System.Drawing.Point(59, 113)
        Me.lbl_apellido.Name = "lbl_apellido"
        Me.lbl_apellido.Size = New System.Drawing.Size(44, 13)
        Me.lbl_apellido.TabIndex = 4
        Me.lbl_apellido.Text = "Apellido"
        '
        'lbl_nombre
        '
        Me.lbl_nombre.AutoSize = True
        Me.lbl_nombre.Location = New System.Drawing.Point(59, 139)
        Me.lbl_nombre.Name = "lbl_nombre"
        Me.lbl_nombre.Size = New System.Drawing.Size(44, 13)
        Me.lbl_nombre.TabIndex = 5
        Me.lbl_nombre.Text = "Nombre"
        '
        'cmb_tipoDocumento
        '
        Me.cmb_tipoDocumento.FormattingEnabled = True
        Me.cmb_tipoDocumento.Location = New System.Drawing.Point(114, 57)
        Me.cmb_tipoDocumento.Name = "cmb_tipoDocumento"
        Me.cmb_tipoDocumento.Size = New System.Drawing.Size(64, 21)
        Me.cmb_tipoDocumento.TabIndex = 6
        '
        'txt_cantidadAlojamientos
        '
        Me.txt_cantidadAlojamientos.Location = New System.Drawing.Point(114, 31)
        Me.txt_cantidadAlojamientos.Mask = "99999"
        Me.txt_cantidadAlojamientos.Name = "txt_cantidadAlojamientos"
        Me.txt_cantidadAlojamientos.Size = New System.Drawing.Size(39, 20)
        Me.txt_cantidadAlojamientos.TabIndex = 7
        Me.txt_cantidadAlojamientos.ValidatingType = GetType(Integer)
        '
        'txt_numeroDocumento
        '
        Me.txt_numeroDocumento.Location = New System.Drawing.Point(114, 84)
        Me.txt_numeroDocumento.Mask = "999999999"
        Me.txt_numeroDocumento.Name = "txt_numeroDocumento"
        Me.txt_numeroDocumento.Size = New System.Drawing.Size(64, 20)
        Me.txt_numeroDocumento.TabIndex = 8
        '
        'txt_apellido
        '
        Me.txt_apellido.Location = New System.Drawing.Point(114, 110)
        Me.txt_apellido.Name = "txt_apellido"
        Me.txt_apellido.Size = New System.Drawing.Size(100, 20)
        Me.txt_apellido.TabIndex = 9
        '
        'txt_nombre
        '
        Me.txt_nombre.Location = New System.Drawing.Point(114, 136)
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Size = New System.Drawing.Size(100, 20)
        Me.txt_nombre.TabIndex = 10
        '
        'rp_clientesRecurrentes
        '
        ReportDataSource2.Name = "ListadoClientesRecurrentes"
        ReportDataSource2.Value = Me.TablaEstadisticaClientesRecurrentesBindingSource
        Me.rp_clientesRecurrentes.LocalReport.DataSources.Add(ReportDataSource2)
        Me.rp_clientesRecurrentes.LocalReport.ReportEmbeddedResource = "TPI___PAV___2016.EstadisticaClientesRecurrentes.rdlc"
        Me.rp_clientesRecurrentes.Location = New System.Drawing.Point(220, 9)
        Me.rp_clientesRecurrentes.Name = "rp_clientesRecurrentes"
        Me.rp_clientesRecurrentes.Size = New System.Drawing.Size(705, 447)
        Me.rp_clientesRecurrentes.TabIndex = 11
        '
        'lbl_desSeleccionarTipoDocumento
        '
        Me.lbl_desSeleccionarTipoDocumento.Location = New System.Drawing.Point(184, 55)
        Me.lbl_desSeleccionarTipoDocumento.Name = "lbl_desSeleccionarTipoDocumento"
        Me.lbl_desSeleccionarTipoDocumento.Size = New System.Drawing.Size(26, 23)
        Me.lbl_desSeleccionarTipoDocumento.TabIndex = 12
        Me.lbl_desSeleccionarTipoDocumento.Text = "X"
        Me.lbl_desSeleccionarTipoDocumento.UseVisualStyleBackColor = True
        '
        'btn_aplicarFiltros
        '
        Me.btn_aplicarFiltros.Location = New System.Drawing.Point(139, 162)
        Me.btn_aplicarFiltros.Name = "btn_aplicarFiltros"
        Me.btn_aplicarFiltros.Size = New System.Drawing.Size(75, 23)
        Me.btn_aplicarFiltros.TabIndex = 13
        Me.btn_aplicarFiltros.Text = "Aplicar filtros"
        Me.btn_aplicarFiltros.UseVisualStyleBackColor = True
        '
        'btn_limpiar
        '
        Me.btn_limpiar.Location = New System.Drawing.Point(11, 162)
        Me.btn_limpiar.Name = "btn_limpiar"
        Me.btn_limpiar.Size = New System.Drawing.Size(75, 23)
        Me.btn_limpiar.TabIndex = 14
        Me.btn_limpiar.Text = "Limpiar"
        Me.btn_limpiar.UseVisualStyleBackColor = True
        '
        'TablaEstadisticaClientesRecurrentesTableAdapter
        '
        Me.TablaEstadisticaClientesRecurrentesTableAdapter.ClearBeforeFill = True
        '
        'FormClientesRecurrentes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(937, 468)
        Me.Controls.Add(Me.btn_limpiar)
        Me.Controls.Add(Me.btn_aplicarFiltros)
        Me.Controls.Add(Me.lbl_desSeleccionarTipoDocumento)
        Me.Controls.Add(Me.rp_clientesRecurrentes)
        Me.Controls.Add(Me.txt_nombre)
        Me.Controls.Add(Me.txt_apellido)
        Me.Controls.Add(Me.txt_numeroDocumento)
        Me.Controls.Add(Me.txt_cantidadAlojamientos)
        Me.Controls.Add(Me.cmb_tipoDocumento)
        Me.Controls.Add(Me.lbl_nombre)
        Me.Controls.Add(Me.lbl_apellido)
        Me.Controls.Add(Me.lbl_numeroDocumento)
        Me.Controls.Add(Me.lbl_tipoDocumento)
        Me.Controls.Add(Me.lbl_cantidad)
        Me.Controls.Add(Me.lbl_filtros)
        Me.Name = "FormClientesRecurrentes"
        Me.Text = "FormClientesRecurrentes"
        CType(Me.TablaEstadisticaClientesRecurrentesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetMarcelo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_filtros As System.Windows.Forms.Label
    Friend WithEvents lbl_cantidad As System.Windows.Forms.Label
    Friend WithEvents lbl_tipoDocumento As System.Windows.Forms.Label
    Friend WithEvents lbl_numeroDocumento As System.Windows.Forms.Label
    Friend WithEvents lbl_apellido As System.Windows.Forms.Label
    Friend WithEvents lbl_nombre As System.Windows.Forms.Label
    Friend WithEvents cmb_tipoDocumento As System.Windows.Forms.ComboBox
    Friend WithEvents txt_cantidadAlojamientos As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txt_numeroDocumento As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txt_apellido As System.Windows.Forms.TextBox
    Friend WithEvents txt_nombre As System.Windows.Forms.TextBox
    Friend WithEvents rp_clientesRecurrentes As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents lbl_desSeleccionarTipoDocumento As System.Windows.Forms.Button
    Friend WithEvents btn_aplicarFiltros As System.Windows.Forms.Button
    Friend WithEvents btn_limpiar As System.Windows.Forms.Button
    Friend WithEvents TablaEstadisticaClientesRecurrentesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DataSetMarcelo As TPI___PAV___2016.DataSetMarcelo
    Friend WithEvents TablaEstadisticaClientesRecurrentesTableAdapter As TPI___PAV___2016.DataSetMarceloTableAdapters.TablaEstadisticaClientesRecurrentesTableAdapter
End Class
