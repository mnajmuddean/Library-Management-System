<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Borrowers
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Borrowers))
        Me.Reset_Button = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Search_Button = New System.Windows.Forms.Button()
        Me.SearchBox = New System.Windows.Forms.TextBox()
        Me.BookList = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Delete_Button = New System.Windows.Forms.Button()
        Me.NumBooksBox = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.PhoneNumberBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.AddressBox = New System.Windows.Forms.TextBox()
        Me.Insert_Button = New System.Windows.Forms.Button()
        Me.Update_Button = New System.Windows.Forms.Button()
        Me.NameBox = New System.Windows.Forms.TextBox()
        Me.IcBox = New System.Windows.Forms.TextBox()
        Me.Back_Button = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label7 = New System.Windows.Forms.Label()
        CType(Me.BookList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Reset_Button
        '
        Me.Reset_Button.Location = New System.Drawing.Point(200, 251)
        Me.Reset_Button.Margin = New System.Windows.Forms.Padding(2)
        Me.Reset_Button.Name = "Reset_Button"
        Me.Reset_Button.Size = New System.Drawing.Size(72, 21)
        Me.Reset_Button.TabIndex = 46
        Me.Reset_Button.Text = "Reset"
        Me.Reset_Button.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 59)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 13)
        Me.Label1.TabIndex = 45
        Me.Label1.Text = "List Book Borrow"
        '
        'Search_Button
        '
        Me.Search_Button.Location = New System.Drawing.Point(352, 42)
        Me.Search_Button.Margin = New System.Windows.Forms.Padding(2)
        Me.Search_Button.Name = "Search_Button"
        Me.Search_Button.Size = New System.Drawing.Size(72, 20)
        Me.Search_Button.TabIndex = 44
        Me.Search_Button.Text = "Search"
        Me.Search_Button.UseVisualStyleBackColor = True
        '
        'SearchBox
        '
        Me.SearchBox.Location = New System.Drawing.Point(124, 18)
        Me.SearchBox.Margin = New System.Windows.Forms.Padding(2)
        Me.SearchBox.Name = "SearchBox"
        Me.SearchBox.Size = New System.Drawing.Size(300, 20)
        Me.SearchBox.TabIndex = 39
        '
        'BookList
        '
        Me.BookList.AllowUserToAddRows = False
        Me.BookList.AllowUserToDeleteRows = False
        Me.BookList.BackgroundColor = System.Drawing.Color.White
        Me.BookList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.BookList.Location = New System.Drawing.Point(21, 74)
        Me.BookList.Margin = New System.Windows.Forms.Padding(2)
        Me.BookList.Name = "BookList"
        Me.BookList.RowHeadersWidth = 62
        Me.BookList.RowTemplate.Height = 28
        Me.BookList.Size = New System.Drawing.Size(373, 116)
        Me.BookList.TabIndex = 43
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.DarkCyan
        Me.GroupBox1.Controls.Add(Me.Delete_Button)
        Me.GroupBox1.Controls.Add(Me.Reset_Button)
        Me.GroupBox1.Controls.Add(Me.Search_Button)
        Me.GroupBox1.Controls.Add(Me.PhoneNumberBox)
        Me.GroupBox1.Controls.Add(Me.SearchBox)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.AddressBox)
        Me.GroupBox1.Controls.Add(Me.Insert_Button)
        Me.GroupBox1.Controls.Add(Me.Update_Button)
        Me.GroupBox1.Controls.Add(Me.NameBox)
        Me.GroupBox1.Controls.Add(Me.IcBox)
        Me.GroupBox1.Location = New System.Drawing.Point(40, 255)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(442, 285)
        Me.GroupBox1.TabIndex = 42
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Borrower Information"
        '
        'Delete_Button
        '
        Me.Delete_Button.Location = New System.Drawing.Point(352, 252)
        Me.Delete_Button.Margin = New System.Windows.Forms.Padding(2)
        Me.Delete_Button.Name = "Delete_Button"
        Me.Delete_Button.Size = New System.Drawing.Size(72, 20)
        Me.Delete_Button.TabIndex = 49
        Me.Delete_Button.Text = "Delete"
        Me.Delete_Button.UseVisualStyleBackColor = True
        '
        'NumBooksBox
        '
        Me.NumBooksBox.Location = New System.Drawing.Point(135, 18)
        Me.NumBooksBox.Margin = New System.Windows.Forms.Padding(2)
        Me.NumBooksBox.Name = "NumBooksBox"
        Me.NumBooksBox.ReadOnly = True
        Me.NumBooksBox.Size = New System.Drawing.Size(134, 20)
        Me.NumBooksBox.TabIndex = 48
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(18, 17)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(73, 26)
        Me.Label6.TabIndex = 47
        Me.Label6.Text = "Number Of " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Book Borrows"
        '
        'PhoneNumberBox
        '
        Me.PhoneNumberBox.Location = New System.Drawing.Point(124, 172)
        Me.PhoneNumberBox.Margin = New System.Windows.Forms.Padding(2)
        Me.PhoneNumberBox.Name = "PhoneNumberBox"
        Me.PhoneNumberBox.Size = New System.Drawing.Size(300, 20)
        Me.PhoneNumberBox.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(32, 145)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "IC Number :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(11, 175)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Phone Number :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(9, 104)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(86, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Borrower Name :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(44, 208)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Address :"
        '
        'AddressBox
        '
        Me.AddressBox.Location = New System.Drawing.Point(124, 208)
        Me.AddressBox.Margin = New System.Windows.Forms.Padding(2)
        Me.AddressBox.Multiline = True
        Me.AddressBox.Name = "AddressBox"
        Me.AddressBox.Size = New System.Drawing.Size(300, 22)
        Me.AddressBox.TabIndex = 10
        '
        'Insert_Button
        '
        Me.Insert_Button.Location = New System.Drawing.Point(124, 251)
        Me.Insert_Button.Margin = New System.Windows.Forms.Padding(2)
        Me.Insert_Button.Name = "Insert_Button"
        Me.Insert_Button.Size = New System.Drawing.Size(72, 20)
        Me.Insert_Button.TabIndex = 40
        Me.Insert_Button.Text = "Insert"
        Me.Insert_Button.UseVisualStyleBackColor = True
        '
        'Update_Button
        '
        Me.Update_Button.Location = New System.Drawing.Point(276, 252)
        Me.Update_Button.Margin = New System.Windows.Forms.Padding(2)
        Me.Update_Button.Name = "Update_Button"
        Me.Update_Button.Size = New System.Drawing.Size(72, 20)
        Me.Update_Button.TabIndex = 41
        Me.Update_Button.Text = "Update"
        Me.Update_Button.UseVisualStyleBackColor = True
        '
        'NameBox
        '
        Me.NameBox.Location = New System.Drawing.Point(124, 101)
        Me.NameBox.Margin = New System.Windows.Forms.Padding(2)
        Me.NameBox.Name = "NameBox"
        Me.NameBox.Size = New System.Drawing.Size(300, 20)
        Me.NameBox.TabIndex = 7
        '
        'IcBox
        '
        Me.IcBox.Location = New System.Drawing.Point(124, 138)
        Me.IcBox.Margin = New System.Windows.Forms.Padding(2)
        Me.IcBox.Name = "IcBox"
        Me.IcBox.Size = New System.Drawing.Size(300, 20)
        Me.IcBox.TabIndex = 8
        '
        'Back_Button
        '
        Me.Back_Button.Location = New System.Drawing.Point(862, 104)
        Me.Back_Button.Margin = New System.Windows.Forms.Padding(2)
        Me.Back_Button.Name = "Back_Button"
        Me.Back_Button.Size = New System.Drawing.Size(75, 20)
        Me.Back_Button.TabIndex = 50
        Me.Back_Button.Text = "Return"
        Me.Back_Button.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.DarkCyan
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.NumBooksBox)
        Me.GroupBox2.Controls.Add(Me.BookList)
        Me.GroupBox2.Location = New System.Drawing.Point(508, 255)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(409, 201)
        Me.GroupBox2.TabIndex = 51
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Book Borror Information"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(862, 26)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(75, 73)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 92
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(440, 49)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(108, 104)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 93
        Me.PictureBox1.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(12, 9)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(397, 25)
        Me.Label7.TabIndex = 94
        Me.Label7.Text = "BORROWER'S INFORMATION PAGE"
        '
        'Borrowers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Linen
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(960, 697)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Back_Button)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Borrowers"
        Me.Text = "Borrowers"
        CType(Me.BookList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Reset_Button As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Search_Button As Button
    Friend WithEvents SearchBox As TextBox
    Friend WithEvents BookList As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents PhoneNumberBox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents AddressBox As TextBox
    Friend WithEvents NameBox As TextBox
    Friend WithEvents IcBox As TextBox
    Friend WithEvents Update_Button As Button
    Friend WithEvents Insert_Button As Button
    Friend WithEvents NumBooksBox As TextBox
    Friend WithEvents Label6 As Label

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Friend WithEvents Delete_Button As Button
    Friend WithEvents Back_Button As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label7 As Label
End Class
