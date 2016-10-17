Imports Microsoft.Reporting.WinForms

Public Class Impresion_Orden
    Private idOrden As Integer

    Private Sub Impresion_Factura_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim accesoBD As New AccesoBD
        Dim consulta As String = "SELECT O.fechaEmision,O.fechaRecepcion,O.total,P.nombre"
        consulta &= "FROM OrdenesCompra O JOIN Proveedores P ON O.idProveedor=P.idProveedor"
        consulta &= "WHERE idOrden=" + idOrden

        Dim tabla As DataTable = accesoBD.query(consulta)

        Dim fechaEmision As String = tabla.Rows(0)(0)
        Dim fechaRecepcion As String = tabla.Rows(0)(1)
        Dim total As String = tabla.Rows(0)(2)
        Dim nombre As String = tabla.Rows(0)(3)
        Dim idOrdenMuestra As String = idOrden
        While idOrdenMuestra.Length < 8
            idOrdenMuestra = "0" + idOrdenMuestra
        End While

        Dim ap As ReportParameter = New ReportParameter("Proveedor", nombre)
        Dim no As ReportParameter = New ReportParameter("FechaRecepcion", fechaRecepcion)
        Dim nf As ReportParameter = New ReportParameter("Total", total)
        Dim fe As ReportParameter = New ReportParameter("NroOrden", idOrdenMuestra)
        Dim ff As ReportParameter = New ReportParameter("Fecha", fechaEmision)

        ReportViewer1.LocalReport.SetParameters(New ReportParameter() {ap, no, nf, fe, ff})
        Me.DataOrdenesTableAdapter.Fill(Me.DataSet.DataOrdenes, idOrden)

        Me.ReportViewer1.RefreshReport()
    End Sub

    Public Sub New(ByVal idO As Integer)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        idOrden = idO

    End Sub
End Class