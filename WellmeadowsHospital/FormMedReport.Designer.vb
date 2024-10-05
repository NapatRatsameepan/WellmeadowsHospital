<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormMedReport
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Wellmeadows_HospitalDataSet = New WellmeadowsHospital.Wellmeadows_HospitalDataSet()
        Me.PrescribeReport2BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PrescribeReport2TableAdapter = New WellmeadowsHospital.Wellmeadows_HospitalDataSetTableAdapters.PrescribeReport2TableAdapter()
        Me.TableAdapterManager = New WellmeadowsHospital.Wellmeadows_HospitalDataSetTableAdapters.TableAdapterManager()
        Me.PrescribeIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrescribeDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PatientNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DrugNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UnitsperdayDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StartdateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EndDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DaysUsedDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalUnitDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StaffNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel2.SuspendLayout()
        CType(Me.Wellmeadows_HospitalDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrescribeReport2BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.TableLayoutPanel1.TabIndex = 3
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PrescribeIDDataGridViewTextBoxColumn, Me.PrescribeDateDataGridViewTextBoxColumn, Me.PatientNameDataGridViewTextBoxColumn, Me.DrugNameDataGridViewTextBoxColumn, Me.UnitsperdayDataGridViewTextBoxColumn, Me.StartdateDataGridViewTextBoxColumn, Me.EndDateDataGridViewTextBoxColumn, Me.DaysUsedDataGridViewTextBoxColumn, Me.TotalUnitDataGridViewTextBoxColumn, Me.StaffNameDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.PrescribeReport2BindingSource
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
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.55046!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.44954!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 666.0!))
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
        Me.Label39.Size = New System.Drawing.Size(207, 38)
        Me.Label39.TabIndex = 227
        Me.Label39.Text = "PRESCRIBE"
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.TextBox1.Location = New System.Drawing.Point(385, 13)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(230, 22)
        Me.TextBox1.TabIndex = 228
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(298, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 16)
        Me.Label1.TabIndex = 229
        Me.Label1.Text = "Prescribe ID"
        '
        'Wellmeadows_HospitalDataSet
        '
        Me.Wellmeadows_HospitalDataSet.DataSetName = "Wellmeadows_HospitalDataSet"
        Me.Wellmeadows_HospitalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PrescribeReport2BindingSource
        '
        Me.PrescribeReport2BindingSource.DataMember = "PrescribeReport2"
        Me.PrescribeReport2BindingSource.DataSource = Me.Wellmeadows_HospitalDataSet
        '
        'PrescribeReport2TableAdapter
        '
        Me.PrescribeReport2TableAdapter.ClearBeforeFill = True
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
        'PrescribeIDDataGridViewTextBoxColumn
        '
        Me.PrescribeIDDataGridViewTextBoxColumn.DataPropertyName = "Prescribe_ID"
        Me.PrescribeIDDataGridViewTextBoxColumn.HeaderText = "Prescribe_ID"
        Me.PrescribeIDDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.PrescribeIDDataGridViewTextBoxColumn.Name = "PrescribeIDDataGridViewTextBoxColumn"
        Me.PrescribeIDDataGridViewTextBoxColumn.Width = 125
        '
        'PrescribeDateDataGridViewTextBoxColumn
        '
        Me.PrescribeDateDataGridViewTextBoxColumn.DataPropertyName = "Prescribe_Date"
        Me.PrescribeDateDataGridViewTextBoxColumn.HeaderText = "Prescribe_Date"
        Me.PrescribeDateDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.PrescribeDateDataGridViewTextBoxColumn.Name = "PrescribeDateDataGridViewTextBoxColumn"
        Me.PrescribeDateDataGridViewTextBoxColumn.Width = 125
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
        'DrugNameDataGridViewTextBoxColumn
        '
        Me.DrugNameDataGridViewTextBoxColumn.DataPropertyName = "Drug_Name"
        Me.DrugNameDataGridViewTextBoxColumn.HeaderText = "Drug_Name"
        Me.DrugNameDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.DrugNameDataGridViewTextBoxColumn.Name = "DrugNameDataGridViewTextBoxColumn"
        Me.DrugNameDataGridViewTextBoxColumn.Width = 125
        '
        'UnitsperdayDataGridViewTextBoxColumn
        '
        Me.UnitsperdayDataGridViewTextBoxColumn.DataPropertyName = "Units_per_day"
        Me.UnitsperdayDataGridViewTextBoxColumn.HeaderText = "Units_per_day"
        Me.UnitsperdayDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.UnitsperdayDataGridViewTextBoxColumn.Name = "UnitsperdayDataGridViewTextBoxColumn"
        Me.UnitsperdayDataGridViewTextBoxColumn.Width = 125
        '
        'StartdateDataGridViewTextBoxColumn
        '
        Me.StartdateDataGridViewTextBoxColumn.DataPropertyName = "Start_date"
        Me.StartdateDataGridViewTextBoxColumn.HeaderText = "Start_date"
        Me.StartdateDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.StartdateDataGridViewTextBoxColumn.Name = "StartdateDataGridViewTextBoxColumn"
        Me.StartdateDataGridViewTextBoxColumn.Width = 125
        '
        'EndDateDataGridViewTextBoxColumn
        '
        Me.EndDateDataGridViewTextBoxColumn.DataPropertyName = "End_Date"
        Me.EndDateDataGridViewTextBoxColumn.HeaderText = "End_Date"
        Me.EndDateDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.EndDateDataGridViewTextBoxColumn.Name = "EndDateDataGridViewTextBoxColumn"
        Me.EndDateDataGridViewTextBoxColumn.Width = 125
        '
        'DaysUsedDataGridViewTextBoxColumn
        '
        Me.DaysUsedDataGridViewTextBoxColumn.DataPropertyName = "Days_Used"
        Me.DaysUsedDataGridViewTextBoxColumn.HeaderText = "Days_Used"
        Me.DaysUsedDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.DaysUsedDataGridViewTextBoxColumn.Name = "DaysUsedDataGridViewTextBoxColumn"
        Me.DaysUsedDataGridViewTextBoxColumn.ReadOnly = True
        Me.DaysUsedDataGridViewTextBoxColumn.Width = 125
        '
        'TotalUnitDataGridViewTextBoxColumn
        '
        Me.TotalUnitDataGridViewTextBoxColumn.DataPropertyName = "Total_Unit"
        Me.TotalUnitDataGridViewTextBoxColumn.HeaderText = "Total_Unit"
        Me.TotalUnitDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.TotalUnitDataGridViewTextBoxColumn.Name = "TotalUnitDataGridViewTextBoxColumn"
        Me.TotalUnitDataGridViewTextBoxColumn.ReadOnly = True
        Me.TotalUnitDataGridViewTextBoxColumn.Width = 125
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
        'FormMedReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1055, 812)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "FormMedReport"
        Me.Text = "FormMedReport"
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        CType(Me.Wellmeadows_HospitalDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrescribeReport2BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents Label39 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Wellmeadows_HospitalDataSet As Wellmeadows_HospitalDataSet
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents PrescribeReport2BindingSource As BindingSource
    Friend WithEvents PrescribeReport2TableAdapter As Wellmeadows_HospitalDataSetTableAdapters.PrescribeReport2TableAdapter
    Friend WithEvents TableAdapterManager As Wellmeadows_HospitalDataSetTableAdapters.TableAdapterManager
    Friend WithEvents PrescribeIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PrescribeDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PatientNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DrugNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UnitsperdayDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StartdateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EndDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DaysUsedDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TotalUnitDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StaffNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
