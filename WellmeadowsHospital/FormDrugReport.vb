Public Class FormDrugReport
    Private DrugBindingSource As New BindingSource
    Private Sub FormDrugReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Wellmeadows_HospitalDataSet.View_DrugReport' table. You can move, or remove it, as needed.
        Me.View_DrugReportTableAdapter.Fill(Me.Wellmeadows_HospitalDataSet.View_DrugReport)
        ' Bind the BedBindingSource to the BED_LIST data.
        DrugBindingSource.DataSource = Me.Wellmeadows_HospitalDataSet.View_DrugReport

        ' Bind the DataGridView to the BedBindingSource.
        DataGridView1.DataSource = DrugBindingSource
    End Sub


    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        ' Check if the input is numeric and apply a different filter accordingly
        If IsNumeric(TextBox1.Text) Then
            ' Use LIKE to allow partial matching
            DrugBindingSource.Filter = String.Format("Convert(Drug_Requisition_ID, 'System.String') LIKE '{0}%'", TextBox1.Text)
        Else
            ' Clear the filter when the input is not numeric
            DrugBindingSource.Filter = ""
        End If
    End Sub
End Class