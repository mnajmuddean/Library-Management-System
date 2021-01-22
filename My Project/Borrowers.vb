Imports System.Configuration
Imports System.Data.OleDb
Imports System.Data
Public Class Borrowers

    Private Function GetDataList(ByVal IC As String) As DataTable
        Dim dtBook As New DataTable
        Dim connString As String = ConfigurationManager.ConnectionStrings("dbc").ConnectionString
        Dim sql As String
        sql = "SELECT * From Book INNER JOIN Borrow ON Book.ISBN = Borrow.Book_ID Where Borrow.Borrower_ID = '" & IC & "'"
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

    Private Sub Search_Button_Click(sender As Object, e As EventArgs) Handles Search_Button.Click
        Dim command As OleDbCommand
        Dim query As String
        Dim datareader As OleDbDataReader
        BookList.DataSource = ""
        query = "SELECT * FROM [Borrower] where Borrower_Name='" & SearchBox.Text & "' "
        Dim connString2 As String = ConfigurationManager.ConnectionStrings("dbc").ConnectionString
        Dim connection As New OleDb.OleDbConnection(connString2)

        Try
            connection.Open()
            command = New OleDbCommand(query, connection)
            command.ExecuteNonQuery()
            datareader = command.ExecuteReader

            If datareader.Read Then
                NameBox.Text = datareader("Borrower_Name")
                IcBox.Text = datareader("IC")
                Dim ic As String = IcBox.Text
                PhoneNumberBox.Text = datareader("numberPhone")
                AddressBox.Text = datareader("address")
                BookList.DataSource = GetDataList(ic)
                NumBooksBox.Text = BookList.Rows.Count()
                connection.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Borrowers_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Insert_Button_Click(sender As Object, e As EventArgs) Handles Insert_Button.Click
        Dim query As String
        query = "INSERT into [Borrower] ([Borrower_Name],[IC],[numberPhone],[Address]) values ('" & NameBox.Text & "','" & IcBox.Text & "','" & PhoneNumberBox.Text & "','" & AddressBox.Text & "')"
        Dim connString2 As String = ConfigurationManager.ConnectionStrings("dbc").ConnectionString

        Try
            Using connection As New OleDbConnection(connString2)
                Using cmd As New OleDbCommand(query, connection)
                    connection.Open()
                    Dim reader As OleDbDataReader = cmd.ExecuteReader()
                    MsgBox("Borrower Saved")
                    connection.Close()
                End Using
            End Using
        Catch ex As Exception
            MsgBox("Error")
        End Try
    End Sub

    Private Sub Update_Button_Click(sender As Object, e As EventArgs) Handles Update_Button.Click
        Dim command As OleDbCommand
        Dim query As String
        Dim datareader As OleDbDataReader

        query = "UPDATE [Borrower] set Borrower_Name ='" & NameBox.Text & "',numberPhone ='" & PhoneNumberBox.Text & "', address='" & AddressBox.Text & "'  where   IC ='" + IcBox.Text + "' "
        Dim connString2 As String = ConfigurationManager.ConnectionStrings("dbc").ConnectionString
        Dim connection As New OleDb.OleDbConnection(connString2)

        Try
            connection.Open()
            command = New OleDbCommand(query, connection)
            datareader = command.ExecuteReader()
            MsgBox("Data Updated")
            connection.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub Reset_Button_Click(sender As Object, e As EventArgs) Handles Reset_Button.Click
        NameBox.Clear()
        IcBox.Clear()
        PhoneNumberBox.Clear()
        AddressBox.Clear()
        NumBooksBox.Clear()
        SearchBox.Clear()
        BookList.DataSource = GetDataList(" ")
    End Sub

    Private Sub Delete_Button_Click(sender As Object, e As EventArgs) Handles Delete_Button.Click
        Dim command As OleDbCommand
        Dim query As String
        Dim datareader As OleDbDataReader

        query = "DELETE * FROM [Borrower] where  IC ='" + IcBox.Text + "'"
        Dim connString2 As String = ConfigurationManager.ConnectionStrings("dbc").ConnectionString
        Dim connection As New OleDb.OleDbConnection(connString2)

        Try
            connection.Open()
            command = New OleDbCommand(query, connection)
            command.ExecuteNonQuery()
            datareader = command.ExecuteReader
            MsgBox("Data Deleted")
            NameBox.Clear()
            IcBox.Clear()
            PhoneNumberBox.Clear()
            AddressBox.Clear()
            NumBooksBox.Clear()
            SearchBox.Clear()
            BookList.DataSource = GetDataList(" ")
            connection.Close()
        Catch ex As Exception
            MsgBox("Error")

        End Try
    End Sub

    Private Sub Back_Button_Click(sender As Object, e As EventArgs) Handles Back_Button.Click
        Me.Close()
        Menu_List.Visible = True
    End Sub
End Class