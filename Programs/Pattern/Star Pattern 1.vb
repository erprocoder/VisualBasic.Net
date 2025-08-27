Module Module1
    Sub Main()

        Dim i, j, n As Integer

        Console.WriteLine("Enter the number of lines : ")
        n = CInt(Console.ReadLine())

        For i = 1 To n
            For j = 1 To n
                Console.Write(" * ")

            Next
            n -= 1
            Console.WriteLine()
        Next
        Console.ReadLine()

    End Sub
End Module