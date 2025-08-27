Module ProgrammingHub

            Sub MergeSort(ByVal ar() As Integer,ByVal low As Integer, ByVal high As Integer)
                print(ar)
                If low >= high Then Return
                        Dim length As Integer = high - low + 1
                        Dim middle As Integer = Math.Floor((low + high) / 2)
                        MergeSort(ar, low, middle)
                        MergeSort(ar, middle + 1, high)
                        Dim temp(ar.Length - 1) As Integer
                        For i As Integer = 0 To length - 1
                            temp(i) = ar(low + i)
                        Next
                        Dim m1 As Integer = 0
                        Dim m2 As Integer = middle - low + 1
                        For i As Integer = 0 To length - 1
                If m2 <= high - low Then
                If m1 <= middle - low Then
                If temp(m1) > temp(m2) Then
                                        ar(i + low) = temp(m2)
                                        m2 += 1
                                    Else
                                        ar(i + low) = temp(m1)
                                        m1 += 1
                                    End If
                                Else
                                    ar(i + low) = temp(m2)
                                    m2 += 1
                                End If
                            Else
                                ar(i + low) = temp(m1)
                                m1 += 1
                            End If
                        Next
               
            End Sub

'function to print the array
Public Sub print(arr As Integer())
For i As Integer = 0 To arr.Length - 1
Console.Write(arr(i).toString + " ")
Next
Console.WriteLine()
End Sub

Sub Main()
'input array initialization that needs to be sorted
Dim arr As Integer() = {5, 7, 3, 4, 1}

Console.WriteLine("Before Sorting")
print(arr)
Console.WriteLine("Sorting Process starts:")
'invokation of static function within the same class needs not
'object reference or class name
MergeSort(arr, 0, arr.Length - 1)
Console.WriteLine("Sorting Process ends:")
Console.WriteLine("After Sorting")
print(arr)
'keeps the console open till any key is entered
Console.ReadKey()

End Sub

End Module