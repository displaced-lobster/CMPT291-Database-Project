Public Class Main_Manager_Interface
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

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles MI_add_emp_btn.Click

    End Sub

    Private Sub MI_list_movies_btn_Click(sender As Object, e As EventArgs) Handles MI_list_movies_btn.Click
        List_All_Movies.Show()
    End Sub

    Private Sub MI_list_rentals_btn_Click(sender As Object, e As EventArgs) Handles MI_list_rentals_btn.Click
        List_Current_Rentals.Show()
    End Sub

    Private Sub MI_sr_btn_Click(sender As Object, e As EventArgs) Handles MI_sr_btn.Click
        Sales_Report_Generator.Show()
    End Sub

    Private Sub MI_active_custs_btn_Click(sender As Object, e As EventArgs) Handles MI_active_custs_btn.Click
        Check_Most_Active.Show()
    End Sub
End Class