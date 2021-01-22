Imports System.Configuration
Imports System.Data.OleDb
Public Class Form2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim command, command2 As OleDbCommand
        Dim query2, query1 As String
        Dim datareader As OleDbDataReader

        Dim connString As String = ConfigurationManager.ConnectionStrings("dbc").ConnectionString
        Dim connection As New OleDb.OleDbConnection(connString)
        connection.Open()

        query1 = "SELECT * FROM [User] where Username='" + TextBox1.Text + "'"
        command2 = New OleDbCommand(query1, connection)
        command2.Parameters.AddWithValue("Username", TextBox1)
        datareader = command2.ExecuteReader

        If datareader.HasRows Then
            MsgBox("Username you entered is already taken. Please enter other username.", MsgBoxStyle.Exclamation, "Add new user")
        Else
            query2 = "Insert into [User] ([Staff_Name],[Phone_Number],[Username],[Password]) values ('" & TextBox1.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "','" & TextBox5.Text & "')"

            command = New OleDbCommand(query2, connection)

            command.Parameters.Add(New OleDbParameter("Staff_Name", CType(TextBox1.Text, String)))
            command.Parameters.Add(New OleDbParameter("Phone_Number", CType(TextBox3.Text, String)))
            command.Parameters.Add(New OleDbParameter("Username", CType(TextBox4.Text, String)))
            command.Parameters.Add(New OleDbParameter("Password", CType(TextBox5.Text, String)))
            MsgBox("Data saved")

            Try
                command.ExecuteNonQuery()
                command.Dispose()
                connection.Close()
                TextBox1.Clear()
                TextBox3.Clear()
                TextBox4.Clear()
                TextBox5.Clear()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Visible = False
        StartUp.Visible = True
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class