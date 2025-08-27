Module ProgrammingHub

    Dim num As Integer
    Sub Main()

        Console.Write("Enter a Number : ")
        num = Console.ReadLine()

        If num > 0 Then
            Console.WriteLine("POSITIVE")
        ElseIf num < 0 Then
            Console.WriteLine("NEGATIVE")
        ElseIf num = 0 Then
            Console.WriteLine("ZERO")
        End If

        'This line is to hold the output screen
        Console.Read()

    End Sub

End Module