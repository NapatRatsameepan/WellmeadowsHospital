<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormDashboardItem
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
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.ComboBoxYear = New System.Windows.Forms.ComboBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.View_ItemOrder2BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Wellmeadows_HospitalDataSet = New WellmeadowsHospital.Wellmeadows_HospitalDataSet()
        Me.ComboBoxMonth = New System.Windows.Forms.ComboBox()
        Me.View_ItemOrder2TableAdapter = New WellmeadowsHospital.Wellmeadows_HospitalDataSetTableAdapters.View_ItemOrder2TableAdapter()
        Me.TableAdapterManager = New WellmeadowsHospital.Wellmeadows_HospitalDataSetTableAdapters.TableAdapterManager()
        Me.ItemIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemOrderDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OrderMonthDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OrderYearDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemOrderQuantityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemPriceTotalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemOrderDetailIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LabelTotal = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.View_ItemOrder2BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Wellmeadows_HospitalDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "WellmeadowsHospital.ReportItemOrder.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(12, 110)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(749, 700)
        Me.ReportViewer1.TabIndex = 0
        '
        'ComboBoxYear
        '
        Me.ComboBoxYear.FormattingEnabled = True
        Me.ComboBoxYear.Location = New System.Drawing.Point(12, 70)
        Me.ComboBoxYear.Name = "ComboBoxYear"
        Me.ComboBoxYear.Size = New System.Drawing.Size(208, 24)
        Me.ComboBoxYear.TabIndex = 1
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ItemIDDataGridViewTextBoxColumn, Me.ItemNameDataGridViewTextBoxColumn, Me.ItemOrderDateDataGridViewTextBoxColumn, Me.OrderMonthDataGridViewTextBoxColumn, Me.OrderYearDataGridViewTextBoxColumn, Me.ItemOrderQuantityDataGridViewTextBoxColumn, Me.ItemPriceTotalDataGridViewTextBoxColumn, Me.ItemOrderDetailIDDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.View_ItemOrder2BindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(767, 110)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(356, 652)
        Me.DataGridView1.TabIndex = 2
        '
        'View_ItemOrder2BindingSource
        '
        Me.View_ItemOrder2BindingSource.DataMember = "View_ItemOrder2"
        Me.View_ItemOrder2BindingSource.DataSource = Me.Wellmeadows_HospitalDataSet
        '
        'Wellmeadows_HospitalDataSet
        '
        Me.Wellmeadows_HospitalDataSet.DataSetName = "Wellmeadows_HospitalDataSet"
        Me.Wellmeadows_HospitalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ComboBoxMonth
        '
        Me.ComboBoxMonth.FormattingEnabled = True
        Me.ComboBoxMonth.Location = New System.Drawing.Point(767, 70)
        Me.ComboBoxMonth.Name = "ComboBoxMonth"
        Me.ComboBoxMonth.Size = New System.Drawing.Size(208, 24)
        Me.ComboBoxMonth.TabIndex = 3
        '
        'View_ItemOrder2TableAdapter
        '
        Me.View_ItemOrder2TableAdapter.ClearBeforeFill = True
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
        'ItemIDDataGridViewTextBoxColumn
        '
        Me.ItemIDDataGridViewTextBoxColumn.DataPropertyName = "Item_ID"
        Me.ItemIDDataGridViewTextBoxColumn.HeaderText = "Item_ID"
        Me.ItemIDDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.ItemIDDataGridViewTextBoxColumn.Name = "ItemIDDataGridViewTextBoxColumn"
        Me.ItemIDDataGridViewTextBoxColumn.Width = 125
        '
        'ItemNameDataGridViewTextBoxColumn
        '
        Me.ItemNameDataGridViewTextBoxColumn.DataPropertyName = "Item_Name"
        Me.ItemNameDataGridViewTextBoxColumn.HeaderText = "Item_Name"
        Me.ItemNameDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.ItemNameDataGridViewTextBoxColumn.Name = "ItemNameDataGridViewTextBoxColumn"
        Me.ItemNameDataGridViewTextBoxColumn.Width = 125
        '
        'ItemOrderDateDataGridViewTextBoxColumn
        '
        Me.ItemOrderDateDataGridViewTextBoxColumn.DataPropertyName = "Item_Order_Date"
        Me.ItemOrderDateDataGridViewTextBoxColumn.HeaderText = "Item_Order_Date"
        Me.ItemOrderDateDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.ItemOrderDateDataGridViewTextBoxColumn.Name = "ItemOrderDateDataGridViewTextBoxColumn"
        Me.ItemOrderDateDataGridViewTextBoxColumn.Width = 125
        '
        'OrderMonthDataGridViewTextBoxColumn
        '
        Me.OrderMonthDataGridViewTextBoxColumn.DataPropertyName = "Order_Month"
        Me.OrderMonthDataGridViewTextBoxColumn.HeaderText = "Order_Month"
        Me.OrderMonthDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.OrderMonthDataGridViewTextBoxColumn.Name = "OrderMonthDataGridViewTextBoxColumn"
        Me.OrderMonthDataGridViewTextBoxColumn.ReadOnly = True
        Me.OrderMonthDataGridViewTextBoxColumn.Width = 125
        '
        'OrderYearDataGridViewTextBoxColumn
        '
        Me.OrderYearDataGridViewTextBoxColumn.DataPropertyName = "Order_Year"
        Me.OrderYearDataGridViewTextBoxColumn.HeaderText = "Order_Year"
        Me.OrderYearDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.OrderYearDataGridViewTextBoxColumn.Name = "OrderYearDataGridViewTextBoxColumn"
        Me.OrderYearDataGridViewTextBoxColumn.ReadOnly = True
        Me.OrderYearDataGridViewTextBoxColumn.Width = 125
        '
        'ItemOrderQuantityDataGridViewTextBoxColumn
        '
        Me.ItemOrderQuantityDataGridViewTextBoxColumn.DataPropertyName = "Item_Order_Quantity"
        Me.ItemOrderQuantityDataGridViewTextBoxColumn.HeaderText = "Item_Order_Quantity"
        Me.ItemOrderQuantityDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.ItemOrderQuantityDataGridViewTextBoxColumn.Name = "ItemOrderQuantityDataGridViewTextBoxColumn"
        Me.ItemOrderQuantityDataGridViewTextBoxColumn.Width = 125
        '
        'ItemPriceTotalDataGridViewTextBoxColumn
        '
        Me.ItemPriceTotalDataGridViewTextBoxColumn.DataPropertyName = "Item_Price_Total"
        Me.ItemPriceTotalDataGridViewTextBoxColumn.HeaderText = "Item_Price_Total"
        Me.ItemPriceTotalDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.ItemPriceTotalDataGridViewTextBoxColumn.Name = "ItemPriceTotalDataGridViewTextBoxColumn"
        Me.ItemPriceTotalDataGridViewTextBoxColumn.Width = 125
        '
        'ItemOrderDetailIDDataGridViewTextBoxColumn
        '
        Me.ItemOrderDetailIDDataGridViewTextBoxColumn.DataPropertyName = "Item_Order_Detail_ID"
        Me.ItemOrderDetailIDDataGridViewTextBoxColumn.HeaderText = "Item_Order_Detail_ID"
        Me.ItemOrderDetailIDDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.ItemOrderDetailIDDataGridViewTextBoxColumn.Name = "ItemOrderDetailIDDataGridViewTextBoxColumn"
        Me.ItemOrderDetailIDDataGridViewTextBoxColumn.Width = 125
        '
        'LabelTotal
        '
        Me.LabelTotal.AutoSize = True
        Me.LabelTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.LabelTotal.Location = New System.Drawing.Point(767, 780)
        Me.LabelTotal.Name = "LabelTotal"
        Me.LabelTotal.Size = New System.Drawing.Size(65, 20)
        Me.LabelTotal.TabIndex = 4
        Me.LabelTotal.Text = "Label1"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(317, 33)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "ITEM ORDER REPORT"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 20)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Year"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.Location = New System.Drawing.Point(763, 47)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 20)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Month"
        '
        'FormDashboardItem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1135, 822)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LabelTotal)
        Me.Controls.Add(Me.ComboBoxMonth)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.ComboBoxYear)
        Me.Controls.Add(Me.ReportViewer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormDashboardItem"
        Me.Text = "FormDashboardItem"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.View_ItemOrder2BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Wellmeadows_HospitalDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents ComboBoxYear As ComboBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Wellmeadows_HospitalDataSet As Wellmeadows_HospitalDataSet
    Friend WithEvents ComboBoxMonth As ComboBox
    Friend WithEvents View_ItemOrder2BindingSource As BindingSource
    Friend WithEvents View_ItemOrder2TableAdapter As Wellmeadows_HospitalDataSetTableAdapters.View_ItemOrder2TableAdapter
    Friend WithEvents TableAdapterManager As Wellmeadows_HospitalDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ItemIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ItemNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ItemOrderDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents OrderMonthDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents OrderYearDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ItemOrderQuantityDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ItemPriceTotalDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ItemOrderDetailIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LabelTotal As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
