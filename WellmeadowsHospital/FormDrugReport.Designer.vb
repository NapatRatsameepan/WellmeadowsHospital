<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormDrugReport
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
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Wellmeadows_HospitalDataSet = New WellmeadowsHospital.Wellmeadows_HospitalDataSet()
        Me.View_DrugReportBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.View_DrugReportTableAdapter = New WellmeadowsHospital.Wellmeadows_HospitalDataSetTableAdapters.View_DrugReportTableAdapter()
        Me.TableAdapterManager = New WellmeadowsHospital.Wellmeadows_HospitalDataSetTableAdapters.TableAdapterManager()
        Me.DrugRequisitionIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WardNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DrugNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QuantityRequiredDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RequisitionDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RequestedByDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReceivedByDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RequisitionStatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReceivedDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel2.SuspendLayout()
        CType(Me.Wellmeadows_HospitalDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.View_DrugReportBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1117, 775)
        Me.TableLayoutPanel1.TabIndex = 3
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DrugRequisitionIDDataGridViewTextBoxColumn, Me.WardNameDataGridViewTextBoxColumn, Me.DrugNameDataGridViewTextBoxColumn, Me.QuantityRequiredDataGridViewTextBoxColumn, Me.RequisitionDateDataGridViewTextBoxColumn, Me.RequestedByDataGridViewTextBoxColumn, Me.ReceivedByDataGridViewTextBoxColumn, Me.RequisitionStatusDataGridViewTextBoxColumn, Me.ReceivedDateDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.View_DrugReportBindingSource
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(3, 55)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(1111, 717)
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
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(1111, 46)
        Me.TableLayoutPanel2.TabIndex = 228
        '
        'Label39
        '
        Me.Label39.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label39.AutoSize = True
        Me.Label39.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label39.Location = New System.Drawing.Point(3, 4)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(115, 38)
        Me.Label39.TabIndex = 227
        Me.Label39.Text = "DRUG"
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.TextBox1.Location = New System.Drawing.Point(448, 12)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(230, 22)
        Me.TextBox1.TabIndex = 228
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(401, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 16)
        Me.Label1.TabIndex = 229
        Me.Label1.Text = "ไอดีเบิก"
        '
        'Wellmeadows_HospitalDataSet
        '
        Me.Wellmeadows_HospitalDataSet.DataSetName = "Wellmeadows_HospitalDataSet"
        Me.Wellmeadows_HospitalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'View_DrugReportBindingSource
        '
        Me.View_DrugReportBindingSource.DataMember = "View_DrugReport"
        Me.View_DrugReportBindingSource.DataSource = Me.Wellmeadows_HospitalDataSet
        '
        'View_DrugReportTableAdapter
        '
        Me.View_DrugReportTableAdapter.ClearBeforeFill = True
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
        'DrugRequisitionIDDataGridViewTextBoxColumn
        '
        Me.DrugRequisitionIDDataGridViewTextBoxColumn.DataPropertyName = "Drug_Requisition_ID"
        Me.DrugRequisitionIDDataGridViewTextBoxColumn.HeaderText = "Drug_Requisition_ID"
        Me.DrugRequisitionIDDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.DrugRequisitionIDDataGridViewTextBoxColumn.Name = "DrugRequisitionIDDataGridViewTextBoxColumn"
        Me.DrugRequisitionIDDataGridViewTextBoxColumn.Width = 125
        '
        'WardNameDataGridViewTextBoxColumn
        '
        Me.WardNameDataGridViewTextBoxColumn.DataPropertyName = "Ward_Name"
        Me.WardNameDataGridViewTextBoxColumn.HeaderText = "Ward_Name"
        Me.WardNameDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.WardNameDataGridViewTextBoxColumn.Name = "WardNameDataGridViewTextBoxColumn"
        Me.WardNameDataGridViewTextBoxColumn.Width = 125
        '
        'DrugNameDataGridViewTextBoxColumn
        '
        Me.DrugNameDataGridViewTextBoxColumn.DataPropertyName = "Drug_Name"
        Me.DrugNameDataGridViewTextBoxColumn.HeaderText = "Drug_Name"
        Me.DrugNameDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.DrugNameDataGridViewTextBoxColumn.Name = "DrugNameDataGridViewTextBoxColumn"
        Me.DrugNameDataGridViewTextBoxColumn.Width = 125
        '
        'QuantityRequiredDataGridViewTextBoxColumn
        '
        Me.QuantityRequiredDataGridViewTextBoxColumn.DataPropertyName = "Quantity_Required"
        Me.QuantityRequiredDataGridViewTextBoxColumn.HeaderText = "Quantity_Required"
        Me.QuantityRequiredDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.QuantityRequiredDataGridViewTextBoxColumn.Name = "QuantityRequiredDataGridViewTextBoxColumn"
        Me.QuantityRequiredDataGridViewTextBoxColumn.Width = 125
        '
        'RequisitionDateDataGridViewTextBoxColumn
        '
        Me.RequisitionDateDataGridViewTextBoxColumn.DataPropertyName = "Requisition_Date"
        Me.RequisitionDateDataGridViewTextBoxColumn.HeaderText = "Requisition_Date"
        Me.RequisitionDateDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.RequisitionDateDataGridViewTextBoxColumn.Name = "RequisitionDateDataGridViewTextBoxColumn"
        Me.RequisitionDateDataGridViewTextBoxColumn.Width = 125
        '
        'RequestedByDataGridViewTextBoxColumn
        '
        Me.RequestedByDataGridViewTextBoxColumn.DataPropertyName = "Requested_By"
        Me.RequestedByDataGridViewTextBoxColumn.HeaderText = "Requested_By"
        Me.RequestedByDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.RequestedByDataGridViewTextBoxColumn.Name = "RequestedByDataGridViewTextBoxColumn"
        Me.RequestedByDataGridViewTextBoxColumn.ReadOnly = True
        Me.RequestedByDataGridViewTextBoxColumn.Width = 125
        '
        'ReceivedByDataGridViewTextBoxColumn
        '
        Me.ReceivedByDataGridViewTextBoxColumn.DataPropertyName = "Received_By"
        Me.ReceivedByDataGridViewTextBoxColumn.HeaderText = "Received_By"
        Me.ReceivedByDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.ReceivedByDataGridViewTextBoxColumn.Name = "ReceivedByDataGridViewTextBoxColumn"
        Me.ReceivedByDataGridViewTextBoxColumn.ReadOnly = True
        Me.ReceivedByDataGridViewTextBoxColumn.Width = 125
        '
        'RequisitionStatusDataGridViewTextBoxColumn
        '
        Me.RequisitionStatusDataGridViewTextBoxColumn.DataPropertyName = "Requisition_Status"
        Me.RequisitionStatusDataGridViewTextBoxColumn.HeaderText = "Requisition_Status"
        Me.RequisitionStatusDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.RequisitionStatusDataGridViewTextBoxColumn.Name = "RequisitionStatusDataGridViewTextBoxColumn"
        Me.RequisitionStatusDataGridViewTextBoxColumn.Width = 125
        '
        'ReceivedDateDataGridViewTextBoxColumn
        '
        Me.ReceivedDateDataGridViewTextBoxColumn.DataPropertyName = "Received_Date"
        Me.ReceivedDateDataGridViewTextBoxColumn.HeaderText = "Received_Date"
        Me.ReceivedDateDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.ReceivedDateDataGridViewTextBoxColumn.Name = "ReceivedDateDataGridViewTextBoxColumn"
        Me.ReceivedDateDataGridViewTextBoxColumn.Width = 125
        '
        'FormDrugReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1117, 775)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "FormDrugReport"
        Me.Text = "FormDrugReport"
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        CType(Me.Wellmeadows_HospitalDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.View_DrugReportBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents Label39 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Wellmeadows_HospitalDataSet As Wellmeadows_HospitalDataSet
    Friend WithEvents View_DrugReportBindingSource As BindingSource
    Friend WithEvents View_DrugReportTableAdapter As Wellmeadows_HospitalDataSetTableAdapters.View_DrugReportTableAdapter
    Friend WithEvents TableAdapterManager As Wellmeadows_HospitalDataSetTableAdapters.TableAdapterManager
    Friend WithEvents DrugRequisitionIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents WardNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DrugNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents QuantityRequiredDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RequisitionDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RequestedByDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ReceivedByDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RequisitionStatusDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ReceivedDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
