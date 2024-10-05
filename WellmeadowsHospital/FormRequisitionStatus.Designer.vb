<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormRequisitionStatus
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
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtStaffName = New System.Windows.Forms.TextBox()
        Me.btnStaffSearch = New System.Windows.Forms.Button()
        Me.lblStaffID = New System.Windows.Forms.Label()
        Me.TableLayoutPanel7 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnDrugSAVE = New System.Windows.Forms.Button()
        Me.btnItemSAVE = New System.Windows.Forms.Button()
        Me.TableLayoutPanel8 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.DataGridViewItemReceive = New System.Windows.Forms.DataGridView()
        Me.ItemRequisitionIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemFormIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemRequisitionStatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemQuantityRequiredDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemRequisitionReceive2BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Wellmeadows_HospitalDataSet = New WellmeadowsHospital.Wellmeadows_HospitalDataSet()
        Me.TableLayoutPanel6 = New System.Windows.Forms.TableLayoutPanel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbtnCancelledItem = New System.Windows.Forms.RadioButton()
        Me.rbtnReceiveItem = New System.Windows.Forms.RadioButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtItemSearch = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.DataGridViewDrugReceive = New System.Windows.Forms.DataGridView()
        Me.DrugRequisitionIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DrugFormIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DrugRequisitionStatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DrugIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DrugNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DrugQuantityRequiredDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DrugRequisitionReceive2BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.rbtnCancelledDrug = New System.Windows.Forms.RadioButton()
        Me.rbtnReceiveDrug = New System.Windows.Forms.RadioButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtDrugSearch = New System.Windows.Forms.TextBox()
        Me.DrugRequisitionReceive2TableAdapter = New WellmeadowsHospital.Wellmeadows_HospitalDataSetTableAdapters.DrugRequisitionReceive2TableAdapter()
        Me.TableAdapterManager = New WellmeadowsHospital.Wellmeadows_HospitalDataSetTableAdapters.TableAdapterManager()
        Me.ItemRequisitionReceive2TableAdapter = New WellmeadowsHospital.Wellmeadows_HospitalDataSetTableAdapters.ItemRequisitionReceive2TableAdapter()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.TableLayoutPanel7.SuspendLayout()
        Me.TableLayoutPanel8.SuspendLayout()
        Me.TableLayoutPanel5.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridViewItemReceive, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemRequisitionReceive2BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Wellmeadows_HospitalDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel6.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.DataGridViewDrugReceive, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DrugRequisitionReceive2BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 1
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.TableLayoutPanel4, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.TableLayoutPanel7, 0, 2)
        Me.TableLayoutPanel3.Controls.Add(Me.TableLayoutPanel8, 0, 1)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 3
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.33557!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 83.57664!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.20438!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(1135, 822)
        Me.TableLayoutPanel3.TabIndex = 108
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.ColumnCount = 7
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.950249!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.950248!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.950248!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.2985!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.794508!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.56333!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.288751!))
        Me.TableLayoutPanel4.Controls.Add(Me.Label1, 3, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.Label5, 4, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.txtStaffName, 5, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.btnStaffSearch, 6, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.lblStaffID, 2, 0)
        Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 1
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(1129, 78)
        Me.TableLayoutPanel4.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(408, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(300, 38)
        Me.Label1.TabIndex = 89
        Me.Label1.Text = "RECEIVE STATUS"
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(791, 31)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 16)
        Me.Label5.TabIndex = 90
        Me.Label5.Text = "Staff Name"
        '
        'txtStaffName
        '
        Me.txtStaffName.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtStaffName.Location = New System.Drawing.Point(874, 28)
        Me.txtStaffName.Name = "txtStaffName"
        Me.txtStaffName.Size = New System.Drawing.Size(179, 22)
        Me.txtStaffName.TabIndex = 91
        '
        'btnStaffSearch
        '
        Me.btnStaffSearch.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.btnStaffSearch.Location = New System.Drawing.Point(1059, 27)
        Me.btnStaffSearch.Name = "btnStaffSearch"
        Me.btnStaffSearch.Size = New System.Drawing.Size(32, 23)
        Me.btnStaffSearch.TabIndex = 92
        Me.btnStaffSearch.Text = "..."
        Me.btnStaffSearch.UseVisualStyleBackColor = True
        '
        'lblStaffID
        '
        Me.lblStaffID.AutoSize = True
        Me.lblStaffID.Location = New System.Drawing.Point(225, 0)
        Me.lblStaffID.Name = "lblStaffID"
        Me.lblStaffID.Size = New System.Drawing.Size(46, 16)
        Me.lblStaffID.TabIndex = 93
        Me.lblStaffID.Text = "StaffID"
        Me.lblStaffID.Visible = False
        '
        'TableLayoutPanel7
        '
        Me.TableLayoutPanel7.ColumnCount = 2
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel7.Controls.Add(Me.btnDrugSAVE, 1, 0)
        Me.TableLayoutPanel7.Controls.Add(Me.btnItemSAVE, 0, 0)
        Me.TableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel7.Location = New System.Drawing.Point(3, 773)
        Me.TableLayoutPanel7.Name = "TableLayoutPanel7"
        Me.TableLayoutPanel7.RowCount = 1
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46.0!))
        Me.TableLayoutPanel7.Size = New System.Drawing.Size(1129, 46)
        Me.TableLayoutPanel7.TabIndex = 1
        '
        'btnDrugSAVE
        '
        Me.btnDrugSAVE.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDrugSAVE.Location = New System.Drawing.Point(1011, 3)
        Me.btnDrugSAVE.Name = "btnDrugSAVE"
        Me.btnDrugSAVE.Size = New System.Drawing.Size(115, 34)
        Me.btnDrugSAVE.TabIndex = 106
        Me.btnDrugSAVE.Text = "SAVE"
        Me.btnDrugSAVE.UseVisualStyleBackColor = True
        '
        'btnItemSAVE
        '
        Me.btnItemSAVE.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnItemSAVE.Location = New System.Drawing.Point(446, 3)
        Me.btnItemSAVE.Name = "btnItemSAVE"
        Me.btnItemSAVE.Size = New System.Drawing.Size(115, 34)
        Me.btnItemSAVE.TabIndex = 107
        Me.btnItemSAVE.Text = "SAVE"
        Me.btnItemSAVE.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel8
        '
        Me.TableLayoutPanel8.ColumnCount = 2
        Me.TableLayoutPanel8.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel8.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel8.Controls.Add(Me.TableLayoutPanel5, 0, 0)
        Me.TableLayoutPanel8.Controls.Add(Me.TableLayoutPanel1, 1, 0)
        Me.TableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel8.Location = New System.Drawing.Point(3, 87)
        Me.TableLayoutPanel8.Name = "TableLayoutPanel8"
        Me.TableLayoutPanel8.RowCount = 1
        Me.TableLayoutPanel8.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel8.Size = New System.Drawing.Size(1129, 680)
        Me.TableLayoutPanel8.TabIndex = 2
        '
        'TableLayoutPanel5
        '
        Me.TableLayoutPanel5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TableLayoutPanel5.ColumnCount = 1
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 430.0!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel5.Controls.Add(Me.Panel1, 0, 1)
        Me.TableLayoutPanel5.Controls.Add(Me.TableLayoutPanel6, 0, 0)
        Me.TableLayoutPanel5.Location = New System.Drawing.Point(67, 14)
        Me.TableLayoutPanel5.Name = "TableLayoutPanel5"
        Me.TableLayoutPanel5.RowCount = 2
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.81089!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75.18911!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel5.Size = New System.Drawing.Size(430, 652)
        Me.TableLayoutPanel5.TabIndex = 105
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.DataGridViewItemReceive)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(3, 164)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(424, 485)
        Me.Panel1.TabIndex = 103
        '
        'DataGridViewItemReceive
        '
        Me.DataGridViewItemReceive.AutoGenerateColumns = False
        Me.DataGridViewItemReceive.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewItemReceive.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ItemRequisitionIDDataGridViewTextBoxColumn, Me.ItemFormIDDataGridViewTextBoxColumn, Me.ItemRequisitionStatusDataGridViewTextBoxColumn, Me.ItemIDDataGridViewTextBoxColumn, Me.ItemNameDataGridViewTextBoxColumn, Me.ItemQuantityRequiredDataGridViewTextBoxColumn})
        Me.DataGridViewItemReceive.DataSource = Me.ItemRequisitionReceive2BindingSource
        Me.DataGridViewItemReceive.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridViewItemReceive.Location = New System.Drawing.Point(0, 0)
        Me.DataGridViewItemReceive.Name = "DataGridViewItemReceive"
        Me.DataGridViewItemReceive.RowHeadersWidth = 51
        Me.DataGridViewItemReceive.RowTemplate.Height = 24
        Me.DataGridViewItemReceive.Size = New System.Drawing.Size(424, 485)
        Me.DataGridViewItemReceive.TabIndex = 1
        '
        'ItemRequisitionIDDataGridViewTextBoxColumn
        '
        Me.ItemRequisitionIDDataGridViewTextBoxColumn.DataPropertyName = "Item_Requisition_ID"
        Me.ItemRequisitionIDDataGridViewTextBoxColumn.HeaderText = "Item_Requisition_ID"
        Me.ItemRequisitionIDDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.ItemRequisitionIDDataGridViewTextBoxColumn.Name = "ItemRequisitionIDDataGridViewTextBoxColumn"
        Me.ItemRequisitionIDDataGridViewTextBoxColumn.Width = 125
        '
        'ItemFormIDDataGridViewTextBoxColumn
        '
        Me.ItemFormIDDataGridViewTextBoxColumn.DataPropertyName = "Item_Form_ID"
        Me.ItemFormIDDataGridViewTextBoxColumn.HeaderText = "Item_Form_ID"
        Me.ItemFormIDDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.ItemFormIDDataGridViewTextBoxColumn.Name = "ItemFormIDDataGridViewTextBoxColumn"
        Me.ItemFormIDDataGridViewTextBoxColumn.Width = 125
        '
        'ItemRequisitionStatusDataGridViewTextBoxColumn
        '
        Me.ItemRequisitionStatusDataGridViewTextBoxColumn.DataPropertyName = "Item_Requisition_Status"
        Me.ItemRequisitionStatusDataGridViewTextBoxColumn.HeaderText = "Item_Requisition_Status"
        Me.ItemRequisitionStatusDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.ItemRequisitionStatusDataGridViewTextBoxColumn.Name = "ItemRequisitionStatusDataGridViewTextBoxColumn"
        Me.ItemRequisitionStatusDataGridViewTextBoxColumn.Width = 125
        '
        'ItemIDDataGridViewTextBoxColumn
        '
        Me.ItemIDDataGridViewTextBoxColumn.DataPropertyName = "Item_ID"
        Me.ItemIDDataGridViewTextBoxColumn.HeaderText = "Item_ID"
        Me.ItemIDDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.ItemIDDataGridViewTextBoxColumn.Name = "ItemIDDataGridViewTextBoxColumn"
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
        'ItemQuantityRequiredDataGridViewTextBoxColumn
        '
        Me.ItemQuantityRequiredDataGridViewTextBoxColumn.DataPropertyName = "Item_Quantity_Required"
        Me.ItemQuantityRequiredDataGridViewTextBoxColumn.HeaderText = "Item_Quantity_Required"
        Me.ItemQuantityRequiredDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.ItemQuantityRequiredDataGridViewTextBoxColumn.Name = "ItemQuantityRequiredDataGridViewTextBoxColumn"
        Me.ItemQuantityRequiredDataGridViewTextBoxColumn.Width = 125
        '
        'ItemRequisitionReceive2BindingSource
        '
        Me.ItemRequisitionReceive2BindingSource.DataMember = "ItemRequisitionReceive2"
        Me.ItemRequisitionReceive2BindingSource.DataSource = Me.Wellmeadows_HospitalDataSet
        '
        'Wellmeadows_HospitalDataSet
        '
        Me.Wellmeadows_HospitalDataSet.DataSetName = "Wellmeadows_HospitalDataSet"
        Me.Wellmeadows_HospitalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TableLayoutPanel6
        '
        Me.TableLayoutPanel6.ColumnCount = 1
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel6.Controls.Add(Me.GroupBox1, 0, 3)
        Me.TableLayoutPanel6.Controls.Add(Me.Label2, 0, 1)
        Me.TableLayoutPanel6.Controls.Add(Me.Label3, 0, 0)
        Me.TableLayoutPanel6.Controls.Add(Me.txtItemSearch, 0, 2)
        Me.TableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel6.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel6.Name = "TableLayoutPanel6"
        Me.TableLayoutPanel6.RowCount = 4
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 83.0!))
        Me.TableLayoutPanel6.Size = New System.Drawing.Size(424, 155)
        Me.TableLayoutPanel6.TabIndex = 104
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GroupBox1.Controls.Add(Me.rbtnCancelledItem)
        Me.GroupBox1.Controls.Add(Me.rbtnReceiveItem)
        Me.GroupBox1.Location = New System.Drawing.Point(144, 75)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(136, 77)
        Me.GroupBox1.TabIndex = 102
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Receive Status"
        '
        'rbtnCancelledItem
        '
        Me.rbtnCancelledItem.AutoSize = True
        Me.rbtnCancelledItem.Location = New System.Drawing.Point(6, 47)
        Me.rbtnCancelledItem.Name = "rbtnCancelledItem"
        Me.rbtnCancelledItem.Size = New System.Drawing.Size(89, 20)
        Me.rbtnCancelledItem.TabIndex = 1
        Me.rbtnCancelledItem.TabStop = True
        Me.rbtnCancelledItem.Text = "Cancelled"
        Me.rbtnCancelledItem.UseVisualStyleBackColor = True
        '
        'rbtnReceiveItem
        '
        Me.rbtnReceiveItem.AutoSize = True
        Me.rbtnReceiveItem.Location = New System.Drawing.Point(6, 21)
        Me.rbtnReceiveItem.Name = "rbtnReceiveItem"
        Me.rbtnReceiveItem.Size = New System.Drawing.Size(79, 20)
        Me.rbtnReceiveItem.TabIndex = 0
        Me.rbtnReceiveItem.TabStop = True
        Me.rbtnReceiveItem.Text = "Receive"
        Me.rbtnReceiveItem.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.Location = New System.Drawing.Point(143, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(137, 20)
        Me.Label2.TabIndex = 100
        Me.Label2.Text = "REQUISITION ID"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.Location = New System.Drawing.Point(105, 1)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(213, 22)
        Me.Label3.TabIndex = 97
        Me.Label3.Text = "ITEM RECEIVE STATUS"
        '
        'txtItemSearch
        '
        Me.txtItemSearch.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtItemSearch.Location = New System.Drawing.Point(136, 51)
        Me.txtItemSearch.Name = "txtItemSearch"
        Me.txtItemSearch.Size = New System.Drawing.Size(152, 22)
        Me.txtItemSearch.TabIndex = 98
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 430.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Panel2, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 0, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(631, 14)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.81089!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75.18911!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(430, 652)
        Me.TableLayoutPanel1.TabIndex = 104
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.DataGridViewDrugReceive)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(3, 164)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(424, 485)
        Me.Panel2.TabIndex = 103
        '
        'DataGridViewDrugReceive
        '
        Me.DataGridViewDrugReceive.AutoGenerateColumns = False
        Me.DataGridViewDrugReceive.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewDrugReceive.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DrugRequisitionIDDataGridViewTextBoxColumn, Me.DrugFormIDDataGridViewTextBoxColumn, Me.DrugRequisitionStatusDataGridViewTextBoxColumn, Me.DrugIDDataGridViewTextBoxColumn, Me.DrugNameDataGridViewTextBoxColumn, Me.DrugQuantityRequiredDataGridViewTextBoxColumn})
        Me.DataGridViewDrugReceive.DataSource = Me.DrugRequisitionReceive2BindingSource
        Me.DataGridViewDrugReceive.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridViewDrugReceive.Location = New System.Drawing.Point(0, 0)
        Me.DataGridViewDrugReceive.Name = "DataGridViewDrugReceive"
        Me.DataGridViewDrugReceive.RowHeadersWidth = 51
        Me.DataGridViewDrugReceive.RowTemplate.Height = 24
        Me.DataGridViewDrugReceive.Size = New System.Drawing.Size(424, 485)
        Me.DataGridViewDrugReceive.TabIndex = 1
        '
        'DrugRequisitionIDDataGridViewTextBoxColumn
        '
        Me.DrugRequisitionIDDataGridViewTextBoxColumn.DataPropertyName = "Drug_Requisition_ID"
        Me.DrugRequisitionIDDataGridViewTextBoxColumn.HeaderText = "Drug_Requisition_ID"
        Me.DrugRequisitionIDDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.DrugRequisitionIDDataGridViewTextBoxColumn.Name = "DrugRequisitionIDDataGridViewTextBoxColumn"
        Me.DrugRequisitionIDDataGridViewTextBoxColumn.Width = 125
        '
        'DrugFormIDDataGridViewTextBoxColumn
        '
        Me.DrugFormIDDataGridViewTextBoxColumn.DataPropertyName = "Drug_Form_ID"
        Me.DrugFormIDDataGridViewTextBoxColumn.HeaderText = "Drug_Form_ID"
        Me.DrugFormIDDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.DrugFormIDDataGridViewTextBoxColumn.Name = "DrugFormIDDataGridViewTextBoxColumn"
        Me.DrugFormIDDataGridViewTextBoxColumn.Width = 125
        '
        'DrugRequisitionStatusDataGridViewTextBoxColumn
        '
        Me.DrugRequisitionStatusDataGridViewTextBoxColumn.DataPropertyName = "Drug_Requisition_Status"
        Me.DrugRequisitionStatusDataGridViewTextBoxColumn.HeaderText = "Drug_Requisition_Status"
        Me.DrugRequisitionStatusDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.DrugRequisitionStatusDataGridViewTextBoxColumn.Name = "DrugRequisitionStatusDataGridViewTextBoxColumn"
        Me.DrugRequisitionStatusDataGridViewTextBoxColumn.Width = 125
        '
        'DrugIDDataGridViewTextBoxColumn
        '
        Me.DrugIDDataGridViewTextBoxColumn.DataPropertyName = "Drug_ID"
        Me.DrugIDDataGridViewTextBoxColumn.HeaderText = "Drug_ID"
        Me.DrugIDDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.DrugIDDataGridViewTextBoxColumn.Name = "DrugIDDataGridViewTextBoxColumn"
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
        'DrugQuantityRequiredDataGridViewTextBoxColumn
        '
        Me.DrugQuantityRequiredDataGridViewTextBoxColumn.DataPropertyName = "Drug_Quantity_Required"
        Me.DrugQuantityRequiredDataGridViewTextBoxColumn.HeaderText = "Drug_Quantity_Required"
        Me.DrugQuantityRequiredDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.DrugQuantityRequiredDataGridViewTextBoxColumn.Name = "DrugQuantityRequiredDataGridViewTextBoxColumn"
        Me.DrugQuantityRequiredDataGridViewTextBoxColumn.Width = 125
        '
        'DrugRequisitionReceive2BindingSource
        '
        Me.DrugRequisitionReceive2BindingSource.DataMember = "DrugRequisitionReceive2"
        Me.DrugRequisitionReceive2BindingSource.DataSource = Me.Wellmeadows_HospitalDataSet
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.GroupBox2, 0, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.Label4, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Label6, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.txtDrugSearch, 0, 2)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 4
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 83.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(424, 155)
        Me.TableLayoutPanel2.TabIndex = 104
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GroupBox2.Controls.Add(Me.rbtnCancelledDrug)
        Me.GroupBox2.Controls.Add(Me.rbtnReceiveDrug)
        Me.GroupBox2.Location = New System.Drawing.Point(144, 75)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(136, 77)
        Me.GroupBox2.TabIndex = 102
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Receive Status"
        '
        'rbtnCancelledDrug
        '
        Me.rbtnCancelledDrug.AutoSize = True
        Me.rbtnCancelledDrug.Location = New System.Drawing.Point(6, 47)
        Me.rbtnCancelledDrug.Name = "rbtnCancelledDrug"
        Me.rbtnCancelledDrug.Size = New System.Drawing.Size(89, 20)
        Me.rbtnCancelledDrug.TabIndex = 1
        Me.rbtnCancelledDrug.TabStop = True
        Me.rbtnCancelledDrug.Text = "Cancelled"
        Me.rbtnCancelledDrug.UseVisualStyleBackColor = True
        '
        'rbtnReceiveDrug
        '
        Me.rbtnReceiveDrug.AutoSize = True
        Me.rbtnReceiveDrug.Location = New System.Drawing.Point(6, 21)
        Me.rbtnReceiveDrug.Name = "rbtnReceiveDrug"
        Me.rbtnReceiveDrug.Size = New System.Drawing.Size(79, 20)
        Me.rbtnReceiveDrug.TabIndex = 0
        Me.rbtnReceiveDrug.TabStop = True
        Me.rbtnReceiveDrug.Text = "Receive"
        Me.rbtnReceiveDrug.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label4.Location = New System.Drawing.Point(143, 26)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(137, 20)
        Me.Label4.TabIndex = 100
        Me.Label4.Text = "REQUISITION ID"
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label6.Location = New System.Drawing.Point(100, 1)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(224, 22)
        Me.Label6.TabIndex = 97
        Me.Label6.Text = "DRUG RECEIVE STATUS"
        '
        'txtDrugSearch
        '
        Me.txtDrugSearch.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtDrugSearch.Location = New System.Drawing.Point(136, 51)
        Me.txtDrugSearch.Name = "txtDrugSearch"
        Me.txtDrugSearch.Size = New System.Drawing.Size(152, 22)
        Me.txtDrugSearch.TabIndex = 98
        '
        'DrugRequisitionReceive2TableAdapter
        '
        Me.DrugRequisitionReceive2TableAdapter.ClearBeforeFill = True
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
        'ItemRequisitionReceive2TableAdapter
        '
        Me.ItemRequisitionReceive2TableAdapter.ClearBeforeFill = True
        '
        'FormRequisitionStatus
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1135, 822)
        Me.Controls.Add(Me.TableLayoutPanel3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormRequisitionStatus"
        Me.Text = "FormRequisitionStatus"
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.TableLayoutPanel4.PerformLayout()
        Me.TableLayoutPanel7.ResumeLayout(False)
        Me.TableLayoutPanel8.ResumeLayout(False)
        Me.TableLayoutPanel5.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.DataGridViewItemReceive, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemRequisitionReceive2BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Wellmeadows_HospitalDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel6.ResumeLayout(False)
        Me.TableLayoutPanel6.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.DataGridViewDrugReceive, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DrugRequisitionReceive2BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents Wellmeadows_HospitalDataSet As Wellmeadows_HospitalDataSet
    Friend WithEvents DrugRequisitionReceive2BindingSource As BindingSource
    Friend WithEvents DrugRequisitionReceive2TableAdapter As Wellmeadows_HospitalDataSetTableAdapters.DrugRequisitionReceive2TableAdapter
    Friend WithEvents TableAdapterManager As Wellmeadows_HospitalDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ItemRequisitionReceive2BindingSource As BindingSource
    Friend WithEvents ItemRequisitionReceive2TableAdapter As Wellmeadows_HospitalDataSetTableAdapters.ItemRequisitionReceive2TableAdapter
    Friend WithEvents btnItemSAVE As Button
    Friend WithEvents TableLayoutPanel5 As TableLayoutPanel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents DataGridViewItemReceive As DataGridView
    Friend WithEvents ItemRequisitionIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ItemFormIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ItemRequisitionStatusDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ItemIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ItemNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ItemQuantityRequiredDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TableLayoutPanel6 As TableLayoutPanel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rbtnCancelledItem As RadioButton
    Friend WithEvents rbtnReceiveItem As RadioButton
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtItemSearch As TextBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents DataGridViewDrugReceive As DataGridView
    Friend WithEvents DrugRequisitionIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DrugFormIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DrugRequisitionStatusDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DrugIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DrugNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DrugQuantityRequiredDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents rbtnCancelledDrug As RadioButton
    Friend WithEvents rbtnReceiveDrug As RadioButton
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtDrugSearch As TextBox
    Friend WithEvents btnDrugSAVE As Button
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents Label5 As Label
    Friend WithEvents txtStaffName As TextBox
    Friend WithEvents btnStaffSearch As Button
    Friend WithEvents TableLayoutPanel7 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel8 As TableLayoutPanel
    Friend WithEvents lblStaffID As Label
End Class
