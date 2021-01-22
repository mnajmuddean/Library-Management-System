Imports System.Configuration
Imports System.Data.OleDb
Public Class User_Information
    Private Sub UserBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.UserBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.LibraryDataSet)

    End Sub

    Private Sub User_Information_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'LibraryDataSet.User' table. You can move, or remove it, as needed.
        'Me.UserTableAdapter.Fill(Me.LibraryDataSet.User)
        Display_data()



    End Sub

    Private Sub Phone_NumberTextBox_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub UsernameTextBox_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim command As OleDbCommand
        Dim query As String

        query = "UPDATE [User] SET [Username]='" + TextBox1.Text + "' , [Staff_Name]= '" + TextBox2.Text + "',[Phone_Number]= '" + TextBox4.Text + "' WHERE [Staff_ID]= " + TextBox3.Text + " "
        Dim connString As String = ConfigurationManager.ConnectionStrings("dbc").ConnectionString
        Dim connection As New OleDb.OleDbConnection(connString)

        Try
            connection.Open()
            command = New OleDbCommand(query, connection)
            command.ExecuteNonQuery()
            MsgBox("User Updated!")
            command.Dispose()
            connection.Close()


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Display_data()
    End Sub

    Private Sub UserBindingSource_CurrentChanged(sender As Object, e As EventArgs) Handles UserBindingSource.CurrentChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Try

            Dim command As OleDbCommand
            Dim connString As String = ConfigurationManager.ConnectionStrings("dbc").ConnectionString
            Dim connection As New OleDb.OleDbConnection(connString)

            Dim selectedrow As String
            selectedrow = UserDataGridView.SelectedCells.Item(1).Value.ToString

            connection.Open()

            command = connection.CreateCommand
            command.CommandType = CommandType.Text
            Dim query1 As String = "DELETE * FROM [User] WHERE [Username]='" + TextBox12.Text + "'"
            command = New OleDbCommand(query1, connection)
            command.ExecuteNonQuery()

            MsgBox("User deleted")
            Display_data()

            TextBox6.Text = String.Empty
            TextBox7.Text = String.Empty
            TextBox8.Text = String.Empty
            TextBox9.Text = String.Empty
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub

    Private Sub UserDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub UserDataGridView_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles UserDataGridView.CellContentClick, UserDataGridView.CellClick

        Try

            Dim command As OleDbCommand
            Dim datareader As OleDbDataReader
            Dim connString As String = ConfigurationManager.ConnectionStrings("dbc").ConnectionString
            Dim connection As New OleDb.OleDbConnection(connString)

            Dim selectedrow As String
            selectedrow = UserDataGridView.SelectedCells.Item(1).Value.ToString

            connection.Open()

            command = connection.CreateCommand
            command.CommandType = CommandType.Text
            Dim query1 As String = "SELECT * FROM [User] WHERE [Staff_ID]=" + selectedrow + ""
            command = New OleDbCommand(query1, connection)
            command.ExecuteNonQuery()


            Dim dt As New DataTable
            Dim da As New OleDbDataAdapter(command)
            da.Fill(dt)
            datareader = command.ExecuteReader(CommandBehavior.CloseConnection)

            While datareader.Read
                TextBox10.Text = datareader.GetString(0).ToString
                'TextBox11.Text = datareader.GetString(1).ToString
                TextBox12.Text = datareader.GetString(3).ToString
                TextBox13.Text = datareader.GetString(2).ToString

            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try



    End Sub

    Public Sub Display_data()
        Dim command As OleDbCommand
        Dim query As String
        'Dim datareader As OleDbDataReader

        query = "SELECT * FROM [User] "
        Dim connString As String = ConfigurationManager.ConnectionStrings("dbc").ConnectionString
        Dim connection As New OleDb.OleDbConnection(connString)

        Try
            connection.Open()
            command = New OleDbCommand(query, connection)
            command.ExecuteNonQuery()
            Dim ds As DataSet = New DataSet
            Dim search As New OleDbDataAdapter(query, connection)
            search.Fill(ds, "User")
            UserDataGridView.DataSource = ds.Tables("User")
            connection.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs)
        Display_data()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        TextBox5.Text = String.Empty
        TextBox6.Text = String.Empty
        TextBox7.Text = String.Empty
        TextBox8.Text = String.Empty
        TextBox9.Text = String.Empty
    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        Display_data()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.Visible = False
        Menu_List.Visible = True
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim id As Integer
        Dim values As String = TextBox5.Text
        Dim result As Boolean = Integer.TryParse(TextBox5.Text, id)
        Dim command As OleDbCommand
        Dim query As String
        Dim datareader As OleDbDataReader

        query = "SELECT * FROM [User] where Username='" + TextBox5.Text + "' "
        Dim connString As String = ConfigurationManager.ConnectionStrings("dbc").ConnectionString
        Dim connection As New OleDb.OleDbConnection(connString)


        Try
            connection.Open()
            command = New OleDbCommand(query, connection)
            command.ExecuteNonQuery()
            datareader = command.ExecuteReader

            If datareader.Read Then

                TextBox6.Text = datareader("Staff_Name")
                TextBox7.Text = datareader("Staff_ID")
                TextBox8.Text = datareader("Username")
                TextBox9.Text = datareader("Phone_Number")

                connection.Close()
            Else
                MsgBox("No data!")

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click

    End Sub
End Class