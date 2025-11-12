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
        PictureBox1 = New PictureBox()
        btnBannedList = New Button()
        btnHistory = New Button()
        btnStocks = New Button()
        PnlSidebar = New Panel()
        TextBox1 = New TextBox()
        TableLayoutPanel1 = New TableLayoutPanel()
        Label2 = New Label()
        Label1 = New Label()
        Label26 = New Label()
        Label7 = New Label()
        Label3 = New Label()
        Button2 = New Button()
        TableLayoutPanel2 = New TableLayoutPanel()
        Button1 = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        PnlSidebar.SuspendLayout()
        TableLayoutPanel1.SuspendLayout()
        TableLayoutPanel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = SystemColors.ControlDarkDark
        PictureBox1.Cursor = Cursors.Hand
        PictureBox1.Image = My.Resources.Resources._578935847_1627970941508389_3020005775530561214_n_removebg_preview
        PictureBox1.Location = New Point(25, 18)
        PictureBox1.Margin = New Padding(25, 9, 0, 3)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(114, 101)
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
        ' PnlSidebar
        ' 
        PnlSidebar.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        PnlSidebar.BackColor = SystemColors.ControlDarkDark
        PnlSidebar.Controls.Add(PictureBox1)
        PnlSidebar.Controls.Add(btnBannedList)
        PnlSidebar.Controls.Add(btnHistory)
        PnlSidebar.Controls.Add(btnStocks)
        PnlSidebar.ForeColor = Color.White
        PnlSidebar.Location = New Point(0, 0)
        PnlSidebar.Name = "PnlSidebar"
        PnlSidebar.Size = New Size(164, 576)
        PnlSidebar.TabIndex = 19
        ' 
        ' TextBox1
        ' 
        TextBox1.BackColor = SystemColors.HighlightText
        TextBox1.Location = New Point(230, 85)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(318, 23)
        TextBox1.TabIndex = 22
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
        TableLayoutPanel1.Controls.Add(Label2, 2, 0)
        TableLayoutPanel1.Controls.Add(Label1, 1, 0)
        TableLayoutPanel1.Controls.Add(Label26, 0, 0)
        TableLayoutPanel1.Location = New Point(180, 203)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 6
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 16.666666F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 16.666666F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 16.666666F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 16.666666F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 16.666666F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 16.666666F))
        TableLayoutPanel1.Size = New Size(784, 365)
        TableLayoutPanel1.TabIndex = 78
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Top
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Arial Black", 9.75F, FontStyle.Bold)
        Label2.ForeColor = Color.Black
        Label2.Location = New Point(619, 15)
        Label2.Margin = New Padding(0, 15, 0, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(68, 18)
        Label2.TabIndex = 74
        Label2.Text = "REASON"
        Label2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Top
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Arial Black", 9.75F, FontStyle.Bold)
        Label1.ForeColor = Color.Black
        Label1.Location = New Point(354, 15)
        Label1.Margin = New Padding(0, 15, 0, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(75, 18)
        Label1.TabIndex = 73
        Label1.Text = "ADDRESS"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label26
        ' 
        Label26.Anchor = AnchorStyles.Top
        Label26.AutoSize = True
        Label26.BackColor = Color.Transparent
        Label26.Font = New Font("Arial Black", 9.75F, FontStyle.Bold)
        Label26.ForeColor = Color.Black
        Label26.Location = New Point(105, 15)
        Label26.Margin = New Padding(0, 15, 0, 0)
        Label26.Name = "Label26"
        Label26.Size = New Size(50, 18)
        Label26.TabIndex = 72
        Label26.Text = "NAME"
        Label26.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label7
        ' 
        Label7.Anchor = AnchorStyles.Top
        Label7.AutoSize = True
        Label7.BackColor = Color.Transparent
        Label7.Font = New Font("Arial Black", 26.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = Color.GhostWhite
        Label7.Location = New Point(250, 15)
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
        Label3.Location = New Point(126, 87)
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
        Button2.Location = New Point(693, 82)
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
        TableLayoutPanel2.Controls.Add(Label7, 1, 0)
        TableLayoutPanel2.Controls.Add(Label3, 0, 1)
        TableLayoutPanel2.Controls.Add(TextBox1, 1, 1)
        TableLayoutPanel2.Controls.Add(Button1, 2, 1)
        TableLayoutPanel2.Controls.Add(Button2, 3, 1)
        TableLayoutPanel2.Location = New Point(183, 78)
        TableLayoutPanel2.Name = "TableLayoutPanel2"
        TableLayoutPanel2.RowCount = 2
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Absolute, 37F))
        TableLayoutPanel2.Size = New Size(784, 119)
        TableLayoutPanel2.TabIndex = 100
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.White
        Button1.FlatStyle = FlatStyle.System
        Button1.Font = New Font("Arial Black", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = Color.Red
        Button1.Location = New Point(558, 84)
        Button1.Margin = New Padding(0, 2, 0, 0)
        Button1.Name = "Button1"
        Button1.Size = New Size(78, 26)
        Button1.TabIndex = 83
        Button1.Text = "ENTER"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' AdminForm3
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.cover1
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(979, 575)
        Controls.Add(TableLayoutPanel2)
        Controls.Add(TableLayoutPanel1)
        Controls.Add(PnlSidebar)
        Name = "AdminForm3"
        Text = "Form6"
        WindowState = FormWindowState.Maximized
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        PnlSidebar.ResumeLayout(False)
        TableLayoutPanel1.ResumeLayout(False)
        TableLayoutPanel1.PerformLayout()
        TableLayoutPanel2.ResumeLayout(False)
        TableLayoutPanel2.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnBannedList As Button
    Friend WithEvents btnHistory As Button
    Friend WithEvents btnStocks As Button
    Friend WithEvents PnlSidebar As Panel
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents Button1 As Button
End Class
