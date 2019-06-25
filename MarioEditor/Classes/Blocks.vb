Imports System.IO
Imports System.Xml

<Serializable, Serialization.XmlRoot("objects")>
Public Structure Block
    Dim ID As Integer
    Dim PositionRect As Rectangle
    Dim LayerName As String
    Dim DestroyEvent As String
    Dim HitEvent As String
    Dim NoMoreObjectsInLayer As String
    <Serialization.XmlIgnore()>
    Dim IMG As Image
    Dim PhysicalSize As Size
    Dim GraphicSize As Size
    Dim SizableDimensions As Size
    Dim Frames As Frames
    Dim ContainItem As UInteger
    Dim Lava As Boolean
    Dim Breakable As Boolean
    Dim Slip As Boolean
    Dim Invisible As Boolean
End Structure

<Serializable>
Public Structure Frames
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

Public Class Blocks
    Public Shared Invisible As Boolean = False
    Public Shared Slippery As Boolean = False
    Public Shared SizeW As UInteger = 1
    Public Shared SizeH As UInteger = 1
    Public Shared TileSize As UInteger = 32
    <Serialization.XmlArrayItem("block")>
    Public Shared Tiles As New List(Of Block)
    Public Shared Lava As Boolean = False
    Public Shared Hurts As Boolean = False
    Public Shared Sizable As Boolean = False
    Public Shared ContainItem As UInteger = 100
    Public Shared TileRects As New List(Of Rectangle)
    Public Shared FillRect As Rectangle
    Public Shared FillBlocks As New List(Of Block)
    Public Shared FillRects As New List(Of Rectangle)
    Public Shared FillList As New List(Of List(Of Block))
    Public Shared IsSlope As Boolean = False
    Public Shared SlopeType As Integer = 0
    Public Shared Breakable As Boolean

    Public Shared StartRect As Rectangle
    Public Shared ScanRect As Rectangle

    Public Shared path As String

    Public Shared bmp As Bitmap

    Public Shared CreateBlock As Block

    Public Shared fillq As New List(Of Rectangle)

    Public Shared BlockSize As Size
    Public Shared GraphicsSize As Size
    Public Shared Frames As Frames
    Public Shared SizableDimensions As Size
    Private blockReader As StreamReader
    Private parseOutput As Dictionary(Of String, String) = New Dictionary(Of String, String)
    Public Shared blockImageName As String = String.Empty

    Public Sub GetBlockInfo()
        SetDefaults()
        ReadBlockInfo()
        ApplyData()
    End Sub

    Private Sub SetDefaults()
        bmp = Nothing
        BlockSize = New Size(32, 32)
        GraphicsSize = New Size(32, 32)
        SizableDimensions = New Size(1, 1)
        Frames = New Frames(1, 125)
        Lava = False
        Breakable = False
        Invisible = BlocksAndTiles.CheckBox1.CheckState
        Slippery = BlocksAndTiles.CheckBox2.CheckState
    End Sub

    Private Sub ReadBlockInfo()
        Dim blockFilePath As String = String.Format("{0}\configs\block\block-{1}.ini", Main.GetGamePath(), ObjectPlacement.SelectedBlock)
        blockReader = New StreamReader(blockFilePath, FileMode.Open)
        parseOutput.Clear()

        While Not blockReader.EndOfStream
            Dim parse As String = blockReader.ReadLine()
            Dim readInput() As String

            If parse.Contains("=") Then
                readInput = parse.Split("=")
                Dim key As String = readInput(0).Trim(Chr(34), Chr(32))
                Dim value As String = readInput(1).Trim(Chr(34), Chr(32))

                parseOutput.Add(key, value)
            End If
        End While

        blockReader.Close()
        blockReader.Dispose()
    End Sub

    Private Sub ApplyData()
        blockImageName = parseOutput("image")
        Dim blockImagePath As String = String.Format("{0}\graphics\block\{1}", Main.GetGamePath(), blockImageName)
        LoadStream(blockImagePath)

        If parseOutput.ContainsKey("frames") Then
            Frames = New Frames(parseOutput("frames"), parseOutput("frame-delay"))
        Else
            Frames = New Frames(1, parseOutput("frame-delay"))
        End If

        BlockSize = New Size(bmp.Width, bmp.Height / Frames.GetTotalFrames)
        GraphicsSize = New Size(bmp.Width, bmp.Height)
        SizableDimensions = New Size(SizeW, SizeH)

        Try
            ObjectPlacement.TB = New TextureBrush(bmp)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub LoadStream(ByVal StreamPath As String)
        If Sizable Then

            Dim fs As New System.IO.FileStream(StreamPath, System.IO.FileMode.Open)
            Dim graphic As Image

            graphic = Image.FromStream(fs)

            Dim SizeBMP As New Bitmap((CInt(SizeW) * 32) + 32, (CInt(SizeH) * 32) + 32)

            Dim g As Graphics = Graphics.FromImage(SizeBMP)

            g.DrawImage(graphic, New Rectangle(0, 0, 32, 32), New Rectangle(0, 0, 32, 32), GraphicsUnit.Pixel)
            For X = CUInt(1) To SizeW
                g.DrawImage(graphic, New Rectangle(X * 32, 0, 32, 32), New Rectangle(32, 0, 32, 32), GraphicsUnit.Pixel)
                g.DrawImage(graphic, New Rectangle(X * 32, SizeH * 32, 32, 32), New Rectangle(32, 64, 32, 32), GraphicsUnit.Pixel)
            Next
            For Y = CUInt(1) To SizeH
                g.DrawImage(graphic, New Rectangle(0, Y * 32, 32, 32), New Rectangle(0, 32, 32, 32), GraphicsUnit.Pixel)
                g.DrawImage(graphic, New Rectangle(SizeW * 32, Y * 32, 32, 32), New Rectangle(64, 32, 32, 32), GraphicsUnit.Pixel)
            Next
            For FillX = 1 To SizeW - 1
                For FillY = 1 To SizeH - 1
                    g.DrawImage(graphic, New Rectangle(FillX * 32, FillY * 32, 32, 32), New Rectangle(32, 32, 32, 32), GraphicsUnit.Pixel)
                Next
            Next
            g.DrawImage(graphic, New Rectangle((SizeW * 32), 0, 32, 32), New Rectangle(64, 0, 32, 32), GraphicsUnit.Pixel)
            g.DrawImage(graphic, New Rectangle(0, (SizeH * 32), 32, 32), New Rectangle(0, 64, 32, 32), GraphicsUnit.Pixel)
            g.DrawImage(graphic, New Rectangle((SizeW * 32), (SizeH * 32), 32, 32), New Rectangle(64, 64, 32, 32), GraphicsUnit.Pixel)

            bmp = New Bitmap(SizeBMP)

            fs.Close()
            fs.Dispose()
        Else
            Dim fs As New System.IO.FileStream(StreamPath, System.IO.FileMode.Open)

            Dim graphic As Image
            graphic = Image.FromStream(fs)
            bmp = New Bitmap(graphic)

            fs.Close()
            fs.Dispose()
        End If
    End Sub
End Class