Namespace Part3
    Module ModuleTesting
        Sub Testing()
            Dim emp1 As New Programmer(1, "Rayhan", "Yoshara", DateAndTime.Now, 5_000_000, 50_000)
            Console.WriteLine(emp1)
            Dim emp2 As New Sales(2, "Bujang", "Tua", DateAndTime.Now, 3_500_000, 250_000, 50_000)
            Console.WriteLine(emp2)


        End Sub
    End Module
End Namespace