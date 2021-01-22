Imports System.Configuration
Imports System.Data
Imports System.Data.OleDb
Public Class Late_return
    Public Sub GetDataList(value As String)
        Dim dt As New DataTable
        Dim connString As String = ConfigurationManager.ConnectionStrings("dbc").ConnectionString
        Dim sql As String
        If value = "" Then
            sql = "SELECT Borrow.Borrow_ID,Borrower.Borrower_Name,Borrower.IC,Borrower.numberPhone,Book.ISBN,Book.yearPublication,Book.bookTitle,Book.author,Book.publisher_name,Borrow.issue_Date,Borrow.dueDate,Late_Return_Fines.late_fines
                FROM (([Borrow] INNER JOIN [Book]
                ON Borrow.Book_ID=Book.ISBN)
                INNER JOIN [Late_Return_Fines]
                ON Borrow.Borrow_ID = Late_Return_Fines.borrowID)
                INNER JOIN [Borrower]
                ON Borrow.Borrower_ID=Borrower.IC
                Where Borrow.returnDate IS NULL"
        Else
            sql = "SELECT Borrow.Borrow_ID,Borrower.Borrower_Name,Borrower.IC,Borrower.numberPhone,Book.ISBN,Book.yearPublication,Book.bookTitle,Book.author,Book.publisher_name,Borrow.issue_Date,Borrow.dueDate,Late_Return_Fines.late_fines
                FROM (([Borrow] INNER JOIN [Book]
                ON Borrow.Book_ID=Book.ISBN)
                INNER JOIN [Late_Return_Fines]
                ON Borrow.Borrow_ID = Late_Return_Fines.borrowID)
                INNER JOIN [Borrower]
                ON Borrow.Borrower_ID=Borrower.IC
                Where Borrow.returnDate IS NULL AND (Borrower.Borrower_Name = '" & value & "' OR Borrower.IC = '" & value & "')"
        End If

        Try
            Using conn As New OleDbConnection(connString)
                Using cmd As New OleDbCommand(sql, conn)
                    conn.Open()
                    Dim reader As OleDbDataReader = cmd.ExecuteReader()
                    dt.Load(reader)
                    DataGridView1.DataSource = dt
                    conn.Close()
                    DataGridView1.Columns(0).HeaderText = "Borrow ID"
                    DataGridView1.Columns(1).HeaderText = "Borrower's Name"
                    DataGridView1.Columns(2).HeaderText = "IC"
                    DataGridView1.Columns(3).HeaderText = "Phone Number"
                    DataGridView1.Columns(4).HeaderText = "ISBN"
                    DataGridView1.Columns(5).HeaderText = "Year Publish"
                    DataGridView1.Columns(6).HeaderText = "Book Title"
                    DataGridView1.Columns(7).HeaderText = "Author"
                    DataGridView1.Columns(8).HeaderText = "Publisher"
                    DataGridView1.Columns(9).HeaderText = "Issue Date"
                    DataGridView1.Columns(10).HeaderText = "Due Date"
                    DataGridView1.Columns(11).HeaderText = "Late Return Fines"
                    DataGridView1.DefaultCellStyle.BackColor = Color.Azure
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Late_return_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GetDataList("")
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim index As Integer
        index = e.RowIndex
        Dim selectedRow As DataGridViewRow
        selectedRow = DataGridView1.Rows(index)
        BorrowID_Box.Text = selectedRow.Cells(0).Value.ToString()
        NameBox.Text = selectedRow.Cells(1).Value.ToString()
        ICBox.Text = selectedRow.Cells(2).Value.ToString()
        ISBN_Box.Text = selectedRow.Cells(4).Value.ToString()
        TitleBox.Text = selectedRow.Cells(6).Value.ToString()
        DueBox.Text = selectedRow.Cells(10).Value.ToString()
        FinesBox.Text = selectedRow.Cells(11).Value.ToString()
    End Sub

    Private Sub searchButton_Click(sender As Object, e As EventArgs) Handles searchButton.Click
        Dim value As String = searchBox.Text
        GetDataList(value)


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        payment.show()
    End Sub

    Private Sub backButton_Click(sender As Object, e As EventArgs) Handles backButton.Click
        Menu_List.Show()
        Me.Close()
    End Sub
End Class