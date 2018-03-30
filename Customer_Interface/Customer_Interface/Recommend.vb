

Public Class Recommend
    Private SQL As New SQLControl


    Public Function Recommended(account As String) As SQLControl
        If SQL.SQLTable IsNot Nothing Then
            SQL.SQLTable.Clear()
        End If
        ' I know that this doesn't work for what we need but It's just something to get started
        SQL.ExecuteQuery("SELECT movie_name as Movies " &
                         "FROM Movie_Data " &
                         "WHERE movie_type = (Select T1.movie_type " &
                                             "FROM (SELECT movie_type, COUNT(movie_type) As ttl " &
                                                   "FROM Movie_Data AS MD INNER JOIN Order_Data AS OD ON OD.movie_id=MD.movie_id " &
                                                   "GROUP BY movie_type, account_number " &
                                                   "HAVING account_number=" + account + ") as T1, " &
                                                  "(SELECT movie_type, COUNT(movie_type) as ttl " &
                                                   "FROM Movie_Data AS MD INNER JOIN Order_Data AS OD ON OD.movie_id=MD.movie_id " &
                                                   "GROUP BY movie_type, account_number " &
                                                   "HAVING account_number=" + account + ") as T2 " &
                                             "WHERE T1.ttl > T2.ttl);")
        Return SQL ' I have no clue if this will actually work the way we expect for returning
    End Function

End Class
