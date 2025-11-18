<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Label26 = New Label()
        TableLayoutPanel2 = New TableLayoutPanel()
        Label21 = New Label()
        TableLayoutPanel1 = New TableLayoutPanel()
        TableLayoutPanel3 = New TableLayoutPanel()
        Button2 = New Button()
        Button1 = New Button()
        PictureBox1 = New PictureBox()
        TableLayoutPanel2.SuspendLayout()
        TableLayoutPanel1.SuspendLayout()
        TableLayoutPanel3.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label26
        ' 
        Label26.Anchor = AnchorStyles.Top
        Label26.AutoSize = True
        Label26.BackColor = Color.Transparent
        Label26.Font = New Font("Arial Black", 48F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label26.ForeColor = Color.White
        Label26.Location = New Point(591, 200)
        Label26.Margin = New Padding(3, 0, 0, 0)
        Label26.Name = "Label26"
        Label26.Size = New Size(587, 113)
        Label26.TabIndex = 9
        Label26.Text = "RENT NOW!!"
        ' 
        ' TableLayoutPanel2
        ' 
        TableLayoutPanel2.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        TableLayoutPanel2.BackColor = SystemColors.ControlDarkDark
        TableLayoutPanel2.ColumnCount = 3
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 47.2955971F))
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 19.308176F))
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.3333321F))
        TableLayoutPanel2.Controls.Add(PictureBox1, 0, 0)
        TableLayoutPanel2.Controls.Add(Label21, 1, 0)
        TableLayoutPanel2.Location = New Point(0, 0)
        TableLayoutPanel2.Margin = New Padding(3, 4, 3, 4)
        TableLayoutPanel2.Name = "TableLayoutPanel2"
        TableLayoutPanel2.RowCount = 1
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Absolute, 153F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Absolute, 153F))
        TableLayoutPanel2.Size = New Size(1710, 153)
        TableLayoutPanel2.TabIndex = 11
        ' 
        ' Label21
        ' 
        Label21.Anchor = AnchorStyles.Top
        Label21.AutoSize = True
        Label21.Cursor = Cursors.Hand
        Label21.Font = New Font("Arial Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label21.ForeColor = Color.White
        Label21.ImageAlign = ContentAlignment.TopCenter
        Label21.Location = New Point(815, 107)
        Label21.Margin = New Padding(0, 107, 251, 0)
        Label21.Name = "Label21"
        Label21.Size = New Size(66, 24)
        Label21.TabIndex = 4
        Label21.Text = "HOME"
        Label21.TextAlign = ContentAlignment.TopCenter
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        TableLayoutPanel1.BackColor = SystemColors.ScrollBar
        TableLayoutPanel1.ColumnCount = 3
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.3333321F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.3333321F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.3333321F))
        TableLayoutPanel1.Controls.Add(TableLayoutPanel3, 1, 1)
        TableLayoutPanel1.Location = New Point(0, 421)
        TableLayoutPanel1.Margin = New Padding(2, 3, 2, 3)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 2
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 79.21226F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 20.7877464F))
        TableLayoutPanel1.Size = New Size(1710, 585)
        TableLayoutPanel1.TabIndex = 12
        ' 
        ' TableLayoutPanel3
        ' 
        TableLayoutPanel3.Anchor = AnchorStyles.Top
        TableLayoutPanel3.ColumnCount = 2
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel3.Controls.Add(Button2, 1, 0)
        TableLayoutPanel3.Controls.Add(Button1, 0, 0)
        TableLayoutPanel3.Location = New Point(717, 467)
        TableLayoutPanel3.Margin = New Padding(3, 4, 3, 4)
        TableLayoutPanel3.Name = "TableLayoutPanel3"
        TableLayoutPanel3.RowCount = 1
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Absolute, 27F))
        TableLayoutPanel3.Size = New Size(273, 81)
        TableLayoutPanel3.TabIndex = 79
        ' 
        ' Button2
        ' 
        Button2.Anchor = AnchorStyles.Top
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Font = New Font("Arial Black", 9.75F, FontStyle.Bold)
        Button2.ForeColor = Color.Black
        Button2.Location = New Point(155, 4)
        Button2.Margin = New Padding(3, 4, 3, 4)
        Button2.Name = "Button2"
        Button2.Size = New Size(99, 61)
        Button2.TabIndex = 81
        Button2.Text = "BACK"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Anchor = AnchorStyles.Top
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Arial Black", 9.75F, FontStyle.Bold)
        Button1.ForeColor = Color.Black
        Button1.Location = New Point(8, 4)
        Button1.Margin = New Padding(3, 4, 3, 4)
        Button1.Name = "Button1"
        Button1.Size = New Size(119, 61)
        Button1.TabIndex = 80
        Button1.Text = "CONFIRM"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.Cursor = Cursors.Hand
        PictureBox1.Image = My.Resources.Resources._576101383_1180382820892530_8501663318516642353_n_removebg_preview
        PictureBox1.Location = New Point(29, 12)
        PictureBox1.Margin = New Padding(29, 12, 0, 4)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(147, 134)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 5
        PictureBox1.TabStop = False
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.cover
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1710, 1003)
        Controls.Add(TableLayoutPanel1)
        Controls.Add(TableLayoutPanel2)
        Controls.Add(Label26)
        ForeColor = Color.FromArgb(CByte(16), CByte(46), CByte(80))
        Margin = New Padding(3, 4, 3, 4)
        Name = "Form2"
        Text = "Form2"
        WindowState = FormWindowState.Maximized
        TableLayoutPanel2.ResumeLayout(False)
        TableLayoutPanel2.PerformLayout()
        TableLayoutPanel1.ResumeLayout(False)
        TableLayoutPanel3.ResumeLayout(False)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents PictureBox12 As PictureBox
    Friend WithEvents PictureBox13 As PictureBox
    Friend WithEvents PictureBox14 As PictureBox
    Friend WithEvents Label22 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents Button11 As Button
    Friend WithEvents Button12 As Button
    Friend WithEvents Label26 As Label
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents Label21 As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
