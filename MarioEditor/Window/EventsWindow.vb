Public Class EventsWindow
    Public eventInfo As New List(Of LevelEvent)
    Private eventIndex As Integer = 0

    Private toggleLayers As List(Of String)
    Private hideLayers As List(Of String)
    Private showLayers As List(Of String)

    Private Sub EventsWindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UpdateLayersList()
        UpdateEventsList()
    End Sub

    Public Sub CreateDefaultEvents()
        Dim LevelStart As New LevelEvent
        LevelStart.name = "Level - Start"

        Dim PSwitchStart As New LevelEvent
        PSwitchStart.name = "PSwitch - Start"

        Dim PSwitchEnd As New LevelEvent
        PSwitchEnd.name = "PSwitch - End"

        toggleLayers = New List(Of String)
        hideLayers = New List(Of String)
        showLayers = New List(Of String)

        AddNewEvent(LevelStart)
        AddNewEvent(PSwitchStart)
        AddNewEvent(PSwitchEnd)
    End Sub

    Private Sub AddNewEvent(newEvent As LevelEvent)
        eventInfo.Add(newEvent)

        UpdateEventsList()
    End Sub

    Private Sub UpdateEventsList()
        EventsListBox.Items.Clear()
        TriggerEventComboBox.Items.Clear()

        For i = 0 To eventInfo.Count - 1
            EventsListBox.Items.Add(eventInfo(i).name)
            TriggerEventComboBox.Items.Add(eventInfo(i).name)
        Next
    End Sub

    Private Sub UpdateLayersList()
        LayersList.Items.Clear()
        LayersComboBox.Items.Clear()

        For i = 0 To Layers.LayerInfo.Count - 1
            LayersList.Items.Add(Layers.LayerInfo.Keys(i))
            LayersComboBox.Items.Add(Layers.LayerInfo.Keys(i))
        Next
    End Sub

    Private Sub AddEventButton_Click(sender As Object, e As EventArgs) Handles AddEventButton.Click
        Dim setNewEvent As New LevelEvent
        setNewEvent.name = EventNameText.Text
        setNewEvent.smokeEnabled = NoSmokeCheck.Checked
        setNewEvent.layerMovement = LayersComboBox.Text
        setNewEvent.layerHorizontalSpeed = HorizontalSpeedSpin.Value
        setNewEvent.layerVerticalSpeed = VerticalSpeedSpin.Value
        setNewEvent.autoscrollSection = SectionScrollBar.Value
        setNewEvent.autoscrollHorizontalSpeed = AHorizontalSpeedSpin.Value
        setNewEvent.autoscrollVerticalSpeed = AVerticalSpeedSpin.Value
        setNewEvent.message = MessageText.Text
        setNewEvent.autoStart = AutoStartCheck.Checked
        setNewEvent.playSound = PlaySoundComboBox.Text
        setNewEvent.endGame = EndGameComboBox.Text
        setNewEvent.triggerEvent = TriggerEventComboBox.Text
        setNewEvent.triggerEventDelay = DelayScrollBar.Value
        setNewEvent.toggleLayers = toggleLayers
        setNewEvent.hideLayers = hideLayers
        setNewEvent.showLayers = showLayers
        AddNewEvent(setNewEvent)
    End Sub

    Private Sub NoSmokeCheck_CheckedChanged(sender As Object, e As EventArgs) Handles NoSmokeCheck.CheckedChanged
        eventInfo(eventIndex).smokeEnabled = NoSmokeCheck.Checked
    End Sub

    Private Sub EventsListBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles EventsListBox.SelectedIndexChanged
        eventIndex = EventsListBox.SelectedIndex

        EventNameText.Text = eventInfo(eventIndex).name
        NoSmokeCheck.Checked = eventInfo(eventIndex).smokeEnabled
        LayersComboBox.Text = eventInfo(eventIndex).layerMovement
        HorizontalSpeedSpin.Value = eventInfo(eventIndex).layerHorizontalSpeed
        VerticalSpeedSpin.Value = eventInfo(eventIndex).layerVerticalSpeed
        SectionScrollBar.Value = eventInfo(eventIndex).autoscrollSection
        AHorizontalSpeedSpin.Value = eventInfo(eventIndex).autoscrollHorizontalSpeed
        AVerticalSpeedSpin.Value = eventInfo(eventIndex).autoscrollVerticalSpeed
        MessageText.Text = eventInfo(eventIndex).message
        AutoStartCheck.Checked = eventInfo(eventIndex).autoStart
        PlaySoundComboBox.Text = eventInfo(eventIndex).playSound
        EndGameComboBox.Text = eventInfo(eventIndex).endGame
        TriggerEventComboBox.Text = eventInfo(eventIndex).triggerEvent
        DelayScrollBar.Value = eventInfo(eventIndex).triggerEventDelay
        For i = 0 To 20
            ToggleList.Items.Add(eventInfo(eventIndex).toggleLayers(i))
            HideList.Items.Add(eventInfo(eventIndex).hideLayers(i))
            ShowList.Items.Add(eventInfo(eventIndex).showLayers(i))
        Next
    End Sub

    Private Sub LayersComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LayersComboBox.SelectedIndexChanged
        eventInfo(eventIndex).layerMovement = LayersComboBox.Text
    End Sub

    Private Sub AutoStartCheck_CheckedChanged(sender As Object, e As EventArgs) Handles AutoStartCheck.CheckedChanged
        eventInfo(eventIndex).autoStart = AutoStartCheck.Checked
    End Sub

    Private Sub AddToggleButton_Click(sender As Object, e As EventArgs) Handles AddToggleButton.Click
        ToggleList.Items.Add(LayersList.SelectedItem)
        LayersList.Items.Remove(LayersList.SelectedItem)

        toggleLayers.Clear()
        For i = 0 To 20
            toggleLayers.Add(ToggleList.Items(i))
        Next
    End Sub

    Private Sub AddHideButton_Click(sender As Object, e As EventArgs) Handles AddHideButton.Click
        HideList.Items.Add(LayersList.SelectedItem)
        LayersList.Items.Remove(LayersList.SelectedItem)

        hideLayers.Clear()
        For i = 0 To 20
            hideLayers.Add(HideList.Items(i))
        Next
    End Sub

    Private Sub AddShowButton_Click(sender As Object, e As EventArgs) Handles AddShowButton.Click
        ShowList.Items.Add(LayersList.SelectedItem)
        LayersList.Items.Remove(LayersList.SelectedItem)

        showLayers.Clear()
        For i = 0 To 20
            showLayers.Add(ShowList.Items(i))
        Next
    End Sub

    Private Sub RemoveToggleButton_Click(sender As Object, e As EventArgs) Handles RemoveToggleButton.Click
        LayersList.Items.Add(ToggleList.SelectedItem)
        ToggleList.Items.Remove(ToggleList.SelectedItem)

        toggleLayers.Clear()
        For i = 0 To 20
            toggleLayers.Add(ToggleList.Items(i))
        Next
    End Sub

    Private Sub RemoveHideButton_Click(sender As Object, e As EventArgs) Handles RemoveHideButton.Click
        LayersList.Items.Add(HideList.SelectedItem)
        HideList.Items.Remove(HideList.SelectedItem)

        hideLayers.Clear()
        For i = 0 To 20
            hideLayers.Add(HideList.Items(i))
        Next
    End Sub

    Private Sub RemoveShowButton_Click(sender As Object, e As EventArgs) Handles RemoveShowButton.Click
        LayersList.Items.Add(ShowList.SelectedItem)
        ShowList.Items.Remove(ShowList.SelectedItem)

        showLayers.Clear()
        For i = 0 To 20
            showLayers.Add(ShowList.Items(i))
        Next
    End Sub

    Private Sub HorizontalSpeedSpin_ValueChanged(sender As Object, e As EventArgs) Handles HorizontalSpeedSpin.ValueChanged
        eventInfo(eventIndex).layerHorizontalSpeed = HorizontalSpeedSpin.Value
    End Sub

    Private Sub VerticalSpeedSpin_ValueChanged(sender As Object, e As EventArgs) Handles VerticalSpeedSpin.ValueChanged
        eventInfo(eventIndex).layerVerticalSpeed = VerticalSpeedSpin.Value
    End Sub

    Private Sub SectionScrollBar_Scroll(sender As Object, e As ScrollEventArgs) Handles SectionScrollBar.Scroll
        eventInfo(eventIndex).autoscrollSection = SectionScrollBar.Value
    End Sub

    Private Sub AHorizontalSpeedSpin_ValueChanged(sender As Object, e As EventArgs) Handles AHorizontalSpeedSpin.ValueChanged
        eventInfo(eventIndex).autoscrollHorizontalSpeed = AHorizontalSpeedSpin.Value
    End Sub

    Private Sub AVerticalSpeedSpin_ValueChanged(sender As Object, e As EventArgs) Handles AVerticalSpeedSpin.ValueChanged
        eventInfo(eventIndex).autoscrollVerticalSpeed = AVerticalSpeedSpin.Value
    End Sub
End Class

Public Class LevelEvent
    Public name As String
    Public smokeEnabled As Boolean
    Public toggleLayers As New List(Of String)
    Public hideLayers As New List(Of String)
    Public showLayers As New List(Of String)
    Public layerMovement As String
    Public layerHorizontalSpeed As Double
    Public layerVerticalSpeed As Double
    Public autoscrollSection As Integer
    Public autoscrollHorizontalSpeed As Double
    Public autoscrollVerticalSpeed As Double
    Public message As String
    Public autoStart As Boolean
    Public playSound As String
    Public endGame As String
    Public triggerEvent As String
    Public triggerEventDelay As Double
    Public position As Rectangle
    Public music As Integer
    Public background As Integer
    Public playerUp As Boolean
    Public playerDown As Boolean
    Public playerLeft As Boolean
    Public playerRight As Boolean
    Public playerRun As Boolean
    Public playerJump As Boolean
    Public playerAltRun As Boolean
    Public playerAltJump As Boolean
    Public playerDrop As Boolean
    Public playerStart As Boolean
End Class