Public Class GestorOrden
    Private accesoBD As New AccesoBD
    Private idOrden As Integer = 0 'El id de orden lo tenes que obtener despues de haberla insertado en la BD
    Private tablaDetalles As DataTable
    Private idProveedor As Integer
    Private total As Double

    Sub New(ByVal t As DataTable, ByVal p As Integer, ByVal tot As Double)
        tablaDetalles = t
        idProveedor = p
        total = tot
    End Sub

    Sub New(ByVal id As Integer)
        idOrden = id
    End Sub

    Public Sub ordenar()

        'crear orden
        Dim sentencia As String = "INSERT INTO OrdenesCompra (idOrden,idProveedor,fechaEmision)"  ' AGREGAR TOTAL
        sentencia &= "VALUES(" & idOrden & "," & idProveedor & ",'" & Date.Today() & "')"

        accesoBD.nonQuery(sentencia)

        'actualiza fecha fin alojamiento

        'sentencia = "UPDATE alojamientos SET fechaFinAlojamiento='" & Date.Today() & "' where idAlojamiento=" & idAlojamiento
        'accesoBD.nonQuery(sentencia)

        'crear detalles de ordenes
        '    a partir de articulos
        Dim articulos As New DataTable

        sentencia = "SELECT O.idOrden, D.cantidad, D.idRenglon, A.nombre, A.precioUnitario, A.idProveedor, GETDATE()"
        sentencia &= " FROM OrdenesCompra O JOIN DetallesOrdenes D ON O.idOrden=D.idOrden JOIN Aticulos A ON D.idArticulo=A.idArticulo"


        articulos = accesoBD.query(sentencia)
        Dim contador As Integer = 1

        'If articulos.Rows.Count() > 0 Then
        '    For i = 0 To consumiciones.Rows.Count() - 1
        '        Dim fecha As Date = consumiciones.Rows(i)(4)
        '        sentencia = "INSERT INTO DetallesXFactura (nroFactura,tipoFactura,subtotal,idConsumicion,fechaEmision,idRenglon) "
        '        sentencia &= "VALUES(" & consumiciones.Rows(i)(0) & "," & consumiciones.Rows(i)(1)
        '        sentencia &= "," & consumiciones.Rows(i)(2) & "," & consumiciones.Rows(i)(3)
        '        sentencia &= ",'" & fecha.Date & "', " & (i + 1) & ")"
        '        contador = contador + 1
        '        accesoBD.nonQuery(sentencia)
        '    Next
        'End If

        '    a partir de consumiciones
        'Dim servicios As New DataTable

        'sentencia = "SELECT F.nroFactura, F.tipoFactura, S.precioUnitario, C.idServicio, GETDATE()"
        'sentencia &= " FROM ServiciosXAlojamiento C JOIN Facturas F ON C.idAlojamiento=F.idAlojamiento"
        'sentencia &= " JOIN Servicios S ON C.idServicio=S.idServicio"
        'sentencia &= " WHERE F.idAlojamiento=" & idAlojamiento

        'servicios = accesoBD.query(sentencia)

        'If servicios.Rows.Count() > 0 Then
        '    For i = 0 To servicios.Rows.Count() - 1
        '        Dim fecha As Date = servicios.Rows(i)(4)
        '        sentencia = "INSERT INTO DetallesXFactura (nroFactura,tipoFactura,subtotal,idServicio,fechaEmision,idRenglon)"
        '        sentencia &= " VALUES(" & servicios.Rows(i)(0) & "," & servicios.Rows(i)(1)
        '        sentencia &= "," & servicios.Rows(i)(2) & "," & servicios.Rows(i)(3)
        '        sentencia &= ",'" & fecha.Date & "', " & (contador + 1) & ")"
        '        contador = contador + 1
        '        accesoBD.nonQuery(sentencia)
        '    Next
        'End If

        'Suma el total de la factura y actualiza
        sentencia = "SELECT SUM(D.cantidad*A.precioUnitario) FROM DetallesOrdenes D JOIN Articulos A ON D.idArticulo = A.idArticulo WHERE D.idOrden =" & idOrden
        Dim tabla As DataTable = accesoBD.query(sentencia)
        Dim subtotal As Double = tabla.Rows(0)(0)
        'sentencia = "SELECT DATEDIFF(day, fechaInicioAlojamiento, fechaFinAlojamiento), precioPorDia"
        'sentencia &= " from alojamientos where idAlojamiento=" & idAlojamiento
        'tabla = accesoBD.query(sentencia)
        'Dim precioDia As Double = tabla.Rows(0)(1)
        'Dim cantDias As Integer = tabla.Rows(0)(0)
        'Dim costoAloj As Double = precioDia * cantDias

        'sentencia = "UPDATE facturas SET total=" & (subtotal + costoAloj) & " where idAlojamiento=" & idAlojamiento
        'accesoBD.nonQuery(sentencia)

        'imprimir factura

        'sentencia = "SELECT nroFactura FROM Facturas WHERE idAlojamiento=" & idAlojamiento
        'tabla = accesoBD.query(sentencia)
        'Dim nro As Integer = tabla.Rows(0)(0)
        'Dim imprFactura As New Impresion_Factura(nro, idTipoFactura)
        'imprFactura.ShowDialog()

    End Sub

    Public Function recibirOrden() As Boolean
        If idOrden <> 0 Then
            Dim sentencia As String = "UPDATE OrdenesCompra SET fechaRecepcion=GETDATE() WHERE idOrden=" + idOrden
            accesoBD.nonQuery(sentencia)
            actualizarStock()
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub actualizarStock()
        'COMPLETAR
    End Sub

    Public Sub leerOrden()
        'Dim sentencia As String = "SELECT nroFactura, tipoFactura FROM Facturas WHERE idAlojamiento=" & idAlojamiento
        'Dim tabla As DataTable = accesoBD.query(sentencia)
        'Dim nro As Integer = tabla.Rows(0)(0)
        'Dim idTipoFactura As Integer = tabla.Rows(0)(1)
        'Dim imprFactura As New Impresion_Factura(nro, idTipoFactura)
        'imprFactura.ShowDialog()
    End Sub
End Class
