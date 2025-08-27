Module Module1
    Sub Main()

        'array of Integer()
        Dim arr As Integer() = New Integer() {34, 51, 24, 65, 92}
        Array.Sort(arr)

        Console.WriteLine("Array after sorting : ")

        ' Loop through the results.
        Dim values As Integer
        For Each values In arr
            Console.WriteLine(values)
        Next

        Console.Read()

    End Sub
End Module