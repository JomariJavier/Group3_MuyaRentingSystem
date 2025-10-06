<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        TableLayoutPanel1 = New TableLayoutPanel()
        PictureBox11 = New PictureBox()
        Label1 = New Label()
        Label2 = New Label()
        Label27 = New Label()
        Button1 = New Button()
        Label6 = New Label()
        Label5 = New Label()
        Label12 = New Label()
        Label26 = New Label()
        PictureBox1 = New PictureBox()
        TableLayoutPanel2 = New TableLayoutPanel()
        Label21 = New Label()
        Label4 = New Label()
        TableLayoutPanel1.SuspendLayout()
        CType(PictureBox11, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        TableLayoutPanel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        TableLayoutPanel1.BackColor = Color.FromArgb(CByte(255), CByte(178), CByte(44))
        TableLayoutPanel1.ColumnCount = 3
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.33333F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.3333359F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.33334F))
        TableLayoutPanel1.Controls.Add(PictureBox11, 1, 4)
        TableLayoutPanel1.Controls.Add(Label1, 1, 1)
        TableLayoutPanel1.Controls.Add(Label2, 1, 2)
        TableLayoutPanel1.Controls.Add(Label27, 1, 9)
        TableLayoutPanel1.Controls.Add(Button1, 1, 7)
        TableLayoutPanel1.Controls.Add(Label6, 1, 5)
        TableLayoutPanel1.Controls.Add(Label5, 0, 6)
        TableLayoutPanel1.Controls.Add(Label12, 1, 6)
        TableLayoutPanel1.Location = New Point(0, 423)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 10
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 59.872612F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 26.1146488F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 14.0127392F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle())
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 231F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 23F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 26F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 62F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 107F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 31F))
        TableLayoutPanel1.Size = New Size(1590, 638)
        TableLayoutPanel1.TabIndex = 67
        ' 
        ' PictureBox11
        ' 
        PictureBox11.Anchor = AnchorStyles.Top
        PictureBox11.Image = My.Resources.Resources._05dd3501_2199_49e3_8034_57d5582d7809
        PictureBox11.Location = New Point(689, 172)
        PictureBox11.Margin = New Padding(15, 15, 3, 3)
        PictureBox11.Name = "PictureBox11"
        PictureBox11.Size = New Size(221, 195)
        PictureBox11.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox11.TabIndex = 14
        PictureBox11.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Top
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Arial Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Black
        Label1.Location = New Point(678, 94)
        Label1.Margin = New Padding(0)
        Label1.Name = "Label1"
        Label1.Size = New Size(231, 30)
        Label1.TabIndex = 64
        Label1.Text = "IS THIS CORRECT?"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Top
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.Red
        Label2.Location = New Point(707, 135)
        Label2.Margin = New Padding(0)
        Label2.Name = "Label2"
        Label2.Size = New Size(174, 16)
        Label2.TabIndex = 65
        Label2.Text = "Note: Valid ID is Required*"
        Label2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label27
        ' 
        Label27.Anchor = AnchorStyles.Top
        Label27.AutoSize = True
        Label27.BackColor = Color.Transparent
        Label27.Font = New Font("Arial Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label27.ForeColor = Color.Black
        Label27.Location = New Point(689, 606)
        Label27.Margin = New Padding(0)
        Label27.Name = "Label27"
        Label27.Size = New Size(210, 18)
        Label27.TabIndex = 63
        Label27.Text = "All contents © 2025 Group 3"
        Label27.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Button1
        ' 
        Button1.Anchor = AnchorStyles.Top
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = Color.FromArgb(CByte(16), CByte(46), CByte(80))
        Button1.Location = New Point(749, 440)
        Button1.Margin = New Padding(20, 3, 3, 3)
        Button1.Name = "Button1"
        Button1.Size = New Size(107, 40)
        Button1.TabIndex = 67
        Button1.Text = "CONFIRM"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label6
        ' 
        Label6.Anchor = AnchorStyles.Top
        Label6.AutoSize = True
        Label6.Font = New Font("Arial Black", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.FromArgb(CByte(16), CByte(46), CByte(80))
        Label6.Location = New Point(738, 388)
        Label6.Margin = New Padding(18, 0, 3, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(126, 15)
        Label6.TabIndex = 69
        Label6.Text = "WELDING MACHINE"
        ' 
        ' Label5
        ' 
        Label5.Anchor = AnchorStyles.Top
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Arial Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.Black
        Label5.Location = New Point(264, 411)
        Label5.Margin = New Padding(0)
        Label5.Name = "Label5"
        Label5.Size = New Size(0, 18)
        Label5.TabIndex = 68
        Label5.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label12
        ' 
        Label12.Anchor = AnchorStyles.Top
        Label12.AutoSize = True
        Label12.Font = New Font("Arial Black", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label12.ForeColor = Color.FromArgb(CByte(16), CByte(46), CByte(80))
        Label12.Location = New Point(756, 411)
        Label12.Margin = New Padding(18, 0, 3, 0)
        Label12.Name = "Label12"
        Label12.Size = New Size(91, 15)
        Label12.TabIndex = 70
        Label12.Text = "$100 - per day"
        ' 
        ' Label26
        ' 
        Label26.Anchor = AnchorStyles.Top
        Label26.AutoSize = True
        Label26.BackColor = Color.Transparent
        Label26.Font = New Font("Arial Black", 48F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label26.ForeColor = Color.White
        Label26.Location = New Point(509, 227)
        Label26.Margin = New Padding(3, 0, 0, 0)
        Label26.Name = "Label26"
        Label26.Size = New Size(595, 90)
        Label26.TabIndex = 65
        Label26.Text = "CONFIRMATION"
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
        ' TableLayoutPanel2
        ' 
        TableLayoutPanel2.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        TableLayoutPanel2.BackColor = Color.FromArgb(CByte(11), CByte(29), CByte(81))
        TableLayoutPanel2.ColumnCount = 3
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 47.2955971F))
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 19.308176F))
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.3333321F))
        TableLayoutPanel2.Controls.Add(PictureBox1, 0, 0)
        TableLayoutPanel2.Controls.Add(Label21, 1, 0)
        TableLayoutPanel2.Location = New Point(0, 0)
        TableLayoutPanel2.Name = "TableLayoutPanel2"
        TableLayoutPanel2.RowCount = 1
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Absolute, 20F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Absolute, 20F))
        TableLayoutPanel2.Size = New Size(1590, 115)
        TableLayoutPanel2.TabIndex = 66
        ' 
        ' Label21
        ' 
        Label21.Anchor = AnchorStyles.Top
        Label21.AutoSize = True
        Label21.Cursor = Cursors.Hand
        Label21.Font = New Font("Arial Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label21.ForeColor = Color.White
        Label21.ImageAlign = ContentAlignment.TopCenter
        Label21.Location = New Point(770, 80)
        Label21.Margin = New Padding(0, 80, 220, 0)
        Label21.Name = "Label21"
        Label21.Size = New Size(51, 18)
        Label21.TabIndex = 4
        Label21.Text = "HOME"
        Label21.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.Top
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Arial Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.Transparent
        Label4.Location = New Point(562, 317)
        Label4.Margin = New Padding(0)
        Label4.Name = "Label4"
        Label4.Size = New Size(441, 30)
        Label4.TabIndex = 68
        Label4.Text = "Please Confirm if your Tool is correct"
        Label4.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources._140_Common_Construction_Terms_to_Know
        ClientSize = New Size(1591, 1061)
        Controls.Add(Label4)
        Controls.Add(TableLayoutPanel1)
        Controls.Add(Label26)
        Controls.Add(TableLayoutPanel2)
        Name = "Form3"
        Text = "Form3"
        WindowState = FormWindowState.Maximized
        TableLayoutPanel1.ResumeLayout(False)
        TableLayoutPanel1.PerformLayout()
        CType(PictureBox11, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        TableLayoutPanel2.ResumeLayout(False)
        TableLayoutPanel2.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents PictureBox11 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label26 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents Label21 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label12 As Label
End Class
