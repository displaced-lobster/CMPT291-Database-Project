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
        phoneDrop1.Text = i.Item("phone_type")
        num1.Text = i.item("telephone_num")
        'check for more rows after
        streetNum.Text = i.item("street_num")
        street.Text = i.item("street")
        If i.item("apartment_num") <> "0" Then aptNum.Text = i.item("apartment_num") ' will be hopefully changed to null 
        city.Text = i.item("city")
        state.Text = i.item("state")
        zip.Text = i.item("zip_code")
        cardNum.Text = i.item("credit_card_num")
        If i.item("account_type") = "limited" Then
            limited.Checked = True
        ElseIf i.item("account_type") = "unlim1" Then
            unlim1.Checked = True
        ElseIf i.item("account_type") = "unlim2" Then
            unlim2.Checked = True
        ElseIf i.item("account_type") = "unlim3" Then
            unlim3.Checked = True
        End If
        txtUser.Text = i.item("username")

        If rowNumbers = 2 Then
            i = SQL.SQLTable.Rows(1)
            phoneDrop2.Text = (i).Item("phone_type")
            num2.Text = (i).item("telephone_num")
        ElseIf rowNumbers = 3 Then
            i = SQL.SQLTable.Rows(1)
            phoneDrop2.Text = (i).Item("phone_type")
            num2.Text = (i).item("telephone_num")
            i = SQL.SQLTable.Rows(2)
            phoneDrop3.Text = (i).Item("phone_type")
            num3.Text = (i).item("telephone_num")
        End If
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Me.Close()
        Customer_Interface.Show()
    End Sub
End Class