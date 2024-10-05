Public Class FormCentralStock
    Private Sub FormCentralStock_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Wellmeadows_HospitalDataSet.Item' table. You can move, or remove it, as needed.
        Me.ItemTableAdapter.Fill(Me.Wellmeadows_HospitalDataSet.Item)
        'TODO: This line of code loads data into the 'Wellmeadows_HospitalDataSet.Drug' table. You can move, or remove it, as needed.
        Me.DrugTableAdapter.Fill(Me.Wellmeadows_HospitalDataSet.Drug)

    End Sub
End Class