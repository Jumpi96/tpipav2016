﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormDuracionAlojamientos
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
        Me.EstadisticaDuracionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet = New TPI___PAV___2016.DataSet()
        Me.ArticulosConsumoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.ArticulosConsumoTableAdapter = New TPI___PAV___2016.DataSetTableAdapters.ArticulosConsumoTableAdapter()
        Me.EstadisticaDuracionTableAdapter = New TPI___PAV___2016.DataSetTableAdapters.EstadisticaDuracionTableAdapter()
        CType(Me.EstadisticaDuracionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ArticulosConsumoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'EstadisticaDuracionBindingSource
        '
        Me.EstadisticaDuracionBindingSource.DataMember = "EstadisticaDuracion"
        Me.EstadisticaDuracionBindingSource.DataSource = Me.DataSet
        '
        'DataSet
        '
        Me.DataSet.DataSetName = "DataSet"
        Me.DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ArticulosConsumoBindingSource
        '
        Me.ArticulosConsumoBindingSource.DataMember = "ArticulosConsumo"
        Me.ArticulosConsumoBindingSource.DataSource = Me.DataSet
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.EstadisticaDuracionBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "TPI___PAV___2016.EstadisticaDuracionAlojamientos.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Padding = New System.Windows.Forms.Padding(60, 0, 60, 0)
        Me.ReportViewer1.Size = New System.Drawing.Size(643, 517)
        Me.ReportViewer1.TabIndex = 0
        '
        'ArticulosConsumoTableAdapter
        '
        Me.ArticulosConsumoTableAdapter.ClearBeforeFill = True
        '
        'EstadisticaDuracionTableAdapter
        '
        Me.EstadisticaDuracionTableAdapter.ClearBeforeFill = True
        '
        'FormDuracionAlojamientos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(643, 517)
        Me.Controls.Add(Me.ReportViewer1)
        Me.MinimumSize = New System.Drawing.Size(659, 556)
        Me.Name = "FormDuracionAlojamientos"
        Me.Text = "Estadística de duración de alojamientos"
        CType(Me.EstadisticaDuracionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ArticulosConsumoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents ArticulosConsumoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DataSet As TPI___PAV___2016.DataSet
    Friend WithEvents ArticulosConsumoTableAdapter As TPI___PAV___2016.DataSetTableAdapters.ArticulosConsumoTableAdapter
    Friend WithEvents EstadisticaDuracionBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EstadisticaDuracionTableAdapter As TPI___PAV___2016.DataSetTableAdapters.EstadisticaDuracionTableAdapter
End Class
