Public Class AddPlayerSpawn
    Inherits ObjectPlacement

    Public Sub SetPlayer1Spawn()
        If isValidPlacement(PlacementRect) And MouseIsDown Then
            player1SpawnLocation = PlacementRect
        End If
    End Sub

    Public Sub SetPlayer2Spawn()
        If isValidPlacement(PlacementRect) And MouseIsDown Then
            player2SpawnLocation = PlacementRect
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
