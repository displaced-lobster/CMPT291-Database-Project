Imports System.Data.SqlClient
Imports System.Random

Public Class Customer_SignUp
    Private SQL As New SQLControl

    Private Sub Customer_SignUp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MdiParent = Main_Interface
    End Sub

    Public Function CreateAccountNum() As Integer
        SQL.ExecuteQuery("SELECT max(account_number) as cnt FROM Customer_Data") ' changed count() to max()
        If IsDBNull(SQL.SQLTable.Rows(0).Item("cnt")) Then
            Return 1
        End If
        Return SQL.SQLTable.Rows(0).Item("cnt") + 1 ' changed from 1001 to 1
    End Function

    Private Sub AddUser() ' method for inserting new user
        ' create account number
        Dim accountNum = CreateAccountNum()
        ' create SQL parameters to add
        SQL.AddParam("@first", StrConv(firstName.Text, VbStrConv.ProperCase)) ' capitalize the first letter if it is not already
        SQL.AddParam("@last", StrConv(lastName.Text, VbStrConv.ProperCase))
        SQL.AddParam("@email", email.Text)
        ' Mandatory phone number 1
        SQL.AddParam("@phoneType1", phoneDrop1.Text)
        SQL.AddParam("@phoneNum1", num1.Text)
        ' address and payment info
        SQL.AddParam("@streetNum", streetNum.Text)
        SQL.AddParam("@street", street.Text)
        SQL.AddParam("@city", city.Text)
        SQL.AddParam("@state", state.Text)
        SQL.AddParam("@zip", zip.Text)
        SQL.AddParam("@cardNum", cardNum.Text)
        SQL.AddParam("@date", Date.Now)
        SQL.AddParam("@accNum", accountNum)
        ' create password account vitals
        SQL.AddParam("@username", txtUser.Text)
        SQL.AddParam("@password", txtPass.Text) '.GetHashCode() could hash if needed
        ' set whichever membership
        If limited.Checked = True Then SQL.AddParam("@membership", "limited")
        If unlim1.Checked = True Then SQL.AddParam("@membership", "unlimited1")
        If unlim2.Checked = True Then SQL.AddParam("@membership", "unlimited2")
        If unlim3.Checked = True Then SQL.AddParam("@membership", "unlimited3")
        ' add values to table
        If aptNum.Text = "" Then
            SQL.ExecuteQuery("INSERT INTO Customer_Data (account_number, first_name, last_name, city, " &
                         "state, zip_code, street, street_num, apartment_num, email, creation_date, " &
                         "credit_card_num, account_type) VALUES (@accNum, @first, @last, @city, @state, " &
                         "@zip, @street, @streetNum, NULL, @email, @date, @cardNum, @membership); " &
                         "INSERT INTO Customer_Passwords (account_number, username, password) " &
                         "VALUES (@accNum, @username, @password); " &
                         "INSERT INTO Customer_Phone_Numbers (account_number, telephone_num, phone_type) " &
                         "VALUES (@accNum, @phoneNum1, @phoneType1);")
        Else
            SQL.AddParam("@aptNum", aptNum.Text)
            SQL.ExecuteQuery("INSERT INTO Customer_Data (account_number, first_name, last_name, city, " &
                         "state, zip_code, street, street_num, apartment_num, email, creation_date, " &
                         "credit_card_num, account_type) VALUES (@accNum, @first, @last, @city, @state, " &
                         "@zip, @street, @streetNum, @aptNum, @email, @date, @cardNum, @membership); " &
                         "INSERT INTO Customer_Passwords (account_number, username, password) " &
                         "VALUES (@accNum, @username, @password); " &
                         "INSERT INTO Customer_Phone_Numbers (account_number, telephone_num, phone_type) " &
                         "VALUES (@accNum, @phoneNum1, @phoneType1);")
        End If
        If SQL.HasException(True) Then Exit Sub
        addNumbers(accountNum)
        MsgBox("User Created") ' inform user of account creation
    End Sub
    Private Sub addNumbers(accountNum As String) ' fill in the phone number fields
        ' check if phone number field is filled and add additional numbers
        If phoneDrop2.Text <> "" And num2.Text <> "" Then
            MsgBox("phone 2")
            SQL.AddParam("@phoneType2", phoneDrop2.Text)
            SQL.AddParam("@phoneNum2", num2.Text)
            SQL.AddParam("@accNum", accountNum)
            SQL.ExecuteQuery("INSERT INTO Customer_Phone_Numbers (account_number, telephone_num, phone_type) " &
                             "VALUES (@accNum, @phoneNum2, @phoneType2);")
        End If
        If SQL.HasException(True) Then Exit Sub
        If phoneDrop3.Text <> "" And num3.Text <> "" Then
            MsgBox("phone 3")
            SQL.AddParam("@phoneType3", phoneDrop3.Text)
            SQL.AddParam("@phoneNum3", num3.Text)
            SQL.AddParam("@accNum", accountNum)
            SQL.ExecuteQuery("INSERT INTO Customer_Phone_Numbers (account_number, telephone_num, phone_type) " &
                             "VALUES (@accNum, @phoneNum3, @phoneType3);")
        End If
        If SQL.HasException(True) Then Exit Sub
    End Sub
    Private Function checkFields() As Boolean
        If (IsNumeric(num1.Text) AndAlso phoneDrop1.Text <> "") AndAlso
            ((IsNumeric(num2.Text) AndAlso phoneDrop2.Text <> "") Or (num2.Text = "" AndAlso phoneDrop2.Text = "")) AndAlso
            ((IsNumeric(num3.Text) AndAlso phoneDrop3.Text <> "") Or (num3.Text = "" AndAlso phoneDrop3.Text = "")) AndAlso
            IsNumeric(streetNum.Text) AndAlso (IsNumeric(aptNum.Text) Or aptNum.Text = "") AndAlso IsNumeric(zip.Text) AndAlso IsNumeric(cardNum.Text) Then
            Return True
        End If
        ' check the phone number fields to make sure they are filled in
        If num1.Text = "" Xor phoneDrop1.Text = "" Then
            num1.BackColor = Color.Yellow
            MsgBox("Please fill in both the phone number and type")
            Return False
        End If
        If num2.Text = "" Xor phoneDrop2.Text = "" Then
            num2.BackColor = Color.Yellow
            MsgBox("Please fill in both the phone number and type")
            Return False
        End If
        If num3.Text = "" Xor phoneDrop3.Text = "" Then
            num3.BackColor = Color.Yellow
            MsgBox("Please fill in both the phone number and type")
            Return False
        End If
        ' check numeric fields
        If Not IsNumeric(num1.Text) Then
            num1.Clear()
            num1.BackColor = Color.Yellow
        End If
        If Not IsNumeric(num2.Text) And num2.Text <> "" Then
            num2.Clear()
            num2.BackColor = Color.Yellow
        End If
        If Not IsNumeric(num3.Text) And num3.Text <> "" Then
            num3.Clear()
            num3.BackColor = Color.Yellow
        End If
        If Not IsNumeric(streetNum.Text) Then
            streetNum.Clear()
            streetNum.BackColor = Color.Yellow
        End If
        If Not IsNumeric(aptNum.Text) And aptNum.Text <> "" Then
            aptNum.Clear()
            aptNum.BackColor = Color.Yellow
        End If
        If Not IsNumeric(zip.Text) Then
            zip.Clear()
            zip.BackColor = Color.Yellow
        End If
        If Not IsNumeric(cardNum.Text) Then
            cardNum.Clear()
            cardNum.BackColor = Color.Yellow
        End If
        MsgBox("Fields requiring numbers must be numeric")
        Return False
    End Function

    Private Sub createAccount_Click(sender As Object, e As EventArgs) Handles createAccount.Click
        ' create user
        If pwdCheck() = False Then Exit Sub
        ' check parameters
        If checkFields() = False Then Exit Sub
        AddUser()
        ' exit page
        Me.Close()
    End Sub

    ' Apartment number should be able to be null so perhaps we need to change it
    Private Sub txtFields_TextChanged(sender As Object, e As EventArgs) Handles firstName.TextChanged, lastName.TextChanged,
            email.TextChanged, streetNum.TextChanged, street.TextChanged, city.TextChanged, state.TextChanged, zip.TextChanged,
            cardNum.TextChanged, txtUser.TextChanged, txtPass.TextChanged, limited.CheckedChanged, unlim1.CheckedChanged,
            unlim2.CheckedChanged, unlim3.CheckedChanged, num1.TextChanged, phoneDrop1.TextChanged, txtPassCheck.TextChanged

        If Not String.IsNullOrWhiteSpace(firstName.Text) AndAlso Not String.IsNullOrWhiteSpace(lastName.Text) AndAlso
                Not String.IsNullOrWhiteSpace(email.Text) AndAlso Not String.IsNullOrWhiteSpace(streetNum.Text) AndAlso
                Not String.IsNullOrWhiteSpace(street.Text) AndAlso Not String.IsNullOrWhiteSpace(city.Text) AndAlso
                Not String.IsNullOrWhiteSpace(state.Text) AndAlso Not String.IsNullOrWhiteSpace(zip.Text) AndAlso
                Not String.IsNullOrWhiteSpace(cardNum.Text) AndAlso Not String.IsNullOrWhiteSpace(txtUser.Text) AndAlso
                Not String.IsNullOrWhiteSpace(txtPass.Text) AndAlso Not String.IsNullOrWhiteSpace(phoneDrop1.Text) AndAlso
                Not String.IsNullOrWhiteSpace(num1.Text) AndAlso Not String.IsNullOrWhiteSpace(txtPassCheck.Text) AndAlso
                (limited.Checked = True Or unlim1.Checked = True Or unlim2.Checked = True Or unlim3.Checked = True) AndAlso
                IsUnique() = True Then

            createAccount.Enabled = True
            ' is there a way to poll to see if the true conditions have changed ?
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
            MsgBox("Username Already Exists", MsgBoxStyle.Critical, "LOGIN FAILED")
            txtPass.Clear()
            txtUser.Clear()
            Return False
        End If
        Return True
    End Function

    Private Function pwdCheck() As Boolean ' check to make sure that the password fields match
        If txtPass.Text <> txtPassCheck.Text Then
            txtPass.Clear()
            txtPassCheck.Clear()
            MsgBox("Password must match in both fields")
            Return False
        End If
        Return True
    End Function

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class
