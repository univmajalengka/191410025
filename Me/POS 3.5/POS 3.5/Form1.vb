Public Class Form1

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If ProgressBar1.Value > 0 Then
            ProgressBar1.Value -= 2
            If ProgressBar1.Value = 20 Then
                Label1.ForeColor = Color.Aqua
            ElseIf ProgressBar1.Value = 40 Then
                Label1.ForeColor = Color.Orange
            ElseIf ProgressBar1.Value = 60 Then
                Label1.ForeColor = Color.GreenYellow
            ElseIf ProgressBar1.Value = 80 Then
                Label1.ForeColor = Color.Teal
            ElseIf ProgressBar1.Value = 100 Then
                Label1.ForeColor = Color.Aqua
            End If
        ElseIf ProgressBar1.Value = 0 Then
            Timer1.Stop()
            Dim i As New Form6
            i.Show()
            Me.Hide()
        End If
        
        If ProgressBar2.Value > 0 Then
            ProgressBar2.Value -= 2
        End If
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.TransparencyKey = Me.BackColor
    End Sub
End Class
