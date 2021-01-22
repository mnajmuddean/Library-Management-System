<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Book
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
        Dim Book_IDLabel As System.Windows.Forms.Label
        Dim Book_TitleLabel As System.Windows.Forms.Label
        Dim Book_PublisherLabel As System.Windows.Forms.Label
        Dim Book_PageLabel As System.Windows.Forms.Label
        Dim Book_DateLabel As System.Windows.Forms.Label
        Dim Book_LanguageLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Book))
        Me.Button_Update = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.CateTextBox = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.search_button = New System.Windows.Forms.Button()
        Me.SearchField = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PubTextBox = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Book_IDTextBox = New System.Windows.Forms.TextBox()
        Me.Book_TitleTextBox = New System.Windows.Forms.TextBox()
        Me.Book_PublisherTextBox = New System.Windows.Forms.TextBox()
        Me.AuthorTextBox = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Book_IDLabel = New System.Windows.Forms.Label()
        Book_TitleLabel = New System.Windows.Forms.Label()
        Book_PublisherLabel = New System.Windows.Forms.Label()
        Book_PageLabel = New System.Windows.Forms.Label()
        Book_DateLabel = New System.Windows.Forms.Label()
        Book_LanguageLabel = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Book_IDLabel
        '
        Book_IDLabel.Anchor = System.Windows.Forms.AnchorStyles.None
        Book_IDLabel.AutoSize = True
        Book_IDLabel.ForeColor = System.Drawing.Color.Black
        Book_IDLabel.Location = New System.Drawing.Point(90, 49)
        Book_IDLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Book_IDLabel.Name = "Book_IDLabel"
        Book_IDLabel.Size = New System.Drawing.Size(35, 13)
        Book_IDLabel.TabIndex = 64
        Book_IDLabel.Text = "ISBN:"
        '
        'Book_TitleLabel
        '
        Book_TitleLabel.Anchor = System.Windows.Forms.AnchorStyles.None
        Book_TitleLabel.AutoSize = True
        Book_TitleLabel.ForeColor = System.Drawing.Color.Black
        Book_TitleLabel.Location = New System.Drawing.Point(83, 76)
        Book_TitleLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Book_TitleLabel.Name = "Book_TitleLabel"
        Book_TitleLabel.Size = New System.Drawing.Size(58, 13)
        Book_TitleLabel.TabIndex = 66
        Book_TitleLabel.Text = "Book Title:"
        '
        'Book_PublisherLabel
        '
        Book_PublisherLabel.Anchor = System.Windows.Forms.AnchorStyles.None
        Book_PublisherLabel.AutoSize = True
        Book_PublisherLabel.ForeColor = System.Drawing.Color.Black
        Book_PublisherLabel.Location = New System.Drawing.Point(64, 109)
        Book_PublisherLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Book_PublisherLabel.Name = "Book_PublisherLabel"
        Book_PublisherLabel.Size = New System.Drawing.Size(87, 13)
        Book_PublisherLabel.TabIndex = 68
        Book_PublisherLabel.Text = "Publication Year:"
        '
        'Book_PageLabel
        '
        Book_PageLabel.Anchor = System.Windows.Forms.AnchorStyles.None
        Book_PageLabel.AutoSize = True
        Book_PageLabel.ForeColor = System.Drawing.Color.Black
        Book_PageLabel.Location = New System.Drawing.Point(90, 180)
        Book_PageLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Book_PageLabel.Name = "Book_PageLabel"
        Book_PageLabel.Size = New System.Drawing.Size(41, 13)
        Book_PageLabel.TabIndex = 70
        Book_PageLabel.Text = "Author:"
        '
        'Book_DateLabel
        '
        Book_DateLabel.Anchor = System.Windows.Forms.AnchorStyles.None
        Book_DateLabel.AutoSize = True
        Book_DateLabel.ForeColor = System.Drawing.Color.Black
        Book_DateLabel.Location = New System.Drawing.Point(57, 215)
        Book_DateLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Book_DateLabel.Name = "Book_DateLabel"
        Book_DateLabel.Size = New System.Drawing.Size(84, 13)
        Book_DateLabel.TabIndex = 72
        Book_DateLabel.Text = "Publisher Name:"
        '
        'Book_LanguageLabel
        '
        Book_LanguageLabel.Anchor = System.Windows.Forms.AnchorStyles.None
        Book_LanguageLabel.AutoSize = True
        Book_LanguageLabel.ForeColor = System.Drawing.Color.Black
        Book_LanguageLabel.Location = New System.Drawing.Point(65, 145)
        Book_LanguageLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Book_LanguageLabel.Name = "Book_LanguageLabel"
        Book_LanguageLabel.Size = New System.Drawing.Size(80, 13)
        Book_LanguageLabel.TabIndex = 73
        Book_LanguageLabel.Text = "Book Category:"
        '
        'Button_Update
        '
        Me.Button_Update.Location = New System.Drawing.Point(257, 274)
        Me.Button_Update.Margin = New System.Windows.Forms.Padding(2)
        Me.Button_Update.Name = "Button_Update"
        Me.Button_Update.Size = New System.Drawing.Size(50, 22)
        Me.Button_Update.TabIndex = 85
        Me.Button_Update.Text = "Update Book"
        Me.Button_Update.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(385, 274)
        Me.Button4.Margin = New System.Windows.Forms.Padding(2)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(50, 22)
        Me.Button4.TabIndex = 84
        Me.Button4.Text = "Reset"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(891, 92)
        Me.Button2.Margin = New System.Windows.Forms.Padding(2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 83
        Me.Button2.Text = "Return"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'CateTextBox
        '
        Me.CateTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.CateTextBox.Location = New System.Drawing.Point(229, 145)
        Me.CateTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.CateTextBox.Name = "CateTextBox"
        Me.CateTextBox.Size = New System.Drawing.Size(206, 20)
        Me.CateTextBox.TabIndex = 82
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(18, 18)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(2)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 62
        Me.DataGridView1.RowTemplate.Height = 28
        Me.DataGridView1.Size = New System.Drawing.Size(437, 189)
        Me.DataGridView1.TabIndex = 80
        '
        'search_button
        '
        Me.search_button.Location = New System.Drawing.Point(387, 226)
        Me.search_button.Name = "search_button"
        Me.search_button.Size = New System.Drawing.Size(68, 23)
        Me.search_button.TabIndex = 79
        Me.search_button.Text = "Search"
        Me.search_button.UseVisualStyleBackColor = True
        '
        'SearchField
        '
        Me.SearchField.Location = New System.Drawing.Point(112, 228)
        Me.SearchField.Name = "SearchField"
        Me.SearchField.Size = New System.Drawing.Size(269, 20)
        Me.SearchField.TabIndex = 78
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label1.Location = New System.Drawing.Point(411, 132)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(192, 20)
        Me.Label1.TabIndex = 77
        Me.Label1.Text = "BOOK DETAILS PAGE"
        '
        'PubTextBox
        '
        Me.PubTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.PubTextBox.Location = New System.Drawing.Point(229, 215)
        Me.PubTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.PubTextBox.Name = "PubTextBox"
        Me.PubTextBox.Size = New System.Drawing.Size(206, 20)
        Me.PubTextBox.TabIndex = 76
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(321, 274)
        Me.Button3.Margin = New System.Windows.Forms.Padding(2)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(50, 21)
        Me.Button3.TabIndex = 75
        Me.Button3.Text = "Delete"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(190, 274)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(54, 22)
        Me.Button1.TabIndex = 74
        Me.Button1.Text = "Add Book"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Book_IDTextBox
        '
        Me.Book_IDTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Book_IDTextBox.Location = New System.Drawing.Point(229, 42)
        Me.Book_IDTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.Book_IDTextBox.Name = "Book_IDTextBox"
        Me.Book_IDTextBox.Size = New System.Drawing.Size(206, 20)
        Me.Book_IDTextBox.TabIndex = 65
        '
        'Book_TitleTextBox
        '
        Me.Book_TitleTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Book_TitleTextBox.Location = New System.Drawing.Point(229, 76)
        Me.Book_TitleTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.Book_TitleTextBox.Name = "Book_TitleTextBox"
        Me.Book_TitleTextBox.Size = New System.Drawing.Size(206, 20)
        Me.Book_TitleTextBox.TabIndex = 67
        '
        'Book_PublisherTextBox
        '
        Me.Book_PublisherTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Book_PublisherTextBox.Location = New System.Drawing.Point(229, 109)
        Me.Book_PublisherTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.Book_PublisherTextBox.Name = "Book_PublisherTextBox"
        Me.Book_PublisherTextBox.Size = New System.Drawing.Size(206, 20)
        Me.Book_PublisherTextBox.TabIndex = 69
        '
        'AuthorTextBox
        '
        Me.AuthorTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.AuthorTextBox.Location = New System.Drawing.Point(229, 180)
        Me.AuthorTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.AuthorTextBox.Name = "AuthorTextBox"
        Me.AuthorTextBox.Size = New System.Drawing.Size(206, 20)
        Me.AuthorTextBox.TabIndex = 71
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.DarkCyan
        Me.GroupBox1.Controls.Add(Book_IDLabel)
        Me.GroupBox1.Controls.Add(Me.Button4)
        Me.GroupBox1.Controls.Add(Me.Button_Update)
        Me.GroupBox1.Controls.Add(Me.PubTextBox)
        Me.GroupBox1.Controls.Add(Book_DateLabel)
        Me.GroupBox1.Controls.Add(Me.CateTextBox)
        Me.GroupBox1.Controls.Add(Me.Book_IDTextBox)
        Me.GroupBox1.Controls.Add(Me.AuthorTextBox)
        Me.GroupBox1.Controls.Add(Book_LanguageLabel)
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Book_PageLabel)
        Me.GroupBox1.Controls.Add(Me.Book_TitleTextBox)
        Me.GroupBox1.Controls.Add(Book_TitleLabel)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.Book_PublisherTextBox)
        Me.GroupBox1.Controls.Add(Book_PublisherLabel)
        Me.GroupBox1.Location = New System.Drawing.Point(15, 202)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(454, 308)
        Me.GroupBox1.TabIndex = 86
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Details :"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(454, 11)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(108, 104)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 87
        Me.PictureBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.DarkCyan
        Me.GroupBox2.Controls.Add(Me.DataGridView1)
        Me.GroupBox2.Controls.Add(Me.search_button)
        Me.GroupBox2.Controls.Add(Me.SearchField)
        Me.GroupBox2.Location = New System.Drawing.Point(495, 202)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(471, 308)
        Me.GroupBox2.TabIndex = 88
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Book List"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(891, 11)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(75, 73)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 91
        Me.PictureBox2.TabStop = False
        '
        'Book
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkCyan
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(978, 531)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Book"
        Me.Text = "Book Details Page"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button_Update As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents CateTextBox As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents search_button As Button
    Friend WithEvents SearchField As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PubTextBox As TextBox
    Friend WithEvents Button3 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Book_IDTextBox As TextBox
    Friend WithEvents Book_TitleTextBox As TextBox
    Friend WithEvents Book_PublisherTextBox As TextBox
    Friend WithEvents AuthorTextBox As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents PictureBox2 As PictureBox
End Class
