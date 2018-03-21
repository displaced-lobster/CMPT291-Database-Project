Public Class Main_Interface

    Private Sub Close_Click(sender As Object, e As EventArgs) Handles Close.Click
        Application.Exit() ' terminate the program
    End Sub


    Private Sub EmployeeServicesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmployeeServicesToolStripMenuItem.Click
        ' This should go to an employee login page
        Customer_Rep.Show()
    End Sub

    Private Sub CustomersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CustomersToolStripMenuItem.Click
        Customer_Login.Show()
    End Sub

End Class