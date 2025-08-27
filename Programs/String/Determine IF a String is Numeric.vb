Module Module1
    Sub Main()
        Dim Value As String = "+123"

        If IsNumeric(Value) Then
            Console.WriteLine("It is numeric string")
        Else
            Console.WriteLine("It is not numeric string")
        End If

        Console.ReadKey()

    End Sub
End Module