Imports System.IO
Imports System.Xml
Public Structure NPCsets
    Dim ID As Integer
    Dim PositionRect As Rectangle
    Dim NPCSize As Size
    <Serialization.XmlIgnore()>
    Dim IMG As Image
    Dim NPCFrames As NPCFrames
    Dim NPCGraphicsSize As Size
    Dim AI As Integer
    Dim Direction As Integer
    Dim MSG As String
    Dim HasGravity As Boolean
    Dim MoveSpeed As Double
    Dim CurFrame As Integer
    Dim MetroidGlass As Boolean
    Dim NPCcollide As Boolean
    Dim CollRect As Rectangle
    Dim gfxoffsetX As Integer
    Dim gfxoffsetY As Integer
    Dim NPCScore As UInteger
    Dim PlayerBlock As Boolean
    Dim PlayerBlockTop As Boolean
    Dim NPCBlock As Boolean
    Dim NPCBlockTop As Boolean
    Dim GrabSide As Boolean
    Dim GrabTop As Boolean
    Dim JumpHurt As Boolean
    Dim Friendly As Boolean
    Dim BlockCollision As Boolean
    Dim CliffTurn As Boolean
    Dim NoYoshi As Boolean
    Dim ForeGround As Boolean
    Dim Speed As Integer
    Dim NoFireball As Boolean
    Dim NoGravity As Boolean
    Dim NoIceBall As Boolean
End Structure

Public Structure NPCFrames
    Private TotalFrames As Integer
    Private FrameDelay As Integer
    Private FrameStyle As Integer


    Public Sub New(TotalFrames As Integer, FrameDelay As Integer, FrameStyle As Integer)
        Me.TotalFrames = TotalFrames
        Me.FrameDelay = FrameDelay
        Me.FrameStyle = FrameStyle

    End Sub

    Public Function GetTotalFrames() As Integer
        Return TotalFrames
    End Function

    Public Function GetFrameDelay() As Integer
        Return FrameDelay
    End Function

    Public Function isAnimated() As Boolean
        Return TotalFrames > 1
    End Function

    Public Function GetFramestyle() As Integer
        Return FrameStyle
    End Function
End Structure
Public Class NPC
    Public Shared SizeAlign As Integer
    Public Shared NPC As NPCsets
    <Serialization.XmlArrayItem("npc")>
    Public Shared NPCsets As New List(Of NPCsets)
    Public Shared NPCrects As New List(Of Rectangle)
    Public Shared AI As Integer
    Public Shared Direction As Integer
    Public Shared Message As String
    Public Shared HasGravity As Boolean
    Public Shared MoveSpeed As Double
    Public Shared FrameStyle As Integer
    Public Shared MetroidGlass As Boolean
    Public Shared NPCcollide As Boolean

    Public Shared bmp As Bitmap

    Public posX As Integer
    Public posY As Integer

    Public Shared path As String
    Public Shared path2 As String

    Public Shared NPCSize As Size
    Public Shared NPCGraphicsSize As Size
    Public Shared NPCFrames As NPCFrames
    Private npcReader As StreamReader
    Private parseOutput As Dictionary(Of String, String) = New Dictionary(Of String, String)
    Public Shared counter As Integer
    Public Shared frameTimer As New Stopwatch

    Public Sub GetNPCInfo()
        SetDefaults()
        ReadNPCInfo()
        ApplyData()
    End Sub

    Private Sub SetDefaults()
        bmp = Nothing

        NPCSize = New Size(32, 32)
        NPCGraphicsSize = New Size(32, 32)
        NPCFrames = New NPCFrames(1, 8, 0)
        AI = 0
        MetroidGlass = False
        NPCcollide = True

        If NPCs.LeftRadio.Checked Then
            Direction = 2
        ElseIf NPCs.RandomRadio.Checked Then
            Direction = 0
        ElseIf NPCs.RightRadio.Checked Then
            Direction = 1
        End If

        Message = ""
        HasGravity = True
        MoveSpeed = 1

        frameTimer.Start()
    End Sub

    Private Sub ReadNPCInfo()
        Dim npcFilePath As String = String.Format("{0}\configs\npc\npc-{1}.ini", Main.GetGamePath(), ObjectPlacement.SelectedNPC)
        npcReader = New StreamReader(npcFilePath, FileMode.Open)

        While Not npcReader.EndOfStream
            Dim parse As String = npcReader.ReadLine()
            Dim readInput() As String

            If parse.Contains("=") Then
                readInput = parse.Split("=")
                Dim key As String = readInput(0).Trim(Chr(34), Chr(32))
                Dim value As String = readInput(1).Trim(Chr(34), Chr(32))

                parseOutput.Add(key, value)
            End If
        End While

        npcReader.Close()
        npcReader.Dispose()
    End Sub

    Private Sub ApplyData()
        Dim npcImageName As String = String.Empty
        npcImageName = parseOutput("image")
        NPCSize = New Size(parseOutput("gfx-width"), parseOutput("gfx-height"))
        NPCFrames = New NPCFrames(parseOutput("frames"), 8, parseOutput("frame-style"))

        Dim npcImagePath As String = String.Format("{0}\graphics\npc\{1}", Main.GetGamePath(), npcImageName)
        LoadStream(npcImagePath)

        NPCGraphicsSize = New Size(bmp.Width, bmp.Height)
        Try
            ObjectPlacement.TB = New TextureBrush(bmp)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub LoadStream(ByVal StreamPath As String)
        Dim fs As New FileStream(StreamPath, FileMode.Open)

        Dim graphic As Image
        graphic = Image.FromStream(fs)
        bmp = New Bitmap(graphic)

        fs.Close()
        fs.Dispose()
    End Sub
End Class