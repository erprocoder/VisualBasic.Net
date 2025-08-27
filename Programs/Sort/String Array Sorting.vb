Module Module1
    Sub Main()

        'array of String()
        Dim array As String() = New String() {"Maharashtra", "Rajsthan", "Panjab", "UP", "Karnataka"}

        ' Use the System.Array.Sort shared method.
        System.Array.Sort(Of String)(array)

        Console.WriteLine("Array after sorting : ")

        ' Loop through the results.
        Dim values As String

        For Each values In array
            Console.WriteLine(values)
        Next

        Console.Read()

    End Sub
End Module