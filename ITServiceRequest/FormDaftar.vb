Imports System.Data
Imports System.Data.OleDb
Public Class FormDaftar
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'script untuk mendaftarkan user 
        Me.Validate()
        connoledb.ConnectionString = strconnectionstring
        connoledb.Open()


        cmdoledb.CommandText = "select * from tblogin where USER_ID='" & txtid.Text & "'"
        cmdoledb.Connection = connoledb

        Dim rdroledb As OleDbDataReader = cmdoledb.ExecuteReader
        Dim sql As String


        sql = "Insert Into tblogin values('" & txtid.Text & "','" & txtpass.Text & "','" & txtrole.Text & "')"


        cmdupdate.CommandText = sql
        cmdupdate.CommandType = CommandType.Text
        cmdupdate.Connection = connoledb
        cmdupdate.ExecuteNonQuery()
        cmdupdate.Dispose()
        connoledb.Close()
        MsgBox("Data User : " & txtid.Text & " PENDAFTARAN SUKSESS !!!", MsgBoxStyle.Information, "KONFIRMASI")

        txtid.Text = ""
        txtpass.Text = ""
        txtrole.Text = ""


    End Sub

    Private Sub FormDaftar_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnhlogin_Click(sender As Object, e As EventArgs) Handles btnhlogin.Click
        'script untuk memunculkan halaman login
        Form1.Show()
        Me.Close()
    End Sub
End Class