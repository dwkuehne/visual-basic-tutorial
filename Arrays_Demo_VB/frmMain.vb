Public Class frmMain
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim arrFirstNames(6) As String 'Array of 7 strings (0-6)
        arrFirstNames(0) = "David"
        arrFirstNames(1) = "Gary"
        arrFirstNames(2) = "James"
        arrFirstNames(3) = "Alley"
        arrFirstNames(4) = "Casey"
        arrFirstNames(5) = "Kathy"
        arrFirstNames(6) = "Susie"

        lbxFirstNames.Items.Add("First Names")
        For i = 1 To arrFirstNames.Length
            lbxFirstNames.Items.Add(arrFirstNames(i - 1))
        Next

        Dim arrLastNames() As String = {"Kuehne", "Page", "Flippin", "Borden", "Jones", "Wiganowski", "Watkins"}

        lbxLastNames.Items.Add("Last Names")
        For i = 1 To arrLastNames.Length
            lbxLastNames.Items.Add(arrLastNames(i - 1))
        Next

        lbxFullNames.Items.Add("Full Names")
        For i = 1 To arrFirstNames.Length
            lbxFullNames.Items.Add(arrFirstNames(i - 1) + " " + arrLastNames(i - 1))
        Next

        Dim arrFullNames(6, 1) As String
        Dim arrAlternate(,) As String = {{"David", "Kuehne"}, {"Gary", "Page"}, {"etc...", "etc..."}}

        arrFullNames(0, 0) = "David"
        arrFullNames(0, 1) = "Kuehne"

        arrFullNames(1, 0) = "Gary"
        arrFullNames(1, 1) = "Page"

        arrFullNames(2, 0) = "James"
        arrFullNames(2, 1) = "Flippin"

        arrFullNames(3, 0) = "Alley"
        arrFullNames(3, 1) = "Borden"

        arrFullNames(4, 0) = "Casey"
        arrFullNames(4, 1) = "Jones"

        arrFullNames(5, 0) = "Kathy"
        arrFullNames(5, 1) = "Wilganowski"

        arrFullNames(6, 0) = "Susie"
        arrFullNames(6, 1) = "Watkins"

        lbxTwoDimensional.Items.Add("Two Dimensional Array")
        For i = 0 To 6
            lbxTwoDimensional.Items.Add(arrFullNames(i, 0) + " " + arrFullNames(i, 1))
        Next
    End Sub
End Class