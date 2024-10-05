<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormDrugRequisiton
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
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.Wellmeadows_HospitalDataSet = New WellmeadowsHospital.Wellmeadows_HospitalDataSet()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnSUBMIT = New System.Windows.Forms.Button()
        Me.DataGridViewRequisitionList = New System.Windows.Forms.DataGridView()
        Me.DrugID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DrugName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DrugDesc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Dousage = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Method = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DrugCPU = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DrugQuantity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.DataGridViewItemList = New System.Windows.Forms.DataGridView()
        Me.DrugIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DrugNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DrugDetailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DosageDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MethodDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DrugQuantityinstockDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DrugCostPerUnitDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DrugBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label47 = New System.Windows.Forms.Label()
        Me.Label50 = New System.Windows.Forms.Label()
        Me.txtQuantity = New System.Windows.Forms.TextBox()
        Me.btnWardSearch = New System.Windows.Forms.Button()
        Me.TableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnDELETE = New System.Windows.Forms.Button()
        Me.btnADD = New System.Windows.Forms.Button()
        Me.txtWardName = New System.Windows.Forms.TextBox()
        Me.Label46 = New System.Windows.Forms.Label()
        Me.txtWardID = New System.Windows.Forms.TextBox()
        Me.Label44 = New System.Windows.Forms.Label()
        Me.btnStaffSearch = New System.Windows.Forms.Button()
        Me.lblStaffID = New System.Windows.Forms.Label()
        Me.txtStaffName = New System.Windows.Forms.TextBox()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.DrugTableAdapter = New WellmeadowsHospital.Wellmeadows_HospitalDataSetTableAdapters.DrugTableAdapter()
        Me.TableAdapterManager = New WellmeadowsHospital.Wellmeadows_HospitalDataSetTableAdapters.TableAdapterManager()
        Me.txtRequisitionDetail = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.Wellmeadows_HospitalDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.DataGridViewRequisitionList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        CType(Me.DataGridViewItemList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DrugBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel5.SuspendLayout()
        Me.SuspendLayout()
        '
        'Wellmeadows_HospitalDataSet
        '
        Me.Wellmeadows_HospitalDataSet.DataSetName = "Wellmeadows_HospitalDataSet"
        Me.Wellmeadows_HospitalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        Me.Label1.Size = New System.Drawing.Size(260, 32)
        Me.Label1.TabIndex = 226
        Me.Label1.Text = "REQUISITION LIST"
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
        'DataGridViewRequisitionList
        '
        Me.DataGridViewRequisitionList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewRequisitionList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DrugID, Me.DrugName, Me.DrugDesc, Me.Dousage, Me.Method, Me.DrugCPU, Me.DrugQuantity})
        Me.DataGridViewRequisitionList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridViewRequisitionList.Location = New System.Drawing.Point(0, 49)
        Me.DataGridViewRequisitionList.Name = "DataGridViewRequisitionList"
        Me.DataGridViewRequisitionList.RowHeadersWidth = 51
        Me.DataGridViewRequisitionList.RowTemplate.Height = 24
        Me.DataGridViewRequisitionList.Size = New System.Drawing.Size(1135, 316)
        Me.DataGridViewRequisitionList.TabIndex = 1
        '
        'DrugID
        '
        Me.DrugID.HeaderText = "Drug ID"
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
        'DrugDesc
        '
        Me.DrugDesc.HeaderText = "Description"
        Me.DrugDesc.MinimumWidth = 6
        Me.DrugDesc.Name = "DrugDesc"
        Me.DrugDesc.Width = 125
        '
        'Dousage
        '
        Me.Dousage.HeaderText = "Dousage(mg/ml)"
        Me.Dousage.MinimumWidth = 6
        Me.Dousage.Name = "Dousage"
        Me.Dousage.Width = 125
        '
        'Method
        '
        Me.Method.HeaderText = "Method of Admin"
        Me.Method.MinimumWidth = 6
        Me.Method.Name = "Method"
        Me.Method.Width = 125
        '
        'DrugCPU
        '
        Me.DrugCPU.HeaderText = "Cost Per Unit"
        Me.DrugCPU.MinimumWidth = 6
        Me.DrugCPU.Name = "DrugCPU"
        Me.DrugCPU.Width = 125
        '
        'DrugQuantity
        '
        Me.DrugQuantity.HeaderText = "Quantity"
        Me.DrugQuantity.MinimumWidth = 6
        Me.DrugQuantity.Name = "DrugQuantity"
        Me.DrugQuantity.Width = 125
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.DataGridViewRequisitionList)
        Me.Panel1.Controls.Add(Me.TableLayoutPanel1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 457)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1135, 365)
        Me.Panel1.TabIndex = 285
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.TableLayoutPanel3, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label50, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.txtQuantity, 0, 2)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(12, 53)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 3
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 92.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(583, 348)
        Me.TableLayoutPanel2.TabIndex = 317
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 1
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.DataGridViewItemList, 0, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.Label47, 0, 0)
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 2
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.01832!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 84.98168!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(577, 285)
        Me.TableLayoutPanel3.TabIndex = 295
        '
        'DataGridViewItemList
        '
        Me.DataGridViewItemList.AutoGenerateColumns = False
        Me.DataGridViewItemList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewItemList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DrugIDDataGridViewTextBoxColumn, Me.DrugNameDataGridViewTextBoxColumn, Me.DrugDetailDataGridViewTextBoxColumn, Me.DosageDataGridViewTextBoxColumn, Me.MethodDataGridViewTextBoxColumn, Me.DrugQuantityinstockDataGridViewTextBoxColumn, Me.DrugCostPerUnitDataGridViewTextBoxColumn})
        Me.DataGridViewItemList.DataSource = Me.DrugBindingSource
        Me.DataGridViewItemList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridViewItemList.Location = New System.Drawing.Point(3, 45)
        Me.DataGridViewItemList.Name = "DataGridViewItemList"
        Me.DataGridViewItemList.RowHeadersWidth = 51
        Me.DataGridViewItemList.RowTemplate.Height = 24
        Me.DataGridViewItemList.Size = New System.Drawing.Size(571, 237)
        Me.DataGridViewItemList.TabIndex = 216
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
        'Label47
        '
        Me.Label47.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label47.AutoSize = True
        Me.Label47.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label47.Location = New System.Drawing.Point(240, 5)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(96, 32)
        Me.Label47.TabIndex = 216
        Me.Label47.Text = "DRUG"
        '
        'Label50
        '
        Me.Label50.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label50.AutoSize = True
        Me.Label50.Location = New System.Drawing.Point(3, 295)
        Me.Label50.Name = "Label50"
        Me.Label50.Size = New System.Drawing.Size(55, 16)
        Me.Label50.TabIndex = 301
        Me.Label50.Text = "Quantity"
        '
        'txtQuantity
        '
        Me.txtQuantity.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txtQuantity.Location = New System.Drawing.Point(3, 321)
        Me.txtQuantity.Name = "txtQuantity"
        Me.txtQuantity.Size = New System.Drawing.Size(189, 22)
        Me.txtQuantity.TabIndex = 300
        '
        'btnWardSearch
        '
        Me.btnWardSearch.Location = New System.Drawing.Point(814, 70)
        Me.btnWardSearch.Name = "btnWardSearch"
        Me.btnWardSearch.Size = New System.Drawing.Size(32, 23)
        Me.btnWardSearch.TabIndex = 316
        Me.btnWardSearch.Text = "..."
        Me.btnWardSearch.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel5
        '
        Me.TableLayoutPanel5.ColumnCount = 2
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel5.Controls.Add(Me.btnDELETE, 1, 0)
        Me.TableLayoutPanel5.Controls.Add(Me.btnADD, 0, 0)
        Me.TableLayoutPanel5.Location = New System.Drawing.Point(12, 407)
        Me.TableLayoutPanel5.Name = "TableLayoutPanel5"
        Me.TableLayoutPanel5.RowCount = 1
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel5.Size = New System.Drawing.Size(281, 44)
        Me.TableLayoutPanel5.TabIndex = 315
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
        'txtWardName
        '
        Me.txtWardName.Location = New System.Drawing.Point(871, 71)
        Me.txtWardName.Name = "txtWardName"
        Me.txtWardName.Size = New System.Drawing.Size(188, 22)
        Me.txtWardName.TabIndex = 313
        '
        'Label46
        '
        Me.Label46.AutoSize = True
        Me.Label46.Location = New System.Drawing.Point(868, 52)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(80, 16)
        Me.Label46.TabIndex = 314
        Me.Label46.Text = "Ward Name"
        '
        'txtWardID
        '
        Me.txtWardID.Location = New System.Drawing.Point(620, 71)
        Me.txtWardID.Name = "txtWardID"
        Me.txtWardID.Size = New System.Drawing.Size(188, 22)
        Me.txtWardID.TabIndex = 311
        '
        'Label44
        '
        Me.Label44.AutoSize = True
        Me.Label44.Location = New System.Drawing.Point(617, 52)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(56, 16)
        Me.Label44.TabIndex = 312
        Me.Label44.Text = "Ward ID"
        '
        'btnStaffSearch
        '
        Me.btnStaffSearch.Location = New System.Drawing.Point(814, 127)
        Me.btnStaffSearch.Name = "btnStaffSearch"
        Me.btnStaffSearch.Size = New System.Drawing.Size(32, 23)
        Me.btnStaffSearch.TabIndex = 310
        Me.btnStaffSearch.Text = "..."
        Me.btnStaffSearch.UseVisualStyleBackColor = True
        '
        'lblStaffID
        '
        Me.lblStaffID.AutoSize = True
        Me.lblStaffID.Location = New System.Drawing.Point(890, 130)
        Me.lblStaffID.Name = "lblStaffID"
        Me.lblStaffID.Size = New System.Drawing.Size(49, 16)
        Me.lblStaffID.TabIndex = 309
        Me.lblStaffID.Text = "Staff ID"
        Me.lblStaffID.Visible = False
        '
        'txtStaffName
        '
        Me.txtStaffName.Location = New System.Drawing.Point(620, 128)
        Me.txtStaffName.Name = "txtStaffName"
        Me.txtStaffName.Size = New System.Drawing.Size(188, 22)
        Me.txtStaffName.TabIndex = 307
        '
        'Label42
        '
        Me.Label42.AutoSize = True
        Me.Label42.Location = New System.Drawing.Point(617, 109)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(73, 16)
        Me.Label42.TabIndex = 308
        Me.Label42.Text = "Staff Name"
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label39.Location = New System.Drawing.Point(5, 12)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(336, 38)
        Me.Label39.TabIndex = 306
        Me.Label39.Text = "DRUG REQUISITION"
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
        'txtRequisitionDetail
        '
        Me.txtRequisitionDetail.Location = New System.Drawing.Point(620, 188)
        Me.txtRequisitionDetail.Multiline = True
        Me.txtRequisitionDetail.Name = "txtRequisitionDetail"
        Me.txtRequisitionDetail.Size = New System.Drawing.Size(439, 163)
        Me.txtRequisitionDetail.TabIndex = 318
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(617, 169)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(112, 16)
        Me.Label2.TabIndex = 319
        Me.Label2.Text = "Requisition Detail"
        '
        'FormDrugRequisiton
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1135, 822)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtRequisitionDetail)
        Me.Controls.Add(Me.TableLayoutPanel2)
        Me.Controls.Add(Me.btnWardSearch)
        Me.Controls.Add(Me.TableLayoutPanel5)
        Me.Controls.Add(Me.txtWardName)
        Me.Controls.Add(Me.Label46)
        Me.Controls.Add(Me.txtWardID)
        Me.Controls.Add(Me.Label44)
        Me.Controls.Add(Me.btnStaffSearch)
        Me.Controls.Add(Me.lblStaffID)
        Me.Controls.Add(Me.txtStaffName)
        Me.Controls.Add(Me.Label42)
        Me.Controls.Add(Me.Label39)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormDrugRequisiton"
        Me.Text = "FormDrugRequisiton"
        CType(Me.Wellmeadows_HospitalDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.DataGridViewRequisitionList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        CType(Me.DataGridViewItemList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DrugBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel5.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents Wellmeadows_HospitalDataSet As Wellmeadows_HospitalDataSet
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents btnSUBMIT As Button
    Friend WithEvents DataGridViewRequisitionList As DataGridView
    Friend WithEvents DrugID As DataGridViewTextBoxColumn
    Friend WithEvents DrugName As DataGridViewTextBoxColumn
    Friend WithEvents DrugDesc As DataGridViewTextBoxColumn
    Friend WithEvents Dousage As DataGridViewTextBoxColumn
    Friend WithEvents Method As DataGridViewTextBoxColumn
    Friend WithEvents DrugCPU As DataGridViewTextBoxColumn
    Friend WithEvents DrugQuantity As DataGridViewTextBoxColumn
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents DataGridViewItemList As DataGridView
    Friend WithEvents Label47 As Label
    Friend WithEvents Label50 As Label
    Friend WithEvents txtQuantity As TextBox
    Friend WithEvents btnWardSearch As Button
    Friend WithEvents TableLayoutPanel5 As TableLayoutPanel
    Friend WithEvents btnDELETE As Button
    Friend WithEvents btnADD As Button
    Friend WithEvents txtWardName As TextBox
    Friend WithEvents Label46 As Label
    Friend WithEvents txtWardID As TextBox
    Friend WithEvents Label44 As Label
    Friend WithEvents btnStaffSearch As Button
    Friend WithEvents lblStaffID As Label
    Friend WithEvents txtStaffName As TextBox
    Friend WithEvents Label42 As Label
    Friend WithEvents Label39 As Label
    Friend WithEvents DrugBindingSource As BindingSource
    Friend WithEvents DrugTableAdapter As Wellmeadows_HospitalDataSetTableAdapters.DrugTableAdapter
    Friend WithEvents TableAdapterManager As Wellmeadows_HospitalDataSetTableAdapters.TableAdapterManager
    Friend WithEvents DrugIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DrugNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DrugDetailDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DosageDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MethodDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DrugQuantityinstockDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DrugCostPerUnitDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents txtRequisitionDetail As TextBox
    Friend WithEvents Label2 As Label
End Class
