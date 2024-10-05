Imports System.Data.SqlClient

Public Class FormInPatient
    Private connectionString As String = "Data Source=WARMACHINE\DATABASE62;Initial Catalog=Wellmeadows_Hospital;Integrated Security=True;Connect Timeout=30; User Instance=False"
    Dim sqlConnection As New SqlConnection(connectionString)

    Private Sub FormInPatient_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Wellmeadows_HospitalDataSet.InPatient' table. You can move, or remove it, as needed.
        Me.InPatientTableAdapter.Fill(Me.Wellmeadows_HospitalDataSet.InPatient)

    End Sub

    Private Sub DataGridView2_SelectionChanged(sender As Object, e As EventArgs) Handles DataGridView2.SelectionChanged
        ' ตรวจสอบว่ามีการเลือกแถวหรือไม่
        If DataGridView2.SelectedRows.Count > 0 Then
            ' ดึงข้อมูลจากแถวที่เลือก
            Dim selectedRow As DataGridViewRow = DataGridView2.SelectedRows(0)

            ' นำค่าจากเซลล์มาแสดงใน TextBox ต่างๆ
            txtPatientID.Text = selectedRow.Cells(1).Value.ToString()
            txtPatientName.Text = selectedRow.Cells(2).Value.ToString()
        End If
    End Sub


    Private Sub BtnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Try
            ' เปิดการเชื่อมต่อกับฐานข้อมูล
            sqlConnection.Open()

            ' ตรวจสอบว่ามีการเลือกแถวใน DataGridView หรือไม่
            If DataGridView2.SelectedRows.Count > 0 Then
                ' ดึงค่า OPD_ID จากแถวที่เลือก
                Dim selectedRow As DataGridViewRow = DataGridView2.SelectedRows(0)
                Dim Allocaton_ID As Integer = CInt(selectedRow.Cells(0).Value)

                ' กำหนด SQL สำหรับการ UPDATE ข้อมูลลงในแถวที่เลือก
                Dim updateQuery As String = "UPDATE Patients_Allocation SET Expected_Stays = @ExpectDays " &
                                            "WHERE Allocation_ID = @AllocatonID"

                ' ใช้ SqlCommand เพื่อดำเนินการ SQL
                Using command As New SqlCommand(updateQuery, sqlConnection)
                    ' กำหนดค่าให้กับพารามิเตอร์ใน SQL
                    command.Parameters.AddWithValue("@ExpectDays", CInt(txtDays.Text))
                    command.Parameters.AddWithValue("@AllocatonID", Allocaton_ID) ' ระบุ OPD_ID ของแถวที่เลือก

                    ' ดำเนินการ UPDATE ข้อมูลลงในตาราง
                    Dim rowsAffected As Integer = command.ExecuteNonQuery()

                    ' ตรวจสอบว่ามีการอัปเดตข้อมูลสำเร็จหรือไม่
                    If rowsAffected > 0 Then
                        MessageBox.Show("อัปเดตข้อมูลสำเร็จ", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        ' อัปเดต DataGridView ให้แสดงข้อมูลล่าสุด
                        Me.InPatientTableAdapter.Fill(Me.Wellmeadows_HospitalDataSet.InPatient)
                    Else
                        MessageBox.Show("ไม่สามารถอัปเดตข้อมูลได้", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End Using
            Else
                MessageBox.Show("กรุณาเลือกแถวที่ต้องการอัปเดต", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If

            txtDays.Clear()
            txtPatientID.Clear()
            txtPatientName.Clear()

        Catch ex As Exception
            ' จัดการข้อผิดพลาดที่เกิดขึ้น
            MessageBox.Show("เกิดข้อผิดพลาด: " & ex.Message)
        Finally
            ' ปิดการเชื่อมต่อ SQL
            If sqlConnection.State = ConnectionState.Open Then
                sqlConnection.Close()
            End If
        End Try
    End Sub
End Class