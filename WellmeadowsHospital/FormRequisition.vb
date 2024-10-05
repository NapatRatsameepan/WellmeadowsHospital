Public Class FormRequisition
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
                ' Medical Director สามารถเข้าถึงทุกปุ่มได้
                btnReceive.Enabled = True
                btnDrugReuisition.Enabled = True
                btnItemReuisition.Enabled = True
                btnStatus.Enabled = True
                btnReport.Enabled = True

            Case 12 ' Charge Nurse
                ' Charge Nurse สามารถทำการร้องขอยาและสิ่งของ และรับของได้ แต่ไม่สามารถดูสถานะการร้องขอได้
                btnReceive.Enabled = True
                btnDrugReuisition.Enabled = True
                btnItemReuisition.Enabled = True
                btnStatus.Enabled = False
                btnReport.Enabled = True

            Case 13 ' Senior Medical Staff
                ' Senior Medical Staff สามารถทำการร้องขอได้ทั้งยาและสิ่งของ และสามารถรับของได้
                btnReceive.Enabled = True
                btnDrugReuisition.Enabled = True
                btnItemReuisition.Enabled = True
                btnStatus.Enabled = False
                btnReport.Enabled = False

            Case 14 ' Junior Medical Staff
                ' Junior Medical Staff สามารถทำการร้องขอสิ่งของได้เท่านั้น และรับของได้
                btnReceive.Enabled = True
                btnDrugReuisition.Enabled = True
                btnItemReuisition.Enabled = True
                btnStatus.Enabled = False
                btnReport.Enabled = False

            Case 15 ' Personnel Officer
                ' Personnel Officer มีสิทธิ์จัดการร้องขอสิ่งของและรับของ
                btnReceive.Enabled = False
                btnDrugReuisition.Enabled = False
                btnItemReuisition.Enabled = False
                btnStatus.Enabled = False
                btnReport.Enabled = False

            Case 16 ' Staff
                ' Staff สามารถทำการร้องขอสิ่งของได้ และรับของได้ แต่ไม่สามารถร้องขอยาได้
                btnReceive.Enabled = False
                btnDrugReuisition.Enabled = False
                btnItemReuisition.Enabled = False
                btnStatus.Enabled = True
                btnReport.Enabled = False

                ' เพิ่มตำแหน่งอื่น ๆ ตามที่ต้องการ
        End Select
    End Sub


    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnReceive.Click
        switchForm(New FormRequisitionStatus())
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btnDrugReuisition.Click
        switchForm(New FormDrugRequisiton())
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnItemReuisition.Click
        switchForm(New FormItemRequisiton())
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnStatus.Click
        switchForm(New FormRequisitionReceive())
    End Sub

    Private Sub BtnReport_Click(sender As Object, e As EventArgs) Handles btnReport.Click
        switchForm(New FormRequisitionReport)
    End Sub
End Class