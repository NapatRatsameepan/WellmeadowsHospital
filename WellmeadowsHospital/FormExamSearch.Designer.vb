<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormExamSearch
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
        Me.Exam2BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Exam2TableAdapter = New WellmeadowsHospital.Wellmeadows_HospitalDataSetTableAdapters.Exam2TableAdapter()
        Me.TableAdapterManager = New WellmeadowsHospital.Wellmeadows_HospitalDataSetTableAdapters.TableAdapterManager()
        Me.AppointmentIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PatientsIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PatientsNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StaffIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StaffNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ExamDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AppointmentDetailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PatientTypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ExamResultsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Wellmeadows_HospitalDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Exam2BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.AppointmentIDDataGridViewTextBoxColumn, Me.PatientsIDDataGridViewTextBoxColumn, Me.PatientsNameDataGridViewTextBoxColumn, Me.StaffIDDataGridViewTextBoxColumn, Me.StaffNameDataGridViewTextBoxColumn, Me.ExamDateDataGridViewTextBoxColumn, Me.AppointmentDetailDataGridViewTextBoxColumn, Me.PatientTypeDataGridViewTextBoxColumn, Me.ExamResultsDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.Exam2BindingSource
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DataGridView1.Location = New System.Drawing.Point(0, 61)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(836, 666)
        Me.DataGridView1.TabIndex = 0
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
        Me.Label33.Location = New System.Drawing.Point(12, 9)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(187, 38)
        Me.Label33.TabIndex = 207
        Me.Label33.Text = "EXAM LIST"
        '
        'Exam2BindingSource
        '
        Me.Exam2BindingSource.DataMember = "Exam2"
        Me.Exam2BindingSource.DataSource = Me.Wellmeadows_HospitalDataSet
        '
        'Exam2TableAdapter
        '
        Me.Exam2TableAdapter.ClearBeforeFill = True
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
        'AppointmentIDDataGridViewTextBoxColumn
        '
        Me.AppointmentIDDataGridViewTextBoxColumn.DataPropertyName = "Appointment_ID"
        Me.AppointmentIDDataGridViewTextBoxColumn.HeaderText = "Appointment_ID"
        Me.AppointmentIDDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.AppointmentIDDataGridViewTextBoxColumn.Name = "AppointmentIDDataGridViewTextBoxColumn"
        Me.AppointmentIDDataGridViewTextBoxColumn.Width = 125
        '
        'PatientsIDDataGridViewTextBoxColumn
        '
        Me.PatientsIDDataGridViewTextBoxColumn.DataPropertyName = "Patients_ID"
        Me.PatientsIDDataGridViewTextBoxColumn.HeaderText = "Patients_ID"
        Me.PatientsIDDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.PatientsIDDataGridViewTextBoxColumn.Name = "PatientsIDDataGridViewTextBoxColumn"
        Me.PatientsIDDataGridViewTextBoxColumn.Width = 125
        '
        'PatientsNameDataGridViewTextBoxColumn
        '
        Me.PatientsNameDataGridViewTextBoxColumn.DataPropertyName = "Patients Name"
        Me.PatientsNameDataGridViewTextBoxColumn.HeaderText = "Patients Name"
        Me.PatientsNameDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.PatientsNameDataGridViewTextBoxColumn.Name = "PatientsNameDataGridViewTextBoxColumn"
        Me.PatientsNameDataGridViewTextBoxColumn.ReadOnly = True
        Me.PatientsNameDataGridViewTextBoxColumn.Width = 125
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
        'ExamDateDataGridViewTextBoxColumn
        '
        Me.ExamDateDataGridViewTextBoxColumn.DataPropertyName = "Exam_Date"
        Me.ExamDateDataGridViewTextBoxColumn.HeaderText = "Exam_Date"
        Me.ExamDateDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.ExamDateDataGridViewTextBoxColumn.Name = "ExamDateDataGridViewTextBoxColumn"
        Me.ExamDateDataGridViewTextBoxColumn.Width = 125
        '
        'AppointmentDetailDataGridViewTextBoxColumn
        '
        Me.AppointmentDetailDataGridViewTextBoxColumn.DataPropertyName = "Appointment_Detail"
        Me.AppointmentDetailDataGridViewTextBoxColumn.HeaderText = "Appointment_Detail"
        Me.AppointmentDetailDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.AppointmentDetailDataGridViewTextBoxColumn.Name = "AppointmentDetailDataGridViewTextBoxColumn"
        Me.AppointmentDetailDataGridViewTextBoxColumn.Width = 125
        '
        'PatientTypeDataGridViewTextBoxColumn
        '
        Me.PatientTypeDataGridViewTextBoxColumn.DataPropertyName = "Patient_Type"
        Me.PatientTypeDataGridViewTextBoxColumn.HeaderText = "Patient_Type"
        Me.PatientTypeDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.PatientTypeDataGridViewTextBoxColumn.Name = "PatientTypeDataGridViewTextBoxColumn"
        Me.PatientTypeDataGridViewTextBoxColumn.Width = 125
        '
        'ExamResultsDataGridViewTextBoxColumn
        '
        Me.ExamResultsDataGridViewTextBoxColumn.DataPropertyName = "Exam_Results"
        Me.ExamResultsDataGridViewTextBoxColumn.HeaderText = "Exam_Results"
        Me.ExamResultsDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.ExamResultsDataGridViewTextBoxColumn.Name = "ExamResultsDataGridViewTextBoxColumn"
        Me.ExamResultsDataGridViewTextBoxColumn.Width = 125
        '
        'FormExamSearch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(836, 727)
        Me.Controls.Add(Me.Label33)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "FormExamSearch"
        Me.Text = "FormExamSearch"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Wellmeadows_HospitalDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Exam2BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label33 As Label
    Friend WithEvents Wellmeadows_HospitalDataSet As Wellmeadows_HospitalDataSet
    Friend WithEvents Exam2BindingSource As BindingSource
    Friend WithEvents Exam2TableAdapter As Wellmeadows_HospitalDataSetTableAdapters.Exam2TableAdapter
    Friend WithEvents TableAdapterManager As Wellmeadows_HospitalDataSetTableAdapters.TableAdapterManager
    Friend WithEvents AppointmentIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PatientsIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PatientsNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StaffIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StaffNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ExamDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AppointmentDetailDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PatientTypeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ExamResultsDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
