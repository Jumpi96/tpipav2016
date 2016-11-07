Public Class FormClientesRecurrentes
    Dim accesoBD As AccesoBD = accesoBD.instancia
    Dim cantidadPromedio As Int16 = 0
    Private Sub FormClientesRecurrentes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DataSetMarcelo.TablaEstadisticaClientesRecurrentes' Puede moverla o quitarla según sea necesario.
        Me.TablaEstadisticaClientesRecurrentesTableAdapter.Fill(Me.DataSetMarcelo.TablaEstadisticaClientesRecurrentes)
        Me.cargarCombo()
        Me.rp_clientesRecurrentes.RefreshReport()
    End Sub

    Private Sub cargarCombo()
        Dim consulta As String = "SELECT * FROM TiposDocumento"
        Dim tabla As Data.DataTable = AccesoBD.query(consulta)
        cmb_tipoDocumento.DataSource = tabla
        cmb_tipoDocumento.ValueMember = "idTipoDocumento"
        cmb_tipoDocumento.DisplayMember = "nombre"
    End Sub
    Private Sub btn_aplicarFiltros_Click(sender As Object, e As EventArgs) Handles btn_aplicarFiltros.Click
        Dim tabla As Data.DataTable = Me.DataSetMarcelo.TablaEstadisticaClientesRecurrentes
        If Me.txt_cantidadAlojamientos.Text = "" Then
            Me.txt_cantidadAlojamientos.Text = 0
        End If
        If Me.txt_numeroDocumento.Text = "" Then
            Me.TablaEstadisticaClientesRecurrentesBindingSource().DataSource = tabla.Select("Cantidad >= " & Me.txt_cantidadAlojamientos.Text & " and nombreDocumento like '%" & Me.cmb_tipoDocumento.SelectedValue & "%' and nombreCliente like '%" & Me.txt_nombre.Text & "%' and Apellido like '%" & Me.txt_apellido.Text & "%'")
        Else
            Me.TablaEstadisticaClientesRecurrentesBindingSource().DataSource = tabla.Select("Cantidad >= " & Me.txt_cantidadAlojamientos.Text & " and numeroDocumento = " & Me.txt_numeroDocumento.Text & " and nombreDocumento like '%" & Me.cmb_tipoDocumento.SelectedValue & "%' and nombreCliente like '%" & Me.txt_nombre.Text & "%' and Apellido like '%" & Me.txt_apellido.Text & "%'")
        End If
        Me.rp_clientesRecurrentes.RefreshReport()
    End Sub

    Private Sub lbl_desSeleccionarTipoDocumento_Click(sender As Object, e As EventArgs) Handles lbl_desSeleccionarTipoDocumento.Click
        Me.cmb_tipoDocumento.SelectedIndex = -1
    End Sub

    Private Sub txt_cantidadAlojamientos_MouseClick(sender As Object, e As MouseEventArgs) Handles txt_cantidadAlojamientos.MouseClick
        If Me.txt_cantidadAlojamientos.Text = "" Then
            Me.txt_cantidadAlojamientos.SelectionStart = 0
        End If
    End Sub

    Private Sub txt_numeroDocumento_MouseClick(sender As Object, e As MouseEventArgs) Handles txt_numeroDocumento.MouseClick
        If Me.txt_numeroDocumento.Text = "" Then
            Me.txt_numeroDocumento.SelectionStart = 0
        End If
    End Sub

    Private Sub btn_limpiar_Click(sender As Object, e As EventArgs) Handles btn_limpiar.Click
        Me.txt_cantidadAlojamientos.Text = ""
        Me.txt_nombre.Text = ""
        Me.txt_apellido.Text = ""
        Me.txt_numeroDocumento.Text = ""
        Me.cmb_tipoDocumento.SelectedIndex = -1
        Me.rp_clientesRecurrentes.RefreshReport()
    End Sub
End Class