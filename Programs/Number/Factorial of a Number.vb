Module ProgrammingHub

    Dim factorial = 1, i, num As Integer
    Sub Main()

        Console.WriteLine("Enter a number to find a factorial of it : ")
        num = Console.ReadLine()

        factorial = 1
        For i = 1 To num
            factorial = factorial * i
        Next

        Console.WriteLine("Factorial of {0} is {1}", num, factorial)

        'This line is to hold the output screen
        Console.Read()

    End Sub

End Module