Imports System.IO
Imports MySql.Data.MySqlClient
Imports Org.BouncyCastle.Asn1.Cmp

Public Class Form2
    Dim conn As New MySqlConnection("Server=192.168.1.1;Port=3306; Uid=prince_client;Pwd=;Database=db_rent")
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

    Private Sub LoadTools()
        Try
            conn.Open()

            Dim cmd As New MySqlCommand("SELECT Tool_ID, Stocks, Price, Tool_Name, is_Available, Tool_Image FROM tbl_tools ORDER BY Tool_ID ASC LIMIT 3", conn)
            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            Dim index As Integer = 0

            While reader.Read()
                Dim imgBytes() As Byte = CType(reader("Tool_Image"), Byte())
                Dim ms As New MemoryStream(imgBytes)
                Dim toolImg As Image = Image.FromStream(ms)

                Select Case index
                    Case 0  ' FIRST PANEL
                        PictureBox3.Image = toolImg
                        Label5.Text = reader("Stocks").ToString()
                        lblInfo.Text = reader("Tool_Name").ToString()
                        presyo.Text = reader("Price").ToString()
                        avail.Text = reader("is_Available").ToString()
                    Case 1  ' SECOND PANEL
                        PictureBox2.Image = toolImg
                        Label11.Text = reader("Stocks").ToString()
                        Label3.Text = reader("Tool_Name").ToString()
                        Label1.Text = reader("Price").ToString()
                        Label20.Text = reader("is_Available").ToString()
                    Case 2  ' THIRD PANEL
                        PictureBox4.Image = toolImg
                        Label14.Text = reader("Stocks").ToString()
                        Label9.Text = reader("Tool_Name").ToString()
                        Label7.Text = reader("Price").ToString()
                        Label27.Text = reader("is_Available").ToString()

                End Select

                index += 1
            End While

            reader.Close()
            conn.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub RemoveFromCart(itemName As String)
        For Each row As DataGridViewRow In dgvCart.Rows
            If row.Cells("colName").Value = itemName Then
                dgvCart.Rows.Remove(row)
                Exit Sub
            End If
        Next
    End Sub


    Private Sub btnRemove1_Click(sender As Object, e As EventArgs) Handles btnRemove1.Click
        RemoveFromCart(lblInfo.Text)
    End Sub

    Private Sub btnRemove2_Click(sender As Object, e As EventArgs) Handles btnRemove2.Click
        RemoveFromCart(Label3.Text)
    End Sub

    Private Sub btnRemove3_Click(sender As Object, e As EventArgs) Handles btnRemove3.Click
        RemoveFromCart(Label9.Text)
    End Sub


    Private Sub Button3_Click(sender As Object, e As EventArgs)
        Label17.Text = (CInt(Label17.Text) + 1).ToString
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)
        If Label17.Text > 0 Then
            Label17.Text = (CInt(Label17.Text) - 1).ToString
        Else
            MessageBox.Show("Quantity cannot be less than zero.")
        End If
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs)
        Label12.Text = (CInt(Label12.Text) + 1).ToString
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs)

        If Label12.Text > 0 Then
            Label12.Text = (CInt(Label12.Text) - 1).ToString
        Else
            MessageBox.Show("Quantity cannot be less than zero.")
        End If
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        LoadTools()
    End Sub
    Public Sub AddToCart(itemName As String, price As Double, qty As Integer)
        ' Check if item is already in cart
        For Each row As DataGridViewRow In dgvCart.Rows
            If row.Cells("colName").Value = itemName Then
                row.Cells("colQty").Value += qty
                Return
            End If
        Next

        ' Add new item to cart
        dgvCart.Rows.Add(itemName, price, qty)
    End Sub

    Private Sub btnAdd1_Click(sender As Object, e As EventArgs) Handles btnAdd1.Click

        AddToCart(lblInfo.Text, Val(presyo.Text), 1)
    End Sub

    Private Sub dgvCart_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCart.CellContentClick

    End Sub
    Private Sub btnAdd2_Click(sender As Object, e As EventArgs) Handles btnAdd2.Click

        AddToCart(Label3.Text, Val(Label1.Text), 1)
    End Sub
    Private Sub btnAdd3_Click(sender As Object, e As EventArgs) Handles btnAdd3.Click

        AddToCart(Label9.Text, Val(Label7.Text), 1)
    End Sub
End Class