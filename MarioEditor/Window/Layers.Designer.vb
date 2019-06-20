<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Layers
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
        Me.layerNameBox = New System.Windows.Forms.TextBox()
        Me.LayersCheckedList = New System.Windows.Forms.CheckedListBox()
        Me.AddLayerButton = New System.Windows.Forms.Button()
        Me.RemoveLayerButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'layerNameBox
        '
        Me.layerNameBox.Location = New System.Drawing.Point(12, 12)
        Me.layerNameBox.Name = "layerNameBox"
        Me.layerNameBox.Size = New System.Drawing.Size(260, 20)
        Me.layerNameBox.TabIndex = 0
        '
        'LayersCheckedList
        '
        Me.LayersCheckedList.FormattingEnabled = True
        Me.LayersCheckedList.Location = New System.Drawing.Point(12, 38)
        Me.LayersCheckedList.Name = "LayersCheckedList"
        Me.LayersCheckedList.Size = New System.Drawing.Size(260, 184)
        Me.LayersCheckedList.TabIndex = 1
        '
        'AddLayerButton
        '
        Me.AddLayerButton.Location = New System.Drawing.Point(12, 226)
        Me.AddLayerButton.Name = "AddLayerButton"
        Me.AddLayerButton.Size = New System.Drawing.Size(75, 23)
        Me.AddLayerButton.TabIndex = 2
        Me.AddLayerButton.Text = "Add"
        Me.AddLayerButton.UseVisualStyleBackColor = True
        '
        'RemoveLayerButton
        '
        Me.RemoveLayerButton.Location = New System.Drawing.Point(197, 226)
        Me.RemoveLayerButton.Name = "RemoveLayerButton"
        Me.RemoveLayerButton.Size = New System.Drawing.Size(75, 23)
        Me.RemoveLayerButton.TabIndex = 3
        Me.RemoveLayerButton.Text = "Remove"
        Me.RemoveLayerButton.UseVisualStyleBackColor = True
        '
        'Layers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.RemoveLayerButton)
        Me.Controls.Add(Me.AddLayerButton)
        Me.Controls.Add(Me.LayersCheckedList)
        Me.Controls.Add(Me.layerNameBox)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Layers"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Layers"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents layerNameBox As TextBox
    Friend WithEvents LayersCheckedList As CheckedListBox
    Friend WithEvents AddLayerButton As Button
    Friend WithEvents RemoveLayerButton As Button
End Class
