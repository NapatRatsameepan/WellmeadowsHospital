Public Class FormExamSearch
    Public SelectedAppID

    Public SelectedPatientName As String
    Public SelectedPatientID

    Public SelectedStaffName As String
    Public SelectedStaffID
    Private Sub FormExamSearch_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Wellmeadows_HospitalDataSet.Exam2' table. You can move, or remove it, as needed.
        Me.Exam2TableAdapter.Fill(Me.Wellmeadows_HospitalDataSet.Exam2)

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        If e.RowIndex >= 0 Then
            ' ดึงข้อมูลจาก DataBoundItem ของ DataGridView ที่ผูกกับ DataSource
            Dim selectedRow As DataRowView = CType(DataGridView1.Rows(e.RowIndex).DataBoundItem, DataRowView)

            ' ดึงข้อมูลจาก DataSet ที่ถูกเลือก
            SelectedAppID = selectedRow("Appointment_ID")

            SelectedPatientID = selectedRow("Patients_ID")
            SelectedPatientName = selectedRow("Patients Name").ToString()

            SelectedStaffID = selectedRow("Staff_ID")
            SelectedStaffName = selectedRow("Staff Name").ToString()

            ' ปิดฟอร์มและส่งข้อมูลกลับไปยังฟอร์มหลัก
            Me.DialogResult = DialogResult.OK
            Me.Close()
        End If
    End Sub
End Class