Imports System.Configuration
Imports System.Data.OleDb

Public Class StartupForm


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim command As OleDbCommand
        Dim query As String
        Dim datareader As OleDbDataReader

        query = "SELECT * FROM [User] where Username='" + TextBox1.Text + "' And Password= '" + TextBox2.Text + "'"
        Dim connString As String = ConfigurationManager.ConnectionStrings("dbc").ConnectionString
        Dim connection As New OleDb.OleDbConnection(connString)

        Try
            connection.Open()
            command = New OleDbCommand(query, connection)
            command.ExecuteNonQuery()
            datareader = command.ExecuteReader

            If datareader.Read Then
                Menu_List.Visible = True
                Me.Visible = False
                Menu_List.ID_TextBox.Text = datareader("Staff_ID")
                Menu_List.Name_TextBox.Text = datareader("Staff_Name")
                Menu_List.Phone_TextBox.Text = datareader("Phone_Number")
                Menu_List.username_TextBox.Text = datareader("Username")

                User_Information.TextBox1.Text = datareader("Username")
                User_Information.TextBox2.Text = datareader("Staff_Name")
                User_Information.TextBox3.Text = datareader("Staff_ID")
                User_Information.TextBox4.Text = datareader("Phone_Number")

                connection.Close()
            Else
                MsgBox("You entered wrong username or password. Make sure your capslock is off.")

            End If
        Catch ex As Exception
            MsgBox("NOT CONNECTED")
        End Try

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)

        Me.Visible = False
        Form2.Visible = True
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        StartUp.Show()
    End Sub
End Class
