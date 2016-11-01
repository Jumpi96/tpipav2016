Public Class FormListadoFacturas
    Dim accesoBD As AccesoBD = accesoBD.instancia
    Dim flagBusqDocumento As Boolean = False
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet.Facturas' table. You can move, or remove it, as needed.
        carga_combo(Me.cmbTipoDoc, Me.leo_tabla("TiposDocumento"), "idTipoDocumento", "nombre")
        imprimir("")
        Me.ReportViewer1.RefreshReport()
    End Sub
    Private Function leo_tabla(ByVal nombre_tabla As String) As Data.DataTable
        Return accesoBD.query("select * from " + nombre_tabla)
    End Function
    Private Sub imprimir(ByRef sqlWhere As String)
        Dim sql As String = ""
        sql &= "SELECT * FROM Facturas" + sqlWhere

    End Sub
    Private Sub carga_combo(ByRef combo As ComboBox, ByRef datos As Data.DataTable, ByVal pk As String, ByVal descripcion As String)
        combo.DataSource = datos
        combo.ValueMember = pk
        combo.DisplayMember = descripcion
    End Sub


    Private Sub btnBuscarPorDoc_Click(sender As Object, e As EventArgs) Handles btnBuscarPorDoc.Click
        If existeCliente() Then
            flagBusqDocumento = True
            imprimir("WHERE tipoDoc=" & cmbTipoDoc.SelectedValue & " AND nroDoc=" & txtNroDoc.Text)
        Else
            MessageBox.Show("No existe cliente.", "Error")
        End If
    End Sub
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

End Class