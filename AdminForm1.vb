Imports System.IO
Imports MySql.Data.MySqlClient
Imports Mysqlx
Imports Mysqlx.Crud
Public Class AdminForm1
    Dim MySqlConn As MySqlConnection
    Dim Command1 As MySqlCommand
    Dim Command2 As MySqlCommand
    Dim Command3 As MySqlCommand
    Dim cmd As MySqlCommand

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Enter.Click
        Dim Reader1 As MySqlDataReader
        Dim Reader2 As MySqlDataReader
        Dim Reader3 As MySqlDataReader
        Dim isEmpty1 As Boolean = String.IsNullOrEmpty(LabelBox1.Text) Or String.IsNullOrEmpty(AvailabilityBox1.Text) Or String.IsNullOrEmpty(UpdatePriceBox1.Text) Or String.IsNullOrEmpty(UpdateStocksBox1.Text)
        MySqlConn = New MySqlConnection
        MySqlConn.ConnectionString = "Server=localhost;Port=3306;Database=db_rent;Uid=root;Pwd=;"

        Dim imgData() As Byte
        Using ms As New MemoryStream()
            PictureBox2.Image.Save(ms, PictureBox2.Image.RawFormat)
            imgData = ms.ToArray()
        End Using
        Dim imgData2() As Byte
        Using ms As New MemoryStream()
            PictureBox3.Image.Save(ms, PictureBox3.Image.RawFormat)
            imgData2 = ms.ToArray()
        End Using
        Dim imgData3() As Byte
        Using ms As New MemoryStream()
            PictureBox4.Image.Save(ms, PictureBox4.Image.RawFormat)
            imgData3 = ms.ToArray()
        End Using
        Dim ImageQuery As String = "INSERT INTO tbl_tools (Tool_Image) VALUES (@img);"

        If isEmpty1 Then
            MessageBox.Show("There are incomplete fields, please add them")
        Else
            Try
                MySqlConn.Open()

                Dim Query1 As String = "INSERT INTO db_rent.tbl_tools 
                            (Tool_Name, is_Available, Price, Stocks, Tool_Image) 
                            VALUES (@name, @avail, @price, @stocks, @img)"

                Dim cmd As New MySqlCommand(Query1, MySqlConn)

                ' Add text values
                cmd.Parameters.AddWithValue("@name", LabelBox1.Text)
                cmd.Parameters.AddWithValue("@avail", AvailabilityBox1.Text)
                cmd.Parameters.AddWithValue("@price", UpdatePriceBox1.Text)
                cmd.Parameters.AddWithValue("@stocks", UpdateStocksBox1.Text)

                ' Add image blob
                cmd.Parameters.Add("@img", MySqlDbType.Blob).Value = imgData

                cmd.ExecuteNonQuery()
                MySqlConn.Close()

            Catch ex As Exception
                MessageBox.Show("Error in Query number 1: " & ex.Message)
                MySqlConn.Close()
            End Try

        End If

        Try
            MySqlConn.Open()

            Dim Query2 As String = "INSERT INTO db_rent.tbl_tools 
                            (Tool_Name, is_Available, Price, Stocks, Tool_Image) 
                            VALUES (@name, @avail, @price, @stocks, @img)"

            Dim cmd2 As New MySqlCommand(Query2, MySqlConn)

            ' Add text values
            cmd2.Parameters.AddWithValue("@name", LabelBox2.Text)
            cmd2.Parameters.AddWithValue("@avail", AvailabilityBox2.Text)
            cmd2.Parameters.AddWithValue("@price", UpdatePriceBox2.Text)
            cmd2.Parameters.AddWithValue("@stocks", UpdateStocksBox2.Text)

            ' Add image blob
            cmd2.Parameters.Add("@img", MySqlDbType.Blob).Value = imgData2

            cmd2.ExecuteNonQuery()
            MySqlConn.Close()

        Catch ex As Exception
            MessageBox.Show("Error in Query number 2: " & ex.Message)
            MySqlConn.Close()
        End Try

        Try
            MySqlConn.Open()

            Dim Query3 As String = "INSERT INTO db_rent.tbl_tools 
                            (Tool_Name, is_Available, Price, Stocks, Tool_Image) 
                            VALUES (@name, @avail, @price, @stocks, @img)"

            Dim cmd3 As New MySqlCommand(Query3, MySqlConn)

            ' Add text values
            cmd3.Parameters.AddWithValue("@name", LabelBox3.Text)
            cmd3.Parameters.AddWithValue("@avail", AvailabilityBox3.Text)
            cmd3.Parameters.AddWithValue("@price", UpdatePriceBox3.Text)
            cmd3.Parameters.AddWithValue("@stocks", UpdateStocksBox3.Text)

            ' Add image blob
            cmd3.Parameters.Add("@img", MySqlDbType.Blob).Value = imgData3

            cmd3.ExecuteNonQuery()
            MySqlConn.Close()

        Catch ex As Exception
            MessageBox.Show("Error in Query number 3: " & ex.Message)
            MySqlConn.Close()
        End Try
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Update.Click
        Dim Reader1 As MySqlDataReader
        Dim Reader2 As MySqlDataReader
        Dim Reader3 As MySqlDataReader

        MySqlConn = New MySqlConnection
        MySqlConn.ConnectionString = "Server=localhost;Port=3306;Database=db_rent;Uid=root;Pwd=;"
        Try
            MySqlConn.Open()
            Dim Query1 As String

            Query1 = "update db_rent.tbl_tools set Tool_Name='" & LabelBox1.Text & "', is_Available='" & AvailabilityBox1.Text & "', Price='" & UpdatePriceBox1.Text & "', Stocks='" & UpdateStocksBox1.Text & "' WHERE Tool_Name ='" & LabelBox1.Text & "'"

            Command1 = New MySqlCommand(Query1, MySqlConn)

            Reader1 = Command1.ExecuteReader


            MySqlConn.Close()
        Catch ex As Exception
            MessageBox.Show("Error in Query number 1")
            MySqlConn.Close()
        End Try
        Try
            MySqlConn.Open()
            Dim Query2 As String

            Query2 = "update db_rent.tbl_tools set Tool_Name='" & LabelBox2.Text & "', is_Available='" & AvailabilityBox2.Text & "', Price='" & UpdatePriceBox2.Text & "', Stocks='" & UpdateStocksBox2.Text & "' WHERE Tool_Name ='" & LabelBox2.Text & "'"

            Command2 = New MySqlCommand(Query2, MySqlConn)

            Reader2 = Command2.ExecuteReader

            MySqlConn.Close()
        Catch ex As Exception
            MessageBox.Show("Error in Query number 1")
            MySqlConn.Close()
        End Try
        Try
            MySqlConn.Open()
            Dim Query3 As String

            Query3 = "update db_rent.tbl_tools set Tool_Name='" & LabelBox3.Text & "', is_Available='" & AvailabilityBox3.Text & "', Price='" & UpdatePriceBox3.Text & "', Stocks='" & UpdateStocksBox3.Text & "' WHERE Tool_Name ='" & LabelBox3.Text & "'"

            Command3 = New MySqlCommand(Query3, MySqlConn)

            Reader3 = Command3.ExecuteReader

            MySqlConn.Close()
            MessageBox.Show("Data Updated")
        Catch ex As Exception
            MessageBox.Show("Error in Query number 1")
            MySqlConn.Close()
        End Try

    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Delete.Click
        Dim Reader1 As MySqlDataReader
        Dim Reader2 As MySqlDataReader
        Dim Reader3 As MySqlDataReader
        MySqlConn = New MySqlConnection
        MySqlConn.ConnectionString = "Server=localhost;Port=3306;Database=db_rent;Uid=root;Pwd=;"
        Try
            MySqlConn.Open()
            Dim Query1 As String

            Query1 = "DELETE from db_rent.tbl_tools where Tool_Name='" & LabelBox1.Text & "'"
            Command1 = New MySqlCommand(Query1, MySqlConn)

            Reader1 = Command1.ExecuteReader

            MySqlConn.Close()
        Catch ex As Exception
            MessageBox.Show("Error in Query number 1")
            MySqlConn.Close()
        End Try
        Try
            MySqlConn.Open()
            Dim Query2 As String

            Query2 = "DELETE from db_rent.tbl_tools where Tool_Name='" & LabelBox1.Text & "'"
            Command2 = New MySqlCommand(Query2, MySqlConn)

            Reader2 = Command2.ExecuteReader

            MySqlConn.Close()
        Catch ex As Exception
            MessageBox.Show("Error in Query number 2")
            MySqlConn.Close()
        End Try
        Try
            MySqlConn.Open()
            Dim Query3 As String

            Query3 = "DELETE from db_rent.tbl_tools where Tool_Name='" & LabelBox1.Text & "'"
            Command3 = New MySqlCommand(Query3, MySqlConn)

            Reader3 = Command1.ExecuteReader
            MessageBox.Show("Succesfully deleted")
            MySqlConn.Close()
        Catch ex As Exception
            MessageBox.Show("Error in Query number 3")
            MySqlConn.Close()
        End Try
    End Sub
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

    Private Sub ComboBox4_SelectedIndexChanged(sender As Object, e As EventArgs) Handles UpdateStocksBox1.SelectedIndexChanged
        CurrentStocks1.Text = UpdateStocksBox1.Text
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles UpdatePriceBox1.TextChanged
        Dim value As Decimal
        If Decimal.TryParse(UpdatePriceBox1.Text, value) Then
            Price1.Text = "₱" & value.ToString("N2")
        Else
            Price1.Text = ""
        End If
    End Sub
    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles UpdatePriceBox2.TextChanged
        Dim value As Decimal
        If Decimal.TryParse(UpdatePriceBox2.Text, value) Then
            Price2.Text = "₱" & value.ToString("N2")
        Else
            Price2.Text = ""
        End If
    End Sub
    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs) Handles UpdatePriceBox3.TextChanged
        Dim value As Decimal
        If Decimal.TryParse(UpdatePriceBox3.Text, value) Then
            Price3.Text = "₱" & value.ToString("N2")
        Else
            Price3.Text = ""
        End If
    End Sub
    Private Sub ComboBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles UpdateStocksBox2.SelectedIndexChanged
        CurrentStocks2.Text = UpdateStocksBox2.Text
    End Sub
    Private Sub ComboBox6_SelectedIndexChanged(sender As Object, e As EventArgs) Handles UpdateStocksBox3.SelectedIndexChanged
        CurrentStocks3.Text = UpdateStocksBox3.Text
    End Sub

    Private Sub Cancel_Click(sender As Object, e As EventArgs) Handles Cancel.Click
        MessageBox.Show(" The Operation is canceled")
    End Sub

    Private Sub PnlSidebar_Paint(sender As Object, e As PaintEventArgs) Handles PnlSidebar.Paint

    End Sub
End Class
