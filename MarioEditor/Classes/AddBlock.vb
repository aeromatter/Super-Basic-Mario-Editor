Public Class AddBlock
    Inherits ObjectPlacement

    Private Function isValidPlacement(position As Rectangle)
        Return Not isBlockOverlap(position) And Not isNPCOverlap(position)
    End Function

    Private Function isNPCOverlap(position As Rectangle)
        If NPC.NPCrects.Contains(position) Then
            Return True
        Else
            For i = 0 To NPC.NPCrects.Count - 1
                If PlacementRect.IntersectsWith(NPC.NPCrects(i)) Then
                    Return True
                End If
            Next
        End If

        Return False
    End Function

    Private Function isBlockOverlap(position As Rectangle)
        If Blocks.TileRects.Contains(position) Then
            Return True
        Else
            For i = 0 To Blocks.TileRects.Count - 1
                If PlacementRect.IntersectsWith(Blocks.TileRects(i)) Then
                    Return True
                End If
            Next
        End If

        Return False
    End Function

    Public Sub SetBlock()
        BlockSets.PositionRect = PlacementRect
        BlockSets.ID = SelectedBlock

        BlockSets.IMG = TB.Image
        BlockSets.PhysicalSize = Blocks.BlockSize
        BlockSets.GraphicSize = Blocks.GraphicsSize
        BlockSets.Frames = Blocks.Frames
        BlockSets.SizableDimensions = Blocks.SizableDimensions
        BlockSets.Lava = Blocks.Lava
        BlockSets.Breakable = Blocks.Breakable
        BlockSets.Invisible = Blocks.Invisible
        BlockSets.Slip = Blocks.Slippery

        PlaceBlock()
    End Sub

    Private Sub PlaceBlock()
        If isValidPlacement(BlockSets.PositionRect) And isMouseOnscreen() And Not Fill And MouseIsDown Then
            Blocks.TileRects.Add(BlockSets.PositionRect)
            Blocks.Tiles.Add(BlockSets)
        ElseIf isValidPlacement(BlockSets.PositionRect) And isMouseOnscreen() And Fill And MouseIsDown Then
            'Blocks.FillBlock(BlockSets.X, BlockSets.Y, BlockSets.Width, BlockSets.Height)
        End If
    End Sub
End Class