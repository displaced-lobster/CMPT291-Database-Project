Imports System.Data.SqlClient

Public Class Edit_Customer_Account
    Public accountNumber As Integer = CInt(Customer_Login.UserAccount())
    Private SQL As New SQLControl

    Private Sub Edit_Customer_Account_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MdiParent = Main_Interface

        SQL.ExecuteQuery("SELECT * " &
                         "FROM Customer_Data as CD INNER JOIN Customer_Passwords as CP ON CD.account_number = CP.account_number " &
                         "    INNER JOIN Customer_Phone_Numbers as CPN ON CD.account_number = CPN.account_number;")
        Dim rowNumbers As Integer = SQL.SQLTable.Rows.Count()
        Dim i As Object = SQL.SQLTable.Rows(0)
        ' load all fields with current information
        firstName.Text = i.Item("first_name")
        lastName.Text = i.item("last_name")
        email.Text = i.Item("email")
        phoneDrop1.Text = i.Item("type1") ' maybe need to change name in table for joining
        'num1.Text = i.Item("")

    End Sub

    Sub Reload()
        SQL.ExecuteQuery("SELECT * " &
                         "FROM Customer_Data as CD INNER JOIN Customer_Passwords as CP ON CD.account_number = CP.account_number " &
                         "    INNER JOIN Customer_Phone_Numbers as CPN ON CD.account_number = CPN.account_number;")
        Dim rowNumbers As Integer = SQL.SQLTable.Rows.Count()
    End Sub
End Class