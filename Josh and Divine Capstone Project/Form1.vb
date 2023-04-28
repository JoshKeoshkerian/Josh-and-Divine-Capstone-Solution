Public Class Form1

    Dim Value As Integer
    Dim Number As Integer

    Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles Timer.Tick

        Number += 1
        If Number = Value Then
            Timer.Enabled = False
        End If

        If Number Mod 24 = 0 Then
            pic1.Image = My.Resources.O1
            SpinWheel()
        ElseIf Number Mod 24 = 1 Then
            pic1.Image = My.Resources.O2
            SpinWheel()
        ElseIf Number Mod 24 = 2 Then
            pic1.Image = My.Resources.O3
            SpinWheel()
        ElseIf Number Mod 24 = 3 Then
            pic1.Image = My.Resources.O4
            SpinWheel()
        ElseIf Number Mod 24 = 4 Then
            pic1.Image = My.Resources.O5
            SpinWheel()
        ElseIf Number Mod 24 = 5 Then
            pic1.Image = My.Resources.O6
            SpinWheel()
        ElseIf Number Mod 24 = 6 Then
            pic1.Image = My.Resources.O7
            SpinWheel()
        ElseIf Number Mod 24 = 7 Then
            pic1.Image = My.Resources.O8
            SpinWheel()
        ElseIf Number Mod 24 = 8 Then
            pic1.Image = My.Resources.O9
            SpinWheel()
        ElseIf Number Mod 24 = 9 Then
            pic1.Image = My.Resources.O10
            SpinWheel()
        ElseIf Number Mod 24 = 10 Then
            pic1.Image = My.Resources.O11
            SpinWheel()
        ElseIf Number Mod 24 = 11 Then
            pic1.Image = My.Resources.O12
            SpinWheel()
        ElseIf Number Mod 24 = 12 Then
            pic1.Image = My.Resources.O13
            SpinWheel()
        ElseIf Number Mod 24 = 13 Then
            pic1.Image = My.Resources.O14
            SpinWheel()
        ElseIf Number Mod 24 = 14 Then
            pic1.Image = My.Resources.O15
            SpinWheel()
        ElseIf Number Mod 24 = 15 Then
            pic1.Image = My.Resources.O16
            SpinWheel()
        ElseIf Number Mod 24 = 16 Then
            pic1.Image = My.Resources.O17
            SpinWheel()
        ElseIf Number Mod 24 = 17 Then
            pic1.Image = My.Resources.O18
            SpinWheel()
        ElseIf Number Mod 24 = 18 Then
            pic1.Image = My.Resources.O19
            SpinWheel()
        ElseIf Number Mod 24 = 19 Then
            pic1.Image = My.Resources.O20
            SpinWheel()
        ElseIf Number Mod 24 = 20 Then
            pic1.Image = My.Resources.O21
            SpinWheel()
        ElseIf Number Mod 24 = 21 Then
            pic1.Image = My.Resources.O22
            SpinWheel()
        ElseIf Number Mod 24 = 22 Then
            pic1.Image = My.Resources.O23
            SpinWheel()
        ElseIf Number Mod 24 = 23 Then
            pic1.Image = My.Resources.O24
            SpinWheel()
        ElseIf Number Mod 24 = 24 Then
            pic1.Image = My.Resources.O25
            SpinWheel()
        End If

    End Sub

    Private Sub SpinWheel()
        If Number = Int(Value / 1.5) Then
            Timer.Interval = 150
        ElseIf Number = Int(Value / 1.25) Then
            Timer.Interval = 200
        ElseIf Number = Int(Value / 1.1) Then
            Timer.Interval = 350
        ElseIf Number = Int(Value / 1.05) Then
            Timer.Interval = 500
        ElseIf Number = Value - 1 Then
            Timer.Interval = 1000
        End If



    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Number = 0
        Timer.Interval = 100
        Randomize()
        Value = Int((75 * Rnd()) + 50)
        Timer.Enabled = True
    End Sub
End Class
