Imports System.IO

Module Module1
	Sub Main()

		Dim file As System.IO.StreamWriter
		
		file = My.Computer.FileSystem.OpenTextFileWriter("C:\test\text.txt", True)
		
		file.WriteLine("Here is the first string.")
		file.WriteLine("Hello all,good afternoon")
		
		file.Close()

		Console.WriteLine("content has been successfully written  into file ......")

		Console.ReadKey()
	End Sub
End Module