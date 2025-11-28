Imports System.IO
Imports MySql.Data.MySqlClient
Imports Mysqlx.Crud
Public Class AdminForm1
    Dim MySqlConn As MySqlConnection
    Dim Command1 As MySqlCommand
    Dim Command2 As MySqlCommand
    Dim Command3 As MySqlCommand

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Enter.Click
        Dim Reader1 As MySqlDataReader
        Dim Reader2 As MySqlDataReader
        Dim Reader3 As MySqlDataReader


        MySqlConn = New MySqlConnection
        MySqlConn.ConnectionString = "Server=localhost;Port=3306;Database=db_rent;Uid=root;Pwd=;"



        Try
            MySqlConn.Open()
            Dim Query1 As String

            Query1 = "INSERT INTO db_rent.tbl_tools (Tool_Name, is_Available, Price, Stocks) values('" & LabelBox1.Text & "', '" & AvailabilityBox1.Text & "', '" & UpdatePriceBox1.Text & "', '" & UpdateStocksBox1.Text & "')"

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
            Query2 = "INSERT INTO db_rent.tbl_tools (Tool_Name, is_Available, Price, Stocks) values('" & LabelBox2.Text & "', '" & AvailabilityBox2.Text & "', '" & UpdatePriceBox2.Text & "', '" & UpdateStocksBox2.Text & "')"
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
            Query3 = "INSERT INTO db_rent.tbl_tools (Tool_Name, is_Available, Price, Stocks) values('" & LabelBox3.Text & "', '" & AvailabilityBox3.Text & "', '" & UpdatePriceBox3.Text & "', '" & UpdateStocksBox3.Text & "')"
            Command3 = New MySqlCommand(Query3, MySqlConn)
            Reader3 = Command3.ExecuteReader
            MySqlConn.Close()
            MessageBox.Show("Data Saved")
        Catch ex As Exception
            MessageBox.Show("Error in Query number 3")
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

End Class
