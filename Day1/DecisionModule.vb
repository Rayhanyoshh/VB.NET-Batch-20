Module DecisionModule
    Sub OddEvenNumber()

        Dim num As Integer
        Console.Write("Enter the fooking numbah : ")
        num = Console.ReadLine()

        If num Mod 2 = 0 Then
            Console.WriteLine("Even Number")
        Else
            Console.WriteLine("Odd Number")
        End If

    End Sub

    'MUltiple IF
    Sub Grade()
        Dim grade As Integer
        Console.Write("Enter the result number : ")
        grade = Console.ReadLine()

        If grade < 50 Then
            Console.WriteLine("Kok segini nilai kau")
        ElseIf (grade >= 50) And (grade <= 60) Then
            Console.WriteLine("Remedi kau ya?")
        Else
            Console.WriteLine("Ga usah sekolah sekalian")
        End If
    End Sub


    'Pakai Select Case
    Sub GradeCase()

        Dim grade As Integer
        Console.Write("Enter the result number : ")
        grade = Console.ReadLine()

        Select Case grade
            Case < 50
                Console.WriteLine("Nilai kamu rendah sekali")
            Case 50 To 60
                Console.WriteLine("Sedikit lagi kamu hampir berhasil")
            Case 61 To 70
                Console.WriteLine("Lumayanlah")
            Case 71 To 100
                Console.WriteLine("Wah kamu pintar sekali")
            Case > 100
                Console.WriteLine("Inputan kamu salah")
        End Select

    End Sub

    Sub WhoIsTheGreatest()

        Dim num As Integer
        Dim rnd As New Random()
        Console.Write("Enter value between 1-10 : ")
        num = Console.ReadLine()

        If (num > 11) Or (num < 0) Then
            Console.WriteLine("Out Of Range")
        Else
            Dim guess As Integer = rnd.NextInt64(1, 11)
            Console.WriteLine("Your Input : " & num & vbCrLf & "Computer : " & guess)

            If (num > guess) Then
                Console.WriteLine("Kamu Menang")
            ElseIf (num = guess) Then
                Console.WriteLine("Wah Seimbang")
            Else
                Console.WriteLine("Kamu Kalah")
            End If
        End If

    End Sub

End Module
