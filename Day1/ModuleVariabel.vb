Module ModuleVariabel

    Sub StoreProcedure()
        Dim Number As Integer = 200
        Dim MyName As String = "Bootcamp .Net"
        Console.WriteLine("Number :" & Number)
        Console.WriteLine("My Name : " & MyName)
        MyName = "Code ID"
        Console.WriteLine("My Name : " & MyName)

    End Sub

    'store procedure variabel
    Sub StoreConstant()
        Const PHI = 3.14159
        Console.WriteLine("PHI : " & PHI)
    End Sub


    'Variabel a,b,c
    'a=1, b=2, c=3 => a=3, b=1, c=2
    Sub SwapVariabel()
        'declare 3 variabel
        Dim a, b, c As Integer

        Console.Write("Value A : ")
        a = Console.ReadLine()

        Console.Write("Value B : ")
        b = Console.ReadLine()


        Console.WriteLine("Before : A = " & a & " B = " & b)
        c = a
        a = b
        b = c
        Console.WriteLine("After : A = " & a & " B = " & b)

    End Sub


End Module
