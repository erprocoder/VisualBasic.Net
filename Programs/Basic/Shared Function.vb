Module Module1

    Class Widget
        Public Shared Function Test() As Integer
            ' Cannot access regular fields.
            Return Integer.Parse("56")
        End Function

        Dim _value As String = "23"

        Public Function TestB() As Integer
            ' Can access regular fields.
            Return Integer.Parse(_value)
        End Function
    End Class

    Sub Main()
        Console.WriteLine("Use Shared Function")
        Console.WriteLine(Widget.Test())

        Console.WriteLine("Without Shared Function")
        Dim w As Widget = New Widget()
        Console.WriteLine(w.TestB())

        Console.Read()
    End Sub

End Module