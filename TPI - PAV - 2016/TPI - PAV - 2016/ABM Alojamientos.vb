Public Class ABM_Alojamientos
    Dim string_conexion As String = ConexionBD.Instancia.StringConexion
    Dim flagBusqDocumento As Boolean = False
    Dim idAlojamientoModificacion As Integer = 0

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
        dgvAlojamientos.Rows.Clear()
        For Each row As DataRow In tabla.Rows
            If row(2).GetType <> GetType(DateTime) Then
                fechaSalida = ""
            Else
                fechaSalida = CType(row(1), DateTime).ToShortDateString
            End If
            dgvAlojamientos.Rows.Add(row(0), CType(row(1), DateTime).ToShortDateString, fechaSalida, row(3))
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
            cmd.CommandText = "select idAlojamiento, fechaInicioAlojamiento, fechaFinAlojamiento, nroHabitacion " &
                        "from Alojamientos where tipoDoc=" & cmbTipoDoc.SelectedValue & " AND nroDoc=" & txtNroDoc.Text
        Else
            cmd.CommandText = "select idAlojamiento, fechaInicioAlojamiento, fechaFinAlojamiento, nroHabitacion " &
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
            carga_lista(Me.leo_alojamientos(False))
            flagBusqDocumento = False
        End If

        dtpIngreso.Enabled = True
        cmbTipoDoc.Enabled = True
        txtNroDoc.Enabled = True
        flagBusqDocumento = False
        idAlojamientoModificacion = 0
    End Sub

    Private Sub btnBuscarPorDoc_Click(sender As Object, e As EventArgs) Handles btnBuscarPorDoc.Click
        If existeCliente() Then
            carga_lista(Me.leo_alojamientos(True))
            flagBusqDocumento = True
        Else
            MessageBox.Show("No existe cliente.", "Error")
        End If
    End Sub

    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click
        registrar()
        carga_lista(Me.leo_alojamientos(False))
        limpiar()
    End Sub

    Private Sub registrar()
        If validar() Then
            If idAlojamientoModificacion <> 0 Then
                guardar()
            Else
                insertar()
            End If
        End If

    End Sub

    Private Function guardar()
        Dim conexion As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim consulta As String = ""

        conexion.ConnectionString = Me.string_conexion
        conexion.Open()

        consulta = "update alojamientos where idAlojamiento=" & idAlojamientoModificacion &
            "SET nroDoc=" & txtNroDoc.Text & ", tipoDoc=" &
            cmbTipoDoc.SelectedValue & ", nroHabitacion=" & txtHabitacion.Text & ", cantPersonas=" & txtAlojados &
        ", fechaInicioAlojamiento=" & dtpIngreso.Value & ",fechaFinEstimadaalojamiento=" & dtpEstimada.Value & ", fechaFinAlojamiento=" & dtpSalida.Value & ", precioPorDia=" &
        txtPrecio.Text

        cmd.CommandType = CommandType.Text
        cmd.Connection = conexion
        cmd.CommandText = consulta
        cmd.ExecuteNonQuery()
        conexion.Close()
        Return True
    End Function

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

    Private Function existeCliente() As Boolean
        Dim conexion As New OleDb.OleDbConnection
        Dim consulta As String
        Dim cmd As New OleDb.OleDbCommand
        Dim tabla As New DataTable

        conexion.ConnectionString = Me.string_conexion
        conexion.Open()

        If txtNroDoc.Text <> "" Then
            consulta = "select * from Clientes where tipoDocumento =" & cmbTipoDoc.SelectedValue & " AND nroDocumento=" & txtNroDoc.Text

            cmd.CommandType = CommandType.Text
            cmd.CommandText = consulta
            cmd.Connection = conexion

            tabla.Load(cmd.ExecuteReader())
        End If
        

        If (tabla.Rows.Count = 0) Then
            Return False
        End If
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

        cmd.CommandType = CommandType.Text
        cmd.Connection = conexion

        If (existeCliente() = False) Then
            MessageBox.Show("El documento ingresado no existe.", "Error", MessageBoxButtons.OK)
            Return False
        End If
        'verificar habitacion y alojados
        If txtHabitacion.Text <> "" Then
            consulta = "select cantMaxPersonas from HabitacionesXPiso where nroHabitacion = " & txtHabitacion.Text
            cmd.CommandText = consulta

            tabla.Load(cmd.ExecuteReader())
            conexion.Close()
        End If

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

    Private Sub dgvAlojamientos_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvAlojamientos.CellContentDoubleClick, dgvAlojamientos.CellDoubleClick
        Dim a As Integer = dgvAlojamientos.Rows(dgvAlojamientos.CurrentRow.Index).Cells(0).Value

        cargar(a)
    End Sub

    Private Sub cargar(ByVal idAlojamiento As Integer)
        Dim conexion As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim consulta As String

        conexion.ConnectionString = string_conexion
        conexion.Open()
        consulta = "select * from Alojamientos where idAlojamiento=" & idAlojamiento

        cmd.CommandType = CommandType.Text
        cmd.CommandText = consulta
        cmd.Connection = conexion

        Dim tabla As New DataTable
        tabla.Load(cmd.ExecuteReader())

        Dim row As DataRow = tabla.Rows(0)

        cmbTipoDoc.SelectedValue = row(2)
        txtNroDoc.Text = row(1)
        txtHabitacion.Text = row(3)
        txtAlojados.Text = row(4)
        dtpIngreso.Value = row(5)
        dtpEstimada.Value = row(6)
        dtpSalida.Value = row(7)
        txtPrecio.Text = row(8)

        dtpIngreso.Enabled = False
        cmbTipoDoc.Enabled = False
        txtNroDoc.Enabled = False

        idAlojamientoModificacion = idAlojamiento

    End Sub
End Class