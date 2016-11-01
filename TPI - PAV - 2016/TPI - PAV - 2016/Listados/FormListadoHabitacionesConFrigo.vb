Imports Microsoft.Reporting.WinForms

Public Class FormListadoHabitacionesConFrigo
    Dim accesoBD As AccesoBD = accesoBD.instancia
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.impresion()
        Me.ReportViewer1.RefreshReport()
        Me.ReportViewer1.SetDisplayMode(DisplayMode.PrintLayout)
    End Sub
    Private Sub impresion()

        Dim sql As String = ""
        sql = "SELECT * FROM HABITACIONESXPISO"
        Dim tabla As DataTable = accesoBD.query(sql)
        Me.HabitacionesXPisoBindingSource.DataSource = tabla

    End Sub

   
    
    
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim sql As String = ""
        sql = "SELECT * FROM HABITACIONESXPISO"
        If aire.Checked And frigo.Checked Then
            sql = "SELECT * FROM HABITACIONESXPISO WHERE FRIGOBAR=1 and aireAcondicionado=1"
        Else
            If aire.Checked Then
                sql = "SELECT * FROM HABITACIONESXPISO WHERE aireAcondicionado=1"
            End If
            If frigo.Checked Then
                sql = "SELECT * FROM HABITACIONESXPISO WHERE FRIGOBAR=1"
            End If
        End If

        Dim tabla As DataTable = accesoBD.query(sql)
        Me.HabitacionesXPisoBindingSource.DataSource = tabla
        Me.ReportViewer1.RefreshReport()

    End Sub

  
End Class