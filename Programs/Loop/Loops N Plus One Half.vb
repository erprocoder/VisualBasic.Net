Module Module1
    Sub Main()

        'for loop declaration
        For i = 1 To 10
            'print i value
            Console.Write(i)
            'define end condition
            If i = 10 Then Exit For
            Console.Write(", ")
        Next
        Console.ReadKey()

    End Sub
End Module