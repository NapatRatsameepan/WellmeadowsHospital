<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormStaffMenu
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
        Me.btnAlloReport = New System.Windows.Forms.Button()
        Me.btnStaffList = New System.Windows.Forms.Button()
        Me.btnStfmange = New System.Windows.Forms.Button()
        Me.btnStfallo = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.Controls.Add(Me.btnAlloReport, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.btnStaffList, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnStfmange, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnStfallo, 2, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(800, 450)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'btnAlloReport
        '
        Me.btnAlloReport.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnAlloReport.Location = New System.Drawing.Point(3, 228)
        Me.btnAlloReport.Name = "btnAlloReport"
        Me.btnAlloReport.Size = New System.Drawing.Size(260, 219)
        Me.btnAlloReport.TabIndex = 3
        Me.btnAlloReport.Text = "ALLOCATION REPORT"
        Me.btnAlloReport.UseVisualStyleBackColor = True
        '
        'btnStaffList
        '
        Me.btnStaffList.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnStaffList.Location = New System.Drawing.Point(269, 3)
        Me.btnStaffList.Name = "btnStaffList"
        Me.btnStaffList.Size = New System.Drawing.Size(260, 219)
        Me.btnStaffList.TabIndex = 2
        Me.btnStaffList.Text = "STAFF LIST"
        Me.btnStaffList.UseVisualStyleBackColor = True
        '
        'btnStfmange
        '
        Me.btnStfmange.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnStfmange.Location = New System.Drawing.Point(3, 3)
        Me.btnStfmange.Name = "btnStfmange"
        Me.btnStfmange.Size = New System.Drawing.Size(260, 219)
        Me.btnStfmange.TabIndex = 0
        Me.btnStfmange.Text = "STAFF REGISTER"
        Me.btnStfmange.UseVisualStyleBackColor = True
        '
        'btnStfallo
        '
        Me.btnStfallo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnStfallo.Location = New System.Drawing.Point(535, 3)
        Me.btnStfallo.Name = "btnStfallo"
        Me.btnStfallo.Size = New System.Drawing.Size(262, 219)
        Me.btnStfallo.TabIndex = 1
        Me.btnStfallo.Text = "STAFF ALLOCATION"
        Me.btnStfallo.UseVisualStyleBackColor = True
        '
        'FormStaffMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormStaffMenu"
        Me.Text = "FormWardMenu"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents btnStfmange As Button
    Friend WithEvents btnStfallo As Button
    Friend WithEvents btnStaffList As Button
    Friend WithEvents btnAlloReport As Button
End Class
