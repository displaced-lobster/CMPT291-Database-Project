Imports System.Linq


Public Class Customer_Login
    Private SQL As New SQLControl
    Public ValidUser As String ' global to pass user credentials to other classes

    Public Function UserAccount() As String
        Return ValidUser
    End Function

    Private Sub Customer_Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MdiParent = Main_Interface
    End Sub

    Private Function IsAuthenticated() As Boolean
        ' Clear Existing records
        If SQL.SQLTable IsNot Nothing Then
            SQL.SQLTable.Clear()
        End If

        ' check against SQL injection attacks
        Dim invalid As String = " ,./<>?;'\:[]{}+_)(*&^%$#@!~=-`"""
        While username.Text.Where(Function(ch) invalid.Contains(ch)).Count > 0
            MsgBox("There can be no non-alphanumeric characters in the username")
            username.Clear()
            passwd.Clear()
            Return False
        End While
        Dim otherInvalid As String = " '"
        While passwd.Text.Where(Function(ch) invalid.Contains(ch)).Count > 0
            MsgBox("There can be no spaces or ""'"" in the password")
            passwd.Clear()
            Return False
        End While

        SQL.ExecuteQuery("SELECT * " &
                         "FROM Customer_Passwords " &
                         "WHERE username='" & username.Text & "' COLLATE Latin1_General_CS_AS " & ' force case sensitivity
                         "AND password='" & passwd.Text & "' COLLATE Latin1_General_CS_AS;")

        If SQL.SQLTable.Rows.Count() <= 0 Then
            MsgBox("Invalid Credentials", MsgBoxStyle.Critical, "LOGIN FAILED")
            ' ideally a log would be made at this point for an invalid authentication
            username.Clear()
            passwd.Clear()
            Return False
        End If
        Return True
    End Function

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        username.Clear()
        passwd.Clear()
    End Sub

    Private Sub AccessAccount_Click(sender As Object, e As EventArgs) Handles AccessAccount.Click
        If SQL.HasConnection = True Then
            If IsAuthenticated() = True Then
                ValidUser = SQL.SQLTable.Rows(0).Item("account_number") ' pass authenticated primary key to global variable
                'MsgBox("Login Successful") ' for test purposes
                Me.Hide() ' keep open to access global account number for duration of session
                Customer_Interface.Show()
            End If
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
        Main_Interface.pbBlueBox.Show()
    End Sub
End Class