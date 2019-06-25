Public Class AddLiquid
    Inherits ObjectPlacement

    Public Sub SetLiquid()
        LiquidSets.LiquidArea = New Rectangle(PlacementRect.X, PlacementRect.Y, Liquids.LiquidArea.Width, Liquids.LiquidArea.Height)
        LiquidSets.isQuicksand = Liquids.isQuicksand

        PlaceLiquid()
    End Sub

    Public Sub PlaceLiquid()
        If isMouseOnscreen() And MouseIsDown Then
            Liquids.LiquidInfo.Add(LiquidSets)
        End If
    End Sub
End Class
