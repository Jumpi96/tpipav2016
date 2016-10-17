Public Class AccesoBD
    Dim pCadenaConexion As String
    Dim conexion As Object
    Dim comando As Object
    Dim transaccion As Object
    Dim sentenciasTransaccionales As Collection


    Private Shared _instancia As AccesoBD = Nothing
    Private Shared ReadOnly sync As New Object

    Enum tipo_conexion
        simple
        transaccion
    End Enum


    'GETTER Y SETTER de cadena conexion
    Public Property cadenaConexion As String
        Get
            Return Me.pCadenaConexion
        End Get
        Set(ByVal cadena As String)
            Me.pCadenaConexion = cadena
        End Set
    End Property

    'SINGLETON
    Public Shared ReadOnly Property instancia As AccesoBD
        Get
            If _instancia Is Nothing Then
                SyncLock sync
                    If _instancia Is Nothing Then
                        _instancia = New AccesoBD
                        'MessageBox.Show("La conexion a la Base de Datos se realizo correctamente.")
                    End If
                End SyncLock
            End If
            Return _instancia
        End Get
    End Property


    'CONSTRUCTOR
    Public Sub New()
        Me.conexion = New OleDb.OleDbConnection
        Me.comando = New OleDb.OleDbCommand()


        Select Case Environment.MachineName
            Case "LAWEBSTORE-PC"
                Me.pCadenaConexion = "Provider=SQLNCLI11;Data Source=LAWEBSTORE-PC\SQLSERVER2014;Integrated Security=SSPI;Initial Catalog=hotelShaky"

            Case "DESKTOP-2BQ04QL"
                Me.pCadenaConexion = "Provider=SQLNCLI11;Data Source=DESKTOP-2BQ04QL;Integrated Security=SSPI;Initial Catalog=hotelShaky"

            Case "JULIETA"
                Me.pCadenaConexion = "Provider=SQLNCLI11;Data Source=JULIETA\JULIETA1;Integrated Security=SSPI;Initial Catalog=hotelShaky"

            Case "USUARIO-PC"
                Me.pCadenaConexion = "Provider=SQLNCLI11;Data Source=USUARIO-PC\SQLEXPRESS;Integrated Security=SSPI;Initial Catalog=hotelShaky"

            Case "PC-CHICA"
                Me.pCadenaConexion = "Provider=SQLNCLI11;Data Source=PC-CHICA\SQLEXPRESS;Integrated Security=SSPI;Initial Catalog=hotelShaky"

            Case "DESKTOP-D1R0BLD"
                Me.pCadenaConexion = "Provider=SQLNCLI11;Data Source=DESKTOP-D1R0BLD\SQLEXPRESS;Integrated Security=SSPI;Initial Catalog=hotelShaky"
        End Select
    End Sub


    Public Function query(ByVal sentenciaSQL As String) As DataTable
        Dim retorno As New DataTable
        Me.conectar(tipo_conexion.simple)
        Me.comando.CommandType = CommandType.Text
        Me.comando.CommandText = sentenciaSQL

        retorno.Load(comando.ExecuteReader())
        Me.cerrar()

        Return retorno
    End Function

    Public Sub nonQuery(ByVal sentenciaSQL As String)
        Me.conectar(tipo_conexion.simple)
        Me.comando.CommandType = CommandType.Text
        Me.comando.CommandText = sentenciaSQL
        Me.comando.ExecuteNonQuery()
        Me.cerrar()
    End Sub

    Public Function transaction(ByVal primeraSentenciaSQL As String, ByVal segundaSentenciaSQL As String) As String
        Dim retorno As String = ""

        Me.conectar(tipo_conexion.transaccion)
        Me.comando.CommandType = CommandType.Text

        Try
            Me.comando.CommandText = primeraSentenciaSQL
            Me.comando.ExecuteNonQuery()
            Me.comando.CommandText = segundaSentenciaSQL
            Me.comando.ExecuteNonQuery()
            Me.transaccion.commit()
        Catch ex As Exception
            Me.transaccion.rollback()
            retorno = ex.Message
        Finally
            Me.cerrar()
        End Try

        Return retorno
    End Function

    Public Function transaction(ByVal sentenciaSQL As String, ByVal commit As Boolean) As String
        Dim retorno As String = ""
        sentenciasTransaccionales.Add(sentenciaSQL)

        If commit Then
            Me.conectar(tipo_conexion.transaccion)
            Me.comando.CommandType = CommandType.Text

            Try
                For Each collectionItem As Object In sentenciasTransaccionales
                    Me.comando.CommandText = collectionItem.ToString
                    Me.comando.ExecuteNonQuery()
                Next collectionItem

                Me.transaccion.commit()
            Catch ex As Exception
                Me.transaccion.rollback()
                retorno = ex.Message
            Finally
                Me.sentenciasTransaccionales.Clear()
                Me.cerrar()
            End Try
        End If
        Return retorno
    End Function


    Public Sub cerrar()
        Me.conexion.Close()
    End Sub

    Private Sub conectar(ByVal tipoConexion As tipo_conexion)
        If Me.conexion.State.ToString <> "Open" Then

            Me.conexion.ConnectionString = Me.pCadenaConexion
            Me.conexion.Open()
            Me.comando.Connection = Me.conexion
            Me.comando.CommandType() = CommandType.Text

            If tipoConexion = tipo_conexion.transaccion Then

                Me.transaccion = Me.conexion.BeginTransaction()
                Me.comando.Transaction = Me.transaccion

            End If
        End If
    End Sub
End Class