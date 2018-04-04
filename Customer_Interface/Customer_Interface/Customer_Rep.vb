Public Class Customer_Rep
    Public SQL As New SQLControl
    Private Sub rec_order_Click(sender As Object, e As EventArgs) Handles recOrder.Click
        CreateOrder()
    End Sub

    Private Sub Customer_Rep_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MdiParent = Main_Interface
        SQL.ExecuteQuery("SELECT max(account_number) FROM customer_data")

        If Not IsDBNull(SQL.SQLTable.Rows(0).ItemArray(0)) Then
            addAcctNum.Text = (SQL.SQLTable.Rows(0).ItemArray(0) + 1).ToString()
        Else
            addAcctNum.Text = "1"
        End If
        recDate.Text = Today()
        SQL.ExecuteQuery("SELECT max(order_id) FROM order_data")

        If Not IsDBNull(SQL.SQLTable.Rows(0).ItemArray(0)) Then
            recOrderID.Text = (SQL.SQLTable.Rows(0).ItemArray(0) + 1).ToString()
        Else
            recOrderID.Text = "1"
        End If

        recSIN.Text = Employee_Login.UserAccount()

    End Sub

    Private Sub DelCust()
        SQL.AddParam("@acctnum", delAcctNum.Text)
        SQL.ExecuteQuery("DELETE FROM customer_data WHERE account_number = @acctnum;")
        If SQL.HasException(True) Then Exit Sub

        SQL.AddParam("@acctnum", delAcctNum.Text)
        SQL.ExecuteQuery("DELETE From customer_phone_numbers WHERE account_number = @acctnum;")
        If SQL.HasException(True) Then Exit Sub

        MsgBox("Customer deleted.")
        delAcctNum.Clear()
        delData.ClearSelection()
        del_cust.Enabled = False
    End Sub

    Private Sub makeMailingList()
        AddressList.Items.Clear()
        SQL.ExecuteQuery("SELECT first_name, last_name, city, state, zip_code, street, street_num, apartment_num FROM customer_data;")

        For Each r As DataRow In SQL.SQLTable.Rows
            Dim mailee As String = r("first_name") + " " + r("last_name") + ", "
            mailee += r("street_num").ToString() + " " + r("street") + " "

            If Not IsDBNull(r("apartment_num")) And Not r("apartment_num").ToString() = "0" Then
                mailee += "APT " + r("apartment_num").ToString() + " "
            End If

            mailee += r("city") + ", " + r("state") + " " + r("zip_code").ToString()

            AddressList.Items.Add(mailee)

        Next
    End Sub

    Private Sub makeEmailList()
        Emails.Items.Clear()
        SQL.ExecuteQuery("SELECT email FROM customer_data;")

        For Each r As DataRow In SQL.SQLTable.Rows
            Emails.Items.Add(r("email"))
        Next
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

            If r("account_type") = "limited" Then
                editLim.Checked = True
            ElseIf r("account_type") = "unlim1" Then
                editUnlim1.Checked = True
            ElseIf r("account_type") = "unlim2" Then
                editUnlim2.Checked = True
            ElseIf r("account_type") = "unlim3" Then
                editUnlim3.Checked = True
            End If
        Next

        SQL.AddParam("@acctnum", editAcctNum.Text)
        SQL.ExecuteQuery("SELECT telephone_num, phone_type FROM customer_phone_numbers WHERE account_number = @acctnum;")

        If SQL.RecordCount > 0 Then
            editNum1.Text = SQL.SQLTable.Rows(0).ItemArray(0)
            If SQL.SQLTable.Rows(0).ItemArray(1) = "home" Then
                editHome1.Checked = True
            ElseIf SQL.SQLTable.Rows(0).ItemArray(1) = "work" Then
                editWork1.Checked = True
            Else
                editCell1.Checked = True
            End If
        End If

        If SQL.RecordCount > 1 Then
            editNum2.Text = SQL.SQLTable.Rows(1).ItemArray(0)
            If SQL.SQLTable.Rows(1).ItemArray(1) = "home" Then
                editHome2.Checked = True
            ElseIf SQL.SQLTable.Rows(1).ItemArray(1) = "work" Then
                editWork2.Checked = True
            Else
                editCell2.Checked = True
            End If
        End If

        If SQL.RecordCount > 2 Then
            editNum3.Text = SQL.SQLTable.Rows(2).ItemArray(0)
            If SQL.SQLTable.Rows(2).ItemArray(1) = "home" Then
                editHome3.Checked = True
            ElseIf SQL.SQLTable.Rows(2).ItemArray(1) = "work" Then
                editWork3.Checked = True
            Else
                editCell3.Checked = True
            End If
        End If

        edit_cust.Enabled = True
    End Sub

    Private Sub UpdateCustomer()
        SQL.AddParam("@acctnum", editAcctNum.Text)
        SQL.AddParam("@fname", editFName.Text)
        SQL.AddParam("@lname", editLName.Text)
        SQL.AddParam("@email", editEmail.Text)
        SQL.AddParam("@cc", editCC.Text)
        SQL.AddParam("@strnum", editStreetNum.Text)
        SQL.AddParam("@strname", editStreetName.Text)
        If editAcctNum.Text.Length = 0 Then
            SQL.AddParam("@aptnum", "NULL")
        Else
            SQL.AddParam("@aptnum", editAPTNum.Text)
        End If
        SQL.AddParam("@city", editCity.Text)
        SQL.AddParam("@state", editState.Text)
        SQL.AddParam("@zip", editZip.Text)

        If editLim.Checked Then
            SQL.AddParam("@type", "limited")
        ElseIf editUnlim1.Checked Then
            SQL.AddParam("@type", "unlim1")
        ElseIf editUnlim2.Checked Then
            SQL.AddParam("@type", "unlim2")
        ElseIf editUnlim3.Checked Then
            SQL.AddParam("@type", "unlim3")
        Else
            SQL.AddParam("@type", "NULL")
        End If

        SQL.ExecuteQuery("UPDATE customer_data SET first_name=@fname, last_name=@lname, email=@email, credit_card_num=@cc, street_num=@strnum, street=@strname, apartment_num=@aptnum, city=@city, state=@state, zip_code=@zip, account_type=@type WHERE account_number = @acctnum;")
        If SQL.HasException(True) Then Exit Sub

        SQL.AddParam("@acct", editAcctNum.Text)
        SQL.ExecuteQuery("DELETE FROM customer_phone_numbers WHERE account_number = @acct;")
        If SQL.HasException(True) Then Exit Sub

        If editNum1.TextLength > 0 Then
            SQL.AddParam("@acctnum", editAcctNum.Text)
            SQL.AddParam("@num1", editNum1.Text)
            If editHome1.Checked Then
                SQL.AddParam("@type1", "home")
            ElseIf editWork1.Checked Then
                SQL.AddParam("@type1", "work")
            Else
                SQL.AddParam("@type1", "cell")
            End If
            SQL.ExecuteQuery("INSERT INTO customer_phone_numbers (account_number, telephone_num, phone_type) VALUES (@acctnum, @num1, @type1);")
        End If

        If SQL.HasException(True) Then Exit Sub

        If editNum2.TextLength > 0 Then
            SQL.AddParam("@acctnum", editAcctNum.Text)
            SQL.AddParam("@num2", editNum2.Text)
            If editHome2.Checked Then
                SQL.AddParam("@type2", "home")
            ElseIf editWork2.Checked Then
                SQL.AddParam("@type2", "work")
            Else
                SQL.AddParam("@type2", "cell")
            End If
            SQL.ExecuteQuery("INSERT INTO customer_phone_numbers (account_number, telephone_num, phone_type) VALUES (@acctnum, @num2, @type2);")
        End If

        If SQL.HasException(True) Then Exit Sub

        If editNum3.TextLength > 0 Then
            SQL.AddParam("@acctnum", editAcctNum.Text)
            SQL.AddParam("@num3", editNum3.Text)
            If editHome3.Checked Then
                SQL.AddParam("@type3", "home")
            ElseIf editWork3.Checked Then
                SQL.AddParam("@type3", "work")
            Else
                SQL.AddParam("@type3", "cell")
            End If
            SQL.ExecuteQuery("INSERT INTO customer_phone_numbers (account_number, telephone_num, phone_type) VALUES (@acctnum, @num3, @type3);")
        End If

        If SQL.HasException(True) Then Exit Sub

        editFilter.Clear()
        editAcctNum.Text = ""
        editFName.Clear()
        editLName.Clear()
        editEmail.Clear()
        editCC.Clear()
        editStreetName.Clear()
        editStreetNum.Clear()
        editAPTNum.Clear()
        editCity.Clear()
        editState.Clear()
        editZip.Clear()
        editNum1.Clear()
        editNum2.Clear()
        editNum3.Clear()

        edit_cust.Enabled = False
        MsgBox("User has been updated.")
    End Sub

    Private Sub LoadData(Optional Query As String = "")
        CustData.ClearSelection()
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

        If SQL.HasException(False) Then Exit Sub

        SQL.ExecuteQuery("SELECT max(order_id) FROM order_data")
        recOrderID.Text = SQL.SQLTable.Rows(0).ItemArray(0)
        recAcctNum.Text = ""
        orderAcctNum.Clear()
        orderList.Items.Clear()
        recMovieId.Items.Clear()
        MsgBox("Order successfully created.")
    End Sub

    Private Sub FindCust()
        If AcctNum.TextLength = 0 And FName.TextLength = 0 And LName.TextLength = 0 And findEmail.TextLength = 0 Then
            LoadData()
        Else
            Dim Query As String = "SELECT * FROM customer_data WHERE"
            If AcctNum.TextLength > 0 Then
                SQL.AddParam("@acctnum", AcctNum.Text)
                Query += " account_number = @acctnum"
            Else
                If FName.TextLength > 0 Then
                    SQL.AddParam("@fname", "%" & FName.Text & "%")
                    Query += " first_name LIKE @fname"
                ElseIf LName.TextLength > 0 Then
                    SQL.AddParam("@lname", "%" & LName.Text & "%")
                    Query += " last_name LIKE @lname"
                ElseIf findEmail.TextLength > 0 Then
                    SQL.AddParam("@email", "%" & findEmail.Text & "%")
                    Query += " email LIKE @email"
                End If
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
            SQL.AddParam("@type", "limited")
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

        If SQL.HasException(True) Then Exit Sub

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
            SQL.ExecuteQuery("INSERT INTO customer_phone_numbers (account_number, telephone_num, phone_type) VALUES (@acctnum, @num1, @type1);")
        End If

        If SQL.HasException(True) Then Exit Sub

        If addNum2.TextLength > 0 Then
            SQL.AddParam("@acctnum", addAcctNum.Text)
            SQL.AddParam("@num2", addNum2.Text)
            If Home2.Checked Then
                SQL.AddParam("@type2", "home")
            ElseIf Work2.Checked Then
                SQL.AddParam("@type2", "work")
            Else
                SQL.AddParam("@type2", "cell")
            End If
            SQL.ExecuteQuery("INSERT INTO customer_phone_numbers (account_number, telephone_num, phone_type) VALUES (@acctnum, @num2, @type2);")
        End If

        If SQL.HasException(True) Then Exit Sub

        If addNum3.TextLength > 0 Then
            SQL.AddParam("@acctnum", addAcctNum.Text)
            SQL.AddParam("@num3", addNum3.Text)
            If Home3.Checked Then
                SQL.AddParam("@type3", "home")
            ElseIf Work3.Checked Then
                SQL.AddParam("@type3", "work")
            Else
                SQL.AddParam("@type3", "cell")
            End If
            SQL.ExecuteQuery("INSERT INTO customer_phone_numbers (account_number, telephone_num, phone_type) VALUES (@acctnum, @num3, @type3);")
        End If

        If SQL.HasException(True) Then Exit Sub

        SQL.ExecuteQuery("SELECT max(account_number) FROM customer_data")
        addAcctNum.Text = (SQL.SQLTable.Rows(0).ItemArray(0) + 1).ToString()
        addFName.Clear()
        addLName.Clear()
        addEmail.Clear()
        addCC.Clear()
        addStreetName.Clear()
        addStreetNum.Clear()
        addCity.Clear()
        addState.Clear()
        addZip.Clear()
        addAPTNum.Clear()
        addNum1.Clear()
        addNum2.Clear()
        addNum3.Clear()

        MsgBox("Customer successfully added.")

    End Sub

    Private Sub FindCustToDel()
        If delAcctNum.TextLength > 0 Then
            SQL.AddParam("@acctnum", delAcctNum.Text)
            SQL.ExecuteQuery("SELECT * FROM customer_data WHERE account_number = @acctnum")

            delData.DataSource = SQL.SQLTable

            del_cust.Enabled = True
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

    Private Sub delSearch_Click(sender As Object, e As EventArgs) Handles delSearch.Click
        FindCustToDel()
    End Sub

    Private Sub del_cust_Click(sender As Object, e As EventArgs) Handles del_cust.Click
        Dim result As Integer = MessageBox.Show("Are you sure you want to delete customer?", "WARNING", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            DelCust()
        End If
    End Sub

    Private Sub mailingList_Click(sender As Object, e As EventArgs) Handles mailingList.Click
        makeMailingList()
    End Sub

    Private Sub EmailList_Click(sender As Object, e As EventArgs) Handles EmailList.Click
        makeEmailList()
    End Sub

    Private Sub FindOrderQueue()
        orderList.Items.Clear()
        SQL.AddParam("@acct", orderAcctNum.Text)
        SQL.ExecuteQuery("SELECT movie_data.movie_id, movie_data.movie_name FROM order_queue, movie_data WHERE account_number = @acct AND order_queue.movie_id = movie_data.movie_id;")

        For Each r As DataRow In SQL.SQLTable.Rows
            Dim movie As String = r("movie_id").ToString() + vbTab + r("movie_name")
            orderList.Items.Add(movie)
            recMovieId.Items.Add(r("movie_id"))
        Next
    End Sub

    Private Sub orderSearch_Click(sender As Object, e As EventArgs) Handles orderSearch.Click
        FindOrderQueue()
        recAcctNum.Text = orderAcctNum.Text
    End Sub

    Private Sub MovieRec_Click(sender As Object, e As EventArgs) Handles MovieRec.Click
        Dim acct As String = FindMovieAcctNum.Text
        RecMovies.Items.Clear()
        If acct.Length > 0 Then
            Dim movie_ids = Recommendation.GetRecommendations(acct)

            For Each movie_id As Integer In movie_ids
                SQL.AddParam("@movie", movie_id)
                SQL.ExecuteQuery("SELECT movie_name FROM movie_data WHERE movie_id = @movie")
                RecMovies.Items.Add(SQL.SQLTable.Rows(0).ItemArray(0))
            Next
        End If
    End Sub
End Class