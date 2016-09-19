<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ABM_ServiciosXAlojamiento
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
        Me.lbl = New System.Windows.Forms.Label()
        Me.txtIdAloj = New System.Windows.Forms.TextBox()
        Me.btnBuscarAloj = New System.Windows.Forms.Button()
        Me.dgvServiciosXAloj = New System.Windows.Forms.DataGridView()
        Me.cmbServicios = New System.Windows.Forms.ComboBox()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.btnBorrar = New System.Windows.Forms.Button()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.Id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Alojamiento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Servicio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgvServiciosXAloj, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl
        '
        Me.lbl.AutoSize = True
        Me.lbl.Location = New System.Drawing.Point(13, 13)
        Me.lbl.Name = "lbl"
        Me.lbl.Size = New System.Drawing.Size(90, 13)
        Me.lbl.TabIndex = 0
        Me.lbl.Text = "Id. de alojamiento"
        '
        'txtIdAloj
        '
        Me.txtIdAloj.Location = New System.Drawing.Point(107, 10)
        Me.txtIdAloj.Name = "txtIdAloj"
        Me.txtIdAloj.Size = New System.Drawing.Size(100, 20)
        Me.txtIdAloj.TabIndex = 0
        '
        'btnBuscarAloj
        '
        Me.btnBuscarAloj.Location = New System.Drawing.Point(213, 8)
        Me.btnBuscarAloj.Name = "btnBuscarAloj"
        Me.btnBuscarAloj.Size = New System.Drawing.Size(75, 23)
        Me.btnBuscarAloj.TabIndex = 1
        Me.btnBuscarAloj.Text = "Buscar"
        Me.btnBuscarAloj.UseVisualStyleBackColor = True
        '
        'dgvServiciosXAloj
        '
        Me.dgvServiciosXAloj.AllowUserToAddRows = False
        Me.dgvServiciosXAloj.AllowUserToDeleteRows = False
        Me.dgvServiciosXAloj.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvServiciosXAloj.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Id, Me.Alojamiento, Me.Servicio})
        Me.dgvServiciosXAloj.Location = New System.Drawing.Point(8, 90)
        Me.dgvServiciosXAloj.MultiSelect = False
        Me.dgvServiciosXAloj.Name = "dgvServiciosXAloj"
        Me.dgvServiciosXAloj.ReadOnly = True
        Me.dgvServiciosXAloj.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvServiciosXAloj.Size = New System.Drawing.Size(326, 105)
        Me.dgvServiciosXAloj.TabIndex = 4
        '
        'cmbServicios
        '
        Me.cmbServicios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbServicios.FormattingEnabled = True
        Me.cmbServicios.Location = New System.Drawing.Point(69, 63)
        Me.cmbServicios.Name = "cmbServicios"
        Me.cmbServicios.Size = New System.Drawing.Size(160, 21)
        Me.cmbServicios.TabIndex = 2
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(235, 61)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(75, 23)
        Me.btnAgregar.TabIndex = 3
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Servicios"
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Location = New System.Drawing.Point(8, 201)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(75, 23)
        Me.btnLimpiar.TabIndex = 5
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'btnBorrar
        '
        Me.btnBorrar.Location = New System.Drawing.Point(89, 201)
        Me.btnBorrar.Name = "btnBorrar"
        Me.btnBorrar.Size = New System.Drawing.Size(75, 23)
        Me.btnBorrar.TabIndex = 6
        Me.btnBorrar.Text = "Borrar"
        Me.btnBorrar.UseVisualStyleBackColor = True
        '
        'btnCerrar
        '
        Me.btnCerrar.Location = New System.Drawing.Point(259, 238)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(75, 23)
        Me.btnCerrar.TabIndex = 7
        Me.btnCerrar.Text = "Cerrar"
        Me.btnCerrar.UseVisualStyleBackColor = True
        '
        'Id
        '
        Me.Id.HeaderText = "Id"
        Me.Id.Name = "Id"
        Me.Id.ReadOnly = True
        Me.Id.Width = 50
        '
        'Alojamiento
        '
        Me.Alojamiento.HeaderText = "Alojamiento"
        Me.Alojamiento.Name = "Alojamiento"
        Me.Alojamiento.ReadOnly = True
        Me.Alojamiento.Width = 80
        '
        'Servicio
        '
        Me.Servicio.HeaderText = "Servicio"
        Me.Servicio.Name = "Servicio"
        Me.Servicio.ReadOnly = True
        Me.Servicio.Width = 130
        '
        'ABM_ServiciosXAlojamiento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(346, 273)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.btnBorrar)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.cmbServicios)
        Me.Controls.Add(Me.dgvServiciosXAloj)
        Me.Controls.Add(Me.btnBuscarAloj)
        Me.Controls.Add(Me.txtIdAloj)
        Me.Controls.Add(Me.lbl)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(362, 312)
        Me.MinimumSize = New System.Drawing.Size(362, 312)
        Me.Name = "ABM_ServiciosXAlojamiento"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "ABM ServiciosXAlojamiento"
        CType(Me.dgvServiciosXAloj, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl As System.Windows.Forms.Label
    Friend WithEvents txtIdAloj As System.Windows.Forms.TextBox
    Friend WithEvents btnBuscarAloj As System.Windows.Forms.Button
    Friend WithEvents dgvServiciosXAloj As System.Windows.Forms.DataGridView
    Friend WithEvents cmbServicios As System.Windows.Forms.ComboBox
    Friend WithEvents btnAgregar As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnLimpiar As System.Windows.Forms.Button
    Friend WithEvents btnBorrar As System.Windows.Forms.Button
    Friend WithEvents btnCerrar As System.Windows.Forms.Button
    Friend WithEvents Id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Alojamiento As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Servicio As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
