Public Class UserProductForm
    Public Overrides Sub DataGridView1_CellClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs)
        MyBase.DataGridView1_CellClick(sender, e)
        If DataGridView1.SelectedRows.Count > 0 Then
            prID = DataGridView1.SelectedRows(0).Cells(0).Value
            NameTextBox.Text = DataGridView1.SelectedRows(0).Cells(1).Value.ToString
            StockTextBox.Text = DataGridView1.SelectedRows(0).Cells(2).Value.ToString
            PriceTextBox.Text = DataGridView1.SelectedRows(0).Cells(3).Value.ToString
            PictureBox1.Image = New ImageConverter().ConvertFrom(DataGridView1.SelectedRows(0).Cells(4).Value)

        End If
    End Sub
    Dim index As Integer
    Dim prID As Integer

    Private Sub AddButton_Click(sender As System.Object, e As System.EventArgs) Handles AddButton.Click
        'masukin k data grid view di sini bon
         If NameTextBox.Text = "" Then
            MsgBox("tidak ada data yang bisa di addtocart", vbInformation, "Informasi")
        ElseIf QuantityNumericUpDown.Value >= 1 Then
            For Each row As DataGridViewRow In CartDataGridView.Rows
                If row.Cells(0).Value = prID Then
                    row.Cells(3).Value += QuantityNumericUpDown.Value
                    Return
                End If
            Next

            CartDataGridView.Rows.Add(prID, NameTextBox.Text, PriceTextBox.Text, QuantityNumericUpDown.Value)
            'CartDataGridView.Rows(index).Cells(0).Value = NameTextBox.Text
            'CartDataGridView.Rows(index).Cells(1).Value = StockTextBox.Text
            'CartDataGridView.Rows(index).Cells(2).Value = PriceTextBox.Text
            'CartDataGridView.Rows(index).Cells(3).Value = QuantityNumericUpDown.Value
            index += 1
        End If
        'masukin ke CartDataGridView ya
    End Sub

    Private Sub CheckoutButton_Click(sender As System.Object, e As System.EventArgs) Handles CheckoutButton.Click
        'masukin transaction
        If CartDataGridView.RowCount > 0 Then

            Dim db As New COFABONIDatabaseEntities
            Dim lasttrans = (From x In db.HeaderTransactions Order By x.Id Descending Select x).ToList
            Dim newid
            If lasttrans.Count < 1 Then
                newid = 1
            Else
                newid = lasttrans.First.Id + 1
            End If

            Dim newtrans = New HeaderTransaction
            newtrans.Id = newid
            newtrans.UserId = Homepage.userid
            newtrans.Date = Today
            db.AddToHeaderTransactions(newtrans)
            db.SaveChanges()
            For i = 0 To CartDataGridView.RowCount - 1
                Dim newdetail = New DetailTransaction
                newdetail.TransactionId = newid
                newdetail.ProductId = CartDataGridView.Rows(i).Cells(0).Value
                newdetail.Quantity = CartDataGridView.Rows(i).Cells(3).Value
                db.AddToDetailTransactions(newdetail)
            Next

            CartDataGridView.Rows.Clear()
            MsgBox("Thank you for buying!")
        End If


    End Sub

    Private Sub UserProductForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim db As New COFABONIDatabaseEntities
        DataGridView1.DataSource = (From x In db.Products Select x).ToList
        DataGridView1.Columns(4).Visible = False
        DataGridView1.Columns(5).Visible = False

        index = prID = 0

        CartDataGridView.Columns.Add("ProductId", "ProductId")
        CartDataGridView.Columns.Add("Name", "Name")
        CartDataGridView.Columns.Add("Price", "Price")
        CartDataGridView.Columns.Add("Quantity", "Quantity")

    End Sub

  
End Class
