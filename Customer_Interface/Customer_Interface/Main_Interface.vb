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
        Main_Manager_Interface.Show()
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
End Class