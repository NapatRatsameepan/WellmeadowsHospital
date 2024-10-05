<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPatientReport
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
        Me.btnPSB = New System.Windows.Forms.Button()
        Me.btnOPD = New System.Windows.Forms.Button()
        Me.btnIPReport = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.btnPSB, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.btnOPD, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnIPReport, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1135, 822)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'btnPSB
        '
        Me.btnPSB.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnPSB.Location = New System.Drawing.Point(152, 507)
        Me.btnPSB.Name = "btnPSB"
        Me.btnPSB.Size = New System.Drawing.Size(262, 219)
        Me.btnPSB.TabIndex = 4
        Me.btnPSB.Text = "PRESCRIBE REPORT"
        Me.btnPSB.UseVisualStyleBackColor = True
        '
        'btnOPD
        '
        Me.btnOPD.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnOPD.Location = New System.Drawing.Point(720, 96)
        Me.btnOPD.Name = "btnOPD"
        Me.btnOPD.Size = New System.Drawing.Size(262, 219)
        Me.btnOPD.TabIndex = 3
        Me.btnOPD.Text = "OUT-PATIENTS"
        Me.btnOPD.UseVisualStyleBackColor = True
        '
        'btnIPReport
        '
        Me.btnIPReport.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnIPReport.Location = New System.Drawing.Point(152, 96)
        Me.btnIPReport.Name = "btnIPReport"
        Me.btnIPReport.Size = New System.Drawing.Size(262, 219)
        Me.btnIPReport.TabIndex = 2
        Me.btnIPReport.Text = "WAITING LIST REPORT"
        Me.btnIPReport.UseVisualStyleBackColor = True
        '
        'FormPatientReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1135, 822)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormPatientReport"
        Me.Text = "FormPatientReport"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents btnOPD As Button
    Friend WithEvents btnIPReport As Button
    Friend WithEvents btnPSB As Button
End Class
