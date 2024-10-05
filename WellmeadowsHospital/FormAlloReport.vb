Imports System.Data.SqlClient


Public Class FormAlloReport
    Private connectionString As String = "Data Source=WARMACHINE\DATABASE62;Initial Catalog=Wellmeadows_Hospital;Integrated Security=True;Connect Timeout=30; User Instance=False"
    Dim sqlConnection As New SqlConnection(connectionString)

    Private WardBindingSource As New BindingSource
    Private StaffBindingSource As New BindingSource

    Private Sub FormAlloReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Load Allocation Data and bind to DataGridView2
        LoadAllocationData()

        ' Set the DataSource for DataGridViews to the respective BindingSources
        DataGridView2.DataSource = WardBindingSource
        DataGridView1.DataSource = StaffBindingSource

        ' Bind the event handlers
        AddHandler DataGridView2.SelectionChanged, AddressOf DataGridView2_SelectionChanged
        DataGridView1.Columns(0).Visible = False
    End Sub

    Private Sub LoadAllocationData()
        Try
            Using sqlConnection As New SqlConnection(connectionString)
                sqlConnection.Open()

                ' Load all Ward_Allocation data
                Dim selectQuery As String = "SELECT * FROM Ward_Allocation"
                Dim dataAdapter As New SqlDataAdapter(selectQuery, sqlConnection)
                Dim dataTable As New DataTable()
                dataAdapter.Fill(dataTable)

                ' Set the DataSource for the WardBindingSource
                WardBindingSource.DataSource = dataTable
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading Allocation data: " & ex.Message)
        End Try
    End Sub

    ' ฟังก์ชันสำหรับโหลดข้อมูลใน DataGridView1 (ตาราง Staff_List) โดยอ้างอิงจาก Ward_Allocation_ID
    Private Sub LoadStaffData(wardAllocationID As String)
        Try
            Using sqlConnection As New SqlConnection(connectionString)
                sqlConnection.Open()

                ' Load Staff_Allo_list data based on selected Ward_Allocation_ID
                Dim selectQuery As String = "SELECT * FROM Staff_Allo_list WHERE Ward_Allocation_ID = @Ward_Allocation_ID"
                Dim command As New SqlCommand(selectQuery, sqlConnection)
                command.Parameters.AddWithValue("@Ward_Allocation_ID", wardAllocationID)

                Dim dataAdapter As New SqlDataAdapter(command)
                Dim dataTable As New DataTable()
                dataAdapter.Fill(dataTable)

                ' Set the DataSource for the StaffBindingSource
                StaffBindingSource.DataSource = dataTable
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading Staff_List: " & ex.Message)
        End Try
    End Sub

    Private Sub FormStaffAllo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' โหลดข้อมูล Allocation ลงใน DataGridView2 เมื่อฟอร์มเริ่มต้น
        LoadAllocationData()
    End Sub


    Private Sub DataGridView2_SelectionChanged(sender As Object, e As EventArgs)
        ' ตรวจสอบว่ามีแถวที่ถูกเลือกใน Allocation List หรือไม่
        If DataGridView2.SelectedRows.Count > 0 Then
            ' ดึงค่า Ward_Allocation_ID จากแถวที่ถูกเลือกใน Allocation List
            Dim selectedWardAllocationID As String = DataGridView2.SelectedRows(0).Cells(0).Value.ToString()

            ' โหลดข้อมูล Staff ที่เชื่อมกับ Ward_Allocation_ID ที่เลือก
            LoadStaffData(selectedWardAllocationID)
        End If
    End Sub

    Private Sub TxtStaff_TextChanged(sender As Object, e As EventArgs) Handles txtStaff.TextChanged
        ' Filter the StaffBindingSource by Staff_Name
        Dim filterString As String = txtStaff.Text
        If String.IsNullOrEmpty(filterString) Then
            StaffBindingSource.Filter = "" ' Show all records
        Else
            StaffBindingSource.Filter = String.Format("[Staff Name] LIKE '%{0}%'", filterString) ' Filter by Staff_Name
        End If
    End Sub

    Private Sub TxtWard_TextChanged(sender As Object, e As EventArgs) Handles txtWard.TextChanged
        ' Filter the WardBindingSource by Ward_Allocation_ID using partial match
        Dim filterString As String = txtWard.Text
        If String.IsNullOrEmpty(filterString) Then
            WardBindingSource.Filter = "" ' Show all records
        ElseIf IsNumeric(filterString) Then
            WardBindingSource.Filter = String.Format("Convert(Ward_Allocation_ID, 'System.String') LIKE '{0}%'", filterString) ' Filter by partial Ward_Allocation_ID
        Else
            WardBindingSource.Filter = "" ' Clear filter if not numeric
        End If
    End Sub


End Class