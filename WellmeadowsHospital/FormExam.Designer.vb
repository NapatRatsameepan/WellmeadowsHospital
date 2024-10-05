<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormExam
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
        Me.btnExamSearch = New System.Windows.Forms.Button()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.txtExam = New System.Windows.Forms.TextBox()
        Me.txtPatientID = New System.Windows.Forms.TextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.txtStaffName = New System.Windows.Forms.TextBox()
        Me.txtPatientName = New System.Windows.Forms.TextBox()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.rbtnIP = New System.Windows.Forms.RadioButton()
        Me.rbtnOPD = New System.Windows.Forms.RadioButton()
        Me.lblStaffID = New System.Windows.Forms.Label()
        Me.AppID = New System.Windows.Forms.Label()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnExamSearch
        '
        Me.btnExamSearch.Location = New System.Drawing.Point(494, 134)
        Me.btnExamSearch.Name = "btnExamSearch"
        Me.btnExamSearch.Size = New System.Drawing.Size(32, 23)
        Me.btnExamSearch.TabIndex = 217
        Me.btnExamSearch.Text = "..."
        Me.btnExamSearch.UseVisualStyleBackColor = True
        '
        'btnSubmit
        '
        Me.btnSubmit.BackColor = System.Drawing.Color.LimeGreen
        Me.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSubmit.Location = New System.Drawing.Point(799, 701)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(137, 41)
        Me.btnSubmit.TabIndex = 216
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = False
        '
        'txtExam
        '
        Me.txtExam.Location = New System.Drawing.Point(300, 354)
        Me.txtExam.Multiline = True
        Me.txtExam.Name = "txtExam"
        Me.txtExam.Size = New System.Drawing.Size(530, 316)
        Me.txtExam.TabIndex = 215
        '
        'txtPatientID
        '
        Me.txtPatientID.Location = New System.Drawing.Point(300, 134)
        Me.txtPatientID.Name = "txtPatientID"
        Me.txtPatientID.Size = New System.Drawing.Size(188, 22)
        Me.txtPatientID.TabIndex = 211
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(297, 115)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(64, 16)
        Me.Label26.TabIndex = 212
        Me.Label26.Text = "Patient ID"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label27.Location = New System.Drawing.Point(293, 313)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(379, 38)
        Me.Label27.TabIndex = 210
        Me.Label27.Text = "EXAMINATON DETAILS"
        '
        'txtStaffName
        '
        Me.txtStaffName.Location = New System.Drawing.Point(642, 135)
        Me.txtStaffName.Name = "txtStaffName"
        Me.txtStaffName.Size = New System.Drawing.Size(188, 22)
        Me.txtStaffName.TabIndex = 208
        '
        'txtPatientName
        '
        Me.txtPatientName.Location = New System.Drawing.Point(300, 194)
        Me.txtPatientName.Name = "txtPatientName"
        Me.txtPatientName.Size = New System.Drawing.Size(188, 22)
        Me.txtPatientName.TabIndex = 206
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Location = New System.Drawing.Point(639, 116)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(73, 16)
        Me.Label31.TabIndex = 209
        Me.Label31.Text = "Staff Name"
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Location = New System.Drawing.Point(297, 175)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(88, 16)
        Me.Label32.TabIndex = 207
        Me.Label32.Text = "Patient Name"
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label33.Location = New System.Drawing.Point(454, 47)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(234, 38)
        Me.Label33.TabIndex = 205
        Me.Label33.Text = "EXAMINATON"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.rbtnIP)
        Me.GroupBox3.Controls.Add(Me.rbtnOPD)
        Me.GroupBox3.Location = New System.Drawing.Point(300, 222)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(166, 75)
        Me.GroupBox3.TabIndex = 204
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Patient Type"
        '
        'rbtnIP
        '
        Me.rbtnIP.AutoSize = True
        Me.rbtnIP.Location = New System.Drawing.Point(6, 21)
        Me.rbtnIP.Name = "rbtnIP"
        Me.rbtnIP.Size = New System.Drawing.Size(83, 20)
        Me.rbtnIP.TabIndex = 4
        Me.rbtnIP.TabStop = True
        Me.rbtnIP.Text = "In-Patient"
        Me.rbtnIP.UseVisualStyleBackColor = True
        '
        'rbtnOPD
        '
        Me.rbtnOPD.AutoSize = True
        Me.rbtnOPD.Location = New System.Drawing.Point(6, 47)
        Me.rbtnOPD.Name = "rbtnOPD"
        Me.rbtnOPD.Size = New System.Drawing.Size(93, 20)
        Me.rbtnOPD.TabIndex = 5
        Me.rbtnOPD.TabStop = True
        Me.rbtnOPD.Text = "Out-Patient"
        Me.rbtnOPD.UseVisualStyleBackColor = True
        '
        'lblStaffID
        '
        Me.lblStaffID.AutoSize = True
        Me.lblStaffID.Location = New System.Drawing.Point(639, 200)
        Me.lblStaffID.Name = "lblStaffID"
        Me.lblStaffID.Size = New System.Drawing.Size(49, 16)
        Me.lblStaffID.TabIndex = 218
        Me.lblStaffID.Text = "Staff ID"
        Me.lblStaffID.Visible = False
        '
        'AppID
        '
        Me.AppID.AutoSize = True
        Me.AppID.Location = New System.Drawing.Point(640, 234)
        Me.AppID.Name = "AppID"
        Me.AppID.Size = New System.Drawing.Size(98, 16)
        Me.AppID.TabIndex = 219
        Me.AppID.Text = "Appointment ID"
        Me.AppID.Visible = False
        '
        'FormExam
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1117, 775)
        Me.Controls.Add(Me.AppID)
        Me.Controls.Add(Me.lblStaffID)
        Me.Controls.Add(Me.btnExamSearch)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.txtExam)
        Me.Controls.Add(Me.txtPatientID)
        Me.Controls.Add(Me.Label26)
        Me.Controls.Add(Me.Label27)
        Me.Controls.Add(Me.txtStaffName)
        Me.Controls.Add(Me.txtPatientName)
        Me.Controls.Add(Me.Label31)
        Me.Controls.Add(Me.Label32)
        Me.Controls.Add(Me.Label33)
        Me.Controls.Add(Me.GroupBox3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormExam"
        Me.Text = "FormExam"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnExamSearch As Button
    Friend WithEvents btnSubmit As Button
    Friend WithEvents txtExam As TextBox
    Friend WithEvents txtPatientID As TextBox
    Friend WithEvents Label26 As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents txtStaffName As TextBox
    Friend WithEvents txtPatientName As TextBox
    Friend WithEvents Label31 As Label
    Friend WithEvents Label32 As Label
    Friend WithEvents Label33 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents rbtnIP As RadioButton
    Friend WithEvents rbtnOPD As RadioButton
    Friend WithEvents lblStaffID As Label
    Friend WithEvents AppID As Label
End Class
