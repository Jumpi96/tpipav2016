Public Class ABM_Alojamientos
    Dim string_conexion As String = ConexionBD.Instancia.StringConexion
    Dim flagBusqDocumento As Boolean = False

    Private Sub ABM_Alojamientos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        carga_combo(Me.cmbTipoDoc, Me.leo_tabla("TiposDocumento"), "idTipoDocumento", "nombre")
        carga_lista(Me.leo_alojamientos(False))
        dtpSalida.Format = DateTimePickerFormat.Custom
        dtpSalida.CustomFormat = "    "
    End Sub

    Private Sub carga_combo(ByRef combo As ComboBox, ByRef datos As Data.DataTable, ByVal pk As String, ByVal descripcion As String)
        combo.DataSource = datos
        combo.ValueMember = pk
        combo.DisplayMember = descripcion
    End Sub

    Private Sub carga_lista(ByVal tabla As Data.DataTable)

        Dim fechaSalida As String
        For Each row As DataRow In tabla.Rows
            If row(1).GetType <> GetType(DateTime) Then
                fechaSalida = ""
            Else
                fechaSalida = CType(row(1), DateTime).ToShortDateString
            End If
            dgvAlojamientos.Rows.Add(CType(row(0), DateTime).ToShortDateString, fechaSalida, row(2))
        Next row




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
            cmd.CommandText = "select fechaInicioAlojamiento, fechaFinAlojamiento, nroHabitacion " &
                        "from Alojamientos where tipoDoc=" & cmbTipoDoc.SelectedValue & " AND numeroDoc=" & txtNroDoc.Text
        Else
            cmd.CommandText = "select fechaInicioAlojamiento, fechaFinAlojamiento, nroHabitacion " &
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
        registrar()
        carga_lista(Me.leo_alojamientos(False))
        limpiar()
    End Sub

    Private Sub registrar()
        If validar() Then
            insertar()
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

        cmd.CommandType = CommandType.Text
        cmd.Connection = conexion
        cmd.CommandText = consulta
        cmd.ExecuteNonQuery()
        conexion.Close()
        Return True
    End Function

    Private Function validar() As Boolean
        'verificar Documento
        Dim conexion As New OleDb.OleDbConnection
        Dim consulta As String
        Dim cmd As New OleDb.OleDbCommand
        Dim tabla As New DataTable

        conexion.ConnectionString = Me.string_conexion
        conexion.Open()

        consulta = "select * from Clientes where tipoDoc=" & cmbTipoDoc.SelectedValue & " AND numeroDoc=" & txtNroDoc.Text

        cmd.CommandType = CommandType.Text
        cmd.CommandText = consulta
        cmd.Connection = conexion

        tabla.Load(cmd.ExecuteReader())

        If (tabla.Rows.Count = 0) Then
            MessageBox.Show("El documento ingresado no existe.", "Error", MessageBoxButtons.OK)
            Return False
        End If
        'verificar habitacion y alojados
        consulta = "select cantMaxPersonas from HabitacionesXPiso where nroHabitacion = " & txtHabitacion.Text
        cmd.CommandText = consulta

        tabla.Load(cmd.ExecuteReader())
        conexion.Close()


        If (tabla.Rows.Count = 0) Then
            MessageBox.Show("La habitación ingresada no existe.", "Error", MessageBoxButtons.OK)
            Return False
        Else
            If (CType(tabla.Rows(0).ItemArray(0).ToString, Integer) < txtAlojados.Text Or txtAlojados.Text < 1) Then
                MessageBox.Show("El número de alojados no es válido.", "Error", MessageBoxButtons.OK)
                Return False
            End If
        End If
        'controlar fechas
        If (dtpIngreso.Value > Today Or dtpEstimada.Value <= dtpIngreso.Value Or dtpSalida.Value <= dtpIngreso.Value Or dtpSalida.Value < dtpEstimada.Value) Then
            MessageBox.Show("Las fechas ingresadas no son válidas.", "Error", MessageBoxButtons.OK)
            Return False
        End If
        'controlar precio
        If (txtPrecio.Text < 0) Then
            MessageBox.Show("El precio por día no puede ser negativo.", "Error", MessageBoxButtons.OK)
            Return False
        End If

        Return True
    End Function
End Class