Public Class Start
    Dim GuessWord As String = "Apple"
    Dim WordArray(0) As String
    Dim ProgressArray(0) As String
    Dim GuessedLetters(26) As String
    Dim GuessedIndex As Integer = 0
    Dim lives As Integer = 10

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

        For index = 0 To 26
            If InputBox.Text = GuessedLetters(index) Then
                MsgBox("|" & InputBox.Text & "| has already been used", 0, "Message")

                Exit Sub
            End If
        Next

        For index = 0 To GuessWord.Length - 1
            If InputBox.Text = WordArray(index) Then
                ProgressArray(index) = WordArray(index)
            End If
        Next



        InputBox.Clear()

        For index = 0 To WordArray.Length - 1
            GuessLetters.Text = Join(ProgressArray, " ")
        Next
    End Sub
End Class