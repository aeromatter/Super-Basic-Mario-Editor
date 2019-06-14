Imports System.IO
Public Class LevelSettings

    Private Sub Level_Manager_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For i = 0 To BackgroundImages.Images.Count - 1
            BackgroundsList.Items.Add(String.Format("background-{0}.png", i + 1), i)
        Next

        Dim musicDirectory As String = String.Format("{0}\music\", Main.GetGamePath)
        For Each file As String In My.Computer.FileSystem.GetFiles(musicDirectory)
            MusicComboBox.Items.Add(Path.GetFileName(file))
        Next

        For sections = 0 To 21
            SectionsComboBox.Items.Add(String.Format("Section {0}", sections))
        Next

        SectionsComboBox.Text = SectionsComboBox.Items(0).ToString

        LevelWidthSpin.Value = LevelWindow.LevelData.SectionBounds.Width / 32
        LevelHeightSpin.Value = LevelWindow.LevelData.SectionBounds.Height / 32

    End Sub

    Private Sub MusicComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles MusicComboBox.SelectedIndexChanged
        Audio.PlayMusic(MusicComboBox.SelectedItem)
        Level.Music = MusicComboBox.SelectedText
    End Sub

    Private Sub BackgroundsList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles BackgroundsList.SelectedIndexChanged
        For Each i As ListViewItem In BackgroundsList.SelectedItems
            If i.Focused Then
                LevelWindow.LevelData.ReadBackgroundConfigs(BackgroundsList.Items.IndexOf(i) + 1)
            End If
        Next
    End Sub

    Private Sub P1Button_Click(sender As Object, e As EventArgs) Handles P1Button.Click
        ObjectPlacement.EditMode = 3
        Dim Align = New ObjectPlacement.ObjectAlignment(4, 32)
    End Sub

    Private Sub P2Button_Click(sender As Object, e As EventArgs) Handles P2Button.Click
        ObjectPlacement.EditMode = 4
        Dim Align = New ObjectPlacement.ObjectAlignment(4, 32)
    End Sub

    Private Sub UpdateLevelButton_Click(sender As Object, e As EventArgs) Handles UpdateLevelButton.Click
        Try
            If LevelWidthSpin.Value * 32 > LevelWindow.Width / 32 And LevelHeightSpin.Value * 32 > LevelWindow.Height / 32 Then
                LevelWindow.LevelData.SetSectionBounds(New Rectangle(0, 0, LevelWidthSpin.Value * 32, LevelHeightSpin.Value * 32))

                Level.HeightInc = ((LevelWindow.LevelData.SectionBounds.Height - (19 * 32)) + 32) / 32

                LevelWindow.Update()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub WrapCheck_CheckedChanged(sender As Object, e As EventArgs) Handles WrapCheck.CheckedChanged
        SetSectionProperties()
    End Sub

    Private Sub OffscreenCheck_CheckedChanged(sender As Object, e As EventArgs) Handles OffscreenCheck.CheckedChanged
        SetSectionProperties()
    End Sub

    Private Sub NoTurnbackCheck_CheckedChanged(sender As Object, e As EventArgs) Handles NoTurnbackCheck.CheckedChanged
        SetSectionProperties()
    End Sub

    Private Sub UnderwaterCheck_CheckedChanged(sender As Object, e As EventArgs) Handles UnderwaterCheck.CheckedChanged
        SetSectionProperties()
    End Sub

    Private Sub SetSectionProperties()
        If WrapCheck.Checked Then
            LevelWindow.LevelData.ToggleSettings(Level.SectionSettings.LevelWrap)
        End If

        If OffscreenCheck.Checked Then
            LevelWindow.LevelData.ToggleSettings(Level.SectionSettings.OffscreenExit)
        End If

        If NoTurnbackCheck.Checked Then
            LevelWindow.LevelData.ToggleSettings(Level.SectionSettings.NoTurnback)
        End If

        If UnderwaterCheck.Checked Then
            LevelWindow.LevelData.ToggleSettings(Level.SectionSettings.Underwater)
        End If
    End Sub

    Private Sub SectionsComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles SectionsComboBox.SelectedIndexChanged
        LevelWindow.LevelData.LoadSection(SectionsComboBox.SelectedIndex)
    End Sub
End Class