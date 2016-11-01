Imports Microsoft.Reporting.WinForms

Public Class FormListadoArticulos
    Dim accesoBD As AccesoBD = accesoBD.instancia
    Private Sub FormListadoArticulos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.cargar_combo()

        Me.impresion()
        Me.ReportViewer1.RefreshReport()
        Me.ReportViewer1.SetDisplayMode(DisplayMode.PrintLayout)
    End Sub

    Private Sub impresion()

        Dim sql As String = ""
        sql = "SELECT * FROM ARTICULOS"
        Dim tabla As DataTable = accesoBD.query(sql)
        Me.ArticulosBindingSource.DataSource = tabla
    End Sub

    Private Sub ReportViewer1_Load(sender As Object, e As EventArgs) Handles ReportViewer1.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim sql As String = ""
        sql = "SELECT * FROM ARTICULOS WHERE idproveedor=" & cmb_proveedor.SelectedValue
        Dim tabla As DataTable = accesoBD.query(sql)
        Me.ArticulosBindingSource.DataSource = tabla
        Me.ReportViewer1.RefreshReport()
    End Sub
    Private Sub cargar_combo()
        Dim sentenciaSQL As String = "SELECT * FROM Proveedores"
        Dim tabla As DataTable = accesoBD.query(sentenciaSQL)

        cmb_proveedor.DataSource = tabla
        cmb_proveedor.DisplayMember = "nombre"
        cmb_proveedor.ValueMember = "idProveedor"

    End Sub
End Class