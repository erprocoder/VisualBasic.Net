Module Module1

    Function Recursive(ByVal value As Integer, ByRef count As Integer) As Integer

        Console.WriteLine("Recursive({0}, {1})", value, count)

        count = count + 1
        If value >= 250 Then
            Return value
        End If
        Return Recursive(value * 4, count)

    End Function

    Sub Main()

        Dim count As Integer = 0
        Dim total As Integer = Recursive(3, count)

        Console.WriteLine("Total = {0}", total)
        Console.WriteLine("Count = {0}", count)
        Console.Read()

    End Sub

End Module