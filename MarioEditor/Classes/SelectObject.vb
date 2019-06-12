Public Class SelectObject
    Inherits ObjectPlacement
    Public Sub GetSelection()
        If MouseIsDown Then
            SelectBlock()
            SelectBGO()
            SelectNPC()
            Audio.PlaySound("grab")
            LevelWindow.Invalidate()
        End If
    End Sub

    Private Sub SelectBlock()
        For Each i As Block In Blocks.Tiles.ToList
            If i.PositionRect.Contains(PlacementRect) Then
                SelectedBlock = i.ID
                Dim blocks As New Blocks
                If hasBlockSelectChanged() Then
                    blocks.GetBlockInfo()
                End If
                Blocks.Tiles.Remove(i)
                Blocks.TileRects.Remove(i.PositionRect)
                EditMode = 0
            End If
        Next
    End Sub

    Private Sub SelectBGO()
        For Each bg As BGO In Backgrounds.BGOs.ToList
            If bg.PositionRect.Contains(PlacementRect) Then
                SelectedBGO = bg.ID
                Dim bgos As New Backgrounds
                bgos.GetBGOInfo()
                Backgrounds.BGOs.Remove(bg)
                Backgrounds.bgorects.Remove(bg.PositionRect)
                EditMode = 2
            End If
        Next
    End Sub

    Private Sub SelectNPC()
        For Each i As NPCsets In NPC.NPCsets.ToList
            If i.PositionRect.Contains(PlacementRect) Then
                SelectedNPC = i.ID
                Dim npc As New NPC
                npc.GetNPCInfo()
                NPC.NPCsets.Remove(i)
                NPC.NPCrects.Remove(i.PositionRect)
                EditMode = 5
            End If
        Next
    End Sub
End Class