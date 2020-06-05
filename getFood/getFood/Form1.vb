Public Class Form1
    Private Sub btnGo_Click(sender As Object, e As EventArgs) Handles btnGo.Click

        Dim numbers As String = ""
        Dim newNumber As String = ""

        numbers = tbxPhone.Text.ToLower()

        For index = 0 To numbers.Length - 1

            Select Case numbers.Substring(index, 1)
                Case "a", "b", "c"
                    newNumber += "2"
                Case "d", "e", "f"
                    newNumber += "3"
                Case "g", "h", "i"
                    newNumber += "4"
                Case "j", "k", "l"
                    newNumber += "5"
                Case "m", "n", "o"
                    newNumber += "6"
                Case "p", "q", "r", "s"
                    newNumber += "7"
                Case "t", "u", "v"
                    newNumber += "8"
                Case "w", "x", "y", "z"
                    newNumber += "9"

                Case Else
                    newNumber += numbers.Substring(index, 1)
            End Select
        Next

        tbxNumbers.Text = newNumber

    End Sub
End Class
