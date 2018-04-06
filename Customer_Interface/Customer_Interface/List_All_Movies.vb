Public Class List_All_Movies
    Private SQL As New SQLControl

    Private Sub List_All_Movies_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MdiParent = Main_Interface

        SQL.ExecuteQuery("Select movie_id as ID, movie_name as Name, movie_type as Type, distribution_fee as Fee, inventory as Inventory, rating as Rating From Movie_Data")
        data_grid_movies.DataSource = SQL.SQLTable
    End Sub

    Private Sub movie_list_close_btn_Click(sender As Object, e As EventArgs) Handles movie_list_close_btn.Click
        Me.Close()
    End Sub
End Class