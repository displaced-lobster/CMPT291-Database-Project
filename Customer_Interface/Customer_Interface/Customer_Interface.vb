
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
        Me.Hide() ' have it reapear after done
        Edit_Customer_Account.Show()
    End Sub

    Private Sub btnChangePass_Click(sender As Object, e As EventArgs)

    End Sub

    ' load the past, current and queue fields for the customers account info with movies
    Private Sub LoadMovies()
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
        If SQL.SQLTable IsNot Nothing Then
            SQL.SQLTable.Clear()
        End If
        SQL.ExecuteQuery("SELECT DISTINCT(movie_name) as Movies " &
                         "FROM Order_Data as OD, Movie_Data as MD " &
                         "WHERE OD.movie_id = MD.movie_id AND return_flag = 0 AND account_number = " & CInt(GetAccount()) & ";")
        If SQL.HasException(True) Then Exit Sub

        ttlRows = SQL.SQLTable.Rows.Count()
        For i As Integer = 0 To (ttlRows - 1)
            cbxCur.Items.Add(SQL.SQLTable.Rows(i).Item("Movies").ToString)
        Next

        ' load pull down for order queue
        If SQL.SQLTable IsNot Nothing Then
            SQL.SQLTable.Clear()
        End If
        SQL.ExecuteQuery("SELECT DISTINCT(movie_name) as Movies, date " &
                         "FROM Order_Queue as OQ, Movie_Data as MD " &
                         "WHERE OQ.movie_id = MD.movie_id AND account_number = " & CInt(GetAccount()) &
                         "ORDER BY date ASC;")
        If SQL.HasException(True) Then Exit Sub

        ttlRows = SQL.SQLTable.Rows.Count()
        For i As Integer = 0 To (ttlRows - 1)
            cbxQueue.Items.Add(SQL.SQLTable.Rows(i).Item("Movies").ToString)
            cbEditQueue.Items.Add(SQL.SQLTable.Rows(i).Item("Movies").ToString)
        Next
    End Sub

    ' load the account information fields
    Public Sub LoadData()
        Dim user As String = GetAccount()

        ' clear table
        If SQL.SQLTable IsNot Nothing Then
            SQL.SQLTable.Clear()
        End If

        SQL.ExecuteQuery("SELECT * FROM Customer_Data as CD INNER JOIN Customer_Phone_Numbers as CPN ON CD.account_number = CPN.account_number WHERE CPN.account_number = " + user + ";")

        txtUserName.Text = SQL.SQLTable.Rows(0).Item("first_name") & " " & SQL.SQLTable.Rows(0).Item("last_name") ' print User name

        Dim rowNumbers As Integer = SQL.SQLTable.Rows.Count()

        Dim i As Object = SQL.SQLTable.Rows(0)
        Dim accountNumber As String = i.Item("account_number")
        Dim fullName As String = i.Item("first_name") + " " + i.Item("last_name")
        Dim email As String = i.Item("email")
        Dim address As String = "#" & i.Item("apartment_num") & " " & i.Item("street_num") & " " & i.Item("street") & vbCrLf &
                               "    " & i.Item("city") & ", " & i.Item("state") & ", " & i.Item("zip_code")
        Dim cardNum As String = i.Item("credit_card_num")
        Dim type As String = i.Item("account_type")
        Dim creation As String = i.Item("creation_date")
        Dim phone1 As String = i.item("phone_type") + ": " + i.Item("telephone_num")

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
                       "Name: " + fullName + vbCrLf +
                       "Email: " + email + vbCrLf +
                       "Phone Number: " + vbCrLf + "    " + phone1 + vbCrLf + vbCrLf +
                       "Address: " + address + vbCrLf + vbCrLf +
                       "Card Number: " & cardNum & vbCrLf & vbCrLf &
                       "Account Type: " & type & vbCrLf &
                       "Account Created On: " & creation

    End Sub

    Private Sub btnBest_Click(sender As Object, e As EventArgs) Handles btnBest.Click
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

    Private Sub btnPersonal_Click(sender As Object, e As EventArgs) Handles btnPersonal.Click

        ' recomemended does not work ***************************

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
                        queryString += "movie_name LIKE '%" + word + "%' AND " ' could be OR?
                    End If
                Next
            ElseIf rbActor.Checked = True Then
                ' works for one name but not two at a time ***************************************************************************************************************
                queryString += "FROM Movie_Data AS MD FULL JOIN Acts_In AS AI ON MD.movie_id=AI.movie_id FULL JOIN Actor_Data as AD ON AI.actor_id=AD.actor_id WHERE "
                For Each word As String In words
                    If word = words(ttl - 1) Then ' if at the end 
                        queryString += "(first_name LIKE '%" + word + "%' OR last_name LIKE '%" + word + "%')"
                    Else
                        queryString += "(first_name LIKE '%" + word + "%' OR last_name LIKE '%" + word + "%') AND " ' could be OR?
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
        cbxQueue.Items.Clear()
        cbEditQueue.Items.Clear()
        LoadMovies()

    End Sub

    Private Sub btnEditQueue_Click(sender As Object, e As EventArgs) Handles btnEditQueue.Click
        ' need to order the queue by date
        ' clear table
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
        cbEditQueue.Items.Clear()
        cbxQueue.Items.Clear()
        LoadMovies()
    End Sub

    Private Sub btnRatingSearch_Click(sender As Object, e As EventArgs) Handles btnRatingSearch.Click
        Dim ttl As Integer
        Dim movieList As String = ""
        Dim actorList As String = ""

        ' clear table
        If SQL.SQLTable IsNot Nothing Then
            SQL.SQLTable.Clear()
        End If
        ' reset fields
        cbRateRes.Items.Clear() ' clear the text field
        cbRateRes.Refresh()

        If txtRatingSearch.Text = "" Then Exit Sub
        ' run the query
        If rbRateMovie.Checked = True Then
            SQL.ExecuteQuery("SELECT DISTINCT(movie_name) AS Movies " &
                             "FROM Movie_Data " &
                             "WHERE movie_name LIKE '%" + txtRatingSearch.Text + "%';")
            If SQL.HasException(True) Then Exit Sub
            ttl = SQL.SQLTable.Rows.Count()

            If SQL.SQLTable.Rows.Count > 0 Then
                For i As Integer = 0 To (ttl - 1)
                    cbRateRes.Items.Add(SQL.SQLTable.Rows(i).Item("Movies").ToString)
                Next
            End If

        ElseIf rbRateActor.Checked = True Then
            SQL.ExecuteQuery("SELECT first_name, last_name " &
                             "FROM Actor_Data " &
                             "WHERE first_name LIKE '%" + txtRatingSearch.Text + "%' OR last_name LIKE '%" + txtRatingSearch.Text + "%'")
            If SQL.HasException(True) Then Exit Sub
            ttl = SQL.SQLTable.Rows.Count()

            If SQL.SQLTable.Rows.Count > 0 Then
                For i As Integer = 0 To (ttl - 1)
                    cbRateRes.Items.Add(SQL.SQLTable.Rows(i).Item("first_name").ToString + " " + SQL.SQLTable.Rows(i).Item("last_name").ToString)
                Next
            End If
        Else
            ' if nothing was selected
            MsgBox("Please choose to search by either title or actor")
            Exit Sub
        End If

        txtRatingSearch.Clear()
    End Sub

    Private Sub btnRate_Click(sender As Object, e As EventArgs) Handles btnRate.Click
        'cbRateRes.Text
        Dim rating As String
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

        ' if based on rb actor or title
        If rbRateMovie.Checked Then
            ' get the rating and adjust before updating
            ' need a way of keeping track of the number of ratings for average **********************************************************************
            'SQL.ExecuteQuery("")
            ' update the entry
        ElseIf rbRateMovie.Checked Then
            ' get the rating and adjust before updating
            ' need a way of keeping track of the number of ratings for average **********************************************************************
            'SQL.ExecuteQuery("")
            ' update the entry
        End If

    End Sub

    Private Sub rentMovie_Click(sender As Object, e As EventArgs) Handles rentMovie.Click
        ' for allowing a movie rental
    End Sub
End Class

