<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LOGIN
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
        Label7 = New Label()
        TableLayoutPanel1 = New TableLayoutPanel()
        TableLayoutPanel2 = New TableLayoutPanel()
        Label1 = New Label()
        TextBox2 = New TextBox()
        Label8 = New Label()
        Button1 = New Button()
        TextBox1 = New TextBox()
        FileSystemWatcher1 = New IO.FileSystemWatcher()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        TableLayoutPanel1.SuspendLayout()
        TableLayoutPanel2.SuspendLayout()
        CType(FileSystemWatcher1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Anchor = AnchorStyles.None
        PictureBox1.BackColor = SystemColors.ScrollBar
        PictureBox1.Cursor = Cursors.Hand
        PictureBox1.Image = My.Resources.Resources._578935847_1627970941508389_3020005775530561214_n_removebg_preview
        PictureBox1.Location = New Point(169, 14)
        PictureBox1.Margin = New Padding(9, 7, 0, 4)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(162, 169)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 3
        PictureBox1.TabStop = False
        ' 
        ' Label7
        ' 
        Label7.Anchor = AnchorStyles.Top
        Label7.AutoSize = True
        Label7.BackColor = Color.Transparent
        Label7.Font = New Font("Arial Black", 26.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = Color.GhostWhite
        Label7.Location = New Point(379, 33)
        Label7.Margin = New Padding(0, 33, 0, 0)
        Label7.Name = "Label7"
        Label7.Size = New Size(362, 62)
        Label7.TabIndex = 83
        Label7.Text = "ADMIN LOGIN"
        Label7.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        TableLayoutPanel1.AutoSize = True
        TableLayoutPanel1.BackColor = SystemColors.ControlDarkDark
        TableLayoutPanel1.ColumnCount = 3
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 29.9329033F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 40.1341972F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 29.9329033F))
        TableLayoutPanel1.Controls.Add(Label7, 1, 0)
        TableLayoutPanel1.Location = New Point(0, 0)
        TableLayoutPanel1.Margin = New Padding(3, 4, 3, 4)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 1
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanel1.Size = New Size(1122, 133)
        TableLayoutPanel1.TabIndex = 84
        ' 
        ' TableLayoutPanel2
        ' 
        TableLayoutPanel2.Anchor = AnchorStyles.Top
        TableLayoutPanel2.AutoSize = True
        TableLayoutPanel2.BackColor = SystemColors.ScrollBar
        TableLayoutPanel2.ColumnCount = 3
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 29.9329F))
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 40.1341972F))
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 29.9329033F))
        TableLayoutPanel2.Controls.Add(Label1, 1, 3)
        TableLayoutPanel2.Controls.Add(TextBox2, 1, 4)
        TableLayoutPanel2.Controls.Add(Label8, 1, 1)
        TableLayoutPanel2.Controls.Add(Button1, 1, 5)
        TableLayoutPanel2.Controls.Add(PictureBox1, 1, 0)
        TableLayoutPanel2.Controls.Add(TextBox1, 1, 2)
        TableLayoutPanel2.Location = New Point(321, 176)
        TableLayoutPanel2.Margin = New Padding(3, 4, 3, 4)
        TableLayoutPanel2.Name = "TableLayoutPanel2"
        TableLayoutPanel2.RowCount = 6
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 36.4532F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 8.374384F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 12.3152714F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 8.128078F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 14.2857141F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 21.6748772F))
        TableLayoutPanel2.Size = New Size(493, 541)
        TableLayoutPanel2.TabIndex = 85
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Top
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Arial Black", 9.75F, FontStyle.Bold)
        Label1.ForeColor = Color.Black
        Label1.ImageAlign = ContentAlignment.TopCenter
        Label1.Location = New Point(199, 316)
        Label1.Margin = New Padding(6, 13, 0, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(99, 24)
        Label1.TabIndex = 89
        Label1.Text = "Password"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' TextBox2
        ' 
        TextBox2.Anchor = AnchorStyles.None
        TextBox2.Location = New Point(151, 370)
        TextBox2.Margin = New Padding(3, 4, 3, 4)
        TextBox2.Name = "TextBox2"
        TextBox2.PasswordChar = "*"c
        TextBox2.Size = New Size(189, 27)
        TextBox2.TabIndex = 86
        ' 
        ' Label8
        ' 
        Label8.Anchor = AnchorStyles.Top
        Label8.AutoSize = True
        Label8.BackColor = Color.Transparent
        Label8.Font = New Font("Arial Black", 9.75F, FontStyle.Bold)
        Label8.ForeColor = Color.Black
        Label8.ImageAlign = ContentAlignment.TopCenter
        Label8.Location = New Point(196, 207)
        Label8.Margin = New Padding(6, 13, 0, 0)
        Label8.Name = "Label8"
        Label8.Size = New Size(104, 24)
        Label8.TabIndex = 88
        Label8.Text = "Username"
        Label8.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Button1
        ' 
        Button1.Anchor = AnchorStyles.Top
        Button1.BackColor = Color.Transparent
        Button1.FlatStyle = FlatStyle.System
        Button1.Font = New Font("Arial Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = Color.White
        Button1.Location = New Point(178, 422)
        Button1.Margin = New Padding(6, 0, 3, 4)
        Button1.Name = "Button1"
        Button1.Size = New Size(137, 60)
        Button1.TabIndex = 96
        Button1.Text = "Enter"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' TextBox1
        ' 
        TextBox1.Anchor = AnchorStyles.None
        TextBox1.Location = New Point(155, 257)
        TextBox1.Margin = New Padding(3, 4, 3, 4)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(180, 27)
        TextBox1.TabIndex = 4
        ' 
        ' FileSystemWatcher1
        ' 
        FileSystemWatcher1.EnableRaisingEvents = True
        FileSystemWatcher1.SynchronizingObject = Me
        ' 
        ' LOGIN
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        AutoSize = True
        BackgroundImage = My.Resources.Resources.cover1
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1119, 767)
        Controls.Add(TableLayoutPanel2)
        Controls.Add(TableLayoutPanel1)
        Margin = New Padding(3, 4, 3, 4)
        Name = "LOGIN"
        Text = "Form1"
        WindowState = FormWindowState.Maximized
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        TableLayoutPanel1.ResumeLayout(False)
        TableLayoutPanel1.PerformLayout()
        TableLayoutPanel2.ResumeLayout(False)
        TableLayoutPanel2.PerformLayout()
        CType(FileSystemWatcher1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents FileSystemWatcher1 As IO.FileSystemWatcher
End Class
