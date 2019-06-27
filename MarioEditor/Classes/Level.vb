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
        Public levelWrap As Boolean
        Public offscreenExit As Boolean
        Public noTurnBack As Boolean
        Public underWater As Boolean
        Public background As SectionBackground
        Public music As String
        Public bounds As Rectangle
    End Structure

    Public Structure SectionBackground
        Public ID As Integer
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

    Public Shared Sections(21) As Section
    Public Shared LastSectionSelected As Integer
    Private Settings As SectionSettings
    Public Shared levelWrap As Boolean
    Public Shared offscreenExit As Boolean
    Public Shared noTurnBack As Boolean
    Public Shared underWater As Boolean
    Public SectionBounds As New Rectangle(0, 0, 25 * 32, 19 * 32)
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
        sect.settings = Settings
        sect.levelWrap = levelWrap
        sect.offscreenExit = offscreenExit
        sect.noTurnBack = noTurnBack
        sect.underWater = underWater
        sect.music = Music
        sect.background = Background
        sect.bounds = GetDefaultSectionLocations(index)
        Sections(index) = sect
    End Sub

    Public Sub GetSection(index As Integer)
        Settings = Sections(index).settings
        levelWrap = Sections(index).levelWrap
        offscreenExit = Sections(index).offscreenExit
        noTurnBack = Sections(index).noTurnBack
        underWater = Sections(index).underWater
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

    Public Sub SetDefaultSections()
        For i = 1 To 21
            SetSection(i)
        Next
    End Sub

    Private Function GetDefaultSectionLocations(index As Integer) As Rectangle
        Select Case index
            Case 1
                Return New Rectangle(-200000, -200000, 800, 600)
            Case 2
                Return New Rectangle(-180000, -180000, 800, 600)
            Case 3
                Return New Rectangle(-160000, -160000, 800, 600)
            Case 4
                Return New Rectangle(-140000, -140000, 800, 600)
            Case 5
                Return New Rectangle(-120000, -120000, 800, 600)
            Case 6
                Return New Rectangle(-100000, -100000, 800, 600)
            Case 7
                Return New Rectangle(-80000, -80000, 800, 600)
            Case 8
                Return New Rectangle(-60000, -60000, 800, 600)
            Case 9
                Return New Rectangle(-40000, -40000, 800, 600)
            Case 10
                Return New Rectangle(-20000, -20000, 800, 600)
            Case 11
                Return New Rectangle(0, 0, 800, 600)
            Case 12
                Return New Rectangle(20000, 20000, 800, 600)
            Case 13
                Return New Rectangle(40000, 40000, 800, 600)
            Case 14
                Return New Rectangle(60000, 60000, 800, 600)
            Case 15
                Return New Rectangle(80000, 80000, 800, 600)
            Case 16
                Return New Rectangle(100000, 100000, 800, 600)
            Case 17
                Return New Rectangle(120000, 120000, 800, 600)
            Case 18
                Return New Rectangle(140000, 140000, 800, 600)
            Case 19
                Return New Rectangle(160000, 160000, 800, 600)
            Case 20
                Return New Rectangle(180000, 180000, 800, 600)
            Case 21
                Return New Rectangle(200000, 200000, 800, 600)
        End Select

    End Function

    Public Sub ToggleSettings(input As SectionSettings)
        Settings = input
    End Sub

    Public Sub SetSectionBounds(bounds As Rectangle)
        If bounds.Width < (25 * 32) Then
            bounds.Width = (25 * 32)
        End If

        If bounds.Height < (19 * 32) Then
            bounds.Height = (19 * 32)
        End If
        SectionBounds = bounds

        LevelWindow.AutoScrollMinSize = New Size(419998, 419998)

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
