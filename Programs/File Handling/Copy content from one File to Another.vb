Imports System.IO

Module Module1
	Sub Main()

		' Copy one file to a new location.
		File.Copy("C:\test\text.txt", "C:\test\test.txt", True)

		' Display file contents.
		Console.WriteLine(File.ReadAllText("C:\test\text.txt"))
		Console.WriteLine(File.ReadAllText("C:\test\test.txt"))

		Console.ReadKey()
	End Sub
End Module