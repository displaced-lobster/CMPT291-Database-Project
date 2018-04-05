Public Class Main_Interface

    Private Sub Close_Click(sender As Object, e As EventArgs) Handles Close.Click
        Application.Exit() ' terminate the program
    End Sub

    Private Sub CustomersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CustomersToolStripMenuItem.Click
        Customer_SignUp.Show()
        pbBlueBox.Hide()
    End Sub

    Private Sub EmployeeServicesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmployeeServicesToolStripMenuItem.Click
        Customer_Login.Show()
        pbBlueBox.Hide()
    End Sub

    Private Sub EmployeeServicesToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles EmployeeServicesToolStripMenuItem1.Click
        Employee_Login.Show()
        pbBlueBox.Hide()
    End Sub

    Private Sub TestToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TestToolStripMenuItem.Click
        Test_Query_Page.Show()
        pbBlueBox.Hide()
    End Sub

    Private Sub ManagerServicesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ManagerServicesToolStripMenuItem.Click
        Main_Manager_Interface.Show()
        pbBlueBox.Hide()
    End Sub

End Class