Public Class FormChargeNurse

    Public SelectedStaffID

    Public SelectedStaffName As String
    Private Sub FormChargeNurse_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Wellmeadows_HospitalDataSet.Staff_Charge_Nurse' table. You can move, or remove it, as needed.
        Me.Staff_Charge_NurseTableAdapter.Fill(Me.Wellmeadows_HospitalDataSet.Staff_Charge_Nurse)

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        If e.RowIndex >= 0 Then
            ' ดึงข้อมูลจาก DataBoundItem ของ DataGridView ที่ผูกกับ DataSource
            Dim selectedRow As DataRowView = CType(DataGridView1.Rows(e.RowIndex).DataBoundItem, DataRowView)

            SelectedStaffID = selectedRow(0)
            SelectedStaffName = selectedRow(1).ToString()

            ' ปิดฟอร์มและส่งข้อมูลกลับไปยังฟอร์มหลัก
            Me.DialogResult = DialogResult.OK
            Me.Close()
        End If
    End Sub
End Class