Public Class FormStaffMenu
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
                btnStfmange.Enabled = True
                btnStfallo.Enabled = True
                btnStaffList.Enabled = True
                btnAlloReport.Enabled = True

            Case 12 ' Charge Nurse
                btnStfmange.Enabled = False
                btnStfallo.Enabled = True
                btnStaffList.Enabled = True
                btnAlloReport.Enabled = True

            Case 13 ' Senior Medical Staff
                btnStfmange.Enabled = False
                btnStfallo.Enabled = False
                btnStaffList.Enabled = True
                btnAlloReport.Enabled = False

            Case 14 ' Junior Medical Staff
                btnStfmange.Enabled = False
                btnStfallo.Enabled = False
                btnStaffList.Enabled = True
                btnAlloReport.Enabled = False

            Case 15 ' Personel Officer
                btnStfmange.Enabled = True
                btnStfallo.Enabled = False
                btnStaffList.Enabled = True
                btnAlloReport.Enabled = True

            Case 16 ' Staff
                btnStfmange.Enabled = False
                btnStfallo.Enabled = False
                btnStaffList.Enabled = True
                btnAlloReport.Enabled = False

                ' เพิ่มตำแหน่งอื่น ๆ ตามที่ต้องการ
        End Select
    End Sub

    Private Sub BtnStfmange_Click(sender As Object, e As EventArgs) Handles btnStfmange.Click
        switchForm(New FormStaff()) ' Load FormStaff on pnlMain
    End Sub

    ' ปุ่มสำหรับไปที่หน้า FormStaffAllo
    Private Sub BtnStfallo_Click(sender As Object, e As EventArgs) Handles btnStfallo.Click
        switchForm(New FormStaffAllo()) ' Add functionality to switch to Staff Allocation form
    End Sub

    ' ปุ่มสำหรับไปที่หน้า FormStaffList
    Private Sub BtnStaffList_Click(sender As Object, e As EventArgs) Handles btnStaffList.Click
        switchForm(New FormStaffList())
    End Sub

    Private Sub BtnAlloReport_Click(sender As Object, e As EventArgs) Handles btnAlloReport.Click
        switchForm(New FormAlloReport())
    End Sub

End Class