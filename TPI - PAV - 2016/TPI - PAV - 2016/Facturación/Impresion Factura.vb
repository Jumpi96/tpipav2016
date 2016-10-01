Public Class Impresion_Factura
    Private idFactura As Integer
    Private idTipoFactura As Integer

    Private Sub Impresion_Factura_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'COMPLETAR pasaje de parametros

        'ReportParameter fi = new ReportParameter("TipoFactura", NOMBREFACTURA);

        'reportViewer1.LocalReport.SetParameters(new ReportParameter[] { fi })

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