<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormRequisition
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
        Me.btnReceive = New System.Windows.Forms.Button()
        Me.btnItemReuisition = New System.Windows.Forms.Button()
        Me.btnDrugReuisition = New System.Windows.Forms.Button()
        Me.btnStatus = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.Controls.Add(Me.btnReport, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.btnReceive, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnItemReuisition, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnDrugReuisition, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnStatus, 0, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1000, 700)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'btnReport
        '
        Me.btnReport.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnReport.Location = New System.Drawing.Point(368, 415)
        Me.btnReport.Name = "btnReport"
        Me.btnReport.Size = New System.Drawing.Size(262, 219)
        Me.btnReport.TabIndex = 4
        Me.btnReport.Text = "REQUISITION REPORT"
        Me.btnReport.UseVisualStyleBackColor = True
        '
        'btnReceive
        '
        Me.btnReceive.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnReceive.Location = New System.Drawing.Point(702, 65)
        Me.btnReceive.Name = "btnReceive"
        Me.btnReceive.Size = New System.Drawing.Size(262, 219)
        Me.btnReceive.TabIndex = 2
        Me.btnReceive.Text = "RECEIVE"
        Me.btnReceive.UseVisualStyleBackColor = True
        '
        'btnItemReuisition
        '
        Me.btnItemReuisition.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnItemReuisition.Location = New System.Drawing.Point(35, 65)
        Me.btnItemReuisition.Name = "btnItemReuisition"
        Me.btnItemReuisition.Size = New System.Drawing.Size(262, 219)
        Me.btnItemReuisition.TabIndex = 0
        Me.btnItemReuisition.Text = "ITEM REQUISITION"
        Me.btnItemReuisition.UseVisualStyleBackColor = True
        '
        'btnDrugReuisition
        '
        Me.btnDrugReuisition.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnDrugReuisition.Location = New System.Drawing.Point(368, 65)
        Me.btnDrugReuisition.Name = "btnDrugReuisition"
        Me.btnDrugReuisition.Size = New System.Drawing.Size(262, 219)
        Me.btnDrugReuisition.TabIndex = 3
        Me.btnDrugReuisition.Text = "DRUG REQUISITION"
        Me.btnDrugReuisition.UseVisualStyleBackColor = True
        '
        'btnStatus
        '
        Me.btnStatus.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnStatus.Location = New System.Drawing.Point(35, 415)
        Me.btnStatus.Name = "btnStatus"
        Me.btnStatus.Size = New System.Drawing.Size(262, 219)
        Me.btnStatus.TabIndex = 1
        Me.btnStatus.Text = "REQUISITION STATUS"
        Me.btnStatus.UseVisualStyleBackColor = True
        '
        'FormRequisition
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1000, 700)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormRequisition"
        Me.Text = "FormRequisition"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents btnItemReuisition As Button
    Friend WithEvents btnDrugReuisition As Button
    Friend WithEvents btnReceive As Button
    Friend WithEvents btnStatus As Button
    Friend WithEvents btnReport As Button
End Class
