Public Class Solve
    Private Sub Solve_Load(sender As Object, e As EventArgs) Handles MyBase.Load, Me.VisibleChanged
        lblSolvePhrase.Text = Guess.Dash
        lblSolved.Visible = False
        btnYes.Visible = False
        btnNo.Visible = False
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
        End If

    End Sub
End Class