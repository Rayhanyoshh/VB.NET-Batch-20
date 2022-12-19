Namespace Part1
    Public Class Employee1                   '1 row record itu 1 objek, 2 row 2 objek
        Public empId As Integer
        Public FirstName As String
        Public LastName As String
        Public JoinDate As Date
        Public BasicSalary As Double


        Public Overrides Function ToString() As String
            Return $"
EmpID        : {empId} 
FirstName    : {FirstName} 
LastName     : {LastName} 
JoinDate     : {JoinDate} 
Basic Salary : {BasicSalary}"

        End Function

    End Class
End Namespace
