<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormItemRequisiton
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.DataGridViewRequisitionList = New System.Windows.Forms.DataGridView()
        Me.ItemID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemDesc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemCPU = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemQuantity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnSUBMIT = New System.Windows.Forms.Button()
        Me.TableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnDELETE = New System.Windows.Forms.Button()
        Me.btnADD = New System.Windows.Forms.Button()
        Me.txtQuantity = New System.Windows.Forms.TextBox()
        Me.Label50 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.DataGridViewItemList = New System.Windows.Forms.DataGridView()
        Me.ItemIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemDetailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemQuantityinstockDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemCostPerUnitDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Wellmeadows_HospitalDataSet = New WellmeadowsHospital.Wellmeadows_HospitalDataSet()
        Me.Label47 = New System.Windows.Forms.Label()
        Me.txtWardName = New System.Windows.Forms.TextBox()
        Me.Label46 = New System.Windows.Forms.Label()
        Me.txtWardID = New System.Windows.Forms.TextBox()
        Me.Label44 = New System.Windows.Forms.Label()
        Me.btnStaffSearch = New System.Windows.Forms.Button()
        Me.lblStaffID = New System.Windows.Forms.Label()
        Me.txtStaffName = New System.Windows.Forms.TextBox()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.ItemTableAdapter = New WellmeadowsHospital.Wellmeadows_HospitalDataSetTableAdapters.ItemTableAdapter()
        Me.TableAdapterManager = New WellmeadowsHospital.Wellmeadows_HospitalDataSetTableAdapters.TableAdapterManager()
        Me.btnWardSearch = New System.Windows.Forms.Button()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtRequisitionDetail = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridViewRequisitionList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel5.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        CType(Me.DataGridViewItemList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Wellmeadows_HospitalDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.DataGridViewRequisitionList)
        Me.Panel1.Controls.Add(Me.TableLayoutPanel1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 454)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1135, 368)
        Me.Panel1.TabIndex = 303
        '
        'DataGridViewRequisitionList
        '
        Me.DataGridViewRequisitionList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewRequisitionList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ItemID, Me.ItemName, Me.ItemDesc, Me.ItemCPU, Me.ItemQuantity})
        Me.DataGridViewRequisitionList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridViewRequisitionList.Location = New System.Drawing.Point(0, 49)
        Me.DataGridViewRequisitionList.Name = "DataGridViewRequisitionList"
        Me.DataGridViewRequisitionList.RowHeadersWidth = 51
        Me.DataGridViewRequisitionList.RowTemplate.Height = 24
        Me.DataGridViewRequisitionList.Size = New System.Drawing.Size(1135, 319)
        Me.DataGridViewRequisitionList.TabIndex = 1
        '
        'ItemID
        '
        Me.ItemID.HeaderText = "Item ID"
        Me.ItemID.MinimumWidth = 6
        Me.ItemID.Name = "ItemID"
        Me.ItemID.Width = 125
        '
        'ItemName
        '
        Me.ItemName.HeaderText = "Item Name"
        Me.ItemName.MinimumWidth = 6
        Me.ItemName.Name = "ItemName"
        Me.ItemName.Width = 125
        '
        'ItemDesc
        '
        Me.ItemDesc.HeaderText = "Description"
        Me.ItemDesc.MinimumWidth = 6
        Me.ItemDesc.Name = "ItemDesc"
        Me.ItemDesc.Width = 125
        '
        'ItemCPU
        '
        Me.ItemCPU.HeaderText = "Cost Per Unit"
        Me.ItemCPU.MinimumWidth = 6
        Me.ItemCPU.Name = "ItemCPU"
        Me.ItemCPU.Width = 125
        '
        'ItemQuantity
        '
        Me.ItemQuantity.HeaderText = "Quantity"
        Me.ItemQuantity.MinimumWidth = 6
        Me.ItemQuantity.Name = "ItemQuantity"
        Me.ItemQuantity.Width = 125
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
        'TableLayoutPanel5
        '
        Me.TableLayoutPanel5.ColumnCount = 2
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel5.Controls.Add(Me.btnDELETE, 1, 0)
        Me.TableLayoutPanel5.Controls.Add(Me.btnADD, 0, 0)
        Me.TableLayoutPanel5.Location = New System.Drawing.Point(12, 404)
        Me.TableLayoutPanel5.Name = "TableLayoutPanel5"
        Me.TableLayoutPanel5.RowCount = 1
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel5.Size = New System.Drawing.Size(281, 44)
        Me.TableLayoutPanel5.TabIndex = 302
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
        'txtQuantity
        '
        Me.txtQuantity.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txtQuantity.Location = New System.Drawing.Point(3, 321)
        Me.txtQuantity.Name = "txtQuantity"
        Me.txtQuantity.Size = New System.Drawing.Size(189, 22)
        Me.txtQuantity.TabIndex = 300
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
        Me.DataGridViewItemList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ItemIDDataGridViewTextBoxColumn, Me.ItemNameDataGridViewTextBoxColumn, Me.ItemDetailDataGridViewTextBoxColumn, Me.ItemQuantityinstockDataGridViewTextBoxColumn, Me.ItemCostPerUnitDataGridViewTextBoxColumn})
        Me.DataGridViewItemList.DataSource = Me.ItemBindingSource
        Me.DataGridViewItemList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridViewItemList.Location = New System.Drawing.Point(3, 45)
        Me.DataGridViewItemList.Name = "DataGridViewItemList"
        Me.DataGridViewItemList.RowHeadersWidth = 51
        Me.DataGridViewItemList.RowTemplate.Height = 24
        Me.DataGridViewItemList.Size = New System.Drawing.Size(571, 237)
        Me.DataGridViewItemList.TabIndex = 216
        '
        'ItemIDDataGridViewTextBoxColumn
        '
        Me.ItemIDDataGridViewTextBoxColumn.DataPropertyName = "Item_ID"
        Me.ItemIDDataGridViewTextBoxColumn.HeaderText = "Item_ID"
        Me.ItemIDDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.ItemIDDataGridViewTextBoxColumn.Name = "ItemIDDataGridViewTextBoxColumn"
        Me.ItemIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.ItemIDDataGridViewTextBoxColumn.Width = 125
        '
        'ItemNameDataGridViewTextBoxColumn
        '
        Me.ItemNameDataGridViewTextBoxColumn.DataPropertyName = "Item_Name"
        Me.ItemNameDataGridViewTextBoxColumn.HeaderText = "Item_Name"
        Me.ItemNameDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.ItemNameDataGridViewTextBoxColumn.Name = "ItemNameDataGridViewTextBoxColumn"
        Me.ItemNameDataGridViewTextBoxColumn.Width = 125
        '
        'ItemDetailDataGridViewTextBoxColumn
        '
        Me.ItemDetailDataGridViewTextBoxColumn.DataPropertyName = "Item_Detail"
        Me.ItemDetailDataGridViewTextBoxColumn.HeaderText = "Item_Detail"
        Me.ItemDetailDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.ItemDetailDataGridViewTextBoxColumn.Name = "ItemDetailDataGridViewTextBoxColumn"
        Me.ItemDetailDataGridViewTextBoxColumn.Width = 125
        '
        'ItemQuantityinstockDataGridViewTextBoxColumn
        '
        Me.ItemQuantityinstockDataGridViewTextBoxColumn.DataPropertyName = "Item_Quantity_in_stock"
        Me.ItemQuantityinstockDataGridViewTextBoxColumn.HeaderText = "Item_Quantity_in_stock"
        Me.ItemQuantityinstockDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.ItemQuantityinstockDataGridViewTextBoxColumn.Name = "ItemQuantityinstockDataGridViewTextBoxColumn"
        Me.ItemQuantityinstockDataGridViewTextBoxColumn.Width = 125
        '
        'ItemCostPerUnitDataGridViewTextBoxColumn
        '
        Me.ItemCostPerUnitDataGridViewTextBoxColumn.DataPropertyName = "Item_Cost_Per_Unit"
        Me.ItemCostPerUnitDataGridViewTextBoxColumn.HeaderText = "Item_Cost_Per_Unit"
        Me.ItemCostPerUnitDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.ItemCostPerUnitDataGridViewTextBoxColumn.Name = "ItemCostPerUnitDataGridViewTextBoxColumn"
        Me.ItemCostPerUnitDataGridViewTextBoxColumn.Width = 125
        '
        'ItemBindingSource
        '
        Me.ItemBindingSource.DataMember = "Item"
        Me.ItemBindingSource.DataSource = Me.Wellmeadows_HospitalDataSet
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
        Me.Label47.Location = New System.Drawing.Point(248, 5)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(80, 32)
        Me.Label47.TabIndex = 216
        Me.Label47.Text = "ITEM"
        '
        'txtWardName
        '
        Me.txtWardName.Location = New System.Drawing.Point(871, 68)
        Me.txtWardName.Name = "txtWardName"
        Me.txtWardName.Size = New System.Drawing.Size(188, 22)
        Me.txtWardName.TabIndex = 293
        '
        'Label46
        '
        Me.Label46.AutoSize = True
        Me.Label46.Location = New System.Drawing.Point(868, 49)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(80, 16)
        Me.Label46.TabIndex = 294
        Me.Label46.Text = "Ward Name"
        '
        'txtWardID
        '
        Me.txtWardID.Location = New System.Drawing.Point(620, 68)
        Me.txtWardID.Name = "txtWardID"
        Me.txtWardID.Size = New System.Drawing.Size(188, 22)
        Me.txtWardID.TabIndex = 291
        '
        'Label44
        '
        Me.Label44.AutoSize = True
        Me.Label44.Location = New System.Drawing.Point(617, 49)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(56, 16)
        Me.Label44.TabIndex = 292
        Me.Label44.Text = "Ward ID"
        '
        'btnStaffSearch
        '
        Me.btnStaffSearch.Location = New System.Drawing.Point(814, 124)
        Me.btnStaffSearch.Name = "btnStaffSearch"
        Me.btnStaffSearch.Size = New System.Drawing.Size(32, 23)
        Me.btnStaffSearch.TabIndex = 290
        Me.btnStaffSearch.Text = "..."
        Me.btnStaffSearch.UseVisualStyleBackColor = True
        '
        'lblStaffID
        '
        Me.lblStaffID.AutoSize = True
        Me.lblStaffID.Location = New System.Drawing.Point(890, 127)
        Me.lblStaffID.Name = "lblStaffID"
        Me.lblStaffID.Size = New System.Drawing.Size(49, 16)
        Me.lblStaffID.TabIndex = 289
        Me.lblStaffID.Text = "Staff ID"
        Me.lblStaffID.Visible = False
        '
        'txtStaffName
        '
        Me.txtStaffName.Location = New System.Drawing.Point(620, 125)
        Me.txtStaffName.Name = "txtStaffName"
        Me.txtStaffName.Size = New System.Drawing.Size(188, 22)
        Me.txtStaffName.TabIndex = 287
        '
        'Label42
        '
        Me.Label42.AutoSize = True
        Me.Label42.Location = New System.Drawing.Point(617, 106)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(73, 16)
        Me.Label42.TabIndex = 288
        Me.Label42.Text = "Staff Name"
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label39.Location = New System.Drawing.Point(5, 9)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(315, 38)
        Me.Label39.TabIndex = 286
        Me.Label39.Text = "ITEM REQUISITION"
        '
        'ItemTableAdapter
        '
        Me.ItemTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.DrugTableAdapter = Nothing
        Me.TableAdapterManager.Item_Order_DetailTableAdapter = Nothing
        Me.TableAdapterManager.Item_OrderTableAdapter = Nothing
        Me.TableAdapterManager.Item_ReceiveTableAdapter = Nothing
        Me.TableAdapterManager.Item_Requisitions_ByTableAdapter = Nothing
        Me.TableAdapterManager.Item_Requisitions_FormTableAdapter = Nothing
        Me.TableAdapterManager.ItemTableAdapter = Me.ItemTableAdapter
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
        'btnWardSearch
        '
        Me.btnWardSearch.Location = New System.Drawing.Point(814, 67)
        Me.btnWardSearch.Name = "btnWardSearch"
        Me.btnWardSearch.Size = New System.Drawing.Size(32, 23)
        Me.btnWardSearch.TabIndex = 304
        Me.btnWardSearch.Text = "..."
        Me.btnWardSearch.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.TableLayoutPanel3, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label50, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.txtQuantity, 0, 2)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(12, 50)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 3
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 92.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(583, 348)
        Me.TableLayoutPanel2.TabIndex = 305
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(617, 167)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(112, 16)
        Me.Label2.TabIndex = 321
        Me.Label2.Text = "Requisition Detail"
        '
        'txtRequisitionDetail
        '
        Me.txtRequisitionDetail.Location = New System.Drawing.Point(620, 186)
        Me.txtRequisitionDetail.Multiline = True
        Me.txtRequisitionDetail.Name = "txtRequisitionDetail"
        Me.txtRequisitionDetail.Size = New System.Drawing.Size(439, 163)
        Me.txtRequisitionDetail.TabIndex = 320
        '
        'FormItemRequisiton
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1135, 822)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtRequisitionDetail)
        Me.Controls.Add(Me.TableLayoutPanel2)
        Me.Controls.Add(Me.btnWardSearch)
        Me.Controls.Add(Me.Panel1)
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
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormItemRequisiton"
        Me.Text = "FormItemRequisiton"
        Me.Panel1.ResumeLayout(False)
        CType(Me.DataGridViewRequisitionList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.TableLayoutPanel5.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        CType(Me.DataGridViewItemList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Wellmeadows_HospitalDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents btnSUBMIT As Button
    Friend WithEvents TableLayoutPanel5 As TableLayoutPanel
    Friend WithEvents btnDELETE As Button
    Friend WithEvents btnADD As Button
    Friend WithEvents txtQuantity As TextBox
    Friend WithEvents Label50 As Label
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents Label47 As Label
    Friend WithEvents txtWardName As TextBox
    Friend WithEvents Label46 As Label
    Friend WithEvents txtWardID As TextBox
    Friend WithEvents Label44 As Label
    Friend WithEvents btnStaffSearch As Button
    Friend WithEvents lblStaffID As Label
    Friend WithEvents txtStaffName As TextBox
    Friend WithEvents Label42 As Label
    Friend WithEvents Label39 As Label
    Friend WithEvents Wellmeadows_HospitalDataSet As Wellmeadows_HospitalDataSet
    Friend WithEvents ItemBindingSource As BindingSource
    Friend WithEvents ItemTableAdapter As Wellmeadows_HospitalDataSetTableAdapters.ItemTableAdapter
    Friend WithEvents TableAdapterManager As Wellmeadows_HospitalDataSetTableAdapters.TableAdapterManager
    Friend WithEvents btnWardSearch As Button
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents DataGridViewItemList As DataGridView
    Friend WithEvents ItemIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ItemNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ItemDetailDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ItemQuantityinstockDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ItemCostPerUnitDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewRequisitionList As DataGridView
    Friend WithEvents ItemID As DataGridViewTextBoxColumn
    Friend WithEvents ItemName As DataGridViewTextBoxColumn
    Friend WithEvents ItemDesc As DataGridViewTextBoxColumn
    Friend WithEvents ItemCPU As DataGridViewTextBoxColumn
    Friend WithEvents ItemQuantity As DataGridViewTextBoxColumn
    Friend WithEvents Label2 As Label
    Friend WithEvents txtRequisitionDetail As TextBox
End Class
