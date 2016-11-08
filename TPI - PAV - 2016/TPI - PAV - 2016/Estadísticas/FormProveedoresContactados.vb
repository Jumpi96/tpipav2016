Public Class FormProveedoresContactados
    Private accesoBD As New AccesoBD
    Private Sub FormProveedoresContactados_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.imprimirEstadistica()

        Me.ReportViewer1.RefreshReport()
    End Sub
    Private Sub imprimirEstadistica()

        Dim sql As String = ""
        sql = "SELECT P.NOMBRE AS nombreProveedor, COUNT(O.IdOrden) AS cantidad FROM PROVEEDORES P JOIN OrdenesCompra O ON P.idProveedor= O.idProveedor GROUP BY P.idProveedor,P.nombre "
        Dim tabla As DataTable = accesoBD.query(sql)
        Me.ESTADISTICAPROVEEDORESBindingSource.DataSource = tabla

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If txt_cantidad.Text = "" Then
            MessageBox.Show("Debe ingresar un valor", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Return
        End If

        Dim sql As String = ""
        sql = "SELECT P.NOMBRE AS nombreProveedor, COUNT(O.IdOrden) AS cantidad FROM PROVEEDORES P JOIN OrdenesCompra O ON P.idProveedor= O.idProveedor GROUP BY P.idProveedor HAVING COUNT(O.IdOrden)> " & txt_cantidad.Text


        Dim tabla As DataTable = accesoBD.query(sql)
        Me.ESTADISTICAPROVEEDORESBindingSource.DataSource = tabla
    End Sub
End Class