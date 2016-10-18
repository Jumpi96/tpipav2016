﻿Public Class GestorOrden
    Private accesoBD As New AccesoBD
    Private idOrden As Integer = 0 'El id de orden lo tenes que obtener despues de haberla insertado en la BD
    Private tablaDetalles As DataTable
    Private idProveedor As Integer
    Private total As Double

    Sub New(ByRef t As DataTable, ByVal p As Integer, ByVal tot As Double)
        tablaDetalles = t
        idProveedor = p
        total = tot
    End Sub

    Sub New(ByVal id As Integer)
        idOrden = id
    End Sub

    Public Sub ordenar()

        'crear orden
        Dim sentencia As String = "INSERT INTO OrdenesCompra (idProveedor,fechaEmision,total)"
        sentencia &= "VALUES(" & idProveedor & ",'" & Date.Today() & "'," & total & ")"

        accesoBD.nonQuery(sentencia)

        'busca el nroOrden
        sentencia = "SELECT top 1 idOrden FROM OrdenesCompra ORDER BY 1 DESC"
        Dim tabla As DataTable = accesoBD.query(sentencia)
        idOrden = tabla.Rows(0)(0)

        'crear detalles de ordenes
        '    a partir de articulos
        Dim contador As Integer = 1

        For i = 0 To tablaDetalles.Rows.Count() - 1
            sentencia = "INSERT INTO DetallesOrdenes (idOrden,idArticulo,cantidad,idRenglon,subtotal)"
            sentencia &= " VALUES(" & idOrden & "," & tablaDetalles.Rows(i)(0)
            sentencia &= "," & tablaDetalles.Rows(i)(1) & "," & contador & "," & tablaDetalles.Rows(i)(2) & ")"
            accesoBD.nonQuery(sentencia)

            contador = contador + 1
        Next
      
        leerOrden()
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
        Dim n As New Impresion_Orden(idOrden)
        n.ShowDialog()
    End Sub
End Class
