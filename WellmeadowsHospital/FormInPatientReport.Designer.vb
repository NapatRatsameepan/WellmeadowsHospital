﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormInPatientReport
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
        Me.Wellmeadows_HospitalDataSet = New WellmeadowsHospital.Wellmeadows_HospitalDataSet()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.View_IPBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.View_IPTableAdapter = New WellmeadowsHospital.Wellmeadows_HospitalDataSetTableAdapters.View_IPTableAdapter()
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
        Me.StaffNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BedIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WardNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.Wellmeadows_HospitalDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel2.SuspendLayout()
        CType(Me.View_IPBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Wellmeadows_HospitalDataSet
        '
        Me.Wellmeadows_HospitalDataSet.DataSetName = "Wellmeadows_HospitalDataSet"
        Me.Wellmeadows_HospitalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.DataGridView1, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.773399!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 93.2266!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1055, 812)
        Me.TableLayoutPanel1.TabIndex = 2
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.AllocationIDDataGridViewTextBoxColumn, Me.DatePlacedDataGridViewTextBoxColumn, Me.ExpectedStaysDataGridViewTextBoxColumn, Me.DateLeaveDataGridViewTextBoxColumn, Me.ActualLeaveDataGridViewTextBoxColumn, Me.OnWaitinglistDataGridViewTextBoxColumn, Me.WaitingStatusDataGridViewTextBoxColumn, Me.PatientsIDDataGridViewTextBoxColumn, Me.PatientNameDataGridViewTextBoxColumn, Me.StaffNameDataGridViewTextBoxColumn, Me.BedIDDataGridViewTextBoxColumn, Me.WardNameDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.View_IPBindingSource
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(3, 58)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(1049, 751)
        Me.DataGridView1.TabIndex = 227
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 3
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 79.16666!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.83333!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 665.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.Label39, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.TextBox1, 2, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label1, 1, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(1049, 49)
        Me.TableLayoutPanel2.TabIndex = 228
        '
        'Label39
        '
        Me.Label39.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label39.AutoSize = True
        Me.Label39.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label39.Location = New System.Drawing.Point(3, 5)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(218, 38)
        Me.Label39.TabIndex = 227
        Me.Label39.Text = "IN PATIENTS"
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.TextBox1.Location = New System.Drawing.Point(387, 13)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(230, 22)
        Me.TextBox1.TabIndex = 228
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(335, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 16)
        Me.Label1.TabIndex = 229
        Me.Label1.Text = "ชื่อผูู้ป่วย"
        '
        'View_IPBindingSource
        '
        Me.View_IPBindingSource.DataMember = "View_IP"
        Me.View_IPBindingSource.DataSource = Me.Wellmeadows_HospitalDataSet
        '
        'View_IPTableAdapter
        '
        Me.View_IPTableAdapter.ClearBeforeFill = True
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
        'WardNameDataGridViewTextBoxColumn
        '
        Me.WardNameDataGridViewTextBoxColumn.DataPropertyName = "Ward_Name"
        Me.WardNameDataGridViewTextBoxColumn.HeaderText = "Ward_Name"
        Me.WardNameDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.WardNameDataGridViewTextBoxColumn.Name = "WardNameDataGridViewTextBoxColumn"
        Me.WardNameDataGridViewTextBoxColumn.Width = 125
        '
        'FormInPatientReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1055, 812)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "FormInPatientReport"
        Me.Text = "FormInPatientReport"
        CType(Me.Wellmeadows_HospitalDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        CType(Me.View_IPBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Wellmeadows_HospitalDataSet As Wellmeadows_HospitalDataSet
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents Label39 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents View_IPBindingSource As BindingSource
    Friend WithEvents View_IPTableAdapter As Wellmeadows_HospitalDataSetTableAdapters.View_IPTableAdapter
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
    Friend WithEvents StaffNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BedIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents WardNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
