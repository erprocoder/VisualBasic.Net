Imports System
Imports System.Collections
Imports Microsoft.VisualBasic

Public Class StackExample   

    Public Shared Sub Main()

        ' Creates and initializes a new Stack.
        Dim objStack As New Stack()
        objStack.Push("Hello")
        objStack.Push("Programming")
        objStack.Push("Hub")
       
        Dim numStack As New Stack()
        numStack.Push(234)
        numStack.Push(567)
        numStack.Push(890)

        ' Displays the properties and values of the Stack.
        Console.WriteLine("Text Stack")
        Console.WriteLine(ControlChars.Tab & "Count:    {0}", objStack.Count)
        Console.Write(ControlChars.Tab & "Values:")
        PrintVal(objStack)
       
        Console.WriteLine("Number Stack")
        Console.WriteLine(ControlChars.Tab & "Count:    {0}", numStack.Count)
        Console.Write(ControlChars.Tab & "Values:")
        PrintVal(numStack)
    End Sub

    Public Shared Sub PrintVal(myCollection As IEnumerable)
        Dim obj As [Object]
        For Each obj In  myCollection
            Console.Write("    {0}", obj)
        Next obj
        Console.WriteLine()
    End Sub

End Class