Imports System.Drawing.Drawing2D


Public Class Form1

    Public Player As Integer
    Dim Value As Integer
    Dim Number As Integer
    Public spinValue As Integer
    Public Player1Score As Integer
    Public Player2Score As Integer
    Public Player1TotalScore As Integer
    Public Player2TotalScore As Integer


    Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles Timer.Tick

        If Number = Value Then
            EndImage()
            Number = 0
            Timer.Interval = 30
            Timer.Enabled = False
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
            spinValue = 0
            If Player = 1 Then
                Player = 2
                Player1Score = 0
            Else
                Player = 1
                Player2Score = 0
            End If
            Player1Score = 0
            Player2Score = 0
            lblRunningScore1.Text = Player1Score.ToString("C0")
            lblRunningScore2.Text = Player2Score.ToString("C0")
            pic1.Image = My.Resources.O1
            If Player = 1 Then
                lblPlayer1.Visible = True
                lblPlayer2.Visible = False
            Else
                lblPlayer2.Visible = True
                lblPlayer1.Visible = False
            End If
        ElseIf Number Mod 25 = 1 Then
            pic1.Image = My.Resources.S2
            lblValue.Text = "$1000"
            spinValue = 1000
        ElseIf Number Mod 25 = 2 Then
            pic1.Image = My.Resources.S3
            lblValue.Text = "$2000"
            spinValue = 2000
        ElseIf Number Mod 25 = 3 Then
            pic1.Image = My.Resources.S4
            lblValue.Text = "$1000"
            spinValue = 1000
        ElseIf Number Mod 25 = 4 Then
            pic1.Image = My.Resources.S5
            lblValue.Text = "$5000"
            spinValue = 5000
        ElseIf Number Mod 25 = 5 Then
            pic1.Image = My.Resources.S6
            lblValue.Text = "$1000"
            spinValue = 1000
        ElseIf Number Mod 25 = 6 Then
            pic1.Image = My.Resources.S7
            lblValue.Text = "SKIP"
            spinValue = 0
            If Player = 1 Then
                Player = 2
            Else
                Player = 1
            End If
            If Player = 1 Then
                lblPlayer1.Visible = True
                lblPlayer2.Visible = False
            Else
                lblPlayer2.Visible = True
                lblPlayer1.Visible = False
            End If
            pic1.Image = My.Resources.O1
        ElseIf Number Mod 25 = 7 Then
            pic1.Image = My.Resources.S8
            lblValue.Text = "$2000"
            spinValue = 2000
        ElseIf Number Mod 25 = 8 Then
            pic1.Image = My.Resources.S9
            lblValue.Text = "$1000"
            spinValue = 1000
        ElseIf Number Mod 25 = 9 Then
            pic1.Image = My.Resources.S10
            lblValue.Text = "$1000"
            spinValue = 1000
        ElseIf Number Mod 25 = 10 Then
            pic1.Image = My.Resources.S11
            lblValue.Text = "$2000"
            spinValue = 2000
        ElseIf Number Mod 25 = 11 Then
            pic1.Image = My.Resources.S12
            lblValue.Text = "BANKRUPT"
            spinValue = 0
            If Player = 1 Then
                Player = 2
                Player1Score = 0
            Else
                Player = 1
                Player2Score = 0
            End If
            Player1Score = 0
            Player2Score = 0
            lblRunningScore1.Text = Player1Score.ToString("C0")
            lblRunningScore2.Text = Player2Score.ToString("C0")
            pic1.Image = My.Resources.O1
            If Player = 1 Then
                lblPlayer1.Visible = True
                lblPlayer2.Visible = False
            Else
                lblPlayer2.Visible = True
                lblPlayer1.Visible = False
            End If
        ElseIf Number Mod 25 = 12 Then
            pic1.Image = My.Resources.S13
            lblValue.Text = "$1000"
            spinValue = 1000
        ElseIf Number Mod 25 = 13 Then
            pic1.Image = My.Resources.S14
            lblValue.Text = "$1000"
            spinValue = 1000
        ElseIf Number Mod 25 = 14 Then
            pic1.Image = My.Resources.S15
            lblValue.Text = "10000"
            spinValue = 10000
        ElseIf Number Mod 25 = 15 Then
            pic1.Image = My.Resources.S16
            lblValue.Text = "5000"
            spinValue = 5000
        ElseIf Number Mod 25 = 16 Then
            pic1.Image = My.Resources.S17
            lblValue.Text = "SKIP"
            spinValue = 0
            If Player = 1 Then
                Player = 2
            Else
                Player = 1
            End If
            pic1.Image = My.Resources.O1
            If Player = 1 Then
                lblPlayer1.Visible = True
                lblPlayer2.Visible = False
            Else
                lblPlayer2.Visible = True
                lblPlayer1.Visible = False
            End If
        ElseIf Number Mod 25 = 17 Then
            pic1.Image = My.Resources.S18
            lblValue.Text = "$2000"
            spinValue = 2000
        ElseIf Number Mod 25 = 18 Then
            pic1.Image = My.Resources.S19
            lblValue.Text = "$5000"
            spinValue = 5000
        ElseIf Number Mod 25 = 19 Then
            pic1.Image = My.Resources.S20
            lblValue.Text = "$2000"
            spinValue = 2000
        ElseIf Number Mod 25 = 20 Then
            pic1.Image = My.Resources.S21
            lblValue.Text = "$1000"
            spinValue = 1000
        ElseIf Number Mod 25 = 21 Then
            pic1.Image = My.Resources.S22
            lblValue.Text = "$1000"
            spinValue = 1000
        ElseIf Number Mod 25 = 22 Then
            pic1.Image = My.Resources.S23
            lblValue.Text = "$2000"
            spinValue = 2000
        ElseIf Number Mod 25 = 23 Then
            pic1.Image = My.Resources.S24
            lblValue.Text = "SKIP"
            spinValue = 0
            If Player = 1 Then
                Player = 2
            Else
                Player = 1
            End If
            If Player = 1 Then
                lblPlayer1.Visible = True
                lblPlayer2.Visible = False
            Else
                lblPlayer2.Visible = True
                lblPlayer1.Visible = False
            End If
            pic1.Image = My.Resources.O1
        ElseIf Number Mod 25 = 24 Then
            pic1.Image = My.Resources.S25
            lblValue.Text = "$1000"
            spinValue = 1000
        End If

        If spinValue <> 0 Then
            tmrWait.Enabled = True
        End If
    End Sub


    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        lblValue.Text = String.Empty
        Number = 0
        Timer.Interval = 30
        Randomize()
        Value = Int((50 * Rnd()) + 25)
        Timer.Enabled = True
    End Sub

    Private Sub tmrWait_Tick(sender As Object, e As EventArgs) Handles tmrWait.Tick
        Me.Visible = False
        Guess.Visible = True
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        lblPlayer1.Visible = True
        lblPlayer2.Visible = False
        Player = 1

    End Sub

    Private Sub pic2_Click(sender As Object, e As EventArgs) Handles pic2.Click
        lblValue.Text = String.Empty
        Number = 0
        Timer.Interval = 30
        Randomize()
        Value = Int((50 * Rnd()) + 25)
        Timer.Enabled = True
    End Sub

    Private Sub Form1_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        pic1.Image = My.Resources.O1
        tmrWait.Enabled = False
        lblValue.Text = String.Empty
        If Player = 1 Then
            lblPlayer1.Visible = True
            lblPlayer2.Visible = False
        Else
            lblPlayer2.Visible = True
            lblPlayer1.Visible = False
        End If
    End Sub
End Class
