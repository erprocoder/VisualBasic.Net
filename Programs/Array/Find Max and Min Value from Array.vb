Module Module1
    Sub Main()

        Dim n, i, min, max As Integer
        Console.WriteLine("Enter the number of Elements you want : ")

        n = CInt(Console.ReadLine())
        Dim arr(n) As Integer

        For i = 0 To n - 1
            Console.WriteLine("Enter the " & (i + 1).ToString & "th element: ")
            arr(i) = CInt(Console.ReadLine())
        Next

        Console.WriteLine("Array Elements : ")

        For i = 0 To n - 1
            Console.Write(arr(i) & " ")
        Next

        min = arr(0)
        max = arr(0)

        For i = 0 To n - 1
            If arr(i) < min Then
                min = arr(i)
            End If

        Next

        For i = 0 To n - 1
            If arr(i) > max Then
                max = arr(i)
            End If

        Next

        Console.WriteLine()
        Console.WriteLine("Minimum value from array is : " & min)
        Console.WriteLine("Maximum value from array is : " & max)
        Console.ReadLine()

    End Sub
End Module