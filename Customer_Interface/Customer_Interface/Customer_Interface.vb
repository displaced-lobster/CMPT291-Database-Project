
Public Class Customer_Interface
    Private SQL As New SQLControl

    Private Function GetAccount()
        Return Customer_Login.UserAccount()
    End Function


    Private Sub Customer_Interface_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MdiParent = Main_Interface
        Dim user As String = GetAccount()
        ' clear table
        If SQL.SQLTable IsNot Nothing Then
            SQL.SQLTable.Clear()
        End If

        SQL.ExecuteQuery("SELECT * FROM Customer_Data WHERE account_number =" & user & ";")
        txtUserName.Text = SQL.SQLTable.Rows(0).Item("first_name") & " " & SQL.SQLTable.Rows(0).Item("last_name") ' print User name
    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        Customer_Login.Close()
        Me.Close()
        MsgBox("Current Session Closed")
    End Sub
End Class