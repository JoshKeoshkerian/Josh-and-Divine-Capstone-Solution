Imports System.IO

Public Class Guess

    Dim LetterAmount As Integer
    Public strFileName As String
    Dim strShortName As String
    Public Phrase As String
    Public Dash As String

    Private Sub Guess_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        If Form1.Player = 1 Then
            lblPlayer21.Visible = True
            lblPlayer22.Visible = False
        Else
            lblPlayer22.Visible = True
            lblPlayer21.Visible = False
        End If
        tmrBack.Enabled = False



    End Sub

    Private Sub lblA_Click(sender As Object, e As EventArgs) Handles lblA.Click
        If Phrase.Contains("A") Then
            For letter As Integer = 0 To Phrase.Length - 1
                If Phrase(letter) = "A" Then
                    Dash = Dash.Remove(letter, 1)
                    Dash = Dash.Insert(letter, "A")
                    LetterAmount += 1
                End If
            Next letter
            lblPhrase.Text = Dash
            lblA.BackColor = Color.Green
            Form1.spinValue = Form1.spinValue * LetterAmount
            If Form1.Player = 1 Then
                Form1.Player1Score += Form1.spinValue
            Else
                Form1.Player2Score += Form1.spinValue
            End If
            Form1.lblRunningScore1.Text = Form1.Player1Score.ToString("C0")
            Form1.lblRunningScore2.Text = Form1.Player2Score.ToString("C0")
            tmrBack.Enabled = True
            lblA.Enabled = False
        Else
            lblA.BackColor = Color.Red
            If Form1.Player = 1 Then
                Form1.Player = 2
            Else
                Form1.Player = 1
            End If
            tmrBack.Enabled = True
            lblA.Enabled = False
        End If
        If Phrase = Dash Then
            Me.Visible = False
            Solve.Visible = True
            Solve.lblSolved.Visible = True
            Solve.btnYes.Visible = True
            Solve.btnNo.Visible = True
        End If
    End Sub



    Private Sub tmrBack_Tick(sender As Object, e As EventArgs) Handles tmrBack.Tick
        Me.Visible = False
        Form1.Visible = True
    End Sub

    Private Sub Guess_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        LetterAmount = 0
        tmrBack.Enabled = False
        If Form1.Player = 1 Then
            lblPlayer21.Visible = True
            lblPlayer22.Visible = False
        Else
            lblPlayer22.Visible = True
            lblPlayer21.Visible = False
        End If
    End Sub

    Private Sub lblB_Click(sender As Object, e As EventArgs) Handles lblB.Click
        If Phrase.Contains("B") Then
            For letter As Integer = 0 To Phrase.Length - 1
                If Phrase(letter) = "B" Then
                    Dash = Dash.Remove(letter, 1)
                    Dash = Dash.Insert(letter, "B")
                    LetterAmount += 1
                End If
            Next letter
            lblPhrase.Text = Dash
            lblB.BackColor = Color.Green
            Form1.spinValue = Form1.spinValue * LetterAmount
            If Form1.Player = 1 Then
                Form1.Player1Score += Form1.spinValue
            Else
                Form1.Player2Score += Form1.spinValue
            End If
            Form1.lblRunningScore1.Text = Form1.Player1Score.ToString("C0")
            Form1.lblRunningScore2.Text = Form1.Player2Score.ToString("C0")
            tmrBack.Enabled = True
            lblB.Enabled = False
        Else
            lblB.BackColor = Color.Red
            If Form1.Player = 1 Then
                Form1.Player = 2
            Else
                Form1.Player = 1
            End If
            tmrBack.Enabled = True
            lblB.Enabled = False
        End If
        If Phrase = Dash Then
            Me.Visible = False
            Solve.Visible = True
            Solve.lblSolved.Visible = True
            Solve.btnYes.Visible = True
            Solve.btnNo.Visible = True
        End If
    End Sub

    Private Sub lblC_Click(sender As Object, e As EventArgs) Handles lblC.Click
        If Phrase.Contains("C") Then
            For letter As Integer = 0 To Phrase.Length - 1
                If Phrase(letter) = "C" Then
                    Dash = Dash.Remove(letter, 1)
                    Dash = Dash.Insert(letter, "C")
                    LetterAmount += 1
                End If
            Next letter
            lblPhrase.Text = Dash
            lblA.BackColor = Color.Green
            Form1.spinValue = Form1.spinValue * LetterAmount
            If Form1.Player = 1 Then
                Form1.Player1Score += Form1.spinValue
            Else
                Form1.Player2Score += Form1.spinValue
            End If
            Form1.lblRunningScore1.Text = Form1.Player1Score.ToString("C0")
            Form1.lblRunningScore2.Text = Form1.Player2Score.ToString("C0")
            tmrBack.Enabled = True
            lblC.Enabled = False
        Else
            lblC.BackColor = Color.Red
            If Form1.Player = 1 Then
                Form1.Player = 2
            Else
                Form1.Player = 1
            End If
            tmrBack.Enabled = True
            lblC.Enabled = False
        End If
        If Phrase = Dash Then
            Me.Visible = False
            Solve.Visible = True
            Solve.lblSolved.Visible = True
            Solve.btnYes.Visible = True
            Solve.btnNo.Visible = True
        End If
    End Sub

    Private Sub lblD_Click(sender As Object, e As EventArgs) Handles lblD.Click
        If Phrase.Contains("D") Then
            For letter As Integer = 0 To Phrase.Length - 1
                If Phrase(letter) = "D" Then
                    Dash = Dash.Remove(letter, 1)
                    Dash = Dash.Insert(letter, "D")
                    LetterAmount += 1
                End If
            Next letter
            lblPhrase.Text = Dash
            lblD.BackColor = Color.Green
            Form1.spinValue = Form1.spinValue * LetterAmount
            If Form1.Player = 1 Then
                Form1.Player1Score += Form1.spinValue
            Else
                Form1.Player2Score += Form1.spinValue
            End If
            Form1.lblRunningScore1.Text = Form1.Player1Score.ToString("C0")
            Form1.lblRunningScore2.Text = Form1.Player2Score.ToString("C0")
            tmrBack.Enabled = True
            lblD.Enabled = False
        Else
            lblD.BackColor = Color.Red
            If Form1.Player = 1 Then
                Form1.Player = 2
            Else
                Form1.Player = 1
            End If
            tmrBack.Enabled = True
            lblD.Enabled = False
        End If
        If Phrase = Dash Then
            Me.Visible = False
            Solve.Visible = True
            Solve.lblSolved.Visible = True
            Solve.btnYes.Visible = True
            Solve.btnNo.Visible = True
        End If
    End Sub

    Private Sub lblE_Click(sender As Object, e As EventArgs) Handles lblE.Click
        If Phrase.Contains("E") Then
            For letter As Integer = 0 To Phrase.Length - 1
                If Phrase(letter) = "E" Then
                    Dash = Dash.Remove(letter, 1)
                    Dash = Dash.Insert(letter, "E")
                    LetterAmount += 1
                End If
            Next letter
            lblPhrase.Text = Dash
            lblE.BackColor = Color.Green
            Form1.spinValue = Form1.spinValue * LetterAmount
            If Form1.Player = 1 Then
                Form1.Player1Score += Form1.spinValue
            Else
                Form1.Player2Score += Form1.spinValue
            End If
            Form1.lblRunningScore1.Text = Form1.Player1Score.ToString("C0")
            Form1.lblRunningScore2.Text = Form1.Player2Score.ToString("C0")
            tmrBack.Enabled = True
            lblE.Enabled = False
        Else
            lblE.BackColor = Color.Red
            If Form1.Player = 1 Then
                Form1.Player = 2
            Else
                Form1.Player = 1
            End If
            tmrBack.Enabled = True
            lblE.Enabled = False
        End If
        If Phrase = Dash Then
            Me.Visible = False
            Solve.Visible = True
            Solve.lblSolved.Visible = True
            Solve.btnYes.Visible = True
            Solve.btnNo.Visible = True
        End If
    End Sub

    Private Sub btnReveal_Click(sender As Object, e As EventArgs) Handles btnReveal.Click
        MsgBox("The phrase is " + Phrase)

    End Sub

    Private Sub btnSolve_Click(sender As Object, e As EventArgs) Handles btnSolve.Click
        Solve.lblSolvePhrase.Text = Dash
        Solve.lblSolved.Visible = False
        Solve.btnYes.Visible = False
        Solve.btnNo.Visible = False
        Me.Visible = False
        Solve.Visible = True
    End Sub

    Private Sub lblF_Click(sender As Object, e As EventArgs) Handles lblF.Click
        If Phrase.Contains("F") Then
            For letter As Integer = 0 To Phrase.Length - 1
                If Phrase(letter) = "F" Then
                    Dash = Dash.Remove(letter, 1)
                    Dash = Dash.Insert(letter, "F")
                    LetterAmount += 1
                End If
            Next letter
            lblPhrase.Text = Dash
            lblF.BackColor = Color.Green
            Form1.spinValue = Form1.spinValue * LetterAmount
            If Form1.Player = 1 Then
                Form1.Player1Score += Form1.spinValue
            Else
                Form1.Player2Score += Form1.spinValue
            End If
            Form1.lblRunningScore1.Text = Form1.Player1Score.ToString("C0")
            Form1.lblRunningScore2.Text = Form1.Player2Score.ToString("C0")
            tmrBack.Enabled = True
            lblF.Enabled = False
        Else
            lblF.BackColor = Color.Red
            If Form1.Player = 1 Then
                Form1.Player = 2
            Else
                Form1.Player = 1
            End If
            tmrBack.Enabled = True
            lblF.Enabled = False
        End If
        If Phrase = Dash Then
            Me.Visible = False
            Solve.Visible = True
            Solve.lblSolved.Visible = True
            Solve.btnYes.Visible = True
            Solve.btnNo.Visible = True
        End If
    End Sub

    Private Sub lblG_Click(sender As Object, e As EventArgs) Handles lblG.Click
        If Phrase.Contains("G") Then
            For letter As Integer = 0 To Phrase.Length - 1
                If Phrase(letter) = "G" Then
                    Dash = Dash.Remove(letter, 1)
                    Dash = Dash.Insert(letter, "G")
                    LetterAmount += 1
                End If
            Next letter
            lblPhrase.Text = Dash
            lblG.BackColor = Color.Green
            Form1.spinValue = Form1.spinValue * LetterAmount
            If Form1.Player = 1 Then
                Form1.Player1Score += Form1.spinValue
            Else
                Form1.Player2Score += Form1.spinValue
            End If
            Form1.lblRunningScore1.Text = Form1.Player1Score.ToString("C0")
            Form1.lblRunningScore2.Text = Form1.Player2Score.ToString("C0")
            tmrBack.Enabled = True
            lblG.Enabled = False
        Else
            lblG.BackColor = Color.Red
            If Form1.Player = 1 Then
                Form1.Player = 2
            Else
                Form1.Player = 1
            End If
            tmrBack.Enabled = True
            lblG.Enabled = False
        End If
        If Phrase = Dash Then
            Me.Visible = False
            Solve.Visible = True
            Solve.lblSolved.Visible = True
            Solve.btnYes.Visible = True
            Solve.btnNo.Visible = True
        End If
    End Sub

    Private Sub lblH_Click(sender As Object, e As EventArgs) Handles lblH.Click
        If Phrase.Contains("H") Then
            For letter As Integer = 0 To Phrase.Length - 1
                If Phrase(letter) = "H" Then
                    Dash = Dash.Remove(letter, 1)
                    Dash = Dash.Insert(letter, "H")
                    LetterAmount += 1
                End If
            Next letter
            lblPhrase.Text = Dash
            lblH.BackColor = Color.Green
            Form1.spinValue = Form1.spinValue * LetterAmount
            If Form1.Player = 1 Then
                Form1.Player1Score += Form1.spinValue
            Else
                Form1.Player2Score += Form1.spinValue
            End If
            Form1.lblRunningScore1.Text = Form1.Player1Score.ToString("C0")
            Form1.lblRunningScore2.Text = Form1.Player2Score.ToString("C0")
            tmrBack.Enabled = True
            lblH.Enabled = False
        Else
            lblH.BackColor = Color.Red
            If Form1.Player = 1 Then
                Form1.Player = 2
            Else
                Form1.Player = 1
            End If
            tmrBack.Enabled = True
            lblH.Enabled = False
        End If
        If Phrase = Dash Then
            Me.Visible = False
            Solve.Visible = True
            Solve.lblSolved.Visible = True
            Solve.btnYes.Visible = True
            Solve.btnNo.Visible = True
        End If
    End Sub

    Private Sub lblI_Click(sender As Object, e As EventArgs) Handles lblI.Click
        If Phrase.Contains("I") Then
            For letter As Integer = 0 To Phrase.Length - 1
                If Phrase(letter) = "I" Then
                    Dash = Dash.Remove(letter, 1)
                    Dash = Dash.Insert(letter, "I")
                    LetterAmount += 1
                End If
            Next letter
            lblPhrase.Text = Dash
            lblI.BackColor = Color.Green
            Form1.spinValue = Form1.spinValue * LetterAmount
            If Form1.Player = 1 Then
                Form1.Player1Score += Form1.spinValue
            Else
                Form1.Player2Score += Form1.spinValue
            End If
            Form1.lblRunningScore1.Text = Form1.Player1Score.ToString("C0")
            Form1.lblRunningScore2.Text = Form1.Player2Score.ToString("C0")
            tmrBack.Enabled = True
            lblI.Enabled = False
        Else
            lblI.BackColor = Color.Red
            If Form1.Player = 1 Then
                Form1.Player = 2
            Else
                Form1.Player = 1
            End If
            tmrBack.Enabled = True
            lblI.Enabled = False
        End If
        If Phrase = Dash Then
            Me.Visible = False
            Solve.Visible = True
            Solve.lblSolved.Visible = True
            Solve.btnYes.Visible = True
            Solve.btnNo.Visible = True
        End If
    End Sub

    Private Sub lblJ_Click(sender As Object, e As EventArgs) Handles lblJ.Click
        If Phrase.Contains("J") Then
            For letter As Integer = 0 To Phrase.Length - 1
                If Phrase(letter) = "J" Then
                    Dash = Dash.Remove(letter, 1)
                    Dash = Dash.Insert(letter, "J")
                    LetterAmount += 1
                End If
            Next letter
            lblPhrase.Text = Dash
            lblJ.BackColor = Color.Green
            Form1.spinValue = Form1.spinValue * LetterAmount
            If Form1.Player = 1 Then
                Form1.Player1Score += Form1.spinValue
            Else
                Form1.Player2Score += Form1.spinValue
            End If
            Form1.lblRunningScore1.Text = Form1.Player1Score.ToString("C0")
            Form1.lblRunningScore2.Text = Form1.Player2Score.ToString("C0")
            tmrBack.Enabled = True
            lblJ.Enabled = False
        Else
            lblJ.BackColor = Color.Red
            If Form1.Player = 1 Then
                Form1.Player = 2
            Else
                Form1.Player = 1
            End If
            tmrBack.Enabled = True
            lblJ.Enabled = False
        End If
        If Phrase = Dash Then
            Me.Visible = False
            Solve.Visible = True
            Solve.lblSolved.Visible = True
            Solve.btnYes.Visible = True
            Solve.btnNo.Visible = True
        End If
    End Sub

    Private Sub lblK_Click(sender As Object, e As EventArgs) Handles lblK.Click
        If Phrase.Contains("K") Then
            For letter As Integer = 0 To Phrase.Length - 1
                If Phrase(letter) = "K" Then
                    Dash = Dash.Remove(letter, 1)
                    Dash = Dash.Insert(letter, "K")
                    LetterAmount += 1
                End If
            Next letter
            lblPhrase.Text = Dash
            lblK.BackColor = Color.Green
            Form1.spinValue = Form1.spinValue * LetterAmount
            If Form1.Player = 1 Then
                Form1.Player1Score += Form1.spinValue
            Else
                Form1.Player2Score += Form1.spinValue
            End If
            Form1.lblRunningScore1.Text = Form1.Player1Score.ToString("C0")
            Form1.lblRunningScore2.Text = Form1.Player2Score.ToString("C0")
            tmrBack.Enabled = True
            lblK.Enabled = False
        Else
            lblK.BackColor = Color.Red
            If Form1.Player = 1 Then
                Form1.Player = 2
            Else
                Form1.Player = 1
            End If
            tmrBack.Enabled = True
            lblK.Enabled = False
        End If
        If Phrase = Dash Then
            Me.Visible = False
            Solve.Visible = True
            Solve.lblSolved.Visible = True
            Solve.btnYes.Visible = True
            Solve.btnNo.Visible = True
        End If
    End Sub

    Private Sub lblL_Click(sender As Object, e As EventArgs) Handles lblL.Click
        If Phrase.Contains("L") Then
            For letter As Integer = 0 To Phrase.Length - 1
                If Phrase(letter) = "L" Then
                    Dash = Dash.Remove(letter, 1)
                    Dash = Dash.Insert(letter, "L")
                    LetterAmount += 1
                End If
            Next letter
            lblPhrase.Text = Dash
            lblL.BackColor = Color.Green
            Form1.spinValue = Form1.spinValue * LetterAmount
            If Form1.Player = 1 Then
                Form1.Player1Score += Form1.spinValue
            Else
                Form1.Player2Score += Form1.spinValue
            End If
            Form1.lblRunningScore1.Text = Form1.Player1Score.ToString("C0")
            Form1.lblRunningScore2.Text = Form1.Player2Score.ToString("C0")
            tmrBack.Enabled = True
            lblL.Enabled = False
        Else
            lblL.BackColor = Color.Red
            If Form1.Player = 1 Then
                Form1.Player = 2
            Else
                Form1.Player = 1
            End If
            tmrBack.Enabled = True
            lblL.Enabled = False
        End If
        If Phrase = Dash Then
            Me.Visible = False
            Solve.Visible = True
            Solve.lblSolved.Visible = True
            Solve.btnYes.Visible = True
            Solve.btnNo.Visible = True
        End If
    End Sub

    Private Sub lblM_Click(sender As Object, e As EventArgs) Handles lblM.Click
        If Phrase.Contains("M") Then
            For letter As Integer = 0 To Phrase.Length - 1
                If Phrase(letter) = "M" Then
                    Dash = Dash.Remove(letter, 1)
                    Dash = Dash.Insert(letter, "M")
                    LetterAmount += 1
                End If
            Next letter
            lblPhrase.Text = Dash
            lblM.BackColor = Color.Green
            Form1.spinValue = Form1.spinValue * LetterAmount
            If Form1.Player = 1 Then
                Form1.Player1Score += Form1.spinValue
            Else
                Form1.Player2Score += Form1.spinValue
            End If
            Form1.lblRunningScore1.Text = Form1.Player1Score.ToString("C0")
            Form1.lblRunningScore2.Text = Form1.Player2Score.ToString("C0")
            tmrBack.Enabled = True
            lblM.Enabled = False
        Else
            lblM.BackColor = Color.Red
            If Form1.Player = 1 Then
                Form1.Player = 2
            Else
                Form1.Player = 1
            End If
            tmrBack.Enabled = True
            lblM.Enabled = False
        End If
        If Phrase = Dash Then
            Me.Visible = False
            Solve.Visible = True
            Solve.lblSolved.Visible = True
            Solve.btnYes.Visible = True
            Solve.btnNo.Visible = True
        End If
    End Sub

    Private Sub lblN_Click(sender As Object, e As EventArgs) Handles lblN.Click
        If Phrase.Contains("N") Then
            For letter As Integer = 0 To Phrase.Length - 1
                If Phrase(letter) = "N" Then
                    Dash = Dash.Remove(letter, 1)
                    Dash = Dash.Insert(letter, "N")
                    LetterAmount += 1
                End If
            Next letter
            lblPhrase.Text = Dash
            lblN.BackColor = Color.Green
            Form1.spinValue = Form1.spinValue * LetterAmount
            If Form1.Player = 1 Then
                Form1.Player1Score += Form1.spinValue
            Else
                Form1.Player2Score += Form1.spinValue
            End If
            Form1.lblRunningScore1.Text = Form1.Player1Score.ToString("C0")
            Form1.lblRunningScore2.Text = Form1.Player2Score.ToString("C0")
            tmrBack.Enabled = True
            lblN.Enabled = False
        Else
            lblN.BackColor = Color.Red
            If Form1.Player = 1 Then
                Form1.Player = 2
            Else
                Form1.Player = 1
            End If
            tmrBack.Enabled = True
            lblN.Enabled = False
        End If
        If Phrase = Dash Then
            Me.Visible = False
            Solve.Visible = True
            Solve.lblSolved.Visible = True
            Solve.btnYes.Visible = True
            Solve.btnNo.Visible = True
        End If
    End Sub

    Private Sub lblO_Click(sender As Object, e As EventArgs) Handles lblO.Click
        If Phrase.Contains("O") Then
            For letter As Integer = 0 To Phrase.Length - 1
                If Phrase(letter) = "O" Then
                    Dash = Dash.Remove(letter, 1)
                    Dash = Dash.Insert(letter, "O")
                    LetterAmount += 1
                End If
            Next letter
            lblPhrase.Text = Dash
            lblO.BackColor = Color.Green
            Form1.spinValue = Form1.spinValue * LetterAmount
            If Form1.Player = 1 Then
                Form1.Player1Score += Form1.spinValue
            Else
                Form1.Player2Score += Form1.spinValue
            End If
            Form1.lblRunningScore1.Text = Form1.Player1Score.ToString("C0")
            Form1.lblRunningScore2.Text = Form1.Player2Score.ToString("C0")
            tmrBack.Enabled = True
            lblO.Enabled = False
        Else
            lblO.BackColor = Color.Red
            If Form1.Player = 1 Then
                Form1.Player = 2
            Else
                Form1.Player = 1
            End If
            tmrBack.Enabled = True
            lblO.Enabled = False
        End If
        If Phrase = Dash Then
            Me.Visible = False
            Solve.Visible = True
            Solve.lblSolved.Visible = True
            Solve.btnYes.Visible = True
            Solve.btnNo.Visible = True
        End If
    End Sub

    Private Sub lblP_Click(sender As Object, e As EventArgs) Handles lblP.Click
        If Phrase.Contains("P") Then
            For letter As Integer = 0 To Phrase.Length - 1
                If Phrase(letter) = "P" Then
                    Dash = Dash.Remove(letter, 1)
                    Dash = Dash.Insert(letter, "P")
                    LetterAmount += 1
                End If
            Next letter
            lblPhrase.Text = Dash
            lblP.BackColor = Color.Green
            Form1.spinValue = Form1.spinValue * LetterAmount
            If Form1.Player = 1 Then
                Form1.Player1Score += Form1.spinValue
            Else
                Form1.Player2Score += Form1.spinValue
            End If
            Form1.lblRunningScore1.Text = Form1.Player1Score.ToString("C0")
            Form1.lblRunningScore2.Text = Form1.Player2Score.ToString("C0")
            tmrBack.Enabled = True
            lblP.Enabled = False
        Else
            lblP.BackColor = Color.Red
            If Form1.Player = 1 Then
                Form1.Player = 2
            Else
                Form1.Player = 1
            End If
            tmrBack.Enabled = True
            lblP.Enabled = False
        End If
        If Phrase = Dash Then
            Me.Visible = False
            Solve.Visible = True
            Solve.lblSolved.Visible = True
            Solve.btnYes.Visible = True
            Solve.btnNo.Visible = True
        End If
    End Sub

    Private Sub lblQ_Click(sender As Object, e As EventArgs) Handles lblQ.Click
        If Phrase.Contains("Q") Then
            For letter As Integer = 0 To Phrase.Length - 1
                If Phrase(letter) = "Q" Then
                    Dash = Dash.Remove(letter, 1)
                    Dash = Dash.Insert(letter, "Q")
                    LetterAmount += 1
                End If
            Next letter
            lblPhrase.Text = Dash
            lblQ.BackColor = Color.Green
            Form1.spinValue = Form1.spinValue * LetterAmount
            If Form1.Player = 1 Then
                Form1.Player1Score += Form1.spinValue
            Else
                Form1.Player2Score += Form1.spinValue
            End If
            Form1.lblRunningScore1.Text = Form1.Player1Score.ToString("C0")
            Form1.lblRunningScore2.Text = Form1.Player2Score.ToString("C0")
            tmrBack.Enabled = True
            lblQ.Enabled = False
        Else
            lblQ.BackColor = Color.Red
            If Form1.Player = 1 Then
                Form1.Player = 2
            Else
                Form1.Player = 1
            End If
            tmrBack.Enabled = True
            lblQ.Enabled = False
        End If
        If Phrase = Dash Then
            Me.Visible = False
            Solve.Visible = True
            Solve.lblSolved.Visible = True
            Solve.btnYes.Visible = True
            Solve.btnNo.Visible = True
        End If
    End Sub

    Private Sub lblR_Click(sender As Object, e As EventArgs) Handles lblR.Click
        If Phrase.Contains("A") Then
            For letter As Integer = 0 To Phrase.Length - 1
                If Phrase(letter) = "R" Then
                    Dash = Dash.Remove(letter, 1)
                    Dash = Dash.Insert(letter, "R")
                    LetterAmount += 1
                End If
            Next letter
            lblPhrase.Text = Dash
            lblR.BackColor = Color.Green
            Form1.spinValue = Form1.spinValue * LetterAmount
            If Form1.Player = 1 Then
                Form1.Player1Score += Form1.spinValue
            Else
                Form1.Player2Score += Form1.spinValue
            End If
            Form1.lblRunningScore1.Text = Form1.Player1Score.ToString("C0")
            Form1.lblRunningScore2.Text = Form1.Player2Score.ToString("C0")
            tmrBack.Enabled = True
            lblR.Enabled = False
        Else
            lblR.BackColor = Color.Red
            If Form1.Player = 1 Then
                Form1.Player = 2
            Else
                Form1.Player = 1
            End If
            tmrBack.Enabled = True
            lblR.Enabled = False
        End If
        If Phrase = Dash Then
            Me.Visible = False
            Solve.Visible = True
            Solve.lblSolved.Visible = True
            Solve.btnYes.Visible = True
            Solve.btnNo.Visible = True
        End If
    End Sub

    Private Sub lblS_Click(sender As Object, e As EventArgs) Handles lblS.Click
        If Phrase.Contains("S") Then
            For letter As Integer = 0 To Phrase.Length - 1
                If Phrase(letter) = "S" Then
                    Dash = Dash.Remove(letter, 1)
                    Dash = Dash.Insert(letter, "S")
                    LetterAmount += 1
                End If
            Next letter
            lblPhrase.Text = Dash
            lblS.BackColor = Color.Green
            Form1.spinValue = Form1.spinValue * LetterAmount
            If Form1.Player = 1 Then
                Form1.Player1Score += Form1.spinValue
            Else
                Form1.Player2Score += Form1.spinValue
            End If
            Form1.lblRunningScore1.Text = Form1.Player1Score.ToString("C0")
            Form1.lblRunningScore2.Text = Form1.Player2Score.ToString("C0")
            tmrBack.Enabled = True
            lblS.Enabled = False
        Else
            lblS.BackColor = Color.Red
            If Form1.Player = 1 Then
                Form1.Player = 2
            Else
                Form1.Player = 1
            End If
            tmrBack.Enabled = True
            lblS.Enabled = False
        End If
        If Phrase = Dash Then
            Me.Visible = False
            Solve.Visible = True
            Solve.lblSolved.Visible = True
            Solve.btnYes.Visible = True
            Solve.btnNo.Visible = True
        End If
    End Sub

    Private Sub lblT_Click(sender As Object, e As EventArgs) Handles lblT.Click
        If Phrase.Contains("T") Then
            For letter As Integer = 0 To Phrase.Length - 1
                If Phrase(letter) = "T" Then
                    Dash = Dash.Remove(letter, 1)
                    Dash = Dash.Insert(letter, "T")
                    LetterAmount += 1
                End If
            Next letter
            lblPhrase.Text = Dash
            lblT.BackColor = Color.Green
            Form1.spinValue = Form1.spinValue * LetterAmount
            If Form1.Player = 1 Then
                Form1.Player1Score += Form1.spinValue
            Else
                Form1.Player2Score += Form1.spinValue
            End If
            Form1.lblRunningScore1.Text = Form1.Player1Score.ToString("C0")
            Form1.lblRunningScore2.Text = Form1.Player2Score.ToString("C0")
            tmrBack.Enabled = True
            lblT.Enabled = False
        Else
            lblT.BackColor = Color.Red
            If Form1.Player = 1 Then
                Form1.Player = 2
            Else
                Form1.Player = 1
            End If
            tmrBack.Enabled = True
            lblT.Enabled = False
        End If
        If Phrase = Dash Then
            Me.Visible = False
            Solve.Visible = True
            Solve.lblSolved.Visible = True
            Solve.btnYes.Visible = True
            Solve.btnNo.Visible = True
        End If
    End Sub

    Private Sub lblU_Click(sender As Object, e As EventArgs) Handles lblU.Click
        If Phrase.Contains("U") Then
            For letter As Integer = 0 To Phrase.Length - 1
                If Phrase(letter) = "U" Then
                    Dash = Dash.Remove(letter, 1)
                    Dash = Dash.Insert(letter, "U")
                    LetterAmount += 1
                End If
            Next letter
            lblPhrase.Text = Dash
            lblU.BackColor = Color.Green
            Form1.spinValue = Form1.spinValue * LetterAmount
            If Form1.Player = 1 Then
                Form1.Player1Score += Form1.spinValue
            Else
                Form1.Player2Score += Form1.spinValue
            End If
            Form1.lblRunningScore1.Text = Form1.Player1Score.ToString("C0")
            Form1.lblRunningScore2.Text = Form1.Player2Score.ToString("C0")
            tmrBack.Enabled = True
            lblU.Enabled = False
        Else
            lblU.BackColor = Color.Red
            If Form1.Player = 1 Then
                Form1.Player = 2
            Else
                Form1.Player = 1
            End If
            tmrBack.Enabled = True
            lblU.Enabled = False
        End If
        If Phrase = Dash Then
            Me.Visible = False
            Solve.Visible = True
            Solve.lblSolved.Visible = True
            Solve.btnYes.Visible = True
            Solve.btnNo.Visible = True
        End If
    End Sub

    Private Sub lblV_Click(sender As Object, e As EventArgs) Handles lblV.Click
        If Phrase.Contains("V") Then
            For letter As Integer = 0 To Phrase.Length - 1
                If Phrase(letter) = "V" Then
                    Dash = Dash.Remove(letter, 1)
                    Dash = Dash.Insert(letter, "V")
                    LetterAmount += 1
                End If
            Next letter
            lblPhrase.Text = Dash
            lblV.BackColor = Color.Green
            Form1.spinValue = Form1.spinValue * LetterAmount
            If Form1.Player = 1 Then
                Form1.Player1Score += Form1.spinValue
            Else
                Form1.Player2Score += Form1.spinValue
            End If
            Form1.lblRunningScore1.Text = Form1.Player1Score.ToString("C0")
            Form1.lblRunningScore2.Text = Form1.Player2Score.ToString("C0")
            tmrBack.Enabled = True
            lblV.Enabled = False
        Else
            lblV.BackColor = Color.Red
            If Form1.Player = 1 Then
                Form1.Player = 2
            Else
                Form1.Player = 1
            End If
            tmrBack.Enabled = True
            lblV.Enabled = False
        End If
        If Phrase = Dash Then
            Me.Visible = False
            Solve.Visible = True
            Solve.lblSolved.Visible = True
            Solve.btnYes.Visible = True
            Solve.btnNo.Visible = True
        End If
    End Sub

    Private Sub lblW_Click(sender As Object, e As EventArgs) Handles lblW.Click
        If Phrase.Contains("W") Then
            For letter As Integer = 0 To Phrase.Length - 1
                If Phrase(letter) = "W" Then
                    Dash = Dash.Remove(letter, 1)
                    Dash = Dash.Insert(letter, "W")
                    LetterAmount += 1
                End If
            Next letter
            lblPhrase.Text = Dash
            lblW.BackColor = Color.Green
            Form1.spinValue = Form1.spinValue * LetterAmount
            If Form1.Player = 1 Then
                Form1.Player1Score += Form1.spinValue
            Else
                Form1.Player2Score += Form1.spinValue
            End If
            Form1.lblRunningScore1.Text = Form1.Player1Score.ToString("C0")
            Form1.lblRunningScore2.Text = Form1.Player2Score.ToString("C0")
            tmrBack.Enabled = True
            lblW.Enabled = False
        Else
            lblW.BackColor = Color.Red
            If Form1.Player = 1 Then
                Form1.Player = 2
            Else
                Form1.Player = 1
            End If
            tmrBack.Enabled = True
            lblW.Enabled = False
        End If
        If Phrase = Dash Then
            Me.Visible = False
            Solve.Visible = True
            Solve.lblSolved.Visible = True
            Solve.btnYes.Visible = True
            Solve.btnNo.Visible = True
        End If
    End Sub

    Private Sub lblX_Click(sender As Object, e As EventArgs) Handles lblX.Click
        If Phrase.Contains("X") Then
            For letter As Integer = 0 To Phrase.Length - 1
                If Phrase(letter) = "X" Then
                    Dash = Dash.Remove(letter, 1)
                    Dash = Dash.Insert(letter, "X")
                    LetterAmount += 1
                End If
            Next letter
            lblPhrase.Text = Dash
            lblX.BackColor = Color.Green
            Form1.spinValue = Form1.spinValue * LetterAmount
            If Form1.Player = 1 Then
                Form1.Player1Score += Form1.spinValue
            Else
                Form1.Player2Score += Form1.spinValue
            End If
            Form1.lblRunningScore1.Text = Form1.Player1Score.ToString("C0")
            Form1.lblRunningScore2.Text = Form1.Player2Score.ToString("C0")
            tmrBack.Enabled = True
            lblX.Enabled = False
        Else
            lblX.BackColor = Color.Red
            If Form1.Player = 1 Then
                Form1.Player = 2
            Else
                Form1.Player = 1
            End If
            tmrBack.Enabled = True
            lblX.Enabled = False
        End If
        If Phrase = Dash Then
            Me.Visible = False
            Solve.Visible = True
            Solve.lblSolved.Visible = True
            Solve.btnYes.Visible = True
            Solve.btnNo.Visible = True
        End If
    End Sub

    Private Sub lblY_Click(sender As Object, e As EventArgs) Handles lblY.Click
        If Phrase.Contains("Y") Then
            For letter As Integer = 0 To Phrase.Length - 1
                If Phrase(letter) = "Y" Then
                    Dash = Dash.Remove(letter, 1)
                    Dash = Dash.Insert(letter, "Y")
                    LetterAmount += 1
                End If
            Next letter
            lblPhrase.Text = Dash
            lblY.BackColor = Color.Green
            Form1.spinValue = Form1.spinValue * LetterAmount
            If Form1.Player = 1 Then
                Form1.Player1Score += Form1.spinValue
            Else
                Form1.Player2Score += Form1.spinValue
            End If
            Form1.lblRunningScore1.Text = Form1.Player1Score.ToString("C0")
            Form1.lblRunningScore2.Text = Form1.Player2Score.ToString("C0")
            tmrBack.Enabled = True
            lblY.Enabled = False
        Else
            lblY.BackColor = Color.Red
            If Form1.Player = 1 Then
                Form1.Player = 2
            Else
                Form1.Player = 1
            End If
            tmrBack.Enabled = True
            lblY.Enabled = False
        End If
        If Phrase = Dash Then
            Me.Visible = False
            Solve.Visible = True
            Solve.lblSolved.Visible = True
            Solve.btnYes.Visible = True
            Solve.btnNo.Visible = True
        End If
    End Sub

    Private Sub lblZ_Click(sender As Object, e As EventArgs) Handles lblZ.Click
        If Phrase.Contains("Z") Then
            For letter As Integer = 0 To Phrase.Length - 1
                If Phrase(letter) = "Z" Then
                    Dash = Dash.Remove(letter, 1)
                    Dash = Dash.Insert(letter, "Z")
                    LetterAmount += 1
                End If
            Next letter
            lblPhrase.Text = Dash
            lblZ.BackColor = Color.Green
            Form1.spinValue = Form1.spinValue * LetterAmount
            If Form1.Player = 1 Then
                Form1.Player1Score += Form1.spinValue
            Else
                Form1.Player2Score += Form1.spinValue
            End If
            Form1.lblRunningScore1.Text = Form1.Player1Score.ToString("C0")
            Form1.lblRunningScore2.Text = Form1.Player2Score.ToString("C0")
            tmrBack.Enabled = True
            lblZ.Enabled = False
        Else
            lblZ.BackColor = Color.Red
            If Form1.Player = 1 Then
                Form1.Player = 2
            Else
                Form1.Player = 1
            End If
            tmrBack.Enabled = True
            lblZ.Enabled = False
        End If
        If Phrase = Dash Then
            Me.Visible = False
            Solve.Visible = True
            Solve.lblSolved.Visible = True
            Solve.btnYes.Visible = True
            Solve.btnNo.Visible = True
        End If
    End Sub


End Class