Module ProgrammingHub

    Dim area, base, height As Double

    Sub Main()

        Console.WriteLine("Enter base of Triangle : ")
        base = Convert.ToDouble(Console.ReadLine())
       
        Console.WriteLine("Enter height of Triangle  : ")
        height = Convert.ToDouble(Console.ReadLine())

        area = (1 / 2) * base * height
        Console.WriteLine("Area of Triangle is {0}", area)

        'This line is to hold the output screen
        Console.Read()

    End Sub

End Module