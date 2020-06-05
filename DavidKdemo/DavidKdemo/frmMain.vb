'A comment about Celsuis to Fahrenheit calculations
'The formula: F = (C * 1.8000) + 32.00

'PEMDAS - Parenthesis, Exponents, Multiply or Divide, Add or Subtract
Public Class frmMain
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim dblDegreesF As Double = 0
        Dim dblDegreesC As Double = 0

        If txtCelcius.Text = String.Empty Then
            Return
        End If

        If Char.IsDigit(txtCelcius.Text) Then
            dblDegreesC = txtCelcius.Text
            'The formula: F = (C * 1.8000) + 32.00
            dblDegreesF = dblDegreesC * 1.8 + 32.0
            lblDegrees.Text = "Degrees in Fahrenheit: " + dblDegreesF.ToString()
        Else
            Return
        End If

        Select Case dblDegreesF
            Case 212
                lblDegrees.Text = dblDegreesF.ToString() + " Fahrenheit"
                lblDegrees.Text += " - That's Boiling!"
            Case 32
                lblDegrees.Text = dblDegreesF.ToString() + " Fahrenheit"
                lblDegrees.Text += " - That's Freezing!"
            Case Else
                lblDegrees.Text = "Degrees in Fahrenheit: " + dblDegreesF.ToString()
        End Select

        If dblDegreesF > 100 Then
            pbxPicture.Image = My.Resources.hot
        ElseIf dblDegreesF > 75 Then
            pbxPicture.Image = My.Resources.warm
        Else
            pbxPicture.Image = My.Resources.cold
        End If

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtCelcius.Clear()
        txtCelcius.Select()
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtCelcius.Select()
    End Sub
End Class
