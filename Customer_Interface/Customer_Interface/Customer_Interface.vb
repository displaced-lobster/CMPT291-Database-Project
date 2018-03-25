

' "COLLATE Latin1_General_CS_AS" used for case sensitivity

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
        Edit_Customer_Account.Show()
    End Sub

    Private Sub btnChangePass_Click(sender As Object, e As EventArgs)

    End Sub

    ' load the past, current and queue fields for the customers account info with movies
    Private Sub LoadMovies()
        SQL.ExecuteQuery("SELECT DISTINCT(movie_name) as Movies " &
                         "FROM Order_Data as OD, Movie_Data as MD " &
                         "WHERE OD.movie_id = MD.movie_id AND return_flag = 1 AND account_number = " & CInt(GetAccount()) & ";")
        Dim ttlRows As Integer = SQL.SQLTable.Rows.Count()
        For i As Integer = 0 To (ttlRows - 1)
            cbxPrev.Items.Add(SQL.SQLTable.Rows(i).Item("Movies").ToString)
        Next

        ' load pull down current movies
        SQL.ExecuteQuery("SELECT DISTINCT(movie_name) as Movies " &
                         "FROM Order_Data as OD, Movie_Data as MD " &
                         "WHERE OD.movie_id = MD.movie_id AND return_flag = 0 AND account_number = " & CInt(GetAccount()) & ";")
        ttlRows = SQL.SQLTable.Rows.Count()
        For i As Integer = 0 To (ttlRows - 1)
            cbxCur.Items.Add(SQL.SQLTable.Rows(i).Item("Movies").ToString)
        Next

        ' load pull down for order queue
        SQL.SQLTable.Clear()
        SQL.ExecuteQuery("SELECT DISTINCT(movie_name) as Movies " &
                         "FROM Order_Queue as OQ, Movie_Data as MD " &
                         "WHERE OQ.movie_id = MD.movie_id AND account_number = " & CInt(GetAccount()) & ";")
        ttlRows = SQL.SQLTable.Rows.Count()
        For i As Integer = 0 To (ttlRows - 1)
            cbxQueue.Items.Add(SQL.SQLTable.Rows(i).Item("Movies").ToString)
        Next
    End Sub

    ' load the account information fields
    Private Sub LoadData()
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
        txtRes.Text = ""

        ' run the query
        SQL.ExecuteQuery("SELECT DISTINCT(movie_name) AS Movies " &
                         "FROM Movie_Data " &
                         "WHERE rating >= 4; ")

        ttlMovies = SQL.SQLTable.Rows.Count()

        For i As Integer = 0 To (ttlMovies - 1)
            movieList = movieList + SQL.SQLTable.Rows(i).Item("Movies").ToString + vbCrLf
        Next
        txtRes.Text = movieList ' display movies

        For i As Integer = 0 To (ttlMovies - 1)
            movieSelect.Items.Add(SQL.SQLTable.Rows(i).Item("Movies").ToString)
        Next

    End Sub

    Private Sub btnPersonal_Click(sender As Object, e As EventArgs) Handles btnPersonal.Click
        Dim ttlMovies As Integer = SQL.SQLTable.Rows.Count()
        Dim movieList As String = ""
        ' clear table
        If SQL.SQLTable IsNot Nothing Then
            SQL.SQLTable.Clear()
        End If
        ' reset fields
        movieSelect.Items.Clear() ' clear entries in table
        movieSelect.Refresh() ' need to figure out how to get the list to shrink back down
        txtRes.Text = ""

        ' run the query
        SQL.ExecuteQuery("SELECT movie_name as Movies " &
                         "FROM Movie_Data " &
                         "WHERE movie_type = (Select T1.movie_type " &
                                             "FROM (SELECT movie_type, COUNT(movie_type) As ttl " &
                                                   "FROM Movie_Data AS MD INNER JOIN Order_Data AS OD ON OD.movie_id=MD.movie_id " &
                                                   "GROUP BY movie_type, account_number " &
                                                   "HAVING account_number = 1001) as T1, " &
                                                  "(SELECT movie_type, COUNT(movie_type) as ttl " &
                                                   "FROM Movie_Data AS MD INNER JOIN Order_Data AS OD ON OD.movie_id=MD.movie_id " &
                                                   "GROUP BY movie_type, account_number " &
                                                   "HAVING account_number = 1001) as T2 " &
                                             "WHERE T1.ttl > T2.ttl);")
        ttlMovies = SQL.SQLTable.Rows.Count()

        For i As Integer = 0 To (ttlMovies - 1)
            movieList = movieList + SQL.SQLTable.Rows(i).Item("Movies").ToString + vbCrLf
        Next
        txtRes.Text = movieList ' display movies

        For i As Integer = 0 To (ttlMovies - 1)
            movieSelect.Items.Add(SQL.SQLTable.Rows(i).Item("Movies").ToString)
        Next

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
        txtRes.Text = ""
        If SQL.SQLTable IsNot Nothing Then
            SQL.SQLTable.Clear()
        End If

        ' run the query
        If Trim(txtSearch.Text.ToLower) = "action" Or Trim(txtSearch.Text.ToLower) = "comedy" Or Trim(txtSearch.Text.ToLower) = "drama" Or Trim(txtSearch.Text.ToLower) = "foreign" Then
            ' clear table

            SQL.ExecuteQuery("SELECT movie_name AS Movies " &
                             "FROM Movie_Data " &
                             "WHERE movie_type LIKE '" + Trim(txtSearch.Text.ToLower) + "';")
            ttlMovies = SQL.SQLTable.Rows.Count()

            For i As Integer = 0 To (ttlMovies - 1)
                movieList = movieList + SQL.SQLTable.Rows(i).Item("Movies").ToString + vbCrLf
            Next
            txtRes.Text = movieList ' display movies

            For i As Integer = 0 To (ttlMovies - 1)
                movieSelect.Items.Add(SQL.SQLTable.Rows(i).Item("Movies").ToString)
            Next

        Else
            ' search first based on movie titles then based on actors
            ' check against sql attack
            Dim words() As String = txtSearch.Text.Split(" "c) ' split based on the space character
            Dim queryString As String = "SELECT DISTINCT(movie_name) AS Movies "
            Dim ttl As Integer = words.Length

            If rbTitle.Checked = True Then
                queryString += "FROM Movie_Data WHERE "
                For Each word As String In words
                    If word = words(ttl - 1) Then ' if at the end 
                        queryString += "movie_name LIKE '%" + word + "%';"
                    Else
                        queryString += "movie_name LIKE '%" + word + "%' OR " ' could be OR?
                    End If
                Next

                MsgBox(queryString)

            ElseIf rbActor.Checked = True Then
                MsgBox("Actor name")
            End If

            ' how to deal with with if a search returns nothing
            SQL.ExecuteQuery(queryString)
            'DataGridView1.DataSource = SQL.SQLTable

            ' error here depending on the situation *************************************************************
            If Not IsNothing(SQL.SQLTable) AndAlso SQL.SQLTable.Rows.Count > 0 Then
                For i As Integer = 0 To (ttlMovies - 2)
                    movieList = movieList + SQL.SQLTable.Rows(i).Item("Movies").ToString + vbCrLf
                Next
                txtRes.Text = movieList ' display movies

                For i As Integer = 0 To (ttlMovies - 2)
                    movieSelect.Items.Add(SQL.SQLTable.Rows(i).Item("Movies").ToString)
                Next
                MsgBox("Done")
            End If

        End If


    End Sub

    Private Sub search_param_CheckedChanged(sender As Object, e As EventArgs) Handles rbTitle.CheckedChanged, rbActor.CheckedChanged
        If rbTitle.Checked = True Or rbTitle.Checked = True Then
            btnSearch.Enabled = True
        End If
    End Sub
End Class


' if queue changes or if customer updates info, reload the customer data and movie data
' need to check if movie is already in customers queue


'ElseIf Trim(txtSearch.Text.ToLower) = "comedy" Then
'SQL.ExecuteQuery("SELECT movie_name AS Movies " &
'                             "FROM Movie_Data " &
'                             "WHERE movie_type LIKE 'Comedy';")
'ElseIf Trim(txtSearch.Text.ToLower) = "drama" Then
'SQL.ExecuteQuery("SELECT movie_name AS Movies " &
'                             "FROM Movie_Data " &
'                             "WHERE movie_type LIKE 'Drama';")
'ElseIf Trim(txtSearch.Text.ToLower) = "foreign" Then
'SQL.ExecuteQuery("SELECT movie_name AS Movies " &
'                             "FROM Movie_Data " &
'                             "WHERE movie_type LIKE 'Foreign';")
