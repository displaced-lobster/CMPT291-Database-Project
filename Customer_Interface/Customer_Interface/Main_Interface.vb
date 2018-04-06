Public Class Main_Interface

    Private Sub Close_Click(sender As Object, e As EventArgs) Handles Close.Click
        Application.Exit() ' terminate the program
    End Sub

    Private Sub CustomersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CustomersToolStripMenuItem.Click
        My.Application.OpenForms.Cast(Of Form)().Except({Me}).ToList() ' close all previous windows
        Customer_SignUp.Show()
        pbBlueBox.Hide()
    End Sub

    Private Sub EmployeeServicesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmployeeServicesToolStripMenuItem.Click
        My.Application.OpenForms.Cast(Of Form)().Except({Me}).ToList() ' close all previous windows
        Customer_Login.username.Clear()
        Customer_Login.passwd.Clear()
        Customer_Login.Show()
        pbBlueBox.Hide()
    End Sub

    Private Sub EmployeeServicesToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles EmployeeServicesToolStripMenuItem1.Click
        My.Application.OpenForms.Cast(Of Form)().Except({Me}).ToList() ' close all previous windows
        Employee_Login.username.Clear()
        Employee_Login.passwd.Clear()
        Employee_Login.Show()
        pbBlueBox.Hide()
    End Sub

    Private Sub ManagerServicesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ManagerServicesToolStripMenuItem.Click
        My.Application.OpenForms.Cast(Of Form)().Except({Me}).ToList() ' close all previous windows
        Manager_LogIn.Show()
        pbBlueBox.Hide()
    End Sub

    Private Sub UserHelpToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UserHelpToolStripMenuItem.Click
        My.Application.OpenForms.Cast(Of Form)().Except({Me}).ToList() ' close all previous windows
        CustomerHelp.Show()
        pbBlueBox.Hide()
    End Sub

    Private Sub EmployeeHelpToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmployeeHelpToolStripMenuItem.Click
        My.Application.OpenForms.Cast(Of Form)().Except({Me}).ToList() ' close all previous windows
        EmployeeHelp.Show()
        pbBlueBox.Hide()
    End Sub

    Private Sub ManagerHelpToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ManagerHelpToolStripMenuItem.Click
        My.Application.OpenForms.Cast(Of Form)().Except({Me}).ToList() ' close all previous windows
        ManagerHelp.Show()
        pbBlueBox.Hide()
    End Sub

    Private Sub InterestingFactoidToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InterestingFactoidToolStripMenuItem.Click
        Dim SQL As New SQLControl
        SQL.ExecuteQuery("SELECT first_name, last_name " &
                         "FROM actor_data, " &
                         "(SELECT TOP 1 actor_data.actor_id, count(movie_data.movie_id) AS bad_movies " &
                         "FROM actor_data, movie_data, acts_in " &
                         "WHERE actor_data.actor_id = acts_in.actor_id AND " &
                         "movie_data.movie_id = acts_in.movie_id AND " &
                         "actor_data.rating > 4 AND movie_data.rating < 2 " &
                         "GROUP BY actor_data.actor_id ORDER BY bad_movies DESC) AS flops " &
                         "WHERE actor_data.actor_id = flops.actor_id;")
        If SQL.HasException(True) Then Exit Sub

        MsgBox("The best actor in the worst films: " + SQL.SQLTable.Rows(0).ItemArray(0) + " " + SQL.SQLTable.Rows(0).ItemArray(1))
    End Sub
End Class