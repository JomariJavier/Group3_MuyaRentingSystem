Imports System.IO
Imports MySql.Data.MySqlClient

Public Class Form4

    ' ==========================
    '  IMAGE UPLOAD BUTTON
    ' ==========================
    Private Sub PictureBox11_Click(sender As Object, e As EventArgs) Handles PictureBox11.Click
        Dim ofd As New OpenFileDialog With {
            .Title = "Select an Image",
            .Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif",
            .Multiselect = False
        }

        If ofd.ShowDialog() = DialogResult.OK Then
            Try
                PictureBox11.Image = Image.FromFile(ofd.FileName)
                PictureBox11.SizeMode = PictureBoxSizeMode.Zoom
            Catch ex As Exception
                MessageBox.Show("Unable to load image: " & ex.Message)
            End Try
        End If
    End Sub



    ' ==========================
    '  SAVE CLIENT + ADDRESS
    ' ==========================
    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Dim conn As New MySqlConnection("Server=localhost;Port=3306;Uid=root;Pwd=;Database=db_rent;")

        Try
            conn.Open()

            ' 1. INSERT ADDRESS -----------------------
            Dim addressID As Integer
            Dim qAddress As String = "INSERT INTO tbl_address (Street, Block, Lot) 
                                      VALUES (@Street, @Block, @Lot)"

            Using cmd As New MySqlCommand(qAddress, conn)
                cmd.Parameters.AddWithValue("@Street", TextBox5.Text)
                cmd.Parameters.AddWithValue("@Block", TextBox6.Text)
                cmd.Parameters.AddWithValue("@Lot", TextBox7.Text)
                cmd.ExecuteNonQuery()
            End Using

            ' Retrieve inserted Address_ID
            Using cmd As New MySqlCommand("SELECT LAST_INSERT_ID()", conn)
                addressID = Convert.ToInt32(cmd.ExecuteScalar())
            End Using



            ' 2. INSERT CLIENT ------------------------
            Dim clientID As Integer
            Dim qClient As String =
                "INSERT INTO tbl_client 
                 (Address_ID, FirstName, MiddleName, LastName, MobileNum, ReceiptientNum) 
                 VALUES 
                 (@Address_ID, @FirstName, @MiddleName, @LastName, @Mobile, @Receiptient)"

            Using cmd As New MySqlCommand(qClient, conn)
                cmd.Parameters.AddWithValue("@Address_ID", addressID)
                cmd.Parameters.AddWithValue("@FirstName", TextBox1.Text)
                cmd.Parameters.AddWithValue("@MiddleName", TextBox2.Text)
                cmd.Parameters.AddWithValue("@LastName", TextBox3.Text)
                cmd.Parameters.AddWithValue("@Mobile", TextBox4.Text)
                cmd.Parameters.AddWithValue("@Receiptient", TextBox8.Text)
                cmd.ExecuteNonQuery()
            End Using

            ' Retrieve inserted Client_ID
            Using cmd As New MySqlCommand("SELECT LAST_INSERT_ID()", conn)
                clientID = Convert.ToInt32(cmd.ExecuteScalar())
            End Using



            ' 3. SAVE CLIENT PHOTO --------------------
            If PictureBox11.Image IsNot Nothing Then

                Using ms As New MemoryStream()
                    PictureBox11.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg)
                    Dim imgBytes As Byte() = ms.ToArray()

                    Dim qPhoto As String = "UPDATE tbl_client SET Picture=@photo WHERE Client_ID=@id"
                    Using cmd As New MySqlCommand(qPhoto, conn)
                        cmd.Parameters.AddWithValue("@photo", imgBytes)
                        cmd.Parameters.AddWithValue("@id", clientID)

                        Dim rows = cmd.ExecuteNonQuery()
                        MessageBox.Show("Photo saved. Rows affected: " & rows)
                    End Using
                End Using

            End If



            ' DONE ------------------------------------
            MessageBox.Show("Record Saved Successfully!")

            Agreement.Show()
            Me.Hide()

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)

        Finally
            conn.Close()
        End Try
    End Sub



    ' ==========================
    '  BACK BUTTON
    ' ==========================
    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        Dim Form3 As New Form3
        Form3.Show()
        Me.Hide()
    End Sub

End Class

