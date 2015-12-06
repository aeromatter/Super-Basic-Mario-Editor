Imports System.Drawing
Imports MarioEditor.libZPlay
Public Class Audio

    Public Shared PlaySFX As New ZPlay()

    Public Shared Sub PlaySound(ID As UInteger)
        Select Case ID
            Case 0
                PlayAudio(Form1.FilePath & "\sound\block-smash.ogg")
            Case 1
                PlayAudio(Form1.FilePath & "\sound\smash.ogg")
            Case 2
                PlayAudio(Form1.FilePath & "\sound\shell-hit.ogg")
            Case 3
                PlayAudio(Form1.FilePath & "\sound\level-select.ogg")
            Case 4
                PlayAudio(Form1.FilePath & "\sound\grab.ogg")
            Case 5
                PlayAudio(Form1.FilePath & "\sound\has-item.ogg")
            Case 6
                'Needs Conversion
                PlayAudio(Form1.FilePath & "\sound\thwomp.ogg")
        End Select
    End Sub

    Public Shared Sub PlayMusic(ID As UInteger)
        Select Case ID
            Case 0
                PlayAudio(Form1.FilePath & "\music\smb3-overworld.ogg")
            Case 1
                PlayAudio(Form1.FilePath & "\music\smb3-sky.ogg")
            Case 2
                PlayAudio(Form1.FilePath & "\music\smb3-castle.ogg")
            Case 3
                PlayAudio(Form1.FilePath & "\music\smb3-underground.ogg")
            Case 4
                PlayAudio(Form1.FilePath & "\music\smb2-overworld.ogg")
            Case 5
                PlayAudio(Form1.FilePath & "\music\smb3-boss.ogg")
            Case 6
                PlayAudio(Form1.FilePath & "\music\smb-underground.ogg")
            Case 7
                PlayAudio(Form1.FilePath & "\music\sf-corneria.ogg")
            Case 8
                PlayAudio(Form1.FilePath & "\music\smb-overworld.ogg")
            Case 9
                PlayAudio(Form1.FilePath & "\music\smw-overworld.ogg")
            Case 10
                PlayAudio(Form1.FilePath & "\music\sm-brinstar.ogg")
            Case 11
                PlayAudio(Form1.FilePath & "\music\sm-crateria.ogg")
            Case 12
                PlayAudio(Form1.FilePath & "\music\nsmb-overworld.ogg")
            Case 13
                PlayAudio(Form1.FilePath & "\music\sm64-desert.ogg")
            Case 14
                PlayAudio(Form1.FilePath & "\music\smb2-boss.ogg")
            Case 15
                PlayAudio(Form1.FilePath & "\music\mariorpg-forestmaze.ogg")
            Case 16
                PlayAudio(Form1.FilePath & "\music\smw-ghosthouse.ogg")
            Case 17
                PlayAudio(Form1.FilePath & "\music\smg-beach-bowl-galaxy.ogg")
            Case 18
                PlayAudio(Form1.FilePath & "\music\ssbb-airship.ogg")
            Case 19
                PlayAudio(Form1.FilePath & "\music\smg-star-reactor.ogg")
            Case 20
                PlayAudio(Form1.FilePath & "\music\mariorpg-bowser.ogg")
            Case 21
                PlayAudio(Form1.FilePath & "\music\tds-metroid-charge.ogg")
            Case 22
                PlayAudio(Form1.FilePath & "\music\z3-lost-woods.ogg")
            Case 23
                'Custom goes here
            Case 24
                PlayAudio(Form1.FilePath & "\music\smb2-underground.ogg")
            Case 25
                PlayAudio(Form1.FilePath & "\music\mario64-castle.ogg")
            Case 26
                PlayAudio(Form1.FilePath & "\music\mario64-maintheme.ogg")
            Case 27
                PlayAudio(Form1.FilePath & "\music\smw-sky.ogg")
            Case 28
                PlayAudio(Form1.FilePath & "\music\smw-cave.ogg")
            Case 29
                PlayAudio(Form1.FilePath & "\music\mariorpg-mariospad.ogg")
            Case 30
                PlayAudio(Form1.FilePath & "\music\mariorpg-seasidetown.ogg")
            Case 31
                PlayAudio(Form1.FilePath & "\music\mariorpg-tadpolepond.ogg")
            Case 32
                PlayAudio(Form1.FilePath & "\music\mariorpg-nimbusland.ogg")
            Case 33
                PlayAudio(Form1.FilePath & "\music\mariorpg-rosetown.ogg")
            Case 34
                PlayAudio(Form1.FilePath & "\music\mario64-snowmountain.ogg")
            Case 35
                PlayAudio(Form1.FilePath & "\music\mario64-boss.ogg")
            Case 36
                PlayAudio(Form1.FilePath & "\music\pm-shiver-mountain.ogg")
            Case 37
                PlayAudio(Form1.FilePath & "\music\pm-yoshis-village.ogg")
            Case 38
                PlayAudio(Form1.FilePath & "\music\ssbb-zelda2.ogg")
            Case 39
                PlayAudio(Form1.FilePath & "\music\ssbb-meta.ogg")
            Case 40
                PlayAudio(Form1.FilePath & "\music\smw-castle.ogg")
            Case 41
                PlayAudio(Form1.FilePath & "\music\smb-castle.ogg")
            Case 42
                PlayAudio(Form1.FilePath & "\music\smb2-wart.ogg")
            Case 43
                PlayAudio(Form1.FilePath & "\music\sm-itemroom.ogg")
            Case 44
                PlayAudio(Form1.FilePath & "\music\sm-brain.ogg")
            Case 45
                PlayAudio(Form1.FilePath & "\music\smb-water.ogg")
            Case 46
                PlayAudio(Form1.FilePath & "\music\smb3-water.ogg")
            Case 47
                PlayAudio(Form1.FilePath & "\music\smw-water.ogg")
            Case 48
                PlayAudio(Form1.FilePath & "\music\mario64-water.ogg")
            Case 49
                PlayAudio(Form1.FilePath & "\music\mario64-cave.ogg")
            Case 50
                PlayAudio(Form1.FilePath & "\music\smw-boss.ogg")
            Case 51
                PlayAudio(Form1.FilePath & "\music\ssbb-underground.ogg")
            Case 52
                PlayAudio(Form1.FilePath & "\music\ssbb-waluigi.ogg")
            Case 53
                PlayAudio(Form1.FilePath & "\music\smb3-hammer.ogg")
            Case 54
                PlayAudio(Form1.FilePath & "\music\smg2-fg.ogg")
            Case 55
                PlayAudio(Form1.FilePath & "\music\mkwii-mushroom-gorge.ogg")
        End Select
    End Sub

    Public Shared Sub PlayAudio(sound As String)
        PlaySFX.StopPlayback()
        PlaySFX.OpenFile(sound, TStreamFormat.sfAutodetect)
        PlaySFX.StartPlayback()
    End Sub
End Class
