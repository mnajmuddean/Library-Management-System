<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class payment
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(payment))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.IC_Box = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.NameBox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Date_payment = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BorrowID_box = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.payButton = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.payment_box = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Amount_Box = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(51, 101)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Borrower's IC :"
        '
        'IC_Box
        '
        Me.IC_Box.Location = New System.Drawing.Point(140, 101)
        Me.IC_Box.Name = "IC_Box"
        Me.IC_Box.ReadOnly = True
        Me.IC_Box.Size = New System.Drawing.Size(168, 20)
        Me.IC_Box.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(33, 60)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Borrower's Name :"
        '
        'NameBox
        '
        Me.NameBox.Location = New System.Drawing.Point(140, 57)
        Me.NameBox.Multiline = True
        Me.NameBox.Name = "NameBox"
        Me.NameBox.ReadOnly = True
        Me.NameBox.Size = New System.Drawing.Size(312, 32)
        Me.NameBox.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(32, 159)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(94, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Date Of Payment :"
        '
        'Date_payment
        '
        Me.Date_payment.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Date_payment.Location = New System.Drawing.Point(140, 153)
        Me.Date_payment.Name = "Date_payment"
        Me.Date_payment.Size = New System.Drawing.Size(113, 20)
        Me.Date_payment.TabIndex = 7
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.DarkCyan
        Me.GroupBox1.Controls.Add(Me.BorrowID_box)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.payButton)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.payment_box)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Amount_Box)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.NameBox)
        Me.GroupBox1.Controls.Add(Me.Date_payment)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.IC_Box)
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GroupBox1.Location = New System.Drawing.Point(36, 24)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(464, 258)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Fines Details"
        '
        'BorrowID_box
        '
        Me.BorrowID_box.Location = New System.Drawing.Point(140, 25)
        Me.BorrowID_box.Name = "BorrowID_box"
        Me.BorrowID_box.ReadOnly = True
        Me.BorrowID_box.Size = New System.Drawing.Size(168, 20)
        Me.BorrowID_box.TabIndex = 16
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(66, 28)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(60, 13)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Borrow ID :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(140, 130)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(24, 13)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "RM"
        '
        'payButton
        '
        Me.payButton.Location = New System.Drawing.Point(377, 203)
        Me.payButton.Name = "payButton"
        Me.payButton.Size = New System.Drawing.Size(75, 23)
        Me.payButton.TabIndex = 13
        Me.payButton.Text = "Pay"
        Me.payButton.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(140, 188)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(24, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "RM"
        '
        'payment_box
        '
        Me.payment_box.Location = New System.Drawing.Point(170, 185)
        Me.payment_box.Name = "payment_box"
        Me.payment_box.Size = New System.Drawing.Size(71, 20)
        Me.payment_box.TabIndex = 11
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(72, 188)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Payment :"
        '
        'Amount_Box
        '
        Me.Amount_Box.Location = New System.Drawing.Point(170, 127)
        Me.Amount_Box.Name = "Amount_Box"
        Me.Amount_Box.ReadOnly = True
        Me.Amount_Box.Size = New System.Drawing.Size(61, 20)
        Me.Amount_Box.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(50, 130)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(76, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Total Amount :"
        '
        'payment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(553, 329)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "payment"
        Me.Text = "Fines Payment"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents IC_Box As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents NameBox As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Date_payment As DateTimePicker
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Amount_Box As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents payButton As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents payment_box As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents BorrowID_box As TextBox
End Class
