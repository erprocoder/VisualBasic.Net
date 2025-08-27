Imports System

Module Module1
    Sub Main()

        Dim base As Integer = 2
        Dim power As Integer = 5

        Console.WriteLine("{0} to the {1}th power is {2}",
          base, power, base ^ power)

        Console.Read()

    End Sub
End Module