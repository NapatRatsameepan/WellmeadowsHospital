<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormDrugManage
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Txtname = New System.Windows.Forms.TextBox()
        Me.txtcost = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Txtdousage = New System.Windows.Forms.TextBox()
        Me.Txtmet = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Txtdetail = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.DataGridViewDrugList = New System.Windows.Forms.DataGridView()
        Me.DrugIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DrugNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DrugDetailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DosageDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MethodDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QuantityInStockDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CostPerUnitDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Drug_ListBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Wellmeadows_HospitalDataSet = New WellmeadowsHospital.Wellmeadows_HospitalDataSet()
        Me.txtDrugName = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnadd = New System.Windows.Forms.Button()
        Me.Drug_ListTableAdapter = New WellmeadowsHospital.Wellmeadows_HospitalDataSetTableAdapters.Drug_ListTableAdapter()
        Me.TableAdapterManager = New WellmeadowsHospital.Wellmeadows_HospitalDataSetTableAdapters.TableAdapterManager()
        CType(Me.DataGridViewDrugList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Drug_ListBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Wellmeadows_HospitalDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.Location = New System.Drawing.Point(76, 91)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 20)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Drug Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(399, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 38)
        Me.Label1.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.Location = New System.Drawing.Point(389, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(360, 38)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "DRUG MANAGEMENT"
        '
        'Txtname
        '
        Me.Txtname.Location = New System.Drawing.Point(80, 114)
        Me.Txtname.Name = "Txtname"
        Me.Txtname.Size = New System.Drawing.Size(152, 22)
        Me.Txtname.TabIndex = 8
        '
        'txtcost
        '
        Me.txtcost.Location = New System.Drawing.Point(258, 114)
        Me.txtcost.Name = "txtcost"
        Me.txtcost.Size = New System.Drawing.Size(152, 22)
        Me.txtcost.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label4.Location = New System.Drawing.Point(254, 91)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(110, 20)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Cost Per Unit"
        '
        'Txtdousage
        '
        Me.Txtdousage.Location = New System.Drawing.Point(80, 165)
        Me.Txtdousage.Name = "Txtdousage"
        Me.Txtdousage.Size = New System.Drawing.Size(152, 22)
        Me.Txtdousage.TabIndex = 11
        '
        'Txtmet
        '
        Me.Txtmet.Location = New System.Drawing.Point(258, 165)
        Me.Txtmet.Name = "Txtmet"
        Me.Txtmet.Size = New System.Drawing.Size(152, 22)
        Me.Txtmet.TabIndex = 12
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label5.Location = New System.Drawing.Point(76, 142)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(76, 20)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Dousage"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label6.Location = New System.Drawing.Point(254, 142)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(64, 20)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Method"
        '
        'Txtdetail
        '
        Me.Txtdetail.Location = New System.Drawing.Point(80, 222)
        Me.Txtdetail.Multiline = True
        Me.Txtdetail.Name = "Txtdetail"
        Me.Txtdetail.Size = New System.Drawing.Size(336, 109)
        Me.Txtdetail.TabIndex = 15
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label7.Location = New System.Drawing.Point(76, 199)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(53, 20)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Detail"
        '
        'DataGridViewDrugList
        '
        Me.DataGridViewDrugList.AutoGenerateColumns = False
        Me.DataGridViewDrugList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewDrugList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DrugIDDataGridViewTextBoxColumn, Me.DrugNameDataGridViewTextBoxColumn, Me.DrugDetailDataGridViewTextBoxColumn, Me.DosageDataGridViewTextBoxColumn, Me.MethodDataGridViewTextBoxColumn, Me.QuantityInStockDataGridViewTextBoxColumn, Me.CostPerUnitDataGridViewTextBoxColumn})
        Me.DataGridViewDrugList.DataSource = Me.Drug_ListBindingSource
        Me.DataGridViewDrugList.Location = New System.Drawing.Point(76, 379)
        Me.DataGridViewDrugList.Name = "DataGridViewDrugList"
        Me.DataGridViewDrugList.RowHeadersWidth = 51
        Me.DataGridViewDrugList.RowTemplate.Height = 24
        Me.DataGridViewDrugList.Size = New System.Drawing.Size(973, 384)
        Me.DataGridViewDrugList.TabIndex = 26
        '
        'DrugIDDataGridViewTextBoxColumn
        '
        Me.DrugIDDataGridViewTextBoxColumn.DataPropertyName = "Drug ID"
        Me.DrugIDDataGridViewTextBoxColumn.HeaderText = "Drug ID"
        Me.DrugIDDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.DrugIDDataGridViewTextBoxColumn.Name = "DrugIDDataGridViewTextBoxColumn"
        Me.DrugIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.DrugIDDataGridViewTextBoxColumn.Width = 125
        '
        'DrugNameDataGridViewTextBoxColumn
        '
        Me.DrugNameDataGridViewTextBoxColumn.DataPropertyName = "Drug Name"
        Me.DrugNameDataGridViewTextBoxColumn.HeaderText = "Drug Name"
        Me.DrugNameDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.DrugNameDataGridViewTextBoxColumn.Name = "DrugNameDataGridViewTextBoxColumn"
        Me.DrugNameDataGridViewTextBoxColumn.Width = 125
        '
        'DrugDetailDataGridViewTextBoxColumn
        '
        Me.DrugDetailDataGridViewTextBoxColumn.DataPropertyName = "Drug Detail"
        Me.DrugDetailDataGridViewTextBoxColumn.HeaderText = "Drug Detail"
        Me.DrugDetailDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.DrugDetailDataGridViewTextBoxColumn.Name = "DrugDetailDataGridViewTextBoxColumn"
        Me.DrugDetailDataGridViewTextBoxColumn.Width = 125
        '
        'DosageDataGridViewTextBoxColumn
        '
        Me.DosageDataGridViewTextBoxColumn.DataPropertyName = "Dosage"
        Me.DosageDataGridViewTextBoxColumn.HeaderText = "Dosage (mg/ml)"
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
        'Drug_ListBindingSource
        '
        Me.Drug_ListBindingSource.DataMember = "Drug_List"
        Me.Drug_ListBindingSource.DataSource = Me.Wellmeadows_HospitalDataSet
        '
        'Wellmeadows_HospitalDataSet
        '
        Me.Wellmeadows_HospitalDataSet.DataSetName = "Wellmeadows_HospitalDataSet"
        Me.Wellmeadows_HospitalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'txtDrugName
        '
        Me.txtDrugName.Location = New System.Drawing.Point(185, 350)
        Me.txtDrugName.Name = "txtDrugName"
        Me.txtDrugName.Size = New System.Drawing.Size(152, 22)
        Me.txtDrugName.TabIndex = 24
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label9.Location = New System.Drawing.Point(76, 350)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(95, 20)
        Me.Label9.TabIndex = 21
        Me.Label9.Text = "Drug Name"
        '
        'btnadd
        '
        Me.btnadd.Location = New System.Drawing.Point(422, 297)
        Me.btnadd.Name = "btnadd"
        Me.btnadd.Size = New System.Drawing.Size(80, 34)
        Me.btnadd.TabIndex = 77
        Me.btnadd.Text = "ADD"
        Me.btnadd.UseVisualStyleBackColor = True
        '
        'Drug_ListTableAdapter
        '
        Me.Drug_ListTableAdapter.ClearBeforeFill = True
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
        'FormDrugManage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1117, 775)
        Me.Controls.Add(Me.btnadd)
        Me.Controls.Add(Me.DataGridViewDrugList)
        Me.Controls.Add(Me.txtDrugName)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Txtdetail)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Txtmet)
        Me.Controls.Add(Me.Txtdousage)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtcost)
        Me.Controls.Add(Me.Txtname)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormDrugManage"
        Me.Text = "FormDrug"
        CType(Me.DataGridViewDrugList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Drug_ListBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Wellmeadows_HospitalDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Txtname As TextBox
    Friend WithEvents txtcost As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Txtdousage As TextBox
    Friend WithEvents Txtmet As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Txtdetail As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents DataGridViewDrugList As DataGridView
    Friend WithEvents txtDrugName As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents btnadd As Button
    Friend WithEvents Wellmeadows_HospitalDataSet As Wellmeadows_HospitalDataSet
    Friend WithEvents Drug_ListBindingSource As BindingSource
    Friend WithEvents Drug_ListTableAdapter As Wellmeadows_HospitalDataSetTableAdapters.Drug_ListTableAdapter
    Friend WithEvents TableAdapterManager As Wellmeadows_HospitalDataSetTableAdapters.TableAdapterManager
    Friend WithEvents DrugIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DrugNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DrugDetailDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DosageDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MethodDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents QuantityInStockDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CostPerUnitDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
