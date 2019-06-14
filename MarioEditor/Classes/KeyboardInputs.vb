Imports System.Windows.Input

Public Class KeyboardInputs
    Private Audio As Audio
    Public Shared Function GetKeyStates(key As Key) As KeyStates
        Return key
    End Function

    Public Sub KeyboardControl()
        'Begin Testing
        If (Keyboard.GetKeyStates(Key.F5) And KeyStates.Down) > 0 Then
            Select Case MsgBox("Do you want to save the level first? Any unsaved changes will be lost.", MsgBoxStyle.YesNoCancel)
                Case MsgBoxResult.Yes
                    'Dim sf As New SaveFiles
                    'sf.VSMBXSave()
                    Audio = New Audio
                    Audio.PlaySound("has-item")
                Case MsgBoxResult.No
                    Audio = New Audio
                    Audio.PlaySound("has-item")
            End Select
        End If

        If ((Keyboard.GetKeyStates(Key.LeftCtrl) And Keyboard.GetKeyStates(Key.Q)) And KeyStates.Down) > 0 Then
            MainWindow.Close()
        End If

        If ((Keyboard.GetKeyStates(Key.LeftCtrl) And Keyboard.GetKeyStates(Key.S)) And KeyStates.Down) > 0 Then
            MainWindow.SaveLevelFileDialog.Filter = "Level Files|*.vlvl"
            MainWindow.SaveLevelFileDialog.InitialDirectory = Main.GetGamePath() & "\Worlds\"
            MainWindow.SaveLevelFileDialog.Title = "Save Level"

            MainWindow.SaveLevelFileDialog.ShowDialog()
        End If

        If ((Keyboard.GetKeyStates(Key.LeftCtrl) And Keyboard.GetKeyStates(Key.O)) And KeyStates.Down) > 0 Then
            MainWindow.OpenLevelFileDialog.Filter = "Level Files|*.vlvl"
            MainWindow.OpenLevelFileDialog.InitialDirectory = Main.GetGamePath() & "\Worlds\"
            MainWindow.OpenLevelFileDialog.Title = "Open Level"
            MainWindow.OpenLevelFileDialog.FileName = ""

            MainWindow.OpenLevelFileDialog.ShowDialog()
        End If

        If ((Keyboard.GetKeyStates(Key.LeftCtrl) And Keyboard.GetKeyStates(Key.N)) And KeyStates.Down) > 0 Then
            Blocks.Tiles.Clear()
            Blocks.TileRects.Clear()
            Backgrounds.BGOs.Clear()
            Backgrounds.bgorects.Clear()
            NPC.NPCsets.Clear()
            NPC.NPCrects.Clear()
            Level.Music = ""
            Level.P1start = Nothing
            Level.P2start = Nothing
            Blocks.fillq.Clear()
            LevelWindow.Invalidate()

            Audio = New Audio
            Audio.PlaySound("smash")
        End If
    End Sub
End Class
