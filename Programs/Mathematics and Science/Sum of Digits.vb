Module Module1
    Sub Main()

        Dim n, sum, r As Integer

        Console.WriteLine("Enter a Number : ")
        n = CInt(Console.ReadLine())

        sum = 0

        While n <> 0
            r = n Mod 10
            sum += r
            n \= 10
        End While

        Console.WriteLine("Sum of Digits : " + sum.ToString())
        Console.ReadLine()

    End Sub
End Module