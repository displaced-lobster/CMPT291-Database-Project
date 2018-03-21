
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

        SQL.ExecuteQuery("SELECT * FROM Customer_Data WHERE account_number =" & user & ";") ' join doesn't seem to work
        txtUserName.Text = SQL.SQLTable.Rows(0).Item("first_name") & " " & SQL.SQLTable.Rows(0).Item("last_name") ' print User name

        Dim i As Object = SQL.SQLTable.Rows(0)
        Dim accountNum As String = i.Item("account_number")
        Dim fullName As String = i.Item("first_name") & " " & i.Item("last_name")
        Dim email As String = i.Item("email")
        Dim address As String = "#" & i.Item("apartment_num") & " " & i.Item("street_num") & " " & i.Item("street") & vbCrLf &
                                "    " & i.Item("city") & ", " & i.Item("state") & ", " & i.Item("zip_code")
        Dim creditCard As String = i.Item("credit_card_num")
        Dim type As String = i.Item("type")
        Dim creation As String = i.Item("creation_date")

        'SQL.ExecuteQuery()
        'txtInfo.Text = 






    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        Me.Close()
        Customer_Login.Close()
        MsgBox("Current Session Closed")
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub
End Class