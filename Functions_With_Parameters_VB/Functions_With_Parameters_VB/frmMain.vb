Public Class frmMain
    'This Sub Procedure will check the two textboxes
    'For Valid data, and update the controls to reflect
    'if the data is "Valid" or "Not Valid"
    Sub CheckValues()
        Dim decInput As Decimal = 0
        Dim strInput As String = ""

        'If the texbox can be converted to a decimal,
        'Assign it to variable decInput
        'DataType.TryParse(what to check, where to store)
        If Decimal.TryParse(tbxInputOne.Text, decInput) Then
            'Update Controls
            lblInputOne.Text = "Valid!"
            lblInputOne.ForeColor = Color.Green
        Else
            'Update Controls
            lblInputOne.Text = "Not Valid!"
            lblInputOne.ForeColor = Color.Red
        End If

        strInput = tbxInputTwo.Text 'Assign textbox text to strInput
        'Check to see if box is empty
        If strInput = "" Then
            'Update Controls
            lblInputTwo.Text = "Not Valid!"
            lblInputTwo.ForeColor = Color.Red
        End If

        'Check each character for invalid input
        For index = 1 To strInput.Length 'Length of the string entered
            'Check to see if a digit is present
            If Char.IsDigit(strInput(index - 1)) Then
                'Update Controls
                lblInputTwo.Text = "Not Valid!"
                lblInputTwo.ForeColor = Color.Red
                Return 'Return stops checking and returns to form
                'Be careful with Return if you want to continue checking
                'something in your block of code!

            Else 'This will say "Valid" for every "good" character.
                'The "Return" above is what keeps it from checking for 
                'a valid character AFTER a "bad" character.

                'Update Controls
                lblInputTwo.Text = "Valid!"
                lblInputTwo.ForeColor = Color.Green
            End If
        Next
    End Sub

    'This is a function that accepts two parameters
    'Format is MyFunc(name As DataType) As ReturnedDataType
    'Multipe parameters will be separated by commas
    Function ValidateData(inputOne As String, inputTwo As String) As Boolean
        Dim decCheck As Decimal = 0
        Dim strCheck As String = inputTwo
        Dim blnInputOne As Boolean = False
        Dim blnInputTwo As Boolean = False

        'Does it parse? Assign TRUE if it does, default is FALSE
        If Decimal.TryParse(inputOne, decCheck) Then
            blnInputOne = True 'Good Input!
        End If

        'Does the textbox contain a digit?
        For index = 1 To strCheck.Length
            If Char.IsDigit(strCheck(index - 1)) Then
                blnInputTwo = False 'Digit found!
                Exit For 'Stop the For Loop
                'A "Return" would break out of Function with 
                'invalid responses. I want to perform more logic,
                'So I only exit the For Loop to perform my IF statement
            Else
                blnInputTwo = True 'Good Input!
            End If
        Next

        If blnInputOne And blnInputTwo Then
            Return True 'If both input textboxes are valid
        Else
            Return False 'Something went wrong and data is not valid
        End If
    End Function

    Private Sub btnCheck_Click(sender As Object, e As EventArgs) Handles btnCheck.Click
        CheckValues() 'My "Update Controls" sub procedure

        'My Function returning a True or False to be used with
        'this IF/ELSE statement
        If ValidateData(tbxInputOne.Text, tbxInputTwo.Text) Then
            lblOutput.Text = "All input is valid."
        Else
            lblOutput.Text = "One or more errors present"
        End If
    End Sub
End Class