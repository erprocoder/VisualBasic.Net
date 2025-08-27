Module Module1
    Sub Main()

        'variable declaration
        Dim i, j, n As Integer

        Console.WriteLine("Enter the number of lines : ")
        n = CInt(Console.ReadLine())

        'loop to display number pattern
        For i = 1 To n
            For j = 1 To i
                Console.Write(j & " ")
            Next
            'for next line
            Console.WriteLine()
        Next
        Console.ReadLine()

    End Sub
End Module