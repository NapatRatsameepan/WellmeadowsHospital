<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPatientWaitingList
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.TableLayoutPanel8 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnSUBMIT = New System.Windows.Forms.Button()
        Me.btnBedSearch = New System.Windows.Forms.Button()
        Me.txtBedID = New System.Windows.Forms.TextBox()
        Me.Label73 = New System.Windows.Forms.Label()
        Me.dtpDateLeave = New System.Windows.Forms.DateTimePicker()
        Me.Label71 = New System.Windows.Forms.Label()
        Me.dtpDatePlaced = New System.Windows.Forms.DateTimePicker()
        Me.Label70 = New System.Windows.Forms.Label()
        Me.txtExpectedStays = New System.Windows.Forms.TextBox()
        Me.Label69 = New System.Windows.Forms.Label()
        Me.Label58 = New System.Windows.Forms.Label()
        Me.txtPatientsName = New System.Windows.Forms.TextBox()
        Me.Label57 = New System.Windows.Forms.Label()
        Me.txtPatientID = New System.Windows.Forms.TextBox()
        Me.Label56 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.DataGridView6 = New System.Windows.Forms.DataGridView()
        Me.AllocationIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DatePlacedDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ExpectedStaysDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateLeaveDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ActualLeaveDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OnWaitinglistDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WaitingStatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PatientsIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PatientsNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StaffIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BedIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Waiting_List_3BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Wellmeadows_HospitalDataSet = New WellmeadowsHospital.Wellmeadows_HospitalDataSet()
        Me.txtTel = New System.Windows.Forms.TextBox()
        Me.Label55 = New System.Windows.Forms.Label()
        Me.txtLocation = New System.Windows.Forms.TextBox()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.txtWardName = New System.Windows.Forms.TextBox()
        Me.txtWardID = New System.Windows.Forms.TextBox()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.cmbWaitingStatus = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtpOnWaitingList = New System.Windows.Forms.DateTimePicker()
        Me.txtStaffName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Staff_ID = New System.Windows.Forms.Label()
        Me.btnChargeNurse = New System.Windows.Forms.Button()
        Me.Waiting_List_3TableAdapter = New WellmeadowsHospital.Wellmeadows_HospitalDataSetTableAdapters.Waiting_List_3TableAdapter()
        Me.TableAdapterManager = New WellmeadowsHospital.Wellmeadows_HospitalDataSetTableAdapters.TableAdapterManager()
        Me.lblAllocationID = New System.Windows.Forms.Label()
        Me.TableLayoutPanel8.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.DataGridView6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Waiting_List_3BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Wellmeadows_HospitalDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel8
        '
        Me.TableLayoutPanel8.ColumnCount = 1
        Me.TableLayoutPanel8.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel8.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel8.Controls.Add(Me.btnSUBMIT, 0, 0)
        Me.TableLayoutPanel8.Location = New System.Drawing.Point(838, 341)
        Me.TableLayoutPanel8.Name = "TableLayoutPanel8"
        Me.TableLayoutPanel8.RowCount = 1
        Me.TableLayoutPanel8.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel8.Size = New System.Drawing.Size(148, 44)
        Me.TableLayoutPanel8.TabIndex = 257
        '
        'btnSUBMIT
        '
        Me.btnSUBMIT.BackColor = System.Drawing.Color.LimeGreen
        Me.btnSUBMIT.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnSUBMIT.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSUBMIT.Location = New System.Drawing.Point(10, 3)
        Me.btnSUBMIT.Margin = New System.Windows.Forms.Padding(10, 3, 10, 3)
        Me.btnSUBMIT.Name = "btnSUBMIT"
        Me.btnSUBMIT.Size = New System.Drawing.Size(128, 38)
        Me.btnSUBMIT.TabIndex = 35
        Me.btnSUBMIT.Text = "SUBMIT"
        Me.btnSUBMIT.UseVisualStyleBackColor = False
        '
        'btnBedSearch
        '
        Me.btnBedSearch.Location = New System.Drawing.Point(954, 302)
        Me.btnBedSearch.Name = "btnBedSearch"
        Me.btnBedSearch.Size = New System.Drawing.Size(32, 23)
        Me.btnBedSearch.TabIndex = 256
        Me.btnBedSearch.Text = "..."
        Me.btnBedSearch.UseVisualStyleBackColor = True
        '
        'txtBedID
        '
        Me.txtBedID.Location = New System.Drawing.Point(780, 302)
        Me.txtBedID.Name = "txtBedID"
        Me.txtBedID.Size = New System.Drawing.Size(168, 22)
        Me.txtBedID.TabIndex = 254
        '
        'Label73
        '
        Me.Label73.AutoSize = True
        Me.Label73.Location = New System.Drawing.Point(777, 283)
        Me.Label73.Name = "Label73"
        Me.Label73.Size = New System.Drawing.Size(48, 16)
        Me.Label73.TabIndex = 255
        Me.Label73.Text = "Bed ID"
        '
        'dtpDateLeave
        '
        Me.dtpDateLeave.Enabled = False
        Me.dtpDateLeave.Location = New System.Drawing.Point(556, 300)
        Me.dtpDateLeave.Name = "dtpDateLeave"
        Me.dtpDateLeave.Size = New System.Drawing.Size(200, 22)
        Me.dtpDateLeave.TabIndex = 251
        '
        'Label71
        '
        Me.Label71.AutoSize = True
        Me.Label71.Location = New System.Drawing.Point(553, 281)
        Me.Label71.Name = "Label71"
        Me.Label71.Size = New System.Drawing.Size(77, 16)
        Me.Label71.TabIndex = 250
        Me.Label71.Text = "Date Leave"
        '
        'dtpDatePlaced
        '
        Me.dtpDatePlaced.Location = New System.Drawing.Point(556, 244)
        Me.dtpDatePlaced.Name = "dtpDatePlaced"
        Me.dtpDatePlaced.Size = New System.Drawing.Size(200, 22)
        Me.dtpDatePlaced.TabIndex = 249
        '
        'Label70
        '
        Me.Label70.AutoSize = True
        Me.Label70.Location = New System.Drawing.Point(553, 225)
        Me.Label70.Name = "Label70"
        Me.Label70.Size = New System.Drawing.Size(82, 16)
        Me.Label70.TabIndex = 248
        Me.Label70.Text = "Date Placed"
        '
        'txtExpectedStays
        '
        Me.txtExpectedStays.Enabled = False
        Me.txtExpectedStays.Location = New System.Drawing.Point(350, 302)
        Me.txtExpectedStays.Name = "txtExpectedStays"
        Me.txtExpectedStays.Size = New System.Drawing.Size(188, 22)
        Me.txtExpectedStays.TabIndex = 246
        '
        'Label69
        '
        Me.Label69.AutoSize = True
        Me.Label69.Location = New System.Drawing.Point(347, 283)
        Me.Label69.Name = "Label69"
        Me.Label69.Size = New System.Drawing.Size(143, 16)
        Me.Label69.TabIndex = 247
        Me.Label69.Text = "Expected Stay ( Days )"
        '
        'Label58
        '
        Me.Label58.AutoSize = True
        Me.Label58.Location = New System.Drawing.Point(347, 225)
        Me.Label58.Name = "Label58"
        Me.Label58.Size = New System.Drawing.Size(92, 16)
        Me.Label58.TabIndex = 245
        Me.Label58.Text = "On Wating List"
        '
        'txtPatientsName
        '
        Me.txtPatientsName.Enabled = False
        Me.txtPatientsName.Location = New System.Drawing.Point(133, 302)
        Me.txtPatientsName.Name = "txtPatientsName"
        Me.txtPatientsName.Size = New System.Drawing.Size(188, 22)
        Me.txtPatientsName.TabIndex = 242
        '
        'Label57
        '
        Me.Label57.AutoSize = True
        Me.Label57.Location = New System.Drawing.Point(130, 283)
        Me.Label57.Name = "Label57"
        Me.Label57.Size = New System.Drawing.Size(88, 16)
        Me.Label57.TabIndex = 243
        Me.Label57.Text = "Patient Name"
        '
        'txtPatientID
        '
        Me.txtPatientID.Enabled = False
        Me.txtPatientID.Location = New System.Drawing.Point(133, 244)
        Me.txtPatientID.Name = "txtPatientID"
        Me.txtPatientID.Size = New System.Drawing.Size(188, 22)
        Me.txtPatientID.TabIndex = 240
        '
        'Label56
        '
        Me.Label56.AutoSize = True
        Me.Label56.Location = New System.Drawing.Point(130, 225)
        Me.Label56.Name = "Label56"
        Me.Label56.Size = New System.Drawing.Size(64, 16)
        Me.Label56.TabIndex = 241
        Me.Label56.Text = "Patient ID"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.DataGridView6)
        Me.Panel2.Location = New System.Drawing.Point(133, 403)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(853, 346)
        Me.Panel2.TabIndex = 239
        '
        'DataGridView6
        '
        Me.DataGridView6.AutoGenerateColumns = False
        Me.DataGridView6.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView6.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.AllocationIDDataGridViewTextBoxColumn, Me.DatePlacedDataGridViewTextBoxColumn, Me.ExpectedStaysDataGridViewTextBoxColumn, Me.DateLeaveDataGridViewTextBoxColumn, Me.ActualLeaveDataGridViewTextBoxColumn, Me.OnWaitinglistDataGridViewTextBoxColumn, Me.WaitingStatusDataGridViewTextBoxColumn, Me.PatientsIDDataGridViewTextBoxColumn, Me.PatientsNameDataGridViewTextBoxColumn, Me.StaffIDDataGridViewTextBoxColumn, Me.BedIDDataGridViewTextBoxColumn})
        Me.DataGridView6.DataSource = Me.Waiting_List_3BindingSource
        Me.DataGridView6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView6.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView6.Name = "DataGridView6"
        Me.DataGridView6.RowHeadersWidth = 51
        Me.DataGridView6.RowTemplate.Height = 24
        Me.DataGridView6.Size = New System.Drawing.Size(853, 346)
        Me.DataGridView6.TabIndex = 0
        '
        'AllocationIDDataGridViewTextBoxColumn
        '
        Me.AllocationIDDataGridViewTextBoxColumn.DataPropertyName = "Allocation_ID"
        Me.AllocationIDDataGridViewTextBoxColumn.HeaderText = "Allocation_ID"
        Me.AllocationIDDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.AllocationIDDataGridViewTextBoxColumn.Name = "AllocationIDDataGridViewTextBoxColumn"
        Me.AllocationIDDataGridViewTextBoxColumn.Width = 125
        '
        'DatePlacedDataGridViewTextBoxColumn
        '
        Me.DatePlacedDataGridViewTextBoxColumn.DataPropertyName = "Date_Placed"
        Me.DatePlacedDataGridViewTextBoxColumn.HeaderText = "Date_Placed"
        Me.DatePlacedDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.DatePlacedDataGridViewTextBoxColumn.Name = "DatePlacedDataGridViewTextBoxColumn"
        Me.DatePlacedDataGridViewTextBoxColumn.Width = 125
        '
        'ExpectedStaysDataGridViewTextBoxColumn
        '
        Me.ExpectedStaysDataGridViewTextBoxColumn.DataPropertyName = "Expected_Stays"
        Me.ExpectedStaysDataGridViewTextBoxColumn.HeaderText = "Expected_Stays"
        Me.ExpectedStaysDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.ExpectedStaysDataGridViewTextBoxColumn.Name = "ExpectedStaysDataGridViewTextBoxColumn"
        Me.ExpectedStaysDataGridViewTextBoxColumn.Width = 125
        '
        'DateLeaveDataGridViewTextBoxColumn
        '
        Me.DateLeaveDataGridViewTextBoxColumn.DataPropertyName = "Date_Leave"
        Me.DateLeaveDataGridViewTextBoxColumn.HeaderText = "Date_Leave"
        Me.DateLeaveDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.DateLeaveDataGridViewTextBoxColumn.Name = "DateLeaveDataGridViewTextBoxColumn"
        Me.DateLeaveDataGridViewTextBoxColumn.Width = 125
        '
        'ActualLeaveDataGridViewTextBoxColumn
        '
        Me.ActualLeaveDataGridViewTextBoxColumn.DataPropertyName = "Actual_Leave"
        Me.ActualLeaveDataGridViewTextBoxColumn.HeaderText = "Actual_Leave"
        Me.ActualLeaveDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.ActualLeaveDataGridViewTextBoxColumn.Name = "ActualLeaveDataGridViewTextBoxColumn"
        Me.ActualLeaveDataGridViewTextBoxColumn.Width = 125
        '
        'OnWaitinglistDataGridViewTextBoxColumn
        '
        Me.OnWaitinglistDataGridViewTextBoxColumn.DataPropertyName = "On_Waiting_list"
        Me.OnWaitinglistDataGridViewTextBoxColumn.HeaderText = "On_Waiting_list"
        Me.OnWaitinglistDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.OnWaitinglistDataGridViewTextBoxColumn.Name = "OnWaitinglistDataGridViewTextBoxColumn"
        Me.OnWaitinglistDataGridViewTextBoxColumn.Width = 125
        '
        'WaitingStatusDataGridViewTextBoxColumn
        '
        Me.WaitingStatusDataGridViewTextBoxColumn.DataPropertyName = "Waiting_Status"
        Me.WaitingStatusDataGridViewTextBoxColumn.HeaderText = "Waiting_Status"
        Me.WaitingStatusDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.WaitingStatusDataGridViewTextBoxColumn.Name = "WaitingStatusDataGridViewTextBoxColumn"
        Me.WaitingStatusDataGridViewTextBoxColumn.Width = 125
        '
        'PatientsIDDataGridViewTextBoxColumn
        '
        Me.PatientsIDDataGridViewTextBoxColumn.DataPropertyName = "Patients_ID"
        Me.PatientsIDDataGridViewTextBoxColumn.HeaderText = "Patients_ID"
        Me.PatientsIDDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.PatientsIDDataGridViewTextBoxColumn.Name = "PatientsIDDataGridViewTextBoxColumn"
        Me.PatientsIDDataGridViewTextBoxColumn.Width = 125
        '
        'PatientsNameDataGridViewTextBoxColumn
        '
        Me.PatientsNameDataGridViewTextBoxColumn.DataPropertyName = "Patients Name"
        Me.PatientsNameDataGridViewTextBoxColumn.HeaderText = "Patients Name"
        Me.PatientsNameDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.PatientsNameDataGridViewTextBoxColumn.Name = "PatientsNameDataGridViewTextBoxColumn"
        Me.PatientsNameDataGridViewTextBoxColumn.ReadOnly = True
        Me.PatientsNameDataGridViewTextBoxColumn.Width = 125
        '
        'StaffIDDataGridViewTextBoxColumn
        '
        Me.StaffIDDataGridViewTextBoxColumn.DataPropertyName = "Staff_ID"
        Me.StaffIDDataGridViewTextBoxColumn.HeaderText = "Staff_ID"
        Me.StaffIDDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.StaffIDDataGridViewTextBoxColumn.Name = "StaffIDDataGridViewTextBoxColumn"
        Me.StaffIDDataGridViewTextBoxColumn.Width = 125
        '
        'BedIDDataGridViewTextBoxColumn
        '
        Me.BedIDDataGridViewTextBoxColumn.DataPropertyName = "Bed_ID"
        Me.BedIDDataGridViewTextBoxColumn.HeaderText = "Bed_ID"
        Me.BedIDDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.BedIDDataGridViewTextBoxColumn.Name = "BedIDDataGridViewTextBoxColumn"
        Me.BedIDDataGridViewTextBoxColumn.Width = 125
        '
        'Waiting_List_3BindingSource
        '
        Me.Waiting_List_3BindingSource.DataMember = "Waiting_List_3"
        Me.Waiting_List_3BindingSource.DataSource = Me.Wellmeadows_HospitalDataSet
        '
        'Wellmeadows_HospitalDataSet
        '
        Me.Wellmeadows_HospitalDataSet.DataSetName = "Wellmeadows_HospitalDataSet"
        Me.Wellmeadows_HospitalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'txtTel
        '
        Me.txtTel.Location = New System.Drawing.Point(626, 164)
        Me.txtTel.Name = "txtTel"
        Me.txtTel.Size = New System.Drawing.Size(188, 22)
        Me.txtTel.TabIndex = 237
        '
        'Label55
        '
        Me.Label55.AutoSize = True
        Me.Label55.Location = New System.Drawing.Point(623, 145)
        Me.Label55.Name = "Label55"
        Me.Label55.Size = New System.Drawing.Size(61, 16)
        Me.Label55.TabIndex = 238
        Me.Label55.Text = "Tel. Extn."
        '
        'txtLocation
        '
        Me.txtLocation.Location = New System.Drawing.Point(284, 164)
        Me.txtLocation.Name = "txtLocation"
        Me.txtLocation.Size = New System.Drawing.Size(188, 22)
        Me.txtLocation.TabIndex = 235
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Location = New System.Drawing.Point(281, 145)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(58, 16)
        Me.Label38.TabIndex = 236
        Me.Label38.Text = "Location"
        '
        'txtWardName
        '
        Me.txtWardName.Location = New System.Drawing.Point(626, 110)
        Me.txtWardName.Name = "txtWardName"
        Me.txtWardName.Size = New System.Drawing.Size(188, 22)
        Me.txtWardName.TabIndex = 231
        '
        'txtWardID
        '
        Me.txtWardID.Location = New System.Drawing.Point(284, 110)
        Me.txtWardID.Name = "txtWardID"
        Me.txtWardID.Size = New System.Drawing.Size(188, 22)
        Me.txtWardID.TabIndex = 229
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Location = New System.Drawing.Point(623, 91)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(80, 16)
        Me.Label34.TabIndex = 232
        Me.Label34.Text = "Ward Name"
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Location = New System.Drawing.Point(281, 91)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(56, 16)
        Me.Label35.TabIndex = 230
        Me.Label35.Text = "Ward ID"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label30.Location = New System.Drawing.Point(456, 25)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(198, 38)
        Me.Label30.TabIndex = 224
        Me.Label30.Text = "IN-PATIENT"
        '
        'cmbWaitingStatus
        '
        Me.cmbWaitingStatus.FormattingEnabled = True
        Me.cmbWaitingStatus.Items.AddRange(New Object() {"Assigned", "Discharged"})
        Me.cmbWaitingStatus.Location = New System.Drawing.Point(780, 244)
        Me.cmbWaitingStatus.Name = "cmbWaitingStatus"
        Me.cmbWaitingStatus.Size = New System.Drawing.Size(206, 24)
        Me.cmbWaitingStatus.TabIndex = 258
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(777, 225)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 16)
        Me.Label1.TabIndex = 259
        Me.Label1.Text = "Waiting Status"
        '
        'dtpOnWaitingList
        '
        Me.dtpOnWaitingList.Enabled = False
        Me.dtpOnWaitingList.Location = New System.Drawing.Point(350, 244)
        Me.dtpOnWaitingList.Name = "dtpOnWaitingList"
        Me.dtpOnWaitingList.Size = New System.Drawing.Size(188, 22)
        Me.dtpOnWaitingList.TabIndex = 260
        '
        'txtStaffName
        '
        Me.txtStaffName.Location = New System.Drawing.Point(861, 28)
        Me.txtStaffName.Name = "txtStaffName"
        Me.txtStaffName.Size = New System.Drawing.Size(188, 22)
        Me.txtStaffName.TabIndex = 261
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(858, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 16)
        Me.Label2.TabIndex = 262
        Me.Label2.Text = "Staff Name"
        '
        'Staff_ID
        '
        Me.Staff_ID.AutoSize = True
        Me.Staff_ID.Location = New System.Drawing.Point(858, 63)
        Me.Staff_ID.Name = "Staff_ID"
        Me.Staff_ID.Size = New System.Drawing.Size(49, 16)
        Me.Staff_ID.TabIndex = 263
        Me.Staff_ID.Text = "Staff ID"
        Me.Staff_ID.Visible = False
        '
        'btnChargeNurse
        '
        Me.btnChargeNurse.Location = New System.Drawing.Point(1055, 28)
        Me.btnChargeNurse.Name = "btnChargeNurse"
        Me.btnChargeNurse.Size = New System.Drawing.Size(32, 23)
        Me.btnChargeNurse.TabIndex = 264
        Me.btnChargeNurse.Text = "..."
        Me.btnChargeNurse.UseVisualStyleBackColor = True
        '
        'Waiting_List_3TableAdapter
        '
        Me.Waiting_List_3TableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.Allocation_ListTableAdapter = Nothing
        Me.TableAdapterManager.Allocation_ToTableAdapter = Nothing
        Me.TableAdapterManager.AppointmentTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BedTableAdapter = Nothing
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.Drug_Order_DetailTableAdapter = Nothing
        Me.TableAdapterManager.Drug_OrderTableAdapter = Nothing
        Me.TableAdapterManager.Drug_ReceiveTableAdapter = Nothing
        Me.TableAdapterManager.Drug_Requisitions_ByTableAdapter = Nothing
        Me.TableAdapterManager.Drug_Requisitions_FormTableAdapter = Nothing
        Me.TableAdapterManager.DrugTableAdapter = Nothing
        Me.TableAdapterManager.Item_Order_DetailTableAdapter = Nothing
        Me.TableAdapterManager.Item_OrderTableAdapter = Nothing
        Me.TableAdapterManager.Item_ReceiveTableAdapter = Nothing
        Me.TableAdapterManager.Item_Requisitions_ByTableAdapter = Nothing
        Me.TableAdapterManager.Item_Requisitions_FormTableAdapter = Nothing
        Me.TableAdapterManager.ItemTableAdapter = Nothing
        Me.TableAdapterManager.Local_DoctorTableAdapter = Nothing
        Me.TableAdapterManager.Next_of_KinTableAdapter = Nothing
        Me.TableAdapterManager.Patients_AllocationTableAdapter = Nothing
        Me.TableAdapterManager.PatientsTableAdapter = Nothing
        Me.TableAdapterManager.PositionTableAdapter = Nothing
        Me.TableAdapterManager.PrescribedDrugTableAdapter = Nothing
        Me.TableAdapterManager.PrescribeTableAdapter = Nothing
        Me.TableAdapterManager.QualificationTableAdapter = Nothing
        Me.TableAdapterManager.Salary_ScaleTableAdapter = Nothing
        Me.TableAdapterManager.StaffTableAdapter = Nothing
        Me.TableAdapterManager.SuppliersTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = WellmeadowsHospital.Wellmeadows_HospitalDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.Ward_Allocation_OPDTableAdapter = Nothing
        Me.TableAdapterManager.WardTableAdapter = Nothing
        Me.TableAdapterManager.Work_ExperienceTableAdapter = Nothing
        '
        'lblAllocationID
        '
        Me.lblAllocationID.AutoSize = True
        Me.lblAllocationID.Location = New System.Drawing.Point(858, 91)
        Me.lblAllocationID.Name = "lblAllocationID"
        Me.lblAllocationID.Size = New System.Drawing.Size(82, 16)
        Me.lblAllocationID.TabIndex = 265
        Me.lblAllocationID.Text = "Allocation ID"
        Me.lblAllocationID.Visible = False
        '
        'FormPatientWaitingList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1117, 775)
        Me.Controls.Add(Me.lblAllocationID)
        Me.Controls.Add(Me.btnChargeNurse)
        Me.Controls.Add(Me.Staff_ID)
        Me.Controls.Add(Me.txtStaffName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dtpOnWaitingList)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbWaitingStatus)
        Me.Controls.Add(Me.TableLayoutPanel8)
        Me.Controls.Add(Me.btnBedSearch)
        Me.Controls.Add(Me.txtBedID)
        Me.Controls.Add(Me.Label73)
        Me.Controls.Add(Me.dtpDateLeave)
        Me.Controls.Add(Me.Label71)
        Me.Controls.Add(Me.dtpDatePlaced)
        Me.Controls.Add(Me.Label70)
        Me.Controls.Add(Me.txtExpectedStays)
        Me.Controls.Add(Me.Label69)
        Me.Controls.Add(Me.Label58)
        Me.Controls.Add(Me.txtPatientsName)
        Me.Controls.Add(Me.Label57)
        Me.Controls.Add(Me.txtPatientID)
        Me.Controls.Add(Me.Label56)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.txtTel)
        Me.Controls.Add(Me.Label55)
        Me.Controls.Add(Me.txtLocation)
        Me.Controls.Add(Me.Label38)
        Me.Controls.Add(Me.txtWardName)
        Me.Controls.Add(Me.txtWardID)
        Me.Controls.Add(Me.Label34)
        Me.Controls.Add(Me.Label35)
        Me.Controls.Add(Me.Label30)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormPatientWaitingList"
        Me.Text = "FormPatientWaitingList"
        Me.TableLayoutPanel8.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.DataGridView6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Waiting_List_3BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Wellmeadows_HospitalDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TableLayoutPanel8 As TableLayoutPanel
    Friend WithEvents btnSUBMIT As Button
    Friend WithEvents btnBedSearch As Button
    Friend WithEvents txtBedID As TextBox
    Friend WithEvents Label73 As Label
    Friend WithEvents dtpDateLeave As DateTimePicker
    Friend WithEvents Label71 As Label
    Friend WithEvents dtpDatePlaced As DateTimePicker
    Friend WithEvents Label70 As Label
    Friend WithEvents txtExpectedStays As TextBox
    Friend WithEvents Label69 As Label
    Friend WithEvents Label58 As Label
    Friend WithEvents txtPatientsName As TextBox
    Friend WithEvents Label57 As Label
    Friend WithEvents txtPatientID As TextBox
    Friend WithEvents Label56 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents DataGridView6 As DataGridView
    Friend WithEvents txtTel As TextBox
    Friend WithEvents Label55 As Label
    Friend WithEvents txtLocation As TextBox
    Friend WithEvents Label38 As Label
    Friend WithEvents txtWardName As TextBox
    Friend WithEvents txtWardID As TextBox
    Friend WithEvents Label34 As Label
    Friend WithEvents Label35 As Label
    Friend WithEvents Label30 As Label
    Friend WithEvents cmbWaitingStatus As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Wellmeadows_HospitalDataSet As Wellmeadows_HospitalDataSet
    Friend WithEvents dtpOnWaitingList As DateTimePicker
    Friend WithEvents Waiting_List_3BindingSource As BindingSource
    Friend WithEvents Waiting_List_3TableAdapter As Wellmeadows_HospitalDataSetTableAdapters.Waiting_List_3TableAdapter
    Friend WithEvents TableAdapterManager As Wellmeadows_HospitalDataSetTableAdapters.TableAdapterManager
    Friend WithEvents AllocationIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DatePlacedDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ExpectedStaysDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DateLeaveDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ActualLeaveDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents OnWaitinglistDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents WaitingStatusDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PatientsIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PatientsNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StaffIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BedIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents txtStaffName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Staff_ID As Label
    Friend WithEvents btnChargeNurse As Button
    Friend WithEvents lblAllocationID As Label
End Class
