﻿Imports System.Data.SqlClient

' Source code borrowed from https://www.youtube.com/watch?v=7Z4BGEHD-JQ

Public Class SQLControl
    Private SQLcon As New SqlConnection("Server=localhost;Database=CMPT291_Project;Integrated Security=True")
    Private SQLcmd As SqlCommand

    ' Database Data
    Public SQLDataAdapter As SqlDataAdapter
    Public SQLTable As DataTable
    Public SQLDS As DataSet

    ' Query Parameters
    Public Params As New List(Of SqlParameter)

    ' Query Statistics
    Public RecordCount As Integer 'might not be necessary
    Public Exception As String 'stores error messages

    Public Sub New() ' blank sql control class with the default string
    End Sub

    ' Allow Connection string override
    Public Sub New(connectionString As String)
        SQLcon = New SqlConnection(connectionString) ' allow new database connection string
    End Sub

    ' for testing
    Public Function HasConnection() As Boolean
        Try
            SQLcon.Open()
            SQLcon.Close()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

        Return False
    End Function

    ' Execute Query 
    Public Sub ExecuteQuery(Query As String)
        ' Reset query statistics
        RecordCount = 0
        Exception = ""

        Try
            SQLcon.Open() ' connection is opened
            ' create database command
            SQLcmd = New SqlCommand(Query, SQLcon) ' perform the query in Query string

            'load params into sql command
            Params.ForEach(Sub(p) SQLcmd.Parameters.Add(p)) ' lambda expression

            ' Clear paramaters list
            Params.Clear()

            ' Execute command and fill dataset
            SQLTable = New DataTable
            SQLDataAdapter = New SqlDataAdapter(SQLcmd)
            RecordCount = SQLDataAdapter.Fill(SQLTable)


        Catch ex As Exception
            ' Capture Errors
            Exception = "ExecuteQuery Error: " & vbNewLine & ex.Message

        Finally
            'Close connection if still open
            If SQLcon.State = ConnectionState.Open Then SQLcon.Close()
        End Try
    End Sub

    ' Add parameters
    Public Sub AddParam(Name As String, Value As Object)
        Dim NewParam As New SqlParameter(Name, Value)
        Params.Add(NewParam)
    End Sub

    ' Error checking
    Public Function HasException(Optional Report As Boolean = False) As Boolean
        If String.IsNullOrEmpty(Exception) Then Return False
        If Report = True Then MsgBox(Exception, MsgBoxStyle.Critical, "Exception")
        Return True
    End Function
End Class

'Private Sub Findbtn_Click(sender As Object, e As EventArgs) Handles Findbtn.Click

'   Using connection As New OleDbConnection(connectionString)
'       Dim command As OleDbCommand = connection.CreateCommand()
'       command.CommandText = queryString
'       Try
'           connection.Open()
'           Dim dataReader As OleDbDataReader =
'           command.ExecuteReader()
'           Do While dataReader.Read()
'               Answer1.Text = dataReader(0).ToString
'               Answer2.Text = dataReader(1).ToString
'           Loop
'           Answer1.Refresh()
'           Answer2.Refresh()
'
'           dataReader.Close()

'       Catch ex As Exception
'           Console.WriteLine(ex.Message)
'       End Try
'   End Using
'End Sub


' Execute Query 
'Public Sub ExecuteQuery(Query As String)
' Reset query statistics
'   RecordCount = 0
'   Exception = ""

'   Using SQLcon
'       SQLcmd = SQLcon.CreateCommand()
'       SQLcmd.CommandText = Query
'       Try
'           SQLcon.Open() ' connection is opened
'           create database command
'           Dim dataReader As SqlDataReader = SQLcmd.ExecuteReader()

'           Do While 
'                Execute command and fill dataset
'               SQLTable = New DataTable
'               SqlDataAdapter = New SqlDataAdapter(SQLcmd)
'               RecordCount = SqlDataAdapter.Fill(SQLTable)


'       Catch ex As Exception
'           Capture Errors
'           Exception = "ExecuteQuery Error: " & vbNewLine & ex.Message

'       Finally
'           Close connection if still open
'           If SQLcon.State = ConnectionState.Open Then SQLcon.Close()
'       End Try
'   End Using
'End Sub
