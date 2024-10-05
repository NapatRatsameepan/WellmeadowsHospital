Imports System.Data.SqlClient

Public Class FormDrugManage
    Private connectionString As String = "Data Source=WARMACHINE\DATABASE62;Initial Catalog=Wellmeadows_Hospital;Integrated Security=True;Connect Timeout=30; User Instance=False"
    Dim sqlConnection As New SqlConnection(connectionString)
    Private Sub FormDrugManage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Wellmeadows_HospitalDataSet.Drug_List' table. You can move, or remove it, as needed.
        Me.Drug_ListTableAdapter.Fill(Me.Wellmeadows_HospitalDataSet.Drug_List)

    End Sub

    Private Sub TxtDrugName_TextChanged(sender As Object, e As EventArgs) Handles txtDrugName.TextChanged
        ' กรองข้อมูลตาม Drug Name
        Dim filterText As String = txtDrugName.Text

        ' ตรวจสอบว่ามีข้อมูลใน textbox หรือไม่ ถ้ามีให้ทำการกรอง
        If Not String.IsNullOrEmpty(filterText) Then
            ' กรองข้อมูลใน DataTable ผ่าน BindingSource
            Drug_ListBindingSource.Filter = String.Format("[Drug Name] LIKE '{0}%'", filterText)
        Else
            ' หากไม่มีข้อความใน txtDrugName ให้แสดงข้อมูลทั้งหมด
            Drug_ListBindingSource.Filter = ""
        End If
    End Sub

    Private Sub Btnadd_Click(sender As Object, e As EventArgs) Handles btnadd.Click
        Try
            ' เปิดการเชื่อมต่อกับฐานข้อมูล
            If sqlConnection.State = ConnectionState.Closed Then
                sqlConnection.Open()
            End If

            ' ตรวจสอบว่า TextBox ไม่ว่าง
            If String.IsNullOrEmpty(Txtname.Text) OrElse String.IsNullOrEmpty(Txtdetail.Text) OrElse String.IsNullOrEmpty(Txtdousage.Text) OrElse String.IsNullOrEmpty(Txtmet.Text) OrElse String.IsNullOrEmpty(txtcost.Text) Then
                MessageBox.Show("กรุณากรอกข้อมูลให้ครบ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            ' สร้างคำสั่ง SQL สำหรับการเพิ่มข้อมูลลงในตาราง Drug_List
            Dim query As String = "INSERT INTO Drug (Drug_Name, Drug_Detail, Dosage, Method, Drug_Quantity_in_stock, Drug_Cost_Per_Unit) VALUES (@DrugName, @DrugDetail, @Dosage, @Method, @QuantityInStock, @CostPerUnit)"

            Using command As New SqlCommand(query, sqlConnection)
                ' เพิ่มค่าจาก TextBox ลงในพารามิเตอร์ของคำสั่ง SQL
                command.Parameters.AddWithValue("@DrugName", Txtname.Text)
                command.Parameters.AddWithValue("@DrugDetail", Txtdetail.Text)
                command.Parameters.AddWithValue("@Dosage", Convert.ToDecimal(Txtdousage.Text))
                command.Parameters.AddWithValue("@Method", Txtmet.Text)
                command.Parameters.AddWithValue("@QuantityInStock", 0) ' ตั้งค่าเริ่มต้นเป็น 0
                command.Parameters.AddWithValue("@CostPerUnit", Convert.ToDecimal(txtcost.Text))

                ' ดำเนินการ Execute เพื่อบันทึกข้อมูลลงในฐานข้อมูล
                command.ExecuteNonQuery()
            End Using

            Txtname.Clear()
            Txtdetail.Clear()
            Txtmet.Clear()
            Txtdousage.Clear()
            txtcost.Clear()

            ' รีเฟรช DataGridView เพื่อแสดงข้อมูลที่เพิ่ม
            Me.Drug_ListTableAdapter.Fill(Me.Wellmeadows_HospitalDataSet.Drug_List)
            MessageBox.Show("เพิ่มข้อมูลยาเรียบร้อย", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MessageBox.Show("เกิดข้อผิดพลาด: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ' ปิดการเชื่อมต่อกับฐานข้อมูล
            If sqlConnection.State = ConnectionState.Open Then
                sqlConnection.Close()
            End If
        End Try
    End Sub


End Class