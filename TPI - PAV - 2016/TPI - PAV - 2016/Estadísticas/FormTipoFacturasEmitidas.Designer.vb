<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormTipoFacturasEmitidas
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_cantidad = New System.Windows.Forms.MaskedTextBox()
        Me.ESTADISTICAFACTURASEMITIDASBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet = New TPI___PAV___2016.DataSet()
        CType(Me.ESTADISTICAFACTURASEMITIDASBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.ESTADISTICAFACTURASEMITIDASBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "TPI___PAV___2016.EstadisticaFacturasEmitidas.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(1, 45)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(641, 473)
        Me.ReportViewer1.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(549, 10)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Filtrar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(5, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Cantidad Mínima"
        '
        'txt_cantidad
        '
        Me.txt_cantidad.Location = New System.Drawing.Point(104, 12)
        Me.txt_cantidad.Mask = "99999"
        Me.txt_cantidad.Name = "txt_cantidad"
        Me.txt_cantidad.Size = New System.Drawing.Size(48, 20)
        Me.txt_cantidad.TabIndex = 4
        Me.txt_cantidad.ValidatingType = GetType(Integer)
        '
        'ESTADISTICAFACTURASEMITIDASBindingSource
        '
        Me.ESTADISTICAFACTURASEMITIDASBindingSource.DataMember = "ESTADISTICAFACTURASEMITIDAS"
        Me.ESTADISTICAFACTURASEMITIDASBindingSource.DataSource = Me.DataSet
        '
        'DataSet
        '
        Me.DataSet.DataSetName = "DataSet"
        Me.DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'FormFacturasEmitidas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(643, 518)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_cantidad)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "FormFacturasEmitidas"
        Me.Text = "FormFacturasEmitidas"
        CType(Me.ESTADISTICAFACTURASEMITIDASBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents ESTADISTICAFACTURASEMITIDASBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DataSet As TPI___PAV___2016.DataSet
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_cantidad As System.Windows.Forms.MaskedTextBox
End Class
