Module ProgrammingHub

    Dim num1, num2, num3 As Double
    Sub Main()

        Console.WriteLine("Enter 1st number : ")
        num1 = Console.ReadLine()
        Console.WriteLine("Enter 2nd number : ")
        num2 = Console.ReadLine()
        Console.WriteLine("Enter 3rd number : ")
        num3 = Console.ReadLine()

        If (num1 >= num2 And num1 >= num3) Then
            Console.WriteLine("Largest number is {0}", num1)
        ElseIf (num2 >= num1 And num2 >= num3) Then
            Console.WriteLine("Largest number is {0}", num2)
        Else
            Console.WriteLine("Largest number is {0}", num3)
        End If

        'This line is to hold the output screen
        Console.Read()
    End Sub

End Module