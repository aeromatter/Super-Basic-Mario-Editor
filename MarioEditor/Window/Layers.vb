Public Class Layers
    Private layerData As New Layer

    Private Sub Layers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        layerData.CreateDefaultLayers()

        UpdateLayersList()
    End Sub

    Private Sub AddLayerButton_Click(sender As Object, e As EventArgs) Handles AddLayerButton.Click
        If Not Layer.LayerInfo.ContainsKey(layerNameBox.Text) Then
            layerData.AddNewLayer(layerNameBox.Text, True)
            UpdateLayersList()
        End If
    End Sub

    Private Sub RemoveLayerButton_Click(sender As Object, e As EventArgs) Handles RemoveLayerButton.Click
        If LayersCheckedList.SelectedItem IsNot Nothing Then
            layerData.RemoveLayer(LayersCheckedList.SelectedItem)
            UpdateLayersList()
        End If
    End Sub

    Private Sub UpdateLayersList()
        LayersCheckedList.Items.Clear()

        For i = 0 To Layer.LayerInfo.Count - 1
            LayersCheckedList.Items.Add(Layer.LayerInfo.Keys(i), Layer.LayerInfo.Values(i))
        Next
    End Sub

    Private Sub LayersCheckedList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LayersCheckedList.SelectedIndexChanged
        If LayersCheckedList.SelectedItem IsNot Nothing Then
            ObjectPlacement.SelectedLayer = LayersCheckedList.SelectedItem.ToString()
        End If
    End Sub
End Class