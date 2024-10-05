<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPatientManage
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
        Me.txtNPaddress = New System.Windows.Forms.TextBox()
        Me.txtNPRelationship = New System.Windows.Forms.TextBox()
        Me.txtNPtel = New System.Windows.Forms.TextBox()
        Me.txtNLname = New System.Windows.Forms.TextBox()
        Me.txtNPname = New System.Windows.Forms.TextBox()
        Me.txtPtel = New System.Windows.Forms.TextBox()
        Me.txtPaddress = New System.Windows.Forms.TextBox()
        Me.txtPLname = New System.Windows.Forms.TextBox()
        Me.txtPname = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnPdelete = New System.Windows.Forms.Button()
        Me.btnPadd = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.dgvNextOfKin = New System.Windows.Forms.DataGridView()
        Me.PName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PLastname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Ptel = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PRelationship = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PAddress = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.rbtnWidowed = New System.Windows.Forms.RadioButton()
        Me.rbtnSeperated = New System.Windows.Forms.RadioButton()
        Me.rbtnDivorced = New System.Windows.Forms.RadioButton()
        Me.rbtnMarried = New System.Windows.Forms.RadioButton()
        Me.rbtnSingle = New System.Windows.Forms.RadioButton()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbtnMale = New System.Windows.Forms.RadioButton()
        Me.rbtnFemale = New System.Windows.Forms.RadioButton()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PDOB = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtLDAddress = New System.Windows.Forms.TextBox()
        Me.txtLDTEL = New System.Windows.Forms.TextBox()
        Me.txtLDLName = New System.Windows.Forms.TextBox()
        Me.txtLDFName = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnPSubmit = New System.Windows.Forms.Button()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.btnLD = New System.Windows.Forms.Button()
        Me.txtClinicID = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.dgvNextOfKin, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtNPaddress
        '
        Me.txtNPaddress.Location = New System.Drawing.Point(25, 604)
        Me.txtNPaddress.Multiline = True
        Me.txtNPaddress.Name = "txtNPaddress"
        Me.txtNPaddress.Size = New System.Drawing.Size(354, 72)
        Me.txtNPaddress.TabIndex = 210
        '
        'txtNPRelationship
        '
        Me.txtNPRelationship.Location = New System.Drawing.Point(207, 559)
        Me.txtNPRelationship.Name = "txtNPRelationship"
        Me.txtNPRelationship.Size = New System.Drawing.Size(175, 22)
        Me.txtNPRelationship.TabIndex = 208
        '
        'txtNPtel
        '
        Me.txtNPtel.Location = New System.Drawing.Point(25, 559)
        Me.txtNPtel.MaxLength = 10
        Me.txtNPtel.Name = "txtNPtel"
        Me.txtNPtel.Size = New System.Drawing.Size(175, 22)
        Me.txtNPtel.TabIndex = 206
        '
        'txtNLname
        '
        Me.txtNLname.Location = New System.Drawing.Point(207, 510)
        Me.txtNLname.Name = "txtNLname"
        Me.txtNLname.Size = New System.Drawing.Size(172, 22)
        Me.txtNLname.TabIndex = 203
        '
        'txtNPname
        '
        Me.txtNPname.Location = New System.Drawing.Point(26, 510)
        Me.txtNPname.Name = "txtNPname"
        Me.txtNPname.Size = New System.Drawing.Size(175, 22)
        Me.txtNPname.TabIndex = 201
        '
        'txtPtel
        '
        Me.txtPtel.Location = New System.Drawing.Point(229, 283)
        Me.txtPtel.MaxLength = 10
        Me.txtPtel.Name = "txtPtel"
        Me.txtPtel.Size = New System.Drawing.Size(168, 22)
        Me.txtPtel.TabIndex = 192
        '
        'txtPaddress
        '
        Me.txtPaddress.Location = New System.Drawing.Point(20, 131)
        Me.txtPaddress.Multiline = True
        Me.txtPaddress.Name = "txtPaddress"
        Me.txtPaddress.Size = New System.Drawing.Size(409, 72)
        Me.txtPaddress.TabIndex = 189
        '
        'txtPLname
        '
        Me.txtPLname.Location = New System.Drawing.Point(241, 80)
        Me.txtPLname.Name = "txtPLname"
        Me.txtPLname.Size = New System.Drawing.Size(188, 22)
        Me.txtPLname.TabIndex = 186
        '
        'txtPname
        '
        Me.txtPname.Location = New System.Drawing.Point(20, 80)
        Me.txtPname.Name = "txtPname"
        Me.txtPname.Size = New System.Drawing.Size(188, 22)
        Me.txtPname.TabIndex = 184
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(25, 585)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(58, 16)
        Me.Label9.TabIndex = 211
        Me.Label9.Text = "Address"
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.btnPdelete, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.btnPadd, 0, 0)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(28, 682)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(149, 31)
        Me.TableLayoutPanel2.TabIndex = 209
        '
        'btnPdelete
        '
        Me.btnPdelete.BackColor = System.Drawing.Color.Red
        Me.btnPdelete.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnPdelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPdelete.Location = New System.Drawing.Point(77, 3)
        Me.btnPdelete.Name = "btnPdelete"
        Me.btnPdelete.Size = New System.Drawing.Size(69, 25)
        Me.btnPdelete.TabIndex = 65
        Me.btnPdelete.Text = "Delete"
        Me.btnPdelete.UseVisualStyleBackColor = False
        '
        'btnPadd
        '
        Me.btnPadd.BackColor = System.Drawing.Color.LimeGreen
        Me.btnPadd.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnPadd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPadd.Location = New System.Drawing.Point(3, 3)
        Me.btnPadd.Name = "btnPadd"
        Me.btnPadd.Size = New System.Drawing.Size(68, 25)
        Me.btnPadd.TabIndex = 63
        Me.btnPadd.Text = "Add"
        Me.btnPadd.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(207, 540)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(82, 16)
        Me.Label8.TabIndex = 207
        Me.Label8.Text = "Relationship"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(25, 540)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(27, 16)
        Me.Label7.TabIndex = 205
        Me.Label7.Text = "Tel"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(207, 491)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(72, 16)
        Me.Label15.TabIndex = 204
        Me.Label15.Text = "Last Name"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(23, 491)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(72, 16)
        Me.Label17.TabIndex = 202
        Me.Label17.Text = "First Name"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.dgvNextOfKin)
        Me.Panel1.Location = New System.Drawing.Point(467, 485)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(606, 222)
        Me.Panel1.TabIndex = 200
        '
        'dgvNextOfKin
        '
        Me.dgvNextOfKin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvNextOfKin.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PName, Me.PLastname, Me.Ptel, Me.PRelationship, Me.PAddress})
        Me.dgvNextOfKin.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvNextOfKin.Location = New System.Drawing.Point(0, 0)
        Me.dgvNextOfKin.Name = "dgvNextOfKin"
        Me.dgvNextOfKin.RowHeadersWidth = 51
        Me.dgvNextOfKin.RowTemplate.Height = 24
        Me.dgvNextOfKin.Size = New System.Drawing.Size(606, 222)
        Me.dgvNextOfKin.TabIndex = 0
        '
        'PName
        '
        Me.PName.HeaderText = "Name"
        Me.PName.MinimumWidth = 6
        Me.PName.Name = "PName"
        Me.PName.Width = 125
        '
        'PLastname
        '
        Me.PLastname.HeaderText = "Lastname"
        Me.PLastname.MinimumWidth = 6
        Me.PLastname.Name = "PLastname"
        Me.PLastname.Width = 125
        '
        'Ptel
        '
        Me.Ptel.HeaderText = "Tel"
        Me.Ptel.MinimumWidth = 6
        Me.Ptel.Name = "Ptel"
        Me.Ptel.Width = 125
        '
        'PRelationship
        '
        Me.PRelationship.HeaderText = "Relationship"
        Me.PRelationship.MinimumWidth = 6
        Me.PRelationship.Name = "PRelationship"
        Me.PRelationship.Width = 125
        '
        'PAddress
        '
        Me.PAddress.HeaderText = "Address"
        Me.PAddress.MinimumWidth = 6
        Me.PAddress.Name = "PAddress"
        Me.PAddress.Width = 125
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label11.Location = New System.Drawing.Point(16, 447)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(245, 38)
        Me.Label11.TabIndex = 199
        Me.Label11.Text = "NEXT OF KINS"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(504, 513)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(0, 16)
        Me.Label14.TabIndex = 198
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rbtnWidowed)
        Me.GroupBox2.Controls.Add(Me.rbtnSeperated)
        Me.GroupBox2.Controls.Add(Me.rbtnDivorced)
        Me.GroupBox2.Controls.Add(Me.rbtnMarried)
        Me.GroupBox2.Controls.Add(Me.rbtnSingle)
        Me.GroupBox2.Location = New System.Drawing.Point(20, 274)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(165, 160)
        Me.GroupBox2.TabIndex = 197
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Martial Status"
        '
        'rbtnWidowed
        '
        Me.rbtnWidowed.AutoSize = True
        Me.rbtnWidowed.Location = New System.Drawing.Point(6, 126)
        Me.rbtnWidowed.Name = "rbtnWidowed"
        Me.rbtnWidowed.Size = New System.Drawing.Size(85, 20)
        Me.rbtnWidowed.TabIndex = 9
        Me.rbtnWidowed.TabStop = True
        Me.rbtnWidowed.Text = "Widowed"
        Me.rbtnWidowed.UseVisualStyleBackColor = True
        '
        'rbtnSeperated
        '
        Me.rbtnSeperated.AutoSize = True
        Me.rbtnSeperated.Location = New System.Drawing.Point(6, 100)
        Me.rbtnSeperated.Name = "rbtnSeperated"
        Me.rbtnSeperated.Size = New System.Drawing.Size(92, 20)
        Me.rbtnSeperated.TabIndex = 8
        Me.rbtnSeperated.TabStop = True
        Me.rbtnSeperated.Text = "Separated"
        Me.rbtnSeperated.UseVisualStyleBackColor = True
        '
        'rbtnDivorced
        '
        Me.rbtnDivorced.AutoSize = True
        Me.rbtnDivorced.Location = New System.Drawing.Point(6, 74)
        Me.rbtnDivorced.Name = "rbtnDivorced"
        Me.rbtnDivorced.Size = New System.Drawing.Size(83, 20)
        Me.rbtnDivorced.TabIndex = 7
        Me.rbtnDivorced.TabStop = True
        Me.rbtnDivorced.Text = "Divorced"
        Me.rbtnDivorced.UseVisualStyleBackColor = True
        '
        'rbtnMarried
        '
        Me.rbtnMarried.AutoSize = True
        Me.rbtnMarried.Location = New System.Drawing.Point(6, 48)
        Me.rbtnMarried.Name = "rbtnMarried"
        Me.rbtnMarried.Size = New System.Drawing.Size(74, 20)
        Me.rbtnMarried.TabIndex = 6
        Me.rbtnMarried.TabStop = True
        Me.rbtnMarried.Text = "Married"
        Me.rbtnMarried.UseVisualStyleBackColor = True
        '
        'rbtnSingle
        '
        Me.rbtnSingle.AutoSize = True
        Me.rbtnSingle.Location = New System.Drawing.Point(6, 21)
        Me.rbtnSingle.Name = "rbtnSingle"
        Me.rbtnSingle.Size = New System.Drawing.Size(66, 20)
        Me.rbtnSingle.TabIndex = 4
        Me.rbtnSingle.TabStop = True
        Me.rbtnSingle.Text = "Single"
        Me.rbtnSingle.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label10.Location = New System.Drawing.Point(13, 12)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(415, 38)
        Me.Label10.TabIndex = 195
        Me.Label10.Text = "PATIENTS INFORMATION"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbtnMale)
        Me.GroupBox1.Controls.Add(Me.rbtnFemale)
        Me.GroupBox1.Location = New System.Drawing.Point(20, 210)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(165, 47)
        Me.GroupBox1.TabIndex = 194
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Sex"
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
        Me.rbtnFemale.Location = New System.Drawing.Point(83, 21)
        Me.rbtnFemale.Name = "rbtnFemale"
        Me.rbtnFemale.Size = New System.Drawing.Size(74, 20)
        Me.rbtnFemale.TabIndex = 5
        Me.rbtnFemale.TabStop = True
        Me.rbtnFemale.Text = "Female"
        Me.rbtnFemale.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(226, 264)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(27, 16)
        Me.Label6.TabIndex = 193
        Me.Label6.Text = "Tel"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(226, 210)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 16)
        Me.Label4.TabIndex = 191
        Me.Label4.Text = "Date of Birth"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(20, 112)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 16)
        Me.Label3.TabIndex = 190
        Me.Label3.Text = "Address"
        '
        'PDOB
        '
        Me.PDOB.Location = New System.Drawing.Point(229, 229)
        Me.PDOB.Name = "PDOB"
        Me.PDOB.Size = New System.Drawing.Size(168, 22)
        Me.PDOB.TabIndex = 188
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(240, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 16)
        Me.Label2.TabIndex = 187
        Me.Label2.Text = "Last Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 61)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 16)
        Me.Label1.TabIndex = 185
        Me.Label1.Text = "First Name"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(25, 924)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(58, 16)
        Me.Label12.TabIndex = 221
        Me.Label12.Text = "Address"
        '
        'txtLDAddress
        '
        Me.txtLDAddress.Location = New System.Drawing.Point(25, 943)
        Me.txtLDAddress.Multiline = True
        Me.txtLDAddress.Name = "txtLDAddress"
        Me.txtLDAddress.Size = New System.Drawing.Size(354, 72)
        Me.txtLDAddress.TabIndex = 220
        '
        'txtLDTEL
        '
        Me.txtLDTEL.Location = New System.Drawing.Point(25, 898)
        Me.txtLDTEL.Name = "txtLDTEL"
        Me.txtLDTEL.Size = New System.Drawing.Size(175, 22)
        Me.txtLDTEL.TabIndex = 219
        '
        'txtLDLName
        '
        Me.txtLDLName.Location = New System.Drawing.Point(207, 849)
        Me.txtLDLName.Name = "txtLDLName"
        Me.txtLDLName.Size = New System.Drawing.Size(172, 22)
        Me.txtLDLName.TabIndex = 216
        '
        'txtLDFName
        '
        Me.txtLDFName.Location = New System.Drawing.Point(26, 849)
        Me.txtLDFName.Name = "txtLDFName"
        Me.txtLDFName.Size = New System.Drawing.Size(175, 22)
        Me.txtLDFName.TabIndex = 214
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(25, 879)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(27, 16)
        Me.Label16.TabIndex = 218
        Me.Label16.Text = "Tel"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(204, 827)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(72, 16)
        Me.Label18.TabIndex = 217
        Me.Label18.Text = "Last Name"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(25, 830)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(72, 16)
        Me.Label19.TabIndex = 215
        Me.Label19.Text = "First Name"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.btnPSubmit, 0, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(939, 1012)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(134, 44)
        Me.TableLayoutPanel1.TabIndex = 213
        '
        'btnPSubmit
        '
        Me.btnPSubmit.BackColor = System.Drawing.Color.LimeGreen
        Me.btnPSubmit.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnPSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPSubmit.Location = New System.Drawing.Point(10, 3)
        Me.btnPSubmit.Margin = New System.Windows.Forms.Padding(10, 3, 10, 3)
        Me.btnPSubmit.Name = "btnPSubmit"
        Me.btnPSubmit.Size = New System.Drawing.Size(114, 38)
        Me.btnPSubmit.TabIndex = 34
        Me.btnPSubmit.Text = "ADD"
        Me.btnPSubmit.UseVisualStyleBackColor = False
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label23.Location = New System.Drawing.Point(19, 739)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(278, 38)
        Me.Label23.TabIndex = 212
        Me.Label23.Text = "LOCAL DOCTOR"
        '
        'btnLD
        '
        Me.btnLD.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnLD.Location = New System.Drawing.Point(207, 799)
        Me.btnLD.Name = "btnLD"
        Me.btnLD.Size = New System.Drawing.Size(44, 23)
        Me.btnLD.TabIndex = 222
        Me.btnLD.Text = "..."
        Me.btnLD.UseVisualStyleBackColor = True
        '
        'txtClinicID
        '
        Me.txtClinicID.Location = New System.Drawing.Point(26, 800)
        Me.txtClinicID.Name = "txtClinicID"
        Me.txtClinicID.Size = New System.Drawing.Size(175, 22)
        Me.txtClinicID.TabIndex = 223
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(25, 781)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 16)
        Me.Label5.TabIndex = 224
        Me.Label5.Text = "Clinic ID"
        '
        'FormPatientManage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoScrollMargin = New System.Drawing.Size(10, 10)
        Me.ClientSize = New System.Drawing.Size(1156, 822)
        Me.Controls.Add(Me.txtClinicID)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnLD)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtLDAddress)
        Me.Controls.Add(Me.txtLDTEL)
        Me.Controls.Add(Me.txtLDLName)
        Me.Controls.Add(Me.txtLDFName)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.txtNPaddress)
        Me.Controls.Add(Me.txtNPRelationship)
        Me.Controls.Add(Me.txtNPtel)
        Me.Controls.Add(Me.txtNLname)
        Me.Controls.Add(Me.txtNPname)
        Me.Controls.Add(Me.txtPtel)
        Me.Controls.Add(Me.txtPaddress)
        Me.Controls.Add(Me.txtPLname)
        Me.Controls.Add(Me.txtPname)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.TableLayoutPanel2)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PDOB)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormPatientManage"
        Me.Text = "FormPatientManage"
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.dgvNextOfKin, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtNPaddress As TextBox
    Friend WithEvents txtNPRelationship As TextBox
    Friend WithEvents txtNPtel As TextBox
    Friend WithEvents txtNLname As TextBox
    Friend WithEvents txtNPname As TextBox
    Friend WithEvents txtPtel As TextBox
    Friend WithEvents txtPaddress As TextBox
    Friend WithEvents txtPLname As TextBox
    Friend WithEvents txtPname As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents btnPdelete As Button
    Friend WithEvents btnPadd As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents dgvNextOfKin As DataGridView
    Friend WithEvents Label11 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents rbtnWidowed As RadioButton
    Friend WithEvents rbtnSeperated As RadioButton
    Friend WithEvents rbtnDivorced As RadioButton
    Friend WithEvents rbtnMarried As RadioButton
    Friend WithEvents rbtnSingle As RadioButton
    Friend WithEvents Label10 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rbtnMale As RadioButton
    Friend WithEvents rbtnFemale As RadioButton
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents PDOB As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents txtLDAddress As TextBox
    Friend WithEvents txtLDTEL As TextBox
    Friend WithEvents txtLDLName As TextBox
    Friend WithEvents txtLDFName As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents btnPSubmit As Button
    Friend WithEvents Label23 As Label
    Friend WithEvents PName As DataGridViewTextBoxColumn
    Friend WithEvents PLastname As DataGridViewTextBoxColumn
    Friend WithEvents Ptel As DataGridViewTextBoxColumn
    Friend WithEvents PRelationship As DataGridViewTextBoxColumn
    Friend WithEvents PAddress As DataGridViewTextBoxColumn
    Friend WithEvents btnLD As Button
    Friend WithEvents txtClinicID As TextBox
    Friend WithEvents Label5 As Label
End Class
