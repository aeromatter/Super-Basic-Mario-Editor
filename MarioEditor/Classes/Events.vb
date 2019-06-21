Public Class Events
    Public Structure LevelEvent
        Public name As String
        Public smokeEnabled As Boolean
        Public toggleLayers As List(Of String)
        Public hideLayers As List(Of String)
        Public showLayers As List(Of String)
        Public layerMovement As String
        Public layerHorizontalSpeed As Double
        Public layerVerticalSpeed As Double
        Public autoscrollSection As Integer
        Public autoscrollHorizontalSpeed As Double
        Public autoscrollVerticalSpeed As Double
        Public message As String
        Public autoStart As Boolean
        Public playSound As String
        Public endGame As Boolean
        Public triggerEvent As String
        Public triggerEventDelay As Double
        Public position As Point
        Public music As Integer
        Public background As Integer
    End Structure

    Public Sub CreateDefaultEvents()

    End Sub

    Public Sub AddNewEvent(entryName As String)

    End Sub

    Public Sub RemoveEvent(entryName As String)

    End Sub
End Class
