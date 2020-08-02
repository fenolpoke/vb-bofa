Public Class ProductForm

    Overridable Sub ProductForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'Dim db As New COFABONIDatabaseEntities
        'DataGridView1.DataSource = (From x In db.Products Select x).ToList

    End Sub


    
    Overridable Sub DataGridView1_CellClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        'MsgBox("click")
    End Sub

    Overridable Sub searchBtn_Click(sender As System.Object, e As System.EventArgs) Handles searchBtn.Click
        Dim db As New COFABONIDatabaseEntities
        If String.IsNullOrEmpty(TextBox1.Text) Then
            MsgBox("Fill text box!")
        ElseIf ComboBox1.SelectedIndex < 0 Then
            MsgBox("Choose combo box!")
        Else
            Dim value
            If ComboBox1.SelectedItem.ToString.ToLower().Equals("name") Then
                value = (From x In db.Products Where x.Name.Contains(TextBox1.Text) Select x).ToList
            Else
                If Int32.TryParse(TextBox1.Text, value) = False Then
                    MsgBox("Input numeric!")
                ElseIf ComboBox1.SelectedItem.ToString.ToLower().Equals("stock") Then
                    value = (From x In db.Products Where x.Stock > Int32.Parse(TextBox1.Text) Select x).ToList
                ElseIf ComboBox1.SelectedItem.ToString.ToLower().Equals("stock") Then
                    value = (From x In db.Products Where x.Price > Int32.Parse(TextBox1.Text) Select x).ToList
                Else
                    value = (From x In db.Products Select x).ToList
                End If
            End If
            DataGridView1.DataSource = value
        End If

    End Sub
End Class