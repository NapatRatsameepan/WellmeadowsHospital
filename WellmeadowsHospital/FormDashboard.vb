Imports Microsoft.Reporting.WinForms
Imports System.Data.SqlClient

Public Class FormDashboard
    Private connectionString As String = "Data Source=WARMACHINE\DATABASE62;Initial Catalog=Wellmeadows_Hospital;Integrated Security=True;Connect Timeout=30; User Instance=False"

    Private Sub FormDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadReport()
    End Sub

    Private Sub LoadReport()
        Try
            ' สร้าง DataTable เพื่อเก็บข้อมูลจากฐานข้อมูล
            Dim dt As New DataTable()

            ' เชื่อมต่อกับฐานข้อมูลและดึงข้อมูลจาก View_PatientSexCount
            Using conn As New SqlConnection(connectionString)
                Dim query As String = "SELECT * FROM View_PDashboard"  ' SQL Query เพื่อดึงข้อมูลจาก View
                Using cmd As New SqlCommand(query, conn)
                    conn.Open()
                    Dim da As New SqlDataAdapter(cmd)
                    da.Fill(dt)  ' ดึงข้อมูลจากฐานข้อมูลและใส่ลงใน DataTable
                End Using
            End Using

            ' สร้าง ReportDataSource สำหรับ ReportViewer
            Dim rds As New ReportDataSource("DataSet1", dt)  ' "View_PatientSexCount" ต้องตรงกับ DataSet ใน RDLC

            ' ตั้งค่าเส้นทางของ Report ที่จะใช้ใน ReportViewer
            Dim reportPath As String = Application.StartupPath & "\Reports\ReportPatient.rdlc"

            ' เคลียร์ DataSource เก่าแล้วเพิ่ม DataSource ใหม่
            ReportViewer1.LocalReport.DataSources.Clear()
            ReportViewer1.LocalReport.DataSources.Add(rds)

            ' โหลดรายงานและแสดงใน ReportViewer
            Me.ReportViewer1.RefreshReport()

        Catch ex As Exception
            MessageBox.Show("Error loading report: " & ex.Message)
        End Try
    End Sub
End Class
