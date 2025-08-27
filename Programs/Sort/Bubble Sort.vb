Imports System.Collections.Generic

Module BubbleSortProgram

    Sub Main()
        'input array initialization that needs to be sorted
        Dim arr() As Integer = {120, 23, 453, 123, 2446, 2324, 5, 77, 4646, 12}

        Dim temp,writ,i,bsort As Integer = 0

        For writ = 0 To arr.Length - 1
            'outer loop iterates n times(n is the length of the array)
            For bsort = 0 To arr.Length - 2
                'inner loop will iterate n-1 times
                If arr(bsort) > arr(bsort + 1) Then
                    'logic: if the LHS value is greater than RHS then swap the value
                    'swap logic
                    temp = arr(bsort + 1)
                    arr(bsort + 1) = arr(bsort)
                    arr(bsort) = temp
                End If
            Next
        Next

        'print the sorted array on console
        For i = 0 To arr.Length - 1
            Console.Write(arr(i))
            Console.Write(" ")
        Next

        'keeps the console open till any key is entered
        Console.ReadKey()

    End Sub

End Module