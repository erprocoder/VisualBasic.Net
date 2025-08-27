Module Module1
    Sub Main()

        Dim a As String = "Test String"

        ' New string
        Dim b As String = "Nothing"

        Console.WriteLine("Before performing a copy operation value of variable b is : " + b)
        b = String.Copy(a)

        Console.WriteLine("After performing a copy operation value of variable b is : " + b)

        Console.ReadKey()

    End Sub
End Module