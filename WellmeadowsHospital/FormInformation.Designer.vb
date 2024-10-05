<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormInformation
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DataGridView4 = New System.Windows.Forms.DataGridView()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Wellmeadows_HospitalDataSet = New WellmeadowsHospital.Wellmeadows_HospitalDataSet()
        Me.Work_ExperienceBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Work_ExperienceTableAdapter = New WellmeadowsHospital.Wellmeadows_HospitalDataSetTableAdapters.Work_ExperienceTableAdapter()
        Me.TableAdapterManager = New WellmeadowsHospital.Wellmeadows_HospitalDataSetTableAdapters.TableAdapterManager()
        Me.ExpIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OrganizationDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PositionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EXPStartDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EXPFinishDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StaffIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QualificationBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.QualificationTableAdapter = New WellmeadowsHospital.Wellmeadows_HospitalDataSetTableAdapters.QualificationTableAdapter()
        Me.QualificationIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QualificationNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GraduationDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InstitutionNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StaffIDDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Wellmeadows_HospitalDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Work_ExperienceBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QualificationBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label10, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.DataGridView4, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.DataGridView1, 0, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.869249!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 92.13075!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1096, 826)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.QualificationIDDataGridViewTextBoxColumn, Me.QualificationNameDataGridViewTextBoxColumn, Me.GraduationDateDataGridViewTextBoxColumn, Me.InstitutionNameDataGridViewTextBoxColumn, Me.StaffIDDataGridViewTextBoxColumn1})
        Me.DataGridView1.DataSource = Me.QualificationBindingSource
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(10, 74)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(10)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(528, 742)
        Me.DataGridView1.TabIndex = 0
        '
        'DataGridView4
        '
        Me.DataGridView4.AutoGenerateColumns = False
        Me.DataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView4.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ExpIDDataGridViewTextBoxColumn, Me.OrganizationDataGridViewTextBoxColumn, Me.PositionDataGridViewTextBoxColumn, Me.EXPStartDateDataGridViewTextBoxColumn, Me.EXPFinishDateDataGridViewTextBoxColumn, Me.StaffIDDataGridViewTextBoxColumn})
        Me.DataGridView4.DataSource = Me.Work_ExperienceBindingSource
        Me.DataGridView4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView4.Location = New System.Drawing.Point(558, 74)
        Me.DataGridView4.Margin = New System.Windows.Forms.Padding(10)
        Me.DataGridView4.Name = "DataGridView4"
        Me.DataGridView4.RowHeadersWidth = 51
        Me.DataGridView4.RowTemplate.Height = 24
        Me.DataGridView4.Size = New System.Drawing.Size(528, 742)
        Me.DataGridView4.TabIndex = 3
        '
        'Label10
        '
        Me.Label10.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label10.Location = New System.Drawing.Point(3, 13)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(267, 38)
        Me.Label10.TabIndex = 96
        Me.Label10.Text = "QUALIFICATION"
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(551, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(341, 38)
        Me.Label1.TabIndex = 97
        Me.Label1.Text = "WORK EXPERIENCE"
        '
        'Wellmeadows_HospitalDataSet
        '
        Me.Wellmeadows_HospitalDataSet.DataSetName = "Wellmeadows_HospitalDataSet"
        Me.Wellmeadows_HospitalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Work_ExperienceBindingSource
        '
        Me.Work_ExperienceBindingSource.DataMember = "Work_Experience"
        Me.Work_ExperienceBindingSource.DataSource = Me.Wellmeadows_HospitalDataSet
        '
        'Work_ExperienceTableAdapter
        '
        Me.Work_ExperienceTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.ItemTableAdapter = Nothing
        Me.TableAdapterManager.Local_DoctorTableAdapter = Nothing
        Me.TableAdapterManager.Next_of_KinTableAdapter = Nothing
        Me.TableAdapterManager.Patients_AllocationTableAdapter = Nothing
        Me.TableAdapterManager.PatientsTableAdapter = Nothing
        Me.TableAdapterManager.PositionTableAdapter = Nothing
        Me.TableAdapterManager.PrescribedDrugTableAdapter = Nothing
        Me.TableAdapterManager.PrescribeTableAdapter = Nothing
        Me.TableAdapterManager.QualificationTableAdapter = Me.QualificationTableAdapter
        Me.TableAdapterManager.Salary_ScaleTableAdapter = Nothing
        Me.TableAdapterManager.StaffTableAdapter = Nothing
        Me.TableAdapterManager.SuppliersTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = WellmeadowsHospital.Wellmeadows_HospitalDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.Ward_Allocation_OPDTableAdapter = Nothing
        Me.TableAdapterManager.WardTableAdapter = Nothing
        Me.TableAdapterManager.Work_ExperienceTableAdapter = Me.Work_ExperienceTableAdapter
        '
        'ExpIDDataGridViewTextBoxColumn
        '
        Me.ExpIDDataGridViewTextBoxColumn.DataPropertyName = "Exp_ID"
        Me.ExpIDDataGridViewTextBoxColumn.HeaderText = "Exp_ID"
        Me.ExpIDDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.ExpIDDataGridViewTextBoxColumn.Name = "ExpIDDataGridViewTextBoxColumn"
        Me.ExpIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.ExpIDDataGridViewTextBoxColumn.Width = 125
        '
        'OrganizationDataGridViewTextBoxColumn
        '
        Me.OrganizationDataGridViewTextBoxColumn.DataPropertyName = "Organization"
        Me.OrganizationDataGridViewTextBoxColumn.HeaderText = "Organization"
        Me.OrganizationDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.OrganizationDataGridViewTextBoxColumn.Name = "OrganizationDataGridViewTextBoxColumn"
        Me.OrganizationDataGridViewTextBoxColumn.Width = 125
        '
        'PositionDataGridViewTextBoxColumn
        '
        Me.PositionDataGridViewTextBoxColumn.DataPropertyName = "Position"
        Me.PositionDataGridViewTextBoxColumn.HeaderText = "Position"
        Me.PositionDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.PositionDataGridViewTextBoxColumn.Name = "PositionDataGridViewTextBoxColumn"
        Me.PositionDataGridViewTextBoxColumn.Width = 125
        '
        'EXPStartDateDataGridViewTextBoxColumn
        '
        Me.EXPStartDateDataGridViewTextBoxColumn.DataPropertyName = "EXP_Start_Date"
        Me.EXPStartDateDataGridViewTextBoxColumn.HeaderText = "EXP_Start_Date"
        Me.EXPStartDateDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.EXPStartDateDataGridViewTextBoxColumn.Name = "EXPStartDateDataGridViewTextBoxColumn"
        Me.EXPStartDateDataGridViewTextBoxColumn.Width = 125
        '
        'EXPFinishDateDataGridViewTextBoxColumn
        '
        Me.EXPFinishDateDataGridViewTextBoxColumn.DataPropertyName = "EXP_Finish_Date"
        Me.EXPFinishDateDataGridViewTextBoxColumn.HeaderText = "EXP_Finish_Date"
        Me.EXPFinishDateDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.EXPFinishDateDataGridViewTextBoxColumn.Name = "EXPFinishDateDataGridViewTextBoxColumn"
        Me.EXPFinishDateDataGridViewTextBoxColumn.Width = 125
        '
        'StaffIDDataGridViewTextBoxColumn
        '
        Me.StaffIDDataGridViewTextBoxColumn.DataPropertyName = "Staff_ID"
        Me.StaffIDDataGridViewTextBoxColumn.HeaderText = "Staff_ID"
        Me.StaffIDDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.StaffIDDataGridViewTextBoxColumn.Name = "StaffIDDataGridViewTextBoxColumn"
        Me.StaffIDDataGridViewTextBoxColumn.Width = 125
        '
        'QualificationBindingSource
        '
        Me.QualificationBindingSource.DataMember = "Qualification"
        Me.QualificationBindingSource.DataSource = Me.Wellmeadows_HospitalDataSet
        '
        'QualificationTableAdapter
        '
        Me.QualificationTableAdapter.ClearBeforeFill = True
        '
        'QualificationIDDataGridViewTextBoxColumn
        '
        Me.QualificationIDDataGridViewTextBoxColumn.DataPropertyName = "Qualification_ID"
        Me.QualificationIDDataGridViewTextBoxColumn.HeaderText = "Qualification_ID"
        Me.QualificationIDDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.QualificationIDDataGridViewTextBoxColumn.Name = "QualificationIDDataGridViewTextBoxColumn"
        Me.QualificationIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.QualificationIDDataGridViewTextBoxColumn.Width = 125
        '
        'QualificationNameDataGridViewTextBoxColumn
        '
        Me.QualificationNameDataGridViewTextBoxColumn.DataPropertyName = "Qualification_Name"
        Me.QualificationNameDataGridViewTextBoxColumn.HeaderText = "Qualification_Name"
        Me.QualificationNameDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.QualificationNameDataGridViewTextBoxColumn.Name = "QualificationNameDataGridViewTextBoxColumn"
        Me.QualificationNameDataGridViewTextBoxColumn.Width = 125
        '
        'GraduationDateDataGridViewTextBoxColumn
        '
        Me.GraduationDateDataGridViewTextBoxColumn.DataPropertyName = "Graduation_Date"
        Me.GraduationDateDataGridViewTextBoxColumn.HeaderText = "Graduation_Date"
        Me.GraduationDateDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.GraduationDateDataGridViewTextBoxColumn.Name = "GraduationDateDataGridViewTextBoxColumn"
        Me.GraduationDateDataGridViewTextBoxColumn.Width = 125
        '
        'InstitutionNameDataGridViewTextBoxColumn
        '
        Me.InstitutionNameDataGridViewTextBoxColumn.DataPropertyName = "Institution_Name"
        Me.InstitutionNameDataGridViewTextBoxColumn.HeaderText = "Institution_Name"
        Me.InstitutionNameDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.InstitutionNameDataGridViewTextBoxColumn.Name = "InstitutionNameDataGridViewTextBoxColumn"
        Me.InstitutionNameDataGridViewTextBoxColumn.Width = 125
        '
        'StaffIDDataGridViewTextBoxColumn1
        '
        Me.StaffIDDataGridViewTextBoxColumn1.DataPropertyName = "Staff_ID"
        Me.StaffIDDataGridViewTextBoxColumn1.HeaderText = "Staff_ID"
        Me.StaffIDDataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.StaffIDDataGridViewTextBoxColumn1.Name = "StaffIDDataGridViewTextBoxColumn1"
        Me.StaffIDDataGridViewTextBoxColumn1.Width = 125
        '
        'FormInformation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1096, 826)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "FormInformation"
        Me.Text = "FormInformation"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Wellmeadows_HospitalDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Work_ExperienceBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QualificationBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents DataGridView4 As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Wellmeadows_HospitalDataSet As Wellmeadows_HospitalDataSet
    Friend WithEvents Work_ExperienceBindingSource As BindingSource
    Friend WithEvents Work_ExperienceTableAdapter As Wellmeadows_HospitalDataSetTableAdapters.Work_ExperienceTableAdapter
    Friend WithEvents TableAdapterManager As Wellmeadows_HospitalDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ExpIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents OrganizationDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PositionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EXPStartDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EXPFinishDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StaffIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents QualificationTableAdapter As Wellmeadows_HospitalDataSetTableAdapters.QualificationTableAdapter
    Friend WithEvents QualificationBindingSource As BindingSource
    Friend WithEvents QualificationIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents QualificationNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GraduationDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents InstitutionNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StaffIDDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
End Class
