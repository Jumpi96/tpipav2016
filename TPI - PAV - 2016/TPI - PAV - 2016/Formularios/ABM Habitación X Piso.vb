Public Class ABM_Habitación_X_Piso
    Dim acceso As AccesoBD = AccesoBD.instancia
    Dim cadena_conexion As String = ConexionBD.Instancia.StringConexion

    Private Sub ABM_Habitación_X_Piso_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.cargarComboTipoHabitacion()
        Me.cargarGrilla()
    End Sub

    Private Sub insertarHabitacionPiso()
        Dim sql As String = ""
        sql &= "INSERT INTO HabitacionesXPiso (nroHabitacion, cantCamas, aireAcondicionado, frigobar, fechaEmision, cantBaños, idTipoHabitacion, cantMaxPersonas) "
        sql &= "VALUES ('" & Me.txt_nroHabitacion.Text & "', '" & Me.txt_camas.Text & "'"
        If Me.chb_aireAcondicionado.CheckState = CheckState.Unchecked Then
            sql &= ", '" & 0 & "'"
        Else
            sql &= ", '" & 1 & "'"
        End If
        If Me.chb_frigoBar.CheckState = CheckState.Unchecked Then
            sql &= ", '" & 0 & "'"
        Else
            sql &= ", '" & 1 & "'"
        End If
        sql &= ", '" & Me.dtp_fechaEmision.Value.Date & "'"
        sql &= ", '" & Me.txt_baños.Text & "'"
        sql &= ", '" & Me.cmb_tipoHabitacion.SelectedValue & "'"
        sql &= ", '" & Me.txt_personas.Text & "')"

        acceso.nonQuery(sql)

        MessageBox.Show("Habitación registrada con éxito")
    End Sub

    Private Function validarCampos() As Boolean
        If txt_nroHabitacion.Text = "" Then
            MessageBox.Show("No ha ingresado un número de habitación", "Error", MessageBoxButtons.OK)
            txt_nroHabitacion.Focus()
            Return False
        End If
        If txt_camas.Text = "" Then
            MessageBox.Show("No ha ingresado una cantidad de camas", "Error", MessageBoxButtons.OK)
            txt_camas.Focus()
            Return False
        End If
        If txt_baños.Text = "" Then
            MessageBox.Show("No ha ingresado una cantidad de baños", "Error", MessageBoxButtons.OK)
            txt_baños.Focus()
            Return False
        End If
        If txt_camas.Text = "" Then
            MessageBox.Show("No ha ingresado una cantidad de camas", "Error", MessageBoxButtons.OK)
            txt_camas.Focus()
            Return False
        End If
        If cmb_tipoHabitacion.SelectedIndex = -1 Then
            MessageBox.Show("No ha seleccionado ningún tipo de habitación", "Error", MessageBoxButtons.OK)
            cmb_tipoHabitacion.Focus()
            Return False
        End If
        If txt_personas.Text = "" Then
            MessageBox.Show("No ha ingresado una cantidad máxima de personas", "Error", MessageBoxButtons.OK)
            txt_personas.Focus()
            Return False
        End If
        Return True
    End Function

    Private Function validarExistencia() As Boolean
        Dim tabla As New Data.DataTable
        Dim sql As String = ""
        sql = "SELECT nroHabitacion FROM HabitacionesXPiso"

        tabla = acceso.query(sql)

        Dim i As Integer

        For i = 0 To tabla.Rows.Count() - 1
            If txt_nroHabitacion.Text = tabla.Rows(i)("nroHabitacion") Then
                MessageBox.Show("Habitación ya existente", "Error", MessageBoxButtons.OK)
                txt_nroHabitacion.Focus()
                Return False
            End If
        Next
        Return True
    End Function

    Private Sub cargarComboTipoHabitacion()
        Dim tabla As New Data.DataTable
        Dim sql As String = ""
        
        sql = "SELECT * FROM TiposHabitacion"

        tabla = acceso.query(sql)

        cmb_tipoHabitacion.DataSource = tabla
        cmb_tipoHabitacion.ValueMember = "idTipoHabitacion"
        cmb_tipoHabitacion.DisplayMember = "nombre"
    End Sub

    Private Sub cargarGrilla()
        Me.grid_habitacionPiso.Rows.Clear()
        Dim tabla As New Data.DataTable
        Dim sql As String = ""
        sql = "SELECT * FROM HabitacionesXPiso HP JOIN TiposHabitacion TH ON HP.idTipoHabitacion = TH.idTipoHabitacion"

        tabla = acceso.query(sql)

        Dim i As Integer

        For i = 0 To tabla.Rows.Count() - 1
            Me.grid_habitacionPiso.Rows.Add()
            Me.grid_habitacionPiso.Rows(i).Cells("clm_nroHabitacion").Value = tabla.Rows(i)("nroHabitacion")
            Me.grid_habitacionPiso.Rows(i).Cells("clm_fechaEmision").Value = tabla.Rows(i)("fechaEmision")
            Me.grid_habitacionPiso.Rows(i).Cells("clm_tipoHabitacion").Value = tabla.Rows(i)("nombre")
        Next
    End Sub

    Private Sub cmd_registrar_Click(sender As Object, e As EventArgs) Handles cmd_registrar.Click
        If Me.validarCampos = True Then
            If Me.validarExistencia = True Then
                Me.insertarHabitacionPiso()
                Me.cmd_limpiar.PerformClick()
                Me.cargarGrilla()
            End If
        End If
    End Sub

    Private Sub cmd_salir_Click(sender As Object, e As EventArgs) Handles cmd_salir.Click
        Me.Close()
    End Sub

    Private Sub cmd_limpiar_Click(sender As Object, e As EventArgs) Handles cmd_limpiar.Click
        Me.txt_nroHabitacion.Text = ""
        Me.txt_camas.Text = ""
        Me.txt_personas.Text = ""
        Me.txt_baños.Text = ""
        Me.cmb_tipoHabitacion.SelectedIndex = -1
        Me.chb_frigoBar.CheckState = CheckState.Unchecked
        Me.chb_aireAcondicionado.CheckState = CheckState.Unchecked
        Me.dtp_fechaEmision.Value = Today
    End Sub

    Private Sub txt_nroHabitacion_MouseClick(sender As Object, e As MouseEventArgs) Handles txt_nroHabitacion.MouseClick
        If Me.txt_nroHabitacion.Text = "" Then
            Me.txt_nroHabitacion.SelectionStart = 0
        End If
    End Sub

    Private Sub txt_camas_MouseClick(sender As Object, e As MouseEventArgs) Handles txt_camas.MouseClick
        If Me.txt_camas.Text = "" Then
            Me.txt_camas.SelectionStart = 0
        End If
    End Sub

    Private Sub txt_baños_MouseClick(sender As Object, e As MouseEventArgs) Handles txt_baños.MouseClick
        If Me.txt_baños.Text = "" Then
            Me.txt_baños.SelectionStart = 0
        End If
    End Sub

    Private Sub txt_personas_MouseClick(sender As Object, e As MouseEventArgs) Handles txt_personas.MouseClick
        If Me.txt_personas.Text = "" Then
            Me.txt_personas.SelectionStart = 0
        End If
    End Sub

    Private Sub grid_habitacionPiso_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles grid_habitacionPiso.CellContentDoubleClick
        Dim tabla As New Data.DataTable
        Dim sql As String = ""

        cmd_cancelar.Enabled = True
        cmd_modificar.Enabled = True
        cmd_limpiar.Enabled = False
        cmd_registrar.Enabled = False
        txt_nroHabitacion.ReadOnly = True

        sql &= "SELECT * FROM HabitacionesXPiso HP JOIN TiposHabitacion TH "
        sql &= "ON HP.idTipoHabitacion = TH.idTipoHabitacion "
        sql &= "WHERE nroHabitacion = " & Me.grid_habitacionPiso.CurrentRow.Cells("clm_nroHabitacion").Value

        tabla = acceso.query(sql)

        If tabla.Rows.Count() = 0 Then
            MessageBox.Show("Habitacion no seleccionada", "Error", MessageBoxButtons.OK)
            Exit Sub
        End If

        grid_habitacionPiso.Rows.Clear()

        Dim i As Integer

        For i = 0 To tabla.Rows.Count() - 1
            Me.grid_habitacionPiso.Rows.Add()
            Me.grid_habitacionPiso.Rows(i).Cells("clm_nroHabitacion").Value = tabla.Rows(i)("nroHabitacion")
            Me.grid_habitacionPiso.Rows(i).Cells("clm_fechaEmision").Value = tabla.Rows(i)("fechaEmision")
            Me.grid_habitacionPiso.Rows(i).Cells("clm_tipoHabitacion").Value = tabla.Rows(i)("nombre")
        Next

        Me.txt_nroHabitacion.Text = tabla.Rows(0)("nroHabitacion")
        Me.txt_camas.Text = tabla.Rows(0)("cantCamas")
        Me.txt_baños.Text = tabla.Rows(0)("cantBaños")
        Me.txt_personas.Text = tabla.Rows(0)("cantMaxPersonas")
        Me.txt_nroHabitacion.Text = tabla.Rows(0)("nroHabitacion")
        If tabla.Rows(0)("frigobar") = 0 Then
            Me.chb_frigoBar.CheckState = CheckState.Unchecked
        ElseIf tabla.Rows(0)("frigobar") = 1 Then
            Me.chb_frigoBar.CheckState = CheckState.Checked
        End If
        If tabla.Rows(0)("aireAcondicionado") = 0 Then
            Me.chb_aireAcondicionado.CheckState = CheckState.Unchecked
        ElseIf tabla.Rows(0)("aireAcondicionado") = 1 Then
            Me.chb_aireAcondicionado.CheckState = CheckState.Checked
        End If
        Me.cmb_tipoHabitacion.SelectedValue = tabla.Rows(0)("idTipoHabitacion")
    End Sub

    Private Sub cmd_cancelar_Click(sender As Object, e As EventArgs) Handles cmd_cancelar.Click
        Me.cmd_limpiar_Click(sender, e)
        Me.cmd_registrar.Enabled = True
        Me.cmd_limpiar.Enabled = True
        Me.cmd_modificar.Enabled = False
        Me.cmd_cancelar.Enabled = False
        Me.txt_nroHabitacion.ReadOnly = False
        Me.cargarGrilla()
    End Sub

    Private Sub cmd_modificar_Click(sender As Object, e As EventArgs) Handles cmd_modificar.Click
        Dim sql As String = ""

        sql &= "UPDATE HabitacionesXPiso "
        sql &= "SET cantCamas = '" & Me.txt_camas.Text & "'"
        If Me.chb_aireAcondicionado.CheckState = CheckState.Unchecked Then
            sql &= ", aireAcondicionado = '" & 0 & "'"
        ElseIf Me.chb_aireAcondicionado.CheckState = CheckState.Checked Then
            sql &= ", aireAcondicionado = '" & 1 & "'"
        End If
        If Me.chb_frigoBar.CheckState = CheckState.Unchecked Then
            sql &= ", frigobar = '" & 0 & "'"
        ElseIf Me.chb_frigoBar.CheckState = CheckState.Checked Then
            sql &= ", frigobar = '" & 1 & "'"
        End If
        sql &= ", fechaEmision = '" & Me.dtp_fechaEmision.Value.Date & "'"
        sql &= ", cantBaños = '" & Me.txt_baños.Text & "'"
        sql &= ", idTipoHabitacion = '" & Me.cmb_tipoHabitacion.SelectedValue & "'"
        sql &= ", cantMaxPersonas = '" & Me.txt_personas.Text & "'"
        sql &= " WHERE nroHabitacion = " & Me.txt_nroHabitacion.Text

        acceso.nonQuery(sql)

        MessageBox.Show("La habitación se modificó correctamente")

        Me.cmd_limpiar_Click(sender, e)
        Me.cmd_registrar.Enabled = True
        Me.cmd_limpiar.Enabled = True
        Me.cmd_modificar.Enabled = False
        Me.cmd_cancelar.Enabled = False
        Me.txt_nroHabitacion.ReadOnly = False
        Me.cargarGrilla()
    End Sub

    Private Sub cmd_actualizarGrilla_Click(sender As Object, e As EventArgs) Handles cmd_actualizarGrilla.Click
        Me.cargarGrilla()
    End Sub

    Private Sub txt_nroHabitacion_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles txt_nroHabitacion.MaskInputRejected

    End Sub
End Class