Public Class FormSejarah
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'script untuk memunculkan form menu
        FormMenu.Show()
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'script untuk munculkan form login
        Form1.Show()
        Me.Close()
    End Sub

    Private Sub FormSejarah_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class