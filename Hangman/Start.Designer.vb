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
        Me.StartButton = New System.Windows.Forms.Button()
        Me.GamePanel = New System.Windows.Forms.Panel()
        Me.InputBox = New System.Windows.Forms.TextBox()
        Me.GuessLetters = New System.Windows.Forms.Label()
        Me.Button_Enter = New System.Windows.Forms.Button()
        Me.GuessedLettersLabel = New System.Windows.Forms.Label()
        Me.StartPanel.SuspendLayout()
        Me.GamePanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'StartPanel
        '
        Me.StartPanel.Controls.Add(Me.StartButton)
        Me.StartPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.StartPanel.Location = New System.Drawing.Point(0, 0)
        Me.StartPanel.Name = "StartPanel"
        Me.StartPanel.Size = New System.Drawing.Size(800, 450)
        Me.StartPanel.TabIndex = 0
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
        Me.GamePanel.Controls.Add(Me.GuessedLettersLabel)
        Me.GamePanel.Controls.Add(Me.InputBox)
        Me.GamePanel.Controls.Add(Me.GuessLetters)
        Me.GamePanel.Controls.Add(Me.Button_Enter)
        Me.GamePanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GamePanel.Location = New System.Drawing.Point(0, 0)
        Me.GamePanel.Name = "GamePanel"
        Me.GamePanel.Size = New System.Drawing.Size(800, 450)
        Me.GamePanel.TabIndex = 1
        Me.GamePanel.Visible = False
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
        'Start
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.GamePanel)
        Me.Controls.Add(Me.StartPanel)
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
End Class
