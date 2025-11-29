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
        Panel1 = New Panel()
        DataGridView1 = New DataGridView()
        TableLayoutPanel2.SuspendLayout()
        PnlSidebar.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' TextBox1
        ' 
        TextBox1.BackColor = SystemColors.HighlightText
        TextBox1.Location = New Point(458, 114)
        TextBox1.Margin = New Padding(3, 4, 3, 4)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(363, 27)
        TextBox1.TabIndex = 22
        ' 
        ' Label7
        ' 
        Label7.Anchor = AnchorStyles.Top
        Label7.AutoSize = True
        Label7.BackColor = Color.Transparent
        Label7.Font = New Font("Arial Black", 26.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = Color.GhostWhite
        Label7.Location = New Point(607, 20)
        Label7.Margin = New Padding(0, 20, 0, 0)
        Label7.Name = "Label7"
        Label7.Size = New Size(359, 62)
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
        Label3.Location = New Point(235, 117)
        Label3.Margin = New Padding(114, 7, 0, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(99, 24)
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
        Button2.Location = New Point(1388, 110)
        Button2.Margin = New Padding(0)
        Button2.Name = "Button2"
        Button2.Size = New Size(98, 49)
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
        TableLayoutPanel2.Location = New Point(209, 104)
        TableLayoutPanel2.Margin = New Padding(3, 4, 3, 4)
        TableLayoutPanel2.Name = "TableLayoutPanel2"
        TableLayoutPanel2.RowCount = 2
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Absolute, 49F))
        TableLayoutPanel2.Size = New Size(1570, 159)
        TableLayoutPanel2.TabIndex = 100
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.White
        Button1.FlatStyle = FlatStyle.System
        Button1.Font = New Font("Arial Black", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = Color.Red
        Button1.Location = New Point(1118, 113)
        Button1.Margin = New Padding(0, 3, 0, 0)
        Button1.Name = "Button1"
        Button1.Size = New Size(89, 35)
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
        PnlSidebar.Margin = New Padding(3, 4, 3, 4)
        PnlSidebar.Name = "PnlSidebar"
        PnlSidebar.Size = New Size(187, 853)
        PnlSidebar.TabIndex = 103
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = SystemColors.ControlDarkDark
        PictureBox1.Cursor = Cursors.Hand
        PictureBox1.Image = My.Resources.Resources._576101383_1180382820892530_8501663318516642353_n_removebg_preview1
        PictureBox1.Location = New Point(19, 21)
        PictureBox1.Margin = New Padding(29, 12, 0, 4)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(139, 125)
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
        btnBannedList.Location = New Point(29, 369)
        btnBannedList.Margin = New Padding(3, 4, 3, 4)
        btnBannedList.Name = "btnBannedList"
        btnBannedList.Size = New Size(130, 49)
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
        btnHistory.Location = New Point(29, 287)
        btnHistory.Margin = New Padding(3, 4, 3, 4)
        btnHistory.Name = "btnHistory"
        btnHistory.Size = New Size(130, 44)
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
        btnStocks.Location = New Point(29, 196)
        btnStocks.Margin = New Padding(3, 4, 3, 4)
        btnStocks.Name = "btnStocks"
        btnStocks.Size = New Size(130, 45)
        btnStocks.TabIndex = 4
        btnStocks.Text = "Stocks"
        btnStocks.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.ControlDarkDark
        Panel1.Controls.Add(DataGridView1)
        Panel1.Location = New Point(209, 299)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1165, 383)
        Panel1.TabIndex = 104
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(11, 22)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(764, 272)
        DataGridView1.TabIndex = 0
        ' 
        ' AdminForm3
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.cover1
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1793, 853)
        Controls.Add(Panel1)
        Controls.Add(PnlSidebar)
        Controls.Add(TableLayoutPanel2)
        Margin = New Padding(3, 4, 3, 4)
        Name = "AdminForm3"
        Text = "Form6"
        WindowState = FormWindowState.Maximized
        TableLayoutPanel2.ResumeLayout(False)
        TableLayoutPanel2.PerformLayout()
        PnlSidebar.ResumeLayout(False)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents Panel1 As Panel
    Friend WithEvents DataGridView1 As DataGridView
End Class
