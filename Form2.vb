Imports MySql.Data.MySqlClient
Imports Org.BouncyCastle.Asn1.Cmp

Public Class Form2
    Public conn As New MySqlConnection("Server=192.168.1.1;Port=3306; Uid=prince_client;Database=db_rent;")
    Private Sub Label21_Click(sender As Object, e As EventArgs) Handles Label21.Click
        Dim Form1 As New Form1
        Form1.Show()
        Hide()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)
        Dim Form1 As New Form1
        Form1.Show()
        Hide()
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
        Try
            conn.Open()

            ' Load the newest added tool
            Dim cmd As New MySqlCommand("SELECT Stocks, Price, Tool_Name, is_Available FROM tbl_tools ORDER BY Tool_ID DESC LIMIT 1", conn)
            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            If reader.Read() Then
                Label5.Text = reader("Stocks").ToString()
                lblInfo.Text = reader("Tool_Name").ToString()
                presyo.Text = reader("Price").ToString()
                Label4.Text = reader("is_Available").ToString()
            End If

            reader.Close()
            conn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click

    End Sub

    Private Sub Label13_Click(sender As Object, e As EventArgs) Handles Label13.Click

    End Sub

    Private Sub Label14_Click(sender As Object, e As EventArgs) Handles Label14.Click

    End Sub



    Private Sub Label18_Click(sender As Object, e As EventArgs) Handles Label18.Click

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Label18.Text = (CInt(Label18.Text) + 1).ToString()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click


        If Label18.Text > 0 Then
            Label18.Text = (CInt(Label18.Text) - 1).ToString()
        Else
            MessageBox.Show("Quantity cannot be less than zero.")
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Label17.Text = (CInt(Label17.Text) + 1).ToString()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If Label17.Text > 0 Then
            Label17.Text = (CInt(Label17.Text) - 1).ToString()
        Else
            MessageBox.Show("Quantity cannot be less than zero.")
        End If
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Label12.Text = (CInt(Label12.Text) + 1).ToString()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click

        If Label12.Text > 0 Then
            Label12.Text = (CInt(Label12.Text) - 1).ToString()
        Else
            MessageBox.Show("Quantity cannot be less than zero.")
        End If
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class