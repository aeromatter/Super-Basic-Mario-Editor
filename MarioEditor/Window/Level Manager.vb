Imports System.IO
Public Class Level_Manager
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
    End Sub

    Private Sub MusicComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles MusicComboBox.SelectedIndexChanged
        Audio.PlayMusic(MusicComboBox.SelectedItem)
    End Sub

    Private Sub BackgroundsList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles BackgroundsList.SelectedIndexChanged
        Dim main As New Main
        For Each i As ListViewItem In BackgroundsList.SelectedItems
            If i.Focused Then
                main.GetBackgroundInfo(BackgroundsList.Items.IndexOf(i) + 1)
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
                Level.LevelW = LevelWidthSpin.Value * 32
                Level.LevelH = LevelHeightSpin.Value * 32

                LevelWindow.AutoScrollMinSize = New Size(Level.LevelW, Level.LevelH)

                Level.HeightInc = ((Level.LevelH - (19 * 32)) + 32) / 32
                LevelWindow.Update()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub
End Class