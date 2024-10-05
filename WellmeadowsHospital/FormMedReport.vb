Public Class FormMedReport
    Private PatientBindingSource As New BindingSource()
    Private Sub FormMedReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Wellmeadows_HospitalDataSet.PrescribeReport2' table. You can move, or remove it, as needed.
        Me.PrescribeReport2TableAdapter.Fill(Me.Wellmeadows_HospitalDataSet.PrescribeReport2)

        PatientBindingSource.DataSource = Me.Wellmeadows_HospitalDataSet.PrescribeReport2

        DataGridView1.DataSource = PatientBindingSource

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

        ' Check if the input is numeric and apply a different filter accordingly
        If IsNumeric(TextBox1.Text) Then
            ' Use LIKE to allow partial matching by converting Ward_ID to a string
            PatientBindingSource.Filter = String.Format("Convert(Prescribe_ID, 'System.String') LIKE '{0}%'", TextBox1.Text)
        Else
            ' Clear the filter when the input is not numeric
            PatientBindingSource.Filter = ""
        End If
    End Sub
End Class