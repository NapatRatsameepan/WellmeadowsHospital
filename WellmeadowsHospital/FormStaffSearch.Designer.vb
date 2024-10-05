<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormStaffSearch
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
        Me.Label33 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ไอดDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ชอDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.นามสกลDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.เพศDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.เบอรโทรDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ตำแหนงDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.อายDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Staff_App2BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Wellmeadows_HospitalDataSet = New WellmeadowsHospital.Wellmeadows_HospitalDataSet()
        Me.Staff_App2TableAdapter = New WellmeadowsHospital.Wellmeadows_HospitalDataSetTableAdapters.Staff_App2TableAdapter()
        Me.TableAdapterManager = New WellmeadowsHospital.Wellmeadows_HospitalDataSetTableAdapters.TableAdapterManager()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Staff_App2BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Wellmeadows_HospitalDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label33.Location = New System.Drawing.Point(12, 9)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(121, 38)
        Me.Label33.TabIndex = 206
        Me.Label33.Text = "STAFF"
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ไอดDataGridViewTextBoxColumn, Me.ชอDataGridViewTextBoxColumn, Me.นามสกลDataGridViewTextBoxColumn, Me.เพศDataGridViewTextBoxColumn, Me.เบอรโทรDataGridViewTextBoxColumn, Me.ตำแหนงDataGridViewTextBoxColumn, Me.อายDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.Staff_App2BindingSource
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DataGridView1.Location = New System.Drawing.Point(0, 61)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(836, 666)
        Me.DataGridView1.TabIndex = 207
        '
        'ไอดDataGridViewTextBoxColumn
        '
        Me.ไอดDataGridViewTextBoxColumn.DataPropertyName = "ไอดี"
        Me.ไอดDataGridViewTextBoxColumn.HeaderText = "ไอดี"
        Me.ไอดDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.ไอดDataGridViewTextBoxColumn.Name = "ไอดDataGridViewTextBoxColumn"
        Me.ไอดDataGridViewTextBoxColumn.Width = 125
        '
        'ชอDataGridViewTextBoxColumn
        '
        Me.ชอDataGridViewTextBoxColumn.DataPropertyName = "ชื่อ"
        Me.ชอDataGridViewTextBoxColumn.HeaderText = "ชื่อ"
        Me.ชอDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.ชอDataGridViewTextBoxColumn.Name = "ชอDataGridViewTextBoxColumn"
        Me.ชอDataGridViewTextBoxColumn.Width = 125
        '
        'นามสกลDataGridViewTextBoxColumn
        '
        Me.นามสกลDataGridViewTextBoxColumn.DataPropertyName = "นามสกุล"
        Me.นามสกลDataGridViewTextBoxColumn.HeaderText = "นามสกุล"
        Me.นามสกลDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.นามสกลDataGridViewTextBoxColumn.Name = "นามสกลDataGridViewTextBoxColumn"
        Me.นามสกลDataGridViewTextBoxColumn.Width = 125
        '
        'เพศDataGridViewTextBoxColumn
        '
        Me.เพศDataGridViewTextBoxColumn.DataPropertyName = "เพศ"
        Me.เพศDataGridViewTextBoxColumn.HeaderText = "เพศ"
        Me.เพศDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.เพศDataGridViewTextBoxColumn.Name = "เพศDataGridViewTextBoxColumn"
        Me.เพศDataGridViewTextBoxColumn.Width = 125
        '
        'เบอรโทรDataGridViewTextBoxColumn
        '
        Me.เบอรโทรDataGridViewTextBoxColumn.DataPropertyName = "เบอร์โทร"
        Me.เบอรโทรDataGridViewTextBoxColumn.HeaderText = "เบอร์โทร"
        Me.เบอรโทรDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.เบอรโทรDataGridViewTextBoxColumn.Name = "เบอรโทรDataGridViewTextBoxColumn"
        Me.เบอรโทรDataGridViewTextBoxColumn.Width = 125
        '
        'ตำแหนงDataGridViewTextBoxColumn
        '
        Me.ตำแหนงDataGridViewTextBoxColumn.DataPropertyName = "ตำแหน่ง"
        Me.ตำแหนงDataGridViewTextBoxColumn.HeaderText = "ตำแหน่ง"
        Me.ตำแหนงDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.ตำแหนงDataGridViewTextBoxColumn.Name = "ตำแหนงDataGridViewTextBoxColumn"
        Me.ตำแหนงDataGridViewTextBoxColumn.Width = 125
        '
        'อายDataGridViewTextBoxColumn
        '
        Me.อายDataGridViewTextBoxColumn.DataPropertyName = "อายุ"
        Me.อายDataGridViewTextBoxColumn.HeaderText = "อายุ"
        Me.อายDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.อายDataGridViewTextBoxColumn.Name = "อายDataGridViewTextBoxColumn"
        Me.อายDataGridViewTextBoxColumn.ReadOnly = True
        Me.อายDataGridViewTextBoxColumn.Width = 125
        '
        'Staff_App2BindingSource
        '
        Me.Staff_App2BindingSource.DataMember = "Staff_App2"
        Me.Staff_App2BindingSource.DataSource = Me.Wellmeadows_HospitalDataSet
        '
        'Wellmeadows_HospitalDataSet
        '
        Me.Wellmeadows_HospitalDataSet.DataSetName = "Wellmeadows_HospitalDataSet"
        Me.Wellmeadows_HospitalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Staff_App2TableAdapter
        '
        Me.Staff_App2TableAdapter.ClearBeforeFill = True
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
        'FormStaffSearch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(836, 727)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label33)
        Me.Name = "FormStaffSearch"
        Me.Text = "FormStaffSearch"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Staff_App2BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Wellmeadows_HospitalDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label33 As Label
    Friend WithEvents Wellmeadows_HospitalDataSet As Wellmeadows_HospitalDataSet
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Staff_App2BindingSource As BindingSource
    Friend WithEvents Staff_App2TableAdapter As Wellmeadows_HospitalDataSetTableAdapters.Staff_App2TableAdapter
    Friend WithEvents TableAdapterManager As Wellmeadows_HospitalDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ไอดDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ชอDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents นามสกลDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents เพศDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents เบอรโทรDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ตำแหนงDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents อายDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
