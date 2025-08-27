Module ProgrammingHub

    Dim num, square, cube As Integer

    Sub Main()

        Console.WriteLine("Enter a number : ")
        num = Convert.ToInt32(Console.ReadLine())

        square = num * num
        cube = num * num * num

        Console.WriteLine("Number you entered : {0}", num)
        Console.WriteLine("Square of Number : {0}", square)
        Console.WriteLine("Cube of Number : {0}", cube)

        'This line is to hold the output screen
        Console.Read()

    End Sub

End Module