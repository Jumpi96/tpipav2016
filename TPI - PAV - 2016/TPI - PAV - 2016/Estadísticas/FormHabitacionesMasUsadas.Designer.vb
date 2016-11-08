<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormHabitacionesMasUsadas
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
        Dim ReportDataSource4 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.DataSetMarcelo = New TPI___PAV___2016.DataSetMarcelo()
        Me.TablaHabitacionesMasUsadasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TablaHabitacionesMasUsadasTableAdapter = New TPI___PAV___2016.DataSetMarceloTableAdapters.TablaHabitacionesMasUsadasTableAdapter()
        Me.TablaHabitacionesMasUsadasTableAdapter.Connection.ConnectionString = accesoBD.instancia.cadenaConexion
        Me.btn_limpiar = New System.Windows.Forms.Button()
        Me.btn_aplicarFiltros = New System.Windows.Forms.Button()
        Me.txt_cantidad = New System.Windows.Forms.MaskedTextBox()
        Me.lbl_cantidad = New System.Windows.Forms.Label()
        Me.lbl_filtros = New System.Windows.Forms.Label()
        CType(Me.DataSetMarcelo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TablaHabitacionesMasUsadasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        ReportDataSource4.Name = "ListaHabitacionesMasUsadas"
        ReportDataSource4.Value = Me.TablaHabitacionesMasUsadasBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource4)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "TPI___PAV___2016.EstadisticaHabitacionesMasUsadas.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(174, 12)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(683, 486)
        Me.ReportViewer1.TabIndex = 0
        '
        'DataSetMarcelo
        '
        Me.DataSetMarcelo.DataSetName = "DataSetMarcelo"
        Me.DataSetMarcelo.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TablaHabitacionesMasUsadasBindingSource
        '
        Me.TablaHabitacionesMasUsadasBindingSource.DataMember = "TablaHabitacionesMasUsadas"
        Me.TablaHabitacionesMasUsadasBindingSource.DataSource = Me.DataSetMarcelo
        '
        'TablaHabitacionesMasUsadasTableAdapter
        '
        Me.TablaHabitacionesMasUsadasTableAdapter.ClearBeforeFill = True
        '
        'btn_limpiar
        '
        Me.btn_limpiar.Location = New System.Drawing.Point(12, 57)
        Me.btn_limpiar.Name = "btn_limpiar"
        Me.btn_limpiar.Size = New System.Drawing.Size(75, 23)
        Me.btn_limpiar.TabIndex = 10
        Me.btn_limpiar.Text = "Limpiar"
        Me.btn_limpiar.UseVisualStyleBackColor = True
        '
        'btn_aplicarFiltros
        '
        Me.btn_aplicarFiltros.Location = New System.Drawing.Point(93, 57)
        Me.btn_aplicarFiltros.Name = "btn_aplicarFiltros"
        Me.btn_aplicarFiltros.Size = New System.Drawing.Size(75, 23)
        Me.btn_aplicarFiltros.TabIndex = 9
        Me.btn_aplicarFiltros.Text = "Aplicar filtros"
        Me.btn_aplicarFiltros.UseVisualStyleBackColor = True
        '
        'txt_cantidad
        '
        Me.txt_cantidad.Location = New System.Drawing.Point(68, 31)
        Me.txt_cantidad.Mask = "99999"
        Me.txt_cantidad.Name = "txt_cantidad"
        Me.txt_cantidad.Size = New System.Drawing.Size(40, 20)
        Me.txt_cantidad.TabIndex = 6
        Me.txt_cantidad.ValidatingType = GetType(Integer)
        '
        'lbl_cantidad
        '
        Me.lbl_cantidad.AutoSize = True
        Me.lbl_cantidad.Location = New System.Drawing.Point(13, 34)
        Me.lbl_cantidad.Name = "lbl_cantidad"
        Me.lbl_cantidad.Size = New System.Drawing.Size(49, 13)
        Me.lbl_cantidad.TabIndex = 8
        Me.lbl_cantidad.Text = "Cantidad"
        '
        'lbl_filtros
        '
        Me.lbl_filtros.AutoSize = True
        Me.lbl_filtros.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_filtros.Location = New System.Drawing.Point(12, 12)
        Me.lbl_filtros.Name = "lbl_filtros"
        Me.lbl_filtros.Size = New System.Drawing.Size(51, 16)
        Me.lbl_filtros.TabIndex = 7
        Me.lbl_filtros.Text = "Filtros"
        '
        'EstadisticaHabitacionesMasUsadas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(870, 510)
        Me.Controls.Add(Me.btn_limpiar)
        Me.Controls.Add(Me.btn_aplicarFiltros)
        Me.Controls.Add(Me.txt_cantidad)
        Me.Controls.Add(Me.lbl_cantidad)
        Me.Controls.Add(Me.lbl_filtros)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "EstadisticaHabitacionesMasUsadas"
        Me.Text = "EstadisticaHabitacionesMasUsadas"
        CType(Me.DataSetMarcelo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TablaHabitacionesMasUsadasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents TablaHabitacionesMasUsadasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DataSetMarcelo As TPI___PAV___2016.DataSetMarcelo
    Friend WithEvents TablaHabitacionesMasUsadasTableAdapter As TPI___PAV___2016.DataSetMarceloTableAdapters.TablaHabitacionesMasUsadasTableAdapter
    Friend WithEvents btn_limpiar As System.Windows.Forms.Button
    Friend WithEvents btn_aplicarFiltros As System.Windows.Forms.Button
    Friend WithEvents txt_cantidad As System.Windows.Forms.MaskedTextBox
    Friend WithEvents lbl_cantidad As System.Windows.Forms.Label
    Friend WithEvents lbl_filtros As System.Windows.Forms.Label
End Class
