Public Class CustomerHelp
    Private Sub CustomerHelp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MdiParent = Main_Interface
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        Main_Interface.pbBlueBox.Show()
    End Sub
End Class