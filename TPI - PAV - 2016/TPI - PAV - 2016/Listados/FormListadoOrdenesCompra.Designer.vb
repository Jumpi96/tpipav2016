<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormListadoOrdenesCompra
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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.OrdenesCompraBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet = New TPI___PAV___2016.DataSet()
        Me.OrdenesCompraTableAdapter = New TPI___PAV___2016.DataSetTableAdapters.OrdenesCompraTableAdapter()
        Me.OrdenesCompraTableAdapter.Connection.ConnectionString = AccesoBD.instancia.cadenaConexion
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.OrdenesCompra1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OrdenesCompra1TableAdapter = New TPI___PAV___2016.DataSetTableAdapters.OrdenesCompra1TableAdapter()
        Me.OrdenesCompra1TableAdapter.Connection.ConnectionString = AccesoBD.instancia.cadenaConexion
        CType(Me.OrdenesCompraBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrdenesCompra1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'OrdenesCompraBindingSource
        '
        Me.OrdenesCompraBindingSource.DataMember = "OrdenesCompra"
        Me.OrdenesCompraBindingSource.DataSource = Me.DataSet
        '
        'DataSet
        '
        Me.DataSet.DataSetName = "DataSet"
        Me.DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'OrdenesCompraTableAdapter
        '
        Me.OrdenesCompraTableAdapter.ClearBeforeFill = True
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.OrdenesCompra1BindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "TPI___PAV___2016.ListadoOrdenesCompra.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(643, 517)
        Me.ReportViewer1.TabIndex = 0
        '
        'OrdenesCompra1BindingSource
        '
        Me.OrdenesCompra1BindingSource.DataMember = "OrdenesCompra1"
        Me.OrdenesCompra1BindingSource.DataSource = Me.DataSet
        '
        'OrdenesCompra1TableAdapter
        '
        Me.OrdenesCompra1TableAdapter.ClearBeforeFill = True
        '
        'FormListadoOrdenesCompra
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(643, 517)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MinimumSize = New System.Drawing.Size(659, 556)
        Me.Name = "FormListadoOrdenesCompra"
        Me.Text = "Form1"
        CType(Me.OrdenesCompraBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrdenesCompra1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents OrdenesCompraBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DataSet As TPI___PAV___2016.DataSet
    Friend WithEvents OrdenesCompraTableAdapter As TPI___PAV___2016.DataSetTableAdapters.OrdenesCompraTableAdapter
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents OrdenesCompra1BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents OrdenesCompra1TableAdapter As TPI___PAV___2016.DataSetTableAdapters.OrdenesCompra1TableAdapter
End Class
