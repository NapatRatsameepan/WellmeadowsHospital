Imports System.Data.SqlClient


Public Class FormPAllocation
    Public SelectedPatientName As String
    Public SelectedPatientID

    Public SelectedWardName As String
    Public SelectedWardID

    Public SelectedBedID
    Private Sub FormPAllocation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Wellmeadows_HospitalDataSet.PAllocation2' table. You can move, or remove it, as needed.
        Me.PAllocation2TableAdapter.Fill(Me.Wellmeadows_HospitalDataSet.PAllocation2)

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        If e.RowIndex >= 0 Then
            ' ดึงข้อมูลจาก DataBoundItem ของ DataGridView ที่ผูกกับ DataSource
            Dim selectedRow As DataRowView = CType(DataGridView1.Rows(e.RowIndex).DataBoundItem, DataRowView)

            ' ดึงข้อมูลจาก DataSet ที่ถูกเลือก
            SelectedPatientID = selectedRow(7)
            SelectedPatientName = selectedRow(8).ToString()

            SelectedWardID = selectedRow(12)
            SelectedWardName = selectedRow(13).ToString()

            SelectedBedID = selectedRow(11)

            ' ปิดฟอร์มและส่งข้อมูลกลับไปยังฟอร์มหลัก
            Me.DialogResult = DialogResult.OK
            Me.Close()
        End If
    End Sub
End Class