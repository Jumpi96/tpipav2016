Public Class menu
    Dim acceso As AccesoBD = AccesoBD.instancia
    Enum estadoNuevoAlojamiento
        nuevoCliente
        clienteExistente
    End Enum
    Dim estado As estadoNuevoAlojamiento = estadoNuevoAlojamiento.nuevoCliente


    Private Sub cargarGrillaSeleccionHabitacion()
        Dim sqlCargarGrilla As String = ""
        Dim tabla As New Data.DataTable

        sqlCargarGrilla &= "SELECT DISTINCT nroHabitacion, cantCamas, cantBaños "
        sqlCargarGrilla &= "FROM HabitacionesXPiso "
        sqlCargarGrilla &= "WHERE cantMaxPersonas >= '" & Me.cmb_canPer.SelectedItem & "'"
        If cmb_tipHab.SelectedText <> "Cualquiera" Then
            sqlCargarGrilla &= " AND idTipoHabitacion = '" & Me.cmb_tipHab.SelectedValue & "'"
        End If
        If Me.chx_airAco.CheckState = CheckState.Checked Then
            sqlCargarGrilla &= " AND aireAcondicionado = 1"
        End If
        If Me.chx_frigobar.CheckState = CheckState.Checked Then
            sqlCargarGrilla &= " AND frigobar = 1"
        End If
        sqlCargarGrilla &= " EXCEPT "
        sqlCargarGrilla &= "SELECT DISTINCT HP.nroHabitacion, HP.cantCamas, HP.cantBaños "
        sqlCargarGrilla &= "FROM HabitacionesXPiso HP JOIN Alojamientos A "
        sqlCargarGrilla &= "ON HP.nroHabitacion = A.nroHabitacion "
        sqlCargarGrilla &= "WHERE A.fechaInicioAlojamiento BETWEEN convert(date,'" & Me.dtp_fecDes.Text & "',103) AND convert(date,'" & Me.dtp_fecHas.Text & "',103) "
        sqlCargarGrilla &= "OR A.fechaFinEstimadaalojamiento BETWEEN convert(date,'" & Me.dtp_fecDes.Text & "',103) AND convert(date,'" & Me.dtp_fecHas.Text & "',103) "
        sqlCargarGrilla &= "OR convert(date,'" & Me.dtp_fecDes.Text & "',103) BETWEEN  A.fechaInicioAlojamiento AND  A.fechaFinEstimadaalojamiento "
        sqlCargarGrilla &= "OR convert(date,'" & Me.dtp_fecHas.Text & "',103) BETWEEN  A.fechaInicioAlojamiento AND  A.fechaFinEstimadaalojamiento "

        tabla = acceso.query(sqlCargarGrilla)

        Dim i As Integer

        For i = 0 To tabla.Rows.Count() - 1
            Me.grid_nueAlo.Rows.Add()
            Me.grid_nueAlo.Rows(i).Cells("clm_nroHabitacion").Value = tabla.Rows(i)("nroHabitacion")
            Me.grid_nueAlo.Rows(i).Cells("clm_cantCamasNuevoAlojamiento").Value = tabla.Rows(i)("cantCamas")
            Me.grid_nueAlo.Rows(i).Cells("clm_cantBaños").Value = tabla.Rows(i)("cantBaños")
        Next
    End Sub

    Private Sub grid_nueAlo_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles grid_nueAlo.CellContentDoubleClick
        Me.txt_habSelNro.Text = Me.grid_nueAlo.CurrentRow.Cells("clm_nroHabitacion").Value
    End Sub

    Private Function consultaClientes() As String
        Dim sqlClientes As String = ""

        sqlClientes &= "INSERT INTO Clientes (apellido, nombre, nroDocumento, tipoDocumento, fechaNacimiento, telefono) "
        sqlClientes &= "VALUES ('" & txt_ape.Text & "'"
        sqlClientes &= ", '" & txt_nom.Text & "'"
        sqlClientes &= ", '" & txt_doc.Text & "'"
        sqlClientes &= ", '" & cmb_tipoDoc.SelectedValue & "'"
        sqlClientes &= ", '" & dtp_fecNac.Value.Date & "'"
        sqlClientes &= ", '" & txt_tel.Text & "')"

        Return sqlClientes
    End Function

    Private Function consultaHospedaje() As String
        Dim sqlHospedaje As String = ""
        Dim sqlAux As String = ""
        Dim idAlojamiento As Integer = -1
        Dim tabla As New Data.DataTable

        sqlAux &= "SELECT idAlojamiento FROM Alojamientos"

        tabla = acceso.query(sqlAux)
        If tabla.Rows.Count() = 0 Then
            idAlojamiento = 1
        Else
            Dim i As Integer
            For i = 0 To tabla.Rows.Count() - 1
                If tabla.Rows(i)("idAlojamiento") > idAlojamiento Then
                    idAlojamiento = (tabla.Rows(i)("idAlojamiento") + 1)
                End If
            Next
        End If

        sqlHospedaje &= "INSERT INTO Alojamientos (nroDoc,tipoDoc,nroHabitacion,cantPersonas,fechaInicioAlojamiento,fechaFinEstimadaalojamiento,precioPorDia) "
        sqlHospedaje &= "VALUES (" & txt_doc.Text
        sqlHospedaje &= ",'" & cmb_tipoDoc.SelectedValue & "'"
        sqlHospedaje &= ",'" & txt_habSelNro.Text & "'"
        sqlHospedaje &= ",'" & cmb_canPer.SelectedItem & "'"
        sqlHospedaje &= ",'" & dtp_fecDes.Value.Date & "'"
        sqlHospedaje &= ",'" & dtp_fecHas.Value.Date & "'"
        sqlHospedaje &= ",'" & txt_preDia.Text & "')"

        Return sqlHospedaje
    End Function

    Private Sub cargarComboTipoDoc()
        Dim tabla As New Data.DataTable
        Dim sql As String = ""

        sql = "SELECT * FROM TiposDocumento"

        tabla = acceso.query(sql)

        cmb_tipoDoc.DataSource = tabla
        cmb_tipoDoc.ValueMember = "idTipoDocumento"
        cmb_tipoDoc.DisplayMember = "nombre"

        cmb_tipDocBusAlo.DataSource = tabla
        cmb_tipDocBusAlo.ValueMember = "idTipoDocumento"
        cmb_tipDocBusAlo.DisplayMember = "nombre"
    End Sub

    Private Sub cargarComboTipoHabitacion()
        Dim tabla As New Data.DataTable
        Dim sql As String = ""

        sql = "SELECT * FROM TiposHabitacion"

        tabla = acceso.query(sql)

        cmb_tipHab.DataSource = tabla
        cmb_tipHab.ValueMember = "idTipoHabitacion"
        cmb_tipHab.DisplayMember = "nombre"

        'cmb_tipHab.Items.Add("Cualquiera")
    End Sub

    Private Sub cargarComboCantidadPersonas()
        Dim tabla As New Data.DataTable
        Dim sql As String = ""
        Dim aux As Integer = 0

        sql &= "SELECT MAX(cantMaxPersonas) AS maxPersonas FROM HabitacionesXPiso "

        tabla = acceso.query(sql)

        If tabla.Rows.Count() = 0 Then
            MessageBox.Show("No se encontraron habitaciones registradas", "Error", MessageBoxButtons.OK)
        End If

        Dim i As Integer
        For i = 0 To tabla.Rows(0)("maxPersonas")
            cmb_canPer.Items.Add(i)
        Next
    End Sub

    Private Sub buscarClienteNuevoAlojamiento()
        Dim sql As String = ""
        Dim tabla As New Data.DataTable

        sql &= "SELECT * FROM Clientes "
        sql &= "WHERE tipoDocumento = '" & Me.cmb_tipoDoc.SelectedValue & "' "
        sql &= "AND nroDocumento = " & Me.txt_doc.Text

        tabla = acceso.query(sql)

        If tabla.Rows.Count() = 0 Then
            MessageBox.Show("EL cliente no existe", "Error", MessageBoxButtons.OK)
            Exit Sub
        End If

        Me.cmb_tipoDoc.SelectedValue = tabla.Rows(0)("tipoDocumento")
        Me.txt_ape.Text = tabla.Rows(0)("apellido")
        Me.txt_nom.Text = tabla.Rows(0)("nombre")
        Me.txt_tel.Text = tabla.Rows(0)("telefono")
        Me.dtp_fecNac.Value = tabla.Rows(0)("fechaNacimiento")

        estado = estadoNuevoAlojamiento.clienteExistente
    End Sub

    Private Function validarCamposClienteNuevoAlojamiento() As Boolean
        If cmb_tipoDoc.SelectedIndex = -1 Then
            MessageBox.Show("Tipo de documento del cliente no seleccionado", "Error", MessageBoxButtons.OK)
            cmb_tipoDoc.Focus()
            Return False
        End If
        If txt_doc.Text = "" Then
            MessageBox.Show("Número de documento del cliente no ingresado", "Error", MessageBoxButtons.OK)
            txt_doc.Focus()
            Return False
        End If
        If txt_ape.Text = "" Then
            MessageBox.Show("Apellido del cliente no ingresado", "Error", MessageBoxButtons.OK)
            txt_ape.Focus()
            Return False
        End If
        If txt_nom.Text = "" Then
            MessageBox.Show("Nombre del cliente no ingresado", "Error", MessageBoxButtons.OK)
            txt_nom.Focus()
            Return False
        End If
        If txt_tel.Text = "" Then
            MessageBox.Show("Teléfono del cliente no ingresado", "Error", MessageBoxButtons.OK)
            txt_tel.Focus()
            Return False
        End If
        Return True
    End Function

    Private Function validarExistenciaClienteNuevoAlojamiento() As Boolean
        Dim sql As String = ""
        Dim tabla As New Data.DataTable
        Dim dr As New DialogResult
        sql &= "SELECT * FROM Clientes "
        sql &= "WHERE tipoDocumento = '" & Me.cmb_tipoDoc.SelectedValue & "' "
        sql &= "AND nroDocumento = '" & Me.txt_doc.Text & "'"

        tabla = acceso.query(sql)

        If tabla.Rows.Count() <> 0 Then
            If estado = estadoNuevoAlojamiento.nuevoCliente Then
                dr = MessageBox.Show("Cliente ya existente. ¿Desea completar el formulario con los datos de éste?", "Error", MessageBoxButtons.YesNo)
                If dr = DialogResult.Yes Then
                    Me.txt_ape.Text = tabla.Rows(0)("apellido")
                    Me.txt_nom.Text = tabla.Rows(0)("nombre")
                    Me.txt_tel.Text = tabla.Rows(0)("telefono")
                    Me.dtp_fecNac.Value = tabla.Rows(0)("fechaNacimiento")
                    estado = estadoNuevoAlojamiento.clienteExistente
                    Return True
                ElseIf dr = DialogResult.No Then
                    Me.txt_doc.Text = ""
                    Me.txt_doc.Focus()
                    estado = estadoNuevoAlojamiento.nuevoCliente
                    Return False
                End If
            End If
        End If
        Return True
    End Function

    Private Function validarCamposHospedajeNuevoAlojamiento() As Boolean
        If Me.dtp_fecDes.Value.Date > Me.dtp_fecHas.Value.Date Or Me.dtp_fecDes.Value.Date < Today.Date Then
            MessageBox.Show("Campos de fechas no válidos", "Error", MessageBoxButtons.OK)
            dtp_fecDes.Focus()
            Return False
        End If
        If cmb_canPer.SelectedIndex = -1 Then
            MessageBox.Show("Cantidad de personas a hospedarse no seleccionada", "Error", MessageBoxButtons.OK)
            cmb_canPer.Focus()
            Return False
        End If
        If cmb_tipHab.SelectedIndex = -1 Then
            MessageBox.Show("Tipo habitación del hospedaje no seleccionada", "Error", MessageBoxButtons.OK)
            cmb_tipHab.Focus()
            Return False
        End If
        Return True
    End Function

    Private Function validarCamposHabitacionNuevoAlojamiento() As Boolean
        If Me.txt_habSelNro.Text = "" Then
            MessageBox.Show("Habitación no seleccionada", "Error", MessageBoxButtons.OK)
            Return False
        End If
        If Me.txt_preDia.Text = "" Then
            MessageBox.Show("Precio por día no ingresado", "Error", MessageBoxButtons.OK)
            Me.txt_preDia.Focus()
            Return False
        End If
        Return True
    End Function

    Private Sub ocultarNuevoAlojamiento()
        Me.pnl_nueAlo.Visible = False
        Me.pnl_nueAlo.Enabled = False
        Me.pnl_nueAlo.SendToBack()
    End Sub

    Private Sub mostrarNuevoAlojamiento()
        Me.pnl_nueAlo.Visible = True
        Me.pnl_nueAlo.Enabled = True
        Me.tab_aloNue.SelectedTab = tab_aloNueDatCli
        Me.cmb_tipoDoc.Focus()
        Me.pnl_nueAlo.BringToFront()
    End Sub

    Private Sub ocultarBuscarAlojamiento()
        Me.pnl_busAlo.Visible = False
        Me.pnl_busAlo.Enabled = False
        Me.pnl_busAlo.SendToBack()
    End Sub

    Private Sub mostrarBuscarAlojamiento()
        Me.pnl_busAlo.Visible = True
        Me.pnl_busAlo.Enabled = True
        Me.tab_busAlo.SelectedTab = tab_busAloDatCli
        Me.cmb_tipDocBusAlo.Focus()
        Me.pnl_busAlo.BringToFront()
    End Sub

    Private Sub ocultarNuevaOrdenCompra()
        Me.pnl_nueOrdCom.Visible = False
        Me.pnl_nueOrdCom.Enabled = False
        Me.pnl_nueOrdCom.SendToBack()
    End Sub

    Private Sub mostrarNuevaOrdenCompra()
        Me.pnl_nueOrdCom.Visible = True
        Me.pnl_nueOrdCom.Enabled = True
        Me.tab_nueOrdCom.SelectedTab = tab_nueOrdComDatPro
        Me.cmb_IDPro.Focus()
        Me.pnl_nueOrdCom.BringToFront()
    End Sub

    Private Sub ocultarBuscarOrdenCompra()
        Me.pnl_busOrdCom.Visible = False
        Me.pnl_busOrdCom.Enabled = False
        Me.pnl_busOrdCom.SendToBack()
    End Sub

    Private Sub mostrarBuscarOrdenCompra()
        Me.pnl_busOrdCom.Visible = True
        Me.pnl_busOrdCom.Enabled = True
        Me.tab_busOrdCom.SelectedTab = tab_busOrdComDatPro
        Me.cmb_IDProBusOrdCom.Focus()
        Me.pnl_busOrdCom.BringToFront()
    End Sub

    Private Sub ocultarAgregarArticulo()
        Me.pnl_agrArt.Visible = False
        Me.pnl_agrArt.Enabled = False
        Me.pnl_agrArt.SendToBack()
    End Sub

    Private Sub mostrarAgregarArticulo()
        Me.pnl_agrArt.Visible = True
        Me.pnl_agrArt.Enabled = True
        Me.tab_carArt.SelectedTab = tab_carArtHab
        Me.cmb_nroPisoCarArt.Focus()
        Me.pnl_agrArt.BringToFront()
    End Sub

    Private Sub ocultarAgregarServicio()
        Me.pnl_agrServ.Visible = False
        Me.pnl_agrServ.Enabled = False
        Me.pnl_agrServ.SendToBack()
    End Sub

    Private Sub mostrarAgregarServicio()
        Me.pnl_agrServ.Visible = True
        Me.pnl_agrServ.Enabled = True
        Me.tab_carServ.SelectedTab = tab_carServHab
        Me.cmb_nroPiso.Focus()
        Me.pnl_agrServ.BringToFront()
    End Sub

    Private Sub NuevoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevoToolStripMenuItem.Click
        Me.menu_Menu.Enabled = False
        Me.ocultarBuscarAlojamiento()
        Me.ocultarNuevaOrdenCompra()
        Me.ocultarBuscarOrdenCompra()
        Me.ocultarAgregarArticulo()
        Me.ocultarAgregarServicio()
        Me.mostrarNuevoAlojamiento()
    End Sub

    Private Sub txt_doc_Click(sender As Object, e As EventArgs) Handles txt_doc.Click
        If Me.txt_doc.Text = "" Then
            Me.txt_doc.SelectionStart = 0
        End If
    End Sub

    Private Sub BuscarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BuscarToolStripMenuItem.Click
        Me.menu_Menu.Enabled = False
        Me.ocultarNuevoAlojamiento()
        Me.ocultarNuevaOrdenCompra()
        Me.ocultarBuscarOrdenCompra()
        Me.ocultarAgregarServicio()
        Me.ocultarAgregarArticulo()
        Me.mostrarBuscarAlojamiento()
    End Sub

    Private Sub cmd_canCli_Click(sender As Object, e As EventArgs) Handles cmd_canCli.Click
        Me.ocultarNuevoAlojamiento()
        Me.menu_Menu.Enabled = True
        Me.cmd_nueAloDatCliLim_Click(sender, e)
        Me.cmd_nueAloDatHosLim_Click(sender, e)
    End Sub

    Private Sub cmd_atrHos_Click(sender As Object, e As EventArgs) Handles cmd_atrHos.Click
        Me.tab_aloNue.SelectedTab = tab_aloNueDatCli
        Me.dtp_fecDes.Value = Today.Date
        Me.dtp_fecHas.Value = Today.Date
        Me.cmb_canPer.Text = ""
        Me.cmb_tipHab.Text = ""
    End Sub

    Private Sub cmd_aceHab_Click(sender As Object, e As EventArgs) Handles cmd_aceHab.Click
        If estado = estadoNuevoAlojamiento.nuevoCliente And Me.validarCamposClienteNuevoAlojamiento = True Then
            Dim tablaCliente As New Data.DataTable
            tablaCliente = acceso.query(Me.consultaClientes())
            MessageBox.Show("Cliente registrado con éxito")
        End If
        If Me.validarCamposHospedajeNuevoAlojamiento = True And Me.validarCamposHabitacionNuevoAlojamiento = True Then
            Dim tablaHospedaje As New Data.DataTable
            tablaHospedaje = acceso.query(Me.consultaHospedaje())
            MessageBox.Show("Hospedaje registrado con éxito")
        Else
            Exit Sub
        End If
        Me.ocultarNuevoAlojamiento()
        Me.menu_Menu.Enabled = True
        Me.cmd_nueAloDatCliLim_Click(sender, e)
        Me.cmd_nueAloDatHosLim_Click(sender, e)
        Me.txt_habSelNro.Text = ""
        Me.txt_preDia.Text = ""
    End Sub

    Private Sub cmd_sigHos_Click(sender As Object, e As EventArgs) Handles cmd_sigHos.Click
        Me.grid_nueAlo.Rows.Clear()
        If Me.validarCamposHospedajeNuevoAlojamiento = True Then
            Me.tab_aloNue.SelectedTab = tab_aloNueSelHab
            Me.cargarGrillaSeleccionHabitacion()
        End If
    End Sub

    Private Sub cmd_sigCli_Click(sender As Object, e As EventArgs) Handles cmd_sigCli.Click
        If Me.validarCamposClienteNuevoAlojamiento = True Then
            If Me.validarExistenciaClienteNuevoAlojamiento = True Then
                Me.tab_aloNue.SelectedTab = tab_aloNueDatHos
                Me.cmb_tipoDoc.Enabled = False
                Me.txt_doc.ReadOnly = True
                Me.txt_ape.ReadOnly = True
                Me.txt_nom.ReadOnly = True
                Me.dtp_fecNac.Enabled = False
                Me.txt_tel.ReadOnly = True
            End If
        End If
    End Sub

    Private Sub cam_atrHab_Click(sender As Object, e As EventArgs) Handles cam_atrHab.Click
        Me.tab_aloNue.SelectedTab = tab_aloNueDatHos
        Me.txt_habSelNro.Text = ""
        Me.txt_preDia.Text = ""
    End Sub

    Private Sub cmd_busAloDatCliSig_Click(sender As Object, e As EventArgs) Handles cmd_busAloDatCliSig.Click
        Me.tab_busAlo.SelectedTab = tab_busAloAlo
    End Sub

    Private Sub cmd_busAloCan_Click(sender As Object, e As EventArgs) Handles cmd_busAloCan.Click
        Me.txt_docBusAlo.Text = ""
        Me.txt_apeBusAlo.Text = ""
        Me.txt_nomBusAlo.Text = ""
        Me.cmb_tipDocBusAlo.Text = ""
        Me.ocultarBuscarAlojamiento()
        Me.menu_Menu.Enabled = True
    End Sub

    Private Sub txt_docBusAlo_Click(sender As Object, e As EventArgs) Handles txt_docBusAlo.Click
        If Me.txt_docBusAlo.Text = "" Then
            Me.txt_docBusAlo.SelectionStart = 0
        End If
    End Sub

    Private Sub cmd_busAloAtr_Click(sender As Object, e As EventArgs) Handles cmd_busAloAtr.Click
        Me.tab_busAlo.SelectedTab = tab_busAloDatCli
    End Sub

    Private Sub cmd_busAloFin_Click(sender As Object, e As EventArgs) Handles cmd_busAloFin.Click
        Me.txt_docBusAlo.Text = ""
        Me.txt_apeBusAlo.Text = ""
        Me.txt_nomBusAlo.Text = ""
        Me.cmb_tipDocBusAlo.Text = ""
        Me.ocultarBuscarAlojamiento()
        Me.menu_Menu.Enabled = True
    End Sub

    Private Sub cmd_nueOrdComCan_Click(sender As Object, e As EventArgs) Handles cmd_nueOrdComCan.Click
        Me.cmb_IDPro.Text = ""
        Me.txt_nomPro.Text = ""
        Me.txt_telPro.Text = ""
        Me.txt_corPro.Text = ""
        Me.ocultarNuevaOrdenCompra()
        Me.menu_Menu.Enabled = True
    End Sub

    Private Sub cmd_nueOrdComSig_Click(sender As Object, e As EventArgs) Handles cmd_nueOrdComSig.Click
        tab_nueOrdCom.SelectedTab = tab_nueOrdComArt
    End Sub

    Private Sub NuevaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevaToolStripMenuItem.Click
        Me.menu_Menu.Enabled = False
        Me.ocultarNuevoAlojamiento()
        Me.ocultarBuscarAlojamiento()
        Me.ocultarBuscarOrdenCompra()
        Me.ocultarAgregarServicio()
        Me.ocultarAgregarArticulo()
        Me.mostrarNuevaOrdenCompra()
    End Sub

    Private Sub cmd_nueOrdComAtr_Click(sender As Object, e As EventArgs) Handles cmd_nueOrdComAtr.Click
        Me.tab_nueOrdCom.SelectedTab = tab_nueOrdComDatPro
    End Sub

    Private Sub cmd_nueOrdComFin_Click(sender As Object, e As EventArgs) Handles cmd_nueOrdComArtSig.Click
        Me.tab_nueOrdCom.SelectedTab = tab_nueOrdComRes
    End Sub

    Private Sub BuscarToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles BuscarToolStripMenuItem1.Click
        Me.menu_Menu.Enabled = False
        Me.ocultarNuevoAlojamiento()
        Me.ocultarBuscarAlojamiento()
        Me.ocultarNuevaOrdenCompra()
        Me.ocultarAgregarArticulo()
        Me.ocultarAgregarServicio()
        Me.mostrarBuscarOrdenCompra()
    End Sub

    Private Sub cmd_busOrdComCan_Click(sender As Object, e As EventArgs) Handles cmd_busOrdComCan.Click
        Me.cmb_IDProBusOrdCom.Text = ""
        Me.txt_corProBusOrdCom.Text = ""
        Me.txt_telProBusOrdCom.Text = ""
        Me.txt_nomProBusOrdCom.Text = ""
        Me.ocultarBuscarOrdenCompra()
        Me.menu_Menu.Enabled = True
    End Sub

    Private Sub cmd_busOrdComSig_Click(sender As Object, e As EventArgs) Handles cmd_busOrdComSig.Click
        Me.tab_busOrdCom.SelectedTab = tab_busOrdComOrdCom
    End Sub

    Private Sub cmd_busOrdComAtr_Click(sender As Object, e As EventArgs) Handles cmd_busOrdComAtr.Click
        Me.tab_busOrdCom.SelectedTab = Me.tab_busOrdComDatPro
    End Sub

    Private Sub cmd_busOrdComFin_Click(sender As Object, e As EventArgs) Handles cmd_busOrdComFin.Click
        Me.cmb_IDProBusOrdCom.Text = ""
        Me.txt_corProBusOrdCom.Text = ""
        Me.txt_telProBusOrdCom.Text = ""
        Me.txt_nomProBusOrdCom.Text = ""
        Me.ocultarBuscarOrdenCompra()
        Me.menu_Menu.Enabled = True
    End Sub

    Private Sub AgrearArtículoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AgrearArtículoToolStripMenuItem.Click
        Me.menu_Menu.Enabled = False
        Me.ocultarNuevoAlojamiento()
        Me.ocultarBuscarAlojamiento()
        Me.ocultarNuevaOrdenCompra()
        Me.ocultarBuscarOrdenCompra()
        Me.ocultarAgregarServicio()
        Me.mostrarAgregarArticulo()
    End Sub

    Private Sub AgregarServicioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AgregarServicioToolStripMenuItem.Click
        Me.menu_Menu.Enabled = False
        Me.ocultarNuevoAlojamiento()
        Me.ocultarBuscarAlojamiento()
        Me.ocultarNuevaOrdenCompra()
        Me.ocultarBuscarOrdenCompra()
        Me.ocultarAgregarArticulo()
        Me.mostrarAgregarServicio()
    End Sub

    Private Sub cmd_carServCan_Click(sender As Object, e As EventArgs) Handles cmd_carServCan.Click
        Me.cmb_nroHab.Text = ""
        Me.cmb_nroPiso.Text = ""
        Me.txt_cliAso.Text = ""
        Me.ocultarAgregarServicio()
        Me.menu_Menu.Enabled = True
    End Sub

    Private Sub cmd_carServSig_Click(sender As Object, e As EventArgs) Handles cmd_carServSig.Click
        Me.tab_carServ.SelectedTab = tab_carServServ
    End Sub

    Private Sub cmd_carSerFin_Click(sender As Object, e As EventArgs) Handles cmd_carSerFin.Click
        Me.cmb_nroHab.Text = ""
        Me.cmb_nroPiso.Text = ""
        Me.txt_cliAso.Text = ""
        Me.ocultarAgregarServicio()
        Me.menu_Menu.Enabled = True
    End Sub

    Private Sub cmd_carServAtr_Click(sender As Object, e As EventArgs) Handles cmd_carServAtr.Click
        Me.tab_carServ.SelectedTab = tab_carServHab
    End Sub

    Private Sub cmd_carArtCan_Click(sender As Object, e As EventArgs) Handles cmd_carArtCan.Click
        Me.cmb_nroHabCarArt.Text = ""
        Me.cmb_nroPisoCarArt.Text = ""
        Me.txt_cliAsoCarArt.Text = ""
        Me.ocultarAgregarArticulo()
        Me.menu_Menu.Enabled = True
    End Sub

    Private Sub cmd_carArtSig_Click(sender As Object, e As EventArgs) Handles cmd_carArtSig.Click
        Me.tab_carArt.SelectedTab = tab_carArtArt
    End Sub

    Private Sub cmd_carArtAtr_Click(sender As Object, e As EventArgs) Handles cmd_carArtAtr.Click
        Me.tab_carArt.SelectedTab = tab_carArtHab
    End Sub

    Private Sub cmd_carArtFin_Click(sender As Object, e As EventArgs) Handles cmd_carArtFin.Click
        Me.cmb_nroHabCarArt.Text = ""
        Me.cmb_nroPisoCarArt.Text = ""
        Me.txt_cliAsoCarArt.Text = ""
        Me.ocultarAgregarArticulo()
        Me.menu_Menu.Enabled = True
    End Sub

    Private Sub cmd_carSerHabLim_Click(sender As Object, e As EventArgs) Handles cmd_carSerHabLim.Click
        Me.cmb_nroPiso.Text = ""
        Me.cmb_nroHab.Text = ""
        Me.txt_cliAso.Text = ""
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles cmd_busArtLim.Click
        Me.cmb_nroHabCarArt.Text = ""
        Me.cmb_nroPisoCarArt.Text = ""
        Me.txt_cliAsoCarArt.Text = ""
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles cmd_busOrdComLim.Click
        Me.cmb_IDProBusOrdCom.Text = ""
        Me.txt_corProBusOrdCom.Text = ""
        Me.txt_nomProBusOrdCom.Text = ""
        Me.txt_telProBusOrdCom.Text = ""
    End Sub

    Private Sub cmd_nueOrdComLim_Click(sender As Object, e As EventArgs) Handles cmd_nueOrdComLim.Click
        Me.cmb_IDPro.Text = ""
        Me.txt_nomPro.Text = ""
        Me.txt_corPro.Text = ""
        Me.txt_telPro.Text = ""
    End Sub

    Private Sub cmd_nueAloDatCliLim_Click(sender As Object, e As EventArgs) Handles cmd_nueAloDatCliLim.Click
        Me.cmb_tipoDoc.Enabled = True
        Me.txt_doc.ReadOnly = False
        Me.txt_ape.ReadOnly = False
        Me.txt_nom.ReadOnly = False
        Me.dtp_fecNac.Enabled = True
        Me.txt_tel.ReadOnly = False
        Me.cmb_tipoDoc.SelectedIndex = -1
        Me.txt_doc.Text = ""
        Me.txt_ape.Text = ""
        Me.txt_nom.Text = ""
        Me.txt_tel.Text = ""
        estado = estadoNuevoAlojamiento.nuevoCliente
    End Sub

    Private Sub cmd_nueAloDatHosLim_Click(sender As Object, e As EventArgs) Handles cmd_nueAloDatHosLim.Click
        Me.dtp_fecDes.Value = Today.Date
        Me.dtp_fecHas.Value = Today.Date
        Me.cmb_canPer.SelectedIndex = -1
        Me.cmb_tipHab.SelectedIndex = -1
        Me.chx_airAco.Checked = False
        Me.chx_airAco.CheckState = CheckState.Unchecked
        Me.chx_frigobar.Checked = False
        Me.chx_frigobar.CheckState = CheckState.Unchecked
        Me.grid_nueAlo.Rows.Clear()
    End Sub

    Private Sub cmd_busAloLim_Click(sender As Object, e As EventArgs) Handles cmd_busAloLim.Click
        Me.cmb_tipDocBusAlo.Text = ""
        Me.txt_docBusAlo.Text = ""
        Me.txt_apeBusAlo.Text = ""
        Me.txt_nomBusAlo.Text = ""
    End Sub

    Private Sub cmd_atrAloSel_Click(sender As Object, e As EventArgs) Handles cmd_atrAloSel.Click
        pnl_busAloSel.Enabled = False
        pnl_busAloSel.Visible = False
        pnl_busAloSel.SendToBack()
    End Sub

    Private Sub cmd_clickEnGrilla_Click(sender As Object, e As EventArgs) Handles cmd_clickEnGrilla.Click
        pnl_busAloSel.Enabled = True
        pnl_busAloSel.Visible = True
        pnl_busAloSel.BringToFront()
    End Sub

    Private Sub cmd_atrOrdComSel_Click(sender As Object, e As EventArgs) Handles cmd_atrOrdComSel.Click
        pnl_ordComSel.Enabled = False
        pnl_ordComSel.Visible = False
        pnl_ordComSel.SendToBack()
    End Sub

    Private Sub cmd_clickEnGrillaOrdenDeCompra_Click(sender As Object, e As EventArgs) Handles cmd_clickEnGrillaOrdenDeCompra.Click
        pnl_ordComSel.Enabled = True
        pnl_ordComSel.Visible = True
        pnl_ordComSel.BringToFront()
    End Sub

    Private Sub cmd_nueOrdComFin_Click_1(sender As Object, e As EventArgs) Handles cmd_nueOrdComFin.Click
        Me.cmb_IDPro.Text = ""
        Me.txt_nomPro.Text = ""
        Me.txt_telPro.Text = ""
        Me.txt_corPro.Text = ""
        Me.txt_nueOrdComArtFilDes.Text = ""
        Me.txt_nueOrdComArtFilID.Text = ""
        Me.ocultarNuevaOrdenCompra()
        Me.menu_Menu.Enabled = True
    End Sub

    Private Sub cmd_nueOrdComResAtr_Click(sender As Object, e As EventArgs) Handles cmd_nueOrdComResAtr.Click
        Me.tab_nueOrdCom.SelectedTab = tab_nueOrdComArt
    End Sub

    Private Sub menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.lbl_fechahora.Text = Today.Day & "/" & Today.Month & "/" & Today.Year
        Me.cargarComboTipoDoc()
        'Me.cargarComboCantidadPersonas()
        'Me.cargarComboTipoHabitacion()
    End Sub


    Private Sub cmd_busCli_Click(sender As Object, e As EventArgs) Handles cmd_busCli.Click
        Me.buscarClienteNuevoAlojamiento()
    End Sub
    
    Private Sub grid_nueAlo_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles grid_nueAlo.CellContentClick
        Me.txt_habSelNro.Text = Me.grid_nueAlo.CurrentRow.Cells("clm_nroHabitacion").Value
    End Sub
    Private Sub txt_tel_MouseClick(sender As Object, e As MouseEventArgs) Handles txt_tel.MouseClick
        If Me.txt_tel.Text = "" Then
            Me.txt_tel.SelectionStart = 0
        End If
    End Sub

    Private Sub txt_preDia_MouseClick(sender As Object, e As MouseEventArgs) Handles txt_preDia.MouseClick
        If Me.txt_preDia.Text = "" Then
            Me.txt_preDia.SelectionStart = 0
        End If
    End Sub

    Private Sub tab_aloNueDatCli_Click(sender As Object, e As EventArgs) Handles tab_aloNueDatCli.Click
        Me.cmd_atrAloSel_Click(sender, e)
    End Sub

    Private Sub tab_aloNueDatHos_Click(sender As Object, e As EventArgs) Handles tab_aloNueDatHos.Click
        Me.cmd_sigCli_Click(sender, e)
        Me.cam_atrHab_Click(sender, e)
    End Sub

    Private Sub tab_aloNueSelHab_Click(sender As Object, e As EventArgs) Handles tab_aloNueSelHab.Click
        Me.cmd_sigCli_Click(sender, e)
        Me.cmd_sigHos_Click(sender, e)
    End Sub

    Private Sub ABMTiposHabitaciónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ABMTiposHabitaciónToolStripMenuItem.Click
        ABM_TiposHabitacion.Show()
    End Sub

    Private Sub ABMProveedoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ABMProveedoresToolStripMenuItem.Click
        ABM_Proveedores.Show()
    End Sub

    Private Sub ABMHabitaciónXPisoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ABMHabitaciónXPisoToolStripMenuItem.Click
        ABM_Habitación_X_Piso.Show()
    End Sub

    Private Sub ABMAlojamientosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ABMAlojamientosToolStripMenuItem.Click
        ABM_Alojamientos.Show()
    End Sub

    Private Sub ABMClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ABMClientesToolStripMenuItem.Click
        ABM_Clientes.Show()
    End Sub

    Private Sub ABMTiposDocumentosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ABMTiposDocumentosToolStripMenuItem.Click
        ABM_TiposDocumentos.Show()
    End Sub

    Private Sub ABMServiciosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ABMServiciosToolStripMenuItem.Click
        ABM_Servicios.Show()
    End Sub

    Private Sub ABMTiposCamaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ABMTiposCamaToolStripMenuItem.Click
        ABM_Tipos_Cama.Show()
    End Sub

    Private Sub ABMServiciosXAlojamientoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ABMServiciosXAlojamientoToolStripMenuItem.Click
        ABM_ServiciosXAlojamiento.Show()

    End Sub

    Private Sub ABMArtículosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ABMArtículosToolStripMenuItem.Click
        ABM_Articulos.Show()
    End Sub

    Private Sub ABMTiposFacturaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ABMTiposFacturaToolStripMenuItem.Click
        ABM_Tipo_Factura.Show()
    End Sub

    Private Sub ABMConsumicionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ABMConsumicionToolStripMenuItem.Click
        ABM_Consumicion.Show()

    End Sub

    Private Sub FuncionesAdministrativasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FuncionesAdministrativasToolStripMenuItem.Click

    End Sub
End Class