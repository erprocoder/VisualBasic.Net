Imports System

Module Module1
    Sub Main()

        ' Define string
        Dim s As String = "HeLlo"

        ' Change 's' to Upper Case.
        s = s.ToUpper()
        Console.WriteLine("After converting string in uppercase : " + s)

        ' Change 's' to Lower Case.
        s = s.ToLower()
        Console.WriteLine("After converting string in lowercase : " + s)

        Console.ReadKey()

    End Sub
End Module