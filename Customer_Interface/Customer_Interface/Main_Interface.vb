Public Class Main_Interface

    Private Sub Close_Click(sender As Object, e As EventArgs) Handles Close.Click
        Application.Exit() ' terminate the program
    End Sub

    Private Sub CustomersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CustomersToolStripMenuItem.Click
        Customer_SignUp.Show()
        pbBlueBox.Hide()
    End Sub

    Private Sub EmployeeServicesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmployeeServicesToolStripMenuItem.Click
        My.Application.OpenForms.Cast(Of Form)().Except({Me}).ToList().ForEach(Sub(form) form.Close())  ' close all forms open first to close any current sessions
        Customer_Login.username.Clear() ' clear any past login information
        Customer_Login.passwd.Clear()
        Customer_Login.Show()
        pbBlueBox.Hide()
    End Sub

    Private Sub EmployeeServicesToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles EmployeeServicesToolStripMenuItem1.Click
        My.Application.OpenForms.Cast(Of Form)().Except({Me}).ToList().ForEach(Sub(form) form.Close())  ' close all forms open first to close any current sessions
        Employee_Login.Show()
        pbBlueBox.Hide()
    End Sub

    Private Sub ManagerServicesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ManagerServicesToolStripMenuItem.Click
        My.Application.OpenForms.Cast(Of Form)().Except({Me}).ToList().ForEach(Sub(form) form.Close())  ' close all forms open first to close any current sessions
        Main_Manager_Interface.Show()
        pbBlueBox.Hide()
    End Sub

    Private Sub UserHelpToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UserHelpToolStripMenuItem.Click
        CustomerHelp.Show()
        pbBlueBox.Hide()
    End Sub

End Class