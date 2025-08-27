Module ProgrammingHub

        Sub Main()
       
            Console.WriteLine("Enter Number to check if it is an Armstrong Number")
           
            Dim numToCheck As Integer = Integer.Parse(Console.ReadLine())
            Dim lenthOfNum As Integer = numToCheck.ToString().Length
            Dim reminder As Double = 0
            Dim sum As Double = 0
            Dim tempNo As Integer = numToCheck
           
            While tempNo > 0
                reminder = tempNo Mod 10
                sum = sum + Math.Pow(reminder, lenthOfNum)
                tempNo = tempNo \ 10
            End While
           
            If sum = numToCheck Then
                Console.WriteLine("The given Number {0} is an Armstrong Number", numToCheck)
            Else
                Console.WriteLine("The given Number {0} is NOT an Armstrong Number", numToCheck)
            End If
            Console.ReadLine()
        End Sub

End Module