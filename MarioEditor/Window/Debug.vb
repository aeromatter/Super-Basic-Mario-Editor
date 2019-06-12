Imports System.Diagnostics
Imports System.Windows.Input
Public Class Debug
    Public Shared TotalBlocks As Integer = 0
    Public Shared TotalBGOs As Integer = 0
    Public Shared TotalNPCs As Integer = 0
    Public Shared TotalObjBlocks As Integer = 0
    Public Shared TotalObjBGOs As Integer = 0
    Public Shared TotalObjNPCs As Integer = 0
    Public Memory As New PerformanceCounter("Memory", "Available MBytes", True)
    Public CPU As New PerformanceCounter("Process", "% Processor Time", Process.GetCurrentProcess().ProcessName, True)

    Public Shared Sub MouseLoc(X As Integer, Y As Integer)
        Debug.cursorXLabel.Text = $"X: {X}"
        Debug.cursorYLabel.Text = $"X: {Y}"
    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        Try
            memoryAvailable.Text = String.Format("Memory Available: {0}GB", Math.Round(Memory.NextValue() / 1024, 2))
            cpuLabel.Text = String.Format("CPU: {0}%", Math.Round(CPU.NextValue() * 0.5))

            Select Case ObjectPlacement.EditMode
                Case 0
                    modeLabel.Text = "Select Mode: Block"
                Case 1
                    modeLabel.Text = "Select Mode: Eraser"
                Case 2
                    modeLabel.Text = "Select Mode: BGO"
                Case 3 Or 4
                    modeLabel.Text = "Select Mode: Player"
                Case 5
                    modeLabel.Text = "Select Mode: NPC"
                Case 6
                    modeLabel.Text = "Select Mode: Selection"
            End Select

            blockIDLabel.Text = "Block ID: " & ObjectPlacement.SelectedBlock
            bgoIDLabel.Text = "BGO ID: " & ObjectPlacement.SelectedBGO
            npcIDLabel.Text = "NPC ID: " & ObjectPlacement.SelectedNPC

            Dim kc As New KeyConverter

            FPSLabel.Text = CStr(LevelWindow.FPScounter)
            LevelWindow.FPScounter = 0
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        TotalBlocks = Blocks.Tiles.Count
        TotalBGOs = Backgrounds.BGOs.Count
        TotalNPCs = NPC.NPCsets.Count

        blockCountLabel.Text = "Blocks: " & TotalBlocks
        bgoCountLabel.Text = "BGOs: " & TotalBGOs
        npcCountLabel.Text = "NPCs: " & TotalNPCs
    End Sub
End Class