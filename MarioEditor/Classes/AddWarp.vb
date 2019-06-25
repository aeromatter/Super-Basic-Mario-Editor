Public Class AddWarp
    Inherits ObjectPlacement

    Public Sub SetWarp()
        WarpSets.entranceDir = Warps.warpEntranceDir
        WarpSets.exitDir = Warps.warpExitDir
        WarpSets.entranceLocation = PlacementRect
        WarpSets.passage = Warps.passageType
        WarpSets.placement = Warps.placementType
        WarpSets.starsNeeded = Warps.stars
        WarpSets.warp = Warps.warpType

        PlaceWarp()
    End Sub

    Public Sub PlaceWarp()
        If isMouseOnscreen() And MouseIsDown Then
            Warps.LevelWarps.Add(WarpSets)
        End If
    End Sub
End Class
