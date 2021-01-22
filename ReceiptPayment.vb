Public Class ReceiptPayment
    Private Sub ReceiptPayment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        borrowID.Text = payment.BorrowID_box.Text
        BorrowerName.Text = payment.NameBox.Text
        finesAmount.Text = payment.Amount_Box.Text
        datePayment.Text = payment.Date_payment.Value
        paymentAmount.Text = payment.payment_box.Text
    End Sub
End Class