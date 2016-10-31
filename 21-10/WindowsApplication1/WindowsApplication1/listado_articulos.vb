Public Class listado_articulos
    Dim cadenaDeConexion As String = "Provider=SQLNCLI11;Data Source=maquis;User ID=avisuales1;Initial Catalog=_PEDIDOS;Password=avisuales1"
    Private Sub listado_articulos_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        Me.impresion()

        Me.ReportViewer1.RefreshReport()
    End Sub
    Private Sub impresion()
        'Dim acceso As New acceso_datos_3k3 With {._cadena_conexion = cadenaDeConexion, ._nombre_tabla = "T_ARTICULOS"}
        'tabla = acceso.leo_tabla()
        Dim conexion As New Data.OleDb.OleDbConnection
        Dim cmd As New Data.OleDb.OleDbCommand
        Dim tabla As New DataTable
        Dim sql As String = ""
        sql = "SELECT * FROM T_ARTICULOS"
        conexion.ConnectionString = Me.cadenaDeConexion
        conexion.Open()
        cmd.Connection = conexion
        cmd.CommandType = CommandType.Text
        cmd.CommandText = sql
        tabla.Load(cmd.ExecuteReader)

        Me.LISTA_ARTICULOSBindingSource.DataSource = tabla




    End Sub
End Class
