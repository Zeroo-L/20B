﻿Imports System.IO

Public Class Form1
    Dim GuessWord As String 'The random guess word chosen from different files
    Dim WordArray(0) As String 'Array of each letter of the GuessWord
    Dim ProgressArray(0) As String 'Array of the progress that the user made
    Dim GuessedLetters(25) As String 'Array of the guessed letters
    Dim GuessedIndex As Integer = 0 'Index for the array of guseed latters
    Dim Lives As Integer = 10 'How many lives the player has
    Dim Score As Integer = 0 'THe score player has earn
    Dim Subject As String

    'Starting Screen
    Private Sub Start_Button_Click(sender As Object, e As EventArgs) Handles StartButton.Click
        StartPanel.Visible = False
        SubjectPanel.Visible = True
    End Sub

    Private Sub ExitPB_Click(sender As Object, e As EventArgs) Handles ExitPB.Click
        Application.Exit()
    End Sub

    'Subject Screen
    Private Sub SoftwareLabel_Click(sender As Object, e As EventArgs) Handles SoftwareLabel.Click
        Subject = "Software"
        Call GenerateRandomWord(".\assets\Software.txt")
        SubjectPanel.Visible = False
        GamePanel.Visible = True
    End Sub

    Private Sub PhysicsLabel_Click(sender As Object, e As EventArgs) Handles PhysicsLabel.Click
        Subject = "Physics"
        Call GenerateRandomWord(".\assets\Physics.txt")
        SubjectPanel.Visible = False
        GamePanel.Visible = True
    End Sub

    Private Sub ChemistryLabel_Click(sender As Object, e As EventArgs) Handles ChemistryLabel.Click
        Subject = "Chemistry"
        Call GenerateRandomWord(".\assets\Chemistry.txt")
        SubjectPanel.Visible = False
        GamePanel.Visible = True
    End Sub

    Private Sub Start_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        InputBox.MaxLength() = 1
        ScoreLabel.Text = 0

        HangManImage()
    End Sub

    Private Sub Button_Enter_Click(sender As Object, e As EventArgs) Handles Button_Enter.Click
        Call MainGameLoop()
    End Sub

    Private Sub InputBox_KeyDown(sender As Object, e As KeyEventArgs) Handles InputBox.KeyDown
        If e.KeyCode = Keys.Enter Then
            Console.WriteLine("Enter is pressed")
            Call MainGameLoop()
        End If
    End Sub

    Private Sub InputBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles InputBox.KeyPress

        If Not (Asc(e.KeyChar) = 8) Then
            If Not ((Asc(e.KeyChar) >= 97 And Asc(e.KeyChar) <= 122) Or (Asc(e.KeyChar) >= 65 And Asc(e.KeyChar) <= 90)) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If

    End Sub

    Private Sub MainGameLoop()
        Dim Correct As Boolean = False 'If the input is correct or not

        For index = 0 To 25 'Check if letter is used already
            If InputBox.Text = "" Then
                Exit Sub
            ElseIf InputBox.Text.ToUpper = GuessedLetters(index) Then
                MsgBox("| " & InputBox.Text.ToUpper & " | has already been used", 0, "Message")
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
        Console.WriteLine(GuessedLetters.Length())

        GuessedLetters(GuessedIndex) = InputBox.Text.ToUpper
        GuessedIndex = GuessedIndex + 1
        InputBox.Clear()

        For i = 0 To GuessedIndex
            If String.Compare(GuessedLetters(i), GuessedLetters(i + 1)) > 0 Then
                Swap(GuessedLetters(i), GuessedLetters(i + 1))
            End If
        Next

        For i = 0 To GuessedIndex
            Console.WriteLine(GuessedLetters(i))
        Next
        GuessLetters.Text = Join(ProgressArray, " ")
        GuessedLettersLabel.Text = Join(GuessedLetters, " ")

        HangManImage()

        If Lives = 0 Then
            MsgBox("Game lost", 0, "Message")
        End If
        If Join(ProgressArray, "") = Join(WordArray, "") Then
            Score = Score + 1
            Select Case Subject
                Case "Software"
                    Call GenerateRandomWord(".\assets\Software.txt")
                Case "Physics"
                    Call GenerateRandomWord(".\assets\physics.txt")
                Case "Chemistry"
                    Call GenerateRandomWord(".\assets\Chemistry.txt")
            End Select

            ReDim GuessedLetters(25)
            GuessedLettersLabel.Text = Join(GuessedLetters, " ")
            ScoreLabel.Text = Score
        End If
    End Sub

    Function GenerateRandomWord(ByVal location As String)
        Randomize()
        Dim ListArray As String() = File.ReadAllLines(location)
        For i = 0 To ListArray.Length - 1
            Console.WriteLine(ListArray(i))
        Next
        GuessWord = ListArray(Int(ListArray.Length * Rnd()))
        Console.WriteLine(GuessWord)

        ReDim WordArray(GuessWord.Length() - 1)
        ReDim ProgressArray(GuessWord.Length() - 1)

        For index = 0 To GuessWord.Length - 1
            WordArray(index) = GuessWord.Chars(index)
            ProgressArray(index) = "_"
            If WordArray(index) = " " Then
                ProgressArray(index) = WordArray(index)
            End If
        Next

        GuessLetters.Text = Join(ProgressArray, " ")

        GuessedLettersLabel.Text = Join(GuessedLetters, " ")
    End Function

    Function Swap(ByRef Object1 As String, ByRef Object2 As String)
        Dim TEMP As String
        TEMP = Object1
        Object1 = Object2
        Object2 = TEMP
    End Function

    Private Sub HangManImage()
        Select Case Lives
            Case 9
                HangManPB.Image = Image.FromFile(".\assets\hangman9.png")
            Case 8
                HangManPB.Image = Image.FromFile(".\assets\hangman8.png")
            Case 7
                HangManPB.Image = Image.FromFile(".\assets\hangman7.png")
            Case 6
                HangManPB.Image = Image.FromFile(".\assets\hangman6.png")
            Case 5
                HangManPB.Image = Image.FromFile(".\assets\hangman5.png")
            Case 4
                HangManPB.Image = Image.FromFile(".\assets\hangman4.png")
            Case 3
                HangManPB.Image = Image.FromFile(".\assets\hangman3.png")
            Case 2
                HangManPB.Image = Image.FromFile(".\assets\hangman2.png")
            Case 1
                HangManPB.Image = Image.FromFile(".\assets\hangman1.png")
            Case 0
                HangManPB.Image = Image.FromFile(".\assets\hangman0.png")
            Case 0
        End Select
    End Sub


End Class
