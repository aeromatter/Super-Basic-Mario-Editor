Imports System.Drawing
Imports MarioEditor.libZPlay

Public Class LevelSettings
    Public Shared BGColor As Color
    Public Shared PlayM As New ZPlay()

    Public Shared startpos As New TStreamTime()
    Public Shared endpos As New TStreamTime()
    Public Shared endtime As New TStreamInfo()

    Private Sub Button26_Click(sender As System.Object, e As System.EventArgs) Handles Button26.Click
        'SMB3 Blocks BG
        Main.SetLevelBG(1, 2)
        SetLevelBG()
    End Sub

    Private Sub Button27_Click(sender As System.Object, e As System.EventArgs) Handles Button27.Click
        Main.SetLevelBG(3, 2)
        SetLevelBG()
        'REPEATING BOTTOM
    End Sub

    Private Sub Button28_Click(sender As System.Object, e As System.EventArgs) Handles Button28.Click
        Main.SetLevelBG(4, 0)
        SetLevelBG()
    End Sub

    Private Sub Button29_Click(sender As System.Object, e As System.EventArgs) Handles Button29.Click
        Main.SetLevelBG(5, 0)
        SetLevelBG()
    End Sub

    Private Sub Button30_Click(sender As System.Object, e As System.EventArgs) Handles Button30.Click
        Main.SetLevelBG(7, 0)
        SetLevelBG()
    End Sub

    Private Sub Button31_Click(sender As System.Object, e As System.EventArgs) Handles Button31.Click
        Main.SetLevelBG(2, 0)
        SetLevelBG()
    End Sub

    Private Sub Button32_Click(sender As System.Object, e As System.EventArgs) Handles Button32.Click
        Main.SetLevelBG(36, 0)
        SetLevelBG()
    End Sub

    Private Sub Button33_Click(sender As System.Object, e As System.EventArgs) Handles Button33.Click
        Main.SetLevelBG(14, 0)
        SetLevelBG()
    End Sub

    Private Sub Button34_Click(sender As System.Object, e As System.EventArgs) Handles Button34.Click
        Main.SetLevelBG(15, 0)
        SetLevelBG()
    End Sub

    Private Sub Button35_Click(sender As System.Object, e As System.EventArgs) Handles Button35.Click
        Main.SetLevelBG(17, 0)
        SetLevelBG()
        'REPEATING BOTTOM
    End Sub

    Private Sub Button36_Click(sender As System.Object, e As System.EventArgs) Handles Button36.Click
        Main.SetLevelBG(20, 0)
        SetLevelBG()
    End Sub

    Private Sub Button37_Click(sender As System.Object, e As System.EventArgs) Handles Button37.Click
        Main.SetLevelBG(21, 0)
        SetLevelBG()
    End Sub

    Private Sub Button38_Click(sender As System.Object, e As System.EventArgs) Handles Button38.Click
        Main.SetLevelBG(22, 2)
        SetLevelBG()
    End Sub

    Private Sub Button39_Click(sender As System.Object, e As System.EventArgs) Handles Button39.Click
        Main.SetLevelBG(23, 0)
        SetLevelBG()
    End Sub

    Private Sub Button40_Click(sender As System.Object, e As System.EventArgs) Handles Button40.Click
        Main.SetLevelBG(24, 0)
        SetLevelBG()
    End Sub

    Private Sub Button41_Click(sender As System.Object, e As System.EventArgs) Handles Button41.Click
        Main.SetLevelBG(26, 0)
        SetLevelBG()
    End Sub

    Private Sub Button42_Click(sender As System.Object, e As System.EventArgs) Handles Button42.Click
        Main.SetLevelBG(27, 0)
        SetLevelBG()
    End Sub

    Private Sub Button43_Click(sender As System.Object, e As System.EventArgs) Handles Button43.Click
        Main.SetLevelBG(35, 36)
        SetLevelBG()
    End Sub

    Private Sub Button44_Click(sender As System.Object, e As System.EventArgs) Handles Button44.Click
        Main.SetLevelBG(37, 36)
        SetLevelBG()
    End Sub

    Private Sub Button45_Click(sender As System.Object, e As System.EventArgs) Handles Button45.Click
        Main.SetLevelBG(38, 0)
        SetLevelBG()
        'REPEATING BOTTOM
    End Sub

    Private Sub Button46_Click(sender As System.Object, e As System.EventArgs) Handles Button46.Click
        Main.SetLevelBG(39, 0)
        SetLevelBG()
    End Sub

    Private Sub Button47_Click(sender As System.Object, e As System.EventArgs) Handles Button47.Click
        Main.SetLevelBG(56, 0)
        SetLevelBG()
    End Sub

    Private Sub Button19_Click(sender As System.Object, e As System.EventArgs) Handles Button19.Click
        Level.Music = Form1.FilePath & "\music\smb3-overworld.ogg"

        SetLevelMusic()
    End Sub

    Private Sub Button20_Click(sender As System.Object, e As System.EventArgs) Handles Button20.Click
        Level.Music = Form1.FilePath & "\music\smb3-sky.ogg"

        SetLevelMusic()
    End Sub

    Private Sub Button21_Click(sender As System.Object, e As System.EventArgs) Handles Button21.Click
        Level.Music = Form1.FilePath & "\music\smb3-underground.ogg"

        SetLevelMusic()
    End Sub

    Private Sub Button22_Click(sender As System.Object, e As System.EventArgs) Handles Button22.Click
        Level.Music = Form1.FilePath & "\music\smb3-castle.ogg"

        SetLevelMusic()
    End Sub

    Private Sub Button23_Click(sender As System.Object, e As System.EventArgs) Handles Button23.Click
        Level.Music = Form1.FilePath & "\music\smb3-boss.ogg"

        SetLevelMusic()
    End Sub

    Private Sub Button24_Click(sender As System.Object, e As System.EventArgs) Handles Button24.Click
        Level.Music = Form1.FilePath & "\music\smb3-water.ogg"

        SetLevelMusic()
    End Sub

    Private Sub Button25_Click(sender As System.Object, e As System.EventArgs) Handles Button25.Click
        Level.Music = Form1.FilePath & "\music\smb3-hammer.ogg"

        SetLevelMusic()
    End Sub

    Private Sub Button61_Click(sender As System.Object, e As System.EventArgs) Handles Button61.Click
        Main.SetLevelBG(11, 0)
        SetLevelBG()
    End Sub

    Private Sub LevelSettings_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        TextBox2.Text = Level.LevelW / 32
        TextBox3.Text = Level.LevelH / 32

        NumericUpDown1.Value = Play.GravityLevel

        TrackBar1.Value = Level.Brightness / 10
    End Sub

    Private Sub Button8_Click(sender As System.Object, e As System.EventArgs) Handles Button8.Click
        Try
            If Convert.ToInt32(TextBox2.Text) * 32 > Form2.Width / 32 And Convert.ToInt32(TextBox3.Text) * 32 > Form2.Height / 32 Then
                Level.LevelW = Convert.ToInt32(TextBox2.Text) * 32
                Level.LevelH = Convert.ToInt32(TextBox3.Text) * 32

                Form2.AutoScrollMinSize = New Size(Level.LevelW, Level.LevelH)

                Level.HeightInc = ((Level.LevelH - (19 * 32)) + 32) / 32
                Form2.Update()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub Button62_Click(sender As System.Object, e As System.EventArgs) Handles Button62.Click
        Main.SetLevelBG(8, 0)
        SetLevelBG()
    End Sub

    Private Sub Button63_Click(sender As System.Object, e As System.EventArgs) Handles Button63.Click
        Main.SetLevelBG(9, 0)
        SetLevelBG()
    End Sub

    Private Sub Button64_Click(sender As System.Object, e As System.EventArgs) Handles Button64.Click
        Main.SetLevelBG(10, 9)
        SetLevelBG()
    End Sub

    Private Sub Button65_Click(sender As System.Object, e As System.EventArgs) Handles Button65.Click
        Main.SetLevelBG(41, 0)
        SetLevelBG()
    End Sub

    Private Sub Button66_Click(sender As System.Object, e As System.EventArgs) Handles Button66.Click
        Main.SetLevelBG(50, 0)
        SetLevelBG()
    End Sub

    Private Sub Button67_Click(sender As System.Object, e As System.EventArgs) Handles Button67.Click
        Main.SetLevelBG(51, 0)
        SetLevelBG()
    End Sub

    Private Sub Button68_Click(sender As System.Object, e As System.EventArgs) Handles Button68.Click
        Level.Music = Form1.FilePath & "\music\smb-overworld.ogg"

        SetLevelMusic()
    End Sub

    Private Sub Button69_Click(sender As System.Object, e As System.EventArgs) Handles Button69.Click
        Level.Music = Form1.FilePath & "\music\smb-underground.ogg"

        SetLevelMusic()
    End Sub

    Private Sub Button70_Click(sender As System.Object, e As System.EventArgs) Handles Button70.Click
        Level.Music = Form1.FilePath & "\music\smb-castle.ogg"

        SetLevelMusic()
    End Sub

    Private Sub Button71_Click(sender As System.Object, e As System.EventArgs) Handles Button71.Click
        Level.Music = Form1.FilePath & "\music\smb-water.ogg"

        SetLevelMusic()
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        smb_settings.Visible = True
        smb2_settings.Visible = False
        smb3_settings.Visible = False
        smw_settings.Visible = False
        mariorpg_settings.Visible = False
        mario64_settings.Visible = False
        misc_settings.Visible = False
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        smb_settings.Visible = False
        smb2_settings.Visible = False
        smb3_settings.Visible = True
        smw_settings.Visible = False
        mariorpg_settings.Visible = False
        mario64_settings.Visible = False
        misc_settings.Visible = False
    End Sub

    Private Sub Button48_Click(sender As System.Object, e As System.EventArgs) Handles Button48.Click
        Main.SetLevelBG(6, 0)
        SetLevelBG()
    End Sub

    Private Sub Button49_Click(sender As System.Object, e As System.EventArgs) Handles Button49.Click
        Main.SetLevelBG(25, 0)
        SetLevelBG()
    End Sub

    Private Sub Button50_Click(sender As System.Object, e As System.EventArgs) Handles Button50.Click
        Main.SetLevelBG(44, 0)
        SetLevelBG()
    End Sub

    Private Sub Button51_Click(sender As System.Object, e As System.EventArgs) Handles Button51.Click
        Main.SetLevelBG(48, 0)
        SetLevelBG()
    End Sub

    Private Sub Button52_Click(sender As System.Object, e As System.EventArgs) Handles Button52.Click
        Main.SetLevelBG(49, 0)
        SetLevelBG()
    End Sub

    Private Sub Button53_Click(sender As System.Object, e As System.EventArgs) Handles Button53.Click
        Main.SetLevelBG(52, 0)
        SetLevelBG()
    End Sub

    Private Sub Button54_Click(sender As System.Object, e As System.EventArgs) Handles Button54.Click
        Main.SetLevelBG(53, 0)
        SetLevelBG()
    End Sub

    Private Sub Button55_Click(sender As System.Object, e As System.EventArgs) Handles Button55.Click
        Main.SetLevelBG(54, 0)
        SetLevelBG()
    End Sub

    Private Sub Button56_Click(sender As System.Object, e As System.EventArgs) Handles Button56.Click
        Main.SetLevelBG(57, 0)
        SetLevelBG()
    End Sub

    Private Sub Button57_Click(sender As System.Object, e As System.EventArgs) Handles Button57.Click
        Level.Music = Form1.FilePath & "\music\smb2-overworld.ogg"

        SetLevelMusic()
    End Sub

    Private Sub Button58_Click(sender As System.Object, e As System.EventArgs) Handles Button58.Click
        Level.Music = Form1.FilePath & "\music\smb2-underground.ogg"

        SetLevelMusic()
    End Sub

    Private Sub Button59_Click(sender As System.Object, e As System.EventArgs) Handles Button59.Click
        Level.Music = Form1.FilePath & "\music\smb2-boss.ogg"

        SetLevelMusic()
    End Sub

    Private Sub Button60_Click(sender As System.Object, e As System.EventArgs) Handles Button60.Click
        Level.Music = Form1.FilePath & "\music\smb2-wart.ogg"

        SetLevelMusic()
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        smb_settings.Visible = False
        smb2_settings.Visible = True
        smb3_settings.Visible = False
        smw_settings.Visible = False
        mariorpg_settings.Visible = False
        mario64_settings.Visible = False
        misc_settings.Visible = False
    End Sub

    Private Sub Button72_Click(sender As System.Object, e As System.EventArgs) Handles Button72.Click
        Main.SetLevelBG(12, 0)
        SetLevelBG()
    End Sub

    Private Sub Button73_Click(sender As System.Object, e As System.EventArgs) Handles Button73.Click
        Main.SetLevelBG(32, 0)
        SetLevelBG()
    End Sub

    Private Sub Button74_Click(sender As System.Object, e As System.EventArgs) Handles Button74.Click
        Main.SetLevelBG(34, 0)
        SetLevelBG()
    End Sub

    Private Sub Button75_Click(sender As System.Object, e As System.EventArgs) Handles Button75.Click
        Main.SetLevelBG(33, 0)
        SetLevelBG()
    End Sub

    Private Sub Button76_Click(sender As System.Object, e As System.EventArgs) Handles Button76.Click
        Main.SetLevelBG(31, 0)
        SetLevelBG()
    End Sub

    Private Sub Button77_Click(sender As System.Object, e As System.EventArgs) Handles Button77.Click
        Main.SetLevelBG(18, 0)
        SetLevelBG()
    End Sub

    Private Sub Button78_Click(sender As System.Object, e As System.EventArgs) Handles Button78.Click
        Main.SetLevelBG(19, 0)
        SetLevelBG()
    End Sub

    Private Sub Button79_Click(sender As System.Object, e As System.EventArgs) Handles Button79.Click
        Main.SetLevelBG(13, 0)
        SetLevelBG()
    End Sub

    Private Sub Button80_Click(sender As System.Object, e As System.EventArgs) Handles Button80.Click
        Main.SetLevelBG(29, 0)
        SetLevelBG()
    End Sub

    Private Sub Button81_Click(sender As System.Object, e As System.EventArgs) Handles Button81.Click
        Main.SetLevelBG(30, 0)
        SetLevelBG()
    End Sub

    Private Sub Button82_Click(sender As System.Object, e As System.EventArgs) Handles Button82.Click
        Main.SetLevelBG(42, 0)
        SetLevelBG()
    End Sub

    Private Sub Button83_Click(sender As System.Object, e As System.EventArgs) Handles Button83.Click
        Main.SetLevelBG(43, 0)
        SetLevelBG()
    End Sub

    Private Sub Button84_Click(sender As System.Object, e As System.EventArgs) Handles Button84.Click
        Main.SetLevelBG(28, 0)
        SetLevelBG()
    End Sub

    Private Sub Button85_Click(sender As System.Object, e As System.EventArgs) Handles Button85.Click
        Main.SetLevelBG(55, 0)
        SetLevelBG()
    End Sub

    Private Sub Button86_Click(sender As System.Object, e As System.EventArgs) Handles Button86.Click
        Main.SetLevelBG(58, 0)
        SetLevelBG()
    End Sub

    Private Sub Button87_Click(sender As System.Object, e As System.EventArgs) Handles Button87.Click
        Level.Music = Form1.FilePath & "\music\smw-overworld.ogg"

        SetLevelMusic()
    End Sub

    Private Sub Button88_Click(sender As System.Object, e As System.EventArgs) Handles Button88.Click
        Level.Music = Form1.FilePath & "\music\smw-sky.ogg"

        SetLevelMusic()
    End Sub

    Private Sub Button89_Click(sender As System.Object, e As System.EventArgs) Handles Button89.Click
        Level.Music = Form1.FilePath & "\music\smw-cave.ogg"

        SetLevelMusic()
    End Sub

    Private Sub Button90_Click(sender As System.Object, e As System.EventArgs) Handles Button90.Click
        Level.Music = Form1.FilePath & "\music\smw-ghosthouse.ogg"

        SetLevelMusic()
    End Sub

    Private Sub Button91_Click(sender As System.Object, e As System.EventArgs) Handles Button91.Click
        Level.Music = Form1.FilePath & "\music\smw-castle.ogg"

        SetLevelMusic()
    End Sub

    Private Sub Button92_Click(sender As System.Object, e As System.EventArgs) Handles Button92.Click
        Level.Music = Form1.FilePath & "\music\smw-water.ogg"

        SetLevelMusic()
    End Sub

    Private Sub Button93_Click(sender As System.Object, e As System.EventArgs) Handles Button93.Click
        Level.Music = Form1.FilePath & "\music\smw-boss.ogg"

        SetLevelMusic()
    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        smb_settings.Visible = False
        smb2_settings.Visible = False
        smb3_settings.Visible = False
        smw_settings.Visible = True
        mariorpg_settings.Visible = False
        mario64_settings.Visible = False
        misc_settings.Visible = False
    End Sub

    Private Sub Button94_Click(sender As System.Object, e As System.EventArgs) Handles Button94.Click
        Level.Music = Form1.FilePath & "\music\mariorpg-forestmaze.ogg"

        SetLevelMusic()
    End Sub

    Private Sub Button95_Click(sender As System.Object, e As System.EventArgs) Handles Button95.Click
        Level.Music = Form1.FilePath & "\music\mariorpg-mariospad.ogg"

        SetLevelMusic()
    End Sub

    Private Sub Button96_Click(sender As System.Object, e As System.EventArgs) Handles Button96.Click
        Level.Music = Form1.FilePath & "\music\mariorpg-seasidetown.ogg"

        SetLevelMusic()
    End Sub

    Private Sub Button97_Click(sender As System.Object, e As System.EventArgs) Handles Button97.Click
        Level.Music = Form1.FilePath & "\music\mariorpg-bowser.ogg"

        SetLevelMusic()
    End Sub

    Private Sub Button98_Click(sender As System.Object, e As System.EventArgs) Handles Button98.Click
        Level.Music = Form1.FilePath & "\music\mariorpg-rosetown.ogg"

        SetLevelMusic()
    End Sub

    Private Sub Button99_Click(sender As System.Object, e As System.EventArgs) Handles Button99.Click
        Level.Music = Form1.FilePath & "\music\mariorpg-nimbusland.ogg"

        SetLevelMusic()
    End Sub

    Private Sub Button100_Click(sender As System.Object, e As System.EventArgs) Handles Button100.Click
        Level.Music = Form1.FilePath & "\music\mariorpg-tadpolepond.ogg"

        SetLevelMusic()
    End Sub

    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles Button5.Click
        smb_settings.Visible = False
        smb2_settings.Visible = False
        smb3_settings.Visible = False
        smw_settings.Visible = False
        mariorpg_settings.Visible = True
        mario64_settings.Visible = False
        misc_settings.Visible = False
    End Sub

    Private Sub Button101_Click(sender As System.Object, e As System.EventArgs) Handles Button101.Click
        Level.Music = Form1.FilePath & "\music\mario64-maintheme.ogg"

        SetLevelMusic()
    End Sub

    Private Sub Button102_Click(sender As System.Object, e As System.EventArgs) Handles Button102.Click
        Level.Music = Form1.FilePath & "\music\mario64-castle.ogg"

        SetLevelMusic()
    End Sub

    Private Sub Button103_Click(sender As System.Object, e As System.EventArgs) Handles Button103.Click
        Level.Music = Form1.FilePath & "\music\sm64-desert.ogg"

        SetLevelMusic()
    End Sub

    Private Sub Button104_Click(sender As System.Object, e As System.EventArgs) Handles Button104.Click
        Level.Music = Form1.FilePath & "\music\mario64-snowmountain.ogg"

        SetLevelMusic()
    End Sub

    Private Sub Button105_Click(sender As System.Object, e As System.EventArgs) Handles Button105.Click
        Level.Music = Form1.FilePath & "\music\mario64-boss.ogg"

        SetLevelMusic()
    End Sub

    Private Sub Button106_Click(sender As System.Object, e As System.EventArgs) Handles Button106.Click
        Level.Music = Form1.FilePath & "\music\mario64-water.ogg"

        SetLevelMusic()
    End Sub

    Private Sub Button107_Click(sender As System.Object, e As System.EventArgs) Handles Button107.Click
        Level.Music = Form1.FilePath & "\music\mario64-cave.ogg"

        SetLevelMusic()
    End Sub

    Private Sub Button108_Click(sender As System.Object, e As System.EventArgs) Handles Button108.Click
        Level.Music = Form1.FilePath & "\music\smg-star-reactor.ogg"

        SetLevelMusic()
    End Sub

    Private Sub Button6_Click(sender As System.Object, e As System.EventArgs) Handles Button6.Click
        smb_settings.Visible = False
        smb2_settings.Visible = False
        smb3_settings.Visible = False
        smw_settings.Visible = False
        mariorpg_settings.Visible = False
        mario64_settings.Visible = True
        misc_settings.Visible = False
    End Sub

    Private Sub Button109_Click(sender As System.Object, e As System.EventArgs) Handles Button109.Click
        Level.BGtype = 0
        BGColor = Color.Black
        Level.BG = Nothing
        Level.BG2 = Nothing
    End Sub

    Private Sub Button110_Click(sender As System.Object, e As System.EventArgs) Handles Button110.Click
        Main.SetLevelBG(16, 0)
        SetLevelBG()
    End Sub

    Private Sub Button111_Click(sender As System.Object, e As System.EventArgs) Handles Button111.Click
        Main.SetLevelBG(45, 0)
        SetLevelBG()
    End Sub

    Private Sub Button112_Click(sender As System.Object, e As System.EventArgs) Handles Button112.Click
        Main.SetLevelBG(46, 0)
        SetLevelBG()
    End Sub

    Private Sub Button113_Click(sender As System.Object, e As System.EventArgs) Handles Button113.Click
        Main.SetLevelBG(47, 0)
        SetLevelBG()
    End Sub

    Private Sub Button114_Click(sender As System.Object, e As System.EventArgs) Handles Button114.Click
        Main.SetLevelBG(40, 0)
        SetLevelBG()
    End Sub

    Private Sub Button115_Click(sender As System.Object, e As System.EventArgs) Handles Button115.Click
        PlayM.StopPlayback()
    End Sub

    Private Sub Button116_Click(sender As System.Object, e As System.EventArgs) Handles Button116.Click
        Level.Music = Form1.FilePath & "\music\sm-crateria.ogg"

        SetLevelMusic()
    End Sub

    Private Sub Button117_Click(sender As System.Object, e As System.EventArgs) Handles Button117.Click
        Level.Music = Form1.FilePath & "\music\sm-brinstar.ogg"

        SetLevelMusic()
    End Sub

    Private Sub Button118_Click(sender As System.Object, e As System.EventArgs) Handles Button118.Click
        Level.Music = Form1.FilePath & "\music\tds-metroid-charge.ogg"

        SetLevelMusic()
    End Sub

    Private Sub Button119_Click(sender As System.Object, e As System.EventArgs) Handles Button119.Click
        Level.Music = Form1.FilePath & "\music\sm-itemroom.ogg"

        SetLevelMusic()
    End Sub

    Private Sub Button120_Click(sender As System.Object, e As System.EventArgs) Handles Button120.Click
        Level.Music = Form1.FilePath & "\music\sm-brain.ogg"

        SetLevelMusic()
    End Sub

    Private Sub Button121_Click(sender As System.Object, e As System.EventArgs) Handles Button121.Click
        If TextBox1.Text.Contains("\") = False Then
            Level.Music = IO.Path.GetDirectoryName(Level.LevelPath) & "\" & TextBox1.Text
        Else
            Level.Music = TextBox1.Text
        End If

        If (IO.File.Exists(Level.Music) = True And Level.Music.EndsWith(".ogg")) Then
            SetLevelMusic()
        End If

    End Sub

    Private Sub Button122_Click(sender As System.Object, e As System.EventArgs) Handles Button122.Click
        Level.Music = Form1.FilePath & "\music\nsmb-overworld.ogg"

        SetLevelMusic()
    End Sub

    Private Sub Button123_Click(sender As System.Object, e As System.EventArgs) Handles Button123.Click
        Level.Music = Form1.FilePath & "\music\ssbb-airship.ogg"

        SetLevelMusic()
    End Sub

    Private Sub Button124_Click(sender As System.Object, e As System.EventArgs) Handles Button124.Click
        Level.Music = Form1.FilePath & "\music\mkwii-mushroom-gorge.ogg"

        SetLevelMusic()
    End Sub

    Private Sub Button125_Click(sender As System.Object, e As System.EventArgs) Handles Button125.Click
        Level.Music = Form1.FilePath & "\music\smg-beach-bowl-galaxy.ogg"

        SetLevelMusic()
    End Sub

    Private Sub Button126_Click(sender As System.Object, e As System.EventArgs) Handles Button126.Click
        Level.Music = Form1.FilePath & "\music\ssbb-zelda2.ogg"

        SetLevelMusic()
    End Sub

    Private Sub Button127_Click(sender As System.Object, e As System.EventArgs) Handles Button127.Click
        Level.Music = Form1.FilePath & "\music\pm-yoshis-village.ogg"

        SetLevelMusic()
    End Sub

    Private Sub Button128_Click(sender As System.Object, e As System.EventArgs) Handles Button128.Click
        Level.Music = Form1.FilePath & "\music\pm-shiver-mountain.ogg"

        SetLevelMusic()
    End Sub

    Private Sub Button129_Click(sender As System.Object, e As System.EventArgs) Handles Button129.Click
        Level.Music = Form1.FilePath & "\music\ssbb-meta.ogg"

        SetLevelMusic()
    End Sub

    Private Sub Button130_Click(sender As System.Object, e As System.EventArgs) Handles Button130.Click
        Level.Music = Form1.FilePath & "\music\z3-lost-woods.ogg"

        SetLevelMusic()
    End Sub

    Private Sub Button7_Click(sender As System.Object, e As System.EventArgs) Handles Button7.Click
        smb_settings.Visible = False
        smb2_settings.Visible = False
        smb3_settings.Visible = False
        smw_settings.Visible = False
        mariorpg_settings.Visible = False
        mario64_settings.Visible = False
        misc_settings.Visible = True
    End Sub

    Private Sub Button131_Click(sender As System.Object, e As System.EventArgs) Handles Button131.Click
        Level.Music = Form1.FilePath & "\music\sf-corneria.ogg"

        SetLevelMusic()
    End Sub

    Private Sub Button132_Click(sender As System.Object, e As System.EventArgs) Handles Button132.Click
        Level.Music = Form1.FilePath & "\music\ssbb-underground.ogg"

        SetLevelMusic()
    End Sub

    Private Sub Button133_Click(sender As System.Object, e As System.EventArgs) Handles Button133.Click
        Level.Music = Form1.FilePath & "\music\ssbb-waluigi.ogg"

        SetLevelMusic()
    End Sub

    Private Sub Button134_Click(sender As System.Object, e As System.EventArgs) Handles Button134.Click
        Level.Music = Form1.FilePath & "\music\smg2-fg.ogg"

        SetLevelMusic()
    End Sub

    Private Sub Button12_Click(sender As System.Object, e As System.EventArgs) Handles Button12.Click
        Form2.EditMode = 3
    End Sub

    Private Sub Button13_Click(sender As System.Object, e As System.EventArgs) Handles Button13.Click
        Form2.EditMode = 4
    End Sub

    Private Sub Button10_Click(sender As System.Object, e As System.EventArgs) Handles Button10.Click

        NumericUpDown1.Value = 12
    End Sub

    Public Shared Sub SetLevelMusic()
        PlayM.StopPlayback()

        PlayM.OpenFile(Level.Music, TStreamFormat.sfOgg)

        PlayM.GetPosition(startpos)

        PlayM.GetStreamInfo(endtime)

        endpos.sec = endtime.Length.sec

        PlayM.PlayLoop(TTimeFormat.tfSecond, startpos, TTimeFormat.tfSecond, endpos, 1000, True)
    End Sub

    Public Sub SetLevelBG()
        Dim g As Graphics = Form2.CreateGraphics()

        Select Case Level.BGtype
            Case 1, 3, 7
                Dim fs As New System.IO.FileStream(Level.BGpath, System.IO.FileMode.Open)
                Level.BG = Image.FromStream(fs)

                g.DrawImage(Level.BG, New Rectangle(0, Form2.Height - 538, Level.BG.Width, Level.BG.Height))

                fs.Close()
                fs.Dispose()

                fs = New System.IO.FileStream(Level.BG2path, System.IO.FileMode.Open)
                Level.BG2 = Image.FromStream(fs)
                g.DrawImage(Level.BG2, New Rectangle(0, Level.BG.Height - Level.BG2.Height, Level.BG2.Width, Level.BG2.Height))

                fs.Close()
                fs.Dispose()
            Case 2, 4, 5, 6, 8
                Dim fs As New System.IO.FileStream(Level.BGpath, System.IO.FileMode.Open)
                Level.BG = Image.FromStream(fs)
                g.DrawImage(Level.BG, New Rectangle(0, Form2.Height - 538, Level.BG.Width, Level.BG.Height))

                fs.Close()
                fs.Dispose()
        End Select

        Form2.Refresh()
    End Sub

    Private Sub TrackBar1_Scroll(sender As Object, e As EventArgs) Handles TrackBar1.Scroll
        Level.Brightness = TrackBar1.Value * 10
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        BrowseMusic.Filter = "Music Files|*.ogg"
        BrowseMusic.InitialDirectory = Form1.FilePath & "\worlds\"
        BrowseMusic.Title = "Select File"

        BrowseMusic.FileName = ""

        BrowseMusic.ShowDialog()
    End Sub

    Private Sub BrowseMusic_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles BrowseMusic.FileOk
        TextBox1.Text = BrowseMusic.FileName
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        If (IO.File.Exists(TextBox1.Text) And TextBox1.Text.EndsWith(".ogg")) Then
            TextBox1.ForeColor = Color.Green
        Else
            TextBox1.ForeColor = Color.Red
        End If
    End Sub

    Private Sub NumericUpDown1_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown1.ValueChanged
        Play.GravityLevel = NumericUpDown1.Value
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click

    End Sub
End Class