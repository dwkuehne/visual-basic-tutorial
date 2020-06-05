Public Class Form1
    Private Sub btnChange_Click(sender As Object, e As EventArgs) Handles btnChange.Click
        Dim getName As String = String.Empty
        getName = tbxGetText.Text

        Dim firstLetter As String
        firstLetter = getName.Substring(0, 1)

        Dim restOfString As String
        restOfString = getName.Substring(1, getName.Length - 1)

        tbxRead.Text = restOfString + firstLetter + "ay"

        'tbxRead.Text = getName.Substring(1, getName.Length - 1) +
        '    getName.Substring(0, 1) + "ay"

    End Sub
End Class
