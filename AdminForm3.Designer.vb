<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminForm3
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        TextBox1 = New TextBox()
        Label7 = New Label()
        Label3 = New Label()
        Button2 = New Button()
        TableLayoutPanel2 = New TableLayoutPanel()
        Button1 = New Button()
        PnlSidebar = New Panel()
        PictureBox1 = New PictureBox()
        btnBannedList = New Button()
        btnHistory = New Button()
        btnStocks = New Button()
        Label26 = New Label()
        Label1 = New Label()
        Label2 = New Label()
        TableLayoutPanel1 = New TableLayoutPanel()
        Breason5 = New Label()
        Breason4 = New Label()
        Breason3 = New Label()
        Breason2 = New Label()
        Breason1 = New Label()
        Badd1 = New Label()
        Bname1 = New Label()
        Bname2 = New Label()
        Bname3 = New Label()
        Bname4 = New Label()
        Bname5 = New Label()
        Badd2 = New Label()
        Badd3 = New Label()
        Badd4 = New Label()
        Badd5 = New Label()
        TableLayoutPanel2.SuspendLayout()
        PnlSidebar.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        TableLayoutPanel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' TextBox1
        ' 
        TextBox1.BackColor = SystemColors.HighlightText
        TextBox1.Location = New Point(401, 85)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(318, 23)
        TextBox1.TabIndex = 22
        ' 
        ' Label7
        ' 
        Label7.Anchor = AnchorStyles.Top
        Label7.AutoSize = True
        Label7.BackColor = Color.Transparent
        Label7.Font = New Font("Arial Black", 26.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = Color.GhostWhite
        Label7.Location = New Point(546, 15)
        Label7.Margin = New Padding(0, 15, 0, 0)
        Label7.Name = "Label7"
        Label7.Size = New Size(284, 50)
        Label7.TabIndex = 79
        Label7.Text = "BANNED LIST"
        Label7.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.Top
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Arial Black", 9.75F, FontStyle.Bold)
        Label3.ForeColor = Color.White
        Label3.Location = New Point(211, 87)
        Label3.Margin = New Padding(100, 5, 0, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(75, 18)
        Label3.TabIndex = 80
        Label3.Text = "SEARCH :"
        Label3.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.White
        Button2.FlatStyle = FlatStyle.System
        Button2.Font = New Font("Arial Black", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button2.ForeColor = Color.Red
        Button2.Location = New Point(1214, 82)
        Button2.Margin = New Padding(0)
        Button2.Name = "Button2"
        Button2.Size = New Size(86, 37)
        Button2.TabIndex = 82
        Button2.Text = "ADD BAN"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' TableLayoutPanel2
        ' 
        TableLayoutPanel2.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        TableLayoutPanel2.BackColor = Color.Transparent
        TableLayoutPanel2.ColumnCount = 4
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 28.9540825F))
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 42.2193871F))
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 17.2193871F))
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 11.4795914F))
        TableLayoutPanel2.Controls.Add(Label3, 0, 1)
        TableLayoutPanel2.Controls.Add(TextBox1, 1, 1)
        TableLayoutPanel2.Controls.Add(Button1, 2, 1)
        TableLayoutPanel2.Controls.Add(Button2, 3, 1)
        TableLayoutPanel2.Controls.Add(Label7, 1, 0)
        TableLayoutPanel2.Location = New Point(183, 78)
        TableLayoutPanel2.Name = "TableLayoutPanel2"
        TableLayoutPanel2.RowCount = 2
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Absolute, 37F))
        TableLayoutPanel2.Size = New Size(1374, 119)
        TableLayoutPanel2.TabIndex = 100
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.White
        Button1.FlatStyle = FlatStyle.System
        Button1.Font = New Font("Arial Black", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = Color.Red
        Button1.Location = New Point(978, 84)
        Button1.Margin = New Padding(0, 2, 0, 0)
        Button1.Name = "Button1"
        Button1.Size = New Size(78, 26)
        Button1.TabIndex = 83
        Button1.Text = "ENTER"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' PnlSidebar
        ' 
        PnlSidebar.BackColor = SystemColors.ControlDarkDark
        PnlSidebar.Controls.Add(PictureBox1)
        PnlSidebar.Controls.Add(btnBannedList)
        PnlSidebar.Controls.Add(btnHistory)
        PnlSidebar.Controls.Add(btnStocks)
        PnlSidebar.Dock = DockStyle.Left
        PnlSidebar.ForeColor = Color.White
        PnlSidebar.Location = New Point(0, 0)
        PnlSidebar.Name = "PnlSidebar"
        PnlSidebar.Size = New Size(164, 640)
        PnlSidebar.TabIndex = 103
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = SystemColors.ControlDarkDark
        PictureBox1.Cursor = Cursors.Hand
        PictureBox1.Image = My.Resources.Resources._576101383_1180382820892530_8501663318516642353_n_removebg_preview1
        PictureBox1.Location = New Point(17, 16)
        PictureBox1.Margin = New Padding(25, 9, 0, 3)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(122, 94)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 3
        PictureBox1.TabStop = False
        ' 
        ' btnBannedList
        ' 
        btnBannedList.BackColor = Color.Transparent
        btnBannedList.Cursor = Cursors.Hand
        btnBannedList.FlatStyle = FlatStyle.Flat
        btnBannedList.Font = New Font("Arial Black", 9.75F, FontStyle.Bold)
        btnBannedList.ForeColor = Color.White
        btnBannedList.Location = New Point(25, 277)
        btnBannedList.Name = "btnBannedList"
        btnBannedList.Size = New Size(114, 37)
        btnBannedList.TabIndex = 6
        btnBannedList.Text = "Banned List"
        btnBannedList.UseVisualStyleBackColor = False
        ' 
        ' btnHistory
        ' 
        btnHistory.BackColor = Color.Transparent
        btnHistory.Cursor = Cursors.Hand
        btnHistory.FlatStyle = FlatStyle.Flat
        btnHistory.Font = New Font("Arial Black", 9.75F, FontStyle.Bold)
        btnHistory.ForeColor = Color.White
        btnHistory.Location = New Point(25, 215)
        btnHistory.Name = "btnHistory"
        btnHistory.Size = New Size(114, 33)
        btnHistory.TabIndex = 5
        btnHistory.Text = "History"
        btnHistory.UseVisualStyleBackColor = False
        ' 
        ' btnStocks
        ' 
        btnStocks.BackColor = Color.Transparent
        btnStocks.Cursor = Cursors.Hand
        btnStocks.FlatStyle = FlatStyle.Flat
        btnStocks.Font = New Font("Arial Black", 9.75F, FontStyle.Bold)
        btnStocks.ForeColor = Color.White
        btnStocks.Location = New Point(25, 147)
        btnStocks.Name = "btnStocks"
        btnStocks.Size = New Size(114, 34)
        btnStocks.TabIndex = 4
        btnStocks.Text = "Stocks"
        btnStocks.UseVisualStyleBackColor = False
        ' 
        ' Label26
        ' 
        Label26.Anchor = AnchorStyles.Top
        Label26.AutoSize = True
        Label26.BackColor = Color.Transparent
        Label26.Font = New Font("Arial Black", 9.75F, FontStyle.Bold)
        Label26.ForeColor = Color.Black
        Label26.Location = New Point(204, 15)
        Label26.Margin = New Padding(0, 15, 0, 0)
        Label26.Name = "Label26"
        Label26.Size = New Size(50, 18)
        Label26.TabIndex = 72
        Label26.Text = "NAME"
        Label26.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Top
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Arial Black", 9.75F, FontStyle.Bold)
        Label1.ForeColor = Color.Black
        Label1.Location = New Point(649, 15)
        Label1.Margin = New Padding(0, 15, 0, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(75, 18)
        Label1.TabIndex = 73
        Label1.Text = "ADDRESS"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Top
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Arial Black", 9.75F, FontStyle.Bold)
        Label2.ForeColor = Color.Black
        Label2.Location = New Point(1111, 15)
        Label2.Margin = New Padding(0, 15, 0, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(68, 18)
        Label2.TabIndex = 74
        Label2.Text = "REASON"
        Label2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        TableLayoutPanel1.BackColor = SystemColors.ScrollBar
        TableLayoutPanel1.ColumnCount = 3
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.3333321F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.3333321F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.3333321F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 20F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 20F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 20F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 20F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 20F))
        TableLayoutPanel1.Controls.Add(Breason5, 2, 5)
        TableLayoutPanel1.Controls.Add(Breason4, 2, 4)
        TableLayoutPanel1.Controls.Add(Breason3, 2, 3)
        TableLayoutPanel1.Controls.Add(Breason2, 2, 2)
        TableLayoutPanel1.Controls.Add(Breason1, 2, 1)
        TableLayoutPanel1.Controls.Add(Badd1, 1, 1)
        TableLayoutPanel1.Controls.Add(Bname1, 0, 1)
        TableLayoutPanel1.Controls.Add(Label2, 2, 0)
        TableLayoutPanel1.Controls.Add(Label1, 1, 0)
        TableLayoutPanel1.Controls.Add(Label26, 0, 0)
        TableLayoutPanel1.Controls.Add(Bname2, 0, 2)
        TableLayoutPanel1.Controls.Add(Bname3, 0, 3)
        TableLayoutPanel1.Controls.Add(Bname4, 0, 4)
        TableLayoutPanel1.Controls.Add(Bname5, 0, 5)
        TableLayoutPanel1.Controls.Add(Badd2, 1, 2)
        TableLayoutPanel1.Controls.Add(Badd3, 1, 3)
        TableLayoutPanel1.Controls.Add(Badd4, 1, 4)
        TableLayoutPanel1.Controls.Add(Badd5, 1, 5)
        TableLayoutPanel1.Location = New Point(180, 203)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 6
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 16.666666F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 16.8377819F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 16.4271049F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 16.666666F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 16.666666F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 16.666666F))
        TableLayoutPanel1.Size = New Size(1374, 365)
        TableLayoutPanel1.TabIndex = 78
        ' 
        ' Breason5
        ' 
        Breason5.Anchor = AnchorStyles.Top
        Breason5.AutoSize = True
        Breason5.BackColor = Color.FloralWhite
        Breason5.Font = New Font("Arial", 7.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Breason5.Location = New Point(1138, 309)
        Breason5.Margin = New Padding(3, 8, 3, 0)
        Breason5.Name = "Breason5"
        Breason5.Size = New Size(13, 14)
        Breason5.TabIndex = 89
        Breason5.Text = "#"
        ' 
        ' Breason4
        ' 
        Breason4.Anchor = AnchorStyles.Top
        Breason4.AutoSize = True
        Breason4.BackColor = Color.FloralWhite
        Breason4.Font = New Font("Arial", 7.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Breason4.Location = New Point(1138, 249)
        Breason4.Margin = New Padding(3, 8, 3, 0)
        Breason4.Name = "Breason4"
        Breason4.Size = New Size(13, 14)
        Breason4.TabIndex = 88
        Breason4.Text = "#"
        ' 
        ' Breason3
        ' 
        Breason3.Anchor = AnchorStyles.Top
        Breason3.AutoSize = True
        Breason3.BackColor = Color.FloralWhite
        Breason3.Font = New Font("Arial", 7.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Breason3.Location = New Point(1138, 189)
        Breason3.Margin = New Padding(3, 8, 3, 0)
        Breason3.Name = "Breason3"
        Breason3.Size = New Size(13, 14)
        Breason3.TabIndex = 87
        Breason3.Text = "#"
        ' 
        ' Breason2
        ' 
        Breason2.Anchor = AnchorStyles.Top
        Breason2.AutoSize = True
        Breason2.BackColor = Color.FloralWhite
        Breason2.Font = New Font("Arial", 7.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Breason2.Location = New Point(1138, 129)
        Breason2.Margin = New Padding(3, 8, 3, 0)
        Breason2.Name = "Breason2"
        Breason2.Size = New Size(13, 14)
        Breason2.TabIndex = 86
        Breason2.Text = "#"
        ' 
        ' Breason1
        ' 
        Breason1.Anchor = AnchorStyles.Top
        Breason1.AutoSize = True
        Breason1.BackColor = Color.FloralWhite
        Breason1.Font = New Font("Arial", 7.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Breason1.Location = New Point(1138, 68)
        Breason1.Margin = New Padding(3, 8, 3, 0)
        Breason1.Name = "Breason1"
        Breason1.Size = New Size(13, 14)
        Breason1.TabIndex = 85
        Breason1.Text = "#"
        ' 
        ' Badd1
        ' 
        Badd1.Anchor = AnchorStyles.Top
        Badd1.AutoSize = True
        Badd1.BackColor = Color.FloralWhite
        Badd1.Font = New Font("Arial", 7.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Badd1.Location = New Point(680, 68)
        Badd1.Margin = New Padding(3, 8, 3, 0)
        Badd1.Name = "Badd1"
        Badd1.Size = New Size(13, 14)
        Badd1.TabIndex = 80
        Badd1.Text = "#"
        ' 
        ' Bname1
        ' 
        Bname1.Anchor = AnchorStyles.Top
        Bname1.AutoSize = True
        Bname1.BackColor = Color.FloralWhite
        Bname1.Font = New Font("Arial", 7.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Bname1.Location = New Point(222, 68)
        Bname1.Margin = New Padding(3, 8, 3, 0)
        Bname1.Name = "Bname1"
        Bname1.Size = New Size(13, 14)
        Bname1.TabIndex = 75
        Bname1.Text = "#"
        ' 
        ' Bname2
        ' 
        Bname2.Anchor = AnchorStyles.Top
        Bname2.AutoSize = True
        Bname2.BackColor = Color.FloralWhite
        Bname2.Font = New Font("Arial", 7.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Bname2.Location = New Point(222, 129)
        Bname2.Margin = New Padding(3, 8, 3, 0)
        Bname2.Name = "Bname2"
        Bname2.Size = New Size(13, 14)
        Bname2.TabIndex = 76
        Bname2.Text = "#"
        ' 
        ' Bname3
        ' 
        Bname3.Anchor = AnchorStyles.Top
        Bname3.AutoSize = True
        Bname3.BackColor = Color.FloralWhite
        Bname3.Font = New Font("Arial", 7.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Bname3.Location = New Point(222, 189)
        Bname3.Margin = New Padding(3, 8, 3, 0)
        Bname3.Name = "Bname3"
        Bname3.Size = New Size(13, 14)
        Bname3.TabIndex = 77
        Bname3.Text = "#"
        ' 
        ' Bname4
        ' 
        Bname4.Anchor = AnchorStyles.Top
        Bname4.AutoSize = True
        Bname4.BackColor = Color.FloralWhite
        Bname4.Font = New Font("Arial", 7.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Bname4.Location = New Point(222, 249)
        Bname4.Margin = New Padding(3, 8, 3, 0)
        Bname4.Name = "Bname4"
        Bname4.Size = New Size(13, 14)
        Bname4.TabIndex = 78
        Bname4.Text = "#"
        ' 
        ' Bname5
        ' 
        Bname5.Anchor = AnchorStyles.Top
        Bname5.AutoSize = True
        Bname5.BackColor = Color.FloralWhite
        Bname5.Font = New Font("Arial", 7.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Bname5.Location = New Point(222, 309)
        Bname5.Margin = New Padding(3, 8, 3, 0)
        Bname5.Name = "Bname5"
        Bname5.Size = New Size(13, 14)
        Bname5.TabIndex = 79
        Bname5.Text = "#"
        ' 
        ' Badd2
        ' 
        Badd2.Anchor = AnchorStyles.Top
        Badd2.AutoSize = True
        Badd2.BackColor = Color.FloralWhite
        Badd2.Font = New Font("Arial", 7.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Badd2.Location = New Point(680, 129)
        Badd2.Margin = New Padding(3, 8, 3, 0)
        Badd2.Name = "Badd2"
        Badd2.Size = New Size(13, 14)
        Badd2.TabIndex = 81
        Badd2.Text = "#"
        ' 
        ' Badd3
        ' 
        Badd3.Anchor = AnchorStyles.Top
        Badd3.AutoSize = True
        Badd3.BackColor = Color.FloralWhite
        Badd3.Font = New Font("Arial", 7.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Badd3.Location = New Point(680, 189)
        Badd3.Margin = New Padding(3, 8, 3, 0)
        Badd3.Name = "Badd3"
        Badd3.Size = New Size(13, 14)
        Badd3.TabIndex = 82
        Badd3.Text = "#"
        ' 
        ' Badd4
        ' 
        Badd4.Anchor = AnchorStyles.Top
        Badd4.AutoSize = True
        Badd4.BackColor = Color.FloralWhite
        Badd4.Font = New Font("Arial", 7.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Badd4.Location = New Point(680, 249)
        Badd4.Margin = New Padding(3, 8, 3, 0)
        Badd4.Name = "Badd4"
        Badd4.Size = New Size(13, 14)
        Badd4.TabIndex = 83
        Badd4.Text = "#"
        ' 
        ' Badd5
        ' 
        Badd5.Anchor = AnchorStyles.Top
        Badd5.AutoSize = True
        Badd5.BackColor = Color.FloralWhite
        Badd5.Font = New Font("Arial", 7.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Badd5.Location = New Point(680, 309)
        Badd5.Margin = New Padding(3, 8, 3, 0)
        Badd5.Name = "Badd5"
        Badd5.Size = New Size(13, 14)
        Badd5.TabIndex = 84
        Badd5.Text = "#"
        ' 
        ' AdminForm3
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.cover1
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1569, 640)
        Controls.Add(PnlSidebar)
        Controls.Add(TableLayoutPanel2)
        Controls.Add(TableLayoutPanel1)
        Name = "AdminForm3"
        Text = "Form6"
        WindowState = FormWindowState.Maximized
        TableLayoutPanel2.ResumeLayout(False)
        TableLayoutPanel2.PerformLayout()
        PnlSidebar.ResumeLayout(False)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        TableLayoutPanel1.ResumeLayout(False)
        TableLayoutPanel1.PerformLayout()
        ResumeLayout(False)
    End Sub
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents Button1 As Button
    Friend WithEvents PnlSidebar As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnBannedList As Button
    Friend WithEvents btnHistory As Button
    Friend WithEvents btnStocks As Button
    Friend WithEvents Label26 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Bname1 As Label
    Friend WithEvents Bname2 As Label
    Friend WithEvents Bname3 As Label
    Friend WithEvents Bname4 As Label
    Friend WithEvents Bname5 As Label
    Friend WithEvents Badd1 As Label
    Friend WithEvents Badd2 As Label
    Friend WithEvents Badd3 As Label
    Friend WithEvents Breason1 As Label
    Friend WithEvents Badd4 As Label
    Friend WithEvents Badd5 As Label
    Friend WithEvents Breason2 As Label
    Friend WithEvents Breason5 As Label
    Friend WithEvents Breason4 As Label
    Friend WithEvents Breason3 As Label
End Class
