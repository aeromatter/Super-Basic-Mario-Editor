Imports System.IO
Imports System.Xml

Public Class LevelFile
    Private writer As StreamWriter
    Private reader As StreamReader
    Private serializer As Serialization.XmlSerializer
    Private Const LVL_STANDARD As Integer = 64
    Private Const LVL_TRUE As String = "#TRUE#"
    Private Const LVL_FALSE As String = "#FALSE#"

    Public Sub SaveLevelAsXML()
        SaveBlocks()
        SaveBGOs()
        SaveNPCs()
    End Sub

    Public Sub LoadLevelFromXML()
        LoadBlocks()
        LoadBGOs()
        LoadNPCs()
    End Sub

    Public Sub SaveBlocks()
        serializer = New Serialization.XmlSerializer(GetType(List(Of Block)))
        writer = New StreamWriter(String.Format("{0}\worlds\blocks.xml", Main.GetGamePath()), False)
        serializer.Serialize(writer, Blocks.Tiles)
        writer.Close()
    End Sub

    Public Sub SaveBGOs()
        Dim serializer As New Serialization.XmlSerializer(GetType(List(Of BGO)))
        writer = New StreamWriter(String.Format("{0}\worlds\bgos.xml", Main.GetGamePath()), False)
        serializer.Serialize(writer, Backgrounds.BGOs)
        writer.Close()
    End Sub

    Public Sub SaveNPCs()
        Dim serializer As New Serialization.XmlSerializer(GetType(List(Of NPCsets)))
        writer = New StreamWriter(String.Format("{0}\worlds\npcs.xml", Main.GetGamePath()), False)
        serializer.Serialize(writer, NPC.NPCsets)
        writer.Close()
    End Sub

    Public Sub LoadBlocks()
        Dim deserializer As New Serialization.XmlSerializer(GetType(List(Of Block)))
        reader = New StreamReader(String.Format("{0}\worlds\blocks.xml", Main.GetGamePath()))
        Blocks.Tiles = deserializer.Deserialize(reader)
        reader.Close()
    End Sub

    Public Sub LoadBGOs()
        Dim deserializer As New Serialization.XmlSerializer(GetType(List(Of BGO)))
        reader = New StreamReader(String.Format("{0}\worlds\bgos.xml", Main.GetGamePath()))
        Backgrounds.BGOs = deserializer.Deserialize(reader)
        reader.Close()
    End Sub

    Public Sub LoadNPCs()
        Dim deserializer As New Serialization.XmlSerializer(GetType(List(Of NPCsets)))
        reader = New StreamReader(String.Format("{0}\worlds\npcs.xml", Main.GetGamePath()))
        NPC.NPCsets = deserializer.Deserialize(reader)
        reader.Close()
    End Sub

    Private Function FormatStringLVL(input As String) As String
        Return Chr(34) + input + Chr(34)
    End Function

    Private Function FormatBoolLVL(input As Boolean) As String
        If input Then
            Return LVL_TRUE
        Else
            Return LVL_FALSE
        End If
    End Function

    Public Sub SaveAsSMBX64(path As String)

        writer = New StreamWriter(path, False)
        WriteSMBX64Header()
        WriteSMBX64Sections()
        WriteSMBX64PlayerLocations()
        WriteSMBX64Blocks()
        writer.WriteLine(FormatStringLVL("next"))
        WriteSMBX64BackgroundObjects()
        writer.WriteLine(FormatStringLVL("next"))
        WriteSMBX64NPCs()
        writer.WriteLine(FormatStringLVL("next"))
        WriteSMBX64Warps()
        writer.WriteLine(FormatStringLVL("next"))
        WriteSMBX64Liquids()
        writer.WriteLine(FormatStringLVL("next"))
        WriteSMBX64Layers()
        writer.WriteLine(FormatStringLVL("next"))
        WriteSMBX64Events()

        writer.Close()
        writer.Dispose()
    End Sub

    Private Sub WriteSMBX64Header()
        writer.WriteLine(LVL_STANDARD)
        writer.WriteLine("0") 'Number of stars
        writer.WriteLine(FormatStringLVL(""))
    End Sub

    Private Sub WriteSMBX64Sections()
        For i = 1 To 21
            writer.WriteLine(Level.Sections(i).bounds.Left)
            writer.WriteLine(Level.Sections(i).bounds.Top)
            writer.WriteLine(Level.Sections(i).bounds.Bottom)
            writer.WriteLine(Level.Sections(i).bounds.Right)
            writer.WriteLine("0") 'Music ID
            writer.WriteLine("16291944") 'Background color for old versions
            writer.WriteLine(FormatBoolLVL(Level.Sections(i).levelWrap))
            writer.WriteLine(FormatBoolLVL(Level.Sections(i).offscreenExit))
            writer.WriteLine(Level.Sections(i).background.ID)
            writer.WriteLine(FormatBoolLVL(Level.Sections(i).noTurnBack))
            writer.WriteLine(FormatBoolLVL(Level.Sections(i).underWater))
            writer.WriteLine(FormatStringLVL(Level.Music))
        Next
    End Sub

    Private Sub WriteSMBX64PlayerLocations()
        writer.WriteLine(ObjectPlacement.player1SpawnLocation.X)
        writer.WriteLine(ObjectPlacement.player1SpawnLocation.Y)
        writer.WriteLine(ObjectPlacement.player1SpawnLocation.Width)
        writer.WriteLine(ObjectPlacement.player1SpawnLocation.Height)

        writer.WriteLine(ObjectPlacement.player2SpawnLocation.X)
        writer.WriteLine(ObjectPlacement.player2SpawnLocation.Y)
        writer.WriteLine(ObjectPlacement.player2SpawnLocation.Width)
        writer.WriteLine(ObjectPlacement.player2SpawnLocation.Height)
    End Sub

    Private Sub WriteSMBX64Blocks()
        For i = 0 To Blocks.Tiles.Count - 1
            writer.WriteLine(Blocks.Tiles(i).PositionRect.X)
            writer.WriteLine(Blocks.Tiles(i).PositionRect.Y)
            writer.WriteLine(Blocks.Tiles(i).PositionRect.Height)
            writer.WriteLine(Blocks.Tiles(i).PositionRect.Width)
            writer.WriteLine(Blocks.Tiles(i).ID)
            writer.WriteLine(Blocks.Tiles(i).ContainItem)
            writer.WriteLine(FormatBoolLVL(Blocks.Tiles(i).Invisible))
            writer.WriteLine(FormatBoolLVL(Blocks.Tiles(i).Slip))
            writer.WriteLine(FormatStringLVL(Blocks.Tiles(i).LayerName))
            writer.WriteLine(FormatStringLVL(Blocks.Tiles(i).DestroyEvent))
            writer.WriteLine(FormatStringLVL(Blocks.Tiles(i).HitEvent))
            writer.WriteLine(FormatStringLVL(Blocks.Tiles(i).NoMoreObjectsInLayer))
        Next
    End Sub

    Private Sub WriteSMBX64BackgroundObjects()
        For i = 0 To Backgrounds.BGOs.Count - 1
            writer.WriteLine(Backgrounds.BGOs(i).PositionRect.X)
            writer.WriteLine(Backgrounds.BGOs(i).PositionRect.Y)
            writer.WriteLine(Backgrounds.BGOs(i).ID)
            writer.WriteLine(FormatStringLVL(Backgrounds.BGOs(i).LayerName))
        Next
    End Sub

    Private Sub WriteSMBX64NPCs()
        For i = 0 To NPC.NPCsets.Count - 1
            writer.WriteLine(NPC.NPCsets(i).PositionRect.X)
            writer.WriteLine(NPC.NPCsets(i).PositionRect.Y)
            writer.WriteLine(NPC.NPCsets(i).Direction)
            writer.WriteLine(NPC.NPCsets(i).ID)
            writer.WriteLine(NPC.NPCsets(i).specialSettingA)
            writer.WriteLine(NPC.NPCsets(i).specialSettingB)
            writer.WriteLine(FormatBoolLVL(NPC.NPCsets(i).isGenerator))
            writer.WriteLine(NPC.NPCsets(i).specialGeneratorDir)
            writer.WriteLine(NPC.NPCsets(i).specialGeneratorType)
            writer.WriteLine(NPC.NPCsets(i).specialGeneratorDelay)
            writer.WriteLine(FormatStringLVL(NPC.NPCsets(i).message))
            writer.WriteLine(FormatBoolLVL(NPC.NPCsets(i).Friendly))
            writer.WriteLine(FormatBoolLVL(NPC.NPCsets(i).dontMove))
            writer.WriteLine(FormatBoolLVL(NPC.NPCsets(i).isLegacyBoss))
            writer.WriteLine(FormatStringLVL(NPC.NPCsets(i).message))
            writer.WriteLine(FormatStringLVL(NPC.NPCsets(i).LayerName))
            writer.WriteLine(FormatStringLVL(NPC.NPCsets(i).ActivateEvent))
            writer.WriteLine(FormatStringLVL(NPC.NPCsets(i).DeathEvent))
            writer.WriteLine(FormatStringLVL(NPC.NPCsets(i).TalkEvent))
            writer.WriteLine(FormatStringLVL(NPC.NPCsets(i).NoMoreObjectsInLayerEvent))
            writer.WriteLine(FormatStringLVL(NPC.NPCsets(i).AttachToLayer))
        Next
    End Sub

    Private Sub WriteSMBX64Warps()
        For i = 0 To Warps.LevelWarps.Count - 1
            writer.WriteLine(Warps.LevelWarps(i).entranceLocation.X)
            writer.WriteLine(Warps.LevelWarps(i).entranceLocation.Y)
            writer.WriteLine(Warps.LevelWarps(i).exitLocation.X)
            writer.WriteLine(Warps.LevelWarps(i).exitLocation.Y)
            writer.WriteLine(Warps.LevelWarps(i).entranceDir)
            writer.WriteLine(Warps.LevelWarps(i).exitDir)
            writer.WriteLine(Warps.LevelWarps(i).warp)
            writer.WriteLine(FormatStringLVL(Warps.LevelWarps(i).levelName))
            writer.WriteLine(Warps.LevelWarps(i).levelEntrance)
            writer.WriteLine(Warps.LevelWarps(i).isLevelEntrance)
            writer.WriteLine(FormatBoolLVL(Warps.LevelWarps(i).canExitLevel))
            writer.WriteLine(Warps.LevelWarps(i).mapWarpX) 'or -1 for empty
            writer.WriteLine(Warps.LevelWarps(i).mapWarpY) 'or -1 for empty
            writer.WriteLine(Warps.LevelWarps(i).starsNeeded)
            writer.WriteLine(FormatStringLVL(Warps.LevelWarps(i).layerName))
            writer.WriteLine("#FALSE#") 'Unused value
            writer.WriteLine(FormatBoolLVL(Warps.LevelWarps(i).noYoshi))
            writer.WriteLine(FormatBoolLVL(Warps.LevelWarps(i).allowNPC))
            writer.WriteLine(FormatBoolLVL(Warps.LevelWarps(i).isLocked))
        Next
    End Sub

    Private Sub WriteSMBX64Liquids()
        For i = 0 To Liquids.LiquidInfo.Count - 1
            writer.WriteLine(Liquids.LiquidInfo(i).LiquidArea.X)
            writer.WriteLine(Liquids.LiquidInfo(i).LiquidArea.Y)
            writer.WriteLine(Liquids.LiquidInfo(i).LiquidArea.Width)
            writer.WriteLine(Liquids.LiquidInfo(i).LiquidArea.Height)
            writer.WriteLine("0") 'Unused value
            writer.WriteLine(FormatBoolLVL(Liquids.LiquidInfo(i).isQuicksand))
            writer.WriteLine(FormatStringLVL(Liquids.LiquidInfo(i).layerName))
        Next
    End Sub

    Private Sub WriteSMBX64Layers()
        For i = 0 To Layers.LayerInfo.Count - 1
            writer.WriteLine(FormatStringLVL(Layers.LayerInfo.Keys(i)))
            writer.WriteLine(FormatBoolLVL(Layers.LayerInfo.Values(i)))
        Next
    End Sub

    Private Sub WriteSMBX64Events()
        For i = 0 To EventsWindow.eventInfo.Count - 1
            writer.WriteLine(FormatStringLVL(EventsWindow.eventInfo(i).name))
            writer.WriteLine(FormatStringLVL(EventsWindow.eventInfo(i).message))
            writer.WriteLine(EventsWindow.eventInfo(i).playSound)
            writer.WriteLine(EventsWindow.eventInfo(i).endGame)
            For j = 0 To 19
                If j < EventsWindow.eventInfo(i).showLayers.Count Then
                    writer.WriteLine(FormatStringLVL(EventsWindow.eventInfo(i).showLayers(j)))
                Else
                    writer.WriteLine(FormatStringLVL(""))
                End If

                If j < EventsWindow.eventInfo(i).hideLayers.Count Then
                    writer.WriteLine(FormatStringLVL(EventsWindow.eventInfo(i).hideLayers(j)))
                Else
                    writer.WriteLine(FormatStringLVL(""))
                End If

                If j < EventsWindow.eventInfo(i).toggleLayers.Count Then
                    writer.WriteLine(FormatStringLVL(EventsWindow.eventInfo(i).toggleLayers(j)))
                Else
                    writer.WriteLine(FormatStringLVL(""))
                End If
            Next
            writer.WriteLine(FormatStringLVL("")) 'Empty
            writer.WriteLine(FormatStringLVL("")) 'Empty
            writer.WriteLine(FormatStringLVL("")) 'Empty
            For sectionSettings = 1 To 21
                writer.WriteLine("-1")
                writer.WriteLine("-1")
                writer.WriteLine("-1")
                writer.WriteLine("0")
                writer.WriteLine("0")
                writer.WriteLine("0")
            Next
            writer.WriteLine(FormatStringLVL(EventsWindow.eventInfo(i).triggerEvent))
            writer.WriteLine(EventsWindow.eventInfo(i).triggerEventDelay)
            writer.WriteLine(FormatBoolLVL(EventsWindow.eventInfo(i).smokeEnabled))
            writer.WriteLine(FormatBoolLVL(EventsWindow.eventInfo(i).playerAltJump))
            writer.WriteLine(FormatBoolLVL(EventsWindow.eventInfo(i).playerAltRun))
            writer.WriteLine(FormatBoolLVL(EventsWindow.eventInfo(i).playerDown))
            writer.WriteLine(FormatBoolLVL(EventsWindow.eventInfo(i).playerDrop))
            writer.WriteLine(FormatBoolLVL(EventsWindow.eventInfo(i).playerJump))
            writer.WriteLine(FormatBoolLVL(EventsWindow.eventInfo(i).playerLeft))
            writer.WriteLine(FormatBoolLVL(EventsWindow.eventInfo(i).playerRight))
            writer.WriteLine(FormatBoolLVL(EventsWindow.eventInfo(i).playerRun))
            writer.WriteLine(FormatBoolLVL(EventsWindow.eventInfo(i).playerStart))
            writer.WriteLine(FormatBoolLVL(EventsWindow.eventInfo(i).playerUp))
            writer.WriteLine(FormatBoolLVL(EventsWindow.eventInfo(i).autoStart))
            writer.WriteLine(FormatStringLVL(EventsWindow.eventInfo(i).layerMovement))
            writer.WriteLine(EventsWindow.eventInfo(i).layerHorizontalSpeed)
            writer.WriteLine(EventsWindow.eventInfo(i).layerVerticalSpeed)
            writer.WriteLine(EventsWindow.eventInfo(i).autoscrollHorizontalSpeed)
            writer.WriteLine(EventsWindow.eventInfo(i).autoscrollVerticalSpeed)
            writer.WriteLine(EventsWindow.eventInfo(i).autoscrollSection)
        Next
    End Sub
End Class
