Public Class frmMain
    Dim Box1 As Box = New Box() 'New instance of Box
    Dim Box2 As Box = New Box() 'New instance of Box
    Dim volume As Double = 0.0

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Box1.setHeight(5.0)
        Box1.setLength(6.0)
        Box1.setWidth(7.0)

        Box2.setLength(12.0)
        Box2.setWidth(13.0)
        Box2.setHeight(10.0)
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    Private Sub btnBox1_Click(sender As Object, e As EventArgs) Handles btnBox1.Click
        volume = Box1.getHeight * Box1.getWidth * Box1.getLength
        MessageBox.Show(volume.ToString("n2"))
    End Sub

    Private Sub btnBox2_Click(sender As Object, e As EventArgs) Handles btnBox2.Click
        MessageBox.Show(Box2.getVolume().ToString("n2"))
    End Sub

    Private Sub btnCustom_Click(sender As Object, e As EventArgs) Handles btnCustom.Click
        If Char.IsDigit(tbxHeight.Text) And Char.IsDigit(tbxWidth.Text) And Char.IsDigit(tbxLength.Text) Then
            Dim customBox As Box = New Box(tbxLength.Text, tbxWidth.Text, tbxHeight.Text)
            MessageBox.Show(customBox.getVolume().ToString("n2"))
        End If
    End Sub
End Class
