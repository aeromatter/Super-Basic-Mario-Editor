Imports System.IO
Imports System.Xml
Public Structure BGO
    Dim ID As Integer
    Dim PositionRect As Rectangle
    Dim BGOSize As Size
    Dim BGOGraphicsSize As Size
    <Serialization.XmlIgnore()>
    Dim IMG As Image
    Dim BGOFrames As BGOFrames
    Dim ForeGround As Boolean
End Structure

Public Structure BGOFrames
    Public Property TotalFrames As Integer
    Public Property FrameDelay As Integer

    Public Sub New(TotalFrames As Integer, delay As Integer)
        Me.TotalFrames = TotalFrames
        Me.FrameDelay = delay
    End Sub

    Public Function GetTotalFrames()
        Return TotalFrames
    End Function

    Public Function GetFrameSpeed()
        Return FrameDelay
    End Function

    Public Function isAnimated()
        Return TotalFrames > 1
    End Function
End Structure

Public Class Backgrounds
    Public Shared ForeGround As Boolean = False
    Public Shared BGOAlign As Integer = 32
    Public Shared bgo As BGO
    <Serialization.XmlArrayItem("bgo")>
    Public Shared BGOs As New List(Of BGO)
    Public Shared bgorects As New List(Of Rectangle)

    Public Shared path As String

    Public Shared bmp As Bitmap

    Public Shared BGOSize As Size
    Public Shared BGOGraphicsSize As Size
    Public Shared BGOFrames As BGOFrames
    Private bgoReader As StreamReader
    Private parseOutput As Dictionary(Of String, String) = New Dictionary(Of String, String)

    Public Sub GetBGOInfo()
        SetDefaults()
        ReadBGOInfo()
        ApplyData()
    End Sub

    Private Sub SetDefaults()
        bmp = Nothing
        BGOSize = New Size(32, 32)
        BGOGraphicsSize = New Size(32, 32)
        BGOFrames = New BGOFrames(1, 125)
    End Sub

    Private Sub ReadBGOInfo()
        Dim bgoFilePath As String = String.Format("{0}\configs\background\background-{1}.ini", Main.GetGamePath(), ObjectPlacement.SelectedBGO)
        bgoReader = New StreamReader(bgoFilePath, FileMode.Open)

        While Not bgoReader.EndOfStream
            Dim parse As String = bgoReader.ReadLine()
            Dim readInput() As String

            If parse.Contains("=") Then
                readInput = parse.Split("=")
                Dim key As String = readInput(0).Trim(Chr(34), Chr(32))
                Dim value As String = readInput(1).Trim(Chr(34), Chr(32))

                parseOutput.Add(key, value)
            End If
        End While

        bgoReader.Close()
        bgoReader.Dispose()
    End Sub

    Private Sub ApplyData()
        Dim bgoImageName As String = String.Empty
        bgoImageName = parseOutput("image")
        Dim bgoImagePath As String = String.Format("{0}\graphics\background\{1}", Main.GetGamePath(), bgoImageName)
        LoadStream(bgoImagePath)

        BGOGraphicsSize = New Size(bmp.Width, bmp.Height)
        If parseOutput.ContainsKey("frames") Then
            BGOFrames = New BGOFrames(parseOutput("frames"), parseOutput("frame-delay"))
        Else
            BGOFrames = New BGOFrames(1, 125)
        End If
        BGOSize = New Size(bmp.Width, bmp.Height / BGOFrames.GetTotalFrames)

        ForeGround = parseOutput.ContainsKey("foreground")

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