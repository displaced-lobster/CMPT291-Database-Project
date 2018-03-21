Imports System.Data.SqlClient
Imports System.Random

Public Class Customer_SignUp
    Private SQL As New SQLControl

    Private Sub Customer_SignUp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MdiParent = Main_Interface
    End Sub

    Public Function CreateAccountNum() As Integer
        SQL.ExecuteQuery("SELECT COUNT(account_number) as cnt FROM Customer_Data")
        Return SQL.SQLTable.Rows(0).Item("cnt") + 1001
    End Function

    Private Sub AddUser() ' method for inserting new user
        ' create account number
        Dim accountNum = CreateAccountNum()
        ' create SQL parameters to add
        SQL.AddParam("@first", firstName.Text)
        SQL.AddParam("@last", lastName.Text)
        SQL.AddParam("@email", email.Text)
        ' Mandatory phone number 1
        SQL.AddParam("@phoneType1", phoneDrop1.Text)
        SQL.AddParam("@phoneNum1", num1.Text)
        ' address and payment info
        SQL.AddParam("@streetNum", streetNum.Text)
        SQL.AddParam("@street", street.Text)
        SQL.AddParam("@aptNum", aptNum.Text)
        SQL.AddParam("@city", city.Text)
        SQL.AddParam("@state", state.Text)
        SQL.AddParam("@zip", zip.Text)
        SQL.AddParam("@cardNum", Convert.ToInt32(cardNum.Text))
        SQL.AddParam("@date", Date.Now)
        SQL.AddParam("@accNum", accountNum)
        ' create password account vitals
        SQL.AddParam("@username", txtUser.Text)
        SQL.AddParam("@password", txtPass.Text) '.GetHashCode() could hash if needed
        ' set which ever membership
        If limited.Checked = True Then SQL.AddParam("@membership", "limited")
        If unlim1.Checked = True Then SQL.AddParam("@membership", "unlimited1")
        If unlim2.Checked = True Then SQL.AddParam("@membership", "unlimited2")
        If unlim3.Checked = True Then SQL.AddParam("@membership", "unlimited3")
        ' add values to table
        SQL.ExecuteQuery("INSERT INTO Customer_Data (account_number, first_name, last_name, city, " &
                         "state, zip_code, street, street_num, apartment_num, email, creation_date, " &
                         "credit_card_num, type) VALUES (@accNum, @first, @last, @city, @state, " &
                         "@zip, @street, @streetNum, @aptNum, @email, @date, @cardNum, @membership); " &
                         "INSERT INTO Customer_Passwords (account_number, username, password) " &
                         "VALUES (@accNum, @username, @password); " &
                         "INSERT INTO Customer_Phone_Numbers (account_number, telephone_num, type) " &
                         "VALUES (@accNum, @phoneNum1, @phoneType1);")
        If SQL.HasException(True) Then Exit Sub
        ' check if phone number field is filled and add additional numbers
        If phoneDrop2.Text <> "" Then
            SQL.AddParam("@phoneType2", phoneDrop2.Text)
            SQL.AddParam("@phoneNum2", num2.Text)
            SQL.AddParam("@accNum", accountNum)
            SQL.ExecuteQuery("INSERT INTO Customer_Phone_Numbers (account_number, telephone_num, type) " &
                             "VALUES (@accNum, @phoneNum2, @phoneType2);")
        End If
        If SQL.HasException(True) Then Exit Sub
        If phoneDrop3.Text <> "" Then
            SQL.AddParam("@phoneType3", phoneDrop3.Text)
            SQL.AddParam("@phoneNum3", num3.Text)
            SQL.AddParam("@accNum", accountNum)
            SQL.ExecuteQuery("INSERT INTO Customer_Phone_Numbers (account_number, telephone_num, type) " &
                             "VALUES (@accNum, @phoneNum3, @phoneType3);")
        End If
        If SQL.HasException(True) Then Exit Sub
        ' inform user of account creation
        MsgBox("User Created") ' for test
    End Sub

    Private Sub createAccount_Click(sender As Object, e As EventArgs) Handles createAccount.Click
        ' create user
        AddUser()
        ' exit page
        Me.Close()
    End Sub

    ' Apartment number should be able to be null so perhaps we need to change it
    Private Sub txtFields_TextChanged(sender As Object, e As EventArgs) Handles firstName.TextChanged, lastName.TextChanged,
            email.TextChanged, streetNum.TextChanged, street.TextChanged, aptNum.TextChanged, city.TextChanged, state.TextChanged,
            zip.TextChanged, cardNum.TextChanged, txtUser.TextChanged, txtPass.TextChanged, limited.CheckedChanged, unlim1.CheckedChanged,
            unlim2.CheckedChanged, unlim3.CheckedChanged, num1.TextChanged, phoneDrop1.TextChanged

        If Not String.IsNullOrWhiteSpace(firstName.Text) AndAlso Not String.IsNullOrWhiteSpace(lastName.Text) AndAlso
                Not String.IsNullOrWhiteSpace(email.Text) AndAlso Not String.IsNullOrWhiteSpace(streetNum.Text) AndAlso
                Not String.IsNullOrWhiteSpace(street.Text) AndAlso Not String.IsNullOrWhiteSpace(aptNum.Text) AndAlso
                Not String.IsNullOrWhiteSpace(city.Text) AndAlso Not String.IsNullOrWhiteSpace(state.Text) AndAlso
                Not String.IsNullOrWhiteSpace(zip.Text) AndAlso Not String.IsNullOrWhiteSpace(cardNum.Text) AndAlso
                Not String.IsNullOrWhiteSpace(txtUser.Text) AndAlso Not String.IsNullOrWhiteSpace(txtPass.Text) AndAlso
                Not String.IsNullOrWhiteSpace(phoneDrop1.Text) AndAlso Not String.IsNullOrWhiteSpace(num1.Text) AndAlso
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
        ' check to see if username exists
        SQL.ExecuteQuery("SELECT * " &
                         "FROM Customer_Passwords " &
                         "WHERE username='" & txtUser.Text & "' " &
                         "COLLATE SQL_Latin1_General_CP1_CS_AS") ' force case sensitive nature
        ' if so clear values in form
        If SQL.SQLTable.Rows.Count() > 0 Then
            MsgBox("Username Already Exists", MsgBoxStyle.Critical, "LOGIN FAILED")
            txtPass.Clear()
            txtUser.Clear()
            Return False
        End If
        Return True
    End Function

End Class
