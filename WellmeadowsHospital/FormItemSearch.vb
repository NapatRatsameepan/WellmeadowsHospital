Public Class FormItemSearch
    Public SelectedItemID
    Public SelectedItemName As String
    Public SelectedCost As Decimal

    Private Sub FormItemSearch_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Wellmeadows_HospitalDataSet.Item' table. You can move, or remove it, as needed.
        Me.ItemTableAdapter.Fill(Me.Wellmeadows_HospitalDataSet.Item)

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        If e.RowIndex >= 0 Then
            ' ดึงข้อมูลจาก DataBoundItem ของ DataGridView ที่ผูกกับ DataSource
            Dim selectedRow As DataRowView = CType(DataGridView1.Rows(e.RowIndex).DataBoundItem, DataRowView)

            ' ดึงข้อมูลจาก DataSet ที่ถูกเลือก
            SelectedItemID = selectedRow(0)
            SelectedItemName = selectedRow(1).ToString()
            SelectedCost = Convert.ToDecimal(selectedRow(5))
            ' ปิดฟอร์มและส่งข้อมูลกลับไปยังฟอร์มหลัก
            Me.DialogResult = DialogResult.OK
            Me.Close()
        End If
    End Sub
End Class