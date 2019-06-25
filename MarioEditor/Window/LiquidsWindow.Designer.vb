<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LiquidsWindow
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
        Me.WaterSizeBox = New System.Windows.Forms.GroupBox()
        Me.QuicksandCheck = New System.Windows.Forms.CheckBox()
        Me.WaterHeightLabel = New System.Windows.Forms.Label()
        Me.WaterHeightSpin = New System.Windows.Forms.NumericUpDown()
        Me.WaterWidthLabel = New System.Windows.Forms.Label()
        Me.WaterWidthSpin = New System.Windows.Forms.NumericUpDown()
        Me.WaterSizeBox.SuspendLayout()
        CType(Me.WaterHeightSpin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WaterWidthSpin, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'WaterSizeBox
        '
        Me.WaterSizeBox.Controls.Add(Me.QuicksandCheck)
        Me.WaterSizeBox.Controls.Add(Me.WaterHeightLabel)
        Me.WaterSizeBox.Controls.Add(Me.WaterHeightSpin)
        Me.WaterSizeBox.Controls.Add(Me.WaterWidthLabel)
        Me.WaterSizeBox.Controls.Add(Me.WaterWidthSpin)
        Me.WaterSizeBox.Location = New System.Drawing.Point(12, 12)
        Me.WaterSizeBox.Name = "WaterSizeBox"
        Me.WaterSizeBox.Size = New System.Drawing.Size(118, 98)
        Me.WaterSizeBox.TabIndex = 0
        Me.WaterSizeBox.TabStop = False
        Me.WaterSizeBox.Text = "Water Size"
        '
        'QuicksandCheck
        '
        Me.QuicksandCheck.AutoSize = True
        Me.QuicksandCheck.Location = New System.Drawing.Point(6, 75)
        Me.QuicksandCheck.Name = "QuicksandCheck"
        Me.QuicksandCheck.Size = New System.Drawing.Size(77, 17)
        Me.QuicksandCheck.TabIndex = 4
        Me.QuicksandCheck.Text = "Quicksand"
        Me.QuicksandCheck.UseVisualStyleBackColor = True
        '
        'WaterHeightLabel
        '
        Me.WaterHeightLabel.AutoSize = True
        Me.WaterHeightLabel.Location = New System.Drawing.Point(3, 47)
        Me.WaterHeightLabel.Name = "WaterHeightLabel"
        Me.WaterHeightLabel.Size = New System.Drawing.Size(41, 13)
        Me.WaterHeightLabel.TabIndex = 3
        Me.WaterHeightLabel.Text = "Height:"
        '
        'WaterHeightSpin
        '
        Me.WaterHeightSpin.Increment = New Decimal(New Integer() {32, 0, 0, 0})
        Me.WaterHeightSpin.Location = New System.Drawing.Point(50, 45)
        Me.WaterHeightSpin.Maximum = New Decimal(New Integer() {32000, 0, 0, 0})
        Me.WaterHeightSpin.Minimum = New Decimal(New Integer() {32, 0, 0, 0})
        Me.WaterHeightSpin.Name = "WaterHeightSpin"
        Me.WaterHeightSpin.Size = New System.Drawing.Size(62, 20)
        Me.WaterHeightSpin.TabIndex = 2
        Me.WaterHeightSpin.Value = New Decimal(New Integer() {32, 0, 0, 0})
        '
        'WaterWidthLabel
        '
        Me.WaterWidthLabel.AutoSize = True
        Me.WaterWidthLabel.Location = New System.Drawing.Point(6, 21)
        Me.WaterWidthLabel.Name = "WaterWidthLabel"
        Me.WaterWidthLabel.Size = New System.Drawing.Size(38, 13)
        Me.WaterWidthLabel.TabIndex = 1
        Me.WaterWidthLabel.Text = "Width:"
        '
        'WaterWidthSpin
        '
        Me.WaterWidthSpin.Increment = New Decimal(New Integer() {32, 0, 0, 0})
        Me.WaterWidthSpin.Location = New System.Drawing.Point(50, 19)
        Me.WaterWidthSpin.Maximum = New Decimal(New Integer() {32000, 0, 0, 0})
        Me.WaterWidthSpin.Minimum = New Decimal(New Integer() {32, 0, 0, 0})
        Me.WaterWidthSpin.Name = "WaterWidthSpin"
        Me.WaterWidthSpin.Size = New System.Drawing.Size(62, 20)
        Me.WaterWidthSpin.TabIndex = 1
        Me.WaterWidthSpin.Value = New Decimal(New Integer() {32, 0, 0, 0})
        '
        'LiquidsWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(142, 122)
        Me.Controls.Add(Me.WaterSizeBox)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "LiquidsWindow"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Water"
        Me.WaterSizeBox.ResumeLayout(False)
        Me.WaterSizeBox.PerformLayout()
        CType(Me.WaterHeightSpin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WaterWidthSpin, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents WaterSizeBox As GroupBox
    Friend WithEvents QuicksandCheck As CheckBox
    Friend WithEvents WaterHeightLabel As Label
    Friend WithEvents WaterHeightSpin As NumericUpDown
    Friend WithEvents WaterWidthLabel As Label
    Friend WithEvents WaterWidthSpin As NumericUpDown
End Class
