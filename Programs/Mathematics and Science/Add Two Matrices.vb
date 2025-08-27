Module Module1
    Sub Main()

        'using 2D-ARRAYS
        Dim RowSize As Integer = 5, ColSize As Integer = 5

        'declaring 2-d arrays below
        Dim Matrix1 As Integer(,) = New Integer(RowSize - 1, ColSize - 1) {}
        Dim Matrix2 As Integer(,) = New Integer(RowSize - 1, ColSize - 1) {}
        Dim ResultMatrix As Integer(,) = New Integer(RowSize - 1, ColSize - 1) {}
        Dim i As Integer, j As Integer

        Try
            Console.WriteLine("PROGRAM To PRINT ADDITION OF TWO MATRICES ")
            Console.WriteLine(vbLf & " Enter the Size of a Matrix N*N form : ")
            Dim s As String = Console.ReadLine()
            Dim values As String() = s.Split("*"c)
            RowSize = Integer.Parse(values(0))
            ColSize = Integer.Parse(values(1))

            If RowSize > 5 OrElse ColSize > 5 Then
                'limiting the size of matrix
                Console.BackgroundColor = ConsoleColor.DarkRed
                'changing background color to red
                Console.WriteLine(" The Size Of Matrix should Be in Less Than 5 (limiting size of array)")
                Console.WriteLine(vbLf & vbLf & vbTab & " Press Enter key to exit....")
                Console.ReadKey()
                Return
            Else


                'Initializing all the elements to zero
                For i = 0 To RowSize - 1
                    For j = 0 To ColSize - 1
                        Matrix1(i, j) = 0
                        Matrix2(i, j) = 0
                    Next
                Next
                'Reading elements of Matrix1
                Console.WriteLine(vbLf & " Enter the elements of Matrix1({0}*{1})", RowSize, ColSize)
                For i = 0 To RowSize - 1
                    For j = 0 To ColSize - 1
                        Console.Write(" Matrix1[{0},{1}] : ", i, j)
                        Matrix1(i, j) = Convert.ToInt32(Console.ReadLine())
                    Next
                Next
                'Reading elements of Matrix2
                Console.WriteLine(vbLf & " Enter the elements of Matrix2({0}*{1})", RowSize, ColSize)
                For i = 0 To RowSize - 1
                    For j = 0 To ColSize - 1
                        Console.Write(" Matrix2[{0},{1}] : ", i, j)
                        Matrix2(i, j) = Convert.ToInt32(Console.ReadLine())
                    Next
                Next

                'calculating ResultMatrix, by adding Matrix1 and Matrix2
                For i = 0 To RowSize - 1
                    For j = 0 To ColSize - 1
                        ResultMatrix(i, j) = Matrix1(i, j) + Matrix2(i, j)
                    Next
                Next

                'Printing Result Matrix
                Console.Write(vbLf & vbLf & vbTab & "Resultant Matrix" & vbLf & vbLf & vbTab)
                For i = 0 To RowSize - 1

                    For j = 0 To ColSize - 1
                        If ResultMatrix(i, j) < 10 Then
                            'Making number as 01,02,etc,.
                            Console.Write("  0" & Convert.ToString(ResultMatrix(i, j)))
                        Else
                            Console.Write("  " & Convert.ToString(ResultMatrix(i, j)))
                        End If

                        If j = ColSize - 1 Then
                            Console.Write(vbLf & vbTab)

                        End If
                    Next
                Next
            End If
        Catch
            'to catch exceptions,suppose string entered as a RowSize or Colsize  of matrix
            Console.BackgroundColor = ConsoleColor.DarkRed
            Console.WriteLine("WARNING:only Number are allowed, Enter Correct Input example 3*3 or 4*4")
            Console.ResetColor()
        End Try

        Console.WriteLine(vbLf & vbLf & vbTab & " Press Enter key to exit....")
        Console.ReadLine()

    End Sub
End Module