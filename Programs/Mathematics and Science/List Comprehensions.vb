Module Module1
    Sub Main()

        Dim ts = From a In Enumerable.Range(1, 20)
                 From b In Enumerable.Range(a, 21 - a)
                 From c In Enumerable.Range(b, 21 - b)
                 Where a * a + b * b = c * c
                 Select New With {a, b, c}

        For Each t In ts
            System.Console.WriteLine("{0}, {1}, {2}", t.a, t.b, t.c)
        Next

        Console.ReadKey()

    End Sub
End Module