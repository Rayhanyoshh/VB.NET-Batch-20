Namespace Part2
    Public MustInherit Class HR
        Implements I_HR

        Public Sub DisplayEmployee(listEmps As List(Of EmployeeParent)) Implements I_HR.DisplayEmployee
            For Each emp In listEmps
                Console.WriteLine(emp)
            Next
        End Sub

        Public MustOverride Function InItEmployee() As List(Of EmployeeParent) Implements I_HR.InItEmployee
        Dim listEmp As New List(Of EmployeeParent) From {
            New Programmer(120, "Anton", "Pratama", #03/03/2015#, 6_500_000, 500_000),
            New Programmer(121, "Budi", "Junaedi", #08/15/2016#, 6_000_000, 500_000),
            New Programmer(122, "Charlie", "Van Djik", #09/05/2017#, 6_000_000, 500_000),
            New Sales(123, "Dian", "Permana", #10/12/2017#, 3_000_000, 500_000, 200_000),
            New Sales(124, "Fatur", "Rahman", #01/15/2019#, 3_000_000, 350_000, 250_000),
            New QA(125, "Ellise", "Toon", #01/15/2019#, 4_500_000, 10_000),
            New QA(126, "Gita", "Gutawa", #03/01/2019#, 4_500_000, 10_000)
            }


        'dim emp3 As new Programmer("Widi","Vierra", DateAndTime.Now,5_000_000,100_000)
        'listEmp.Add(emp3)

        Public Function FindEmployeeByID(listEmps As List(Of EmployeeParent), Id As Integer) As EmployeeParent Implements I_HR.FindEmployeeByID
            'declare variabel untuk 
            'Dim emp As Employee2 = Nothing

            For Each list In listEmps
                If (list.EmpId.Equals(Id)) Then
                    Return list
                    'emp = list
                End If
            Next

            Return Nothing

        End Function

        Public Function TotalSalaryAll(listEmps As List(Of EmployeeParent)) As Double Implements I_HR.TotalSalaryAll
            Dim total = listEmps.Sum(Function(s) s.TotalSalary)
            Return total
        End Function

        Public Function TotalEmployeeByRole(listEmps As List(Of EmployeeParent), role As String) As Integer Implements I_HR.TotalEmployeeByRole
            Dim totalEmp As Integer
            For Each eachEmp In listEmps
                If eachEmp.RoleJob = role Then totalEmp += 1
            Next
            Return totalEmp

        End Function

        Public Function TotalSalaryEmployeeByRole(listEmps As List(Of EmployeeParent), role As String) As Double Implements I_HR.TotalSalaryEmployeeByRole
            Dim totalRoleSalary As Double
            For Each eachemp In listEmps
                If eachemp.RoleJob = role Then totalRoleSalary = eachemp.TotalSalary
            Next
            Return totalRoleSalary
        End Function

        Public Function TotalBasic(listEmps As List(Of EmployeeParent)) As Double Implements I_HR.TotalBasic
            Dim total = listEmps.Sum(Function(s) s.BasicSalary)
            Return total
        End Function



    End Class
End Namespace
