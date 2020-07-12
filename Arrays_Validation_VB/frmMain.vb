Public Class frmMain
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim arrTextboxes(2) As TextBox
        arrTextboxes(0) = tbxFirst
        arrTextboxes(1) = tbxLast
        arrTextboxes(2) = tbxColor

        For i = 0 To arrTextboxes.Length - 1
            If arrTextboxes(i).Text = "" Then
                MsgBox(arrTextboxes(i).Name + " needs input!")
                arrTextboxes(i).Focus()
                Return
            End If
        Next
        MsgBox("All fields have input!")
    End Sub
End Class
