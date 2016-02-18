Public Class Form1
    'websites that may help
    'for the looping set times http://www.wiseowl.co.uk/blog/s193/vba-for-next.htm
    'need some varbiles
    Private sent As Integer
    Private plus1 As Integer
    Private count As Integer

    Private Sub Start_Click(sender As System.Object, e As System.EventArgs) Handles Start.Click
        Delay.Enabled = True
    End Sub

    Private Sub Delay_Tick(sender As System.Object, e As System.EventArgs) Handles Delay.Tick
        Delay.Enabled = False
        sent = 0
        count = 0
        Begin.Enabled = True
    End Sub

    'Start loop when aftter button is pressed and the delay  timmer is over
    Private Sub Begin_Tick(sender As System.Object, e As System.EventArgs) Handles Begin.Tick
        sentcounter.Text = count.ToString() + " times"
        plus1 = Integer.Parse(add1.Text)
        If sent < amount.Value Then
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
End Class
