Imports System.Data.SqlClient

Public Class Test_Query_Page
    Private Shared Function GetConnectionString() As String
        Return "Server=localhost;Database=CMPT291_Project;Integrated Security=True" 'DESKTOP-UOGE2DE is the localhost
    End Function

    Dim SQL As New SQLControl

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim connectionString As String = GetConnectionString()

        Dim queryString As String = "SELECT first_name FROM Customer_Data" ' + Idtxt.Text.ToString
        Using connection As New SqlConnection(connectionString)
            Dim commands As SqlCommand = connection.CreateCommand()
            commands.CommandText = queryString

            Try
                connection.Open()
                Dim dataReader As SqlDataReader = commands.ExecuteReader()

                Do While dataReader.Read()
                    Answer1.text = dataReader(0).ToString
                Loop
                answer1.Refresh()

                dataReader.Close()
            Catch ex As Exception
                Console.WriteLine(ex.Message)
            End Try
        End Using
    End Sub
End Class