
Public Class Menu_List

    Private Sub Menu_List_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BookReturn_Form.LateStatus()
    End Sub

    Private Sub Book_Details_Click(sender As Object, e As EventArgs) Handles Book_Details.Click
        Book.Show()
        Me.Visible = False
    End Sub

    Private Sub exit_button_Click(sender As Object, e As EventArgs) Handles exit_button.Click
        Me.Close()
        StartupForm.Close()
    End Sub

    Private Sub book_return_Click(sender As Object, e As EventArgs) Handles book_return.Click
        BookReturn_Form.Visible = True
        Me.Visible = False
    End Sub

    Private Sub late_return_Click(sender As Object, e As EventArgs) Handles late_returnButton.Click
        Late_return.Visible = True
        Me.Visible = False
    End Sub

    Private Sub book_issue_Click(sender As Object, e As EventArgs) Handles book_issue.Click
        Book_IssueForm.Show()
        Me.Hide()
    End Sub

    Private Sub borrowersButton_Click(sender As Object, e As EventArgs) Handles borrowersButton.Click
        Borrowers.Visible = True
        Me.Visible = False

    End Sub

    Private Sub user_button_Click(sender As Object, e As EventArgs) Handles user_button.Click
        Me.Visible = False
        User_Information.Visible = True
    End Sub


End Class