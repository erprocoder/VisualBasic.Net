Imports System.Collections

Module Module1
    Sub Main()

        'Hashtable instance.
        Dim table As Hashtable = New Hashtable
        table("MAharashtra : ") = "Mumbai"
        table("Rajsthan : ") = "Jaipur"
        table("Panjaab : ") = "Chandigarh"
        table("Karnataka : ") = "Bengaluru"

        Console.WriteLine("Hastable's key and  Value are : ")

        ' Use For Each loop over the Hashtable.
        For Each element As DictionaryEntry In table
            Console.Write(element.Key)
            Console.Write(element.Value)
            Console.WriteLine()
        Next

        Console.Read()

    End Sub
End Module