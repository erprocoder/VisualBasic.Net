Module Module1
    Sub Main()

        Dim n, r, sum, t As Integer

        Console.WriteLine("Enter a number : ")
        n = CInt(Console.ReadLine())
        sum = 0
        t = n

        While n <> 0
            r = n Mod 10
            sum += Math.Pow(r, 3)
            n = n \ 10

        End While

        If sum = t Then
            Console.WriteLine(t.ToString + " is a Armstrong Number")
        Else
            Console.WriteLine(t.ToString + " is not an Armstrong Number")
        End If

        Console.ReadLine()

    End Sub
End Module