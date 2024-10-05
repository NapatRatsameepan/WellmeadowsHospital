Imports System.Data.SqlClient
Imports Microsoft.Reporting.WinForms

Public Class FormDashboardStaff
    Private connectionString As String = "Data Source=WARMACHINE\DATABASE62;Initial Catalog=Wellmeadows_Hospital;Integrated Security=True;Connect Timeout=30; User Instance=False"
    Dim sqlConnection As New SqlConnection(connectionString)
    Private Sub FormDashboardStaff_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Wellmeadows_HospitalDataSet.Allocation_To' table. You can move, or remove it, as needed.
        Me.Allocation_ToTableAdapter.Fill(Me.Wellmeadows_HospitalDataSet.Allocation_To)
        Me.ReportViewer1.RefreshReport()
        LoadReport()
    End Sub

    Private Sub LoadReport()
        Try
            ' สร้าง DataTable เพื่อเก็บข้อมูลจากฐานข้อมูล
            Dim dt As New DataTable()

            ' เชื่อมต่อกับฐานข้อมูลและดึงข้อมูลจาก View_PatientSexCount
            Using conn As New SqlConnection(connectionString)
                Dim query As String = "SELECT * FROM View_Staff2"  ' SQL Query เพื่อดึงข้อมูลจาก View
                Using cmd As New SqlCommand(query, conn)
                    conn.Open()
                    Dim da As New SqlDataAdapter(cmd)
                    da.Fill(dt)  ' ดึงข้อมูลจากฐานข้อมูลและใส่ลงใน DataTable
                End Using
            End Using

            ' สร้าง ReportDataSource สำหรับ ReportViewer
            Dim rds As New ReportDataSource("DataSet1", dt)  ' "View_PatientSexCount" ต้องตรงกับ DataSet ใน RDLC

            ' ตั้งค่าเส้นทางของ Report ที่จะใช้ใน ReportViewer
            Dim reportPath As String = Application.StartupPath & "\Reports\ReportStaff.rdlc"

            ' เคลียร์ DataSource เก่าแล้วเพิ่ม DataSource ใหม่
            ReportViewer1.LocalReport.DataSources.Clear()
            ReportViewer1.LocalReport.DataSources.Add(rds)

            ' โหลดรายงานและแสดงใน ReportViewer
            Me.ReportViewer1.RefreshReport()

        Catch ex As Exception
            MessageBox.Show("Error loading report: " & ex.Message)
        End Try
    End Sub

    ' จับเหตุการณ์การเลือกแถวใน DataGridView
    Private Sub DataGridView1_SelectionChanged(sender As Object, e As EventArgs) Handles DataGridView1.SelectionChanged
        ' ตรวจสอบว่ามีแถวที่เลือกใน DataGridView หรือไม่
        If DataGridView1.SelectedRows.Count > 0 Then
            ' ดึงค่า Ward_Allocation_ID จากแถวที่เลือก
            Dim selectedWardAllocationID As Integer = Convert.ToInt32(DataGridView1.SelectedRows(0).Cells(0).Value)

            ' เรียกใช้ฟังก์ชันเพื่อดึงข้อมูลที่ต้องการแสดงใน Report
            LoadStaffAllocationReport(selectedWardAllocationID)
        End If
    End Sub

    ' ฟังก์ชันสำหรับดึงข้อมูลพนักงานที่ถูกจัดสรรตาม Ward_Allocation_ID ที่เลือก
    Private Sub LoadStaffAllocationReport(wardAllocationID As Integer)
        ' สร้าง SQL Query เพื่อดึงข้อมูลพนักงานที่ถูกจัดสรรสำหรับ Ward_Allocation_ID ที่เลือก
        Dim query As String = "SELECT * FROM View_Staff2 WHERE Ward_Allocation_ID = @Ward_Allocation_ID"

        ' สร้าง connection และ data adapter สำหรับการดึงข้อมูล
        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand(query, connection)
                ' กำหนดค่า parameter สำหรับ Ward_Allocation_ID
                command.Parameters.AddWithValue("@Ward_Allocation_ID", wardAllocationID)

                ' ดึงข้อมูลลง DataSet
                Dim adapter As New SqlDataAdapter(command)
                Dim ds As New DataSet()
                adapter.Fill(ds, "StaffAllocation")

                ' ผูกข้อมูลกับ ReportViewer
                Dim reportDataSource As New ReportDataSource("DataSet1", ds.Tables("StaffAllocation"))
                ReportViewer1.LocalReport.DataSources.Clear()
                ReportViewer1.LocalReport.DataSources.Add(reportDataSource)
                ReportViewer1.RefreshReport()
            End Using
        End Using
    End Sub

End Class