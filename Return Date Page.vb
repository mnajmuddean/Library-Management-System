Imports System.Configuration
Imports System.Data
Imports System.Data.OleDb
Public Class return_date
    Private Sub insertButton_Click(sender As Object, e As EventArgs) Handles insertButton.Click
        Dim returnDate As Date
        returnDate = DateTimePicker1.Value.Date
        For i As Integer = 0 To BookReturn_Form.DataGridView1.Rows.Count() - 1 Step +1
            Dim check As Boolean = BookReturn_Form.DataGridView1.Rows(i).Cells(0).Value
            If check = True Then
                Try
                    Dim isbn As String = BookReturn_Form.DataGridView1.Rows(i).Cells(1).Value
                    Dim issueDate As Date = BookReturn_Form.DataGridView1.Rows(i).Cells(6).Value
                    Dim ic As String = BookReturn_Form.TextBox2.Text
                    Dim connString3 As String = ConfigurationManager.ConnectionStrings("dbc").ConnectionString
                    Dim conn2 As New OleDb.OleDbConnection(connString3)
                    Dim cmd As OleDbCommand
                    Dim query As String
                    Dim dt As OleDbDataReader
                    conn2.Open()

                    query = "UPDATE [Borrow] SET returnDate = '" & returnDate & "' Where Book_ID = '" & isbn & "' And Borrower_ID = '" & ic & "'"
                    cmd = New OleDbCommand(query, conn2)
                    dt = cmd.ExecuteReader

                    MsgBox("Returned")
                    conn2.Close()

                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
        Next
        Dim IdentityCard As String = BookReturn_Form.TextBox2.Text
        BookReturn_Form.GetDataList(IdentityCard)
        Me.Close()
    End Sub

    Private Sub return_date_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class