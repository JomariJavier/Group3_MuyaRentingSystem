Public Class AdminForm1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim scaleX As Single = Screen.PrimaryScreen.Bounds.Width / 1920.0F
        Dim scaleY As Single = Screen.PrimaryScreen.Bounds.Height / 1080.0F
        Me.Scale(New SizeF(scaleX, scaleY))
    End Sub

    Private Sub btnStocks_Click(sender As Object, e As EventArgs) Handles btnStocks.Click
        Dim AdminForm1 As New AdminForm1
        AdminForm1.Show()
        Hide()
    End Sub

    Private Sub btnHistory_Click(sender As Object, e As EventArgs) Handles btnHistory.Click
        Dim AdminForm2 As New AdminForm2
        AdminForm2.Show()
        Hide()
    End Sub

    Private Sub btnBannedList_Click(sender As Object, e As EventArgs) Handles btnBannedList.Click
        Dim AdminForm3 As New AdminForm3
        AdminForm3.Show()
        Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub
End Class