Imports System.IO
Imports System.Xml

Public Class LevelFile
    Private writer As StreamWriter
    Private reader As StreamReader
    Private serializer As Serialization.XmlSerializer
    Private Const LVL_STANDARD As Integer = 64

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

    Public Sub SaveAsSMBX64()

        writer = New StreamWriter(MainWindow.SaveLevelFileDialog.FileName, False)
        WriteSMBX64Header()
        WriteSMBX64Sections()
        WriteSMBX64PlayerLocations()
        WriteSMBX64Blocks()
        writer.WriteLine("next")
        WriteSMBX64BackgroundObjects()
        writer.WriteLine("next")
        WriteSMBX64NPCs()
        writer.WriteLine("next")
        WriteSMBX64Warps()
        writer.WriteLine("next")
        WriteSMBX64Liquids()
        writer.WriteLine("next")
        WriteSMBX64Layers()
        writer.WriteLine("next")
        'WriteSMBX64Events()
        'EOF
    End Sub

    Private Sub WriteSMBX64Header()
        writer.WriteLine(LVL_STANDARD)
        writer.WriteLine("0" + vbCrLf) 'Number of stars
        writer.WriteLine("level name")
    End Sub

    Private Sub WriteSMBX64Sections()
        For i = 1 To 21
            writer.WriteLine(Level.Sections(i).bounds.Left)
            writer.WriteLine(Level.Sections(i).bounds.Top)
            writer.WriteLine(Level.Sections(i).bounds.Bottom)
            writer.WriteLine(Level.Sections(i).bounds.Right)
            writer.WriteLine("0") 'Music ID
            writer.WriteLine("0") 'Background color for old versions
            'Write level wrap bool
            'Write offscreen exit bool
            writer.WriteLine("0") 'Background ID
            'Write noturnback bool
            'Write underwater bool
            writer.WriteLine(Level.Music)
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
        For i = 0 To Blocks.Tiles.Count
            writer.WriteLine(Blocks.Tiles(i).PositionRect.X)
            writer.WriteLine(Blocks.Tiles(i).PositionRect.Y)
            writer.WriteLine(Blocks.Tiles(i).PositionRect.Height)
            writer.WriteLine(Blocks.Tiles(i).PositionRect.Width)
            writer.WriteLine(Blocks.Tiles(i).ID)
            writer.WriteLine(Blocks.Tiles(i).ContainItem)
            writer.WriteLine(Blocks.Tiles(i).Invisible)
            writer.WriteLine(Blocks.Tiles(i).Slip)
            writer.WriteLine(Blocks.Tiles(i).LayerName)
            writer.WriteLine(Blocks.Tiles(i).DestroyEvent)
            writer.WriteLine(Blocks.Tiles(i).HitEvent)
            writer.WriteLine(Blocks.Tiles(i).NoMoreObjectsInLayer)
        Next
    End Sub

    Private Sub WriteSMBX64BackgroundObjects()
        For i = 0 To Backgrounds.BGOs.Count
            writer.WriteLine(Backgrounds.BGOs(i).PositionRect.X)
            writer.WriteLine(Backgrounds.BGOs(i).PositionRect.Y)
            writer.WriteLine(Backgrounds.BGOs(i).ID)
            writer.WriteLine(Backgrounds.BGOs(i).LayerName)
        Next
    End Sub

    Private Sub WriteSMBX64NPCs()
        For i = 0 To NPC.NPCsets.Count
            writer.WriteLine(NPC.NPCsets(i).PositionRect.X)
            writer.WriteLine(NPC.NPCsets(i).PositionRect.Y)
            writer.WriteLine(NPC.NPCsets(i).Direction)
            writer.WriteLine(NPC.NPCsets(i).ID)
            'Write special option 1
            'Write special option 2
            'Write generator bool
            'Write generator direction
            'Write generator type
            'Write generator period
            writer.WriteLine(NPC.NPCsets(i).MSG)
            writer.WriteLine(NPC.NPCsets(i).Friendly)
            'Write dont move bool
            'Write legacy boss bool
            'Write layer name
            'Write Activate event
            'Write Death event
            'Write Talk event
            'Write no more obj event
            'Write attack to layer
        Next
    End Sub

    Private Sub WriteSMBX64Warps()
        For i = 0 To Warps.LevelWarps.Count
            writer.WriteLine(Warps.LevelWarps(i).entranceLocation.X)
            writer.WriteLine(Warps.LevelWarps(i).entranceLocation.Y)
            writer.WriteLine(Warps.LevelWarps(i).exitLocation.X)
            writer.WriteLine(Warps.LevelWarps(i).exitLocation.Y)
            writer.WriteLine(Warps.LevelWarps(i).entranceDir)
            writer.WriteLine(Warps.LevelWarps(i).exitDir)
            writer.WriteLine(Warps.LevelWarps(i).warp)
            'Write warp to level
            'Write normal entrance
            'Write level entrance
            'Write level exit
            'Write map warp X or -1 for empty
            'Write map warp Y or -1 for empty
            'Write stars needed
            'Write layer name
            writer.WriteLine("#FALSE#") 'Unused value
            writer.WriteLine(Warps.LevelWarps(i).passage) 'TODO: Write values for Yoshi, NPCs, and Locked
        Next
    End Sub

    Private Sub WriteSMBX64Liquids()
        For i = 0 To Liquids.LiquidInfo.Count
            writer.WriteLine(Liquids.LiquidInfo(i).LiquidArea.X)
            writer.WriteLine(Liquids.LiquidInfo(i).LiquidArea.Y)
            writer.WriteLine(Liquids.LiquidInfo(i).LiquidArea.Width)
            writer.WriteLine(Liquids.LiquidInfo(i).LiquidArea.Height)
            writer.WriteLine("0") 'Unused value
            writer.WriteLine(Liquids.LiquidInfo(i).isQuicksand)
            'Layer name
        Next
    End Sub

    Private Sub WriteSMBX64Layers()
        For i = 0 To Layers.LayerInfo.Count
            writer.WriteLine(Layers.LayerInfo.Keys(i))
            writer.WriteLine(Layers.LayerInfo.Values(i))
        Next
    End Sub
End Class
