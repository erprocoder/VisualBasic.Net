Imports System.IO

Module Module1
	Sub Main()

		' Store the line in this String.
		Dim line As String

		' Create new StreamReader instance with Using block.
		Using reader As StreamReader = New StreamReader("C:\test\text.txt")

			' Read one line from file
			line = reader.ReadLine
		End Using

		' Write the line we read from "file.txt"
		Console.WriteLine(line)

		Console.ReadKey()
	End Sub
End Module