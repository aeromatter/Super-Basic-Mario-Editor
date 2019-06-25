Public Enum EditorMode
    Block = 0
    Eraser = 1
    BGO = 2
    Player1 = 3
    Player2 = 4
    NPC = 5
    Selection = 6
    Warp = 7
    Liquid = 8
End Enum
Public Class ObjectPlacement
    Public Shared EditMode As Integer = 0

    'Mouse Location Variables
    Public Shared mouselocX As Integer
    Public Shared mouselocY As Integer
    Public Shared mouseToScreen As Point
    Public Shared mouseToLevel As Point

    'Placement IDs | Defaults Set
    Public Shared SelectedBlock As Integer = 1
    Public Shared SelectedBGO As Integer = 1
    Public Shared SelectedNPC As Integer = 1
    Public Shared LastBlock As Integer = 1
    Public Shared SelectedLayer As String = "Default"

    'Detect Mouse Inputs
    Public Shared MouseIsDown As Boolean = False
    Public Shared MouseIsMoving As Boolean = False

    Public Shared PlacementRect As Rectangle

    Public BlockSets As Block
    Public NPCSets As NPCsets
    Public BGOSets As BGO
    Public WarpSets As WarpSettings
    Public LiquidSets As Liquid

    Public Shared TB As TextureBrush

    Public Shared AlignFactor As Integer = 32

    Public Shared screen As New Rectangle(0, 0, 816, 632)
    Public Shared curscreen As Rectangle

    'Fill Data
    Public Shared Fill As Boolean = False
    Public Shared FillMode As Integer = 0
    Public Shared FillPoint As Integer

    'Pointer boundries
    Public Shared PointRec As Rectangle
    Public Shared EraseRec As Rectangle

    Public Shared player1SpawnLocation As Rectangle
    Public Shared player2SpawnLocation As Rectangle

    Public BlockList As List(Of String)

    Structure MouseLocToLevel
        Private mouseX As Integer
        Private mouseY As Integer

        Public Sub New(x As Integer, y As Integer)
            mouseX = x
            mouseY = y
        End Sub
        Public Function GetX()
            Return mouseX
        End Function

        Public Function GetY()
            Return mouseY
        End Function
    End Structure

    Structure ObjectAlignment
        Private xAlign As Integer
        Private yAlign As Integer

        Public Sub New(x As Integer, y As Integer)
            xAlign = x
            yAlign = y
        End Sub

        Public Function GetXAlignment()
            Return xAlign
        End Function

        Public Function GetYAlignment()
            Return yAlign
        End Function
    End Structure

    Public Shared Sub GetMouseRelativeToWindow(ByVal loc As Point)
        Dim Align As ObjectAlignment
        Dim mode As EditorMode = EditMode
        If mode = EditorMode.Player1 Or mode = EditorMode.Player2 Then
            Align = New ObjectAlignment(4, 32)
        Else
            Align = New ObjectAlignment(32, 32)
        End If

        Dim OffsetX = LevelWindow.HorizontalScroll.Value
        Dim OffsetY = LevelWindow.VerticalScroll.Value
        Dim AlignX = Align.GetXAlignment()
        Dim AlignY = Align.GetYAlignment()
        Dim MouseLoc = New MouseLocToLevel(Math.Floor((loc.X + OffsetX) / AlignX), Math.Floor((loc.Y + OffsetY) / AlignY))

        mouseToLevel = New Point(MouseLoc.GetX, MouseLoc.GetY)
        mouseToLevel.Offset(New Point((-419998 * 0.5) / 32, (-419998 * 0.5) / 32))
    End Sub

    Protected Function isMouseOnscreen()
        Return screen.Contains(mouseToScreen)
    End Function

    Public Shared Function hasBlockSelectChanged()
        If LastBlock <> SelectedBlock Then
            LastBlock = SelectedBlock
            Return True
        End If
        Return False
    End Function

    Public Shared Sub AddObject()
        Dim mode As EditorMode = EditMode

        Select Case mode
            Case EditorMode.Block
                Dim AB As New AddBlock
                PlacementRect = New Rectangle(mouseToLevel.X * AlignFactor, mouseToLevel.Y * AlignFactor, Blocks.GraphicsSize.Width, Blocks.GraphicsSize.Height)
                AB.SetBlock()
            Case EditorMode.Eraser
                Dim Eraser As New Eraser
                PlacementRect = New Rectangle(mouseToLevel.X * 32, mouseToLevel.Y * 32, 32, 32)
                Eraser.EraseObject()
            Case EditorMode.BGO
                Dim AddBGO As New AddBGO
                PlacementRect = New Rectangle(mouseToLevel.X * AlignFactor, mouseToLevel.Y * AlignFactor, Backgrounds.BGOSize.Width, Backgrounds.BGOSize.Height)
                AddBGO.SetBGO()
            Case EditorMode.Player1
                Dim AddPlayerSpawn As New AddPlayerSpawn
                PlacementRect = New Rectangle(mouseToLevel.X * AlignFactor, mouseToLevel.Y * AlignFactor, 24, 54)
                AddPlayerSpawn.SetPlayer1Spawn()
            Case EditorMode.Player2
                Dim AddPlayerSpawn As New AddPlayerSpawn
                PlacementRect = New Rectangle(mouseToLevel.X * AlignFactor, mouseToLevel.Y * AlignFactor, 24, 56)
                AddPlayerSpawn.SetPlayer2Spawn()
            Case EditorMode.NPC
                Dim AddNPC As New AddNPC
                PlacementRect = New Rectangle(mouseToLevel.X * AlignFactor, (mouseToLevel.Y * AlignFactor) - (NPC.NPCSize.Height - AlignFactor), NPC.NPCSize.Width, NPC.NPCSize.Height)
                AddNPC.SetNPC()
            Case EditorMode.Selection
                Dim SelectObject As New SelectObject
                PlacementRect = New Rectangle(mouseToLevel.X * 32, mouseToLevel.Y * 32, 32, 32)
                SelectObject.GetSelection()
            Case EditorMode.Warp
                Dim AddWarp As New AddWarp
                PlacementRect = New Rectangle(mouseToLevel.X * 32, mouseToLevel.Y * 32, 32, 32)
                AddWarp.SetWarp()
            Case EditorMode.Liquid
                Dim AddLiquid As New AddLiquid
                PlacementRect = New Rectangle(mouseToLevel.X * 32, mouseToLevel.Y * 32, Liquids.LiquidArea.Width, Liquids.LiquidArea.Height)
                AddLiquid.SetLiquid()
        End Select

        PointRec = New Rectangle(mouselocX, mouselocY, My.Resources.Pointer.Width, My.Resources.Pointer.Height)
        EraseRec = New Rectangle(mouselocX, mouselocY, My.Resources.Eraser.Width, My.Resources.Eraser.Height)

        Debug.MouseLoc(mouseToLevel.X, mouseToLevel.Y)
    End Sub
End Class