Imports Microsoft.Reporting.WinForms

Public Class FormListadoProveedores
    Dim accesoBD As AccesoBD = accesoBD.instancia
    Private Sub FormListadoProveedores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.impresion()

        Me.ReportViewer1.RefreshReport()
        Me.ReportViewer1.SetDisplayMode(DisplayMode.PrintLayout)
    End Sub
    Private Sub impresion()

        Dim sql As String = ""
        sql = "SELECT * FROM PROVEEDORES"
        Dim tabla As DataTable = accesoBD.query(sql)
        Me.ProveedoresBindingSource.DataSource = tabla
    End Sub


End Class