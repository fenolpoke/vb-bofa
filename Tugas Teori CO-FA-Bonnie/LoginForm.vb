Public Class LoginForm

    Dim db As New COFABONIDatabaseEntities

    Private Sub btnLogin_Click(sender As System.Object, e As System.EventArgs) Handles btnLogin.Click
        If String.IsNullOrEmpty(TextBox1.Text) Or String.IsNullOrEmpty(txtUsername.Text) Then
            MsgBox("Fill username and password!")
        ElseIf (From x In db.MsUsers Where x.Username = txtUsername.Text And x.Password = TextBox1.Text Select x).ToList().Count < 1 Then
            MsgBox("Wrong username and password combination!")
        Else
            Homepage.userid = (From x In db.MsUsers Where x.Username = txtUsername.Text And x.Password = TextBox1.Text Select x).ToList().First.Id
            MsgBox("Success!")
            Homepage.LoginToolStripMenuItem.Visible = False
            Homepage.LogOutToolStripMenuItem.Visible = True
            Homepage.productForm = New UserProductForm
            Me.Close()
        End If
    End Sub
End Class