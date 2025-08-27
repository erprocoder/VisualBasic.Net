Module Module1
    Sub Main()

        Dim width As Double
        Dim height As Double

        Console.WriteLine("Enter Rectangle height : ")
        height = Double.Parse(Console.ReadLine())

        Console.WriteLine("Enter Rectangle width : ")
        width = Double.Parse(Console.ReadLine())

        Console.Writeline("Rectangle area : ")
        Console.WriteLine(height * width)

        Console.Read()

    End Sub
End Module