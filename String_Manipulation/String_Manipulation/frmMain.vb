Public Class frmMain
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Output() 'Calling our Sub
    End Sub
    Sub Output()
        'Update our label text with our function return value
        lblOutput.Text = Manipulate(tbxInput.Text) 'Pass in our textbox control text
    End Sub

    Function Manipulate(strString As String) As String
        Dim strOutput As String = ""
        Dim intNumOfTotalChars As Integer = 0
        Dim intNumOfNums As Integer = 0
        Dim intNumOfWhiteSpace As Integer = 0
        Dim strOriginal As String = ""
        Dim strNew As String = ""

        strOriginal = strString 'Store the original
        intNumOfTotalChars = strString.Length 'Count each character

        'Replace a string, checking the equivalent to all lowercase characters
        strNew = strOriginal.ToLower.Replace("cat", "Dog") + vbNewLine
        strOutput = strNew 'Add to our output string

        If strOriginal.Length >= 5 Then
            strNew = strOriginal.Substring(0, 5) 'Get the first 5 characters and assign to variable
            strOutput += "The first 5 chars are: " + strNew + vbNewLine 'Append to output string
        End If

        For index = 1 To strString.Length
            'Count the numbers in the string
            If Char.IsDigit(strString(index - 1)) Then
                intNumOfNums += 1
            End If
            'Count the number of whitespaces in the string
            If Char.IsWhiteSpace(strString(index - 1)) Then
                intNumOfWhiteSpace += 1
            End If
        Next

        'Creating a random number to randomize where we search our text string
        If strString.Length > 0 Then
            Dim rand As Random = New Random 'Create a new "Random" object

            'Assign our new variable with the results of our random number
            'I'm expecting a number from 1 and however long the string is
            Dim randNum As Integer = rand.Next(1, strString.Length + 1)

            'Append to our output string
            strOutput += "Random number (" + (randNum).ToString() + ") for string: " +
                vbNewLine + strString.Substring(0, randNum) + vbNewLine
        End If

        'Append more to our Output String
        strOutput += "Number of characters in String: " + intNumOfTotalChars.ToString()
        strOutput += vbNewLine + "Number of digits in String: " + intNumOfNums.ToString()
        strOutput += vbNewLine + "Number of whitespaces in String: " + intNumOfWhiteSpace.ToString()

        Return strOutput 'Send the result back to whatever called it
    End Function
End Class