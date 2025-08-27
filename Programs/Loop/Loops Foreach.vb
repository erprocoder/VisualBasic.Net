Module Module1
    Sub Main()

        'declaration of list collection
        Dim list As New List(Of String)
        'adding elements into list
        list.Add("Car")
        list.Add("Boat")
        list.Add("Train")

        Console.WriteLine("List elements : ")

        'retrive values from list
        For Each item In list
            'display list element
            Console.WriteLine(item)
        Next
        Console.ReadKey()

    End Sub
End Module