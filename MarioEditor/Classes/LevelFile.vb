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
        'WriteSMBX64Warps()
        'next
        'WriteSMBX64Liquids()
        'next
        'WriteSMBX64Layers()
        'next
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
            'Write layer name
            'Write destroy event
            'Write hit event
            'Write no more objects in layer event
        Next
    End Sub

    Private Sub WriteSMBX64BackgroundObjects()
        For i = 0 To Backgrounds.BGOs.Count
            writer.WriteLine(Backgrounds.BGOs(i).PositionRect.X)
            writer.WriteLine(Backgrounds.BGOs(i).PositionRect.Y)
            writer.WriteLine(Backgrounds.BGOs(i).ID)
            'Write layer name
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
End Class
