Imports System

Module Module1
    Sub Main()

        ' Define string
        Dim s As String = "Hello"

        '& to String concatenation
        Console.WriteLine(s & " literal")

        '+ operator to String concatenation
        Dim s1 As String = s + " world"
        Console.WriteLine(s1)

        Console.ReadKey()

    End Sub
End Module