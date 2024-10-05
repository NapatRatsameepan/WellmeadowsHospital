<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPatientMenu
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnReport = New System.Windows.Forms.Button()
        Me.btnIn = New System.Windows.Forms.Button()
        Me.btnExam = New System.Windows.Forms.Button()
        Me.btnApp = New System.Windows.Forms.Button()
        Me.btnPTmange = New System.Windows.Forms.Button()
        Me.btnPSB = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.Controls.Add(Me.btnReport, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.btnIn, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.btnExam, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnApp, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnPTmange, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnPSB, 1, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1117, 775)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'btnReport
        '
        Me.btnReport.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnReport.Location = New System.Drawing.Point(799, 471)
        Me.btnReport.Name = "btnReport"
        Me.btnReport.Size = New System.Drawing.Size(262, 219)
        Me.btnReport.TabIndex = 7
        Me.btnReport.Text = "PATIENTS REPORT"
        Me.btnReport.UseVisualStyleBackColor = True
        '
        'btnIn
        '
        Me.btnIn.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnIn.Location = New System.Drawing.Point(55, 471)
        Me.btnIn.Name = "btnIn"
        Me.btnIn.Size = New System.Drawing.Size(262, 219)
        Me.btnIn.TabIndex = 4
        Me.btnIn.Text = "IN-PATIENTS"
        Me.btnIn.UseVisualStyleBackColor = True
        '
        'btnExam
        '
        Me.btnExam.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnExam.Location = New System.Drawing.Point(799, 84)
        Me.btnExam.Name = "btnExam"
        Me.btnExam.Size = New System.Drawing.Size(262, 219)
        Me.btnExam.TabIndex = 3
        Me.btnExam.Text = "EXAMINATION"
        Me.btnExam.UseVisualStyleBackColor = True
        '
        'btnApp
        '
        Me.btnApp.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnApp.Location = New System.Drawing.Point(427, 84)
        Me.btnApp.Name = "btnApp"
        Me.btnApp.Size = New System.Drawing.Size(262, 219)
        Me.btnApp.TabIndex = 2
        Me.btnApp.Text = "APPOINTMENT"
        Me.btnApp.UseVisualStyleBackColor = True
        '
        'btnPTmange
        '
        Me.btnPTmange.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnPTmange.Location = New System.Drawing.Point(55, 84)
        Me.btnPTmange.Name = "btnPTmange"
        Me.btnPTmange.Size = New System.Drawing.Size(262, 219)
        Me.btnPTmange.TabIndex = 1
        Me.btnPTmange.Text = "PATIENTS REGISTER"
        Me.btnPTmange.UseVisualStyleBackColor = True
        '
        'btnPSB
        '
        Me.btnPSB.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnPSB.Location = New System.Drawing.Point(427, 471)
        Me.btnPSB.Name = "btnPSB"
        Me.btnPSB.Size = New System.Drawing.Size(262, 219)
        Me.btnPSB.TabIndex = 6
        Me.btnPSB.Text = "PRESCRIBE"
        Me.btnPSB.UseVisualStyleBackColor = True
        '
        'FormPatientMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1117, 775)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormPatientMenu"
        Me.Text = "FormPatientMenu"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents btnPSB As Button
    Friend WithEvents btnIn As Button
    Friend WithEvents btnExam As Button
    Friend WithEvents btnApp As Button
    Friend WithEvents btnPTmange As Button
    Friend WithEvents btnReport As Button
End Class
