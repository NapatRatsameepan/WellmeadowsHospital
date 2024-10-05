<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormItemSearch
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
        Me.Label33 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Wellmeadows_HospitalDataSet = New WellmeadowsHospital.Wellmeadows_HospitalDataSet()
        Me.ItemBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ItemTableAdapter = New WellmeadowsHospital.Wellmeadows_HospitalDataSetTableAdapters.ItemTableAdapter()
        Me.TableAdapterManager = New WellmeadowsHospital.Wellmeadows_HospitalDataSetTableAdapters.TableAdapterManager()
        Me.ItemIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemDetailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemQuantityinstockDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemCostPerUnitDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Wellmeadows_HospitalDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label33.Location = New System.Drawing.Point(12, 2)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(94, 38)
        Me.Label33.TabIndex = 211
        Me.Label33.Text = "ITEM"
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ItemIDDataGridViewTextBoxColumn, Me.ItemNameDataGridViewTextBoxColumn, Me.ItemDetailDataGridViewTextBoxColumn, Me.ItemQuantityinstockDataGridViewTextBoxColumn, Me.ItemCostPerUnitDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.ItemBindingSource
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DataGridView1.Location = New System.Drawing.Point(0, 61)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(836, 666)
        Me.DataGridView1.TabIndex = 210
        '
        'Wellmeadows_HospitalDataSet
        '
        Me.Wellmeadows_HospitalDataSet.DataSetName = "Wellmeadows_HospitalDataSet"
        Me.Wellmeadows_HospitalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ItemBindingSource
        '
        Me.ItemBindingSource.DataMember = "Item"
        Me.ItemBindingSource.DataSource = Me.Wellmeadows_HospitalDataSet
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
        'FormItemSearch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(836, 727)
        Me.Controls.Add(Me.Label33)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "FormItemSearch"
        Me.Text = "FormItemSearch"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Wellmeadows_HospitalDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label33 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Wellmeadows_HospitalDataSet As Wellmeadows_HospitalDataSet
    Friend WithEvents ItemBindingSource As BindingSource
    Friend WithEvents ItemTableAdapter As Wellmeadows_HospitalDataSetTableAdapters.ItemTableAdapter
    Friend WithEvents TableAdapterManager As Wellmeadows_HospitalDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ItemIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ItemNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ItemDetailDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ItemQuantityinstockDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ItemCostPerUnitDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
