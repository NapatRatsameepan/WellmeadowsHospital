Imports System.Data.SqlClient

Public Class FormOutPatient
    Private connectionString As String = "Data Source=WARMACHINE\DATABASE62;Initial Catalog=Wellmeadows_Hospital;Integrated Security=True;Connect Timeout=30; User Instance=False"
    Dim sqlConnection As New SqlConnection(connectionString)

    Private Sub FormOutPatient_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Wellmeadows_HospitalDataSet.OPD' table. You can move, or remove it, as needed.
        Me.OPDTableAdapter.Fill(Me.Wellmeadows_HospitalDataSet.OPD)

        'TODO: This line of code loads data into the 'Wellmeadows_HospitalDataSet.OPDSearch' table. You can move, or remove it, as needed.


        txtWardID.ReadOnly = True
        txtWardname.ReadOnly = True


        txtWardID.Text = "12" ' Ward ID เป็นค่าเริ่มต้น
        txtWardname.Text = "Outpatient Ward" ' Ward Name เป็นค่าเริ่มต้น
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        If e.RowIndex >= 0 Then
            ' ดึงข้อมูลจากแถวที่เลือก
            Dim selectedRow As DataGridViewRow = DataGridView1.Rows(e.RowIndex)

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
            If DataGridView1.SelectedRows.Count > 0 Then
                ' ดึงค่า OPD_ID จากแถวที่เลือก
                Dim selectedRow As DataGridViewRow = DataGridView1.SelectedRows(0)
                Dim opdID As Integer = CInt(selectedRow.Cells(0).Value)

                ' กำหนด SQL สำหรับการ UPDATE ข้อมูลลงในแถวที่เลือก
                Dim updateQuery As String = "UPDATE Ward_Allocation_OPD SET OPD_appointment_date = @AppointmentDate, Ward_ID = @WardID " &
                                            "WHERE OPD_ID = @OPDID"

                ' ใช้ SqlCommand เพื่อดำเนินการ SQL
                Using command As New SqlCommand(updateQuery, sqlConnection)
                    ' กำหนดค่าให้กับพารามิเตอร์ใน SQL
                    command.Parameters.AddWithValue("@AppointmentDate", dtpAppointmentDate.Value) ' ใช้ค่าจาก DateTimePicker
                    command.Parameters.AddWithValue("@WardID", CInt(txtWardID.Text)) ' ใช้ค่า Ward ID
                    command.Parameters.AddWithValue("@OPDID", opdID) ' ระบุ OPD_ID ของแถวที่เลือก

                    ' ดำเนินการ UPDATE ข้อมูลลงในตาราง
                    Dim rowsAffected As Integer = command.ExecuteNonQuery()

                    ' ตรวจสอบว่ามีการอัปเดตข้อมูลสำเร็จหรือไม่
                    If rowsAffected > 0 Then
                        MessageBox.Show("อัปเดตข้อมูลสำเร็จ", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        ' อัปเดต DataGridView ให้แสดงข้อมูลล่าสุด
                        Me.OPDTableAdapter.Fill(Me.Wellmeadows_HospitalDataSet.OPD)
                    Else
                        MessageBox.Show("ไม่สามารถอัปเดตข้อมูลได้", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End Using
            Else
                MessageBox.Show("กรุณาเลือกแถวที่ต้องการอัปเดต", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If

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