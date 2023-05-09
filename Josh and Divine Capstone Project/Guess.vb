Imports System.IO

Public Class Guess

    Public strFileName As String
    Dim strShortName As String
    Dim Phrase As String
    Dim Dash As String
    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click
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

    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
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

    Private Sub Guess_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dash = ""
        Phrase = String.Empty
    End Sub

    Private Sub lblA_Click(sender As Object, e As EventArgs) Handles lblA.Click
        If Phrase.Contains("A") Then
            For letter As Integer = 0 To Phrase.Length - 1
                If Phrase(letter) = "A" Then
                    Dash = Dash.Remove(letter, 1)
                    Dash = Dash.Insert(letter, "A")
                End If
            Next letter
            lblPhrase.Text = Dash
            lblA.BackColor = Color.Green

        Else
            MsgBox("Try Again")
            lblA.BackColor = Color.Red
        End If
    End Sub
End Class