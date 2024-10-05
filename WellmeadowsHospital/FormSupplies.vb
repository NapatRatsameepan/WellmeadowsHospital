Public Class FormSupplies
    Private parentForm As FormMenu ' Reference to FormMenu
    Private positionID As Integer ' ตัวแปรสำหรับเก็บ Position_ID ของผู้ใช้

    ' Constructor to receive the reference to FormMenu
    ' Constructor รับค่า FormMenu และ Position_ID
    Public Sub New(parent As FormMenu, position As Integer)
        InitializeComponent()
        Me.parentForm = parent
        Me.positionID = position
        SetButtonPermissions()
    End Sub
    Private Sub switchForm(form As Form)
        parentForm.pnlMain.Controls.Clear() ' Clear pnlMain of FormMenu
        form.TopLevel = False
        form.Dock = DockStyle.Fill
        parentForm.pnlMain.Controls.Add(form)
        form.BringToFront()
        form.Show()
    End Sub

    Private Sub SetButtonPermissions()
        Select Case positionID
            Case 11 ' Medical Director
                btnItemManage.Enabled = True
                btnDrugManage.Enabled = True
                btnItemOrder.Enabled = True
                btnDrugOrder.Enabled = True
                btnReceive.Enabled = True

            Case 12 ' Charge Nurse
                btnItemManage.Enabled = False
                btnDrugManage.Enabled = False
                btnItemOrder.Enabled = True
                btnDrugOrder.Enabled = True
                btnReceive.Enabled = True

            Case 13 ' Senior Medical Staff
                btnItemManage.Enabled = False
                btnDrugManage.Enabled = False
                btnItemOrder.Enabled = True
                btnDrugOrder.Enabled = True
                btnReceive.Enabled = True

            Case 14 ' Junior Medical Staff
                btnItemManage.Enabled = False
                btnDrugManage.Enabled = False
                btnItemOrder.Enabled = False
                btnDrugOrder.Enabled = False
                btnReceive.Enabled = True

            Case 15 ' Personel Officer
                btnItemManage.Enabled = False
                btnDrugManage.Enabled = False
                btnItemOrder.Enabled = False
                btnDrugOrder.Enabled = False
                btnReceive.Enabled = False

            Case 16 ' Staff
                btnItemManage.Enabled = False
                btnDrugManage.Enabled = False
                btnItemOrder.Enabled = True
                btnDrugOrder.Enabled = True
                btnReceive.Enabled = True

                ' เพิ่มตำแหน่งอื่น ๆ ตามที่ต้องการ
        End Select
    End Sub

    Private Sub btnReceive_Click(sender As Object, e As EventArgs) Handles btnReceive.Click
        switchForm(New FormReceive())
    End Sub

    Private Sub btnDrugManage_Click(sender As Object, e As EventArgs) Handles btnDrugManage.Click
        switchForm(New FormDrugManage())
    End Sub

    Private Sub btnItemOrder_Click(sender As Object, e As EventArgs) Handles btnItemOrder.Click
        switchForm(New FormItemOrder())
    End Sub

    Private Sub btnDrugOrder_Click(sender As Object, e As EventArgs) Handles btnDrugOrder.Click
        switchForm(New FormDrugOrder())
    End Sub

    Private Sub btnItemManage_Click(sender As Object, e As EventArgs) Handles btnItemManage.Click
        switchForm(New FormItemManage())
    End Sub


End Class