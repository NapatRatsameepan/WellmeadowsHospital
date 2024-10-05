<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormWard
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.BedIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PatientsIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WardIDDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BEDLISTBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Wellmeadows_HospitalDataSet = New WellmeadowsHospital.Wellmeadows_HospitalDataSet()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BED_LISTTableAdapter = New WellmeadowsHospital.Wellmeadows_HospitalDataSetTableAdapters.BED_LISTTableAdapter()
        Me.WellmeadowsHospitalDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.WardIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WardNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LocationDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ExtTelDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WardBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TableAdapterManager = New WellmeadowsHospital.Wellmeadows_HospitalDataSetTableAdapters.TableAdapterManager()
        Me.WardTableAdapter = New WellmeadowsHospital.Wellmeadows_HospitalDataSetTableAdapters.WardTableAdapter()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BEDLISTBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Wellmeadows_HospitalDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WellmeadowsHospitalDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.TableLayoutPanel5.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WardBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.DataGridView2)
        Me.Panel1.Location = New System.Drawing.Point(3, 108)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(506, 594)
        Me.Panel1.TabIndex = 106
        '
        'DataGridView2
        '
        Me.DataGridView2.AutoGenerateColumns = False
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.BedIDDataGridViewTextBoxColumn, Me.PatientsIDDataGridViewTextBoxColumn, Me.WardIDDataGridViewTextBoxColumn1})
        Me.DataGridView2.DataSource = Me.BEDLISTBindingSource
        Me.DataGridView2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView2.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.RowHeadersWidth = 51
        Me.DataGridView2.RowTemplate.Height = 24
        Me.DataGridView2.Size = New System.Drawing.Size(506, 594)
        Me.DataGridView2.TabIndex = 1
        '
        'BedIDDataGridViewTextBoxColumn
        '
        Me.BedIDDataGridViewTextBoxColumn.DataPropertyName = "Bed_ID"
        Me.BedIDDataGridViewTextBoxColumn.HeaderText = "Bed_ID"
        Me.BedIDDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.BedIDDataGridViewTextBoxColumn.Name = "BedIDDataGridViewTextBoxColumn"
        Me.BedIDDataGridViewTextBoxColumn.Width = 125
        '
        'PatientsIDDataGridViewTextBoxColumn
        '
        Me.PatientsIDDataGridViewTextBoxColumn.DataPropertyName = "Patients_ID"
        Me.PatientsIDDataGridViewTextBoxColumn.HeaderText = "Patients_ID"
        Me.PatientsIDDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.PatientsIDDataGridViewTextBoxColumn.Name = "PatientsIDDataGridViewTextBoxColumn"
        Me.PatientsIDDataGridViewTextBoxColumn.Width = 125
        '
        'WardIDDataGridViewTextBoxColumn1
        '
        Me.WardIDDataGridViewTextBoxColumn1.DataPropertyName = "Ward_ID"
        Me.WardIDDataGridViewTextBoxColumn1.HeaderText = "Ward_ID"
        Me.WardIDDataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.WardIDDataGridViewTextBoxColumn1.Name = "WardIDDataGridViewTextBoxColumn1"
        Me.WardIDDataGridViewTextBoxColumn1.Width = 125
        '
        'BEDLISTBindingSource
        '
        Me.BEDLISTBindingSource.DataMember = "BED_LIST"
        Me.BEDLISTBindingSource.DataSource = Me.Wellmeadows_HospitalDataSet
        '
        'Wellmeadows_HospitalDataSet
        '
        Me.Wellmeadows_HospitalDataSet.DataSetName = "Wellmeadows_HospitalDataSet"
        Me.Wellmeadows_HospitalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.Location = New System.Drawing.Point(158, 7)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(195, 38)
        Me.Label2.TabIndex = 109
        Me.Label2.Text = "WARD LIST"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BED_LISTTableAdapter
        '
        Me.BED_LISTTableAdapter.ClearBeforeFill = True
        '
        'WellmeadowsHospitalDataSetBindingSource
        '
        Me.WellmeadowsHospitalDataSetBindingSource.DataSource = Me.Wellmeadows_HospitalDataSet
        Me.WellmeadowsHospitalDataSetBindingSource.Position = 0
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(500, 43)
        Me.TableLayoutPanel2.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(169, 2)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(162, 38)
        Me.Label1.TabIndex = 112
        Me.Label1.Text = "BED LIST"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 72.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.TextBox1, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 52)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(500, 44)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.TextBox1.Location = New System.Drawing.Point(143, 11)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(203, 22)
        Me.TextBox1.TabIndex = 110
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(81, 14)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 16)
        Me.Label3.TabIndex = 111
        Me.Label3.Text = "Ward ID"
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 1
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.Panel1, 0, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.TableLayoutPanel4, 0, 0)
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(596, 45)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 2
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.89362!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85.10638!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(512, 705)
        Me.TableLayoutPanel3.TabIndex = 112
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.ColumnCount = 1
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel4.Controls.Add(Me.TableLayoutPanel1, 0, 1)
        Me.TableLayoutPanel4.Controls.Add(Me.TableLayoutPanel2, 0, 0)
        Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 2
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(506, 99)
        Me.TableLayoutPanel4.TabIndex = 107
        '
        'TableLayoutPanel5
        '
        Me.TableLayoutPanel5.ColumnCount = 1
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel5.Controls.Add(Me.Label2, 0, 0)
        Me.TableLayoutPanel5.Controls.Add(Me.DataGridView1, 0, 1)
        Me.TableLayoutPanel5.Location = New System.Drawing.Point(44, 45)
        Me.TableLayoutPanel5.Name = "TableLayoutPanel5"
        Me.TableLayoutPanel5.RowCount = 2
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.375886!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 92.62411!))
        Me.TableLayoutPanel5.Size = New System.Drawing.Size(512, 705)
        Me.TableLayoutPanel5.TabIndex = 113
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.WardIDDataGridViewTextBoxColumn, Me.WardNameDataGridViewTextBoxColumn, Me.LocationDataGridViewTextBoxColumn, Me.ExtTelDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.WardBindingSource
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(3, 55)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(506, 647)
        Me.DataGridView1.TabIndex = 110
        '
        'WardIDDataGridViewTextBoxColumn
        '
        Me.WardIDDataGridViewTextBoxColumn.DataPropertyName = "Ward_ID"
        Me.WardIDDataGridViewTextBoxColumn.HeaderText = "Ward_ID"
        Me.WardIDDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.WardIDDataGridViewTextBoxColumn.Name = "WardIDDataGridViewTextBoxColumn"
        Me.WardIDDataGridViewTextBoxColumn.ReadOnly = True
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
        'LocationDataGridViewTextBoxColumn
        '
        Me.LocationDataGridViewTextBoxColumn.DataPropertyName = "Location"
        Me.LocationDataGridViewTextBoxColumn.HeaderText = "Location"
        Me.LocationDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.LocationDataGridViewTextBoxColumn.Name = "LocationDataGridViewTextBoxColumn"
        Me.LocationDataGridViewTextBoxColumn.Width = 125
        '
        'ExtTelDataGridViewTextBoxColumn
        '
        Me.ExtTelDataGridViewTextBoxColumn.DataPropertyName = "Ext_Tel"
        Me.ExtTelDataGridViewTextBoxColumn.HeaderText = "Ext_Tel"
        Me.ExtTelDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.ExtTelDataGridViewTextBoxColumn.Name = "ExtTelDataGridViewTextBoxColumn"
        Me.ExtTelDataGridViewTextBoxColumn.Width = 125
        '
        'WardBindingSource
        '
        Me.WardBindingSource.DataMember = "Ward"
        Me.WardBindingSource.DataSource = Me.Wellmeadows_HospitalDataSet
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
        Me.TableAdapterManager.QualificationTableAdapter = Nothing
        Me.TableAdapterManager.Salary_ScaleTableAdapter = Nothing
        Me.TableAdapterManager.StaffTableAdapter = Nothing
        Me.TableAdapterManager.SuppliersTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = WellmeadowsHospital.Wellmeadows_HospitalDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.Ward_Allocation_OPDTableAdapter = Nothing
        Me.TableAdapterManager.WardTableAdapter = Me.WardTableAdapter
        Me.TableAdapterManager.Work_ExperienceTableAdapter = Nothing
        '
        'WardTableAdapter
        '
        Me.WardTableAdapter.ClearBeforeFill = True
        '
        'FormWard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1135, 822)
        Me.Controls.Add(Me.TableLayoutPanel5)
        Me.Controls.Add(Me.TableLayoutPanel3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormWard"
        Me.Text = "FormStaff"
        Me.Panel1.ResumeLayout(False)
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BEDLISTBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Wellmeadows_HospitalDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WellmeadowsHospitalDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.TableLayoutPanel5.ResumeLayout(False)
        Me.TableLayoutPanel5.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WardBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents Wellmeadows_HospitalDataSet As Wellmeadows_HospitalDataSet
    Friend WithEvents BEDLISTBindingSource As BindingSource
    Friend WithEvents BED_LISTTableAdapter As Wellmeadows_HospitalDataSetTableAdapters.BED_LISTTableAdapter
    Friend WithEvents BedIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PatientsIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents WardIDDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents WellmeadowsHospitalDataSetBindingSource As BindingSource
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TableLayoutPanel5 As TableLayoutPanel
    Friend WithEvents TableAdapterManager As Wellmeadows_HospitalDataSetTableAdapters.TableAdapterManager
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents WardTableAdapter As Wellmeadows_HospitalDataSetTableAdapters.WardTableAdapter
    Friend WithEvents WardBindingSource As BindingSource
    Friend WithEvents WardIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents WardNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LocationDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ExtTelDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
