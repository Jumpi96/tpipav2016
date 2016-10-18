Imports Microsoft.Reporting.WinForms

Public Class Impresion_Factura
    Private idFactura As Integer
    Private idTipoFactura As Integer

    Private Sub Impresion_Factura_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim accesoBD As New AccesoBD
        Dim consulta As String = "SELECT Clientes.apellido, Clientes.nombre, Facturas.nroFactura,"
        consulta &= " Facturas.fechaEmision, Alojamientos.fechaFinAlojamiento, Alojamientos.fechaInicioAlojamiento,"
        consulta &= " Alojamientos.cantPersonas, Alojamientos.precioPorDia, Facturas.total, TiposFactura.nombre AS tipoFactura"
        consulta &= " FROM TiposFactura JOIN Facturas ON TiposFactura.idTipoFactura = Facturas.tipoFactura JOIN Alojamientos"
		consulta &= " ON Alojamientos.idAlojamiento=Facturas.idAlojamiento JOIN"
        consulta &= " Clientes ON Clientes.nroDocumento=Alojamientos.nroDoc AND Clientes.tipoDocumento=Alojamientos.tipoDoc"
        consulta &= " WHERE Facturas.nroFactura=" & idFactura
        consulta &= " AND Facturas.tipoFactura=" & idTipoFactura
        Dim tabla As DataTable = accesoBD.query(consulta)

        Dim apellido As String = tabla.Rows(0)(0)
        Dim nombre As String = tabla.Rows(0)(1)
        Dim nroFactura As String = tabla.Rows(0)(2)
        While nroFactura.Length < 8
            nroFactura = "0" + nroFactura
        End While
        nroFactura = "0001-" + nroFactura
        Dim fecha As String = tabla.Rows(0)(3)
        Dim fechaFin As String = tabla.Rows(0)(4)
        Dim fechaInicio As String = tabla.Rows(0)(5)
        Dim personas As String = tabla.Rows(0)(6)
        Dim precioPorDia As String = tabla.Rows(0)(7)
        Dim total As String = tabla.Rows(0)(8)
        Dim tipoFactura As String = tabla.Rows(0)(9)

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
        Me.DataFacturasTableAdapter.Fill(Me.DataSet.DataFacturas, idTipoFactura, idFactura, idTipoFactura, idFactura, idTipoFactura, idFactura)

        Me.ReportViewer1.RefreshReport()
        Me.ReportViewer1.SetDisplayMode(DisplayMode.PrintLayout)
    End Sub

    Public Sub New(ByVal idFac As Integer, ByVal idTipoFac As Integer)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        idFactura = idFac
        idTipoFactura = idTipoFac

    End Sub
End Class