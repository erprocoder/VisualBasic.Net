Imports System

Module Module1
    Sub Main()

        Dim i As Integer = 0

        Try
            Dim y As Integer = 1200 / i
        Catch ex As ArithmeticException
            Console.WriteLine("Arithmetic Exception occurred")
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try

        Console.ReadKey()

    End Sub
End Module