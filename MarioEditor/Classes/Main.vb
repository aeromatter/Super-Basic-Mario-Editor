Imports System.IO
Imports System.Text

Public Class Main
    Enum BackgroundStyles
        Normal
        RepeatBottom
    End Enum

    Public Structure LevelBackgroundDisplay
        Private primaryBackground As String
        Private secondaryBackground As String
        Private backgroundStyle As BackgroundStyles

        Public Sub New(primary As String, secondary As String, style As BackgroundStyles)
            primaryBackground = primary
            secondaryBackground = secondary
            backgroundStyle = style
        End Sub

        Public Function GetPrimary() As String
            Return primaryBackground
        End Function

        Public Function GetSecondary() As String
            Return secondaryBackground
        End Function

        Public Function GetStyle()
            Return backgroundStyle
        End Function
    End Structure

    Private Sub SetLevelBackground(ByVal background As LevelBackgroundDisplay)
        Dim fs As FileStream

        Level.BGpath = String.Format("{0}\graphics\background2\background2-{1}", GetGamePath(), background.GetPrimary())
        Level.BG2path = String.Format("{0}\graphics\background2\background2-{1}", GetGamePath(), background.GetSecondary())
        Level.BGid = background.GetPrimary()
        Level.BG2id = background.GetSecondary()

        Try
            fs = New FileStream(Level.BGpath, FileMode.Open)
            Level.BG = Image.FromStream(fs)
            fs.Close()
            fs.Dispose()

            fs = New FileStream(Level.BG2path, FileMode.Open)
            Level.BG2 = Image.FromStream(fs)
            fs.Close()
            fs.Dispose()
        Catch ex As Exception
            LevelWindow.BackColor = Color.Black
        End Try

        LevelWindow.Refresh()
        LevelWindow.Update()
    End Sub

    Public Sub GetBackgroundInfo(ByVal backgroundID As Integer)
        Dim openBackgroundProperties As StreamReader
        Dim parseOutput As Dictionary(Of String, String) = New Dictionary(Of String, String)
        Dim primaryBackgroundName As String = String.Empty
        Dim secondaryBackgroundName As String = String.Empty

        openBackgroundProperties = New StreamReader(String.Format("{0}\configs\background2\background2-{1}.ini", GetGamePath(), backgroundID), FileMode.Open)

        While Not openBackgroundProperties.EndOfStream
            Dim parse As String = openBackgroundProperties.ReadLine()
            Dim readInput() As String

            If parse.Contains("=") Then
                readInput = parse.Split("=")
                Dim key As String = readInput(0).Trim(Chr(34), Chr(32))
                Dim value As String = readInput(1).Trim(Chr(34), Chr(32))

                parseOutput.Add(key, value)
            End If
        End While

        openBackgroundProperties.Close()
        openBackgroundProperties.Dispose()

        For Each kv As KeyValuePair(Of String, String) In parseOutput
            If kv.Key = "image" Then
                primaryBackgroundName = kv.Value
            End If

            If kv.Key = "second-image" Then
                secondaryBackgroundName = kv.Value
            End If
        Next

        'TODO: Match background ID to ini file.

        Level.BGpath = String.Format("{0}\graphics\background2\{1}", GetGamePath(), primaryBackgroundName)
        Level.BG2path = String.Format("{0}\graphics\background2\{1}", GetGamePath(), secondaryBackgroundName)
        Level.BGtype = 1

        Dim fs As FileStream
        Dim fs2 As FileStream
        Try
            fs = New FileStream(Level.BGpath, FileMode.Open)
            Level.BG = Image.FromStream(fs)

            fs.Close()
            fs.Dispose()

            If Not Level.BG2path = "" Then
                fs2 = New FileStream(Level.BG2path, FileMode.Open)
                Level.BG2 = Image.FromStream(fs2)

                fs2.Close()
                fs2.Dispose()
            End If
        Catch ex As Exception
            LevelWindow.BackColor = Color.Black
        End Try

        LevelWindow.Refresh()
        LevelWindow.Update()
        'SetLevelBackground()
    End Sub
    Public Shared Sub SetLevelBG(ByVal ID As UInteger, ByVal ID2 As UInteger)
        Dim fs As FileStream
        Dim fs2 As FileStream

        Level.BGpath = String.Format(GetGamePath() & "\graphics\background2\background2-{0}.png", ID)

        If ID2 > 0 Then
            Level.BG2path = String.Format(GetGamePath() & "\graphics\background2\background2-{0}.png", ID2)
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
        Level.BG2id = ID2

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
            LevelWindow.BackColor = Color.Black
        End Try

        If Not Level.BG2path = "" Then
            fs2 = New FileStream(Level.BG2path, FileMode.Open)
            Level.BG2 = Image.FromStream(fs2)

            fs2.Close()
            fs2.Dispose()
        End If

        LevelWindow.Refresh()
        LevelWindow.Update()
    End Sub

    Public Shared Function Clamp(ByVal input As Double, ByVal min As Double, ByVal max As Double)
        If input >= max Then
            Return max
        ElseIf input <= min Then
            Return min
        End If

        Return input
    End Function

    Public Shared Function GetGamePath() As String
        Return Path.GetDirectoryName(Application.ExecutablePath)
    End Function
End Class
