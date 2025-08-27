Class Demo
    Private val As Integer

    Public Sub New()
        Console.WriteLine("Inside Constructor")
        val = 42
    End Sub

    Public Function Value() As Integer
        Console.WriteLine("Inside Value function")
        Return val * 20
    End Function
End Class

Module Module1

    Sub Main()
        Dim x As Demo = New Demo()
        Console.WriteLine("Return value by Value function : " & x.Value())
        Console.Read()
    End Sub

End Module