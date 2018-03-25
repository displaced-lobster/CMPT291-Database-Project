Public Class Customer_Rep
    Public SQL As New SQLControl
    Private Sub rec_order_Click(sender As Object, e As EventArgs) Handles recOrder.Click
        CreateOrder()
    End Sub

    Private Sub Customer_Rep_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MdiParent = Main_Interface
        SQL.ExecuteQuery("SELECT max(account_number) FROM customer_data")
        addAcctNum.Text = (SQL.SQLTable.Rows(0).ItemArray(0) + 1).ToString()
        recDate.Text = Today()
        SQL.ExecuteQuery("SELECT max(order_id) FROM order_data")
        recOrderID.Text = (SQL.SQLTable.Rows(0).ItemArray(0) + 1).ToString()

    End Sub

    Private Sub GetCustomer()
        SQL.AddParam("@acctnum", editFilter.Text)
        SQL.ExecuteQuery("SELECT TOP 1 * FROM customer_data WHERE account_number = @acctnum;")

        If SQL.RecordCount < 1 Then Exit Sub

        For Each r As DataRow In SQL.SQLTable.Rows
            editAcctNum.Text = r("account_number")
            editFName.Text = r("first_name")
            editLName.Text = r("last_name")
            editEmail.Text = r("email")
            editCC.Text = r("credit_card_num")
            editStreetNum.Text = r("street_num")
            editStreetName.Text = r("street")
            editAPTNum.Text = r("apartment_num")
            editCity.Text = r("city")
            editState.Text = r("state")
            editZip.Text = r("zip_code")

            If IsDBNull(r("account_type")) Then Exit For

            If r("account_type") = "lim" Then
                editLim.Checked = True
            ElseIf r("account_type") = "unlim1" Then
                editUnlim1.Checked = True
            ElseIf r("account_type") = "unlim2" Then
                editUnlim2.Checked = True
            ElseIf r("account_type") = "unlim3" Then
                editUnlim3.Checked = True
            End If
        Next
        edit_cust.Enabled = True
        'SQL.AddParam("@acctnum", editAcctNum.Text)
    End Sub

    Private Sub UpdateCustomer()
        SQL.AddParam("@acctnum", editAcctNum.Text)
        SQL.AddParam("@fname", editFName.Text)
        SQL.AddParam("@lname", editLName.Text)
        SQL.AddParam("@email", editEmail.Text)
        SQL.AddParam("@cc", editCC.Text)
        SQL.AddParam("@strnum", editStreetNum.Text)
        SQL.AddParam("@strname", editStreetName.Text)
        SQL.AddParam("@aptnum", editAPTNum.Text)
        SQL.AddParam("@city", editCity.Text)
        SQL.AddParam("@state", editState.Text)
        SQL.AddParam("@zip", editZip.Text)

        If editLim.Checked Then
            SQL.AddParam("@type", "lim")
        ElseIf editUnlim1.Checked Then
            SQL.AddParam("@type", "unlim1")
        ElseIf editUnlim2.Checked Then
            SQL.AddParam("@type", "unlim2")
        ElseIf editUnlim3.Checked Then
            SQL.AddParam("@type", "unlim3")
        Else
            SQL.AddParam("@type", "NULL")
        End If

        SQL.ExecuteQuery("UPDATE customer_data SET first_name=@fname, last_name=@lname, email=@email, credit_card_num=@cc, street_num=@strnum, street=@strname, apartment_num=@aptnum, city=@city, state=@state, zip_code=@zip, account_type=@type WHERE account_number = @acctnum")

        If SQL.HasException(True) Then Exit Sub

        edit_cust.Enabled = False
        MsgBox("User has been updated.")
    End Sub

    Private Sub LoadData(Optional Query As String = "")
        If Query = "" Then
            SQL.ExecuteQuery("SELECT * FROM customer_data;")
        Else
            SQL.ExecuteQuery(Query)
        End If

        ' Error Handling
        If SQL.HasException(False) Then Exit Sub

        CustData.DataSource = SQL.SQLTable
    End Sub

    Private Sub CreateOrder()
        SQL.AddParam("@orderid", recOrderID.Text)
        SQL.AddParam("@acctnum", recAcctNum.Text)
        SQL.AddParam("@movieid", recMovieID.Text)
        SQL.AddParam("@date", recDate.Text)
        SQL.AddParam("@sin", recSIN.Text)

        SQL.ExecuteQuery("INSERT INTO order_data (order_id, date, return_flag, account_number, movie_id, SIN) VALUES (@orderid, @date, 0, @acctnum, @movieid, @sin);")
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
        ElseIf Unlim3.Checked Then
            SQL.AddParam("@type", "unlim3")
        Else
            SQL.AddParam("@type", "NULL")
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

    Private Sub editSearch_Click(sender As Object, e As EventArgs) Handles editSearch.Click
        GetCustomer()
    End Sub

    Private Sub edit_cust_Click(sender As Object, e As EventArgs) Handles edit_cust.Click
        UpdateCustomer()
    End Sub
End Class