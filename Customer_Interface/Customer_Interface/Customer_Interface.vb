
' Need to fix, my changes did not stick when merging

Public Class Customer_Interface
    Private SQL As New SQLControl

    Private Function GetAccount() As Integer
        Return CInt(Customer_Login.UserAccount()) ' convert string to integer 
    End Function

    Private Sub Customer_Interface_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MdiParent = Main_Interface
        LoadData()
        LoadMovies()
    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        Me.Close()
        Customer_Login.Close() ' terminate the session
        MsgBox("Current Session Closed")
    End Sub

    Private Sub btnChangeInfo_Click(sender As Object, e As EventArgs) Handles btnChangeInfo.Click
        ' opens the page to edit customer info
        Me.Hide() ' have it reapear after done
        Edit_Customer_Account.Show()
    End Sub

    ' load the past, current and queue fields for the customers account info with movies
    Private Sub LoadMovies()
        cbxPrev.Items.Clear()

        If SQL.SQLTable IsNot Nothing Then
            SQL.SQLTable.Clear()
        End If
        SQL.ExecuteQuery("SELECT DISTINCT(movie_name) as Movies " &
                         "FROM Order_Data as OD, Movie_Data as MD " &
                         "WHERE OD.movie_id = MD.movie_id AND return_flag = 1 AND account_number = " & CInt(GetAccount()) & ";")
        If SQL.HasException(True) Then Exit Sub

        Dim ttlRows As Integer = SQL.SQLTable.Rows.Count()
        For i As Integer = 0 To (ttlRows - 1)
            cbxPrev.Items.Add(SQL.SQLTable.Rows(i).Item("Movies").ToString)
        Next

        ' load pull down current movies
        cbxCur.Items.Clear()
        cbCurrentRentals.Items().Clear()

        If SQL.SQLTable IsNot Nothing Then
            SQL.SQLTable.Clear()
        End If
        SQL.ExecuteQuery("SELECT DISTINCT(movie_name) as Movies " &
                         "FROM Order_Data as OD, Movie_Data as MD " &
                         "WHERE OD.movie_id = MD.movie_id AND return_flag = 0 AND account_number = " & GetAccount() & ";")
        If SQL.HasException(True) Then Exit Sub

        ttlRows = SQL.SQLTable.Rows.Count()
        For i As Integer = 0 To (ttlRows - 1)
            cbxCur.Items.Add(SQL.SQLTable.Rows(i).Item("Movies").ToString)
            cbCurrentRentals.Items.Add(SQL.SQLTable.Rows(i).Item("Movies").ToString)
        Next

        ' load pull down for order queue
        cbxQueue.Items.Clear() ' refresh the list
        cbEditQueue.Items.Clear()

        If SQL.SQLTable IsNot Nothing Then
            SQL.SQLTable.Clear()
        End If
        SQL.ExecuteQuery("SELECT DISTINCT(movie_name) as Movies, date " &
                         "FROM Order_Queue as OQ, Movie_Data as MD " &
                         "WHERE OQ.movie_id = MD.movie_id AND account_number = " & GetAccount() &
                         "ORDER BY date ASC;")
        If SQL.HasException(True) Then Exit Sub

        ttlRows = SQL.SQLTable.Rows.Count()
        For i As Integer = 0 To (ttlRows - 1)
            cbxQueue.Items.Add(SQL.SQLTable.Rows(i).Item("Movies").ToString)
            cbEditQueue.Items.Add(SQL.SQLTable.Rows(i).Item("Movies").ToString)
        Next

        ' load pull down for movies that need to be rated
        cbRateRes.Items.Clear()
        If SQL.SQLTable IsNot Nothing Then
            SQL.SQLTable.Clear()
        End If
        SQL.ExecuteQuery("SELECT movie_rating, movie_name " &
                         "FROM Order_Data as OD INNER JOIN Movie_Data as MD ON OD.movie_id=MD.movie_id INNER JOIN Rental_History as RH ON OD.order_id=RH.order_id " &
                         "WHERE return_flag=1 AND movie_rating IS NULL AND OD.account_number=" & GetAccount().ToString & ";")
        If SQL.HasException(True) Then Exit Sub

        ttlRows = SQL.SQLTable.Rows.Count()
        'MsgBox(ttlRows)
        For i As Integer = 0 To (ttlRows - 1)
            cbRateRes.Items.Add(SQL.SQLTable.Rows(i).Item("movie_name").ToString)
        Next

    End Sub

    Public Sub LoadData()
        Dim user As String = GetAccount()
        ' clear table
        If SQL.SQLTable IsNot Nothing Then
            SQL.SQLTable.Clear()
        End If

        SQL.ExecuteQuery("SELECT * FROM Customer_Data as CD INNER JOIN Customer_Phone_Numbers as CPN ON CD.account_number=CPN.account_number " &
                         "INNER JOIN Customer_Passwords as CP ON CP.account_number=CPN.account_number WHERE CPN.account_number = " + user + ";")
        If SQL.HasException(True) Then Exit Sub
        Dim rowNumbers As Integer = SQL.SQLTable.Rows.Count()

        Dim i As Object = SQL.SQLTable.Rows(0)
        Dim accountNumber As String = i.Item("account_number").ToString
        Dim fullName As String = i.Item("first_name") + " " + i.Item("last_name")
        txtUserName.Text = fullName
        Dim email As String = i.Item("email")
        Dim address As String = "#" & i.Item("apartment_num") & " " & i.Item("street_num") & " " & i.Item("street") & vbCrLf &
                               "    " & i.Item("city") & ", " & i.Item("state") & ", " & i.Item("zip_code")
        Dim cardNum As String = i.Item("credit_card_num")
        Dim type As String = i.Item("account_type")
        Dim creation As String = i.Item("creation_date")
        Dim phone1 As String = i.Item("phone_type") + ": " + i.Item("telephone_num")
        Dim username As String = i.Item("username")

        If rowNumbers = 2 Then ' I recognize that this is overkill but it made managing the numbers easier
            Dim phone2 As String = SQL.SQLTable.Rows(1).Item("phone_type") + ": " + SQL.SQLTable.Rows(1).Item("telephone_num")
            phone1 = phone1 + vbCrLf + "    " + phone2
        End If
        If rowNumbers = 3 Then ' there can be at most 3 numbers on file
            Dim phone2 As String = SQL.SQLTable.Rows(1).Item("phone_type") + ": " + SQL.SQLTable.Rows(1).Item("telephone_num")
            Dim phone3 As String = SQL.SQLTable.Rows(2).Item("phone_type") + ": " + SQL.SQLTable.Rows(2).Item("telephone_num")
            phone1 = phone1 + vbCrLf + "    " + phone2 + vbCrLf + "    " + phone3
        End If
        'Print out current account information
        txtInfo.Text = "Account Number: " + accountNumber + vbCrLf +
                       "Username: " + username + vbCrLf +
                       "Name: " + fullName + vbCrLf +
                       "Email: " + email + vbCrLf +
                       "Phone Number: " + vbCrLf + "    " + phone1 + vbCrLf + vbCrLf +
                       "Address: " + address + vbCrLf + vbCrLf +
                       "Card Number: " & cardNum & vbCrLf & vbCrLf &
                       "Account Type: " & type & vbCrLf &
                       "Account Created On: " & creation

    End Sub

    Private Sub btnBest_Click(sender As Object, e As EventArgs) Handles btnBest.Click ' need to change the query criteria for this
        Dim ttlMovies As Integer = SQL.SQLTable.Rows.Count()
        Dim movieList As String = ""
        ' clear table
        If SQL.SQLTable IsNot Nothing Then
            SQL.SQLTable.Clear()
        End If
        movieSelect.Items.Clear() ' clear entries in table
        movieSelect.Refresh() ' need to figure out how to get the list to shrink back down
        txtRes.Clear() ' clear the text field
        txtRes.Text = ""

        ' run the query
        SQL.ExecuteQuery("SELECT DISTINCT(movie_name) AS Movies " &
                         "FROM Movie_Data " &
                         "WHERE rating >= 4; ")
        If SQL.HasException(True) Then Exit Sub

        ttlMovies = SQL.SQLTable.Rows.Count()

        If SQL.SQLTable.Rows.Count > 0 Then
            For i As Integer = 0 To (ttlMovies - 1)
                movieList = movieList + SQL.SQLTable.Rows(i).Item("Movies").ToString + vbCrLf
            Next
            txtRes.Text = movieList ' display movies

            For i As Integer = 0 To (ttlMovies - 1)
                movieSelect.Items.Add(SQL.SQLTable.Rows(i).Item("Movies").ToString)
            Next
        End If

    End Sub

    Private Sub btnPersonal_Click(sender As Object, e As EventArgs) Handles btnPersonal.Click '**************************************************************** This needs work

        Dim ttlMovies As Integer = SQL.SQLTable.Rows.Count()
        Dim movieList As String = ""
        ' clear table
        If SQL.SQLTable IsNot Nothing Then
            SQL.SQLTable.Clear()
        End If
        ' reset fields
        movieSelect.Items.Clear() ' clear entries in table
        movieSelect.Refresh() ' need to figure out how to get the list to shrink back down
        txtRes.Clear() ' clear the text field
        txtRes.Text = ""

        ' MsgBox(GetAccount()) ' for test purposes

        ' run the query for recommended
        Dim Query As New Recommend
        SQL = Query.Recommended(GetAccount().ToString)

        If SQL.HasException(True) Then Exit Sub

        ttlMovies = SQL.SQLTable.Rows.Count()
        'DataGridView1.DataSource = SQL.SQLTable

        If SQL.SQLTable.Rows.Count > 0 Then
            For i As Integer = 0 To (ttlMovies - 1)
                movieList = movieList + SQL.SQLTable.Rows(i).Item("Movies").ToString + vbCrLf
            Next
            txtRes.Text = movieList ' display movies

            For i As Integer = 0 To (ttlMovies - 1)
                movieSelect.Items.Add(SQL.SQLTable.Rows(i).Item("Movies").ToString)
            Next
        End If

    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim ttlMovies As Integer = SQL.SQLTable.Rows.Count()
        Dim movieList As String = ""

        ' clear table
        If SQL.SQLTable IsNot Nothing Then
            SQL.SQLTable.Clear()
        End If
        ' reset fields
        movieSelect.Items.Clear() ' clear entries in table
        movieSelect.Refresh() ' need to figure out how to get the list to shrink back down
        txtRes.Clear() ' clear the text field
        txtRes.Text = ""

        If txtSearch.Text = "" Then Exit Sub

        ' run the query
        If Trim(txtSearch.Text.ToLower) = "action" Or Trim(txtSearch.Text.ToLower) = "comedy" Or Trim(txtSearch.Text.ToLower) = "drama" Or Trim(txtSearch.Text.ToLower) = "foreign" Then
            SQL.ExecuteQuery("SELECT movie_name AS Movies " &
                             "FROM Movie_Data " &
                             "WHERE movie_type LIKE '" + Trim(txtSearch.Text.ToLower) + "';")
            If SQL.HasException(True) Then Exit Sub

            ttlMovies = SQL.SQLTable.Rows.Count()

            For i As Integer = 0 To (ttlMovies - 1)
                movieList = movieList + SQL.SQLTable.Rows(i).Item("Movies").ToString + vbCrLf
            Next
            txtRes.Text = movieList ' display movies

            For i As Integer = 0 To (ttlMovies - 1)
                movieSelect.Items.Add(SQL.SQLTable.Rows(i).Item("Movies").ToString)
            Next

        Else
            Dim words() As String = txtSearch.Text.Split(" "c) ' split based on the space character
            Dim queryString As String = "SELECT DISTINCT(movie_name) AS Movies "
            Dim ttl As Integer = words.Length ' or count
            ' how to prevent SQL injection attack?
            If rbTitle.Checked = True Then
                queryString += "FROM Movie_Data WHERE "
                For Each word As String In words
                    If word = words(ttl - 1) Then ' if at the end 
                        queryString += "movie_name LIKE '%" + word + "%';"
                    Else
                        queryString += "movie_name LIKE '%" + word + "%' OR " ' changed from and to or
                    End If
                Next
            ElseIf rbActor.Checked = True Then
                ' works for one name but not two at a time *********************************************************************************************** needs to be in comparison to a movie

                queryString += "FROM Movie_Data AS MD FULL JOIN Acts_In AS AI ON MD.movie_id=AI.movie_id FULL JOIN Actor_Data as AD ON AI.actor_id=AD.actor_id WHERE "
                For Each word As String In words
                    If word = words(ttl - 1) Then ' if at the end 
                        queryString += "(first_name LIKE '%" + word + "%' OR last_name LIKE '%" + word + "%')"
                    Else
                        queryString += "(first_name LIKE '%" + word + "%' OR last_name LIKE '%" + word + "%') OR " ' changed from and to or
                    End If
                Next
            End If
            'MsgBox(queryString) 'for test purposes

            ' print out query
            SQL.ExecuteQuery(queryString)
            If SQL.HasException(True) Then Exit Sub

            ttlMovies = SQL.SQLTable.Rows.Count()

            If SQL.SQLTable.Rows.Count > 0 Then
                For i As Integer = 0 To (ttlMovies - 1)
                    movieList = movieList + SQL.SQLTable.Rows(i).Item("Movies").ToString + vbCrLf
                Next
                txtRes.Text = movieList ' display movies

                For i As Integer = 0 To (ttlMovies - 1)
                    movieSelect.Items.Add(SQL.SQLTable.Rows(i).Item("Movies").ToString)
                Next
            End If

        End If
        txtSearch.Clear()

    End Sub

    Private Sub search_param_CheckedChanged(sender As Object, e As EventArgs) Handles rbCategory.CheckedChanged, rbTitle.CheckedChanged, rbActor.CheckedChanged
        If rbTitle.Checked = True Or rbActor.Checked = True Or rbCategory.Checked = True Then
            btnSearch.Enabled = True
        End If
    End Sub

    Private Sub btnAddQueue_Click(sender As Object, e As EventArgs) Handles btnAddQueue.Click
        ' add to the queue based on what is in the combo box
        ' need account number, movie id and data
        ' add to order queue
        'MsgBox(movieSelect.Text) ' for test purposes

        ' clear table
        If SQL.SQLTable IsNot Nothing Then
            SQL.SQLTable.Clear()
        End If

        SQL.ExecuteQuery("SELECT movie_id " &
                         "FROM Movie_Data " &
                         "WHERE movie_name LIKE '" + movieSelect.Text + "';")
        'Dim movie_ID As String = SQL.SQLTable.Rows(0).Item("movie_id")
        Dim user As String = GetAccount().ToString
        'Dim movie_ID As String = SQL.SQLTable.Rows(0).Item("movie_id").ToString
        Dim movie_ID As String
        If SQL.SQLTable.Rows.Count > 0 Then
            movie_ID = SQL.SQLTable.Rows(0).Item("movie_id").ToString
        Else
            MsgBox("You must add a movie from the search results to add to your queue")
            Exit Sub
        End If

        ' check to make sure its not already in the queue
        SQL.ExecuteQuery("SELECT movie_id " &
                         "FROM Order_Queue " &
                         "WHERE account_number=" + user + " AND movie_id=" + movie_ID + ";")
        If SQL.SQLTable.Rows.Count > 0 Then
            If SQL.SQLTable.Rows(0).Item("movie_id") Then
                MsgBox("The movie you have selected is already in your queue")
                ' maybe clear the combo box text field? 
                Exit Sub
            End If
        End If

        ' clear table
        If SQL.SQLTable IsNot Nothing Then
            SQL.SQLTable.Clear()
        End If

        SQL.AddParam("@user_ID", user)
        SQL.AddParam("@movie_ID", movie_ID)
        SQL.AddParam("@date", Date.Now)
        SQL.ExecuteQuery("INSERT INTO Order_Queue (account_number, movie_id, date) " &
                         "VALUES (@user_ID, @movie_ID, @date)")
        If SQL.HasException(True) Then Exit Sub

        MsgBox("The movie """ + movieSelect.Text + """ has been added to your queue")
        ' update movie queue in account
        'cbxQueue.Items.Clear()
        'cbEditQueue.Items.Clear()
        LoadMovies()

    End Sub

    Private Sub btnEditQueue_Click(sender As Object, e As EventArgs) Handles btnEditQueue.Click
        ' clear table
        If SQL.SQLTable IsNot Nothing Then
            SQL.SQLTable.Clear()
        End If
        SQL.ExecuteQuery("SELECT movie_id " &
                         "FROM Movie_Data " &
                         "WHERE movie_name LIKE '" + cbEditQueue.Text + "';")

        Dim user As String = GetAccount().ToString
        Dim movie_ID As String
        If SQL.SQLTable.Rows.Count > 0 Then
            movie_ID = SQL.SQLTable.Rows(0).Item("movie_id").ToString
        Else
            MsgBox("You must add a movie from your queue to remove")
            Exit Sub
        End If

        ' clear table
        If SQL.SQLTable IsNot Nothing Then
            SQL.SQLTable.Clear()
        End If
        ' remove from queue
        SQL.AddParam("@user_ID", user)
        SQL.AddParam("@movie_ID", movie_ID)

        SQL.ExecuteQuery("DELETE FROM Order_Queue " &
                         "WHERE account_number=@user_ID AND movie_id=@movie_ID;")
        If SQL.HasException(True) Then Exit Sub

        MsgBox("The movie """ + movieSelect.Text + """ has been removed from your queue")
        'cbEditQueue.Items.Clear()
        'cbxQueue.Items.Clear()
        LoadMovies()
    End Sub

    Private Sub btnRate_Click(sender As Object, e As EventArgs) Handles btnRate.Click
        'cbRateRes.Text
        Dim rating As Integer
        If rb1.Checked Then
            rating = "1"
        ElseIf rb2.Checked Then
            rating = "2"
        ElseIf rb3.Checked Then
            rating = "3"
        ElseIf rb4.Checked Then
            rating = "4"
        ElseIf rb5.Checked Then
            rating = "5"
        Else
            MsgBox("Please choose a rating")
            Exit Sub
        End If

        ' calculate rating
        If cbRateRes.Text = "" Then ' check to make sure something has been selected
            MsgBox("Please select a choice to rate")
            Exit Sub
        End If

        Dim movie_ID As Integer
        SQL.ExecuteQuery("SELECT movie_id FROM Movie_Data WHERE movie_name='" + cbRateRes.Text + "';")
        If SQL.SQLTable.Rows.Count > 0 Then
            movie_ID = SQL.SQLTable.Rows(0).Item("movie_id").ToString
        Else
            MsgBox("Sorry for the inconvenience. There was an internal error")
            Exit Sub
        End If

        ' if all fields are filled out, calculate the new rating for the movie and update
        Dim order_ID As Integer
        SQL.ExecuteQuery("SELECT RH.order_id " &
                         "From Rental_History AS RH, Order_Data AS OD " &
                         "Where RH.account_number = OD.account_number And OD.account_number=" + GetAccount.ToString + " AND movie_id=" + movie_ID.ToString + " AND movie_rating IS NULL " &
                         "GROUP BY RH.order_id;")

        If SQL.SQLTable.Rows.Count > 0 Then
            order_ID = SQL.SQLTable.Rows(0).Item("order_id").ToString
        Else
            MsgBox("There was an error and your rating was not recorded")
            Exit Sub
        End If
        ' update the users rating into the table
        SQL.ExecuteQuery("UPDATE Rental_History " &
                         "SET movie_rating=" + rating.ToString + " " &
                         "WHERE account_number=" + GetAccount().ToString + " AND order_id=" + order_ID.ToString + ";")
        ' update the movies overall rating
        ' apparently an aggregate cannot be used in an update statement... so extract average first and then update.
        SQL.ExecuteQuery("SELECT round(avg(movie_rating*1.0), 2) as rating " &
                         "FROM Rental_History AS RH INNER JOIN Order_Data AS OD ON RH.account_number=OD.account_number " &
                         "WHERE movie_id=" + movie_ID.ToString + ";")
        Dim averageRating As Decimal = 0
        If SQL.SQLTable.Rows.Count > 0 Then
            averageRating = SQL.SQLTable.Rows(0).Item("rating").ToString
        End If
        MsgBox(averageRating)
        SQL.ExecuteQuery("UPDATE Movie_Data " &
                         "SET rating=" + averageRating.ToString + " " &
                         "WHERE movie_id=" + movie_ID.ToString + ";")
        MsgBox("Your rating has been submitted")
        cbRateRes.Items.Clear()
        cbRateRes.Text = ""
        LoadMovies()
    End Sub

    Private Sub rentMovie_Click(sender As Object, e As EventArgs) Handles rentMovie.Click ' could change this just to spit out a message and send the order to be filled by a rep ***************
        ' for allowing a movie rental
        ' need to check if the movie is available by counting the number of already rented versus the number that can be rented
        If SQL.SQLTable IsNot Nothing Then
            SQL.SQLTable.Clear()
        End If
        ' rent a movie from the queue
        SQL.ExecuteQuery("SELECT movie_id " &
                         "FROM Movie_Data " &
                         "WHERE movie_name LIKE '" + cbEditQueue.Text + "';")
        Dim user As String = GetAccount().ToString
        MsgBox(user)
        Dim movie_ID As String
        If SQL.SQLTable.Rows.Count > 0 Then
            movie_ID = SQL.SQLTable.Rows(0).Item("movie_id").ToString
        Else
            MsgBox("You must pick a movie to rent from your queue")
            Exit Sub
        End If

        ' clear table
        If SQL.SQLTable IsNot Nothing Then
            SQL.SQLTable.Clear()
        End If
        ' obtain their account information
        Dim account_type As String
        Dim ttlAllowedRentals As Integer
        SQL.ExecuteQuery("SELECT type, num_of_movies FROM Account as A INNER JOIN Customer_Data as CD ON A.type=CD.account_type WHERE account_number='" + user + "';")
        If SQL.SQLTable.Rows.Count > 0 Then
            account_type = SQL.SQLTable.Rows(0).Item("type")
            ttlAllowedRentals = SQL.SQLTable.Rows(0).Item("num_of_movies")
        Else
            MsgBox("error")
            Exit Sub
        End If
        MsgBox(account_type + " " + ttlAllowedRentals.ToString) ' for test
        ' check to see if they already have a rental
        ' clear table
        If SQL.SQLTable IsNot Nothing Then
            SQL.SQLTable.Clear()
        End If
        Dim rentCount As Integer
        SQL.ExecuteQuery("SELECT count(return_flag) as ttl FROM Order_Data WHERE account_number='" + user + "' AND return_flag = 0;")
        If SQL.SQLTable.Rows.Count > 0 Then
            rentCount = SQL.SQLTable.Rows(0).Item("ttl")
            MsgBox(rentCount.ToString)
        End If
        ' check to see if customer is allowed to rent 
        checkRent(user, account_type, movie_ID, rentCount)
        ' move these updates into other sub routine? *********************************************************************************************************************************************
        'cbEditQueue.Items.Clear()
        'cbxQueue.Items.Clear()
        LoadMovies()
    End Sub

    Private Sub checkRent(user As String, account_type As String, movie_ID As String, rentCount As Integer)
        ' need to check if they have rented this month
        If account_type = "limited" Then ' if they have already rented this month than they are not allowed to rent again
            If rentCount > 0 Then ' if they still have a rental out, exit the sub
                MsgBox("You must first return a movie before you can rent another")
                Exit Sub
            End If
            ' clear table
            If SQL.SQLTable IsNot Nothing Then
                SQL.SQLTable.Clear()
            End If
            SQL.ExecuteQuery("SELECT date FROM Order_Data WHERE account_number='" + user + "' AND return_flag = 1;") '
            If SQL.SQLTable.Rows.Count > 0 Then
                Dim today As Date = Date.Now
                Dim displacement As Day = today.Subtract(Convert.ToDateTime(SQL.SQLTable.Rows(0).Item("date"))).Days
                'MsgBox("inner if for days") ' for test
                If displacement < 30 Then ' find out how many days it has been since you rented a movie
                    MsgBox("You may only rent one movie per month, please check back in " + (30 - displacement).ToString + "days")
                    Exit Sub
                End If
            End If
            MsgBox("You may rent a movie") ' for test purposes

        Else ' if account is an unlimited one, no need to check dates
            If account_type = "unlimited1" Then
                If rentCount > 0 Then
                    MsgBox("You are only allowed one rental at a time. Please return a movie first")
                    Exit Sub
                End If
            ElseIf account_type = "unlimited2" Then
                If rentCount > 1 Then
                    MsgBox("You are only allowed two rentals at a time. Please return a movie first")
                    Exit Sub
                End If
            ElseIf account_type = "unlimited3" Then
                If rentCount > 2 Then
                    MsgBox("You are only allowed three rentals at a time. Please return a movie first")
                    Exit Sub
                End If
            End If
            MsgBox("You may rent a movie") ' for test purposes
        End If
        ' if user reaches this point, they are allowed to rent the movie, now check if there are enough movies to rent
        ' clear table
        If SQL.SQLTable IsNot Nothing Then
            SQL.SQLTable.Clear()
        End If
        ' find out how many copies of this movie are out being rented right now
        SQL.ExecuteQuery("SELECT count(return_flag) as copies FROM Order_Data as OD INNER JOIN Movie_Data as MD ON OD.movie_id=MD.movie_id WHERE movie_id='" + movie_ID + "' AND return_flag = 0;")
        Dim movieCopiesOut As Integer
        If SQL.SQLTable.Rows.Count > 0 Then
            movieCopiesOut = SQL.SQLTable.Rows(0).Item("copies")
        End If
        ' clear table
        If SQL.SQLTable IsNot Nothing Then
            SQL.SQLTable.Clear()
        End If
        SQL.ExecuteQuery("SELECT inventory FROM Movie_Data WHERE movie_id='" + movie_ID + "';")
        If SQL.SQLTable.Rows.Count > 0 Then
            If movieCopiesOut = SQL.SQLTable.Rows(0).Item("inventory") Then ' if there are no copies left to rent
                MsgBox("Unfortunately the title you are trying to rent is not in stock right now." + vbCrLf + "Please check back at a later date")
                Exit Sub
            Else
                ' ********************************************************************************************************************************************** Need to finish the actual rental
                ' there are copies and you can rent it so go ahead
                ' assign random employee to fill the order
                ' remove from queue and add to rental list
                ' reload data
                'SQL.ExecuteQuery("INSERT INTO ")
                MsgBox("Your rental has been placed")
            End If
        End If
    End Sub

    Private Sub btnReturnMovie_Click(sender As Object, e As EventArgs) Handles btnReturnMovie.Click
        ' return from the current rentals list
        ' clear table
        If SQL.SQLTable IsNot Nothing Then
            SQL.SQLTable.Clear()
        End If
        SQL.ExecuteQuery("SELECT movie_id " &
                         "FROM Movie_Data " &
                         "WHERE movie_name LIKE '" + cbCurrentRentals.Text + "';")

        Dim user As String = GetAccount().ToString
        Dim movie_ID As String
        If SQL.SQLTable.Rows.Count > 0 Then
            movie_ID = SQL.SQLTable.Rows(0).Item("movie_id").ToString
        Else
            MsgBox("You must add a movie from your current rentals to return")
            Exit Sub
        End If

        ' clear table
        If SQL.SQLTable IsNot Nothing Then
            SQL.SQLTable.Clear()
        End If
        ' get the order id
        SQL.ExecuteQuery("SELECT order_id FROM Order_Data WHERE account_number='" + user + "';")
        Dim orderNum As Integer
        If SQL.SQLTable.Rows.Count > 0 Then
            orderNum = SQL.SQLTable.Rows(0).Item("order_id").ToString
        End If
        ' remove from queue
        SQL.AddParam("@order_ID", orderNum)
        SQL.AddParam("@user_ID", user)
        SQL.AddParam("@movie_ID", movie_ID)
        ' remove from current rentals
        SQL.ExecuteQuery("UPDATE Order_Data " &
                         "SET return_flag=1 " &
                         "WHERE account_number=@user_ID AND movie_id=@movie_ID AND order_id=@order_ID;") ' might need to check based on order_id as well **********************************
        If SQL.HasException(True) Then Exit Sub
        ' update Rental_History
        SQL.AddParam("@user_ID", user)
        SQL.AddParam("@order_ID", orderNum)
        SQL.ExecuteQuery("INSERT INTO Rental_History (account_number, order_id)" &
                         "VALUES (@user_ID, @order_ID);")
        If SQL.HasException(True) Then Exit Sub

        MsgBox("The movie """ + cbCurrentRentals.Text + """ has been returned")
        'cbCurrentRentals.Items.Clear()
        'cbxCur.Items.Clear()
        LoadMovies()
    End Sub
End Class

