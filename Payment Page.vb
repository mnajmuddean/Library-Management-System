Imports System.Configuration
Imports System.Data
Imports System.Data.OleDb
Public Class payment


    Private Sub payment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BorrowID_box.Text = Late_return.BorrowID_Box.Text
        NameBox.Text = Late_return.NameBox.Text
        IC_Box.Text = Late_return.ICBox.Text
        Amount_Box.Text = Late_return.FinesBox.Text
    End Sub

    Private Sub payButton_Click(sender As Object, e As EventArgs) Handles payButton.Click
        Dim DatePayment As Date = Date_payment.Value.Date
        Dim total As Double = Convert.ToDouble(Amount_Box.Text)
        Dim payment As Double = Convert.ToDouble(payment_box.Text)
        Dim borrowID As Integer = Convert.ToInt32(BorrowID_box.Text)
        Dim change As Double = payment - total
        If change >= 0 Then
            Try
                Dim connString As String = ConfigurationManager.ConnectionStrings("dbc").ConnectionString
                Dim conn As New OleDb.OleDbConnection(connString)
                Dim cmd As OleDbCommand
                Dim query As String
                Dim dt As OleDbDataReader
                conn.Open()

                query = "UPDATE [Late_Return_FInes] SET payment = '" & payment & "', date_payment = '" & DatePayment & "' Where  BorrowID = " & borrowID & ""
                cmd = New OleDbCommand(query, conn)
                dt = cmd.ExecuteReader
                conn.Close()

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            Try
                Dim connString2 As String = ConfigurationManager.ConnectionStrings("dbc").ConnectionString
                Dim conn2 As New OleDb.OleDbConnection(connString2)
                Dim cmd2 As OleDbCommand
                Dim query2 As String
                Dim reader As OleDbDataReader
                conn2.Open()

                query2 = "UPDATE [Borrow] SET  returnDate = '" & DatePayment & "' Where  Borrow_ID = " & borrowID & ""
                cmd2 = New OleDbCommand(query2, conn2)
                reader = cmd2.ExecuteReader

                MsgBox("Payment Received" & Environment.NewLine & "Change = RM" & change)
                Me.Hide()
                ReceiptPayment.Show()
                Late_return.GetDataList("")
                conn2.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            MsgBox("Not Enough Money")
        End If
    End Sub
End Class