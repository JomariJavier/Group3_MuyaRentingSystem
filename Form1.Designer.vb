<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Label2 = New Label()
        Label3 = New Label()
        PictureBox1 = New PictureBox()
        PnlSidebar = New Panel()
        TableLayoutPanel1 = New TableLayoutPanel()
        PictureBox3 = New PictureBox()
        Label27 = New Label()
        Label5 = New Label()
        PictureBox2 = New PictureBox()
        Label1 = New Label()
        Label6 = New Label()
        Label4 = New Label()
        TextBox2 = New TextBox()
        TextBox1 = New TextBox()
        btnToggle = New Button()
        btnBannedList = New Button()
        btnHistory = New Button()
        btnStocks = New Button()
        SidebarTimer = New Timer(components)
        TableLayoutPanel2 = New TableLayoutPanel()
        PictureBox7 = New PictureBox()
        Label10 = New Label()
        Label9 = New Label()
        TextBox4 = New TextBox()
        TextBox3 = New TextBox()
        Label8 = New Label()
        PictureBox4 = New PictureBox()
        Label7 = New Label()
        Label12 = New Label()
        Label14 = New Label()
        TextBox5 = New TextBox()
        TextBox6 = New TextBox()
        TextBox7 = New TextBox()
        TextBox8 = New TextBox()
        TextBox10 = New TextBox()
        TextBox9 = New TextBox()
        Label11 = New Label()
        Label15 = New Label()
        Label16 = New Label()
        Label17 = New Label()
        Label13 = New Label()
        Label18 = New Label()
        Label19 = New Label()
        btnsave = New Button()
        PictureBox5 = New PictureBox()
        PictureBox6 = New PictureBox()
        PictureBox8 = New PictureBox()
        Label26 = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        PnlSidebar.SuspendLayout()
        TableLayoutPanel1.SuspendLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        TableLayoutPanel2.SuspendLayout()
        CType(PictureBox7, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox6, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox8, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Top
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Mongolian Baiti", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.White
        Label2.Location = New Point(798, 380)
        Label2.Margin = New Padding(800, 70, 200, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(0, 25)
        Label2.TabIndex = 1
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.Top
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Arial Black", 36F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.LavenderBlush
        Label3.Location = New Point(589, 51)
        Label3.Margin = New Padding(10, 70, 0, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(556, 68)
        Label3.TabIndex = 10
        Label3.Text = "MUYA'S HARDWARE"
        Label3.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.FromArgb(CByte(11), CByte(29), CByte(81))
        PictureBox1.Cursor = Cursors.Hand
        PictureBox1.Image = My.Resources.Resources._05dd3501_2199_49e3_8034_57d5582d7809_removebg_preview1
        PictureBox1.Location = New Point(25, 9)
        PictureBox1.Margin = New Padding(25, 9, 0, 3)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(114, 98)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 3
        PictureBox1.TabStop = False
        ' 
        ' PnlSidebar
        ' 
        PnlSidebar.BackColor = Color.FromArgb(CByte(11), CByte(29), CByte(81))
        PnlSidebar.Controls.Add(TableLayoutPanel1)
        PnlSidebar.Controls.Add(btnToggle)
        PnlSidebar.Controls.Add(btnBannedList)
        PnlSidebar.Controls.Add(btnHistory)
        PnlSidebar.Controls.Add(PictureBox1)
        PnlSidebar.Controls.Add(btnStocks)
        PnlSidebar.Dock = DockStyle.Left
        PnlSidebar.ForeColor = Color.White
        PnlSidebar.Location = New Point(0, 0)
        PnlSidebar.Name = "PnlSidebar"
        PnlSidebar.Size = New Size(172, 881)
        PnlSidebar.TabIndex = 14
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.BackColor = Color.FromArgb(CByte(255), CByte(178), CByte(44))
        TableLayoutPanel1.ColumnCount = 6
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 16.2313442F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 55.8189659F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 28.01724F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 133F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 445F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 358F))
        TableLayoutPanel1.Controls.Add(PictureBox3, 0, 0)
        TableLayoutPanel1.Controls.Add(Label27, 1, 9)
        TableLayoutPanel1.Controls.Add(Label5, 0, 6)
        TableLayoutPanel1.Controls.Add(PictureBox2, 1, 1)
        TableLayoutPanel1.Controls.Add(Label1, 2, 1)
        TableLayoutPanel1.Controls.Add(Label6, 3, 2)
        TableLayoutPanel1.Controls.Add(Label4, 2, 2)
        TableLayoutPanel1.Controls.Add(TextBox2, 3, 4)
        TableLayoutPanel1.Controls.Add(TextBox1, 2, 4)
        TableLayoutPanel1.Location = New Point(178, 423)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 10
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 23.1231232F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 56.7567558F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 20.120121F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle())
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 55F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 23F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 26F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 62F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 107F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 31F))
        TableLayoutPanel1.Size = New Size(1419, 638)
        TableLayoutPanel1.TabIndex = 68
        ' 
        ' PictureBox3
        ' 
        PictureBox3.BackColor = Color.Transparent
        PictureBox3.Cursor = Cursors.Hand
        PictureBox3.Image = My.Resources.Resources._05dd3501_2199_49e3_8034_57d5582d7809_removebg_preview1
        PictureBox3.Location = New Point(25, 9)
        PictureBox3.Margin = New Padding(25, 9, 0, 3)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(53, 65)
        PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox3.TabIndex = 74
        PictureBox3.TabStop = False
        ' 
        ' Label27
        ' 
        Label27.Anchor = AnchorStyles.Top
        Label27.AutoSize = True
        Label27.BackColor = Color.Transparent
        Label27.Font = New Font("Arial Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label27.ForeColor = Color.Black
        Label27.Location = New Point(107, 606)
        Label27.Margin = New Padding(0)
        Label27.Name = "Label27"
        Label27.Size = New Size(210, 18)
        Label27.TabIndex = 63
        Label27.Text = "All contents © 2025 Group 3"
        Label27.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label5
        ' 
        Label5.Anchor = AnchorStyles.Top
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Arial Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.Black
        Label5.Location = New Point(39, 411)
        Label5.Margin = New Padding(0)
        Label5.Name = "Label5"
        Label5.Size = New Size(0, 18)
        Label5.TabIndex = 68
        Label5.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = Color.Transparent
        PictureBox2.Cursor = Cursors.Hand
        PictureBox2.Image = My.Resources.Resources._05dd3501_2199_49e3_8034_57d5582d7809_removebg_preview1
        PictureBox2.Location = New Point(103, 86)
        PictureBox2.Margin = New Padding(25, 9, 0, 3)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(244, 177)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 15
        PictureBox2.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.None
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(393, 161)
        Label1.Name = "Label1"
        Label1.Size = New Size(43, 21)
        Label1.TabIndex = 69
        Label1.Text = "Drill"
        ' 
        ' Label6
        ' 
        Label6.Anchor = AnchorStyles.None
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(490, 279)
        Label6.Name = "Label6"
        Label6.Size = New Size(117, 40)
        Label6.TabIndex = 71
        Label6.Text = "Update Current Stocks"
        Label6.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.None
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(354, 289)
        Label4.Name = "Label4"
        Label4.Size = New Size(120, 21)
        Label4.TabIndex = 70
        Label4.Text = "Current Stocks"
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(485, 336)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(127, 23)
        TextBox2.TabIndex = 73
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(350, 336)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(129, 23)
        TextBox1.TabIndex = 72
        ' 
        ' btnToggle
        ' 
        btnToggle.BackColor = Color.Transparent
        btnToggle.BackgroundImage = CType(resources.GetObject("btnToggle.BackgroundImage"), Image)
        btnToggle.Cursor = Cursors.Hand
        btnToggle.FlatStyle = FlatStyle.Flat
        btnToggle.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnToggle.Location = New Point(25, 122)
        btnToggle.Name = "btnToggle"
        btnToggle.Size = New Size(114, 33)
        btnToggle.TabIndex = 7
        btnToggle.Text = "☰"
        btnToggle.UseVisualStyleBackColor = False
        ' 
        ' btnBannedList
        ' 
        btnBannedList.BackColor = Color.Transparent
        btnBannedList.Cursor = Cursors.Hand
        btnBannedList.FlatStyle = FlatStyle.Flat
        btnBannedList.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnBannedList.ForeColor = Color.White
        btnBannedList.Location = New Point(25, 357)
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
        btnHistory.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnHistory.ForeColor = Color.White
        btnHistory.Location = New Point(25, 295)
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
        btnStocks.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnStocks.ForeColor = Color.White
        btnStocks.Location = New Point(25, 230)
        btnStocks.Name = "btnStocks"
        btnStocks.Size = New Size(114, 34)
        btnStocks.TabIndex = 4
        btnStocks.Text = "Stocks"
        btnStocks.UseVisualStyleBackColor = False
        ' 
        ' SidebarTimer
        ' 
        SidebarTimer.Interval = 10
        ' 
        ' TableLayoutPanel2
        ' 
        TableLayoutPanel2.Anchor = AnchorStyles.Top
        TableLayoutPanel2.BackColor = Color.FromArgb(CByte(255), CByte(178), CByte(44))
        TableLayoutPanel2.ColumnCount = 8
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 6.140351F))
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 21.9298248F))
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 8.77193F))
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 13.1578951F))
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 21.9298248F))
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 8.77193F))
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 13.1578951F))
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 6.140351F))
        TableLayoutPanel2.Controls.Add(PictureBox7, 4, 4)
        TableLayoutPanel2.Controls.Add(Label10, 2, 1)
        TableLayoutPanel2.Controls.Add(Label9, 2, 2)
        TableLayoutPanel2.Controls.Add(TextBox4, 3, 3)
        TableLayoutPanel2.Controls.Add(TextBox3, 2, 3)
        TableLayoutPanel2.Controls.Add(Label8, 3, 2)
        TableLayoutPanel2.Controls.Add(PictureBox4, 1, 1)
        TableLayoutPanel2.Controls.Add(Label7, 5, 1)
        TableLayoutPanel2.Controls.Add(Label12, 5, 2)
        TableLayoutPanel2.Controls.Add(Label14, 6, 2)
        TableLayoutPanel2.Controls.Add(TextBox5, 5, 3)
        TableLayoutPanel2.Controls.Add(TextBox6, 6, 3)
        TableLayoutPanel2.Controls.Add(TextBox7, 2, 6)
        TableLayoutPanel2.Controls.Add(TextBox8, 3, 6)
        TableLayoutPanel2.Controls.Add(TextBox10, 6, 6)
        TableLayoutPanel2.Controls.Add(TextBox9, 5, 6)
        TableLayoutPanel2.Controls.Add(Label11, 2, 5)
        TableLayoutPanel2.Controls.Add(Label15, 5, 5)
        TableLayoutPanel2.Controls.Add(Label16, 3, 5)
        TableLayoutPanel2.Controls.Add(Label17, 6, 5)
        TableLayoutPanel2.Controls.Add(Label13, 4, 7)
        TableLayoutPanel2.Controls.Add(Label18, 2, 4)
        TableLayoutPanel2.Controls.Add(Label19, 5, 4)
        TableLayoutPanel2.Controls.Add(btnsave, 7, 7)
        TableLayoutPanel2.Controls.Add(PictureBox5, 4, 1)
        TableLayoutPanel2.Controls.Add(PictureBox6, 1, 4)
        TableLayoutPanel2.Location = New Point(220, 323)
        TableLayoutPanel2.Name = "TableLayoutPanel2"
        TableLayoutPanel2.RowCount = 8
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 7.60869551F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 27.173914F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 7.60869551F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 7.60869551F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 27.173914F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 7.60869551F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 7.60869551F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 7.60869551F))
        TableLayoutPanel2.Size = New Size(1324, 558)
        TableLayoutPanel2.TabIndex = 19
        ' 
        ' PictureBox7
        ' 
        PictureBox7.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        PictureBox7.BackColor = Color.FromArgb(CByte(11), CByte(29), CByte(81))
        PictureBox7.Cursor = Cursors.Hand
        PictureBox7.Image = My.Resources.Resources._05dd3501_2199_49e3_8034_57d5582d7809_removebg_preview1
        PictureBox7.Location = New Point(686, 287)
        PictureBox7.Margin = New Padding(25, 9, 0, 3)
        PictureBox7.Name = "PictureBox7"
        PictureBox7.Size = New Size(265, 137)
        PictureBox7.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox7.TabIndex = 72
        PictureBox7.TabStop = False
        ' 
        ' Label10
        ' 
        Label10.Anchor = AnchorStyles.None
        Label10.AutoSize = True
        Label10.BackColor = Color.Transparent
        Label10.Font = New Font("Arial Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label10.ForeColor = Color.FromArgb(CByte(16), CByte(46), CByte(80))
        Label10.Location = New Point(386, 108)
        Label10.Margin = New Padding(0)
        Label10.Name = "Label10"
        Label10.Size = New Size(85, 18)
        Label10.TabIndex = 1
        Label10.Text = "Power Drill"
        Label10.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label9
        ' 
        Label9.Anchor = AnchorStyles.Top
        Label9.AutoSize = True
        Label9.BackColor = Color.Transparent
        Label9.Font = New Font("Arial Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label9.ForeColor = Color.Black
        Label9.Location = New Point(397, 193)
        Label9.Margin = New Padding(0)
        Label9.Name = "Label9"
        Label9.Size = New Size(64, 36)
        Label9.TabIndex = 2
        Label9.Text = "Current Stocks"
        Label9.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' TextBox4
        ' 
        TextBox4.Anchor = AnchorStyles.None
        TextBox4.Location = New Point(524, 244)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(100, 23)
        TextBox4.TabIndex = 10
        ' 
        ' TextBox3
        ' 
        TextBox3.Anchor = AnchorStyles.None
        TextBox3.Location = New Point(374, 244)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(109, 23)
        TextBox3.TabIndex = 9
        TextBox3.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label8
        ' 
        Label8.Anchor = AnchorStyles.Top
        Label8.AutoSize = True
        Label8.BackColor = Color.Transparent
        Label8.Font = New Font("Arial Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.ForeColor = Color.FromArgb(CByte(16), CByte(46), CByte(80))
        Label8.Location = New Point(516, 193)
        Label8.Margin = New Padding(0)
        Label8.Name = "Label8"
        Label8.Size = New Size(115, 18)
        Label8.TabIndex = 3
        Label8.Text = "Update Stocks"
        Label8.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' PictureBox4
        ' 
        PictureBox4.BackColor = Color.FromArgb(CByte(11), CByte(29), CByte(81))
        PictureBox4.Cursor = Cursors.Hand
        PictureBox4.Image = My.Resources.Resources._05dd3501_2199_49e3_8034_57d5582d7809_removebg_preview1
        PictureBox4.Location = New Point(106, 51)
        PictureBox4.Margin = New Padding(25, 9, 0, 3)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(263, 137)
        PictureBox4.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox4.TabIndex = 8
        PictureBox4.TabStop = False
        ' 
        ' Label7
        ' 
        Label7.Anchor = AnchorStyles.None
        Label7.AutoSize = True
        Label7.BackColor = Color.Transparent
        Label7.Font = New Font("Arial Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = Color.Black
        Label7.Location = New Point(974, 99)
        Label7.Margin = New Padding(0)
        Label7.Name = "Label7"
        Label7.Size = New Size(69, 36)
        Label7.TabIndex = 4
        Label7.Text = "Welding Machine"
        Label7.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label12
        ' 
        Label12.Anchor = AnchorStyles.Top
        Label12.AutoSize = True
        Label12.BackColor = Color.Transparent
        Label12.Font = New Font("Arial Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label12.ForeColor = Color.Black
        Label12.Location = New Point(977, 193)
        Label12.Margin = New Padding(0)
        Label12.Name = "Label12"
        Label12.Size = New Size(64, 36)
        Label12.TabIndex = 12
        Label12.Text = "Current Stocks"
        Label12.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label14
        ' 
        Label14.Anchor = AnchorStyles.Top
        Label14.AutoSize = True
        Label14.BackColor = Color.Transparent
        Label14.Font = New Font("Arial Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label14.ForeColor = Color.FromArgb(CByte(16), CByte(46), CByte(80))
        Label14.Location = New Point(1096, 193)
        Label14.Margin = New Padding(0)
        Label14.Name = "Label14"
        Label14.Size = New Size(115, 18)
        Label14.TabIndex = 13
        Label14.Text = "Update Stocks"
        Label14.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' TextBox5
        ' 
        TextBox5.Anchor = AnchorStyles.None
        TextBox5.Location = New Point(954, 244)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(109, 23)
        TextBox5.TabIndex = 14
        TextBox5.TextAlign = HorizontalAlignment.Center
        ' 
        ' TextBox6
        ' 
        TextBox6.Anchor = AnchorStyles.None
        TextBox6.Location = New Point(1089, 244)
        TextBox6.Name = "TextBox6"
        TextBox6.Size = New Size(129, 23)
        TextBox6.TabIndex = 15
        TextBox6.TextAlign = HorizontalAlignment.Center
        ' 
        ' TextBox7
        ' 
        TextBox7.Anchor = AnchorStyles.None
        TextBox7.Location = New Point(374, 479)
        TextBox7.Name = "TextBox7"
        TextBox7.Size = New Size(109, 23)
        TextBox7.TabIndex = 18
        TextBox7.TextAlign = HorizontalAlignment.Center
        ' 
        ' TextBox8
        ' 
        TextBox8.Anchor = AnchorStyles.None
        TextBox8.Location = New Point(511, 479)
        TextBox8.Name = "TextBox8"
        TextBox8.Size = New Size(126, 23)
        TextBox8.TabIndex = 19
        TextBox8.TextAlign = HorizontalAlignment.Center
        ' 
        ' TextBox10
        ' 
        TextBox10.Anchor = AnchorStyles.None
        TextBox10.Location = New Point(1089, 479)
        TextBox10.Name = "TextBox10"
        TextBox10.Size = New Size(129, 23)
        TextBox10.TabIndex = 21
        TextBox10.TextAlign = HorizontalAlignment.Center
        ' 
        ' TextBox9
        ' 
        TextBox9.Anchor = AnchorStyles.None
        TextBox9.Location = New Point(954, 479)
        TextBox9.Name = "TextBox9"
        TextBox9.Size = New Size(109, 23)
        TextBox9.TabIndex = 20
        TextBox9.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label11
        ' 
        Label11.Anchor = AnchorStyles.Top
        Label11.AutoSize = True
        Label11.BackColor = Color.Transparent
        Label11.Font = New Font("Arial Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label11.ForeColor = Color.Black
        Label11.Location = New Point(397, 428)
        Label11.Margin = New Padding(0)
        Label11.Name = "Label11"
        Label11.Size = New Size(64, 36)
        Label11.TabIndex = 22
        Label11.Text = "Current Stocks"
        Label11.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label15
        ' 
        Label15.Anchor = AnchorStyles.Top
        Label15.AutoSize = True
        Label15.BackColor = Color.Transparent
        Label15.Font = New Font("Arial Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label15.ForeColor = Color.Black
        Label15.Location = New Point(977, 428)
        Label15.Margin = New Padding(0)
        Label15.Name = "Label15"
        Label15.Size = New Size(64, 36)
        Label15.TabIndex = 23
        Label15.Text = "Current Stocks"
        Label15.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label16
        ' 
        Label16.Anchor = AnchorStyles.Top
        Label16.AutoSize = True
        Label16.BackColor = Color.Transparent
        Label16.Font = New Font("Arial Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label16.ForeColor = Color.FromArgb(CByte(16), CByte(46), CByte(80))
        Label16.Location = New Point(516, 428)
        Label16.Margin = New Padding(0)
        Label16.Name = "Label16"
        Label16.Size = New Size(115, 18)
        Label16.TabIndex = 24
        Label16.Text = "Update Stocks"
        Label16.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label17
        ' 
        Label17.Anchor = AnchorStyles.Top
        Label17.AutoSize = True
        Label17.BackColor = Color.Transparent
        Label17.Font = New Font("Arial Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label17.ForeColor = Color.FromArgb(CByte(16), CByte(46), CByte(80))
        Label17.Location = New Point(1096, 428)
        Label17.Margin = New Padding(0)
        Label17.Name = "Label17"
        Label17.Size = New Size(115, 18)
        Label17.TabIndex = 25
        Label17.Text = "Update Stocks"
        Label17.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label13
        ' 
        Label13.Anchor = AnchorStyles.Top
        Label13.AutoSize = True
        Label13.BackColor = Color.Transparent
        Label13.Font = New Font("Arial Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label13.ForeColor = Color.Black
        Label13.Location = New Point(701, 512)
        Label13.Margin = New Padding(0)
        Label13.Name = "Label13"
        Label13.Size = New Size(210, 18)
        Label13.TabIndex = 7
        Label13.Text = "All contents © 2025 Group 3"
        Label13.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label18
        ' 
        Label18.Anchor = AnchorStyles.None
        Label18.AutoSize = True
        Label18.BackColor = Color.Transparent
        Label18.Font = New Font("Arial Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label18.ForeColor = Color.Black
        Label18.Location = New Point(410, 343)
        Label18.Margin = New Padding(0)
        Label18.Name = "Label18"
        Label18.Size = New Size(38, 18)
        Label18.TabIndex = 26
        Label18.Text = "Saw"
        Label18.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label19
        ' 
        Label19.Anchor = AnchorStyles.None
        Label19.AutoSize = True
        Label19.BackColor = Color.Transparent
        Label19.Font = New Font("Arial Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label19.ForeColor = Color.Black
        Label19.Location = New Point(974, 343)
        Label19.Margin = New Padding(0)
        Label19.Name = "Label19"
        Label19.Size = New Size(69, 18)
        Label19.TabIndex = 27
        Label19.Text = "Nail Gun"
        Label19.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' btnsave
        ' 
        btnsave.Anchor = AnchorStyles.None
        btnsave.Location = New Point(1245, 523)
        btnsave.Name = "btnsave"
        btnsave.Size = New Size(75, 23)
        btnsave.TabIndex = 28
        btnsave.Text = "SAVE"
        btnsave.UseVisualStyleBackColor = True
        ' 
        ' PictureBox5
        ' 
        PictureBox5.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        PictureBox5.BackColor = Color.FromArgb(CByte(11), CByte(29), CByte(81))
        PictureBox5.Cursor = Cursors.Hand
        PictureBox5.Image = My.Resources.Resources._05dd3501_2199_49e3_8034_57d5582d7809_removebg_preview1
        PictureBox5.Location = New Point(686, 52)
        PictureBox5.Margin = New Padding(25, 9, 0, 3)
        PictureBox5.Name = "PictureBox5"
        PictureBox5.Size = New Size(265, 137)
        PictureBox5.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox5.TabIndex = 29
        PictureBox5.TabStop = False
        ' 
        ' PictureBox6
        ' 
        PictureBox6.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        PictureBox6.BackColor = Color.FromArgb(CByte(11), CByte(29), CByte(81))
        PictureBox6.Cursor = Cursors.Hand
        PictureBox6.Image = My.Resources.Resources._05dd3501_2199_49e3_8034_57d5582d7809_removebg_preview1
        PictureBox6.Location = New Point(106, 287)
        PictureBox6.Margin = New Padding(25, 9, 0, 3)
        PictureBox6.Name = "PictureBox6"
        PictureBox6.Size = New Size(265, 137)
        PictureBox6.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox6.TabIndex = 30
        PictureBox6.TabStop = False
        ' 
        ' PictureBox8
        ' 
        PictureBox8.BackColor = Color.Transparent
        PictureBox8.Cursor = Cursors.Hand
        PictureBox8.Image = My.Resources.Resources._05dd3501_2199_49e3_8034_57d5582d7809_removebg_preview1
        PictureBox8.Location = New Point(465, 27)
        PictureBox8.Margin = New Padding(25, 9, 0, 3)
        PictureBox8.Name = "PictureBox8"
        PictureBox8.Size = New Size(129, 112)
        PictureBox8.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox8.TabIndex = 20
        PictureBox8.TabStop = False
        ' 
        ' Label26
        ' 
        Label26.AutoSize = True
        Label26.BackColor = Color.Transparent
        Label26.Font = New Font("Arial Black", 48F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label26.ForeColor = Color.White
        Label26.Location = New Point(220, 230)
        Label26.Margin = New Padding(3, 0, 0, 0)
        Label26.Name = "Label26"
        Label26.Size = New Size(330, 90)
        Label26.TabIndex = 71
        Label26.Text = "STOCKS"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources._140_Common_Construction_Terms_to_Know1
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1591, 881)
        Controls.Add(Label26)
        Controls.Add(PictureBox8)
        Controls.Add(TableLayoutPanel2)
        Controls.Add(Label2)
        Controls.Add(Label3)
        Controls.Add(PnlSidebar)
        Name = "Form1"
        Text = "Form1"
        WindowState = FormWindowState.Maximized
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        PnlSidebar.ResumeLayout(False)
        TableLayoutPanel1.ResumeLayout(False)
        TableLayoutPanel1.PerformLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        TableLayoutPanel2.ResumeLayout(False)
        TableLayoutPanel2.PerformLayout()
        CType(PictureBox7, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox6, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox8, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PnlSidebar As Panel
    Friend WithEvents btnStocks As Button
    Friend WithEvents btnBannedList As Button
    Friend WithEvents btnHistory As Button
    Friend WithEvents SidebarTimer As Timer
    Friend WithEvents btnToggle As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Label27 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents TextBox10 As TextBox
    Friend WithEvents TextBox9 As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents btnsave As Button
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents Label26 As Label
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox6 As PictureBox

End Class
