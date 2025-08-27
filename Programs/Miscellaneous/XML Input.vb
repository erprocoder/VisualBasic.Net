Imports System.Net
Imports System.IO

Module Module1
    Sub Main()

        'write xml code
        Dim xml = <Students>
                      <Student Name="bhagyashree"/>
                      <Student Name="pratham"/>
                      <Student Name="shreya"/>
                      <Student Name="arvind"/>
                      <Student Name="ravneet"/>
                  </Students>

        Dim names = (From node In xml...<Student> Select node.@Name).ToArray
        Console.WriteLine("Extracted xml content is : ")

        'print xml content
        For Each name In names
            Console.WriteLine(name)
        Next
        Console.ReadKey()

    End Sub
End Module