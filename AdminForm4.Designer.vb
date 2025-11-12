<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminForm4
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
        TableLayoutPanel1 = New TableLayoutPanel()
        TextBox18 = New TextBox()
        TextBox17 = New TextBox()
        TextBox16 = New TextBox()
        TextBox15 = New TextBox()
        TextBox14 = New TextBox()
        TextBox13 = New TextBox()
        TextBox12 = New TextBox()
        TextBox11 = New TextBox()
        TextBox10 = New TextBox()
        TextBox9 = New TextBox()
        TextBox8 = New TextBox()
        TextBox7 = New TextBox()
        TextBox6 = New TextBox()
        TextBox5 = New TextBox()
        TextBox4 = New TextBox()
        TextBox3 = New TextBox()
        TextBox2 = New TextBox()
        TextBox1 = New TextBox()
        Label2 = New Label()
        Label1 = New Label()
        Label26 = New Label()
        FlowLayoutPanel1 = New FlowLayoutPanel()
        Button1 = New Button()
        Button2 = New Button()
        Label7 = New Label()
        TableLayoutPanel2 = New TableLayoutPanel()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        PnlSidebar.SuspendLayout()
        TableLayoutPanel1.SuspendLayout()
        FlowLayoutPanel1.SuspendLayout()
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
        PnlSidebar.TabIndex = 78
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        TableLayoutPanel1.BackColor = SystemColors.ScrollBar
        TableLayoutPanel1.ColumnCount = 3
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.33333F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.3333359F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.3333359F))
        TableLayoutPanel1.Controls.Add(TextBox18, 2, 6)
        TableLayoutPanel1.Controls.Add(TextBox17, 1, 6)
        TableLayoutPanel1.Controls.Add(TextBox16, 0, 6)
        TableLayoutPanel1.Controls.Add(TextBox15, 2, 5)
        TableLayoutPanel1.Controls.Add(TextBox14, 1, 5)
        TableLayoutPanel1.Controls.Add(TextBox13, 0, 5)
        TableLayoutPanel1.Controls.Add(TextBox12, 2, 4)
        TableLayoutPanel1.Controls.Add(TextBox11, 1, 4)
        TableLayoutPanel1.Controls.Add(TextBox10, 0, 4)
        TableLayoutPanel1.Controls.Add(TextBox9, 2, 3)
        TableLayoutPanel1.Controls.Add(TextBox8, 1, 3)
        TableLayoutPanel1.Controls.Add(TextBox7, 0, 3)
        TableLayoutPanel1.Controls.Add(TextBox6, 2, 2)
        TableLayoutPanel1.Controls.Add(TextBox5, 1, 2)
        TableLayoutPanel1.Controls.Add(TextBox4, 0, 2)
        TableLayoutPanel1.Controls.Add(TextBox3, 2, 1)
        TableLayoutPanel1.Controls.Add(TextBox2, 1, 1)
        TableLayoutPanel1.Controls.Add(TextBox1, 0, 1)
        TableLayoutPanel1.Controls.Add(Label2, 2, 0)
        TableLayoutPanel1.Controls.Add(Label1, 1, 0)
        TableLayoutPanel1.Controls.Add(Label26, 0, 0)
        TableLayoutPanel1.Controls.Add(FlowLayoutPanel1, 1, 7)
        TableLayoutPanel1.Location = New Point(183, 171)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 8
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 12.5F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 12.5F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 12.5F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 12.5F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 12.5F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 12.5F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 10.606061F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 15.151515F))
        TableLayoutPanel1.Size = New Size(784, 396)
        TableLayoutPanel1.TabIndex = 81
        ' 
        ' TextBox18
        ' 
        TextBox18.Anchor = AnchorStyles.Top
        TextBox18.Location = New Point(551, 297)
        TextBox18.Name = "TextBox18"
        TextBox18.Size = New Size(204, 23)
        TextBox18.TabIndex = 99
        ' 
        ' TextBox17
        ' 
        TextBox17.Anchor = AnchorStyles.Top
        TextBox17.Location = New Point(289, 297)
        TextBox17.Name = "TextBox17"
        TextBox17.Size = New Size(204, 23)
        TextBox17.TabIndex = 98
        ' 
        ' TextBox16
        ' 
        TextBox16.Anchor = AnchorStyles.Top
        TextBox16.Location = New Point(28, 297)
        TextBox16.Name = "TextBox16"
        TextBox16.Size = New Size(204, 23)
        TextBox16.TabIndex = 97
        ' 
        ' TextBox15
        ' 
        TextBox15.Anchor = AnchorStyles.Top
        TextBox15.Location = New Point(551, 248)
        TextBox15.Name = "TextBox15"
        TextBox15.Size = New Size(204, 23)
        TextBox15.TabIndex = 96
        ' 
        ' TextBox14
        ' 
        TextBox14.Anchor = AnchorStyles.Top
        TextBox14.Location = New Point(289, 248)
        TextBox14.Name = "TextBox14"
        TextBox14.Size = New Size(204, 23)
        TextBox14.TabIndex = 95
        ' 
        ' TextBox13
        ' 
        TextBox13.Anchor = AnchorStyles.Top
        TextBox13.Location = New Point(28, 248)
        TextBox13.Name = "TextBox13"
        TextBox13.Size = New Size(204, 23)
        TextBox13.TabIndex = 94
        ' 
        ' TextBox12
        ' 
        TextBox12.Anchor = AnchorStyles.Top
        TextBox12.Location = New Point(551, 199)
        TextBox12.Name = "TextBox12"
        TextBox12.Size = New Size(204, 23)
        TextBox12.TabIndex = 93
        ' 
        ' TextBox11
        ' 
        TextBox11.Anchor = AnchorStyles.Top
        TextBox11.Location = New Point(289, 199)
        TextBox11.Name = "TextBox11"
        TextBox11.Size = New Size(204, 23)
        TextBox11.TabIndex = 92
        ' 
        ' TextBox10
        ' 
        TextBox10.Anchor = AnchorStyles.Top
        TextBox10.Location = New Point(28, 199)
        TextBox10.Name = "TextBox10"
        TextBox10.Size = New Size(204, 23)
        TextBox10.TabIndex = 91
        ' 
        ' TextBox9
        ' 
        TextBox9.Anchor = AnchorStyles.Top
        TextBox9.Location = New Point(551, 150)
        TextBox9.Name = "TextBox9"
        TextBox9.Size = New Size(204, 23)
        TextBox9.TabIndex = 90
        ' 
        ' TextBox8
        ' 
        TextBox8.Anchor = AnchorStyles.Top
        TextBox8.Location = New Point(289, 150)
        TextBox8.Name = "TextBox8"
        TextBox8.Size = New Size(204, 23)
        TextBox8.TabIndex = 89
        ' 
        ' TextBox7
        ' 
        TextBox7.Anchor = AnchorStyles.Top
        TextBox7.Location = New Point(28, 150)
        TextBox7.Name = "TextBox7"
        TextBox7.Size = New Size(204, 23)
        TextBox7.TabIndex = 88
        ' 
        ' TextBox6
        ' 
        TextBox6.Anchor = AnchorStyles.Top
        TextBox6.Location = New Point(551, 101)
        TextBox6.Name = "TextBox6"
        TextBox6.Size = New Size(204, 23)
        TextBox6.TabIndex = 87
        ' 
        ' TextBox5
        ' 
        TextBox5.Anchor = AnchorStyles.Top
        TextBox5.Location = New Point(289, 101)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(204, 23)
        TextBox5.TabIndex = 86
        ' 
        ' TextBox4
        ' 
        TextBox4.Anchor = AnchorStyles.Top
        TextBox4.Location = New Point(28, 101)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(204, 23)
        TextBox4.TabIndex = 85
        ' 
        ' TextBox3
        ' 
        TextBox3.Anchor = AnchorStyles.Top
        TextBox3.Location = New Point(551, 52)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(204, 23)
        TextBox3.TabIndex = 84
        ' 
        ' TextBox2
        ' 
        TextBox2.Anchor = AnchorStyles.Top
        TextBox2.Location = New Point(289, 52)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(204, 23)
        TextBox2.TabIndex = 83
        ' 
        ' TextBox1
        ' 
        TextBox1.Anchor = AnchorStyles.Top
        TextBox1.Location = New Point(28, 52)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(204, 23)
        TextBox1.TabIndex = 82
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
        ' FlowLayoutPanel1
        ' 
        FlowLayoutPanel1.Anchor = AnchorStyles.None
        FlowLayoutPanel1.Controls.Add(Button1)
        FlowLayoutPanel1.Controls.Add(Button2)
        FlowLayoutPanel1.Location = New Point(264, 338)
        FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        FlowLayoutPanel1.Size = New Size(255, 55)
        FlowLayoutPanel1.TabIndex = 83
        ' 
        ' Button1
        ' 
        Button1.Anchor = AnchorStyles.Top
        Button1.BackColor = Color.Transparent
        Button1.FlatStyle = FlatStyle.System
        Button1.Font = New Font("Arial Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = Color.White
        Button1.Location = New Point(60, 3)
        Button1.Margin = New Padding(60, 3, 3, 3)
        Button1.Name = "Button1"
        Button1.Size = New Size(70, 43)
        Button1.TabIndex = 82
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
        Button2.Location = New Point(136, 3)
        Button2.Name = "Button2"
        Button2.Size = New Size(70, 43)
        Button2.TabIndex = 94
        Button2.Text = "Cancel"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Label7
        ' 
        Label7.Anchor = AnchorStyles.Top
        Label7.AutoSize = True
        Label7.BackColor = Color.Transparent
        Label7.Font = New Font("Arial Black", 26.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = Color.GhostWhite
        Label7.Location = New Point(231, 15)
        Label7.Margin = New Padding(0, 15, 0, 0)
        Label7.Name = "Label7"
        Label7.Size = New Size(329, 50)
        Label7.TabIndex = 80
        Label7.Text = "BANNING FORM"
        Label7.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' TableLayoutPanel2
        ' 
        TableLayoutPanel2.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        TableLayoutPanel2.BackColor = Color.Transparent
        TableLayoutPanel2.ColumnCount = 3
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 28.4438782F))
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 44.0051F))
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 27.42347F))
        TableLayoutPanel2.Controls.Add(Label7, 1, 0)
        TableLayoutPanel2.Location = New Point(183, 101)
        TableLayoutPanel2.Name = "TableLayoutPanel2"
        TableLayoutPanel2.RowCount = 1
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanel2.Size = New Size(784, 67)
        TableLayoutPanel2.TabIndex = 99
        ' 
        ' AdminForm4
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.cover1
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(979, 575)
        Controls.Add(TableLayoutPanel2)
        Controls.Add(TableLayoutPanel1)
        Controls.Add(PnlSidebar)
        Name = "AdminForm4"
        Text = "Form1"
        WindowState = FormWindowState.Maximized
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        PnlSidebar.ResumeLayout(False)
        TableLayoutPanel1.ResumeLayout(False)
        TableLayoutPanel1.PerformLayout()
        FlowLayoutPanel1.ResumeLayout(False)
        TableLayoutPanel2.ResumeLayout(False)
        TableLayoutPanel2.PerformLayout()
        ResumeLayout(False)
    End Sub
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnBannedList As Button
    Friend WithEvents btnHistory As Button
    Friend WithEvents btnStocks As Button
    Friend WithEvents PnlSidebar As Panel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TextBox12 As TextBox
    Friend WithEvents TextBox11 As TextBox
    Friend WithEvents TextBox10 As TextBox
    Friend WithEvents TextBox9 As TextBox
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents TextBox18 As TextBox
    Friend WithEvents TextBox17 As TextBox
    Friend WithEvents TextBox16 As TextBox
    Friend WithEvents TextBox15 As TextBox
    Friend WithEvents TextBox14 As TextBox
    Friend WithEvents TextBox13 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
End Class
