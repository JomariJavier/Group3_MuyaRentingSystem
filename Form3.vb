Imports MySql.Data.MySqlClient

Public Class Form3
    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        Dim con As New MySqlConnection("Server=localhost;Port=3306;Uid=root;Pwd=;Database=db_rent")
        con.Open()

        For Each row As DataGridViewRow In dgvConfirm.Rows
            If Not row.IsNewRow Then

                ' SAFETY CHECK ✔️
                If row.Cells("colName").Value Is Nothing OrElse row.Cells("colQty").Value Is Nothing Then
                    Continue For
                End If

                Dim toolName As String = row.Cells("colName").Value.ToString()
                Dim qty As Integer = CInt(row.Cells("colQty").Value)

                Dim cmd As New MySqlCommand("
                UPDATE tbl_tools 
                SET Stocks = Stocks - @qty 
                WHERE tool_name = @name
            ", con)

                cmd.Parameters.AddWithValue("@qty", qty)
                cmd.Parameters.AddWithValue("@name", toolName)

                cmd.ExecuteNonQuery()
            End If
        Next

        con.Close()

        MessageBox.Show("Rental confirmed! Stock updated.")

        ' 👉 After confirming, open Form4
        Dim f4 As New Form4
        f4.Show()

        ' 👉 Close Form3
        Me.Close()
    End Sub



    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)
        Dim Form1 As New Form1
        Form1.Show()
        Hide()
    End Sub

    Private Sub Label21_Click(sender As Object, e As EventArgs)
        Dim Form1 As New Form1
        Form1.Show()
        Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim Form2 As New Form2
        Form2.Show()
        Hide()
    End Sub

    Private Sub CalculateTotalPrice()
        If dtReturn.Value.Date < dtBorrow.Value.Date Then
            MessageBox.Show("Return date cannot be earlier than borrow date.")
            Exit Sub
        End If

        Dim days As Integer = (dtReturn.Value.Date - dtBorrow.Value.Date).TotalDays

        If days = 0 Then days = 1 ' Minimum 1 day rent

        Dim total As Decimal = 0D

        ' Add price for each item in the cart
        For Each row As DataGridViewRow In dgvConfirm.Rows
            If Not row.IsNewRow Then
                Dim price As Decimal = CDec(row.Cells("colPrice").Value)
                Dim qty As Integer = CInt(row.Cells("colQty").Value)

                total += (price * qty * days)
            End If
        Next

        txtTotalPrice.Text = total.ToString("0.00")

    End Sub

    Private Sub dtBorrow_ValueChanged(sender As Object, e As EventArgs) Handles dtBorrow.ValueChanged
        CalculateTotalPrice()
    End Sub

    Private Sub dtReturn_ValueChanged(sender As Object, e As EventArgs) Handles dtReturn.ValueChanged
        CalculateTotalPrice()
    End Sub

End Class