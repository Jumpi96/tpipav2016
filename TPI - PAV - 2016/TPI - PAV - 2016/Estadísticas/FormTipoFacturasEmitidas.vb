Public Class FormTipoFacturasEmitidas
    Private accesoBD As New AccesoBD
    Private Sub FormFacturasEmitidas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.imprimirEstadistica()

        Me.ReportViewer1.RefreshReport()
    End Sub
    Private Sub imprimirEstadistica()

        Dim sql As String = ""
        sql = "SELECT T.nombre as nombre, F.nroFactura,F.tipoFactura, COUNT(*) as cantidad FROM Facturas F JOIN TiposFactura T ON F.tipoFactura=T.idTipoFactura GROUP BY T.nombre, F.nroFactura,F.tipoFactura "
        Dim tabla As DataTable = accesoBD.query(sql)
        Me.ESTADISTICAFACTURASEMITIDASBindingSource.DataSource = tabla
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If txt_cantidad.Text = "" Then
            MessageBox.Show("Debe ingresar un valor", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Return
        End If

        Dim sql As String = ""
        sql = "SELECT T.nombre as nombre, F.nroFactura,F.tipoFactura, COUNT(*) as cantidad FROM Facturas F JOIN TiposFactura T ON F.tipoFactura=T.idTipoFactura GROUP BY T.nombre, F.nroFactura,F.tipoFactura HAVING COUNT(*)> " & txt_cantidad.Text

        Dim tabla As DataTable = accesoBD.query(sql)
        Me.ESTADISTICAFACTURASEMITIDASBindingSource.DataSource = tabla
    End Sub
End Class