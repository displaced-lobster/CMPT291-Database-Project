Imports System.Data.SqlClient

Public Class Test_Query_Page
    Private Shared Function GetConnectionString() As String
        Return "Data Source=localhost\MSSQLSERVER2014;Initial Catalog=CMPT291_Project;Integrated Security=True"

    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        'SQL QUERY
        Dim connectionString As String = "CMPT291_ProjectConnectionString"

        Dim queryString As String = "SELECT first_name FROM Customer_Data" ' + Idtxt.Text.ToString

        Using connection As New SqlConnection(connectionString)
            Dim command As SqlCommand = connection.CreateCommand()
            command.CommandText = queryString
            Try
                connection.Open()
                Dim dataReader As SqlDataReader = command.ExecuteReader()

                Do While dataReader.Read()
                    Button1.Text = dataReader(0).ToString
                    'Answer2.Text = dataReader(1).ToString
                Loop
                Button1.Refresh()
                'Answer2.Refresh()

                dataReader.Close()

            Catch ex As Exception
                MsgBox(ex.Message)
                'Console.WriteLine(ex.Message)
            End Try
        End Using
    End Sub

End Class