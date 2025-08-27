Module ProgrammingHub

    Dim name As String
    Dim amount, year, rate, compoundInterest As Double

    Sub Main()

        Console.WriteLine("Enter Principle amount : ")
        amount = Console.ReadLine()

        Console.WriteLine("Enter Number of years : ")
        year = Console.ReadLine()

        Console.WriteLine("Enter rate of interest : ")
        rate = Console.ReadLine()

        compoundInterest = amount * (1 + rate / 100) ^ year
        Console.WriteLine("Compound Interest : {0}", compoundInterest)

        'This line is to hold the output screen
        Console.Read()

    End Sub

End Module