Module QuickSortProgram

    Public Sub QuickSort(input As Integer(), left As Integer, right As Integer)
        If left < right Then
            Dim q As Integer = Partition(input, left, right)
            QuickSort(input, left, q - 1)
            QuickSort(input, q + 1, right)
        End If
    End Sub

    Private Function Partition(input As Integer(), left As Integer, right As Integer) As Integer
        print(input)
        ' put the chosen pivot at input[right]
        Dim pivot As Integer = input(right)
        Dim temp As Integer

        Dim i As Integer = left
        ' Compare remaining array elements against pivot = input[right]
        For j As Integer = left To right - 1
            ' Move pivot to its final place
            If input(j) <= pivot Then
                temp = input(j)
                input(j) = input(i)
                input(i) = temp
                i += 1
            End If
        Next

        input(right) = input(i)
        input(i) = pivot

        Return i
    End Function

    'function to print the array
    Public Sub print(arr As Integer())
        For i As Integer = 0 To arr.Length - 1
            Console.Write(arr(i))
            Console.Write(" ")

        Next
        Console.WriteLine()
    End Sub

    Sub Main()
        'input array initialization that needs to be sorted
        Dim arr As Integer() = {5, 7, 3, 4, 1}

        Console.WriteLine("Before Sorting")
        print(arr)
        Console.WriteLine("Sorting Process starts:")
        'invokation of static function within the same class needs not object reference or class name
        QuickSort(arr, 0, arr.Length - 1)
        Console.WriteLine("Sorting Process ends:")
        Console.WriteLine("After Sorting")
        print(arr)
        'keeps the console open till any key is entered
        Console.ReadKey()
    End Sub

End Module