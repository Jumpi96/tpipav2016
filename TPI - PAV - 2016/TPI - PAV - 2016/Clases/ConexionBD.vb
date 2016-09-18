'Para acceder: Dim string_conexion As String = ConexionBD.Instancia.StringConexion
'Cuando todos lo tengamos funcionando podemos tener un metodo switch que dependiendo nombre de la maquina
' de cada uno devuelva el string correcto sin tener que cambiarlo cada vez que usamos

Public NotInheritable Class ConexionBD

    Private Shared _instancia As ConexionBD = Nothing
    Private Shared ReadOnly sync As New Object

    Private conexion As String = "Provider=SQLNCLI11;Data Source=USUARIO-PC\SQLEXPRESS;Integrated Security=SSPI;Initial Catalog=hotelShaky;Initial File Name=C:\Marcelo\Facultad\3º año\Programación de aplicaciones visuales\github\tpipav2016\BasedeDatosJu\hotelShaky.mdf"
    Public Property StringConexion() As String
        Get
            Return Me.conexion
        End Get
        Set(value As String)
            Me.conexion = value
        End Set
    End Property

    Private Sub New()

    End Sub

    Public Shared ReadOnly Property Instancia() As ConexionBD
        Get
            If _instancia Is Nothing Then
                SyncLock sync
                    If _instancia Is Nothing Then
                        _instancia = New ConexionBD()
                    End If
                End SyncLock
            End If
            Return _instancia
        End Get
    End Property


End Class
