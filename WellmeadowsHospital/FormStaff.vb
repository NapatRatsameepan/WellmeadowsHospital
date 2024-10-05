Imports System.Data.SqlClient

Public Class FormStaff
    Private connectionString As String = "Data Source=WARMACHINE\DATABASE62;Initial Catalog=Wellmeadows_Hospital;Integrated Security=True;Connect Timeout=30; User Instance=False"
    Dim sqlConnection As New SqlConnection(connectionString)

    Private Sub FormStaff_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' โหลดข้อมูลลงใน ComboBox
        Me.PositionTableAdapter.Fill(Me.Wellmeadows_HospitalDataSet.Position)
        Me.Salary_ScaleTableAdapter.Fill(Me.Wellmeadows_HospitalDataSet.Salary_Scale)
    End Sub

    Private Sub BtnExpAdd_Click(sender As Object, e As EventArgs) Handles btnExpAdd.Click
        Try
            ' ตรวจสอบว่าข้อมูลถูกกรอกครบหรือไม่
            If String.IsNullOrEmpty(txtOrga.Text) OrElse String.IsNullOrEmpty(txtPosition.Text) Then
                Throw New Exception("กรุณากรอกข้อมูลให้ครบถ้วน")
            End If

            Dim Organization As String = txtOrga.Text
            Dim StfPosition As String = txtPosition.Text
            Dim StartDate As DateTime = Sdate.Value
            Dim EndDate As DateTime = Fdate.Value

            ' เพิ่มข้อมูลลงใน DataGridView
            dgvWorkExperience.Rows.Add(Organization, StfPosition, StartDate.ToString("yyyy-MM-dd"), EndDate.ToString("yyyy-MM-dd"))

            ' ล้างฟิลด์หลังจากเพิ่มข้อมูล
            txtOrga.Clear()
            txtPosition.Clear()
            Sdate.Value = DateTime.Now
            Fdate.Value = DateTime.Now
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BtnExpDelete_Click(sender As Object, e As EventArgs) Handles btnExpDelete.Click
        ' ตรวจสอบว่ามีแถวที่ถูกเลือกใน DataGridView หรือไม่
        If dgvWorkExperience.SelectedRows.Count > 0 Then
            ' ลบแถวที่ถูกเลือก
            dgvWorkExperience.Rows.RemoveAt(dgvWorkExperience.SelectedRows(0).Index)
        Else
            MessageBox.Show("กรุณาเลือกแถวที่ต้องการลบ")
        End If
    End Sub

    Private Sub BtnQuaAdd_Click(sender As Object, e As EventArgs) Handles btnQuaAdd.Click
        Try
            ' ตรวจสอบว่าข้อมูลถูกกรอกครบหรือไม่
            If String.IsNullOrWhiteSpace(txtQuaName.Text) OrElse String.IsNullOrWhiteSpace(txtInstitute.Text) Then
                Throw New Exception("กรุณากรอกข้อมูลให้ครบถ้วน")
            End If

            Dim qualificationName As String = txtQuaName.Text
            Dim institution As String = txtInstitute.Text
            Dim graduationDate As DateTime = GraduDate.Value

            ' เพิ่มข้อมูลลงใน DataGridView
            dgvQualification.Rows.Add(qualificationName, institution, graduationDate.ToString("yyyy-MM-dd"))

            ' ล้างฟิลด์หลังจากเพิ่มข้อมูล
            txtQuaName.Clear()
            txtInstitute.Clear()
            GraduDate.Value = DateTime.Now
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BtnQuaDelete_Click(sender As Object, e As EventArgs) Handles btnQuaDelete.Click
        If dgvQualification.SelectedRows.Count > 0 Then
            ' ลบแถวที่ถูกเลือก
            dgvQualification.Rows.RemoveAt(dgvQualification.SelectedRows(0).Index)
        Else
            MessageBox.Show("กรุณาเลือกแถวที่ต้องการลบ")
        End If
    End Sub

    Private Sub BtnStaffSubmit_Click(sender As Object, e As EventArgs) Handles btnStaffSubmit.Click
        Try
            ' ตรวจสอบว่ากรอกข้อมูลครบถ้วนหรือไม่
            If String.IsNullOrEmpty(txtStaffName.Text) OrElse
               String.IsNullOrEmpty(txtStaffLastName.Text) OrElse
               String.IsNullOrEmpty(txtCurrentSalary.Text) OrElse
               String.IsNullOrEmpty(txtStaffAddress.Text) OrElse
               String.IsNullOrEmpty(txtTel.Text) OrElse
               String.IsNullOrEmpty(txtNIN.Text) OrElse
               String.IsNullOrEmpty(txtHour.Text) Then
                MessageBox.Show("กรุณากรอกข้อมูลให้ครบ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            ' ตรวจสอบค่า Salary
            Dim salary As Integer
            If Not Int32.TryParse(txtCurrentSalary.Text, salary) Then
                MessageBox.Show("กรุณากรอกเงินเดือนเป็นตัวเลข", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            ' ตรวจสอบการเลือก Sex
            Dim Sex As String = ""
            If rbtnMale.Checked Then
                Sex = "Male"
            ElseIf rbtnFemale.Checked Then
                Sex = "Female"
            Else
                MessageBox.Show("กรุณาเลือก Sex", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            ' ตรวจสอบการเลือก Paid Type
            Dim paidType As String = ""
            If rdoWeekly.Checked Then
                paidType = "W"
            ElseIf rdoMonthly.Checked Then
                paidType = "M"
            Else
                MessageBox.Show("กรุณาเลือก Paid Type", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            ' ตรวจสอบการเลือก Contract Type
            Dim contractType As String = ""
            If rdoPermanent.Checked Then
                contractType = "P"
            ElseIf rdoTemporary.Checked Then
                contractType = "T"
            Else
                MessageBox.Show("กรุณาเลือก Contract Type", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            ' ยืนยันการลงทะเบียน
            Dim result As DialogResult = MessageBox.Show("คุณต้องการลงทะเบียนพนักงานใช่หรือไม่?", "ยืนยันการลงทะเบียน", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.Yes Then
                sqlConnection.Open()

                ' 1. Insert ข้อมูล Staff Information
                Dim insertStaffInfo As String = "INSERT INTO Staff (Staff_Name, Staff_Lastname, Sex, Staff_DOB, Address, Staff_Tel, NIN, Salary, Work_Hour_Per_Week, PaidType, ContractType, Position_ID, Scale_ID) " &
                                                "VALUES (@FirstName, @LastName, @Sex, @DOB, @Address, @Tel, @NIN, @Salary, @HoursWeek, @PaidType, @ContractType, @PositionID, @ScaleID); " &
                                                "SELECT SCOPE_IDENTITY();"

                Dim staffID As Integer = 0
                Using cmd As New SqlCommand(insertStaffInfo, sqlConnection)
                    cmd.Parameters.AddWithValue("@FirstName", txtStaffName.Text)
                    cmd.Parameters.AddWithValue("@LastName", txtStaffLastName.Text)
                    cmd.Parameters.AddWithValue("@Sex", Sex)
                    cmd.Parameters.AddWithValue("@DOB", dtpDOB.Value.ToString("yyyy-MM-dd")) ' แปลงเป็น yyyy-MM-dd
                    cmd.Parameters.AddWithValue("@Address", txtStaffAddress.Text)
                    cmd.Parameters.AddWithValue("@Tel", txtTel.Text)
                    cmd.Parameters.AddWithValue("@NIN", txtNIN.Text)
                    cmd.Parameters.AddWithValue("@Salary", salary)
                    cmd.Parameters.AddWithValue("@HoursWeek", Convert.ToInt32(txtHour.Text))
                    cmd.Parameters.AddWithValue("@PaidType", paidType)
                    cmd.Parameters.AddWithValue("@ContractType", contractType)
                    cmd.Parameters.AddWithValue("@PositionID", cboPosition.SelectedValue)
                    cmd.Parameters.AddWithValue("@ScaleID", cboSalaryScale.SelectedValue)

                    staffID = Convert.ToInt32(cmd.ExecuteScalar())
                End Using

                ' 2. Insert ข้อมูล Work Experience
                For Each row As DataGridViewRow In dgvWorkExperience.Rows
                    If Not row.IsNewRow Then
                        Dim startDate As DateTime
                        Dim endDate As DateTime
                        If DateTime.TryParse(row.Cells(2).Value.ToString(), startDate) AndAlso DateTime.TryParse(row.Cells(3).Value.ToString(), endDate) Then
                            Dim insertWorkExp As String = "INSERT INTO Work_Experience (Staff_ID, Organization, Position, EXP_Start_Date, EXP_Finish_Date) " &
                                                          "VALUES (@Staff_ID, @Organization, @Position, @StartDate, @EndDate)"
                            Using cmd As New SqlCommand(insertWorkExp, sqlConnection)
                                cmd.Parameters.AddWithValue("@Organization", row.Cells(0).Value)
                                cmd.Parameters.AddWithValue("@Position", row.Cells(1).Value)
                                cmd.Parameters.AddWithValue("@StartDate", startDate)
                                cmd.Parameters.AddWithValue("@EndDate", endDate)
                                cmd.Parameters.AddWithValue("@Staff_ID", staffID)
                                cmd.ExecuteNonQuery()
                            End Using
                        Else
                            MessageBox.Show("ข้อมูลวันที่ไม่ถูกต้อง กรุณาตรวจสอบวันที่ในข้อมูล Work Experience", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            Exit Sub
                        End If
                    End If
                Next

                ' 3. Insert ข้อมูล Qualification (วนลูปข้อมูลใน DataGridView)
                For Each row As DataGridViewRow In dgvQualification.Rows
                    If Not row.IsNewRow Then
                        Dim graduationDate As DateTime
                        ' ตรวจสอบวันที่ของ GraduationDate
                        If DateTime.TryParse(row.Cells(2).Value.ToString(), graduationDate) Then
                            Dim insertQualification As String = "INSERT INTO Qualification (Staff_ID, Qualification_Name, Graduation_Date, Institution_Name) " &
                                                                "VALUES (@Staff_ID, @QualificationName, @GraduationDate, @Institution)"
                            Using cmd As New SqlCommand(insertQualification, sqlConnection)
                                cmd.Parameters.AddWithValue("@QualificationName", row.Cells(0).Value)
                                cmd.Parameters.AddWithValue("@GraduationDate", graduationDate) ' ใช้ DateTime ที่แปลงแล้ว
                                cmd.Parameters.AddWithValue("@Institution", row.Cells(1).Value)
                                cmd.Parameters.AddWithValue("@Staff_ID", staffID)
                                cmd.ExecuteNonQuery()
                            End Using
                        Else
                            MessageBox.Show("ข้อมูลวันที่ไม่ถูกต้อง กรุณาตรวจสอบวันที่ในข้อมูล Qualification", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            Exit Sub
                        End If
                    End If
                Next

                ' แสดงข้อความเมื่อสำเร็จ
                MessageBox.Show("ข้อมูลถูกบันทึกเรียบร้อย", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                ' ถ้าผู้ใช้ตอบ No ให้หยุดการทำงาน
                MessageBox.Show("การลงทะเบียนถูกยกเลิก", "ยกเลิกการลงทะเบียน", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

            ' ล้างข้อมูลในฟิลด์ต่างๆ หลังจากบันทึกเสร็จ
            txtStaffName.Clear()
            txtStaffLastName.Clear()
            txtCurrentSalary.Clear()
            txtStaffAddress.Clear()
            txtTel.Clear()
            txtNIN.Clear()
            txtHour.Clear()

            rbtnMale.Checked = False
            rbtnFemale.Checked = False
            rdoWeekly.Checked = False
            rdoMonthly.Checked = False
            rdoPermanent.Checked = False
            rdoTemporary.Checked = False

            dtpDOB.Value = DateTime.Now
            cboPosition.SelectedIndex = -1
            cboSalaryScale.SelectedIndex = -1

            ' ล้างข้อมูลใน DataGridView
            dgvWorkExperience.Rows.Clear()
            dgvQualification.Rows.Clear()

        Catch ex As Exception
            MessageBox.Show("เกิดข้อผิดพลาด: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ' ปิดการเชื่อมต่อฐานข้อมูล
            If sqlConnection.State = ConnectionState.Open Then
                sqlConnection.Close()
            End If

        End Try
    End Sub

End Class

