Module ProgrammingHub

    Dim area, circumference, radius As Double

    Sub Main()

        Console.WriteLine("Enter radius of circle : ")
        radius = Convert.ToDouble(Console.ReadLine())

        area = 3.14 * radius * radius
        Console.WriteLine("Area of Circle is {0}", area)

        circumference = 2 * 3.14 * radius
        Console.WriteLine("Circumference of Circle is {0}", circumference)

        'This line is to hold the output screen
        Console.Read()

    End Sub

End Module