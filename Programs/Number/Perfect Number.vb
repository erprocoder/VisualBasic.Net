Module ProgrammingHub

    Sub Main()
        Dim n, p, r, sum As Integer
        Console.WriteLine("Enter a number: ")
        n = Integer.Parse(Console.ReadLine())
        p = 1
        sum = 0
        While p <= n \ 2
            r = n Mod p
            If r = 0 Then
                sum += p
            End If
            p += 1
        End While
        If sum = n Then
            Console.WriteLine(n.ToString + " is a Perfect Number")
        Else
            Console.WriteLine(n.ToString + " is NOT a Perfect Number")
        End If
        Console.ReadLine()
    End Sub
End Module