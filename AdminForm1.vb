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

    Private Sub btnBannedList_Click_1(sender As Object, e As EventArgs) Handles btnBannedList.Click
        Dim AdminForm3 As New AdminForm3
        AdminForm3.Show()
        Hide()
    End Sub

    Dim currentPic As PictureBox

    ' ==========================
    ' CLICK EVENT FOR PICTUREBOX2 TO PICTUREBOX8
    ' ==========================
    Private Sub PictureBox_Click(sender As Object, e As EventArgs) _
            Handles PictureBox2.Click, PictureBox3.Click, PictureBox4.Click

        currentPic = CType(sender, PictureBox)

        ' Show dialog options
        Dim answer = MessageBox.Show(
                "Choose an action:" & vbCrLf &
                "Yes = Add Photo" & vbCrLf &
                "No = Update Photo" & vbCrLf &
                "Cancel = Delete Photo",
                "Photo Options",
                MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Question)

        Select Case answer
            Case DialogResult.Yes
                AddPhoto()
            Case DialogResult.No
                UpdatePhoto()
            Case DialogResult.Cancel
                DeletePhoto()
        End Select

    End Sub

    ' ==========================
    ' ADD PHOTO
    ' ==========================
    Private Sub AddPhoto()
        OpenFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp"

        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            currentPic.Image = Image.FromFile(OpenFileDialog1.FileName)
        End If
    End Sub

    ' ==========================
    ' UPDATE PHOTO
    ' ==========================
    Private Sub UpdatePhoto()
        OpenFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp"

        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            currentPic.Image = Image.FromFile(OpenFileDialog1.FileName)
        End If
    End Sub

    ' ==========================
    ' DELETE PHOTO
    ' ==========================
    Private Sub DeletePhoto()
        currentPic.Image = Nothing
    End Sub

    Private Sub PnlSidebar_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub ComboBox4_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox4.SelectedIndexChanged
        CurrStocks1.Text = ComboBox4.Text
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        Dim value As Decimal
        If Decimal.TryParse(TextBox2.Text, value) Then
            priceS.Text = "₱" & value.ToString("N2")
        Else
            priceS.Text = ""
        End If
    End Sub
    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged
        Dim value As Decimal
        If Decimal.TryParse(TextBox4.Text, value) Then
            priceS2.Text = "₱" & value.ToString("N2")
        Else
            priceS2.Text = ""
        End If
    End Sub
    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs) Handles TextBox6.TextChanged
        Dim value As Decimal
        If Decimal.TryParse(TextBox6.Text, value) Then
            priceS3.Text = "₱" & value.ToString("N2")
        Else
            priceS3.Text = ""
        End If
    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox3.SelectedIndexChanged
        Label12.Text = ComboBox3.Text
    End Sub
    Private Sub ComboBox6_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox6.SelectedIndexChanged
        Label21.Text = ComboBox6.Text
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click

    End Sub
End Class
