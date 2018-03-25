Public Class Customer_Rep
    Public SQL As New SQLControl
    Private Sub rec_order_Click(sender As Object, e As EventArgs) Handles rec_order.Click

    End Sub

    Private Sub Customer_Rep_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MdiParent = Main_Interface
        SQL.ExecuteQuery("SELECT max(account_number) FROM customer_data")
        addAcctNum.Text = (SQL.SQLTable.Rows(0).ItemArray(0) + 1).ToString()
    End Sub

    Private Sub LoadData(Optional Query As String = "")
        If Query = "" Then
            SQL.ExecuteQuery("SELECT * FROM customer_data;")
        Else
            SQL.ExecuteQuery(Query)
        End If

        ' Error Handling
        If SQL.HasException(False) Then Exit Sub ' check for errors and exit gracefully

        CustData.DataSource = SQL.SQLTable
    End Sub

    Private Sub FindCust()
        If AcctNum.TextLength = 0 And FName.TextLength = 0 And LName.TextLength = 0 Then
            LoadData()
        Else
            Dim Query As String = "SELECT * FROM customer_data WHERE"
            If AcctNum.TextLength > 0 Then
                SQL.AddParam("@acctnum", AcctNum.Text)
                Query += " account_number = @acctnum"
            ElseIf FName.TextLength > 0 And LName.TextLength > 0 Then
                SQL.AddParam("@fname", "%" & FName.Text & "%")
                SQL.AddParam("@lname", "%" & LName.Text & "%")
                Query += " first_name Like @fname and last_name LIKE @lname"
            ElseIf FName.TextLength > 0 Then
                SQL.AddParam("@fname", "%" & FName.Text & "%")
                Query += " first_name LIKE @fname"
            ElseIf LName.TextLength > 0 Then
                SQL.AddParam("@lname", "%" & LName.Text & "%")
                Query += " last_name LIKE @lname"
            End If
            Query += ";"
            LoadData(Query)
        End If
    End Sub

    Private Sub AddCust()
        SQL.AddParam("@acctnum", addAcctNum.Text)
        SQL.AddParam("@fname", addFName.Text)
        SQL.AddParam("@lname", addLName.Text)
        SQL.AddParam("@email", addEmail.Text)
        SQL.AddParam("@cc", addCC.Text)
        SQL.AddParam("@strnum", addStreetNum.Text)
        SQL.AddParam("@strname", addStreetName.Text)
        SQL.AddParam("@city", addCity.Text)
        SQL.AddParam("@state", addState.Text)
        SQL.AddParam("@zip", addZip.Text)
        SQL.AddParam("@aptnum", addAPTNum.Text)

        If Lim1.Checked Then
            SQL.AddParam("@type", "lim1")
        ElseIf Unlim1.Checked Then
            SQL.AddParam("@type", "unlim1")
        ElseIf Unlim2.Checked Then
            SQL.AddParam("@type", "unlim2")
        Else
            SQL.AddParam("@type", "unlim3")
        End If

        SQL.ExecuteQuery("INSERT INTO customer_data (account_number, first_name, last_name, city, state, zip_code, street, street_num, apartment_num, email, creation_date, credit_card_num, account_type) " &
            "VALUES (@acctnum, @fname, @lname, @city, @state, @zip, @strname, @strnum, @aptnum, @email, GETDATE(), @cc, @type);")

        If addNum1.TextLength > 0 Then
            SQL.AddParam("@acctnum", addAcctNum.Text)
            SQL.AddParam("@num1", addNum1.Text)
            If Home1.Checked Then
                SQL.AddParam("@type1", "home")
            ElseIf Work1.Checked Then
                SQL.AddParam("@type1", "work")
            Else
                SQL.AddParam("@type1", "cell")
            End If
            SQL.ExecuteQuery("INSERT INTO customer_phone_numbers (account_number, telephone_num, type) VALUES (@acctnum, @num1, @type1);")
        End If

    End Sub

    Private Sub Find_Click(sender As Object, e As EventArgs) Handles Find.Click
        FindCust()
    End Sub

    Private Sub add_cust_Click(sender As Object, e As EventArgs) Handles add_cust.Click
        AddCust()
    End Sub
End Class