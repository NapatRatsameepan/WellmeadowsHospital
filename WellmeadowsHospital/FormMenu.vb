Imports System.Data.SqlClient

Public Class FormMenu
    Private connectionString As String = "Data Source=WARMACHINE\DATABASE62;Initial Catalog=Wellmeadows_Hospital;Integrated Security=True;Connect Timeout=30; User Instance=False"
    Dim sqlConnection As New SqlConnection(connectionString)
    Private Sub switchForm(form As Form)
        pnlMain.Controls.Clear()
        form.TopLevel = False
        form.Dock = DockStyle.Fill
        pnlMain.Controls.Add(form)
        form.BringToFront()
        form.Show()
    End Sub

    Private Sub FormMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        switchForm(FormWard)
    End Sub

    Private Sub BtnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        FormMain.Show()
        Me.Close()
    End Sub

    Private Sub BtnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        switchForm(FormWard)
    End Sub

    Private Sub BtnWard_Click(sender As Object, e As EventArgs) Handles btnWard.Click
        switchForm(FormWard)
    End Sub

    Private Sub btnStaff_Click(sender As Object, e As EventArgs) Handles btnStaff.Click
        Dim staffMenu As New FormStaffMenu(Me, positionID)
        switchForm(staffMenu)
    End Sub

    Private Sub BtnPatients_Click(sender As Object, e As EventArgs) Handles btnPatients.Click
        Dim PatientMenu As New FormPatientMenu(Me, positionID) ' Pass FormMenu reference to FormStaffMenu
        switchForm(PatientMenu)
    End Sub

    Private Sub BtnSupplies_Click(sender As Object, e As EventArgs) Handles btnSupplies.Click
        Dim PatientMenu As New FormSupplies(Me, positionID) ' Pass FormMenu reference to FormStaffMenu
        switchForm(PatientMenu)
    End Sub

    Private Sub BtnSuppliers_Click(sender As Object, e As EventArgs) Handles btnSuppliers.Click
        ' ตรวจสอบว่า Position_ID คือ 11 (Medical Director)
        If positionID = 11 Then
            ' หากเป็น Medical Director ให้เข้าถึงได้
            switchForm(FormSuppliers)
        Else
            ' หากไม่ใช่ Medical Director ให้แสดงข้อความแจ้งเตือน
            MessageBox.Show("คุณไม่มีสิทธ์เข้าถึง", "ข้อจำกัดการเข้าถึง", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub


    Private Sub BtnRequisition_Click(sender As Object, e As EventArgs) Handles btnRequisition.Click
        Dim PatientMenu As New FormRequisition(Me, positionID) ' Pass FormMenu reference to FormStaffMenu
        switchForm(PatientMenu)
    End Sub

    Private Sub BtnDashboard_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click
        Dim PatientMenu As New FormDashboardMenu(Me)
        If positionID = 11 Then
            switchForm(PatientMenu)
        Else
            MessageBox.Show("คุณไม่มีสิทธ์เข้าถึง", "ข้อจำกัดการเข้าถึง", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private positionID As Integer ' ตัวแปรสำหรับเก็บ Position_ID ของผู้ใช้

    ' Constructor รับค่า Position_ID จาก FormMain
    Public Sub New(posID As Integer)
        InitializeComponent()
        Me.positionID = posID
    End Sub

    Private Sub TableLayoutPanel3_Paint(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel3.Paint

    End Sub

    Private Sub AxWindowsMediaPlayer1_Enter(sender As Object, e As EventArgs) Handles AxWindowsMediaPlayer1.Enter

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' ตรวจสอบสถานะการเล่นของ Windows Media Player
        If AxWindowsMediaPlayer1.playState = WMPLib.WMPPlayState.wmppsPlaying Then
            ' ถ้าเสียงกำลังเล่น ให้หยุดชั่วคราว (Pause)
            AxWindowsMediaPlayer1.Ctlcontrols.pause()
        ElseIf AxWindowsMediaPlayer1.playState = WMPLib.WMPPlayState.wmppsPaused Then
            ' ถ้าเสียงถูกหยุดชั่วคราว ให้เล่นต่อ (Resume)
            AxWindowsMediaPlayer1.Ctlcontrols.play()
        Else
            ' ถ้าไม่มีการเล่นหรือหยุดชั่วคราว เริ่มเล่นจากจุดเริ่มต้น
            ' กำหนดไฟล์ MP3 ที่ต้องการเล่น
            AxWindowsMediaPlayer1.URL = "C:\Users\keem3\OneDrive\Desktop\Project 1101173\WellmeadowsHospital\WellmeadowsHospital\Resources\The Afternoon's Hat.mp3"
            ' เล่นเสียง
            AxWindowsMediaPlayer1.Ctlcontrols.play()
        End If
    End Sub

End Class