Imports System.IO

Public Class MainWindow

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        autoalignCheckBox.Checked = True

        LevelWindow.MdiParent = Me
        LevelWindow.Show()

        Layers.CreateDefaultLayers()
        EventsWindow.CreateDefaultEvents()
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles BlocksButton.Click
        ObjectPlacement.EditMode = 0

        BlocksAndTiles.MdiParent = Me
        BlocksAndTiles.Location = New Point(0, LevelWindow.Height)

        LevelSettings.Hide()
        BlocksAndTiles.Show()
        BGOs_Form.Hide()
        NPCs.Hide()
        BlocksAndTiles.Focus()
    End Sub

    Private Sub DebuggerToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles DebuggerToolStripMenuItem.Click
        Debug.MdiParent = Me
        Debug.Show()
    End Sub

    Private Sub SaveFileDialog1_FileOk(sender As System.Object, e As System.ComponentModel.CancelEventArgs) Handles SaveLevelFileDialog.FileOk
        Level.LevelPath = SaveLevelFileDialog.FileName
        ''Dim sf As New SaveFiles
        ''sf.VSMBXSave()
        Dim saveLevel As New LevelFile
        saveLevel.SaveLevelAsXML()

        Dim Audio = New Audio
        Audio.PlaySound("has-item")
    End Sub

    Private Sub OpenToolStripMenuItem3_Click(sender As System.Object, e As System.EventArgs) Handles OpenToolStripMenuItem3.Click
        OpenLevelFileDialog.Filter = "Level Files|*.xml"
        OpenLevelFileDialog.InitialDirectory = Main.GetGamePath() & "\worlds\"
        OpenLevelFileDialog.Title = "Open Level"

        OpenLevelFileDialog.FileName = ""

        OpenLevelFileDialog.ShowDialog()
    End Sub

    Private Sub SaveToolStripMenuItem3_Click(sender As System.Object, e As System.EventArgs) Handles SaveToolStripMenuItem3.Click
        SaveLevelFileDialog.Filter = "Level Files|*.xml"
        SaveLevelFileDialog.InitialDirectory = Main.GetGamePath() & "\worlds\"
        SaveLevelFileDialog.Title = "Save Level"

        SaveLevelFileDialog.FileName = ""

        SaveLevelFileDialog.ShowDialog()
    End Sub

    Private Sub OpenFileDialog1_FileOk(sender As System.Object, e As System.ComponentModel.CancelEventArgs) Handles OpenLevelFileDialog.FileOk
        Level.LevelPath = OpenLevelFileDialog.FileName
        Dim loadLevel As New LevelFile
        loadLevel.LoadLevelFromXML()
    End Sub

    Private Sub Button6_Click(sender As System.Object, e As System.EventArgs) Handles levelSettingsButton.Click
        ObjectPlacement.EditMode = 7
        'LevelSettings.MdiParent = Me

        If LevelWindow.PlayerGraphic Is Nothing And LevelWindow.Player2Graphic Is Nothing And Directory.Exists(Main.GetGamePath() & "\graphics\mario\") And Directory.Exists(Main.GetGamePath() & "\graphics\luigi\") Then
            LevelWindow.PlayerGraphic = New Bitmap(Main.GetGamePath() & "\graphics\mario\mario-2.png")
            LevelWindow.Player2Graphic = New Bitmap(Main.GetGamePath() & "\graphics\luigi\luigi-2.png")
        End If

        'LevelSettings.Location = New Point(0, LevelWindow.Height)
        'LevelSettings.Show()
        LevelSettings.MdiParent = Me
        LevelSettings.Location = New Point(0, LevelWindow.Height)
        LevelSettings.Show()
        BlocksAndTiles.Hide()
        BGOs_Form.Hide()
        NPCs.Hide()
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles EraserButton.Click
        ObjectPlacement.EditMode = 1
        LevelSettings.Hide()
        BlocksAndTiles.Hide()
        BGOs_Form.Hide()
        NPCs.Hide()
    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles BGOsButton.Click
        BGOs_Form.MdiParent = Me
        BGOs_Form.Location = New Point(0, LevelWindow.Height)

        LevelSettings.Hide()
        BlocksAndTiles.Hide()
        BGOs_Form.Show()
        NPCs.Hide()
        ObjectPlacement.EditMode = 2
    End Sub

    Private Sub NewToolStripMenuItem3_Click(sender As System.Object, e As System.EventArgs) Handles NewToolStripMenuItem3.Click
        Blocks.Tiles.Clear()
        Blocks.TileRects.Clear()
        Backgrounds.BGOs.Clear()
        Backgrounds.bgorects.Clear()
    End Sub

    Private Sub ExitToolStripMenuItem3_Click(sender As System.Object, e As System.EventArgs) Handles ExitToolStripMenuItem3.Click
        Close()
    End Sub

    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles NPCsButton.Click
        NPCs.MdiParent = Me
        NPCs.Location = New Point(0, LevelWindow.Height)

        LevelSettings.Hide()
        BlocksAndTiles.Hide()
        BGOs_Form.Hide()
        NPCs.Show()
        ObjectPlacement.EditMode = 5
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles SelectionButton.Click
        ObjectPlacement.EditMode = 6

        LevelSettings.Hide()
        BlocksAndTiles.Hide()
        BGOs_Form.Hide()
        NPCs.Hide()
    End Sub

    Private Sub TestLevel1upF5ToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles TestLevel1upF5ToolStripMenuItem.Click
        Select Case MsgBox("Do you want to save the level first? Any unsaved changes will be lost.", MsgBoxStyle.YesNoCancel)
            Case MsgBoxResult.Yes
                Dim Audio = New Audio
                Audio.PlaySound("has-item")
            Case MsgBoxResult.No
                Dim Audio = New Audio
                Audio.PlaySound("has-item")
        End Select
    End Sub

    Private Sub DebuggerCtrlDToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles DebuggerCtrlDToolStripMenuItem.Click
        Debug.MdiParent = Me
        Debug.Location = New Point(LevelWindow.Width, 0)

        Debug.Show()
    End Sub

    Private Sub TestSettingsCtrlTToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles TestSettingsCtrlTToolStripMenuItem.Click
        TestSettings.MdiParent = Me
        TestSettings.Location = New Point(LevelWindow.Width, 0)

        TestSettings.Show()
    End Sub

    Private Sub GridCtrlGToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GridCtrlGToolStripMenuItem.Click
        Grid.Show()
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles autoalignCheckBox.CheckedChanged
        If autoalignCheckBox.CheckState = CheckState.Checked Then
            ObjectPlacement.AlignFactor = 32
        Else
            ObjectPlacement.AlignFactor = 1
        End If
    End Sub

    Private Sub LayersCtrlLToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LayersCtrlLToolStripMenuItem.Click
        Layers.MdiParent = Me
        Layers.Location = New Point(LevelWindow.Width, 0)
        Layers.Show()
    End Sub

    Private Sub EventsCtrlEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EventsCtrlEToolStripMenuItem.Click
        EventsWindow.MdiParent = Me
        EventsWindow.Location = New Point(LevelWindow.Width, 0)
        EventsWindow.Show()
    End Sub
End Class