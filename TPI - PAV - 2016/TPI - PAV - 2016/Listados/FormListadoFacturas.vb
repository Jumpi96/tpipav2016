Imports Microsoft.Reporting.WinForms

Public Class FormListadoFacturas
    Dim accesoBD As AccesoBD = accesoBD.instancia
    Dim flagBusqDocumento As Integer
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet.Facturas' table. You can move, or remove it, as needed.
        carga_combo(Me.cmbTipoDoc, Me.leo_tabla("TiposDocumento"), "idTipoDocumento", "nombre")
        imprimir()
        Me.ReportViewer1.RefreshReport()
        Me.ReportViewer1.SetDisplayMode(DisplayMode.PrintLayout)
    End Sub
    Private Function leo_tabla(ByVal nombre_tabla As String) As Data.DataTable
        Return accesoBD.query("select * from " + nombre_tabla)
    End Function
    Private Sub imprimir()
        Dim sql As String = ""
        Dim text As String = ""
        If txtNroDoc.Text = "" Then
            flagBusqDocumento = 1
            text = 0
        Else
            flagBusqDocumento = 0
            text = txtNroDoc.Text
        End If
        sql &= "SELECT * FROM Facturas F JOIN ALOJAMIENTOS A ON F.IDALOJAMIENTO = A.IDALOJAMIENTO JOIN CLIENTES C ON A.NRODOC = C.NRODOCUMENTO AND A.TIPODOC = C.TIPODOCUMENTO WHERE (C.NRODOCUMENTO= " & text & "AND C.TIPODOCUMENTO=" & cmbTipoDoc.SelectedValue & ") OR 1=" & flagBusqDocumento
        Dim tabla As DataTable = accesoBD.query(sql)
        Me.FacturasBindingSource.DataSource = tabla
        Me.ReportViewer1.RefreshReport()
    End Sub
    Private Sub carga_combo(ByRef combo As ComboBox, ByRef datos As Data.DataTable, ByVal pk As String, ByVal descripcion As String)
        combo.DataSource = datos
        combo.ValueMember = pk
        combo.DisplayMember = descripcion
    End Sub


    Private Sub btnBuscarPorDoc_Click(sender As Object, e As EventArgs) Handles btnBuscarPorDoc.Click
        imprimir()
    End Sub

End Class