<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Late_return
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Late_return))
        Me.searchBox = New System.Windows.Forms.TextBox()
        Me.searchButton = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.NameBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ICBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ISBN_Box = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TitleBox = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DueBox = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.FinesBox = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.backButton = New System.Windows.Forms.Button()
        Me.Details = New System.Windows.Forms.GroupBox()
        Me.BorrowID_Box = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label8 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Details.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'searchBox
        '
        Me.searchBox.Location = New System.Drawing.Point(35, 168)
        Me.searchBox.Name = "searchBox"
        Me.searchBox.Size = New System.Drawing.Size(367, 20)
        Me.searchBox.TabIndex = 1
        '
        'searchButton
        '
        Me.searchButton.Location = New System.Drawing.Point(409, 167)
        Me.searchButton.Name = "searchButton"
        Me.searchButton.Size = New System.Drawing.Size(83, 20)
        Me.searchButton.TabIndex = 2
        Me.searchButton.Text = "Search"
        Me.searchButton.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(19, 22)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(473, 132)
        Me.DataGridView1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(19, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 26)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Borrower's " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Name : "
        '
        'NameBox
        '
        Me.NameBox.Location = New System.Drawing.Point(88, 55)
        Me.NameBox.Multiline = True
        Me.NameBox.Name = "NameBox"
        Me.NameBox.Size = New System.Drawing.Size(197, 37)
        Me.NameBox.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(12, 98)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Identity Card : "
        '
        'ICBox
        '
        Me.ICBox.Location = New System.Drawing.Point(88, 98)
        Me.ICBox.Name = "ICBox"
        Me.ICBox.Size = New System.Drawing.Size(197, 20)
        Me.ICBox.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(20, 136)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Book ISBN : "
        '
        'ISBN_Box
        '
        Me.ISBN_Box.Location = New System.Drawing.Point(88, 133)
        Me.ISBN_Box.Name = "ISBN_Box"
        Me.ISBN_Box.Size = New System.Drawing.Size(197, 20)
        Me.ISBN_Box.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(23, 168)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Book Title : "
        '
        'TitleBox
        '
        Me.TitleBox.Location = New System.Drawing.Point(86, 168)
        Me.TitleBox.Multiline = True
        Me.TitleBox.Name = "TitleBox"
        Me.TitleBox.Size = New System.Drawing.Size(199, 37)
        Me.TitleBox.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(25, 225)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(62, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Due Date : "
        '
        'DueBox
        '
        Me.DueBox.Location = New System.Drawing.Point(86, 222)
        Me.DueBox.Name = "DueBox"
        Me.DueBox.Size = New System.Drawing.Size(197, 20)
        Me.DueBox.TabIndex = 12
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(18, 255)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(66, 26)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Late Return " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Fines : "
        '
        'FinesBox
        '
        Me.FinesBox.Location = New System.Drawing.Point(86, 261)
        Me.FinesBox.Name = "FinesBox"
        Me.FinesBox.Size = New System.Drawing.Size(107, 20)
        Me.FinesBox.TabIndex = 14
        '
        'Button1
        '
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Location = New System.Drawing.Point(15, 297)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 22)
        Me.Button1.TabIndex = 15
        Me.Button1.Text = "Payment"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'backButton
        '
        Me.backButton.ForeColor = System.Drawing.Color.Black
        Me.backButton.Location = New System.Drawing.Point(976, 98)
        Me.backButton.Name = "backButton"
        Me.backButton.Size = New System.Drawing.Size(75, 22)
        Me.backButton.TabIndex = 16
        Me.backButton.Text = "Back"
        Me.backButton.UseVisualStyleBackColor = True
        '
        'Details
        '
        Me.Details.BackColor = System.Drawing.Color.DarkCyan
        Me.Details.Controls.Add(Me.BorrowID_Box)
        Me.Details.Controls.Add(Me.Button1)
        Me.Details.Controls.Add(Me.Label7)
        Me.Details.Controls.Add(Me.NameBox)
        Me.Details.Controls.Add(Me.Label1)
        Me.Details.Controls.Add(Me.ICBox)
        Me.Details.Controls.Add(Me.FinesBox)
        Me.Details.Controls.Add(Me.Label6)
        Me.Details.Controls.Add(Me.Label2)
        Me.Details.Controls.Add(Me.ISBN_Box)
        Me.Details.Controls.Add(Me.DueBox)
        Me.Details.Controls.Add(Me.Label5)
        Me.Details.Controls.Add(Me.Label3)
        Me.Details.Controls.Add(Me.TitleBox)
        Me.Details.Controls.Add(Me.Label4)
        Me.Details.ForeColor = System.Drawing.Color.White
        Me.Details.Location = New System.Drawing.Point(74, 242)
        Me.Details.Name = "Details"
        Me.Details.Size = New System.Drawing.Size(474, 337)
        Me.Details.TabIndex = 17
        Me.Details.TabStop = False
        Me.Details.Text = "Details"
        '
        'BorrowID_Box
        '
        Me.BorrowID_Box.Location = New System.Drawing.Point(88, 19)
        Me.BorrowID_Box.Name = "BorrowID_Box"
        Me.BorrowID_Box.Size = New System.Drawing.Size(197, 20)
        Me.BorrowID_Box.TabIndex = 16
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(19, 22)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(63, 13)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Borrow ID : "
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.DarkCyan
        Me.GroupBox1.Controls.Add(Me.DataGridView1)
        Me.GroupBox1.Controls.Add(Me.searchBox)
        Me.GroupBox1.Controls.Add(Me.searchButton)
        Me.GroupBox1.Location = New System.Drawing.Point(567, 242)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(509, 337)
        Me.GroupBox1.TabIndex = 18
        Me.GroupBox1.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(479, 46)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(163, 156)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 90
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(976, 19)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(75, 73)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 91
        Me.PictureBox2.TabStop = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(12, 9)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(238, 25)
        Me.Label8.TabIndex = 95
        Me.Label8.Text = "LATE RETURN PAGE"
        '
        'Late_return
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Linen
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1078, 643)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.backButton)
        Me.Controls.Add(Me.Details)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Name = "Late_return"
        Me.Text = "Late Return Page"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Details.ResumeLayout(False)
        Me.Details.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents searchBox As TextBox
    Friend WithEvents searchButton As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents NameBox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents ICBox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents ISBN_Box As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TitleBox As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents DueBox As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents FinesBox As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents backButton As Button
    Friend WithEvents Details As GroupBox
    Friend WithEvents BorrowID_Box As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label8 As Label
End Class
