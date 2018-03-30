Public Class List_Current_Rentals
    Private Sub List_Current_Rentals_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MdiParent = Main_Interface
    End Sub

    Private Sub current_rentals_close_btn_Click(sender As Object, e As EventArgs) Handles current_rentals_close_btn.Click
        Me.Close()
    End Sub

    Private Sub data_grid_most_active_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles data_grid_most_active.CellContentClick

    End Sub

    Private Sub List_Current_Rentals_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MdiParent = Main_Interface
    End Sub
End Class