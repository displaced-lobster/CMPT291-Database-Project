Public Class Sales_Report_Generator
    Private SQL As New SQLControl

    Private Sub Sales_Report_Generator_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MdiParent = Main_Interface
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles month_format.Click

    End Sub

    Private Sub close_button_Click(sender As Object, e As EventArgs) Handles close_button.Click
        Me.Close()
    End Sub

    Private Sub total_income_label_Click(sender As Object, e As EventArgs) Handles total_income_label.Click

    End Sub

    ' Execute Query to find amount made for given date, storing in a visible text label.
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        SQL.ExecuteQuery("Select SUM(M.distribution_fee) as Sum " &
                         "From Movie_Data as M, Order_Data as O " &
                         "Where O.movie_id = M.movie_id and YEAR(O.date) = " & year_textbox.Text &
                         " and MONTH(O.date) = " & month_textbox.Text & ";")

        If SQL.HasException(True) Then Exit Sub

        ' Converting float to a string making sure it only has two decimal places.
        income_label.Text = Convert.ToString(FormatNumber(SQL.SQLTable.Rows(0).Item("Sum"), 2))
    End Sub

    Private Sub income_label_Click(sender As Object, e As EventArgs) Handles income_label.Click

    End Sub
End Class