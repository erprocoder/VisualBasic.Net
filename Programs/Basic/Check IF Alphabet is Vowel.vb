Module ProgrammingHub

    Dim alphabet, c As Char
    Sub Main()
        Console.Write("Enter a Alphabet : ")
        alphabet = Console.ReadLine()

        c = alphabet.ToString.ToUpper

        If c = "A" Or c = "E" Or c = "I" Or c = "O" Or c = "U" Then
            Console.WriteLine("{0} is vowel", alphabet)
        Else
            Console.WriteLine("{0} is not vowel", alphabet)
        End If

        'This line is to hold the output screen
        Console.Read()

    End Sub

End Module