Imports System.Data
Imports System.Data.OleDb
Module ModuleKoneksi
    Public Userrole As String
    Public connoledb As New OleDbConnection
    Public cmdoledb As New OleDbCommand
    Public cmdinsert As New OleDbCommand
    Public cmdupdate As New OleDbCommand
    Public cmddelete As New OleDbCommand
    Public strconnectionstring = "provider=microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\DianShafer\Documents\dbservices.mdb"
End Module
