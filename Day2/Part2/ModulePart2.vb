Namespace Part2
    Module ModulePart2
        Sub initEmployee()
            'create object employee
            Dim emp1 As New Employee2(1, "Siapa sih", "Kamu", DateTime.Now, 5_000_000)
            'display Employee Info
            Console.WriteLine(emp1.ToString())

            'cara update
            emp1.FirstName = "Yoshhh"
            emp1.BasicSalary = 4_000_000
            Console.WriteLine(emp1.ToString)

            'Dim emp2 As New Employee2("Yuli", "Yulianto", DateTime.Now, "QA", 75000000)
            'Console.WriteLine(emp2.ToString)

            'Dim emp3 As New Programmer("3", "Vidi", "Aldiana", DateTime.Now, "QA", 5600000,)
            'Console.WriteLine(emp3.ToString)

            'emp3.Transportasi = 2_000_000
            ''Console.WriteLine(emp3.ToString)

            'emp3.Transportasi = 500_000
            'Console.WriteLine(emp3.ToString)

            'emp3.BasicSalary = 7_000_000
            'Console.WriteLine(emp3.ToString)


        End Sub
    End Module
End Namespace