Public Class Manager_LogIn
    Private SQL As New SQLControl
    Public ValidUser As String

    Public Function UserAccount() As String
        Return ValidUser
    End Function

    Private Function IsAuthenticated()
        If SQL.SQLTable IsNot Nothing Then
            SQL.SQLTable.Clear()
        End If

        Dim invalid As String = " ,./<>?;'\:[]{}+_)(*&^%$#@!~=-`"""

        While username.Text.Where(Function(ch) invalid.Contains(ch)).Count > 0
            MsgBox("Username can only contain alphanumeric characters.")
            username.Clear()
            passwd.Clear()
            Return False
        End While

        Dim otherInvalid As String = " '"
        While passwd.Text.Where(Function(ch) invalid.Contains(ch)).Count > 0
            MsgBox("Password cannot contain spaces or ""'"".")
            passwd.Clear()
            Return False
        End While
        SQL.AddParam("@uname", username.Text)
        SQL.AddParam("@passwd", passwd.Text)
        SQL.ExecuteQuery("SELECT * FROM employee_passwords WHERE username = @uname " &
                         "COLLATE Latin1_General_CS_AS " &
                         "And password = @passwd COLLATE Latin1_General_CS_AS;")

        If SQL.SQLTable.Rows.Count() <= 0 Then
            MsgBox("Invalid username or password.")
            username.Clear()
            passwd.Clear()
            Return False
        End If

        Return True
    End Function

    Private Sub AccessAccount_Click(sender As Object, e As EventArgs) Handles AccessAccount.Click
        If SQL.HasConnection = True Then
            If IsAuthenticated() = True Then
                ValidUser = SQL.SQLTable.Rows(0).Item("SIN")
                Me.Hide()
                Main_Manager_Interface.Show()
            End If
        End If
    End Sub

    Private Sub Manager_LogIn_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MdiParent = Main_Interface
    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        username.Clear()
        passwd.Clear()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
        Main_Interface.pbBlueBox.Show()
    End Sub
End Class