Public Class FormDashboardMenu

    Private parentForm As FormMenu ' Reference to FormMenu
    Public Sub New(parent As FormMenu)
        InitializeComponent()
        Me.ParentForm = parent
    End Sub

    Private Sub switchForm(form As Form)
        ParentForm.pnlMain.Controls.Clear() ' Clear pnlMain of FormMenu
        form.TopLevel = False
        form.Dock = DockStyle.Fill
        ParentForm.pnlMain.Controls.Add(form)
        form.BringToFront()
        form.Show()
    End Sub

    Private Sub BtnPatient_Click(sender As Object, e As EventArgs) Handles btnPatient.Click
        switchForm(New FormDashboard())
    End Sub

    Private Sub BtnStaff_Click(sender As Object, e As EventArgs) Handles btnStaff.Click
        switchForm(New FormDashboardStaff())
    End Sub

    Private Sub BtnItem_Click(sender As Object, e As EventArgs) Handles btnItem.Click
        switchForm(New FormDashboardItem)
    End Sub

    Private Sub BtnDrug_Click(sender As Object, e As EventArgs) Handles btnDrug.Click
        switchForm(New FormDashboardDrug())
    End Sub
End Class