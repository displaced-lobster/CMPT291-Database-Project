
Public Class Customer_Interface
    Private SQL As New SQLControl

    Private Function GetAccount() As Integer ' This works ************************************************************************************************************** DONE
        Return CInt(Customer_Login.UserAccount()) ' convert string to integer 
    End Function

    Private Sub Customer_Interface_Load(sender As Object, e As EventArgs) Handles MyBase.Load ' This works ************************************************************** DONE
        MdiParent = Main_Interface
        txtRes.ScrollBars = ScrollBars.Vertical ' enables the scroll bar for text box
        LoadData()
        LoadMovies()
    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click ' This Works *********************************************************************** DONE
        Me.Close()
        Customer_Login.Close() ' terminate the session
        Main_Interface.pbBlueBox.Show()
        MsgBox("Current Session Closed")
    End Sub

    Private Sub btnChangeInfo_Click(sender As Object, e As EventArgs) Handles btnChangeInfo.Click ' This works ************************************************************ DONE
        ' opens the page to edit customer info and hides the current page
        Me.Hide()
        Edit_Customer_Account.Show()
    End Sub

    ' load the past, current and queue fields for the customers account info with movies
    Private Sub LoadMovies()
        ' load pull down for past movies rented  ******************************************************************************************************* works how I expect DONE
        cbxPrev.Items.Clear() ' refresh the list
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

        ' load pull down current movies ************************************************************************************************************* works how I expect, DONE
        cbxCur.Items.Clear() ' refresh the list
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

        ' load pull down for order queue ***************************************************************************************************** Works how I expect it to, DONE
        cbxQueue.Items.Clear() ' refresh the list
        cbEditQueue.Items.Clear()
        If SQL.SQLTable IsNot Nothing Then
            SQL.SQLTable.Clear()
        End If
        SQL.ExecuteQuery("SELECT DISTINCT(movie_name) as Movies, date " &
                         "FROM Order_Queue as OQ, Movie_Data as MD " &
                         "WHERE OQ.movie_id = MD.movie_id AND account_number = " & GetAccount() &
                         "ORDER BY date ASC;") ' order from oldest in queue to most recent
        If SQL.HasException(True) Then Exit Sub

        ttlRows = SQL.SQLTable.Rows.Count()
        For i As Integer = 0 To (ttlRows - 1)
            cbxQueue.Items.Add(SQL.SQLTable.Rows(i).Item("Movies").ToString)
            cbEditQueue.Items.Add(SQL.SQLTable.Rows(i).Item("Movies").ToString)
        Next

        ' load pull down for past movies that need to be rated ********************************************************************************* Works how I expect it to, DONE
        cbRateRes.Items.Clear() ' refresh the list
        If SQL.SQLTable IsNot Nothing Then
            SQL.SQLTable.Clear()
        End If
        SQL.ExecuteQuery("SELECT movie_rating, movie_name " &
                         "FROM Order_Data as OD INNER JOIN Movie_Data as MD ON OD.movie_id=MD.movie_id INNER JOIN Rental_History as RH ON OD.order_id=RH.order_id " &
                         "WHERE return_flag=1 AND movie_rating IS NULL AND OD.account_number=" & GetAccount().ToString & ";")
        If SQL.HasException(True) Then Exit Sub
        ttlRows = SQL.SQLTable.Rows.Count()
        For i As Integer = 0 To (ttlRows - 1)
            cbRateRes.Items.Add(SQL.SQLTable.Rows(i).Item("movie_name").ToString)
        Next

    End Sub

    Public Sub LoadData() ' Works how I expect ******************************************************************************************************************* DONE
        Dim user As String = GetAccount()
        ' clear table
        If SQL.SQLTable IsNot Nothing Then
            SQL.SQLTable.Clear()
        End If
        ' get the users information
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

    Private Sub btnBest_Click(sender As Object, e As EventArgs) Handles btnBest.Click ' seems to work ******************************************************************* DONE
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

        ' run the query takes the top three most rented movies as the best sellers
        SQL.ExecuteQuery("SELECT TOP 3 MD.movie_name AS Movies, COUNT(OD.order_id) as count " &
                         "FROM Movie_Data as MD, Order_Data as OD " &
                         "WHERE MD.movie_id=OD.movie_id " &
                         "GROUP BY MD.movie_name ")
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

    Private Sub btnPersonal_Click(sender As Object, e As EventArgs) Handles btnPersonal.Click ' Recommendation algorithm has issues with a user having rented the movie multiple times

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

        Dim Recommends As List(Of Integer) = Recommendation.GetRecommendations(GetAccount())

        ttlMovies = Recommends.Count

        If Recommends.Count > 0 Then
            For i As Integer = 0 To (ttlMovies - 1)
                SQL.ExecuteQuery("SELECT movie_name FROM Movie_Data WHERE movie_id=" + Recommends(i).ToString + ";")
                movieList = movieList + SQL.SQLTable.Rows(0).Item("movie_name") + vbCrLf 'SQL.SQLTable.Rows(i).Item("Movies").ToString
                movieSelect.Items.Add(SQL.SQLTable.Rows(0).Item("movie_name"))
            Next
            txtRes.Text = movieList ' display movies
        End If

    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click ' seems to work how I expect it to ****************************************** DONE 
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
        If txtSearch.Text = "" Then Exit Sub ' to take care of when the user has entered nothing at all
        ' run the query
        If rbCategory.Checked Then
            If Trim(txtSearch.Text.ToLower) = "action" Or Trim(txtSearch.Text.ToLower) = "comedy" Or
            Trim(txtSearch.Text.ToLower) = "drama" Or Trim(txtSearch.Text.ToLower) = "foreign" Then
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
                MsgBox("If you are searching by category, the category name must be spelled correctly")
            End If
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
                queryString += "FROM Movie_Data AS MD FULL JOIN Acts_In AS AI ON MD.movie_id=AI.movie_id FULL JOIN Actor_Data as AD ON AI.actor_id=AD.actor_id WHERE "
                For Each word As String In words
                    If word = words(ttl - 1) Then ' if at the end 
                        queryString += "(first_name LIKE '%" + word + "%' OR last_name LIKE '%" + word + "%')"
                    Else
                        queryString += "(first_name LIKE '%" + word + "%' OR last_name LIKE '%" + word + "%') OR " ' changed from AND to OR
                    End If
                Next
            End If
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

    Private Sub search_param_CheckedChanged(sender As Object, e As EventArgs) Handles rbCategory.CheckedChanged, rbTitle.CheckedChanged, rbActor.CheckedChanged ' ********DONE
        If rbTitle.Checked = True Or rbActor.Checked = True Or rbCategory.Checked = True Then
            btnSearch.Enabled = True
        End If
    End Sub

    Private Sub btnAddQueue_Click(sender As Object, e As EventArgs) Handles btnAddQueue.Click ' works how expected ******************************************************** DONE
        ' is added to queue based on the date and time to create ordering
        ' clear table
        If SQL.SQLTable IsNot Nothing Then
            SQL.SQLTable.Clear()
        End If
        ' get the movie id for the selected movie
        SQL.ExecuteQuery("SELECT movie_id " &
                         "FROM Movie_Data " &
                         "WHERE movie_name LIKE '" + movieSelect.Text + "';")
        Dim user As String = GetAccount().ToString
        Dim movie_ID As String
        ' check to make sure that the user has actually added a movie to the queue
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
        If SQL.SQLTable.Rows.Count > 0 Then ' if any results are returned than you can't add because it is already in your queue
            If SQL.SQLTable.Rows(0).Item("movie_id") Then
                MsgBox("The movie you have selected is already in your queue")
                Exit Sub
            End If
        End If
        ' clear table
        If SQL.SQLTable IsNot Nothing Then
            SQL.SQLTable.Clear()
        End If
        ' get query params and execute
        SQL.AddParam("@user_ID", user)
        SQL.AddParam("@movie_ID", movie_ID)
        SQL.AddParam("@date", DateTime.Now) ' changed to be date time for ordering in list
        SQL.ExecuteQuery("INSERT INTO Order_Queue (account_number, movie_id, date) " &
                         "VALUES (@user_ID, @movie_ID, @date)")
        If SQL.HasException(True) Then Exit Sub
        MsgBox("The movie """ + movieSelect.Text + """ has been added to your queue")
        LoadMovies()

    End Sub

    Private Sub btnEditQueue_Click(sender As Object, e As EventArgs) Handles btnEditQueue.Click ' Works how expected ******************************************************** DONE
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
        LoadMovies()
    End Sub

    Private Sub btnRate_Click(sender As Object, e As EventArgs) Handles btnRate.Click ' Works how I expect *************************************************************** DONE
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
        ' MsgBox(averageRating) ' for test purposes
        SQL.ExecuteQuery("UPDATE Movie_Data " &
                         "SET rating=" + averageRating.ToString + " " &
                         "WHERE movie_id=" + movie_ID.ToString + ";")
        MsgBox("Your rating has been submitted")
        LoadMovies()
    End Sub

    Private Sub rentMovie_Click(sender As Object, e As EventArgs) Handles rentMovie.Click ' Seems to work *********************************************************** POSSIBLY DONE
        ' for allowing a movie rental
        ' need to check if the movie is available by counting the number of already rented versus the number that can be rented
        If SQL.SQLTable IsNot Nothing Then
            SQL.SQLTable.Clear()
        End If
        ' clear table
        If SQL.SQLTable IsNot Nothing Then
            SQL.SQLTable.Clear()
        End If
        ' obtain their account information
        Dim account_type As String
        Dim ttlAllowedRentals As Integer
        ' get the users account type and number of movies they are allowed to rent
        SQL.ExecuteQuery("SELECT type, num_of_movies FROM Account as A INNER JOIN Customer_Data as CD ON A.type=CD.account_type WHERE account_number='" + GetAccount().ToString + "';")
        If SQL.SQLTable.Rows.Count > 0 Then
            account_type = SQL.SQLTable.Rows(0).Item("type")
            ttlAllowedRentals = SQL.SQLTable.Rows(0).Item("num_of_movies")
        Else
            MsgBox("error")
            Exit Sub
        End If
        'MsgBox(account_type + " " + ttlAllowedRentals.ToString) ' for test
        ' clear table
        If SQL.SQLTable IsNot Nothing Then
            SQL.SQLTable.Clear()
        End If
        Dim rentCount As Integer
        ' check to see if they already have a rental
        SQL.ExecuteQuery("SELECT count(return_flag) as ttl FROM Order_Data WHERE account_number='" + GetAccount().ToString + "' AND return_flag = 0;")
        If SQL.SQLTable.Rows.Count > 0 Then
            rentCount = SQL.SQLTable.Rows(0).Item("ttl")
            'MsgBox("rented=" + rentCount.ToString)
        End If
        ' check to see if customer is allowed to rent 
        If checkRent(GetAccount().ToString, account_type, rentCount) = False Then
            Exit Sub
        End If
        FindAvail()

    End Sub

    Private Function checkRent(user As String, account_type As String, rentCount As Integer) ' SEEMS TO WORK ************************************************************* DONE
        ' need to check if they have rented this month
        If account_type = "limited" Then ' if they have already rented twice this month than they are not allowed to rent again
            If rentCount > 0 Then ' if they still have a rental out, exit the sub
                MsgBox("You must first return a movie before you can rent another")
                Return False
            End If
            ' clear table
            If SQL.SQLTable IsNot Nothing Then
                SQL.SQLTable.Clear()
            End If
            Dim today As Date = DateTime.Now
            ' get the rentals from the user in the past month
            SQL.ExecuteQuery("SELECT date FROM Order_Data WHERE account_number='" + user + "' AND return_flag = 1 AND date>DATEADD(month, -1, '" + today + "')")
            If SQL.SQLTable.Rows.Count > 0 Then
                If SQL.SQLTable.Rows.Count > 1 Then ' if they have already rented two this month then they cannot rent anymore
                    MsgBox("Sorry, you have reached your limit for rentals this month." + vbCrLf + "Please check back at a later date") ' how to get it to center?
                    Return False
                End If
            End If
        Else ' if account is an unlimited, no need to check dates
            If account_type = "unlim1" Then
                If rentCount > 0 Then
                    MsgBox("You are only allowed one rental at a time. Please return a movie first")
                    Return False
                End If
            ElseIf account_type = "unlim2" Then
                If rentCount > 1 Then
                    MsgBox("You are only allowed two rentals at a time. Please return a movie first")
                    Return False
                End If
            ElseIf account_type = "unlim3" Then
                If rentCount > 2 Then
                    MsgBox("You are only allowed three rentals at a time. Please return a movie first")
                    Return False
                End If
            End If
        End If ' WORKS UP TO THIS POINT
        'MsgBox("You may rent a movie") ' for test purposes
        Return True
    End Function

    Private Sub FindAvail() ' This seems to work ******************************************************************************************************************* DONE
        ' if so rent the first available movie
        ' clear table
        If SQL.SQLTable IsNot Nothing Then
            SQL.SQLTable.Clear()
        End If
        'for loop of the rental queue
        Dim movie As String = ""
        For i As Integer = 0 To (cbxQueue.Items.Count() - 1) ' loop through all of the items in the combo box
            movie = cbxQueue.Items(i) ' copy the movie title for the next available movie
            SQL.ExecuteQuery("SELECT count(return_flag) as copies FROM Order_Data as OD INNER JOIN Movie_Data as MD ON OD.movie_id=MD.movie_id WHERE movie_name='" +
                                cbxQueue.Items(i) + "' AND return_flag = 0;") ' check each item in the list starting from the top of the queue
            Dim movieCopiesOut As Integer
            If SQL.SQLTable.Rows.Count > 0 Then
                movieCopiesOut = SQL.SQLTable.Rows(0).Item("copies")
                'MsgBox(movieCopiesOut) ' for text purposes
            End If
            SQL.ExecuteQuery("SELECT inventory FROM Movie_Data WHERE movie_name='" + cbxQueue.Items(i) + "';")
            If SQL.SQLTable.Rows.Count > 0 Then
                If movieCopiesOut < SQL.SQLTable.Rows(0).Item("inventory") Then ' if there are no copies left to rent
                    Exit For ' if a movie can be rented, go on 
                End If
            End If
            If i = cbxQueue.Items.Count() - 1 Then ' if in the odd instance that no choices can be rented
                MsgBox("Unfortunately, all of your choices are unavailable right now")
                Exit Sub
            End If
        Next
        sendMovie(movie) ' since all is good, go ahead and rent
    End Sub

    Private Sub sendMovie(movieToRent As String) ' This seems to work *********************************************************************************************** DONE
        If movieToRent = "" Then
            MsgBox("Error")
            Exit Sub
        End If
        ' get the number of employees
        SQL.ExecuteQuery("SELECT count(*) as ttl FROM Employee_Data")
        Dim ttl As Integer = 0
        If SQL.SQLTable.Rows.Count > 0 Then
            ttl = SQL.SQLTable.Rows(0).Item("ttl")
        End If
        Dim random As Random = New Random
        Dim employee As Integer = random.Next(1, ttl + 1) ' generate and assign a random employee
        ' generate the next order id
        SQL.ExecuteQuery("SELECT count(*) as ttl FROM Order_Data")
        Dim order_ID As Integer = 0
        If SQL.SQLTable.Rows.Count > 0 Then
            order_ID = SQL.SQLTable.Rows(0).Item("ttl") + 1
        End If
        ' get the movie id
        SQL.ExecuteQuery("SELECT movie_id " &
                         "FROM Movie_Data " &
                         "WHERE movie_name LIKE '" + movieToRent + "';")
        Dim movie_ID As String = ""
        If SQL.SQLTable.Rows.Count > 0 Then
            movie_ID = SQL.SQLTable.Rows(0).Item("movie_id").ToString
        End If
        If movie_ID = "" Then
            MsgBox("error")
            Exit Sub
        End If
        SQL.AddParam("@order_id", order_ID)
        SQL.AddParam("@date", Date.Now)
        SQL.AddParam("@sin", employee)
        SQL.AddParam("@account", GetAccount().ToString)
        SQL.AddParam("movie_id", movie_ID)
        SQL.AddParam("@return", 0)
        SQL.AddParam("@rate", "NULL")
        'MsgBox("*** " + order_ID.ToString + " " + Date.Now.ToString + " " + employee.ToString + " " + GetAccount().ToString + " " + movie_ID.ToString) ' for test purposes
        SQL.ExecuteQuery("INSERT INTO Order_Data (order_id, date, return_flag, account_number, movie_id, SIN) " &
                         "VALUES (@order_id, @date, @return, @account, @movie_id, @sin); " &
                         "INSERT INTO Rental_History (account_number, order_id) " &
                         "VALUES (@account, @order_id);")
        If SQL.HasException Then Exit Sub
        ' update the movie queue
        SQL.ExecuteQuery("DELETE FROM Order_Queue " &
                         "WHERE account_number=" + GetAccount().ToString + " AND movie_id=" + movie_ID + ";")
        'rental history
        MsgBox("Your movie has been shipped")
        LoadMovies()
    End Sub


    Private Sub btnReturnMovie_Click(sender As Object, e As EventArgs) Handles btnReturnMovie.Click ' This works how I expect it to ******************************************** DONE
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
        SQL.ExecuteQuery("SELECT order_id FROM Order_Data WHERE account_number='" + user + "' AND movie_id=" + movie_ID + ";")
        Dim orderNum As Integer
        If SQL.SQLTable.Rows.Count > 0 Then
            orderNum = SQL.SQLTable.Rows(0).Item("order_id").ToString
        End If
        'MsgBox(orderNum) ' for test purposes
        ' remove from queue
        SQL.AddParam("@order_ID", orderNum)
        SQL.AddParam("@user_ID", user)
        SQL.AddParam("@movie_ID", movie_ID)
        ' remove from current rentals
        SQL.ExecuteQuery("UPDATE Order_Data " &
                         "SET return_flag=1 " &
                         "WHERE account_number=@user_ID AND movie_id=@movie_ID AND order_id=@order_ID;")
        If SQL.HasException(True) Then Exit Sub
        ' update Rental_History ' this needs to happen during the rent process
        MsgBox("The movie """ + cbCurrentRentals.Text + """ has been returned")
        LoadMovies()
    End Sub

End Class

