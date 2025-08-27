Module ProgrammingHub

    Dim seconds, hours, minutes, second As Integer

    Sub Main()

        Console.WriteLine("Enter time in seconds : ")
        seconds = Console.ReadLine()

        second = seconds Mod 60
        minutes = (seconds / 60) Mod 60
        hours = (seconds / 60) / 60

        Console.WriteLine("{0} hours {1} minutes {2} seconds", hours, minutes, second)

        'This line is to hold the output screen
        Console.Read()

    End Sub

End Module