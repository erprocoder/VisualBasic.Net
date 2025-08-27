Imports System
Imports System.Collections
Imports Microsoft.VisualBasic

Public Class StackExample 
    Public Shared Sub Main()

        Dim objStack As New Stack()

        objStack.Push(120)
        objStack.Push(13050)
        objStack.Push(103050)

        Console.WriteLine("Stack operations")

        ' operation Pop.
        Dim value As Integer = objStack.Pop()
        Console.WriteLine("Element popped : {0}", value)

        ' operation Peek.
        value = objStack.Peek()
        Console.WriteLine("Element peeked : {0}", value)

        Console.Read()

    End Sub
End Class