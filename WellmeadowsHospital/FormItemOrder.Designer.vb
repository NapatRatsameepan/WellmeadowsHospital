<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormItemOrder
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.txtSuppName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtItemID = New System.Windows.Forms.TextBox()
        Me.txtSuppID = New System.Windows.Forms.TextBox()
        Me.txtItemName = New System.Windows.Forms.TextBox()
        Me.txtQuantity = New System.Windows.Forms.TextBox()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.btnOrder = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnbtnSuppSearch = New System.Windows.Forms.Button()
        Me.btnItemSearch = New System.Windows.Forms.Button()
        Me.txtCPU = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuppID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Quantity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Price = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SuppID, Me.ItemID, Me.Quantity, Me.Price})
        Me.DataGridView1.Location = New System.Drawing.Point(74, 356)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(967, 354)
        Me.DataGridView1.TabIndex = 34
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(321, 314)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(80, 36)
        Me.btnAdd.TabIndex = 28
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'txtSuppName
        '
        Me.txtSuppName.Location = New System.Drawing.Point(323, 154)
        Me.txtSuppName.Name = "txtSuppName"
        Me.txtSuppName.Size = New System.Drawing.Size(152, 22)
        Me.txtSuppName.TabIndex = 24
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(408, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(223, 38)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "ITEM ORDER"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.Location = New System.Drawing.Point(319, 187)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 20)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Item Name"
        '
        'txtItemID
        '
        Me.txtItemID.Location = New System.Drawing.Point(76, 210)
        Me.txtItemID.Name = "txtItemID"
        Me.txtItemID.Size = New System.Drawing.Size(152, 22)
        Me.txtItemID.TabIndex = 21
        '
        'txtSuppID
        '
        Me.txtSuppID.Location = New System.Drawing.Point(76, 154)
        Me.txtSuppID.Name = "txtSuppID"
        Me.txtSuppID.Size = New System.Drawing.Size(152, 22)
        Me.txtSuppID.TabIndex = 35
        '
        'txtItemName
        '
        Me.txtItemName.Location = New System.Drawing.Point(321, 210)
        Me.txtItemName.Name = "txtItemName"
        Me.txtItemName.Size = New System.Drawing.Size(152, 22)
        Me.txtItemName.TabIndex = 36
        '
        'txtQuantity
        '
        Me.txtQuantity.Location = New System.Drawing.Point(76, 266)
        Me.txtQuantity.Name = "txtQuantity"
        Me.txtQuantity.Size = New System.Drawing.Size(152, 22)
        Me.txtQuantity.TabIndex = 37
        '
        'txtTotal
        '
        Me.txtTotal.Location = New System.Drawing.Point(323, 266)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(152, 22)
        Me.txtTotal.TabIndex = 38
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label4.Location = New System.Drawing.Point(441, 252)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(0, 20)
        Me.Label4.TabIndex = 39
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label7.Location = New System.Drawing.Point(72, 187)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(63, 20)
        Me.Label7.TabIndex = 40
        Me.Label7.Text = "Item ID"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label8.Location = New System.Drawing.Point(72, 131)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(69, 20)
        Me.Label8.TabIndex = 41
        Me.Label8.Text = "Supp ID"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label9.Location = New System.Drawing.Point(319, 131)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(96, 20)
        Me.Label9.TabIndex = 42
        Me.Label9.Text = "Supp Name"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label10.Location = New System.Drawing.Point(70, 243)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(71, 20)
        Me.Label10.TabIndex = 43
        Me.Label10.Text = "Quantity"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label11.Location = New System.Drawing.Point(319, 243)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(46, 20)
        Me.Label11.TabIndex = 44
        Me.Label11.Text = "Total"
        '
        'btnOrder
        '
        Me.btnOrder.Location = New System.Drawing.Point(961, 716)
        Me.btnOrder.Name = "btnOrder"
        Me.btnOrder.Size = New System.Drawing.Size(80, 34)
        Me.btnOrder.TabIndex = 72
        Me.btnOrder.Text = "Order"
        Me.btnOrder.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(407, 314)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(80, 34)
        Me.btnDelete.TabIndex = 71
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label5.Location = New System.Drawing.Point(69, 315)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(214, 38)
        Me.Label5.TabIndex = 73
        Me.Label5.Text = "ORDER LIST"
        '
        'btnbtnSuppSearch
        '
        Me.btnbtnSuppSearch.Location = New System.Drawing.Point(234, 154)
        Me.btnbtnSuppSearch.Name = "btnbtnSuppSearch"
        Me.btnbtnSuppSearch.Size = New System.Drawing.Size(39, 23)
        Me.btnbtnSuppSearch.TabIndex = 227
        Me.btnbtnSuppSearch.Text = "..."
        Me.btnbtnSuppSearch.UseVisualStyleBackColor = True
        '
        'btnItemSearch
        '
        Me.btnItemSearch.Location = New System.Drawing.Point(234, 210)
        Me.btnItemSearch.Name = "btnItemSearch"
        Me.btnItemSearch.Size = New System.Drawing.Size(39, 23)
        Me.btnItemSearch.TabIndex = 228
        Me.btnItemSearch.Text = "..."
        Me.btnItemSearch.UseVisualStyleBackColor = True
        '
        'txtCPU
        '
        Me.txtCPU.Location = New System.Drawing.Point(525, 210)
        Me.txtCPU.Name = "txtCPU"
        Me.txtCPU.Size = New System.Drawing.Size(152, 22)
        Me.txtCPU.TabIndex = 229
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.Location = New System.Drawing.Point(521, 187)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(110, 20)
        Me.Label2.TabIndex = 230
        Me.Label2.Text = "Cost Per Unit"
        '
        'SuppID
        '
        Me.SuppID.HeaderText = "Supp ID"
        Me.SuppID.MinimumWidth = 6
        Me.SuppID.Name = "SuppID"
        Me.SuppID.Width = 125
        '
        'ItemID
        '
        Me.ItemID.HeaderText = "Item ID"
        Me.ItemID.MinimumWidth = 6
        Me.ItemID.Name = "ItemID"
        Me.ItemID.Width = 125
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
        'FormItemOrder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1117, 775)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtCPU)
        Me.Controls.Add(Me.btnItemSearch)
        Me.Controls.Add(Me.btnbtnSuppSearch)
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
        Me.Controls.Add(Me.txtItemName)
        Me.Controls.Add(Me.txtSuppID)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.txtSuppName)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtItemID)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormItemOrder"
        Me.Text = "FormItemOrder"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnAdd As Button
    Friend WithEvents txtSuppName As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtItemID As TextBox
    Friend WithEvents txtSuppID As TextBox
    Friend WithEvents txtItemName As TextBox
    Friend WithEvents txtQuantity As TextBox
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents btnOrder As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents btnbtnSuppSearch As Button
    Friend WithEvents btnItemSearch As Button
    Friend WithEvents txtCPU As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents SuppID As DataGridViewTextBoxColumn
    Friend WithEvents ItemID As DataGridViewTextBoxColumn
    Friend WithEvents Quantity As DataGridViewTextBoxColumn
    Friend WithEvents Price As DataGridViewTextBoxColumn
End Class
