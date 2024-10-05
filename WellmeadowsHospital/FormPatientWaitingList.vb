Imports System.Data.SqlClient

Public Class FormPatientWaitingList

    Private connectionString As String = "Data Source=WARMACHINE\DATABASE62;Initial Catalog=Wellmeadows_Hospital;Integrated Security=True;Connect Timeout=30; User Instance=False"
    Dim sqlConnection As New SqlConnection(connectionString)
    Private Sub FormPatientWaitingList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Wellmeadows_HospitalDataSet.Waiting_List_3' table. You can move, or remove it, as needed.
        Me.Waiting_List_3TableAdapter.Fill(Me.Wellmeadows_HospitalDataSet.Waiting_List_3)
    End Sub

    Private Sub BtnBedSearch_Click(sender As Object, e As EventArgs) Handles btnBedSearch.Click
        Dim searchForm As New FormBedAllocation()
        If searchForm.ShowDialog() = DialogResult.OK Then
            txtBedID.Text = searchForm.SelectedBedID
            txtWardID.Text = searchForm.SelectedWardID
            txtWardName.Text = searchForm.SelectedWardName

            txtLocation.Text = searchForm.SelectedLocation
            txtTel.Text = searchForm.SelectedTel
        End If
    End Sub

    Private Sub DataGridView6_SelectionChanged(sender As Object, e As EventArgs) Handles DataGridView6.SelectionChanged
        ' ตรวจสอบว่ามีแถวที่ถูกเลือกหรือไม่
        If DataGridView6.SelectedRows.Count > 0 Then
            ' ดึงข้อมูลจากแถวที่ถูกเลือก
            Dim selectedRow As DataGridViewRow = DataGridView6.SelectedRows(0)

            ' นำค่าจากเซลล์มาแสดงใน TextBox ต่างๆ โดยตรวจสอบค่า NULL ก่อน
            Staff_ID.Text = If(IsDBNull(selectedRow.Cells(9).Value), String.Empty, selectedRow.Cells(9).Value.ToString())
            txtPatientID.Text = If(IsDBNull(selectedRow.Cells(7).Value), String.Empty, selectedRow.Cells(7).Value.ToString())
            txtPatientsName.Text = If(IsDBNull(selectedRow.Cells(8).Value), String.Empty, selectedRow.Cells(8).Value.ToString())
            txtExpectedStays.Text = If(IsDBNull(selectedRow.Cells(2).Value), String.Empty, selectedRow.Cells(2).Value.ToString())

            ' ดึง Allocation_ID จากแถวที่เลือกไปใส่ใน lblAllocationID
            lblAllocationID.Text = If(IsDBNull(selectedRow.Cells(0).Value), String.Empty, selectedRow.Cells(0).Value.ToString())

            txtStaffName.Text = GetStaffNameByID(Staff_ID.Text)

            ' ตรวจสอบค่า Waiting Status ถ้าไม่ใช่ "Waiting" ให้แสดงใน ComboBox
            Dim waitingStatus As String = If(IsDBNull(selectedRow.Cells(6).Value), String.Empty, selectedRow.Cells(6).Value.ToString())
            If waitingStatus <> "Waiting" Then
                cmbWaitingStatus.Text = waitingStatus
            Else
                cmbWaitingStatus.Text = String.Empty ' เคลียร์ค่าใน ComboBox ถ้าเป็น "Waiting"
            End If

            ' ตรวจสอบว่า Bed_ID เป็น NULL หรือไม่
            If Not IsDBNull(selectedRow.Cells(10).Value) Then
                txtBedID.Text = selectedRow.Cells(10).Value.ToString()

                ' ดึงข้อมูลที่เกี่ยวข้องกับ Bed_ID (เช่นจากฐานข้อมูล)
                GetBedRelatedInfo(txtBedID.Text)
            Else
                txtBedID.Text = String.Empty
                ClearBedRelatedTextBoxes()
            End If

            ' ตรวจสอบว่า Date Placed เป็น NULL หรือไม่
            If IsDBNull(selectedRow.Cells(1).Value) Then
                ' ถ้า Date Placed เป็น NULL รอให้ผู้ใช้เลือกค่าใน DateTimePicker แล้วคำนวณ
                dtpDatePlaced.Value = DateTime.Now ' หรือให้ผู้ใช้เลือกเอง
                AddHandler dtpDatePlaced.ValueChanged, AddressOf CalculateDateLeave
            Else
                ' ถ้า Date Placed มีค่าอยู่แล้วให้แสดงค่าเดิม
                dtpDatePlaced.Value = Convert.ToDateTime(selectedRow.Cells(1).Value)

                ' ตรวจสอบว่า Date Leave เป็น NULL หรือไม่
                If IsDBNull(selectedRow.Cells(3).Value) Then
                    ' ถ้า Date Leave เป็น NULL ให้ทำการคำนวณโดยใช้ Expected Days
                    If Not IsDBNull(selectedRow.Cells(2).Value) Then
                        Dim expectedDays As Integer = Convert.ToInt32(selectedRow.Cells(2).Value)
                        dtpDateLeave.Value = dtpDatePlaced.Value.AddDays(expectedDays)
                    End If
                Else
                    ' ถ้ามีค่า Date Leave อยู่แล้วให้แสดงค่าเดิม
                    dtpDateLeave.Value = Convert.ToDateTime(selectedRow.Cells(3).Value)
                End If
            End If

            ' ถ้ามีค่า On Waiting List แสดงใน DateTimePicker
            If Not IsDBNull(selectedRow.Cells(5).Value) Then
                dtpOnWaitingList.Value = Convert.ToDateTime(selectedRow.Cells(5).Value)
            End If
        End If
    End Sub



    ' ฟังก์ชันคำนวณ Date Leave เมื่อผู้ใช้เลือก Date Placed
    Private Sub CalculateDateLeave(sender As Object, e As EventArgs)
        If Not String.IsNullOrEmpty(txtExpectedStays.Text) AndAlso IsNumeric(txtExpectedStays.Text) Then
            Dim expectedDays As Integer = Convert.ToInt32(txtExpectedStays.Text)
            dtpDateLeave.Value = dtpDatePlaced.Value.AddDays(expectedDays)
        End If

        ' หลังจากคำนวณแล้ว สามารถยกเลิกการจับเหตุการณ์นี้เพื่อลดการทำงานซ้ำซ้อน
        RemoveHandler dtpDatePlaced.ValueChanged, AddressOf CalculateDateLeave
    End Sub

    Private Sub GetBedRelatedInfo(bedID As String)
        ' สมมติว่ามีการเชื่อมต่อฐานข้อมูลอยู่แล้ว ชื่อว่า "sqlConnection"
        Try
            ' ตรวจสอบว่าการเชื่อมต่อเปิดอยู่หรือไม่ ถ้ายังไม่เปิด ให้เปิดการเชื่อมต่อ
            If sqlConnection.State = ConnectionState.Closed Then
                sqlConnection.Open()
            End If

            ' สร้างคำสั่ง SQL Query
            Dim query As String = "SELECT Ward_ID, Ward_Name, Location, Ext_Tel FROM Bed_By_Ward WHERE Bed_ID = @BedID"

            ' สร้าง SqlCommand สำหรับรันคำสั่ง SQL
            Using command As New SqlCommand(query, sqlConnection)
                ' กำหนดพารามิเตอร์สำหรับ Bed_ID
                command.Parameters.AddWithValue("@BedID", bedID)

                ' ดึงข้อมูลจากฐานข้อมูล
                Using reader As SqlDataReader = command.ExecuteReader()
                    If reader.HasRows Then
                        ' ถ้ามีข้อมูลจากฐานข้อมูล
                        While reader.Read()
                            ' ตั้งค่าข้อมูลที่ดึงมาใน TextBox ต่าง ๆ
                            txtWardID.Text = reader("Ward_ID").ToString()
                            txtWardName.Text = reader("Ward_Name").ToString()
                            txtLocation.Text = reader("Location").ToString()
                            txtTel.Text = reader("Ext_Tel").ToString()
                        End While
                    Else
                        ' ถ้าไม่พบข้อมูล ให้ล้างค่าใน TextBox
                        ClearBedRelatedTextBoxes()
                    End If
                End Using
            End Using
        Catch ex As Exception
            ' จัดการข้อผิดพลาด เช่นแสดงข้อความแจ้งเตือน
            MessageBox.Show("เกิดข้อผิดพลาดในการดึงข้อมูล: " & ex.Message)
        End Try
    End Sub

    ' ฟังก์ชันเคลียร์ค่าใน TextBox ที่เกี่ยวกับ Bed
    Private Sub ClearBedRelatedTextBoxes()
        txtWardID.Text = String.Empty
        txtWardName.Text = String.Empty
        txtLocation.Text = String.Empty
        txtTel.Text = String.Empty
    End Sub

    Private Sub BtnSUBMIT_Click(sender As Object, e As EventArgs) Handles btnSUBMIT.Click
        Try
            ' เปิดการเชื่อมต่อกับฐานข้อมูล
            If sqlConnection.State = ConnectionState.Closed Then
                sqlConnection.Open()
            End If

            ' ตรวจสอบค่า Waiting Status ถ้าเป็น "Discharged" ให้ตั้งค่า Bed_ID เป็น NULL
            Dim bedIDValue As Object = If(cmbWaitingStatus.Text = "Discharged", DBNull.Value, txtBedID.Text)

            ' ตรวจสอบค่า Actual Leave ถ้าเป็น "Discharged" จะใช้วันที่ปัจจุบัน
            Dim actualLeaveValue As Object = If(cmbWaitingStatus.Text = "Discharged", DateTime.Now, DBNull.Value)

            ' สร้างคำสั่ง SQL สำหรับการ UPDATE ข้อมูลในตารางหลัก (เช่น Patients_Allocation)
            Dim query As String = "UPDATE Patients_Allocation " &
                              "SET Date_Placed = @DatePlaced, " &
                              "Expected_Stays = @ExpectedStays, " &
                              "Date_Leave = @DateLeave, " &
                              "On_Waiting_list = @OnWaitingList, " &
                              "Waiting_Status = @WaitingStatus, " &
                              "Bed_ID = @BedID, " &
                              "Staff_ID = @StaffID, " &
                              "Actual_Leave = @ActualLeave " &
                              "WHERE Allocation_ID = @AllocationID"

            ' สร้าง SqlCommand และกำหนดค่าพารามิเตอร์ที่ต้องการ
            Using command As New SqlCommand(query, sqlConnection)
                command.Parameters.AddWithValue("@DatePlaced", dtpDatePlaced.Value)
                command.Parameters.AddWithValue("@ExpectedStays", txtExpectedStays.Text)
                command.Parameters.AddWithValue("@DateLeave", dtpDateLeave.Value)
                command.Parameters.AddWithValue("@OnWaitingList", dtpOnWaitingList.Value)
                command.Parameters.AddWithValue("@WaitingStatus", cmbWaitingStatus.Text)
                command.Parameters.AddWithValue("@StaffID", CInt(Staff_ID.Text))
                command.Parameters.AddWithValue("@BedID", bedIDValue) ' ถ้า Waiting Status เป็น "Discharged" จะใส่ค่า NULL
                command.Parameters.AddWithValue("@ActualLeave", actualLeaveValue) ' ถ้า Waiting Status เป็น "Discharged" จะใส่วันที่ปัจจุบัน
                command.Parameters.AddWithValue("@AllocationID", lblAllocationID.Text) ' ใช้ Allocation_ID ในการอัปเดตแถว

                ' ดำเนินการอัปเดตข้อมูล
                Dim rowsAffected As Integer = command.ExecuteNonQuery()

                ' ตรวจสอบว่ามีแถวที่ถูกอัปเดตหรือไม่
                If rowsAffected > 0 Then
                    MessageBox.Show("อัปเดตข้อมูลสำเร็จ", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    ' โหลดข้อมูลใหม่ลง DataGridView หลังจากอัปเดต
                    Me.Waiting_List_3TableAdapter.Fill(Me.Wellmeadows_HospitalDataSet.Waiting_List_3)
                Else
                    MessageBox.Show("ไม่สามารถอัปเดตข้อมูลได้", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End Using

        Catch ex As Exception
            ' จัดการข้อผิดพลาด
            MessageBox.Show("เกิดข้อผิดพลาด: " & ex.Message)
        Finally
            ' ปิดการเชื่อมต่อฐานข้อมูล
            If sqlConnection.State = ConnectionState.Open Then
                sqlConnection.Close()
            End If
        End Try
    End Sub



    Private Sub BtnChargeNurse_Click(sender As Object, e As EventArgs) Handles btnChargeNurse.Click
        Dim searchForm As New FormChargeNurse()
        If searchForm.ShowDialog() = DialogResult.OK Then
            Staff_ID.Text = searchForm.SelectedStaffID
            txtStaffName.Text = searchForm.SelectedStaffName

        End If
    End Sub

    ' ฟังก์ชันสำหรับดึงชื่อพนักงานตาม Staff_ID
    Private Function GetStaffNameByID(staffID As String) As String
        Dim staffName As String = String.Empty
        Try
            ' เปิดการเชื่อมต่อกับฐานข้อมูล
            If sqlConnection.State = ConnectionState.Closed Then
                sqlConnection.Open()
            End If

            ' สร้างคำสั่ง SQL Query สำหรับดึงชื่อพนักงาน
            Dim query As String = "SELECT ชื่อ FROM Staff_list2 WHERE Staff_ID = @StaffID"

            ' ใช้ SqlCommand เพื่อดึงข้อมูล
            Using command As New SqlCommand(query, sqlConnection)
                command.Parameters.AddWithValue("@StaffID", staffID)

                ' อ่านข้อมูลจากฐานข้อมูล
                Using reader As SqlDataReader = command.ExecuteReader()
                    If reader.Read() Then
                        staffName = reader("ชื่อ").ToString()
                    End If
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("เกิดข้อผิดพลาด: " & ex.Message)
        Finally
            ' ปิดการเชื่อมต่อฐานข้อมูล
            If sqlConnection.State = ConnectionState.Open Then
                sqlConnection.Close()
            End If
        End Try

        Return staffName
    End Function
End Class