Public Class Main_Manager_Interface
    Public SQL As New SQLControl

    Private Sub TabPage2_Click(sender As Object, e As EventArgs) Handles MI_EmpTab.Click

    End Sub

    Private Sub ManagerTab1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ManagerTab1.SelectedIndexChanged

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles MI_rem_emp_btn.Click

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles MI_edit_emp_btn.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles MI_emp_hr_tb.TextChanged

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles MI_emp_hr.Click

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles MI_emp_start_tb.TextChanged

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles MI_emp_start.Click

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles MI_emp_ln_tb.TextChanged

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles MI_emp_fn.Click

    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles MI_emp_fn_tb.TextChanged

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles MI_emp_ln.Click

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles MI_emp_sin.Click

    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles MI_emp_sin_tb.TextChanged

    End Sub

    Private Sub MI_list_movies_btn_Click(sender As Object, e As EventArgs) Handles MI_list_movies_btn.Click
        List_All_Movies.Show()
    End Sub

    Private Sub MI_list_rentals_btn_Click(sender As Object, e As EventArgs) Handles MI_list_rentals_btn.Click
        Current_Rentals.Show()
    End Sub

    Private Sub MI_sr_btn_Click(sender As Object, e As EventArgs) Handles MI_sr_btn.Click
        Sales_Report_Generator.Show()
    End Sub

    Private Sub MI_active_custs_btn_Click(sender As Object, e As EventArgs) Handles MI_active_custs_btn.Click
        Check_Most_Active.Show()
    End Sub

    Private Sub Main_Manager_Interface_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MdiParent = Main_Interface
    End Sub

    Private Sub MI_most_active_Click(sender As Object, e As EventArgs) Handles MI_most_active.Click

    End Sub

    Private Sub search_btn_Click(sender As Object, e As EventArgs) Handles search_btn.Click
        If (MI_movie_id_tb.Text.Length > 0) Then
            SQL.ExecuteQuery("Select * From Movie_Data Where movie_id = " & MI_movie_id_tb.Text & ";")

            If SQL.HasException(True) Then Exit Sub

            Try
                MI_movie_title_tb.Text = Convert.ToString(SQL.SQLTable.Rows(0).Item("movie_name"))
                MI_movie_type_tb.Text = Convert.ToString(SQL.SQLTable.Rows(0).Item("movie_type"))
                MI_dist_fee_tb.Text = Convert.ToString(SQL.SQLTable.Rows(0).Item("distribution_fee"))
                MI_inventory_tb.Text = Convert.ToString(SQL.SQLTable.Rows(0).Item("inventory"))
            Catch
                Exit Sub
            End Try
        End If
    End Sub

    Private Sub MI_add_movie_btn_Click(sender As Object, e As EventArgs) Handles MI_add_movie_btn.Click
        SQL.ExecuteQuery("INSERT INTO Movie_Data (movie_id, movie_name, movie_type, distribution_fee, inventory, rating) " &
                         "VALUES (" & MI_movie_id_tb.Text & ", '" & MI_movie_title_tb.Text & "', '" &
                         MI_movie_type_tb.Text & "', " & MI_dist_fee_tb.Text & ", " & MI_inventory_tb.Text & ", 0);")
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles MI_add_emp_btn.Click
        SQL.ExecuteQuery("INSERT INTO Employee_Data (SIN, first_name, last_name, city, state, zip_code, street, street_num, apartment_num, start_date, hourly_rate) " &
                         "VALUES (" & MI_emp_sin_tb.Text & ", '" & MI_emp_fn_tb.Text & "', '" & MI_emp_ln_tb.Text & "', '" & MI_emp_city_tb.Text &
                                  "', '" & MI_emp_state_tb.Text & "', " & MI_emp_zip_tb.Text & ", '" & MI_emp_street_tb.Text & "', " & MI_emp_street_num_tb.Text &
                                  ", " & MI_emp_ap_num_tb.Text & ", '" & MI_emp_start_tb.Text & "', " & MI_emp_hr_tb.Text & ");")
    End Sub

    Private Sub MI_edit_movie_btn_Click(sender As Object, e As EventArgs) Handles MI_edit_movie_btn.Click
        SQL.ExecuteQuery("UPDATE Movie_Data " &
                         "SET movie_name = '" & MI_movie_title_tb.Text & "', movie_type = '" & MI_movie_type_tb.Text &
                         "', distribution_fee = " & MI_dist_fee_tb.Text & ", inventory = " & MI_inventory_tb.Text &
                         " Where movie_id = " & MI_movie_id_tb.Text & ";")
    End Sub

    Private Sub MI_rem_movie_btn_Click(sender As Object, e As EventArgs) Handles MI_rem_movie_btn.Click
        SQL.ExecuteQuery("DELETE FROM Movie_Data Where movie_id = " & MI_movie_id_tb.Text & ";")

        MI_movie_id_tb.Text = ""
        MI_movie_title_tb.Text = ""
        MI_movie_type_tb.Text = ""
        MI_dist_fee_tb.Text = ""
        MI_inventory_tb.Text = ""
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles emp_search_btn.Click
        If (MI_movie_id_tb.Text.Length > 0) Then
            SQL.ExecuteQuery("Select * From Employee_Data Where SIN = " & MI_emp_sin_tb.Text & ";")

            If SQL.HasException(True) Then Exit Sub

            Try
                MI_emp_fn_tb.Text = Convert.ToString(SQL.SQLTable.Rows(0).Item("first_name"))
                MI_emp_ln_tb.Text = Convert.ToString(SQL.SQLTable.Rows(0).Item("last_name"))
                MI_emp_city_tb.Text = Convert.ToString(SQL.SQLTable.Rows(0).Item("city"))
                MI_emp_state_tb.Text = Convert.ToString(SQL.SQLTable.Rows(0).Item("state"))
                MI_emp_zip_tb.Text = Convert.ToString(SQL.SQLTable.Rows(0).Item("zip_code"))
                MI_emp_street_tb.Text = Convert.ToString(SQL.SQLTable.Rows(0).Item("street"))
                MI_emp_street_num_tb.Text = Convert.ToString(SQL.SQLTable.Rows(0).Item("steet_num"))
                MI_emp_ap_num_tb.Text = Convert.ToString(SQL.SQLTable.Rows(0).Item("apartment_num"))
                MI_emp_start_tb.Text = Convert.ToString(SQL.SQLTable.Rows(0).Item("start_date"))
                MI_emp_hr_tb.Text = Convert.ToString(SQL.SQLTable.Rows(0).Item("hourly_rate"))
            Catch
                Exit Sub
            End Try
        End If
    End Sub
End Class