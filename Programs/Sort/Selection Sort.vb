Module SelectionSortProgram

    Public Sub selectionSort(arr As Integer())
        'pos_min is short for position of min
        Dim pos_min As Integer, temp As Integer

        For i As Integer = 0 To arr.Length - 2
            print(arr)
            pos_min = i
            'set pos_min to the current index of array
            For j As Integer = i + 1 To arr.Length - 1
                If arr(j) < arr(pos_min) Then
                    'pos_min will keep track of the index that min is in, this is needed when a swap happens
                    pos_min = j
                End If
            Next

            'if pos_min no longer equals i than a smaller value must have been found, so a swap must occur
            If pos_min <> i Then
                temp = arr(i)
                arr(i) = arr(pos_min)
                arr(pos_min) = temp
            End If
        Next
    End Sub

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
        selectionSort(arr)
        Console.WriteLine("Sorting Process ends:")
        Console.WriteLine("After Sorting")
        print(arr)
        'keeps the console open till any key is entered
        Console.ReadKey()
    End Sub

End Module