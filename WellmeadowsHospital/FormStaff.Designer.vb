<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormStaff
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
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SalaryScaleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Wellmeadows_HospitalDataSet = New WellmeadowsHospital.Wellmeadows_HospitalDataSet()
        Me.PositionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Salary_ScaleTableAdapter = New WellmeadowsHospital.Wellmeadows_HospitalDataSetTableAdapters.Salary_ScaleTableAdapter()
        Me.PositionTableAdapter = New WellmeadowsHospital.Wellmeadows_HospitalDataSetTableAdapters.PositionTableAdapter()
        Me.txtStaffName = New System.Windows.Forms.TextBox()
        Me.txtStaffLastName = New System.Windows.Forms.TextBox()
        Me.txtStaffAddress = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.rdoPermanent = New System.Windows.Forms.RadioButton()
        Me.rdoTemporary = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.rdoWeekly = New System.Windows.Forms.RadioButton()
        Me.rdoMonthly = New System.Windows.Forms.RadioButton()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnStaffSubmit = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtInstitute = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtTel = New System.Windows.Forms.TextBox()
        Me.cboSalaryScale = New System.Windows.Forms.ComboBox()
        Me.txtQuaName = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtNIN = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtCurrentSalary = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtPosition = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtHour = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtOrga = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Fdate = New System.Windows.Forms.DateTimePicker()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.cboPosition = New System.Windows.Forms.ComboBox()
        Me.rdoSex = New System.Windows.Forms.GroupBox()
        Me.rbtnMale = New System.Windows.Forms.RadioButton()
        Me.rbtnFemale = New System.Windows.Forms.RadioButton()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.dtpDOB = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Sdate = New System.Windows.Forms.DateTimePicker()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.dgvQualification = New System.Windows.Forms.DataGridView()
        Me.QualificationName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Institution = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Graduation = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.dgvWorkExperience = New System.Windows.Forms.DataGridView()
        Me.Organization = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StfPosition = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StartDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EndDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnExpDelete = New System.Windows.Forms.Button()
        Me.btnExpAdd = New System.Windows.Forms.Button()
        Me.GraduDate = New System.Windows.Forms.DateTimePicker()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnQuaDelete = New System.Windows.Forms.Button()
        Me.btnQuaAdd = New System.Windows.Forms.Button()
        CType(Me.SalaryScaleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Wellmeadows_HospitalDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PositionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.rdoSex.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.dgvQualification, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.dgvWorkExperience, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 205)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(0, 16)
        Me.Label5.TabIndex = 10
        '
        'SalaryScaleBindingSource
        '
        Me.SalaryScaleBindingSource.DataMember = "Salary_Scale"
        Me.SalaryScaleBindingSource.DataSource = Me.Wellmeadows_HospitalDataSet
        '
        'Wellmeadows_HospitalDataSet
        '
        Me.Wellmeadows_HospitalDataSet.DataSetName = "Wellmeadows_HospitalDataSet"
        Me.Wellmeadows_HospitalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PositionBindingSource
        '
        Me.PositionBindingSource.DataMember = "Position"
        Me.PositionBindingSource.DataSource = Me.Wellmeadows_HospitalDataSet
        '
        'Salary_ScaleTableAdapter
        '
        Me.Salary_ScaleTableAdapter.ClearBeforeFill = True
        '
        'PositionTableAdapter
        '
        Me.PositionTableAdapter.ClearBeforeFill = True
        '
        'txtStaffName
        '
        Me.txtStaffName.Location = New System.Drawing.Point(26, 93)
        Me.txtStaffName.Name = "txtStaffName"
        Me.txtStaffName.Size = New System.Drawing.Size(172, 22)
        Me.txtStaffName.TabIndex = 121
        '
        'txtStaffLastName
        '
        Me.txtStaffLastName.Location = New System.Drawing.Point(226, 93)
        Me.txtStaffLastName.Name = "txtStaffLastName"
        Me.txtStaffLastName.Size = New System.Drawing.Size(172, 22)
        Me.txtStaffLastName.TabIndex = 123
        '
        'txtStaffAddress
        '
        Me.txtStaffAddress.Location = New System.Drawing.Point(26, 209)
        Me.txtStaffAddress.Multiline = True
        Me.txtStaffAddress.Name = "txtStaffAddress"
        Me.txtStaffAddress.Size = New System.Drawing.Size(372, 69)
        Me.txtStaffAddress.TabIndex = 116
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.rdoPermanent)
        Me.GroupBox3.Controls.Add(Me.rdoTemporary)
        Me.GroupBox3.Location = New System.Drawing.Point(223, 457)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(222, 47)
        Me.GroupBox3.TabIndex = 93
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Contract Type"
        '
        'rdoPermanent
        '
        Me.rdoPermanent.AutoSize = True
        Me.rdoPermanent.Location = New System.Drawing.Point(6, 21)
        Me.rdoPermanent.Name = "rdoPermanent"
        Me.rdoPermanent.Size = New System.Drawing.Size(93, 20)
        Me.rdoPermanent.TabIndex = 4
        Me.rdoPermanent.TabStop = True
        Me.rdoPermanent.Text = "Permanent"
        Me.rdoPermanent.UseVisualStyleBackColor = True
        '
        'rdoTemporary
        '
        Me.rdoTemporary.AutoSize = True
        Me.rdoTemporary.Location = New System.Drawing.Point(117, 21)
        Me.rdoTemporary.Name = "rdoTemporary"
        Me.rdoTemporary.Size = New System.Drawing.Size(95, 20)
        Me.rdoTemporary.TabIndex = 5
        Me.rdoTemporary.TabStop = True
        Me.rdoTemporary.Text = "Temporary"
        Me.rdoTemporary.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rdoWeekly)
        Me.GroupBox2.Controls.Add(Me.rdoMonthly)
        Me.GroupBox2.Location = New System.Drawing.Point(26, 457)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(175, 47)
        Me.GroupBox2.TabIndex = 92
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Paid Type"
        '
        'rdoWeekly
        '
        Me.rdoWeekly.AutoSize = True
        Me.rdoWeekly.Location = New System.Drawing.Point(6, 21)
        Me.rdoWeekly.Name = "rdoWeekly"
        Me.rdoWeekly.Size = New System.Drawing.Size(74, 20)
        Me.rdoWeekly.TabIndex = 4
        Me.rdoWeekly.TabStop = True
        Me.rdoWeekly.Text = "Weekly"
        Me.rdoWeekly.UseVisualStyleBackColor = True
        '
        'rdoMonthly
        '
        Me.rdoMonthly.AutoSize = True
        Me.rdoMonthly.Location = New System.Drawing.Point(90, 21)
        Me.rdoMonthly.Name = "rdoMonthly"
        Me.rdoMonthly.Size = New System.Drawing.Size(74, 20)
        Me.rdoMonthly.TabIndex = 5
        Me.rdoMonthly.TabStop = True
        Me.rdoMonthly.Text = "Monthly"
        Me.rdoMonthly.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.btnStaffSubmit, 0, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(916, 1108)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(157, 44)
        Me.TableLayoutPanel1.TabIndex = 95
        '
        'btnStaffSubmit
        '
        Me.btnStaffSubmit.BackColor = System.Drawing.Color.LimeGreen
        Me.btnStaffSubmit.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnStaffSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStaffSubmit.Location = New System.Drawing.Point(10, 3)
        Me.btnStaffSubmit.Margin = New System.Windows.Forms.Padding(10, 3, 10, 3)
        Me.btnStaffSubmit.Name = "btnStaffSubmit"
        Me.btnStaffSubmit.Size = New System.Drawing.Size(137, 38)
        Me.btnStaffSubmit.TabIndex = 34
        Me.btnStaffSubmit.Text = "SUBMIT"
        Me.btnStaffSubmit.UseVisualStyleBackColor = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(223, 393)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(84, 16)
        Me.Label13.TabIndex = 91
        Me.Label13.Text = "Salary Scale"
        '
        'txtInstitute
        '
        Me.txtInstitute.Location = New System.Drawing.Point(23, 917)
        Me.txtInstitute.Name = "txtInstitute"
        Me.txtInstitute.Size = New System.Drawing.Size(175, 22)
        Me.txtInstitute.TabIndex = 108
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label11.Location = New System.Drawing.Point(19, 520)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(341, 38)
        Me.Label11.TabIndex = 96
        Me.Label11.Text = "WORK EXPERIENCE"
        '
        'txtTel
        '
        Me.txtTel.Location = New System.Drawing.Point(26, 306)
        Me.txtTel.MaxLength = 10
        Me.txtTel.Name = "txtTel"
        Me.txtTel.Size = New System.Drawing.Size(172, 22)
        Me.txtTel.TabIndex = 80
        '
        'cboSalaryScale
        '
        Me.cboSalaryScale.DataSource = Me.SalaryScaleBindingSource
        Me.cboSalaryScale.DisplayMember = "Scale_Name"
        Me.cboSalaryScale.FormattingEnabled = True
        Me.cboSalaryScale.Location = New System.Drawing.Point(223, 410)
        Me.cboSalaryScale.Name = "cboSalaryScale"
        Me.cboSalaryScale.Size = New System.Drawing.Size(172, 24)
        Me.cboSalaryScale.TabIndex = 90
        Me.cboSalaryScale.ValueMember = "Scale_ID"
        '
        'txtQuaName
        '
        Me.txtQuaName.Location = New System.Drawing.Point(23, 873)
        Me.txtQuaName.Name = "txtQuaName"
        Me.txtQuaName.Size = New System.Drawing.Size(175, 22)
        Me.txtQuaName.TabIndex = 106
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(223, 338)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(83, 16)
        Me.Label12.TabIndex = 89
        Me.Label12.Text = "Hours/Week"
        '
        'txtNIN
        '
        Me.txtNIN.Location = New System.Drawing.Point(223, 306)
        Me.txtNIN.MaxLength = 50
        Me.txtNIN.Name = "txtNIN"
        Me.txtNIN.Size = New System.Drawing.Size(172, 22)
        Me.txtNIN.TabIndex = 82
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(23, 568)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(82, 16)
        Me.Label17.TabIndex = 98
        Me.Label17.Text = "Organization"
        '
        'txtCurrentSalary
        '
        Me.txtCurrentSalary.Location = New System.Drawing.Point(26, 412)
        Me.txtCurrentSalary.Name = "txtCurrentSalary"
        Me.txtCurrentSalary.Size = New System.Drawing.Size(172, 22)
        Me.txtCurrentSalary.TabIndex = 86
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(23, 393)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(91, 16)
        Me.Label9.TabIndex = 87
        Me.Label9.Text = "Current Salary"
        '
        'txtPosition
        '
        Me.txtPosition.Location = New System.Drawing.Point(26, 631)
        Me.txtPosition.Name = "txtPosition"
        Me.txtPosition.Size = New System.Drawing.Size(175, 22)
        Me.txtPosition.TabIndex = 99
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(26, 612)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(55, 16)
        Me.Label15.TabIndex = 100
        Me.Label15.Text = "Position"
        '
        'txtHour
        '
        Me.txtHour.Location = New System.Drawing.Point(223, 357)
        Me.txtHour.Name = "txtHour"
        Me.txtHour.Size = New System.Drawing.Size(172, 22)
        Me.txtHour.TabIndex = 88
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(26, 700)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(74, 16)
        Me.Label18.TabIndex = 101
        Me.Label18.Text = "Finish Date"
        '
        'txtOrga
        '
        Me.txtOrga.Location = New System.Drawing.Point(26, 587)
        Me.txtOrga.Name = "txtOrga"
        Me.txtOrga.Size = New System.Drawing.Size(175, 22)
        Me.txtOrga.TabIndex = 97
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(23, 338)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(55, 16)
        Me.Label8.TabIndex = 85
        Me.Label8.Text = "Position"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(23, 74)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(72, 16)
        Me.Label24.TabIndex = 122
        Me.Label24.Text = "First Name"
        '
        'Fdate
        '
        Me.Fdate.Location = New System.Drawing.Point(26, 719)
        Me.Fdate.Name = "Fdate"
        Me.Fdate.Size = New System.Drawing.Size(175, 22)
        Me.Fdate.TabIndex = 102
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(223, 74)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(72, 16)
        Me.Label25.TabIndex = 124
        Me.Label25.Text = "Last Name"
        '
        'cboPosition
        '
        Me.cboPosition.DataSource = Me.PositionBindingSource
        Me.cboPosition.DisplayMember = "Position_Name"
        Me.cboPosition.FormattingEnabled = True
        Me.cboPosition.Location = New System.Drawing.Point(26, 355)
        Me.cboPosition.Name = "cboPosition"
        Me.cboPosition.Size = New System.Drawing.Size(172, 24)
        Me.cboPosition.TabIndex = 84
        Me.cboPosition.ValueMember = "Position_ID"
        '
        'rdoSex
        '
        Me.rdoSex.Controls.Add(Me.rbtnMale)
        Me.rdoSex.Controls.Add(Me.rbtnFemale)
        Me.rdoSex.Location = New System.Drawing.Point(26, 130)
        Me.rdoSex.Name = "rdoSex"
        Me.rdoSex.Size = New System.Drawing.Size(175, 47)
        Me.rdoSex.TabIndex = 120
        Me.rdoSex.TabStop = False
        Me.rdoSex.Text = "Sex"
        '
        'rbtnMale
        '
        Me.rbtnMale.AutoSize = True
        Me.rbtnMale.Location = New System.Drawing.Point(6, 21)
        Me.rbtnMale.Name = "rbtnMale"
        Me.rbtnMale.Size = New System.Drawing.Size(58, 20)
        Me.rbtnMale.TabIndex = 4
        Me.rbtnMale.TabStop = True
        Me.rbtnMale.Text = "Male"
        Me.rbtnMale.UseVisualStyleBackColor = True
        '
        'rbtnFemale
        '
        Me.rbtnFemale.AutoSize = True
        Me.rbtnFemale.Location = New System.Drawing.Point(90, 21)
        Me.rbtnFemale.Name = "rbtnFemale"
        Me.rbtnFemale.Size = New System.Drawing.Size(74, 20)
        Me.rbtnFemale.TabIndex = 5
        Me.rbtnFemale.TabStop = True
        Me.rbtnFemale.Text = "Female"
        Me.rbtnFemale.UseVisualStyleBackColor = True
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(26, 656)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(66, 16)
        Me.Label16.TabIndex = 103
        Me.Label16.Text = "Start Date"
        '
        'dtpDOB
        '
        Me.dtpDOB.Checked = False
        Me.dtpDOB.Location = New System.Drawing.Point(226, 155)
        Me.dtpDOB.Name = "dtpDOB"
        Me.dtpDOB.Size = New System.Drawing.Size(172, 22)
        Me.dtpDOB.TabIndex = 119
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(223, 287)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(30, 16)
        Me.Label7.TabIndex = 83
        Me.Label7.Text = "NIN"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(223, 130)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(79, 16)
        Me.Label20.TabIndex = 118
        Me.Label20.Text = "Date of Birth"
        '
        'Sdate
        '
        Me.Sdate.Location = New System.Drawing.Point(26, 675)
        Me.Sdate.Name = "Sdate"
        Me.Sdate.Size = New System.Drawing.Size(175, 22)
        Me.Sdate.TabIndex = 104
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(23, 190)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(58, 16)
        Me.Label14.TabIndex = 117
        Me.Label14.Text = "Address"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label23.Location = New System.Drawing.Point(16, 803)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(267, 38)
        Me.Label23.TabIndex = 105
        Me.Label23.Text = "QUALIFICATION"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label10.Location = New System.Drawing.Point(16, 18)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(359, 38)
        Me.Label10.TabIndex = 94
        Me.Label10.Text = "STAFF INFORMATION"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(23, 287)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(27, 16)
        Me.Label6.TabIndex = 81
        Me.Label6.Text = "Tel"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.dgvQualification)
        Me.Panel2.Location = New System.Drawing.Point(219, 856)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(639, 208)
        Me.Panel2.TabIndex = 115
        '
        'dgvQualification
        '
        Me.dgvQualification.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvQualification.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.QualificationName, Me.Institution, Me.Graduation})
        Me.dgvQualification.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvQualification.Location = New System.Drawing.Point(0, 0)
        Me.dgvQualification.Name = "dgvQualification"
        Me.dgvQualification.RowHeadersWidth = 51
        Me.dgvQualification.RowTemplate.Height = 24
        Me.dgvQualification.Size = New System.Drawing.Size(639, 208)
        Me.dgvQualification.TabIndex = 1
        '
        'QualificationName
        '
        Me.QualificationName.HeaderText = "Qualification Name"
        Me.QualificationName.MinimumWidth = 6
        Me.QualificationName.Name = "QualificationName"
        Me.QualificationName.Width = 125
        '
        'Institution
        '
        Me.Institution.HeaderText = "Institution"
        Me.Institution.MinimumWidth = 6
        Me.Institution.Name = "Institution"
        Me.Institution.Width = 125
        '
        'Graduation
        '
        Me.Graduation.HeaderText = "Graduation Date"
        Me.Graduation.MinimumWidth = 6
        Me.Graduation.Name = "Graduation"
        Me.Graduation.Width = 125
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(23, 854)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(120, 16)
        Me.Label22.TabIndex = 107
        Me.Label22.Text = "Qualification Name"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.dgvWorkExperience)
        Me.Panel1.Location = New System.Drawing.Point(219, 573)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(639, 208)
        Me.Panel1.TabIndex = 114
        '
        'dgvWorkExperience
        '
        Me.dgvWorkExperience.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvWorkExperience.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Organization, Me.StfPosition, Me.StartDate, Me.EndDate})
        Me.dgvWorkExperience.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvWorkExperience.Location = New System.Drawing.Point(0, 0)
        Me.dgvWorkExperience.Name = "dgvWorkExperience"
        Me.dgvWorkExperience.RowHeadersWidth = 51
        Me.dgvWorkExperience.RowTemplate.Height = 24
        Me.dgvWorkExperience.Size = New System.Drawing.Size(639, 208)
        Me.dgvWorkExperience.TabIndex = 0
        '
        'Organization
        '
        Me.Organization.HeaderText = "Organization"
        Me.Organization.MinimumWidth = 6
        Me.Organization.Name = "Organization"
        Me.Organization.Width = 125
        '
        'StfPosition
        '
        Me.StfPosition.HeaderText = "Position"
        Me.StfPosition.MinimumWidth = 6
        Me.StfPosition.Name = "StfPosition"
        Me.StfPosition.Width = 125
        '
        'StartDate
        '
        Me.StartDate.HeaderText = "Start Date"
        Me.StartDate.MinimumWidth = 6
        Me.StartDate.Name = "StartDate"
        Me.StartDate.Width = 125
        '
        'EndDate
        '
        Me.EndDate.HeaderText = "End Date"
        Me.EndDate.MinimumWidth = 6
        Me.EndDate.Name = "EndDate"
        Me.EndDate.Width = 125
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(23, 898)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(61, 16)
        Me.Label21.TabIndex = 109
        Me.Label21.Text = "Institution"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(23, 942)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(105, 16)
        Me.Label19.TabIndex = 110
        Me.Label19.Text = "Graduation Date"
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.btnExpDelete, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.btnExpAdd, 0, 0)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(26, 750)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(149, 31)
        Me.TableLayoutPanel2.TabIndex = 113
        '
        'btnExpDelete
        '
        Me.btnExpDelete.BackColor = System.Drawing.Color.Red
        Me.btnExpDelete.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnExpDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExpDelete.Location = New System.Drawing.Point(77, 3)
        Me.btnExpDelete.Name = "btnExpDelete"
        Me.btnExpDelete.Size = New System.Drawing.Size(69, 25)
        Me.btnExpDelete.TabIndex = 65
        Me.btnExpDelete.Text = "Delete"
        Me.btnExpDelete.UseVisualStyleBackColor = False
        '
        'btnExpAdd
        '
        Me.btnExpAdd.BackColor = System.Drawing.Color.LimeGreen
        Me.btnExpAdd.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnExpAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExpAdd.Location = New System.Drawing.Point(3, 3)
        Me.btnExpAdd.Name = "btnExpAdd"
        Me.btnExpAdd.Size = New System.Drawing.Size(68, 25)
        Me.btnExpAdd.TabIndex = 63
        Me.btnExpAdd.Text = "Add"
        Me.btnExpAdd.UseVisualStyleBackColor = False
        '
        'GraduDate
        '
        Me.GraduDate.Location = New System.Drawing.Point(23, 961)
        Me.GraduDate.Name = "GraduDate"
        Me.GraduDate.Size = New System.Drawing.Size(175, 22)
        Me.GraduDate.TabIndex = 111
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 2
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.btnQuaDelete, 1, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.btnQuaAdd, 0, 0)
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(23, 1033)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 1
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(149, 31)
        Me.TableLayoutPanel3.TabIndex = 112
        '
        'btnQuaDelete
        '
        Me.btnQuaDelete.BackColor = System.Drawing.Color.Red
        Me.btnQuaDelete.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnQuaDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnQuaDelete.Location = New System.Drawing.Point(77, 3)
        Me.btnQuaDelete.Name = "btnQuaDelete"
        Me.btnQuaDelete.Size = New System.Drawing.Size(69, 25)
        Me.btnQuaDelete.TabIndex = 65
        Me.btnQuaDelete.Text = "Delete"
        Me.btnQuaDelete.UseVisualStyleBackColor = False
        '
        'btnQuaAdd
        '
        Me.btnQuaAdd.BackColor = System.Drawing.Color.LimeGreen
        Me.btnQuaAdd.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnQuaAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnQuaAdd.Location = New System.Drawing.Point(3, 3)
        Me.btnQuaAdd.Name = "btnQuaAdd"
        Me.btnQuaAdd.Size = New System.Drawing.Size(68, 25)
        Me.btnQuaAdd.TabIndex = 63
        Me.btnQuaAdd.Text = "Add"
        Me.btnQuaAdd.UseVisualStyleBackColor = False
        '
        'FormStaff
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoScrollMargin = New System.Drawing.Size(10, 10)
        Me.ClientSize = New System.Drawing.Size(1156, 822)
        Me.Controls.Add(Me.txtStaffName)
        Me.Controls.Add(Me.txtStaffLastName)
        Me.Controls.Add(Me.txtStaffAddress)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txtInstitute)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtTel)
        Me.Controls.Add(Me.cboSalaryScale)
        Me.Controls.Add(Me.txtQuaName)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtNIN)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.txtCurrentSalary)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtPosition)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.txtHour)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.txtOrga)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.Fdate)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.cboPosition)
        Me.Controls.Add(Me.rdoSex)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.dtpDOB)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Sdate)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.TableLayoutPanel2)
        Me.Controls.Add(Me.GraduDate)
        Me.Controls.Add(Me.TableLayoutPanel3)
        Me.Controls.Add(Me.Label5)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormStaff"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormWard"
        CType(Me.SalaryScaleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Wellmeadows_HospitalDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PositionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.rdoSex.ResumeLayout(False)
        Me.rdoSex.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.dgvQualification, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.dgvWorkExperience, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label5 As Label
    Friend WithEvents Wellmeadows_HospitalDataSet As Wellmeadows_HospitalDataSet
    Friend WithEvents SalaryScaleBindingSource As BindingSource
    Friend WithEvents Salary_ScaleTableAdapter As Wellmeadows_HospitalDataSetTableAdapters.Salary_ScaleTableAdapter
    Friend WithEvents PositionBindingSource As BindingSource
    Friend WithEvents PositionTableAdapter As Wellmeadows_HospitalDataSetTableAdapters.PositionTableAdapter
    Friend WithEvents txtStaffName As TextBox
    Friend WithEvents txtStaffLastName As TextBox
    Friend WithEvents txtStaffAddress As TextBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents rdoPermanent As RadioButton
    Friend WithEvents rdoTemporary As RadioButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents rdoWeekly As RadioButton
    Friend WithEvents rdoMonthly As RadioButton
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents btnStaffSubmit As Button
    Friend WithEvents Label13 As Label
    Friend WithEvents txtInstitute As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txtTel As TextBox
    Friend WithEvents cboSalaryScale As ComboBox
    Friend WithEvents txtQuaName As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txtNIN As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents txtCurrentSalary As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtPosition As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents txtHour As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents txtOrga As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents Fdate As DateTimePicker
    Friend WithEvents Label25 As Label
    Friend WithEvents cboPosition As ComboBox
    Friend WithEvents rdoSex As GroupBox
    Friend WithEvents rbtnMale As RadioButton
    Friend WithEvents rbtnFemale As RadioButton
    Friend WithEvents Label16 As Label
    Friend WithEvents dtpDOB As DateTimePicker
    Friend WithEvents Label7 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Sdate As DateTimePicker
    Friend WithEvents Label14 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents dgvQualification As DataGridView
    Friend WithEvents QualificationName As DataGridViewTextBoxColumn
    Friend WithEvents Institution As DataGridViewTextBoxColumn
    Friend WithEvents Graduation As DataGridViewTextBoxColumn
    Friend WithEvents Label22 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents dgvWorkExperience As DataGridView
    Friend WithEvents Organization As DataGridViewTextBoxColumn
    Friend WithEvents StfPosition As DataGridViewTextBoxColumn
    Friend WithEvents StartDate As DataGridViewTextBoxColumn
    Friend WithEvents EndDate As DataGridViewTextBoxColumn
    Friend WithEvents Label21 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents btnExpDelete As Button
    Friend WithEvents btnExpAdd As Button
    Friend WithEvents GraduDate As DateTimePicker
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents btnQuaDelete As Button
    Friend WithEvents btnQuaAdd As Button
End Class
