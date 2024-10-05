<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormStaffList
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
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.StaffIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StaffNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SexDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TelDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StaffDOBDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AgeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AddressDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NINDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SalaryDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WorkHoursDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PaidTypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ContractTypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PositionNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ScaleNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.View_StaffDetail2BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Wellmeadows_HospitalDataSet = New WellmeadowsHospital.Wellmeadows_HospitalDataSet()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.View_StaffDetail2TableAdapter = New WellmeadowsHospital.Wellmeadows_HospitalDataSetTableAdapters.View_StaffDetail2TableAdapter()
        Me.TableAdapterManager = New WellmeadowsHospital.Wellmeadows_HospitalDataSetTableAdapters.TableAdapterManager()
        Me.btnInformation = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.View_StaffDetail2BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Wellmeadows_HospitalDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label10.Location = New System.Drawing.Point(12, 9)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(198, 38)
        Me.Label10.TabIndex = 95
        Me.Label10.Text = "STAFF LIST"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(57, 60)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(191, 22)
        Me.TextBox1.TabIndex = 96
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.StaffIDDataGridViewTextBoxColumn, Me.StaffNameDataGridViewTextBoxColumn, Me.SexDataGridViewTextBoxColumn, Me.TelDataGridViewTextBoxColumn, Me.StaffDOBDataGridViewTextBoxColumn, Me.AgeDataGridViewTextBoxColumn, Me.AddressDataGridViewTextBoxColumn, Me.NINDataGridViewTextBoxColumn, Me.SalaryDataGridViewTextBoxColumn, Me.WorkHoursDataGridViewTextBoxColumn, Me.PaidTypeDataGridViewTextBoxColumn, Me.ContractTypeDataGridViewTextBoxColumn, Me.PositionNameDataGridViewTextBoxColumn, Me.ScaleNameDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.View_StaffDetail2BindingSource
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DataGridView1.Location = New System.Drawing.Point(0, 102)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(1135, 720)
        Me.DataGridView1.TabIndex = 97
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
        'SexDataGridViewTextBoxColumn
        '
        Me.SexDataGridViewTextBoxColumn.DataPropertyName = "Sex"
        Me.SexDataGridViewTextBoxColumn.HeaderText = "Sex"
        Me.SexDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.SexDataGridViewTextBoxColumn.Name = "SexDataGridViewTextBoxColumn"
        Me.SexDataGridViewTextBoxColumn.Width = 125
        '
        'TelDataGridViewTextBoxColumn
        '
        Me.TelDataGridViewTextBoxColumn.DataPropertyName = "Tel"
        Me.TelDataGridViewTextBoxColumn.HeaderText = "Tel"
        Me.TelDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.TelDataGridViewTextBoxColumn.Name = "TelDataGridViewTextBoxColumn"
        Me.TelDataGridViewTextBoxColumn.Width = 125
        '
        'StaffDOBDataGridViewTextBoxColumn
        '
        Me.StaffDOBDataGridViewTextBoxColumn.DataPropertyName = "Staff_DOB"
        Me.StaffDOBDataGridViewTextBoxColumn.HeaderText = "Staff_DOB"
        Me.StaffDOBDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.StaffDOBDataGridViewTextBoxColumn.Name = "StaffDOBDataGridViewTextBoxColumn"
        Me.StaffDOBDataGridViewTextBoxColumn.Width = 125
        '
        'AgeDataGridViewTextBoxColumn
        '
        Me.AgeDataGridViewTextBoxColumn.DataPropertyName = "Age"
        Me.AgeDataGridViewTextBoxColumn.HeaderText = "Age"
        Me.AgeDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.AgeDataGridViewTextBoxColumn.Name = "AgeDataGridViewTextBoxColumn"
        Me.AgeDataGridViewTextBoxColumn.ReadOnly = True
        Me.AgeDataGridViewTextBoxColumn.Width = 125
        '
        'AddressDataGridViewTextBoxColumn
        '
        Me.AddressDataGridViewTextBoxColumn.DataPropertyName = "Address"
        Me.AddressDataGridViewTextBoxColumn.HeaderText = "Address"
        Me.AddressDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.AddressDataGridViewTextBoxColumn.Name = "AddressDataGridViewTextBoxColumn"
        Me.AddressDataGridViewTextBoxColumn.Width = 125
        '
        'NINDataGridViewTextBoxColumn
        '
        Me.NINDataGridViewTextBoxColumn.DataPropertyName = "NIN"
        Me.NINDataGridViewTextBoxColumn.HeaderText = "NIN"
        Me.NINDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.NINDataGridViewTextBoxColumn.Name = "NINDataGridViewTextBoxColumn"
        Me.NINDataGridViewTextBoxColumn.Width = 125
        '
        'SalaryDataGridViewTextBoxColumn
        '
        Me.SalaryDataGridViewTextBoxColumn.DataPropertyName = "Salary"
        Me.SalaryDataGridViewTextBoxColumn.HeaderText = "Salary"
        Me.SalaryDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.SalaryDataGridViewTextBoxColumn.Name = "SalaryDataGridViewTextBoxColumn"
        Me.SalaryDataGridViewTextBoxColumn.Width = 125
        '
        'WorkHoursDataGridViewTextBoxColumn
        '
        Me.WorkHoursDataGridViewTextBoxColumn.DataPropertyName = "Work Hours"
        Me.WorkHoursDataGridViewTextBoxColumn.HeaderText = "Work Hours"
        Me.WorkHoursDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.WorkHoursDataGridViewTextBoxColumn.Name = "WorkHoursDataGridViewTextBoxColumn"
        Me.WorkHoursDataGridViewTextBoxColumn.Width = 125
        '
        'PaidTypeDataGridViewTextBoxColumn
        '
        Me.PaidTypeDataGridViewTextBoxColumn.DataPropertyName = "PaidType"
        Me.PaidTypeDataGridViewTextBoxColumn.HeaderText = "PaidType"
        Me.PaidTypeDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.PaidTypeDataGridViewTextBoxColumn.Name = "PaidTypeDataGridViewTextBoxColumn"
        Me.PaidTypeDataGridViewTextBoxColumn.Width = 125
        '
        'ContractTypeDataGridViewTextBoxColumn
        '
        Me.ContractTypeDataGridViewTextBoxColumn.DataPropertyName = "ContractType"
        Me.ContractTypeDataGridViewTextBoxColumn.HeaderText = "ContractType"
        Me.ContractTypeDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.ContractTypeDataGridViewTextBoxColumn.Name = "ContractTypeDataGridViewTextBoxColumn"
        Me.ContractTypeDataGridViewTextBoxColumn.Width = 125
        '
        'PositionNameDataGridViewTextBoxColumn
        '
        Me.PositionNameDataGridViewTextBoxColumn.DataPropertyName = "Position_Name"
        Me.PositionNameDataGridViewTextBoxColumn.HeaderText = "Position_Name"
        Me.PositionNameDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.PositionNameDataGridViewTextBoxColumn.Name = "PositionNameDataGridViewTextBoxColumn"
        Me.PositionNameDataGridViewTextBoxColumn.Width = 125
        '
        'ScaleNameDataGridViewTextBoxColumn
        '
        Me.ScaleNameDataGridViewTextBoxColumn.DataPropertyName = "Scale_Name"
        Me.ScaleNameDataGridViewTextBoxColumn.HeaderText = "Scale_Name"
        Me.ScaleNameDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.ScaleNameDataGridViewTextBoxColumn.Name = "ScaleNameDataGridViewTextBoxColumn"
        Me.ScaleNameDataGridViewTextBoxColumn.Width = 125
        '
        'View_StaffDetail2BindingSource
        '
        Me.View_StaffDetail2BindingSource.DataMember = "View_StaffDetail2"
        Me.View_StaffDetail2BindingSource.DataSource = Me.Wellmeadows_HospitalDataSet
        '
        'Wellmeadows_HospitalDataSet
        '
        Me.Wellmeadows_HospitalDataSet.DataSetName = "Wellmeadows_HospitalDataSet"
        Me.Wellmeadows_HospitalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(22, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 22)
        Me.Label1.TabIndex = 98
        Me.Label1.Text = "ชื่อ"
        '
        'View_StaffDetail2TableAdapter
        '
        Me.View_StaffDetail2TableAdapter.ClearBeforeFill = True
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
        'btnInformation
        '
        Me.btnInformation.Location = New System.Drawing.Point(286, 59)
        Me.btnInformation.Name = "btnInformation"
        Me.btnInformation.Size = New System.Drawing.Size(104, 23)
        Me.btnInformation.TabIndex = 99
        Me.btnInformation.Text = "Information"
        Me.btnInformation.UseVisualStyleBackColor = True
        '
        'FormStaffList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1135, 822)
        Me.Controls.Add(Me.btnInformation)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label10)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormStaffList"
        Me.Text = "FormStaffList"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.View_StaffDetail2BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Wellmeadows_HospitalDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Wellmeadows_HospitalDataSet As Wellmeadows_HospitalDataSet
    Friend WithEvents Label10 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents View_StaffDetail2BindingSource As BindingSource
    Friend WithEvents View_StaffDetail2TableAdapter As Wellmeadows_HospitalDataSetTableAdapters.View_StaffDetail2TableAdapter
    Friend WithEvents TableAdapterManager As Wellmeadows_HospitalDataSetTableAdapters.TableAdapterManager
    Friend WithEvents StaffIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StaffNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SexDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TelDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StaffDOBDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AgeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AddressDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NINDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SalaryDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents WorkHoursDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PaidTypeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ContractTypeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PositionNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ScaleNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents btnInformation As Button
End Class
