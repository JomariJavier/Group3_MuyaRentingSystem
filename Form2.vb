Public Class Form2
    Private Sub Label21_Click(sender As Object, e As EventArgs) Handles Label21.Click
        Dim Form1 As New Form1
        Form1.Show()
        Hide()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)
        Dim Form1 As New Form1
        Form1.Show
        Hide
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim Form1 As New Form1
        Form1.Show()
        Hide()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Form3 As New Form3
        Form3.Show()
        Hide()
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class