Imports System.Collections.Generic

Module HeapSortProgram

    'static function-functions that are invoked without creating an object of the class
    Public Sub HeapSort(input As Integer())
        'an unordered array input of length heapSize
        Dim heapSize As Integer = input.Length
        For p As Integer = (heapSize - 1) / 2 To 0 Step -1
            'Build the heap in array a input that largest value is at the root
            MaxHeap(input, heapSize, p)
        Next
        '       (The following loop maintains the invariants that input[0:end] is a heap and every element
        '         beyond end is greater than everything before it (so input[end:count] is in sorted order))
        For i As Integer = input.Length - 1 To 1 Step -1
            '(input[0] is the root and largest value. The swap moves it in front of the sorted elements.)
            Dim temp As Integer = input(i)
            input(i) = input(0)
            input(0) = temp
            '(the heap size is reduced by one)
            heapSize -= 1
            '(the swap ruined the heap property, so restore it)
            MaxHeap(input, heapSize, 0)
        Next
    End Sub

    Private Sub MaxHeap(input As Integer(), heapSize As Integer, index As Integer)
        print(input)
        Dim left As Integer = (index + 1) * 2 - 1
        Dim right As Integer = (index + 1) * 2
        Dim largest As Integer = 0
        '(The largest holds the largest element. Since we assume the heaps rooted at the
        ' children are valid, this means that we are done.)
        If left < heapSize AndAlso input(left) > input(index) Then
            largest = left
        Else
            largest = index
        End If

        If right < heapSize AndAlso input(right) > input(largest) Then
            largest = right
        End If

        If largest <> index Then
            Dim temp As Integer = input(index)
            input(index) = input(largest)
            input(largest) = temp
            '(repeat to continue sifting down the child now)
            MaxHeap(input, heapSize, largest)
        End If

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
        HeapSort(arr)
        Console.WriteLine("Sorting Process ends:")
        Console.WriteLine("After Sorting")
        print(arr)
        'keeps the console open till any key is entered
        Console.ReadKey()

    End Sub

End Module