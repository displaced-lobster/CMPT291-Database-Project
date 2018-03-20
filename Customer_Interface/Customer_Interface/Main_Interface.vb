Public Class Main_Interface
    Private Sub C_Home_Page_Click(sender As Object, e As EventArgs) Handles C_Home_Page.Click
        Customer_Home_Page.Show()
    End Sub

    Private Sub C_Interactions_Click(sender As Object, e As EventArgs) Handles C_Interactions.Click
        Customer_Interactions.Show()
    End Sub

    Private Sub C_Login_Click(sender As Object, e As EventArgs) Handles C_Login.Click
        Customer_Login.Show()
    End Sub

    Private Sub C_Rep_Click(sender As Object, e As EventArgs) Handles C_Rep.Click
        Customer_Rep.Show()
    End Sub

    Private Sub C_Signup_Click(sender As Object, e As EventArgs) Handles C_Signup.Click
        Customer_SignUp.Show()
    End Sub

    Private Sub Test_Q_Click(sender As Object, e As EventArgs) Handles Test_Q.Click
        Test_Query_Page.Show()
    End Sub

    Private Sub Close_Click(sender As Object, e As EventArgs) Handles Close.Click
        Application.Exit() ' terminate the program
    End Sub
End Class