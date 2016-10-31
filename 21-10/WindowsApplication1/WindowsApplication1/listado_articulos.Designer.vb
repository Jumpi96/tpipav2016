<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class listado_articulos
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
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.LISTA_ARTICULOSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DSlistados = New WindowsApplication1.DSlistados()
        CType(Me.LISTA_ARTICULOSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DSlistados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.LISTA_ARTICULOSBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "WindowsApplication1.LISTADO_ARTICULO01.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(-4, 1)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(676, 525)
        Me.ReportViewer1.TabIndex = 0
        '
        'LISTA_ARTICULOSBindingSource
        '
        Me.LISTA_ARTICULOSBindingSource.DataMember = "LISTA_ARTICULOS"
        Me.LISTA_ARTICULOSBindingSource.DataSource = Me.DSlistados
        '
        'DSlistados
        '
        Me.DSlistados.DataSetName = "DSlistados"
        Me.DSlistados.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'listado_articulos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(672, 524)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "listado_articulos"
        Me.Text = "Form1"
        CType(Me.LISTA_ARTICULOSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DSlistados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents LISTA_ARTICULOSBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DSlistados As WindowsApplication1.DSlistados

End Class
