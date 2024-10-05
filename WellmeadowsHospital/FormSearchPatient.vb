Public Class FormSearchPatient

    Public SelectedFirstName As String
    Public SelectedLastName As String
    Public SelectedPatientID
    Private Sub FormSearchPatient_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Wellmeadows_HospitalDataSet.Patients' table. You can move, or remove it, as needed.
        Me.PatientsTableAdapter.Fill(Me.Wellmeadows_HospitalDataSet.Patients)

    End Sub

    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        If e.RowIndex >= 0 Then
            ' ดึงข้อมูลจาก DataBoundItem ของ DataGridView ที่ผูกกับ DataSource
            Dim selectedRow As DataRowView = CType(DataGridView1.Rows(e.RowIndex).DataBoundItem, DataRowView)

            ' ดึงข้อมูลจาก DataSet ที่ถูกเลือก
            SelectedPatientID = selectedRow("Patients_ID")
            SelectedFirstName = selectedRow("Patient_Name").ToString()
            SelectedLastName = selectedRow("Patient_Lastname").ToString()

            ' ปิดฟอร์มและส่งข้อมูลกลับไปยังฟอร์มหลัก
            Me.DialogResult = DialogResult.OK
            Me.Close()
        End If
    End Sub
End Class