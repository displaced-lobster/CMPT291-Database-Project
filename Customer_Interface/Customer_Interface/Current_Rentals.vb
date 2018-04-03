Public Class Current_Rentals
    Public SQL As New SQLControl

    Private Sub List_Current_Rentals_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MdiParent = Main_Interface
    End Sub

    Private Sub current_rentals_close_btn_Click(sender As Object, e As EventArgs) Handles close_btn_rentals.Click
        Me.Close()
    End Sub

    Private Sub execute_button_Click(sender As Object, e As EventArgs) Handles execute_button.Click
        If rentals_mn_rbutton.Checked = True Then
            ' If Movie Name was the selected option
            SQL.ExecuteQuery("Select C.first_name, C.last_name, O.date " &
                             "From Movie_Data as M, Order_Data as O, Customer_Data as C " &
                             "Where O.movie_id = M.movie_id and O.account_number = C.account_number and M.movie_name = '" & textbox_input.Text &
                             "' and O.return_flag = 0;")
        ElseIf rentals_mt_rbutton.Checked = True Then
            ' Movie Type
            SQL.ExecuteQuery("Select C.first_name, C.last_name, O.date " &
                             "From Movie_Data as M, Order_Data as O, Customer_Data as C " &
                             "Where O.movie_id = M.movie_id and O.account_number = C.account_number and M.movie_type = '" & textbox_input.Text &
                             "' and O.return_flag = 0;")
        ElseIf rentals_cn_rbutton.Checked = True Then
            ' Customer Name
            Dim strArr() As String = textbox_input.Text.Split(" ") ' Split name into two pieces in a string array
            If (strArr.Length <> 2) Then
                Exit Sub
            Else
                SQL.ExecuteQuery("Select C.first_name, C.last_name, O.date " &
                                 "From Movie_Data as M, Order_Data as O, Customer_Data as C, Rental_History as R " &
                                 "Where O.movie_id = M.movie_id And O.order_id = R.order_id And R.account_number = C.account_number " &
                                 "And C.first_name = '" & strArr(0) & "' and C.last_name = '" & strArr(1) & "' and O.return_flag = 0;")
            End If
        End If

        If SQL.HasException(True) Then Exit Sub
        data_grid_rentals.DataSource = SQL.SQLTable
    End Sub
End Class