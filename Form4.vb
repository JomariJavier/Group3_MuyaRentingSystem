Imports System.IO
Imports MySql.Data.MySqlClient
Imports OpenCvSharp
Imports OpenCvSharp.Extensions

Public Class Form4
    Private capture As VideoCapture
    Private timer As New Timer()

    ' --- FORM LOAD ---
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        capture = New VideoCapture(0) ' 0 = first webcam
        If Not capture.IsOpened() Then
            MessageBox.Show("No webcam found.")
            Return
        End If

        timer.Interval = 30 ' ~30 FPS
        AddHandler timer.Tick, AddressOf Timer_Tick
        timer.Start()
    End Sub

    ' --- WEBCAM NEW FRAME ---
    Private Sub Timer_Tick(sender As Object, e As EventArgs)
        Using mat As New Mat()
            capture.Read(mat)
            If Not mat.Empty() Then
                PictureBox11.Image?.Dispose()
                PictureBox11.Image = mat.ToBitmap()
            End If
        End Using
    End Sub

    ' --- FORM CLOSING ---
    Private Sub Form4_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        timer.Stop()
        capture.Release()
    End Sub

    ' --- INSERT CLIENT & ADDRESS DATA ---
    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Dim conn As New MySqlConnection("Server=localhost;Port=3306;Uid=root;Pwd=;Database=db_rent;")
        conn.Open()

        Try
            ' Insert Address
            Dim queryAddress As String = "INSERT INTO tbl_address (Subdivision_Building, Block, Street) VALUES (@Subdivision, @Block, @Street)"
            Using cmd As New MySqlCommand(queryAddress, conn)
                cmd.Parameters.AddWithValue("@Subdivision", TextBox5.Text)
                cmd.Parameters.AddWithValue("@Block", TextBox6.Text)
                cmd.Parameters.AddWithValue("@Street", TextBox7.Text)
                cmd.ExecuteNonQuery()
            End Using

            ' Insert Client
            Dim queryClient As String = "INSERT INTO tbl_client (MobileNum, ReceiptientNum) VALUES (@Contact, @ReceiptientNum)"
            Using cmd As New MySqlCommand(queryClient, conn)
                cmd.Parameters.AddWithValue("@Contact", TextBox4.Text)
                cmd.Parameters.AddWithValue("@ReceiptientNum", TextBox8.Text)
                cmd.ExecuteNonQuery()
            End Using

            ' Get the last inserted ClientID
            Dim clientID As Integer
            Using cmd As New MySqlCommand("SELECT LAST_INSERT_ID()", conn)
                clientID = Convert.ToInt32(cmd.ExecuteScalar())
            End Using

            ' Save photo if available
            If PictureBox11.Image IsNot Nothing Then
                Using ms As New MemoryStream()
                    PictureBox11.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg)
                    Dim imgBytes() As Byte = ms.ToArray()

                    Dim queryPhoto As String = "UPDATE tbl_client SET Picture=@photo WHERE ClientID=@id"
                    Using cmd As New MySqlCommand(queryPhoto, conn)
                        cmd.Parameters.AddWithValue("@photo", imgBytes)
                        cmd.Parameters.AddWithValue("@id", clientID)
                        cmd.ExecuteNonQuery()
                    End Using
                End Using
            End If

            MessageBox.Show("Record Saved!")
            Agreement.Show()
            Me.Hide()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    ' --- CAPTURE BUTTON (OPTIONAL) ---
    Private Sub btnCapture_Click(sender As Object, e As EventArgs) Handles btnCapture.Click
        If PictureBox11.Image Is Nothing Then
            MessageBox.Show("No image to capture.")
            Return
        End If

        ' Photo is already captured in PictureBox11
        MessageBox.Show("Photo ready to save with the client record!")
    End Sub

    ' --- NAVIGATION BUTTON ---
    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        Dim Form3 As New Form3
        Form3.Show()
        Me.Hide()
    End Sub

End Class
