Module ProgrammingHub

    Dim centigrade, fahrenheit As Double

    Sub Main()

        Console.WriteLine("Enter temperature in centigrade : ")
        centigrade = Convert.ToDouble(Console.ReadLine())

        fahrenheit = 1.8 * centigrade + 32
        Console.WriteLine("Fahrenheit : {0}", fahrenheit)

        'This line is to hold the output screen
        Console.Read()

    End Sub

End Module