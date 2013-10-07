Option Strict On

Public Class Form1

    Private Sub btnDetermine_Click(sender As System.Object, e As System.EventArgs) Handles btnDetermine.Click
        Dim Name As String
        Name = txtFullName.Text
        txtFirstName.Text = FirstName(name)
    End Sub

    Function FirstName(ByVal name As String) As String

        'Find First Space
        Dim idx As Integer
        idx = name.IndexOf(" ")

        'Extract First Name
        Dim fName As String
        fName = name.Substring(0, idx)

        Return fName


    End Function

End Class
