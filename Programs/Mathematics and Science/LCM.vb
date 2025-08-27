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

    Function LCM(a As Integer, b As Integer) As Integer
        Return (a * b) \ GCD(a, b)
    End Function

    Sub Main()
        Console.Write("LCM is : ")
        Console.Write(LCM(12, 11))
        Console.Read()
    End Sub

End Module