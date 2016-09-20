Public Class ABM_Clientes
    Dim acceso As AccesoBD = AccesoBD.instancia
    Dim cadena_conexion As String = AccesoBD.instancia.cadenaConexion

    Enum estado
        insertar
        modificar
    End Enum
    Dim condicion_estado As estado = estado.insertar

    Enum estadoBusqueda
        todo
        tipoDocumento
        nroDocumento
    End Enum

    'LOAD FORM
    Private Sub ABM_Clientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.cargarCombo("TiposDocumento", "idTipoDocumento", "nombre", Me.cmb_tipoDoc)
        Me.cargarGrilla(estadoBusqueda.todo)
    End Sub

#Region "Subrutinas"
    'CARGAR COMBO
    Private Sub cargarCombo(ByVal nombre_tabla As String, ByVal pk As String, ByVal descripcion As String, ByRef combo As ComboBox)
        Dim tabla As Data.DataTable = acceso.query("SELECT * FROM " + nombre_tabla)

        combo.DataSource = tabla
        combo.DisplayMember = descripcion
        combo.ValueMember = pk
    End Sub

    'CARGAR GRILLA
    Private Sub cargarGrilla(ByVal buscarEn As estadoBusqueda)
        Me.grid_clientes.Rows.Clear()

        Dim consultaSQL As String = "SELECT * FROM Clientes C JOIN TiposDocumento T ON  C.tipoDocumento = T.idTipoDocumento "

        If buscarEn = estadoBusqueda.tipoDocumento Then
            consultaSQL &= " WHERE tipoDocumento = " & Me.cmb_tipoDoc.SelectedValue

        ElseIf buscarEn = estadoBusqueda.nroDocumento Then
            consultaSQL &= " WHERE nroDocumento = " & Me.txt_nroDoc.Text & " AND tipoDocumento = " & Me.cmb_tipoDoc.SelectedValue
        End If

        Dim tabla As Data.DataTable = acceso.query(consultaSQL)

        Dim i As Integer
        For i = 0 To tabla.Rows.Count() - 1

            Me.grid_clientes.Rows.Add() 'current row es la fila actual y cell es la celda de esa fila
            Me.grid_clientes.Rows(i).Cells("col_nombre").Value = tabla.Rows(i)("nombre")
            Me.grid_clientes.Rows(i).Cells("col_apellido").Value = tabla.Rows(i)("apellido")
            Me.grid_clientes.Rows(i).Cells("col_tipoDocumento").Value = tabla.Rows(i)(7)
            Me.grid_clientes.Rows(i).Cells("col_nroDocumento").Value = tabla.Rows(i)("nroDocumento")
        Next
    End Sub

    'INSERTAR CLIENTE
    Private Sub insertar()
        Dim sentenciaSQL As String = "INSERT INTO Clientes (apellido, nombre, nroDocumento, tipoDocumento, fechaNacimiento, telefono) " _
           & "VALUES ('" & txt_apellido.Text & "', '" & txt_nombre.Text & "', " & txt_nroDoc.Text & ", '" & cmb_tipoDoc.SelectedValue & "', CONVERT(datetime,'" & date_fechaNacimiento.Value.Date & "',103) , '" & txt_telefono.Text & "')"
        'cast('" & date_fechaNacimiento.Value.Date & "' as datetime)
        'CONVERT(datetime,'" & date_fechaNacimiento.Value.Date & "',103)

        acceso.nonQuery(sentenciaSQL)
        MessageBox.Show("Se registró exitosamente.")
        Me.cargarGrilla(estadoBusqueda.todo)
    End Sub

    'BUSCAR CLIENTE
    Private Sub cmd_buscar_Click(sender As Object, e As EventArgs) Handles cmd_buscar.Click
        If Me.txt_nroDoc.Text = "" Then
            Me.cargarGrilla(estadoBusqueda.tipoDocumento)
        Else
            Me.cargarGrilla(estadoBusqueda.nroDocumento)
        End If
    End Sub

    'MODIFICAR CLIENTE
    Private Sub modificar()
        Dim sentenciaSQL As String = ""
        sentenciaSQL &= "UPDATE Clientes "
        sentenciaSQL &= "SET nombre = '" & Me.txt_nombre.Text & "'"
        sentenciaSQL &= " , apellido = '" & Me.txt_apellido.Text & "'"
        sentenciaSQL &= " , telefono = '" & Me.txt_telefono.Text & "'"
        sentenciaSQL &= " , fechaNacimiento = '" & Me.date_fechaNacimiento.Value.Date & "'"
        sentenciaSQL &= " WHERE nroDocumento = " & Me.txt_nroDoc.Text
        sentenciaSQL &= " AND tipoDocumento = " & Me.cmb_tipoDoc.SelectedValue

        acceso.nonQuery(sentenciaSQL)

        MessageBox.Show("Se modificó correctamente.")
        Me.cargarGrilla(estadoBusqueda.todo)
    End Sub



#End Region


#Region "Funciones"

    'VALIDAR
    Private Function Validar() As Boolean
        If txt_apellido.Text = "" Then
            MessageBox.Show("Debe completar el campo Apellido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            txt_apellido.Focus()
            Return False
        End If
        If txt_nombre.Text = "" Then
            MessageBox.Show("Debe completar el campo Nombre", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            txt_nombre.Focus()
            Return False
        End If
        If txt_nroDoc.Text = "" Then
            MessageBox.Show("Debe completar el campo Nro de Documento", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            txt_nroDoc.Focus()
            Return False
        End If
        If txt_telefono.Text = "" Then
            MessageBox.Show("Debe completar el campo Teléfono.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            txt_telefono.Focus()
            Return False
        End If
        If cmb_tipoDoc.SelectedIndex = -1 Then
            MessageBox.Show("Debe completar el campo Tipo de Documento.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            cmb_tipoDoc.Focus()
            Return False
        End If
        If date_fechaNacimiento.Value.CompareTo(Today) > 0 Then
            MessageBox.Show("La fecha de nacimiento no puede ser superior a la Fecha Actual.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            cmb_tipoDoc.Focus()
            Return False
        End If
        Return True
    End Function


    Private Function validarExistencia() As Boolean
        Dim sentenciaSQL As String = "SELECT * FROM Clientes "
        sentenciaSQL &= "WHERE tipoDocumento = " & Me.cmb_tipoDoc.SelectedValue & " AND nroDocumento = " & txt_nroDoc.Text

        Dim tabla As DataTable = acceso.query(sentenciaSQL)

        If tabla.Rows.Count() = 0 Then
            Return False
        Else
            Return True
        End If
    End Function

#End Region


#Region "CLICK"

    ' CLICK EN REGISTRAR
    Private Sub cmd_registrar_Click(sender As Object, e As EventArgs) Handles cmd_registrar.Click

        If Me.Validar = True Then
            If condicion_estado = estado.insertar Then
                If Me.validarExistencia() = False Then
                    Me.insertar()
                Else
                    MessageBox.Show("Ya existe este Cliente")
                    Exit Sub
                End If
            Else
                Me.modificar()

            End If
            Me.cmd_limpiar.PerformClick()
        End If
    End Sub

    'CLICK EN LIMPIAR
    Private Sub cmd_limpiar_Click(sender As Object, e As EventArgs) Handles cmd_limpiar.Click
        Me.condicion_estado = estado.insertar
        Me.txt_apellido.Text = ""
        Me.txt_nombre.Text = ""
        Me.txt_nroDoc.Text = ""
        Me.txt_telefono.Text = ""
        Me.date_fechaNacimiento.Value = Today
        Me.txt_nroDoc.Enabled = True
        Me.cmb_tipoDoc.Enabled = True
        Me.cargarGrilla(estadoBusqueda.todo)
        Me.cmd_registrar.Text = "Registrar"
        Me.cmd_borrar.Enabled = False
        Me.cmd_borrar.Visible = False
    End Sub

    'CLICK EN CANCELAR
    Private Sub cmd_cancelar_Click(sender As Object, e As EventArgs) Handles cmd_cancelar.Click
        Me.Close()
    End Sub

    'CLICK EN BORRAR
    Private Sub cmd_borrar_Click(sender As Object, e As EventArgs) Handles cmd_borrar.Click
        Dim sql As String = "DELETE FROM Clientes WHERE nroDocumento = " & Me.txt_nroDoc.Text
        sql &= " AND tipoDocumento = " & Me.cmb_tipoDoc.SelectedValue

        Dim tabla As DataTable = acceso.query(sql)
        MessageBox.Show("Se ha eliminado el tipo de Documento Satisfactoriamente")
        Me.cargarGrilla(estadoBusqueda.todo)
        Me.cmd_limpiar.PerformClick()
    End Sub

    'DOBLE CLICK SOBRE LA GRILLA
    Private Sub grid_clientes_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles grid_clientes.CellContentDoubleClick
        Dim sentenciaSQL As String = ""

        sentenciaSQL = "SELECT * FROM Clientes C JOIN TiposDocumento T ON  C.tipoDocumento = T.idTipoDocumento " _
            & "WHERE T.nombre = '" & Me.grid_clientes.CurrentRow.Cells("col_tipoDocumento").Value & "' AND C.nroDocumento = " & Me.grid_clientes.CurrentRow.Cells("col_nroDocumento").Value


        Dim tabla As DataTable = acceso.query(sentenciaSQL)

        If tabla.Rows.Count() = 0 Then
            MessageBox.Show("El cliente requerido no existe.")
            Exit Sub
        End If

        Me.cmd_borrar.Enabled = True
        'Me.cmd_borrar.Visible = True
        Me.cmd_registrar.Text = "Modificar"


        Me.txt_nroDoc.Text = tabla.Rows(0)("nroDocumento")
        Me.txt_apellido.Text = tabla.Rows(0)("apellido")
        Me.txt_nombre.Text = tabla.Rows(0)("nombre")
        Me.cmb_tipoDoc.SelectedValue = tabla.Rows(0)("idTipoDocumento")
        Me.txt_telefono.Text = tabla.Rows(0)("telefono")
        Me.date_fechaNacimiento.Value = tabla.Rows(0)("fechaNacimiento")


        Me.cmb_tipoDoc.Enabled = False
        Me.txt_nroDoc.Enabled = False
        Me.condicion_estado = estado.modificar
        Me.cmd_buscar.PerformClick()
    End Sub

    'CLICK EN NRODOCUMENTO
    Private Sub txt_nroDoc_MouseClick(sender As Object, e As MouseEventArgs) Handles txt_nroDoc.MouseClick
        If Me.txt_nroDoc.Text = "" Then
            Me.txt_nroDoc.SelectionStart = 0
        End If
    End Sub

    'CLICK EN NRODOCUMENTO
    Private Sub txt_telefono_MouseClick(sender As Object, e As MouseEventArgs) Handles txt_telefono.MouseClick
        If Me.txt_telefono.Text = "" Then
            Me.txt_telefono.SelectionStart = 0
        End If
    End Sub

#End Region

End Class