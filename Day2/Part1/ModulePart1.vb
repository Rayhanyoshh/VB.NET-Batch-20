Namespace Part1
    Module ModulePart1
        Sub initEmployee()
            'create object employee
            Dim emp1 As New Employee1 With {
                .empId = 1,
                .FirstName = "Rayhan",
                .LastName = "Yoshara",
                .JoinDate = #12/12/2002 08:00:00 AM#,
                .BasicSalary = 5_000_000
            }
            'display Employee Info
            Console.WriteLine(emp1.ToString)

            emp1.BasicSalary = 4_000_000
            Console.WriteLine(emp1.ToString)
        End Sub
    End Module
End Namespace