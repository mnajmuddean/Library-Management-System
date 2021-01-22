Imports System.Configuration
Imports System.Data.OleDb
Public Class Book_IssueForm
    Dim borrowerID As String
    Public Sub clearText()
        SearchBook_txt.Clear()
        SearchBorrower.Clear()
        ISBNBox.Clear()
        TitleBox.Clear()
        NameBox.Clear()
        BookView.DataSource = Nothing
        BookView.Rows.Clear()
        BorrowerView.DataSource = Nothing
        BorrowerView.Rows.Clear()
    End Sub
    Public Sub searchBook()
        Dim dt As New DataTable
        Dim ds As New DataSet
        ds.Tables.Add(dt)
        Dim connString As String = ConfigurationManager.ConnectionStrings("dbc").ConnectionString
        Dim conn As New OleDbConnection(connString)
        Dim da As New OleDbDataAdapter("Select ISBN,author,bookTitle From Book", conn)
        da.Fill(dt)
        Dim r As DataRow
        SearchBook_txt.AutoCompleteCustomSource.Clear()
        For Each r In dt.Rows
            SearchBook_txt.AutoCompleteCustomSource.Add(r.Item(0).ToString)
            SearchBook_txt.AutoCompleteCustomSource.Add(r.Item(1).ToString)
            SearchBook_txt.AutoCompleteCustomSource.Add(r.Item(2).ToString)
        Next
        SearchBook_txt.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        SearchBook_txt.AutoCompleteSource = AutoCompleteSource.CustomSource

    End Sub

    Private Sub GetBookList(book As String)
        Dim dtBook As New DataTable
        dtBook.Rows.Clear()
        Dim connString As String = ConfigurationManager.ConnectionStrings("dbc").ConnectionString
        Dim sql As String
        sql = "Select * FROM Book WHERE ISBN = '" & book & "' OR bookTitle = '" & book & "' OR author = '" & book & "'"
        Try
            Using conn As New OleDbConnection(connString)
                Using cmd As New OleDbCommand(sql, conn)
                    conn.Open()
                    Dim reader As OleDbDataReader = cmd.ExecuteReader()
                    dtBook.Load(reader)
                    BookView.DataSource = dtBook
                    conn.Close()
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub GetBorrowerList(borrower As String)

        Dim dtBorrower As New DataTable
        dtBorrower.Rows.Clear()
        Dim connString As String = ConfigurationManager.ConnectionStrings("dbc").ConnectionString
        Dim sql As String
        sql = "Select * FROM Borrower WHERE Borrower_Name = '" & borrower & "'"
        Try
            Using conn As New OleDbConnection(connString)
                Using cmd As New OleDbCommand(sql, conn)
                    conn.Open()
                    Dim reader As OleDbDataReader = cmd.ExecuteReader()
                    dtBorrower.Load(reader)
                    BorrowerView.DataSource = dtBorrower
                    If dtBorrower.Rows.Count() = 0 Then
                        MsgBox("Borrower Not Registered")
                        addButton.Visible = True
                    End If
                    conn.Close()
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub Book_IssueForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call searchBook()
        addButton.Visible = False
    End Sub


    Private Sub SearchBook_button_Click(sender As Object, e As EventArgs) Handles SearchBook_button.Click
        Dim book As String = SearchBook_txt.Text
        GetBookList(book)
    End Sub

    Private Sub BookView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles BookView.CellClick
        Dim index As Integer
        index = e.RowIndex
        Dim selectedRow As DataGridViewRow
        selectedRow = BookView.Rows(index)
        ISBNBox.Text = selectedRow.Cells(0).Value.ToString()
        TitleBox.Text = selectedRow.Cells(2).Value.ToString()
    End Sub

    Private Sub searchBorrower_Button_Click(sender As Object, e As EventArgs) Handles searchBorrower_Button.Click
        Dim Borrower As String = SearchBorrower.Text
        GetBorrowerList(Borrower)
    End Sub

    Private Sub BorrowerView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles BorrowerView.CellClick
        Dim index As Integer
        index = e.RowIndex
        Dim selectedRow As DataGridViewRow
        selectedRow = BorrowerView.Rows(index)
        NameBox.Text = selectedRow.Cells(0).Value.ToString()
        borrowerID = selectedRow.Cells(1).Value.ToString()
    End Sub

    Private Sub bookButton_Click(sender As Object, e As EventArgs) Handles bookButton.Click
        Dim isbn As String = ISBNBox.Text
        Dim issueDate As Date = IssueDatePicker.Value.Date
        Dim dueDate As Date = DueDatePicker.Value.Date
        Dim id As String = borrowerID

        Try
            Dim connString As String = ConfigurationManager.ConnectionStrings("dbc").ConnectionString
            Dim sql As String
            sql = "INSERT INTO [Borrow](Book_ID,Borrower_ID,issue_Date,dueDate) VALUES ('" & isbn & "','" & id & "','" & issueDate & "','" & dueDate & "')"
            Using conn As New OleDbConnection(connString)
                Using cmd As New OleDbCommand(sql, conn)
                    conn.Open()
                    Dim reader As OleDbDataReader = cmd.ExecuteReader()
                    conn.Close()
                End Using
            End Using
            MsgBox("Book Issued")
            clearText()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub addButton_Click(sender As Object, e As EventArgs) Handles addButton.Click
        Me.Close()
        Borrowers.Show()
    End Sub

    Private Sub returnButton_Click(sender As Object, e As EventArgs) Handles returnButton.Click
        Me.Close()
        Menu_List.Show()
    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub
End Class