Module Module1
    Sub Main()

        Dim n As Integer, k As Integer, limit As Integer
        Console.WriteLine("The Sieve of Eratosthenes is a simple algorithm that finds the prime numbers up to a given integer.")
        Console.WriteLine()

        Console.WriteLine("Enter Range : ")
        limit = Console.ReadLine
        Dim flags(limit) As Integer

        For n = 2 To Math.Sqrt(limit)
            If flags(n) = 0 Then
                For k = n * n To limit Step n
                    flags(k) = 1
                Next k
            End If
        Next n

        ' Display the primes
        For n = 2 To limit
            If flags(n) = 0 Then
                Console.WriteLine(n)
            End If
        Next n

        Console.Read()

    End Sub
End Module