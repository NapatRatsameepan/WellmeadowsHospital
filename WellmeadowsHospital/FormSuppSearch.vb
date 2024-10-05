Public Class FormSuppSearch
    Public SelectedSuppID
    Public SelectedSuppName As String

    Private Sub FormSuppSearch_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Wellmeadows_HospitalDataSet.Suppliers' table. You can move, or remove it, as needed.
        Me.SuppliersTableAdapter.Fill(Me.Wellmeadows_HospitalDataSet.Suppliers)

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        If e.RowIndex >= 0 Then
            ' ดึงข้อมูลจาก DataBoundItem ของ DataGridView ที่ผูกกับ DataSource
            Dim selectedRow As DataRowView = CType(DataGridView1.Rows(e.RowIndex).DataBoundItem, DataRowView)

            ' ดึงข้อมูลจาก DataSet ที่ถูกเลือก
            SelectedSuppID = selectedRow(0)
            SelectedSuppName = selectedRow(1).ToString()
            ' ปิดฟอร์มและส่งข้อมูลกลับไปยังฟอร์มหลัก
            Me.DialogResult = DialogResult.OK
            Me.Close()
        End If
    End Sub
End Class