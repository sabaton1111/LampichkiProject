Option Strict On
Public Class BulbForm
    Dim SW As New Stopwatch
    Public Property Dialog As DialogResult
    Dim Random1 As Integer
    Dim Random2 As Integer
    Dim IFMissed As Boolean = False
    Dim missed As Integer = 0
    Private Sub StopWatchTimer_Tick(sender As Object, e As EventArgs) Handles StopWatchTimer.Tick
        TimeLabel.Text = SW.Elapsed.ToString
    End Sub
    Sub WrongAnswer()
        ListOfResults.Items.Add(WrongLabel.Text)
        Dim Item As New ListViewItem(CStr(ListOfResults.Items.Count + 1))
        Item.SubItems.Add(SW.Elapsed.ToString)
        ListOfResults.Items.Add(TimeLabel.Text)
        NumberOfWrongAnswers.Text = CStr(Val(NumberOfWrongAnswers.Text) + 1)
    End Sub
    Sub CorrectAnswer()
        ListOfResults.Items.Add(CorrectLabel.Text)
        Dim Item As New ListViewItem(CStr(ListOfResults.Items.Count + 1))
        Item.SubItems.Add(SW.Elapsed.ToString)
        ListOfResults.Items.Add(TimeLabel.Text)
        NumberOfCorrectAnswers.Text = CStr(Val(NumberOfCorrectAnswers.Text) + 1)
    End Sub
    Sub MissedClick()
        If Random2 = 1 And Random1 = 1 Then
            IFMissed = True
        Else
            IFMissed = False
        End If
        If IFMissed = True Then
            missed = missed + 1
        End If
        NumberOfMissed.Text = CStr(missed - Val(NumberOfCorrectAnswers.Text))
    End Sub
    Sub Level()
        ListOfResults.Items.Clear()
        StartStopButton.Text = "Стоп"
        SW = Stopwatch.StartNew
        StopWatchTimer.Interval = 1
        StopWatchTimer.Start()
        RandomTimer.Enabled = True
        RandomTimer.Enabled = False
        ChangeTimer.Enabled = True
        Bulb1PictureBox.Image = My.Resources.kp
        Bulb2PictureBox.Image = My.Resources.kp
        RandomTimer.Enabled = True
        ChangeTimer.Enabled = False
    End Sub
    Sub startEasy()
        Level()
        RandomTimer.Interval = 1000
        ChangeTimer.Interval = 1500
    End Sub
    Sub startVeryHard()
        Level()
        RandomTimer.Interval = 550
        ChangeTimer.Interval = 550
    End Sub
    Sub startHard()
        Level()
        RandomTimer.Interval = 750
        ChangeTimer.Interval = 750
    End Sub
    Sub startMedium()
        Level()
        RandomTimer.Interval = 1000
        ChangeTimer.Interval = 1000
    End Sub
    Sub Vreme()
        StopWatchTimer.Stop()
        StopWatchTimer.Enabled = False
        StartStopButton.Text = "Старт"
        StopWatchTimer.Stop()
        SW.Stop()
        TimeLabel.Text = SW.Elapsed.ToString
        RandomTimer.Enabled = False
        ChangeTimer.Enabled = False
        Min1Timer.Enabled = False
        Min3Timer.Enabled = False
        Min5Timer.Enabled = False
        LevelPanel.Enabled = True
        Bulb1PictureBox.Image = My.Resources.kp
        Bulb2PictureBox.Image = My.Resources.kp
        Bulb1PictureBox.Enabled = False
        Bulb2PictureBox.Enabled = False
    End Sub
    Sub Minn1()
        Vreme()
        TimeLabel.Text = "00:01:00.0000000"
    End Sub
    Sub Minn2()
        Vreme()
        TimeLabel.Text = "00:02:00.0000000"
    End Sub
    Sub Minn3()
        Vreme()
        TimeLabel.Text = "00:03:00.0000000"
    End Sub
    Sub Minn5()
        Vreme()
        TimeLabel.Text = "00:05:00.0000000"
    End Sub
    Private Sub StartStopButton_Click(sender As Object, e As EventArgs) Handles StartStopButton.Click
        If Min1.Checked Then
            Min1Timer.Start()
        End If
        If Min2.Checked Then
            Min2Timer.Start()
        End If
        If Min3.Checked Then
            Min3Timer.Start()
        End If
        If Min5.Checked Then
            Min5Timer.Start()
        End If
        Select Case StartStopButton.Text
            Case "Старт"
                If Easy.Checked And Min2.Checked Then
                    startEasy()
                End If
                If Easy.Checked And Min5.Checked Then
                    startEasy()
                End If
                If Easy.Checked And Min1.Checked Then
                    startEasy()
                End If
                If Easy.Checked And Min3.Checked Then
                    startEasy()
                End If
                If VeryHard.Checked And Min2.Checked Then
                    startVeryHard()
                End If
                If VeryHard.Checked And Min5.Checked Then
                    startVeryHard()
                End If
                If VeryHard.Checked And Min1.Checked Then
                    startVeryHard()
                End If
                If VeryHard.Checked And Min3.Checked Then
                    startVeryHard()
                End If
                If Hard.Checked And Min2.Checked Then
                    startHard()
                End If
                If Hard.Checked And Min5.Checked Then
                    startHard()
                End If
                If Hard.Checked And Min1.Checked Then
                    startHard()
                End If
                If Hard.Checked And Min3.Checked Then
                    startHard()
                End If
                If Medium.Checked And Min2.Checked Then
                    startMedium()
                End If
                If Medium.Checked And Min5.Checked Then
                    startMedium()
                End If
                If Medium.Checked And Min3.Checked Then
                    startMedium()
                End If
                If Medium.Checked And Min1.Checked Then
                    startMedium()
                End If
                LevelPanel.Enabled = False
                TimePanel.Enabled = False
                If Easy.Checked = False And Medium.Checked = False And Hard.Checked = False And VeryHard.Checked = False Then
                    If Min1.Checked = False And Min2.Checked = False And Min3.Checked = False And Min5.Checked = False Then
                        Beep()
                        Me.Hide()
                        NotCheckedForm.Show()
                    End If
                End If
            Case "Стоп"
                StartStopButton.Text = "Старт"
                StopWatchTimer.Stop()
                SW.Stop()
                TimeLabel.Text = SW.Elapsed.ToString
                RandomTimer.Enabled = False
                ChangeTimer.Enabled = False
                Bulb1PictureBox.Image = My.Resources.kp
                Bulb2PictureBox.Image = My.Resources.kp
                Min1Timer.Stop()
                Min2Timer.Stop()
                Min3Timer.Stop()
                Min5Timer.Stop()
                LevelPanel.Enabled = True
                TimePanel.Enabled = True
        End Select
    End Sub
    
    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles Bulb1PictureBox.Click
        If Random2 = 1 And Random1 = 1 Then
            CorrectAnswer()
        End If
        If Random2 = 1 And Random1 = 2 Then
            WrongAnswer()
        End If
        If Random2 = 1 And Random1 = 3 Then
            WrongAnswer()
        End If
        If Random2 = 2 Then
            WrongAnswer()
        End If
    End Sub
    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles Bulb2PictureBox.Click
        If Random1 = 3 Then
            WrongAnswer()
        End If
        If Random1 = 2 And Random2 = 3 Then
            CorrectAnswer()
        End If
        If Random1 = 2 And Random2 = 1 Then
            WrongAnswer()
        End If
        If Random1 = 2 And Random2 = 2 Then
            WrongAnswer()
        End If
    End Sub
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Beep()
        Me.Hide()
        MessageBoxExit.Show()
    End Sub
    Private Sub RandomTimer_Tick(sender As Object, e As EventArgs) Handles RandomTimer.Tick
        If Bulb1PictureBox.Enabled = False And Bulb2PictureBox.Enabled = False Then
            Bulb1PictureBox.Enabled = True
            Bulb2PictureBox.Enabled = True
        End If
        Dim vqrno As Random
        vqrno = New Random
        Random2 = vqrno.Next(1, 4)
        TextBox4.Text = Random2.ToString
        If Random2 = 1 Then
            Bulb1PictureBox.Image = My.Resources.green1
        End If
        If Random2 = 2 Then
            Bulb1PictureBox.Image = My.Resources.red1
        End If
        Dim random As Random
        random = New Random
        Random1 = random.Next(1, 5)
        TextBox3.Text = Random1.ToString
        If Random1 = 3 Then
            Bulb2PictureBox.Image = My.Resources.red1
        End If
        If Random1 = 2 Then
            Bulb2PictureBox.Image = My.Resources.green1
        End If
        Bulb2PictureBox.Enabled = True
        Bulb2PictureBox.Visible = True
        RandomTimer.Enabled = False
        ChangeTimer.Enabled = True
    End Sub
    Private Sub ChangeTimer_Tick(sender As Object, e As EventArgs) Handles ChangeTimer.Tick
        Bulb1PictureBox.Image = My.Resources.kp
        Bulb2PictureBox.Image = My.Resources.kp
        Bulb1PictureBox.Enabled = False
        Bulb2PictureBox.Enabled = False
        MissedClick()
        RandomTimer.Enabled = True
        ChangeTimer.Enabled = False
    End Sub
    Private Sub ЗапазиРезултатToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ЗапазиРезултатToolStripMenuItem.Click
        Me.Hide()
        SaveForm.Show()
    End Sub
    Private Sub RestartButton_Click(sender As Object, e As EventArgs) Handles RestartButton.Click
        ListOfResults.Items.Clear()
        NumberOfCorrectAnswers.Text = "0"
        NumberOfWrongAnswers.Text = "0"
        NumberOfMissed.Text = "0"
        missed = 0
        LevelPanel.Enabled = False
        LevelPanel.Enabled = True
        TimePanel.Enabled = False
        TimePanel.Enabled = True
        Min1.Checked = False
        Min2.Checked = False
        Min3.Checked = False
        Min5.Checked = False
        Easy.Checked = False
        Medium.Checked = False
        Hard.Checked = False
        VeryHard.Checked = False
        StartStopButton.Text = "Старт"
        SW = Stopwatch.StartNew
        StopWatchTimer.Interval = 1
        StopWatchTimer.Stop()
        SW.Stop()
        TimeLabel.Text = "00:00:00:0000000"
        RandomTimer.Enabled = False
        ChangeTimer.Enabled = False
        Bulb1PictureBox.Image = My.Resources.kp
        Bulb2PictureBox.Image = My.Resources.kp
    End Sub
    Private Sub ИзходToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ИзходToolStripMenuItem.Click
        Beep()
        Dim result As Integer = MessageBox.Show("Сигурни ли сте, че искате да излезнете от програмата? Ако не сте запазили вашите резултати, те ще бъдат изгубени!", "Изход", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
        If result = DialogResult.Cancel Then
        ElseIf result = DialogResult.OK Then
            Me.Close()
        End If
    End Sub

    Private Sub Min1Timer_Tick(sender As Object, e As EventArgs) Handles Min1Timer.Tick
        If Min1.Checked Then
            Minn1()
            Min1Timer.Stop()
            TimePanel.Enabled = True
        End If
    End Sub
    Private Sub Min2Timer_Tick(sender As Object, e As EventArgs) Handles Min2Timer.Tick
        If Min2.Checked Then
            Minn2()
            Min2Timer.Stop()
            TimePanel.Enabled = True
        End If
    End Sub
    Private Sub Min3Timer_Tick(sender As Object, e As EventArgs) Handles Min3Timer.Tick
        If Min3.Checked Then
            Minn3()
            Min3Timer.Stop()
            TimePanel.Enabled = True
        End If
    End Sub
    Private Sub Min5Timer_Tick(sender As Object, e As EventArgs) Handles Min5Timer.Tick
        If Min5.Checked Then
            Minn5()
            Min5Timer.Stop()
            TimePanel.Enabled = True
        End If
    End Sub
    Private Sub ЗаПрограматаToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ЗаПрограматаToolStripMenuItem.Click
        Me.Hide()
        HelpForm.Show()
    End Sub
    Private Sub ProgramHelpButton_Click(sender As Object, e As EventArgs) Handles ProgramHelpButton.Click
        Me.Hide()
        HelpForm.Show()
    End Sub
    Private Sub ClearScreenButton_Click(sender As Object, e As EventArgs) Handles ClearScreenButton.Click
        ListOfResults.Items.Clear()
    End Sub
    Private Sub SaveResultsButton_Click(sender As Object, e As EventArgs) Handles SaveResultsButton.Click
        Me.Hide()
        SaveForm.Show()
    End Sub
End Class

