Imports System.Data.SqlClient

Public Class FormReceive
    Private connectionString As String = "Data Source=WARMACHINE\DATABASE62;Initial Catalog=Wellmeadows_Hospital;Integrated Security=True;Connect Timeout=30; User Instance=False"
    Dim sqlConnection As New SqlConnection(connectionString)
    Private Sub FormReceive_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Wellmeadows_HospitalDataSet.ItemReceiveStatus' table. You can move, or remove it, as needed.
        Me.ItemReceiveStatusTableAdapter.Fill(Me.Wellmeadows_HospitalDataSet.ItemReceiveStatus)
        'TODO: This line of code loads data into the 'Wellmeadows_HospitalDataSet.DrugReceiveStatus' table. You can move, or remove it, as needed.
        Me.DrugReceiveStatusTableAdapter.Fill(Me.Wellmeadows_HospitalDataSet.DrugReceiveStatus)

    End Sub

    Private Function GetDrugStatus() As String
        If rbtnReceiveDrug.Checked Then
            Return "Received"
        ElseIf rbtnCancelledDrug.Checked Then
            Return "Cancelled"
        Else
            Return String.Empty
        End If
    End Function

    Private Function GetItemStatus() As String
        If rbtnReceiveItem.Checked Then
            Return "Received"
        ElseIf rbtnCancelledItem.Checked Then
            Return "Cancelled"
        Else
            Return String.Empty
        End If
    End Function

    Private Sub TxtItemSearch_TextChanged(sender As Object, e As EventArgs) Handles txtItemSearch.TextChanged
        ' กรองข้อมูลตาม Drug Name
        Dim filterText As String = txtItemSearch.Text

        ' ตรวจสอบว่ามีข้อมูลใน textbox หรือไม่ ถ้ามีให้ทำการกรอง
        If Not String.IsNullOrEmpty(filterText) Then
            ' กรองข้อมูลใน DataTable ผ่าน BindingSource
            ItemReceiveStatusBindingSource.Filter = String.Format("[Supp_Name] LIKE '{0}%'", filterText)
        Else
            ' หากไม่มีข้อความใน txtDrugName ให้แสดงข้อมูลทั้งหมด
            ItemReceiveStatusBindingSource.Filter = ""
        End If
    End Sub

    Private Sub TxtDrugSearch_TextChanged(sender As Object, e As EventArgs) Handles txtDrugSearch.TextChanged
        ' กรองข้อมูลตาม Drug Name
        Dim filterText As String = txtDrugSearch.Text

        ' ตรวจสอบว่ามีข้อมูลใน textbox หรือไม่ ถ้ามีให้ทำการกรอง
        If Not String.IsNullOrEmpty(filterText) Then
            ' กรองข้อมูลใน DataTable ผ่าน BindingSource
            DrugReceiveStatusBindingSource.Filter = String.Format("[Supp_Name] LIKE '{0}%'", filterText)
        Else
            ' หากไม่มีข้อความใน txtDrugName ให้แสดงข้อมูลทั้งหมด
            DrugReceiveStatusBindingSource.Filter = ""
        End If
    End Sub

    Private Sub BtnSAVEDrug_Click(sender As Object, e As EventArgs) Handles btnSAVEDrug.Click
        Try
            ' ตรวจสอบว่าเลือกคำสั่งการเปลี่ยนสถานะไว้หรือไม่
            Dim status As String = GetDrugStatus()
            If String.IsNullOrEmpty(status) Then
                MessageBox.Show("กรุณาเลือกสถานะ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            ' ตรวจสอบว่ามีการเลือกแถวใน DataGridView หรือไม่
            If DataGridViewDrugReceive.SelectedRows.Count = 0 Then
                MessageBox.Show("กรุณาเลือกแถวเพื่อเปลี่ยนสถานะ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            ' ดึงค่า Drug_Order_ID และ Drug_ID จากแถวที่เลือก
            Dim drugOrderID As Integer = Convert.ToInt32(DataGridViewDrugReceive.SelectedRows(0).Cells(0).Value)
            Dim drugID As Integer = Convert.ToInt32(DataGridViewDrugReceive.SelectedRows(0).Cells(4).Value)
            Dim quantityReceived As Integer = Convert.ToInt32(DataGridViewDrugReceive.SelectedRows(0).Cells(6).Value)

            ' เปิดการเชื่อมต่อฐานข้อมูล
            If sqlConnection.State = ConnectionState.Closed Then
                sqlConnection.Open()
            End If

            ' ตรวจสอบสถานะ หากเป็น "Received" จะอัปเดตวันที่รับและเพิ่มจำนวนใน stock
            Dim query As String
            If status = "Received" Then
                query = "UPDATE Drug_Order SET Drug_Order_Status = @Status, Drug_Order_Receive_Date = GETDATE() WHERE Drug_Order_ID = @DrugOrderID; " &
                    "UPDATE Drug SET Drug_Quantity_in_stock = Drug_Quantity_in_stock + @QuantityReceived WHERE Drug_ID = @DrugID"
            Else
                query = "UPDATE Drug_Order SET Drug_Order_Status = @Status WHERE Drug_Order_ID = @DrugOrderID"
            End If

            ' สร้างคำสั่ง SqlCommand สำหรับการอัปเดต
            Using command As New SqlCommand(query, sqlConnection)
                command.Parameters.AddWithValue("@Status", status)
                command.Parameters.AddWithValue("@DrugOrderID", drugOrderID)
                command.Parameters.AddWithValue("@QuantityReceived", quantityReceived)
                command.Parameters.AddWithValue("@DrugID", drugID)

                ' ดำเนินการคำสั่ง UPDATE
                command.ExecuteNonQuery()
            End Using

            MessageBox.Show("อัปเดตสถานะการสั่งซื้อยาเรียบร้อย", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' ทำการรีเฟรชข้อมูล DataGridView
            Me.DrugReceiveStatusTableAdapter.Fill(Me.Wellmeadows_HospitalDataSet.DrugReceiveStatus)

            rbtnReceiveDrug.Checked = False
            rbtnCancelledDrug.Checked = False

        Catch ex As Exception
            MessageBox.Show("เกิดข้อผิดพลาด: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ' ปิดการเชื่อมต่อฐานข้อมูล
            If sqlConnection.State = ConnectionState.Open Then
                sqlConnection.Close()
            End If
        End Try
    End Sub


    Private Sub BtnSAVEItem_Click(sender As Object, e As EventArgs) Handles btnSAVEItem.Click
        Try
            ' ตรวจสอบว่าเลือกคำสั่งการเปลี่ยนสถานะไว้หรือไม่
            Dim status As String = GetItemStatus()
            If String.IsNullOrEmpty(status) Then
                MessageBox.Show("กรุณาเลือกสถานะ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            ' ตรวจสอบว่ามีการเลือกแถวใน DataGridView หรือไม่
            If DataGridViewItemReceive.SelectedRows.Count = 0 Then
                MessageBox.Show("กรุณาเลือกแถวเพื่อเปลี่ยนสถานะ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            ' ดึงค่า Item_Order_ID และ Item_ID จากแถวที่เลือก
            Dim itemOrderID As Integer = Convert.ToInt32(DataGridViewItemReceive.SelectedRows(0).Cells(0).Value)
            Dim itemID As Integer = Convert.ToInt32(DataGridViewItemReceive.SelectedRows(0).Cells(4).Value)
            Dim quantityReceived As Integer = Convert.ToInt32(DataGridViewItemReceive.SelectedRows(0).Cells(6).Value)

            ' เปิดการเชื่อมต่อฐานข้อมูล
            If sqlConnection.State = ConnectionState.Closed Then
                sqlConnection.Open()
            End If

            ' ตรวจสอบสถานะ หากเป็น "Received" จะอัปเดตวันที่รับและเพิ่มจำนวนใน stock
            Dim query As String
            If status = "Received" Then
                query = "UPDATE Item_Order SET Item_Order_Status = @Status, Item_Order_Receive_Date = GETDATE() WHERE Item_Order_ID = @ItemOrderID; " &
                        "UPDATE Item SET Item_Quantity_in_stock = Item_Quantity_in_stock + @QuantityReceived WHERE Item_ID = @ItemID"
            Else
                query = "UPDATE Item_Order SET Item_Order_Status = @Status WHERE Item_Order_ID = @ItemOrderID"
            End If

            ' สร้างคำสั่ง SqlCommand สำหรับการอัปเดต
            Using command As New SqlCommand(query, sqlConnection)
                command.Parameters.AddWithValue("@Status", status)
                command.Parameters.AddWithValue("@ItemOrderID", itemOrderID)
                command.Parameters.AddWithValue("@QuantityReceived", quantityReceived)
                command.Parameters.AddWithValue("@ItemID", itemID)

                ' ดำเนินการคำสั่ง UPDATE
                command.ExecuteNonQuery()
            End Using

            MessageBox.Show("อัปเดตสถานะการสั่งซื้ออุปกรณ์เรียบร้อย", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' ทำการรีเฟรชข้อมูล DataGridView
            Me.ItemReceiveStatusTableAdapter.Fill(Me.Wellmeadows_HospitalDataSet.ItemReceiveStatus)

            rbtnReceiveItem.Checked = False
            rbtnCancelledItem.Checked = False

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