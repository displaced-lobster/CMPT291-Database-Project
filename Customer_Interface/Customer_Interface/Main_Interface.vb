Public Class Main_Interface
    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        Customer_Home_Page.Show()
    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        Customer_Interactions.Show()
    End Sub

    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        Customer_Login.Show()
    End Sub

    Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        Customer_Rep.Show()
    End Sub

    Private Sub btn5_Click(sender As Object, e As EventArgs) Handles btn5.Click
        Customer_SignUp.Show()
    End Sub
End Class