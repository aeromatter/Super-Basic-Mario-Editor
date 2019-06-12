Imports MarioEditor.libZPlay

Public Class Audio

    Public Shared PlaySFX As New ZPlay()
    Public Shared playSong As New ZPlay()

    Public Shared Sub PlaySound(ByVal name As String)
        PlayAudio(String.Format("{0}\sound\{1}.ogg", Main.GetGamePath(), name))
    End Sub

    Public Shared Sub PlayMusic(ByVal name As String)
        LoopMusic(String.Format("{0}\music\{1}", Main.GetGamePath(), name))
    End Sub

    Public Shared Sub PlayAudio(ByVal sound As String)
        PlaySFX.StopPlayback()
        PlaySFX.OpenFile(sound, TStreamFormat.sfAutodetect)
        PlaySFX.StartPlayback()
    End Sub

    Public Shared Sub LoopMusic(ByVal musicname As String)
        playSong.StopPlayback()
        playSong.OpenFile(musicname, TStreamFormat.sfAutodetect)
        playSong.StartPlayback()
    End Sub
End Class