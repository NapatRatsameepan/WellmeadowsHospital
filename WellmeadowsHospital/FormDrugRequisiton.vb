Imports System.Data.SqlClient

Public Class FormDrugRequisiton
    Private connectionString As String = "Data Source=WARMACHINE\DATABASE62;Initial Catalog=Wellmeadows_Hospital;Integrated Security=True;Connect Timeout=30; User Instance=False"
    Dim sqlConnection As New SqlConnection(connectionString)
    Private Sub FormDrugRequisiton_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Wellmeadows_HospitalDataSet.Drug' table. You can move, or remove it, as needed.
        Me.DrugTableAdapter.Fill(Me.Wellmeadows_HospitalDataSet.Drug)

    End Sub

    Private Sub BtnSUBMIT_Click(sender As Object, e As EventArgs) Handles btnSUBMIT.Click
        Try
            ' ตรวจสอบการกรอกข้อมูลในช่อง Ward และ Staff
            If String.IsNullOrEmpty(txtWardID.Text) Or String.IsNullOrEmpty(txtWardName.Text) Or String.IsNullOrEmpty(txtStaffName.Text) Then
                MessageBox.Show("กรุณากรอกข้อมูลให้ครบถ้วน", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            Dim result As DialogResult = MessageBox.Show("คุณต้องการเบิกยาใช่หรือไม่?", "ยืนยันการเบิก", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.Yes Then
                sqlConnection.Open()

                ' Insert into Drug_Requisitions_By table and get the new ID
                Dim InsertDrugRequisition As String = "INSERT INTO Drug_Requisitions_By (Drug_Requisitions_Detail, Ward_ID, Staff_ID) " &
                                                  "VALUES (@Detail, @WardID, @StaffID); " &
                                                  "SELECT SCOPE_IDENTITY();"
                Dim DrugRequisitionID As Integer

                Using command As New SqlCommand(InsertDrugRequisition, sqlConnection)
                    command.Parameters.AddWithValue("@Detail", txtRequisitionDetail.Text)
                    command.Parameters.AddWithValue("@WardID", Convert.ToInt32(txtWardID.Text))
                    command.Parameters.AddWithValue("@StaffID", Convert.ToInt32(lblStaffID.Text))

                    DrugRequisitionID = Convert.ToInt32(command.ExecuteScalar())
                End Using

                ' Insert each row from the Requisition List into Drug_Requisitions_Form table
                For Each row As DataGridViewRow In DataGridViewRequisitionList.Rows
                    If Not row.IsNewRow Then
                        Dim InsertRequisitionForm As String = "INSERT INTO Drug_Requisitions_Form (Drug_Quantity_Required, Drug_Requisition_ID, Drug_ID) " &
                                                          "VALUES (@Quantity, @RequisitionID, @DrugID);"

                        Using formCommand As New SqlCommand(InsertRequisitionForm, sqlConnection)
                            formCommand.Parameters.AddWithValue("@Quantity", Convert.ToInt32(row.Cells(6).Value))
                            formCommand.Parameters.AddWithValue("@RequisitionID", DrugRequisitionID)
                            formCommand.Parameters.AddWithValue("@DrugID", Convert.ToInt32(row.Cells(0).Value))

                            formCommand.ExecuteNonQuery()
                        End Using

                        ' Update Drug_Quantity_in_Stock for the selected drug
                        Dim UpdateStockQuantity As String = "UPDATE Drug SET Drug_Quantity_in_Stock = Drug_Quantity_in_Stock - @Quantity " &
                                                        "WHERE Drug_ID = @DrugID;"
                        Using stockCommand As New SqlCommand(UpdateStockQuantity, sqlConnection)
                            stockCommand.Parameters.AddWithValue("@Quantity", Convert.ToInt32(row.Cells(6).Value))
                            stockCommand.Parameters.AddWithValue("@DrugID", Convert.ToInt32(row.Cells(0).Value))
                            stockCommand.ExecuteNonQuery()
                        End Using
                    End If
                Next

                ' Insert into Drug_Receive table with initial status 'Pending'
                Dim InsertDrugReceive As String = "INSERT INTO Drug_Receive (Drug_Requisition_ID) " &
                                              "VALUES (@RequisitionID);"

                Using receiveCommand As New SqlCommand(InsertDrugReceive, sqlConnection)
                    receiveCommand.Parameters.AddWithValue("@RequisitionID", DrugRequisitionID)
                    receiveCommand.ExecuteNonQuery()
                End Using

                ' Clear fields and reset
                txtStaffName.Clear()
                txtWardName.Clear()
                txtWardID.Clear()
                txtRequisitionDetail.Clear()
                txtQuantity.Clear()
                DataGridViewRequisitionList.Rows.Clear()
                Me.DrugTableAdapter.Fill(Me.Wellmeadows_HospitalDataSet.Drug)

                ' Show success message
                MessageBox.Show("การเบิกยาเสร็จสิ้น", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("การเบิกยาถูกยกเลิก", "ยกเลิกการเบิกยา", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show("เกิดข้อผิดพลาด: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ' ปิดการเชื่อมต่อฐานข้อมูล
            If sqlConnection.State = ConnectionState.Open Then
                sqlConnection.Close()
            End If
        End Try
    End Sub


    Private Sub BtnDELETE_Click(sender As Object, e As EventArgs) Handles btnDELETE.Click
        ' ตรวจสอบว่ามีการเลือกแถวในตาราง Requisition List หรือไม่
        If DataGridViewRequisitionList.SelectedRows.Count = 0 Then
            MessageBox.Show("กรุณาเลือกแถวที่จะลบ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' ลบแถวที่เลือก
        DataGridViewRequisitionList.Rows.RemoveAt(DataGridViewRequisitionList.SelectedRows(0).Index)
    End Sub


    Private Sub BtnADD_Click(sender As Object, e As EventArgs) Handles btnADD.Click
        ' ตรวจสอบว่ามีการเลือกแถวจาก DataGridView Drug และกรอก Quantity หรือไม่
        If DataGridViewItemList.SelectedRows.Count = 0 Then
            MessageBox.Show("กรุณาเลือกยา", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If String.IsNullOrWhiteSpace(txtQuantity.Text) Then
            MessageBox.Show("กรุณากรอกจำนวน", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' ดึงข้อมูลจากแถวที่เลือกในตาราง Drug
        Dim selectedRow As DataGridViewRow = DataGridViewItemList.SelectedRows(0)
        Dim drugID As String = selectedRow.Cells(0).Value.ToString()
        Dim drugName As String = selectedRow.Cells(1).Value.ToString()
        Dim drugDetail As String = selectedRow.Cells(2).Value.ToString()
        Dim dosage As String = selectedRow.Cells(3).Value.ToString()
        Dim method As String = selectedRow.Cells(4).Value.ToString()
        Dim cpu As Decimal = Convert.ToDecimal(selectedRow.Cells(6).Value)
        Dim quantity As Integer = Convert.ToInt32(txtQuantity.Text)

        ' ตรวจสอบปริมาณในคลังว่ามีเพียงพอหรือไม่
        Dim stockQuantity As Integer = Convert.ToInt32(selectedRow.Cells(5).Value)
        If quantity > stockQuantity Then
            MessageBox.Show("ปริมาณยาในคลังไม่เพียงพอ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' เพิ่มข้อมูลลงใน DataGridView Requisition List
        DataGridViewRequisitionList.Rows.Add(drugID, drugName, drugDetail, dosage, method, cpu, quantity)

        ' ล้างค่าในช่อง Quantity
        txtQuantity.Clear()
    End Sub

    Private Sub BtnWardSearch_Click(sender As Object, e As EventArgs) Handles btnWardSearch.Click
        Dim searchForm As New FormWardSearch()
        If searchForm.ShowDialog() = DialogResult.OK Then
            txtWardID.Text = searchForm.SelectedWardID
            txtWardName.Text = searchForm.SelectedWardName
        End If
    End Sub

    Private Sub BtnStaffSearch_Click(sender As Object, e As EventArgs) Handles btnStaffSearch.Click
        Dim searchForm As New FormStaffSearch()
        If searchForm.ShowDialog() = DialogResult.OK Then

            lblStaffID.Text = searchForm.SelectedStaffID
            txtStaffName.Text = searchForm.SelectedFirstName & " " & searchForm.SelectedLastName
        End If
    End Sub
End Class