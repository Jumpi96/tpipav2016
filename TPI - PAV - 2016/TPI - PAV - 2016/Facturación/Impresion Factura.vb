Imports Microsoft.Reporting.WinForms

Public Class Impresion_Factura
    Private idFactura As Integer
    Private idTipoFactura As Integer

    Private Sub Impresion_Factura_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim accesoBD As New AccesoBD
        Dim consulta As String = "SELECT Clientes.apellido, Clientes.nombre, Facturas.nroFactura,"
        consulta &= " Facturas.fechaEmision, Alojamientos.fechaFinAlojamiento, Alojamientos.fechaInicioAlojamiento,"
        consulta &= " Alojamientos.cantPersonas, Alojamientos.precioPorDia, Facturas.total, TiposFactura.nombre"
        consulta &= " AS Expr1 FROM TiposFactura INNER JOIN Facturas ON TiposFactura.idTipoFactura = Facturas.tipoFactura"
        consulta &= " CROSS JOIN Clientes INNER JOIN Alojamientos ON Clientes.nroDocumento = Alojamientos.nroDoc"
        consulta &= "AND Clientes.tipoDocumento = Alojamientos.tipoDoc WHERE Facturas.idFactura=" & idFactura
        consulta &= " AND Facturas.idTipoFactura=" & idTipoFactura
        Dim tabla As DataTable = accesoBD.query(consulta)

        Dim apellido As String = tabla.Rows(0)(0).Value
        Dim nombre As String = tabla.Rows(0)(1).Value
        Dim nroFactura As String = tabla.Rows(0)(2).Value
        Dim fecha As String = tabla.Rows(0)(3).Value
        Dim fechaFin As String = tabla.Rows(0)(4).Value
        Dim fechaInicio As String = tabla.Rows(0)(5).Value
        Dim personas As String = tabla.Rows(0)(6).Value
        Dim precioPorDia As String = tabla.Rows(0)(7).Value
        Dim total As String = tabla.Rows(0)(8).Value
        Dim tipoFactura As String = tabla.Rows(0)(9).Value

        Dim ap As ReportParameter = New ReportParameter("ClienteApellido", apellido)
        Dim no As ReportParameter = New ReportParameter("ClienteNombre", nombre)
        Dim nf As ReportParameter = New ReportParameter("NroFactura", nroFactura)
        Dim fe As ReportParameter = New ReportParameter("Fecha", fecha)
        Dim ff As ReportParameter = New ReportParameter("FechaFin", fechaFin)
        Dim fi As ReportParameter = New ReportParameter("FechaInicio", fechaInicio)
        Dim pe As ReportParameter = New ReportParameter("Personas", personas)
        Dim pr As ReportParameter = New ReportParameter("PrecioPorDia", precioPorDia)
        Dim tot As ReportParameter = New ReportParameter("Total", total)
        Dim ti As ReportParameter = New ReportParameter("TipoFactura", tipoFactura)

        ReportViewer1.LocalReport.SetParameters(New ReportParameter() {ap, no, nf, fe, ff, fi, pe, pr, tot, ti})
        Me.DataFacturasTableAdapter.Fill(Me.DataSet.DataFacturas, idFactura, idTipoFactura, idFactura, idTipoFactura)

        Me.ReportViewer1.RefreshReport()
    End Sub

    Public Sub New(ByVal idFac As Integer, ByVal idTipoFac As Integer)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        idFactura = idFac
        idTipoFactura = idTipoFac

    End Sub
End Class