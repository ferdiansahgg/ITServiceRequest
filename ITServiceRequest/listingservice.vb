Imports System.Data
Imports System.Data.OleDb

Public Class listingservice
    Private Sub listingservice_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DbservicesDataSet.tbservice' table. You can move, or remove it, as needed.
        'script untuk membedakan user client dan admin dan untuk merefresh data base
        refreshdata()

        If Userrole = "client" Then
            btndelete.Visible = False
            btnupdate.Visible = False
            cbstatus.Visible = False
            Label6.Visible = False

        Else
            btnupdate.Visible = True
            btndelete.Visible = True


        End If
    End Sub

    Private Sub btnadd_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        'script untuk menghapus data di database
        Me.Validate()
        connoledb.ConnectionString = strconnectionstring
        connoledb.Open()


        cmdoledb.CommandText = "select * from tbservice where NIK='" & txtnik.Text & "'"
        cmdoledb.Connection = connoledb

        Dim rdroledb As OleDbDataReader = cmdoledb.ExecuteReader
        Dim sql As String
        Dim keterangan As String
        sql = "Delete  from tbservice where NIK='" & txtnik.Text & "'"
        keterangan = "Data Berhasil Dihapus"

        cmdupdate.CommandText = sql
        cmdupdate.CommandType = CommandType.Text
        cmdupdate.Connection = connoledb
        cmdupdate.ExecuteNonQuery()
        cmdupdate.Dispose()
        connoledb.Close()
        MsgBox(keterangan)

        txtnik.Enabled = False
        txtnama.Enabled = False
        txtkeluhan.Enabled = False

        refreshdata()

    End Sub

    Private Sub btnupdate_Click(sender As Object, e As EventArgs) Handles btnupdate.Click
        'script untuk mengedit data,tetapi apabila data belum ada di database maka akan beralih fungsi untuk menjadi tombol save
        Me.Validate()
        connoledb.ConnectionString = strconnectionstring
        connoledb.Open()
        cmdoledb.CommandText = "select * from tbservice where NIK='" & txtnik.Text & "'"
        cmdoledb.Connection = connoledb
        Dim rdroledb As OleDbDataReader = cmdoledb.ExecuteReader
        Dim sql As String
        Dim keterangan As String
        Dim Penanganan As String


        If cbstatus.Text = "OnProses" Then
            Penanganan = "Akan Diperbaiki"
        Else

            cbstatus.Text = "Fix"
            Penanganan = "Sudah DiPerbaiki"

        End If


        If rdroledb.Read = True Then


            sql = "update tbservice set NAMA='" & txtnama.Text & "',DEPARTEMENT='" & cbdept.Text & "',[Jenis Keluhan]='" & cbjk.Text & "',Keluhan='" & txtkeluhan.Text & "',Status='" & cbstatus.Text & "',Penanganan='" & Penanganan & "' where NIK='" & txtnik.Text & "'"
            keterangan = "Data Sudah Diupdate"



        Else
            sql = "Insert Into tbservice (NIK,NAMA,DEPARTEMENT,[Jenis Keluhan],Keluhan,Status) values('" & txtnik.Text & "','" & txtnama.Text & "','" & cbdept.Text & "','" & cbjk.Text & "','" & txtkeluhan.Text & "','" & cbstatus.Text & "')"
            keterangan = "Data Sudah DiSimpan"
        End If
        rdroledb.Close()
        cmdupdate.CommandText = sql
        cmdupdate.CommandType = CommandType.Text
        cmdupdate.Connection = connoledb
        cmdupdate.ExecuteNonQuery()
        cmdupdate.Dispose()
        connoledb.Close()
        MsgBox(keterangan)

        txtnik.Enabled = False
        txtnama.Enabled = False
        txtkeluhan.Enabled = False
        refreshdata()
    End Sub

    Private Sub btnrefresh_Click(sender As Object, e As EventArgs) Handles btnrefresh.Click
        'script untuk merefresh data
        txtnik.Text = ""
        txtnama.Text = ""
        cbdept.Text = ""
        cbjk.Text = ""
        txtkeluhan.Text = ""
        cbstatus.Text = ""
        refreshdata()



    End Sub

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        'script untuk menyimpan data kedalam database
        Me.Validate()
        connoledb.ConnectionString = strconnectionstring
        connoledb.Open()


        cmdoledb.CommandText = "select * from tbservice where NIK='" & txtnik.Text & "'"
        cmdoledb.Connection = connoledb

        Dim rdroledb As OleDbDataReader = cmdoledb.ExecuteReader
        Dim sql As String
        Dim keterangan As String
        Dim status As String
        If Userrole = "admin" Then
            status = "OnProses"
        Else
            status = "OnProses"
        End If

        sql = "Insert Into tbservice (NIK,NAMA,DEPARTEMENT,[Jenis Keluhan],Keluhan,Status) values('" & txtnik.Text & "','" & txtnama.Text & "','" & cbdept.Text & "','" & cbjk.Text & "','" & txtkeluhan.Text & "','" & status & "')"
        keterangan = "Data Sudah DiSimpan"

        cmdupdate.CommandText = sql
        cmdupdate.CommandType = CommandType.Text
        cmdupdate.Connection = connoledb
        cmdupdate.ExecuteNonQuery()
        cmdupdate.Dispose()
        connoledb.Close()
        MsgBox(keterangan)

        txtnik.Enabled = False
        txtnama.Enabled = False

        txtkeluhan.Enabled = False

        refreshdata()
    End Sub
    Public Sub refreshdata()
        'script untuk merefresh data didalam database
        connoledb.ConnectionString = strconnectionstring
        connoledb.Open()




        Dim Sql = "Select * from tbservice"

        cmdoledb.Connection = connoledb
        Dim DA As New OleDbDataAdapter(Sql, connoledb)
        Dim ds As New DataSet
        DA.Fill(ds, "tbservice")
        DataGridView1.DataSource = ds
        DataGridView1.DataMember = "tbservice"


        cmdoledb.CommandText = "select count(*) from tbservice where status = 'OnProses' "
        Dim rdroledb As OleDbDataReader = cmdoledb.ExecuteReader
        If rdroledb.Read = True Then

            lblpending.Text = rdroledb.Item(0).ToString
        Else
            lblpending.Text = "0"



        End If
        rdroledb.Close()
        cmdoledb.CommandText = "select count(*) from tbservice where status = 'Fix' "
        Dim rdroledb2 As OleDbDataReader = cmdoledb.ExecuteReader
        If rdroledb2.Read = True Then

            lblclose.Text = rdroledb2.Item(0).ToString
        Else
            lblclose.Text = "0"



        End If



        connoledb.Close()
    End Sub



    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'script untuk menampilkan form login
        Form1.Show()
        Me.Close()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick






    End Sub

    Private Sub btnreport_Click(sender As Object, e As EventArgs) Handles btnreport.Click
        'script untuk menampilkan form halaman report
        HalamanReport.Show()
        Me.Close()
    End Sub

    Private Sub txtnik_TextChanged(sender As Object, e As EventArgs)

        connoledb.ConnectionString = strconnectionstring
        connoledb.Open()

        If txtnik.Text = "" Then
            Dim Sql = "Select * from tbservice where NIK Like '%" & txtnik.Text & "%' order by NIK asc"

            cmdoledb.Connection = connoledb
            Dim DA As New OleDbDataAdapter(Sql, connoledb)
            Dim ds As New DataSet
            ds.Clear()
            DA.Fill(ds, "tbservice")
            DataGridView1.DataSource = ds
            DataGridView1.DataMember = "tbservice"

            DataGridView1.ReadOnly = True
        End If
        connoledb.Close()




    End Sub



    Private Sub cbstatus_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbstatus.SelectedIndexChanged

    End Sub

    Private Sub txtnik_TextChanged_1(sender As Object, e As EventArgs) Handles txtnik.TextChanged
        'script untuk menampilkan data yang ada didatabase kedalam textbox atau combo box
        connoledb.Open()
        cmdoledb.CommandText = "Select * from tbservice where NIK  = '" & txtnik.Text & "'"
        Dim rdroledb2 As OleDbDataReader = cmdoledb.ExecuteReader
        If rdroledb2.Read = True Then


            txtnama.Text = rdroledb2.Item(1).ToString()
            cbdept.Text = rdroledb2.Item(2).ToString()
            cbstatus.Text = rdroledb2.Item(5).ToString()
            cbjk.Text = rdroledb2.Item(3).ToString()
            txtkeluhan.Text = rdroledb2.Item(4).ToString()
            cbstatus.Text = "Fix"
            cbstatus.Enabled = False



        Else

            txtnama.Text = ""
            cbdept.Text = ""
            cbstatus.Text = ""
            cbstatus.Enabled = True
            cbjk.Text = ""
            txtkeluhan.Text = ""



        End If
        connoledb.Close()
    End Sub

    Private Sub btnhide_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'script untuk menampilkan form menu
        FormMenu.Show()
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        'script untuk merefresh textbox dan combobox
        txtnik.Text = ""
        txtnama.Text = ""
        cbdept.Text = ""
        cbjk.Text = ""
        txtkeluhan.Text = ""
        cbstatus.Text = ""

        txtnik.Enabled = True
        txtnama.Enabled = True
        cbdept.Enabled = True
        cbjk.Enabled = True
        txtkeluhan.Enabled = True
        cbstatus.Enabled = True
    End Sub

    Private Sub txtnama_TextChanged(sender As Object, e As EventArgs) Handles txtnama.TextChanged

    End Sub
End Class