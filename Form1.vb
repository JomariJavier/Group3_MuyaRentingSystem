Public Class Form1
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Dim Form2 As New Form2
        Form2.Show
        Hide

    End Sub

    Private Sub FlowLayoutPanel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub SidebarTimer_Tick(sender As Object, e As EventArgs) Handles SidebarTimer.Tick
        Dim sidebarExpanded As Boolean = True
        If sidebarExpanded Then
            PnlSidebar.Width -= 10
            If PnlSidebar.Width <= 60 Then
                sidebarExpanded = False
                SidebarTimer.Stop()
            End If
        Else
            PnlSidebar.Width += 10
            If PnlSidebar.Width >= 180 Then
                sidebarExpanded = True
                SidebarTimer.Stop()
            End If
        End If
    End Sub

    Private Sub btnToggle_Click(sender As Object, e As EventArgs) Handles btnToggle.Click
        SidebarTimer.Start()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub btnStocks_Click(sender As Object, e As EventArgs) Handles btnStocks.Click

    End Sub

    Private Sub btnHistory_Click(sender As Object, e As EventArgs) Handles btnHistory.Click
        Dim Form2 As New Form2
        Form2.Show()
        Me.Hide()

    End Sub

    Private Sub btnBannedList_Click(sender As Object, e As EventArgs) Handles btnBannedList.Click
        Dim Form6 As New Form6
        Form6.Show()
        Me.Hide()
    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click

    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click

    End Sub
End Class
