<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormLDsearch
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
        Me.dgvLocalDoctor = New System.Windows.Forms.DataGridView()
        Me.ClinicIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LDNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LDLastnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LDTelDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AddressDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Local_DoctorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Wellmeadows_HospitalDataSet = New WellmeadowsHospital.Wellmeadows_HospitalDataSet()
        Me.Local_DoctorTableAdapter = New WellmeadowsHospital.Wellmeadows_HospitalDataSetTableAdapters.Local_DoctorTableAdapter()
        Me.TableAdapterManager = New WellmeadowsHospital.Wellmeadows_HospitalDataSetTableAdapters.TableAdapterManager()
        Me.Label11 = New System.Windows.Forms.Label()
        CType(Me.dgvLocalDoctor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Local_DoctorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Wellmeadows_HospitalDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvLocalDoctor
        '
        Me.dgvLocalDoctor.AutoGenerateColumns = False
        Me.dgvLocalDoctor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvLocalDoctor.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ClinicIDDataGridViewTextBoxColumn, Me.LDNameDataGridViewTextBoxColumn, Me.LDLastnameDataGridViewTextBoxColumn, Me.LDTelDataGridViewTextBoxColumn, Me.AddressDataGridViewTextBoxColumn})
        Me.dgvLocalDoctor.DataSource = Me.Local_DoctorBindingSource
        Me.dgvLocalDoctor.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.dgvLocalDoctor.Location = New System.Drawing.Point(0, 61)
        Me.dgvLocalDoctor.Name = "dgvLocalDoctor"
        Me.dgvLocalDoctor.RowHeadersWidth = 51
        Me.dgvLocalDoctor.RowTemplate.Height = 24
        Me.dgvLocalDoctor.Size = New System.Drawing.Size(836, 666)
        Me.dgvLocalDoctor.TabIndex = 0
        '
        'ClinicIDDataGridViewTextBoxColumn
        '
        Me.ClinicIDDataGridViewTextBoxColumn.DataPropertyName = "Clinic_ID"
        Me.ClinicIDDataGridViewTextBoxColumn.HeaderText = "Clinic_ID"
        Me.ClinicIDDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.ClinicIDDataGridViewTextBoxColumn.Name = "ClinicIDDataGridViewTextBoxColumn"
        Me.ClinicIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.ClinicIDDataGridViewTextBoxColumn.Width = 125
        '
        'LDNameDataGridViewTextBoxColumn
        '
        Me.LDNameDataGridViewTextBoxColumn.DataPropertyName = "LD_Name"
        Me.LDNameDataGridViewTextBoxColumn.HeaderText = "LD_Name"
        Me.LDNameDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.LDNameDataGridViewTextBoxColumn.Name = "LDNameDataGridViewTextBoxColumn"
        Me.LDNameDataGridViewTextBoxColumn.Width = 125
        '
        'LDLastnameDataGridViewTextBoxColumn
        '
        Me.LDLastnameDataGridViewTextBoxColumn.DataPropertyName = "LD_Lastname"
        Me.LDLastnameDataGridViewTextBoxColumn.HeaderText = "LD_Lastname"
        Me.LDLastnameDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.LDLastnameDataGridViewTextBoxColumn.Name = "LDLastnameDataGridViewTextBoxColumn"
        Me.LDLastnameDataGridViewTextBoxColumn.Width = 125
        '
        'LDTelDataGridViewTextBoxColumn
        '
        Me.LDTelDataGridViewTextBoxColumn.DataPropertyName = "LD_Tel"
        Me.LDTelDataGridViewTextBoxColumn.HeaderText = "LD_Tel"
        Me.LDTelDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.LDTelDataGridViewTextBoxColumn.Name = "LDTelDataGridViewTextBoxColumn"
        Me.LDTelDataGridViewTextBoxColumn.Width = 125
        '
        'AddressDataGridViewTextBoxColumn
        '
        Me.AddressDataGridViewTextBoxColumn.DataPropertyName = "Address"
        Me.AddressDataGridViewTextBoxColumn.HeaderText = "Address"
        Me.AddressDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.AddressDataGridViewTextBoxColumn.Name = "AddressDataGridViewTextBoxColumn"
        Me.AddressDataGridViewTextBoxColumn.Width = 125
        '
        'Local_DoctorBindingSource
        '
        Me.Local_DoctorBindingSource.DataMember = "Local_Doctor"
        Me.Local_DoctorBindingSource.DataSource = Me.Wellmeadows_HospitalDataSet
        '
        'Wellmeadows_HospitalDataSet
        '
        Me.Wellmeadows_HospitalDataSet.DataSetName = "Wellmeadows_HospitalDataSet"
        Me.Wellmeadows_HospitalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Local_DoctorTableAdapter
        '
        Me.Local_DoctorTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.Local_DoctorTableAdapter = Me.Local_DoctorTableAdapter
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
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label11.Location = New System.Drawing.Point(12, 9)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(278, 38)
        Me.Label11.TabIndex = 200
        Me.Label11.Text = "LOCAL DOCTOR"
        '
        'FormLDsearch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(836, 727)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.dgvLocalDoctor)
        Me.Name = "FormLDsearch"
        Me.Text = "FormLDsearch"
        CType(Me.dgvLocalDoctor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Local_DoctorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Wellmeadows_HospitalDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvLocalDoctor As DataGridView
    Friend WithEvents Wellmeadows_HospitalDataSet As Wellmeadows_HospitalDataSet
    Friend WithEvents Local_DoctorBindingSource As BindingSource
    Friend WithEvents Local_DoctorTableAdapter As Wellmeadows_HospitalDataSetTableAdapters.Local_DoctorTableAdapter
    Friend WithEvents TableAdapterManager As Wellmeadows_HospitalDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ClinicIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LDNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LDLastnameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LDTelDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AddressDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Label11 As Label
End Class
