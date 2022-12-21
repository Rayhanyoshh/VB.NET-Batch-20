Namespace Part2
    Public Interface I_HR

        Function InItEmployee() As List(Of EmployeeParent)

        Sub DisplayEmployee(listEmps As List(Of EmployeeParent))

        Function FindEmployeeByID(listEmps As List(Of EmployeeParent), Id As Integer) As EmployeeParent

        Function TotalSalaryAll(listEmps As List(Of EmployeeParent)) As Double

        Function TotalEmployeeByRole(listEmps As List(Of EmployeeParent), role As String) As Integer

        Function TotalSalaryEmployeeByRole(listEmps As List(Of EmployeeParent), role As String) As Double

        Function TotalBasic(listEmps As List(Of EmployeeParent)) As Double




    End Interface
End Namespace

