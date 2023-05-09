Imports System.Drawing.Drawing2D
Imports System.IO

Public Class Form1

    Dim Value As Integer
    Dim Number As Integer

    Public Sub Wait()
        System.Threading.Thread.Sleep(5000) ' 500 milliseconds = 0.5 seconds
    End Sub

    Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles Timer.Tick

        If Number = Value Then
            EndImage()
            Number = 0
            Timer.Interval = 30
            Timer.Enabled = False
            Me.Visible = False
            Guess.Show()
            Exit Sub

        End If
        Number += 1

        If Number Mod 25 = 0 Then
            pic1.Image = My.Resources.O1
            SpinWheel()
        ElseIf Number Mod 25 = 1 Then
            pic1.Image = My.Resources.O2
            SpinWheel()
        ElseIf Number Mod 25 = 2 Then
            pic1.Image = My.Resources.O3
            SpinWheel()
        ElseIf Number Mod 25 = 3 Then
            pic1.Image = My.Resources.O4
            SpinWheel()
        ElseIf Number Mod 25 = 4 Then
            pic1.Image = My.Resources.O5
            SpinWheel()
        ElseIf Number Mod 25 = 5 Then
            pic1.Image = My.Resources.O6
            SpinWheel()
        ElseIf Number Mod 25 = 6 Then
            pic1.Image = My.Resources.O7
            SpinWheel()
        ElseIf Number Mod 25 = 7 Then
            pic1.Image = My.Resources.O8
            SpinWheel()
        ElseIf Number Mod 25 = 8 Then
            pic1.Image = My.Resources.O9
            SpinWheel()
        ElseIf Number Mod 25 = 9 Then
            pic1.Image = My.Resources.O10
            SpinWheel()
        ElseIf Number Mod 25 = 10 Then
            pic1.Image = My.Resources.O11
            SpinWheel()
        ElseIf Number Mod 25 = 11 Then
            pic1.Image = My.Resources.O12
            SpinWheel()
        ElseIf Number Mod 25 = 12 Then
            pic1.Image = My.Resources.O13
            SpinWheel()
        ElseIf Number Mod 25 = 13 Then
            pic1.Image = My.Resources.O14
            SpinWheel()
        ElseIf Number Mod 25 = 14 Then
            pic1.Image = My.Resources.O15
            SpinWheel()
        ElseIf Number Mod 25 = 15 Then
            pic1.Image = My.Resources.O16
            SpinWheel()
        ElseIf Number Mod 25 = 16 Then
            pic1.Image = My.Resources.O17
            SpinWheel()
        ElseIf Number Mod 25 = 17 Then
            pic1.Image = My.Resources.O18
            SpinWheel()
        ElseIf Number Mod 25 = 18 Then
            pic1.Image = My.Resources.O19
            SpinWheel()
        ElseIf Number Mod 25 = 19 Then
            pic1.Image = My.Resources.O20
            SpinWheel()
        ElseIf Number Mod 25 = 20 Then
            pic1.Image = My.Resources.O21
            SpinWheel()
        ElseIf Number Mod 25 = 21 Then
            pic1.Image = My.Resources.O22
            SpinWheel()
        ElseIf Number Mod 25 = 22 Then
            pic1.Image = My.Resources.O23
            SpinWheel()
        ElseIf Number Mod 25 = 23 Then
            pic1.Image = My.Resources.O24
            SpinWheel()
        ElseIf Number Mod 25 = 24 Then
            pic1.Image = My.Resources.O25
            SpinWheel()
        End If

    End Sub

    Private Sub SpinWheel()
        If Number = Int(Value / 2) Then
            Timer.Interval = 50
        ElseIf Number = Int(Value / 1.5) Then
            Timer.Interval = 100
        ElseIf Number = Int(Value / 1.25) Then
            Timer.Interval = 200
        ElseIf Number = Int(Value / 1.1) Then
            Timer.Interval = 350
        ElseIf Number = Value - 1 Then
            Timer.Interval = 1000
        End If
    End Sub

    Private Sub EndImage()
        If Number Mod 25 = 0 Then
            pic1.Image = My.Resources.S1
            lblValue.Text = "BANKRUPT"
        ElseIf Number Mod 25 = 1 Then
            pic1.Image = My.Resources.S2
            lblValue.Text = "$1000"
        ElseIf Number Mod 25 = 2 Then
            pic1.Image = My.Resources.S3
            lblValue.Text = "$2000"
        ElseIf Number Mod 25 = 3 Then
            pic1.Image = My.Resources.S4
            lblValue.Text = "$1000"
        ElseIf Number Mod 25 = 4 Then
            pic1.Image = My.Resources.S5
            lblValue.Text = "$5000"
        ElseIf Number Mod 25 = 5 Then
            pic1.Image = My.Resources.S6
            lblValue.Text = "$1000"
        ElseIf Number Mod 25 = 6 Then
            pic1.Image = My.Resources.S7
            lblValue.Text = "SKIP"
        ElseIf Number Mod 25 = 7 Then
            pic1.Image = My.Resources.S8
            lblValue.Text = "$2000"
        ElseIf Number Mod 25 = 8 Then
            pic1.Image = My.Resources.S9
            lblValue.Text = "$1000"
        ElseIf Number Mod 25 = 9 Then
            pic1.Image = My.Resources.S10
            lblValue.Text = "$1000"
        ElseIf Number Mod 25 = 10 Then
            pic1.Image = My.Resources.S11
            lblValue.Text = "$2000"
        ElseIf Number Mod 25 = 11 Then
            pic1.Image = My.Resources.S12
            lblValue.Text = "BANKRUPT"
        ElseIf Number Mod 25 = 12 Then
            pic1.Image = My.Resources.S13
            lblValue.Text = "$1000"
        ElseIf Number Mod 25 = 13 Then
            pic1.Image = My.Resources.S14
            lblValue.Text = "$1000"
        ElseIf Number Mod 25 = 14 Then
            pic1.Image = My.Resources.S15
            lblValue.Text = "10000"
        ElseIf Number Mod 25 = 15 Then
            pic1.Image = My.Resources.S16
            lblValue.Text = "5000"
        ElseIf Number Mod 25 = 16 Then
            pic1.Image = My.Resources.S17
            lblValue.Text = "SKIP"
        ElseIf Number Mod 25 = 17 Then
            pic1.Image = My.Resources.S18
            lblValue.Text = "$2000"
        ElseIf Number Mod 25 = 18 Then
            pic1.Image = My.Resources.S19
            lblValue.Text = "$5000"
        ElseIf Number Mod 25 = 19 Then
            pic1.Image = My.Resources.S20
            lblValue.Text = "$2000"
        ElseIf Number Mod 25 = 20 Then
            pic1.Image = My.Resources.S21
            lblValue.Text = "$1000"
        ElseIf Number Mod 25 = 21 Then
            pic1.Image = My.Resources.S22
            lblValue.Text = "$1000"
        ElseIf Number Mod 25 = 22 Then
            pic1.Image = My.Resources.S23
            lblValue.Text = "$2000"
        ElseIf Number Mod 25 = 23 Then
            pic1.Image = My.Resources.S24
            lblValue.Text = "SKIP"
        ElseIf Number Mod 25 = 24 Then
            pic1.Image = My.Resources.S25
            lblValue.Text = "$1000"
        End If
        Wait()

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        lblValue.Text = String.Empty
        Number = 0
        Timer.Interval = 30
        Randomize()
        Value = Int((50 * Rnd()) + 25)
        Timer.Enabled = True
    End Sub




End Class
