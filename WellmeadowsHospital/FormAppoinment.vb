Imports System.Data.SqlClient
Imports System.Runtime.InteropServices
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Button

Public Class FormAppoinment
    Private connectionString As String = "Data Source=WARMACHINE\DATABASE62;Initial Catalog=Wellmeadows_Hospital;Integrated Security=True;Connect Timeout=30; User Instance=False"
    Dim sqlConnection As New SqlConnection(connectionString)

    ' การค้นหาเจ้าหน้าที่ (Staff Search)
    Private Sub BtnStaffSearch_Click(sender As Object, e As EventArgs) Handles btnStaffSearch.Click
        Dim searchForm As New FormStaffSearch()
        If searchForm.ShowDialog() = DialogResult.OK Then
            lblStaffID.Text = searchForm.SelectedStaffID
            txtStaffName.Text = String.Format("{0} {1}", searchForm.SelectedFirstName, searchForm.SelectedLastName)
        End If
    End Sub

    ' การค้นหาผู้ป่วย (Patient Search)
    Private Sub btnPatientSearch_Click(sender As Object, e As EventArgs) Handles btnPatientSearch.Click
        Dim searchForm As New FormPatientApp()
        If searchForm.ShowDialog() = DialogResult.OK Then
            txtPatient.Text = searchForm.SelectedPatientID
            txtPatientName.Text = String.Format("{0} {1}", searchForm.SelectedFirstName, searchForm.SelectedLastName)
        End If
    End Sub

    ' การเพิ่มการนัดหมายลงในฐานข้อมูล (Submit Appointment)
    Private Sub BtnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Try
            sqlConnection.Open()

            ' กำหนด SQL สำหรับเพิ่มข้อมูลการนัดหมาย
            Dim insertAppoinmentSql As String = "INSERT INTO Appointment (Exam_Date, Appointment_Detail, Staff_ID, Patients_ID) " &
                                                "VALUES (@ExamDate, @AppDetail, @StaffID, @PatientID);"

            ' ใช้ SqlCommand เพื่อดำเนินการ SQL
            Using command As New SqlCommand(insertAppoinmentSql, sqlConnection)
                ' กำหนดค่าให้กับพารามิเตอร์ใน SQL
                command.Parameters.AddWithValue("@ExamDate", dtpExam.Value.ToString("yyyy-MM-dd"))
                command.Parameters.AddWithValue("@AppDetail", txtAppDetail.Text)
                command.Parameters.AddWithValue("@StaffID", CInt(lblStaffID.Text))  ' Staff ID ที่ได้จากการค้นหา
                command.Parameters.AddWithValue("@PatientID", CInt(txtPatient.Text)) ' Patient ID ที่ได้จากการค้นหา

                ' ดำเนินการเพิ่มข้อมูล
                command.ExecuteNonQuery()
            End Using
            txtPatient.Clear()
            txtAppDetail.Clear()
            txtPatientName.Clear()
            txtStaffName.Clear()
            dtpExam.Value = DateTime.Now

            ' แสดงข้อความเมื่อการเพิ่มข้อมูลสำเร็จ
            MessageBox.Show("นัดหมายเสร็จสิ้น")

        Catch ex As Exception
            ' จัดการข้อผิดพลาดที่เกิดขึ้น
            MessageBox.Show("An error occurred: " & ex.Message)
        Finally
            ' ปิดการเชื่อมต่อ SQL
            If sqlConnection.State = ConnectionState.Open Then
                sqlConnection.Close()
            End If
        End Try
    End Sub
End Class
