Public Class ABM_Alojamientos
    Dim accesoBD As AccesoBD = AccesoBD.instancia

    Dim flagBusqDocumento As Boolean = False
    Dim idAlojamientoModificacion As Integer = 0
    Dim flagFechaSalida As Boolean = False

    Private Sub ABM_Alojamientos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        carga_combo(Me.cmbTipoDoc, Me.leo_tabla("TiposDocumento"), "idTipoDocumento", "nombre")
        carga_lista(Me.leo_alojamientos(False))
        flagFechaSalida = False
        dtpEstimada.Value = Today.AddDays(1)
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
                fechaSalida = CType(row(2), DateTime).ToShortDateString
            End If
            dgvAlojamientos.Rows.Add(row(0), CType(row(1), DateTime).ToShortDateString, fechaSalida, row(3))
        Next row

    End Sub

    Private Function leo_alojamientos(ByVal porDoc As Boolean)
        Dim sentenciaSQL As String = ""

        If porDoc Then
            sentenciaSQL = "select idAlojamiento, fechaInicioAlojamiento, fechaFinAlojamiento, nroHabitacion " &
                        "from Alojamientos where tipoDoc=" & cmbTipoDoc.SelectedValue & " AND nroDoc=" & txtNroDoc.Text
        Else
            sentenciaSQL = "select idAlojamiento, fechaInicioAlojamiento, fechaFinAlojamiento, nroHabitacion " &
                "from Alojamientos order by fechaInicioAlojamiento DESC"
        End If

        Return accesoBD.query(sentenciaSQL)
    End Function

    Private Function leo_tabla(ByVal nombre_tabla As String) As Data.DataTable
        Return accesoBD.query("select * from " + nombre_tabla)
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
        dtpEstimada.Value = Today.AddDays(1)
        flagFechaSalida = False
        txtPrecio.Text = ""
        dtpSalida.Format = DateTimePickerFormat.Custom
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
            carga_lista(leo_alojamientos(False))
        End If
    End Sub

    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click
        If registrar() Then
            limpiar()
        End If
        carga_lista(Me.leo_alojamientos(False))

    End Sub

    Private Function registrar() As Boolean
        If validar() Then
            If idAlojamientoModificacion <> 0 Then
                guardar()
                Return True
            Else
                insertar()
                Return True
            End If
        Else
            Return False
        End If
    End Function

    Private Function guardar() As Boolean
        Dim sentenciaSQL As String = ""
        Dim valueSalida As String

        If flagFechaSalida = False Then
            sentenciaSQL = "update alojamientos " & "SET nroDoc=" + txtNroDoc.Text + ", tipoDoc=" _
            & cmbTipoDoc.SelectedValue & ", nroHabitacion=" + txtHabitacion.Text + ", cantPersonas=" & txtAlojados.Text _
            & ", fechaInicioAlojamiento='" & dtpIngreso.Value & "',fechaFinEstimadaalojamiento='" & dtpEstimada.Value _
            & "', precioPorDia=" & txtPrecio.Text & " where idAlojamiento=" & idAlojamientoModificacion
        Else
            valueSalida = dtpSalida.Value
            sentenciaSQL &= "update alojamientos " & "SET nroDoc=" & txtNroDoc.Text & ", tipoDoc=" & cmbTipoDoc.SelectedValue
            sentenciaSQL &= ", nroHabitacion=" & txtHabitacion.Text & ", cantPersonas=" & txtAlojados.Text
            sentenciaSQL &= ", fechaInicioAlojamiento='" & dtpIngreso.Value & "',fechaFinEstimadaalojamiento='" & dtpEstimada.Value & "', fechaFinAlojamiento='"
            sentenciaSQL &= valueSalida & "', precioPorDia=" & txtPrecio.Text & " where idAlojamiento=" & idAlojamientoModificacion
        End If

        accesoBD.nonQuery(sentenciaSQL)
        Return True
    End Function

    Private Function insertar() As Boolean
        Dim sentenciaSQL As String = ""

        If flagFechaSalida = False Then
            sentenciaSQL = "insert into alojamientos(nroDoc,tipoDoc,nroHabitacion,cantPersonas,fechaInicioAlojamiento,fechaFinEstimadaalojamiento,precioPorDia) " _
            & " values(" + txtNroDoc.Text + "," & cmbTipoDoc.SelectedValue & "," + txtHabitacion.Text _
            + "," & txtAlojados.Text & ", CONVERT(datetime,'" & dtpIngreso.Value.Date & "',103) , CONVERT(datetime,'" & dtpEstimada.Value.Date & "',103) ," _
            & txtPrecio.Text & ")"
        Else
            sentenciaSQL = "insert into alojamientos " +
            "values(" + txtNroDoc.Text + "," & cmbTipoDoc.SelectedValue & "," + txtHabitacion.Text + "," & txtAlojados.Text _
            & ",CONVERT(datetime,'" & dtpIngreso.Value.Date & "',103), CONVERT(datetime,'" & dtpEstimada.Value.Date & "',103), CONVERT(datetime,'" & dtpSalida.Value.Date & "',103)," & txtPrecio.Text & ")"
        End If

        accesoBD.nonQuery(sentenciaSQL)

        Return True
    End Function

    Private Function existeCliente() As Boolean
        Dim sentenciaSQL As String
        Dim tabla As New DataTable

        If txtNroDoc.Text <> "" Then
            sentenciaSQL = "select * from Clientes where tipoDocumento =" & cmbTipoDoc.SelectedValue & " AND nroDocumento=" & txtNroDoc.Text
            tabla = accesoBD.query(sentenciaSQL)
        End If
        
        If (tabla.Rows.Count = 0) Then
            Return False
        End If
        Return True
    End Function

    Private Function validar() As Boolean
        Dim sentenciaSQL As String
        Dim tabla As New DataTable

        If (existeCliente() = False) Then
            MessageBox.Show("El documento ingresado no existe.", "Error", MessageBoxButtons.OK)
            txtNroDoc.Focus()
            Return False
        End If
        'verificar habitacion y alojados
        If txtHabitacion.Text <> "" Then
            sentenciaSQL = "select cantMaxPersonas from HabitacionesXPiso where nroHabitacion = " & txtHabitacion.Text
            tabla = accesoBD.query(sentenciaSQL)
        End If

        If (tabla.Rows.Count = 0) Then
            MessageBox.Show("La habitación ingresada no existe.", "Error", MessageBoxButtons.OK)
            txtHabitacion.Focus()
            Return False
        Else
            If (CType(tabla.Rows(0).ItemArray(0).ToString, Integer) < txtAlojados.Text Or txtAlojados.Text < 1) Then
                MessageBox.Show("El número de alojados no es válido.", "Error", MessageBoxButtons.OK)
                txtAlojados.Focus()
                Return False
            End If
        End If
        'controlar fechas
        If flagFechaSalida Then
            If (dtpIngreso.Value.Date > Date.Today Or dtpEstimada.Value <= dtpIngreso.Value Or dtpSalida.Value <= dtpIngreso.Value Or dtpSalida.Value < dtpEstimada.Value) Then
                MessageBox.Show("Las fechas ingresadas no son válidas.", "Error", MessageBoxButtons.OK)
                dtpIngreso.Focus()
                Return False
            End If
        Else
            If (dtpIngreso.Value.Date > Date.Today Or dtpEstimada.Value <= dtpIngreso.Value) Then
                MessageBox.Show("Las fechas ingresadas no son válidas.", "Error", MessageBoxButtons.OK)
                dtpIngreso.Focus()
                Return False
            End If
        End If
        'controlar precio
        If (txtPrecio.Text < 0) Then
            MessageBox.Show("El precio por día no puede ser negativo.", "Error", MessageBoxButtons.OK)
            txtPrecio.Focus()
            Return False
        End If

        Return True
    End Function

    Private Sub dgvAlojamientos_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvAlojamientos.CellContentDoubleClick, dgvAlojamientos.CellDoubleClick
        Dim a As Integer = dgvAlojamientos.Rows(dgvAlojamientos.CurrentRow.Index).Cells(0).Value

        cargar(a)
    End Sub

    Private Sub cargar(ByVal idAlojamiento As Integer)
        Dim sentenciaSQL As String

        sentenciaSQL = "select * from Alojamientos where idAlojamiento=" & idAlojamiento

        Dim tabla As DataTable = accesoBD.query(sentenciaSQL)

        Dim row As DataRow = tabla.Rows(0)

        cmbTipoDoc.SelectedValue = row(2)
        txtNroDoc.Text = row(1)
        txtHabitacion.Text = row(3)
        txtAlojados.Text = row(4)
        dtpIngreso.Value = row(5)
        dtpEstimada.Value = row(6)
        If row(7).ToString = "" Then
            flagFechaSalida = False
            dtpSalida.Format = DateTimePickerFormat.Custom
            dtpSalida.CustomFormat = "    "
        Else
            dtpSalida.Value = row(7)
            flagFechaSalida = True
        End If
        txtPrecio.Text = row(8)

        dtpIngreso.Enabled = False
        cmbTipoDoc.Enabled = False
        txtNroDoc.Enabled = False

        idAlojamientoModificacion = idAlojamiento

    End Sub

    Private Sub dtpSalida_Enter(sender As Object, e As EventArgs) Handles dtpSalida.Enter
        dtpSalida.Format = DateTimePickerFormat.Long
    End Sub

    Private Sub dtpSalida_ValueChanged(sender As Object, e As EventArgs) Handles dtpSalida.ValueChanged
        dtpSalida.Format = DateTimePickerFormat.Long
        flagFechaSalida = True
    End Sub
End Class