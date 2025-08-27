Module Module1
    Sub Main()

        Dim n, r, sum, t As Integer

        Console.WriteLine("Enter a Number : ")
        n = CInt(Console.ReadLine())
        sum = 0
        t = n

        While n <> 0
            r = n Mod 10
            sum = sum * 10 + r
            n = n \ 10
        End While

        If sum = t Then
            Console.WriteLine(t.ToString() + " is a Palindrome Number")
        Else
            Console.WriteLine(t.ToString() + " is not a Palindrome Number")
        End If

        Console.Read()

    End Sub
End Module