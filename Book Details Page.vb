Imports System.Configuration
Imports System.Data.OleDb
Imports System.Data

Public Class Book
    Public Sub searchBook()
        Dim dt As New DataTable
        Dim ds As New DataSet
        ds.Tables.Add(dt)
        Dim connString As String = ConfigurationManager.ConnectionStrings("dbc").ConnectionString
        Dim conn As New OleDbConnection(connString)
        Dim da As New OleDbDataAdapter("Select ISBN,author,bookTitle From Book", conn)
        da.Fill(dt)
        Dim r As DataRow
        SearchField.AutoCompleteCustomSource.Clear()
        For Each r In dt.Rows
            SearchField.AutoCompleteCustomSource.Add(r.Item(0).ToString)
            SearchField.AutoCompleteCustomSource.Add(r.Item(1).ToString)
            SearchField.AutoCompleteCustomSource.Add(r.Item(2).ToString)
        Next
        SearchField.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        SearchField.AutoCompleteSource = AutoCompleteSource.CustomSource
    End Sub

    Private Function GetDataList(ByVal value As String) As DataTable
        Dim dtBook As New DataTable
        Dim connString As String = ConfigurationManager.ConnectionStrings("dbc").ConnectionString
        Dim sql As String
        If value = "" Then
            sql = "SELECT * FROM [Book]"
        Else
            sql = "SELECT * FROM [Book] Where  ISBN LIKE '" & value & "' OR bookTitle LIKE '" & value & "' OR author LIKE '" & value & "'"
        End If

        Using conn As New OleDbConnection(connString)
            Using cmd As New OleDbCommand(sql, conn)
                conn.Open()
                Dim reader As OleDbDataReader = cmd.ExecuteReader()
                dtBook.Load(reader)
                conn.Close()
            End Using
        End Using
        Return dtBook
    End Function

    Private Sub Book_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridView1.DataSource = GetDataList("")
        searchBook()
        DataGridView1.Columns(0).HeaderText = "ISBN"
        DataGridView1.Columns(1).HeaderText = "Year Publication"
        DataGridView1.Columns(2).HeaderText = "Title"
        DataGridView1.Columns(3).HeaderText = "Author"
        DataGridView1.Columns(4).HeaderText = "Publisher"
        DataGridView1.Columns(5).HeaderText = "Category"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Try
            Dim query As String
            query = "INSERT into [Book] ([ISBN],[yearPublication],[bookTitle],[author],[publisher_name],[bookCategory]) values ('" & Book_IDTextBox.Text & "','" & Book_PublisherTextBox.Text & "','" & Book_TitleTextBox.Text & "','" & AuthorTextBox.Text & "','" & PubTextBox.Text & "','" & CateTextBox.Text & "')"
            Dim connString2 As String = ConfigurationManager.ConnectionStrings("dbc").ConnectionString
            Using connection As New OleDbConnection(connString2)
                Using command As New OleDbCommand(query, connection)
                    connection.Open()
                    Dim reader As OleDbDataReader = command.ExecuteReader()
                    connection.Close()
                End Using
            End Using
            MsgBox("Book Added")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        DataGridView1.DataSource = GetDataList("")
    End Sub

    Private Sub search_button_Click(sender As Object, e As EventArgs) Handles search_button.Click
        Dim searchValue As String = SearchField.Text
        DataGridView1.DataSource = GetDataList(searchValue)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
        Menu_List.Visible = True
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        PubTextBox.Clear()
        Book_TitleTextBox.Clear()
        Book_IDTextBox.Clear()
        Book_PublisherTextBox.Clear()
        AuthorTextBox.Clear()
        CateTextBox.Clear()
        SearchField.Clear()

        DataGridView1.DataSource = GetDataList("")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim command As OleDbCommand
        Dim query As String
        Dim datareader As OleDbDataReader

        query = "DELETE * FROM [Book] where  bookTitle ='" + Book_TitleTextBox.Text + "' "
        Dim connString2 As String = ConfigurationManager.ConnectionStrings("dbc").ConnectionString
        Dim connection As New OleDb.OleDbConnection(connString2)

        Try
            connection.Open()
            command = New OleDbCommand(query, connection)
            command.ExecuteNonQuery()
            datareader = command.ExecuteReader()
            MsgBox("Book Deleted")
            connection.Close()
        Catch ex As Exception
            MsgBox("Error")

        End Try

        DataGridView1.DataSource = GetDataList("")
        PubTextBox.Clear()
        Book_TitleTextBox.Clear()
        Book_IDTextBox.Clear()
        Book_PublisherTextBox.Clear()
        AuthorTextBox.Clear()
        CateTextBox.Clear()
        SearchField.Clear()
    End Sub

    Private Sub Button_Update_Click(sender As Object, e As EventArgs) Handles Button_Update.Click
        Dim command As OleDbCommand
        Dim query As String
        Dim datareader As OleDbDataReader

        query = "UPDATE [Book] set yearPublication ='" & Book_PublisherTextBox.Text & "',bookTitle ='" & Book_TitleTextBox.Text & "', author='" & AuthorTextBox.Text & "', publisher_name ='" & PubTextBox.Text & "',bookCategory = '" & CateTextBox.Text & "' WHERE ISBN = '" & Book_IDTextBox.Text & "'"
        Dim connString2 As String = ConfigurationManager.ConnectionStrings("dbc").ConnectionString
        Dim connection As New OleDb.OleDbConnection(connString2)

        Try
            connection.Open()
            command = New OleDbCommand(query, connection)
            command.ExecuteNonQuery()
            datareader = command.ExecuteReader
            If datareader.Read Then
                MsgBox("Book Updated")
                connection.Close()
            End If

        Catch ex As Exception
            MsgBox("Error")

        End Try

        DataGridView1.DataSource = GetDataList("")
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim index As Integer
        index = e.RowIndex
        Dim selectedRow As DataGridViewRow
        selectedRow = DataGridView1.Rows(index)
        Book_IDTextBox.Text = selectedRow.Cells(0).Value.ToString()
        Book_PublisherTextBox.Text = selectedRow.Cells(1).Value.ToString()
        Book_TitleTextBox.Text = selectedRow.Cells(2).Value.ToString()
        AuthorTextBox.Text = selectedRow.Cells(3).Value.ToString()
        PubTextBox.Text = selectedRow.Cells(4).Value.ToString()
        CateTextBox.Text = selectedRow.Cells(5).Value.ToString()
    End Sub

    Private Sub SearchField_TextChanged(sender As Object, e As EventArgs) Handles SearchField.TextChanged

    End Sub
End Class
