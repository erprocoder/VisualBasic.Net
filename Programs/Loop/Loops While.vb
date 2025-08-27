Module Module1
    Sub Main()

        Dim x = 1024

        'Do loop declaration
        Do
            Console.WriteLine(x)
            x = x \ 2
        Loop While x > 0
        Console.ReadKey()

    End Sub
End Module