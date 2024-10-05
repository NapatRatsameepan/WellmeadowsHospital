<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormPAllocation
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Wellmeadows_HospitalDataSet = New WellmeadowsHospital.Wellmeadows_HospitalDataSet()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.PAllocation2BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PAllocation2TableAdapter = New WellmeadowsHospital.Wellmeadows_HospitalDataSetTableAdapters.PAllocation2TableAdapter()
        Me.TableAdapterManager = New WellmeadowsHospital.Wellmeadows_HospitalDataSetTableAdapters.TableAdapterManager()
        Me.AllocationIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DatePlacedDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ExpectedStaysDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateLeaveDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ActualLeaveDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OnWaitinglistDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WaitingStatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PatientsIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PatientNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StaffIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StaffNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BedIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WardIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WardNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Wellmeadows_HospitalDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PAllocation2BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.AllocationIDDataGridViewTextBoxColumn, Me.DatePlacedDataGridViewTextBoxColumn, Me.ExpectedStaysDataGridViewTextBoxColumn, Me.DateLeaveDataGridViewTextBoxColumn, Me.ActualLeaveDataGridViewTextBoxColumn, Me.OnWaitinglistDataGridViewTextBoxColumn, Me.WaitingStatusDataGridViewTextBoxColumn, Me.PatientsIDDataGridViewTextBoxColumn, Me.PatientNameDataGridViewTextBoxColumn, Me.StaffIDDataGridViewTextBoxColumn, Me.StaffNameDataGridViewTextBoxColumn, Me.BedIDDataGridViewTextBoxColumn, Me.WardIDDataGridViewTextBoxColumn, Me.WardNameDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.PAllocation2BindingSource
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DataGridView1.Location = New System.Drawing.Point(0, 61)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(836, 666)
        Me.DataGridView1.TabIndex = 209
        '
        'Wellmeadows_HospitalDataSet
        '
        Me.Wellmeadows_HospitalDataSet.DataSetName = "Wellmeadows_HospitalDataSet"
        Me.Wellmeadows_HospitalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label33.Location = New System.Drawing.Point(12, 4)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(177, 38)
        Me.Label33.TabIndex = 208
        Me.Label33.Text = "PATIENTS"
        '
        'PAllocation2BindingSource
        '
        Me.PAllocation2BindingSource.DataMember = "PAllocation2"
        Me.PAllocation2BindingSource.DataSource = Me.Wellmeadows_HospitalDataSet
        '
        'PAllocation2TableAdapter
        '
        Me.PAllocation2TableAdapter.ClearBeforeFill = True
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
        'AllocationIDDataGridViewTextBoxColumn
        '
        Me.AllocationIDDataGridViewTextBoxColumn.DataPropertyName = "Allocation_ID"
        Me.AllocationIDDataGridViewTextBoxColumn.HeaderText = "Allocation_ID"
        Me.AllocationIDDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.AllocationIDDataGridViewTextBoxColumn.Name = "AllocationIDDataGridViewTextBoxColumn"
        Me.AllocationIDDataGridViewTextBoxColumn.Width = 125
        '
        'DatePlacedDataGridViewTextBoxColumn
        '
        Me.DatePlacedDataGridViewTextBoxColumn.DataPropertyName = "Date_Placed"
        Me.DatePlacedDataGridViewTextBoxColumn.HeaderText = "Date_Placed"
        Me.DatePlacedDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.DatePlacedDataGridViewTextBoxColumn.Name = "DatePlacedDataGridViewTextBoxColumn"
        Me.DatePlacedDataGridViewTextBoxColumn.Width = 125
        '
        'ExpectedStaysDataGridViewTextBoxColumn
        '
        Me.ExpectedStaysDataGridViewTextBoxColumn.DataPropertyName = "Expected_Stays"
        Me.ExpectedStaysDataGridViewTextBoxColumn.HeaderText = "Expected_Stays"
        Me.ExpectedStaysDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.ExpectedStaysDataGridViewTextBoxColumn.Name = "ExpectedStaysDataGridViewTextBoxColumn"
        Me.ExpectedStaysDataGridViewTextBoxColumn.Width = 125
        '
        'DateLeaveDataGridViewTextBoxColumn
        '
        Me.DateLeaveDataGridViewTextBoxColumn.DataPropertyName = "Date_Leave"
        Me.DateLeaveDataGridViewTextBoxColumn.HeaderText = "Date_Leave"
        Me.DateLeaveDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.DateLeaveDataGridViewTextBoxColumn.Name = "DateLeaveDataGridViewTextBoxColumn"
        Me.DateLeaveDataGridViewTextBoxColumn.Width = 125
        '
        'ActualLeaveDataGridViewTextBoxColumn
        '
        Me.ActualLeaveDataGridViewTextBoxColumn.DataPropertyName = "Actual_Leave"
        Me.ActualLeaveDataGridViewTextBoxColumn.HeaderText = "Actual_Leave"
        Me.ActualLeaveDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.ActualLeaveDataGridViewTextBoxColumn.Name = "ActualLeaveDataGridViewTextBoxColumn"
        Me.ActualLeaveDataGridViewTextBoxColumn.Width = 125
        '
        'OnWaitinglistDataGridViewTextBoxColumn
        '
        Me.OnWaitinglistDataGridViewTextBoxColumn.DataPropertyName = "On_Waiting_list"
        Me.OnWaitinglistDataGridViewTextBoxColumn.HeaderText = "On_Waiting_list"
        Me.OnWaitinglistDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.OnWaitinglistDataGridViewTextBoxColumn.Name = "OnWaitinglistDataGridViewTextBoxColumn"
        Me.OnWaitinglistDataGridViewTextBoxColumn.Width = 125
        '
        'WaitingStatusDataGridViewTextBoxColumn
        '
        Me.WaitingStatusDataGridViewTextBoxColumn.DataPropertyName = "Waiting_Status"
        Me.WaitingStatusDataGridViewTextBoxColumn.HeaderText = "Waiting_Status"
        Me.WaitingStatusDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.WaitingStatusDataGridViewTextBoxColumn.Name = "WaitingStatusDataGridViewTextBoxColumn"
        Me.WaitingStatusDataGridViewTextBoxColumn.Width = 125
        '
        'PatientsIDDataGridViewTextBoxColumn
        '
        Me.PatientsIDDataGridViewTextBoxColumn.DataPropertyName = "Patients_ID"
        Me.PatientsIDDataGridViewTextBoxColumn.HeaderText = "Patients_ID"
        Me.PatientsIDDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.PatientsIDDataGridViewTextBoxColumn.Name = "PatientsIDDataGridViewTextBoxColumn"
        Me.PatientsIDDataGridViewTextBoxColumn.Width = 125
        '
        'PatientNameDataGridViewTextBoxColumn
        '
        Me.PatientNameDataGridViewTextBoxColumn.DataPropertyName = "Patient Name"
        Me.PatientNameDataGridViewTextBoxColumn.HeaderText = "Patient Name"
        Me.PatientNameDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.PatientNameDataGridViewTextBoxColumn.Name = "PatientNameDataGridViewTextBoxColumn"
        Me.PatientNameDataGridViewTextBoxColumn.ReadOnly = True
        Me.PatientNameDataGridViewTextBoxColumn.Width = 125
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
        'BedIDDataGridViewTextBoxColumn
        '
        Me.BedIDDataGridViewTextBoxColumn.DataPropertyName = "Bed_ID"
        Me.BedIDDataGridViewTextBoxColumn.HeaderText = "Bed_ID"
        Me.BedIDDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.BedIDDataGridViewTextBoxColumn.Name = "BedIDDataGridViewTextBoxColumn"
        Me.BedIDDataGridViewTextBoxColumn.Width = 125
        '
        'WardIDDataGridViewTextBoxColumn
        '
        Me.WardIDDataGridViewTextBoxColumn.DataPropertyName = "Ward_ID"
        Me.WardIDDataGridViewTextBoxColumn.HeaderText = "Ward_ID"
        Me.WardIDDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.WardIDDataGridViewTextBoxColumn.Name = "WardIDDataGridViewTextBoxColumn"
        Me.WardIDDataGridViewTextBoxColumn.Width = 125
        '
        'WardNameDataGridViewTextBoxColumn
        '
        Me.WardNameDataGridViewTextBoxColumn.DataPropertyName = "Ward_Name"
        Me.WardNameDataGridViewTextBoxColumn.HeaderText = "Ward_Name"
        Me.WardNameDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.WardNameDataGridViewTextBoxColumn.Name = "WardNameDataGridViewTextBoxColumn"
        Me.WardNameDataGridViewTextBoxColumn.Width = 125
        '
        'FormPAllocation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(836, 727)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label33)
        Me.Name = "FormPAllocation"
        Me.Text = "FormPAllocation"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Wellmeadows_HospitalDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PAllocation2BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label33 As Label
    Friend WithEvents Wellmeadows_HospitalDataSet As Wellmeadows_HospitalDataSet
    Friend WithEvents PAllocation2BindingSource As BindingSource
    Friend WithEvents PAllocation2TableAdapter As Wellmeadows_HospitalDataSetTableAdapters.PAllocation2TableAdapter
    Friend WithEvents TableAdapterManager As Wellmeadows_HospitalDataSetTableAdapters.TableAdapterManager
    Friend WithEvents AllocationIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DatePlacedDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ExpectedStaysDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DateLeaveDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ActualLeaveDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents OnWaitinglistDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents WaitingStatusDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PatientsIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PatientNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StaffIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StaffNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BedIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents WardIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents WardNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
