Imports System.Math
Public Class Recommendation
    Public Shared Function GetRecommendations(ID As Integer) As List(Of Integer)
        Dim SQL As New SQLControl
        Dim TopMovies As New List(Of Integer)
        Dim Nearest As New List(Of Integer)
        Dim Data As New Dictionary(Of Integer, Double)
        Dim MyData As New Dictionary(Of Integer, Double)

        'Get users movie ratings
        SQL.AddParam("@acct", ID)
        SQL.ExecuteQuery("SELECT movie_data.movie_id, rental_history.movie_rating as rating FROM movie_data, rental_history, order_data " &
                         "WHERE rental_history.account_number = @acct AND " &
                         "rental_history.order_id = order_data.order_id AND " &
                         "order_data.movie_id = movie_data.movie_id;")
        If SQL.HasException(True) Then Exit Function

        'Store results
        For Each r As DataRow In SQL.SQLTable.Rows
            MyData.Add(r("movie_id"), r("rating"))
        Next

        'Get everyone elses movie ratings
        SQL.AddParam("@acct", ID)
        SQL.ExecuteQuery("SELECT rental_history.account_number, rental_history.movie_rating as rating, order_data.movie_id " &
                         "FROM movie_data, rental_history, order_data " &
                         "WHERE rental_history.account_number != @acct AND " &
                         "rental_history.order_id = order_Data.order_id AND " &
                         "order_data.movie_id = movie_data.movie_id;")
        If SQL.HasException(True) Then Exit Function

        'Calculate the distance between all other users and the target user
        For Each r As DataRow In SQL.SQLTable.Rows
            Dim diff As Double = 0.0
            If MyData.ContainsKey(r("movie_id")) Then
                diff += (MyData(r("movie_id")) - r("rating")) ^ 2
            End If

            If Data.ContainsKey(r("account_number")) Then
                Data(r("account_number")) = Sqrt(Data(r("account_number")) ^ 2 + diff)
            Else
                Data.Add(r("account_number"), Sqrt(diff))
            End If
        Next

        'Find top 5 closest neighbors (shortest distance)
        For Each i As Integer In {1, 2, 3, 4, 5}
            Dim min As Double = Data.Values.Min
            Dim cust_id As Integer
            For Each KvP As KeyValuePair(Of Integer, Double) In Data
                Dim Key As Integer = KvP.Key
                Dim Value As Double = KvP.Value
                If min = Value Then
                    cust_id = Key
                    Exit For
                End If
            Next
            Nearest.Add(cust_id)
            Data.Remove(cust_id)
        Next

        'For each of these, find the movies they liked
        For Each customer As Integer In Nearest
            SQL.AddParam("@acct", customer)
            SQL.ExecuteQuery("SELECT order_data.movie_id FROM rental_history, order_data " &
                             "WHERE rental_history.order_id = order_data.order_id AND " &
                             "rental_history.account_number = @acct AND " &
                             "rental_history.rating > 3;")
            If SQL.HasException(True) Then Exit Function

            'MsgBox(SQL.RecordCount)

            For Each r As DataRow In Sql.SQLTable.Rows
                TopMovies.Add(r("movie_id"))
                If TopMovies.Count >= 10 Then
                    Return TopMovies
                End If
            Next
        Next

        Return TopMovies
    End Function

End Class
