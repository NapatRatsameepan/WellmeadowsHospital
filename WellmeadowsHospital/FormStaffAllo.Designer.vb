<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormStaffAllo
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.txtStaffID = New System.Windows.Forms.TextBox()
        Me.txtPosition = New System.Windows.Forms.TextBox()
        Me.dtpWeekFinish = New System.Windows.Forms.DateTimePicker()
        Me.dtpWeekBegin = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.WardAllocationIDDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WardIDDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WardNameDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StartDateDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FinishDateDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Ward_AllocationBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Wellmeadows_HospitalDataSet = New WellmeadowsHospital.Wellmeadows_HospitalDataSet()
        Me.txtWardName = New System.Windows.Forms.TextBox()
        Me.txtWardID = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.AllocationListDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WardAllocationIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WardIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WardNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StaffIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StaffNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ShiftDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StartDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FinishDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Staff_Allo_listBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnDELETE = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.rbtnNight = New System.Windows.Forms.RadioButton()
        Me.rbtnLate = New System.Windows.Forms.RadioButton()
        Me.rbtnEarly = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtStaffName = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnStaffSearch = New System.Windows.Forms.Button()
        Me.btnWardSearch = New System.Windows.Forms.Button()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnAllocationAdd = New System.Windows.Forms.Button()
        Me.btnAllocationDelete = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Staff_Allo_listTableAdapter = New WellmeadowsHospital.Wellmeadows_HospitalDataSetTableAdapters.Staff_Allo_listTableAdapter()
        Me.TableAdapterManager = New WellmeadowsHospital.Wellmeadows_HospitalDataSetTableAdapters.TableAdapterManager()
        Me.Ward_AllocationTableAdapter = New WellmeadowsHospital.Wellmeadows_HospitalDataSetTableAdapters.Ward_AllocationTableAdapter()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ward_AllocationBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Wellmeadows_HospitalDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Staff_Allo_listBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtStaffID
        '
        Me.txtStaffID.Location = New System.Drawing.Point(42, 94)
        Me.txtStaffID.Name = "txtStaffID"
        Me.txtStaffID.ReadOnly = True
        Me.txtStaffID.Size = New System.Drawing.Size(183, 22)
        Me.txtStaffID.TabIndex = 167
        '
        'txtPosition
        '
        Me.txtPosition.Location = New System.Drawing.Point(287, 94)
        Me.txtPosition.Name = "txtPosition"
        Me.txtPosition.ReadOnly = True
        Me.txtPosition.Size = New System.Drawing.Size(198, 22)
        Me.txtPosition.TabIndex = 166
        '
        'dtpWeekFinish
        '
        Me.dtpWeekFinish.Location = New System.Drawing.Point(854, 143)
        Me.dtpWeekFinish.Name = "dtpWeekFinish"
        Me.dtpWeekFinish.Size = New System.Drawing.Size(200, 22)
        Me.dtpWeekFinish.TabIndex = 165
        '
        'dtpWeekBegin
        '
        Me.dtpWeekBegin.Location = New System.Drawing.Point(577, 143)
        Me.dtpWeekBegin.Name = "dtpWeekBegin"
        Me.dtpWeekBegin.Size = New System.Drawing.Size(200, 22)
        Me.dtpWeekBegin.TabIndex = 164
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(39, 188)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(32, 16)
        Me.Label8.TabIndex = 163
        Me.Label8.Text = "Shift"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(851, 124)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(81, 16)
        Me.Label7.TabIndex = 162
        Me.Label7.Text = "Week Finish"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(851, 76)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(83, 16)
        Me.Label6.TabIndex = 161
        Me.Label6.Text = "Ward Name "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(570, 76)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 16)
        Me.Label5.TabIndex = 160
        Me.Label5.Text = "Ward ID"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(574, 124)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(106, 16)
        Me.Label4.TabIndex = 159
        Me.Label4.Text = "Week Beginning"
        '
        'DataGridView2
        '
        Me.DataGridView2.AutoGenerateColumns = False
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.WardAllocationIDDataGridViewTextBoxColumn1, Me.WardIDDataGridViewTextBoxColumn1, Me.WardNameDataGridViewTextBoxColumn1, Me.StartDateDataGridViewTextBoxColumn1, Me.FinishDateDataGridViewTextBoxColumn1})
        Me.DataGridView2.DataSource = Me.Ward_AllocationBindingSource
        Me.DataGridView2.Location = New System.Drawing.Point(573, 224)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.RowHeadersWidth = 51
        Me.DataGridView2.RowTemplate.Height = 24
        Me.DataGridView2.Size = New System.Drawing.Size(512, 161)
        Me.DataGridView2.TabIndex = 157
        '
        'WardAllocationIDDataGridViewTextBoxColumn1
        '
        Me.WardAllocationIDDataGridViewTextBoxColumn1.DataPropertyName = "Ward_Allocation_ID"
        Me.WardAllocationIDDataGridViewTextBoxColumn1.HeaderText = "Ward_Allocation_ID"
        Me.WardAllocationIDDataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.WardAllocationIDDataGridViewTextBoxColumn1.Name = "WardAllocationIDDataGridViewTextBoxColumn1"
        Me.WardAllocationIDDataGridViewTextBoxColumn1.Width = 125
        '
        'WardIDDataGridViewTextBoxColumn1
        '
        Me.WardIDDataGridViewTextBoxColumn1.DataPropertyName = "Ward_ID"
        Me.WardIDDataGridViewTextBoxColumn1.HeaderText = "Ward_ID"
        Me.WardIDDataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.WardIDDataGridViewTextBoxColumn1.Name = "WardIDDataGridViewTextBoxColumn1"
        Me.WardIDDataGridViewTextBoxColumn1.Width = 125
        '
        'WardNameDataGridViewTextBoxColumn1
        '
        Me.WardNameDataGridViewTextBoxColumn1.DataPropertyName = "Ward_Name"
        Me.WardNameDataGridViewTextBoxColumn1.HeaderText = "Ward_Name"
        Me.WardNameDataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.WardNameDataGridViewTextBoxColumn1.Name = "WardNameDataGridViewTextBoxColumn1"
        Me.WardNameDataGridViewTextBoxColumn1.Width = 125
        '
        'StartDateDataGridViewTextBoxColumn1
        '
        Me.StartDateDataGridViewTextBoxColumn1.DataPropertyName = "Start Date"
        Me.StartDateDataGridViewTextBoxColumn1.HeaderText = "Start Date"
        Me.StartDateDataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.StartDateDataGridViewTextBoxColumn1.Name = "StartDateDataGridViewTextBoxColumn1"
        Me.StartDateDataGridViewTextBoxColumn1.Width = 125
        '
        'FinishDateDataGridViewTextBoxColumn1
        '
        Me.FinishDateDataGridViewTextBoxColumn1.DataPropertyName = "Finish Date"
        Me.FinishDateDataGridViewTextBoxColumn1.HeaderText = "Finish Date"
        Me.FinishDateDataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.FinishDateDataGridViewTextBoxColumn1.Name = "FinishDateDataGridViewTextBoxColumn1"
        Me.FinishDateDataGridViewTextBoxColumn1.Width = 125
        '
        'Ward_AllocationBindingSource
        '
        Me.Ward_AllocationBindingSource.DataMember = "Ward_Allocation"
        Me.Ward_AllocationBindingSource.DataSource = Me.Wellmeadows_HospitalDataSet
        '
        'Wellmeadows_HospitalDataSet
        '
        Me.Wellmeadows_HospitalDataSet.DataSetName = "Wellmeadows_HospitalDataSet"
        Me.Wellmeadows_HospitalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'txtWardName
        '
        Me.txtWardName.Location = New System.Drawing.Point(854, 95)
        Me.txtWardName.Name = "txtWardName"
        Me.txtWardName.ReadOnly = True
        Me.txtWardName.Size = New System.Drawing.Size(200, 22)
        Me.txtWardName.TabIndex = 156
        '
        'txtWardID
        '
        Me.txtWardID.Location = New System.Drawing.Point(573, 95)
        Me.txtWardID.Name = "txtWardID"
        Me.txtWardID.ReadOnly = True
        Me.txtWardID.Size = New System.Drawing.Size(204, 22)
        Me.txtWardID.TabIndex = 155
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.AllocationListDataGridViewTextBoxColumn, Me.WardAllocationIDDataGridViewTextBoxColumn, Me.WardIDDataGridViewTextBoxColumn, Me.WardNameDataGridViewTextBoxColumn, Me.StaffIDDataGridViewTextBoxColumn, Me.StaffNameDataGridViewTextBoxColumn, Me.ShiftDataGridViewTextBoxColumn, Me.StartDateDataGridViewTextBoxColumn, Me.FinishDateDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.Staff_Allo_listBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(42, 404)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(1043, 359)
        Me.DataGridView1.TabIndex = 154
        '
        'AllocationListDataGridViewTextBoxColumn
        '
        Me.AllocationListDataGridViewTextBoxColumn.DataPropertyName = "Allocation_List"
        Me.AllocationListDataGridViewTextBoxColumn.HeaderText = "Allocation_List"
        Me.AllocationListDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.AllocationListDataGridViewTextBoxColumn.Name = "AllocationListDataGridViewTextBoxColumn"
        Me.AllocationListDataGridViewTextBoxColumn.Width = 125
        '
        'WardAllocationIDDataGridViewTextBoxColumn
        '
        Me.WardAllocationIDDataGridViewTextBoxColumn.DataPropertyName = "Ward_Allocation_ID"
        Me.WardAllocationIDDataGridViewTextBoxColumn.HeaderText = "Ward_Allocation_ID"
        Me.WardAllocationIDDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.WardAllocationIDDataGridViewTextBoxColumn.Name = "WardAllocationIDDataGridViewTextBoxColumn"
        Me.WardAllocationIDDataGridViewTextBoxColumn.Width = 125
        '
        'WardIDDataGridViewTextBoxColumn
        '
        Me.WardIDDataGridViewTextBoxColumn.DataPropertyName = "Ward_ID"
        Me.WardIDDataGridViewTextBoxColumn.HeaderText = "Ward_ID"
        Me.WardIDDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.WardIDDataGridViewTextBoxColumn.Name = "WardIDDataGridViewTextBoxColumn"
        Me.WardIDDataGridViewTextBoxColumn.Width = 125
        '
        'WardNameDataGridViewTextBoxColumn
        '
        Me.WardNameDataGridViewTextBoxColumn.DataPropertyName = "Ward_Name"
        Me.WardNameDataGridViewTextBoxColumn.HeaderText = "Ward_Name"
        Me.WardNameDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.WardNameDataGridViewTextBoxColumn.Name = "WardNameDataGridViewTextBoxColumn"
        Me.WardNameDataGridViewTextBoxColumn.Width = 125
        '
        'StaffIDDataGridViewTextBoxColumn
        '
        Me.StaffIDDataGridViewTextBoxColumn.DataPropertyName = "Staff_ID"
        Me.StaffIDDataGridViewTextBoxColumn.HeaderText = "Staff_ID"
        Me.StaffIDDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.StaffIDDataGridViewTextBoxColumn.Name = "StaffIDDataGridViewTextBoxColumn"
        Me.StaffIDDataGridViewTextBoxColumn.Width = 125
        '
        'StaffNameDataGridViewTextBoxColumn
        '
        Me.StaffNameDataGridViewTextBoxColumn.DataPropertyName = "Staff Name"
        Me.StaffNameDataGridViewTextBoxColumn.HeaderText = "Staff Name"
        Me.StaffNameDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.StaffNameDataGridViewTextBoxColumn.Name = "StaffNameDataGridViewTextBoxColumn"
        Me.StaffNameDataGridViewTextBoxColumn.ReadOnly = True
        Me.StaffNameDataGridViewTextBoxColumn.Width = 125
        '
        'ShiftDataGridViewTextBoxColumn
        '
        Me.ShiftDataGridViewTextBoxColumn.DataPropertyName = "Shift"
        Me.ShiftDataGridViewTextBoxColumn.HeaderText = "Shift"
        Me.ShiftDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.ShiftDataGridViewTextBoxColumn.Name = "ShiftDataGridViewTextBoxColumn"
        Me.ShiftDataGridViewTextBoxColumn.Width = 125
        '
        'StartDateDataGridViewTextBoxColumn
        '
        Me.StartDateDataGridViewTextBoxColumn.DataPropertyName = "Start Date"
        Me.StartDateDataGridViewTextBoxColumn.HeaderText = "Start Date"
        Me.StartDateDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.StartDateDataGridViewTextBoxColumn.Name = "StartDateDataGridViewTextBoxColumn"
        Me.StartDateDataGridViewTextBoxColumn.Width = 125
        '
        'FinishDateDataGridViewTextBoxColumn
        '
        Me.FinishDateDataGridViewTextBoxColumn.DataPropertyName = "Finish Date"
        Me.FinishDateDataGridViewTextBoxColumn.HeaderText = "Finish Date"
        Me.FinishDateDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.FinishDateDataGridViewTextBoxColumn.Name = "FinishDateDataGridViewTextBoxColumn"
        Me.FinishDateDataGridViewTextBoxColumn.Width = 125
        '
        'Staff_Allo_listBindingSource
        '
        Me.Staff_Allo_listBindingSource.DataMember = "Staff_Allo_list"
        Me.Staff_Allo_listBindingSource.DataSource = Me.Wellmeadows_HospitalDataSet
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.Controls.Add(Me.btnAdd, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnDELETE, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(194, 270)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(333, 43)
        Me.TableLayoutPanel1.TabIndex = 153
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.LimeGreen
        Me.btnAdd.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdd.Location = New System.Drawing.Point(10, 3)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(10, 3, 10, 3)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(91, 37)
        Me.btnAdd.TabIndex = 34
        Me.btnAdd.Text = "ADD"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'btnDELETE
        '
        Me.btnDELETE.BackColor = System.Drawing.Color.Red
        Me.btnDELETE.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnDELETE.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDELETE.Location = New System.Drawing.Point(121, 3)
        Me.btnDELETE.Margin = New System.Windows.Forms.Padding(10, 3, 10, 3)
        Me.btnDELETE.Name = "btnDELETE"
        Me.btnDELETE.Size = New System.Drawing.Size(91, 37)
        Me.btnDELETE.TabIndex = 35
        Me.btnDELETE.Text = "DELETE"
        Me.btnDELETE.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(284, 75)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 16)
        Me.Label3.TabIndex = 152
        Me.Label3.Text = "Position"
        '
        'rbtnNight
        '
        Me.rbtnNight.AutoSize = True
        Me.rbtnNight.Location = New System.Drawing.Point(42, 293)
        Me.rbtnNight.Name = "rbtnNight"
        Me.rbtnNight.Size = New System.Drawing.Size(59, 20)
        Me.rbtnNight.TabIndex = 151
        Me.rbtnNight.TabStop = True
        Me.rbtnNight.Text = "Night"
        Me.rbtnNight.UseVisualStyleBackColor = True
        '
        'rbtnLate
        '
        Me.rbtnLate.AutoSize = True
        Me.rbtnLate.Location = New System.Drawing.Point(42, 255)
        Me.rbtnLate.Name = "rbtnLate"
        Me.rbtnLate.Size = New System.Drawing.Size(54, 20)
        Me.rbtnLate.TabIndex = 150
        Me.rbtnLate.TabStop = True
        Me.rbtnLate.Text = "Late"
        Me.rbtnLate.UseVisualStyleBackColor = True
        '
        'rbtnEarly
        '
        Me.rbtnEarly.AutoSize = True
        Me.rbtnEarly.Location = New System.Drawing.Point(42, 217)
        Me.rbtnEarly.Name = "rbtnEarly"
        Me.rbtnEarly.Size = New System.Drawing.Size(59, 20)
        Me.rbtnEarly.TabIndex = 149
        Me.rbtnEarly.TabStop = True
        Me.rbtnEarly.Text = "Early"
        Me.rbtnEarly.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(39, 119)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 16)
        Me.Label1.TabIndex = 147
        Me.Label1.Text = "Staff Name"
        '
        'txtStaffName
        '
        Me.txtStaffName.Location = New System.Drawing.Point(42, 138)
        Me.txtStaffName.Name = "txtStaffName"
        Me.txtStaffName.ReadOnly = True
        Me.txtStaffName.Size = New System.Drawing.Size(183, 22)
        Me.txtStaffName.TabIndex = 145
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label10.Location = New System.Drawing.Point(35, 27)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(338, 38)
        Me.Label10.TabIndex = 144
        Me.Label10.Text = "STAFF ALLOCATION"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(39, 75)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(49, 16)
        Me.Label9.TabIndex = 168
        Me.Label9.Text = "Staff ID"
        '
        'btnStaffSearch
        '
        Me.btnStaffSearch.Location = New System.Drawing.Point(230, 94)
        Me.btnStaffSearch.Name = "btnStaffSearch"
        Me.btnStaffSearch.Size = New System.Drawing.Size(39, 23)
        Me.btnStaffSearch.TabIndex = 226
        Me.btnStaffSearch.Text = "..."
        Me.btnStaffSearch.UseVisualStyleBackColor = True
        '
        'btnWardSearch
        '
        Me.btnWardSearch.Location = New System.Drawing.Point(783, 94)
        Me.btnWardSearch.Name = "btnWardSearch"
        Me.btnWardSearch.Size = New System.Drawing.Size(39, 23)
        Me.btnWardSearch.TabIndex = 227
        Me.btnWardSearch.Text = "..."
        Me.btnWardSearch.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.btnAllocationAdd, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.btnAllocationDelete, 1, 0)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(577, 180)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(200, 33)
        Me.TableLayoutPanel2.TabIndex = 228
        '
        'btnAllocationAdd
        '
        Me.btnAllocationAdd.BackColor = System.Drawing.Color.LimeGreen
        Me.btnAllocationAdd.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnAllocationAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAllocationAdd.Location = New System.Drawing.Point(10, 3)
        Me.btnAllocationAdd.Margin = New System.Windows.Forms.Padding(10, 3, 10, 3)
        Me.btnAllocationAdd.Name = "btnAllocationAdd"
        Me.btnAllocationAdd.Size = New System.Drawing.Size(80, 27)
        Me.btnAllocationAdd.TabIndex = 34
        Me.btnAllocationAdd.Text = "ADD"
        Me.btnAllocationAdd.UseVisualStyleBackColor = False
        '
        'btnAllocationDelete
        '
        Me.btnAllocationDelete.BackColor = System.Drawing.Color.Red
        Me.btnAllocationDelete.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnAllocationDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAllocationDelete.Location = New System.Drawing.Point(110, 3)
        Me.btnAllocationDelete.Margin = New System.Windows.Forms.Padding(10, 3, 10, 3)
        Me.btnAllocationDelete.Name = "btnAllocationDelete"
        Me.btnAllocationDelete.Size = New System.Drawing.Size(80, 27)
        Me.btnAllocationDelete.TabIndex = 35
        Me.btnAllocationDelete.Text = "DELETE"
        Me.btnAllocationDelete.UseVisualStyleBackColor = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label11.Location = New System.Drawing.Point(35, 363)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(198, 38)
        Me.Label11.TabIndex = 229
        Me.Label11.Text = "STAFF LIST"
        '
        'Staff_Allo_listTableAdapter
        '
        Me.Staff_Allo_listTableAdapter.ClearBeforeFill = True
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
        'Ward_AllocationTableAdapter
        '
        Me.Ward_AllocationTableAdapter.ClearBeforeFill = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.Location = New System.Drawing.Point(566, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(302, 38)
        Me.Label2.TabIndex = 230
        Me.Label2.Text = "ALLOCATION LIST"
        '
        'FormStaffAllo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1117, 775)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.TableLayoutPanel2)
        Me.Controls.Add(Me.btnWardSearch)
        Me.Controls.Add(Me.btnStaffSearch)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtStaffID)
        Me.Controls.Add(Me.txtPosition)
        Me.Controls.Add(Me.dtpWeekFinish)
        Me.Controls.Add(Me.dtpWeekBegin)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.txtWardName)
        Me.Controls.Add(Me.txtWardID)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.rbtnNight)
        Me.Controls.Add(Me.rbtnLate)
        Me.Controls.Add(Me.rbtnEarly)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtStaffName)
        Me.Controls.Add(Me.Label10)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormStaffAllo"
        Me.Text = "FormStaffAllo"
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ward_AllocationBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Wellmeadows_HospitalDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Staff_Allo_listBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Wellmeadows_HospitalDataSet As Wellmeadows_HospitalDataSet
    Friend WithEvents txtStaffID As TextBox
    Friend WithEvents txtPosition As TextBox
    Friend WithEvents dtpWeekFinish As DateTimePicker
    Friend WithEvents dtpWeekBegin As DateTimePicker
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents txtWardName As TextBox
    Friend WithEvents txtWardID As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnDELETE As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents rbtnLate As RadioButton
    Friend WithEvents rbtnEarly As RadioButton
    Friend WithEvents Label1 As Label
    Friend WithEvents txtStaffName As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents btnStaffSearch As Button
    Friend WithEvents btnWardSearch As Button
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents btnAllocationAdd As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents Staff_Allo_listBindingSource As BindingSource
    Friend WithEvents Staff_Allo_listTableAdapter As Wellmeadows_HospitalDataSetTableAdapters.Staff_Allo_listTableAdapter
    Friend WithEvents TableAdapterManager As Wellmeadows_HospitalDataSetTableAdapters.TableAdapterManager
    Friend WithEvents AllocationListDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents WardAllocationIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents WardIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents WardNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StaffIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StaffNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ShiftDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StartDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FinishDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Ward_AllocationBindingSource As BindingSource
    Friend WithEvents Ward_AllocationTableAdapter As Wellmeadows_HospitalDataSetTableAdapters.Ward_AllocationTableAdapter
    Friend WithEvents WardAllocationIDDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents WardIDDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents WardNameDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents StartDateDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents FinishDateDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents btnAllocationDelete As Button
    Friend WithEvents rbtnNight As RadioButton
    Friend WithEvents Label2 As Label
End Class
