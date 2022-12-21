Namespace Part2
    Module ModuleArray
        Function GetArray() As Integer()                        'setiap ada function pasti ada Return
            Dim Arr() As Integer = New Integer(2) {1, 2, 3}        'Return itu tipe data nya sama dengan asal return nya
            Return Arr
        End Function

        Sub DisplayArr()
            Dim Arr() As Integer

            Arr = GetArray()
            For i = 0 To Arr.Length - 1
                Console.Write($"{Arr(i)}")
            Next
        End Sub

        Sub InitListGeneric()
            Dim listCode As New List(Of String) From {$"Code Id", "CodingID", "CoingAE"}

            For Each List In listCode
                Console.WriteLine(List)
            Next
        End Sub


    End Module
End Namespace
