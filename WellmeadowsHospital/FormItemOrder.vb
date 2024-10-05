Imports System.Data.SqlClient

Public Class FormItemOrder
    Private connectionString As String = "Data Source=WARMACHINE\DATABASE62;Initial Catalog=Wellmeadows_Hospital;Integrated Security=True;Connect Timeout=30; User Instance=False"
    Dim sqlConnection As New SqlConnection(connectionString)
    Private Sub BtnbtnSuppSearch_Click(sender As Object, e As EventArgs) Handles btnbtnSuppSearch.Click
        Dim searchForm As New FormSuppSearch()
        If searchForm.ShowDialog() = DialogResult.OK Then
            txtSuppID.Text = searchForm.SelectedSuppID
            txtSuppName.Text = searchForm.SelectedSuppName
        End If
    End Sub

    Private Sub BtnItemSearch_Click(sender As Object, e As EventArgs) Handles btnItemSearch.Click
        Dim searchForm As New FormItemSearch()
        If searchForm.ShowDialog() = DialogResult.OK Then
            txtItemID.Text = searchForm.SelectedItemID
            txtItemName.Text = searchForm.SelectedItemName
            txtCPU.Text = searchForm.SelectedCost.ToString("N2")
        End If
    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Try
            ' ตรวจสอบว่าได้กรอกข้อมูลครบถ้วน
            If String.IsNullOrEmpty(txtItemID.Text) OrElse String.IsNullOrEmpty(txtQuantity.Text) OrElse String.IsNullOrEmpty(txtCPU.Text) OrElse String.IsNullOrEmpty(txtTotal.Text) Then
                MessageBox.Show("กรุณากรอกข้อมูลให้ครบถ้วน", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            ' เพิ่มแถวลงใน DataGridView
            Dim row As String() = New String() {
            txtSuppID.Text,
            txtItemID.Text,
            txtQuantity.Text,
            txtTotal.Text
        }

            ' เพิ่มแถวลงใน DataGridView
            DataGridView1.Rows.Add(row)

            ' ล้างข้อมูลใน TextBox เพื่อให้พร้อมสำหรับการกรอกข้อมูลถัดไป
            txtSuppID.Clear()
            txtItemID.Clear()
            txtQuantity.Clear()
            txtTotal.Clear()
            txtItemName.Clear()
            txtSuppName.Clear()
            txtCPU.Clear()

        Catch ex As Exception
            MessageBox.Show("เกิดข้อผิดพลาด: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Try
            ' ตรวจสอบว่ามีการเลือกแถวใน DataGridView หรือไม่
            If DataGridView1.SelectedRows.Count > 0 Then
                ' ลบแถวที่ถูกเลือกออก
                For Each row As DataGridViewRow In DataGridView1.SelectedRows
                    DataGridView1.Rows.Remove(row)
                Next
            Else
                MessageBox.Show("กรุณาเลือกแถวที่ต้องการลบ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show("เกิดข้อผิดพลาด: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub BtnOrder_Click(sender As Object, e As EventArgs) Handles btnOrder.Click
        Try
            ' ตรวจสอบว่ามีรายการใน DataGridView
            If DataGridView1.Rows.Count = 0 Then
                MessageBox.Show("กรุณาเพิ่มรายการก่อนสั่งซื้อ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            ' เปิดการเชื่อมต่อฐานข้อมูล
            If sqlConnection.State = ConnectionState.Closed Then
                sqlConnection.Open()
            End If

            ' เริ่มการ transaction
            Using transaction = sqlConnection.BeginTransaction()
                Try
                    ' วนลูปเพื่อเพิ่มข้อมูลลงใน Item_Order_Detail
                    For Each row As DataGridViewRow In DataGridView1.Rows
                        If Not row.IsNewRow Then
                            ' Insert ข้อมูลลงใน Item_Order_Detail
                            Dim queryDetail As String = "INSERT INTO Item_Order_Detail (Item_Order_Quantity, Item_Price_Total, Supp_ID, Item_ID) VALUES (@Quantity, @TotalPrice, @SuppID, @ItemID); SELECT SCOPE_IDENTITY();"

                            Using command As New SqlCommand(queryDetail, sqlConnection, transaction)
                                ' แปลงค่าจากข้อความให้เป็นตัวเลขก่อนการส่งไปยังฐานข้อมูล
                                Dim quantity As Integer = Convert.ToInt32(row.Cells(2).Value)
                                Dim totalPrice As Decimal = Convert.ToDecimal(row.Cells(3).Value)

                                ' ส่งค่าไปยังคำสั่ง SQL
                                command.Parameters.AddWithValue("@Quantity", quantity) ' Quantity
                                command.Parameters.AddWithValue("@TotalPrice", totalPrice) ' Total Price
                                command.Parameters.AddWithValue("@SuppID", Convert.ToInt32(row.Cells(0).Value)) ' Supplier ID
                                command.Parameters.AddWithValue("@ItemID", Convert.ToInt32(row.Cells(1).Value)) ' Item ID

                                ' รับค่าของ Item_Order_Detail_ID ที่เพิ่งถูกสร้าง
                                Dim itemOrderDetailID As Integer = Convert.ToInt32(command.ExecuteScalar())

                                ' Insert ข้อมูลลงใน Item_Order
                                Dim queryOrder As String = "INSERT INTO Item_Order (Item_Order_Detail_ID) VALUES (@ItemOrderDetailID)"
                                Using commandOrder As New SqlCommand(queryOrder, sqlConnection, transaction)
                                    commandOrder.Parameters.AddWithValue("@ItemOrderDetailID", itemOrderDetailID)
                                    commandOrder.ExecuteNonQuery()
                                End Using
                            End Using
                        End If
                    Next

                    ' Commit การ transaction
                    transaction.Commit()
                    MessageBox.Show("บันทึกข้อมูลการสั่งซื้อสำเร็จ", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    ' เคลียร์ DataGridView หลังจากบันทึกสำเร็จ
                    DataGridView1.Rows.Clear()

                Catch ex As Exception
                    ' Rollback การ transaction หากเกิดข้อผิดพลาด
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


    Private Sub TxtQuantity_TextChanged(sender As Object, e As EventArgs) Handles txtQuantity.TextChanged
        Try
            ' ตรวจสอบว่า txtQuantity และ txtCPU ไม่ว่างและเป็นตัวเลขที่ถูกต้อง
            If Not String.IsNullOrEmpty(txtQuantity.Text) AndAlso Not String.IsNullOrEmpty(txtCPU.Text) Then
                Dim quantity As Integer
                Dim costPerUnit As Decimal
                Dim total As Decimal

                ' ตรวจสอบและแปลงค่าจาก TextBox
                If Integer.TryParse(txtQuantity.Text, quantity) AndAlso Decimal.TryParse(txtCPU.Text, costPerUnit) Then
                    ' คำนวณ Total = Quantity * Cost Per Unit
                    total = quantity * costPerUnit

                    ' แสดงผลใน txtTotal โดยมีทศนิยม 2 ตำแหน่ง
                    txtTotal.Text = total.ToString("N2")
                Else
                    ' หากการแปลงค่ามีปัญหา ให้เคลียร์ txtTotal
                    txtTotal.Text = String.Empty
                End If
            Else
                ' หาก TextBox ว่าง ให้เคลียร์ txtTotal
                txtTotal.Text = String.Empty
            End If
        Catch ex As Exception
            MessageBox.Show("เกิดข้อผิดพลาด: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

End Class