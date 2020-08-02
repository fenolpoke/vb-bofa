Imports System.Windows.Forms

Public Class Homepage

    Public productForm As ProductForm
    Public userid

    Private Sub LoginToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LoginToolStripMenuItem.Click
        LoginForm.MdiParent = Me
        LoginForm.Show()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub ProductToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProductToolStripMenuItem.Click
        productForm.MdiParent = Me
        productForm.Show()
    End Sub

    Private Sub Homepage_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        My.Computer.Audio.Play(My.Resources.Groovy_day_infomercial_music_converted, AudioPlayMode.BackgroundLoop)
        LogOutToolStripMenuItem.Visible = False
        productForm = New GuestProductForm
        Dim db As New COFABONIDatabaseEntities
        For index = 1 To (From x In db.Products Select x).ToList.Count
            Dim i = index
            Dim p = (From x In db.Products Where x.Id = i Select x).ToList.First
            p.Picture = New ImageConverter().ConvertTo(Image.FromFile(index.ToString + ".jpg"), GetType(Byte()))
        Next
        db.SaveChanges()
    End Sub

    Private Sub LogOutToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles LogOutToolStripMenuItem.Click
        LoginToolStripMenuItem.Visible = True
        LogOutToolStripMenuItem.Visible = False
        productForm = New GuestProductForm
        MsgBox("Good bye!")
    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        Ads.Show()
    End Sub
End Class
