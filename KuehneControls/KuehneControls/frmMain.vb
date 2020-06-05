Public Class frmMain

    Dim blnToggle As Boolean = False

    Private Sub btnSelect_Click(sender As Object, e As EventArgs) Handles btnSelect.Click
        If rdoStart.Checked Then
            timTimer.Start()
        Else
            timTimer.Stop()
        End If
    End Sub

    Private Sub timTimer_Tick(sender As Object, e As EventArgs) Handles timTimer.Tick
        If blnToggle Then
            pbxLight.Image = My.Resources._on
            blnToggle = False
        Else
            pbxLight.Image = My.Resources.off
            blnToggle = True
        End If
    End Sub
End Class
