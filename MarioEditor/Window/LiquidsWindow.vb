Public Class LiquidsWindow
    Private Sub LiquidsWindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub WaterWidthSpin_ValueChanged(sender As Object, e As EventArgs) Handles WaterWidthSpin.ValueChanged
        Liquids.LiquidArea.Width = WaterWidthSpin.Value
    End Sub

    Private Sub WaterHeightSpin_ValueChanged(sender As Object, e As EventArgs) Handles WaterHeightSpin.ValueChanged
        Liquids.LiquidArea.Height = WaterHeightSpin.Value
    End Sub

    Private Sub QuicksandCheck_CheckedChanged(sender As Object, e As EventArgs) Handles QuicksandCheck.CheckedChanged
        Liquids.isQuicksand = QuicksandCheck.Checked
    End Sub
End Class

Public Structure Liquid
    Public LiquidArea As Rectangle
    Public isQuicksand As Boolean
    Public layerName As String
End Structure

Public Class Liquids
    Public Shared LiquidInfo As New List(Of Liquid)
    Public Shared LiquidArea As New Rectangle
    Public Shared isQuicksand As Boolean
End Class