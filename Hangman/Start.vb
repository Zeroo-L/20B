Imports System.IO

Public Class Start
    Dim GuessWord As String 'The random guess word chosen from different files
    Dim WordArray(0) As String 'Array of each letter of the GuessWord
    Dim ProgressArray(0) As String 'Array of the progress that the user made
    Dim GuessedLetters(25) As String 'Array of the guessed letters
    Dim GuessedIndex As Integer = 0 'Index for the array of guseed latters
    Dim Lives As Integer = 10 'How many lives the player has
    Dim InputLetter As String

    Private Sub Start_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Randomize()
        Dim ListArray As String() = File.ReadAllLines(".\assets\test.txt")
        GuessWord = ListArray(Int(ListArray.Length * Rnd()))
        Console.WriteLine(GuessWord)

        ReDim WordArray(GuessWord.Length() - 1)
        ReDim ProgressArray(GuessWord.Length() - 1)

        For index = 0 To GuessWord.Length - 1
            WordArray(index) = GuessWord.Chars(index)
            ProgressArray(index) = "_"
        Next

        GuessLetters.Text = Join(ProgressArray, " ")

        InputBox.MaxLength() = 1

        GuessedLettersLabel.Text = Join(GuessedLetters, " ")

    End Sub

    Private Sub Start_Button_Click(sender As Object, e As EventArgs) Handles StartButton.Click
        StartPanel.Visible = False
        GamePanel.Visible = True

    End Sub

    Private Sub Button_Enter_Click(sender As Object, e As EventArgs) Handles Button_Enter.Click
        Call MainGameLoop()
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

    Private Sub InputBox_KeyDown(sender As Object, e As KeyEventArgs) Handles InputBox.KeyDown
        If e.KeyCode = Keys.Enter Then
            Console.WriteLine("Enter is pressed")
            Call MainGameLoop()
        End If
    End Sub

    Private Sub MainGameLoop()
        Dim Correct As Boolean = False 'If the input is correct or not

        For index = 0 To 25 'Check if letter is used already
            If InputBox.Text = GuessedLetters(index) Then
                MsgBox("| " & InputBox.Text & " | has already been used", 0, "Message")
                InputBox.Clear()
                Exit Sub
            End If
        Next


        For index = 0 To GuessWord.Length - 1
            If (InputBox.Text.Equals(WordArray(index), StringComparison.InvariantCultureIgnoreCase)) Then
                ProgressArray(index) = WordArray(index)
                Correct = True
            End If
        Next

        If Correct = False Then
            Lives = Lives - 1
        End If

        Console.WriteLine(Lives)

        GuessedLetters(GuessedIndex) = InputBox.Text.ToUpper
        GuessedIndex = GuessedIndex + 1
        InputBox.Clear()


        GuessLetters.Text = Join(ProgressArray, " ")
        GuessedLettersLabel.Text = Join(GuessedLetters, " ")

        If Lives = 0 Then
            Console.WriteLine("game lost")
        End If
        If Join(ProgressArray, "") = Join(WordArray, "") Then
            Console.WriteLine("game won")
        End If
    End Sub
End Class