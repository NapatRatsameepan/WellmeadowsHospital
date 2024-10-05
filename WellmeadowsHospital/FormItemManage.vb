Imports System.Data.SqlClient

Public Class FormItemManage
    Private connectionString As String = "Data Source=WARMACHINE\DATABASE62;Initial Catalog=Wellmeadows_Hospital;Integrated Security=True;Connect Timeout=30; User Instance=False"
    Dim sqlConnection As New SqlConnection(connectionString)
    Private Sub FormItemManage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Wellmeadows_HospitalDataSet.Item_List' table. You can move, or remove it, as needed.
        Me.Item_ListTableAdapter.Fill(Me.Wellmeadows_HospitalDataSet.Item_List)

    End Sub

    Private Sub TxtItemName_TextChanged(sender As Object, e As EventArgs) Handles txtItemName.TextChanged
        ' กรองข้อมูลตาม Drug Name
        Dim filterText As String = txtItemName.Text

        ' ตรวจสอบว่ามีข้อมูลใน textbox หรือไม่ ถ้ามีให้ทำการกรอง
        If Not String.IsNullOrEmpty(filterText) Then
            ' กรองข้อมูลใน DataTable ผ่าน BindingSource
            Item_ListBindingSource.Filter = String.Format("[Item Name] LIKE '{0}%'", filterText)
        Else
            ' หากไม่มีข้อความใน txtDrugName ให้แสดงข้อมูลทั้งหมด
            Item_ListBindingSource.Filter = ""
        End If
    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles btnadd.Click
        Try
            ' ตรวจสอบว่ามีการกรอกข้อมูลใน TextBox ครบหรือไม่
            If String.IsNullOrEmpty(txtItem.Text) OrElse String.IsNullOrEmpty(txtItemDetail.Text) OrElse String.IsNullOrEmpty(txtCost.Text) Then
                MessageBox.Show("กรุณากรอกข้อมูลให้ครบ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return ' ออกจากฟังก์ชันถ้าข้อมูลไม่ครบ
            End If

            ' เปิดการเชื่อมต่อกับฐานข้อมูล
            If sqlConnection.State = ConnectionState.Closed Then
                sqlConnection.Open()
            End If

            ' สร้างคำสั่ง SQL สำหรับการ INSERT ข้อมูล
            Dim query As String = "INSERT INTO Item (Item_Name, Item_Detail, Item_Quantity_in_stock, Item_Cost_Per_Unit) VALUES (@ItemName, @ItemDetail, @QuantityInStock, @CostPerUnit)"

            ' กำหนดคำสั่ง SqlCommand
            Using command As New SqlCommand(query, sqlConnection)
                command.Parameters.AddWithValue("@ItemName", txtItem.Text)
                command.Parameters.AddWithValue("@ItemDetail", txtItemDetail.Text)
                command.Parameters.AddWithValue("@QuantityInStock", 0) ' กำหนดค่า Default เป็น 0
                command.Parameters.AddWithValue("@CostPerUnit", Convert.ToDecimal(txtCost.Text))

                ' ดำเนินการ Execute เพื่อบันทึกข้อมูลลงในฐานข้อมูล
                command.ExecuteNonQuery()
            End Using
            txtItem.Clear()
            txtItemDetail.Clear()
            txtCost.Clear()

            ' รีเฟรช DataGridView เพื่อแสดงรายการใหม่
            Me.Item_ListTableAdapter.Fill(Me.Wellmeadows_HospitalDataSet.Item_List)
            MessageBox.Show("เพิ่มข้อมูลอุปกรณ์เรียบร้อย", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            ' แสดงข้อความข้อผิดพลาดหากเกิดข้อผิดพลาด
            MessageBox.Show("เกิดข้อผิดพลาด: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ' ปิดการเชื่อมต่อฐานข้อมูล
            If sqlConnection.State = ConnectionState.Open Then
                sqlConnection.Close()
            End If
        End Try
    End Sub

End Class