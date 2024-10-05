<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormAppoinment
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
        Me.btnStaffSearch = New System.Windows.Forms.Button()
        Me.btnPatientSearch = New System.Windows.Forms.Button()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.txtAppDetail = New System.Windows.Forms.TextBox()
        Me.txtPatient = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.dtpExam = New System.Windows.Forms.DateTimePicker()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.txtStaffName = New System.Windows.Forms.TextBox()
        Me.txtPatientName = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblStaffID = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnStaffSearch
        '
        Me.btnStaffSearch.Location = New System.Drawing.Point(807, 134)
        Me.btnStaffSearch.Name = "btnStaffSearch"
        Me.btnStaffSearch.Size = New System.Drawing.Size(32, 23)
        Me.btnStaffSearch.TabIndex = 203
        Me.btnStaffSearch.Text = "..."
        Me.btnStaffSearch.UseVisualStyleBackColor = True
        '
        'btnPatientSearch
        '
        Me.btnPatientSearch.Location = New System.Drawing.Point(465, 134)
        Me.btnPatientSearch.Name = "btnPatientSearch"
        Me.btnPatientSearch.Size = New System.Drawing.Size(32, 23)
        Me.btnPatientSearch.TabIndex = 202
        Me.btnPatientSearch.Text = "..."
        Me.btnPatientSearch.UseVisualStyleBackColor = True
        '
        'btnSubmit
        '
        Me.btnSubmit.BackColor = System.Drawing.Color.LimeGreen
        Me.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSubmit.Location = New System.Drawing.Point(770, 701)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(137, 41)
        Me.btnSubmit.TabIndex = 201
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = False
        '
        'txtAppDetail
        '
        Me.txtAppDetail.Location = New System.Drawing.Point(271, 341)
        Me.txtAppDetail.Multiline = True
        Me.txtAppDetail.Name = "txtAppDetail"
        Me.txtAppDetail.Size = New System.Drawing.Size(530, 316)
        Me.txtAppDetail.TabIndex = 200
        '
        'txtPatient
        '
        Me.txtPatient.Location = New System.Drawing.Point(271, 134)
        Me.txtPatient.Name = "txtPatient"
        Me.txtPatient.Size = New System.Drawing.Size(188, 22)
        Me.txtPatient.TabIndex = 196
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(268, 115)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(64, 16)
        Me.Label24.TabIndex = 197
        Me.Label24.Text = "Patient ID"
        '
        'dtpExam
        '
        Me.dtpExam.Location = New System.Drawing.Point(271, 258)
        Me.dtpExam.Name = "dtpExam"
        Me.dtpExam.Size = New System.Drawing.Size(200, 22)
        Me.dtpExam.TabIndex = 195
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label29.Location = New System.Drawing.Point(264, 300)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(399, 38)
        Me.Label29.TabIndex = 194
        Me.Label29.Text = "APPOINTMENT DETAILS"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(268, 230)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(73, 16)
        Me.Label28.TabIndex = 193
        Me.Label28.Text = "Exam Date"
        '
        'txtStaffName
        '
        Me.txtStaffName.Location = New System.Drawing.Point(613, 135)
        Me.txtStaffName.Name = "txtStaffName"
        Me.txtStaffName.Size = New System.Drawing.Size(188, 22)
        Me.txtStaffName.TabIndex = 191
        '
        'txtPatientName
        '
        Me.txtPatientName.Location = New System.Drawing.Point(271, 194)
        Me.txtPatientName.Name = "txtPatientName"
        Me.txtPatientName.Size = New System.Drawing.Size(188, 22)
        Me.txtPatientName.TabIndex = 189
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(610, 115)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(73, 16)
        Me.Label21.TabIndex = 192
        Me.Label21.Text = "Staff Name"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(268, 175)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(88, 16)
        Me.Label13.TabIndex = 190
        Me.Label13.Text = "Patient Name"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label5.Location = New System.Drawing.Point(405, 37)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(254, 38)
        Me.Label5.TabIndex = 188
        Me.Label5.Text = "APPOINTMENT"
        '
        'lblStaffID
        '
        Me.lblStaffID.AutoSize = True
        Me.lblStaffID.Location = New System.Drawing.Point(721, 59)
        Me.lblStaffID.Name = "lblStaffID"
        Me.lblStaffID.Size = New System.Drawing.Size(49, 16)
        Me.lblStaffID.TabIndex = 204
        Me.lblStaffID.Text = "Staff ID"
        Me.lblStaffID.Visible = False
        '
        'FormAppoinment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1117, 775)
        Me.Controls.Add(Me.lblStaffID)
        Me.Controls.Add(Me.btnStaffSearch)
        Me.Controls.Add(Me.btnPatientSearch)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.txtAppDetail)
        Me.Controls.Add(Me.txtPatient)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.dtpExam)
        Me.Controls.Add(Me.Label29)
        Me.Controls.Add(Me.Label28)
        Me.Controls.Add(Me.txtStaffName)
        Me.Controls.Add(Me.txtPatientName)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label5)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormAppoinment"
        Me.Text = "FormAppoinment"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnStaffSearch As Button
    Friend WithEvents btnPatientSearch As Button
    Friend WithEvents btnSubmit As Button
    Friend WithEvents txtAppDetail As TextBox
    Friend WithEvents txtPatient As TextBox
    Friend WithEvents Label24 As Label
    Friend WithEvents dtpExam As DateTimePicker
    Friend WithEvents Label29 As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents txtStaffName As TextBox
    Friend WithEvents txtPatientName As TextBox
    Friend WithEvents Label21 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblStaffID As Label
End Class
