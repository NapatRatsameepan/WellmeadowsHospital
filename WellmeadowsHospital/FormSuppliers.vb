Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class FormSuppliers
    Private connectionString As String = "Data Source=WARMACHINE\DATABASE62;Initial Catalog=Wellmeadows_Hospital;Integrated Security=True;Connect Timeout=30; User Instance=False"
    Dim sqlConnection As New SqlConnection(connectionString)

    Private SuppBindingSource As New BindingSource()

    Private Sub FormSuppliers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' โหลดข้อมูลใน DataGridView เมื่อฟอร์มเปิด
        Me.SuppliersTableAdapter.Fill(Me.Wellmeadows_HospitalDataSet.Suppliers)
        SuppBindingSource.DataSource = Me.Wellmeadows_HospitalDataSet.Suppliers

        ' Bind the DataGridView to the BindingSource (optional if you use DataGridView)
        DataGridView3.DataSource = SuppBindingSource
    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        ' ตรวจสอบว่ากรอกข้อมูลครบหรือไม่
        If txtSuppName.Text = "" Or txtSuppTel.Text = "" Or txtFax.Text = "" Or txtAddress.Text = "" Then
            MessageBox.Show("กรุณากรอกข้อมูลให้ครบถ้วน")
            Return
        End If

        ' คำสั่ง SQL สำหรับเพิ่มข้อมูลใหม่
        Dim query As String = "INSERT INTO Suppliers (Supp_Name, Supp_Tel, Fax, Address) " &
                              "VALUES (@SuppName, @SuppTel, @Fax, @Address)"

        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand(query, connection)
                ' เพิ่มค่าให้กับพารามิเตอร์ใน SQL
                command.Parameters.AddWithValue("@SuppName", txtSuppName.Text)
                command.Parameters.AddWithValue("@SuppTel", txtSuppTel.Text)
                command.Parameters.AddWithValue("@Fax", txtFax.Text)
                command.Parameters.AddWithValue("@Address", txtAddress.Text)

                ' เปิดการเชื่อมต่อและรันคำสั่ง
                connection.Open()
                command.ExecuteNonQuery()
                connection.Close()

                MessageBox.Show("เพิ่มข้อมูลผู้จำหน่ายเรียบร้อยแล้ว")

                ' โหลดข้อมูลใหม่ใน DataGridView
                Me.SuppliersTableAdapter.Fill(Me.Wellmeadows_HospitalDataSet.Suppliers)
            End Using
        End Using
    End Sub

    Private Sub BtnUPDATE_Click(sender As Object, e As EventArgs) Handles btnUPDATE.Click
        ' ตรวจสอบว่ากรอกข้อมูลครบหรือไม่
        If txtSuppName.Text = "" Or txtSuppTel.Text = "" Or txtFax.Text = "" Or txtAddress.Text = "" Then
            MessageBox.Show("กรุณากรอกข้อมูลให้ครบถ้วน")
            Return
        End If

        ' ตรวจสอบว่าเลือกผู้จำหน่ายหรือไม่
        If DataGridView3.SelectedRows.Count = 0 Then
            MessageBox.Show("กรุณาเลือกผู้จำหน่ายที่ต้องการอัปเดต")
            Return
        End If

        ' ดึง Supp_ID ของผู้จำหน่ายที่เลือก
        Dim selectedSuppID As Integer = CInt(DataGridView3.SelectedRows(0).Cells(0).Value)

        ' คำสั่ง SQL สำหรับอัปเดตข้อมูล
        Dim query As String = "UPDATE Suppliers " &
                              "SET Supp_Name = @SuppName, Supp_Tel = @SuppTel, Fax = @Fax, Address = @Address " &
                              "WHERE Supp_ID = @SuppID"

        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand(query, connection)
                ' เพิ่มค่าให้กับพารามิเตอร์ใน SQL
                command.Parameters.AddWithValue("@SuppName", txtSuppName.Text)
                command.Parameters.AddWithValue("@SuppTel", txtSuppTel.Text)
                command.Parameters.AddWithValue("@Fax", txtFax.Text)
                command.Parameters.AddWithValue("@Address", txtAddress.Text)
                command.Parameters.AddWithValue("@SuppID", selectedSuppID)

                ' เปิดการเชื่อมต่อและรันคำสั่ง
                connection.Open()
                command.ExecuteNonQuery()
                connection.Close()

                MessageBox.Show("อัปเดตข้อมูลผู้จำหน่ายเรียบร้อยแล้ว")

                ' โหลดข้อมูลใหม่ใน DataGridView
                Me.SuppliersTableAdapter.Fill(Me.Wellmeadows_HospitalDataSet.Suppliers)
            End Using
        End Using
    End Sub

    ' ฟังก์ชันการแสดงข้อมูลเมื่อคลิกเลือกแถวใน DataGridView
    Private Sub DataGridView3_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView3.CellContentClick
        ' ตรวจสอบว่าแถวที่คลิกเป็นข้อมูลหรือไม่
        If e.RowIndex >= 0 Then
            ' ดึงข้อมูลจากแถวที่เลือก
            Dim row As DataGridViewRow = DataGridView3.Rows(e.RowIndex)

            ' แสดงข้อมูลใน TextBox
            txtSuppName.Text = row.Cells(1).Value.ToString()
            txtSuppTel.Text = row.Cells(2).Value.ToString()
            txtFax.Text = row.Cells(3).Value.ToString()
            txtAddress.Text = row.Cells(4).Value.ToString()
        End If
    End Sub

    Private Sub TextBox12_TextChanged(sender As Object, e As EventArgs) Handles TextBox12.TextChanged
        SuppBindingSource.Filter = String.Format("Supp_Name LIKE '%{0}%'", TextBox12.Text)
    End Sub
End Class
