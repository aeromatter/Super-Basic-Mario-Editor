Imports System.IO
Imports System.Xml

Public Class LevelFile
    Private writer As StreamWriter
    Private reader As StreamReader
    Private serializer As Serialization.XmlSerializer

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
End Class
