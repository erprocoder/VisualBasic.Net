Module ProgrammingHub

    Dim inches, feet, inche As Integer

    Sub Main()

        Console.WriteLine("Enter height in inches : ")
        inches = Console.ReadLine()

        feet = inches / 12
        inche = inches Mod 12

        Console.WriteLine("{0} foot and {1} inche", feet, inche)

        'This line is to hold the output screen
        Console.Read()

    End Sub

End Module