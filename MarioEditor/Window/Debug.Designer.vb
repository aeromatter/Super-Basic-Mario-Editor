<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Debug
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Debug))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cpuLabel = New System.Windows.Forms.Label()
        Me.memoryAvailable = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.cursorYLabel = New System.Windows.Forms.Label()
        Me.cursorXLabel = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.modeLabel = New System.Windows.Forms.Label()
        Me.npcIDLabel = New System.Windows.Forms.Label()
        Me.blockIDLabel = New System.Windows.Forms.Label()
        Me.bgoIDLabel = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.npcCountLabel = New System.Windows.Forms.Label()
        Me.bgoCountLabel = New System.Windows.Forms.Label()
        Me.blockCountLabel = New System.Windows.Forms.Label()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.FPSLabel = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cpuLabel)
        Me.GroupBox1.Controls.Add(Me.memoryAvailable)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(170, 51)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Performance"
        '
        'cpuLabel
        '
        Me.cpuLabel.AutoSize = True
        Me.cpuLabel.Location = New System.Drawing.Point(6, 29)
        Me.cpuLabel.Name = "cpuLabel"
        Me.cpuLabel.Size = New System.Drawing.Size(32, 13)
        Me.cpuLabel.TabIndex = 1
        Me.cpuLabel.Text = "CPU:"
        '
        'memoryAvailable
        '
        Me.memoryAvailable.AutoSize = True
        Me.memoryAvailable.Location = New System.Drawing.Point(6, 16)
        Me.memoryAvailable.Name = "memoryAvailable"
        Me.memoryAvailable.Size = New System.Drawing.Size(93, 13)
        Me.memoryAvailable.TabIndex = 1
        Me.memoryAvailable.Text = "Memory Available:"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.GroupBox4)
        Me.GroupBox2.Controls.Add(Me.GroupBox3)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 69)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(170, 167)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Editor"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.cursorYLabel)
        Me.GroupBox4.Controls.Add(Me.cursorXLabel)
        Me.GroupBox4.Location = New System.Drawing.Point(6, 110)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(118, 51)
        Me.GroupBox4.TabIndex = 3
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Cursor"
        '
        'cursorYLabel
        '
        Me.cursorYLabel.AutoSize = True
        Me.cursorYLabel.Location = New System.Drawing.Point(6, 29)
        Me.cursorYLabel.Name = "cursorYLabel"
        Me.cursorYLabel.Size = New System.Drawing.Size(17, 13)
        Me.cursorYLabel.TabIndex = 3
        Me.cursorYLabel.Text = "Y:"
        '
        'cursorXLabel
        '
        Me.cursorXLabel.AutoSize = True
        Me.cursorXLabel.Location = New System.Drawing.Point(6, 16)
        Me.cursorXLabel.Name = "cursorXLabel"
        Me.cursorXLabel.Size = New System.Drawing.Size(17, 13)
        Me.cursorXLabel.TabIndex = 3
        Me.cursorXLabel.Text = "X:"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.modeLabel)
        Me.GroupBox3.Controls.Add(Me.npcIDLabel)
        Me.GroupBox3.Controls.Add(Me.blockIDLabel)
        Me.GroupBox3.Controls.Add(Me.bgoIDLabel)
        Me.GroupBox3.Location = New System.Drawing.Point(6, 19)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(158, 85)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Placement"
        '
        'modeLabel
        '
        Me.modeLabel.AutoSize = True
        Me.modeLabel.Location = New System.Drawing.Point(6, 16)
        Me.modeLabel.Name = "modeLabel"
        Me.modeLabel.Size = New System.Drawing.Size(73, 13)
        Me.modeLabel.TabIndex = 3
        Me.modeLabel.Text = "Select Mode: "
        '
        'npcIDLabel
        '
        Me.npcIDLabel.AutoSize = True
        Me.npcIDLabel.Location = New System.Drawing.Point(6, 55)
        Me.npcIDLabel.Name = "npcIDLabel"
        Me.npcIDLabel.Size = New System.Drawing.Size(46, 13)
        Me.npcIDLabel.TabIndex = 3
        Me.npcIDLabel.Text = "NPC ID:"
        '
        'blockIDLabel
        '
        Me.blockIDLabel.AutoSize = True
        Me.blockIDLabel.Location = New System.Drawing.Point(6, 29)
        Me.blockIDLabel.Name = "blockIDLabel"
        Me.blockIDLabel.Size = New System.Drawing.Size(54, 13)
        Me.blockIDLabel.TabIndex = 3
        Me.blockIDLabel.Text = "Block ID: "
        '
        'bgoIDLabel
        '
        Me.bgoIDLabel.AutoSize = True
        Me.bgoIDLabel.Location = New System.Drawing.Point(6, 42)
        Me.bgoIDLabel.Name = "bgoIDLabel"
        Me.bgoIDLabel.Size = New System.Drawing.Size(50, 13)
        Me.bgoIDLabel.TabIndex = 3
        Me.bgoIDLabel.Text = "BGO ID: "
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.npcCountLabel)
        Me.GroupBox5.Controls.Add(Me.bgoCountLabel)
        Me.GroupBox5.Controls.Add(Me.blockCountLabel)
        Me.GroupBox5.Location = New System.Drawing.Point(188, 69)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(99, 65)
        Me.GroupBox5.TabIndex = 3
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Level Stats"
        '
        'npcCountLabel
        '
        Me.npcCountLabel.AutoSize = True
        Me.npcCountLabel.Location = New System.Drawing.Point(6, 42)
        Me.npcCountLabel.Name = "npcCountLabel"
        Me.npcCountLabel.Size = New System.Drawing.Size(37, 13)
        Me.npcCountLabel.TabIndex = 2
        Me.npcCountLabel.Text = "NPCs:"
        '
        'bgoCountLabel
        '
        Me.bgoCountLabel.AutoSize = True
        Me.bgoCountLabel.Location = New System.Drawing.Point(6, 29)
        Me.bgoCountLabel.Name = "bgoCountLabel"
        Me.bgoCountLabel.Size = New System.Drawing.Size(38, 13)
        Me.bgoCountLabel.TabIndex = 1
        Me.bgoCountLabel.Text = "BGOs:"
        '
        'blockCountLabel
        '
        Me.blockCountLabel.AutoSize = True
        Me.blockCountLabel.Location = New System.Drawing.Point(6, 16)
        Me.blockCountLabel.Name = "blockCountLabel"
        Me.blockCountLabel.Size = New System.Drawing.Size(42, 13)
        Me.blockCountLabel.TabIndex = 0
        Me.blockCountLabel.Text = "Blocks:"
        '
        'Timer2
        '
        Me.Timer2.Enabled = True
        Me.Timer2.Interval = 10
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.FPSLabel)
        Me.GroupBox8.Location = New System.Drawing.Point(188, 12)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(58, 51)
        Me.GroupBox8.TabIndex = 6
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "FPS"
        '
        'FPSLabel
        '
        Me.FPSLabel.AutoSize = True
        Me.FPSLabel.Location = New System.Drawing.Point(6, 16)
        Me.FPSLabel.Name = "FPSLabel"
        Me.FPSLabel.Size = New System.Drawing.Size(13, 13)
        Me.FPSLabel.TabIndex = 0
        Me.FPSLabel.Text = "0"
        '
        'Debug
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(299, 248)
        Me.Controls.Add(Me.GroupBox8)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Debug"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Debug"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cpuLabel As System.Windows.Forms.Label
    Friend WithEvents memoryAvailable As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents modeLabel As System.Windows.Forms.Label
    Friend WithEvents npcIDLabel As System.Windows.Forms.Label
    Friend WithEvents blockIDLabel As System.Windows.Forms.Label
    Friend WithEvents bgoIDLabel As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents cursorYLabel As System.Windows.Forms.Label
    Friend WithEvents cursorXLabel As System.Windows.Forms.Label
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents npcCountLabel As System.Windows.Forms.Label
    Friend WithEvents bgoCountLabel As System.Windows.Forms.Label
    Friend WithEvents blockCountLabel As System.Windows.Forms.Label
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents GroupBox8 As System.Windows.Forms.GroupBox
    Friend WithEvents FPSLabel As System.Windows.Forms.Label
End Class
