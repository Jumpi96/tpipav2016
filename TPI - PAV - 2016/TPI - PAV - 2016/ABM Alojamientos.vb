Public Class ABM_Alojamientos
    Dim string_conexion As String = ConexionBD.Instancia.StringConexion

    Private Sub ABM_Alojamientos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        carga_combo(Me.cmbTipoDoc, Me.leo_tabla("TiposDocumento"), "idTipoDocumento", "nombre")
        'carga_lista(Me.leo_alojamientos(null)) COMPLETAR
        dtpSalida.Format = DateTimePickerFormat.Custom
        dtpSalida.CustomFormat = "    "
    End Sub

    Private Sub carga_combo(ByRef combo As ComboBox, ByRef datos As Data.DataTable, ByVal pk As String, ByVal descripcion As String)
        combo.DataSource = datos
        combo.ValueMember = pk
        combo.DisplayMember = descripcion
    End Sub

    Private Sub carga_lista(ByVal tabla As Data.DataTable)
        Me.dgvAlojamientos.DataSource = tabla
        'COMPLETAR
    End Sub

    Private Function leo_alojamientos(ByVal porDoc As Boolean)
        Dim conexion As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim tabla As New Data.DataTable

        conexion.ConnectionString = Me.string_conexion
        conexion.Open()
        cmd.Connection = conexion
        cmd.CommandType = CommandType.Text
        If porDoc Then
            cmd.CommandText = "select fechaInicioAlojamiento, fechaFinAlojamiento, nroHabitacion" &
                        "from Alojamientos where tipoDoc=" & cmbTipoDoc.SelectedValue & " AND numeroDoc=" & txtNroDoc.Text
        Else
            cmd.CommandText = "select fechaInicioAlojamiento, fechaFinAlojamiento, nroHabitacion" &
                "from Alojamientos order by fechaInicioAlojamiento DESC"
        End If
        tabla.Load(cmd.ExecuteReader())

        Return tabla
    End Function

    Private Function leo_tabla(ByVal nombre_tabla As String) As Data.DataTable
        Dim conexion As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim tabla As New Data.DataTable

        conexion.ConnectionString = Me.string_conexion
        conexion.Open()
        cmd.Connection = conexion
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select * from " + nombre_tabla
        tabla.Load(cmd.ExecuteReader())

        Return tabla
    End Function

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        Me.limpiar()
    End Sub

    Private Sub limpiar()
        'Completar
    End Sub
End Class