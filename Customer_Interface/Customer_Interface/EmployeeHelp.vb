Public Class EmployeeHelp
    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint
        MdiParent = Main_Interface
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        Main_Interface.pbBlueBox.Show()
    End Sub

End Class