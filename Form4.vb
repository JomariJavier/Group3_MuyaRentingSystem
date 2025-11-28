Imports MySql.Data.MySqlClient

Public Class Form4
    Private Sub Button2_Click(sender As Object, e As EventArgs)

        Dim Form3 As New Form3
        Form3.Show()
        Hide()

    End Sub

    Private Sub PictureBox11_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        OpenFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif"

        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            PictureBox2.Image = Image.FromFile(OpenFileDialog1.FileName)
            PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        End If

    End Sub

    Private Sub Label21_Click(sender As Object, e As EventArgs) Handles Label21.Click
        Dim Form1 As New Form1
        Form1.Show()
        Hide()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Dim Form1 As New Form1
        Form1.Show()
        Hide()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Form5 As New Form5

        Dim conn As New MySqlConnection("Server=localhost;Port=3306;Uid=root;Pwd=;Database=db_rent;")
        Dim query As String = "INSERT INTO tbl_address (Subdivision_Building, Block, Street) VALUES (@Subdivision, @Block, @Street)"
        Dim cmd As New MySqlCommand(query, conn)

        cmd.Parameters.AddWithValue("@Subdivision", TextBox5.Text)
        cmd.Parameters.AddWithValue("@Block", TextBox6.Text)
        cmd.Parameters.AddWithValue("@Street", TextBox7.Text)

        Dim query2 As String = "INSERT INTO tbl_client (MobileNum, ReceiptientNum) VALUES (@Contact, @ReceiptientNum)"
        Dim cmd1 As New MySqlCommand(query2, conn)

        cmd1.Parameters.AddWithValue("@Contact", TextBox4.Text)
        cmd1.Parameters.AddWithValue("@ReceiptientNum", TextBox8.Text)

        conn.Open()
        cmd.ExecuteNonQuery()
        cmd1.ExecuteNonQuery()
        conn.Close()

        MsgBox("Record Saved!")
        Agreement.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        Dim Form3 As New Form3
        Form3.Show()
        Hide()
    End Sub

End Class