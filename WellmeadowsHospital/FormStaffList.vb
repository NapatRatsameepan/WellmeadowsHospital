Public Class FormStaffList
    ' Declare a BindingSource to bind your dataset table
    Private staffBindingSource As New BindingSource()



    Private Sub FormStaffList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Wellmeadows_HospitalDataSet.View_StaffDetail2' table. You can move, or remove it, as needed.
        Me.View_StaffDetail2TableAdapter.Fill(Me.Wellmeadows_HospitalDataSet.View_StaffDetail2)
        ' Bind the STAFF_SEARCH data to the BindingSource
        staffBindingSource.DataSource = Me.Wellmeadows_HospitalDataSet.View_StaffDetail2

        ' Bind the DataGridView to the BindingSource (optional if you use DataGridView)
        DataGridView1.DataSource = staffBindingSource
        DataGridView1.Columns(0).Visible = False
    End Sub

    ' Implement search functionality in the TextBox
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        ' Filter for Staff_Name or another appropriate column. Adjust column name as needed.
        staffBindingSource.Filter = String.Format("[Staff Name] LIKE '%{0}%'", TextBox1.Text)
    End Sub

    Private Sub BtnInformation_Click(sender As Object, e As EventArgs) Handles btnInformation.Click
        ' ตรวจสอบว่ามีแถวที่ถูกเลือกใน DataGridView1 หรือไม่
        If DataGridView1.SelectedRows.Count > 0 Then
            ' ดึงค่า Staff_ID จากคอลัมน์ที่ถูกซ่อนอยู่ (Column(0))
            Dim selectedStaffID As Integer = Convert.ToInt32(DataGridView1.SelectedRows(0).Cells(0).Value)

            ' ส่งค่า Staff_ID ไปยัง FormInformation และแสดงฟอร์ม
            Dim infoForm As New FormInformation(selectedStaffID)
            infoForm.ShowDialog()
        Else
            MessageBox.Show("กรุณาเลือกพนักงานจากรายการ")
        End If
    End Sub

End Class
