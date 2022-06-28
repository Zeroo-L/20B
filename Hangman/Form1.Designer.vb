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
        Me.SettingPB = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ExitPB = New System.Windows.Forms.PictureBox()
        Me.StartButton = New System.Windows.Forms.Button()
        Me.SubjectPanel = New System.Windows.Forms.Panel()
        Me.Custom2Label = New System.Windows.Forms.Label()
        Me.Custom1Label = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ChemistryLabel = New System.Windows.Forms.Label()
        Me.PhysicsLabel = New System.Windows.Forms.Label()
        Me.SoftwareLabel = New System.Windows.Forms.Label()
        Me.GamePanel = New System.Windows.Forms.Panel()
        Me.HangManPB = New System.Windows.Forms.PictureBox()
        Me.ScoreLabel = New System.Windows.Forms.Label()
        Me.GuessedLettersLabel = New System.Windows.Forms.Label()
        Me.UserInputBox = New System.Windows.Forms.TextBox()
        Me.GuessLettersLabel = New System.Windows.Forms.Label()
        Me.Button_Enter = New System.Windows.Forms.Button()
        Me.SettingsPanel = New System.Windows.Forms.Panel()
        Me.SettingsBackPB = New System.Windows.Forms.PictureBox()
        Me.RedPB = New System.Windows.Forms.PictureBox()
        Me.OrangePb = New System.Windows.Forms.PictureBox()
        Me.YellowPb = New System.Windows.Forms.PictureBox()
        Me.GreenPB = New System.Windows.Forms.PictureBox()
        Me.BluePB = New System.Windows.Forms.PictureBox()
        Me.PurplePB = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LeaderboardPanel = New System.Windows.Forms.Panel()
        Me.Leaderboardlabel = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.LeaderboardBack = New System.Windows.Forms.PictureBox()
        Me.StartPanel.SuspendLayout()
        CType(Me.SettingPB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ExitPB, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SubjectPanel.SuspendLayout()
        Me.GamePanel.SuspendLayout()
        CType(Me.HangManPB, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SettingsPanel.SuspendLayout()
        CType(Me.SettingsBackPB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RedPB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrangePb, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.YellowPb, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GreenPB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BluePB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PurplePB, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LeaderboardPanel.SuspendLayout()
        CType(Me.LeaderboardBack, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StartPanel
        '
        Me.StartPanel.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.StartPanel.Controls.Add(Me.SettingPB)
        Me.StartPanel.Controls.Add(Me.Label1)
        Me.StartPanel.Controls.Add(Me.ExitPB)
        Me.StartPanel.Controls.Add(Me.StartButton)
        Me.StartPanel.Location = New System.Drawing.Point(0, 0)
        Me.StartPanel.Margin = New System.Windows.Forms.Padding(4)
        Me.StartPanel.Name = "StartPanel"
        Me.StartPanel.Size = New System.Drawing.Size(1067, 554)
        Me.StartPanel.TabIndex = 0
        '
        'SettingPB
        '
        Me.SettingPB.BackgroundImage = Global.Hangman.My.Resources.Resources.SettingsIcon
        Me.SettingPB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.SettingPB.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.SettingPB.Location = New System.Drawing.Point(975, 484)
        Me.SettingPB.Margin = New System.Windows.Forms.Padding(4)
        Me.SettingPB.Name = "SettingPB"
        Me.SettingPB.Size = New System.Drawing.Size(75, 64)
        Me.SettingPB.TabIndex = 6
        Me.SettingPB.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 90.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(156, 48)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(720, 170)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Hangman"
        '
        'ExitPB
        '
        Me.ExitPB.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.ExitPB.Image = CType(resources.GetObject("ExitPB.Image"), System.Drawing.Image)
        Me.ExitPB.Location = New System.Drawing.Point(16, 484)
        Me.ExitPB.Margin = New System.Windows.Forms.Padding(4)
        Me.ExitPB.Name = "ExitPB"
        Me.ExitPB.Size = New System.Drawing.Size(73, 66)
        Me.ExitPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ExitPB.TabIndex = 4
        Me.ExitPB.TabStop = False
        '
        'StartButton
        '
        Me.StartButton.BackColor = System.Drawing.Color.Transparent
        Me.StartButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StartButton.Location = New System.Drawing.Point(439, 260)
        Me.StartButton.Margin = New System.Windows.Forms.Padding(4)
        Me.StartButton.Name = "StartButton"
        Me.StartButton.Size = New System.Drawing.Size(189, 90)
        Me.StartButton.TabIndex = 0
        Me.StartButton.Text = "Play"
        Me.StartButton.UseVisualStyleBackColor = False
        '
        'SubjectPanel
        '
        Me.SubjectPanel.BackColor = System.Drawing.Color.PaleGreen
        Me.SubjectPanel.Controls.Add(Me.Custom2Label)
        Me.SubjectPanel.Controls.Add(Me.Custom1Label)
        Me.SubjectPanel.Controls.Add(Me.Label3)
        Me.SubjectPanel.Controls.Add(Me.ChemistryLabel)
        Me.SubjectPanel.Controls.Add(Me.PhysicsLabel)
        Me.SubjectPanel.Controls.Add(Me.SoftwareLabel)
        Me.SubjectPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SubjectPanel.Location = New System.Drawing.Point(0, 0)
        Me.SubjectPanel.Margin = New System.Windows.Forms.Padding(4)
        Me.SubjectPanel.Name = "SubjectPanel"
        Me.SubjectPanel.Size = New System.Drawing.Size(1067, 554)
        Me.SubjectPanel.TabIndex = 5
        Me.SubjectPanel.Visible = False
        '
        'Custom2Label
        '
        Me.Custom2Label.AutoSize = True
        Me.Custom2Label.BackColor = System.Drawing.Color.LightGray
        Me.Custom2Label.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Custom2Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Custom2Label.Location = New System.Drawing.Point(597, 411)
        Me.Custom2Label.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Custom2Label.MaximumSize = New System.Drawing.Size(267, 0)
        Me.Custom2Label.Name = "Custom2Label"
        Me.Custom2Label.Size = New System.Drawing.Size(155, 41)
        Me.Custom2Label.TabIndex = 5
        Me.Custom2Label.Text = "Custom2"
        Me.Custom2Label.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Custom1Label
        '
        Me.Custom1Label.AutoSize = True
        Me.Custom1Label.BackColor = System.Drawing.Color.LightGray
        Me.Custom1Label.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Custom1Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Custom1Label.Location = New System.Drawing.Point(301, 411)
        Me.Custom1Label.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Custom1Label.MaximumSize = New System.Drawing.Size(267, 0)
        Me.Custom1Label.Name = "Custom1Label"
        Me.Custom1Label.Size = New System.Drawing.Size(155, 41)
        Me.Custom1Label.TabIndex = 4
        Me.Custom1Label.Text = "Custom1"
        Me.Custom1Label.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(271, 68)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(489, 58)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Choose Your subject"
        '
        'ChemistryLabel
        '
        Me.ChemistryLabel.AutoSize = True
        Me.ChemistryLabel.BackColor = System.Drawing.Color.LightGray
        Me.ChemistryLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.ChemistryLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChemistryLabel.Location = New System.Drawing.Point(763, 260)
        Me.ChemistryLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.ChemistryLabel.MaximumSize = New System.Drawing.Size(267, 0)
        Me.ChemistryLabel.Name = "ChemistryLabel"
        Me.ChemistryLabel.Size = New System.Drawing.Size(172, 41)
        Me.ChemistryLabel.TabIndex = 2
        Me.ChemistryLabel.Text = "Chemistry"
        Me.ChemistryLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'PhysicsLabel
        '
        Me.PhysicsLabel.AutoSize = True
        Me.PhysicsLabel.BackColor = System.Drawing.Color.LightGray
        Me.PhysicsLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PhysicsLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PhysicsLabel.Location = New System.Drawing.Point(453, 260)
        Me.PhysicsLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.PhysicsLabel.MaximumSize = New System.Drawing.Size(267, 0)
        Me.PhysicsLabel.Name = "PhysicsLabel"
        Me.PhysicsLabel.Size = New System.Drawing.Size(137, 41)
        Me.PhysicsLabel.TabIndex = 1
        Me.PhysicsLabel.Text = "Physics"
        Me.PhysicsLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'SoftwareLabel
        '
        Me.SoftwareLabel.AutoSize = True
        Me.SoftwareLabel.BackColor = System.Drawing.Color.LightGray
        Me.SoftwareLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.SoftwareLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SoftwareLabel.Location = New System.Drawing.Point(76, 218)
        Me.SoftwareLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.SoftwareLabel.MaximumSize = New System.Drawing.Size(267, 0)
        Me.SoftwareLabel.Name = "SoftwareLabel"
        Me.SoftwareLabel.Size = New System.Drawing.Size(220, 119)
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
        Me.GamePanel.Controls.Add(Me.UserInputBox)
        Me.GamePanel.Controls.Add(Me.GuessLettersLabel)
        Me.GamePanel.Controls.Add(Me.Button_Enter)
        Me.GamePanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GamePanel.Location = New System.Drawing.Point(0, 0)
        Me.GamePanel.Margin = New System.Windows.Forms.Padding(4)
        Me.GamePanel.Name = "GamePanel"
        Me.GamePanel.Size = New System.Drawing.Size(1067, 554)
        Me.GamePanel.TabIndex = 1
        Me.GamePanel.Visible = False
        '
        'HangManPB
        '
        Me.HangManPB.BackColor = System.Drawing.Color.Gainsboro
        Me.HangManPB.BackgroundImage = Global.Hangman.My.Resources.Resources.HangmanBackImage
        Me.HangManPB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.HangManPB.Location = New System.Drawing.Point(597, 21)
        Me.HangManPB.Margin = New System.Windows.Forms.Padding(4)
        Me.HangManPB.Name = "HangManPB"
        Me.HangManPB.Size = New System.Drawing.Size(453, 507)
        Me.HangManPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.HangManPB.TabIndex = 8
        Me.HangManPB.TabStop = False
        '
        'ScoreLabel
        '
        Me.ScoreLabel.AutoSize = True
        Me.ScoreLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ScoreLabel.Location = New System.Drawing.Point(15, 21)
        Me.ScoreLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.ScoreLabel.Name = "ScoreLabel"
        Me.ScoreLabel.Size = New System.Drawing.Size(106, 39)
        Me.ScoreLabel.TabIndex = 7
        Me.ScoreLabel.Text = "Score"
        '
        'GuessedLettersLabel
        '
        Me.GuessedLettersLabel.AutoSize = True
        Me.GuessedLettersLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GuessedLettersLabel.Location = New System.Drawing.Point(15, 338)
        Me.GuessedLettersLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.GuessedLettersLabel.Name = "GuessedLettersLabel"
        Me.GuessedLettersLabel.Size = New System.Drawing.Size(209, 39)
        Me.GuessedLettersLabel.TabIndex = 5
        Me.GuessedLettersLabel.Text = "Used Letters"
        '
        'UserInputBox
        '
        Me.UserInputBox.Location = New System.Drawing.Point(16, 213)
        Me.UserInputBox.Margin = New System.Windows.Forms.Padding(4)
        Me.UserInputBox.Name = "UserInputBox"
        Me.UserInputBox.Size = New System.Drawing.Size(403, 22)
        Me.UserInputBox.TabIndex = 4
        '
        'GuessLettersLabel
        '
        Me.GuessLettersLabel.AutoSize = True
        Me.GuessLettersLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GuessLettersLabel.Location = New System.Drawing.Point(45, 123)
        Me.GuessLettersLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.GuessLettersLabel.Name = "GuessLettersLabel"
        Me.GuessLettersLabel.Size = New System.Drawing.Size(0, 58)
        Me.GuessLettersLabel.TabIndex = 3
        '
        'Button_Enter
        '
        Me.Button_Enter.Location = New System.Drawing.Point(457, 213)
        Me.Button_Enter.Margin = New System.Windows.Forms.Padding(4)
        Me.Button_Enter.Name = "Button_Enter"
        Me.Button_Enter.Size = New System.Drawing.Size(100, 28)
        Me.Button_Enter.TabIndex = 2
        Me.Button_Enter.Text = "Enter"
        Me.Button_Enter.UseVisualStyleBackColor = True
        '
        'SettingsPanel
        '
        Me.SettingsPanel.BackColor = System.Drawing.Color.Khaki
        Me.SettingsPanel.Controls.Add(Me.SettingsBackPB)
        Me.SettingsPanel.Controls.Add(Me.RedPB)
        Me.SettingsPanel.Controls.Add(Me.OrangePb)
        Me.SettingsPanel.Controls.Add(Me.YellowPb)
        Me.SettingsPanel.Controls.Add(Me.GreenPB)
        Me.SettingsPanel.Controls.Add(Me.BluePB)
        Me.SettingsPanel.Controls.Add(Me.PurplePB)
        Me.SettingsPanel.Controls.Add(Me.Label2)
        Me.SettingsPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SettingsPanel.Location = New System.Drawing.Point(0, 0)
        Me.SettingsPanel.Margin = New System.Windows.Forms.Padding(4)
        Me.SettingsPanel.Name = "SettingsPanel"
        Me.SettingsPanel.Size = New System.Drawing.Size(1067, 554)
        Me.SettingsPanel.TabIndex = 9
        Me.SettingsPanel.Visible = False
        '
        'SettingsBackPB
        '
        Me.SettingsBackPB.BackgroundImage = Global.Hangman.My.Resources.Resources.BackIcon
        Me.SettingsBackPB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.SettingsBackPB.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.SettingsBackPB.Location = New System.Drawing.Point(23, 470)
        Me.SettingsBackPB.Margin = New System.Windows.Forms.Padding(4)
        Me.SettingsBackPB.Name = "SettingsBackPB"
        Me.SettingsBackPB.Size = New System.Drawing.Size(73, 68)
        Me.SettingsBackPB.TabIndex = 7
        Me.SettingsBackPB.TabStop = False
        '
        'RedPB
        '
        Me.RedPB.BackColor = System.Drawing.Color.LightCoral
        Me.RedPB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.RedPB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.RedPB.Location = New System.Drawing.Point(53, 128)
        Me.RedPB.Margin = New System.Windows.Forms.Padding(4)
        Me.RedPB.Name = "RedPB"
        Me.RedPB.Size = New System.Drawing.Size(93, 86)
        Me.RedPB.TabIndex = 0
        Me.RedPB.TabStop = False
        '
        'OrangePb
        '
        Me.OrangePb.BackColor = System.Drawing.Color.LightSalmon
        Me.OrangePb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.OrangePb.Location = New System.Drawing.Point(215, 128)
        Me.OrangePb.Margin = New System.Windows.Forms.Padding(4)
        Me.OrangePb.Name = "OrangePb"
        Me.OrangePb.Size = New System.Drawing.Size(93, 86)
        Me.OrangePb.TabIndex = 2
        Me.OrangePb.TabStop = False
        '
        'YellowPb
        '
        Me.YellowPb.BackColor = System.Drawing.Color.Khaki
        Me.YellowPb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.YellowPb.Location = New System.Drawing.Point(383, 128)
        Me.YellowPb.Margin = New System.Windows.Forms.Padding(4)
        Me.YellowPb.Name = "YellowPb"
        Me.YellowPb.Size = New System.Drawing.Size(93, 86)
        Me.YellowPb.TabIndex = 3
        Me.YellowPb.TabStop = False
        '
        'GreenPB
        '
        Me.GreenPB.BackColor = System.Drawing.Color.PaleGreen
        Me.GreenPB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.GreenPB.Location = New System.Drawing.Point(547, 128)
        Me.GreenPB.Margin = New System.Windows.Forms.Padding(4)
        Me.GreenPB.Name = "GreenPB"
        Me.GreenPB.Size = New System.Drawing.Size(93, 86)
        Me.GreenPB.TabIndex = 4
        Me.GreenPB.TabStop = False
        '
        'BluePB
        '
        Me.BluePB.BackColor = System.Drawing.Color.PaleTurquoise
        Me.BluePB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.BluePB.Location = New System.Drawing.Point(719, 128)
        Me.BluePB.Margin = New System.Windows.Forms.Padding(4)
        Me.BluePB.Name = "BluePB"
        Me.BluePB.Size = New System.Drawing.Size(93, 86)
        Me.BluePB.TabIndex = 5
        Me.BluePB.TabStop = False
        '
        'PurplePB
        '
        Me.PurplePB.BackColor = System.Drawing.Color.Plum
        Me.PurplePB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PurplePB.Location = New System.Drawing.Point(884, 128)
        Me.PurplePB.Margin = New System.Windows.Forms.Padding(4)
        Me.PurplePB.Name = "PurplePB"
        Me.PurplePB.Size = New System.Drawing.Size(93, 86)
        Me.PurplePB.TabIndex = 6
        Me.PurplePB.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(47, 21)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(164, 48)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Colours"
        '
        'LeaderboardPanel
        '
        Me.LeaderboardPanel.BackColor = System.Drawing.Color.Plum
        Me.LeaderboardPanel.Controls.Add(Me.LeaderboardBack)
        Me.LeaderboardPanel.Controls.Add(Me.Leaderboardlabel)
        Me.LeaderboardPanel.Controls.Add(Me.Label4)
        Me.LeaderboardPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LeaderboardPanel.Location = New System.Drawing.Point(0, 0)
        Me.LeaderboardPanel.Margin = New System.Windows.Forms.Padding(4)
        Me.LeaderboardPanel.Name = "LeaderboardPanel"
        Me.LeaderboardPanel.Size = New System.Drawing.Size(1067, 554)
        Me.LeaderboardPanel.TabIndex = 9
        Me.LeaderboardPanel.Visible = False
        '
        'Leaderboardlabel
        '
        Me.Leaderboardlabel.AutoSize = True
        Me.Leaderboardlabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Leaderboardlabel.Location = New System.Drawing.Point(372, 90)
        Me.Leaderboardlabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Leaderboardlabel.Name = "Leaderboardlabel"
        Me.Leaderboardlabel.Size = New System.Drawing.Size(0, 58)
        Me.Leaderboardlabel.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Plum
        Me.Label4.Cursor = System.Windows.Forms.Cursors.No
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 45.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(4, 5)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(486, 85)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Leaderboard:"
        '
        'LeaderboardBack
        '
        Me.LeaderboardBack.BackgroundImage = Global.Hangman.My.Resources.Resources.BackIcon
        Me.LeaderboardBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.LeaderboardBack.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LeaderboardBack.Location = New System.Drawing.Point(19, 484)
        Me.LeaderboardBack.Name = "LeaderboardBack"
        Me.LeaderboardBack.Size = New System.Drawing.Size(52, 54)
        Me.LeaderboardBack.TabIndex = 2
        Me.LeaderboardBack.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1067, 554)
        Me.Controls.Add(Me.LeaderboardPanel)
        Me.Controls.Add(Me.StartPanel)
        Me.Controls.Add(Me.SubjectPanel)
        Me.Controls.Add(Me.GamePanel)
        Me.Controls.Add(Me.SettingsPanel)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form1"
        Me.Text = "Start"
        Me.StartPanel.ResumeLayout(False)
        Me.StartPanel.PerformLayout()
        CType(Me.SettingPB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ExitPB, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SubjectPanel.ResumeLayout(False)
        Me.SubjectPanel.PerformLayout()
        Me.GamePanel.ResumeLayout(False)
        Me.GamePanel.PerformLayout()
        CType(Me.HangManPB, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SettingsPanel.ResumeLayout(False)
        Me.SettingsPanel.PerformLayout()
        CType(Me.SettingsBackPB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RedPB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrangePb, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.YellowPb, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GreenPB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BluePB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PurplePB, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LeaderboardPanel.ResumeLayout(False)
        Me.LeaderboardPanel.PerformLayout()
        CType(Me.LeaderboardBack, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents StartPanel As Panel
    Friend WithEvents StartButton As Button
    Friend WithEvents GamePanel As Panel
    Friend WithEvents Button_Enter As Button
    Friend WithEvents GuessLettersLabel As Label
    Friend WithEvents UserInputBox As TextBox
    Friend WithEvents GuessedLettersLabel As Label
    Friend WithEvents ScoreLabel As Label
    Friend WithEvents HangManPB As PictureBox
    Friend WithEvents ExitPB As PictureBox
    Friend WithEvents SubjectPanel As Panel
    Friend WithEvents ChemistryLabel As Label
    Friend WithEvents PhysicsLabel As Label
    Friend WithEvents SoftwareLabel As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents SettingsPanel As Panel
    Friend WithEvents PurplePB As PictureBox
    Friend WithEvents BluePB As PictureBox
    Friend WithEvents GreenPB As PictureBox
    Friend WithEvents YellowPb As PictureBox
    Friend WithEvents OrangePb As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents RedPB As PictureBox
    Friend WithEvents SettingPB As PictureBox
    Friend WithEvents SettingsBackPB As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Custom2Label As Label
    Friend WithEvents Custom1Label As Label
    Friend WithEvents LeaderboardPanel As Panel
    Friend WithEvents Leaderboardlabel As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents LeaderboardBack As PictureBox
End Class
