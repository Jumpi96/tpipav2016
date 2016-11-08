<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormEdadesUsuales
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
        Dim ReportDataSource3 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.TabalaEstadisticaEdadesUsualesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSetMarcelo = New TPI___PAV___2016.DataSetMarcelo()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.lbl_filtros = New System.Windows.Forms.Label()
        Me.lbl_edadesDesde = New System.Windows.Forms.Label()
        Me.lbl_cantidad = New System.Windows.Forms.Label()
        Me.lbl_edadesHasta = New System.Windows.Forms.Label()
        Me.cmb_edadesDesde = New System.Windows.Forms.ComboBox()
        Me.cmb_edadesHasta = New System.Windows.Forms.ComboBox()
        Me.txt_cantidad = New System.Windows.Forms.MaskedTextBox()
        Me.btn_aplicarFiltros = New System.Windows.Forms.Button()
        Me.btn_limpiar = New System.Windows.Forms.Button()
        Me.TabalaEstadisticaEdadesUsualesTableAdapter = New TPI___PAV___2016.DataSetMarceloTableAdapters.TabalaEstadisticaEdadesUsualesTableAdapter()
        Me.TabalaEstadisticaEdadesUsualesTableAdapter.Connection.ConnectionString = accesoBD.instancia.cadenaConexion
        CType(Me.TabalaEstadisticaEdadesUsualesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetMarcelo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabalaEstadisticaEdadesUsualesBindingSource
        '
        Me.TabalaEstadisticaEdadesUsualesBindingSource.DataMember = "TabalaEstadisticaEdadesUsuales"
        Me.TabalaEstadisticaEdadesUsualesBindingSource.DataSource = Me.DataSetMarcelo
        '
        'DataSetMarcelo
        '
        Me.DataSetMarcelo.DataSetName = "DataSetMarcelo"
        Me.DataSetMarcelo.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        ReportDataSource3.Name = "ListaEdadesUsuales"
        ReportDataSource3.Value = Me.TabalaEstadisticaEdadesUsualesBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource3)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "TPI___PAV___2016.EstadisticaEdadesUsuales.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(240, 12)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(678, 483)
        Me.ReportViewer1.TabIndex = 10
        '
        'lbl_filtros
        '
        Me.lbl_filtros.AutoSize = True
        Me.lbl_filtros.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_filtros.Location = New System.Drawing.Point(12, 12)
        Me.lbl_filtros.Name = "lbl_filtros"
        Me.lbl_filtros.Size = New System.Drawing.Size(51, 16)
        Me.lbl_filtros.TabIndex = 1
        Me.lbl_filtros.Text = "Filtros"
        '
        'lbl_edadesDesde
        '
        Me.lbl_edadesDesde.AutoSize = True
        Me.lbl_edadesDesde.Location = New System.Drawing.Point(8, 60)
        Me.lbl_edadesDesde.Name = "lbl_edadesDesde"
        Me.lbl_edadesDesde.Size = New System.Drawing.Size(75, 13)
        Me.lbl_edadesDesde.TabIndex = 2
        Me.lbl_edadesDesde.Text = "Edades desde"
        '
        'lbl_cantidad
        '
        Me.lbl_cantidad.AutoSize = True
        Me.lbl_cantidad.Location = New System.Drawing.Point(34, 34)
        Me.lbl_cantidad.Name = "lbl_cantidad"
        Me.lbl_cantidad.Size = New System.Drawing.Size(49, 13)
        Me.lbl_cantidad.TabIndex = 3
        Me.lbl_cantidad.Text = "Cantidad"
        '
        'lbl_edadesHasta
        '
        Me.lbl_edadesHasta.AutoSize = True
        Me.lbl_edadesHasta.Location = New System.Drawing.Point(144, 60)
        Me.lbl_edadesHasta.Name = "lbl_edadesHasta"
        Me.lbl_edadesHasta.Size = New System.Drawing.Size(35, 13)
        Me.lbl_edadesHasta.TabIndex = 4
        Me.lbl_edadesHasta.Text = "Hasta"
        '
        'cmb_edadesDesde
        '
        Me.cmb_edadesDesde.FormattingEnabled = True
        Me.cmb_edadesDesde.Location = New System.Drawing.Point(89, 57)
        Me.cmb_edadesDesde.Name = "cmb_edadesDesde"
        Me.cmb_edadesDesde.Size = New System.Drawing.Size(49, 21)
        Me.cmb_edadesDesde.TabIndex = 2
        '
        'cmb_edadesHasta
        '
        Me.cmb_edadesHasta.FormattingEnabled = True
        Me.cmb_edadesHasta.Location = New System.Drawing.Point(185, 57)
        Me.cmb_edadesHasta.Name = "cmb_edadesHasta"
        Me.cmb_edadesHasta.Size = New System.Drawing.Size(49, 21)
        Me.cmb_edadesHasta.TabIndex = 3
        '
        'txt_cantidad
        '
        Me.txt_cantidad.Location = New System.Drawing.Point(89, 31)
        Me.txt_cantidad.Mask = "99999"
        Me.txt_cantidad.Name = "txt_cantidad"
        Me.txt_cantidad.Size = New System.Drawing.Size(38, 20)
        Me.txt_cantidad.TabIndex = 1
        Me.txt_cantidad.ValidatingType = GetType(Integer)
        '
        'btn_aplicarFiltros
        '
        Me.btn_aplicarFiltros.Location = New System.Drawing.Point(159, 84)
        Me.btn_aplicarFiltros.Name = "btn_aplicarFiltros"
        Me.btn_aplicarFiltros.Size = New System.Drawing.Size(75, 23)
        Me.btn_aplicarFiltros.TabIndex = 8
        Me.btn_aplicarFiltros.Text = "Aplicar filtros"
        Me.btn_aplicarFiltros.UseVisualStyleBackColor = True
        '
        'btn_limpiar
        '
        Me.btn_limpiar.Location = New System.Drawing.Point(8, 84)
        Me.btn_limpiar.Name = "btn_limpiar"
        Me.btn_limpiar.Size = New System.Drawing.Size(75, 23)
        Me.btn_limpiar.TabIndex = 9
        Me.btn_limpiar.Text = "Limpiar"
        Me.btn_limpiar.UseVisualStyleBackColor = True
        '
        'TabalaEstadisticaEdadesUsualesTableAdapter
        '
        Me.TabalaEstadisticaEdadesUsualesTableAdapter.ClearBeforeFill = True
        '
        'FormEdadesUsuales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(929, 507)
        Me.Controls.Add(Me.btn_limpiar)
        Me.Controls.Add(Me.btn_aplicarFiltros)
        Me.Controls.Add(Me.txt_cantidad)
        Me.Controls.Add(Me.cmb_edadesHasta)
        Me.Controls.Add(Me.cmb_edadesDesde)
        Me.Controls.Add(Me.lbl_edadesHasta)
        Me.Controls.Add(Me.lbl_cantidad)
        Me.Controls.Add(Me.lbl_edadesDesde)
        Me.Controls.Add(Me.lbl_filtros)
        Me.Controls.Add(Me.ReportViewer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "FormEdadesUsuales"
        Me.Text = "FormEdadesUsuales"
        CType(Me.TabalaEstadisticaEdadesUsualesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetMarcelo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents lbl_filtros As System.Windows.Forms.Label
    Friend WithEvents lbl_edadesDesde As System.Windows.Forms.Label
    Friend WithEvents lbl_cantidad As System.Windows.Forms.Label
    Friend WithEvents lbl_edadesHasta As System.Windows.Forms.Label
    Friend WithEvents cmb_edadesDesde As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_edadesHasta As System.Windows.Forms.ComboBox
    Friend WithEvents txt_cantidad As System.Windows.Forms.MaskedTextBox
    Friend WithEvents btn_aplicarFiltros As System.Windows.Forms.Button
    Friend WithEvents btn_limpiar As System.Windows.Forms.Button
    Friend WithEvents TabalaEstadisticaEdadesUsualesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DataSetMarcelo As TPI___PAV___2016.DataSetMarcelo
    Friend WithEvents TabalaEstadisticaEdadesUsualesTableAdapter As TPI___PAV___2016.DataSetMarceloTableAdapters.TabalaEstadisticaEdadesUsualesTableAdapter
End Class
