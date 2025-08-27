Module Module1
    Sub Main()

        Dim n, r As Integer

        Console.WriteLine("Enter an number : ")
        n = CInt(Console.ReadLine())

        Console.WriteLine("Reverse number of entered number is : ")

        While n <> 0
            r = n Mod 10
            Console.Write(r)
            n \= 10
        End While

        Console.ReadKey()

    End Sub
End Module