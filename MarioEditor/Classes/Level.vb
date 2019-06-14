Imports System.IO
Public Class Level
    <Flags()>
    Enum SectionSettings
        None = 0
        LevelWrap = 1
        OffscreenExit = 2
        NoTurnback = 4
        Underwater = 8
    End Enum

    Public Structure Section
        Public settings As SectionSettings
        Public background As SectionBackground
        Public music As String
        Public bounds As Rectangle
        Public blocks As List(Of Block)
        Public bgos As List(Of BGO)
        Public npcs As List(Of NPCsets)
    End Structure

    Public Structure SectionBackground
        Public primaryBackground As String
        Public secondaryBackground As String
        Public backgroundStyle As Integer
        Public primaryImage As Image
        Public secondaryImage As Image
    End Structure

    Public Shared Music As String = ""
    Public Shared HeightInc As Integer = 1
    Public Shared LevelPath As String = Main.GetGamePath() & "\worlds\"
    Public Shared P1start As Rectangle
    Public Shared P2start As Rectangle

    Private Sections(21) As Section
    Public Shared LastSectionSelected As Integer
    Private Settings As SectionSettings
    Public SectionBounds As New Rectangle(0, 0, 25 * 32, 18 * 32)
    Public Shared Background As New SectionBackground
    Private parseOutput As Dictionary(Of String, String) = New Dictionary(Of String, String)
    Private primaryBackgroundName As String = String.Empty
    Private secondaryBackgroundName As String = String.Empty

    Public Sub LoadSection(index As Integer)
        SetSection(LastSectionSelected)
        GetSection(index)
        LastSectionSelected = index
    End Sub

    Public Sub SetSection(index)
        Dim sect As New Section
        sect.blocks = Blocks.Tiles
        sect.bgos = Backgrounds.BGOs
        sect.npcs = NPC.NPCsets
        sect.settings = Settings
        sect.music = Music
        sect.background = Background
        sect.bounds = SectionBounds

        Sections(index) = sect
    End Sub

    Public Sub GetSection(index As Integer)
        If Sections(index).blocks IsNot Nothing Then
            Blocks.Tiles = Sections(index).blocks
        Else
            Blocks.Tiles = New List(Of Block)
        End If

        If Sections(index).bgos IsNot Nothing Then
            Backgrounds.BGOs = Sections(index).bgos
        Else
            Backgrounds.BGOs = New List(Of BGO)
        End If

        If Sections(index).npcs IsNot Nothing Then
            NPC.NPCsets = Sections(index).npcs
        Else
            NPC.NPCsets = New List(Of NPCsets)
        End If

        Settings = Sections(index).settings
        Music = Sections(index).music
        Background = Sections(index).background
        SectionBounds = Sections(index).bounds

        ApplySectionSettings()
    End Sub

    Private Sub ApplySectionSettings()
        Audio.LoopMusic(Music)
        SetSectionBounds(SectionBounds)
        ToggleSettings(Settings)
        LevelWindow.Refresh()
    End Sub

    Public Sub ToggleSettings(input As SectionSettings)
        Settings = input
    End Sub

    Public Sub SetSectionBounds(bounds As Rectangle)
        If bounds.Width < (25 * 32) Then
            bounds.Width = (25 * 32)
        End If

        If bounds.Height < (18 * 32) Then
            bounds.Height = (18 * 32)
        End If
        SectionBounds = bounds

        LevelWindow.AutoScrollMinSize = New Size(bounds.Width, bounds.Height)
    End Sub

    Public Sub ReadBackgroundConfigs(ByVal backgroundID As Integer)
        Dim openBackgroundProperties As StreamReader
        parseOutput.Clear()
        openBackgroundProperties = New StreamReader(String.Format("{0}\configs\background2\background2-{1}.ini", Main.GetGamePath(), backgroundID), FileMode.Open)

        While Not openBackgroundProperties.EndOfStream
            Dim parse As String = openBackgroundProperties.ReadLine()
            Dim readInput() As String

            If parse.Contains("=") Then
                readInput = parse.Split("=")
                Dim key As String = readInput(0).Trim(Chr(34), Chr(32))
                Dim value As String = readInput(1).Trim(Chr(34), Chr(32))

                parseOutput.Add(key, value)
            End If
        End While

        openBackgroundProperties.Close()
        openBackgroundProperties.Dispose()

        SetBackgroundInfo()
    End Sub

    Private Sub SetBackgroundInfo()
        For Each kv As KeyValuePair(Of String, String) In parseOutput
            If kv.Key = "image" Then
                primaryBackgroundName = kv.Value
            End If

            If kv.Key = "second-image" Then
                secondaryBackgroundName = kv.Value
            End If
        Next

        SetSectionBackground()
    End Sub

    Private Sub SetSectionBackground()
        Background.backgroundStyle = 1
        Background.primaryBackground = primaryBackgroundName
        Background.secondaryBackground = secondaryBackgroundName

        Dim bgStream As FileStream
        Try
            bgStream = New FileStream(String.Format("{0}\graphics\background2\{1}", Main.GetGamePath(), primaryBackgroundName), FileMode.Open)
            Background.primaryImage = Image.FromStream(bgStream)
            bgStream.Close()
            bgStream.Dispose()

            If Not Background.secondaryBackground = "" Then
                bgStream = New FileStream(String.Format("{0}\graphics\background2\{1}", Main.GetGamePath(), secondaryBackgroundName), FileMode.Open)
                Background.secondaryImage = Image.FromStream(bgStream)
                bgStream.Close()
                bgStream.Dispose()
            End If
        Catch ex As Exception
            LevelWindow.BackColor = Color.Black
        End Try

        LevelWindow.Refresh()
    End Sub

    Public Function PrimaryBGMaxDrawTimesX() As Integer
        Return (SectionBounds.Width / Background.primaryImage.Width) * 2
    End Function

    Public Function SecondaryBGMaxDrawTimesX() As Integer
        Return (SectionBounds.Width / Background.secondaryImage.Width) * 2
    End Function

    Public Function PrimaryBGMaxDrawTimesY() As Integer
        Return (SectionBounds.Height / Background.primaryImage.Height) * 2
    End Function

    Public Function PrimaryBGLocation(ByVal x As Integer) As Rectangle
        Return New Rectangle(x * Background.primaryImage.Width, SectionBounds.Height - Background.primaryImage.Height, Background.primaryImage.Width, Background.primaryImage.Height)
    End Function

    Public Function SecondaryBGLocation(ByVal x As Integer) As Rectangle
        Return New Rectangle(x * Background.secondaryImage.Width, SectionBounds.Height - (Background.primaryImage.Height + Background.primaryImage.Height), Background.secondaryImage.Width, Background.primaryImage.Height)
    End Function
End Class
