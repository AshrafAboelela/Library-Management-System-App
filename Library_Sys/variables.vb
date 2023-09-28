Imports System.Data.OleDb
Module variables
    Public cn As New ADODB.Connection
    Public rs As New ADODB.Recordset
    Public con As New OleDb.OleDbConnection
    Public cmd As New OleDb.OleDbCommand
    Public reader As OleDb.OleDbDataReader
    Public connect As String = "Provider=microsoft.ACE.oledb.12.0;Data Source=administration.accdb;Persist Security Info=False"
    Public provider As String
End Module
