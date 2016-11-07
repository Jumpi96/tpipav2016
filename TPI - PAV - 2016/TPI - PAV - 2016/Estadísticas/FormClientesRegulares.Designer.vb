<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormClientesRegulares
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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.btn_x = New System.Windows.Forms.Button()
        Me.lbl_tipoDocumento = New System.Windows.Forms.Label()
        Me.lbl_numeroDocumento = New System.Windows.Forms.Label()
        Me.cmb_tipoDocumento = New System.Windows.Forms.ComboBox()
        Me.txt_numeroDocumento = New System.Windows.Forms.MaskedTextBox()
        Me.txt_apellido = New System.Windows.Forms.TextBox()
        Me.txt_nombre = New System.Windows.Forms.TextBox()
        Me.btn_aplicarFiltros = New System.Windows.Forms.Button()
        Me.lbl_nombre = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbl_cantidadAlojamientos = New System.Windows.Forms.Label()
        Me.txt_cantidadAlojamientos = New System.Windows.Forms.MaskedTextBox()
        Me.lbl_filtros = New System.Windows.Forms.Label()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.DataSetMarce = New TPI___PAV___2016.DataSetMarce()
        Me.TablaClientesRegularesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TablaClientesRegularesTableAdapter = New TPI___PAV___2016.DataSetMarceTableAdapters.TablaClientesRegularesTableAdapter()
        Me.TablaClientesRegularesTableAdapter.Connection.ConnectionString = accesoBD.cadenaConexion
        CType(Me.DataSetMarce, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TablaClientesRegularesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_x
        '
        Me.btn_x.Location = New System.Drawing.Point(227, 85)
        Me.btn_x.Name = "btn_x"
        Me.btn_x.Size = New System.Drawing.Size(28, 23)
        Me.btn_x.TabIndex = 29
        Me.btn_x.Text = "X"
        Me.btn_x.UseVisualStyleBackColor = True
        '
        'lbl_tipoDocumento
        '
        Me.lbl_tipoDocumento.AutoSize = True
        Me.lbl_tipoDocumento.Location = New System.Drawing.Point(44, 90)
        Me.lbl_tipoDocumento.Name = "lbl_tipoDocumento"
        Me.lbl_tipoDocumento.Size = New System.Drawing.Size(84, 13)
        Me.lbl_tipoDocumento.TabIndex = 28
        Me.lbl_tipoDocumento.Text = "Tipo documento"
        '
        'lbl_numeroDocumento
        '
        Me.lbl_numeroDocumento.AutoSize = True
        Me.lbl_numeroDocumento.Location = New System.Drawing.Point(28, 64)
        Me.lbl_numeroDocumento.Name = "lbl_numeroDocumento"
        Me.lbl_numeroDocumento.Size = New System.Drawing.Size(100, 13)
        Me.lbl_numeroDocumento.TabIndex = 27
        Me.lbl_numeroDocumento.Text = "Número documento"
        '
        'cmb_tipoDocumento
        '
        Me.cmb_tipoDocumento.FormattingEnabled = True
        Me.cmb_tipoDocumento.Location = New System.Drawing.Point(134, 87)
        Me.cmb_tipoDocumento.Name = "cmb_tipoDocumento"
        Me.cmb_tipoDocumento.Size = New System.Drawing.Size(87, 21)
        Me.cmb_tipoDocumento.TabIndex = 26
        '
        'txt_numeroDocumento
        '
        Me.txt_numeroDocumento.Location = New System.Drawing.Point(134, 61)
        Me.txt_numeroDocumento.Mask = "999999999"
        Me.txt_numeroDocumento.Name = "txt_numeroDocumento"
        Me.txt_numeroDocumento.Size = New System.Drawing.Size(66, 20)
        Me.txt_numeroDocumento.TabIndex = 25
        '
        'txt_apellido
        '
        Me.txt_apellido.Location = New System.Drawing.Point(134, 114)
        Me.txt_apellido.Name = "txt_apellido"
        Me.txt_apellido.Size = New System.Drawing.Size(121, 20)
        Me.txt_apellido.TabIndex = 24
        '
        'txt_nombre
        '
        Me.txt_nombre.Location = New System.Drawing.Point(134, 140)
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Size = New System.Drawing.Size(121, 20)
        Me.txt_nombre.TabIndex = 23
        '
        'btn_aplicarFiltros
        '
        Me.btn_aplicarFiltros.Location = New System.Drawing.Point(98, 166)
        Me.btn_aplicarFiltros.Name = "btn_aplicarFiltros"
        Me.btn_aplicarFiltros.Size = New System.Drawing.Size(75, 23)
        Me.btn_aplicarFiltros.TabIndex = 22
        Me.btn_aplicarFiltros.Text = "Aplicar filtros"
        Me.btn_aplicarFiltros.UseVisualStyleBackColor = True
        '
        'lbl_nombre
        '
        Me.lbl_nombre.AutoSize = True
        Me.lbl_nombre.Location = New System.Drawing.Point(84, 143)
        Me.lbl_nombre.Name = "lbl_nombre"
        Me.lbl_nombre.Size = New System.Drawing.Size(44, 13)
        Me.lbl_nombre.TabIndex = 21
        Me.lbl_nombre.Text = "Nombre"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(84, 117)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 13)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Apellido"
        '
        'lbl_cantidadAlojamientos
        '
        Me.lbl_cantidadAlojamientos.AutoSize = True
        Me.lbl_cantidadAlojamientos.Location = New System.Drawing.Point(2, 38)
        Me.lbl_cantidadAlojamientos.Name = "lbl_cantidadAlojamientos"
        Me.lbl_cantidadAlojamientos.Size = New System.Drawing.Size(126, 13)
        Me.lbl_cantidadAlojamientos.TabIndex = 19
        Me.lbl_cantidadAlojamientos.Text = "Cantidad de Alojamientos"
        '
        'txt_cantidadAlojamientos
        '
        Me.txt_cantidadAlojamientos.Location = New System.Drawing.Point(134, 35)
        Me.txt_cantidadAlojamientos.Mask = "99999"
        Me.txt_cantidadAlojamientos.Name = "txt_cantidadAlojamientos"
        Me.txt_cantidadAlojamientos.Size = New System.Drawing.Size(39, 20)
        Me.txt_cantidadAlojamientos.TabIndex = 18
        Me.txt_cantidadAlojamientos.ValidatingType = GetType(Integer)
        '
        'lbl_filtros
        '
        Me.lbl_filtros.AutoSize = True
        Me.lbl_filtros.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_filtros.Location = New System.Drawing.Point(108, 12)
        Me.lbl_filtros.Name = "lbl_filtros"
        Me.lbl_filtros.Size = New System.Drawing.Size(44, 16)
        Me.lbl_filtros.TabIndex = 17
        Me.lbl_filtros.Text = "Filtros"
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "ListaClientesRegulares"
        ReportDataSource1.Value = Me.TablaClientesRegularesBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "TPI___PAV___2016.EstadisticaClientesRegulares.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(261, 12)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(664, 454)
        Me.ReportViewer1.TabIndex = 30
        '
        'DataSetMarce
        '
        Me.DataSetMarce.DataSetName = "DataSetMarce"
        Me.DataSetMarce.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TablaClientesRegularesBindingSource
        '
        Me.TablaClientesRegularesBindingSource.DataMember = "TablaClientesRegulares"
        Me.TablaClientesRegularesBindingSource.DataSource = Me.DataSetMarce
        '
        'TablaClientesRegularesTableAdapter
        '
        Me.TablaClientesRegularesTableAdapter.ClearBeforeFill = True
        '
        'FormClientesRegulares
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(937, 478)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.btn_x)
        Me.Controls.Add(Me.lbl_tipoDocumento)
        Me.Controls.Add(Me.lbl_numeroDocumento)
        Me.Controls.Add(Me.cmb_tipoDocumento)
        Me.Controls.Add(Me.txt_numeroDocumento)
        Me.Controls.Add(Me.txt_apellido)
        Me.Controls.Add(Me.txt_nombre)
        Me.Controls.Add(Me.btn_aplicarFiltros)
        Me.Controls.Add(Me.lbl_nombre)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lbl_cantidadAlojamientos)
        Me.Controls.Add(Me.txt_cantidadAlojamientos)
        Me.Controls.Add(Me.lbl_filtros)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "FormClientesRegulares"
        Me.Text = "FormClientesRegulares"
        CType(Me.DataSetMarce, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TablaClientesRegularesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_x As System.Windows.Forms.Button
    Friend WithEvents lbl_tipoDocumento As System.Windows.Forms.Label
    Friend WithEvents lbl_numeroDocumento As System.Windows.Forms.Label
    Friend WithEvents cmb_tipoDocumento As System.Windows.Forms.ComboBox
    Friend WithEvents txt_numeroDocumento As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txt_apellido As System.Windows.Forms.TextBox
    Friend WithEvents txt_nombre As System.Windows.Forms.TextBox
    Friend WithEvents btn_aplicarFiltros As System.Windows.Forms.Button
    Friend WithEvents lbl_nombre As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lbl_cantidadAlojamientos As System.Windows.Forms.Label
    Friend WithEvents txt_cantidadAlojamientos As System.Windows.Forms.MaskedTextBox
    Friend WithEvents lbl_filtros As System.Windows.Forms.Label
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents TablaClientesRegularesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DataSetMarce As TPI___PAV___2016.DataSetMarce
    Friend WithEvents TablaClientesRegularesTableAdapter As TPI___PAV___2016.DataSetMarceTableAdapters.TablaClientesRegularesTableAdapter
End Class
