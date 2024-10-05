<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPSB
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
        Me.TableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnDELETE = New System.Windows.Forms.Button()
        Me.btnADD = New System.Windows.Forms.Button()
        Me.txtUnitPerDay = New System.Windows.Forms.TextBox()
        Me.Label50 = New System.Windows.Forms.Label()
        Me.txtDrugID = New System.Windows.Forms.TextBox()
        Me.Label51 = New System.Windows.Forms.Label()
        Me.txtDrugName = New System.Windows.Forms.TextBox()
        Me.Label52 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.DataGridView4 = New System.Windows.Forms.DataGridView()
        Me.DrugIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DrugNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DrugDetailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DosageDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MethodDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DrugQuantityinstockDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DrugCostPerUnitDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DrugBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Wellmeadows_HospitalDataSet = New WellmeadowsHospital.Wellmeadows_HospitalDataSet()
        Me.Label47 = New System.Windows.Forms.Label()
        Me.Label49 = New System.Windows.Forms.Label()
        Me.Label48 = New System.Windows.Forms.Label()
        Me.dtpFinishDate = New System.Windows.Forms.DateTimePicker()
        Me.dtpStartDate = New System.Windows.Forms.DateTimePicker()
        Me.txtWardName = New System.Windows.Forms.TextBox()
        Me.Label46 = New System.Windows.Forms.Label()
        Me.txtWardID = New System.Windows.Forms.TextBox()
        Me.txtBedID = New System.Windows.Forms.TextBox()
        Me.Label44 = New System.Windows.Forms.Label()
        Me.Label45 = New System.Windows.Forms.Label()
        Me.btnStaffSearch = New System.Windows.Forms.Button()
        Me.btnPatientSearch = New System.Windows.Forms.Button()
        Me.txtPatientsID = New System.Windows.Forms.TextBox()
        Me.lblStaffID = New System.Windows.Forms.Label()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.txtStaffName = New System.Windows.Forms.TextBox()
        Me.txtPatientName = New System.Windows.Forms.TextBox()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.Label43 = New System.Windows.Forms.Label()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.DataGridViewPrescribeList = New System.Windows.Forms.DataGridView()
        Me.DrugID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DrugName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Units_Per_Day = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Edate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnSUBMIT = New System.Windows.Forms.Button()
        Me.DrugTableAdapter = New WellmeadowsHospital.Wellmeadows_HospitalDataSetTableAdapters.DrugTableAdapter()
        Me.TableAdapterManager = New WellmeadowsHospital.Wellmeadows_HospitalDataSetTableAdapters.TableAdapterManager()
        Me.TableLayoutPanel5.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        CType(Me.DataGridView4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DrugBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Wellmeadows_HospitalDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridViewPrescribeList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel5
        '
        Me.TableLayoutPanel5.ColumnCount = 2
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel5.Controls.Add(Me.btnDELETE, 1, 0)
        Me.TableLayoutPanel5.Controls.Add(Me.btnADD, 0, 0)
        Me.TableLayoutPanel5.Location = New System.Drawing.Point(15, 386)
        Me.TableLayoutPanel5.Name = "TableLayoutPanel5"
        Me.TableLayoutPanel5.RowCount = 1
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel5.Size = New System.Drawing.Size(281, 44)
        Me.TableLayoutPanel5.TabIndex = 253
        '
        'btnDELETE
        '
        Me.btnDELETE.BackColor = System.Drawing.Color.Red
        Me.btnDELETE.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnDELETE.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDELETE.Location = New System.Drawing.Point(150, 3)
        Me.btnDELETE.Margin = New System.Windows.Forms.Padding(10, 3, 10, 3)
        Me.btnDELETE.Name = "btnDELETE"
        Me.btnDELETE.Size = New System.Drawing.Size(121, 38)
        Me.btnDELETE.TabIndex = 37
        Me.btnDELETE.Text = "DELETE"
        Me.btnDELETE.UseVisualStyleBackColor = False
        '
        'btnADD
        '
        Me.btnADD.BackColor = System.Drawing.Color.LimeGreen
        Me.btnADD.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnADD.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnADD.Location = New System.Drawing.Point(10, 3)
        Me.btnADD.Margin = New System.Windows.Forms.Padding(10, 3, 10, 3)
        Me.btnADD.Name = "btnADD"
        Me.btnADD.Size = New System.Drawing.Size(120, 38)
        Me.btnADD.TabIndex = 34
        Me.btnADD.Text = "ADD"
        Me.btnADD.UseVisualStyleBackColor = False
        '
        'txtUnitPerDay
        '
        Me.txtUnitPerDay.Location = New System.Drawing.Point(15, 283)
        Me.txtUnitPerDay.Name = "txtUnitPerDay"
        Me.txtUnitPerDay.Size = New System.Drawing.Size(200, 22)
        Me.txtUnitPerDay.TabIndex = 251
        '
        'Label50
        '
        Me.Label50.AutoSize = True
        Me.Label50.Location = New System.Drawing.Point(12, 264)
        Me.Label50.Name = "Label50"
        Me.Label50.Size = New System.Drawing.Size(82, 16)
        Me.Label50.TabIndex = 252
        Me.Label50.Text = "Unit Per Day"
        '
        'txtDrugID
        '
        Me.txtDrugID.Location = New System.Drawing.Point(15, 231)
        Me.txtDrugID.Name = "txtDrugID"
        Me.txtDrugID.Size = New System.Drawing.Size(200, 22)
        Me.txtDrugID.TabIndex = 249
        '
        'Label51
        '
        Me.Label51.AutoSize = True
        Me.Label51.Location = New System.Drawing.Point(12, 212)
        Me.Label51.Name = "Label51"
        Me.Label51.Size = New System.Drawing.Size(52, 16)
        Me.Label51.TabIndex = 250
        Me.Label51.Text = "Drug ID"
        '
        'txtDrugName
        '
        Me.txtDrugName.Location = New System.Drawing.Point(274, 231)
        Me.txtDrugName.Name = "txtDrugName"
        Me.txtDrugName.Size = New System.Drawing.Size(200, 22)
        Me.txtDrugName.TabIndex = 247
        '
        'Label52
        '
        Me.Label52.AutoSize = True
        Me.Label52.Location = New System.Drawing.Point(271, 212)
        Me.Label52.Name = "Label52"
        Me.Label52.Size = New System.Drawing.Size(76, 16)
        Me.Label52.TabIndex = 248
        Me.Label52.Text = "Drug Name"
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 1
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.DataGridView4, 0, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.Label47, 0, 0)
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(531, 167)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 2
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.01832!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 84.98168!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(583, 266)
        Me.TableLayoutPanel3.TabIndex = 246
        '
        'DataGridView4
        '
        Me.DataGridView4.AutoGenerateColumns = False
        Me.DataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView4.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DrugIDDataGridViewTextBoxColumn, Me.DrugNameDataGridViewTextBoxColumn, Me.DrugDetailDataGridViewTextBoxColumn, Me.DosageDataGridViewTextBoxColumn, Me.MethodDataGridViewTextBoxColumn, Me.DrugQuantityinstockDataGridViewTextBoxColumn, Me.DrugCostPerUnitDataGridViewTextBoxColumn})
        Me.DataGridView4.DataSource = Me.DrugBindingSource
        Me.DataGridView4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView4.Location = New System.Drawing.Point(3, 42)
        Me.DataGridView4.Name = "DataGridView4"
        Me.DataGridView4.RowHeadersWidth = 51
        Me.DataGridView4.RowTemplate.Height = 24
        Me.DataGridView4.Size = New System.Drawing.Size(577, 221)
        Me.DataGridView4.TabIndex = 216
        '
        'DrugIDDataGridViewTextBoxColumn
        '
        Me.DrugIDDataGridViewTextBoxColumn.DataPropertyName = "Drug_ID"
        Me.DrugIDDataGridViewTextBoxColumn.HeaderText = "Drug_ID"
        Me.DrugIDDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.DrugIDDataGridViewTextBoxColumn.Name = "DrugIDDataGridViewTextBoxColumn"
        Me.DrugIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.DrugIDDataGridViewTextBoxColumn.Width = 125
        '
        'DrugNameDataGridViewTextBoxColumn
        '
        Me.DrugNameDataGridViewTextBoxColumn.DataPropertyName = "Drug_Name"
        Me.DrugNameDataGridViewTextBoxColumn.HeaderText = "Drug_Name"
        Me.DrugNameDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.DrugNameDataGridViewTextBoxColumn.Name = "DrugNameDataGridViewTextBoxColumn"
        Me.DrugNameDataGridViewTextBoxColumn.Width = 125
        '
        'DrugDetailDataGridViewTextBoxColumn
        '
        Me.DrugDetailDataGridViewTextBoxColumn.DataPropertyName = "Drug_Detail"
        Me.DrugDetailDataGridViewTextBoxColumn.HeaderText = "Drug_Detail"
        Me.DrugDetailDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.DrugDetailDataGridViewTextBoxColumn.Name = "DrugDetailDataGridViewTextBoxColumn"
        Me.DrugDetailDataGridViewTextBoxColumn.Width = 125
        '
        'DosageDataGridViewTextBoxColumn
        '
        Me.DosageDataGridViewTextBoxColumn.DataPropertyName = "Dosage"
        Me.DosageDataGridViewTextBoxColumn.HeaderText = "Dosage"
        Me.DosageDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.DosageDataGridViewTextBoxColumn.Name = "DosageDataGridViewTextBoxColumn"
        Me.DosageDataGridViewTextBoxColumn.Width = 125
        '
        'MethodDataGridViewTextBoxColumn
        '
        Me.MethodDataGridViewTextBoxColumn.DataPropertyName = "Method"
        Me.MethodDataGridViewTextBoxColumn.HeaderText = "Method"
        Me.MethodDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.MethodDataGridViewTextBoxColumn.Name = "MethodDataGridViewTextBoxColumn"
        Me.MethodDataGridViewTextBoxColumn.Width = 125
        '
        'DrugQuantityinstockDataGridViewTextBoxColumn
        '
        Me.DrugQuantityinstockDataGridViewTextBoxColumn.DataPropertyName = "Drug_Quantity_in_stock"
        Me.DrugQuantityinstockDataGridViewTextBoxColumn.HeaderText = "Drug_Quantity_in_stock"
        Me.DrugQuantityinstockDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.DrugQuantityinstockDataGridViewTextBoxColumn.Name = "DrugQuantityinstockDataGridViewTextBoxColumn"
        Me.DrugQuantityinstockDataGridViewTextBoxColumn.Width = 125
        '
        'DrugCostPerUnitDataGridViewTextBoxColumn
        '
        Me.DrugCostPerUnitDataGridViewTextBoxColumn.DataPropertyName = "Drug_Cost_Per_Unit"
        Me.DrugCostPerUnitDataGridViewTextBoxColumn.HeaderText = "Drug_Cost_Per_Unit"
        Me.DrugCostPerUnitDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.DrugCostPerUnitDataGridViewTextBoxColumn.Name = "DrugCostPerUnitDataGridViewTextBoxColumn"
        Me.DrugCostPerUnitDataGridViewTextBoxColumn.Width = 125
        '
        'DrugBindingSource
        '
        Me.DrugBindingSource.DataMember = "Drug"
        Me.DrugBindingSource.DataSource = Me.Wellmeadows_HospitalDataSet
        '
        'Wellmeadows_HospitalDataSet
        '
        Me.Wellmeadows_HospitalDataSet.DataSetName = "Wellmeadows_HospitalDataSet"
        Me.Wellmeadows_HospitalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label47
        '
        Me.Label47.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label47.AutoSize = True
        Me.Label47.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label47.Location = New System.Drawing.Point(243, 3)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(96, 32)
        Me.Label47.TabIndex = 216
        Me.Label47.Text = "DRUG"
        '
        'Label49
        '
        Me.Label49.AutoSize = True
        Me.Label49.Location = New System.Drawing.Point(271, 317)
        Me.Label49.Name = "Label49"
        Me.Label49.Size = New System.Drawing.Size(74, 16)
        Me.Label49.TabIndex = 245
        Me.Label49.Text = "Finish Date"
        '
        'Label48
        '
        Me.Label48.AutoSize = True
        Me.Label48.Location = New System.Drawing.Point(12, 317)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(66, 16)
        Me.Label48.TabIndex = 244
        Me.Label48.Text = "Start Date"
        '
        'dtpFinishDate
        '
        Me.dtpFinishDate.Location = New System.Drawing.Point(274, 336)
        Me.dtpFinishDate.Name = "dtpFinishDate"
        Me.dtpFinishDate.Size = New System.Drawing.Size(200, 22)
        Me.dtpFinishDate.TabIndex = 243
        '
        'dtpStartDate
        '
        Me.dtpStartDate.Location = New System.Drawing.Point(15, 336)
        Me.dtpStartDate.Name = "dtpStartDate"
        Me.dtpStartDate.Size = New System.Drawing.Size(200, 22)
        Me.dtpStartDate.TabIndex = 242
        '
        'txtWardName
        '
        Me.txtWardName.Location = New System.Drawing.Point(274, 118)
        Me.txtWardName.Name = "txtWardName"
        Me.txtWardName.Size = New System.Drawing.Size(188, 22)
        Me.txtWardName.TabIndex = 240
        '
        'Label46
        '
        Me.Label46.AutoSize = True
        Me.Label46.Location = New System.Drawing.Point(271, 99)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(80, 16)
        Me.Label46.TabIndex = 241
        Me.Label46.Text = "Ward Name"
        '
        'txtWardID
        '
        Me.txtWardID.Location = New System.Drawing.Point(274, 69)
        Me.txtWardID.Name = "txtWardID"
        Me.txtWardID.Size = New System.Drawing.Size(188, 22)
        Me.txtWardID.TabIndex = 238
        '
        'txtBedID
        '
        Me.txtBedID.Location = New System.Drawing.Point(14, 167)
        Me.txtBedID.Name = "txtBedID"
        Me.txtBedID.Size = New System.Drawing.Size(188, 22)
        Me.txtBedID.TabIndex = 236
        '
        'Label44
        '
        Me.Label44.AutoSize = True
        Me.Label44.Location = New System.Drawing.Point(271, 50)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(56, 16)
        Me.Label44.TabIndex = 239
        Me.Label44.Text = "Ward ID"
        '
        'Label45
        '
        Me.Label45.AutoSize = True
        Me.Label45.Location = New System.Drawing.Point(11, 148)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(48, 16)
        Me.Label45.TabIndex = 237
        Me.Label45.Text = "Bed ID"
        '
        'btnStaffSearch
        '
        Me.btnStaffSearch.Location = New System.Drawing.Point(688, 69)
        Me.btnStaffSearch.Name = "btnStaffSearch"
        Me.btnStaffSearch.Size = New System.Drawing.Size(32, 23)
        Me.btnStaffSearch.TabIndex = 235
        Me.btnStaffSearch.Text = "..."
        Me.btnStaffSearch.UseVisualStyleBackColor = True
        '
        'btnPatientSearch
        '
        Me.btnPatientSearch.Location = New System.Drawing.Point(208, 69)
        Me.btnPatientSearch.Name = "btnPatientSearch"
        Me.btnPatientSearch.Size = New System.Drawing.Size(32, 23)
        Me.btnPatientSearch.TabIndex = 234
        Me.btnPatientSearch.Text = "..."
        Me.btnPatientSearch.UseVisualStyleBackColor = True
        '
        'txtPatientsID
        '
        Me.txtPatientsID.Location = New System.Drawing.Point(14, 69)
        Me.txtPatientsID.Name = "txtPatientsID"
        Me.txtPatientsID.Size = New System.Drawing.Size(188, 22)
        Me.txtPatientsID.TabIndex = 230
        '
        'lblStaffID
        '
        Me.lblStaffID.AutoSize = True
        Me.lblStaffID.Location = New System.Drawing.Point(506, 13)
        Me.lblStaffID.Name = "lblStaffID"
        Me.lblStaffID.Size = New System.Drawing.Size(49, 16)
        Me.lblStaffID.TabIndex = 233
        Me.lblStaffID.Text = "Staff ID"
        Me.lblStaffID.Visible = False
        '
        'Label41
        '
        Me.Label41.AutoSize = True
        Me.Label41.Location = New System.Drawing.Point(11, 50)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(64, 16)
        Me.Label41.TabIndex = 231
        Me.Label41.Text = "Patient ID"
        '
        'txtStaffName
        '
        Me.txtStaffName.Location = New System.Drawing.Point(494, 70)
        Me.txtStaffName.Name = "txtStaffName"
        Me.txtStaffName.Size = New System.Drawing.Size(188, 22)
        Me.txtStaffName.TabIndex = 228
        '
        'txtPatientName
        '
        Me.txtPatientName.Location = New System.Drawing.Point(14, 118)
        Me.txtPatientName.Name = "txtPatientName"
        Me.txtPatientName.Size = New System.Drawing.Size(188, 22)
        Me.txtPatientName.TabIndex = 226
        '
        'Label42
        '
        Me.Label42.AutoSize = True
        Me.Label42.Location = New System.Drawing.Point(491, 51)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(73, 16)
        Me.Label42.TabIndex = 229
        Me.Label42.Text = "Staff Name"
        '
        'Label43
        '
        Me.Label43.AutoSize = True
        Me.Label43.Location = New System.Drawing.Point(11, 99)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(88, 16)
        Me.Label43.TabIndex = 227
        Me.Label43.Text = "Patient Name"
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label39.Location = New System.Drawing.Point(7, 4)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(207, 38)
        Me.Label39.TabIndex = 225
        Me.Label39.Text = "PRESCRIBE"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.DataGridViewPrescribeList)
        Me.Panel1.Controls.Add(Me.TableLayoutPanel1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 454)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1135, 368)
        Me.Panel1.TabIndex = 256
        '
        'DataGridViewPrescribeList
        '
        Me.DataGridViewPrescribeList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewPrescribeList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DrugID, Me.DrugName, Me.Units_Per_Day, Me.SDate, Me.Edate})
        Me.DataGridViewPrescribeList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridViewPrescribeList.Location = New System.Drawing.Point(0, 49)
        Me.DataGridViewPrescribeList.Name = "DataGridViewPrescribeList"
        Me.DataGridViewPrescribeList.RowHeadersWidth = 51
        Me.DataGridViewPrescribeList.RowTemplate.Height = 24
        Me.DataGridViewPrescribeList.Size = New System.Drawing.Size(1135, 319)
        Me.DataGridViewPrescribeList.TabIndex = 1
        '
        'DrugID
        '
        Me.DrugID.HeaderText = "Drug_ID"
        Me.DrugID.MinimumWidth = 6
        Me.DrugID.Name = "DrugID"
        Me.DrugID.Width = 125
        '
        'DrugName
        '
        Me.DrugName.HeaderText = "Drug Name"
        Me.DrugName.MinimumWidth = 6
        Me.DrugName.Name = "DrugName"
        Me.DrugName.Width = 125
        '
        'Units_Per_Day
        '
        Me.Units_Per_Day.HeaderText = "Units Per Day"
        Me.Units_Per_Day.MinimumWidth = 6
        Me.Units_Per_Day.Name = "Units_Per_Day"
        Me.Units_Per_Day.Width = 125
        '
        'SDate
        '
        Me.SDate.HeaderText = "Start Date"
        Me.SDate.MinimumWidth = 6
        Me.SDate.Name = "SDate"
        Me.SDate.Width = 125
        '
        'Edate
        '
        Me.Edate.HeaderText = "End Date"
        Me.Edate.MinimumWidth = 6
        Me.Edate.Name = "Edate"
        Me.Edate.Width = 125
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.88451!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 63.11549!))
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnSUBMIT, 1, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1135, 49)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(242, 32)
        Me.Label1.TabIndex = 226
        Me.Label1.Text = "PRESCRIBE LIST"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnSUBMIT
        '
        Me.btnSUBMIT.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btnSUBMIT.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSUBMIT.Location = New System.Drawing.Point(428, 5)
        Me.btnSUBMIT.Margin = New System.Windows.Forms.Padding(10, 5, 10, 5)
        Me.btnSUBMIT.Name = "btnSUBMIT"
        Me.btnSUBMIT.Size = New System.Drawing.Size(125, 39)
        Me.btnSUBMIT.TabIndex = 227
        Me.btnSUBMIT.Text = "SUBMIT"
        Me.btnSUBMIT.UseVisualStyleBackColor = False
        '
        'DrugTableAdapter
        '
        Me.DrugTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.Allocation_ListTableAdapter = Nothing
        Me.TableAdapterManager.Allocation_ToTableAdapter = Nothing
        Me.TableAdapterManager.AppointmentTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BedTableAdapter = Nothing
        Me.TableAdapterManager.Drug_Order_DetailTableAdapter = Nothing
        Me.TableAdapterManager.Drug_OrderTableAdapter = Nothing
        Me.TableAdapterManager.Drug_ReceiveTableAdapter = Nothing
        Me.TableAdapterManager.Drug_Requisitions_ByTableAdapter = Nothing
        Me.TableAdapterManager.Drug_Requisitions_FormTableAdapter = Nothing
        Me.TableAdapterManager.DrugTableAdapter = Me.DrugTableAdapter
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
        'FormPSB
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1135, 822)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TableLayoutPanel5)
        Me.Controls.Add(Me.txtUnitPerDay)
        Me.Controls.Add(Me.Label50)
        Me.Controls.Add(Me.txtDrugID)
        Me.Controls.Add(Me.Label51)
        Me.Controls.Add(Me.txtDrugName)
        Me.Controls.Add(Me.Label52)
        Me.Controls.Add(Me.TableLayoutPanel3)
        Me.Controls.Add(Me.Label49)
        Me.Controls.Add(Me.Label48)
        Me.Controls.Add(Me.dtpFinishDate)
        Me.Controls.Add(Me.dtpStartDate)
        Me.Controls.Add(Me.txtWardName)
        Me.Controls.Add(Me.Label46)
        Me.Controls.Add(Me.txtWardID)
        Me.Controls.Add(Me.txtBedID)
        Me.Controls.Add(Me.Label44)
        Me.Controls.Add(Me.Label45)
        Me.Controls.Add(Me.btnStaffSearch)
        Me.Controls.Add(Me.btnPatientSearch)
        Me.Controls.Add(Me.txtPatientsID)
        Me.Controls.Add(Me.lblStaffID)
        Me.Controls.Add(Me.Label41)
        Me.Controls.Add(Me.txtStaffName)
        Me.Controls.Add(Me.txtPatientName)
        Me.Controls.Add(Me.Label42)
        Me.Controls.Add(Me.Label43)
        Me.Controls.Add(Me.Label39)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormPSB"
        Me.Text = "FormPSB"
        Me.TableLayoutPanel5.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        CType(Me.DataGridView4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DrugBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Wellmeadows_HospitalDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.DataGridViewPrescribeList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel5 As TableLayoutPanel
    Friend WithEvents btnDELETE As Button
    Friend WithEvents btnADD As Button
    Friend WithEvents txtUnitPerDay As TextBox
    Friend WithEvents Label50 As Label
    Friend WithEvents txtDrugID As TextBox
    Friend WithEvents Label51 As Label
    Friend WithEvents txtDrugName As TextBox
    Friend WithEvents Label52 As Label
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents DataGridView4 As DataGridView
    Friend WithEvents Label47 As Label
    Friend WithEvents Label49 As Label
    Friend WithEvents Label48 As Label
    Friend WithEvents dtpFinishDate As DateTimePicker
    Friend WithEvents dtpStartDate As DateTimePicker
    Friend WithEvents txtWardName As TextBox
    Friend WithEvents Label46 As Label
    Friend WithEvents txtWardID As TextBox
    Friend WithEvents txtBedID As TextBox
    Friend WithEvents Label44 As Label
    Friend WithEvents Label45 As Label
    Friend WithEvents btnStaffSearch As Button
    Friend WithEvents btnPatientSearch As Button
    Friend WithEvents txtPatientsID As TextBox
    Friend WithEvents lblStaffID As Label
    Friend WithEvents Label41 As Label
    Friend WithEvents txtStaffName As TextBox
    Friend WithEvents txtPatientName As TextBox
    Friend WithEvents Label42 As Label
    Friend WithEvents Label43 As Label
    Friend WithEvents Label39 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents DataGridViewPrescribeList As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents btnSUBMIT As Button
    Friend WithEvents Wellmeadows_HospitalDataSet As Wellmeadows_HospitalDataSet
    Friend WithEvents DrugBindingSource As BindingSource
    Friend WithEvents DrugTableAdapter As Wellmeadows_HospitalDataSetTableAdapters.DrugTableAdapter
    Friend WithEvents TableAdapterManager As Wellmeadows_HospitalDataSetTableAdapters.TableAdapterManager
    Friend WithEvents DrugID As DataGridViewTextBoxColumn
    Friend WithEvents DrugName As DataGridViewTextBoxColumn
    Friend WithEvents Units_Per_Day As DataGridViewTextBoxColumn
    Friend WithEvents SDate As DataGridViewTextBoxColumn
    Friend WithEvents Edate As DataGridViewTextBoxColumn
    Friend WithEvents DrugIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DrugNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DrugDetailDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DosageDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MethodDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DrugQuantityinstockDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DrugCostPerUnitDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
