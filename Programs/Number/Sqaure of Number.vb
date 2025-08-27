Module Module1

    Sub Main()
        Dim i As Integer ' counter

        Console.WriteLine("NUMBER" & vbTab & "SQUARE" & vbCrLf)

        ' square numbers from 1 to 5
        For i = 1 To 5
            Console.WriteLine(i & vbTab & Square(i))
        Next
        Console.Read()
    End Sub

    Function Square(ByVal y As Integer) As Integer
        Return y ^ 2

    End Function

End Module