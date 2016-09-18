Public Class ABM_Proveedores
    Dim acceso As AccesoBD = AccesoBD.instancia
    Enum analizar_existencia
        existe
        no_existe
    End Enum
    Enum estado
        insertar
        modificar
    End Enum
    Dim condicion_estado As estado = estado.insertar

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
    Private Function validar_Existencia() As Boolean
        Dim sentenciaSQL As String = "SELECT * FROM Proveedores "
        sentenciaSQL &= "WHERE nombre = " & Me.txt_nombre.Text

        Dim tabla As DataTable = acceso.query(sentenciaSQL)


        If tabla.Rows.Count() = 0 Then
            Return analizar_existencia.no_existe
        Else
            Return analizar_existencia.existe
        End If
    End Function
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

    Private Sub insertar()
        Dim sentenciaSQL As String = "INSERT INTO Proveedores (nombre, correo, telefono) " _
           & "VALUES ('" & txt_nombre.Text & "', " & txt_correo.Text & ", '" & txt_telefono.Text & ")"

        acceso.nonQuery(sentenciaSQL)
        MessageBox.Show("Se registró exitosamente.")
    End Sub
    Private Sub modificar()
        Dim sentenciaSQL As String = ""
        sentenciaSQL &= "UPDATE Proveedores "
        sentenciaSQL &= "SET nombre = '" & Me.txt_nombre.Text & "'"
        sentenciaSQL &= " , correo = '" & Me.txt_correo.Text & "'"
        sentenciaSQL &= " , telefono = '" & Me.txt_telefono.Text

        acceso.nonQuery(sentenciaSQL)

        MessageBox.Show("Se modificó correctamente.")
    End Sub

    Private Sub ABM_Proveedores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Validar()
        cargarGrilla()
    End Sub
    Private Sub cmd_guardar_Click(sender As Object, e As EventArgs) Handles cmd_guardar.Click
        If Me.validar = True Then
            If condicion_estado = estado.insertar Then
                If Me.validar_existencia() = analizar_existencia.no_existe Then
                    Me.insertar()
                Else
                    MessageBox.Show("Ya existe este Tipo de Documento")
                    Exit Sub
                End If
            Else
                Me.modificar()
            End If

            Me.cmd_limpiar.PerformClick()
        End If


    End Sub
    Private Sub cmd_limpiar_Click(sender As Object, e As EventArgs) Handles cmd_limpiar.Click
        Me.condicion_estado = estado.insertar

        txt_correo.Text = ""
        txt_nombre.Text = ""
        txt_telefono.Text = ""
    End Sub

    Private Sub cmd_cancelar_Click(sender As Object, e As EventArgs) Handles cmd_cancelar.Click
        Me.Close()
    End Sub
    Private Sub cmd_borrar_Click(sender As Object, e As EventArgs) Handles cmd_borrar.Click
        Dim sql As String = "DELETE FROM Proveedores WHERE nombre = " & Me.txt_nombre.Text

        Dim tabla As DataTable = acceso.query(sql)
        MessageBox.Show("Se ha eliminado el proveedor Satisfactoriamente")
        Me.cmd_limpiar.PerformClick()
    End Sub
    Private Sub grid_proveedores_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles grid_proveedores.CellContentDoubleClick
        Dim sentenciaSQL As String = ""

        sentenciaSQL = "SELECT * FROM Proveedores WHERE nombre = '" & Me.grid_proveedores.CurrentRow.Cells("c_nombre").Value

        Dim tabla As DataTable = acceso.query(sentenciaSQL)

        If tabla.Rows.Count() = 0 Then
            MessageBox.Show("El Proveedor requerido no existe.")
            Exit Sub
        End If

        Me.cmd_borrar.Enabled = True
        'Me.cmd_borrar.Visible = True
        Me.cmd_guardar.Text = "Modificar"


        Me.txt_nombre.Text = tabla.Rows(0)("nombre")
        Me.txt_correo.Text = tabla.Rows(0)("correo")
        Me.txt_telefono.Text = tabla.Rows(0)("telefono")

        Me.condicion_estado = estado.modificar

    End Sub
End Class