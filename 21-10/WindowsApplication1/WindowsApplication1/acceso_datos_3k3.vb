'Imports MySql.Data.MySqlClient
Public Class acceso_datos_3k3
    Enum motores
        sqlserver
        mysql
        oracle
    End Enum
    Enum tipo_conexion
        simple
        transanccion
    End Enum
    Enum resultado
        _ok
        _error
    End Enum

    Dim configuracion_conexion As tipo_conexion = tipo_conexion.simple

    Dim cadena_conexion As String = ""
    Dim conexion As Object
    Dim cmd As Object
    Dim transaccion As Object

    Dim motor As motores = motores.sqlserver
    Dim nombre_tabla As String = ""
    Dim UltimoError As String = ""
    Dim control_transaccion As resultado = resultado._ok

    Public Property _nombre_tabla As String
        Get
            Return nombre_tabla
        End Get
        Set(ByVal value As String)
            nombre_tabla = value
        End Set
    End Property
    Public Property _motor As motores
        Get
            Return motor
        End Get
        Set(ByVal value As motores)
            motor = value
            Me.configurar_motor()
        End Set
    End Property

    Public Property _cadena_conexion As String
        Get
            Return cadena_conexion
        End Get
        Set(ByVal value As String)
            cadena_conexion = value
        End Set
    End Property
 
    Public Function Consulta(ByVal sql As String) As DataTable
        Return ejecutar(sql)
    End Function
    Public Function leo_tabla() As DataTable
        Return ejecutar("SELECT * FROM " & Me.nombre_tabla)
    End Function
    Public Function leo_tabla(ByVal nombre_tabla As String) As DataTable
        Return ejecutar("SELECT * FROM " & nombre_tabla)
    End Function
    Private Function ejecutar(ByRef sql As String) As DataTable
        Dim tabla As New DataTable
        Me.conectar()
        cmd.CommandText = sql
        tabla.Load(cmd.ExecuteReader())
        Me.cerrar()
        Return tabla
    End Function
    Public Sub conexion_con_transaccion()
        Me.configuracion_conexion = tipo_conexion.transanccion
        Me.control_transaccion = resultado._ok
    End Sub
    Public Sub cerrar_con_transaccion()
        If control_transaccion = resultado._ok Then
            Me.transaccion.Commit()
        Else
            Me.transaccion.RollBack()
        End If
        Me.conexion.Close()
        Me.configuracion_conexion = tipo_conexion.simple
    End Sub
    Public Function insertar(ByVal datos As String) As resultado
        Dim igual, coma, columna As Integer
        Dim valor As String
        Dim txt_datos As String = datos.ToUpper
        Dim tabla As New DataTable
        Dim nom_col As String
        Dim cabecera As String = ""
        Dim paquete_datos As String = ""
        Dim tipoDato As String
        Dim sqlinsert As String = ""

        tabla = Me.estructura_tabla()

        Dim c As Integer

        For c = 0 To tabla.Columns.Count - 1
            nom_col = tabla.Columns(c).Caption.ToUpper
            columna = txt_datos.IndexOf(nom_col)
            If columna = -1 Then
                Continue For
            End If
            igual = txt_datos.IndexOf("=", columna)
            coma = txt_datos.IndexOf(",", columna)
            If coma = -1 Then
                valor = txt_datos.Substring(igual + 1)
            Else
                valor = txt_datos.Substring(igual + 1, coma - igual - 1)
            End If

            tipoDato = tabla.Columns(c).DataType.Name

            If cabecera = "" Then
                cabecera = cabecera + nom_col
                paquete_datos = paquete_datos + Me.formatear(valor, tipoDato)
            Else
                cabecera = cabecera + ", " + nom_col
                paquete_datos = paquete_datos + ", " + Me.formatear(valor, tipoDato)
            End If
        Next
        sqlinsert = "INSERT INTO " & Me.nombre_tabla _
                    & " (" & cabecera & ") VALUES (" _
                    & paquete_datos & ")"

        'MessageBox.Show(sqlinsert)

        If resultado._ok = Me.conectar() Then
            Me.cmd.CommandText = sqlinsert
            Try
                Me.cmd.ExecuteNonQuery()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
                Me.control_transaccion = resultado._error
                Me.cerrar()
                Return resultado._error
            End Try
            Me.cerrar()
            Return resultado._ok
        End If

    End Function
    Private Function formatear(ByVal dato As String, ByVal tipodato As String) As String
        Select Case tipodato
            Case "String"
                Return "'" + dato + "'"
            Case Else
                Return dato
        End Select
    End Function
    Private Function estructura_tabla() As DataTable
        Select Case Me.motor
            Case motores.sqlserver
                Return Me.ejecutar("select top 1 *  from " & Me.nombre_tabla)
        End Select
        Return New DataTable
    End Function

    Private Sub cerrar()
        If configuracion_conexion = tipo_conexion.simple Then
            Me.conexion.Close()
        End If
    End Sub
    Private Sub configurar_motor()
        Select Case Me.motor
            Case motores.sqlserver
                Me.conexion = New OleDb.OleDbConnection
                Me.cmd = New OleDb.OleDbCommand
                'Case motores.mysql
                '    Me.conexion = New MySqlConnection
                '    Me.cmd = New MySqlCommand
        End Select
    End Sub
    Private Function conectar() As resultado

        If conexion.State.ToString <> "Open" Then
            conexion.ConnectionString = cadena_conexion

            Try
                conexion.Open()
            Catch ex As Exception
                MessageBox.Show("Error al Intentar conectar", "Error Grave")
                Me.UltimoError = ex.Message
                Return resultado._error
            End Try

            cmd.Connection = conexion
            cmd.CommandType = CommandType.Text

            If Me.configuracion_conexion = tipo_conexion.transanccion Then
                Me.transaccion = conexion.BeginTransaction()
                cmd.Transaction = Me.transaccion
            End If
        End If
        Return resultado._ok
    End Function
End Class
