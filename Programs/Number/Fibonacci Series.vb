Module ProgrammingHub

   
    Sub Main()
        Dim num As Integer = 0
        Dim _pre As Integer = 1
        Dim _next As Integer = 0
        Dim temp As Integer = 0
        Dim i As Integer = 0
        Console.Write("Enter number upto which Fibonacci series to print: ")
        num = Integer.Parse(Console.ReadLine())

        While i < num
            Console.WriteLine(_next)
            temp = _pre
            _pre = _next
            _next = _pre + temp
            i = i + 1
        End While

        'This line is to hold the output screen
        Console.Read()

    End Sub

End Module