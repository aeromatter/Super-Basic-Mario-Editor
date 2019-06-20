
Public Class Layer

    Public Shared LayerInfo As Dictionary(Of String, Boolean) = New Dictionary(Of String, Boolean)

    Public Sub CreateDefaultLayers()
        LayerInfo.Add("Default", True)
        LayerInfo.Add("Destroyed", False)
    End Sub

    Public Sub AddNewLayer(entryName As String, isVisible As Boolean)
        LayerInfo.Add(entryName, isVisible)
    End Sub

    Public Sub RemoveLayer(entryName As String)
        LayerInfo.Remove(entryName)
    End Sub
End Class
