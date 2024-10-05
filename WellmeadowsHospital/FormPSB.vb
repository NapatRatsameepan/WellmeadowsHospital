Imports System.Data.SqlClient

Public Class FormPSB
    Private connectionString As String = "Data Source=WARMACHINE\DATABASE62;Initial Catalog=Wellmeadows_Hospital;Integrated Security=True;Connect Timeout=30; User Instance=False"
    Dim sqlConnection As New SqlConnection(connectionString)
    Private Sub FormPSB_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Wellmeadows_HospitalDataSet.Drug' table. You can move, or remove it, as needed.
        Me.DrugTableAdapter.Fill(Me.Wellmeadows_HospitalDataSet.Drug)

    End Sub

    Private Sub BtnPatientSearch_Click(sender As Object, e As EventArgs) Handles btnPatientSearch.Click
        Dim searchForm As New FormPAllocation()
        If searchForm.ShowDialog() = DialogResult.OK Then

            txtPatientsID.Text = searchForm.SelectedPatientID
            txtPatientName.Text = searchForm.SelectedPatientName

            txtWardID.Text = searchForm.SelectedWardID
            txtWardName.Text = searchForm.SelectedWardName

            txtBedID.Text = searchForm.SelectedBedID

        End If
    End Sub

    Private Sub BtnStaffSearch_Click(sender As Object, e As EventArgs) Handles btnStaffSearch.Click
        Dim searchForm As New FormStaffSearch()
        If searchForm.ShowDialog() = DialogResult.OK Then

            lblStaffID.Text = searchForm.SelectedStaffID
            txtStaffName.Text = searchForm.SelectedFirstName & " " & searchForm.SelectedLastName
        End If
    End Sub

    Private Sub DataGridView4_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView4.CellDoubleClick
        If e.RowIndex >= 0 Then
            ' ดึงข้อมูลจากแถวที่ถูกเลือก
            Dim selectedRow As DataGridViewRow = DataGridView4.Rows(e.RowIndex)

            ' แสดงข้อมูลใน TextBox ตามคอลัมน์ต่าง ๆ ของตาราง Drug
            txtDrugID.Text = selectedRow.Cells(0).Value.ToString()
            txtDrugName.Text = selectedRow.Cells(1).Value.ToString()
            ' คุณสามารถเพิ่ม TextBox อื่นๆ ที่ต้องการให้แสดงข้อมูลได้
        End If
    End Sub

    Private Sub BtnADD_Click(sender As Object, e As EventArgs) Handles btnADD.Click
        ' ตรวจสอบว่า Drug ID และ Drug Name ไม่ว่าง
        If String.IsNullOrEmpty(txtDrugID.Text) Or String.IsNullOrEmpty(txtDrugName.Text) Then
            MessageBox.Show("กรุณาเลือกยาที่ต้องการเพิ่ม", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' สร้างแถวใหม่ใน DataGridView ของ Prescribe List
        Dim row As String() = New String() {
        txtDrugID.Text,                  ' Drug ID
        txtDrugName.Text,                ' Drug Name
        txtUnitPerDay.Text,              ' Units Per Day
        dtpStartDate.Value.ToString("dd-MM-yyyy"),   ' Start Date
        dtpFinishDate.Value.ToString("dd-MM-yyyy")   ' Finish Date
    }

        ' เพิ่มแถวลงใน DataGridView
        DataGridViewPrescribeList.Rows.Add(row)

        ' ล้างข้อมูลใน TextBox เพื่อพร้อมสำหรับการเพิ่มรายการถัดไป
        txtDrugID.Text = ""
        txtDrugName.Text = ""
        txtUnitPerDay.Text = ""
        dtpStartDate.Value = DateTime.Now
        dtpFinishDate.Value = DateTime.Now
    End Sub


    Private Sub BtnDELETE_Click(sender As Object, e As EventArgs) Handles btnDELETE.Click
        ' ตรวจสอบว่าได้เลือกแถวใน DataGridView แล้วหรือไม่
        If DataGridViewPrescribeList.SelectedRows.Count > 0 Then
            ' ลบแถวที่เลือกออกจาก DataGridView
            For Each row As DataGridViewRow In DataGridViewPrescribeList.SelectedRows
                DataGridViewPrescribeList.Rows.Remove(row)
            Next
        Else
            MessageBox.Show("กรุณาเลือกแถวที่ต้องการลบ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub


    Private Sub BtnSUBMIT_Click(sender As Object, e As EventArgs) Handles btnSUBMIT.Click
        Try
            ' เปิดการเชื่อมต่อกับฐานข้อมูล
            If sqlConnection.State = ConnectionState.Closed Then
                sqlConnection.Open()
            End If

            ' เริ่มการ transaction
            Using transaction = sqlConnection.BeginTransaction()
                Try
                    ' ตรวจสอบว่า Patient ID และ Staff ID ถูกต้องก่อนเริ่มการ Insert ข้อมูล
                    Dim patientID As Integer
                    Dim staffID As Integer

                    If Not Integer.TryParse(txtPatientsID.Text, patientID) Then
                        MessageBox.Show("กรุณากรอก Patient ID ที่ถูกต้อง", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Return
                    End If

                    If Not Integer.TryParse(lblStaffID.Text, staffID) Then
                        MessageBox.Show("กรุณากรอก Staff ID ที่ถูกต้อง", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Return
                    End If

                    ' Insert ข้อมูลลงในตาราง Prescribe
                    Dim queryPrescribe As String = "INSERT INTO Prescribe (Patients_ID, Staff_ID) OUTPUT INSERTED.Prescribe_ID VALUES (@Patients_ID, @Staff_ID)"
                    Dim prescribeID As Integer

                    Using command As New SqlCommand(queryPrescribe, sqlConnection, transaction)
                        command.Parameters.AddWithValue("@Patients_ID", patientID)
                        command.Parameters.AddWithValue("@Staff_ID", staffID)
                        prescribeID = Convert.ToInt32(command.ExecuteScalar())
                    End Using

                    ' Loop ผ่าน DataGridViewPrescribeList เพื่อ Insert ข้อมูลลงในตาราง PrescribedDrug
                    For Each row As DataGridViewRow In DataGridViewPrescribeList.Rows
                        If Not row.IsNewRow Then
                            Dim drugID As Integer = Convert.ToInt32(row.Cells(0).Value)
                            Dim unitsPerDay As Integer = Convert.ToInt32(row.Cells(2).Value)

                            ' แปลงค่าข้อมูลวันที่จาก DataGridView โดยใช้ ParseExact
                            Dim startDate As DateTime = DateTime.ParseExact(row.Cells(3).Value.ToString(), "dd-MM-yyyy", Nothing)
                            Dim endDate As DateTime = DateTime.ParseExact(row.Cells(4).Value.ToString(), "dd-MM-yyyy", Nothing)

                            ' คำนวณจำนวนวันที่สั่งยาทั้งหมด
                            Dim totalDays As Integer = (endDate - startDate).Days + 1 ' บวก 1 เพื่อรวมวันเริ่มต้น

                            ' คำนวณจำนวนรวมของยาที่ต้องใช้
                            Dim totalUnitsRequired As Integer = unitsPerDay * totalDays

                            ' ตรวจสอบจำนวนยาที่เหลือในสต็อก
                            Dim queryCheckStock As String = "SELECT Drug_Quantity_in_stock FROM Drug WHERE Drug_ID = @DrugID"
                            Dim currentStock As Integer

                            Using commandCheckStock As New SqlCommand(queryCheckStock, sqlConnection, transaction)
                                commandCheckStock.Parameters.AddWithValue("@DrugID", drugID)
                                currentStock = Convert.ToInt32(commandCheckStock.ExecuteScalar())
                            End Using

                            ' หากจำนวนในสต็อกน้อยกว่าที่ต้องใช้ ให้แสดงข้อความเตือนและยกเลิก
                            If currentStock < totalUnitsRequired Then
                                MessageBox.Show("ยามีจำนวนไม่เพียงพอในสต็อก", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                transaction.Rollback()
                                Return
                            End If

                            ' หากยามีเพียงพอ ลบจำนวนจากสต็อก
                            Dim queryUpdateStock As String = "UPDATE Drug SET Drug_Quantity_in_stock = Drug_Quantity_in_stock - @UnitsUsed WHERE Drug_ID = @DrugID"
                            Using commandUpdateStock As New SqlCommand(queryUpdateStock, sqlConnection, transaction)
                                commandUpdateStock.Parameters.AddWithValue("@UnitsUsed", totalUnitsRequired)
                                commandUpdateStock.Parameters.AddWithValue("@DrugID", drugID)
                                commandUpdateStock.ExecuteNonQuery()
                            End Using

                            ' Insert ข้อมูลลงในตาราง PrescribedDrug
                            Dim queryPrescribedDrug As String = "INSERT INTO PrescribedDrug (Units_per_day, Start_date, End_Date, Prescribe_ID, Drug_ID) VALUES (@UnitsPerDay, @StartDate, @EndDate, @PrescribeID, @DrugID)"
                            Using command As New SqlCommand(queryPrescribedDrug, sqlConnection, transaction)
                                command.Parameters.AddWithValue("@UnitsPerDay", unitsPerDay)
                                command.Parameters.AddWithValue("@StartDate", startDate)
                                command.Parameters.AddWithValue("@EndDate", endDate)
                                command.Parameters.AddWithValue("@PrescribeID", prescribeID)
                                command.Parameters.AddWithValue("@DrugID", drugID)
                                command.ExecuteNonQuery()
                            End Using
                        End If
                    Next

                    ' Commit การ transaction
                    transaction.Commit()
                    MessageBox.Show("บันทึกข้อมูลสำเร็จ", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    Me.DrugTableAdapter.Fill(Me.Wellmeadows_HospitalDataSet.Drug)

                    DataGridViewPrescribeList.Rows.Clear() ' เคลียร์ DataGridView หลังจากบันทึกสำเร็จ

                Catch ex As Exception
                    ' Rollback การ transaction หากมีข้อผิดพลาด
                    transaction.Rollback()
                    MessageBox.Show("เกิดข้อผิดพลาดในการบันทึกข้อมูล: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End Using

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