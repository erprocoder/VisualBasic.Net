Module Module1
    Sub Main()

        Dim i As Integer
        i = 0

        Do
            i += 1
            Console.WriteLine(i)
        Loop Until i Mod 6 = 0
        Console.ReadKey()

    End Sub
End Module