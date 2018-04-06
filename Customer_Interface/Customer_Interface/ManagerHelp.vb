Public Class ManagerHelp
    Private Sub ManagerHelp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MdiParent = Main_Interface
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
        Main_Interface.pbBlueBox.Show()
    End Sub
End Class