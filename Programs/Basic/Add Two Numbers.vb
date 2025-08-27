Module ProgrammingHub

    Dim num1, num2, add As Integer
    Sub Main()

        Console.Write("Enter 1st number : ")
        num1 = Convert.ToInt32(Console.ReadLine())
        Console.Write("Enter 2nd number : ")
        num2 = Convert.ToInt32(Console.ReadLine())

        add = num1 + num2
        Console.WriteLine("{0} + {1} = {2}", num1, num2, add)

        'This line is to hold the output screen
        Console.Read()

    End Sub

End Module