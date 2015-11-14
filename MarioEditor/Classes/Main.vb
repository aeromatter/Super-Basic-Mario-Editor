Imports System.IO
Imports System.Text

Public Class Main

    Public Shared Sub SetLevelBG(ByVal ID As UInteger, ByVal ID2 As UInteger)
        Dim fs As System.IO.FileStream
        Dim fs2 As System.IO.FileStream

        If ID > 0 And ID2 > 0 Then
            Level.BGpath = String.Format(Form1.FilePath & "\graphics\background2\background2-{0}.png", ID)
            Level.BG2path = String.Format(Form1.FilePath & "\graphics\background2\background2-{0}.png", ID2)
        ElseIf ID2 = 0
            Level.BGpath = String.Format(Form1.FilePath & "\graphics\background2\background2-{0}.png", ID)
        End If

        'Set Type
        Select Case ID
            Case 1, 3, 35, 37
                Level.BGtype = 1
            Case 6, 9, 12, 13, 17, 19, 27, 31, 32, 33, 34, 40, 41, 43, 44, 48, 49, 50, 51, 52, 53, 54, 56, 57
                Level.BGtype = 6
            Case 4, 5, 7, 8, 15, 16, 24, 25, 28, 39, 45, 46, 47
                Level.BGtype = 4
            Case 2, 11, 14, 20, 23, 36, 38
                Level.BGtype = 2
            Case 21, 26
                Level.BGtype = 5
            Case 22
                Level.BGtype = 3
            Case 10
                Level.BGtype = 7
            Case 18, 29, 30, 42, 55, 58
                Level.BGtype = 8
        End Select

        Level.BGid = ID

        'Set Color
        Select Case ID
            Case 1, 2, 3, 22
                LevelSettings.BGColor = Color.FromArgb(255, 104, 152, 248)
            Case 4
                LevelSettings.BGColor = Color.FromArgb(255, 48, 64, 48)
            Case 36, 35, 37
                LevelSettings.BGColor = Color.FromArgb(255, 152, 144, 248)
            Case 20, 18
                LevelSettings.BGColor = Color.Black
            Case 23
                LevelSettings.BGColor = Color.FromArgb(255, 0, 0, 24)
            Case 38
                LevelSettings.BGColor = Color.FromArgb(255, 216, 240, 248)
            Case 56
                LevelSettings.BGColor = Color.FromArgb(255, 8, 0, 96)
            Case 11, 9, 41, 50, 51, 6, 44, 48, 49, 52, 53, 54, 57, 12, 32, 34, 33, 31, 19, 13, 29, 30, 42, 43, 55, 58
                LevelSettings.BGColor = Color.FromArgb(255, 80, 136, 160)
        End Select

        Try
            fs = New FileStream(Level.BGpath, FileMode.Open)
            Level.BG = Image.FromStream(fs)

            fs.Close()
            fs.Dispose()
        Catch ex As Exception
            Form2.BackColor = Color.Black
        End Try

        If Not Level.BG2path = "" Then
            fs2 = New FileStream(Level.BG2path, FileMode.Open)
            Level.BG2 = Image.FromStream(fs2)

            fs2.Close()
            fs2.Dispose()
        End If

        Form2.Refresh()
        Form2.Update()
    End Sub

    Public Shared Function Clamp(input As Double, min As Double, max As Double)
        If input >= max Then
            Return max
        ElseIf input <= min
            Return min
        End If

        Return input
    End Function

    Public Shared Function IntChanged(input As Integer, original As Integer) As Boolean
        Return input <> original
    End Function

End Class
