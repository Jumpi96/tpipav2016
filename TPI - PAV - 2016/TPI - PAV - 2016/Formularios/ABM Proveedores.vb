Public Class ABM_Proveedores
    Dim acceso As AccesoBD = AccesoBD.instancia

    Enum estado
        insertar
        modificar
    End Enum
    Dim estadoInsercion As estado = estado.insertar

    'LOAD FORM
    Private Sub ABM_Proveedores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarGrilla()
        cmd_borrar.Visible = False

    End Sub


#Region "Subrutinas"

    'CARGAR GRILLA
    Private Sub cargarGrilla()
        Me.grid_proveedores.Rows.Clear()

        Dim consultaSQL As String = "SELECT * FROM Proveedores "

        Dim tabla As Data.DataTable = acceso.query(consultaSQL)

        Dim i As Integer
        For i = 0 To tabla.Rows.Count() - 1

            Me.grid_proveedores.Rows.Add() 'current row es la fila actual y cell es la celda de esa fila
            Me.grid_proveedores.Rows(i).Cells("c_idProveedor").Value = tabla.Rows(i)("idProveedor")
            Me.grid_proveedores.Rows(i).Cells("c_nombre").Value = tabla.Rows(i)("nombre")
            Me.grid_proveedores.Rows(i).Cells("c_correo").Value = tabla.Rows(i)("correo")
            Me.grid_proveedores.Rows(i).Cells("c_telefono").Value = tabla.Rows(i)("telefono")
        Next
    End Sub

    'INSERTAR
    Private Sub insertar()
        Dim sentenciaSQL As String = "INSERT INTO Proveedores (nombre, correo, telefono) "
        sentenciaSQL &= "VALUES ('" & txt_nombre.Text & "'"
        sentenciaSQL &= " , '" & txt_correo.Text & "'"
        sentenciaSQL &= " , " & txt_telefono.Text & ")"

        acceso.nonQuery(sentenciaSQL)
        MessageBox.Show("Se registró exitosamente.")
        Me.cargarGrilla()
    End Sub

    'MODIFICAR
    Private Sub modificar()
        Dim sentenciaSQL As String = ""
        sentenciaSQL &= "UPDATE Proveedores "
        sentenciaSQL &= "SET correo = '" & Me.txt_correo.Text & "'"
        sentenciaSQL &= " , telefono = " & txt_telefono.Text
        sentenciaSQL &= " WHERE nombre = '" & Me.txt_nombre.Text & "'"

        acceso.nonQuery(sentenciaSQL)

        MessageBox.Show("Se modificó correctamente.")
    End Sub



#End Region

#Region "Funciones"

    'VALIDAR CAMPOS
    Private Function Validar() As Boolean
        If txt_nombre.Text = "" Then
            MessageBox.Show("Debe completar el campo Nombre", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            txt_nombre.Focus()
            Return False
        End If
        If txt_correo.Text = "" Then
            MessageBox.Show("Debe completar el campo correo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            txt_correo.Focus()
            Return False
        End If
        If txt_telefono.Text = "" Then
            MessageBox.Show("Debe completar el campo telefono", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            txt_telefono.Focus()
            Return False
        End If
        Return True
    End Function

    'VALIDAR EXISTENCIA DE UN ELEMENTO
    Private Function validar_Existencia() As Boolean
        Dim sentenciaSQL As String = "SELECT * FROM Proveedores "
        sentenciaSQL &= "WHERE nombre = '" & Me.txt_nombre.Text & "'"

        Dim tabla As DataTable = acceso.query(sentenciaSQL)

        If tabla.Rows.Count() = 0 Then
            Return False
        Else
            Return True
        End If
    End Function



#End Region

#Region "BOTONES"

    'CLICK EN GUARDAR
    Private Sub cmd_guardar_Click(sender As Object, e As EventArgs) Handles cmd_guardar.Click
        If Me.Validar = True Then
            If estadoInsercion = estado.insertar Then
                If Me.validar_Existencia() = False Then
                    Me.insertar()
                Else
                    MessageBox.Show("Ya existe este Proveedor")
                    Exit Sub
                End If
            Else
                Me.modificar()
            End If

            Me.cmd_limpiar.PerformClick()
        End If
    End Sub

    'DOBLECLICK EN ELEMENTO DE LA GRILLA
    Private Sub grid_proveedores_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles grid_proveedores.CellDoubleClick
        Dim sentenciaSQL As String = ""

        sentenciaSQL = "SELECT * FROM Proveedores WHERE nombre = '" & Me.grid_proveedores.CurrentRow.Cells("c_nombre").Value & "'"
        Dim tabla As DataTable = acceso.query(sentenciaSQL)

        If tabla.Rows.Count() = 0 Then
            MessageBox.Show("El Proveedor requerido no existe.")
            Exit Sub
        End If

        Me.cmd_guardar.Text = "Modificar"
        Me.txt_nombre.Enabled = False
        Me.cmd_borrar.Visible = True

        Me.txt_nombre.Text = tabla.Rows(0)("nombre")
        Me.txt_correo.Text = tabla.Rows(0)("correo")
        Me.txt_telefono.Text = tabla.Rows(0)("telefono")

        Me.estadoInsercion = estado.modificar

        Me.grid_proveedores.Rows.Clear()

        Dim c As Integer = 0
        For c = 0 To tabla.Rows.Count - 1
            Me.grid_proveedores.Rows.Add()
            Me.grid_proveedores.Rows(c).Cells("c_idProveedor").Value = tabla.Rows(c)("idProveedor")
            Me.grid_proveedores.Rows(c).Cells("c_nombre").Value = tabla.Rows(c)("nombre")
            Me.grid_proveedores.Rows(c).Cells("c_correo").Value = tabla.Rows(c)("correo")
            Me.grid_proveedores.Rows(c).Cells("c_telefono").Value = tabla.Rows(c)("telefono")
        Next
    End Sub


    'CLICK EN LIMPIAR
    Private Sub cmd_limpiar_Click(sender As Object, e As EventArgs) Handles cmd_limpiar.Click
        Me.estadoInsercion = estado.insertar
        Me.txt_correo.Text = ""
        Me.txt_nombre.Text = ""
        Me.txt_telefono.Text = ""
        Me.cmd_guardar.Text = "Guardar"
        Me.txt_nombre.Enabled = True
        Me.cargarGrilla()
        cmd_borrar.Visible = False
    End Sub

    'CLICK EN CANCELAR
    Private Sub cmd_cancelar_Click(sender As Object, e As EventArgs) Handles cmd_cancelar.Click
        Me.Close()
    End Sub
#End Region

    Private Sub cmd_borrar_Click(sender As Object, e As EventArgs) Handles cmd_borrar.Click
        Try
            Dim sentenciaSQL As String = "DELETE FROM Proveedores WHERE idProveedor = " & Me.grid_proveedores.Rows(0).Cells("c_idProveedor").Value

            acceso.nonQuery(sentenciaSQL)

            MessageBox.Show("Se ha eliminado el Proveedor satisfactoriamente")
            Me.cargarGrilla()
            Me.cmd_limpiar.PerformClick()

        Catch ex As OleDb.OleDbException
            MessageBox.Show("El registro no puede eliminarse por tener otros registros relacionados.")
            acceso.cerrar()
        End Try
    End Sub
End Class