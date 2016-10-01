Public Class AccesoBD
    Private pCadenaConexion As String
    Private conexion As Object
    Private comando As Object

    Private Shared _instancia As AccesoBD = Nothing
    Private Shared ReadOnly sync As New Object


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
                Me.pCadenaConexion = "Provider=SQLNCLI11;Data Source=JULIETA\JULIETA;Integrated Security=SSPI;Initial Catalog=hotelShaky"

            Case "PC-CHICA"
                Me.pCadenaConexion = "Provider=SQLNCLI11;Data Source=PC-CHICA\SQLEXPRESS;Integrated Security=SSPI;Initial Catalog=hotelShaky"


        End Select
    End Sub


    Public Function query(ByVal sentenciaSQL As String) As DataTable
        Dim retorno As New DataTable
        Me.conectar()
        Me.comando.CommandType = CommandType.Text
        Me.comando.CommandText = sentenciaSQL

        retorno.Load(comando.ExecuteReader())
        Me.cerrar()

        Return retorno
    End Function

    Public Sub nonQuery(ByVal sentenciaSQL As String)
        Me.conectar()
        Me.comando.CommandType = CommandType.Text
        Me.comando.CommandText = sentenciaSQL
        Me.comando.ExecuteNonQuery()
        Me.cerrar()
    End Sub

    Public Sub cerrar()
        Me.conexion.Close()
    End Sub

    Private Sub conectar()
        Me.conexion.ConnectionString = Me.pCadenaConexion
        Me.conexion.Open()
        Me.comando.Connection = Me.conexion
        Me.comando.CommandType() = CommandType.Text
    End Sub
End Class
