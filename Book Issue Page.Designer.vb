<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Book_IssueForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Book_IssueForm))
        Me.ISBNBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BookView = New System.Windows.Forms.DataGridView()
        Me.TitleBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SearchBook_txt = New System.Windows.Forms.TextBox()
        Me.SearchBook_button = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.addButton = New System.Windows.Forms.Button()
        Me.BorrowerView = New System.Windows.Forms.DataGridView()
        Me.NameBox = New System.Windows.Forms.TextBox()
        Me.SearchBorrower = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.searchBorrower_Button = New System.Windows.Forms.Button()
        Me.IssueDatePicker = New System.Windows.Forms.DateTimePicker()
        Me.DueDatePicker = New System.Windows.Forms.DateTimePicker()
        Me.bookButton = New System.Windows.Forms.Button()
        Me.returnButton = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.BookView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.BorrowerView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ISBNBox
        '
        Me.ISBNBox.Location = New System.Drawing.Point(41, 121)
        Me.ISBNBox.Name = "ISBNBox"
        Me.ISBNBox.ReadOnly = True
        Me.ISBNBox.Size = New System.Drawing.Size(163, 20)
        Me.ISBNBox.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 105)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "ISBN"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.DarkCyan
        Me.GroupBox1.Controls.Add(Me.BookView)
        Me.GroupBox1.Controls.Add(Me.TitleBox)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.ISBNBox)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.SearchBook_txt)
        Me.GroupBox1.Controls.Add(Me.SearchBook_button)
        Me.GroupBox1.Location = New System.Drawing.Point(48, 228)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(575, 188)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Book Details"
        '
        'BookView
        '
        Me.BookView.AllowUserToAddRows = False
        Me.BookView.AllowUserToDeleteRows = False
        Me.BookView.BackgroundColor = System.Drawing.Color.White
        Me.BookView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.BookView.Location = New System.Drawing.Point(25, 19)
        Me.BookView.Name = "BookView"
        Me.BookView.Size = New System.Drawing.Size(523, 83)
        Me.BookView.TabIndex = 6
        '
        'TitleBox
        '
        Me.TitleBox.Location = New System.Drawing.Point(231, 121)
        Me.TitleBox.Name = "TitleBox"
        Me.TitleBox.ReadOnly = True
        Me.TitleBox.Size = New System.Drawing.Size(317, 20)
        Me.TitleBox.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(214, 105)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Book Title"
        '
        'SearchBook_txt
        '
        Me.SearchBook_txt.Location = New System.Drawing.Point(133, 150)
        Me.SearchBook_txt.Name = "SearchBook_txt"
        Me.SearchBook_txt.Size = New System.Drawing.Size(293, 20)
        Me.SearchBook_txt.TabIndex = 1
        '
        'SearchBook_button
        '
        Me.SearchBook_button.Location = New System.Drawing.Point(432, 147)
        Me.SearchBook_button.Name = "SearchBook_button"
        Me.SearchBook_button.Size = New System.Drawing.Size(116, 23)
        Me.SearchBook_button.TabIndex = 0
        Me.SearchBook_button.Text = "Search Book"
        Me.SearchBook_button.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.DarkCyan
        Me.GroupBox2.Controls.Add(Me.addButton)
        Me.GroupBox2.Controls.Add(Me.BorrowerView)
        Me.GroupBox2.Controls.Add(Me.NameBox)
        Me.GroupBox2.Controls.Add(Me.SearchBorrower)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.searchBorrower_Button)
        Me.GroupBox2.Location = New System.Drawing.Point(653, 228)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(572, 188)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Borrower"
        '
        'addButton
        '
        Me.addButton.Location = New System.Drawing.Point(470, 123)
        Me.addButton.Name = "addButton"
        Me.addButton.Size = New System.Drawing.Size(75, 23)
        Me.addButton.TabIndex = 16
        Me.addButton.Text = "Add"
        Me.addButton.UseVisualStyleBackColor = True
        '
        'BorrowerView
        '
        Me.BorrowerView.AllowUserToAddRows = False
        Me.BorrowerView.AllowUserToDeleteRows = False
        Me.BorrowerView.BackgroundColor = System.Drawing.Color.White
        Me.BorrowerView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.BorrowerView.Location = New System.Drawing.Point(22, 17)
        Me.BorrowerView.Name = "BorrowerView"
        Me.BorrowerView.Size = New System.Drawing.Size(523, 75)
        Me.BorrowerView.TabIndex = 7
        '
        'NameBox
        '
        Me.NameBox.Location = New System.Drawing.Point(112, 98)
        Me.NameBox.Name = "NameBox"
        Me.NameBox.ReadOnly = True
        Me.NameBox.Size = New System.Drawing.Size(433, 20)
        Me.NameBox.TabIndex = 2
        '
        'SearchBorrower
        '
        Me.SearchBorrower.Location = New System.Drawing.Point(130, 147)
        Me.SearchBorrower.Name = "SearchBorrower"
        Me.SearchBorrower.Size = New System.Drawing.Size(293, 20)
        Me.SearchBorrower.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(19, 101)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(87, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Borrower's Name"
        '
        'searchBorrower_Button
        '
        Me.searchBorrower_Button.Location = New System.Drawing.Point(429, 147)
        Me.searchBorrower_Button.Name = "searchBorrower_Button"
        Me.searchBorrower_Button.Size = New System.Drawing.Size(116, 23)
        Me.searchBorrower_Button.TabIndex = 7
        Me.searchBorrower_Button.Text = "Search Borrower"
        Me.searchBorrower_Button.UseVisualStyleBackColor = True
        '
        'IssueDatePicker
        '
        Me.IssueDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.IssueDatePicker.Location = New System.Drawing.Point(9, 32)
        Me.IssueDatePicker.Name = "IssueDatePicker"
        Me.IssueDatePicker.Size = New System.Drawing.Size(200, 20)
        Me.IssueDatePicker.TabIndex = 9
        '
        'DueDatePicker
        '
        Me.DueDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DueDatePicker.Location = New System.Drawing.Point(294, 32)
        Me.DueDatePicker.Name = "DueDatePicker"
        Me.DueDatePicker.Size = New System.Drawing.Size(200, 20)
        Me.DueDatePicker.TabIndex = 10
        '
        'bookButton
        '
        Me.bookButton.Location = New System.Drawing.Point(212, 67)
        Me.bookButton.Name = "bookButton"
        Me.bookButton.Size = New System.Drawing.Size(75, 23)
        Me.bookButton.TabIndex = 11
        Me.bookButton.Text = "Book Issue"
        Me.bookButton.UseVisualStyleBackColor = True
        '
        'returnButton
        '
        Me.returnButton.Location = New System.Drawing.Point(1150, 106)
        Me.returnButton.Name = "returnButton"
        Me.returnButton.Size = New System.Drawing.Size(75, 23)
        Me.returnButton.TabIndex = 12
        Me.returnButton.Text = "Return"
        Me.returnButton.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 13)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Isuue Date"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(291, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 13)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Due Date"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(12, 12)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(219, 25)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "BOOK ISSUE PAGE"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.IssueDatePicker)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.bookButton)
        Me.GroupBox3.Controls.Add(Me.DueDatePicker)
        Me.GroupBox3.Location = New System.Drawing.Point(388, 436)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(507, 96)
        Me.GroupBox3.TabIndex = 16
        Me.GroupBox3.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(581, 53)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(108, 104)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 88
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(1150, 27)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(75, 73)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 91
        Me.PictureBox2.TabStop = False
        '
        'Book_IssueForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Linen
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1237, 682)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.returnButton)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Book_IssueForm"
        Me.Text = "Book Issue Page"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.BookView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.BorrowerView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ISBNBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TitleBox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents NameBox As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents SearchBook_button As Button
    Friend WithEvents SearchBook_txt As TextBox
    Friend WithEvents SearchBorrower As TextBox
    Friend WithEvents searchBorrower_Button As Button
    Friend WithEvents IssueDatePicker As DateTimePicker
    Friend WithEvents DueDatePicker As DateTimePicker
    Friend WithEvents bookButton As Button
    Friend WithEvents returnButton As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents BookView As DataGridView
    Friend WithEvents BorrowerView As DataGridView
    Friend WithEvents addButton As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
End Class
