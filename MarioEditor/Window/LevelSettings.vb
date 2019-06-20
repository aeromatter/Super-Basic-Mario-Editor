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

        For sections = 1 To 21
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

        Select Case SectionsComboBox.SelectedIndex + 1
            Case 1
                ScrollToSectionCenter(New Point(-200000, -200000))
            Case 2
                ScrollToSectionCenter(New Point(-180000, -180000))
            Case 3
                ScrollToSectionCenter(New Point(-160000, -160000))
            Case 4
                ScrollToSectionCenter(New Point(-140000, -140000))
            Case 5
                ScrollToSectionCenter(New Point(-120000, -120000))
            Case 6
                ScrollToSectionCenter(New Point(-100000, -100000))
            Case 7
                ScrollToSectionCenter(New Point(-80000, -80000))
            Case 8
                ScrollToSectionCenter(New Point(-60000, -60000))
            Case 9
                ScrollToSectionCenter(New Point(-40000, -40000))
            Case 10
                ScrollToSectionCenter(New Point(-20000, -20000))
            Case 11
                ScrollToSectionCenter(New Point(0, 0))
            Case 12
                ScrollToSectionCenter(New Point(20000, 20000))
            Case 13
                ScrollToSectionCenter(New Point(40000, 40000))
            Case 14
                ScrollToSectionCenter(New Point(60000, 60000))
            Case 15
                ScrollToSectionCenter(New Point(80000, 80000))
            Case 16
                ScrollToSectionCenter(New Point(100000, 100000))
            Case 17
                ScrollToSectionCenter(New Point(120000, 120000))
            Case 18
                ScrollToSectionCenter(New Point(140000, 140000))
            Case 19
                ScrollToSectionCenter(New Point(160000, 160000))
            Case 20
                ScrollToSectionCenter(New Point(180000, 180000))
            Case 21
                ScrollToSectionCenter(New Point(200000, 200000))
        End Select
    End Sub

    Private Sub ScrollToSectionCenter(location As Point)
        LevelWindow.HorizontalScroll.Maximum = LevelWindow.AutoScrollMinSize.Width
        LevelWindow.VerticalScroll.Maximum = LevelWindow.AutoScrollMinSize.Height

        location.Offset(419998 * 0.5, 419998 * 0.5)
        LevelWindow.HorizontalScroll.Value = location.X
        LevelWindow.VerticalScroll.Value = location.Y
        LevelWindow.PerformLayout()
    End Sub
End Class