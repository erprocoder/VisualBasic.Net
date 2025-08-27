Imports System

Module Module1
	Sub Main()

		For i = 1 To 30
			If i Mod 15 = 0 Then
				Console.WriteLine("FizzBuzz")
			ElseIf i Mod 5 = 0 Then
				Console.WriteLine("Buzz")
			ElseIf i Mod 3 = 0 Then
				Console.WriteLine("Fizz")
			Else
				Console.WriteLine(i)
			End If
		Next
		Console.ReadKey()
	End Sub
End Module