Public Class Main
    Dim Guess_Word As String = "Apple"
    Dim Word_Array(0) As String
    Dim Word_Guessed(0) As String

    Private Sub Button_Enter_Click(sender As Object, e As EventArgs) Handles Button_Enter.Click
        ReDim Word_Array(Guess_Word.Length() - 1)
        ReDim Word_Guessed(Guess_Word.Length() - 1)
        For index = 0 To Guess_Word.Length - 1
            Word_Array(index) = Guess_Word.Chars(index)
        Next

        For index = 0 To Guess_Word.Length - 1
            Word_Guessed(index) = "_"
        Next


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        For index = 0 To Word_Array.Length - 1
            Label2.Text = Join(Word_Guessed, " ")
            Console.WriteLine(Join(Word_Guessed, " "))
        Next

    End Sub
End Class
