﻿Public Class GestorFacturación
    Private accesoBD As New AccesoBD
    Private idAlojamiento As Integer

    Sub New(ByVal a As Integer)
        idAlojamiento = a
    End Sub

    Public Sub facturar(ByVal tF As Integer)
        Dim transaction As OleDb.OleDbTransaction
        Dim sentencia As String
        Dim tabla As New DataTable
        Dim idTipoFactura As Integer = tF
        Dim conexion As New OleDb.OleDbConnection
        Dim comando As New OleDb.OleDbCommand
        Dim subtotal As Double
        conexion.ConnectionString = accesoBD.cadenaConexion
        comando.CommandType = CommandType.Text
        conexion.Open()
        comando.Connection = conexion
        transaction = conexion.BeginTransaction()
        comando.Transaction = transaction

        Try
            'crear factura
            sentencia = "INSERT INTO facturas (idAlojamiento,tipoFactura,fechaEmision)"
            sentencia &= "VALUES(" & idAlojamiento & "," & idTipoFactura & ",'" & Date.Today() & "')"

            comando.CommandText = sentencia
            comando.ExecuteNonQuery()
            'accesoBD.transaction(sentencia, False)
            'accesoBD.nonQuery(sentencia)

            'actualiza fecha fin alojamiento

            sentencia = "UPDATE alojamientos SET fechaFinAlojamiento='" & Date.Today() & "' where idAlojamiento=" & idAlojamiento

            comando.CommandText = sentencia
            comando.ExecuteNonQuery()
            'accesoBD.transaction(sentencia, False)
            'accesoBD.nonQuery(sentencia)

            'crear detalles de factura
            '    a partir de consumiciones
            subtotal = 0
            Dim consumiciones As New DataTable

            sentencia = "SELECT F.nroFactura, F.tipoFactura, A.precioUnitario*C.cantidad, C.idConsumicion, GETDATE()"
            sentencia &= " FROM Consumiciones C JOIN Facturas F ON C.idAlojamiento=F.idAlojamiento"
            sentencia &= " JOIN Articulos A ON C.idArticulo=A.idArticulo"
            sentencia &= " WHERE F.idAlojamiento=" & idAlojamiento

            comando.CommandText = sentencia
            consumiciones.Load(comando.ExecuteReader())
            'consumiciones = accesoBD.query(sentencia)
            Dim contador As Integer = 1

            If consumiciones.Rows.Count() > 0 Then
                For i = 0 To consumiciones.Rows.Count() - 1
                    Dim fecha As Date = consumiciones.Rows(i)(4)
                    sentencia = "INSERT INTO DetallesXFactura (nroFactura,tipoFactura,subtotal,idConsumicion,fechaEmision,idRenglon) "
                    sentencia &= "VALUES(" & consumiciones.Rows(i)(0) & "," & consumiciones.Rows(i)(1)
                    sentencia &= "," & consumiciones.Rows(i)(2) & "," & consumiciones.Rows(i)(3)
                    sentencia &= ",'" & fecha.Date & "', " & (i + 1) & ")"
                    contador = contador + 1
                    subtotal = subtotal + consumiciones.Rows(i)(2)
                    'accesoBD.transaction(sentencia, False)
                    comando.CommandText = sentencia
                    comando.ExecuteNonQuery()
                    'accesoBD.nonQuery(sentencia)
                Next
            End If

            '    a partir de consumiciones
            Dim servicios As New DataTable

            sentencia = "SELECT F.nroFactura, F.tipoFactura, S.precioUnitario, C.idServicio, GETDATE()"
            sentencia &= " FROM ServiciosXAlojamiento C JOIN Facturas F ON C.idAlojamiento=F.idAlojamiento"
            sentencia &= " JOIN Servicios S ON C.idServicio=S.idServicio"
            sentencia &= " WHERE F.idAlojamiento=" & idAlojamiento

            comando.CommandText = sentencia
            servicios.Load(comando.ExecuteReader())
            'servicios = accesoBD.query(sentencia)

            If servicios.Rows.Count() > 0 Then
                For i = 0 To servicios.Rows.Count() - 1
                    Dim fecha As Date = servicios.Rows(i)(4)
                    sentencia = "INSERT INTO DetallesXFactura (nroFactura,tipoFactura,subtotal,idServicio,fechaEmision,idRenglon)"
                    sentencia &= " VALUES(" & servicios.Rows(i)(0) & "," & servicios.Rows(i)(1)
                    sentencia &= "," & servicios.Rows(i)(2) & "," & servicios.Rows(i)(3)
                    sentencia &= ",'" & fecha.Date & "', " & (contador + 1) & ")"
                    contador = contador + 1
                    subtotal = subtotal + servicios.Rows(i)(2)
                    'accesoBD.transaction(sentencia, False)
                    comando.CommandText = sentencia
                    comando.ExecuteNonQuery()
                    'accesoBD.nonQuery(sentencia)
                Next
            End If


            transaction.Commit()
            conexion.Close()
            Try
                sentencia = "SELECT DATEDIFF(day, fechaInicioAlojamiento, GETDATE()), precioPorDia"
                sentencia &= " from alojamientos where idAlojamiento=" & idAlojamiento
                Dim precio As New DataTable
                precio = accesoBD.query(sentencia)
                Dim precioDia As Double = precio.Rows(0)(1)
                Dim cantDias As Integer = precio.Rows(0)(0)
                Dim costoAloj As Double = precioDia * cantDias

                sentencia = "UPDATE facturas SET total=" & (subtotal + costoAloj) & " where idAlojamiento=" & idAlojamiento
                'accesoBD.transaction(sentencia, True)
                accesoBD.nonQuery(sentencia)

                sentencia = "SELECT nroFactura FROM Facturas WHERE idAlojamiento=" & idAlojamiento
                tabla = accesoBD.query(sentencia)
                Dim nro As Integer = tabla.Rows(0)(0)
                Dim imprFactura As New Impresion_Factura(nro, idTipoFactura)
                imprFactura.ShowDialog()
            Catch ex As Exception

            End Try
        Catch ex As Exception
            Try
                transaction.Rollback()
                conexion.Close()
            Catch ex2 As Exception
            End Try
        End Try

    End Sub

    Public Function existeFactura() As Boolean
        Dim sentencia As String = "SELECT * FROM facturas where idAlojamiento=" & idAlojamiento
        Dim tabla As DataTable = accesoBD.query(sentencia)

        Return tabla.Rows.Count() > 0
    End Function

    Public Sub leerFactura()
        Dim sentencia As String = "SELECT nroFactura, tipoFactura FROM Facturas WHERE idAlojamiento=" & idAlojamiento
        Dim tabla As DataTable = accesoBD.query(sentencia)
        Dim nro As Integer = tabla.Rows(0)(0)
        Dim idTipoFactura As Integer = tabla.Rows(0)(1)
        Dim imprFactura As New Impresion_Factura(nro, idTipoFactura)
        imprFactura.ShowDialog()
    End Sub
End Class
