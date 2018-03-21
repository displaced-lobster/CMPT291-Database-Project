Imports System.Data.SqlClient
Imports System.Random

Public Class Customer_SignUp
    Private SQL As New SQLControl

    Private Sub Customer_SignUp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MdiParent = Main_Interface
    End Sub

    Private Sub AddUser() ' method for inserting new user
        ' create random number for ID
        ' need to check to make sure it is not already in the table, maybe a global variable for account instead
        Dim randNum As Integer
        Randomize()
        randNum = Int(Rnd() * 999) + 1

        ' create SQL parameters to add
        SQL.AddParam("@first", firstName.Text)
        SQL.AddParam("@last", lastName.Text)
        SQL.AddParam("@email", email.Text)

        ' Mandatory phone number 1
        ' needs to be adjusted so that the values are added to the right table
        SQL.AddParam("@phoneType1", phoneDrop1.ToString) ' get drop down value
        SQL.AddParam("@phoneNum1", num1.Text)
        ' Extra numbers
        SQL.AddParam("@phoneType2", phoneDrop2.ToString)
        SQL.AddParam("@phoneNum2", num2.Text)
        SQL.AddParam("@phoneType3", phoneDrop3.ToString)
        SQL.AddParam("@phoneNum3", num3.Text)

        SQL.AddParam("@streetNum", streetNum.Text)
        SQL.AddParam("@street", street.Text)
        SQL.AddParam("@aptNum", aptNum.Text)
        SQL.AddParam("@city", city.Text)
        SQL.AddParam("@state", state.Text)
        SQL.AddParam("@zip", zip.Text)
        SQL.AddParam("@cardType", cardType.Text)
        SQL.AddParam("@cardNum", Convert.ToInt32(cardNum.Text))
        SQL.AddParam("@date", Date.Now)
        SQL.AddParam("@accNum", randNum)
        ' set which ever membership
        ' need to figure out which table this will go to
        If limited.Checked = True Then SQL.AddParam("@membership", limited.Checked)
        If unlim1.Checked = True Then SQL.AddParam("@membership", unlim1.Checked)
        If unlim2.Checked = True Then SQL.AddParam("@membership", unlim2.Checked)
        If unlim3.Checked = True Then SQL.AddParam("@membership", unlim3.Checked)

        SQL.ExecuteQuery("INSERT INTO customer_data (account_number, first_name, last_name, city, " &
                         "state, zip_code, street, street_num, apartment_num, email, creation_date, " &
                         "credit_card_num, type) VALUES (@accNum, @first, @last, @city, @state, " &
                         "@zip, @street, @streetNum, @aptNum, @email, @date, @cardNum, @cardType);")

        If SQL.HasException(True) Then Exit Sub
        MsgBox("User Created") ' for test
    End Sub

    Private Sub createAccount_Click(sender As Object, e As EventArgs) Handles createAccount.Click
        ' create user
        AddUser()
        ' exit page
        'Me.Close()

    End Sub

    ' Apartment number should be able to be null so perhaps we need to change it
    Private Sub txtFields_TextChanged(sender As Object, e As EventArgs) Handles firstName.TextChanged, lastName.TextChanged,
            email.TextChanged, streetNum.TextChanged, street.TextChanged, aptNum.TextChanged, city.TextChanged, state.TextChanged,
            zip.TextChanged, cardType.TextChanged, cardNum.TextChanged

        If Not String.IsNullOrWhiteSpace(firstName.Text) AndAlso Not String.IsNullOrWhiteSpace(lastName.Text) AndAlso
                Not String.IsNullOrWhiteSpace(email.Text) AndAlso Not String.IsNullOrWhiteSpace(streetNum.Text) AndAlso
                Not String.IsNullOrWhiteSpace(street.Text) AndAlso Not String.IsNullOrWhiteSpace(aptNum.Text) AndAlso
                Not String.IsNullOrWhiteSpace(city.Text) AndAlso Not String.IsNullOrWhiteSpace(state.Text) AndAlso
                Not String.IsNullOrWhiteSpace(zip.Text) AndAlso Not String.IsNullOrWhiteSpace(cardType.Text) AndAlso
                Not String.IsNullOrWhiteSpace(cardNum.Text) Then
            createAccount.Enabled = True
            ' is there a way to poll to see if the true conditions have changed
        End If
    End Sub


End Class
