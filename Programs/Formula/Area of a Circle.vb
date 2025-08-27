Module ProgrammingHub

    Dim area, radius As Double

    Sub Main()

        Console.WriteLine("Enter radius of circle : ")
        radius = Console.ReadLine()

        area = 3.14 * radius * radius
        Console.WriteLine("Area of Circle is {0}", area)

        'This line is to hold the output screen
        Console.Read()

    End Sub

End Module