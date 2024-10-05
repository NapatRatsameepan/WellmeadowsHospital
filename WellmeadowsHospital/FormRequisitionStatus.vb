﻿Imports System.Data.SqlClient

Public Class FormRequisitionStatus
    Private connectionString As String = "Data Source=WARMACHINE\DATABASE62;Initial Catalog=Wellmeadows_Hospital;Integrated Security=True;Connect Timeout=30; User Instance=False"
    Dim sqlConnection As New SqlConnection(connectionString)
    Private Sub FormRequisitionStatus_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Wellmeadows_HospitalDataSet.ItemRequisitionReceive2' table. You can move, or remove it, as needed.
        Me.ItemRequisitionReceive2TableAdapter.Fill(Me.Wellmeadows_HospitalDataSet.ItemRequisitionReceive2)
        'TODO: This line of code loads data into the 'Wellmeadows_HospitalDataSet.DrugRequisitionReceive2' table. You can move, or remove it, as needed.
        Me.DrugRequisitionReceive2TableAdapter.Fill(Me.Wellmeadows_HospitalDataSet.DrugRequisitionReceive2)

    End Sub

    Private Function GetDrugStatus() As String
        If rbtnReceiveDrug.Checked Then
            Return "Receive"
        ElseIf rbtnCancelledDrug.Checked Then
            Return "Cancelled"
        Else
            Return String.Empty
        End If
    End Function

    Private Function GetItemStatus() As String
        If rbtnReceiveItem.Checked Then
            Return "Receive"
        ElseIf rbtnCancelledItem.Checked Then
            Return "Cancelled"
        Else
            Return String.Empty
        End If
    End Function

    Private Sub TxtItemSearch_TextChanged(sender As Object, e As EventArgs) Handles txtItemSearch.TextChanged
        ' กรองข้อมูลตาม Item_Requisition_ID
        Dim filterText As String = txtItemSearch.Text

        If Not String.IsNullOrEmpty(filterText) Then
            ' กรองข้อมูลใน DataTable โดยแปลงค่าตัวเลขเป็นข้อความก่อน
            ItemRequisitionReceive2BindingSource.Filter = String.Format("CONVERT([Item_Requisition_ID], 'System.String') LIKE '{0}%'", filterText)
        Else
            ' แสดงข้อมูลทั้งหมดถ้าไม่มีการกรอง
            ItemRequisitionReceive2BindingSource.Filter = ""
        End If
    End Sub

    Private Sub TxtDrugSearch_TextChanged(sender As Object, e As EventArgs) Handles txtDrugSearch.TextChanged
        ' กรองข้อมูลตาม Drug_Requisition_ID
        Dim filterText As String = txtDrugSearch.Text

        If Not String.IsNullOrEmpty(filterText) Then
            ' กรองข้อมูลใน DataTable โดยแปลงค่าตัวเลขเป็นข้อความก่อน
            DrugRequisitionReceive2BindingSource.Filter = String.Format("CONVERT([Drug_Requisition_ID], 'System.String') LIKE '{0}%'", filterText)
        Else
            ' แสดงข้อมูลทั้งหมดถ้าไม่มีการกรอง
            DrugRequisitionReceive2BindingSource.Filter = ""
        End If
    End Sub

    Private Sub BtnItemSAVE_Click(sender As Object, e As EventArgs) Handles btnItemSAVE.Click
        Try
            ' ตรวจสอบว่ามีการเลือก Staff หรือไม่
            If String.IsNullOrEmpty(lblStaffID.Text) Or String.IsNullOrEmpty(txtStaffName.Text) Then
                MessageBox.Show("กรุณาเลือก Staff ก่อน", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            ' ตรวจสอบว่าเลือกคำสั่งการเปลี่ยนสถานะไว้หรือไม่
            Dim status As String = GetItemStatus()
            If String.IsNullOrEmpty(status) Then
                MessageBox.Show("กรุณาเลือกสถานะ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            ' ตรวจสอบว่ามีการเลือกแถวใน DataGridView หรือไม่
            If DataGridViewItemReceive.SelectedRows.Count = 0 Then
                MessageBox.Show("กรุณาเลือกการสั่งซื้อเพื่อเปลี่ยนสถานะ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            ' เปิดการเชื่อมต่อฐานข้อมูล
            If sqlConnection.State = ConnectionState.Closed Then
                sqlConnection.Open()
            End If

            ' คำสั่ง SQL สำหรับการอัปเดตสถานะ, Staff_ID, และวันที่
            Dim query As String = "UPDATE Item_Receive SET Item_Requisition_Status = @Status, Staff_ID = @StaffID, Item_Received_Date = @ReceiveDate WHERE Item_Requisition_ID = @ItemRequisitionID"


            ' ดึงค่า Item_Requisition_ID จากแถวที่เลือกใน DataGridView
            Dim ItemRequisitionID As Integer = Convert.ToInt32(DataGridViewItemReceive.SelectedRows(0).Cells(0).Value)

            ' สร้างคำสั่ง SqlCommand สำหรับการอัปเดตสถานะ, Staff_ID, และวันที่
            Using command As New SqlCommand(query, sqlConnection)
                command.Parameters.AddWithValue("@Status", status)
                command.Parameters.AddWithValue("@StaffID", Convert.ToInt32(lblStaffID.Text)) ' แทนค่า StaffID
                command.Parameters.AddWithValue("@ReceiveDate", DateTime.Now) ' วันที่ปัจจุบัน
                command.Parameters.AddWithValue("@ItemRequisitionID", ItemRequisitionID)
                command.ExecuteNonQuery()
            End Using

            ' ตรวจสอบว่ามีการยกเลิก (Cancelled) หรือไม่
            If status = "Cancelled" Then
                ' วนลูปเพื่ออัปเดตปริมาณของแต่ละแถวใน DataGridView
                For Each row As DataGridViewRow In DataGridViewItemReceive.Rows
                    ' ดึงข้อมูลจาก DataGridView
                    Dim ItemID As Integer = Convert.ToInt32(row.Cells(3).Value)
                    Dim quantityRequired As Integer = Convert.ToInt32(row.Cells(5).Value)

                    ' อัปเดตปริมาณในคลัง
                    Dim updateStockQuery As String = "UPDATE Item SET Item_Quantity_in_stock = Item_Quantity_in_stock + @Quantity WHERE Item_ID = @ItemID"
                    Using updateStockCmd As New SqlCommand(updateStockQuery, sqlConnection)
                        updateStockCmd.Parameters.AddWithValue("@Quantity", quantityRequired)
                        updateStockCmd.Parameters.AddWithValue("@ItemID", ItemID)
                        updateStockCmd.ExecuteNonQuery()
                    End Using
                Next
            End If

            MessageBox.Show("อัปเดตสถานะการสั่งซื้ออุปกรณ์เรียบร้อย", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' ทำการรีเฟรชข้อมูล DataGridView
            Me.ItemRequisitionReceive2TableAdapter.Fill(Me.Wellmeadows_HospitalDataSet.ItemRequisitionReceive2)

        Catch ex As Exception
            MessageBox.Show("เกิดข้อผิดพลาด: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ' ปิดการเชื่อมต่อฐานข้อมูล
            If sqlConnection.State = ConnectionState.Open Then
                sqlConnection.Close()
            End If
        End Try
    End Sub


    Private Sub BtnDrugSAVE_Click(sender As Object, e As EventArgs) Handles btnDrugSAVE.Click
        Try
            ' ตรวจสอบว่ามีการเลือก Staff หรือไม่
            If String.IsNullOrEmpty(lblStaffID.Text) Or String.IsNullOrEmpty(txtStaffName.Text) Then
                MessageBox.Show("กรุณาเลือก Staff ก่อน", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            ' ตรวจสอบว่าเลือกคำสั่งการเปลี่ยนสถานะไว้หรือไม่
            Dim status As String = GetDrugStatus()
            If String.IsNullOrEmpty(status) Then
                MessageBox.Show("กรุณาเลือกสถานะ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            ' ตรวจสอบว่ามีการเลือกแถวใน DataGridView หรือไม่
            If DataGridViewDrugReceive.SelectedRows.Count = 0 Then
                MessageBox.Show("กรุณาเลือกการสั่งซื้อเพื่อเปลี่ยนสถานะ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            ' เปิดการเชื่อมต่อฐานข้อมูล
            If sqlConnection.State = ConnectionState.Closed Then
                sqlConnection.Open()
            End If

            ' คำสั่ง SQL สำหรับการอัปเดตสถานะ, Staff_ID, และวันที่
            Dim query As String = "UPDATE Drug_Receive SET Drug_Requisition_Status = @Status, Staff_ID = @StaffID, Drug_Received_Date = @ReceiveDate WHERE Drug_Requisition_ID = @DrugRequisitionID"

            ' ดึงค่า Drug_Requisition_ID จากแถวที่เลือกใน DataGridView
            Dim DrugRequisitionID As Integer = Convert.ToInt32(DataGridViewDrugReceive.SelectedRows(0).Cells(0).Value)

            ' สร้างคำสั่ง SqlCommand สำหรับการอัปเดตสถานะ, Staff_ID, และวันที่
            Using command As New SqlCommand(query, sqlConnection)
                command.Parameters.AddWithValue("@Status", status)
                command.Parameters.AddWithValue("@StaffID", Convert.ToInt32(lblStaffID.Text)) ' แทนค่า StaffID
                command.Parameters.AddWithValue("@ReceiveDate", DateTime.Now) ' วันที่ปัจจุบัน
                command.Parameters.AddWithValue("@DrugRequisitionID", DrugRequisitionID)
                command.ExecuteNonQuery()
            End Using

            ' ตรวจสอบว่ามีการยกเลิก (Cancelled) หรือไม่
            If status = "Cancelled" Then
                ' วนลูปเพื่ออัปเดตปริมาณยาของแต่ละแถวใน DataGridView
                For Each row As DataGridViewRow In DataGridViewDrugReceive.Rows
                    ' ดึงข้อมูลจาก DataGridView
                    Dim DrugID As Integer = Convert.ToInt32(row.Cells(3).Value)
                    Dim quantityRequired As Integer = Convert.ToInt32(row.Cells(5).Value)

                    ' อัปเดตปริมาณยาในคลัง
                    Dim updateStockQuery As String = "UPDATE Drug SET Drug_Quantity_in_stock = Drug_Quantity_in_stock + @Quantity WHERE Drug_ID = @DrugID"
                    Using updateStockCmd As New SqlCommand(updateStockQuery, sqlConnection)
                        updateStockCmd.Parameters.AddWithValue("@Quantity", quantityRequired)
                        updateStockCmd.Parameters.AddWithValue("@DrugID", DrugID)
                        updateStockCmd.ExecuteNonQuery()
                    End Using
                Next
            End If

            MessageBox.Show("อัปเดตสถานะการสั่งซื้อยาเรียบร้อย", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' ทำการรีเฟรชข้อมูล DataGridView
            Me.DrugRequisitionReceive2TableAdapter.Fill(Me.Wellmeadows_HospitalDataSet.DrugRequisitionReceive2)

        Catch ex As Exception
            MessageBox.Show("เกิดข้อผิดพลาด: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ' ปิดการเชื่อมต่อฐานข้อมูล
            If sqlConnection.State = ConnectionState.Open Then
                sqlConnection.Close()
            End If
        End Try
    End Sub


    Private Sub BtnStaffSearch_Click(sender As Object, e As EventArgs) Handles btnStaffSearch.Click
        Dim searchForm As New FormStaffSearch()
        If searchForm.ShowDialog() = DialogResult.OK Then

            lblStaffID.Text = searchForm.SelectedStaffID
            txtStaffName.Text = searchForm.SelectedFirstName & " " & searchForm.SelectedLastName
        End If
    End Sub
End Class