Module Module1
    Sub Main()

        ' Start date
        Dim sdate As DateTime = New DateTime(2015, 2, 1, 3, 4, 12, 56)
        ' End date
        Dim eDate As DateTime = New DateTime(2016, 12, 12, 4, 30, 45, 12)
        ' Time Difference
        Dim diffDate As TimeSpan = eDate.Subtract(sDate)

        Console.WriteLine("Time Difference: ")
        Console.WriteLine(diffDate.Days.ToString() + " Days")
        Console.WriteLine(diffDate.Hours.ToString() + " Hours")
        Console.WriteLine(diffDate.Minutes.ToString() + " Minutes")
        Console.WriteLine(diffDate.Seconds.ToString() + " Seconds ")
        Console.WriteLine(diffDate.Milliseconds.ToString() + " Milliseconds ")
        Console.ReadKey()

    End Sub
End Module