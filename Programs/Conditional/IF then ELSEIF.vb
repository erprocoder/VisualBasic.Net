Module Module1
    Sub Main()

        Dim result As String, a As String = "pants", b As String = "glass"
        If a = b Then
            result = "Test passed"
            Console.WriteLine(result)
        ElseIf a <> b Then
            result = "Test failed"
            Console.WriteLine(result)
        Else
            result = "Test impossible"
            Console.WriteLine(result)
        End If

        Console.ReadKey()

    End Sub
End Module