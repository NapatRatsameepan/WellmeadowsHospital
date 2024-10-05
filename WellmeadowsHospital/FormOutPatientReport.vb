Public Class FormOutPatientReport
    Private PatientBindingSource As New BindingSource()
    Private Sub FormOutPatientReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Wellmeadows_HospitalDataSet.View_OPD' table. You can move, or remove it, as needed.
        Me.View_OPDTableAdapter.Fill(Me.Wellmeadows_HospitalDataSet.View_OPD)

        PatientBindingSource.DataSource = Me.Wellmeadows_HospitalDataSet.View_OPD

        DataGridView1.DataSource = PatientBindingSource

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        PatientBindingSource.Filter = String.Format("[Patient Name] LIKE '%{0}%'", TextBox1.Text)
    End Sub
End Class