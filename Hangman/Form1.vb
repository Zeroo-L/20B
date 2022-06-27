Imports System.IO
Imports System.Linq
Imports System.Collections

Public Class Form1
    Dim GuessWord As String 'The random guess word chosen from different files
    Dim WordArray(0) As String 'Array of each letter of the GuessWord
    Dim ProgressArray(0) As String 'Array of the progress that the user made
    Dim GuessedLetters(25) As String 'Array of the guessed letters
    Dim GuessedIndex As Integer = 0 'Index for the array of guseed latters
    Dim Lives As Integer = 10 'How many lives the player has
    Dim Score As Integer = 0 'THe score player has earn
    Dim Subject As Integer 'Selected subject by the user


    Private Sub Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InputBox.MaxLength() = 1
        ScoreLabel.Text = 0
        HangManImage()

    End Sub

    'Starting Screen
    Private Sub Start_Button_Click(sender As Object, e As EventArgs) Handles StartButton.Click
        StartPanel.Visible = False
        SubjectPanel.Visible = True
    End Sub

    'Exit Button
    Private Sub ExitPB_Click(sender As Object, e As EventArgs) Handles ExitPB.Click
        Application.Exit()
    End Sub

    'Setting Button
    Private Sub SettingPB_Click(sender As Object, e As EventArgs) Handles SettingPB.Click
        StartPanel.Visible = False
        SettingsPanel.Visible = True
    End Sub

    'Setting screen
    Private Sub SettingsBackPB_Click(sender As Object, e As EventArgs) Handles SettingsBackPB.Click
        SettingsPanel.Visible = False
        StartPanel.Visible = True
    End Sub

    'Red Colour Button
    Private Sub RedPB_Click(sender As Object, e As EventArgs) Handles RedPB.Click
        StartPanel.BackColor = Color.LightCoral
        SubjectPanel.BackColor = Color.LightCoral
        GamePanel.BackColor = Color.LightCoral
        SettingsPanel.BackColor = Color.LightCoral
    End Sub

    'Orange Colour Button
    Private Sub OrangePb_Click(sender As Object, e As EventArgs) Handles OrangePb.Click
        StartPanel.BackColor = Color.LightSalmon
        SubjectPanel.BackColor = Color.LightSalmon
        GamePanel.BackColor = Color.LightSalmon
        SettingsPanel.BackColor = Color.LightSalmon
    End Sub

    'Yellow Colour Button
    Private Sub YellowPb_Click(sender As Object, e As EventArgs) Handles YellowPb.Click
        StartPanel.BackColor = Color.Khaki
        SubjectPanel.BackColor = Color.Khaki
        GamePanel.BackColor = Color.Khaki
        SettingsPanel.BackColor = Color.Khaki
    End Sub

    'Green Colour Button
    Private Sub GreenPB_Click(sender As Object, e As EventArgs) Handles GreenPB.Click
        StartPanel.BackColor = Color.PaleGreen
        SubjectPanel.BackColor = Color.PaleGreen
        GamePanel.BackColor = Color.PaleGreen
        SettingsPanel.BackColor = Color.PaleGreen
    End Sub

    'Blue Colour Button
    Private Sub BluePB_Click(sender As Object, e As EventArgs) Handles BluePB.Click
        StartPanel.BackColor = Color.PaleTurquoise
        SubjectPanel.BackColor = Color.PaleTurquoise
        GamePanel.BackColor = Color.PaleTurquoise
        SettingsPanel.BackColor = Color.PaleTurquoise
    End Sub

    'Purple Colour Button
    Private Sub PurplePB_Click(sender As Object, e As EventArgs) Handles PurplePB.Click
        StartPanel.BackColor = Color.Plum
        SubjectPanel.BackColor = Color.Plum
        GamePanel.BackColor = Color.Plum
        SettingsPanel.BackColor = Color.Plum
    End Sub

    'Subject Screens
    'Choosing Subjects
    Private Sub SoftwareLabel_Click(sender As Object, e As EventArgs) Handles SoftwareLabel.Click 'Software Subject
        Subject = 0
        Call GenerateRandomWord(".\assets\Software.txt")
        SubjectPanel.Visible = False
        GamePanel.Visible = True
    End Sub


    Private Sub PhysicsLabel_Click(sender As Object, e As EventArgs) Handles PhysicsLabel.Click 'Physics Subject
        Subject = 1
        Call GenerateRandomWord(".\assets\Physics.txt")
        SubjectPanel.Visible = False
        GamePanel.Visible = True
    End Sub


    Private Sub ChemistryLabel_Click(sender As Object, e As EventArgs) Handles ChemistryLabel.Click 'Chemistry Subject
        Subject = 2
        Call GenerateRandomWord(".\assets\Chemistry.txt")
        SubjectPanel.Visible = False
        GamePanel.Visible = True
    End Sub


    Private Sub Custom1Label_Click(sender As Object, e As EventArgs) Handles Custom1Label.Click 'Custom User Subject 1
        Subject = 3

        If System.IO.File.Exists(".\assets\custom1.txt") Then
            Call GenerateRandomWord(".\assets\custom1.txt")
            SubjectPanel.Visible = False
            GamePanel.Visible = True
        End If

    End Sub


    Private Sub Custom2Label_Click(sender As Object, e As EventArgs) Handles Custom2Label.Click 'Custom User Subject 2
        Subject = 4

        If System.IO.File.Exists(".\assets\custom2.txt") Then
            Call GenerateRandomWord(".\assets\custom2.txt")
            SubjectPanel.Visible = False
            GamePanel.Visible = True
        End If
    End Sub

    'Game Screen
    Private Sub Button_Enter_Click(sender As Object, e As EventArgs) Handles Button_Enter.Click
        Call MainGameLoop()
    End Sub

    '[Enter] Keystroke
    Private Sub InputBox_KeyDown(sender As Object, e As KeyEventArgs) Handles InputBox.KeyDown
        If e.KeyCode = Keys.Enter Then
            Console.WriteLine("Enter is pressed")
            Call MainGameLoop()
        End If
    End Sub

    'Does not allow any input other than letters
    Private Sub InputBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles InputBox.KeyPress

        If Not (Asc(e.KeyChar) = 8) Then
            If Not ((Asc(e.KeyChar) >= 97 And Asc(e.KeyChar) <= 122) Or (Asc(e.KeyChar) >= 65 And Asc(e.KeyChar) <= 90)) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If

    End Sub

    '-----------------------------------------------------------------------------------------------------------------------------------------

    Private Sub MainGameLoop()
        Dim Correct As Boolean = False

        For index = 0 To 25 'Check if letter is used already
            If InputBox.Text = "" Then
                Exit Sub
            ElseIf InputBox.Text.ToUpper = GuessedLetters(index) Then
                MsgBox("| " & InputBox.Text.ToUpper & " | has already been used", 0, "Message")
                InputBox.Clear()
                Exit Sub
            End If
        Next


        For index = 0 To GuessWord.Length - 1 'Check if letter is in word
            If (InputBox.Text.Equals(WordArray(index), StringComparison.InvariantCultureIgnoreCase)) Then
                ProgressArray(index) = WordArray(index)
                Correct = True
            End If
        Next

        If Correct = False Then 'Incorrect
            Lives = Lives - 1
        End If

        Console.WriteLine(Lives)
        Console.WriteLine(GuessedLetters.Length())

        GuessedLetters(GuessedIndex) = InputBox.Text.ToUpper 'Put letter in GuessedLetters
        GuessedIndex = GuessedIndex + 1
        InputBox.Clear()

        For i = 0 To GuessedIndex 'Bubble Sort GuessedLetters
            If String.Compare(GuessedLetters(i), GuessedLetters(i + 1)) > 0 Then
                Swap(GuessedLetters(i), GuessedLetters(i + 1))
            End If
        Next

        'Put Arrays in Labels
        GuessLettersLabel.Text = Join(ProgressArray, " ")
        GuessedLettersLabel.Text = Join(GuessedLetters, " ")

        'Change Hangman image
        HangManImage()



        'Lose condition
        If Lives = 0 Then
            MsgBox("Game lost", 0, "Message")
            ResetValues()
            GamePanel.Visible = False
            StartPanel.Visible = True

            'Win condition
        ElseIf Join(ProgressArray, "") = Join(WordArray, "") Then
            Score = Score + 1
            ScoreLabel.Text = Score
            ReDim GuessedLetters(25) 'Repeating
            Select Case Subject
                Case 0
                    Call GenerateRandomWord(".\assets\Software.txt")
                Case 1
                    Call GenerateRandomWord(".\assets\physics.txt")
                Case 2
                    Call GenerateRandomWord(".\assets\Chemistry.txt")
                Case 3
                    Call GenerateRandomWord(".\assets\custom1.txt")
                Case 4
                    Call GenerateRandomWord(".\assets\custom2.txt")
            End Select
        End If
    End Sub

    'Read from file and generate a random word
    Function GenerateRandomWord(ByVal location As String)
        Randomize()
        Dim ListArray As String() = File.ReadAllLines(location)
        GuessWord = ListArray(Int(ListArray.Length * Rnd()))
        If GuessWord.Length > 15 Then
            GuessLettersLabel.Font = New Font("Microsoft Sans Serif", 15, FontStyle.Regular)
        End If
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

        GuessLettersLabel.Text = Join(ProgressArray, " ")

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
        End Select
    End Sub

    Private Sub ResetValues()
        GuessWord = ""
        Array.Clear(WordArray, 0, WordArray.Length)
        Array.Clear(ProgressArray, 0, ProgressArray.Length)
        Array.Clear(GuessedLetters, 0, GuessedLetters.Length)
        GuessedIndex = 0
        Lives = 10
        Score = 0
        HangManPB.Image = Nothing
    End Sub

End Class
