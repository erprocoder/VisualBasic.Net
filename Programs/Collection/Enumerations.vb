Imports System

Module Module1

    Enum fruits
        apple = 0
        banana = 1
        cherry = 2
    End Enum

    Sub Main()
        Dim value As fruits = fruits.apple
        Select Case value
            Case fruits.banana
                Console.WriteLine("It is false")
                Return
            Case fruits.apple
                Console.WriteLine("It is True")
                Exit Select
        End Select
        Console.ReadKey()
    End Sub

End Module