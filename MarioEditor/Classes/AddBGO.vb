Public Class AddBGO
    Inherits ObjectPlacement

    Public Sub SetBGO()
        BGOSets.PositionRect = PlacementRect
        BGOSets.Layer = SelectedLayer
        BGOSets.IMG = TB.Image
        BGOSets.BGOSize = Backgrounds.BGOSize
        BGOSets.ID = SelectedBGO
        BGOSets.BGOGraphicsSize = Backgrounds.BGOGraphicsSize
        BGOSets.BGOFrames = Backgrounds.BGOFrames
        BGOSets.ForeGround = Backgrounds.ForeGround

        PlaceBGO()
    End Sub

    Private Function isValidPlacement(ByVal position As Rectangle)
        Return Not Backgrounds.bgorects.Contains(position)
    End Function

    Private Sub PlaceBGO()
        If isValidPlacement(PlacementRect) And Not Backgrounds.bgorects.Contains(BGOSets.PositionRect) And isMouseOnscreen() And MouseIsDown Then
            Backgrounds.bgorects.Add(BGOSets.PositionRect)
            Backgrounds.BGOs.Add(BGOSets)
        End If
    End Sub
End Class