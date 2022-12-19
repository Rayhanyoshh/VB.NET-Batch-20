Module IterationModule

    'DO WHILE
    Sub DoWhile(n As Integer, m As Integer)

        Dim i As Integer = 1

        Do While i <= n
            Console.Write(i & " ")
            If (i = m) Then
                Exit Do
            Else
                i += 1
            End If
        Loop

    End Sub

    Sub forLoop()

        For index = 1 To 5
            Console.Write("* ")
        Next

    End Sub

    Sub KotakBintang(num As Integer)
        'Pindah baris
        For i = 1 To num
            For j = 1 To num - i + 1
                'cetak horizontal
                Console.Write("* ")
            Next
            'pindah baris
            Console.WriteLine()
        Next
    End Sub

End Module
