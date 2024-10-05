<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormItemManage
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
        Me.txtItem = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCost = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtItemDetail = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtItemName = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ItemIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemDetailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QuantityInStockDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CostPerUnitDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Item_ListBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Wellmeadows_HospitalDataSet = New WellmeadowsHospital.Wellmeadows_HospitalDataSet()
        Me.btnadd = New System.Windows.Forms.Button()
        Me.Item_ListTableAdapter = New WellmeadowsHospital.Wellmeadows_HospitalDataSetTableAdapters.Item_ListTableAdapter()
        Me.TableAdapterManager = New WellmeadowsHospital.Wellmeadows_HospitalDataSetTableAdapters.TableAdapterManager()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Item_ListBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Wellmeadows_HospitalDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtItem
        '
        Me.txtItem.Location = New System.Drawing.Point(81, 120)
        Me.txtItem.Name = "txtItem"
        Me.txtItem.Size = New System.Drawing.Size(152, 22)
        Me.txtItem.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.Location = New System.Drawing.Point(77, 97)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 20)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Item Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(400, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(339, 38)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "ITEM MANAGEMENT"
        '
        'txtCost
        '
        Me.txtCost.Location = New System.Drawing.Point(266, 120)
        Me.txtCost.Name = "txtCost"
        Me.txtCost.Size = New System.Drawing.Size(152, 22)
        Me.txtCost.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.Location = New System.Drawing.Point(262, 97)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(110, 20)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Cost Per Unit"
        '
        'txtItemDetail
        '
        Me.txtItemDetail.Location = New System.Drawing.Point(82, 168)
        Me.txtItemDetail.Multiline = True
        Me.txtItemDetail.Name = "txtItemDetail"
        Me.txtItemDetail.Size = New System.Drawing.Size(336, 158)
        Me.txtItemDetail.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label4.Location = New System.Drawing.Point(78, 145)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 20)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Detail"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label5.Location = New System.Drawing.Point(78, 349)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(90, 20)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Item Name"
        '
        'txtItemName
        '
        Me.txtItemName.Location = New System.Drawing.Point(184, 349)
        Me.txtItemName.Name = "txtItemName"
        Me.txtItemName.Size = New System.Drawing.Size(152, 22)
        Me.txtItemName.TabIndex = 18
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ItemIDDataGridViewTextBoxColumn, Me.ItemNameDataGridViewTextBoxColumn, Me.ItemDetailDataGridViewTextBoxColumn, Me.QuantityInStockDataGridViewTextBoxColumn, Me.CostPerUnitDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.Item_ListBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(82, 378)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(943, 372)
        Me.DataGridView1.TabIndex = 20
        '
        'ItemIDDataGridViewTextBoxColumn
        '
        Me.ItemIDDataGridViewTextBoxColumn.DataPropertyName = "Item ID"
        Me.ItemIDDataGridViewTextBoxColumn.HeaderText = "Item ID"
        Me.ItemIDDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.ItemIDDataGridViewTextBoxColumn.Name = "ItemIDDataGridViewTextBoxColumn"
        Me.ItemIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.ItemIDDataGridViewTextBoxColumn.Width = 125
        '
        'ItemNameDataGridViewTextBoxColumn
        '
        Me.ItemNameDataGridViewTextBoxColumn.DataPropertyName = "Item Name"
        Me.ItemNameDataGridViewTextBoxColumn.HeaderText = "Item Name"
        Me.ItemNameDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.ItemNameDataGridViewTextBoxColumn.Name = "ItemNameDataGridViewTextBoxColumn"
        Me.ItemNameDataGridViewTextBoxColumn.Width = 125
        '
        'ItemDetailDataGridViewTextBoxColumn
        '
        Me.ItemDetailDataGridViewTextBoxColumn.DataPropertyName = "Item Detail"
        Me.ItemDetailDataGridViewTextBoxColumn.HeaderText = "Item Detail"
        Me.ItemDetailDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.ItemDetailDataGridViewTextBoxColumn.Name = "ItemDetailDataGridViewTextBoxColumn"
        Me.ItemDetailDataGridViewTextBoxColumn.Width = 125
        '
        'QuantityInStockDataGridViewTextBoxColumn
        '
        Me.QuantityInStockDataGridViewTextBoxColumn.DataPropertyName = "Quantity in Stock"
        Me.QuantityInStockDataGridViewTextBoxColumn.HeaderText = "Quantity in Stock"
        Me.QuantityInStockDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.QuantityInStockDataGridViewTextBoxColumn.Name = "QuantityInStockDataGridViewTextBoxColumn"
        Me.QuantityInStockDataGridViewTextBoxColumn.Width = 125
        '
        'CostPerUnitDataGridViewTextBoxColumn
        '
        Me.CostPerUnitDataGridViewTextBoxColumn.DataPropertyName = "Cost Per Unit"
        Me.CostPerUnitDataGridViewTextBoxColumn.HeaderText = "Cost Per Unit"
        Me.CostPerUnitDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.CostPerUnitDataGridViewTextBoxColumn.Name = "CostPerUnitDataGridViewTextBoxColumn"
        Me.CostPerUnitDataGridViewTextBoxColumn.Width = 125
        '
        'Item_ListBindingSource
        '
        Me.Item_ListBindingSource.DataMember = "Item_List"
        Me.Item_ListBindingSource.DataSource = Me.Wellmeadows_HospitalDataSet
        '
        'Wellmeadows_HospitalDataSet
        '
        Me.Wellmeadows_HospitalDataSet.DataSetName = "Wellmeadows_HospitalDataSet"
        Me.Wellmeadows_HospitalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'btnadd
        '
        Me.btnadd.Location = New System.Drawing.Point(424, 292)
        Me.btnadd.Name = "btnadd"
        Me.btnadd.Size = New System.Drawing.Size(80, 34)
        Me.btnadd.TabIndex = 74
        Me.btnadd.Text = "ADD"
        Me.btnadd.UseVisualStyleBackColor = True
        '
        'Item_ListTableAdapter
        '
        Me.Item_ListTableAdapter.ClearBeforeFill = True
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
        'FormItemManage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1117, 775)
        Me.Controls.Add(Me.btnadd)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.txtItemName)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtItemDetail)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtCost)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtItem)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormItemManage"
        Me.Text = "FormItem"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Item_ListBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Wellmeadows_HospitalDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtItem As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtCost As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtItemDetail As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtItemName As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnadd As Button
    Friend WithEvents Wellmeadows_HospitalDataSet As Wellmeadows_HospitalDataSet
    Friend WithEvents Item_ListBindingSource As BindingSource
    Friend WithEvents Item_ListTableAdapter As Wellmeadows_HospitalDataSetTableAdapters.Item_ListTableAdapter
    Friend WithEvents TableAdapterManager As Wellmeadows_HospitalDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ItemIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ItemNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ItemDetailDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents QuantityInStockDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CostPerUnitDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
