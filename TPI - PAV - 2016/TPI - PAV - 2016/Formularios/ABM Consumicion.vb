Public Class ABM_Consumicion
    Dim acceso As AccesoBD = AccesoBD.instancia
    Dim idAlojamientoSub As Integer
    Dim idArticuloSub As Integer
    Dim cantidadSub As Integer
    Dim frigobarSub As String

    Private Sub ABM_Consumicion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.cargarCombo("Articulos", "idArticulo", "nombre", Me.cmb_articulos)
        Me.cmb_articulos.Enabled = False
        Me.grid_articulos.Enabled = False
        Me.cmd_borrar.Enabled = False
        idAlojamientoSub = -1
        idArticuloSub = -1
        cantidadSub = 0
        frigobarSub = ""
        Me.cmb_articulos.SelectedIndex = -1
    End Sub

    Private Sub cargarCombo(ByVal nombre_tabla As String, ByVal pk As String, ByVal descripcion As String, ByRef combo As ComboBox)
        Dim tabla As Data.DataTable = acceso.query("SELECT * FROM " + nombre_tabla)

        combo.DataSource = tabla
        combo.DisplayMember = descripcion
        combo.ValueMember = pk
    End Sub

    Private Sub cargarGrilla()
        Dim sentencia As String = "SELECT A.idAlojamiento, Ar.nombre, C.cantidad, Ar.idArticulo, C.frigobar FROM Consumiciones C "
        sentencia &= "JOIN Alojamientos A ON A.idAlojamiento = C.idAlojamiento JOIN Articulos Ar ON C.idArticulo=Ar.idArticulo "
        sentencia &= "WHERE A.nroHabitacion = '" & txt_nroHabitacion.Text & "'"

        Dim tabla As New DataTable

        tabla = acceso.query(sentencia)
        grid_articulos.Rows.Clear()

        If tabla.Rows.Count() <> 0 Then
            Dim i As Integer
            For i = 0 To tabla.Rows.Count() - 1
                Me.grid_articulos.Rows.Add()
                Me.grid_articulos.Rows(i).Cells("clm_idAlojamiento").Value = tabla.Rows(i)("idAlojamiento")
                Me.grid_articulos.Rows(i).Cells("clm_articulo").Value = tabla.Rows(i)("nombre")
                Me.grid_articulos.Rows(i).Cells("clm_Cantidad").Value = tabla.Rows(i)("cantidad")
                Me.grid_articulos.Rows(i).Cells("clm_idArticulo").Value = tabla.Rows(i)("idArticulo")
                If tabla.Rows(i)("frigobar") = 1 Then
                    Me.grid_articulos.Rows(i).Cells("cln_frigobar").Value = "SI"
                Else
                    Me.grid_articulos.Rows(i).Cells("cln_frigobar").Value = "NO"
                End If
            Next
        End If
    End Sub

    Private Function validarCampos() As Boolean
        If Me.txt_nroHabitacion.Text = "" Then
            MessageBox.Show("Número de habitación no ingresado", "Error", MessageBoxButtons.OK)
            Me.txt_nroHabitacion.Focus()
            Return False
        End If
        Return True
    End Function

    Private Function validarAgregar() As Boolean
        If Me.cmb_articulos.SelectedIndex = -1 Then
            MessageBox.Show("Articulo no seleccionado", "Error", MessageBoxButtons.OK)
            Me.txt_nroHabitacion.Focus()
            Return False
        End If
        If Me.txt_cantidad.Text = "" Then
            MessageBox.Show("Ingrese una cantidad", "Error", MessageBoxButtons.OK)
            Me.txt_cantidad.Focus()
            Return False
        End If
        If Me.txt_cantidad.Text < 0 Then
            MessageBox.Show("Ingrese una cantidad positiva", "Error", MessageBoxButtons.OK)
            Me.txt_cantidad.Focus()
            Return False
        End If
        Return True
    End Function

    Private Function validarNroHabitacion() As Boolean
        Dim sql As String = ""
        Dim tabla As New Data.DataTable

        sql &= "SELECT * FROM HabitacionesXPiso JOIN Alojamientos "
        sql &= "ON HabitacionesXPiso.nroHabitacion = Alojamientos.nroHabitacion "
        sql &= "WHERE CONVERT(date,GETDATE()) BETWEEN fechaInicioAlojamiento AND fechaFinEstimadaAlojamiento "
        sql &= "AND HabitacionesXPiso.nroHabitacion = '" & Me.txt_nroHabitacion.Text & "'"

        tabla = acceso.query(sql)

        If tabla.Rows.Count() = 0 Then
            MessageBox.Show("Esa habitación no esta asociada a un alojamiento en proceso actualmente", "Error", MessageBoxButtons.OK)
            Return False
        End If
        Return True
    End Function

    Private Sub cargarDatosCliente()
        Dim sql As String = ""
        Dim tabla As New Data.DataTable

        sql &= "SELECT * FROM HabitacionesXPiso JOIN Alojamientos "
        sql &= "ON Alojamientos.nroHabitacion = HabitacionesXPiso.nroHabitacion "
        sql &= "JOIN Clientes ON Clientes.nroDocumento = Alojamientos.nroDoc AND clientes.tipoDocumento = Alojamientos.tipoDoc "
        sql &= "JOIN TiposDocumento ON TiposDocumento.idTipoDocumento = Clientes.tipoDocumento "
        sql &= "WHERE CONVERT(date,GETDATE()) BETWEEN fechaInicioAlojamiento AND fechaFinEstimadaAlojamiento "
        sql &= "AND HabitacionesXPiso.nroHabitacion = '" & Me.txt_nroHabitacion.Text & "'"

        tabla = acceso.query(sql)

        Me.txt_tipoDocumento.Text = tabla.Rows(0)("nombre1")
        Me.txt_documento.Text = tabla.Rows(0)("nroDoc")
        Me.txt_apellido.Text = tabla.Rows(0)("apellido")
        Me.txt_nombre.Text = tabla.Rows(0)("nombre")
        idAlojamientoSub = tabla.Rows(0)("idAlojamiento")
    End Sub

    Private Sub cmd_buscar_Click(sender As Object, e As EventArgs) Handles cmd_buscar.Click
        If Me.validarCampos() = True Then
            If Me.validarNroHabitacion() = True Then
                Me.txt_nroHabitacion.ReadOnly = True
                Me.grid_articulos.Enabled = True
                Me.cmb_articulos.Enabled = True
                Me.cmd_agregar.Enabled = True
                Me.cmd_limpiar.Enabled = True
                Me.cargarDatosCliente()
                Me.cargarCombo("Articulos", "idArticulo", "nombre", Me.cmb_articulos)
                Me.cargarGrilla()
            End If
        End If
    End Sub

    Private Function validarConsumicionPrevia() As Boolean
        Dim sql As String = ""
        Dim tabla As New Data.DataTable

        sql &= "SELECT * FROM Consumiciones JOIN Alojamientos "
        sql &= "ON Consumiciones.idAlojamiento = Alojamientos.idAlojamiento "
        sql &= "WHERE Alojamientos.nroHabitacion = " & Me.txt_nroHabitacion.Text & " "
        sql &= "AND Consumiciones.idArticulo = '" & cmb_articulos.SelectedValue & "' "
        If chb_frigobar.CheckState = CheckState.Checked Then
            sql &= "AND Consumiciones.frigobar = 1"
        Else
            sql &= "AND Consumiciones.frigobar = 0"
        End If

        tabla = acceso.query(sql)

        If tabla.Rows.Count() = 0 Then
            Return False
        End If
        Return True
    End Function

    Private Function validarFrigobar() As Boolean
        Dim sql As String = ""
        Dim tabla As New Data.DataTable

        sql &= "SELECT * FROM HabitacionesXPiso "
        sql &= "WHERE nroHabitacion = '" & Me.txt_nroHabitacion.Text & "' "
        sql &= "AND frigobar = 1"

        tabla = acceso.query(sql)

        If tabla.Rows.Count() = 0 Then
            MessageBox.Show("Esa habitación no posee frigobar actualmente", "Error", MessageBoxButtons.OK)
            Return False
        End If
        Return True
    End Function

    Private Function validarStock() As Boolean
        Dim sql As String = ""
        Dim tabla As New Data.DataTable

        sql &= "SELECT stock FROM Articulos "
        sql &= "WHERE idArticulo = '" & Me.cmb_articulos.SelectedValue & "'"

        tabla = acceso.query(sql)

        If tabla.Rows(0)("stock") < Me.txt_cantidad.Text Then
            MessageBox.Show("Stock insuficiente", "Error", MessageBoxButtons.OK)
            Return False
        End If

        Return True
    End Function

    Private Sub restarStock()
        Dim sql As String = ""

        sql &= "UPDATE Articulos "
        sql &= "SET stock = stock - " & Me.txt_cantidad.Text & " "
        sql &= "WHERE idArticulo = '" & Me.cmb_articulos.SelectedValue & "'"

        acceso.nonQuery(sql)
    End Sub

    Private Sub cmd_agregar_Click(sender As Object, e As EventArgs) Handles cmd_agregar.Click
        Dim sql As String = ""

        If validarAgregar() = True Then
            If validarStock() = True Then
                If validarConsumicionPrevia() = True Then
                    If chb_frigobar.CheckState = CheckState.Checked Then
                        If validarFrigobar() = True Then
                            sql &= "UPDATE Consumiciones "
                            sql &= "SET cantidad = cantidad + " & Me.txt_cantidad.Text & " "
                            sql &= "WHERE idAlojamiento = " & idAlojamientoSub & " "
                            sql &= "AND idArticulo = '" & Me.cmb_articulos.SelectedValue & "' "
                            sql &= "AND frigobar = 1"
                        Else
                            Exit Sub
                        End If
                    Else
                        sql &= "UPDATE Consumiciones "
                        sql &= "SET cantidad = cantidad + " & Me.txt_cantidad.Text & " "
                        sql &= "WHERE idAlojamiento = " & idAlojamientoSub & " "
                        sql &= "AND idArticulo = '" & Me.cmb_articulos.SelectedValue & "' "
                        sql &= "AND frigobar = 0"
                    End If
                Else
                    If chb_frigobar.CheckState = CheckState.Checked Then
                        If validarFrigobar() = True Then
                            sql &= "INSERT INTO Consumiciones (idAlojamiento,idArticulo,cantidad,frigobar) "
                            sql &= "VALUES ('" & idAlojamientoSub & "' "
                            sql &= ",'" & Me.cmb_articulos.SelectedValue & "' "
                            sql &= ",'" & Me.txt_cantidad.Text & "' "
                            sql &= ",'1')"
                        Else
                            Exit Sub
                        End If
                    Else
                        sql &= "INSERT INTO Consumiciones (idAlojamiento,idArticulo,cantidad,frigobar) "
                        sql &= "VALUES ('" & idAlojamientoSub & "' "
                        sql &= ",'" & Me.cmb_articulos.SelectedValue & "' "
                        sql &= ",'" & Me.txt_cantidad.Text & "' "
                        sql &= ",'0')"
                    End If
                End If
                acceso.nonQuery(sql)
                MessageBox.Show("Consumición agregada con éxito")
                Me.cargarGrilla()
                Me.restarStock()
            End If
        End If
    End Sub

    Private Sub cmd_limpiar_Click(sender As Object, e As EventArgs) Handles cmd_limpiar.Click
        txt_nroHabitacion.Text = ""
        Me.txt_apellido.Text = ""
        Me.txt_nombre.Text = ""
        Me.txt_documento.Text = ""
        Me.txt_tipoDocumento.Text = ""
        Me.txt_cantidad.Text = ""
        Me.txt_articuloSeleccionado.Text = ""
        Me.cmb_articulos.Enabled = False
        Me.grid_articulos.Enabled = False
        Me.grid_articulos.Rows.Clear()
        Me.cmd_borrar.Enabled = False
        Me.txt_nroHabitacion.ReadOnly = False
        idAlojamientoSub = -1
        idArticuloSub = -1
        cantidadSub = 0
        frigobarSub = ""
    End Sub

    Private Function validarBorrado() As Boolean
        If Me.txt_articuloSeleccionado.Text = "" Then
            MessageBox.Show("No se ha seleccionado ningún servicio", "Error", MessageBoxButtons.OK)
            Return False
        End If
        If Me.txt_cantidadBorrar.Text = "" Then
            MessageBox.Show("Ingrese una cantidad a borrar", "Error", MessageBoxButtons.OK)
            Return False
        End If
        If Me.txt_cantidadBorrar.Text > cantidadSub Then
            MessageBox.Show("Cantidad a borrar no válida", "Error", MessageBoxButtons.OK)
            Return False
        End If
        If idAlojamientoSub < 0 Then
            MessageBox.Show("No hay un idAlojamiento asociado. Consultar al programador", "Error", MessageBoxButtons.OK)
            Return False
        End If
        If idArticuloSub < 0 Then
            MessageBox.Show("No hay un idArticulo asociado. Consultar al programador", "Error", MessageBoxButtons.OK)
            Return False
        End If
        If cantidadSub < 0 Then
            MessageBox.Show("No hay una cantidadSub asociada. Consultar al programador", "Error", MessageBoxButtons.OK)
            Return False
        End If
        If frigobarSub = "" Then
            MessageBox.Show("No hay un frigobarSub asociado. Consultar al programador", "Error", MessageBoxButtons.OK)
            Return False
        End If
        Return True
    End Function

    Private Sub grid_articulos_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles grid_articulos.CellContentDoubleClick
        Me.txt_articuloSeleccionado.Text = Me.grid_articulos.CurrentRow.Cells("clm_articulo").Value
        idArticuloSub = Me.grid_articulos.CurrentRow.Cells("clm_idArticulo").Value
        cantidadSub = Me.grid_articulos.CurrentRow.Cells("clm_Cantidad").Value
        frigobarSub = Me.grid_articulos.CurrentRow.Cells("cln_frigobar").Value
        Me.cmd_borrar.Enabled = True
    End Sub

    Private Sub restaurarStock()
        Dim sql As String = ""
        Dim cant As Integer = txt_cantidadBorrar.Text

        sql &= "UPDATE Articulos "
        sql &= "SET stock = stock + " & cant & " "
        sql &= "WHERE idArticulo = " & idArticuloSub

        acceso.nonQuery(sql)
    End Sub

    Private Sub cmd_borrar_Click(sender As Object, e As EventArgs) Handles cmd_borrar.Click
        Dim sql As String = ""

        If Me.validarBorrado() = True Then
            If txt_cantidadBorrar.Text = cantidadSub Then
                sql &= "DELETE FROM Consumiciones "
                sql &= "WHERE idArticulo = '" & idArticuloSub & "' "
                sql &= "AND idAlojamiento = '" & idAlojamientoSub & "' "
                If frigobarSub = "SI" Then
                    sql &= "AND frigobar = 1"
                ElseIf frigobarSub = "NO" Then
                    sql &= "AND frigobar = 0"
                End If
            Else
                sql &= "UPDATE Consumiciones "
                sql &= "SET cantidad = cantidad - " & Me.txt_cantidadBorrar.Text
                sql &= "WHERE idArticulo = '" & idArticuloSub & "' "
                sql &= "AND idAlojamiento = '" & idAlojamientoSub & "' "
                If frigobarSub = "SI" Then
                    sql &= "AND frigobar = 1"
                ElseIf frigobarSub = "NO" Then
                    sql &= "AND frigobar = 0"
                End If

            End If

            acceso.nonQuery(sql)

            MessageBox.Show("Consumición eliminada con éxito")

            Me.txt_articuloSeleccionado.Text = ""
            Me.restaurarStock()
            idArticuloSub = -1
            Me.txt_cantidadBorrar.Text = ""
            Me.cmd_borrar.Enabled = False

            Me.cargarGrilla()
        End If
    End Sub

    Private Sub txt_cantidadBorrar_MouseClick(sender As Object, e As MouseEventArgs) Handles txt_cantidadBorrar.MouseClick
        If Me.txt_cantidadBorrar.Text = "" Then
            Me.txt_cantidadBorrar.SelectionStart = 0
        End If
    End Sub

    Private Sub txt_cantidad_MouseClick(sender As Object, e As MouseEventArgs) Handles txt_cantidad.MouseClick
        If Me.txt_cantidad.Text = "" Then
            Me.txt_cantidad.SelectionStart = 0
        End If
    End Sub

    Private Sub txt_nroHabitacion_MouseClick(sender As Object, e As MouseEventArgs) Handles txt_nroHabitacion.MouseClick
        If Me.txt_nroHabitacion.Text = "" Then
            Me.txt_nroHabitacion.SelectionStart = 0
        End If
    End Sub

    Private Sub cmd_cerrar_Click(sender As Object, e As EventArgs) Handles cmd_cerrar.Click
        Me.Close()
    End Sub
End Class