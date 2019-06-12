Imports System.IO
Imports System.Xml
Public Class ItemSettings
    Public Enum ItemTypes
        Block
        BGO
        NPC
    End Enum
    Public Structure ItemInfo
        Dim ItemType As ItemTypes
        Dim ID As Integer
        Dim Section As Integer
        Dim PositionRect As Rectangle
        Dim SourceRect As Rectangle
        Dim PhysicalSize As Size
        Dim GraphicSize As Size
        Dim Frames As ItemFrames
        Dim Settings As Dictionary(Of String, Object)
    End Structure

    <Serializable>
    Public Structure ItemFrames
        Public Property totalFrames As Integer
        Public Property frameDelay As Integer

        Public Sub New(TotalFrames As Integer, delay As Integer)
            Me.totalFrames = TotalFrames
            Me.frameDelay = delay
        End Sub

        Public Function GetTotalFrames()
            Return totalFrames
        End Function

        Public Function GetFrameSpeed()
            Return frameDelay
        End Function

        Public Function isAnimated()
            Return totalFrames > 1
        End Function
    End Structure

    Public PlacedItems As List(Of ItemInfo)
    Public graphicPath As String
    Public graphicMap As Bitmap
    Public itemType As ItemTypes
    Public physicalSize As Size
    Public graphicSize As Size
    Public frames As ItemFrames
    Public frameSize As Size
    Public settings As Dictionary(Of String, Object)
    Private itemFilePath As String
    Private itemImagePath As String
    Private itemImageName As String
    Private reader As StreamReader
    Private parseOutput As Dictionary(Of String, String)

    Public Sub GetItemInfo()
        SetDefaultValues()
        ReadItemInfo()
        ApplyItemInfo()
    End Sub

    Private Sub SetDefaultValues()
        graphicPath = String.Empty
        itemFilePath = String.Empty
        itemImagePath = String.Empty
        itemImageName = String.Empty
        graphicMap = Nothing
        parseOutput = New Dictionary(Of String, String)
        settings = New Dictionary(Of String, Object)
    End Sub

    Private Sub ReadItemInfo()
        itemFilePath = GetItemConfigPath()

        reader = New StreamReader(itemFilePath, FileMode.Open)

        While Not reader.EndOfStream
            PopulateDictionary()
        End While

        reader.Close()
        reader.Dispose()
    End Sub

    Private Function GetItemConfigPath() As String
        Select Case itemType
            Case ItemTypes.Block
                Return String.Format("{0}\configs\block\block-{1}.ini", Main.GetGamePath(), ObjectPlacement.SelectedBGO)
            Case ItemTypes.BGO
                Return String.Format("{0}\configs\background\background-{1}.ini", Main.GetGamePath(), ObjectPlacement.SelectedBGO)
            Case ItemTypes.NPC
                Return String.Format("{0}\configs\npc\npc-{1}.ini", Main.GetGamePath(), ObjectPlacement.SelectedBGO)
        End Select

        Return String.Empty
    End Function

    Private Sub PopulateDictionary()
        Dim parse As String = reader.ReadLine()
        Dim readInput() As String

        If parse.Contains("=") Then
            readInput = parse.Split("=")
            Dim key As String = readInput(0).Trim(Chr(34), Chr(32))
            Dim value As String = readInput(1).Trim(Chr(34), Chr(32))

            parseOutput.Add(key, value)
        End If
    End Sub

    Private Sub ApplyItemInfo()
        itemImageName = parseOutput("image")
        itemImagePath = GetItemGraphicPath()

        LoadStream(itemImagePath)

        graphicSize = New Size(graphicMap.Width, graphicMap.Height)
        If parseOutput.ContainsKey("frames") Then
            frames = New ItemFrames(parseOutput("frames"), parseOutput("frame-delay"))
        Else
            frames = New ItemFrames(1, 125)
        End If
        frameSize = New Size(graphicMap.Width, graphicMap.Height / frames.GetTotalFrames)

        SetEditorBrush()
    End Sub

    Private Function GetItemGraphicPath() As String
        Select Case itemType
            Case ItemTypes.Block
                Return String.Format("{0}\graphics\block\{1}", Main.GetGamePath(), itemImageName)
            Case ItemTypes.BGO
                Return String.Format("{0}\graphics\background\{1}", Main.GetGamePath(), itemImageName)
            Case ItemTypes.NPC
                Return String.Format("{0}\graphics\npc\{1}", Main.GetGamePath(), itemImageName)
        End Select

        Return String.Empty
    End Function

    Private Sub LoadStream(ByVal StreamPath As String)
        Dim fs As New FileStream(StreamPath, FileMode.Open)

        Dim graphic As Image
        graphic = Image.FromStream(fs)
        graphicMap = New Bitmap(graphic)

        fs.Close()
        fs.Dispose()
    End Sub

    Private Sub SetEditorBrush()
        Try
            ObjectPlacement.TB = New TextureBrush(graphicMap)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class