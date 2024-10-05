Public Class FormPatientMenu
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
                btnPTmange.Enabled = True
                btnApp.Enabled = True
                btnIn.Enabled = True
                btnPSB.Enabled = True
                btnExam.Enabled = True
                btnReport.Enabled = True

            Case 12 ' Charge Nurse
                btnPTmange.Enabled = True
                btnApp.Enabled = True
                btnIn.Enabled = True
                btnPSB.Enabled = True
                btnExam.Enabled = True
                btnReport.Enabled = True

            Case 13 ' Senior Medical Staff
                btnPTmange.Enabled = True
                btnApp.Enabled = True
                btnIn.Enabled = False
                btnPSB.Enabled = True
                btnExam.Enabled = True
                btnReport.Enabled = False

            Case 14 ' Junior Medical Staff
                btnPTmange.Enabled = True
                btnApp.Enabled = True
                btnIn.Enabled = False
                btnPSB.Enabled = True
                btnExam.Enabled = True
                btnReport.Enabled = False

            Case 15 ' Personel Officer
                btnPTmange.Enabled = True
                btnApp.Enabled = False
                btnIn.Enabled = False
                btnPSB.Enabled = False
                btnExam.Enabled = False
                btnReport.Enabled = False

            Case 16 ' Staff
                btnPTmange.Enabled = True
                btnApp.Enabled = False
                btnIn.Enabled = False
                btnPSB.Enabled = False
                btnExam.Enabled = False
                btnReport.Enabled = False

                ' เพิ่มตำแหน่งอื่น ๆ ตามที่ต้องการ
        End Select
    End Sub

    Private Sub BtnPTmange_Click(sender As Object, e As EventArgs) Handles btnPTmange.Click
        switchForm(New FormPatientManage()) ' Load FormStaff on pnlMain
    End Sub

    Private Sub BtnApp_Click(sender As Object, e As EventArgs) Handles btnApp.Click
        switchForm(New FormAppoinment())
    End Sub

    Private Sub BtnIn_Click(sender As Object, e As EventArgs) Handles btnIn.Click
        switchForm(New FormPatientWaitingList())
    End Sub

    Private Sub BtnPSB_Click(sender As Object, e As EventArgs) Handles btnPSB.Click
        switchForm(New FormPSB())
    End Sub

    Private Sub BtnExam_Click(sender As Object, e As EventArgs) Handles btnExam.Click
        switchForm(New FormExam())
    End Sub

    Private Sub BtnReport_Click(sender As Object, e As EventArgs) Handles btnReport.Click
        switchForm(New FormPatientReport())
    End Sub
End Class