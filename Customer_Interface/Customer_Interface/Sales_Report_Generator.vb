Public Class Sales_Report_Generator
    Private Sub Sales_Report_Generator_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MdiParent = Main_Interface
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles month_format.Click

    End Sub

    Private Sub close_button_Click(sender As Object, e As EventArgs) Handles close_button.Click
        Me.Close()
    End Sub
End Class