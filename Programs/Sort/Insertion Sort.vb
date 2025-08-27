Module InsertionSortProgram

    'static function-functions that are invoked without creating an object of the class
    Private Sub InsertionSort(input As Integer())
        'The outer loop runs over all the elements except the first one 
        'because the single-element prefix input[0:1]
        'is trivially sorted,so the invariant that the first i+1 entries are sorted is true
        'from the start.
        For i As Integer = 0 To input.Length - 2
            'The inner loop moves element input[i] to its correct place
            'so that after the loop,
            'the first i+2 elements are sorted.
            For j As Integer = i + 1 To 1 Step -1
                If input(j - 1) > input(j) Then
                    Dim temp As Integer = input(j - 1)
                    input(j - 1) = input(j)
                    input(j) = temp
                End If
            Next
            print(input)
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
        'invokation of static function within the same class needs not object
         'reference or class name
        InsertionSort(arr)
        Console.WriteLine("Sorting Process ends:")
        Console.WriteLine("After Sorting")
        print(arr)
        'keeps the console open till any key is entered
        Console.ReadKey()

    End Sub

End Module