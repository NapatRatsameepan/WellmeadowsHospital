Imports System.Data.SqlClient

Public Class FormOrderStatus
    Private connectionString As String = "Data Source=WARMACHINE\DATABASE62;Initial Catalog=Wellmeadows_Hospital;Integrated Security=True;Connect Timeout=30; User Instance=False"
    Dim sqlConnection As New SqlConnection(connectionString)
    Private Sub FormOrderStatus_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Wellmeadows_HospitalDataSet.SuppOrderItem' table. You can move, or remove it, as needed.
        Me.SuppOrderItemTableAdapter.Fill(Me.Wellmeadows_HospitalDataSet.SuppOrderItem)
        'TODO: This line of code loads data into the 'Wellmeadows_HospitalDataSet.SuppOrderDrug' table. You can move, or remove it, as needed.
        Me.SuppOrderDrugTableAdapter.Fill(Me.Wellmeadows_HospitalDataSet.SuppOrderDrug)

    End Sub

    Private Sub FormOrderStatus_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        ' เมื่อปิดฟอร์มให้หยุดการทำงานของแอปพลิเคชัน
        Application.Exit() ' หรือใช้คำสั่ง End ก็ได้
    End Sub

    Private Function GetDrugStatus() As String
        If rbtnDeliveredDrug.Checked Then
            Return "Delivered"
        ElseIf rbtnCancelledDrug.Checked Then
            Return "Cancelled"
        Else
            Return String.Empty
        End If
    End Function

    Private Function GetItemStatus() As String
        If rbtnDeliveredItem.Checked Then
            Return "Delivered"
        ElseIf rbtnCancelledItem.Checked Then
            Return "Cancelled"
        Else
            Return String.Empty
        End If
    End Function

    Private Sub TxtDrugSearch_TextChanged(sender As Object, e As EventArgs) Handles txtDrugSearch.TextChanged
        ' กรองข้อมูลตาม Drug Name
        Dim filterText As String = txtDrugSearch.Text

        ' ตรวจสอบว่ามีข้อมูลใน textbox หรือไม่ ถ้ามีให้ทำการกรอง
        If Not String.IsNullOrEmpty(filterText) Then
            ' กรองข้อมูลใน DataTable ผ่าน BindingSource
            SuppOrderDrugBindingSource.Filter = String.Format("[Supp_Name] LIKE '{0}%'", filterText)
        Else
            ' หากไม่มีข้อความใน txtDrugName ให้แสดงข้อมูลทั้งหมด
            SuppOrderDrugBindingSource.Filter = ""
        End If
    End Sub

    Private Sub BtnDrugSAVE_Click(sender As Object, e As EventArgs) Handles btnDrugSAVE.Click
        Try
            ' ตรวจสอบว่าเลือกคำสั่งการเปลี่ยนสถานะไว้หรือไม่
            Dim status As String = GetDrugStatus()
            If String.IsNullOrEmpty(status) Then
                MessageBox.Show("กรุณาเลือกสถานะ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            ' ตรวจสอบว่ามีการเลือกแถวใน DataGridView หรือไม่
            If DataGridViewDrugOrders.SelectedRows.Count = 0 Then
                MessageBox.Show("กรุณาเลือกการสั่งซื้อเพื่อเปลี่ยนสถานะ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            ' ดึงค่า Drug_Order_ID จากแถวที่เลือก
            Dim drugOrderID As Integer = Convert.ToInt32(DataGridViewDrugOrders.SelectedRows(0).Cells(0).Value)

            ' เปิดการเชื่อมต่อฐานข้อมูล
            If sqlConnection.State = ConnectionState.Closed Then
                sqlConnection.Open()
            End If

            ' คำสั่ง SQL สำหรับการอัปเดตสถานะ
            Dim query As String = "UPDATE Drug_Order SET Drug_Order_Status = @Status WHERE Drug_Order_ID = @DrugOrderID"

            ' สร้างคำสั่ง SqlCommand สำหรับการอัปเดต
            Using command As New SqlCommand(query, sqlConnection)
                command.Parameters.AddWithValue("@Status", status)
                command.Parameters.AddWithValue("@DrugOrderID", drugOrderID)

                ' ดำเนินการคำสั่ง UPDATE
                command.ExecuteNonQuery()
            End Using

            MessageBox.Show("อัปเดตสถานะการสั่งซื้อยาเรียบร้อย", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' ทำการรีเฟรชข้อมูล DataGridView
            Me.SuppOrderDrugTableAdapter.Fill(Me.Wellmeadows_HospitalDataSet.SuppOrderDrug)

        Catch ex As Exception
            MessageBox.Show("เกิดข้อผิดพลาด: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ' ปิดการเชื่อมต่อฐานข้อมูล
            If sqlConnection.State = ConnectionState.Open Then
                sqlConnection.Close()
            End If
        End Try
    End Sub


    Private Sub TxtItemSearch_TextChanged(sender As Object, e As EventArgs) Handles txtItemSearch.TextChanged
        ' กรองข้อมูลตาม Drug Name
        Dim filterText As String = txtItemSearch.Text

        ' ตรวจสอบว่ามีข้อมูลใน textbox หรือไม่ ถ้ามีให้ทำการกรอง
        If Not String.IsNullOrEmpty(filterText) Then
            ' กรองข้อมูลใน DataTable ผ่าน BindingSource
            SuppOrderItemBindingSource.Filter = String.Format("[Supp_Name] LIKE '{0}%'", filterText)
        Else
            ' หากไม่มีข้อความใน txtDrugName ให้แสดงข้อมูลทั้งหมด
            SuppOrderItemBindingSource.Filter = ""
        End If
    End Sub

    Private Sub BtnItemSAVE_Click(sender As Object, e As EventArgs) Handles btnItemSAVE.Click
        Try
            ' ตรวจสอบว่าเลือกคำสั่งการเปลี่ยนสถานะไว้หรือไม่
            Dim status As String = GetItemStatus()
            If String.IsNullOrEmpty(status) Then
                MessageBox.Show("กรุณาเลือกสถานะ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            ' ตรวจสอบว่ามีการเลือกแถวใน DataGridView หรือไม่
            If DataGridViewItemOrders.SelectedRows.Count = 0 Then
                MessageBox.Show("กรุณาเลือกการสั่งซื้อเพื่อเปลี่ยนสถานะ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            ' ดึงค่า Item_Order_ID จากแถวที่เลือก
            Dim itemOrderID As Integer = Convert.ToInt32(DataGridViewItemOrders.SelectedRows(0).Cells(0).Value)

            ' เปิดการเชื่อมต่อฐานข้อมูล
            If sqlConnection.State = ConnectionState.Closed Then
                sqlConnection.Open()
            End If

            ' คำสั่ง SQL สำหรับการอัปเดตสถานะ
            Dim query As String = "UPDATE Item_Order SET Item_Order_Status = @Status WHERE Item_Order_ID = @ItemOrderID"

            ' สร้างคำสั่ง SqlCommand สำหรับการอัปเดต
            Using command As New SqlCommand(query, sqlConnection)
                command.Parameters.AddWithValue("@Status", status)
                command.Parameters.AddWithValue("@ItemOrderID", itemOrderID)

                ' ดำเนินการคำสั่ง UPDATE
                command.ExecuteNonQuery()
            End Using

            MessageBox.Show("อัปเดตสถานะการสั่งซื้ออุปกรณ์เรียบร้อย", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' ทำการรีเฟรชข้อมูล DataGridView
            Me.SuppOrderItemTableAdapter.Fill(Me.Wellmeadows_HospitalDataSet.SuppOrderItem)

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