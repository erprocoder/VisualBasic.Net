Module Module1
    Sub Main()

        For x As Integer = 0 To 4
            For y As Integer = 0 To x
                Console.Write("*")
            Next
            Console.WriteLine()
        Next
        Console.ReadKey()

    End Sub
End Module