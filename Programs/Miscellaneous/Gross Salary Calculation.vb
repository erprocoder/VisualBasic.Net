Module Module1
   Sub Main()

        Dim bs, da, hr, gs As Integer

        Console.WriteLine("Enter Basic Salary : ")
        bs = CInt(Console.ReadLine())

        da = bs * 40 \ 100
        hr = bs * 20 \ 100
        gs = bs - (da + hr)

        Console.WriteLine("Gross Salary is : " + gs.ToString())
        Console.ReadLine()

    End Sub
End Module