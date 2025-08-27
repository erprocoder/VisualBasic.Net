Module ProgrammingHub

    Dim num As Integer
    Sub Main()

        Console.Write("Enter a Number : ")
        num = Console.ReadLine()

        If (num Mod 2 = 0) Then
            Console.WriteLine("{0} is even", num)
        Else
            Console.WriteLine("{0} is odd", num)
        End If

        'This line is to hold the output screen
        Console.Read()

    End Sub

End Module