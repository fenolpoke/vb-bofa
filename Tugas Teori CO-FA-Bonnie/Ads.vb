Public Class Ads

    Private Sub Ads_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        My.Computer.Audio.Stop()
    End Sub

    Private Sub btnLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogin.Click
        Me.Close()
        My.Computer.Audio.Play(My.Resources.Groovy_day_infomercial_music_converted, AudioPlayMode.BackgroundLoop)
    End Sub
End Class