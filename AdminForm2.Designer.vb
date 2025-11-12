<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminForm2
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
        btnStocks = New Button()
        btnHistory = New Button()
        btnBannedList = New Button()
        PictureBox1 = New PictureBox()
        PnlSidebar = New Panel()
        Label26 = New Label()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label8 = New Label()
        TableLayoutPanel1 = New TableLayoutPanel()
        TableLayoutPanel2 = New TableLayoutPanel()
        Label7 = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        PnlSidebar.SuspendLayout()
        TableLayoutPanel1.SuspendLayout()
        TableLayoutPanel2.SuspendLayout()
        SuspendLayout()
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
        PnlSidebar.TabIndex = 16
        ' 
        ' Label26
        ' 
        Label26.Anchor = AnchorStyles.Top
        Label26.AutoSize = True
        Label26.BackColor = Color.Transparent
        Label26.Font = New Font("Arial Black", 9.75F, FontStyle.Bold)
        Label26.ForeColor = Color.Black
        Label26.Location = New Point(24, 15)
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
        Label1.Location = New Point(135, 15)
        Label1.Margin = New Padding(0, 15, 0, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(23, 18)
        Label1.TabIndex = 73
        Label1.Text = "ID"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Top
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Arial Black", 9.75F, FontStyle.Bold)
        Label2.ForeColor = Color.Black
        Label2.Location = New Point(209, 15)
        Label2.Margin = New Padding(0, 15, 0, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(71, 18)
        Label2.TabIndex = 74
        Label2.Text = "PICTURE"
        Label2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.Top
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Arial Black", 9.75F, FontStyle.Bold)
        Label3.ForeColor = Color.Black
        Label3.Location = New Point(305, 15)
        Label3.Margin = New Padding(0, 15, 0, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(75, 18)
        Label3.TabIndex = 75
        Label3.Text = "ADDRESS"
        Label3.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.Top
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Arial Black", 9.75F, FontStyle.Bold)
        Label4.ForeColor = Color.Black
        Label4.Location = New Point(408, 15)
        Label4.Margin = New Padding(0, 15, 0, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(66, 36)
        Label4.TabIndex = 76
        Label4.Text = "RENTED DATE"
        Label4.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label5
        ' 
        Label5.Anchor = AnchorStyles.Top
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Arial Black", 9.75F, FontStyle.Bold)
        Label5.ForeColor = Color.Black
        Label5.Location = New Point(505, 15)
        Label5.Margin = New Padding(0, 15, 0, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(68, 36)
        Label5.TabIndex = 77
        Label5.Text = "RETURN DATE"
        Label5.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label6
        ' 
        Label6.Anchor = AnchorStyles.Top
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.Font = New Font("Arial Black", 9.75F, FontStyle.Bold)
        Label6.ForeColor = Color.Black
        Label6.Location = New Point(613, 15)
        Label6.Margin = New Padding(0, 15, 0, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(48, 18)
        Label6.TabIndex = 78
        Label6.Text = "TOOL"
        Label6.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label8
        ' 
        Label8.Anchor = AnchorStyles.Top
        Label8.AutoSize = True
        Label8.BackColor = Color.Transparent
        Label8.Font = New Font("Arial Black", 9.75F, FontStyle.Bold)
        Label8.ForeColor = Color.Black
        Label8.Location = New Point(703, 15)
        Label8.Margin = New Padding(0, 15, 0, 0)
        Label8.Name = "Label8"
        Label8.Size = New Size(63, 18)
        Label8.TabIndex = 80
        Label8.Text = "STATUS"
        Label8.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        TableLayoutPanel1.BackColor = SystemColors.ScrollBar
        TableLayoutPanel1.ColumnCount = 8
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 12.5F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 12.5F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 12.5F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 12.5F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 12.5F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 12.5F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 12.5F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 12.5F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 20F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 20F))
        TableLayoutPanel1.Controls.Add(Label8, 7, 0)
        TableLayoutPanel1.Controls.Add(Label6, 6, 0)
        TableLayoutPanel1.Controls.Add(Label5, 5, 0)
        TableLayoutPanel1.Controls.Add(Label4, 4, 0)
        TableLayoutPanel1.Controls.Add(Label3, 3, 0)
        TableLayoutPanel1.Controls.Add(Label2, 2, 0)
        TableLayoutPanel1.Controls.Add(Label1, 1, 0)
        TableLayoutPanel1.Controls.Add(Label26, 0, 0)
        TableLayoutPanel1.Location = New Point(180, 184)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 6
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 16.6666641F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 16.6666641F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 16.6666641F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 16.6666641F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 16.6666641F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 16.6666641F))
        TableLayoutPanel1.Size = New Size(784, 384)
        TableLayoutPanel1.TabIndex = 18
        ' 
        ' TableLayoutPanel2
        ' 
        TableLayoutPanel2.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        TableLayoutPanel2.BackColor = Color.Transparent
        TableLayoutPanel2.ColumnCount = 2
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel2.Controls.Add(Label7, 0, 0)
        TableLayoutPanel2.Location = New Point(180, 114)
        TableLayoutPanel2.Name = "TableLayoutPanel2"
        TableLayoutPanel2.RowCount = 1
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Absolute, 20F))
        TableLayoutPanel2.Size = New Size(784, 67)
        TableLayoutPanel2.TabIndex = 98
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.Transparent
        Label7.Font = New Font("Arial Black", 26.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = Color.GhostWhite
        Label7.Location = New Point(0, 20)
        Label7.Margin = New Padding(0, 20, 0, 0)
        Label7.Name = "Label7"
        Label7.Size = New Size(195, 47)
        Label7.TabIndex = 98
        Label7.Text = "HISTORY"
        Label7.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' AdminForm2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.cover1
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(979, 575)
        Controls.Add(TableLayoutPanel2)
        Controls.Add(TableLayoutPanel1)
        Controls.Add(PnlSidebar)
        Name = "AdminForm2"
        Text = "Form7"
        WindowState = FormWindowState.Maximized
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        PnlSidebar.ResumeLayout(False)
        TableLayoutPanel1.ResumeLayout(False)
        TableLayoutPanel1.PerformLayout()
        TableLayoutPanel2.ResumeLayout(False)
        TableLayoutPanel2.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents btnStocks As Button
    Friend WithEvents btnHistory As Button
    Friend WithEvents btnBannedList As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PnlSidebar As Panel
    Friend WithEvents Label26 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents Label7 As Label
End Class
