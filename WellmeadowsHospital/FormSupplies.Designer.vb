<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormSupplies
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnReceive = New System.Windows.Forms.Button()
        Me.btnDrugOrder = New System.Windows.Forms.Button()
        Me.btnItemManage = New System.Windows.Forms.Button()
        Me.btnDrugManage = New System.Windows.Forms.Button()
        Me.btnItemOrder = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.btnReceive, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.btnDrugOrder, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.btnItemManage, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnDrugManage, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnItemOrder, 2, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1135, 822)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'btnReceive
        '
        Me.btnReceive.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnReceive.Location = New System.Drawing.Point(436, 507)
        Me.btnReceive.Name = "btnReceive"
        Me.btnReceive.Size = New System.Drawing.Size(262, 219)
        Me.btnReceive.TabIndex = 5
        Me.btnReceive.Text = "ITEM/DRUG RECEIVE"
        Me.btnReceive.UseVisualStyleBackColor = True
        '
        'btnDrugOrder
        '
        Me.btnDrugOrder.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnDrugOrder.Location = New System.Drawing.Point(58, 507)
        Me.btnDrugOrder.Name = "btnDrugOrder"
        Me.btnDrugOrder.Size = New System.Drawing.Size(262, 219)
        Me.btnDrugOrder.TabIndex = 4
        Me.btnDrugOrder.Text = "DRUG ORDER"
        Me.btnDrugOrder.UseVisualStyleBackColor = True
        '
        'btnItemManage
        '
        Me.btnItemManage.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnItemManage.Location = New System.Drawing.Point(58, 96)
        Me.btnItemManage.Name = "btnItemManage"
        Me.btnItemManage.Size = New System.Drawing.Size(262, 219)
        Me.btnItemManage.TabIndex = 1
        Me.btnItemManage.Text = "ITEM MANAGEMENT"
        Me.btnItemManage.UseVisualStyleBackColor = True
        '
        'btnDrugManage
        '
        Me.btnDrugManage.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnDrugManage.Location = New System.Drawing.Point(436, 96)
        Me.btnDrugManage.Name = "btnDrugManage"
        Me.btnDrugManage.Size = New System.Drawing.Size(262, 219)
        Me.btnDrugManage.TabIndex = 2
        Me.btnDrugManage.Text = "DRUG MANAGEMENT"
        Me.btnDrugManage.UseVisualStyleBackColor = True
        '
        'btnItemOrder
        '
        Me.btnItemOrder.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnItemOrder.Location = New System.Drawing.Point(814, 96)
        Me.btnItemOrder.Name = "btnItemOrder"
        Me.btnItemOrder.Size = New System.Drawing.Size(262, 219)
        Me.btnItemOrder.TabIndex = 3
        Me.btnItemOrder.Text = "ITEM ORDER"
        Me.btnItemOrder.UseVisualStyleBackColor = True
        '
        'FormSupplies
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1135, 822)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormSupplies"
        Me.Text = "FormSupplies"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents btnReceive As Button
    Friend WithEvents btnDrugOrder As Button
    Friend WithEvents btnItemOrder As Button
    Friend WithEvents btnDrugManage As Button
    Friend WithEvents btnItemManage As Button
End Class
