Public Class ABM_Alojamientos
    Dim string_conexion As String = "D:\Facultad\PAV\TP\tpipav2016\TPI - PAV - 2016\TPI - PAV - 2016\BD.mdf"

    Private Sub ABM_Alojamientos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        carga_combo(Me.cmbTipoDoc, Me.leo_tabla("TiposDocumentos"), "id_tipo_documento", "pk", "descripcion") 'completar
        carga_lista(Me.leo_alojamientos(null))
        'blanqueo fecha salida
        dtpSalida.Format = DateTimePickerFormat.Custom
        dtpSalida.CustomFormat = "    "
    End Sub
    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub
End Class