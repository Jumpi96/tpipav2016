<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormListadoServiciosActuales
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
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.ListadoConsumicionesActualesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet = New TPI___PAV___2016.DataSet()
        Me.ListadoConsumicionesActualesTableAdapter = New TPI___PAV___2016.DataSetTableAdapters.ListadoConsumicionesActualesTableAdapter()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.ServiciosActualesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ServiciosActualesTableAdapter = New TPI___PAV___2016.DataSetTableAdapters.ServiciosActualesTableAdapter()
        Me.ServiciosActualesTableAdapter.Connection.ConnectionString = AccesoBD.instancia.cadenaConexion
        CType(Me.ListadoConsumicionesActualesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ServiciosActualesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ListadoConsumicionesActualesBindingSource
        '
        Me.ListadoConsumicionesActualesBindingSource.DataMember = "ListadoConsumicionesActuales"
        Me.ListadoConsumicionesActualesBindingSource.DataSource = Me.DataSet
        '
        'DataSet
        '
        Me.DataSet.DataSetName = "DataSet"
        Me.DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ListadoConsumicionesActualesTableAdapter
        '
        Me.ListadoConsumicionesActualesTableAdapter.ClearBeforeFill = True
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource2.Name = "DataSet1"
        ReportDataSource2.Value = Me.ServiciosActualesBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "TPI___PAV___2016.ListadoServiciosActuales.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Padding = New System.Windows.Forms.Padding(60, 0, 60, 0)
        Me.ReportViewer1.Size = New System.Drawing.Size(643, 517)
        Me.ReportViewer1.TabIndex = 0
        '
        'ServiciosActualesBindingSource
        '
        Me.ServiciosActualesBindingSource.DataMember = "ServiciosActuales"
        Me.ServiciosActualesBindingSource.DataSource = Me.DataSet
        '
        'ServiciosActualesTableAdapter
        '
        Me.ServiciosActualesTableAdapter.ClearBeforeFill = True
        '
        'FormListadoServiciosActuales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(643, 517)
        Me.Controls.Add(Me.ReportViewer1)
        Me.MinimumSize = New System.Drawing.Size(659, 556)
        Me.Name = "FormListadoServiciosActuales"
        Me.Text = "Listado de servicios actuales"
        CType(Me.ListadoConsumicionesActualesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ServiciosActualesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ListadoConsumicionesActualesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DataSet As TPI___PAV___2016.DataSet
    Friend WithEvents ListadoConsumicionesActualesTableAdapter As TPI___PAV___2016.DataSetTableAdapters.ListadoConsumicionesActualesTableAdapter
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents ServiciosActualesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ServiciosActualesTableAdapter As TPI___PAV___2016.DataSetTableAdapters.ServiciosActualesTableAdapter
End Class
