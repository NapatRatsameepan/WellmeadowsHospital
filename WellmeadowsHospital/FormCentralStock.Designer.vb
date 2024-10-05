<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCentralStock
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Wellmeadows_HospitalDataSet = New WellmeadowsHospital.Wellmeadows_HospitalDataSet()
        Me.DrugBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DrugTableAdapter = New WellmeadowsHospital.Wellmeadows_HospitalDataSetTableAdapters.DrugTableAdapter()
        Me.TableAdapterManager = New WellmeadowsHospital.Wellmeadows_HospitalDataSetTableAdapters.TableAdapterManager()
        Me.DrugIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DrugNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DrugDetailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DosageDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MethodDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DrugQuantityinstockDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DrugReorderLevelDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DrugCostPerUnitDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ItemTableAdapter = New WellmeadowsHospital.Wellmeadows_HospitalDataSetTableAdapters.ItemTableAdapter()
        Me.ItemIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemDetailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemReorderLevelDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemQuantityinstockDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemCostPerUnitDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Wellmeadows_HospitalDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DrugBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(401, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(294, 38)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "CENTRAL STORE"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.Location = New System.Drawing.Point(180, 146)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Item ID"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(184, 169)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(106, 22)
        Me.TextBox1.TabIndex = 2
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(184, 217)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(106, 22)
        Me.TextBox2.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.Location = New System.Drawing.Point(180, 194)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 20)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Item Name"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.DataGridView1)
        Me.Panel1.Location = New System.Drawing.Point(48, 258)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(486, 490)
        Me.Panel1.TabIndex = 5
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ItemIDDataGridViewTextBoxColumn, Me.ItemNameDataGridViewTextBoxColumn, Me.ItemDetailDataGridViewTextBoxColumn, Me.ItemReorderLevelDataGridViewTextBoxColumn, Me.ItemQuantityinstockDataGridViewTextBoxColumn, Me.ItemCostPerUnitDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.ItemBindingSource
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(486, 490)
        Me.DataGridView1.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(339, 188)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(80, 34)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Search"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label4.Location = New System.Drawing.Point(270, 106)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(94, 38)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "ITEM"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label5.Location = New System.Drawing.Point(735, 106)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(115, 38)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "DRUG"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(804, 188)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(80, 34)
        Me.Button2.TabIndex = 13
        Me.Button2.Text = "Search"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.DataGridView2)
        Me.Panel2.Location = New System.Drawing.Point(580, 258)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(486, 490)
        Me.Panel2.TabIndex = 12
        '
        'DataGridView2
        '
        Me.DataGridView2.AutoGenerateColumns = False
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DrugIDDataGridViewTextBoxColumn, Me.DrugNameDataGridViewTextBoxColumn, Me.DrugDetailDataGridViewTextBoxColumn, Me.DosageDataGridViewTextBoxColumn, Me.MethodDataGridViewTextBoxColumn, Me.DrugQuantityinstockDataGridViewTextBoxColumn, Me.DrugReorderLevelDataGridViewTextBoxColumn, Me.DrugCostPerUnitDataGridViewTextBoxColumn})
        Me.DataGridView2.DataSource = Me.DrugBindingSource
        Me.DataGridView2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView2.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.RowHeadersWidth = 51
        Me.DataGridView2.RowTemplate.Height = 24
        Me.DataGridView2.Size = New System.Drawing.Size(486, 490)
        Me.DataGridView2.TabIndex = 0
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(649, 217)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(106, 22)
        Me.TextBox3.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label6.Location = New System.Drawing.Point(645, 194)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(95, 20)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Drug Name"
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(649, 169)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(106, 22)
        Me.TextBox4.TabIndex = 9
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label7.Location = New System.Drawing.Point(645, 146)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(68, 20)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Drug ID"
        '
        'Wellmeadows_HospitalDataSet
        '
        Me.Wellmeadows_HospitalDataSet.DataSetName = "Wellmeadows_HospitalDataSet"
        Me.Wellmeadows_HospitalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DrugBindingSource
        '
        Me.DrugBindingSource.DataMember = "Drug"
        Me.DrugBindingSource.DataSource = Me.Wellmeadows_HospitalDataSet
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
        'DrugReorderLevelDataGridViewTextBoxColumn
        '
        Me.DrugReorderLevelDataGridViewTextBoxColumn.DataPropertyName = "Drug_Reorder_Level"
        Me.DrugReorderLevelDataGridViewTextBoxColumn.HeaderText = "Drug_Reorder_Level"
        Me.DrugReorderLevelDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.DrugReorderLevelDataGridViewTextBoxColumn.Name = "DrugReorderLevelDataGridViewTextBoxColumn"
        Me.DrugReorderLevelDataGridViewTextBoxColumn.Width = 125
        '
        'DrugCostPerUnitDataGridViewTextBoxColumn
        '
        Me.DrugCostPerUnitDataGridViewTextBoxColumn.DataPropertyName = "Drug_Cost_Per_Unit"
        Me.DrugCostPerUnitDataGridViewTextBoxColumn.HeaderText = "Drug_Cost_Per_Unit"
        Me.DrugCostPerUnitDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.DrugCostPerUnitDataGridViewTextBoxColumn.Name = "DrugCostPerUnitDataGridViewTextBoxColumn"
        Me.DrugCostPerUnitDataGridViewTextBoxColumn.Width = 125
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
        'ItemReorderLevelDataGridViewTextBoxColumn
        '
        Me.ItemReorderLevelDataGridViewTextBoxColumn.DataPropertyName = "Item_Reorder_Level"
        Me.ItemReorderLevelDataGridViewTextBoxColumn.HeaderText = "Item_Reorder_Level"
        Me.ItemReorderLevelDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.ItemReorderLevelDataGridViewTextBoxColumn.Name = "ItemReorderLevelDataGridViewTextBoxColumn"
        Me.ItemReorderLevelDataGridViewTextBoxColumn.Width = 125
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
        'FormCentralStock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1117, 775)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormCentralStock"
        Me.Text = "FormCentralStock"
        Me.Panel1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Wellmeadows_HospitalDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DrugBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Wellmeadows_HospitalDataSet As Wellmeadows_HospitalDataSet
    Friend WithEvents DrugBindingSource As BindingSource
    Friend WithEvents DrugTableAdapter As Wellmeadows_HospitalDataSetTableAdapters.DrugTableAdapter
    Friend WithEvents TableAdapterManager As Wellmeadows_HospitalDataSetTableAdapters.TableAdapterManager
    Friend WithEvents DrugIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DrugNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DrugDetailDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DosageDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MethodDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DrugQuantityinstockDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DrugReorderLevelDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DrugCostPerUnitDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ItemTableAdapter As Wellmeadows_HospitalDataSetTableAdapters.ItemTableAdapter
    Friend WithEvents ItemBindingSource As BindingSource
    Friend WithEvents ItemIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ItemNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ItemDetailDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ItemReorderLevelDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ItemQuantityinstockDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ItemCostPerUnitDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
