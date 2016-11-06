Public Class FormClientesRegulares
    Dim accesoBD As AccesoBD = AccesoBD.instancia
    Private Sub FormClientesRegulares_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TablaClientesRegularesTableAdapter.Fill(Me.DataSetMarce.TablaClientesRegulares)
        Me.cargarCombo()
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub txt_cantidadAlojamientos_MouseClick(sender As Object, e As MouseEventArgs) Handles txt_cantidadAlojamientos.MouseClick
        If Me.txt_cantidadAlojamientos.Text = "" Then
            Me.txt_cantidadAlojamientos.SelectionStart = 0
        End If
    End Sub

    Private Sub cargarCombo()
        Dim consulta As String = "SELECT * FROM TiposDocumento"
        Dim tabla As Data.DataTable = accesoBD.query(consulta)
        cmb_tipoDocumento.DataSource = tabla
        cmb_tipoDocumento.ValueMember = "idTipoDocumento"
        cmb_tipoDocumento.DisplayMember = "nombre"

    End Sub

    Private Sub btn_aplicarFiltros_Click(sender As Object, e As EventArgs) Handles btn_aplicarFiltros.Click
        Dim tabla As Data.DataTable = Me.DataSetMarce.TablaClientesRegulares
        If Me.txt_cantidadAlojamientos.Text = "" Then
            Me.txt_cantidadAlojamientos.Text = 0
        End If
        If Me.cmb_tipoDocumento.SelectedIndex = -1 And Me.txt_numeroDocumento.Text = "" Then
            Me.TablaClientesRegularesBindingSource().DataSource = tabla.Select("cantidad >= " & Me.txt_cantidadAlojamientos.Text & " and nombreCliente like '%" & Me.txt_nombre.Text & "%' and apellido like '%" & Me.txt_apellido.Text & "%'")
        ElseIf Me.cmb_tipoDocumento.SelectedIndex = -1 Then
            Me.TablaClientesRegularesBindingSource().DataSource = tabla.Select("cantidad >= " & Me.txt_cantidadAlojamientos.Text & " and nroDocumento = " & Me.txt_numeroDocumento.Text & " and nombreCliente like '%" & Me.txt_nombre.Text & "%' and apellido like '%" & Me.txt_apellido.Text & "%'")
        ElseIf Me.txt_numeroDocumento.Text = "" Then
            Me.TablaClientesRegularesBindingSource().DataSource = tabla.Select("cantidad >= " & Me.txt_cantidadAlojamientos.Text & " and tipoDocumento = " & Me.cmb_tipoDocumento.SelectedIndex & " and nombreCliente like '%" & Me.txt_nombre.Text & "%' and apellido like '%" & Me.txt_apellido.Text & "%'")
        Else
            Me.TablaClientesRegularesBindingSource().DataSource = tabla.Select("cantidad >= " & Me.txt_cantidadAlojamientos.Text & " and nroDocumento = " & Me.txt_numeroDocumento.Text & " and tipoDocumento = " & Me.cmb_tipoDocumento.SelectedIndex & " and nombreCliente like '%" & Me.txt_nombre.Text & "%' and apellido like '%" & Me.txt_apellido.Text & "%'")
        End If
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub btn_x_Click(sender As Object, e As EventArgs) Handles btn_x.Click
        Me.cmb_tipoDocumento.SelectedIndex = -1
    End Sub

    Private Sub txt_numeroDocumento_MouseClick(sender As Object, e As MouseEventArgs) Handles txt_numeroDocumento.MouseClick
        If Me.txt_numeroDocumento.Text = "" Then
            Me.txt_numeroDocumento.SelectionStart = 0
        End If
    End Sub
End Class