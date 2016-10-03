Public Class ABM_Habitación_X_Piso
    Dim acceso As AccesoBD = AccesoBD.instancia
    Dim cadena_conexion As String = AccesoBD.instancia.cadenaConexion
    Dim registrarModificar As Boolean = True
    Dim auxiliarTiposCamas(4) As Integer
    Enum aceptar
        apretado
        noApretado
    End Enum
    Dim estado_aceptar As aceptar = aceptar.noApretado
    Dim cantidadCamasAuxiliar As Integer

    Private Sub ABM_Habitación_X_Piso_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.cargarComboTipoHabitacion()
        Me.cargarComboTipoCama()
        Me.cmb_tipoCama1.SelectedIndex = 1
        Me.cmb_tipoCama2.SelectedIndex = 1
        Me.cmb_tipoCama3.SelectedIndex = 1
        Me.cmb_tipoCama4.SelectedIndex = 1
        Me.cargarGrilla()
        Me.txt_personas.ReadOnly = True
        Me.pnl_tipoCama.Visible = False
        Me.cmd_atras.Enabled = False
        Me.cmb_tipoCama1.Enabled = False
        Me.cmb_tipoCama2.Enabled = False
        Me.cmb_tipoCama3.Enabled = False
        Me.cmb_tipoCama4.Enabled = False
        auxiliarTiposCamas(0) = 1
        auxiliarTiposCamas(1) = 1
        auxiliarTiposCamas(2) = 1
        auxiliarTiposCamas(3) = 1
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
    End Sub

    Private Function validarCamas() As Boolean
        If txt_camas.Text = "" Then
            MessageBox.Show("No ha ingresado una cantidad de camas.", "Error", MessageBoxButtons.OK)
            txt_camas.Focus()
            Return False
        End If
        If txt_camas.Text < 2 Or txt_camas.Text > 4 Then
            MessageBox.Show("Cantidad incorrecta de camas. Los valores aceptados van entre 2 y 4 inclusives.", "Error", MessageBoxButtons.OK)
            txt_camas.Focus()
            Return False
        End If
        Return True
    End Function

    Private Function validarCampos() As Boolean
        If txt_nroHabitacion.Text = "" Then
            MessageBox.Show("No ha ingresado un número de habitación.", "Error", MessageBoxButtons.OK)
            txt_nroHabitacion.Focus()
            Return False
        End If
        Me.validarCamas()
        If txt_baños.Text = "" Then
            MessageBox.Show("No ha ingresado una cantidad de baños.", "Error", MessageBoxButtons.OK)
            txt_baños.Focus()
            Return False
        End If
        If cmb_tipoHabitacion.SelectedIndex = -1 Then
            MessageBox.Show("No ha seleccionado ningún tipo de habitación.", "Error", MessageBoxButtons.OK)
            cmb_tipoHabitacion.Focus()
            Return False
        End If
        If txt_personas.Text = "" Then
            MessageBox.Show("No ha ingresado una cantidad máxima de personas.", "Error", MessageBoxButtons.OK)
            txt_personas.Focus()
            Return False
        End If
        If txt_personas.Text = 0 Then
            MessageBox.Show("La cantidad máxima de personas no puede ser cero.", "Error", MessageBoxButtons.OK)
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
                MessageBox.Show("Habitación ya existente.", "Error", MessageBoxButtons.OK)
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

    Private Sub cargarComboTipoCama()
        Dim tabla1 As New Data.DataTable
        Dim tabla2 As New Data.DataTable
        Dim tabla3 As New Data.DataTable
        Dim tabla4 As New Data.DataTable
        Dim sql As String = ""

        sql = "SELECT * FROM TiposCama"

        tabla1 = acceso.query(sql)
        tabla2 = acceso.query(sql)
        tabla3 = acceso.query(sql)
        tabla4 = acceso.query(sql)

        cmb_tipoCama1.DataSource = tabla1
        cmb_tipoCama1.ValueMember = "idTipoCama"
        cmb_tipoCama1.DisplayMember = "nombre"

        cmb_tipoCama2.DataSource = tabla2
        cmb_tipoCama2.ValueMember = "idTipoCama"
        cmb_tipoCama2.DisplayMember = "nombre"

        cmb_tipoCama3.DataSource = tabla3
        cmb_tipoCama3.ValueMember = "idTipoCama"
        cmb_tipoCama3.DisplayMember = "nombre"

        cmb_tipoCama4.DataSource = tabla4
        cmb_tipoCama4.ValueMember = "idTipoCama"
        cmb_tipoCama4.DisplayMember = "nombre"
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
        Me.cargarAuxiliarTiposCamas()
        If Me.validarCampos = True Then
            If Me.registrarModificar = True Then
                Dim i As Integer
                If Me.validarExistencia = True Then
                    Me.insertarHabitacionPiso()
                    Dim cantidad = Me.txt_camas.Text
                    For i = 0 To (cantidad - 1)
                        acceso.nonQuery(Me.insertarHabitacionPisoTipoCama(i))
                    Next
                    MessageBox.Show("Habitación registrada con éxito")
                    Me.cmd_limpiar.PerformClick()
                    Me.cargarGrilla()
                End If
            ElseIf Me.registrarModificar = False Then
                Dim cantidad As Integer
                cantidad = Me.txt_camas.Text
                Me.modificarHabitacionPiso()
                'If Me.estado_aceptar = aceptar.apretado Then
                For i = 0 To (cantidad - 1)
                    acceso.nonQuery(ABMHabitacionPisoTipoCama(i, cantidad))
                Next
                'End If
                MessageBox.Show("La habitación se modificó correctamente")
            End If
        End If
        auxiliarTiposCamas(0) = 1
        auxiliarTiposCamas(1) = 1
        auxiliarTiposCamas(2) = 1
        auxiliarTiposCamas(3) = 1
        estado_aceptar = aceptar.noApretado
        Me.cantidadCamasAuxiliar = 0
    End Sub

    Private Sub cmd_cancelar_Click(sender As Object, e As EventArgs) Handles cmd_cancelar.Click
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
        Me.cargarGrilla()
        estado_aceptar = aceptar.noApretado
        Me.cantidadCamasAuxiliar = 0
    End Sub

    Private Sub txt_nroHabitacion_MouseClick(sender As Object, e As MouseEventArgs) Handles txt_nroHabitacion.MouseClick
        If Me.txt_nroHabitacion.Text = "" Then
            Me.txt_nroHabitacion.SelectionStart = 0
        End If
    End Sub

    Private Sub txt_camas_LostFocus(sender As Object, e As EventArgs) Handles txt_camas.LostFocus
        Me.cargarAuxiliarTiposCamas()
        Me.calcularCantidadPersonas()
    End Sub

    Private Sub calcularCantidadPersonas()
        Dim cantidad As Integer
        cantidad = Me.txt_camas.Text
        Dim i As Integer
        For i = 0 To Me.txt_camas.Text - 1
            If Me.auxiliarTiposCamas(i) = 0 Or Me.auxiliarTiposCamas(i) = 2 Then
                cantidad = cantidad + 1
            End If
        Next
        Me.txt_personas.Text = cantidad
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

        Me.cmd_registrar.Text = "Modificar"
        Me.registrarModificar = False
        Me.cantidadCamasAuxiliar = Me.txt_camas.Text
    End Sub

    Private Sub modificarHabitacionPiso()
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

        Me.cmd_limpiar.PerformClick()
        Me.cmd_registrar.Enabled = True
        Me.cmd_limpiar.Enabled = True
        Me.txt_nroHabitacion.ReadOnly = False
        Me.cargarGrilla()
    End Sub

    Private Function insertarHabitacionPisoTipoCama(ByVal i As Integer) As String
        Dim sql As String = ""
        sql &= "INSERT INTO HabitacionXPisoXTipoCama "
        sql &= "VALUES (" & Me.txt_nroHabitacion.Text & ", " & (i + 1)
        sql &= ", " & (Me.auxiliarTiposCamas(i) + 1) & ") "
        Return sql
    End Function

    Private Function modificarHabitacionPisoTipoCama(ByVal i As Integer) As String
        Dim sql As String = ""
        sql &= "UPDATE HabitacionXPisoXTipoCama "
        sql &= "SET idTipoCama = " & Me.auxiliarTiposCamas(i) + 1 & " "
        Return sql
    End Function

    Private Function eliminarHabitacionPisoTipoCama() As String
        Dim sql As String = ""
        sql &= "DELETE FROM HabitacionXPisoXTipoCama "
        Return sql
    End Function

    Private Function ABMHabitacionPisoTipoCama(ByVal i As Integer, ByVal cantidad As Integer) As String
        Dim sql As String = ""
        If cantidad = Me.cantidadCamasAuxiliar Then
            sql &= Me.modificarHabitacionPisoTipoCama(i)
        ElseIf cantidad > Me.cantidadCamasAuxiliar Then
            If i < Me.cantidadCamasAuxiliar Then
                sql &= Me.modificarHabitacionPisoTipoCama(i)
            Else
                sql &= Me.insertarHabitacionPisoTipoCama(i)
            End If
        ElseIf cantidad < Me.cantidadCamasAuxiliar Then
            If i < cantidad Then
                sql &= Me.modificarHabitacionPisoTipoCama(i)
            Else
                sql &= Me.eliminarHabitacionPisoTipoCama()
            End If
        End If
        sql &= "WHERE nroHabitacion = " & Me.txt_nroHabitacion.Text & " AND nroCama = " & i + 1
        Return sql
    End Function

    Private Sub cmd_actualizarGrilla_Click(sender As Object, e As EventArgs) Handles cmd_actualizarGrilla.Click
        Me.cargarGrilla()
    End Sub

    Private Sub cmd_modificarTiposCama_Click(sender As Object, e As EventArgs) Handles cmd_modificarTiposCama.Click
        If Me.validarCamas = True Then
            Me.setearCamposABM(False)
            Me.setearCamposPanel(True)
            Me.pnl_tipoCama.Visible = True
            Me.mostrarCamas()
            If estado_aceptar = aceptar.noApretado Then
                If Me.registrarModificar = True Then
                    Me.cmb_tipoCama1.SelectedIndex = 1
                    Me.cmb_tipoCama2.SelectedIndex = 1
                    Me.cmb_tipoCama3.SelectedIndex = 1
                    Me.cmb_tipoCama4.SelectedIndex = 1
                ElseIf Me.registrarModificar = False Then
                    Me.setearCombosTiposCama()
                    Me.cargarAuxiliarTiposCamas()
                End If
            End If
        End If
    End Sub

    Private Sub cargarAuxiliarTiposCamas()
        auxiliarTiposCamas(0) = Me.cmb_tipoCama1.SelectedIndex
        auxiliarTiposCamas(1) = Me.cmb_tipoCama2.SelectedIndex
        auxiliarTiposCamas(2) = Me.cmb_tipoCama3.SelectedIndex
        auxiliarTiposCamas(3) = Me.cmb_tipoCama4.SelectedIndex
    End Sub

    Private Sub mostrarCamas()
        If Me.txt_camas.Text = 2 Then
            Me.lbl_listaCama3.Visible = False
            Me.cmb_tipoCama3.Visible = False
            Me.lbl_listaCama3.Enabled = False
            Me.cmb_tipoCama3.Enabled = False
            Me.lbl_listaCama4.Visible = False
            Me.cmb_tipoCama4.Visible = False
            Me.lbl_listaCama4.Enabled = False
            Me.cmb_tipoCama4.Enabled = False
        ElseIf Me.txt_camas.Text = 3 Then
            Me.lbl_listaCama3.Visible = True
            Me.cmb_tipoCama3.Visible = True
            Me.lbl_listaCama3.Enabled = True
            Me.cmb_tipoCama3.Enabled = True
            Me.lbl_listaCama4.Visible = False
            Me.cmb_tipoCama4.Visible = False
            Me.lbl_listaCama4.Enabled = False
            Me.cmb_tipoCama4.Enabled = False
        ElseIf Me.txt_camas.Text = 4 Then
            Me.lbl_listaCama3.Visible = True
            Me.cmb_tipoCama3.Visible = True
            Me.lbl_listaCama3.Enabled = True
            Me.cmb_tipoCama3.Enabled = True
            Me.lbl_listaCama4.Visible = True
            Me.cmb_tipoCama4.Visible = True
            Me.lbl_listaCama4.Enabled = True
            Me.cmb_tipoCama4.Enabled = True
        End If
    End Sub

    Private Sub setearCombosTiposCama()
        Dim tabla As New Data.DataTable
        Dim sql As String = ""

        sql &= "SELECT * FROM HabitacionXPisoXTipoCama WHERE nroHabitacion = " & Me.txt_nroHabitacion.Text

        tabla = acceso.query(sql)

        Me.cmb_tipoCama1.SelectedIndex = tabla.Rows(0)("idTipoCama") - 1
        Me.cmb_tipoCama2.SelectedIndex = tabla.Rows(1)("idTipoCama") - 1

        Select Case Me.txt_camas.Text
            Case 3
                If tabla.Rows.Count = 3 Then
                    Me.cmb_tipoCama3.SelectedIndex = tabla.Rows(2)("idTipoCama") - 1
                ElseIf tabla.Rows.Count < 3 Then
                    Me.cmb_tipoCama3.SelectedIndex = 1
                End If
            Case 4
                If tabla.Rows.Count = 4 Then
                    Me.cmb_tipoCama3.SelectedIndex = tabla.Rows(2)("idTipoCama") - 1
                    Me.cmb_tipoCama4.SelectedIndex = tabla.Rows(3)("idTipoCama") - 1
                ElseIf tabla.Rows.Count = 3 Then
                    Me.cmb_tipoCama3.SelectedIndex = tabla.Rows(2)("idTipoCama") - 1
                    Me.cmb_tipoCama4.SelectedIndex = 1
                ElseIf tabla.Rows.Count < 3 Then
                    Me.cmb_tipoCama3.SelectedIndex = 1
                    Me.cmb_tipoCama4.SelectedIndex = 1
                End If
        End Select
    End Sub

    Private Sub cmd_atras_Click(sender As Object, e As EventArgs) Handles cmd_atras.Click
        Me.setearCamposABM(True)
        Me.setearCamposPanel(False)
        Me.pnl_tipoCama.Visible = False
        If Me.registrarModificar = True Then
            Me.cmb_tipoCama1.SelectedIndex = 1
            Me.cmb_tipoCama2.SelectedIndex = 1
            Me.cmb_tipoCama3.SelectedIndex = 1
            Me.cmb_tipoCama4.SelectedIndex = 1
        ElseIf Me.registrarModificar = False Then
            Me.cmb_tipoCama1.SelectedIndex = Me.auxiliarTiposCamas(0)
            Me.cmb_tipoCama2.SelectedIndex = Me.auxiliarTiposCamas(1)
            Me.cmb_tipoCama3.SelectedIndex = Me.auxiliarTiposCamas(2)
            Me.cmb_tipoCama4.SelectedIndex = Me.auxiliarTiposCamas(3)
        End If
    End Sub

    Private Sub cmd_aceptar_Click(sender As Object, e As EventArgs) Handles cmd_aceptar.Click
        Me.setearCamposABM(True)
        Me.setearCamposPanel(False)
        Me.pnl_tipoCama.Visible = False
        Me.cargarAuxiliarTiposCamas()
        estado_aceptar = aceptar.apretado
    End Sub

    Private Sub setearCamposPanel(ByVal b As Boolean)
        Me.pnl_tipoCama.Visible = b
        Me.cmd_atras.Enabled = b
        Me.cmd_aceptar.Enabled = b
        Me.cmb_tipoCama1.Enabled = b
        Me.cmb_tipoCama2.Enabled = b
        Me.cmb_tipoCama3.Enabled = b
        Me.cmb_tipoCama4.Enabled = b
    End Sub

    Private Sub setearCamposABM(ByVal b As Boolean)
        Me.txt_nroHabitacion.Enabled = b
        Me.txt_camas.Enabled = b
        Me.txt_baños.Enabled = b
        Me.txt_personas.Enabled = b
        Me.cmb_tipoHabitacion.Enabled = b
        Me.dtp_fechaEmision.Enabled = b
        Me.cmd_limpiar.Enabled = b
        Me.cmd_cancelar.Enabled = b
        Me.cmd_registrar.Enabled = b
        Me.cmd_actualizarGrilla.Enabled = b
        Me.chb_aireAcondicionado.Enabled = b
        Me.chb_frigoBar.Enabled = b
        Me.cmd_modificarTiposCama.Enabled = b
        Me.grid_habitacionPiso.Enabled = b
    End Sub

    Private Sub grid_habitacionPiso_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles grid_habitacionPiso.CellContentClick

    End Sub

    Private Sub txt_camas_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles txt_camas.MaskInputRejected

    End Sub
End Class