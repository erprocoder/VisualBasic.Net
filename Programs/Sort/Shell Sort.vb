Module ShellSortProgram

    Private Sub shellSort(input As Integer(), array_size As Integer)
        Dim i As Integer, j As Integer, increment As Integer, temp As Integer
        increment = 3
        ' Start with the largest gap and work down to a gap of 1
        While increment > 0
            print(input)
            For i = 0 To array_size - 1
                j = i
                temp = input(i)
                ' shift earlier gap-sorted elements up until the correct location for input[i] is found
                While (j >= increment) AndAlso (input(j - increment) > temp)
                    input(j) = input(j - increment)
                    j = j - increment
                End While
                'put temp (the original input[i]) in its correct location
                input(j) = temp
            Next
            If increment / 2 <> 0 Then
                increment = increment / 2
            ElseIf increment = 1 Then
                increment = 0
            Else
                increment = 1
            End If
        End While
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
        shellSort(arr, arr.Length)
        Console.WriteLine("Sorting Process ends:")
        Console.WriteLine("After Sorting")
        print(arr)
        'keeps the console open till any key is entered
        Console.ReadKey()
    End Sub

End Module