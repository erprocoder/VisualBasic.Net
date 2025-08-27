Imports System.IO
Imports System.Collections.ObjectModel
Imports System.Console
Imports System
Imports System.Collections.Generic

Module Module1
    Sub Main()

        Dim list As New List(Of Integer)()
        list.Add(1)
        list.Add(3)
        list(0) = 2

        Console.WriteLine("Integer value at position 1 is : ")
        Console.WriteLine(list(1))

        Console.ReadKey()

    End Sub
End Module