Public Class FormEdadesUsuales
    Dim accesoBD As AccesoBD = accesoBD.instancia
    Dim cargado As Boolean = False

    Private Sub FormEdadesUsuales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DataSetMarcelo.TabalaEstadisticaEdadesUsuales' Puede moverla o quitarla según sea necesario.


        Me.TabalaEstadisticaEdadesUsualesTableAdapter.Fill(Me.DataSetMarcelo.TabalaEstadisticaEdadesUsuales)

        Me.cargarCombo(cmb_edadesDesde, False)

        Me.cmb_edadesHasta.Enabled = False
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub cargarCombo(ByRef combo As ComboBox, ByVal hasta As Boolean)
        Dim tabla As Data.DataTable = Me.TabalaEstadisticaEdadesUsualesTableAdapter.GetData

        If hasta And cargado Then

            combo.DataSource = tabla.Select("Edad >= " + Me.cmb_edadesDesde.SelectedValue.ToString)
        Else
            combo.DataSource = tabla
        End If

        combo.ValueMember = "Edad"
        combo.DisplayMember = "Edad"

        If cargado = False Then
            Me.cmb_edadesDesde.SelectedIndex = -1
            Me.cmb_edadesHasta.SelectedIndex = -1
        End If
        


        cargado = True

    End Sub

    Private Sub txt_cantidad_MouseClick(sender As Object, e As MouseEventArgs) Handles txt_cantidad.MouseClick
        If Me.txt_cantidad.Text = "" Then
            Me.txt_cantidad.SelectionStart = 0
        End If
    End Sub

    Private Sub btn_limpiar_Click(sender As Object, e As EventArgs) Handles btn_limpiar.Click
        Me.txt_cantidad.Text = ""
        cargado = False
        Me.cmb_edadesHasta.Enabled = False
        Me.cmb_edadesDesde.SelectedIndex = -1
        Me.cmb_edadesHasta.SelectedIndex = -1
        cargado = True
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

    Private Sub cmb_edadesDesde_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_edadesDesde.SelectedIndexChanged
        If cargado Then
            Me.cmb_edadesHasta.Enabled = True

            cargarCombo(Me.cmb_edadesHasta, True)
        End If
    End Sub


End Class