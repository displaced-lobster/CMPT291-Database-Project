Imports System.Data.SqlClient

Public Class Test_Query_Page
    Public SQL As New SQLControl ' can put new string in here ("") if we want

    Private Sub LoadData(Optional Query As String = "")

        If Query = "" Then
            SQL.ExecuteQuery("SELECT * FROM customer_data;") ' run the query
        Else
            SQL.ExecuteQuery(Query)
        End If

        ' Error Handling
        If SQL.HasException(False) Then Exit Sub ' check for errors and exit gracefully

        'DataReader.Read()
        dgvData.DataSource = SQL.SQLTable ' get the data and insert into the data grid
    End Sub

    Private Sub FindName()
        SQL.AddParam("@name", "%" & txtSearch.Text & "%")
        LoadData("SELECT * FROM customer_data WHERE first_name LIKE @name;") ' need like for wild cards
    End Sub


    Private Sub Test_Query_Page_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MdiParent = Main_Interface
        LoadData("SELECT first_name, last_name, account_number FROM customer_data") ' filter columns
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FindName() ' Execute query 
    End Sub
End Class
