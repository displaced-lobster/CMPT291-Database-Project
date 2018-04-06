Public Class ManagerHelp
    Private Sub ManagerHelp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MdiParent = Main_Interface
    End Sub

    Private Sub GroupBox9_Enter(sender As Object, e As EventArgs) Handles GroupBox9.Enter

    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Main_Interface.pbBlueBox.Show()
    End Sub
End Class