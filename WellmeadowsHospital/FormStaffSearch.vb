Public Class FormStaffSearch

    Public SelectedFirstName As String
    Public SelectedLastName As String
    Public SelectedStaffID
    Public SelectedPosition As String
    Private Sub FormStaffSearch_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Wellmeadows_HospitalDataSet.Staff_App2' table. You can move, or remove it, as needed.
        Me.Staff_App2TableAdapter.Fill(Me.Wellmeadows_HospitalDataSet.Staff_App2)

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        If e.RowIndex >= 0 Then
            ' ดึงข้อมูลจาก DataBoundItem ของ DataGridView ที่ผูกกับ DataSource
            Dim selectedRow As DataRowView = CType(DataGridView1.Rows(e.RowIndex).DataBoundItem, DataRowView)

            ' ดึงข้อมูลจาก DataSet ที่ถูกเลือก
            SelectedStaffID = selectedRow("ไอดี")
            SelectedFirstName = selectedRow("ชื่อ").ToString()
            SelectedLastName = selectedRow("นามสกุล").ToString()
            SelectedPosition = selectedRow(5).ToString()

            ' ปิดฟอร์มและส่งข้อมูลกลับไปยังฟอร์มหลัก
            Me.DialogResult = DialogResult.OK
            Me.Close()
        End If
    End Sub

    Private Sub DataGridView1_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        If e.RowIndex >= 0 Then
            ' ดึงข้อมูลจาก DataBoundItem ของ DataGridView ที่ผูกกับ DataSource
            Dim selectedRow As DataRowView = CType(DataGridView1.Rows(e.RowIndex).DataBoundItem, DataRowView)

            ' ดึงข้อมูลจาก DataSet ที่ถูกเลือก
            SelectedStaffID = selectedRow("ไอดี")
            SelectedFirstName = selectedRow("ชื่อ").ToString()
            SelectedLastName = selectedRow("นามสกุล").ToString()
            SelectedPosition = selectedRow(5).ToString()

            ' ปิดฟอร์มและส่งข้อมูลกลับไปยังฟอร์มหลัก
            Me.DialogResult = DialogResult.OK
            Me.Close()
        End If
    End Sub

    Private Sub DataGridView1_CellContentClick_2(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        If e.RowIndex >= 0 Then
            ' ดึงข้อมูลจาก DataBoundItem ของ DataGridView ที่ผูกกับ DataSource
            Dim selectedRow As DataRowView = CType(DataGridView1.Rows(e.RowIndex).DataBoundItem, DataRowView)

            ' ดึงข้อมูลจาก DataSet ที่ถูกเลือก
            SelectedStaffID = selectedRow("ไอดี")
            SelectedFirstName = selectedRow("ชื่อ").ToString()
            SelectedLastName = selectedRow("นามสกุล").ToString()
            SelectedPosition = selectedRow(5).ToString()

            ' ปิดฟอร์มและส่งข้อมูลกลับไปยังฟอร์มหลัก
            Me.DialogResult = DialogResult.OK
            Me.Close()
        End If
    End Sub

End Class