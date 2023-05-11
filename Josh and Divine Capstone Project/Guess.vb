Imports System.IO

Public Class Guess

    Dim LetterAmount As Integer
    Public strFileName As String
    Dim strShortName As String
    Dim Phrase As String
    Dim Dash As String
    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click


    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click

    End Sub

    Private Sub Guess_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dash = ""
        Phrase = String.Empty
        If Form1.Player = 1 Then
            lblPlayer21.Visible = True
            lblPlayer22.Visible = False
        Else
            lblPlayer22.Visible = True
            lblPlayer21.Visible = False
        End If
        tmrBack.Enabled = False

        strFileName = String.Empty
        Dim Open As New OpenFileDialog()
        Dim myStreamReader As StreamReader
        Open.Filter = "Text [*.txt*]|*.txt|All Files [*.*]|*.*"
        Open.CheckFileExists = True
        Open.Title = "OpenFile"
        Open.ShowDialog(Me)
        Try
            strFileName = Open.FileName
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
        myStreamReader = File.OpenText(Open.FileName)
        Do Until myStreamReader.Peek = -1
            lstMain.Items.Add(myStreamReader.ReadLine())
        Loop

        Dash = String.Empty
        Phrase = String.Empty
        lblPhrase.Text = String.Empty

        Phrase = lstMain.Items.Item(Int((lstMain.Items.Count * Rnd())))
        Phrase = Phrase.ToUpper()

        For Each Letter In Phrase
            If Letter <> " " Then
                Dash = Dash + "-"
            Else
                Dash = Dash + " "
            End If
        Next
        lblPhrase.Text = Dash
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
    End Sub



    Private Sub tmrBack_Tick(sender As Object, e As EventArgs) Handles tmrBack.Tick
        Me.Visible = False
        Form1.Visible = True
    End Sub

    Private Sub Guess_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        LetterAmount = 0
        tmrBack.Enabled = False
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
    End Sub
End Class