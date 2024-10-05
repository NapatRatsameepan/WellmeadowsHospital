Imports System.Data.SqlClient

Public Class FormWard
    Private connectionString As String = "Data Source=WARMACHINE\DATABASE62;Initial Catalog=Wellmeadows_Hospital;Integrated Security=True;Connect Timeout=30; User Instance=False"
    Dim sqlConnection As New SqlConnection(connectionString)
    Private BedBindingSource As New BindingSource()
    Private Sub FormWard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Load data into the 'Ward' and 'BED_LIST' tables.
        Me.WardTableAdapter.Fill(Me.Wellmeadows_HospitalDataSet.Ward)
        Me.BED_LISTTableAdapter.Fill(Me.Wellmeadows_HospitalDataSet.BED_LIST)

        ' Bind the BedBindingSource to the BED_LIST data.
        BedBindingSource.DataSource = Me.Wellmeadows_HospitalDataSet.BED_LIST

        ' Bind the DataGridView to the BedBindingSource.
        DataGridView2.DataSource = BedBindingSource
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        ' Check if the input is numeric and apply a different filter accordingly
        If IsNumeric(TextBox1.Text) Then
            ' Use LIKE to allow partial matching by converting Ward_ID to a string
            BedBindingSource.Filter = String.Format("Convert(Ward_ID, 'System.String') LIKE '{0}%'", TextBox1.Text)
        Else
            ' Clear the filter when the input is not numeric
            BedBindingSource.Filter = ""
        End If
    End Sub


End Class