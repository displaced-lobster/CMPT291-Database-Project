Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class SQLConStr

    Public SQLCon As New SqlConnection With {
        .ConnectionString = "Server=localhost;Database=CMPT291_Project;Integrated Security=True" 'DESKTOP-UOGE2DE is the localhost
    }
    Public SQLCmd As SqlCommand
End Class
