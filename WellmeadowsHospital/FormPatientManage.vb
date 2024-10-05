Imports System.Data.SqlClient
Imports System.Windows.Forms.AxHost

Public Class FormPatientManage

    ' เชื่อมต่อฐานข้อมูล
    Private connectionString As String = "Data Source=WARMACHINE\DATABASE62;Initial Catalog=Wellmeadows_Hospital;Integrated Security=True;Connect Timeout=30; User Instance=False"
    ' ฟังก์ชันสำหรับดึงสถานะสมรสจากการเลือก RadioButton
    Private Function GetMaritalStatus() As String
        If rbtnSingle.Checked Then
            Return "Single"
        ElseIf rbtnMarried.Checked Then
            Return "Married"
        ElseIf rbtnDivorced.Checked Then
            Return "Divorced"
        ElseIf rbtnSeperated.Checked Then
            Return "Separated"
        ElseIf rbtnWidowed.Checked Then
            Return "Widowed"
        Else
            Return String.Empty
        End If
    End Function
    Private Sub BtnLD_Click(sender As Object, e As EventArgs) Handles btnLD.Click
        Dim searchForm As New FormLDsearch()
        If searchForm.ShowDialog() = DialogResult.OK Then
            ' รับข้อมูลจากฟอร์มค้นหาและแสดงใน TextBox
            txtLDFName.Text = searchForm.SelectedFirstName
            txtLDLName.Text = searchForm.SelectedLastName
            txtLDTEL.Text = searchForm.SelectedTel
            txtLDAddress.Text = searchForm.SelectedAddress
            txtClinicID.Text = searchForm.SelectedClinicID ' เก็บ Clinic_ID ของ Local Doctor
        End If

    End Sub

    Private Sub BtnPadd_Click(sender As Object, e As EventArgs) Handles btnPadd.Click
        Try
            ' ตรวจสอบว่าข้อมูลถูกกรอกครบหรือไม่
            If String.IsNullOrWhiteSpace(txtNPname.Text) OrElse String.IsNullOrWhiteSpace(txtNLname.Text) OrElse String.IsNullOrWhiteSpace(txtNPaddress.Text) OrElse String.IsNullOrWhiteSpace(txtNPtel.Text) OrElse String.IsNullOrWhiteSpace(txtNPRelationship.Text) Then
                Throw New Exception("กรุณากรอกข้อมูลให้ครบถ้วน")
            End If

            Dim NextOfkinName As String = txtNPname.Text
            Dim NextOfkinLastName As String = txtNLname.Text
            Dim NextOfKinAddress As String = txtNPaddress.Text
            Dim NexOfKinTel As String = txtNPtel.Text
            Dim NextOfKinRelationship As String = txtNPRelationship.Text

            ' เพิ่มข้อมูลลงใน DataGridView
            dgvNextOfKin.Rows.Add(NextOfkinName, NextOfkinLastName, NexOfKinTel, NextOfKinRelationship, NextOfKinAddress)

            ' ล้างฟิลด์หลังจากเพิ่มข้อมูล
            txtNPname.Clear()
            txtNLname.Clear()
            txtNPaddress.Clear()
            txtNPtel.Clear()
            txtNPRelationship.Clear()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BtnPdelete_Click(sender As Object, e As EventArgs) Handles btnPdelete.Click
        ' ตรวจสอบว่ามีแถวที่ถูกเลือกใน DataGridView หรือไม่
        If dgvNextOfKin.SelectedRows.Count > 0 Then
            ' ลบแถวที่ถูกเลือก
            dgvNextOfKin.Rows.RemoveAt(dgvNextOfKin.SelectedRows(0).Index)
        Else
            MessageBox.Show("กรุณาเลือกแถวที่ต้องการลบ")
        End If
    End Sub

    Private Sub BtnPSubmit_Click(sender As Object, e As EventArgs) Handles btnPSubmit.Click
        Try
            ' ตรวจสอบว่าข้อมูลผู้ป่วยถูกกรอกครบถ้วนหรือไม่
            If String.IsNullOrWhiteSpace(txtPname.Text) OrElse String.IsNullOrWhiteSpace(txtPLname.Text) OrElse String.IsNullOrWhiteSpace(txtPaddress.Text) Then
                Throw New Exception("กรุณากรอกข้อมูลผู้ป่วยให้ครบถ้วน")
            End If

            ' ตรวจสอบ Clinic_ID
            Dim clinicID As Long
            If String.IsNullOrWhiteSpace(txtClinicID.Text) Then
                MessageBox.Show("Clinic ID ว่าง", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            ElseIf Not Long.TryParse(txtClinicID.Text, clinicID) Then
                MessageBox.Show("Clinic ID ไม่ถูกต้อง", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            ' ตรวจสอบข้อมูลเพศ
            Dim Sex As String = ""
            If rbtnMale.Checked Then
                Sex = "Male"
            ElseIf rbtnFemale.Checked Then
                Sex = "Female"
            Else
                MessageBox.Show("กรุณาเลือก Sex", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            ' ตรวจสอบสถานะสมรส
            Dim Martial As String = GetMaritalStatus()
            If String.IsNullOrWhiteSpace(Martial) Then
                MessageBox.Show("กรุณาเลือกสถานะสมรส", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            ' เชื่อมต่อฐานข้อมูลและเพิ่มข้อมูลผู้ป่วย
            Using connection As New SqlConnection(connectionString)
                connection.Open()

                ' เพิ่มข้อมูลผู้ป่วย

                Dim insertPatientSQL As String = "INSERT INTO Patients (Patient_Name, Patient_Lastname, Address, Sex, Martial_Status, Patient_Tel, Patient_DOB, Clinic_ID) " &
                                                     "VALUES (@FirstName, @LastName, @Address, @Sex, @MaritalStatus, @Tel, @DateOfBirth, @ClinicID)" &
                                                     "SELECT SCOPE_IDENTITY();"

                    Dim PatientsID As Integer = 0
                    Using command As New SqlCommand(insertPatientSQL, connection)
                        command.Parameters.AddWithValue("@FirstName", txtPname.Text)
                        command.Parameters.AddWithValue("@LastName", txtPLname.Text)
                        command.Parameters.AddWithValue("@Address", txtPaddress.Text)
                        command.Parameters.AddWithValue("@Sex", Sex)
                        command.Parameters.AddWithValue("@MaritalStatus", Martial)
                        command.Parameters.AddWithValue("@Tel", txtPtel.Text)
                        command.Parameters.AddWithValue("@DateOfBirth", PDOB.Value.ToString("yyyy-MM-dd"))
                        command.Parameters.AddWithValue("@ClinicID", clinicID)

                        PatientsID = Convert.ToInt32(command.ExecuteScalar())

                    End Using


                    ' เพิ่มข้อมูล Next of Kin
                    Try
                    For Each row As DataGridViewRow In dgvNextOfKin.Rows
                        If Not row.IsNewRow Then
                            Dim insertNextOfKinSQL As String = "INSERT INTO Next_of_Kin (Kin_Name, Kin_Lastname, Kin_Tel, Address, Relationship, Patients_ID) " &
                                                               "VALUES (@FirstName, @LastName, @Tel, @Address, @Relationship, @PatientID)"
                            Using command As New SqlCommand(insertNextOfKinSQL, connection)
                                command.Parameters.AddWithValue("@FirstName", If(IsDBNull(row.Cells(0).Value), DBNull.Value, row.Cells(0).Value.ToString()))
                                command.Parameters.AddWithValue("@LastName", If(IsDBNull(row.Cells(1).Value), DBNull.Value, row.Cells(1).Value.ToString()))
                                command.Parameters.AddWithValue("@Tel", If(IsDBNull(row.Cells(2).Value), DBNull.Value, row.Cells(2).Value.ToString()))
                                command.Parameters.AddWithValue("@Relationship", If(IsDBNull(row.Cells(3).Value), DBNull.Value, row.Cells(3).Value.ToString()))
                                command.Parameters.AddWithValue("@Address", If(IsDBNull(row.Cells(4).Value), DBNull.Value, row.Cells(4).Value.ToString()))
                                command.Parameters.AddWithValue("@PatientID", PatientsID)

                                command.ExecuteNonQuery()
                            End Using
                        End If
                    Next
                Catch ex As Exception
                    MessageBox.Show("Error in inserting Next of Kin data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return
                End Try

                connection.Close()
                MessageBox.Show("บันทึกข้อมูลผู้ป่วยและ Next of Kin เรียบร้อยแล้ว")
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub




End Class
