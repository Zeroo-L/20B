<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Start
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.StartPanel = New System.Windows.Forms.Panel()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.StartButton = New System.Windows.Forms.Button()
        Me.GamePanel = New System.Windows.Forms.Panel()
        Me.ScoreLabel = New System.Windows.Forms.Label()
        Me.LivesLable = New System.Windows.Forms.Label()
        Me.GuessedLettersLabel = New System.Windows.Forms.Label()
        Me.InputBox = New System.Windows.Forms.TextBox()
        Me.GuessLetters = New System.Windows.Forms.Label()
        Me.Button_Enter = New System.Windows.Forms.Button()
        Me.StartPanel.SuspendLayout()
        Me.GamePanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'StartPanel
        '
        Me.StartPanel.Controls.Add(Me.ExitButton)
        Me.StartPanel.Controls.Add(Me.StartButton)
        Me.StartPanel.Location = New System.Drawing.Point(1, 1)
        Me.StartPanel.Name = "StartPanel"
        Me.StartPanel.Size = New System.Drawing.Size(801, 451)
        Me.StartPanel.TabIndex = 0
        '
        'ExitButton
        '
        Me.ExitButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExitButton.Location = New System.Drawing.Point(12, 11)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(60, 36)
        Me.ExitButton.TabIndex = 3
        Me.ExitButton.Text = "Exit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'StartButton
        '
        Me.StartButton.Location = New System.Drawing.Point(331, 173)
        Me.StartButton.Name = "StartButton"
        Me.StartButton.Size = New System.Drawing.Size(142, 73)
        Me.StartButton.TabIndex = 0
        Me.StartButton.Text = "Start"
        Me.StartButton.UseVisualStyleBackColor = True
        '
        'GamePanel
        '
        Me.GamePanel.Controls.Add(Me.ScoreLabel)
        Me.GamePanel.Controls.Add(Me.LivesLable)
        Me.GamePanel.Controls.Add(Me.GuessedLettersLabel)
        Me.GamePanel.Controls.Add(Me.InputBox)
        Me.GamePanel.Controls.Add(Me.GuessLetters)
        Me.GamePanel.Controls.Add(Me.Button_Enter)
        Me.GamePanel.Location = New System.Drawing.Point(1, 1)
        Me.GamePanel.Name = "GamePanel"
        Me.GamePanel.Size = New System.Drawing.Size(801, 451)
        Me.GamePanel.TabIndex = 1
        Me.GamePanel.Visible = False
        '
        'ScoreLabel
        '
        Me.ScoreLabel.AutoSize = True
        Me.ScoreLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ScoreLabel.Location = New System.Drawing.Point(712, 9)
        Me.ScoreLabel.Name = "ScoreLabel"
        Me.ScoreLabel.Size = New System.Drawing.Size(85, 31)
        Me.ScoreLabel.TabIndex = 7
        Me.ScoreLabel.Text = "Score"
        '
        'LivesLable
        '
        Me.LivesLable.AutoSize = True
        Me.LivesLable.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LivesLable.Location = New System.Drawing.Point(719, 410)
        Me.LivesLable.Name = "LivesLable"
        Me.LivesLable.Size = New System.Drawing.Size(78, 31)
        Me.LivesLable.TabIndex = 6
        Me.LivesLable.Text = "Lives"
        '
        'GuessedLettersLabel
        '
        Me.GuessedLettersLabel.AutoSize = True
        Me.GuessedLettersLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GuessedLettersLabel.Location = New System.Drawing.Point(324, 326)
        Me.GuessedLettersLabel.Name = "GuessedLettersLabel"
        Me.GuessedLettersLabel.Size = New System.Drawing.Size(120, 39)
        Me.GuessedLettersLabel.TabIndex = 5
        Me.GuessedLettersLabel.Text = "Label1"
        '
        'InputBox
        '
        Me.InputBox.Location = New System.Drawing.Point(47, 157)
        Me.InputBox.Name = "InputBox"
        Me.InputBox.Size = New System.Drawing.Size(303, 20)
        Me.InputBox.TabIndex = 4
        '
        'GuessLetters
        '
        Me.GuessLetters.AutoSize = True
        Me.GuessLetters.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GuessLetters.Location = New System.Drawing.Point(39, 27)
        Me.GuessLetters.Name = "GuessLetters"
        Me.GuessLetters.Size = New System.Drawing.Size(0, 46)
        Me.GuessLetters.TabIndex = 3
        '
        'Button_Enter
        '
        Me.Button_Enter.Location = New System.Drawing.Point(366, 154)
        Me.Button_Enter.Name = "Button_Enter"
        Me.Button_Enter.Size = New System.Drawing.Size(75, 23)
        Me.Button_Enter.TabIndex = 2
        Me.Button_Enter.Text = "Enter"
        Me.Button_Enter.UseVisualStyleBackColor = True
        '
        'Start
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.StartPanel)
        Me.Controls.Add(Me.GamePanel)
        Me.Name = "Start"
        Me.Text = "Start"
        Me.StartPanel.ResumeLayout(False)
        Me.GamePanel.ResumeLayout(False)
        Me.GamePanel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents StartPanel As Panel
    Friend WithEvents StartButton As Button
    Friend WithEvents GamePanel As Panel
    Friend WithEvents Button_Enter As Button
    Friend WithEvents GuessLetters As Label
    Friend WithEvents InputBox As TextBox
    Friend WithEvents GuessedLettersLabel As Label
    Friend WithEvents LivesLable As Label
    Friend WithEvents ScoreLabel As Label
    Friend WithEvents ExitButton As Button
End Class
