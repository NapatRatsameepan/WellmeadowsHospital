Imports System.Data.SqlClient

Public Class FormExam
    Private connectionString As String = "Data Source=WARMACHINE\DATABASE62;Initial Catalog=Wellmeadows_Hospital;Integrated Security=True;Connect Timeout=30; User Instance=False"
    Dim sqlConnection As New SqlConnection(connectionString)

    ' ฟังก์ชันสำหรับตรวจสอบประเภทของผู้ป่วย (In-Patient หรือ Out-Patient)
    Private Function GetPatientType() As String
        If rbtnIP.Checked Then
            Return "In-Patient"
        ElseIf rbtnOPD.Checked Then
            Return "Out-Patient"
        Else
            Return String.Empty
        End If
    End Function

    ' เปิดฟอร์มค้นหาและรับค่ากลับจากการเลือก
    Private Sub BtnExamSearch_Click(sender As Object, e As EventArgs) Handles btnExamSearch.Click
        Dim searchForm As New FormExamSearch()
        If searchForm.ShowDialog() = DialogResult.OK Then
            AppID.Text = searchForm.SelectedAppID
            txtPatientID.Text = searchForm.SelectedPatientID
            txtPatientName.Text = searchForm.SelectedPatientName

            txtStaffName.Text = searchForm.SelectedStaffName
            lblStaffID.Text = searchForm.SelectedStaffID
        End If
    End Sub

    ' ฟังก์ชันอัปเดตข้อมูลการนัดหมาย
    Private Sub BtnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Try
            sqlConnection.Open()

            ' กำหนด SQL สำหรับอัปเดตข้อมูลการนัดหมาย
            Dim UpdateAppointment As String = "UPDATE Appointment " &
                                              "SET Exam_Results = @Result, Patient_Type = @PatientType " &
                                              "WHERE Appointment_ID = @AppointmentID"


            ' ใช้ SqlCommand เพื่อดำเนินการ SQL
            Using command As New SqlCommand(UpdateAppointment, sqlConnection)
                ' กำหนดค่าให้กับพารามิเตอร์ใน SQL
                command.Parameters.AddWithValue("@Result", txtExam.Text) ' ค่าผลการตรวจ
                command.Parameters.AddWithValue("@PatientType", GetPatientType()) ' ประเภทของผู้ป่วย
                command.Parameters.AddWithValue("@AppointmentID", CInt(AppID.Text)) ' Appointment_ID ที่ต้องการอัปเดต

                ' ดำเนินการอัปเดตข้อมูล
                Dim rowsAffected As Integer = command.ExecuteNonQuery()

                ' ตรวจสอบว่ามีการอัปเดตแถวใดบ้าง
                If rowsAffected > 0 Then
                    ' แสดงข้อความว่าตรวจโรคเสร็จสิ้นและยืนยันจากผู้ใช้
                    Dim result As DialogResult = MessageBox.Show("ตรวจโรคเสร็จสิ้น ต้องการดำเนินการต่อหรือไม่?", "ตรวจโรคสำเร็จ", MessageBoxButtons.YesNo, MessageBoxIcon.Information)

                    ' ตรวจสอบว่าเลือก In-Patient หรือ Out-Patient
                    If result = DialogResult.Yes Then
                        If GetPatientType() = "In-Patient" Then
                            Dim insertInPatient As String = "INSERT INTO Patients_Allocation (Date_Placed, Expected_Stays, Date_Leave, Actual_Leave, Patients_ID, Staff_ID, Bed_ID)" &
                                                            "VALUES (NULL, NULL, NULL, NULL, @PatientID, NULL, NULL)"

                            Using insertCommand As New SqlCommand(insertInPatient, sqlConnection)
                                insertCommand.Parameters.AddWithValue("@PatientID", CInt(txtPatientID.Text))

                                Dim insertResult As Integer = insertCommand.ExecuteNonQuery()

                                If insertResult > 0 Then
                                    ' เปิดหน้า FormInPatient ถ้า Insert สำเร็จ
                                    Dim FormInPatient As New FormInPatient()
                                    FormInPatient.Show()
                                Else
                                    MessageBox.Show("ไม่สามารถบันทึกข้อมูลผู้ป่วยในได้")
                                End If
                            End Using


                        ElseIf GetPatientType() = "Out-Patient" Then
                            ' Insert ข้อมูลลงในตาราง Ward_Allocation_OPD สำหรับ Out-Patient
                            Dim insertOutPatient As String = "INSERT INTO Ward_Allocation_OPD (OPD_appointment_Date, Ward_ID, Patients_ID) " &
                                                         "VALUES (NULL, NULL, @PatientID)"

                            Using insertCommand As New SqlCommand(insertOutPatient, sqlConnection)
                                insertCommand.Parameters.AddWithValue("@PatientID", CInt(txtPatientID.Text))

                                Dim insertResult As Integer = insertCommand.ExecuteNonQuery()

                                If insertResult > 0 Then
                                    ' เปิดหน้า FormOutPatient ถ้า Insert สำเร็จ
                                    Dim formOutPatient As New FormOutPatient()
                                    formOutPatient.Show()
                                Else
                                    MessageBox.Show("ไม่สามารถบันทึกข้อมูลผู้ป่วยนอกได้")
                                End If
                            End Using
                        End If
                    End If
                Else
                    MessageBox.Show("ไม่พบข้อมูลที่ต้องการอัปเดต")
                End If
            End Using

        Catch ex As Exception
            ' จัดการข้อผิดพลาดที่เกิดขึ้น
            MessageBox.Show("เกิดข้อผิดพลาด: " & ex.Message)
        Finally
            ' ปิดการเชื่อมต่อ SQL
            If sqlConnection.State = ConnectionState.Open Then
                sqlConnection.Close()
            End If
        End Try
    End Sub


End Class
