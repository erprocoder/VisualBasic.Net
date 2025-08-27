Module ProgrammingHub

    Dim num1, num2, temp As Integer
    Sub Main()

        Console.WriteLine("Enter 1st number : ")
        num1 = Console.ReadLine()
        Console.WriteLine("Enter 2nd number : ")
        num2 = Console.ReadLine()

        Console.WriteLine("Values before swapping")
        Console.WriteLine("num1 = {0}", num1)
        Console.WriteLine("num2 = {0}", num2)

        temp = num1
        num1 = num2
        num2 = temp

        Console.WriteLine("Values after swapping")
        Console.WriteLine("num1 = {0}", num1)
        Console.WriteLine("num2 = {0}", num2)

        'This line is to hold the output screen
        Console.Read()

    End Sub

End Module