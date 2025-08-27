Imports System
Imports System.Collections

Public Class QueueExample

    Public Shared Sub Main()

        ' Creates and initializes a new Queue.
        Dim objQ As New Queue()
        objQ.Enqueue("Hello")
        objQ.Enqueue("Programming")
        objQ.Enqueue("Hub!")

        ' Displays the properties and values of the Queue.
        Console.WriteLine("My Queue")
        Console.WriteLine("    Count:    {0}", objQ.Count)
        Console.Write("    Values:")
        PrintValues(objQ)

    End Sub 'Main

    Public Shared Sub PrintValues(myCollection As IEnumerable)
        Dim obj As [Object]
        For Each obj In  myCollection
            Console.Write("    {0}", obj)
        Next obj
        Console.WriteLine()
    End Sub 'PrintValues

End Class