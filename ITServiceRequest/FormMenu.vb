Public Class FormMenu
    Private Sub btnlist_Click(sender As Object, e As EventArgs) Handles btnlist.Click
        'script untuk memunculkan form listing service
        listingservice.Show()
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'script untuk memunculkan form sejarah
        FormSejarah.Show()
        Me.Close()
    End Sub

    Private Sub btnexit_Click(sender As Object, e As EventArgs) Handles btnexit.Click
        End
    End Sub

    Private Sub FormMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        'script untuk memunculkan form daftar
        FormDaftar.Show()
        Me.Close()
    End Sub



End Class