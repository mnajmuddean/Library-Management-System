<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReceiptPayment
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.borrowID = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BorrowerName = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.finesAmount = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.datePayment = New System.Windows.Forms.Label()
        Me.paymentAmount = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(68, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Borrow ID:"
        '
        'borrowID
        '
        Me.borrowID.AutoSize = True
        Me.borrowID.Location = New System.Drawing.Point(128, 31)
        Me.borrowID.Name = "borrowID"
        Me.borrowID.Size = New System.Drawing.Size(0, 13)
        Me.borrowID.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(42, 60)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Borrower Name:"
        '
        'BorrowerName
        '
        Me.BorrowerName.AutoSize = True
        Me.BorrowerName.Location = New System.Drawing.Point(128, 60)
        Me.BorrowerName.Name = "BorrowerName"
        Me.BorrowerName.Size = New System.Drawing.Size(0, 13)
        Me.BorrowerName.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(48, 91)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(74, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Fines Amount:"
        '
        'finesAmount
        '
        Me.finesAmount.AutoSize = True
        Me.finesAmount.Location = New System.Drawing.Point(125, 91)
        Me.finesAmount.Name = "finesAmount"
        Me.finesAmount.Size = New System.Drawing.Size(0, 13)
        Me.finesAmount.TabIndex = 5
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(48, 120)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(77, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Payment Date:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(68, 146)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(54, 13)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Payment :"
        '
        'datePayment
        '
        Me.datePayment.AutoSize = True
        Me.datePayment.Location = New System.Drawing.Point(128, 120)
        Me.datePayment.Name = "datePayment"
        Me.datePayment.Size = New System.Drawing.Size(0, 13)
        Me.datePayment.TabIndex = 8
        '
        'paymentAmount
        '
        Me.paymentAmount.AutoSize = True
        Me.paymentAmount.Location = New System.Drawing.Point(128, 146)
        Me.paymentAmount.Name = "paymentAmount"
        Me.paymentAmount.Size = New System.Drawing.Size(0, 13)
        Me.paymentAmount.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(82, 170)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Status:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(128, 170)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Succesful"
        '
        'ReceiptPayment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkCyan
        Me.ClientSize = New System.Drawing.Size(255, 222)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.paymentAmount)
        Me.Controls.Add(Me.datePayment)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.finesAmount)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.BorrowerName)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.borrowID)
        Me.Controls.Add(Me.Label1)
        Me.Name = "ReceiptPayment"
        Me.Text = "Payment Receipt Page"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents borrowID As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents BorrowerName As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents finesAmount As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents datePayment As Label
    Friend WithEvents paymentAmount As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
End Class
