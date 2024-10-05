<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormDashboardMenu
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
        Me.btnPatient = New System.Windows.Forms.Button()
        Me.btnStaff = New System.Windows.Forms.Button()
        Me.btnItem = New System.Windows.Forms.Button()
        Me.btnDrug = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.btnDrug, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.btnItem, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.btnStaff, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnPatient, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1117, 775)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'btnPatient
        '
        Me.btnPatient.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnPatient.Location = New System.Drawing.Point(148, 84)
        Me.btnPatient.Name = "btnPatient"
        Me.btnPatient.Size = New System.Drawing.Size(262, 219)
        Me.btnPatient.TabIndex = 0
        Me.btnPatient.Text = "PATIENTS"
        Me.btnPatient.UseVisualStyleBackColor = True
        '
        'btnStaff
        '
        Me.btnStaff.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnStaff.Location = New System.Drawing.Point(706, 84)
        Me.btnStaff.Name = "btnStaff"
        Me.btnStaff.Size = New System.Drawing.Size(262, 219)
        Me.btnStaff.TabIndex = 1
        Me.btnStaff.Text = "STAFF"
        Me.btnStaff.UseVisualStyleBackColor = True
        '
        'btnItem
        '
        Me.btnItem.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnItem.Location = New System.Drawing.Point(148, 471)
        Me.btnItem.Name = "btnItem"
        Me.btnItem.Size = New System.Drawing.Size(262, 219)
        Me.btnItem.TabIndex = 2
        Me.btnItem.Text = "ITEM"
        Me.btnItem.UseVisualStyleBackColor = True
        '
        'btnDrug
        '
        Me.btnDrug.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnDrug.Location = New System.Drawing.Point(706, 471)
        Me.btnDrug.Name = "btnDrug"
        Me.btnDrug.Size = New System.Drawing.Size(262, 219)
        Me.btnDrug.TabIndex = 3
        Me.btnDrug.Text = "DRUG"
        Me.btnDrug.UseVisualStyleBackColor = True
        '
        'FormDashboardMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1117, 775)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormDashboardMenu"
        Me.Text = "FormDashboardMenu"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents btnDrug As Button
    Friend WithEvents btnItem As Button
    Friend WithEvents btnStaff As Button
    Friend WithEvents btnPatient As Button
End Class
