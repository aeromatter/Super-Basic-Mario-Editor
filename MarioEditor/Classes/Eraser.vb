Public Class Eraser
    Inherits ObjectPlacement
    Public Sub EraseObject()
        If MouseIsDown Then
            EraseBlock()
            EraseBGO()
            EraseNPC()
            LevelWindow.Invalidate()
        End If
    End Sub

    Private Sub EraseBlock()
        For Each i As Block In Blocks.Tiles.ToList
            If i.PositionRect.Contains(PlacementRect) Or PlacementRect.IntersectsWith(i.PositionRect) Then
                Blocks.Tiles.Remove(i)
                Blocks.TileRects.Remove(i.PositionRect)
                Audio.PlaySound("block-smash")
            End If
        Next
    End Sub

    Private Sub EraseBGO()
        For Each bg As BGO In Backgrounds.BGOs.ToList
            If bg.PositionRect.Contains(PlacementRect) Or PlacementRect.IntersectsWith(bg.PositionRect) Then
                Backgrounds.BGOs.Remove(bg)
                Backgrounds.bgorects.Remove(bg.PositionRect)
                Audio.PlaySound("smash")
            End If
        Next
    End Sub

    Private Sub EraseNPC()
        For Each i As NPCsets In NPC.NPCsets.ToList
            If i.PositionRect.Contains(PlacementRect) Or PlacementRect.IntersectsWith(i.PositionRect) Then
                NPC.NPCsets.Remove(i)
                NPC.NPCrects.Remove(i.PositionRect)
                Audio.PlaySound("shell-hit")
            End If
        Next
    End Sub
End Class