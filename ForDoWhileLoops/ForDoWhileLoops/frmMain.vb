Public Class frmMain
    Private Sub btnForLoop_Click(sender As Object, e As EventArgs) Handles btnForLoop.Click
        Dim strName As String = "Kuehne"
        For index = 1 To strName.Length
            lbxList.Items.Add(strName(index - 1)) '0 based index, Length will cause out of bounds
        Next
    End Sub

    Private Sub btnDoUntil_Click(sender As Object, e As EventArgs) Handles btnDoUntil.Click
        Dim strInput As String = ""
        Do Until strInput = "Quit"
            strInput = InputBox("Please enter a word. Type Quit to exit loop", "Enter Word(s)")
            If strInput = "Quit" Then
                Return
            End If
            lbxList.Items.Add(strInput)
        Loop
    End Sub

    Private Sub btnWhileLoop_Click(sender As Object, e As EventArgs) Handles btnWhileLoop.Click
        While lbxList.Items.Count < 5
            lbxList.Items.Add(lbxList.Items.Count)
            If lbxList.Items.Count = 5 Then
                lbxList.Items.Add("End of List")
            End If
        End While
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lbxList.Items.Clear()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub
End Class
