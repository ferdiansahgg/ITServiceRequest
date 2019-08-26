Public Class FormLoading
    Private Sub FormLoading_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'script untuk membuat form load,diharapkan untuk mengganti propertis pada timer Enabled = True ,Interval = 100
        Me.Opacity = 1.0
        ProgressBar1.Value += 5
        If ProgressBar1.Value = 100 Then
            Timer1.Dispose()
            Me.Visible = False
            FormMenu.Show()
        End If
    End Sub
End Class