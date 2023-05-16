<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Solve
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
        Me.lblSolvePhrase = New System.Windows.Forms.Label()
        Me.txtSolve = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnEnter = New System.Windows.Forms.Button()
        Me.lblSolved = New System.Windows.Forms.Label()
        Me.btnYes = New System.Windows.Forms.Button()
        Me.btnNo = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblSolvePhrase
        '
        Me.lblSolvePhrase.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSolvePhrase.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSolvePhrase.Location = New System.Drawing.Point(12, 92)
        Me.lblSolvePhrase.Name = "lblSolvePhrase"
        Me.lblSolvePhrase.Size = New System.Drawing.Size(658, 148)
        Me.lblSolvePhrase.TabIndex = 28
        Me.lblSolvePhrase.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtSolve
        '
        Me.txtSolve.Location = New System.Drawing.Point(83, 276)
        Me.txtSolve.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtSolve.Multiline = True
        Me.txtSolve.Name = "txtSolve"
        Me.txtSolve.Size = New System.Drawing.Size(312, 63)
        Me.txtSolve.TabIndex = 29
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(163, 11)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(317, 64)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "Solve The Puzzle"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnEnter
        '
        Me.btnEnter.Location = New System.Drawing.Point(441, 294)
        Me.btnEnter.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(100, 28)
        Me.btnEnter.TabIndex = 31
        Me.btnEnter.Text = "Enter"
        Me.btnEnter.UseVisualStyleBackColor = True
        '
        'lblSolved
        '
        Me.lblSolved.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSolved.Location = New System.Drawing.Point(677, 11)
        Me.lblSolved.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSolved.Name = "lblSolved"
        Me.lblSolved.Size = New System.Drawing.Size(317, 108)
        Me.lblSolved.TabIndex = 32
        Me.lblSolved.Text = "You Solved the Puzzle! Would you like to continue playing?"
        Me.lblSolved.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnYes
        '
        Me.btnYes.Location = New System.Drawing.Point(708, 155)
        Me.btnYes.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnYes.Name = "btnYes"
        Me.btnYes.Size = New System.Drawing.Size(100, 28)
        Me.btnYes.TabIndex = 33
        Me.btnYes.Text = "Yes"
        Me.btnYes.UseVisualStyleBackColor = True
        '
        'btnNo
        '
        Me.btnNo.Location = New System.Drawing.Point(861, 155)
        Me.btnNo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnNo.Name = "btnNo"
        Me.btnNo.Size = New System.Drawing.Size(100, 28)
        Me.btnNo.TabIndex = 34
        Me.btnNo.Text = "No"
        Me.btnNo.UseVisualStyleBackColor = True
        '
        'Solve
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1067, 554)
        Me.Controls.Add(Me.btnNo)
        Me.Controls.Add(Me.btnYes)
        Me.Controls.Add(Me.lblSolved)
        Me.Controls.Add(Me.btnEnter)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtSolve)
        Me.Controls.Add(Me.lblSolvePhrase)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Solve"
        Me.Text = "Solve"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblSolvePhrase As Label
    Friend WithEvents txtSolve As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnEnter As Button
    Friend WithEvents lblSolved As Label
    Friend WithEvents btnYes As Button
    Friend WithEvents btnNo As Button
End Class
