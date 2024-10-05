Imports System.Data.SqlClient

Public Class FormItemRequisiton
    Private connectionString As String = "Data Source=WARMACHINE\DATABASE62;Initial Catalog=Wellmeadows_Hospital;Integrated Security=True;Connect Timeout=30; User Instance=False"
    Dim sqlConnection As New SqlConnection(connectionString)
    Private Sub FormItemRequisiton_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Wellmeadows_HospitalDataSet.Item' table. You can move, or remove it, as needed.
        Me.ItemTableAdapter.Fill(Me.Wellmeadows_HospitalDataSet.Item)

    End Sub

    Private Sub BtnSUBMIT_Click(sender As Object, e As EventArgs) Handles btnSUBMIT.Click
        Try
            ' ตรวจสอบการกรอกข้อมูลในช่อง Ward และ Staff
            If String.IsNullOrEmpty(txtWardID.Text) Or String.IsNullOrEmpty(txtWardName.Text) Or String.IsNullOrEmpty(txtStaffName.Text) Then
                MessageBox.Show("กรุณากรอกข้อมูลให้ครบถ้วน", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            Dim result As DialogResult = MessageBox.Show("คุณต้องการเบิกอุปกรณ์ใช่หรือไม่?", "ยืนยันการเบิก", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.Yes Then
                sqlConnection.Open()

                ' Insert into Item_Requisitions_By table and get the new ID
                Dim InsertItemRequisition As String = "INSERT INTO Item_Requisitions_By (Item_Requisitions_Detail, Ward_ID, Staff_ID) " &
                                                  "VALUES (@Detail, @WardID, @StaffID); " &
                                                  "SELECT SCOPE_IDENTITY();"
                Dim ItemRequisitionID As Integer

                Using command As New SqlCommand(InsertItemRequisition, sqlConnection)
                    command.Parameters.AddWithValue("@Detail", txtRequisitionDetail.Text)
                    command.Parameters.AddWithValue("@WardID", Convert.ToInt32(txtWardID.Text))
                    command.Parameters.AddWithValue("@StaffID", Convert.ToInt32(lblStaffID.Text))

                    ItemRequisitionID = Convert.ToInt32(command.ExecuteScalar())
                End Using

                ' Insert each row from the Requisition List into Item_Requisitions_Form table
                For Each row As DataGridViewRow In DataGridViewRequisitionList.Rows
                    If Not row.IsNewRow Then
                        Dim InsertRequisitionForm As String = "INSERT INTO Item_Requisitions_Form (Item_Quantity_Required, Item_Requisition_ID, Item_ID) " &
                                                          "VALUES (@Quantity, @RequisitionID, @ItemID);"

                        Using formCommand As New SqlCommand(InsertRequisitionForm, sqlConnection)
                            formCommand.Parameters.AddWithValue("@Quantity", Convert.ToInt32(row.Cells(4).Value))
                            formCommand.Parameters.AddWithValue("@RequisitionID", ItemRequisitionID)
                            formCommand.Parameters.AddWithValue("@ItemID", Convert.ToInt32(row.Cells(0).Value))

                            formCommand.ExecuteNonQuery()
                        End Using


                        ' Update Drug_Quantity_in_Stock for the selected drug
                        Dim UpdateStockQuantity As String = "UPDATE Item SET Item_Quantity_in_Stock = Item_Quantity_in_Stock - @Quantity " &
                                                        "WHERE Item_ID = @ItemID;"
                        Using stockCommand As New SqlCommand(UpdateStockQuantity, sqlConnection)
                            stockCommand.Parameters.AddWithValue("@Quantity", Convert.ToInt32(row.Cells(4).Value))
                            stockCommand.Parameters.AddWithValue("@ItemID", Convert.ToInt32(row.Cells(0).Value))
                            stockCommand.ExecuteNonQuery()
                        End Using
                    End If
                Next

                ' Insert into Item_Receive table with initial status 'Pending'
                Dim InsertItemReceive As String = "INSERT INTO Item_Receive (Item_Requisition_ID) " &
                                              "VALUES (@RequisitionID);"

                Using receiveCommand As New SqlCommand(InsertItemReceive, sqlConnection)
                    receiveCommand.Parameters.AddWithValue("@RequisitionID", ItemRequisitionID)
                    receiveCommand.ExecuteNonQuery()
                End Using

                txtStaffName.Clear()
                txtWardName.Clear()
                txtWardID.Clear()
                txtRequisitionDetail.Clear()
                txtQuantity.Clear()
                DataGridViewRequisitionList.Rows.Clear()
                Me.ItemTableAdapter.Fill(Me.Wellmeadows_HospitalDataSet.Item)

                ' Show success message
                MessageBox.Show("การเบิกอุปกรณ์เสร็จสิ้น", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("การเบิกอุปกรณ์ถูกยกเลิก", "ยกเลิกการเบิกอุปกรณ์", MessageBoxButtons.OK, MessageBoxIcon.Information)
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
        ' ตรวจสอบว่ามีการเลือกแถวจาก DataGridView Item และกรอก Quantity หรือไม่
        If DataGridViewItemList.SelectedRows.Count = 0 Then
            MessageBox.Show("กรุณาเลือกยา", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If String.IsNullOrWhiteSpace(txtQuantity.Text) Then
            MessageBox.Show("กรุณากรอกจำนวน", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' ดึงข้อมูลจากแถวที่เลือกในตาราง Item
        Dim selectedRow As DataGridViewRow = DataGridViewItemList.SelectedRows(0)
        Dim ItemID As String = selectedRow.Cells(0).Value.ToString()
        Dim ItemName As String = selectedRow.Cells(1).Value.ToString()
        Dim ItemDetail As String = selectedRow.Cells(2).Value.ToString()
        Dim cpu As Decimal = Convert.ToDecimal(selectedRow.Cells(4).Value)
        Dim quantity As Integer = Convert.ToInt32(txtQuantity.Text)

        ' ตรวจสอบปริมาณในคลังว่ามีเพียงพอหรือไม่
        Dim stockQuantity As Integer = Convert.ToInt32(selectedRow.Cells(3).Value)
        If quantity > stockQuantity Then
            MessageBox.Show("ปริมาณยาในคลังไม่เพียงพอ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' เพิ่มข้อมูลลงใน DataGridView Requisition List
        DataGridViewRequisitionList.Rows.Add(ItemID, ItemName, ItemDetail, cpu, quantity)

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