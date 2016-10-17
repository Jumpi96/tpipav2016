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

        'crear detalles de ordenes
        '    a partir de articulos
        Dim contador As Integer = 1
        For i = 0 To tablaDetalles.Rows.Count() - 1

            sentencia = "INSERT INTO DetallesOrdenes (idOrden,idArticulo,cantidad,idRenglon)"
            sentencia &= " VALUES(" & idOrden & "," & tablaDetalles.Rows(i)(1)
            sentencia &= "," & tablaDetalles.Rows(i)(2) & "," & contador
            accesoBD.nonQuery(sentencia)

            contador = contador + 1
        Next
      

        'imprimir orden todo tuyo Juan


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

        Dim tablaArticulosCantidad As New DataTable
        Dim sentencia As String = ""

        sentencia = "SELECT D.idArticulo, D.cantidad"
        sentencia &= " FROM OrdenesCompra O JOIN DetallesOrdenes D ON O.idOrden = D.idOrden"
        sentencia &= " WHERE O.idOrden=" & idOrden

        tablaArticulosCantidad = accesoBD.query(sentencia)

        If tablaArticulosCantidad.Rows.Count > 0 Then

            For i = 0 To tablaArticulosCantidad.Rows.Count() - 1

                sentencia = "UPDATE articulos SET cantidad = cantidad + " & tablaArticulosCantidad.Rows(i)(1) & " WHERE idArticulo=" & tablaArticulosCantidad.Rows(i)(0)
                accesoBD.nonQuery(sentencia)

            Next

            sentencia = "UPDATE OrdenesCompra SET fechaRecepcion='" & Date.Today() & "' where idOrden=" & idOrden
            accesoBD.nonQuery(sentencia)

        End If

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
