<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMenu))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnHome = New System.Windows.Forms.Button()
        Me.btnDashboard = New System.Windows.Forms.Button()
        Me.btnRequisition = New System.Windows.Forms.Button()
        Me.btnSuppliers = New System.Windows.Forms.Button()
        Me.btnSupplies = New System.Windows.Forms.Button()
        Me.btnPatients = New System.Windows.Forms.Button()
        Me.btnStaff = New System.Windows.Forms.Button()
        Me.btnWard = New System.Windows.Forms.Button()
        Me.pnlMain = New System.Windows.Forms.Panel()
        Me.AxWindowsMediaPlayer1 = New AxWMPLib.AxWindowsMediaPlayer()
        Me.Panel1.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.pnlMain.SuspendLayout()
        CType(Me.AxWindowsMediaPlayer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panel1.Controls.Add(Me.TableLayoutPanel3)
        Me.Panel1.Controls.Add(Me.TableLayoutPanel2)
        Me.Panel1.Controls.Add(Me.TableLayoutPanel1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(264, 822)
        Me.Panel1.TabIndex = 0
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 1
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.Button1, 0, 0)
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(3, 672)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 1
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(255, 80)
        Me.TableLayoutPanel3.TabIndex = 2
        '
        'Button1
        '
        Me.Button1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button1.Location = New System.Drawing.Point(42, 14)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(171, 52)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Feeling Good"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.btnLogout, 0, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 758)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(264, 64)
        Me.TableLayoutPanel2.TabIndex = 1
        '
        'btnLogout
        '
        Me.btnLogout.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnLogout.BackColor = System.Drawing.Color.Red
        Me.btnLogout.FlatAppearance.BorderSize = 0
        Me.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogout.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnLogout.ForeColor = System.Drawing.Color.White
        Me.btnLogout.Image = Global.WellmeadowsHospital.My.Resources.Resources.icons8_logout_30
        Me.btnLogout.Location = New System.Drawing.Point(3, 3)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(258, 58)
        Me.btnLogout.TabIndex = 8
        Me.btnLogout.Text = "Log Out"
        Me.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnLogout.UseVisualStyleBackColor = False
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.btnHome, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnDashboard, 0, 7)
        Me.TableLayoutPanel1.Controls.Add(Me.btnRequisition, 0, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.btnSuppliers, 0, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.btnSupplies, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.btnPatients, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.btnStaff, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.btnWard, 0, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 8
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(264, 669)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'btnHome
        '
        Me.btnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnHome.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnHome.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnHome.FlatAppearance.BorderSize = 0
        Me.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHome.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnHome.ForeColor = System.Drawing.Color.White
        Me.btnHome.Image = Global.WellmeadowsHospital.My.Resources.Resources.icons8_hospital_50
        Me.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnHome.Location = New System.Drawing.Point(3, 3)
        Me.btnHome.Name = "btnHome"
        Me.btnHome.Size = New System.Drawing.Size(258, 77)
        Me.btnHome.TabIndex = 8
        Me.btnHome.Text = "Wellmeadows Hospital"
        Me.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnHome.UseMnemonic = False
        Me.btnHome.UseVisualStyleBackColor = True
        '
        'btnDashboard
        '
        Me.btnDashboard.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnDashboard.FlatAppearance.BorderSize = 0
        Me.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDashboard.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnDashboard.ForeColor = System.Drawing.Color.White
        Me.btnDashboard.Image = Global.WellmeadowsHospital.My.Resources.Resources.icons8_graph_64
        Me.btnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDashboard.Location = New System.Drawing.Point(3, 584)
        Me.btnDashboard.Name = "btnDashboard"
        Me.btnDashboard.Size = New System.Drawing.Size(258, 82)
        Me.btnDashboard.TabIndex = 7
        Me.btnDashboard.Text = "Dashboard"
        Me.btnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnDashboard.UseVisualStyleBackColor = True
        '
        'btnRequisition
        '
        Me.btnRequisition.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnRequisition.FlatAppearance.BorderSize = 0
        Me.btnRequisition.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRequisition.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnRequisition.ForeColor = System.Drawing.Color.White
        Me.btnRequisition.Image = Global.WellmeadowsHospital.My.Resources.Resources.icons8_paperwork_50
        Me.btnRequisition.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRequisition.Location = New System.Drawing.Point(3, 501)
        Me.btnRequisition.Name = "btnRequisition"
        Me.btnRequisition.Size = New System.Drawing.Size(258, 77)
        Me.btnRequisition.TabIndex = 6
        Me.btnRequisition.Text = "Requisition"
        Me.btnRequisition.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRequisition.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnRequisition.UseVisualStyleBackColor = True
        '
        'btnSuppliers
        '
        Me.btnSuppliers.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnSuppliers.FlatAppearance.BorderSize = 0
        Me.btnSuppliers.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSuppliers.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnSuppliers.ForeColor = System.Drawing.Color.White
        Me.btnSuppliers.Image = Global.WellmeadowsHospital.My.Resources.Resources.icons8_shopping_cart_50
        Me.btnSuppliers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSuppliers.Location = New System.Drawing.Point(3, 418)
        Me.btnSuppliers.Name = "btnSuppliers"
        Me.btnSuppliers.Size = New System.Drawing.Size(258, 77)
        Me.btnSuppliers.TabIndex = 5
        Me.btnSuppliers.Text = "Suppliers"
        Me.btnSuppliers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSuppliers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSuppliers.UseVisualStyleBackColor = True
        '
        'btnSupplies
        '
        Me.btnSupplies.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnSupplies.FlatAppearance.BorderSize = 0
        Me.btnSupplies.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSupplies.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnSupplies.ForeColor = System.Drawing.Color.White
        Me.btnSupplies.Image = Global.WellmeadowsHospital.My.Resources.Resources.icons8_medical_bag_50
        Me.btnSupplies.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSupplies.Location = New System.Drawing.Point(3, 335)
        Me.btnSupplies.Name = "btnSupplies"
        Me.btnSupplies.Size = New System.Drawing.Size(258, 77)
        Me.btnSupplies.TabIndex = 4
        Me.btnSupplies.Text = "Supplies"
        Me.btnSupplies.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSupplies.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSupplies.UseVisualStyleBackColor = True
        '
        'btnPatients
        '
        Me.btnPatients.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnPatients.FlatAppearance.BorderSize = 0
        Me.btnPatients.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPatients.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnPatients.ForeColor = System.Drawing.Color.White
        Me.btnPatients.Image = Global.WellmeadowsHospital.My.Resources.Resources.icons8_patient_50
        Me.btnPatients.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPatients.Location = New System.Drawing.Point(3, 252)
        Me.btnPatients.Name = "btnPatients"
        Me.btnPatients.Size = New System.Drawing.Size(258, 77)
        Me.btnPatients.TabIndex = 3
        Me.btnPatients.Text = "Patients"
        Me.btnPatients.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPatients.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnPatients.UseVisualStyleBackColor = True
        '
        'btnStaff
        '
        Me.btnStaff.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnStaff.FlatAppearance.BorderSize = 0
        Me.btnStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStaff.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnStaff.ForeColor = System.Drawing.Color.White
        Me.btnStaff.Image = Global.WellmeadowsHospital.My.Resources.Resources.icons8_staff_50
        Me.btnStaff.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnStaff.Location = New System.Drawing.Point(3, 169)
        Me.btnStaff.Name = "btnStaff"
        Me.btnStaff.Size = New System.Drawing.Size(258, 77)
        Me.btnStaff.TabIndex = 2
        Me.btnStaff.Text = "Staff"
        Me.btnStaff.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnStaff.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnStaff.UseVisualStyleBackColor = True
        '
        'btnWard
        '
        Me.btnWard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnWard.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnWard.FlatAppearance.BorderSize = 0
        Me.btnWard.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnWard.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnWard.ForeColor = System.Drawing.Color.White
        Me.btnWard.Image = Global.WellmeadowsHospital.My.Resources.Resources.icons8_ward_50
        Me.btnWard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnWard.Location = New System.Drawing.Point(3, 86)
        Me.btnWard.Name = "btnWard"
        Me.btnWard.Size = New System.Drawing.Size(258, 77)
        Me.btnWard.TabIndex = 1
        Me.btnWard.Text = "Ward"
        Me.btnWard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnWard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnWard.UseVisualStyleBackColor = True
        '
        'pnlMain
        '
        Me.pnlMain.Controls.Add(Me.AxWindowsMediaPlayer1)
        Me.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlMain.Location = New System.Drawing.Point(264, 0)
        Me.pnlMain.Name = "pnlMain"
        Me.pnlMain.Size = New System.Drawing.Size(1135, 822)
        Me.pnlMain.TabIndex = 1
        '
        'AxWindowsMediaPlayer1
        '
        Me.AxWindowsMediaPlayer1.Enabled = True
        Me.AxWindowsMediaPlayer1.Location = New System.Drawing.Point(33, 678)
        Me.AxWindowsMediaPlayer1.Name = "AxWindowsMediaPlayer1"
        Me.AxWindowsMediaPlayer1.OcxState = CType(resources.GetObject("AxWindowsMediaPlayer1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxWindowsMediaPlayer1.Size = New System.Drawing.Size(249, 74)
        Me.AxWindowsMediaPlayer1.TabIndex = 0
        '
        'FormMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1399, 822)
        Me.Controls.Add(Me.pnlMain)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Main Menu"
        Me.Panel1.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.pnlMain.ResumeLayout(False)
        CType(Me.AxWindowsMediaPlayer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents btnLogout As Button
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents btnDashboard As Button
    Friend WithEvents btnRequisition As Button
    Friend WithEvents btnSuppliers As Button
    Friend WithEvents btnSupplies As Button
    Friend WithEvents btnPatients As Button
    Friend WithEvents btnStaff As Button
    Friend WithEvents btnWard As Button
    Friend WithEvents btnHome As Button
    Friend WithEvents pnlMain As Panel
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents AxWindowsMediaPlayer1 As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents Button1 As Button
End Class
