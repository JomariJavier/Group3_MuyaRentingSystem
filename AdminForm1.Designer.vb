<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminForm1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AdminForm1))
        OpenFileDialog1 = New OpenFileDialog()
        PnlSidebar = New Panel()
        PictureBox1 = New PictureBox()
        btnBannedList = New Button()
        btnHistory = New Button()
        btnStocks = New Button()
        TableLayoutPanel2 = New TableLayoutPanel()
        priceS = New Label()
        Label13 = New Label()
        Label8 = New Label()
        TextBox1 = New TextBox()
        ComboBox1 = New ComboBox()
        Label11 = New Label()
        Label4 = New Label()
        TextBox2 = New TextBox()
        CurrStocks1 = New Label()
        Label10 = New Label()
        ComboBox4 = New ComboBox()
        Label1 = New Label()
        PictureBox2 = New PictureBox()
        Button1 = New Button()
        Button2 = New Button()
        PictureBox3 = New PictureBox()
        PictureBox4 = New PictureBox()
        TableLayoutPanel5 = New TableLayoutPanel()
        Label7 = New Label()
        TableLayoutPanel6 = New TableLayoutPanel()
        TableLayoutPanel1 = New TableLayoutPanel()
        priceS2 = New Label()
        Label3 = New Label()
        Label5 = New Label()
        TextBox3 = New TextBox()
        ComboBox2 = New ComboBox()
        Label6 = New Label()
        Label9 = New Label()
        TextBox4 = New TextBox()
        Label12 = New Label()
        Label14 = New Label()
        ComboBox3 = New ComboBox()
        Label15 = New Label()
        TableLayoutPanel3 = New TableLayoutPanel()
        priceS3 = New Label()
        Label17 = New Label()
        Label18 = New Label()
        TextBox5 = New TextBox()
        ComboBox5 = New ComboBox()
        Label19 = New Label()
        Label20 = New Label()
        TextBox6 = New TextBox()
        Label21 = New Label()
        Label22 = New Label()
        ComboBox6 = New ComboBox()
        Label23 = New Label()
        PnlSidebar.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        TableLayoutPanel2.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        TableLayoutPanel5.SuspendLayout()
        TableLayoutPanel6.SuspendLayout()
        TableLayoutPanel1.SuspendLayout()
        TableLayoutPanel3.SuspendLayout()
        SuspendLayout()
        ' 
        ' OpenFileDialog1
        ' 
        OpenFileDialog1.FileName = "OpenFileDialog1"
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
        PnlSidebar.Size = New Size(187, 854)
        PnlSidebar.TabIndex = 104
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = SystemColors.ControlDarkDark
        PictureBox1.Cursor = Cursors.Hand
        PictureBox1.Image = My.Resources.Resources._576101383_1180382820892530_8501663318516642353_n_removebg_preview1
        PictureBox1.Location = New Point(19, 21)
        PictureBox1.Margin = New Padding(29, 12, 0, 4)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(140, 126)
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
        btnBannedList.Location = New Point(29, 369)
        btnBannedList.Margin = New Padding(3, 4, 3, 4)
        btnBannedList.Name = "btnBannedList"
        btnBannedList.Size = New Size(130, 49)
        btnBannedList.TabIndex = 6
        btnBannedList.Text = "Banned List"
        btnBannedList.UseMnemonic = False
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
        ' TableLayoutPanel2
        ' 
        TableLayoutPanel2.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom
        TableLayoutPanel2.AutoSize = True
        TableLayoutPanel2.ColumnCount = 1
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        TableLayoutPanel2.Controls.Add(priceS, 0, 7)
        TableLayoutPanel2.Controls.Add(Label13, 0, 6)
        TableLayoutPanel2.Controls.Add(Label8, 0, 0)
        TableLayoutPanel2.Controls.Add(TextBox1, 0, 1)
        TableLayoutPanel2.Controls.Add(ComboBox1, 0, 3)
        TableLayoutPanel2.Controls.Add(Label11, 0, 2)
        TableLayoutPanel2.Controls.Add(Label4, 0, 4)
        TableLayoutPanel2.Controls.Add(TextBox2, 0, 5)
        TableLayoutPanel2.Controls.Add(CurrStocks1, 0, 11)
        TableLayoutPanel2.Controls.Add(Label10, 0, 10)
        TableLayoutPanel2.Controls.Add(ComboBox4, 0, 9)
        TableLayoutPanel2.Controls.Add(Label1, 0, 8)
        TableLayoutPanel2.Location = New Point(310, 42)
        TableLayoutPanel2.Name = "TableLayoutPanel2"
        TableLayoutPanel2.RowCount = 12
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 8.333333F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 8.333333F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 8.333333F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 8.333333F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 8.333333F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 8.333333F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 8.333333F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 8.333333F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 8.333333F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 8.333333F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 8.333333F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 8.333333F))
        TableLayoutPanel2.Size = New Size(181, 432)
        TableLayoutPanel2.TabIndex = 102
        ' 
        ' priceS
        ' 
        priceS.Anchor = AnchorStyles.Top
        priceS.AutoSize = True
        priceS.BackColor = Color.FloralWhite
        priceS.Font = New Font("Arial", 7.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        priceS.Location = New Point(83, 255)
        priceS.Margin = New Padding(3, 10, 3, 0)
        priceS.Name = "priceS"
        priceS.Size = New Size(14, 16)
        priceS.TabIndex = 14
        priceS.Text = "#"
        ' 
        ' Label13
        ' 
        Label13.Anchor = AnchorStyles.Top
        Label13.AutoSize = True
        Label13.Font = New Font("Arial Narrow", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label13.Location = New Point(35, 215)
        Label13.Margin = New Padding(0, 5, 0, 0)
        Label13.Name = "Label13"
        Label13.Size = New Size(110, 20)
        Label13.TabIndex = 13
        Label13.Text = "UPDATED PRICE"
        ' 
        ' Label8
        ' 
        Label8.Anchor = AnchorStyles.Top
        Label8.AutoSize = True
        Label8.Font = New Font("Arial Narrow", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.Location = New Point(65, 5)
        Label8.Margin = New Padding(0, 5, 0, 0)
        Label8.Name = "Label8"
        Label8.Size = New Size(51, 20)
        Label8.TabIndex = 1
        Label8.Text = "LABEL"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(8, 38)
        TextBox1.Margin = New Padding(8, 3, 3, 3)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(170, 27)
        TextBox1.TabIndex = 4
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"AVAILABLE", "NOT AVAILABLE"})
        ComboBox1.Location = New Point(10, 108)
        ComboBox1.Margin = New Padding(10, 3, 3, 3)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(163, 28)
        ComboBox1.TabIndex = 6
        ' 
        ' Label11
        ' 
        Label11.Anchor = AnchorStyles.Top
        Label11.AutoSize = True
        Label11.Font = New Font("Arial Narrow", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label11.Location = New Point(42, 75)
        Label11.Margin = New Padding(0, 5, 0, 0)
        Label11.Name = "Label11"
        Label11.Size = New Size(96, 20)
        Label11.TabIndex = 5
        Label11.Text = "AVAILABILITY"
        ' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.Top
        Label4.AutoSize = True
        Label4.Font = New Font("Arial Narrow", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(67, 150)
        Label4.Margin = New Padding(0, 10, 0, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(47, 20)
        Label4.TabIndex = 11
        Label4.Text = "PRICE"
        Label4.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(8, 178)
        TextBox2.Margin = New Padding(8, 3, 3, 3)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(170, 27)
        TextBox2.TabIndex = 12
        ' 
        ' CurrStocks1
        ' 
        CurrStocks1.Anchor = AnchorStyles.Top
        CurrStocks1.AutoSize = True
        CurrStocks1.BackColor = Color.FloralWhite
        CurrStocks1.Font = New Font("Arial", 7.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        CurrStocks1.Location = New Point(83, 395)
        CurrStocks1.Margin = New Padding(3, 10, 3, 0)
        CurrStocks1.Name = "CurrStocks1"
        CurrStocks1.Size = New Size(14, 16)
        CurrStocks1.TabIndex = 7
        CurrStocks1.Text = "#"
        ' 
        ' Label10
        ' 
        Label10.Anchor = AnchorStyles.Top
        Label10.AutoSize = True
        Label10.Font = New Font("Arial Narrow", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label10.Location = New Point(28, 360)
        Label10.Margin = New Padding(0, 10, 0, 0)
        Label10.Name = "Label10"
        Label10.Size = New Size(125, 20)
        Label10.TabIndex = 3
        Label10.Text = "CURRENT STOCKS"
        Label10.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' ComboBox4
        ' 
        ComboBox4.FormattingEnabled = True
        ComboBox4.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        ComboBox4.Location = New Point(10, 318)
        ComboBox4.Margin = New Padding(10, 3, 3, 3)
        ComboBox4.Name = "ComboBox4"
        ComboBox4.Size = New Size(163, 28)
        ComboBox4.TabIndex = 10
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Top
        Label1.AutoSize = True
        Label1.Font = New Font("Arial Narrow", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(33, 285)
        Label1.Margin = New Padding(0, 5, 0, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(115, 20)
        Label1.TabIndex = 9
        Label1.Text = "UPDATE STOCKS"
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Anchor = AnchorStyles.None
        PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), Image)
        PictureBox2.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox2.Location = New Point(42, 135)
        PictureBox2.Margin = New Padding(20, 3, 3, 3)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(199, 245)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 97
        PictureBox2.TabStop = False
        ' 
        ' Button1
        ' 
        Button1.Anchor = AnchorStyles.Top
        Button1.BackColor = Color.Transparent
        Button1.FlatStyle = FlatStyle.System
        Button1.Font = New Font("Arial Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = Color.White
        Button1.Location = New Point(617, 477)
        Button1.Margin = New Padding(0)
        Button1.Name = "Button1"
        Button1.Size = New Size(101, 53)
        Button1.TabIndex = 95
        Button1.Text = "Enter"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.Anchor = AnchorStyles.Top
        Button2.BackColor = Color.Transparent
        Button2.FlatStyle = FlatStyle.System
        Button2.Font = New Font("Arial Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button2.ForeColor = Color.White
        Button2.Location = New Point(882, 477)
        Button2.Margin = New Padding(0)
        Button2.Name = "Button2"
        Button2.Size = New Size(105, 53)
        Button2.TabIndex = 96
        Button2.Text = "Cancel"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Anchor = AnchorStyles.None
        PictureBox3.BackgroundImage = CType(resources.GetObject("PictureBox3.BackgroundImage"), Image)
        PictureBox3.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox3.Location = New Point(560, 135)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(215, 245)
        PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox3.TabIndex = 98
        PictureBox3.TabStop = False
        ' 
        ' PictureBox4
        ' 
        PictureBox4.Anchor = AnchorStyles.None
        PictureBox4.BackgroundImage = CType(resources.GetObject("PictureBox4.BackgroundImage"), Image)
        PictureBox4.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox4.Location = New Point(1094, 135)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(215, 245)
        PictureBox4.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox4.TabIndex = 110
        PictureBox4.TabStop = False
        ' 
        ' TableLayoutPanel5
        ' 
        TableLayoutPanel5.BackColor = Color.Transparent
        TableLayoutPanel5.ColumnCount = 2
        TableLayoutPanel5.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel5.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel5.Controls.Add(Label7, 0, 0)
        TableLayoutPanel5.Location = New Point(193, 196)
        TableLayoutPanel5.Margin = New Padding(3, 4, 3, 4)
        TableLayoutPanel5.Name = "TableLayoutPanel5"
        TableLayoutPanel5.RowCount = 1
        TableLayoutPanel5.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanel5.RowStyles.Add(New RowStyle(SizeType.Absolute, 89F))
        TableLayoutPanel5.Size = New Size(1384, 89)
        TableLayoutPanel5.TabIndex = 105
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.Transparent
        Label7.Font = New Font("Arial Black", 26.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = Color.GhostWhite
        Label7.Location = New Point(0, 27)
        Label7.Margin = New Padding(0, 27, 0, 0)
        Label7.Name = "Label7"
        Label7.Size = New Size(229, 62)
        Label7.TabIndex = 98
        Label7.Text = "STOCKS"
        Label7.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' TableLayoutPanel6
        ' 
        TableLayoutPanel6.BackColor = SystemColors.ScrollBar
        TableLayoutPanel6.ColumnCount = 6
        TableLayoutPanel6.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 16.666666F))
        TableLayoutPanel6.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 16.666666F))
        TableLayoutPanel6.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 16.666666F))
        TableLayoutPanel6.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 16.666666F))
        TableLayoutPanel6.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 16.666666F))
        TableLayoutPanel6.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 16.666666F))
        TableLayoutPanel6.Controls.Add(Button2, 3, 2)
        TableLayoutPanel6.Controls.Add(PictureBox3, 2, 1)
        TableLayoutPanel6.Controls.Add(PictureBox4, 4, 1)
        TableLayoutPanel6.Controls.Add(TableLayoutPanel2, 1, 1)
        TableLayoutPanel6.Controls.Add(PictureBox2, 0, 1)
        TableLayoutPanel6.Controls.Add(Button1, 2, 2)
        TableLayoutPanel6.Controls.Add(TableLayoutPanel1, 3, 1)
        TableLayoutPanel6.Controls.Add(TableLayoutPanel3, 5, 1)
        TableLayoutPanel6.Dock = DockStyle.Bottom
        TableLayoutPanel6.Location = New Point(187, 293)
        TableLayoutPanel6.Margin = New Padding(3, 4, 3, 4)
        TableLayoutPanel6.Name = "TableLayoutPanel6"
        TableLayoutPanel6.RowCount = 3
        TableLayoutPanel6.RowStyles.Add(New RowStyle(SizeType.Percent, 7.03125F))
        TableLayoutPanel6.RowStyles.Add(New RowStyle(SizeType.Percent, 77.92969F))
        TableLayoutPanel6.RowStyles.Add(New RowStyle(SizeType.Percent, 14.84375F))
        TableLayoutPanel6.Size = New Size(1606, 561)
        TableLayoutPanel6.TabIndex = 106
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom
        TableLayoutPanel1.AutoSize = True
        TableLayoutPanel1.ColumnCount = 1
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        TableLayoutPanel1.Controls.Add(priceS2, 0, 7)
        TableLayoutPanel1.Controls.Add(Label3, 0, 6)
        TableLayoutPanel1.Controls.Add(Label5, 0, 0)
        TableLayoutPanel1.Controls.Add(TextBox3, 0, 1)
        TableLayoutPanel1.Controls.Add(ComboBox2, 0, 3)
        TableLayoutPanel1.Controls.Add(Label6, 0, 2)
        TableLayoutPanel1.Controls.Add(Label9, 0, 4)
        TableLayoutPanel1.Controls.Add(TextBox4, 0, 5)
        TableLayoutPanel1.Controls.Add(Label12, 0, 11)
        TableLayoutPanel1.Controls.Add(Label14, 0, 10)
        TableLayoutPanel1.Controls.Add(ComboBox3, 0, 9)
        TableLayoutPanel1.Controls.Add(Label15, 0, 8)
        TableLayoutPanel1.Location = New Point(844, 42)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 12
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 8.333333F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 8.333333F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 8.333333F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 8.333333F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 8.333333F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 8.333333F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 8.333333F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 8.333333F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 8.333333F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 8.333333F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 8.333333F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 8.333333F))
        TableLayoutPanel1.Size = New Size(181, 432)
        TableLayoutPanel1.TabIndex = 111
        ' 
        ' priceS2
        ' 
        priceS2.Anchor = AnchorStyles.Top
        priceS2.AutoSize = True
        priceS2.BackColor = Color.FloralWhite
        priceS2.Font = New Font("Arial", 7.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        priceS2.Location = New Point(83, 255)
        priceS2.Margin = New Padding(3, 10, 3, 0)
        priceS2.Name = "priceS2"
        priceS2.Size = New Size(14, 16)
        priceS2.TabIndex = 14
        priceS2.Text = "#"
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.Top
        Label3.AutoSize = True
        Label3.Font = New Font("Arial Narrow", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(35, 215)
        Label3.Margin = New Padding(0, 5, 0, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(110, 20)
        Label3.TabIndex = 13
        Label3.Text = "UPDATED PRICE"
        ' 
        ' Label5
        ' 
        Label5.Anchor = AnchorStyles.Top
        Label5.AutoSize = True
        Label5.Font = New Font("Arial Narrow", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(65, 5)
        Label5.Margin = New Padding(0, 5, 0, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(51, 20)
        Label5.TabIndex = 1
        Label5.Text = "LABEL"
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(8, 38)
        TextBox3.Margin = New Padding(8, 3, 3, 3)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(170, 27)
        TextBox3.TabIndex = 4
        ' 
        ' ComboBox2
        ' 
        ComboBox2.FormattingEnabled = True
        ComboBox2.Items.AddRange(New Object() {"AVAILABLE", "NOT AVAILABLE"})
        ComboBox2.Location = New Point(10, 108)
        ComboBox2.Margin = New Padding(10, 3, 3, 3)
        ComboBox2.Name = "ComboBox2"
        ComboBox2.Size = New Size(163, 28)
        ComboBox2.TabIndex = 6
        ' 
        ' Label6
        ' 
        Label6.Anchor = AnchorStyles.Top
        Label6.AutoSize = True
        Label6.Font = New Font("Arial Narrow", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(42, 75)
        Label6.Margin = New Padding(0, 5, 0, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(96, 20)
        Label6.TabIndex = 5
        Label6.Text = "AVAILABILITY"
        ' 
        ' Label9
        ' 
        Label9.Anchor = AnchorStyles.Top
        Label9.AutoSize = True
        Label9.Font = New Font("Arial Narrow", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label9.Location = New Point(67, 150)
        Label9.Margin = New Padding(0, 10, 0, 0)
        Label9.Name = "Label9"
        Label9.Size = New Size(47, 20)
        Label9.TabIndex = 11
        Label9.Text = "PRICE"
        Label9.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(8, 178)
        TextBox4.Margin = New Padding(8, 3, 3, 3)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(170, 27)
        TextBox4.TabIndex = 12
        ' 
        ' Label12
        ' 
        Label12.Anchor = AnchorStyles.Top
        Label12.AutoSize = True
        Label12.BackColor = Color.FloralWhite
        Label12.Font = New Font("Arial", 7.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label12.Location = New Point(83, 395)
        Label12.Margin = New Padding(3, 10, 3, 0)
        Label12.Name = "Label12"
        Label12.Size = New Size(14, 16)
        Label12.TabIndex = 7
        Label12.Text = "#"
        ' 
        ' Label14
        ' 
        Label14.Anchor = AnchorStyles.Top
        Label14.AutoSize = True
        Label14.Font = New Font("Arial Narrow", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label14.Location = New Point(28, 360)
        Label14.Margin = New Padding(0, 10, 0, 0)
        Label14.Name = "Label14"
        Label14.Size = New Size(125, 20)
        Label14.TabIndex = 3
        Label14.Text = "CURRENT STOCKS"
        Label14.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' ComboBox3
        ' 
        ComboBox3.FormattingEnabled = True
        ComboBox3.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        ComboBox3.Location = New Point(10, 318)
        ComboBox3.Margin = New Padding(10, 3, 3, 3)
        ComboBox3.Name = "ComboBox3"
        ComboBox3.Size = New Size(163, 28)
        ComboBox3.TabIndex = 10
        ' 
        ' Label15
        ' 
        Label15.Anchor = AnchorStyles.Top
        Label15.AutoSize = True
        Label15.Font = New Font("Arial Narrow", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label15.Location = New Point(33, 285)
        Label15.Margin = New Padding(0, 5, 0, 0)
        Label15.Name = "Label15"
        Label15.Size = New Size(115, 20)
        Label15.TabIndex = 9
        Label15.Text = "UPDATE STOCKS"
        ' 
        ' TableLayoutPanel3
        ' 
        TableLayoutPanel3.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom
        TableLayoutPanel3.AutoSize = True
        TableLayoutPanel3.ColumnCount = 1
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        TableLayoutPanel3.Controls.Add(priceS3, 0, 7)
        TableLayoutPanel3.Controls.Add(Label17, 0, 6)
        TableLayoutPanel3.Controls.Add(Label18, 0, 0)
        TableLayoutPanel3.Controls.Add(TextBox5, 0, 1)
        TableLayoutPanel3.Controls.Add(ComboBox5, 0, 3)
        TableLayoutPanel3.Controls.Add(Label19, 0, 2)
        TableLayoutPanel3.Controls.Add(Label20, 0, 4)
        TableLayoutPanel3.Controls.Add(TextBox6, 0, 5)
        TableLayoutPanel3.Controls.Add(Label21, 0, 11)
        TableLayoutPanel3.Controls.Add(Label22, 0, 10)
        TableLayoutPanel3.Controls.Add(ComboBox6, 0, 9)
        TableLayoutPanel3.Controls.Add(Label23, 0, 8)
        TableLayoutPanel3.Location = New Point(1380, 42)
        TableLayoutPanel3.Name = "TableLayoutPanel3"
        TableLayoutPanel3.RowCount = 12
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Percent, 8.333333F))
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Percent, 8.333333F))
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Percent, 8.333333F))
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Percent, 8.333333F))
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Percent, 8.333333F))
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Percent, 8.333333F))
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Percent, 8.333333F))
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Percent, 8.333333F))
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Percent, 8.333333F))
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Percent, 8.333333F))
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Percent, 8.333333F))
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Percent, 8.333333F))
        TableLayoutPanel3.Size = New Size(181, 432)
        TableLayoutPanel3.TabIndex = 112
        ' 
        ' priceS3
        ' 
        priceS3.Anchor = AnchorStyles.Top
        priceS3.AutoSize = True
        priceS3.BackColor = Color.FloralWhite
        priceS3.Font = New Font("Arial", 7.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        priceS3.Location = New Point(83, 255)
        priceS3.Margin = New Padding(3, 10, 3, 0)
        priceS3.Name = "priceS3"
        priceS3.Size = New Size(14, 16)
        priceS3.TabIndex = 14
        priceS3.Text = "#"
        ' 
        ' Label17
        ' 
        Label17.Anchor = AnchorStyles.Top
        Label17.AutoSize = True
        Label17.Font = New Font("Arial Narrow", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label17.Location = New Point(35, 215)
        Label17.Margin = New Padding(0, 5, 0, 0)
        Label17.Name = "Label17"
        Label17.Size = New Size(110, 20)
        Label17.TabIndex = 13
        Label17.Text = "UPDATED PRICE"
        ' 
        ' Label18
        ' 
        Label18.Anchor = AnchorStyles.Top
        Label18.AutoSize = True
        Label18.Font = New Font("Arial Narrow", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label18.Location = New Point(65, 5)
        Label18.Margin = New Padding(0, 5, 0, 0)
        Label18.Name = "Label18"
        Label18.Size = New Size(51, 20)
        Label18.TabIndex = 1
        Label18.Text = "LABEL"
        ' 
        ' TextBox5
        ' 
        TextBox5.Location = New Point(8, 38)
        TextBox5.Margin = New Padding(8, 3, 3, 3)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(170, 27)
        TextBox5.TabIndex = 4
        ' 
        ' ComboBox5
        ' 
        ComboBox5.FormattingEnabled = True
        ComboBox5.Items.AddRange(New Object() {"AVAILABLE", "NOT AVAILABLE"})
        ComboBox5.Location = New Point(10, 108)
        ComboBox5.Margin = New Padding(10, 3, 3, 3)
        ComboBox5.Name = "ComboBox5"
        ComboBox5.Size = New Size(163, 28)
        ComboBox5.TabIndex = 6
        ' 
        ' Label19
        ' 
        Label19.Anchor = AnchorStyles.Top
        Label19.AutoSize = True
        Label19.Font = New Font("Arial Narrow", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label19.Location = New Point(42, 75)
        Label19.Margin = New Padding(0, 5, 0, 0)
        Label19.Name = "Label19"
        Label19.Size = New Size(96, 20)
        Label19.TabIndex = 5
        Label19.Text = "AVAILABILITY"
        ' 
        ' Label20
        ' 
        Label20.Anchor = AnchorStyles.Top
        Label20.AutoSize = True
        Label20.Font = New Font("Arial Narrow", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label20.Location = New Point(67, 150)
        Label20.Margin = New Padding(0, 10, 0, 0)
        Label20.Name = "Label20"
        Label20.Size = New Size(47, 20)
        Label20.TabIndex = 11
        Label20.Text = "PRICE"
        Label20.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' TextBox6
        ' 
        TextBox6.Location = New Point(8, 178)
        TextBox6.Margin = New Padding(8, 3, 3, 3)
        TextBox6.Name = "TextBox6"
        TextBox6.Size = New Size(170, 27)
        TextBox6.TabIndex = 12
        ' 
        ' Label21
        ' 
        Label21.Anchor = AnchorStyles.Top
        Label21.AutoSize = True
        Label21.BackColor = Color.FloralWhite
        Label21.Font = New Font("Arial", 7.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label21.Location = New Point(83, 395)
        Label21.Margin = New Padding(3, 10, 3, 0)
        Label21.Name = "Label21"
        Label21.Size = New Size(14, 16)
        Label21.TabIndex = 7
        Label21.Text = "#"
        ' 
        ' Label22
        ' 
        Label22.Anchor = AnchorStyles.Top
        Label22.AutoSize = True
        Label22.Font = New Font("Arial Narrow", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label22.Location = New Point(28, 360)
        Label22.Margin = New Padding(0, 10, 0, 0)
        Label22.Name = "Label22"
        Label22.Size = New Size(125, 20)
        Label22.TabIndex = 3
        Label22.Text = "CURRENT STOCKS"
        Label22.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' ComboBox6
        ' 
        ComboBox6.FormattingEnabled = True
        ComboBox6.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        ComboBox6.Location = New Point(10, 318)
        ComboBox6.Margin = New Padding(10, 3, 3, 3)
        ComboBox6.Name = "ComboBox6"
        ComboBox6.Size = New Size(163, 28)
        ComboBox6.TabIndex = 10
        ' 
        ' Label23
        ' 
        Label23.Anchor = AnchorStyles.Top
        Label23.AutoSize = True
        Label23.Font = New Font("Arial Narrow", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label23.Location = New Point(33, 285)
        Label23.Margin = New Padding(0, 5, 0, 0)
        Label23.Name = "Label23"
        Label23.Size = New Size(115, 20)
        Label23.TabIndex = 9
        Label23.Text = "UPDATE STOCKS"
        ' 
        ' AdminForm1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        AutoSize = True
        BackgroundImage = My.Resources.Resources.cover1
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1793, 854)
        Controls.Add(TableLayoutPanel6)
        Controls.Add(TableLayoutPanel5)
        Controls.Add(PnlSidebar)
        Name = "AdminForm1"
        StartPosition = FormStartPosition.WindowsDefaultBounds
        WindowState = FormWindowState.Maximized
        PnlSidebar.ResumeLayout(False)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        TableLayoutPanel2.ResumeLayout(False)
        TableLayoutPanel2.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        TableLayoutPanel5.ResumeLayout(False)
        TableLayoutPanel5.PerformLayout()
        TableLayoutPanel6.ResumeLayout(False)
        TableLayoutPanel6.PerformLayout()
        TableLayoutPanel1.ResumeLayout(False)
        TableLayoutPanel1.PerformLayout()
        TableLayoutPanel3.ResumeLayout(False)
        TableLayoutPanel3.PerformLayout()
        ResumeLayout(False)
    End Sub
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents PnlSidebar As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnBannedList As Button
    Friend WithEvents btnHistory As Button
    Friend WithEvents btnStocks As Button
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents CurrStocks1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents TableLayoutPanel5 As TableLayoutPanel
    Friend WithEvents Label7 As Label
    Friend WithEvents ComboBox4 As ComboBox
    Friend WithEvents TableLayoutPanel6 As TableLayoutPanel
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents priceS As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents priceS2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents Label15 As Label
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents priceS3 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents ComboBox5 As ComboBox
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents Label21 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents ComboBox6 As ComboBox
    Friend WithEvents Label23 As Label
End Class
