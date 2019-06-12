Imports System.Drawing.Text

Public Class LevelWindow

    Public Shared IsSaved As Boolean = False
    Dim Parallax As Double

    'Character Loctation image storage
    Public Shared PlayerGraphic As Bitmap
    Public Shared Player2Graphic As Bitmap

    Public Shared Draw As Graphics

    Public PFC As PrivateFontCollection
    Public SMB3font As Font

    Public Audio As Audio

    Public FPScounter As Integer = 0

    Private LevelData As Level

    Private Sub Form2_Deactivate(sender As Object, e As System.EventArgs) Handles Me.Deactivate
        Focus()
    End Sub

    Private Sub Form2_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Dim ki As New KeyboardInputs()
        ki.KeyboardControl()
    End Sub
    Private Sub Form2_KeyUp(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyUp

    End Sub
    Private Sub SetFormDrawSettings()
        SetStyle(ControlStyles.UserPaint, True)
        SetStyle(ControlStyles.AllPaintingInWmPaint, True)
        SetStyle(ControlStyles.OptimizedDoubleBuffer, True)
        ResizeRedraw = True
    End Sub
    Private Sub SetLevelSize()
        AutoScrollMinSize = New Size(Level.LevelW, Level.LevelH)
    End Sub
    Private Sub LoadGameFont()
        Try
            PFC = New PrivateFontCollection
            PFC.AddFontFile(Main.GetGamePath() & "\Fonts\SMB3.ttf")
            SMB3font = New Font(PFC.Families.First, 14, FontStyle.Regular)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
    Private Sub Form2_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        SetFormDrawSettings()

        Show()
        Focus()

        SetLevelSize()
        LevelData = New Level

        Dim blocks As New Blocks
        blocks.GetBlockInfo()
        LoadGameFont()
        PlayerC.LoadControls()

        Audio = New Audio
        Audio.PlaySound("level-select")
    End Sub

    Private Sub Form2_MouseClick(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseClick
        ObjectPlacement.AddObject()
    End Sub

    Private Sub Form2_MouseDown(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown
        ObjectPlacement.MouseIsDown = True
    End Sub

    Private Sub SetForegroundBGO()
        If BGOs_Form.DefaultRadio.Checked Then
            Backgrounds.ForeGround = ObjectPlacement.SelectedBGO = 51 Or ObjectPlacement.SelectedBGO = 52
        Else
            Backgrounds.ForeGround = BGOs_Form.ForegroundRadio.Checked
        End If
    End Sub

    Private Sub Form2_MouseEnter(sender As Object, e As System.EventArgs) Handles Me.MouseEnter
        Cursor.Hide()
        ObjectPlacement.PlacementRect = Nothing
        Backgrounds.bgo.PositionRect = Nothing

        SetForegroundBGO()

        Select Case ObjectPlacement.EditMode
            Case 0
                Dim blocks As New Blocks
                If ObjectPlacement.hasBlockSelectChanged Then
                    blocks.GetBlockInfo()
                End If
            Case 2
                Dim bgos As New Backgrounds
                bgos.GetBGOInfo()
            Case 5
                Dim npc As New NPC
                npc.GetNPCInfo()
        End Select
    End Sub

    Private Sub Form2_MouseLeave(sender As Object, e As System.EventArgs) Handles Me.MouseLeave
        'Reset windows cursor
        Cursor.Show()
    End Sub

    Private Sub Form2_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        ObjectPlacement.MouseIsMoving = True

        ObjectPlacement.mouselocX = e.X
        ObjectPlacement.mouselocY = e.Y

        ObjectPlacement.GetMouseRelativeToWindow(New Point(e.X, e.Y))

        ObjectPlacement.AddObject()

        Invalidate()
    End Sub

    Private Sub Form2_MouseUp(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseUp
        ObjectPlacement.MouseIsDown = False
    End Sub

    Protected Overrides Sub OnLostFocus(e As System.EventArgs)
        MyBase.OnLostFocus(e)
    End Sub

    Private Sub SetDrawingSettings()
        Draw.CompositingQuality = Drawing2D.CompositingQuality.HighSpeed
        Draw.SmoothingMode = Drawing2D.SmoothingMode.HighSpeed
        Draw.PixelOffsetMode = Drawing2D.PixelOffsetMode.HighSpeed
    End Sub

    Private Sub Form2_Paint(sender As Object, e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        Draw = e.Graphics
        SetDrawingSettings()
        Draw.Clear(Color.Black)

        Dim bg As Graphics = Draw
        bg.TranslateTransform(AutoScrollPosition.X, AutoScrollPosition.Y)

        Select Case Level.BGtype
            Case 1
                For x = 0 To LevelData.PrimaryBGMaxDrawTimesX
                    If Draw.IsVisible(LevelData.PrimaryBGLocation(x)) Then
                        bg.DrawImage(Level.BG, LevelData.PrimaryBGLocation(x), 0, 0, Level.BG.Width, Level.BG.Height, GraphicsUnit.Pixel)
                    End If
                Next
            Case 2
                For x = 0 To LevelData.PrimaryBGMaxDrawTimesX
                    If Draw.IsVisible(LevelData.PrimaryBGLocation(x)) Then
                        bg.DrawImage(Level.BG, LevelData.PrimaryBGLocation(x), 0, 0, Level.BG.Width, Level.BG.Height, GraphicsUnit.Pixel)
                    End If
                Next
                For x = 0 To LevelData.SecondaryBGMaxDrawTimesX
                    If Draw.IsVisible(LevelData.SecondaryBGLocation(x)) Then
                        bg.DrawImage(Level.BG2, LevelData.SecondaryBGLocation(x), 0, 0, Level.BG2.Width, Level.BG2.Height, GraphicsUnit.Pixel)
                    End If
                Next
        End Select

        bg.ResetTransform()

        If Grid.GridOn Then
            For X = 0 To Math.Ceiling(Width / 32)
                For Y = 0 To Math.Ceiling(Height / 32)
                    Dim penc As New Pen(Grid.GColor)
                    Draw.DrawRectangle(penc, New Rectangle(X * 32, Y * 32, 32, 32))
                Next
            Next
        End If

        Dim graphic As Graphics = Draw
        graphic.TranslateTransform(AutoScrollPosition.X, AutoScrollPosition.Y, Drawing2D.MatrixOrder.Prepend)

        'BG BGOs
        For Each i As BGO In Backgrounds.BGOs.ToList
            If graphic.IsVisible(i.PositionRect) And Not i.ForeGround Then
                graphic.DrawImage(Image.FromFile(ResolveBGOID(i.ID)), i.PositionRect, New Rectangle(0, 0, i.BGOGraphicsSize.Width, i.BGOGraphicsSize.Height), GraphicsUnit.Pixel)
            End If
        Next

        For Each i As Block In Blocks.Tiles.ToList
            If graphic.IsVisible(i.PositionRect) Then
                graphic.DrawImage(Image.FromFile(ResolveBlockID(i.ID)), i.PositionRect, 0, 0, i.GraphicSize.Width, i.GraphicSize.Height, GraphicsUnit.Pixel)
            End If
        Next

        If Not ObjectPlacement.player1SpawnLocation.IsEmpty Then
            graphic.DrawImage(PlayerGraphic, ObjectPlacement.player1SpawnLocation, New Rectangle(500, 0, 24, 54), GraphicsUnit.Pixel)
        End If

        If Not ObjectPlacement.player2SpawnLocation.IsEmpty Then
            graphic.DrawImage(Player2Graphic, ObjectPlacement.player1SpawnLocation, New Rectangle(500, 0, 24, 56), GraphicsUnit.Pixel)
        End If

        For Each i As NPCsets In NPC.NPCsets
            If graphic.IsVisible(i.PositionRect) Then
                If i.ID >= 1 Then
                    If i.Direction = 2 Then
                        graphic.DrawImage(Image.FromFile(ResolveNPCID(i.ID)), i.PositionRect, New Rectangle(0, 0, i.NPCGraphicsSize.Width, i.NPCSize.Height), GraphicsUnit.Pixel)
                    ElseIf i.Direction = 1 Then
                        Select Case i.NPCFrames.GetFramestyle
                            Case 0
                                graphic.DrawImage(Image.FromFile(ResolveNPCID(i.ID)), i.PositionRect, New Rectangle(0, 0, i.NPCGraphicsSize.Width, i.NPCSize.Height), GraphicsUnit.Pixel)
                            Case 1
                                graphic.DrawImage(Image.FromFile(ResolveNPCID(i.ID)), i.PositionRect, New Rectangle(0, i.NPCGraphicsSize.Height * 0.5, i.NPCGraphicsSize.Width, i.NPCSize.Height), GraphicsUnit.Pixel)
                            Case 2
                                graphic.DrawImage(Image.FromFile(ResolveNPCID(i.ID)), i.PositionRect, New Rectangle(0, i.NPCGraphicsSize.Height * 0.25, i.NPCGraphicsSize.Width, i.NPCSize.Height), GraphicsUnit.Pixel)
                            Case 3
                                graphic.DrawImage(Image.FromFile(ResolveNPCID(i.ID)), i.PositionRect, New Rectangle(0, i.NPCGraphicsSize.Height / 3, i.NPCGraphicsSize.Width, i.NPCSize.Height), GraphicsUnit.Pixel)
                        End Select
                    End If
                End If
            End If
        Next

        'FG BGOs
        For Each i As BGO In Backgrounds.BGOs.ToList
            If graphic.IsVisible(i.PositionRect) Then
                If i.BGOFrames.isAnimated And i.ForeGround Then
                    graphic.DrawImage(Image.FromFile(ResolveBGOID(i.ID)), i.PositionRect, New Rectangle(0, 0, i.BGOGraphicsSize.Width, i.BGOSize.Height), GraphicsUnit.Pixel)
                End If
            End If
        Next

        If ObjectPlacement.MouseIsMoving Then
            Select Case ObjectPlacement.EditMode
                Case 0
                    graphic.DrawImage(ObjectPlacement.TB.Image, ObjectPlacement.PlacementRect, BlockSourceRect(), GraphicsUnit.Pixel)
                Case 2
                    graphic.DrawImage(ObjectPlacement.TB.Image, ObjectPlacement.PlacementRect, BGOSourceRect(), GraphicsUnit.Pixel)
                Case 3
                    graphic.DrawImage(PlayerGraphic, ObjectPlacement.PlacementRect, New Rectangle(500, 0, 26, 56), GraphicsUnit.Pixel)
                Case 4
                    graphic.DrawImage(Player2Graphic, ObjectPlacement.PlacementRect, New Rectangle(500, 0, 26, 58), GraphicsUnit.Pixel)
                Case 5
                    Select Case NPC.NPCFrames.GetFramestyle
                        Case 0
                            graphic.DrawImage(ObjectPlacement.TB.Image, ObjectPlacement.PlacementRect, New Rectangle(0, 0, NPC.NPCGraphicsSize.Width, NPC.NPCSize.Height), GraphicsUnit.Pixel)
                        Case 1
                            If NPC.Direction = 2 Then
                                graphic.DrawImage(ObjectPlacement.TB.Image, ObjectPlacement.PlacementRect, New Rectangle(0, 0, NPC.NPCGraphicsSize.Width, NPC.NPCSize.Height), GraphicsUnit.Pixel)
                            ElseIf NPC.Direction = 1 Then
                                graphic.DrawImage(ObjectPlacement.TB.Image, ObjectPlacement.PlacementRect, New Rectangle(0, NPC.NPCGraphicsSize.Height * 0.5, NPC.NPCGraphicsSize.Width, NPC.NPCSize.Height), GraphicsUnit.Pixel)
                            End If
                        Case 2
                            If NPC.Direction = 2 Then
                                graphic.DrawImage(ObjectPlacement.TB.Image, ObjectPlacement.PlacementRect, New Rectangle(0, 0, NPC.NPCGraphicsSize.Width, NPC.NPCSize.Height), GraphicsUnit.Pixel)
                            ElseIf NPC.Direction = 1 Then
                                graphic.DrawImage(ObjectPlacement.TB.Image, ObjectPlacement.PlacementRect, New Rectangle(0, NPC.NPCGraphicsSize.Height * 0.25, NPC.NPCGraphicsSize.Width, NPC.NPCSize.Height), GraphicsUnit.Pixel)
                            End If
                        Case 3
                            If NPC.Direction = 2 Then
                                graphic.DrawImage(ObjectPlacement.TB.Image, ObjectPlacement.PlacementRect, New Rectangle(0, 0, NPC.NPCGraphicsSize.Width, NPC.NPCSize.Height), GraphicsUnit.Pixel)
                            ElseIf NPC.Direction = 1 Then
                                graphic.DrawImage(ObjectPlacement.TB.Image, ObjectPlacement.PlacementRect, New Rectangle(0, NPC.NPCGraphicsSize.Height / 3, NPC.NPCGraphicsSize.Width, NPC.NPCSize.Height), GraphicsUnit.Pixel)
                            End If
                    End Select
            End Select
        End If

        graphic.ResetTransform()

        If ObjectPlacement.EditMode <> 1 Then
            Draw.DrawImage(My.Resources.Pointer, ObjectPlacement.PointRec)
        Else
            Draw.DrawImage(My.Resources.Eraser, ObjectPlacement.EraseRec)
        End If

        Draw.ResetTransform()
        FPScounter += 1
    End Sub

    Private Function BlockSourceRect() As Rectangle
        Dim ResizeWidth As Integer = Blocks.GraphicsSize.Width
        Dim ResizeHeight As Integer = Blocks.BlockSize.Height
        Return New Rectangle(0, 0, ResizeWidth, ResizeHeight)
    End Function

    Private Function BGOSourceRect() As Rectangle
        Dim BGOWidth As Integer = Backgrounds.BGOSize.Width
        Dim BGOHeight As Integer = Backgrounds.BGOSize.Height
        Return New Rectangle(0, 0, BGOWidth, BGOHeight)
    End Function

    Private Function NPCSourceRect() As Rectangle
        Dim NPCWidth As Integer = NPC.NPCGraphicsSize.Width
        Dim NPCHeight As Integer = NPC.NPCSize.Height
        Return New Rectangle(0, 0, NPCWidth, NPCHeight)
    End Function

    Private Function ResolveBlockID(ByVal id As Integer) As String
        Return String.Format("{0}\graphics\block\block-{1}.png", Main.GetGamePath(), id)
    End Function

    Private Function ResolveBGOID(ByVal id As Integer) As String
        Return String.Format("{0}\graphics\background\background-{1}.png", Main.GetGamePath(), id)
    End Function

    Private Function ResolveNPCID(ByVal id As Integer) As String
        Return String.Format("{0}\graphics\npc\npc-{1}.png", Main.GetGamePath(), id)
    End Function

    Private Sub Form2_Scroll(sender As Object, e As System.Windows.Forms.ScrollEventArgs) Handles Me.Scroll
        If e.ScrollOrientation = ScrollOrientation.VerticalScroll Then
            Parallax += (e.OldValue - e.NewValue)
            Refresh()
        End If
    End Sub

    Private Sub Animation_Tick(sender As System.Object, e As System.EventArgs) Handles Animation.Tick
        If ObjectPlacement.MouseIsMoving Then
            Update()
        End If

        ObjectPlacement.curscreen = New Rectangle(AutoScrollPosition.X * -1, AutoScrollPosition.Y * -1, Width, Height)
    End Sub

    Private Sub Form2_SizeChanged(sender As Object, e As EventArgs) Handles MyBase.SizeChanged
        ObjectPlacement.screen = New Rectangle(0, 0, Width, Height)

        If Width > Level.LevelW + 32 Then
            Width = Level.LevelW + 32
        ElseIf Height > Level.LevelH + 32 Then
            Height = Level.LevelH + 32
        End If
    End Sub

    Private Sub OpenFileDialog2_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs)

    End Sub
End Class