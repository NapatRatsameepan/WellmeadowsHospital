<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormDrugOrder
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
        Me.btnDrugSearch = New System.Windows.Forms.Button()
        Me.btnSuppSearch = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnOrder = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.txtQuantity = New System.Windows.Forms.TextBox()
        Me.txtDrugName = New System.Windows.Forms.TextBox()
        Me.txtSuppID = New System.Windows.Forms.TextBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtSuppName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtDrugID = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtCPU = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.SuppID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DrugID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Quantity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Price = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnDrugSearch
        '
        Me.btnDrugSearch.Location = New System.Drawing.Point(237, 209)
        Me.btnDrugSearch.Name = "btnDrugSearch"
        Me.btnDrugSearch.Size = New System.Drawing.Size(39, 23)
        Me.btnDrugSearch.TabIndex = 250
        Me.btnDrugSearch.Text = "..."
        Me.btnDrugSearch.UseVisualStyleBackColor = True
        '
        'btnSuppSearch
        '
        Me.btnSuppSearch.Location = New System.Drawing.Point(237, 153)
        Me.btnSuppSearch.Name = "btnSuppSearch"
        Me.btnSuppSearch.Size = New System.Drawing.Size(39, 23)
        Me.btnSuppSearch.TabIndex = 249
        Me.btnSuppSearch.Text = "..."
        Me.btnSuppSearch.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label5.Location = New System.Drawing.Point(72, 314)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(214, 38)
        Me.Label5.TabIndex = 248
        Me.Label5.Text = "ORDER LIST"
        '
        'btnOrder
        '
        Me.btnOrder.Location = New System.Drawing.Point(964, 715)
        Me.btnOrder.Name = "btnOrder"
        Me.btnOrder.Size = New System.Drawing.Size(80, 34)
        Me.btnOrder.TabIndex = 247
        Me.btnOrder.Text = "Order"
        Me.btnOrder.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(410, 313)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(80, 36)
        Me.btnDelete.TabIndex = 246
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label11.Location = New System.Drawing.Point(322, 242)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(46, 20)
        Me.Label11.TabIndex = 245
        Me.Label11.Text = "Total"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label10.Location = New System.Drawing.Point(73, 242)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(71, 20)
        Me.Label10.TabIndex = 244
        Me.Label10.Text = "Quantity"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label9.Location = New System.Drawing.Point(322, 130)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(96, 20)
        Me.Label9.TabIndex = 243
        Me.Label9.Text = "Supp Name"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label8.Location = New System.Drawing.Point(75, 130)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(69, 20)
        Me.Label8.TabIndex = 242
        Me.Label8.Text = "Supp ID"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label7.Location = New System.Drawing.Point(75, 186)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(68, 20)
        Me.Label7.TabIndex = 241
        Me.Label7.Text = "Drug ID"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label4.Location = New System.Drawing.Point(444, 251)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(0, 20)
        Me.Label4.TabIndex = 240
        '
        'txtTotal
        '
        Me.txtTotal.Location = New System.Drawing.Point(326, 265)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(152, 22)
        Me.txtTotal.TabIndex = 239
        '
        'txtQuantity
        '
        Me.txtQuantity.Location = New System.Drawing.Point(79, 265)
        Me.txtQuantity.Name = "txtQuantity"
        Me.txtQuantity.Size = New System.Drawing.Size(152, 22)
        Me.txtQuantity.TabIndex = 238
        '
        'txtDrugName
        '
        Me.txtDrugName.Location = New System.Drawing.Point(324, 209)
        Me.txtDrugName.Name = "txtDrugName"
        Me.txtDrugName.Size = New System.Drawing.Size(152, 22)
        Me.txtDrugName.TabIndex = 237
        '
        'txtSuppID
        '
        Me.txtSuppID.Location = New System.Drawing.Point(79, 153)
        Me.txtSuppID.Name = "txtSuppID"
        Me.txtSuppID.Size = New System.Drawing.Size(152, 22)
        Me.txtSuppID.TabIndex = 236
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(324, 313)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(80, 36)
        Me.btnAdd.TabIndex = 234
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.Location = New System.Drawing.Point(256, 153)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 20)
        Me.Label2.TabIndex = 233
        '
        'txtSuppName
        '
        Me.txtSuppName.Location = New System.Drawing.Point(326, 153)
        Me.txtSuppName.Name = "txtSuppName"
        Me.txtSuppName.Size = New System.Drawing.Size(152, 22)
        Me.txtSuppName.TabIndex = 232
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(411, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(244, 38)
        Me.Label1.TabIndex = 231
        Me.Label1.Text = "DRUG ORDER"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.Location = New System.Drawing.Point(322, 186)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 20)
        Me.Label3.TabIndex = 230
        Me.Label3.Text = "Drug Name"
        '
        'txtDrugID
        '
        Me.txtDrugID.Location = New System.Drawing.Point(79, 209)
        Me.txtDrugID.Name = "txtDrugID"
        Me.txtDrugID.Size = New System.Drawing.Size(152, 22)
        Me.txtDrugID.TabIndex = 229
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label6.Location = New System.Drawing.Point(524, 186)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(110, 20)
        Me.Label6.TabIndex = 252
        Me.Label6.Text = "Cost Per Unit"
        '
        'txtCPU
        '
        Me.txtCPU.Location = New System.Drawing.Point(528, 209)
        Me.txtCPU.Name = "txtCPU"
        Me.txtCPU.Size = New System.Drawing.Size(152, 22)
        Me.txtCPU.TabIndex = 251
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SuppID, Me.DrugID, Me.Quantity, Me.Price})
        Me.DataGridView1.Location = New System.Drawing.Point(79, 355)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(967, 354)
        Me.DataGridView1.TabIndex = 253
        '
        'SuppID
        '
        Me.SuppID.HeaderText = "Supp ID"
        Me.SuppID.MinimumWidth = 6
        Me.SuppID.Name = "SuppID"
        Me.SuppID.Width = 125
        '
        'DrugID
        '
        Me.DrugID.HeaderText = "Drug ID"
        Me.DrugID.MinimumWidth = 6
        Me.DrugID.Name = "DrugID"
        Me.DrugID.Width = 125
        '
        'Quantity
        '
        Me.Quantity.HeaderText = "Order Quantity"
        Me.Quantity.MinimumWidth = 6
        Me.Quantity.Name = "Quantity"
        Me.Quantity.Width = 125
        '
        'Price
        '
        Me.Price.HeaderText = "Price Total"
        Me.Price.MinimumWidth = 6
        Me.Price.Name = "Price"
        Me.Price.Width = 125
        '
        'FormDrugOrder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1117, 775)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtCPU)
        Me.Controls.Add(Me.btnDrugSearch)
        Me.Controls.Add(Me.btnSuppSearch)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnOrder)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.txtQuantity)
        Me.Controls.Add(Me.txtDrugName)
        Me.Controls.Add(Me.txtSuppID)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtSuppName)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtDrugID)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormDrugOrder"
        Me.Text = "FormDrugOrder"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnDrugSearch As Button
    Friend WithEvents btnSuppSearch As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents btnOrder As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents txtQuantity As TextBox
    Friend WithEvents txtDrugName As TextBox
    Friend WithEvents txtSuppID As TextBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents txtSuppName As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtDrugID As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtCPU As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents SuppID As DataGridViewTextBoxColumn
    Friend WithEvents DrugID As DataGridViewTextBoxColumn
    Friend WithEvents Quantity As DataGridViewTextBoxColumn
    Friend WithEvents Price As DataGridViewTextBoxColumn
End Class
