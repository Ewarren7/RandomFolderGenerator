Imports System.Text

Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim URS8 As UniqueRandomString = New UniqueRandomString
        Dim baseName As String
        Dim strPathname As String
        Dim newFolder As String

        strPathname = Command()
        For Each argument As String In My.Application.CommandLineArgs
            strPathname = (argument)
        Next

        baseName = InputBox("Please enter the human readable part of the folder name. The random part will be generated.", "Enter Base of Folder Name")
        newFolder = (strPathname + "\" + baseName + URS8.generate)
        newFolder = Replace(newFolder, " ", "")

        System.IO.Directory.CreateDirectory(NewFolder)
        Me.Close()
    End Sub
End Class


Public Class UniqueRandomString

    Dim allocated As List(Of StringBuilder) = New List(Of StringBuilder)

    Public Function generate() As String
        Dim s As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789abcdefghijklmonpqrstuvwxyz"
        Dim r As Random = New Random
        Dim sb As StringBuilder = New StringBuilder
        Do
            For i As Integer = 1 To 20
                Dim idx As Integer = r.Next(0, 35) '26 letters + 10 digits
                sb.Append(s.Substring(idx, 1))
            Next
        Loop Until Not allocated.Contains(sb)
        allocated.Add(sb)
        Return sb.ToString()
    End Function

End Class
