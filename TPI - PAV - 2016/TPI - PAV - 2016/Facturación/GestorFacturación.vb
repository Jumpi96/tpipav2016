Public Class GestorFacturación
    Dim accesoBD As New AccesoBD
    Private idAlojamiento As Integer
    Private idTipoFactura As Integer

    Sub New(ByVal a As Integer, ByVal tF As Integer)
        idAlojamiento = a
        idTipoFactura = tF
    End Sub

    Public Sub facturar()
        'crear factura
        Dim sentencia As String = "INSERT INTO facturas (idAlojamiento,tipoFactura,fechaEmision)"
        sentencia &= "VALUES(" & idAlojamiento & "," & idTipoFactura & "," & Date.Today() & ")"

        accesoBD.nonQuery(sentencia)

        'actualiza fecha fin alojamiento

        sentencia = "UPDATE alojamientos SET fechaFinAlojamiento=" & Date.Today() & "where idAlojamiento=" & idAlojamiento
        accesoBD.nonQuery(sentencia)

        'crear detalles de factura
        '    a partir de consumiciones
        Dim consumiciones As New DataTable

        sentencia = "SELECT F.nroFactura, F.tipoFactura, A.precioUnitario*C.cantidad, C.idConsumicion, GETDATE()"
        sentencia &= " FROM Consumiciones C JOIN Facturas F ON C.idAlojamiento=F.idAlojamiento"
        sentencia &= " JOIN Articulos A ON C.idArticulo=A.idArticulo"
        sentencia &= " WHERE F.idAlojamiento=" & idAlojamiento

        consumiciones = accesoBD.query(sentencia)

        For i = 0 To consumiciones.Rows.Count()
            sentencia = "INSERT INTO DetallesXFactura (nroFactura,tipoFactura,subtotal,idConsumicion,fechaEmision"
            sentencia &= "VALUES(" & consumiciones.Rows(i)(0).Value & "," & consumiciones.Rows(i)(1).Value
            sentencia &= "," & consumiciones.Rows(i)(2).Value & "," & consumiciones.Rows(i)(3).Value
            sentencia &= "," & consumiciones.Rows(i)(4).Value
            accesoBD.nonQuery(sentencia)
        Next

        '    a partir de consumiciones
        Dim servicios As New DataTable

        sentencia = "SELECT F.nroFactura, F.tipoFactura, S.precioUnitario, C.idServicio, GETDATE()"
        sentencia &= " FROM ServiciosXAlojamiento C JOIN Facturas F ON C.idAlojamiento=F.idAlojamiento"
        sentencia &= " JOIN Servicios S ON C.idServicio=S.idServicio"
        sentencia &= " WHERE F.idAlojamiento=" & idAlojamiento

        For i = 0 To consumiciones.Rows.Count()
            sentencia = "INSERT INTO DetallesXFactura (nroFactura,tipoFactura,subtotal,idServicio,fechaEmision"
            sentencia &= "VALUES(" & servicios.Rows(i)(0).Value & "," & servicios.Rows(i)(1).Value
            sentencia &= "," & servicios.Rows(i)(2).Value & "," & servicios.Rows(i)(3).Value
            sentencia &= "," & servicios.Rows(i)(4).Value
            accesoBD.nonQuery(sentencia)
        Next

        'Suma el total de la factura y actualiza
        sentencia = "SELECT SUM(subtotal) FROM DetallesXFactura WHERE idAlojamiento=" & idAlojamiento
        Dim tabla As DataTable = accesoBD.query(sentencia)

        sentencia = "UPDATE facturas SET total=" & tabla.Rows(0)(0).Value & " where idAlojamiento=" & idAlojamiento


        'imprimir factura

        sentencia = "SELECT nroFactura FROM Facturas WHERE idAlojamiento=" & idAlojamiento
        tabla = accesoBD.query(sentencia)
        Dim nro As Integer = tabla.Rows(0)(0).Value
        Dim imprFactura As New Impresion_Factura(nro, idTipoFactura)
        imprFactura.ShowDialog()

    End Sub
End Class
