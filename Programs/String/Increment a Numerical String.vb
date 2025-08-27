Imports System.Net

Module Module1
    Sub Main()

        Dim s As String = "123"
        Console.WriteLine("Before string is : "&s)
        s = CStr(CInt("123") + 1)
        Console.WriteLine("Now string is : "&s)

        Console.Read()

    End Sub
End Module