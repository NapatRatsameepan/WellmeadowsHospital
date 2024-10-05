Imports System.Data.SqlClient

Public Class FormMain

    Private connectionString As String = "Data Source=WARMACHINE\DATABASE62;Initial Catalog=Wellmeadows_Hospital;Integrated Security=True;Connect Timeout=30; User Instance=False"
    Dim sqlConnection As New SqlConnection(connectionString)

    Private Sub BtnSignIn_Click(sender As Object, e As EventArgs) Handles btnSignIn.Click
        If txtStaffID.Text = "" Then
            MessageBox.Show("กรุณากรอกไอดี", "สถานะการล็อกอิน", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtStaffID.Focus()
            Return
        End If

        Dim id As String = txtStaffID.Text.ToUpper

        Try
            sqlConnection.Open()

            ' ตรวจสอบว่า ID ที่กรอกมาคือ Staff หรือ Supplier
            If id.StartsWith("S") Then
                ' ตัดตัว 'S' ออกและแปลงเป็นเลข
                Dim supplierID As Integer = Convert.ToInt32(id.Substring(1))
                CheckSupplier(supplierID)
            ElseIf id.StartsWith("WH") Then
                ' ตัดตัว 'WH' ออกและแปลงเป็นเลข
                Dim staffID As Integer = Convert.ToInt32(id.Substring(2))
                CheckStaff(staffID)
            Else
                MessageBox.Show("ไอดีไม่ถูกต้อง", "สถานะการล็อกอิน", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            sqlConnection.Close() ' Ensure the connection is closed even if an error occurs
        End Try
    End Sub

    ' ฟังก์ชันสำหรับตรวจสอบในตาราง Supplier
    Private Sub CheckSupplier(supplierID As Integer)
        ' Define the query to check the Supplier ID
        Dim query As String = "SELECT COUNT(1) FROM Suppliers WHERE Supp_ID = @Supp_ID"
        Dim sqlCommand As New SqlCommand(query, sqlConnection)
        sqlCommand.Parameters.AddWithValue("@Supp_ID", supplierID)

        ' Execute the query and check if the Supplier ID exists
        Dim result As Integer = Convert.ToInt32(sqlCommand.ExecuteScalar())

        If result = 1 Then
            ' ล็อกอินสำเร็จสำหรับ Supplier
            Dim menuForm As New FormOrderStatus() ' คุณสามารถเปลี่ยนไปยังหน้าเมนูที่แตกต่างถ้าเป็น Supplier
            menuForm.Show()

            Me.Hide()
        Else
            MessageBox.Show("ไอดีไม่ถูกต้อง", "สถานะการล็อกอิน", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    ' ฟังก์ชันสำหรับตรวจสอบในตาราง Staff
    Private Sub CheckStaff(staffID As Integer)
        ' ดึง Position_ID จากตาราง Staff
        Dim query As String = "SELECT Position_ID FROM Staff WHERE Staff_ID = @Staff_ID"
        Dim sqlCommand As New SqlCommand(query, sqlConnection)
        sqlCommand.Parameters.AddWithValue("@Staff_ID", staffID)

        Dim positionID As Integer = Convert.ToInt32(sqlCommand.ExecuteScalar())

        If positionID > 0 Then
            ' ล็อกอินสำเร็จสำหรับ Staff และส่ง Position_ID ไปยัง FormMenu
            Dim menuForm As New FormMenu(positionID)
            menuForm.Show()

            Me.Hide()
        Else
            MessageBox.Show("ไอดีไม่ถูกต้อง", "สถานะการล็อกอิน", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub


    Private Sub BtnLeave_Click(sender As Object, e As EventArgs) Handles btnLeave.Click
        End
    End Sub
End Class
