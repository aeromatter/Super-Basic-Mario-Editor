Public Class Level
    Public Shared BGpath As String
    Public Shared BG2path As String
    Public Shared BG As Image
    Public Shared BG2 As Image
    Public Shared BGid As UInteger
    Public Shared BG2id As UInteger
    Public Shared BGtype As Integer
    Public Shared Music As String = ""
    Public Shared Song As String = ""
    Public Shared MusicID As Integer = 0
    Public Shared LevelWrap As Boolean = False
    Public Shared OffscreenExit As Boolean = False
    Public Shared NoTurnBack As Boolean = False
    Public Shared Underwater As Boolean = False
    Public Shared LevelW As Integer = 25 * 32
    Public Shared LevelH As Integer = 19 * 32
    Public Shared HeightInc As Integer = 1
    Public Shared Time As UInteger = 300
    Public Shared TimeLeft As Integer
    Public Shared LevelPath As String = Main.GetGamePath() & "\worlds\"
    Public Shared P1start As Rectangle
    Public Shared P2start As Rectangle
    Public Shared Brightness As Integer = 100

    Public Function PrimaryBGMaxDrawTimesX() As Integer
        Return (LevelW / BG.Width) * 2
    End Function

    Public Function SecondaryBGMaxDrawTimesX() As Integer
        Return (LevelW / BG2.Width) * 2
    End Function

    Public Function PrimaryBGMaxDrawTimesY() As Integer
        Return (LevelH / BG.Height) * 2
    End Function

    Public Function PrimaryBGLocation(ByVal x As Integer) As Rectangle
        Return New Rectangle(x * BG.Width, LevelH - BG.Height, BG.Width, BG.Height)
    End Function

    Public Function SecondaryBGLocation(ByVal x As Integer) As Rectangle
        Return New Rectangle(x * BG2.Width, LevelH - (BG.Height + BG2.Height), BG2.Width, BG2.Height)
    End Function
End Class
