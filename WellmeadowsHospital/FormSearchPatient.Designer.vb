<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormSearchPatient
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Wellmeadows_HospitalDataSet = New WellmeadowsHospital.Wellmeadows_HospitalDataSet()
        Me.PatientsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PatientsTableAdapter = New WellmeadowsHospital.Wellmeadows_HospitalDataSetTableAdapters.PatientsTableAdapter()
        Me.TableAdapterManager = New WellmeadowsHospital.Wellmeadows_HospitalDataSetTableAdapters.TableAdapterManager()
        Me.PatientsIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PatientNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PatientLastnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AddressDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SexDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MartialStatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PatientTelDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PatientDOBDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateRegisteredDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClinicIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Wellmeadows_HospitalDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PatientsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PatientsIDDataGridViewTextBoxColumn, Me.PatientNameDataGridViewTextBoxColumn, Me.PatientLastnameDataGridViewTextBoxColumn, Me.AddressDataGridViewTextBoxColumn, Me.SexDataGridViewTextBoxColumn, Me.MartialStatusDataGridViewTextBoxColumn, Me.PatientTelDataGridViewTextBoxColumn, Me.PatientDOBDataGridViewTextBoxColumn, Me.DateRegisteredDataGridViewTextBoxColumn, Me.ClinicIDDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.PatientsBindingSource
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DataGridView1.Location = New System.Drawing.Point(0, 61)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(836, 666)
        Me.DataGridView1.TabIndex = 0
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label11.Location = New System.Drawing.Point(12, 9)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(177, 38)
        Me.Label11.TabIndex = 201
        Me.Label11.Text = "PATIENTS"
        '
        'Wellmeadows_HospitalDataSet
        '
        Me.Wellmeadows_HospitalDataSet.DataSetName = "Wellmeadows_HospitalDataSet"
        Me.Wellmeadows_HospitalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PatientsBindingSource
        '
        Me.PatientsBindingSource.DataMember = "Patients"
        Me.PatientsBindingSource.DataSource = Me.Wellmeadows_HospitalDataSet
        '
        'PatientsTableAdapter
        '
        Me.PatientsTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.PatientsTableAdapter = Me.PatientsTableAdapter
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
        'PatientsIDDataGridViewTextBoxColumn
        '
        Me.PatientsIDDataGridViewTextBoxColumn.DataPropertyName = "Patients_ID"
        Me.PatientsIDDataGridViewTextBoxColumn.HeaderText = "Patients_ID"
        Me.PatientsIDDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.PatientsIDDataGridViewTextBoxColumn.Name = "PatientsIDDataGridViewTextBoxColumn"
        Me.PatientsIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.PatientsIDDataGridViewTextBoxColumn.Width = 125
        '
        'PatientNameDataGridViewTextBoxColumn
        '
        Me.PatientNameDataGridViewTextBoxColumn.DataPropertyName = "Patient_Name"
        Me.PatientNameDataGridViewTextBoxColumn.HeaderText = "Patient_Name"
        Me.PatientNameDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.PatientNameDataGridViewTextBoxColumn.Name = "PatientNameDataGridViewTextBoxColumn"
        Me.PatientNameDataGridViewTextBoxColumn.Width = 125
        '
        'PatientLastnameDataGridViewTextBoxColumn
        '
        Me.PatientLastnameDataGridViewTextBoxColumn.DataPropertyName = "Patient_Lastname"
        Me.PatientLastnameDataGridViewTextBoxColumn.HeaderText = "Patient_Lastname"
        Me.PatientLastnameDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.PatientLastnameDataGridViewTextBoxColumn.Name = "PatientLastnameDataGridViewTextBoxColumn"
        Me.PatientLastnameDataGridViewTextBoxColumn.Width = 125
        '
        'AddressDataGridViewTextBoxColumn
        '
        Me.AddressDataGridViewTextBoxColumn.DataPropertyName = "Address"
        Me.AddressDataGridViewTextBoxColumn.HeaderText = "Address"
        Me.AddressDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.AddressDataGridViewTextBoxColumn.Name = "AddressDataGridViewTextBoxColumn"
        Me.AddressDataGridViewTextBoxColumn.Width = 125
        '
        'SexDataGridViewTextBoxColumn
        '
        Me.SexDataGridViewTextBoxColumn.DataPropertyName = "Sex"
        Me.SexDataGridViewTextBoxColumn.HeaderText = "Sex"
        Me.SexDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.SexDataGridViewTextBoxColumn.Name = "SexDataGridViewTextBoxColumn"
        Me.SexDataGridViewTextBoxColumn.Width = 125
        '
        'MartialStatusDataGridViewTextBoxColumn
        '
        Me.MartialStatusDataGridViewTextBoxColumn.DataPropertyName = "Martial_Status"
        Me.MartialStatusDataGridViewTextBoxColumn.HeaderText = "Martial_Status"
        Me.MartialStatusDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.MartialStatusDataGridViewTextBoxColumn.Name = "MartialStatusDataGridViewTextBoxColumn"
        Me.MartialStatusDataGridViewTextBoxColumn.Width = 125
        '
        'PatientTelDataGridViewTextBoxColumn
        '
        Me.PatientTelDataGridViewTextBoxColumn.DataPropertyName = "Patient_Tel"
        Me.PatientTelDataGridViewTextBoxColumn.HeaderText = "Patient_Tel"
        Me.PatientTelDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.PatientTelDataGridViewTextBoxColumn.Name = "PatientTelDataGridViewTextBoxColumn"
        Me.PatientTelDataGridViewTextBoxColumn.Width = 125
        '
        'PatientDOBDataGridViewTextBoxColumn
        '
        Me.PatientDOBDataGridViewTextBoxColumn.DataPropertyName = "Patient_DOB"
        Me.PatientDOBDataGridViewTextBoxColumn.HeaderText = "Patient_DOB"
        Me.PatientDOBDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.PatientDOBDataGridViewTextBoxColumn.Name = "PatientDOBDataGridViewTextBoxColumn"
        Me.PatientDOBDataGridViewTextBoxColumn.Width = 125
        '
        'DateRegisteredDataGridViewTextBoxColumn
        '
        Me.DateRegisteredDataGridViewTextBoxColumn.DataPropertyName = "Date_Registered"
        Me.DateRegisteredDataGridViewTextBoxColumn.HeaderText = "Date_Registered"
        Me.DateRegisteredDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.DateRegisteredDataGridViewTextBoxColumn.Name = "DateRegisteredDataGridViewTextBoxColumn"
        Me.DateRegisteredDataGridViewTextBoxColumn.Width = 125
        '
        'ClinicIDDataGridViewTextBoxColumn
        '
        Me.ClinicIDDataGridViewTextBoxColumn.DataPropertyName = "Clinic_ID"
        Me.ClinicIDDataGridViewTextBoxColumn.HeaderText = "Clinic_ID"
        Me.ClinicIDDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.ClinicIDDataGridViewTextBoxColumn.Name = "ClinicIDDataGridViewTextBoxColumn"
        Me.ClinicIDDataGridViewTextBoxColumn.Width = 125
        '
        'FormSearchPatient
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(836, 727)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "FormSearchPatient"
        Me.Text = "FormSearchPatient"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Wellmeadows_HospitalDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PatientsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label11 As Label
    Friend WithEvents Wellmeadows_HospitalDataSet As Wellmeadows_HospitalDataSet
    Friend WithEvents PatientsBindingSource As BindingSource
    Friend WithEvents PatientsTableAdapter As Wellmeadows_HospitalDataSetTableAdapters.PatientsTableAdapter
    Friend WithEvents TableAdapterManager As Wellmeadows_HospitalDataSetTableAdapters.TableAdapterManager
    Friend WithEvents PatientsIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PatientNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PatientLastnameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AddressDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SexDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MartialStatusDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PatientTelDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PatientDOBDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DateRegisteredDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ClinicIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
