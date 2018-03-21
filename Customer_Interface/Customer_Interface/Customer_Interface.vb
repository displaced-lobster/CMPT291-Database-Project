
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

        For Each i As Object In SQL.SQLTable.Rows
            txtInfo.Text = "Account Number: " & i.Item("account_number") & vbCrLf &
                           "Name: " & i.Item("first_name") & " " & i.item("last_name") & vbCrLf &
                           "Email: " & i.Item("email") & vbCrLf & vbCrLf &
                           "Address: " & "#" & i.Item("apartment_num") & " " & i.Item("street_num") & " " & i.Item("street") & vbCrLf &
                           "    " & i.Item("city") & ", " & i.Item("state") & ", " & i.Item("zip_code") & vbCrLf & vbCrLf &
                           "Card Number: " & i.Item("credit_card_num") & vbCrLf & vbCrLf &
                           "Account Type: " & i.Item("type") & vbCrLf & ' add from other table
                           "Account Created On: " & i.Item("creation_date")
        Next
    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        Me.Close()
        Customer_Login.Close()
        MsgBox("Current Session Closed")
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub
End Class