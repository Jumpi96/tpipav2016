Public Class FormHabitacionesMasUsadas
    Dim accesoBD As AccesoBD = AccesoBD.instancia
    Private Sub EstadisticaHabitacionesMasUsadas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DataSetMarcelo.TablaHabitacionesMasUsadas' Puede moverla o quitarla según sea necesario.
        Me.TablaHabitacionesMasUsadasTableAdapter.Fill(Me.DataSetMarcelo.TablaHabitacionesMasUsadas)

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub txt_cantidad_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles txt_cantidad.MaskInputRejected
        If Me.txt_cantidad.Text = "" Then
            Me.txt_cantidad.SelectionStart = 0
        End If
    End Sub

    Private Sub btn_limpiar_Click(sender As Object, e As EventArgs) Handles btn_limpiar.Click
        Me.txt_cantidad.Text = ""
        Me.TablaHabitacionesMasUsadasBindingSource.DataSource = Me.TablaHabitacionesMasUsadasTableAdapter.GetData
        ReportViewer1.RefreshReport()
    End Sub

    Private Sub btn_aplicarFiltros_Click(sender As Object, e As EventArgs) Handles btn_aplicarFiltros.Click
        If Me.txt_cantidad.Text = "" Then
            Me.txt_cantidad.Text = 0
        End If

        Dim tabla As Data.DataTable = Me.TablaHabitacionesMasUsadasTableAdapter.GetData
        Me.TablaHabitacionesMasUsadasBindingSource.DataSource = tabla.Select("Cantidad >= " & Me.txt_cantidad.Text)
        ReportViewer1.RefreshReport()
    End Sub
End Class