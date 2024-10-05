Public Class FormRequisitionReport
    Private Sub BtnItemReport_Click(sender As Object, e As EventArgs) Handles btnItemReport.Click
        Dim searchForm As New FormItemReport()
        searchForm.ShowDialog()
    End Sub

    Private Sub BtnDrugReport_Click(sender As Object, e As EventArgs) Handles btnDrugReport.Click
        Dim searchForm As New FormDrugReport()
        searchForm.ShowDialog()
    End Sub
End Class