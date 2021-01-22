Imports System.Configuration
Imports System.Data
Imports System.Data.OleDb

Public Class BookReturn_Form
    Private Sub Book_IssueForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim checkboxcol As New DataGridViewCheckBoxColumn
        checkboxcol.Width = 40
        checkboxcol.Name = "CheckBox"
        DataGridView1.Columns.Insert(0, checkboxcol)
    End Sub

    Private Sub updateLate(borrowID As Integer, day As Integer)

        Dim check As Boolean = True
        Dim connString As String = ConfigurationManager.ConnectionStrings("dbc").ConnectionString
        Dim sql As String = "Select * FROM Late_Return_Fines"
        Dim connection As New OleDbConnection(connString)
        Dim command As New OleDbCommand(sql, connection)
        connection.Open()
        Dim dataReader As OleDbDataReader = command.ExecuteReader()
        While dataReader.Read
            If borrowID = dataReader("borrowID") Then
                check = False
            End If
        End While
        connection.Close()

        If check = True Then
            Dim fines As Double = day * 0.5
            Dim connString2 As String = ConfigurationManager.ConnectionStrings("dbc").ConnectionString
            Dim query As String = "Insert INTO [Late_Return_Fines](borrowID,late_fines) VALUES (" & borrowID & "," & fines & ")"
            Dim conn2 As New OleDbConnection(connString2)
            Dim cmd2 As New OleDbCommand(query, conn2)
            conn2.Open()
            Dim dr As OleDbDataReader = cmd2.ExecuteReader()
            conn2.Close()

            Try
                Dim connString3 As String = ConfigurationManager.ConnectionStrings("dbc").ConnectionString
                Dim query2 As String = "UPDATE [Borrow] SET lateStatus = true WHERE Borrow_ID = " & borrowID & ""
                Dim conn3 As New OleDbConnection(connString3)
                Dim cmd3 As New OleDbCommand(query2, conn3)
                conn3.Open()
                Dim dr2 As OleDbDataReader = cmd3.ExecuteReader()

                conn3.Close()
            Catch ex2 As Exception
                MsgBox(ex2.Message)
            End Try
        End If

    End Sub

    Public Sub LateStatus()
        Try
            Dim dueDate As Date
            Dim dateNow As Date = System.DateTime.Today

            Dim connString As String = ConfigurationManager.ConnectionStrings("dbc").ConnectionString
            Dim sql As String
            sql = "SELECT Borrow_ID,dueDate FROM BORROW Where returnDate IS NULL"
            Using conn As New OleDbConnection(connString)
                Using cmd As New OleDbCommand(sql, conn)
                    conn.Open()
                    Dim reader As OleDbDataReader = cmd.ExecuteReader()
                    While reader.Read
                        dueDate = reader("dueDate")
                        Dim diff As System.TimeSpan = dateNow.Subtract(dueDate)
                        Dim diff1 As System.TimeSpan = dateNow - dueDate
                        Dim diff2 As Integer = (dateNow - dueDate).TotalDays
                        If diff2 > 0 Then
                            Dim id As Integer = reader("Borrow_ID")

                            updateLate(id, diff2)
                        End If
                    End While
                    conn.Close()
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub GetDataList(ic As String)
        Dim dtBook As New DataTable
        dtBook.Rows.Clear()
        Dim connString As String = ConfigurationManager.ConnectionStrings("dbc").ConnectionString
        Dim sql As String
        sql = "SELECT Book.ISBN,Book.yearPublication,Book.bookTitle,Book.author,Book.publisher_name,Borrow.issue_Date,Borrow.dueDate,Borrow.lateStatus,Late_Return_Fines.late_fines
                FROM (([Borrow] LEFT JOIN [Book]
                ON Borrow.Book_ID=Book.ISBN)
                LEFT JOIN [Late_Return_Fines]
                ON Borrow.Borrow_ID = Late_Return_Fines.borrowID)
                Where Borrow.Borrower_ID = '" & ic & "' AND Borrow.returnDate IS NULL"
        Try
            Using conn As New OleDbConnection(connString)
                Using cmd As New OleDbCommand(sql, conn)
                    conn.Open()
                    Dim reader As OleDbDataReader = cmd.ExecuteReader()
                    dtBook.Load(reader)
                    DataGridView1.DataSource = dtBook
                    conn.Close()
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub return_button_Click(sender As Object, e As EventArgs) Handles return_button.Click
        Me.Close()
        Menu_List.Visible = True

    End Sub

    Private Sub search_button_Click(sender As Object, e As EventArgs) Handles search_button.Click
        Dim command As OleDbCommand
        Dim query As String
        Dim datareader As OleDbDataReader
        DataGridView1.DataSource = ""
        query = "SELECT * FROM [Borrower] where Borrower_Name='" & SearchField.Text & "' "
        Dim connString2 As String = ConfigurationManager.ConnectionStrings("dbc").ConnectionString
        Dim connection As New OleDb.OleDbConnection(connString2)

        Try
            connection.Open()
            command = New OleDbCommand(query, connection)
            command.ExecuteNonQuery()
            datareader = command.ExecuteReader

            If datareader.Read Then
                TextBox1.Text = datareader("Borrower_Name")
                TextBox2.Text = datareader("IC")
                Dim ic As String = TextBox2.Text
                GetDataList(ic)
                connection.Close()
            End If

            For i As Integer = 0 To DataGridView1.Rows.Count() - 1 Step +1
                Dim check As Boolean = DataGridView1.Rows(i).Cells(8).Value
                If check = True Then
                    MessageBox.Show("Please Settle Your Fine First !", "Late Return", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Late_return.Show()
                    Me.Close()
                End If
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Book_Return_Click(sender As Object, e As EventArgs) Handles Book_Return.Click
        return_date.Show()
    End Sub
End Class