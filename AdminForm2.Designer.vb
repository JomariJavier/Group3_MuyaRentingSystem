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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Label26 = New Label()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label8 = New Label()
        TableLayoutPanel1 = New TableLayoutPanel()
        Button1 = New Button()
        Button2 = New Button()
        TextBox1 = New TextBox()
        TableLayoutPanel2 = New TableLayoutPanel()
        Label7 = New Label()
        PnlSidebar = New Panel()
        btnHistory = New Button()
        PictureBox1 = New PictureBox()
        btnBannedList = New Button()
        btnStocks = New Button()
        ViewTools = New DataGridView()
        TableLayoutPanel1.SuspendLayout()
        TableLayoutPanel2.SuspendLayout()
        PnlSidebar.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(ViewTools, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label26
        ' 
        Label26.Anchor = AnchorStyles.Top
        Label26.AutoSize = True
        Label26.BackColor = Color.Transparent
        Label26.Font = New Font("Arial Black", 9.75F, FontStyle.Bold)
        Label26.ForeColor = Color.Black
        Label26.Location = New Point(65, 20)
        Label26.Margin = New Padding(0, 20, 0, 0)
        Label26.Name = "Label26"
        Label26.Size = New Size(65, 24)
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
        Label1.Location = New Point(279, 20)
        Label1.Margin = New Padding(0, 20, 0, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(30, 24)
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
        Label2.Location = New Point(443, 20)
        Label2.Margin = New Padding(0, 20, 0, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(93, 24)
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
        Label3.Location = New Point(637, 20)
        Label3.Margin = New Padding(0, 20, 0, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(98, 24)
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
        Label4.Location = New Point(812, 20)
        Label4.Margin = New Padding(0, 20, 0, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(140, 24)
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
        Label5.Location = New Point(1007, 20)
        Label5.Margin = New Padding(0, 20, 0, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(142, 24)
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
        Label6.Location = New Point(1244, 20)
        Label6.Margin = New Padding(0, 20, 0, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(60, 24)
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
        Label8.Location = New Point(1429, 20)
        Label8.Margin = New Padding(0, 20, 0, 0)
        Label8.Name = "Label8"
        Label8.Size = New Size(83, 24)
        Label8.TabIndex = 80
        Label8.Text = "STATUS"
        Label8.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        TableLayoutPanel1.BackColor = Color.AliceBlue
        TableLayoutPanel1.ColumnCount = 8
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 12.5F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 12.5F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 12.5F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 12.5F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 12.5F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 12.5F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 12.5F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 12.5F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 23F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 23F))
        TableLayoutPanel1.Controls.Add(Label5, 5, 0)
        TableLayoutPanel1.Controls.Add(Label4, 4, 0)
        TableLayoutPanel1.Controls.Add(Label3, 3, 0)
        TableLayoutPanel1.Controls.Add(Label2, 2, 0)
        TableLayoutPanel1.Controls.Add(Label1, 1, 0)
        TableLayoutPanel1.Controls.Add(Label26, 0, 0)
        TableLayoutPanel1.Controls.Add(Label6, 6, 0)
        TableLayoutPanel1.Controls.Add(Label8, 7, 0)
        TableLayoutPanel1.Controls.Add(Button1, 1, 1)
        TableLayoutPanel1.Controls.Add(Button2, 2, 1)
        TableLayoutPanel1.Controls.Add(TextBox1, 7, 1)
        TableLayoutPanel1.Location = New Point(206, 715)
        TableLayoutPanel1.Margin = New Padding(3, 4, 3, 4)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 6
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 16.6666641F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 16.6666641F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 16.6666641F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 16.6666641F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 16.6666641F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 16.6666641F))
        TableLayoutPanel1.Size = New Size(1570, 512)
        TableLayoutPanel1.TabIndex = 18
        ' 
        ' Button1
        ' 
        Button1.Anchor = AnchorStyles.Top
        Button1.Location = New Point(247, 114)
        Button1.Margin = New Padding(3, 29, 3, 3)
        Button1.Name = "Button1"
        Button1.Size = New Size(94, 40)
        Button1.TabIndex = 81
        Button1.Text = "view"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Anchor = AnchorStyles.Top
        Button2.Location = New Point(443, 114)
        Button2.Margin = New Padding(3, 29, 3, 3)
        Button2.Name = "Button2"
        Button2.Size = New Size(94, 40)
        Button2.TabIndex = 82
        Button2.Text = "view"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' TextBox1
        ' 
        TextBox1.Anchor = AnchorStyles.Top
        TextBox1.Location = New Point(1378, 88)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(186, 27)
        TextBox1.TabIndex = 83
        ' 
        ' TableLayoutPanel2
        ' 
        TableLayoutPanel2.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        TableLayoutPanel2.BackColor = Color.Transparent
        TableLayoutPanel2.ColumnCount = 2
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel2.Controls.Add(Label7, 0, 0)
        TableLayoutPanel2.Location = New Point(206, 13)
        TableLayoutPanel2.Margin = New Padding(3, 4, 3, 4)
        TableLayoutPanel2.Name = "TableLayoutPanel2"
        TableLayoutPanel2.RowCount = 1
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Absolute, 89F))
        TableLayoutPanel2.Size = New Size(1570, 89)
        TableLayoutPanel2.TabIndex = 98
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.Transparent
        Label7.Font = New Font("Arial Black", 26.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = Color.FromArgb(CByte(5), CByte(14), CByte(60))
        Label7.Location = New Point(0, 27)
        Label7.Margin = New Padding(0, 27, 0, 0)
        Label7.Name = "Label7"
        Label7.Size = New Size(246, 62)
        Label7.TabIndex = 98
        Label7.Text = "HISTORY"
        Label7.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' PnlSidebar
        ' 
        PnlSidebar.BackColor = Color.FromArgb(CByte(5), CByte(14), CByte(60))
        PnlSidebar.Controls.Add(btnHistory)
        PnlSidebar.Controls.Add(PictureBox1)
        PnlSidebar.Controls.Add(btnBannedList)
        PnlSidebar.Controls.Add(btnStocks)
        PnlSidebar.Dock = DockStyle.Left
        PnlSidebar.ForeColor = Color.White
        PnlSidebar.Location = New Point(0, 0)
        PnlSidebar.Margin = New Padding(3, 4, 3, 4)
        PnlSidebar.Name = "PnlSidebar"
        PnlSidebar.Size = New Size(187, 853)
        PnlSidebar.TabIndex = 105
        ' 
        ' btnHistory
        ' 
        btnHistory.BackColor = Color.Transparent
        btnHistory.Cursor = Cursors.Hand
        btnHistory.FlatStyle = FlatStyle.Flat
        btnHistory.Font = New Font("Arial Black", 9.75F, FontStyle.Bold)
        btnHistory.ForeColor = Color.White
        btnHistory.Image = My.Resources.Resources.file__2_
        btnHistory.ImageAlign = ContentAlignment.MiddleLeft
        btnHistory.Location = New Point(14, 284)
        btnHistory.Margin = New Padding(3, 4, 3, 4)
        btnHistory.Name = "btnHistory"
        btnHistory.Size = New Size(159, 63)
        btnHistory.TabIndex = 5
        btnHistory.Text = "History"
        btnHistory.UseVisualStyleBackColor = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.Cursor = Cursors.Hand
        PictureBox1.Image = My.Resources.Resources._578935847_1627970941508389_3020005775530561214_n_removebg_preview
        PictureBox1.Location = New Point(19, 21)
        PictureBox1.Margin = New Padding(29, 12, 0, 4)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(139, 151)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 3
        PictureBox1.TabStop = False
        ' 
        ' btnBannedList
        ' 
        btnBannedList.Anchor = AnchorStyles.Top
        btnBannedList.BackColor = Color.Transparent
        btnBannedList.Cursor = Cursors.Hand
        btnBannedList.FlatStyle = FlatStyle.Flat
        btnBannedList.Font = New Font("Arial Black", 9.75F, FontStyle.Bold)
        btnBannedList.ForeColor = Color.White
        btnBannedList.Image = My.Resources.Resources.banned__3_
        btnBannedList.ImageAlign = ContentAlignment.MiddleLeft
        btnBannedList.Location = New Point(14, 355)
        btnBannedList.Margin = New Padding(3, 4, 3, 4)
        btnBannedList.Name = "btnBannedList"
        btnBannedList.Size = New Size(159, 63)
        btnBannedList.TabIndex = 6
        btnBannedList.Text = "Banned List"
        btnBannedList.TextAlign = ContentAlignment.MiddleRight
        btnBannedList.UseMnemonic = False
        btnBannedList.UseVisualStyleBackColor = False
        ' 
        ' btnStocks
        ' 
        btnStocks.BackColor = Color.Transparent
        btnStocks.BackgroundImageLayout = ImageLayout.None
        btnStocks.Cursor = Cursors.Hand
        btnStocks.FlatStyle = FlatStyle.Flat
        btnStocks.Font = New Font("Arial Black", 9.75F, FontStyle.Bold)
        btnStocks.ForeColor = Color.White
        btnStocks.Image = My.Resources.Resources.in_stock__2_
        btnStocks.ImageAlign = ContentAlignment.MiddleLeft
        btnStocks.Location = New Point(14, 213)
        btnStocks.Margin = New Padding(3, 4, 3, 4)
        btnStocks.Name = "btnStocks"
        btnStocks.Size = New Size(159, 63)
        btnStocks.TabIndex = 4
        btnStocks.Text = "Stocks"
        btnStocks.UseVisualStyleBackColor = False
        ' 
        ' ViewTools
        ' 
        ViewTools.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        ViewTools.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = SystemColors.Window
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle1.ForeColor = SystemColors.ControlLightLight
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.False
        ViewTools.DefaultCellStyle = DataGridViewCellStyle1
        ViewTools.Location = New Point(206, 109)
        ViewTools.Name = "ViewTools"
        ViewTools.ReadOnly = True
        ViewTools.RowHeadersWidth = 51
        ViewTools.RowTemplate.Height = 100
        ViewTools.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        ViewTools.Size = New Size(1570, 424)
        ViewTools.TabIndex = 108
        ' 
        ' AdminForm2
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1793, 853)
        Controls.Add(ViewTools)
        Controls.Add(PnlSidebar)
        Controls.Add(TableLayoutPanel2)
        Controls.Add(TableLayoutPanel1)
        Margin = New Padding(3, 4, 3, 4)
        Name = "AdminForm2"
        Text = "Form7"
        WindowState = FormWindowState.Maximized
        TableLayoutPanel1.ResumeLayout(False)
        TableLayoutPanel1.PerformLayout()
        TableLayoutPanel2.ResumeLayout(False)
        TableLayoutPanel2.PerformLayout()
        PnlSidebar.ResumeLayout(False)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(ViewTools, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub
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
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents PnlSidebar As Panel
    Friend WithEvents btnHistory As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnBannedList As Button
    Friend WithEvents btnStocks As Button
    Friend WithEvents ViewTools As DataGridView
End Class
