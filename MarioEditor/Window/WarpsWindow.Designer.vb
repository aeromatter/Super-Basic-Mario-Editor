<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WarpsWindow
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
        Me.EntranceDirGroup = New System.Windows.Forms.GroupBox()
        Me.EntranceRightRadio = New System.Windows.Forms.RadioButton()
        Me.EntranceLeftRadio = New System.Windows.Forms.RadioButton()
        Me.EntranceUpRadio = New System.Windows.Forms.RadioButton()
        Me.EntranceDownRadio = New System.Windows.Forms.RadioButton()
        Me.ExitDirGroup = New System.Windows.Forms.GroupBox()
        Me.ExitRightRadio = New System.Windows.Forms.RadioButton()
        Me.ExitLeftRadio = New System.Windows.Forms.RadioButton()
        Me.ExitUpRadio = New System.Windows.Forms.RadioButton()
        Me.ExitDownRadio = New System.Windows.Forms.RadioButton()
        Me.WarpPlacementGroup = New System.Windows.Forms.GroupBox()
        Me.ExitPlacementRadio = New System.Windows.Forms.RadioButton()
        Me.EntrancePlacementRadio = New System.Windows.Forms.RadioButton()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.WarpEffectGroup = New System.Windows.Forms.GroupBox()
        Me.InstantWarpRadio = New System.Windows.Forms.RadioButton()
        Me.DoorWarpRadio = New System.Windows.Forms.RadioButton()
        Me.PipeWarpRadio = New System.Windows.Forms.RadioButton()
        Me.LevelExitGroup = New System.Windows.Forms.GroupBox()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.NumericUpDown3 = New System.Windows.Forms.NumericUpDown()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.NumericUpDown2 = New System.Windows.Forms.NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ExitLevelCheck = New System.Windows.Forms.CheckBox()
        Me.WarpToLevelGroup = New System.Windows.Forms.GroupBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.HScrollBar1 = New System.Windows.Forms.HScrollBar()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.SettingsGroup = New System.Windows.Forms.GroupBox()
        Me.CheckBox5 = New System.Windows.Forms.CheckBox()
        Me.CheckBox4 = New System.Windows.Forms.CheckBox()
        Me.CheckBox3 = New System.Windows.Forms.CheckBox()
        Me.EntranceDirGroup.SuspendLayout()
        Me.ExitDirGroup.SuspendLayout()
        Me.WarpPlacementGroup.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.WarpEffectGroup.SuspendLayout()
        Me.LevelExitGroup.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        CType(Me.NumericUpDown3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.WarpToLevelGroup.SuspendLayout()
        Me.SettingsGroup.SuspendLayout()
        Me.SuspendLayout()
        '
        'EntranceDirGroup
        '
        Me.EntranceDirGroup.Controls.Add(Me.EntranceRightRadio)
        Me.EntranceDirGroup.Controls.Add(Me.EntranceLeftRadio)
        Me.EntranceDirGroup.Controls.Add(Me.EntranceUpRadio)
        Me.EntranceDirGroup.Controls.Add(Me.EntranceDownRadio)
        Me.EntranceDirGroup.Location = New System.Drawing.Point(12, 12)
        Me.EntranceDirGroup.Name = "EntranceDirGroup"
        Me.EntranceDirGroup.Size = New System.Drawing.Size(118, 111)
        Me.EntranceDirGroup.TabIndex = 0
        Me.EntranceDirGroup.TabStop = False
        Me.EntranceDirGroup.Text = "Entrance Direction"
        '
        'EntranceRightRadio
        '
        Me.EntranceRightRadio.AutoSize = True
        Me.EntranceRightRadio.Location = New System.Drawing.Point(6, 88)
        Me.EntranceRightRadio.Name = "EntranceRightRadio"
        Me.EntranceRightRadio.Size = New System.Drawing.Size(88, 17)
        Me.EntranceRightRadio.TabIndex = 4
        Me.EntranceRightRadio.TabStop = True
        Me.EntranceRightRadio.Text = "Moving Right"
        Me.EntranceRightRadio.UseVisualStyleBackColor = True
        '
        'EntranceLeftRadio
        '
        Me.EntranceLeftRadio.AutoSize = True
        Me.EntranceLeftRadio.Location = New System.Drawing.Point(6, 65)
        Me.EntranceLeftRadio.Name = "EntranceLeftRadio"
        Me.EntranceLeftRadio.Size = New System.Drawing.Size(81, 17)
        Me.EntranceLeftRadio.TabIndex = 3
        Me.EntranceLeftRadio.TabStop = True
        Me.EntranceLeftRadio.Text = "Moving Left"
        Me.EntranceLeftRadio.UseVisualStyleBackColor = True
        '
        'EntranceUpRadio
        '
        Me.EntranceUpRadio.AutoSize = True
        Me.EntranceUpRadio.Location = New System.Drawing.Point(6, 42)
        Me.EntranceUpRadio.Name = "EntranceUpRadio"
        Me.EntranceUpRadio.Size = New System.Drawing.Size(77, 17)
        Me.EntranceUpRadio.TabIndex = 2
        Me.EntranceUpRadio.TabStop = True
        Me.EntranceUpRadio.Text = "Moving Up"
        Me.EntranceUpRadio.UseVisualStyleBackColor = True
        '
        'EntranceDownRadio
        '
        Me.EntranceDownRadio.AutoSize = True
        Me.EntranceDownRadio.Location = New System.Drawing.Point(6, 19)
        Me.EntranceDownRadio.Name = "EntranceDownRadio"
        Me.EntranceDownRadio.Size = New System.Drawing.Size(91, 17)
        Me.EntranceDownRadio.TabIndex = 1
        Me.EntranceDownRadio.TabStop = True
        Me.EntranceDownRadio.Text = "Moving Down"
        Me.EntranceDownRadio.UseVisualStyleBackColor = True
        '
        'ExitDirGroup
        '
        Me.ExitDirGroup.Controls.Add(Me.ExitRightRadio)
        Me.ExitDirGroup.Controls.Add(Me.ExitLeftRadio)
        Me.ExitDirGroup.Controls.Add(Me.ExitUpRadio)
        Me.ExitDirGroup.Controls.Add(Me.ExitDownRadio)
        Me.ExitDirGroup.Location = New System.Drawing.Point(136, 12)
        Me.ExitDirGroup.Name = "ExitDirGroup"
        Me.ExitDirGroup.Size = New System.Drawing.Size(118, 111)
        Me.ExitDirGroup.TabIndex = 1
        Me.ExitDirGroup.TabStop = False
        Me.ExitDirGroup.Text = "Exit Direction"
        '
        'ExitRightRadio
        '
        Me.ExitRightRadio.AutoSize = True
        Me.ExitRightRadio.Location = New System.Drawing.Point(6, 88)
        Me.ExitRightRadio.Name = "ExitRightRadio"
        Me.ExitRightRadio.Size = New System.Drawing.Size(88, 17)
        Me.ExitRightRadio.TabIndex = 4
        Me.ExitRightRadio.TabStop = True
        Me.ExitRightRadio.Text = "Moving Right"
        Me.ExitRightRadio.UseVisualStyleBackColor = True
        '
        'ExitLeftRadio
        '
        Me.ExitLeftRadio.AutoSize = True
        Me.ExitLeftRadio.Location = New System.Drawing.Point(6, 65)
        Me.ExitLeftRadio.Name = "ExitLeftRadio"
        Me.ExitLeftRadio.Size = New System.Drawing.Size(81, 17)
        Me.ExitLeftRadio.TabIndex = 3
        Me.ExitLeftRadio.TabStop = True
        Me.ExitLeftRadio.Text = "Moving Left"
        Me.ExitLeftRadio.UseVisualStyleBackColor = True
        '
        'ExitUpRadio
        '
        Me.ExitUpRadio.AutoSize = True
        Me.ExitUpRadio.Location = New System.Drawing.Point(6, 42)
        Me.ExitUpRadio.Name = "ExitUpRadio"
        Me.ExitUpRadio.Size = New System.Drawing.Size(77, 17)
        Me.ExitUpRadio.TabIndex = 2
        Me.ExitUpRadio.TabStop = True
        Me.ExitUpRadio.Text = "Moving Up"
        Me.ExitUpRadio.UseVisualStyleBackColor = True
        '
        'ExitDownRadio
        '
        Me.ExitDownRadio.AutoSize = True
        Me.ExitDownRadio.Location = New System.Drawing.Point(6, 19)
        Me.ExitDownRadio.Name = "ExitDownRadio"
        Me.ExitDownRadio.Size = New System.Drawing.Size(91, 17)
        Me.ExitDownRadio.TabIndex = 1
        Me.ExitDownRadio.TabStop = True
        Me.ExitDownRadio.Text = "Moving Down"
        Me.ExitDownRadio.UseVisualStyleBackColor = True
        '
        'WarpPlacementGroup
        '
        Me.WarpPlacementGroup.Controls.Add(Me.ExitPlacementRadio)
        Me.WarpPlacementGroup.Controls.Add(Me.EntrancePlacementRadio)
        Me.WarpPlacementGroup.Location = New System.Drawing.Point(260, 12)
        Me.WarpPlacementGroup.Name = "WarpPlacementGroup"
        Me.WarpPlacementGroup.Size = New System.Drawing.Size(128, 42)
        Me.WarpPlacementGroup.TabIndex = 2
        Me.WarpPlacementGroup.TabStop = False
        Me.WarpPlacementGroup.Text = "Warp Placement"
        '
        'ExitPlacementRadio
        '
        Me.ExitPlacementRadio.AutoSize = True
        Me.ExitPlacementRadio.Location = New System.Drawing.Point(80, 19)
        Me.ExitPlacementRadio.Name = "ExitPlacementRadio"
        Me.ExitPlacementRadio.Size = New System.Drawing.Size(42, 17)
        Me.ExitPlacementRadio.TabIndex = 3
        Me.ExitPlacementRadio.TabStop = True
        Me.ExitPlacementRadio.Text = "Exit"
        Me.ExitPlacementRadio.UseVisualStyleBackColor = True
        '
        'EntrancePlacementRadio
        '
        Me.EntrancePlacementRadio.AutoSize = True
        Me.EntrancePlacementRadio.Location = New System.Drawing.Point(6, 19)
        Me.EntrancePlacementRadio.Name = "EntrancePlacementRadio"
        Me.EntrancePlacementRadio.Size = New System.Drawing.Size(68, 17)
        Me.EntrancePlacementRadio.TabIndex = 2
        Me.EntrancePlacementRadio.TabStop = True
        Me.EntrancePlacementRadio.Text = "Entrance"
        Me.EntrancePlacementRadio.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.NumericUpDown1)
        Me.GroupBox4.Location = New System.Drawing.Point(260, 78)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(128, 45)
        Me.GroupBox4.TabIndex = 3
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Stars Needed"
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Location = New System.Drawing.Point(6, 19)
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(116, 20)
        Me.NumericUpDown1.TabIndex = 0
        '
        'WarpEffectGroup
        '
        Me.WarpEffectGroup.Controls.Add(Me.InstantWarpRadio)
        Me.WarpEffectGroup.Controls.Add(Me.DoorWarpRadio)
        Me.WarpEffectGroup.Controls.Add(Me.PipeWarpRadio)
        Me.WarpEffectGroup.Location = New System.Drawing.Point(394, 12)
        Me.WarpEffectGroup.Name = "WarpEffectGroup"
        Me.WarpEffectGroup.Size = New System.Drawing.Size(95, 111)
        Me.WarpEffectGroup.TabIndex = 4
        Me.WarpEffectGroup.TabStop = False
        Me.WarpEffectGroup.Text = "Warp Effect"
        '
        'InstantWarpRadio
        '
        Me.InstantWarpRadio.AutoSize = True
        Me.InstantWarpRadio.Location = New System.Drawing.Point(6, 65)
        Me.InstantWarpRadio.Name = "InstantWarpRadio"
        Me.InstantWarpRadio.Size = New System.Drawing.Size(57, 17)
        Me.InstantWarpRadio.TabIndex = 6
        Me.InstantWarpRadio.TabStop = True
        Me.InstantWarpRadio.Text = "Instant"
        Me.InstantWarpRadio.UseVisualStyleBackColor = True
        '
        'DoorWarpRadio
        '
        Me.DoorWarpRadio.AutoSize = True
        Me.DoorWarpRadio.Location = New System.Drawing.Point(6, 42)
        Me.DoorWarpRadio.Name = "DoorWarpRadio"
        Me.DoorWarpRadio.Size = New System.Drawing.Size(48, 17)
        Me.DoorWarpRadio.TabIndex = 5
        Me.DoorWarpRadio.TabStop = True
        Me.DoorWarpRadio.Text = "Door"
        Me.DoorWarpRadio.UseVisualStyleBackColor = True
        '
        'PipeWarpRadio
        '
        Me.PipeWarpRadio.AutoSize = True
        Me.PipeWarpRadio.Location = New System.Drawing.Point(6, 19)
        Me.PipeWarpRadio.Name = "PipeWarpRadio"
        Me.PipeWarpRadio.Size = New System.Drawing.Size(46, 17)
        Me.PipeWarpRadio.TabIndex = 4
        Me.PipeWarpRadio.TabStop = True
        Me.PipeWarpRadio.Text = "Pipe"
        Me.PipeWarpRadio.UseVisualStyleBackColor = True
        '
        'LevelExitGroup
        '
        Me.LevelExitGroup.Controls.Add(Me.GroupBox7)
        Me.LevelExitGroup.Controls.Add(Me.ExitLevelCheck)
        Me.LevelExitGroup.Location = New System.Drawing.Point(12, 129)
        Me.LevelExitGroup.Name = "LevelExitGroup"
        Me.LevelExitGroup.Size = New System.Drawing.Size(200, 100)
        Me.LevelExitGroup.TabIndex = 5
        Me.LevelExitGroup.TabStop = False
        Me.LevelExitGroup.Text = "Level Exit"
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.NumericUpDown3)
        Me.GroupBox7.Controls.Add(Me.Label2)
        Me.GroupBox7.Controls.Add(Me.NumericUpDown2)
        Me.GroupBox7.Controls.Add(Me.Label1)
        Me.GroupBox7.Location = New System.Drawing.Point(6, 42)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(188, 52)
        Me.GroupBox7.TabIndex = 6
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Warp To Map Location"
        '
        'NumericUpDown3
        '
        Me.NumericUpDown3.Location = New System.Drawing.Point(128, 19)
        Me.NumericUpDown3.Name = "NumericUpDown3"
        Me.NumericUpDown3.Size = New System.Drawing.Size(54, 20)
        Me.NumericUpDown3.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(105, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(17, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Y:"
        '
        'NumericUpDown2
        '
        Me.NumericUpDown2.Location = New System.Drawing.Point(29, 19)
        Me.NumericUpDown2.Name = "NumericUpDown2"
        Me.NumericUpDown2.Size = New System.Drawing.Size(54, 20)
        Me.NumericUpDown2.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(17, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "X:"
        '
        'ExitLevelCheck
        '
        Me.ExitLevelCheck.AutoSize = True
        Me.ExitLevelCheck.Location = New System.Drawing.Point(6, 19)
        Me.ExitLevelCheck.Name = "ExitLevelCheck"
        Me.ExitLevelCheck.Size = New System.Drawing.Size(68, 17)
        Me.ExitLevelCheck.TabIndex = 6
        Me.ExitLevelCheck.Text = "Exit level"
        Me.ExitLevelCheck.UseVisualStyleBackColor = True
        '
        'WarpToLevelGroup
        '
        Me.WarpToLevelGroup.Controls.Add(Me.CheckBox2)
        Me.WarpToLevelGroup.Controls.Add(Me.Label3)
        Me.WarpToLevelGroup.Controls.Add(Me.HScrollBar1)
        Me.WarpToLevelGroup.Controls.Add(Me.TextBox1)
        Me.WarpToLevelGroup.Location = New System.Drawing.Point(218, 129)
        Me.WarpToLevelGroup.Name = "WarpToLevelGroup"
        Me.WarpToLevelGroup.Size = New System.Drawing.Size(196, 100)
        Me.WarpToLevelGroup.TabIndex = 6
        Me.WarpToLevelGroup.TabStop = False
        Me.WarpToLevelGroup.Text = "Warp To Level"
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Location = New System.Drawing.Point(6, 77)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(97, 17)
        Me.CheckBox2.TabIndex = 3
        Me.CheckBox2.Text = "Level entrance"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(89, 46)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Normal entrance"
        '
        'HScrollBar1
        '
        Me.HScrollBar1.Location = New System.Drawing.Point(6, 42)
        Me.HScrollBar1.Name = "HScrollBar1"
        Me.HScrollBar1.Size = New System.Drawing.Size(80, 17)
        Me.HScrollBar1.TabIndex = 1
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(6, 19)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(184, 20)
        Me.TextBox1.TabIndex = 0
        '
        'SettingsGroup
        '
        Me.SettingsGroup.Controls.Add(Me.CheckBox5)
        Me.SettingsGroup.Controls.Add(Me.CheckBox4)
        Me.SettingsGroup.Controls.Add(Me.CheckBox3)
        Me.SettingsGroup.Location = New System.Drawing.Point(420, 129)
        Me.SettingsGroup.Name = "SettingsGroup"
        Me.SettingsGroup.Size = New System.Drawing.Size(69, 100)
        Me.SettingsGroup.TabIndex = 7
        Me.SettingsGroup.TabStop = False
        Me.SettingsGroup.Text = "Settings"
        '
        'CheckBox5
        '
        Me.CheckBox5.AutoSize = True
        Me.CheckBox5.Location = New System.Drawing.Point(6, 68)
        Me.CheckBox5.Name = "CheckBox5"
        Me.CheckBox5.Size = New System.Drawing.Size(62, 17)
        Me.CheckBox5.TabIndex = 2
        Me.CheckBox5.Text = "Locked"
        Me.CheckBox5.UseVisualStyleBackColor = True
        '
        'CheckBox4
        '
        Me.CheckBox4.AutoSize = True
        Me.CheckBox4.Location = New System.Drawing.Point(6, 45)
        Me.CheckBox4.Name = "CheckBox4"
        Me.CheckBox4.Size = New System.Drawing.Size(48, 17)
        Me.CheckBox4.TabIndex = 1
        Me.CheckBox4.Text = "NPC"
        Me.CheckBox4.UseVisualStyleBackColor = True
        '
        'CheckBox3
        '
        Me.CheckBox3.AutoSize = True
        Me.CheckBox3.Location = New System.Drawing.Point(6, 22)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(52, 17)
        Me.CheckBox3.TabIndex = 0
        Me.CheckBox3.Text = "Yoshi"
        Me.CheckBox3.UseVisualStyleBackColor = True
        '
        'WarpsWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(501, 241)
        Me.Controls.Add(Me.SettingsGroup)
        Me.Controls.Add(Me.WarpToLevelGroup)
        Me.Controls.Add(Me.LevelExitGroup)
        Me.Controls.Add(Me.WarpEffectGroup)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.WarpPlacementGroup)
        Me.Controls.Add(Me.ExitDirGroup)
        Me.Controls.Add(Me.EntranceDirGroup)
        Me.Name = "WarpsWindow"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Warps"
        Me.EntranceDirGroup.ResumeLayout(False)
        Me.EntranceDirGroup.PerformLayout()
        Me.ExitDirGroup.ResumeLayout(False)
        Me.ExitDirGroup.PerformLayout()
        Me.WarpPlacementGroup.ResumeLayout(False)
        Me.WarpPlacementGroup.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.WarpEffectGroup.ResumeLayout(False)
        Me.WarpEffectGroup.PerformLayout()
        Me.LevelExitGroup.ResumeLayout(False)
        Me.LevelExitGroup.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        CType(Me.NumericUpDown3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.WarpToLevelGroup.ResumeLayout(False)
        Me.WarpToLevelGroup.PerformLayout()
        Me.SettingsGroup.ResumeLayout(False)
        Me.SettingsGroup.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents EntranceDirGroup As GroupBox
    Friend WithEvents EntranceRightRadio As RadioButton
    Friend WithEvents EntranceLeftRadio As RadioButton
    Friend WithEvents EntranceUpRadio As RadioButton
    Friend WithEvents EntranceDownRadio As RadioButton
    Friend WithEvents ExitDirGroup As GroupBox
    Friend WithEvents ExitRightRadio As RadioButton
    Friend WithEvents ExitLeftRadio As RadioButton
    Friend WithEvents ExitUpRadio As RadioButton
    Friend WithEvents ExitDownRadio As RadioButton
    Friend WithEvents WarpPlacementGroup As GroupBox
    Friend WithEvents ExitPlacementRadio As RadioButton
    Friend WithEvents EntrancePlacementRadio As RadioButton
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents WarpEffectGroup As GroupBox
    Friend WithEvents InstantWarpRadio As RadioButton
    Friend WithEvents DoorWarpRadio As RadioButton
    Friend WithEvents PipeWarpRadio As RadioButton
    Friend WithEvents LevelExitGroup As GroupBox
    Friend WithEvents GroupBox7 As GroupBox
    Friend WithEvents NumericUpDown3 As NumericUpDown
    Friend WithEvents Label2 As Label
    Friend WithEvents NumericUpDown2 As NumericUpDown
    Friend WithEvents Label1 As Label
    Friend WithEvents ExitLevelCheck As CheckBox
    Friend WithEvents WarpToLevelGroup As GroupBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents Label3 As Label
    Friend WithEvents HScrollBar1 As HScrollBar
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents SettingsGroup As GroupBox
    Friend WithEvents CheckBox5 As CheckBox
    Friend WithEvents CheckBox4 As CheckBox
    Friend WithEvents CheckBox3 As CheckBox
End Class
