<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserProductForm
    Inherits Tugas_Teori_CO_FA_Bonnie.ProductForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.DetailGroupBox = New System.Windows.Forms.GroupBox()
        Me.QuantityNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.AddButton = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PriceTextBox = New System.Windows.Forms.TextBox()
        Me.StockTextBox = New System.Windows.Forms.TextBox()
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CartGroupBox = New System.Windows.Forms.GroupBox()
        Me.CheckoutButton = New System.Windows.Forms.Button()
        Me.CartDataGridView = New System.Windows.Forms.DataGridView()
        Me.DetailGroupBox.SuspendLayout()
        CType(Me.QuantityNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CartGroupBox.SuspendLayout()
        CType(Me.CartDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DetailGroupBox
        '
        Me.DetailGroupBox.Controls.Add(Me.QuantityNumericUpDown)
        Me.DetailGroupBox.Controls.Add(Me.AddButton)
        Me.DetailGroupBox.Controls.Add(Me.PictureBox1)
        Me.DetailGroupBox.Controls.Add(Me.PriceTextBox)
        Me.DetailGroupBox.Controls.Add(Me.StockTextBox)
        Me.DetailGroupBox.Controls.Add(Me.NameTextBox)
        Me.DetailGroupBox.Controls.Add(Me.Label6)
        Me.DetailGroupBox.Controls.Add(Me.Label5)
        Me.DetailGroupBox.Controls.Add(Me.Label4)
        Me.DetailGroupBox.Controls.Add(Me.Label3)
        Me.DetailGroupBox.Location = New System.Drawing.Point(27, 280)
        Me.DetailGroupBox.Name = "DetailGroupBox"
        Me.DetailGroupBox.Size = New System.Drawing.Size(394, 136)
        Me.DetailGroupBox.TabIndex = 13
        Me.DetailGroupBox.TabStop = False
        Me.DetailGroupBox.Text = "Product Detail"
        '
        'QuantityNumericUpDown
        '
        Me.QuantityNumericUpDown.Location = New System.Drawing.Point(78, 112)
        Me.QuantityNumericUpDown.Name = "QuantityNumericUpDown"
        Me.QuantityNumericUpDown.Size = New System.Drawing.Size(50, 20)
        Me.QuantityNumericUpDown.TabIndex = 4
        '
        'AddButton
        '
        Me.AddButton.Location = New System.Drawing.Point(137, 109)
        Me.AddButton.Name = "AddButton"
        Me.AddButton.Size = New System.Drawing.Size(78, 23)
        Me.AddButton.TabIndex = 3
        Me.AddButton.Text = "Add to Cart"
        Me.AddButton.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(249, 13)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(119, 111)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'PriceTextBox
        '
        Me.PriceTextBox.Enabled = False
        Me.PriceTextBox.Location = New System.Drawing.Point(78, 83)
        Me.PriceTextBox.Name = "PriceTextBox"
        Me.PriceTextBox.Size = New System.Drawing.Size(137, 20)
        Me.PriceTextBox.TabIndex = 1
        '
        'StockTextBox
        '
        Me.StockTextBox.Enabled = False
        Me.StockTextBox.Location = New System.Drawing.Point(78, 55)
        Me.StockTextBox.Name = "StockTextBox"
        Me.StockTextBox.Size = New System.Drawing.Size(137, 20)
        Me.StockTextBox.TabIndex = 1
        '
        'NameTextBox
        '
        Me.NameTextBox.Enabled = False
        Me.NameTextBox.Location = New System.Drawing.Point(78, 25)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(137, 20)
        Me.NameTextBox.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 114)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(46, 13)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Quantity"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 86)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(31, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Price"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 58)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Stock"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 28)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Name"
        '
        'CartGroupBox
        '
        Me.CartGroupBox.Controls.Add(Me.CheckoutButton)
        Me.CartGroupBox.Controls.Add(Me.CartDataGridView)
        Me.CartGroupBox.Location = New System.Drawing.Point(455, 283)
        Me.CartGroupBox.Name = "CartGroupBox"
        Me.CartGroupBox.Size = New System.Drawing.Size(379, 133)
        Me.CartGroupBox.TabIndex = 14
        Me.CartGroupBox.TabStop = False
        Me.CartGroupBox.Text = "Cart"
        '
        'CheckoutButton
        '
        Me.CheckoutButton.Location = New System.Drawing.Point(121, 106)
        Me.CheckoutButton.Name = "CheckoutButton"
        Me.CheckoutButton.Size = New System.Drawing.Size(137, 23)
        Me.CheckoutButton.TabIndex = 3
        Me.CheckoutButton.Text = "Check Out"
        Me.CheckoutButton.UseVisualStyleBackColor = True
        '
        'CartDataGridView
        '
        Me.CartDataGridView.AllowUserToAddRows = False
        Me.CartDataGridView.AllowUserToDeleteRows = False
        Me.CartDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CartDataGridView.Location = New System.Drawing.Point(6, 19)
        Me.CartDataGridView.MultiSelect = False
        Me.CartDataGridView.Name = "CartDataGridView"
        Me.CartDataGridView.ReadOnly = True
        Me.CartDataGridView.Size = New System.Drawing.Size(367, 77)
        Me.CartDataGridView.TabIndex = 0
        '
        'UserProductForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(865, 428)
        Me.Controls.Add(Me.CartGroupBox)
        Me.Controls.Add(Me.DetailGroupBox)
        Me.Name = "UserProductForm"
        Me.Controls.SetChildIndex(Me.DetailGroupBox, 0)
        Me.Controls.SetChildIndex(Me.CartGroupBox, 0)
        Me.DetailGroupBox.ResumeLayout(False)
        Me.DetailGroupBox.PerformLayout()
        CType(Me.QuantityNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CartGroupBox.ResumeLayout(False)
        CType(Me.CartDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DetailGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PriceTextBox As System.Windows.Forms.TextBox
    Friend WithEvents StockTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents CartGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents CartDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents AddButton As System.Windows.Forms.Button
    Friend WithEvents CheckoutButton As System.Windows.Forms.Button
    Friend WithEvents QuantityNumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label6 As System.Windows.Forms.Label

End Class
