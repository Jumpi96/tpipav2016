﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormListadoFacturas
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
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.FacturasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet = New TPI___PAV___2016.DataSet()
        Me.FacturasTableAdapter = New TPI___PAV___2016.DataSetTableAdapters.FacturasTableAdapter()
        Me.btnBuscarPorDoc = New System.Windows.Forms.Button()
        Me.txtNroDoc = New System.Windows.Forms.TextBox()
        Me.cmbTipoDoc = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.FacturasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        ReportDataSource2.Name = "DataSet1"
        ReportDataSource2.Value = Me.FacturasBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "TPI___PAV___2016.ListadoFacturas.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(2, 165)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(853, 466)
        Me.ReportViewer1.TabIndex = 0
        '
        'FacturasBindingSource
        '
        Me.FacturasBindingSource.DataMember = "Facturas"
        Me.FacturasBindingSource.DataSource = Me.DataSet
        '
        'DataSet
        '
        Me.DataSet.DataSetName = "DataSet"
        Me.DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'FacturasTableAdapter
        '
        Me.FacturasTableAdapter.ClearBeforeFill = True
        '
        'btnBuscarPorDoc
        '
        Me.btnBuscarPorDoc.Location = New System.Drawing.Point(315, 17)
        Me.btnBuscarPorDoc.Margin = New System.Windows.Forms.Padding(4)
        Me.btnBuscarPorDoc.Name = "btnBuscarPorDoc"
        Me.btnBuscarPorDoc.Size = New System.Drawing.Size(148, 46)
        Me.btnBuscarPorDoc.TabIndex = 15
        Me.btnBuscarPorDoc.Text = "Buscar por Documento"
        Me.btnBuscarPorDoc.UseVisualStyleBackColor = True
        '
        'txtNroDoc
        '
        Me.txtNroDoc.Location = New System.Drawing.Point(96, 47)
        Me.txtNroDoc.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNroDoc.Name = "txtNroDoc"
        Me.txtNroDoc.Size = New System.Drawing.Size(183, 22)
        Me.txtNroDoc.TabIndex = 12
        '
        'cmbTipoDoc
        '
        Me.cmbTipoDoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTipoDoc.FormattingEnabled = True
        Me.cmbTipoDoc.Location = New System.Drawing.Point(95, 13)
        Me.cmbTipoDoc.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbTipoDoc.Name = "cmbTipoDoc"
        Me.cmbTipoDoc.Size = New System.Drawing.Size(184, 24)
        Me.cmbTipoDoc.TabIndex = 11
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(18, 47)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 17)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Nro. Doc."
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(16, 17)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 17)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Tipo Doc."
        '
        'FormListadoFacturas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(857, 636)
        Me.Controls.Add(Me.btnBuscarPorDoc)
        Me.Controls.Add(Me.txtNroDoc)
        Me.Controls.Add(Me.cmbTipoDoc)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "FormListadoFacturas"
        Me.Text = "Form1"
        CType(Me.FacturasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents FacturasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DataSet As TPI___PAV___2016.DataSet
    Friend WithEvents FacturasTableAdapter As TPI___PAV___2016.DataSetTableAdapters.FacturasTableAdapter
    Friend WithEvents btnBuscarPorDoc As System.Windows.Forms.Button
    Friend WithEvents txtNroDoc As System.Windows.Forms.TextBox
    Friend WithEvents cmbTipoDoc As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
