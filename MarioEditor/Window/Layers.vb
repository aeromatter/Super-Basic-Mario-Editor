Public Class Layers

    Public Shared LayerInfo As Dictionary(Of String, Boolean) = New Dictionary(Of String, Boolean)

    Public Sub CreateDefaultLayers()
        LayerInfo.Add("Default", True)
        LayerInfo.Add("Destroyed Blocks", False)
        LayerInfo.Add("Spawned NPCs", True)
    End Sub

    Public Sub AddNewLayer(entryName As String, isVisible As Boolean)
        LayerInfo.Add(entryName, isVisible)
    End Sub

    Public Sub RemoveLayer(entryName As String)
        LayerInfo.Remove(entryName)
    End Sub

    Private Sub Layers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UpdateLayersList()
    End Sub

    Private Sub AddLayerButton_Click(sender As Object, e As EventArgs) Handles AddLayerButton.Click
        If Not LayerInfo.ContainsKey(layerNameBox.Text) Then
            AddNewLayer(layerNameBox.Text, True)
            UpdateLayersList()
        End If
    End Sub

    Private Sub RemoveLayerButton_Click(sender As Object, e As EventArgs) Handles RemoveLayerButton.Click
        If LayersCheckedList.SelectedItem IsNot Nothing Then
            RemoveLayer(LayersCheckedList.SelectedItem)
            UpdateLayersList()
        End If
    End Sub

    Private Sub UpdateLayersList()
        LayersCheckedList.Items.Clear()

        For i = 0 To LayerInfo.Count - 1
            LayersCheckedList.Items.Add(LayerInfo.Keys(i), LayerInfo.Values(i))
        Next
    End Sub

    Private Sub LayersCheckedList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LayersCheckedList.SelectedIndexChanged
        If LayersCheckedList.SelectedItem IsNot Nothing Then
            ObjectPlacement.SelectedLayer = LayersCheckedList.SelectedItem.ToString()
        End If
    End Sub
End Class