<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Timer = New System.Windows.Forms.Timer(Me.components)
        Me.lblValue = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.pic1 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.pic2 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblRunningScore1 = New System.Windows.Forms.Label()
        Me.lblRunningScore2 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblTotalScore1 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblTotalScore2 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer
        '
        Me.Timer.Interval = 30
        '
        'lblValue
        '
        Me.lblValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblValue.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblValue.Location = New System.Drawing.Point(557, 21)
        Me.lblValue.Name = "lblValue"
        Me.lblValue.Size = New System.Drawing.Size(192, 87)
        Me.lblValue.TabIndex = 3
        Me.lblValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Josh_and_Divine_Capstone_Project.My.Resources.Resources._69998644_EE6F_43B7_A43A_49E98CDE9CC7_removebg_preview
        Me.PictureBox1.Location = New System.Drawing.Point(31, 45)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(189, 388)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'pic1
        '
        Me.pic1.Image = Global.Josh_and_Divine_Capstone_Project.My.Resources.Resources.O1
        Me.pic1.Location = New System.Drawing.Point(259, 127)
        Me.pic1.Name = "pic1"
        Me.pic1.Size = New System.Drawing.Size(816, 699)
        Me.pic1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic1.TabIndex = 0
        Me.pic1.TabStop = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(31, 772)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(136, 54)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'pic2
        '
        Me.pic2.Image = Global.Josh_and_Divine_Capstone_Project.My.Resources.Resources._69998644_EE6F_43B7_A43A_49E98CDE9CC7_removebg_preview
        Me.pic2.Location = New System.Drawing.Point(1119, 45)
        Me.pic2.Name = "pic2"
        Me.pic2.Size = New System.Drawing.Size(189, 388)
        Me.pic2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic2.TabIndex = 5
        Me.pic2.TabStop = False
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(45, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(165, 41)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Player 1"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(1130, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(165, 41)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Player 2"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(25, 325)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(208, 45)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Score (Round)"
        '
        'lblRunningScore1
        '
        Me.lblRunningScore1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblRunningScore1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRunningScore1.Location = New System.Drawing.Point(28, 370)
        Me.lblRunningScore1.Name = "lblRunningScore1"
        Me.lblRunningScore1.Size = New System.Drawing.Size(192, 79)
        Me.lblRunningScore1.TabIndex = 9
        Me.lblRunningScore1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblRunningScore2
        '
        Me.lblRunningScore2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblRunningScore2.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRunningScore2.Location = New System.Drawing.Point(1116, 370)
        Me.lblRunningScore2.Name = "lblRunningScore2"
        Me.lblRunningScore2.Size = New System.Drawing.Size(192, 79)
        Me.lblRunningScore2.TabIndex = 11
        Me.lblRunningScore2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(1113, 325)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(208, 45)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Score (Round)"
        '
        'lblTotalScore1
        '
        Me.lblTotalScore1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotalScore1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalScore1.Location = New System.Drawing.Point(25, 561)
        Me.lblTotalScore1.Name = "lblTotalScore1"
        Me.lblTotalScore1.Size = New System.Drawing.Size(192, 79)
        Me.lblTotalScore1.TabIndex = 13
        Me.lblTotalScore1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(22, 516)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(208, 45)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "Total Score"
        '
        'lblTotalScore2
        '
        Me.lblTotalScore2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotalScore2.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalScore2.Location = New System.Drawing.Point(1116, 561)
        Me.lblTotalScore2.Name = "lblTotalScore2"
        Me.lblTotalScore2.Size = New System.Drawing.Size(192, 79)
        Me.lblTotalScore2.TabIndex = 15
        Me.lblTotalScore2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(1113, 516)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(208, 45)
        Me.Label10.TabIndex = 14
        Me.Label10.Text = "Total Score"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1368, 838)
        Me.Controls.Add(Me.lblTotalScore2)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.lblTotalScore1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.lblRunningScore2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lblRunningScore1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.pic2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lblValue)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.pic1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pic1 As PictureBox
    Friend WithEvents Timer As Timer
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblValue As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents pic2 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblRunningScore1 As Label
    Friend WithEvents lblRunningScore2 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lblTotalScore1 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents lblTotalScore2 As Label
    Friend WithEvents Label10 As Label
End Class
