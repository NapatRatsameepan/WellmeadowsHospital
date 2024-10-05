Imports System.Data.SqlClient
Imports System.Windows.Forms.AxHost
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class FormStaffAllo

    Private connectionString As String = "Data Source=WARMACHINE\DATABASE62;Initial Catalog=Wellmeadows_Hospital;Integrated Security=True;Connect Timeout=30; User Instance=False"
    Dim sqlConnection As New SqlConnection(connectionString)

    Private Function GetShift() As String
        If rbtnEarly.Checked Then
            Return "Early"
        ElseIf rbtnLate.Checked Then
            Return "Late"
        ElseIf rbtnNight.Checked Then
            Return "Night"
        Else
            Return String.Empty
        End If
    End Function

    ' ฟังก์ชันสำหรับโหลดข้อมูลใน DataGridView2 (ตาราง Allocation)
    Private Sub LoadAllocationData()
        Try
            ' ใช้ Using block เพื่อให้แน่ใจว่าการเชื่อมต่อถูกปิดหลังจากใช้งาน
            Using sqlConnection As New SqlConnection(connectionString)
                sqlConnection.Open()

                ' สร้างคำสั่ง SQL สำหรับ SELECT ข้อมูลทั้งหมดจาก Allocation
                Dim selectQuery As String = "SELECT * FROM Ward_Allocation"

                ' สร้าง DataAdapter เพื่อดึงข้อมูลจากฐานข้อมูล
                Dim dataAdapter As New SqlDataAdapter(selectQuery, sqlConnection)

                ' สร้าง DataTable สำหรับเก็บข้อมูลที่ดึงมา
                Dim dataTable As New DataTable()

                ' เติมข้อมูลจาก DataAdapter ลงใน DataTable
                dataAdapter.Fill(dataTable)

                ' ตั้งค่า DataSource ของ DataGridView2 ให้เป็น DataTable ที่ดึงมา
                DataGridView2.DataSource = dataTable
            End Using

        Catch ex As Exception
            MessageBox.Show("เกิดข้อผิดพลาดในการโหลดข้อมูล Allocation: " & ex.Message)
        End Try
    End Sub

    ' ฟังก์ชันสำหรับโหลดข้อมูลใน DataGridView1 (ตาราง Staff_List) โดยอ้างอิงจาก Ward_Allocation_ID
    Private Sub LoadStaffData(wardAllocationID As String)
        Try
            ' ใช้ Using block เพื่อให้แน่ใจว่าการเชื่อมต่อถูกปิดหลังจากใช้งาน
            Using sqlConnection As New SqlConnection(connectionString)
                sqlConnection.Open()

                ' สร้างคำสั่ง SQL สำหรับ SELECT ข้อมูลจากตาราง Staff_List โดยใช้ Ward_Allocation_ID
                Dim selectQuery As String = "SELECT * FROM Staff_Allo_list WHERE Ward_Allocation_ID = @Ward_Allocation_ID"

                ' สร้าง SqlCommand และเพิ่มค่า Parameter
                Dim command As New SqlCommand(selectQuery, sqlConnection)
                command.Parameters.AddWithValue("@Ward_Allocation_ID", wardAllocationID)

                ' สร้าง DataAdapter เพื่อดึงข้อมูลจากฐานข้อมูล
                Dim dataAdapter As New SqlDataAdapter(command)

                ' สร้าง DataTable สำหรับเก็บข้อมูลที่ดึงมา
                Dim dataTable As New DataTable()

                ' เติมข้อมูลจาก DataAdapter ลงใน DataTable
                dataAdapter.Fill(dataTable)

                ' ตั้งค่า DataSource ของ DataGridView1 ให้เป็น DataTable ที่ดึงมา
                DataGridView1.DataSource = dataTable
            End Using

        Catch ex As Exception
            MessageBox.Show("เกิดข้อผิดพลาดในการโหลดข้อมูล Staff_List: " & ex.Message)
        End Try
    End Sub

    Private Sub FormStaffAllo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' โหลดข้อมูล Allocation ลงใน DataGridView2 เมื่อฟอร์มเริ่มต้น
        LoadAllocationData()
    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        ' ตรวจสอบว่ามีแถวที่ถูกเลือกใน DataGridView2 หรือไม่
        If DataGridView2.SelectedRows.Count > 0 Then
            ' ดึงค่า Ward_Allocation_ID จากแถวที่ถูกเลือก
            Dim selectedWardAllocationID As String = DataGridView2.SelectedRows(0).Cells(0).Value.ToString()

            ' ตรวจสอบว่า TextBox ของข้อมูลพนักงานไม่ว่างเปล่า
            If txtStaffID.Text <> "" Then
                Try
                    ' เปิดการเชื่อมต่อกับฐานข้อมูล
                    Using sqlConnection As New SqlConnection(connectionString)
                        sqlConnection.Open()

                        ' สร้างคำสั่ง SQL สำหรับ INSERT INTO Staff_Allo_list
                        Dim insertQuery As String = "INSERT INTO Allocation_List (Staff_ID, Ward_Allocation_ID, Shift) 
                                                 VALUES (@Staff_ID, @Ward_Allocation_ID, @Shift)"

                        ' สร้าง SqlCommand
                        Using Command As New SqlCommand(insertQuery, sqlConnection)
                            ' เพิ่มค่าลงใน Parameters
                            Command.Parameters.AddWithValue("@Staff_ID", CInt(txtStaffID.Text))
                            Command.Parameters.AddWithValue("@Ward_Allocation_ID", selectedWardAllocationID)
                            Command.Parameters.AddWithValue("@Shift", GetShift()) ' ดึงค่ากะ (Shift) จากฟังก์ชัน GetShift

                            ' ทำการ Execute คำสั่ง INSERT
                            Command.ExecuteNonQuery()

                            MessageBox.Show("เพิ่มพนักงานสำเร็จ")
                        End Using
                    End Using

                    ' โหลดข้อมูลใหม่ใน DataGridView1 (ตาราง Staff_List) หลังจากเพิ่มข้อมูลเสร็จ
                    LoadStaffData(selectedWardAllocationID)

                    ' ล้างข้อมูลใน TextBox หลังจากเพิ่มเสร็จ
                    txtStaffID.Clear()
                    txtStaffName.Clear()
                    txtPosition.Clear()

                Catch ex As Exception
                    MessageBox.Show("เกิดข้อผิดพลาด: " & ex.Message)
                End Try
            Else
                MessageBox.Show("กรุณากรอกข้อมูลพนักงานให้ครบถ้วน")
            End If
        Else
            MessageBox.Show("กรุณาเลือกแถวในตาราง Allocation ก่อนที่จะเพิ่มพนักงาน")
        End If
    End Sub

    Private Sub BtnDELETE_Click(sender As Object, e As EventArgs) Handles btnDELETE.Click
        ' ตรวจสอบว่ามีแถวที่ถูกเลือกใน DataGridView1 หรือไม่
        If DataGridView1.SelectedRows.Count > 0 Then
            ' ยืนยันการลบกับผู้ใช้
            Dim result As DialogResult = MessageBox.Show("คุณต้องการลบข้อมูลนี้ใช่หรือไม่?", "ยืนยันการลบ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

            ' ถ้าผู้ใช้กด Yes
            If result = DialogResult.Yes Then
                Try
                    ' ดึงค่า StaffAllocationID จากแถวที่ถูกเลือกใน Staff List
                    Dim selectedStaffAllocationID As String = DataGridView1.SelectedRows(0).Cells(0).Value.ToString()

                    ' เก็บค่า Ward_Allocation_ID จากแถวที่ถูกเลือกใน DataGridView2 (Allocation List)
                    Dim selectedWardAllocationID As String = DataGridView2.SelectedRows(0).Cells(0).Value.ToString()

                    ' เปิดการเชื่อมต่อฐานข้อมูล
                    Using sqlConnection As New SqlConnection(connectionString)
                        sqlConnection.Open()

                        ' สร้างคำสั่ง SQL สำหรับ DELETE ข้อมูลจากฐานข้อมูล
                        Dim deleteQuery As String = "DELETE FROM Allocation_List WHERE Ward_Allocation_List_ID = @Ward_Allocation_List_ID"

                        ' สร้าง SqlCommand
                        Using command As New SqlCommand(deleteQuery, sqlConnection)
                            ' เพิ่มค่า Parameter
                            command.Parameters.AddWithValue("@Ward_Allocation_List_ID", selectedStaffAllocationID)

                            ' ทำการ Execute คำสั่ง DELETE
                            command.ExecuteNonQuery()
                        End Using
                    End Using

                    ' แสดงข้อความเมื่อการลบเสร็จสิ้น
                    MessageBox.Show("ลบข้อมูลสำเร็จ")

                    ' โหลดข้อมูลใหม่ใน DataGridView1 หลังจากลบข้อมูลเสร็จ
                    LoadStaffData(selectedWardAllocationID)

                    ' รีโหลดข้อมูล Allocation ใน DataGridView2
                    LoadAllocationData()

                    ' ค้นหาและตั้งค่า Selection กลับไปยังแถวที่มี Ward_Allocation_ID เดิมใน DataGridView2
                    For Each row As DataGridViewRow In DataGridView2.Rows
                        If row.Cells(0).Value.ToString() = selectedWardAllocationID Then
                            row.Selected = True
                            Exit For
                        End If
                    Next

                Catch ex As Exception
                    MessageBox.Show("เกิดข้อผิดพลาดในการลบข้อมูล: " & ex.Message)
                End Try
            End If
        Else
            MessageBox.Show("กรุณาเลือกแถวที่ต้องการลบก่อน")
        End If
    End Sub



    ' ฟังก์ชันการเพิ่มข้อมูล Allocation
    Private Sub BtnAllocationAdd_Click(sender As Object, e As EventArgs) Handles btnAllocationAdd.Click
        ' เช็คว่า TextBox ไม่ว่างเปล่า
        If txtWardID.Text <> "" Then
            Try
                ' เปิดการเชื่อมต่อกับฐานข้อมูล
                sqlConnection.Open()

                ' สร้างคำสั่ง SQL สำหรับ INSERT INTO
                Dim insertQuery As String = "INSERT INTO Allocation_To (Ward_ID, Shift_Start_Date, Shift_Finish_Date) 
                                             VALUES (@Ward_ID, @Start_Date, @End_Date)"

                ' สร้าง SqlCommand
                Using Command As New SqlCommand(insertQuery, sqlConnection)
                    ' เพิ่มค่าลงใน Parameters
                    Command.Parameters.AddWithValue("@Ward_ID", CInt(txtWardID.Text))
                    Command.Parameters.AddWithValue("@Start_Date", dtpWeekBegin.Value)
                    Command.Parameters.AddWithValue("@End_Date", dtpWeekFinish.Value)

                    ' ทำการ Execute คำสั่ง INSERT
                    Command.ExecuteNonQuery()

                    MessageBox.Show("เพิ่มข้อมูลสำเร็จ")
                End Using

                ' โหลดข้อมูลใหม่ใน DataGridView2 หลังจากเพิ่มข้อมูลเสร็จ
                LoadAllocationData()
                txtWardID.Clear()
                txtWardName.Clear()
                dtpWeekBegin.Value = DateTime.Now
                dtpWeekFinish.Value = DateTime.Now

            Catch ex As Exception
                MessageBox.Show("เกิดข้อผิดพลาด: " & ex.Message)
            Finally
                ' ปิดการเชื่อมต่อฐานข้อมูล
                sqlConnection.Close()
            End Try
        Else
            MessageBox.Show("กรุณากรอกข้อมูลให้ครบถ้วน")
        End If
    End Sub

    ' ฟังก์ชันการลบ Allocation
    Private Sub BtnAllocationDelete_Click(sender As Object, e As EventArgs) Handles btnAllocationDelete.Click
        ' ตรวจสอบว่ามีแถวที่ถูกเลือกใน DataGridView2 หรือไม่
        If DataGridView2.SelectedRows.Count > 0 Then
            ' ยืนยันการลบกับผู้ใช้
            Dim result As DialogResult = MessageBox.Show("คุณต้องการลบข้อมูลนี้ใช่หรือไม่?", "ยืนยันการลบ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

            ' ถ้าผู้ใช้กด Yes
            If result = DialogResult.Yes Then
                Try
                    ' ดึงค่า Ward_Allocation_ID จากแถวที่ถูกเลือก
                    Dim selectedWardAllocationID As String = DataGridView2.SelectedRows(0).Cells(0).Value.ToString()

                    ' เปิดการเชื่อมต่อฐานข้อมูล
                    Using sqlConnection As New SqlConnection(connectionString)
                        sqlConnection.Open()

                        ' สร้างคำสั่ง SQL สำหรับ DELETE ข้อมูลจากฐานข้อมูล
                        Dim deleteQuery As String = "DELETE FROM Allocation_To WHERE Ward_Allocation_ID = @Ward_Allocation_ID"

                        ' สร้าง SqlCommand
                        Using command As New SqlCommand(deleteQuery, sqlConnection)
                            ' เพิ่มค่า Parameter
                            command.Parameters.AddWithValue("@Ward_Allocation_ID", selectedWardAllocationID)

                            ' ทำการ Execute คำสั่ง DELETE
                            command.ExecuteNonQuery()
                        End Using
                    End Using

                    ' แสดงข้อความเมื่อการลบเสร็จสิ้น
                    MessageBox.Show("ลบข้อมูลสำเร็จ")

                    ' โหลดข้อมูลใหม่ใน DataGridView2 หลังจากลบข้อมูลเสร็จ
                    LoadAllocationData()

                Catch ex As Exception
                    MessageBox.Show("เกิดข้อผิดพลาดในการลบข้อมูล: " & ex.Message)
                End Try
            End If
        Else
            MessageBox.Show("กรุณาเลือกแถวที่ต้องการลบก่อน")
        End If
    End Sub

    ' ฟังก์ชันค้นหาพนักงาน
    Private Sub BtnStaffSearch_Click(sender As Object, e As EventArgs) Handles btnStaffSearch.Click
        Dim searchForm As New FormStaffSearch()
        If searchForm.ShowDialog() = DialogResult.OK Then
            txtStaffID.Text = searchForm.SelectedStaffID
            txtStaffName.Text = String.Format("{0} {1}", searchForm.SelectedFirstName, searchForm.SelectedLastName)
            txtPosition.Text = searchForm.SelectedPosition
        End If
    End Sub

    ' ฟังก์ชันค้นหา Ward
    Private Sub BtnWardSearch_Click(sender As Object, e As EventArgs) Handles btnWardSearch.Click
        Dim searchForm As New FormWardSearch()
        If searchForm.ShowDialog() = DialogResult.OK Then
            txtWardID.Text = searchForm.SelectedWardID
            txtWardName.Text = searchForm.SelectedWardName
        End If
    End Sub

    ' เมื่อมีการเปลี่ยนแปลงวันที่ใน DateTimePicker
    Private Sub DtpWeekBegin_ValueChanged(sender As Object, e As EventArgs) Handles dtpWeekBegin.ValueChanged
        dtpWeekFinish.Value = dtpWeekBegin.Value.AddDays(7)
    End Sub

    ' เมื่อผู้ใช้เลือกแถวใน DataGridView2 (ตาราง Allocation)
    Private Sub DataGridView2_SelectionChanged(sender As Object, e As EventArgs) Handles DataGridView2.SelectionChanged
        ' ตรวจสอบว่ามีแถวที่ถูกเลือกใน Allocation List หรือไม่
        If DataGridView2.SelectedRows.Count > 0 Then
            ' ดึงค่า Ward_Allocation_ID จากแถวที่ถูกเลือกใน Allocation List
            Dim selectedWardAllocationID As String = DataGridView2.SelectedRows(0).Cells(0).Value.ToString()

            ' โหลดข้อมูล Staff ที่เชื่อมกับ Ward_Allocation_ID ที่เลือก
            LoadStaffData(selectedWardAllocationID)
        End If
    End Sub


End Class
