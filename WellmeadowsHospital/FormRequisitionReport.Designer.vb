<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormRequisitionReport
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
        Me.btnItemReport = New System.Windows.Forms.Button()
        Me.btnDrugReport = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.btnDrugReport, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnItemReport, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(979, 573)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'btnItemReport
        '
        Me.btnItemReport.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnItemReport.Location = New System.Drawing.Point(113, 177)
        Me.btnItemReport.Name = "btnItemReport"
        Me.btnItemReport.Size = New System.Drawing.Size(262, 219)
        Me.btnItemReport.TabIndex = 5
        Me.btnItemReport.Text = "ITEM REPORT"
        Me.btnItemReport.UseVisualStyleBackColor = True
        '
        'btnDrugReport
        '
        Me.btnDrugReport.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnDrugReport.Location = New System.Drawing.Point(603, 177)
        Me.btnDrugReport.Name = "btnDrugReport"
        Me.btnDrugReport.Size = New System.Drawing.Size(262, 219)
        Me.btnDrugReport.TabIndex = 6
        Me.btnDrugReport.Text = "DRUG REPORT"
        Me.btnDrugReport.UseVisualStyleBackColor = True
        '
        'FormRequisitionReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(979, 573)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormRequisitionReport"
        Me.Text = "FormRequisitionReport"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents btnDrugReport As Button
    Friend WithEvents btnItemReport As Button
End Class
