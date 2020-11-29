Module Program

    Sub Main()
        Console.WriteLine("Hello Class!")
        Dim a As New Work
        a.Start()
    End Sub

    Public Class Work
        Public Sub Start()
            Console.WriteLine("Sub Class")
        End Sub
    End Class

End Module
