﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormOrderStatus
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
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SuppOrderItemBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Wellmeadows_HospitalDataSet = New WellmeadowsHospital.Wellmeadows_HospitalDataSet()
        Me.SuppOrderDrugBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SuppOrderDrugTableAdapter = New WellmeadowsHospital.Wellmeadows_HospitalDataSetTableAdapters.SuppOrderDrugTableAdapter()
        Me.TableAdapterManager = New WellmeadowsHospital.Wellmeadows_HospitalDataSetTableAdapters.TableAdapterManager()
        Me.SuppOrderItemTableAdapter = New WellmeadowsHospital.Wellmeadows_HospitalDataSetTableAdapters.SuppOrderItemTableAdapter()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnItemSAVE = New System.Windows.Forms.Button()
        Me.TableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.DataGridViewItemOrders = New System.Windows.Forms.DataGridView()
        Me.ItemOrderIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SuppIDDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SuppNameDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemOrderStatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemOrderQuantityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemPriceTotalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemOrderDetailIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TableLayoutPanel6 = New System.Windows.Forms.TableLayoutPanel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbtnCancelledItem = New System.Windows.Forms.RadioButton()
        Me.rbtnDeliveredItem = New System.Windows.Forms.RadioButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtItemSearch = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.DataGridViewDrugOrders = New System.Windows.Forms.DataGridView()
        Me.DrugOrderIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SuppIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SuppNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DrugOrderStatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DrugIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DrugNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DrugOrderQuantityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DrugPriceTotalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DrugOrderDetailIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.rbtnCancelledDrug = New System.Windows.Forms.RadioButton()
        Me.rbtnDeliveredDrug = New System.Windows.Forms.RadioButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtDrugSearch = New System.Windows.Forms.TextBox()
        Me.btnDrugSAVE = New System.Windows.Forms.Button()
        CType(Me.SuppOrderItemBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Wellmeadows_HospitalDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SuppOrderDrugBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.TableLayoutPanel5.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridViewItemOrders, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel6.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.DataGridViewDrugOrders, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label5.Location = New System.Drawing.Point(3, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(0, 20)
        Me.Label5.TabIndex = 99
        '
        'SuppOrderItemBindingSource
        '
        Me.SuppOrderItemBindingSource.DataMember = "SuppOrderItem"
        Me.SuppOrderItemBindingSource.DataSource = Me.Wellmeadows_HospitalDataSet
        '
        'Wellmeadows_HospitalDataSet
        '
        Me.Wellmeadows_HospitalDataSet.DataSetName = "Wellmeadows_HospitalDataSet"
        Me.Wellmeadows_HospitalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SuppOrderDrugBindingSource
        '
        Me.SuppOrderDrugBindingSource.DataMember = "SuppOrderDrug"
        Me.SuppOrderDrugBindingSource.DataSource = Me.Wellmeadows_HospitalDataSet
        '
        'SuppOrderDrugTableAdapter
        '
        Me.SuppOrderDrugTableAdapter.ClearBeforeFill = True
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
        'SuppOrderItemTableAdapter
        '
        Me.SuppOrderItemTableAdapter.ClearBeforeFill = True
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 1
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.TableLayoutPanel4, 0, 0)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 1
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 714.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(1117, 775)
        Me.TableLayoutPanel3.TabIndex = 109
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.ColumnCount = 2
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.Controls.Add(Me.btnItemSAVE, 0, 1)
        Me.TableLayoutPanel4.Controls.Add(Me.TableLayoutPanel5, 0, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.TableLayoutPanel1, 1, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.btnDrugSAVE, 1, 1)
        Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 2
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(1111, 769)
        Me.TableLayoutPanel4.TabIndex = 90
        '
        'btnItemSAVE
        '
        Me.btnItemSAVE.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnItemSAVE.Location = New System.Drawing.Point(437, 732)
        Me.btnItemSAVE.Name = "btnItemSAVE"
        Me.btnItemSAVE.Size = New System.Drawing.Size(115, 34)
        Me.btnItemSAVE.TabIndex = 107
        Me.btnItemSAVE.Text = "SAVE"
        Me.btnItemSAVE.UseVisualStyleBackColor = True
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
        Me.TableLayoutPanel5.Location = New System.Drawing.Point(62, 38)
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
        Me.Panel1.Controls.Add(Me.DataGridViewItemOrders)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(3, 164)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(424, 485)
        Me.Panel1.TabIndex = 103
        '
        'DataGridViewItemOrders
        '
        Me.DataGridViewItemOrders.AutoGenerateColumns = False
        Me.DataGridViewItemOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewItemOrders.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ItemOrderIDDataGridViewTextBoxColumn, Me.SuppIDDataGridViewTextBoxColumn1, Me.SuppNameDataGridViewTextBoxColumn1, Me.ItemOrderStatusDataGridViewTextBoxColumn, Me.ItemIDDataGridViewTextBoxColumn, Me.ItemNameDataGridViewTextBoxColumn, Me.ItemOrderQuantityDataGridViewTextBoxColumn, Me.ItemPriceTotalDataGridViewTextBoxColumn, Me.ItemOrderDetailIDDataGridViewTextBoxColumn})
        Me.DataGridViewItemOrders.DataSource = Me.SuppOrderItemBindingSource
        Me.DataGridViewItemOrders.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridViewItemOrders.Location = New System.Drawing.Point(0, 0)
        Me.DataGridViewItemOrders.Name = "DataGridViewItemOrders"
        Me.DataGridViewItemOrders.RowHeadersWidth = 51
        Me.DataGridViewItemOrders.RowTemplate.Height = 24
        Me.DataGridViewItemOrders.Size = New System.Drawing.Size(424, 485)
        Me.DataGridViewItemOrders.TabIndex = 1
        '
        'ItemOrderIDDataGridViewTextBoxColumn
        '
        Me.ItemOrderIDDataGridViewTextBoxColumn.DataPropertyName = "Item_Order_ID"
        Me.ItemOrderIDDataGridViewTextBoxColumn.HeaderText = "Item_Order_ID"
        Me.ItemOrderIDDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.ItemOrderIDDataGridViewTextBoxColumn.Name = "ItemOrderIDDataGridViewTextBoxColumn"
        Me.ItemOrderIDDataGridViewTextBoxColumn.Width = 125
        '
        'SuppIDDataGridViewTextBoxColumn1
        '
        Me.SuppIDDataGridViewTextBoxColumn1.DataPropertyName = "Supp_ID"
        Me.SuppIDDataGridViewTextBoxColumn1.HeaderText = "Supp_ID"
        Me.SuppIDDataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.SuppIDDataGridViewTextBoxColumn1.Name = "SuppIDDataGridViewTextBoxColumn1"
        Me.SuppIDDataGridViewTextBoxColumn1.Width = 125
        '
        'SuppNameDataGridViewTextBoxColumn1
        '
        Me.SuppNameDataGridViewTextBoxColumn1.DataPropertyName = "Supp_Name"
        Me.SuppNameDataGridViewTextBoxColumn1.HeaderText = "Supp_Name"
        Me.SuppNameDataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.SuppNameDataGridViewTextBoxColumn1.Name = "SuppNameDataGridViewTextBoxColumn1"
        Me.SuppNameDataGridViewTextBoxColumn1.Width = 125
        '
        'ItemOrderStatusDataGridViewTextBoxColumn
        '
        Me.ItemOrderStatusDataGridViewTextBoxColumn.DataPropertyName = "Item_Order_Status"
        Me.ItemOrderStatusDataGridViewTextBoxColumn.HeaderText = "Item_Order_Status"
        Me.ItemOrderStatusDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.ItemOrderStatusDataGridViewTextBoxColumn.Name = "ItemOrderStatusDataGridViewTextBoxColumn"
        Me.ItemOrderStatusDataGridViewTextBoxColumn.Width = 125
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
        'ItemOrderQuantityDataGridViewTextBoxColumn
        '
        Me.ItemOrderQuantityDataGridViewTextBoxColumn.DataPropertyName = "Item_Order_Quantity"
        Me.ItemOrderQuantityDataGridViewTextBoxColumn.HeaderText = "Item_Order_Quantity"
        Me.ItemOrderQuantityDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.ItemOrderQuantityDataGridViewTextBoxColumn.Name = "ItemOrderQuantityDataGridViewTextBoxColumn"
        Me.ItemOrderQuantityDataGridViewTextBoxColumn.Width = 125
        '
        'ItemPriceTotalDataGridViewTextBoxColumn
        '
        Me.ItemPriceTotalDataGridViewTextBoxColumn.DataPropertyName = "Item_Price_Total"
        Me.ItemPriceTotalDataGridViewTextBoxColumn.HeaderText = "Item_Price_Total"
        Me.ItemPriceTotalDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.ItemPriceTotalDataGridViewTextBoxColumn.Name = "ItemPriceTotalDataGridViewTextBoxColumn"
        Me.ItemPriceTotalDataGridViewTextBoxColumn.Width = 125
        '
        'ItemOrderDetailIDDataGridViewTextBoxColumn
        '
        Me.ItemOrderDetailIDDataGridViewTextBoxColumn.DataPropertyName = "Item_Order_Detail_ID"
        Me.ItemOrderDetailIDDataGridViewTextBoxColumn.HeaderText = "Item_Order_Detail_ID"
        Me.ItemOrderDetailIDDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.ItemOrderDetailIDDataGridViewTextBoxColumn.Name = "ItemOrderDetailIDDataGridViewTextBoxColumn"
        Me.ItemOrderDetailIDDataGridViewTextBoxColumn.Width = 125
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
        Me.GroupBox1.Controls.Add(Me.rbtnDeliveredItem)
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
        'rbtnDeliveredItem
        '
        Me.rbtnDeliveredItem.AutoSize = True
        Me.rbtnDeliveredItem.Location = New System.Drawing.Point(6, 21)
        Me.rbtnDeliveredItem.Name = "rbtnDeliveredItem"
        Me.rbtnDeliveredItem.Size = New System.Drawing.Size(87, 20)
        Me.rbtnDeliveredItem.TabIndex = 0
        Me.rbtnDeliveredItem.TabStop = True
        Me.rbtnDeliveredItem.Text = "Delivered"
        Me.rbtnDeliveredItem.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.Location = New System.Drawing.Point(154, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(116, 20)
        Me.Label2.TabIndex = 100
        Me.Label2.Text = "ชื่อซัพพลายเออร์"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.Location = New System.Drawing.Point(112, 1)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(200, 22)
        Me.Label3.TabIndex = 97
        Me.Label3.Text = "ITEM ORDER STATUS"
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
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(618, 38)
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
        Me.Panel2.Controls.Add(Me.DataGridViewDrugOrders)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(3, 164)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(424, 485)
        Me.Panel2.TabIndex = 103
        '
        'DataGridViewDrugOrders
        '
        Me.DataGridViewDrugOrders.AutoGenerateColumns = False
        Me.DataGridViewDrugOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewDrugOrders.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DrugOrderIDDataGridViewTextBoxColumn, Me.SuppIDDataGridViewTextBoxColumn, Me.SuppNameDataGridViewTextBoxColumn, Me.DrugOrderStatusDataGridViewTextBoxColumn, Me.DrugIDDataGridViewTextBoxColumn, Me.DrugNameDataGridViewTextBoxColumn, Me.DrugOrderQuantityDataGridViewTextBoxColumn, Me.DrugPriceTotalDataGridViewTextBoxColumn, Me.DrugOrderDetailIDDataGridViewTextBoxColumn})
        Me.DataGridViewDrugOrders.DataSource = Me.SuppOrderDrugBindingSource
        Me.DataGridViewDrugOrders.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridViewDrugOrders.Location = New System.Drawing.Point(0, 0)
        Me.DataGridViewDrugOrders.Name = "DataGridViewDrugOrders"
        Me.DataGridViewDrugOrders.RowHeadersWidth = 51
        Me.DataGridViewDrugOrders.RowTemplate.Height = 24
        Me.DataGridViewDrugOrders.Size = New System.Drawing.Size(424, 485)
        Me.DataGridViewDrugOrders.TabIndex = 1
        '
        'DrugOrderIDDataGridViewTextBoxColumn
        '
        Me.DrugOrderIDDataGridViewTextBoxColumn.DataPropertyName = "Drug_Order_ID"
        Me.DrugOrderIDDataGridViewTextBoxColumn.HeaderText = "Drug_Order_ID"
        Me.DrugOrderIDDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.DrugOrderIDDataGridViewTextBoxColumn.Name = "DrugOrderIDDataGridViewTextBoxColumn"
        Me.DrugOrderIDDataGridViewTextBoxColumn.Width = 125
        '
        'SuppIDDataGridViewTextBoxColumn
        '
        Me.SuppIDDataGridViewTextBoxColumn.DataPropertyName = "Supp_ID"
        Me.SuppIDDataGridViewTextBoxColumn.HeaderText = "Supp_ID"
        Me.SuppIDDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.SuppIDDataGridViewTextBoxColumn.Name = "SuppIDDataGridViewTextBoxColumn"
        Me.SuppIDDataGridViewTextBoxColumn.Width = 125
        '
        'SuppNameDataGridViewTextBoxColumn
        '
        Me.SuppNameDataGridViewTextBoxColumn.DataPropertyName = "Supp_Name"
        Me.SuppNameDataGridViewTextBoxColumn.HeaderText = "Supp_Name"
        Me.SuppNameDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.SuppNameDataGridViewTextBoxColumn.Name = "SuppNameDataGridViewTextBoxColumn"
        Me.SuppNameDataGridViewTextBoxColumn.Width = 125
        '
        'DrugOrderStatusDataGridViewTextBoxColumn
        '
        Me.DrugOrderStatusDataGridViewTextBoxColumn.DataPropertyName = "Drug_Order_Status"
        Me.DrugOrderStatusDataGridViewTextBoxColumn.HeaderText = "Drug_Order_Status"
        Me.DrugOrderStatusDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.DrugOrderStatusDataGridViewTextBoxColumn.Name = "DrugOrderStatusDataGridViewTextBoxColumn"
        Me.DrugOrderStatusDataGridViewTextBoxColumn.Width = 125
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
        'DrugOrderQuantityDataGridViewTextBoxColumn
        '
        Me.DrugOrderQuantityDataGridViewTextBoxColumn.DataPropertyName = "Drug_Order_Quantity"
        Me.DrugOrderQuantityDataGridViewTextBoxColumn.HeaderText = "Drug_Order_Quantity"
        Me.DrugOrderQuantityDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.DrugOrderQuantityDataGridViewTextBoxColumn.Name = "DrugOrderQuantityDataGridViewTextBoxColumn"
        Me.DrugOrderQuantityDataGridViewTextBoxColumn.Width = 125
        '
        'DrugPriceTotalDataGridViewTextBoxColumn
        '
        Me.DrugPriceTotalDataGridViewTextBoxColumn.DataPropertyName = "Drug_Price_Total"
        Me.DrugPriceTotalDataGridViewTextBoxColumn.HeaderText = "Drug_Price_Total"
        Me.DrugPriceTotalDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.DrugPriceTotalDataGridViewTextBoxColumn.Name = "DrugPriceTotalDataGridViewTextBoxColumn"
        Me.DrugPriceTotalDataGridViewTextBoxColumn.Width = 125
        '
        'DrugOrderDetailIDDataGridViewTextBoxColumn
        '
        Me.DrugOrderDetailIDDataGridViewTextBoxColumn.DataPropertyName = "Drug_Order_Detail_ID"
        Me.DrugOrderDetailIDDataGridViewTextBoxColumn.HeaderText = "Drug_Order_Detail_ID"
        Me.DrugOrderDetailIDDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.DrugOrderDetailIDDataGridViewTextBoxColumn.Name = "DrugOrderDetailIDDataGridViewTextBoxColumn"
        Me.DrugOrderDetailIDDataGridViewTextBoxColumn.Width = 125
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
        Me.GroupBox2.Controls.Add(Me.rbtnDeliveredDrug)
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
        'rbtnDeliveredDrug
        '
        Me.rbtnDeliveredDrug.AutoSize = True
        Me.rbtnDeliveredDrug.Location = New System.Drawing.Point(6, 21)
        Me.rbtnDeliveredDrug.Name = "rbtnDeliveredDrug"
        Me.rbtnDeliveredDrug.Size = New System.Drawing.Size(87, 20)
        Me.rbtnDeliveredDrug.TabIndex = 0
        Me.rbtnDeliveredDrug.TabStop = True
        Me.rbtnDeliveredDrug.Text = "Delivered"
        Me.rbtnDeliveredDrug.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label4.Location = New System.Drawing.Point(154, 26)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(116, 20)
        Me.Label4.TabIndex = 100
        Me.Label4.Text = "ชื่อซัพพลายเออร์"
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label6.Location = New System.Drawing.Point(106, 1)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(211, 22)
        Me.Label6.TabIndex = 97
        Me.Label6.Text = "DRUG ORDER STATUS"
        '
        'txtDrugSearch
        '
        Me.txtDrugSearch.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtDrugSearch.Location = New System.Drawing.Point(136, 51)
        Me.txtDrugSearch.Name = "txtDrugSearch"
        Me.txtDrugSearch.Size = New System.Drawing.Size(152, 22)
        Me.txtDrugSearch.TabIndex = 98
        '
        'btnDrugSAVE
        '
        Me.btnDrugSAVE.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDrugSAVE.Location = New System.Drawing.Point(993, 732)
        Me.btnDrugSAVE.Name = "btnDrugSAVE"
        Me.btnDrugSAVE.Size = New System.Drawing.Size(115, 34)
        Me.btnDrugSAVE.TabIndex = 106
        Me.btnDrugSAVE.Text = "SAVE"
        Me.btnDrugSAVE.UseVisualStyleBackColor = True
        '
        'FormOrderStatus
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1117, 775)
        Me.Controls.Add(Me.TableLayoutPanel3)
        Me.Controls.Add(Me.Label5)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FormOrderStatus"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormOrderStatus"
        CType(Me.SuppOrderItemBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Wellmeadows_HospitalDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SuppOrderDrugBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.TableLayoutPanel5.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.DataGridViewItemOrders, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel6.ResumeLayout(False)
        Me.TableLayoutPanel6.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.DataGridViewDrugOrders, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label5 As Label
    Friend WithEvents Wellmeadows_HospitalDataSet As Wellmeadows_HospitalDataSet
    Friend WithEvents SuppOrderDrugBindingSource As BindingSource
    Friend WithEvents SuppOrderDrugTableAdapter As Wellmeadows_HospitalDataSetTableAdapters.SuppOrderDrugTableAdapter
    Friend WithEvents TableAdapterManager As Wellmeadows_HospitalDataSetTableAdapters.TableAdapterManager
    Friend WithEvents SuppOrderItemBindingSource As BindingSource
    Friend WithEvents SuppOrderItemTableAdapter As Wellmeadows_HospitalDataSetTableAdapters.SuppOrderItemTableAdapter
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents btnItemSAVE As Button
    Friend WithEvents TableLayoutPanel5 As TableLayoutPanel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents DataGridViewItemOrders As DataGridView
    Friend WithEvents ItemOrderIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SuppIDDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents SuppNameDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents ItemOrderStatusDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ItemIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ItemNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ItemOrderQuantityDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ItemPriceTotalDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ItemOrderDetailIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TableLayoutPanel6 As TableLayoutPanel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rbtnCancelledItem As RadioButton
    Friend WithEvents rbtnDeliveredItem As RadioButton
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtItemSearch As TextBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents DataGridViewDrugOrders As DataGridView
    Friend WithEvents DrugOrderIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SuppIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SuppNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DrugOrderStatusDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DrugIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DrugNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DrugOrderQuantityDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DrugPriceTotalDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DrugOrderDetailIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents rbtnCancelledDrug As RadioButton
    Friend WithEvents rbtnDeliveredDrug As RadioButton
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtDrugSearch As TextBox
    Friend WithEvents btnDrugSAVE As Button
End Class
