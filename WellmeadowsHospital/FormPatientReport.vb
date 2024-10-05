Public Class FormPatientReport
    Private Sub BtnIPReport_Click(sender As Object, e As EventArgs) Handles btnIPReport.Click
        Dim searchForm As New FormInPatientReport()
        searchForm.ShowDialog()
    End Sub

    Private Sub BtnOPD_Click(sender As Object, e As EventArgs) Handles btnOPD.Click
        Dim searchForm As New FormOutPatientReport()
        searchForm.ShowDialog()
    End Sub

    Private Sub BtnPSB_Click(sender As Object, e As EventArgs) Handles btnPSB.Click
        Dim searchForm As New FormMedReport()
        searchForm.ShowDialog()
    End Sub
End Class