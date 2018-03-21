Public Class Customer_Login
    Private SQL As New SQLControl
    Private ValidUser As String

    Private Sub Customer_Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MdiParent = Main_Interface
    End Sub

    Private Function IsAuthenticated() As Boolean
        ' Clear Existing records
        If Sql.SQLTable IsNot Nothing Then
            Sql.SQLTable.Clear()
        End If

        SQL.ExecuteQuery("SELECT * " &
                         "FROM Customer_Passwords " &
                         "WHERE username='" & username.Text & "' " &
                         "AND password='" & passwd.Text & "' " &
                         "COLLATE SQL_Latin1_General_CP1_CS_AS") ' force case sensitive nature

        If SQL.SQLTable.Rows.Count() <= 0 Then
            MsgBox("Invalid Credentials.", MsgBoxStyle.Critical, "LOGIN FAILED")
            Return False
        End If
        Return True

    End Function


    Private Sub accessAccount_Click(sender As Object, e As EventArgs) Handles accessAccount.Click
        If SQL.HasConnection = True Then
            If IsAuthenticated() = True Then
                ValidUser = username.Text
                MsgBox("Login Successful")
            End If
        End If
    End Sub
End Class