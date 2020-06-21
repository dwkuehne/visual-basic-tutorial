Public Class frmMain

    Sub MySub() 'Performs actions, but doesn't return values
        lbxList.Items.Clear()
        lblOutput.Text = "Hello World"
        lblMyLabel.Text = "Hello, Dave"
        lblMyLabel.ForeColor = Color.Purple
    End Sub

    Function MyFunc() As String 'Performs actions that can be assigned to variables
        Dim myString As String = "I am a string of text."

        If tbxInput.Text IsNot "" Then
            myString = tbxInput.Text
        End If

        Return myString 'Returns a value when called
    End Function

    Function IsDave() As Boolean
        If tbxInput.Text = "Dave" Then
            Return True
        End If

        Return False
    End Function

    Private Sub btnMyButton_Click(sender As Object, e As EventArgs) Handles btnMyButton.Click
        MySub()
        'lblOutput.Text = MyFunc()

        If IsDave() Then
            lblOutput.Text = "I can't let you do that, Dave."
        Else
            lblOutput.Text = "Hello, There."
        End If

    End Sub
End Class