Public Class FormInformation

    Private staffID As Integer

    ' Constructor รับค่า Staff_ID จากฟอร์มอื่น
    Public Sub New(selectedStaffID As Integer)
        InitializeComponent()
        staffID = selectedStaffID
    End Sub

    Private Sub FormInformation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Wellmeadows_HospitalDataSet.Qualification' table. You can move, or remove it, as needed.
        Me.QualificationTableAdapter.Fill(Me.Wellmeadows_HospitalDataSet.Qualification)
        'TODO: This line of code loads data into the 'Wellmeadows_HospitalDataSet.Work_Experience' table. You can move, or remove it, as needed.
        Me.Work_ExperienceTableAdapter.Fill(Me.Wellmeadows_HospitalDataSet.Work_Experience)

        QualificationBindingSource.Filter = "Staff_ID = " & staffID

        ' กรองข้อมูล Work Experience โดยใช้ Staff_ID
        Work_ExperienceBindingSource.Filter = "Staff_ID = " & staffID
    End Sub


End Class