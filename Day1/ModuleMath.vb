Module ModuleMath

    Sub OperationMath()
        Dim y As Double
        y = 12 + (15 + 3) - 2 ^ 3 / 4 + 5
        Console.WriteLine(y)

    End Sub

    'Pembagian dan sisa
    Sub BagiSisa()
        Dim num1, num2, bagi, sisa As Integer
        Console.Write("Enter num1 : ")
        num1 = Console.ReadLine()
        Console.Write("Enter Num2 : ")
        num2 = Console.ReadLine()

        'Result
        bagi = num1 \ num2
        sisa = num1 Mod num2

        Console.WriteLine("Result bagi : " & bagi & ", Sisa : " & sisa)

    End Sub


End Module
