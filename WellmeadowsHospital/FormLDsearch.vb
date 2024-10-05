Public Class FormLDsearch
    ' ตัวแปรเพื่อเก็บข้อมูลที่เลือก
    Public SelectedFirstName As String
    Public SelectedLastName As String
    Public SelectedTel As String
    Public SelectedAddress As String
    Public SelectedClinicID

    Private Sub FormLDsearch_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' โหลดข้อมูลจากฐานข้อมูลลงใน DataGridView
        Me.Local_DoctorTableAdapter.Fill(Me.Wellmeadows_HospitalDataSet.Local_Doctor)
    End Sub

    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvLocalDoctor.CellDoubleClick
        ' ตรวจสอบว่ามีการเลือกแถวที่ถูกต้อง
        If e.RowIndex >= 0 Then
            ' ดึงข้อมูลจาก DataBoundItem ของ DataGridView ที่ผูกกับ DataSource
            Dim selectedRow As DataRowView = CType(dgvLocalDoctor.Rows(e.RowIndex).DataBoundItem, DataRowView)

            ' ดึงข้อมูลจาก DataSet ที่ถูกเลือก
            SelectedClinicID = selectedRow("Clinic_ID")
            SelectedFirstName = selectedRow("LD_Name").ToString()
            SelectedLastName = selectedRow("LD_Lastname").ToString()
            SelectedTel = selectedRow("LD_Tel").ToString()
            SelectedAddress = selectedRow("Address").ToString()

            ' ปิดฟอร์มและส่งข้อมูลกลับไปยังฟอร์มหลัก
            Me.DialogResult = DialogResult.OK
            Me.Close()
        End If
    End Sub
End Class
