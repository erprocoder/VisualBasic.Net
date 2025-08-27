Module ForwardDifference

    Sub Main()
        Dim returnedValue As Double = Multiply(4, 3)
        Console.WriteLine("Multiplication is : " & returnedValue)
    End Sub
   
    Function Multiply(ByVal a As Integer, ByVal b As Integer) As Integer
    Return a * b
    End Function

End Module