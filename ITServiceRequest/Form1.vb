Imports System.Data
Imports System.Data.OleDb
Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnlogin_Click(sender As Object, e As EventArgs) Handles btnlogin.Click
        'script untuk membuka koneksi dan memilih user
        connoledb.ConnectionString = strconnectionstring
        connoledb.Open()


        cmdoledb.CommandText = "select * from tblogin where USER_ID='" & txtid.Text & "' and Password='" & txtpass.Text & "'"
        cmdoledb.Connection = connoledb

        Dim rdroledb As OleDbDataReader = cmdoledb.ExecuteReader

        Dim keterangan As String
        If rdroledb.Read = True Then

            keterangan = "Login Sukses"
            Userrole = rdroledb.Item(2).ToString
            Me.Hide()
            FormLoading.Show()

        Else

            keterangan = "User ID atau Password anda salah"
        End If
        MsgBox(keterangan)
        rdroledb.Close()
        connoledb.Close()
    End Sub

    Private Sub cb1_CheckedChanged(sender As Object, e As EventArgs) Handles cb1.CheckedChanged
        'script untuk menampilkan password
        If cb1.CheckState = CheckState.Checked Then
            txtpass.UseSystemPasswordChar = False
        Else
            txtpass.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub btndaftar_Click(sender As Object, e As EventArgs) Handles btndaftar.Click
        'script untuk memunculkan form daftars
        Me.Hide()
        FormDaftar.Show()
    End Sub

    Private Sub btnexit_Click(sender As Object, e As EventArgs) Handles btnexit.Click
        End
    End Sub
End Class
