Public Class FormEstadisticaTiposCama
    Dim accesoBD As AccesoBD = AccesoBD.instancia
    Private Sub FormEstadisticaTiposCama_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DataSetMarcelo.TiposCama' Puede moverla o quitarla según sea necesario.
        Me.TiposCamaTableAdapter.Fill(Me.DataSetMarcelo.TiposCama)
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub btn_limpiar_Click(sender As Object, e As EventArgs) Handles btn_limpiar.Click
        Me.txt_cantidad.Text = ""
        Me.TiposCamaBindingSource.DataSource = Me.TiposCamaTableAdapter.GetData
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub btn_aplicarFiltros_Click(sender As Object, e As EventArgs) Handles btn_aplicarFiltros.Click
        Dim tabla As Data.DataTable = Me.TiposCamaTableAdapter.GetData()

        If Me.txt_cantidad.Text = "" Then
            Me.txt_cantidad.Text = 0
        End If

        Me.TiposCamaBindingSource.DataSource = tabla.Select("Cantidad >= " & Me.txt_cantidad.Text)
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub txt_cantidad_MouseClick(sender As Object, e As MouseEventArgs) Handles txt_cantidad.MouseClick
        If Me.txt_cantidad.Text = "" Then
            Me.txt_cantidad.SelectionStart = 0
        End If
    End Sub
End Class