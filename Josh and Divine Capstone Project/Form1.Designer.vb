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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.pic1 = New System.Windows.Forms.PictureBox()
        Me.lblValue = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer
        '
        Me.Timer.Interval = 30
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
        Me.pic1.Location = New System.Drawing.Point(254, 34)
        Me.pic1.Name = "pic1"
        Me.pic1.Size = New System.Drawing.Size(816, 699)
        Me.pic1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic1.TabIndex = 0
        Me.pic1.TabStop = False
        '
        'lblValue
        '
        Me.lblValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblValue.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblValue.Location = New System.Drawing.Point(31, 476)
        Me.lblValue.Name = "lblValue"
        Me.lblValue.Size = New System.Drawing.Size(189, 110)
        Me.lblValue.TabIndex = 3
        Me.lblValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1082, 745)
        Me.Controls.Add(Me.lblValue)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.pic1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pic1 As PictureBox
    Friend WithEvents Timer As Timer
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblValue As Label
End Class
