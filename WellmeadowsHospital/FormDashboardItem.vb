Imports System.Data.SqlClient
Imports Microsoft.Reporting.WinForms

Public Class FormDashboardItem
    Private connectionString As String = "Data Source=WARMACHINE\DATABASE62;Initial Catalog=Wellmeadows_Hospital;Integrated Security=True;Connect Timeout=30; User Instance=False"
    Dim sqlConnection As New SqlConnection(connectionString)

    Private Sub FormDashboardItem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Load available years into ComboBoxYear
        LoadYears()
        ' Load the default data into DataGridView (optional)
        LoadDataGrid()
        ' Refresh ReportViewer with the default selection if needed
        LoadReport() ' Ensure LoadReport is called here to initialize ReportViewer
    End Sub

    Private Sub LoadYears()
        Try
            ' Fill ComboBox with years available in View_ItemExpenses
            Using conn As New SqlConnection(connectionString)
                Dim query As String = "SELECT DISTINCT Order_Year FROM View_ItemExpenses ORDER BY Order_Year"
                Using cmd As New SqlCommand(query, conn)
                    conn.Open()
                    Using reader As SqlDataReader = cmd.ExecuteReader()
                        While reader.Read()
                            ComboBoxYear.Items.Add(reader("Order_Year").ToString())
                        End While
                    End Using
                End Using
            End Using

            ' Set default selection to the first item if available
            If ComboBoxYear.Items.Count > 0 Then
                ComboBoxYear.SelectedIndex = 0
            End If
        Catch ex As Exception
            MessageBox.Show("Error loading years: " & ex.Message)
        End Try
    End Sub

    Private Sub LoadMonths(selectedYear As String)
        Try
            ComboBoxMonth.Items.Clear() ' Clear existing months before loading new ones
            ' Fill ComboBoxMonth with months for the selected year
            Using conn As New SqlConnection(connectionString)
                Dim query As String = "SELECT DISTINCT Order_Month FROM View_ItemExpenses WHERE Order_Year = @Year ORDER BY Order_Month"
                Using cmd As New SqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@Year", selectedYear)
                    conn.Open()
                    Using reader As SqlDataReader = cmd.ExecuteReader()
                        While reader.Read()
                            ComboBoxMonth.Items.Add(reader("Order_Month").ToString())
                        End While
                    End Using
                End Using
            End Using

            ' Set default selection to the first month if available
            If ComboBoxMonth.Items.Count > 0 Then
                ComboBoxMonth.SelectedIndex = 0
            End If
        Catch ex As Exception
            MessageBox.Show("Error loading months: " & ex.Message)
        End Try
    End Sub

    Private Sub ComboBoxYear_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxYear.SelectedIndexChanged
        ' Load the months when a new year is selected
        LoadMonths(ComboBoxYear.SelectedItem.ToString())
        ' Reload DataGridView based on the selected year and month
        LoadDataGrid()
        ' Reload the report for the new year
        LoadReport()
    End Sub

    Private Sub ComboBoxMonth_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxMonth.SelectedIndexChanged
        ' Reload DataGridView based on the selected year and month
        LoadDataGrid()
    End Sub

    Private Sub LoadDataGrid()
        Try
            ' Create a DataTable to store data from the database
            Dim dt As New DataTable()

            ' Connect to the database and retrieve data filtered by the selected year and month
            Using conn As New SqlConnection(connectionString)
                Dim query As String = "SELECT * FROM View_ItemOrder2 WHERE Order_Year = @Year AND Order_Month = @Month"
                Using cmd As New SqlCommand(query, conn)
                    ' Set the selected year and month from ComboBox
                    cmd.Parameters.AddWithValue("@Year", ComboBoxYear.SelectedItem)
                    cmd.Parameters.AddWithValue("@Month", ComboBoxMonth.SelectedItem)

                    conn.Open()
                    Dim da As New SqlDataAdapter(cmd)
                    da.Fill(dt)  ' Fetch data into DataTable
                End Using
            End Using

            ' Bind DataTable to DataGridView1
            DataGridView1.DataSource = dt

            ' Calculate total for the selected month and display in Label
            Dim totalSum As Decimal = 0
            For Each row As DataRow In dt.Rows
                totalSum += Convert.ToDecimal(row("Item_Price_Total")) ' Example column for total price
            Next
            LabelTotal.Text = "Total for " & ComboBoxMonth.SelectedItem.ToString() & ": " & totalSum.ToString("C2")

        Catch ex As Exception
            MessageBox.Show("Error loading data: " & ex.Message)
        End Try
    End Sub

    Private Sub LoadReport()
        Try
            ' Create a DataTable to store data from the database
            Dim dt As New DataTable()

            ' Connect to the database and retrieve data from View_ItemExpenses filtered by the selected year
            Using conn As New SqlConnection(connectionString)
                Dim query As String = "SELECT * FROM View_ItemExpenses WHERE Order_Year = @Year"
                Using cmd As New SqlCommand(query, conn)
                    ' Set the selected year from ComboBox
                    cmd.Parameters.AddWithValue("@Year", ComboBoxYear.SelectedItem)

                    conn.Open()
                    Dim da As New SqlDataAdapter(cmd)
                    da.Fill(dt)  ' Fetch data into DataTable
                End Using
            End Using

            ' Create ReportDataSource for ReportViewer
            Dim rds As New ReportDataSource("DataSet1", dt)

            ' Set the path of the report to be used in ReportViewer
            Dim reportPath As String = Application.StartupPath & "\Reports\ReportItemOrder.rdlc"

            ' Clear old DataSource and add new DataSource
            ReportViewer1.LocalReport.DataSources.Clear()
            ReportViewer1.LocalReport.DataSources.Add(rds)

            ' Load and display the report in ReportViewer
            ReportViewer1.RefreshReport()

        Catch ex As Exception
            MessageBox.Show("Error loading report: " & ex.Message)
        End Try
    End Sub
End Class
