Public Class AddNPC
    Inherits ObjectPlacement

    Public Sub SetNPC()
        NPCSets.PositionRect = PlacementRect

        NPCSets.IMG = TB.Image
        NPCSets.NPCSize = NPC.NPCSize
        NPCSets.ID = SelectedNPC
        NPCSets.NPCGraphicsSize = NPC.NPCGraphicsSize
        NPCSets.NPCFrames = NPC.NPCFrames
        NPCSets.AI = NPC.AI
        NPCSets.Direction = NPC.Direction
        NPCSets.HasGravity = NPC.HasGravity
        NPCSets.MSG = NPC.Message
        NPCSets.MoveSpeed = NPC.MoveSpeed
        NPCSets.MetroidGlass = NPC.MetroidGlass
        NPCSets.NPCcollide = NPC.NPCcollide

        PlaceNPC()
    End Sub

    Private Sub PlaceNPC()
        If isValidPlacement(PlacementRect) And isMouseOnscreen() And MouseIsDown Then
            If NPCSets.NPCSize.Width > 0 And NPCSets.NPCSize.Height > 0 And NPCSets.ID > 0 And Not NPCSets.PositionRect.IsEmpty Then
                NPC.NPCrects.Add(NPCSets.PositionRect)
                NPC.NPCsets.Add(NPCSets)
            End If
        End If
    End Sub

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
End Class