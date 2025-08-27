Module Module1
    Sub main()

        Dim n, i, j, k As Integer

        Console.WriteLine("Enter number of lines : ")
        n = CInt(Console.ReadLine())

        For i = 1 To n
            For j = 2 To n
                Console.Write(" ")
            Next
            For k = 1 To 2 * i - 1
                Console.Write("*")
            Next

            Console.WriteLine()

            n -= 1
        Next

        Console.ReadLine()

    End Sub
End Module