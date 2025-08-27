Module Module1
    Sub Main()

        Dim i, j, s, n As Integer

        Console.WriteLine("Enter the number of lines : ")
        n = CInt(Console.ReadLine())
        s = 1

        For i = 1 To n
            For j = 1 To i
                Console.Write(s & " ")
                s += 1
            Next

            Console.WriteLine()
        Next
        Console.ReadLine()

    End Sub
End Module