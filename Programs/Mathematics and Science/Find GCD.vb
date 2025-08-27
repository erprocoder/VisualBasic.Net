Module Module1

    Function GCD(a As Integer, b As Integer) As Integer
        If a = 0 Then
            Return b
        End If

        While b <> 0
            If a > b Then
                a -= b
            Else
                b -= a
            End If
        End While

        Return a
    End Function

    Sub Main()
        Console.Write("GCD is : ")
        Console.Write(GCD(152, 112))
        Console.Read()
    End Sub

End Module