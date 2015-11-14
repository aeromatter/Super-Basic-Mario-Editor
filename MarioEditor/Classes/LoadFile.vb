Imports System.IO

Public Class LoadFile

    Public Shared Sub LoadFromVSMBX(Path As String)

        Dim RC As RectangleConverter
        RC = New RectangleConverter

        Blocks.Tiles.Clear()
        Blocks.TileRects.Clear()
        Backgrounds.BGOs.Clear()
        Backgrounds.bgorects.Clear()
        NPC.NPCsets.Clear()
        NPC.NPCrects.Clear()

        Dim fs As New System.IO.FileStream(Path, FileMode.Open)
        Dim sr As New StreamReader(fs)

        Dim ParseInput As String = ""
        Dim ParseOutput() As String

        'TODO: Treat as ext data.
        'Level.LevelW = sr.ReadLine()
        'Level.LevelH = sr.ReadLine()

        ParseInput = sr.ReadLine()
        ParseOutput = ParseInput.Split("|")

        For x = 0 To ParseOutput.Count - 1
            Select Case True
                Case ParseOutput(x).StartsWith("LW")
                    Level.LevelW = ParseOutput(x).Substring(3)
                Case ParseOutput(x).StartsWith("LH")
                    Level.LevelH = ParseOutput(x).Substring(3)
            End Select
        Next

        ParseInput = sr.ReadLine()
        'ParseInput = Mid(ParseInput, 2, ParseInput.Length - 2)
        ParseOutput = ParseInput.Split("|")

        For x = 0 To ParseOutput.Count - 1
            Select Case True
                Case ParseOutput(x).StartsWith("OE")
                    Level.OffscreenExit = ParseOutput(x).Substring(3)
                Case ParseOutput(x).StartsWith("WR")
                    Level.LevelWrap = ParseOutput(x).Substring(3)
                Case ParseOutput(x).StartsWith("NB")
                    Level.NoTurnBack = ParseOutput(x).Substring(3)
                Case ParseOutput(x).StartsWith("UW")
                    Level.Underwater = ParseOutput(x).Substring(3)
            End Select
        Next

        ParseInput = sr.ReadLine()
        'ParseInput = Mid(ParseInput, 2, ParseInput.Length - 2)
        ParseOutput = ParseInput.Split("|")

        'Level.P1start = RC.ConvertFromString(ParseOutput(0).Substring(3))
        'Level.P2start = RC.ConvertFromString(ParseOutput(1).Substring(3))

        For x = 0 To ParseOutput.Count - 1
            Select Case True
                Case ParseOutput(x).StartsWith("P1")
                    Level.P1start = RC.ConvertFromString(ParseOutput(x).Substring(3))
                Case ParseOutput(x).StartsWith("P2")
                    Level.P2start = RC.ConvertFromString(ParseOutput(x).Substring(3))
            End Select
        Next

        ParseInput = sr.ReadLine()
        'ParseInput = Mid(ParseInput, 2, ParseInput.Length - 2)
        ParseOutput = ParseInput.Split("|")

        'Level.Time = ParseOutput(0).Substring(2)
        'Play.GravityLevel = ParseOutput(1).Substring(3)
        'Level.Brightness = ParseOutput(2).Substring(2)

        For x = 0 To ParseOutput.Count - 1
            Select Case True
                Case ParseOutput(x).StartsWith("T")
                    Level.Time = ParseOutput(x).Substring(2)
                Case ParseOutput(x).StartsWith("GL")
                    Play.GravityLevel = ParseOutput(x).Substring(3)
                Case ParseOutput(x).StartsWith("B:")
                    Level.Brightness = ParseOutput(x).Substring(2)
                Case ParseOutput(x).StartsWith("BG")
                    Dim bg As String() = ParseOutput(x).Substring(3).Split(",")
                    Level.BGid = bg(0)
                    Level.BG2id = bg(1)
                Case ParseOutput(x).StartsWith("MU")
                    Level.MusicID = ParseOutput(x).Substring(3)
            End Select
        Next
        '''''

        Dim CurTag As String = ""
        CurTag = sr.ReadLine()

        'Dim BlockTags As String() = {"ID", "IT", "X", "Y", "S", "I", "W", "H", "A", "R", "G", "B", "BR", "FS", "GW", "GH", "GL", "LV", "SW", "SH", "TF"}



        While sr.Peek() > -1
            Select Case CurTag
                Case "*BLOCKS*"
                    ParseInput = sr.ReadLine()

                    Dim b As New Block

                    If ParseInput IsNot String.Format("*{0}*", "BGOS", "NPCS") Then
                        ParseOutput = ParseInput.Split("|")
                    Else
                        CurTag = ParseInput
                    End If

                    b.R = 255
                    b.G = 255
                    b.B = 255
                    b.Glow = 100
                    b.Width = 32
                    b.Height = 32
                    b.gfxWidth = 32
                    b.gfxHeight = 32

                    For i = 0 To ParseOutput.Count - 1
                        Select Case True
                            Case ParseOutput(i).StartsWith("ID:")
                                b.ID = ParseOutput(i).Substring(3)
                            Case ParseOutput(i).StartsWith("IT:")
                                b.ContainItem = ParseOutput(i).Substring(3)
                            Case ParseOutput(i).StartsWith("X:")
                                b.X = ParseOutput(i).Substring(2)
                            Case ParseOutput(i).StartsWith("Y:")
                                b.Y = ParseOutput(i).Substring(2)
                            Case ParseOutput(i).StartsWith("S:")
                                b.Slip = ParseOutput(i).Substring(2)
                            Case ParseOutput(i).StartsWith("I:")
                                b.Invisible = ParseOutput(i).Substring(2)
                            Case ParseOutput(i).StartsWith("W:")
                                b.Width = ParseOutput(i).Substring(2)
                            Case ParseOutput(i).StartsWith("H:")
                                b.Height = ParseOutput(i).Substring(2)
                            Case ParseOutput(i).StartsWith("A:")
                                b.Animated = ParseOutput(i).Substring(2)
                            Case ParseOutput(i).StartsWith("R:")
                                b.R = ParseOutput(i).Substring(2)
                            Case ParseOutput(i).StartsWith("G:")
                                b.G = ParseOutput(i).Substring(2)
                            Case ParseOutput(i).StartsWith("B:")
                                b.B = ParseOutput(i).Substring(2)
                            Case ParseOutput(i).StartsWith("BR:")
                                b.Breakable = ParseOutput(i).Substring(3)
                            Case ParseOutput(i).StartsWith("FS:")
                                b.FrameSpeed = ParseOutput(i).Substring(3)
                            Case ParseOutput(i).StartsWith("GW:")
                                b.gfxWidth = ParseOutput(i).Substring(3)
                            Case ParseOutput(i).StartsWith("GH:")
                                b.gfxHeight = ParseOutput(i).Substring(3)
                            Case ParseOutput(i).StartsWith("GL:")
                                b.Glow = ParseOutput(i).Substring(3)
                            Case ParseOutput(i).StartsWith("LV:")
                                b.Lava = ParseOutput(i).Substring(3)
                            Case ParseOutput(i).StartsWith("SW:")
                                b.SizeW = ParseOutput(i).Substring(3)
                            Case ParseOutput(i).StartsWith("SH:")
                                b.SizeH = ParseOutput(i).Substring(3)
                            Case ParseOutput(i).StartsWith("TF:")
                                b.TotalFrames = ParseOutput(i).Substring(3)
                        End Select

                        b.IMG = Form2.TB.Image

                        b.rectangle = New Rectangle(b.X, b.Y, b.Width, b.Height)
                    Next

                    Blocks.Tiles.Add(b)
                    Blocks.TileRects.Add(b.rectangle)
                Case "*BGOS*"

                Case "*NPCS*"

            End Select
        End While

        sr.Close()
        sr.Dispose()

        For Each n As Block In Blocks.Tiles
            MsgBox(String.Format("R: {0} G: {1} B: {2}", n.R, n.G, n.B))
        Next

        'Level.Music = sr.ReadLine()
        'Level.BGid = sr.ReadLine()

        'LevelSettings.PlayM.StopPlayback()
        'Level.Song = "custom"
        'LevelSettings.SetLevelMusic()

        'Level.LevelW = sr.ReadLine()
        'Level.LevelH = sr.ReadLine()

        'Level.HeightInc = ((Level.LevelH - (19 * 32)) + 32) / 32

        'Main.SetLevelBG(Level.BGid, Level.BG2id)

        'Form2.AutoScrollMinSize = New Size(Level.LevelW, Level.LevelH)

        'Level.LevelWrap = sr.ReadLine()
        'Level.NoTurnBack = sr.ReadLine()
        'Level.OffscreenExit = sr.ReadLine()
        'Level.Underwater = sr.ReadLine()

        'If Player.P1.Graphic Is Nothing And Directory.Exists(Form1.FilePath & "\graphics\mario\") Then
        '    Player.P1.Graphic = New Bitmap(Form1.FilePath & "\graphics\mario\mario-2.png")
        'ElseIf Player.P2.Graphic Is Nothing And Directory.Exists(Form1.FilePath & "\graphics\luigi") Then
        '    Player.P2.Graphic = New Bitmap(Form1.FilePath & "\graphics\luigi\luigi-2.png")
        'End If

        'Level.P1start = RC.ConvertFromString(sr.ReadLine())

        'Play.DrawX = Level.P1start.X
        'Play.DrawY = Level.P1start.Y

        'Level.P2start = RC.ConvertFromString(sr.ReadLine())
        'Level.Time = sr.ReadLine()
        'Play.GravityLevel = sr.ReadLine()
        'Level.Brightness = sr.ReadLine()

        'Dim CurLine As String = ""


        'Dim bg As New BGO
        'Dim n As New NPCsets

        ''TODO: Error checking, and section based loading.

        'CurLine = sr.ReadLine().ToString()
        'If CurLine = "[BLOCK]" Then
        '    CurTag = "[BLOCK]"
        'End If

        'If CurTag = "[BLOCK]" Then
        '    Do While CurTag = "[BLOCK]"

        '        Try
        '            b.Animated = sr.ReadLine()
        '            b.ContainItem = sr.ReadLine()
        '            b.FrameSpeed = sr.ReadLine()
        '            b.gfxHeight = sr.ReadLine()
        '            b.gfxWidth = sr.ReadLine()
        '            b.Height = sr.ReadLine()
        '            b.Width = sr.ReadLine()
        '            b.ID = sr.ReadLine()
        '            b.Invisible = sr.ReadLine()
        '            b.Lava = sr.ReadLine()
        '            b.rectangle = RC.ConvertFromString(sr.ReadLine())
        '            b.SizeH = sr.ReadLine()
        '            b.SizeW = sr.ReadLine()
        '            b.Slip = sr.ReadLine()
        '            b.TotalFrames = sr.ReadLine()
        '            b.X = sr.ReadLine()
        '            b.Y = sr.ReadLine()
        '            b.R = sr.ReadLine()
        '            b.G = sr.ReadLine()
        '            b.B = sr.ReadLine()
        '            b.Glow = sr.ReadLine()
        '            b.Breakable = sr.ReadLine()

        '            Blocks.GetBlock(b.ID)

        '            b.IMG = Form2.TB.Image

        '            Blocks.Tiles.Add(b)
        '            Blocks.TileRects.Add(b.rectangle)
        '        Catch ex As Exception
        '            CurTag = "[BGO]"
        '            Exit Do
        '        End Try
        '    Loop
        'End If

        'If CurTag = "[BGO]" Then
        '    Do While CurTag = "[BGO]"
        '        Try
        '            bg.Animated = sr.ReadLine()
        '            bg.ForeGround = sr.ReadLine()
        '            bg.FrameSpeed = sr.ReadLine()
        '            bg.gfxHeight = sr.ReadLine()
        '            bg.gfxWidth = sr.ReadLine()
        '            bg.Height = sr.ReadLine()
        '            bg.Width = sr.ReadLine()
        '            bg.ID = sr.ReadLine()
        '            bg.rectangle = RC.ConvertFromString(sr.ReadLine())
        '            bg.TotalFrames = sr.ReadLine()
        '            bg.X = sr.ReadLine()
        '            bg.Y = sr.ReadLine()

        '            If bg.ID >= 1 Then
        '                Form2.SelectedBGO = bg.ID
        '                Backgrounds.GetBGO()

        '                bg.IMG = Form2.TB.Image

        '                Backgrounds.BGOs.Add(bg)
        '                Backgrounds.bgorects.Add(bg.rectangle)
        '            End If
        '        Catch ex As Exception
        '            CurTag = "[NPC]"
        '            Exit Do
        '        End Try
        '    Loop
        'End If

        'Do While sr.Peek() > -1
        '    If CurTag = "[NPC]" Then
        '        n.AI = sr.ReadLine()
        '        n.Animated = sr.ReadLine()
        '        n.Direction = sr.ReadLine()
        '        n.FrameSpeed = sr.ReadLine()
        '        n.FrameStyle = sr.ReadLine()
        '        n.gfxHeight = sr.ReadLine()
        '        n.gfxWidth = sr.ReadLine()
        '        n.HasGravity = sr.ReadLine()
        '        n.Height = sr.ReadLine()
        '        n.Width = sr.ReadLine()
        '        n.ID = sr.ReadLine()
        '        n.MSG = sr.ReadLine()
        '        n.MetroidGlass = sr.ReadLine()
        '        n.MoveSpeed = sr.ReadLine()
        '        n.rectangle = RC.ConvertFromString(sr.ReadLine())
        '        n.TotalFrames = sr.ReadLine()
        '        n.X = sr.ReadLine()
        '        n.Y = sr.ReadLine()
        '        n.NPCcollide = sr.ReadLine()

        '        If n.ID >= 1 Then
        '            Form2.SelectedNPC = n.ID
        '            NPC.GetNPC()

        '            n.IMG = Form2.TB.Image

        '            NPC.NPCsets.Add(n)
        '            NPC.NPCrects.Add(n.rectangle)
        '        End If
        '    End If
        'Loop

        'sr.Close()
        'sr.Dispose()
    End Sub

    Public Sub LoadFromPGE(Path As String)

    End Sub
End Class
