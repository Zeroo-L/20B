<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.StartPanel = New System.Windows.Forms.Panel()
        Me.SubjectPanel = New System.Windows.Forms.Panel()
        Me.ChemistryLabel = New System.Windows.Forms.Label()
        Me.PhysicsLabel = New System.Windows.Forms.Label()
        Me.SoftwareLabel = New System.Windows.Forms.Label()
        Me.GamePanel = New System.Windows.Forms.Panel()
        Me.HangManPB = New System.Windows.Forms.PictureBox()
        Me.ScoreLabel = New System.Windows.Forms.Label()
        Me.GuessedLettersLabel = New System.Windows.Forms.Label()
        Me.InputBox = New System.Windows.Forms.TextBox()
        Me.GuessLetters = New System.Windows.Forms.Label()
        Me.Button_Enter = New System.Windows.Forms.Button()
        Me.ExitPB = New System.Windows.Forms.PictureBox()
        Me.StartButton = New System.Windows.Forms.Button()
        Me.StartPanel.SuspendLayout()
        Me.SubjectPanel.SuspendLayout()
        Me.GamePanel.SuspendLayout()
        CType(Me.HangManPB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ExitPB, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StartPanel
        '
        Me.StartPanel.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.StartPanel.Controls.Add(Me.ExitPB)
        Me.StartPanel.Controls.Add(Me.StartButton)
        Me.StartPanel.Location = New System.Drawing.Point(0, 0)
        Me.StartPanel.Name = "StartPanel"
        Me.StartPanel.Size = New System.Drawing.Size(800, 450)
        Me.StartPanel.TabIndex = 0
        '
        'SubjectPanel
        '
        Me.SubjectPanel.BackColor = System.Drawing.Color.PaleGreen
        Me.SubjectPanel.Controls.Add(Me.ChemistryLabel)
        Me.SubjectPanel.Controls.Add(Me.PhysicsLabel)
        Me.SubjectPanel.Controls.Add(Me.SoftwareLabel)
        Me.SubjectPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SubjectPanel.Location = New System.Drawing.Point(0, 0)
        Me.SubjectPanel.Name = "SubjectPanel"
        Me.SubjectPanel.Size = New System.Drawing.Size(800, 450)
        Me.SubjectPanel.TabIndex = 5
        '
        'ChemistryLabel
        '
        Me.ChemistryLabel.AutoSize = True
        Me.ChemistryLabel.BackColor = System.Drawing.Color.PaleGreen
        Me.ChemistryLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChemistryLabel.Location = New System.Drawing.Point(572, 211)
        Me.ChemistryLabel.MaximumSize = New System.Drawing.Size(200, 0)
        Me.ChemistryLabel.Name = "ChemistryLabel"
        Me.ChemistryLabel.Size = New System.Drawing.Size(137, 31)
        Me.ChemistryLabel.TabIndex = 2
        Me.ChemistryLabel.Text = "Chemistry"
        Me.ChemistryLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'PhysicsLabel
        '
        Me.PhysicsLabel.AutoSize = True
        Me.PhysicsLabel.BackColor = System.Drawing.Color.PaleGreen
        Me.PhysicsLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PhysicsLabel.Location = New System.Drawing.Point(340, 211)
        Me.PhysicsLabel.MaximumSize = New System.Drawing.Size(200, 0)
        Me.PhysicsLabel.Name = "PhysicsLabel"
        Me.PhysicsLabel.Size = New System.Drawing.Size(109, 31)
        Me.PhysicsLabel.TabIndex = 1
        Me.PhysicsLabel.Text = "Physics"
        Me.PhysicsLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'SoftwareLabel
        '
        Me.SoftwareLabel.AutoSize = True
        Me.SoftwareLabel.BackColor = System.Drawing.Color.PaleGreen
        Me.SoftwareLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SoftwareLabel.Location = New System.Drawing.Point(57, 177)
        Me.SoftwareLabel.MaximumSize = New System.Drawing.Size(200, 0)
        Me.SoftwareLabel.Name = "SoftwareLabel"
        Me.SoftwareLabel.Size = New System.Drawing.Size(174, 93)
        Me.SoftwareLabel.TabIndex = 0
        Me.SoftwareLabel.Text = "Software Design And Development"
        Me.SoftwareLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'GamePanel
        '
        Me.GamePanel.BackColor = System.Drawing.Color.LightCoral
        Me.GamePanel.Controls.Add(Me.HangManPB)
        Me.GamePanel.Controls.Add(Me.ScoreLabel)
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
        'HangManPB
        '
        Me.HangManPB.Location = New System.Drawing.Point(452, 5)
        Me.HangManPB.Name = "HangManPB"
        Me.HangManPB.Size = New System.Drawing.Size(345, 445)
        Me.HangManPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.HangManPB.TabIndex = 8
        Me.HangManPB.TabStop = False
        '
        'ScoreLabel
        '
        Me.ScoreLabel.AutoSize = True
        Me.ScoreLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ScoreLabel.Location = New System.Drawing.Point(11, 17)
        Me.ScoreLabel.Name = "ScoreLabel"
        Me.ScoreLabel.Size = New System.Drawing.Size(85, 31)
        Me.ScoreLabel.TabIndex = 7
        Me.ScoreLabel.Text = "Score"
        '
        'GuessedLettersLabel
        '
        Me.GuessedLettersLabel.AutoSize = True
        Me.GuessedLettersLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GuessedLettersLabel.Location = New System.Drawing.Point(11, 275)
        Me.GuessedLettersLabel.Name = "GuessedLettersLabel"
        Me.GuessedLettersLabel.Size = New System.Drawing.Size(169, 31)
        Me.GuessedLettersLabel.TabIndex = 5
        Me.GuessedLettersLabel.Text = "Used Letters"
        '
        'InputBox
        '
        Me.InputBox.Location = New System.Drawing.Point(12, 173)
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
        Me.Button_Enter.Location = New System.Drawing.Point(343, 173)
        Me.Button_Enter.Name = "Button_Enter"
        Me.Button_Enter.Size = New System.Drawing.Size(75, 23)
        Me.Button_Enter.TabIndex = 2
        Me.Button_Enter.Text = "Enter"
        Me.Button_Enter.UseVisualStyleBackColor = True
        '
        'ExitPB
        '
        Me.ExitPB.Image = CType(resources.GetObject("ExitPB.Image"), System.Drawing.Image)
        Me.ExitPB.Location = New System.Drawing.Point(12, 393)
        Me.ExitPB.Name = "ExitPB"
        Me.ExitPB.Size = New System.Drawing.Size(56, 54)
        Me.ExitPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ExitPB.TabIndex = 4
        Me.ExitPB.TabStop = False
        '
        'StartButton
        '
        Me.StartButton.Location = New System.Drawing.Point(329, 211)
        Me.StartButton.Name = "StartButton"
        Me.StartButton.Size = New System.Drawing.Size(142, 73)
        Me.StartButton.TabIndex = 0
        Me.StartButton.Text = "Play"
        Me.StartButton.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.GamePanel)
        Me.Controls.Add(Me.StartPanel)
        Me.Controls.Add(Me.SubjectPanel)
        Me.Name = "Form1"
        Me.Text = "Start"
        Me.StartPanel.ResumeLayout(False)
        Me.SubjectPanel.ResumeLayout(False)
        Me.SubjectPanel.PerformLayout()
        Me.GamePanel.ResumeLayout(False)
        Me.GamePanel.PerformLayout()
        CType(Me.HangManPB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ExitPB, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents StartPanel As Panel
    Friend WithEvents StartButton As Button
    Friend WithEvents GamePanel As Panel
    Friend WithEvents Button_Enter As Button
    Friend WithEvents GuessLetters As Label
    Friend WithEvents InputBox As TextBox
    Friend WithEvents GuessedLettersLabel As Label
    Friend WithEvents ScoreLabel As Label
    Friend WithEvents HangManPB As PictureBox
    Friend WithEvents ExitPB As PictureBox
    Friend WithEvents SubjectPanel As Panel
    Friend WithEvents ChemistryLabel As Label
    Friend WithEvents PhysicsLabel As Label
    Friend WithEvents SoftwareLabel As Label
End Class
