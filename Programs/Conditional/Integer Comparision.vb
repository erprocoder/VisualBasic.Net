Module Module1
    Sub Main()

        Console.WriteLine("Enter a and b value : ")

        Dim a As Integer = CInt(Console.ReadLine)
        Dim b As Integer = CInt(Console.ReadLine)

        'Using if statements
        If a < b Then Console.WriteLine("a is less than b")
        If a = b Then Console.WriteLine("a equals b")
        If a > b Then Console.WriteLine("a is greater than b")

        Console.ReadKey()

    End Sub
End Module