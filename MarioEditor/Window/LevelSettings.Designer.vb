<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LevelSettings
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ListViewGroup1 As System.Windows.Forms.ListViewGroup = New System.Windows.Forms.ListViewGroup("Super Mario Bros.", System.Windows.Forms.HorizontalAlignment.Left)
        Dim ListViewGroup2 As System.Windows.Forms.ListViewGroup = New System.Windows.Forms.ListViewGroup("Super Mario Bros. 2", System.Windows.Forms.HorizontalAlignment.Left)
        Dim ListViewGroup3 As System.Windows.Forms.ListViewGroup = New System.Windows.Forms.ListViewGroup("Super Mario Bros. 3", System.Windows.Forms.HorizontalAlignment.Left)
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LevelSettings))
        Me.BackgroundsList = New System.Windows.Forms.ListView()
        Me.BackgroundImages = New System.Windows.Forms.ImageList(Me.components)
        Me.AdvancedButton = New System.Windows.Forms.Button()
        Me.StartGroupBox = New System.Windows.Forms.GroupBox()
        Me.P2Button = New System.Windows.Forms.Button()
        Me.P1Button = New System.Windows.Forms.Button()
        Me.LevelSizeGroupBox = New System.Windows.Forms.GroupBox()
        Me.LevelHeightSpin = New System.Windows.Forms.NumericUpDown()
        Me.LevelWidthSpin = New System.Windows.Forms.NumericUpDown()
        Me.UpdateLevelButton = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SectionsComboBox = New System.Windows.Forms.ComboBox()
        Me.SettingsGroupBox = New System.Windows.Forms.GroupBox()
        Me.UnderwaterCheck = New System.Windows.Forms.CheckBox()
        Me.NoTurnbackCheck = New System.Windows.Forms.CheckBox()
        Me.OffscreenCheck = New System.Windows.Forms.CheckBox()
        Me.WrapCheck = New System.Windows.Forms.CheckBox()
        Me.SectionGroupBox = New System.Windows.Forms.GroupBox()
        Me.MusicGroupBox = New System.Windows.Forms.GroupBox()
        Me.MusicComboBox = New System.Windows.Forms.ComboBox()
        Me.BackgroundGroupBox = New System.Windows.Forms.GroupBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.StartGroupBox.SuspendLayout()
        Me.LevelSizeGroupBox.SuspendLayout()
        CType(Me.LevelHeightSpin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LevelWidthSpin, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SettingsGroupBox.SuspendLayout()
        Me.SectionGroupBox.SuspendLayout()
        Me.MusicGroupBox.SuspendLayout()
        Me.BackgroundGroupBox.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'BackgroundsList
        '
        Me.BackgroundsList.Alignment = System.Windows.Forms.ListViewAlignment.Left
        Me.BackgroundsList.Dock = System.Windows.Forms.DockStyle.Fill
        ListViewGroup1.Header = "Super Mario Bros."
        ListViewGroup1.Name = "SMB"
        ListViewGroup2.Header = "Super Mario Bros. 2"
        ListViewGroup2.Name = "SMB2"
        ListViewGroup3.Header = "Super Mario Bros. 3"
        ListViewGroup3.Name = "SMB3"
        Me.BackgroundsList.Groups.AddRange(New System.Windows.Forms.ListViewGroup() {ListViewGroup1, ListViewGroup2, ListViewGroup3})
        Me.BackgroundsList.HideSelection = False
        Me.BackgroundsList.LargeImageList = Me.BackgroundImages
        Me.BackgroundsList.Location = New System.Drawing.Point(3, 16)
        Me.BackgroundsList.MultiSelect = False
        Me.BackgroundsList.Name = "BackgroundsList"
        Me.BackgroundsList.Size = New System.Drawing.Size(783, 148)
        Me.BackgroundsList.TabIndex = 22
        Me.BackgroundsList.UseCompatibleStateImageBehavior = False
        '
        'BackgroundImages
        '
        Me.BackgroundImages.ImageStream = CType(resources.GetObject("BackgroundImages.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.BackgroundImages.TransparentColor = System.Drawing.Color.Transparent
        Me.BackgroundImages.Images.SetKeyName(0, "background2-1.png")
        Me.BackgroundImages.Images.SetKeyName(1, "background2-2.png")
        Me.BackgroundImages.Images.SetKeyName(2, "background2-3.png")
        Me.BackgroundImages.Images.SetKeyName(3, "background2-4.png")
        Me.BackgroundImages.Images.SetKeyName(4, "background2-5.png")
        Me.BackgroundImages.Images.SetKeyName(5, "background2-6.png")
        Me.BackgroundImages.Images.SetKeyName(6, "background2-7.png")
        Me.BackgroundImages.Images.SetKeyName(7, "background2-8.png")
        Me.BackgroundImages.Images.SetKeyName(8, "background2-9.png")
        Me.BackgroundImages.Images.SetKeyName(9, "background2-10.png")
        Me.BackgroundImages.Images.SetKeyName(10, "background2-11.png")
        Me.BackgroundImages.Images.SetKeyName(11, "background2-12.png")
        Me.BackgroundImages.Images.SetKeyName(12, "background2-13.png")
        Me.BackgroundImages.Images.SetKeyName(13, "background2-14.png")
        Me.BackgroundImages.Images.SetKeyName(14, "background2-15.png")
        Me.BackgroundImages.Images.SetKeyName(15, "background2-16.png")
        Me.BackgroundImages.Images.SetKeyName(16, "background2-17.png")
        Me.BackgroundImages.Images.SetKeyName(17, "background2-18.png")
        Me.BackgroundImages.Images.SetKeyName(18, "background2-19.png")
        Me.BackgroundImages.Images.SetKeyName(19, "background2-20.png")
        Me.BackgroundImages.Images.SetKeyName(20, "background2-21.png")
        Me.BackgroundImages.Images.SetKeyName(21, "background2-22.png")
        Me.BackgroundImages.Images.SetKeyName(22, "background2-23.png")
        Me.BackgroundImages.Images.SetKeyName(23, "background2-24.png")
        Me.BackgroundImages.Images.SetKeyName(24, "background2-25.png")
        Me.BackgroundImages.Images.SetKeyName(25, "background2-26.png")
        Me.BackgroundImages.Images.SetKeyName(26, "background2-27.png")
        Me.BackgroundImages.Images.SetKeyName(27, "background2-28.png")
        Me.BackgroundImages.Images.SetKeyName(28, "background2-29.png")
        Me.BackgroundImages.Images.SetKeyName(29, "background2-30.png")
        Me.BackgroundImages.Images.SetKeyName(30, "background2-31.png")
        Me.BackgroundImages.Images.SetKeyName(31, "background2-32.png")
        Me.BackgroundImages.Images.SetKeyName(32, "background2-33.png")
        Me.BackgroundImages.Images.SetKeyName(33, "background2-34.png")
        Me.BackgroundImages.Images.SetKeyName(34, "background2-35.png")
        Me.BackgroundImages.Images.SetKeyName(35, "background2-36.png")
        Me.BackgroundImages.Images.SetKeyName(36, "background2-37.png")
        Me.BackgroundImages.Images.SetKeyName(37, "background2-38.png")
        Me.BackgroundImages.Images.SetKeyName(38, "background2-39.png")
        Me.BackgroundImages.Images.SetKeyName(39, "background2-40.png")
        Me.BackgroundImages.Images.SetKeyName(40, "background2-41.png")
        Me.BackgroundImages.Images.SetKeyName(41, "background2-42.png")
        Me.BackgroundImages.Images.SetKeyName(42, "background2-43.png")
        Me.BackgroundImages.Images.SetKeyName(43, "background2-44.png")
        Me.BackgroundImages.Images.SetKeyName(44, "background2-45.png")
        Me.BackgroundImages.Images.SetKeyName(45, "background2-46.png")
        Me.BackgroundImages.Images.SetKeyName(46, "background2-47.png")
        Me.BackgroundImages.Images.SetKeyName(47, "background2-48.png")
        Me.BackgroundImages.Images.SetKeyName(48, "background2-49.png")
        Me.BackgroundImages.Images.SetKeyName(49, "background2-50.png")
        Me.BackgroundImages.Images.SetKeyName(50, "background2-51.png")
        Me.BackgroundImages.Images.SetKeyName(51, "background2-52.png")
        Me.BackgroundImages.Images.SetKeyName(52, "background2-53.png")
        Me.BackgroundImages.Images.SetKeyName(53, "background2-54.png")
        Me.BackgroundImages.Images.SetKeyName(54, "background2-55.png")
        Me.BackgroundImages.Images.SetKeyName(55, "background2-56.png")
        Me.BackgroundImages.Images.SetKeyName(56, "background2-57.png")
        Me.BackgroundImages.Images.SetKeyName(57, "background2-58.png")
        '
        'AdvancedButton
        '
        Me.AdvancedButton.Enabled = False
        Me.AdvancedButton.Location = New System.Drawing.Point(6, 19)
        Me.AdvancedButton.Name = "AdvancedButton"
        Me.AdvancedButton.Size = New System.Drawing.Size(88, 23)
        Me.AdvancedButton.TabIndex = 25
        Me.AdvancedButton.Text = "Show"
        Me.AdvancedButton.UseVisualStyleBackColor = True
        '
        'StartGroupBox
        '
        Me.StartGroupBox.Controls.Add(Me.P2Button)
        Me.StartGroupBox.Controls.Add(Me.P1Button)
        Me.StartGroupBox.Location = New System.Drawing.Point(542, 12)
        Me.StartGroupBox.Name = "StartGroupBox"
        Me.StartGroupBox.Size = New System.Drawing.Size(199, 50)
        Me.StartGroupBox.TabIndex = 24
        Me.StartGroupBox.TabStop = False
        Me.StartGroupBox.Text = "Start Locations"
        '
        'P2Button
        '
        Me.P2Button.Location = New System.Drawing.Point(100, 19)
        Me.P2Button.Name = "P2Button"
        Me.P2Button.Size = New System.Drawing.Size(88, 23)
        Me.P2Button.TabIndex = 3
        Me.P2Button.Text = "Player 2"
        Me.P2Button.UseVisualStyleBackColor = True
        '
        'P1Button
        '
        Me.P1Button.Location = New System.Drawing.Point(6, 19)
        Me.P1Button.Name = "P1Button"
        Me.P1Button.Size = New System.Drawing.Size(88, 23)
        Me.P1Button.TabIndex = 3
        Me.P1Button.Text = "Player 1"
        Me.P1Button.UseVisualStyleBackColor = True
        '
        'LevelSizeGroupBox
        '
        Me.LevelSizeGroupBox.Controls.Add(Me.LevelHeightSpin)
        Me.LevelSizeGroupBox.Controls.Add(Me.LevelWidthSpin)
        Me.LevelSizeGroupBox.Controls.Add(Me.UpdateLevelButton)
        Me.LevelSizeGroupBox.Controls.Add(Me.Label2)
        Me.LevelSizeGroupBox.Controls.Add(Me.Label1)
        Me.LevelSizeGroupBox.Location = New System.Drawing.Point(12, 12)
        Me.LevelSizeGroupBox.Name = "LevelSizeGroupBox"
        Me.LevelSizeGroupBox.Size = New System.Drawing.Size(100, 100)
        Me.LevelSizeGroupBox.TabIndex = 23
        Me.LevelSizeGroupBox.TabStop = False
        Me.LevelSizeGroupBox.Text = "Level Size"
        '
        'LevelHeightSpin
        '
        Me.LevelHeightSpin.Location = New System.Drawing.Point(33, 45)
        Me.LevelHeightSpin.Name = "LevelHeightSpin"
        Me.LevelHeightSpin.Size = New System.Drawing.Size(61, 20)
        Me.LevelHeightSpin.TabIndex = 24
        '
        'LevelWidthSpin
        '
        Me.LevelWidthSpin.Location = New System.Drawing.Point(33, 20)
        Me.LevelWidthSpin.Name = "LevelWidthSpin"
        Me.LevelWidthSpin.Size = New System.Drawing.Size(61, 20)
        Me.LevelWidthSpin.TabIndex = 23
        '
        'UpdateLevelButton
        '
        Me.UpdateLevelButton.Location = New System.Drawing.Point(6, 71)
        Me.UpdateLevelButton.Name = "UpdateLevelButton"
        Me.UpdateLevelButton.Size = New System.Drawing.Size(88, 23)
        Me.UpdateLevelButton.TabIndex = 16
        Me.UpdateLevelButton.Text = "Update"
        Me.UpdateLevelButton.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(18, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "H:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(21, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "W:"
        '
        'SectionsComboBox
        '
        Me.SectionsComboBox.FormattingEnabled = True
        Me.SectionsComboBox.Location = New System.Drawing.Point(6, 19)
        Me.SectionsComboBox.Name = "SectionsComboBox"
        Me.SectionsComboBox.Size = New System.Drawing.Size(194, 21)
        Me.SectionsComboBox.TabIndex = 28
        '
        'SettingsGroupBox
        '
        Me.SettingsGroupBox.Controls.Add(Me.UnderwaterCheck)
        Me.SettingsGroupBox.Controls.Add(Me.NoTurnbackCheck)
        Me.SettingsGroupBox.Controls.Add(Me.OffscreenCheck)
        Me.SettingsGroupBox.Controls.Add(Me.WrapCheck)
        Me.SettingsGroupBox.Location = New System.Drawing.Point(12, 118)
        Me.SettingsGroupBox.Name = "SettingsGroupBox"
        Me.SettingsGroupBox.Size = New System.Drawing.Size(100, 117)
        Me.SettingsGroupBox.TabIndex = 34
        Me.SettingsGroupBox.TabStop = False
        Me.SettingsGroupBox.Text = "Settings"
        '
        'UnderwaterCheck
        '
        Me.UnderwaterCheck.AutoSize = True
        Me.UnderwaterCheck.Location = New System.Drawing.Point(6, 88)
        Me.UnderwaterCheck.Name = "UnderwaterCheck"
        Me.UnderwaterCheck.Size = New System.Drawing.Size(81, 17)
        Me.UnderwaterCheck.TabIndex = 37
        Me.UnderwaterCheck.Text = "Underwater"
        Me.UnderwaterCheck.UseVisualStyleBackColor = True
        '
        'NoTurnbackCheck
        '
        Me.NoTurnbackCheck.AutoSize = True
        Me.NoTurnbackCheck.Location = New System.Drawing.Point(6, 65)
        Me.NoTurnbackCheck.Name = "NoTurnbackCheck"
        Me.NoTurnbackCheck.Size = New System.Drawing.Size(89, 17)
        Me.NoTurnbackCheck.TabIndex = 36
        Me.NoTurnbackCheck.Text = "No Turnback"
        Me.NoTurnbackCheck.UseVisualStyleBackColor = True
        '
        'OffscreenCheck
        '
        Me.OffscreenCheck.AutoSize = True
        Me.OffscreenCheck.Location = New System.Drawing.Point(6, 42)
        Me.OffscreenCheck.Name = "OffscreenCheck"
        Me.OffscreenCheck.Size = New System.Drawing.Size(92, 17)
        Me.OffscreenCheck.TabIndex = 35
        Me.OffscreenCheck.Text = "Offscreen Exit"
        Me.OffscreenCheck.UseVisualStyleBackColor = True
        '
        'WrapCheck
        '
        Me.WrapCheck.AutoSize = True
        Me.WrapCheck.Location = New System.Drawing.Point(6, 19)
        Me.WrapCheck.Name = "WrapCheck"
        Me.WrapCheck.Size = New System.Drawing.Size(52, 17)
        Me.WrapCheck.TabIndex = 34
        Me.WrapCheck.Text = "Wrap"
        Me.WrapCheck.UseVisualStyleBackColor = True
        '
        'SectionGroupBox
        '
        Me.SectionGroupBox.Controls.Add(Me.SectionsComboBox)
        Me.SectionGroupBox.Location = New System.Drawing.Point(118, 12)
        Me.SectionGroupBox.Name = "SectionGroupBox"
        Me.SectionGroupBox.Size = New System.Drawing.Size(206, 50)
        Me.SectionGroupBox.TabIndex = 35
        Me.SectionGroupBox.TabStop = False
        Me.SectionGroupBox.Text = "Section"
        '
        'MusicGroupBox
        '
        Me.MusicGroupBox.Controls.Add(Me.MusicComboBox)
        Me.MusicGroupBox.Location = New System.Drawing.Point(330, 12)
        Me.MusicGroupBox.Name = "MusicGroupBox"
        Me.MusicGroupBox.Size = New System.Drawing.Size(206, 50)
        Me.MusicGroupBox.TabIndex = 36
        Me.MusicGroupBox.TabStop = False
        Me.MusicGroupBox.Text = "Music"
        '
        'MusicComboBox
        '
        Me.MusicComboBox.FormattingEnabled = True
        Me.MusicComboBox.Location = New System.Drawing.Point(6, 19)
        Me.MusicComboBox.Name = "MusicComboBox"
        Me.MusicComboBox.Size = New System.Drawing.Size(194, 21)
        Me.MusicComboBox.TabIndex = 28
        '
        'BackgroundGroupBox
        '
        Me.BackgroundGroupBox.Controls.Add(Me.BackgroundsList)
        Me.BackgroundGroupBox.Location = New System.Drawing.Point(118, 68)
        Me.BackgroundGroupBox.Name = "BackgroundGroupBox"
        Me.BackgroundGroupBox.Size = New System.Drawing.Size(789, 167)
        Me.BackgroundGroupBox.TabIndex = 37
        Me.BackgroundGroupBox.TabStop = False
        Me.BackgroundGroupBox.Text = "Backgrounds"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.AdvancedButton)
        Me.GroupBox1.Location = New System.Drawing.Point(747, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(100, 50)
        Me.GroupBox1.TabIndex = 38
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Advanced"
        '
        'LevelSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(919, 247)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.BackgroundGroupBox)
        Me.Controls.Add(Me.MusicGroupBox)
        Me.Controls.Add(Me.SectionGroupBox)
        Me.Controls.Add(Me.SettingsGroupBox)
        Me.Controls.Add(Me.StartGroupBox)
        Me.Controls.Add(Me.LevelSizeGroupBox)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "LevelSettings"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Level Settings"
        Me.StartGroupBox.ResumeLayout(False)
        Me.LevelSizeGroupBox.ResumeLayout(False)
        Me.LevelSizeGroupBox.PerformLayout()
        CType(Me.LevelHeightSpin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LevelWidthSpin, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SettingsGroupBox.ResumeLayout(False)
        Me.SettingsGroupBox.PerformLayout()
        Me.SectionGroupBox.ResumeLayout(False)
        Me.MusicGroupBox.ResumeLayout(False)
        Me.BackgroundGroupBox.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BackgroundsList As ListView
    Friend WithEvents BackgroundImages As ImageList
    Friend WithEvents AdvancedButton As Button
    Friend WithEvents StartGroupBox As GroupBox
    Friend WithEvents P2Button As Button
    Friend WithEvents P1Button As Button
    Friend WithEvents LevelSizeGroupBox As GroupBox
    Friend WithEvents UpdateLevelButton As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents SectionsComboBox As ComboBox
    Friend WithEvents SettingsGroupBox As GroupBox
    Friend WithEvents UnderwaterCheck As CheckBox
    Friend WithEvents NoTurnbackCheck As CheckBox
    Friend WithEvents OffscreenCheck As CheckBox
    Friend WithEvents WrapCheck As CheckBox
    Friend WithEvents LevelHeightSpin As NumericUpDown
    Friend WithEvents LevelWidthSpin As NumericUpDown
    Friend WithEvents SectionGroupBox As GroupBox
    Friend WithEvents MusicGroupBox As GroupBox
    Friend WithEvents MusicComboBox As ComboBox
    Friend WithEvents BackgroundGroupBox As GroupBox
    Friend WithEvents GroupBox1 As GroupBox
End Class
