Imports Microsoft.Reporting.WinForms

Public Class FormOcupacionMensual

    Private Sub FormOcupacionMensual_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargaCombo()
        imprimir()
    End Sub

    Private Sub cargaCombo()
        Dim i As Integer = 2016
        Dim j As Integer = 0
        While i <= Today.Year
            ComboBox1.Items.Insert(j, i)
            i = i + 1
            j = j + 1
        End While
        ComboBox1.SelectedIndex = 0
    End Sub

    Private Sub imprimir()
        Dim consulta As String = "SELECT MONTH(fechaInicioAlojamiento) AS Mes, COUNT(fechaInicioAlojamiento) AS Cantidad" _
        & " FROM Alojamientos WHERE YEAR(fechaInicioAlojamiento) = " & ComboBox1.SelectedItem & " GROUP BY fechaInicioAlojamiento"

        Dim accesoBD As New AccesoBD
        Dim tabla As New DataTable
        tabla = accesoBD.query(consulta)

        Me.OcupacionMensualBindingSource.DataSource = tabla

        Dim ap As ReportParameter = New ReportParameter("Anio", ComboBox1.SelectedItem.ToString)
        ReportViewer1.LocalReport.SetParameters(New ReportParameter() {ap})
        Me.ReportViewer1.RefreshReport()
        Me.ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        imprimir()
    End Sub
End Class