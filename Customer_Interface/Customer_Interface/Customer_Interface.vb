
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

    Private Sub LoadData()
        Dim user As String = GetAccount()

        ' clear table
        If SQL.SQLTable IsNot Nothing Then
            SQL.SQLTable.Clear()
        End If
        '"SELECT * FROM Customer_Data WHERE account_number =" & user & ";"
        SQL.ExecuteQuery("SELECT * FROM Customer_Data as CD INNER JOIN Customer_Phone_Numbers as CPN ON CD.account_number = CPN.account_number WHERE CD.account_number = " + user + ";")
        txtUserName.Text = SQL.SQLTable.Rows(0).Item("first_name") & " " & SQL.SQLTable.Rows(0).Item("last_name") ' print User name
        Dim rowNumbers As Integer = SQL.SQLTable.Rows.Count()

        Dim i As Object = SQL.SQLTable.Rows(0)
        Dim accountNumber As String = i.Item("account_number")
        Dim fullName As String = i.Item("first_name") + " " + i.Item("last_name")
        Dim email As String = i.Item("email")
        Dim address As String = "#" & i.Item("apartment_num") & " " & i.Item("street_num") & " " & i.Item("street") & vbCrLf &
                                "    " & i.Item("city") & ", " & i.Item("state") & ", " & i.Item("zip_code")
        Dim cardNum As String = i.Item("credit_card_num")
        Dim type As String = i.Item("type")
        Dim creation As String = i.Item("creation_date")
        Dim phone1 As String = i.item("type1") + ": " + i.Item("telephone_num")

        If rowNumbers = 2 Then ' I recognize that this is overkill but it made managing the numbers easier
            Dim phone2 As String = SQL.SQLTable.Rows(1).Item("type1") + ": " + SQL.SQLTable.Rows(1).Item("telephone_num")
            phone1 = phone1 + vbCrLf + "    " + phone2
        End If
        If rowNumbers = 3 Then ' there can be at most 3 numbers on file
            Dim phone2 As String = SQL.SQLTable.Rows(1).Item("type1") + ": " + SQL.SQLTable.Rows(1).Item("telephone_num")
            Dim phone3 As String = SQL.SQLTable.Rows(2).Item("type1") + ": " + SQL.SQLTable.Rows(2).Item("telephone_num")
            phone1 = phone1 + vbCrLf + "    " + phone2 + vbCrLf + "    " + phone3
        End If

        ' print out current account information
        txtInfo.Text = "Account Number: " + accountNumber + vbCrLf +
                       "Name: " + fullName + vbCrLf +
                       "Email: " + email + vbCrLf +
                       "Phone Number: " + vbCrLf + "    " + phone1 + vbCrLf + vbCrLf +
                       "Address: " + address + vbCrLf + vbCrLf +
                       "Card Number: " & i.Item("credit_card_num") & vbCrLf & vbCrLf &
                       "Account Type: " & i.Item("type") & vbCrLf & ' add from other table
                       "Account Created On: " & i.Item("creation_date")

    End Sub

    Private Sub Radials_CheckedChanged(sender As Object, e As EventArgs) Handles Rtitles.CheckedChanged, Ractors.CheckedChanged,
            Rmovies.CheckedChanged, RbestSellers.CheckedChanged, Rpersonal.CheckedChanged
        btnSearch.Enabled = True

        If Rtitles.Checked Then
            ' search by title string(s)
        ElseIf Ractors.Checked Then
            ' search by actor string(s)
        ElseIf Rmovies.Checked Then
            ' search by type

        ElseIf RbestSellers.Checked Then
            ' search by top rating
        ElseIf Rpersonal.Checked Then
            ' filter to find most rented type of movies and then search based on that rating
        End If

    End Sub

End Class