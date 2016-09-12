Public Class ABM_Alojamientos
    Dim string_conexion As String = ConexionBD.Instancia.StringConexion
    Dim flagBusqDocumento As Boolean = False

    Private Sub ABM_Alojamientos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        carga_combo(Me.cmbTipoDoc, Me.leo_tabla("TiposDocumento"), "idTipoDocumento", "nombre")
        'carga_lista(Me.leo_alojamientos(False)) COMPLETAR
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
        cmbTipoDoc.SelectedValue = 1
        txtNroDoc.Text = ""
        txtHabitacion.Text = ""
        txtAlojados.Text = ""
        dtpIngreso.Value = Today
        dtpEstimada.Value = Today
        dtpSalida.CustomFormat = "    "

        If flagBusqDocumento Then
            'carga_lista(Me.leo_alojamientos(False)) COMPLETAR
            flagBusqDocumento = False
        End If
    End Sub

    Private Sub btnBuscarPorDoc_Click(sender As Object, e As EventArgs) Handles btnBuscarPorDoc.Click
        Dim existe As Boolean = False
        'BUSCAR SI EXISTE
        If existe Then
            carga_lista(Me.leo_alojamientos(True))
        Else
            'Dar mensaje de error
        End If
    End Sub

    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click
        'registrar()
        carga_lista(Me.leo_alojamientos(False))
        limpiar()
    End Sub

    Private Sub registrar()
        If validar() Then
            'instertar()
        End If
    End Sub

    Private Function insertar() As Boolean
        Dim conexion As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim consulta As String = ""

        conexion.ConnectionString = Me.string_conexion
        conexion.Open()

        consulta = "insertar into alojamientos values(" & txtNroDoc.Text & "," &
            cmbTipoDoc.SelectedValue & "," & txtHabitacion.Text & "," & txtAlojados &
        "," & dtpIngreso.Value & "," & dtpEstimada.Value & "," & dtpSalida.Value & "," &
        txtPrecio.Text & ")"

    End Function

    Private Function validar() As Boolean

    End Function
End Class