Imports System.IO

Public Class Main

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
