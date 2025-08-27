Module Module1
    Sub main()

        Dim y As Integer

        Console.WriteLine("Enter a Year : ")
        y = CInt(Console.ReadLine())

        If y Mod 100 = 0 Then
            If y Mod 400 = 0 Then
                Console.WriteLine("The year is a Leap year")
            Else
                Console.WriteLine("The year is not a Leap year")
            End If
        Else
            If y Mod 4 = 0 Then
                Console.WriteLine("The year is a Leap year")
            Else
                Console.WriteLine("The year is not a Leap year")
            End If
        End If
        Console.ReadLine()

    End Sub
End Module