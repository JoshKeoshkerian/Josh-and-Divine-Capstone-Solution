Imports System.IO

Public Class Solve
    Private Sub Solve_Load(sender As Object, e As EventArgs) Handles MyBase.Load, Me.VisibleChanged
        txtSolve.Text = String.Empty

    End Sub

    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        If txtSolve.Text.ToUpper = Guess.Phrase Then
            If Form1.Player = 1 Then
                Form1.Player1TotalScore += Form1.Player1Score
            Else
                Form1.Player2TotalScore += Form1.Player2Score
            End If
            btnYes.Visible = True
            btnNo.Visible = True
            lblSolved.Visible = True
            lblSolvePhrase.Text = Guess.Phrase
        Else
            MsgBox("Wrong!")
            Me.Visible = False
            Form1.Visible = True
            If Form1.Player = 1 Then
                Form1.Player = 2
            Else
                Form1.Player = 1
            End If
        End If

    End Sub

    Private Sub btnYes_Click(sender As Object, e As EventArgs) Handles btnYes.Click
        If Form1.Player = 1 Then
            Form1.Player1TotalScore += Form1.Player1Score
            Form1.Player1Score = 0
        Else
            Form1.Player2TotalScore += Form1.Player2Score
            Form1.Player2Score = 0
        End If

        Dim myStreamReader As StreamReader

        myStreamReader = File.OpenText(Guess.strFileName)
        Do Until myStreamReader.Peek = -1
            Guess.lstMain.Items.Add(myStreamReader.ReadLine())
        Loop
        Me.Visible = False
        Form1.Visible = True
    End Sub

    Private Sub btnNo_Click(sender As Object, e As EventArgs) Handles btnNo.Click
        If Form1.Player1TotalScore > Form1.Player2TotalScore Then
            MsgBox("Player 1 wins with a score of " + Form1.Player1TotalScore.ToString("C2"))
        Else
            MsgBox("Player 2 wins with a score of " + Form1.Player2TotalScore.ToString("C2"))
        End If
        Me.Close()
    End Sub
End Class