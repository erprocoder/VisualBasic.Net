Module ProgrammingHub

    Dim hour, min, sec, totalSeconds As Integer

    Sub Main()

        Console.WriteLine("Enter time (h:m:s)")

        Console.WriteLine("Hours : ")
        hour = Convert.ToInt32(Console.ReadLine())
        Console.WriteLine("Minutes : ")
        min = Convert.ToInt32(Console.ReadLine())
        Console.WriteLine("Seconds : ")
        sec = Convert.ToInt32(Console.ReadLine())

        totalSeconds = (hour * 60 * 60) + (min * 60) + sec

        Console.WriteLine("Time in seconds : {0} ", totalSeconds)

        'This line is to hold the output screen
        Console.Read()

    End Sub

End Module