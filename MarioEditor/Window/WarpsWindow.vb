Public Class WarpsWindow
    Private Sub WarpsWindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class

Public Enum WarpEffect
    None
    Pipe
    Door
    Instant
End Enum

Public Enum WarpPlacement
    isEntrance
    isExit
End Enum

Public Enum WarpDirection
    Down
    Up
    Left
    Right
End Enum

Public Structure WarpSettings
    Public entranceDir As UInteger
    Public exitDir As UInteger
    Public entranceLocation As Rectangle
    Public exitLocation As Rectangle
    Public warp As WarpEffect
    Public placement As WarpPlacement
    Public starsNeeded As UInteger
    Public layerName As String
    Public levelName As String
    Public levelEntrance As UInteger
    Public isLevelEntrance As Boolean
    Public canExitLevel As Boolean
    Public mapWarpX As Integer
    Public mapWarpY As Integer
    Public noYoshi As Boolean
    Public allowNPC As Boolean
    Public isLocked As Boolean
End Structure

Public Class Warps
    Public Shared LevelWarps As New List(Of WarpSettings)
    Public Shared warpEntranceDir As UInteger
    Public Shared warpExitDir As UInteger
    Public Shared entranceLocation As Rectangle
    Public Shared exitLocation As Rectangle
    Public Shared warpType As WarpEffect
    Public Shared placementType As WarpPlacement
    Public Shared stars As UInteger
End Class