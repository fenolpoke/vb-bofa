Public Class GuestProductForm

    Private Sub DataGridView1_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs)
        If DataGridView1.SelectedRows.Count > 0 Then
            NameTextBox.Text = DataGridView1.SelectedRows(0).Cells(0).ToString
            StockTextBox.Text = DataGridView1.SelectedRows(0).Cells(1).ToString
            PriceTextBox.Text = DataGridView1.SelectedRows(0).Cells(2).ToString
        End If
        MsgBox("asd")
    End Sub

    Private Sub GuestProductForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim db As New COFABONIDatabaseEntities
        DataGridView1.DataSource = (From x In db.Products Select x).ToList
        DataGridView1.Columns(4).Visible = False
        DataGridView1.Columns(5).Visible = False

    End Sub

    'Friend Overloads Sub DataGridView1_CellClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
    '    MsgBox("click 1")
    'End Sub
    Public Overrides Sub DataGridView1_CellClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs)
        MyBase.DataGridView1_CellClick(sender, e)
        If DataGridView1.SelectedRows.Count > 0 Then
            NameTextBox.Text = DataGridView1.SelectedRows(0).Cells(1).Value.ToString
            StockTextBox.Text = DataGridView1.SelectedRows(0).Cells(2).Value.ToString
            PriceTextBox.Text = DataGridView1.SelectedRows(0).Cells(3).Value.ToString
            PictureBox1.Image = New ImageConverter().ConvertFrom(DataGridView1.SelectedRows(0).Cells(4).Value)
        End If
    End Sub

End Class
