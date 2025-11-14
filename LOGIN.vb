Public Class LOGIN

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim username As String = TextBox1.Text
        Dim password As String = TextBox2.Text

        If username = "admin" AndAlso password = "1234" Then
            MessageBox.Show("Login successful!", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Dim mainForm As New AdminForm1()
            mainForm.Show()
            Me.Hide()
        Else
            MessageBox.Show("Invalid username or password.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub


    ' ===== USERNAME TEXTBOX =====
    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown

        ' ENTER key → go to password
        If e.KeyCode = Keys.Enter Then
            TextBox2.Focus()
            e.SuppressKeyPress = True
        End If

        ' ↓ Down Arrow → go to password
        If e.KeyCode = Keys.Down Then
            TextBox2.Focus()
            e.SuppressKeyPress = True
        End If

    End Sub


    ' ===== PASSWORD TEXTBOX =====
    Private Sub TextBox2_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox2.KeyDown

        ' ENTER key → click login button
        If e.KeyCode = Keys.Enter Then
            Button1.PerformClick()
            e.SuppressKeyPress = True
        End If

        ' ↑ Up Arrow → go back to username
        If e.KeyCode = Keys.Up Then
            TextBox1.Focus()
            e.SuppressKeyPress = True
        End If

    End Sub


    Private Sub LOGIN_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

End Class
