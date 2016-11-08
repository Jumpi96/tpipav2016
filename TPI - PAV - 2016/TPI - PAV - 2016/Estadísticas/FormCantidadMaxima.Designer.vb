<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCantidadMaxima
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
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.DataSet = New TPI___PAV___2016.DataSet()
        Me.HabitacionesXPisoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.HabitacionesXPisoTableAdapter = New TPI___PAV___2016.DataSetTableAdapters.HabitacionesXPisoTableAdapter()
        Me.EstadisitcaCantMaxBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HabitacionesXPisoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EstadisitcaCantMaxBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.HabitacionesXPisoBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "TPI___PAV___2016.EstadisiticaCantidadMaxima.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(643, 518)
        Me.ReportViewer1.TabIndex = 0
        '
        'DataSet
        '
        Me.DataSet.DataSetName = "DataSet"
        Me.DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'HabitacionesXPisoBindingSource
        '
        Me.HabitacionesXPisoBindingSource.DataMember = "HabitacionesXPiso"
        Me.HabitacionesXPisoBindingSource.DataSource = Me.DataSet
        '
        'HabitacionesXPisoTableAdapter
        '
        Me.HabitacionesXPisoTableAdapter.ClearBeforeFill = True
        '
        'EstadisitcaCantMaxBindingSource
        '
        Me.EstadisitcaCantMaxBindingSource.DataMember = "EstadisitcaCantMax"
        Me.EstadisitcaCantMaxBindingSource.DataSource = Me.DataSet
        '
        'FormCantidadMaxima
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(643, 518)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "FormCantidadMaxima"
        Me.Text = "FormCantidadMaxima"
        CType(Me.DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HabitacionesXPisoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EstadisitcaCantMaxBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents HabitacionesXPisoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DataSet As TPI___PAV___2016.DataSet
    Friend WithEvents HabitacionesXPisoTableAdapter As TPI___PAV___2016.DataSetTableAdapters.HabitacionesXPisoTableAdapter
    Friend WithEvents EstadisitcaCantMaxBindingSource As System.Windows.Forms.BindingSource
End Class
