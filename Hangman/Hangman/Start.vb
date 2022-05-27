Imports System.IO

Public Class Start
    Dim GuessWord As String
    Dim WordArray(0) As String
    Dim ProgressArray(0) As String
    Dim GuessedLetters(25) As String
    Dim GuessedIndex As Integer = 0
    Dim Lives As Integer = 10
    Dim Correct As Boolean

    Private Sub Start_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Randomize()
        Dim ListArray As String() = File.ReadAllLines(".\assets\test.txt")
        GuessWord = ListArray(Int(ListArray.Length * Rnd()))
        Console.WriteLine(GuessWord)
    End Sub

    Private Sub Start_Button_Click(sender As Object, e As EventArgs) Handles StartButton.Click
        StartPanel.Visible = False
        GamePanel.Visible = True

        ReDim WordArray(GuessWord.Length() - 1)
        ReDim ProgressArray(GuessWord.Length() - 1)

        For index = 0 To GuessWord.Length - 1
            WordArray(index) = GuessWord.Chars(index)
        Next

        For index = 0 To GuessWord.Length - 1
            ProgressArray(index) = "_"
        Next

        For index = 0 To WordArray.Length - 1
            GuessLetters.Text = Join(ProgressArray, " ")
        Next

    End Sub

    Private Sub Button_Enter_Click(sender As Object, e As EventArgs) Handles Button_Enter.Click

        For index = 0 To 25
            If InputBox.Text = GuessedLetters(index) Then
                MsgBox("| " & InputBox.Text & " | has already been used", 0, "Message")
                Exit Sub
            End If
        Next

        For index = 0 To GuessWord.Length - 1
            If (InputBox.Text.Equals(WordArray(index), StringComparison.InvariantCultureIgnoreCase)) Then
                Correct = True
                Exit For
            Else
                Correct = False
                Exit For
            End If
        Next

        Console.WriteLine(Correct)
        InputBox.Clear()


        For index = 0 To WordArray.Length - 1
            GuessLetters.Text = Join(ProgressArray, " ")
        Next
    End Sub

    Function LinearSearch(Target As String, SearchSpace() As String, Length As Integer) As Boolean
        For index = 0 To Length
            If Target = SearchSpace(index) Then
                Return True
            Else
                Return False
            End If
        Next
    End Function
End Class