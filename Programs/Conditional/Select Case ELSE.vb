Module Module1
    Sub Main()

        Dim result As String, a As String = "pants", b As String = "glasses"

        Select Case a
            Case b
                result = "Match"
                Console.WriteLine(result)
            Case a
                result = "Hey"
                Console.WriteLine(result)
            Case Else
                result = "Impossible"
                Console.WriteLine(result)
        End Select

        Console.ReadKey()

    End Sub
End Module