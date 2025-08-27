Imports System.Threading

Module Module1
    Public rnd As New Random

    Sub Main()

        Dim result As String, a As String = "pants", b As String = "glasses"

        If a = b Then
            result = "Test passed"
            Console.WriteLine(result)
        Else
            result = "Test failed"
            Console.WriteLine(result)
        End If
        Console.ReadKey()

    End Sub

End Module