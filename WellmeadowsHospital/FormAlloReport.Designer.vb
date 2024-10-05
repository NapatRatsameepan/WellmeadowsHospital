<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormAlloReport
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
        Me.Wellmeadows_HospitalDataSet = New WellmeadowsHospital.Wellmeadows_HospitalDataSet()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Staff_Allo_listTableAdapter = New WellmeadowsHospital.Wellmeadows_HospitalDataSetTableAdapters.Staff_Allo_listTableAdapter()
        Me.TableAdapterManager = New WellmeadowsHospital.Wellmeadows_HospitalDataSetTableAdapters.TableAdapterManager()
        Me.Staff_Allo_listBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.AllocationListDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WardNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StaffIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StaffNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ShiftDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StartDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FinishDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.WardAllocationIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WardIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WardNameDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StartDateDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FinishDateDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Ward_AllocationBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Ward_AllocationTableAdapter = New WellmeadowsHospital.Wellmeadows_HospitalDataSetTableAdapters.Ward_AllocationTableAdapter()
        Me.txtWard = New System.Windows.Forms.TextBox()
        Me.txtStaff = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.Wellmeadows_HospitalDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Staff_Allo_listBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ward_AllocationBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label10.Location = New System.Drawing.Point(5, 9)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(338, 38)
        Me.Label10.TabIndex = 145
        Me.Label10.Text = "STAFF ALLOCATION"
        '
        'Wellmeadows_HospitalDataSet
        '
        Me.Wellmeadows_HospitalDataSet.DataSetName = "Wellmeadows_HospitalDataSet"
        Me.Wellmeadows_HospitalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(821, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(302, 38)
        Me.Label1.TabIndex = 159
        Me.Label1.Text = "ALLOCATION LIST"
        '
        'Staff_Allo_listTableAdapter
        '
        Me.Staff_Allo_listTableAdapter.ClearBeforeFill = True
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
        'Staff_Allo_listBindingSource
        '
        Me.Staff_Allo_listBindingSource.DataMember = "Staff_Allo_list"
        Me.Staff_Allo_listBindingSource.DataSource = Me.Wellmeadows_HospitalDataSet
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.AllocationListDataGridViewTextBoxColumn, Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.WardNameDataGridViewTextBoxColumn, Me.StaffIDDataGridViewTextBoxColumn, Me.StaffNameDataGridViewTextBoxColumn, Me.ShiftDataGridViewTextBoxColumn, Me.StartDateDataGridViewTextBoxColumn, Me.FinishDateDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.Staff_Allo_listBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(12, 104)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(810, 706)
        Me.DataGridView1.TabIndex = 162
        '
        'AllocationListDataGridViewTextBoxColumn
        '
        Me.AllocationListDataGridViewTextBoxColumn.DataPropertyName = "Allocation_List"
        Me.AllocationListDataGridViewTextBoxColumn.HeaderText = "Allocation_List"
        Me.AllocationListDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.AllocationListDataGridViewTextBoxColumn.Name = "AllocationListDataGridViewTextBoxColumn"
        Me.AllocationListDataGridViewTextBoxColumn.Width = 125
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Ward_Allocation_ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Ward_Allocation_ID"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 125
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Ward_ID"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Ward_ID"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 125
        '
        'WardNameDataGridViewTextBoxColumn
        '
        Me.WardNameDataGridViewTextBoxColumn.DataPropertyName = "Ward_Name"
        Me.WardNameDataGridViewTextBoxColumn.HeaderText = "Ward_Name"
        Me.WardNameDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.WardNameDataGridViewTextBoxColumn.Name = "WardNameDataGridViewTextBoxColumn"
        Me.WardNameDataGridViewTextBoxColumn.Width = 125
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
        'ShiftDataGridViewTextBoxColumn
        '
        Me.ShiftDataGridViewTextBoxColumn.DataPropertyName = "Shift"
        Me.ShiftDataGridViewTextBoxColumn.HeaderText = "Shift"
        Me.ShiftDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.ShiftDataGridViewTextBoxColumn.Name = "ShiftDataGridViewTextBoxColumn"
        Me.ShiftDataGridViewTextBoxColumn.Width = 125
        '
        'StartDateDataGridViewTextBoxColumn
        '
        Me.StartDateDataGridViewTextBoxColumn.DataPropertyName = "Start Date"
        Me.StartDateDataGridViewTextBoxColumn.HeaderText = "Start Date"
        Me.StartDateDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.StartDateDataGridViewTextBoxColumn.Name = "StartDateDataGridViewTextBoxColumn"
        Me.StartDateDataGridViewTextBoxColumn.Width = 125
        '
        'FinishDateDataGridViewTextBoxColumn
        '
        Me.FinishDateDataGridViewTextBoxColumn.DataPropertyName = "Finish Date"
        Me.FinishDateDataGridViewTextBoxColumn.HeaderText = "Finish Date"
        Me.FinishDateDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.FinishDateDataGridViewTextBoxColumn.Name = "FinishDateDataGridViewTextBoxColumn"
        Me.FinishDateDataGridViewTextBoxColumn.Width = 125
        '
        'DataGridView2
        '
        Me.DataGridView2.AutoGenerateColumns = False
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.WardAllocationIDDataGridViewTextBoxColumn, Me.WardIDDataGridViewTextBoxColumn, Me.WardNameDataGridViewTextBoxColumn1, Me.StartDateDataGridViewTextBoxColumn1, Me.FinishDateDataGridViewTextBoxColumn1})
        Me.DataGridView2.DataSource = Me.Ward_AllocationBindingSource
        Me.DataGridView2.Location = New System.Drawing.Point(829, 104)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.RowHeadersWidth = 51
        Me.DataGridView2.RowTemplate.Height = 24
        Me.DataGridView2.Size = New System.Drawing.Size(294, 706)
        Me.DataGridView2.TabIndex = 163
        '
        'WardAllocationIDDataGridViewTextBoxColumn
        '
        Me.WardAllocationIDDataGridViewTextBoxColumn.DataPropertyName = "Ward_Allocation_ID"
        Me.WardAllocationIDDataGridViewTextBoxColumn.HeaderText = "Ward_Allocation_ID"
        Me.WardAllocationIDDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.WardAllocationIDDataGridViewTextBoxColumn.Name = "WardAllocationIDDataGridViewTextBoxColumn"
        Me.WardAllocationIDDataGridViewTextBoxColumn.Width = 125
        '
        'WardIDDataGridViewTextBoxColumn
        '
        Me.WardIDDataGridViewTextBoxColumn.DataPropertyName = "Ward_ID"
        Me.WardIDDataGridViewTextBoxColumn.HeaderText = "Ward_ID"
        Me.WardIDDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.WardIDDataGridViewTextBoxColumn.Name = "WardIDDataGridViewTextBoxColumn"
        Me.WardIDDataGridViewTextBoxColumn.Width = 125
        '
        'WardNameDataGridViewTextBoxColumn1
        '
        Me.WardNameDataGridViewTextBoxColumn1.DataPropertyName = "Ward_Name"
        Me.WardNameDataGridViewTextBoxColumn1.HeaderText = "Ward_Name"
        Me.WardNameDataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.WardNameDataGridViewTextBoxColumn1.Name = "WardNameDataGridViewTextBoxColumn1"
        Me.WardNameDataGridViewTextBoxColumn1.Width = 125
        '
        'StartDateDataGridViewTextBoxColumn1
        '
        Me.StartDateDataGridViewTextBoxColumn1.DataPropertyName = "Start Date"
        Me.StartDateDataGridViewTextBoxColumn1.HeaderText = "Start Date"
        Me.StartDateDataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.StartDateDataGridViewTextBoxColumn1.Name = "StartDateDataGridViewTextBoxColumn1"
        Me.StartDateDataGridViewTextBoxColumn1.Width = 125
        '
        'FinishDateDataGridViewTextBoxColumn1
        '
        Me.FinishDateDataGridViewTextBoxColumn1.DataPropertyName = "Finish Date"
        Me.FinishDateDataGridViewTextBoxColumn1.HeaderText = "Finish Date"
        Me.FinishDateDataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.FinishDateDataGridViewTextBoxColumn1.Name = "FinishDateDataGridViewTextBoxColumn1"
        Me.FinishDateDataGridViewTextBoxColumn1.Width = 125
        '
        'Ward_AllocationBindingSource
        '
        Me.Ward_AllocationBindingSource.DataMember = "Ward_Allocation"
        Me.Ward_AllocationBindingSource.DataSource = Me.Wellmeadows_HospitalDataSet
        '
        'Ward_AllocationTableAdapter
        '
        Me.Ward_AllocationTableAdapter.ClearBeforeFill = True
        '
        'txtWard
        '
        Me.txtWard.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txtWard.Location = New System.Drawing.Point(829, 76)
        Me.txtWard.Name = "txtWard"
        Me.txtWard.Size = New System.Drawing.Size(181, 22)
        Me.txtWard.TabIndex = 229
        '
        'txtStaff
        '
        Me.txtStaff.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txtStaff.Location = New System.Drawing.Point(12, 76)
        Me.txtStaff.Name = "txtStaff"
        Me.txtStaff.Size = New System.Drawing.Size(181, 22)
        Me.txtStaff.TabIndex = 230
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 16)
        Me.Label2.TabIndex = 231
        Me.Label2.Text = "ชื่อเจ้าหน้าที่"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(826, 57)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 16)
        Me.Label3.TabIndex = 232
        Me.Label3.Text = "ไอดีเวร"
        '
        'FormAlloReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1135, 822)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtStaff)
        Me.Controls.Add(Me.txtWard)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label10)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormAlloReport"
        Me.Text = "FormAlloReport"
        CType(Me.Wellmeadows_HospitalDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Staff_Allo_listBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ward_AllocationBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label10 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Wellmeadows_HospitalDataSet As Wellmeadows_HospitalDataSet
    Friend WithEvents Staff_Allo_listTableAdapter As Wellmeadows_HospitalDataSetTableAdapters.Staff_Allo_listTableAdapter
    Friend WithEvents TableAdapterManager As Wellmeadows_HospitalDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Staff_Allo_listBindingSource As BindingSource
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents AllocationListDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents WardNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StaffIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StaffNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ShiftDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StartDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FinishDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents Ward_AllocationBindingSource As BindingSource
    Friend WithEvents Ward_AllocationTableAdapter As Wellmeadows_HospitalDataSetTableAdapters.Ward_AllocationTableAdapter
    Friend WithEvents WardAllocationIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents WardIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents WardNameDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents StartDateDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents FinishDateDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents txtWard As TextBox
    Friend WithEvents txtStaff As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
