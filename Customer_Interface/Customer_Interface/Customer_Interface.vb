Public Class Customer_Interface
    Private Sub Customer_Interface_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MdiParent = Main_Interface
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim user As String
        user = Customer_Login.UserAccount()
        MsgBox(user)

        Customer_Login.Close()
        Me.Close()
        MsgBox("Connection closed")
    End Sub
End Class