Public Class FormBedAllocation
    Public SelectedBedID

    Public SelectedWardName As String
    Public SelectedWardID

    Public SelectedLocation As String
    Public SelectedTel As String
    Private Sub FormBedAllocation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Wellmeadows_HospitalDataSet.Bed_Form' table. You can move, or remove it, as needed.
        Me.Bed_FormTableAdapter.Fill(Me.Wellmeadows_HospitalDataSet.Bed_Form)

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        If e.RowIndex >= 0 Then
            ' ดึงข้อมูลจาก DataBoundItem ของ DataGridView ที่ผูกกับ DataSource
            Dim selectedRow As DataRowView = CType(DataGridView1.Rows(e.RowIndex).DataBoundItem, DataRowView)

            ' ดึงข้อมูลจาก DataSet ที่ถูกเลือก
            SelectedBedID = selectedRow(0)

            SelectedWardID = selectedRow(1)
            SelectedWardName = selectedRow(2).ToString()

            SelectedLocation = selectedRow(3)
            SelectedTel = selectedRow(4).ToString()

            ' ปิดฟอร์มและส่งข้อมูลกลับไปยังฟอร์มหลัก
            Me.DialogResult = DialogResult.OK
            Me.Close()
        End If
    End Sub
End Class