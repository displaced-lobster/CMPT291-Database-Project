Imports System.Data.SqlClient

Public Class Edit_Customer_Account

    Public accountNumber As Integer = CInt(Customer_Login.UserAccount())

    Private SQL As New SQLControl

    Private Sub Edit_Customer_Account_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MdiParent = Main_Interface

        'SQL.ExecuteQuery("SELECT * " &
        '                 "FROM Customer_Data as CD INNER JOIN Customer_Passwords as CP ON CD.account_number = CP.account_number " &
        '                 "    INNER JOIN Customer_Phone_Numbers as CPN ON CD.account_number = CPN.account_number ;")
        SQL.ExecuteQuery("SELECT * FROM Customer_Data as CD INNER JOIN Customer_Phone_Numbers as CPN ON CD.account_number=CPN.account_number " &
                         "INNER JOIN Customer_Passwords as CP ON CP.account_number=CPN.account_number WHERE CD.account_number = " + accountNumber.ToString + ";")

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
        If i.item("apartment_num").ToString <> "NULL" Then aptNum.Text = i.item("apartment_num").ToString ' deals with null and not null values
        city.Text = i.item("city")
        state.Text = i.item("state")
        zip.Text = i.item("zip_code")
        cardNum.Text = i.item("credit_card_num")
        If i.item("account_type") = "limited" Then
            limited.Checked = True
        ElseIf i.item("account_type") = "unlimited1" Then
            unlim1.Checked = True
        ElseIf i.item("account_type") = "unlimited2" Then
            unlim2.Checked = True
        ElseIf i.item("account_type") = "unlimited3" Then
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

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
        Customer_Interface.LoadData() ' update changes just in case
        Customer_Interface.Show()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        ' maybe start turning these into a function
        SQL.ExecuteQuery("SELECT * " &
                         "FROM Customer_Data as CD INNER JOIN Customer_Passwords as CP ON CD.account_number = CP.account_number " &
                         "    INNER JOIN Customer_Phone_Numbers as CPN ON CD.account_number = CPN.account_number;")
        If SQL.HasException(True) Then Exit Sub
        Dim rowNumbers As Integer = SQL.SQLTable.Rows.Count()
        Dim i As Object = SQL.SQLTable.Rows(0)
        ' check username and password
        If txtUser.Text <> i.Item("username") Then
            If IsUnique() = False Then Exit Sub ' add check to make sure that if they put in theyre old username that it does nothing
        End If
        If pwdCheck() = False Then Exit Sub
        ' check the numbers
        If num2.Text = "" Xor phoneDrop2.Text = "" Then
            num2.BackColor = Color.Yellow
            MsgBox("Both fields must be filled in for phone number 2")
            Exit Sub
        End If
        If num3.Text = "" Xor phoneDrop3.Text = "" Then
            num3.BackColor = Color.Yellow
            MsgBox("Both fields must be filled in for phone number 3")
            Exit Sub
        End If
        EditUser()
        ' exit page
        Me.Close()
        Customer_Interface.LoadData() ' update changes
        Customer_Interface.Show()
    End Sub

    Private Sub EditUser()
        ' get current information for comparison
        SQL.ExecuteQuery("SELECT * " &
                         "FROM Customer_Data as CD INNER JOIN Customer_Passwords as CP ON CD.account_number = CP.account_number " &
                         "    INNER JOIN Customer_Phone_Numbers as CPN ON CD.account_number = CPN.account_number;")
        If SQL.HasException(True) Then Exit Sub
        Dim rowNumbers As Integer = SQL.SQLTable.Rows.Count()
        Dim i As Object = SQL.SQLTable.Rows(0)
        Dim table As Object = SQL.SQLTable
        ' create SQL parameters to add
        If firstName.Text <> i.Item("first_name") And firstName.Text <> "" Then SQL.ExecuteQuery("UPDATE Customer_Data SET first_name='" + StrConv(firstName.Text, VbStrConv.ProperCase) +
                                                                                                 "' WHERE account_number=" + accountNumber.ToString + ";")
        If lastName.Text <> i.Item("last_name") And lastName.Text <> "" Then SQL.ExecuteQuery("UPDATE Customer_Data SET last_name='" + StrConv(lastName.Text, VbStrConv.ProperCase) +
                                                                                              "' WHERE account_number=" + accountNumber.ToString + ";")
        If email.Text <> i.Item("email") And email.Text <> "" Then SQL.ExecuteQuery("UPDATE Customer_Data SET email='" + email.Text + "' WHERE account_number=" + accountNumber.ToString + ";")
        If streetNum.Text <> i.Item("street_num") And streetNum.Text <> "" Then SQL.ExecuteQuery("UPDATE Customer_Data SET street_num=" + streetNum.Text + " WHERE account_number=" +
                                                                                                 accountNumber.ToString + ";")
        If street.Text <> i.Item("street") And street.Text <> "" Then SQL.ExecuteQuery("UPDATE Customer_Data SET street='" + street.Text + "' WHERE account_number=" + accountNumber.ToString + ";")
        ' check to see if apt number need to be null or not
        If aptNum.Text <> i.Item("apartment_num").ToString And aptNum.Text = "" Then
            MsgBox("changing to null")
            SQL.ExecuteQuery("UPDATE Customer_Data SET apartment_num=NULL WHERE account_number=" + accountNumber.ToString + ";")
        ElseIf aptNum.Text <> i.Item("apartment_num").ToString Then
            SQL.ExecuteQuery("UPDATE Customer_Data SET apartment_num='" + aptNum.Text + "' WHERE account_number=" + accountNumber.ToString + ";")
        End If

        If city.Text <> i.Item("city") And city.Text <> "" Then SQL.ExecuteQuery("UPDATE Customer_Data SET city='" + city.Text + "' WHERE account_number=" + accountNumber.ToString + ";")
        If state.Text <> i.Item("state") And state.Text <> "" Then SQL.ExecuteQuery("UPDATE Customer_Data SET state='" + state.Text + "' WHERE account_number=" + accountNumber.ToString + ";")
        If zip.Text <> i.Item("zip_code") And zip.Text <> "" Then SQL.ExecuteQuery("UPDATE Customer_Data SET zip_code='" + zip.Text + "' WHERE account_number=" + accountNumber.ToString + ";")
        If cardNum.Text <> i.Item("credit_card_num") And cardNum.Text <> "" Then SQL.ExecuteQuery("UPDATE Customer_Data SET credit_card_num='" + cardNum.Text + "' WHERE account_number=" +
                                                                                                  accountNumber.ToString + ";")
        updateNumbers(table, rowNumbers)
        ' account type
        If limited.Checked = True Then SQL.ExecuteQuery("UPDATE Customer_Data SET account_type='limited' WHERE account_number=" + accountNumber.ToString + ";")
        If unlim1.Checked = True Then SQL.ExecuteQuery("UPDATE Customer_Data SET account_type='unlim1' WHERE account_number=" + accountNumber.ToString + ";")
        If unlim2.Checked = True Then SQL.ExecuteQuery("UPDATE Customer_Data SET account_type='unlim2' WHERE account_number=" + accountNumber.ToString + ";")
        If unlim3.Checked = True Then SQL.ExecuteQuery("UPDATE Customer_Data SET account_type='unlim3' WHERE account_number=" + accountNumber.ToString + ";")
        ' username and password
        If txtUser.Text <> i.Item("username") And txtUser.Text <> "" Then SQL.ExecuteQuery("UPDATE Customer_Passwords SET username='" + txtUser.Text + "' WHERE account_number=" +
                                                                                           accountNumber.ToString + ";")
        If txtPass.Text <> i.Item("password") And txtPass.Text <> "" Then SQL.ExecuteQuery("UPDATE Customer_Passwords SET password='" + txtPass.Text + "' WHERE account_number=" +
                                                                                           accountNumber.ToString + ";")

        MsgBox("User has been updated") 'CreateObject("WScript.Shell").Popup("Welcome", 1, "Title") to have popup box that disappears
    End Sub
    Private Sub updateNumbers(table As Object, rows As Integer) ' update, remove and add phone numbers as needed
        ' update or remove a number from the table
        If phoneDrop1.Text <> table.Rows(0).Item("phone_type") And phoneDrop1.Text <> "" Then SQL.ExecuteQuery("UPDATE Customer_Phone_Numbers SET phone_type='" + phoneDrop1.Text +
                                                                      "' WHERE account_number=" + accountNumber.ToString + " AND telephone_num=" + table.Rows(0).Item("telephone_num") + ";")
        If num1.Text <> table.Rows(0).Item("telephone_num") And num1.Text <> "" Then SQL.ExecuteQuery("UPDATE Customer_Phone_Numbers SET telephone_num='" + num1.Text +
                                                                      "' WHERE account_number=" + accountNumber.ToString + " AND telephone_num=" + table.Rows(0).Item("telephone_num") + ";")
        If rows = 2 Then
            If phoneDrop2.Text <> table.Rows(1).Item("phone_type") And phoneDrop2.Text <> "" Then SQL.ExecuteQuery("UPDATE Customer_Phone_Numbers SET phone_type='" + phoneDrop2.Text +
                                                                      "' WHERE account_number=" + accountNumber.ToString + " AND telephone_num=" + table.Rows(1).Item("telephone_num") + ";")
            If num2.Text <> table.Rows(1).Item("telephone_num") And num2.Text <> "" Then SQL.ExecuteQuery("UPDATE Customer_Phone_Numbers SET telephone_num='" + num2.Text +
                                                                      "' WHERE account_number=" + accountNumber.ToString + " AND telephone_num=" + table.Rows(1).Item("telephone_num") + ";")
            If phoneDrop2.Text = "" And num2.Text = "" Then SQL.ExecuteQuery("DELETE FROM Customer_Phone_Numbers WHERE account_number='" + accountNumber.ToString + "' AND telephone_num='" +
                                                                             table.Rows(1).Item("telephone_num") + "';")
        End If
        If rows = 3 Then
            If phoneDrop3.Text <> table.Rows(2).Item("phone_type") And phoneDrop3.Text <> "" Then SQL.ExecuteQuery("UPDATE Customer_Phone_Numbers SET phone_type='" + phoneDrop3.Text +
                                                                      "' WHERE account_number=" + accountNumber.ToString + " AND telephone_num=" + table.Rows(2).Item("telephone_num") + ";")
            If num3.Text <> table.Rows(1).Item("telephone_num") And num3.Text <> "" Then SQL.ExecuteQuery("UPDATE Customer_Phone_Numbers SET telephone_num='" + num3.Text +
                                                                      "' WHERE account_number=" + accountNumber.ToString + " AND telephone_num=" + table.Rows(2).Item("telephone_num") + ";")
            If phoneDrop3.Text = "" And num3.Text = "" Then SQL.ExecuteQuery("DELETE FROM Customer_Phone_Numbers WHERE account_number='" + accountNumber.ToString + "' AND telephone_num='" +
                                                                             table.Rows(2).Item("telephone_num") + "';")
        End If
        ' add new phone number entries
        If phoneDrop2.Text <> "" And num2.Text <> "" Then
            SQL.AddParam("@phoneType2", phoneDrop2.Text)
            SQL.AddParam("@phoneNum2", num2.Text)
            SQL.AddParam("@accNum", accountNumber)
            SQL.ExecuteQuery("INSERT INTO Customer_Phone_Numbers (account_number, telephone_num, phone_type) " &
                                 "VALUES (@accNum, @phoneNum2, @phoneType2);")
        End If
        If phoneDrop3.Text <> "" And num3.Text <> "" Then
            SQL.AddParam("@phoneType3", phoneDrop3.Text)
            SQL.AddParam("@phoneNum3", num3.Text)
            SQL.AddParam("@accNum", accountNumber)
            SQL.ExecuteQuery("INSERT INTO Customer_Phone_Numbers (account_number, telephone_num, phone_type) " &
                                 "VALUES (@accNum, @phoneNum3, @phoneType3);")
        End If
    End Sub
    Private Function IsUnique() As Boolean
        ' Clear Existing records
        If SQL.SQLTable IsNot Nothing Then
            SQL.SQLTable.Clear()
        End If

        ' check against SQL injection attacks
        Dim invalid As String = " ,./<>?;'\:[]{}+_)(*&^%$#@!~=`"""
        While txtUser.Text.Where(Function(ch) invalid.Contains(ch)).Count > 0
            MsgBox("There can be no non-alphanumeric characters in the username")
            txtUser.Clear()
            txtPass.Clear()
            Return False
        End While
        Dim otherInvalid As String = " '"
        While txtPass.Text.Where(Function(ch) invalid.Contains(ch)).Count > 0
            MsgBox("There can be no spaces or ""'"" in the password")
            txtPass.Clear()
            Return False
        End While

        ' check to see if username exists
        SQL.ExecuteQuery("SELECT * " &
                         "FROM Customer_Passwords " &
                         "WHERE username='" & txtUser.Text & "' COLLATE Latin1_General_CS_AS") ' force case sensitive nature

        ' if so clear values in form
        If SQL.SQLTable.Rows.Count() > 0 Then
            MsgBox("Username Already Exists", MsgBoxStyle.Critical, "LOGIN FAILED") ' maybe need to change
            txtPass.Clear()
            txtUser.Clear()
            Return False
        End If
        Return True
    End Function

    Private Function pwdCheck() As Boolean
        If txtPass.Text <> txtPassCheck.Text Then
            txtPass.Clear()
            txtPassCheck.Clear()
            MsgBox("Password must match in both fields")
            Return False
        End If
        Return True
    End Function

    Private Sub btnRem2_Click(sender As Object, e As EventArgs) Handles btnRem2.Click
        num2.Clear()
        phoneDrop2.Text = ""
    End Sub

    Private Sub btnRem3_Click(sender As Object, e As EventArgs) Handles btnRem3.Click
        num3.Clear()
        phoneDrop3.Text = ""
    End Sub
End Class