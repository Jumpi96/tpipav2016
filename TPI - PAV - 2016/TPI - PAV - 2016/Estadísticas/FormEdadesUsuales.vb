Public Class FormEdadesUsuales
    Dim accesoBD As AccesoBD = AccesoBD.instancia
    Private Sub FormEdadesUsuales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DataSetMarcelo.TabalaEstadisticaEdadesUsuales' Puede moverla o quitarla según sea necesario.
        Me.TabalaEstadisticaEdadesUsualesTableAdapter.Fill(Me.DataSetMarcelo.TabalaEstadisticaEdadesUsuales)
        Me.cargarCombo()
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub cargarCombo()
        Dim tabla As Data.DataTable = Me.TabalaEstadisticaEdadesUsualesTableAdapter.GetData

        cmb_edadesDesde.DataSource = tabla
        cmb_edadesDesde.ValueMember = "Edad"
        cmb_edadesDesde.DisplayMember = "Edad"

        cmb_edadesHasta.DataSource = tabla
        cmb_edadesHasta.ValueMember = "Edad"
        cmb_edadesHasta.DisplayMember = "Edad"

        Me.cmb_edadesDesde.SelectedIndex = -1
        Me.cmb_edadesHasta.SelectedIndex = -1
    End Sub

    Private Sub txt_cantidad_MouseClick(sender As Object, e As MouseEventArgs) Handles txt_cantidad.MouseClick
        If Me.txt_cantidad.Text = "" Then
            Me.txt_cantidad.SelectionStart = 0
        End If
    End Sub

    Private Sub btn_limpiar_Click(sender As Object, e As EventArgs) Handles btn_limpiar.Click
        Me.txt_cantidad.Text = ""
        Me.cmb_edadesDesde.SelectedIndex = -1
        Me.cmb_edadesHasta.SelectedIndex = -1
        Me.TabalaEstadisticaEdadesUsualesBindingSource.DataSource = Me.TabalaEstadisticaEdadesUsualesTableAdapter.GetData
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub btn_aplicarFiltros_Click(sender As Object, e As EventArgs) Handles btn_aplicarFiltros.Click
        Dim tabla As Data.DataTable = Me.TabalaEstadisticaEdadesUsualesTableAdapter.GetData

        If Me.txt_cantidad.Text = "" Then
            Me.txt_cantidad.Text = 0
        End If

        If Me.cmb_edadesDesde.SelectedIndex = -1 And Me.cmb_edadesHasta.SelectedIndex = -1 Then
            Me.TabalaEstadisticaEdadesUsualesBindingSource.DataSource = tabla.Select("Cantidad >= " & Me.txt_cantidad.Text)
        ElseIf Me.cmb_edadesDesde.SelectedIndex <> -1 And Me.cmb_edadesHasta.SelectedIndex = -1 Then
            Me.TabalaEstadisticaEdadesUsualesBindingSource.DataSource = tabla.Select("Cantidad >= " & Me.txt_cantidad.Text & " and Edad >= " & Me.cmb_edadesDesde.SelectedValue)
        ElseIf Me.cmb_edadesDesde.SelectedIndex = -1 And Me.cmb_edadesHasta.SelectedIndex <> -1 Then
            Me.TabalaEstadisticaEdadesUsualesBindingSource.DataSource = tabla.Select("Cantidad >= " & Me.txt_cantidad.Text & " and Edad <= " & Me.cmb_edadesHasta.SelectedValue)
        Else
            Me.TabalaEstadisticaEdadesUsualesBindingSource.DataSource = tabla.Select("Cantidad >= " & Me.txt_cantidad.Text & " and Edad >= " & Me.cmb_edadesDesde.SelectedValue & " and Edad <= " & Me.cmb_edadesHasta.SelectedValue)
        End If

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub cmb_edadesHasta_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_edadesHasta.SelectedIndexChanged
        If Me.cmb_edadesDesde.SelectedIndex <> -1 Then
            If Me.cmb_edadesDesde.SelectedIndex < Me.cmb_edadesHasta.SelectedIndex Then
                Me.cmb_edadesDesde.SelectedIndex = Me.cmb_edadesHasta.SelectedIndex
            End If
        Else
            Me.cmb_edadesDesde.SelectedIndex = -1
        End If
    End Sub

    Private Sub cmb_edadesHasta_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cmb_edadesHasta.SelectionChangeCommitted
        
    End Sub

    Private Sub cmb_edadesDesde_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_edadesDesde.SelectedIndexChanged
        If Me.cmb_edadesHasta.SelectedIndex <> -1 Then
            If Me.cmb_edadesHasta.SelectedIndex > Me.cmb_edadesDesde.SelectedIndex Then
                Me.cmb_edadesHasta.SelectedIndex = Me.cmb_edadesDesde.SelectedIndex
            End If
            Me.cmb_edadesHasta.SelectedIndex = -1
        End If
    End Sub

    Private Sub cmb_edadesDesde_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cmb_edadesDesde.SelectionChangeCommitted
        
    End Sub
End Class