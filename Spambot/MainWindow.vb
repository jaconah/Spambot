Public Class MainWindow
    'declare the varbiles
    Private sent As Integer
    Private plus1 As Integer
    Private count As Integer

    Private Sub Start_Click(sender As System.Object, e As System.EventArgs) Handles Start.Click
        Delay.Enabled = True
        If amount.Value = -1 Then
            ProgressBar1.Maximum = 1
        Else
            ProgressBar1.Maximum = amount.Value
        End If
    End Sub

    Private Sub Delay_Tick(sender As System.Object, e As System.EventArgs) Handles Delay.Tick
        Delay.Enabled = False
        Begin.Enabled = True
    End Sub

    'Start loop when aftter button is pressed and the delay  timmer is over
    Private Sub Begin_Tick(sender As System.Object, e As System.EventArgs) Handles Begin.Tick
        sentcounter.Text = count.ToString() + " times"
        plus1 = Integer.Parse(add1.Text)
        ProgressBar1.Value = sent
        If amount.Value = -1 Then
            SendKeys.Send(Message.Text)
            SendKeys.Send("{ENTER}")
            count = count + plus1

        ElseIf sent < amount.Value Then
            SendKeys.Send(Message.Text)
            SendKeys.Send("{ENTER}")
            sent = sent + plus1
            count = count + plus1
        ElseIf sent = amount.Value Then
            Begin.Enabled = False
        End If
    End Sub

    Private Sub pause_Click(sender As Object, e As EventArgs) Handles pause.Click
        Begin.Enabled = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        sent = 0
        count = 0
        Begin.Enabled = False
    End Sub
End Class
