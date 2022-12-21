Namespace Part2
    Friend Class QA
        Inherits EmployeeParent

        Private _makan As Double

        Public Sub New(empId As Integer, firstName As String, lastName As String, joinDate As Date, basicSalary As Double, Optional makan As Double = Nothing)
            MyBase.New(empId, firstName, lastName, joinDate, "QA", basicSalary)
            _makan = makan
            MyBase.TotalSalary = makan + MyBase.BasicSalary
        End Sub

        Public Overrides Function ToString() As String
            Return $" {MyBase.ToString()}
Bonus Makan        : {_makan}
Total Salary       : {MyBase.TotalSalary()}"
        End Function

        Public Property Makan As Double
            Get
                Return _makan
            End Get
            Set(value As Double)
                _makan = value
                TotalSalary = value + BasicSalary
            End Set
        End Property

        Public Overrides Property BasicSalary As Double
            Get
                Return MyBase.BasicSalary
            End Get
            Set(value As Double)
                MyBase.BasicSalary = value
                TotalSalary = value + _makan
            End Set
        End Property

        Public Overrides Function Nett() As Double

            Return TotalSalary - Makan
        End Function

        Public Overrides Function Gross() As Double
            Throw New NotImplementedException()
        End Function
    End Class
End Namespace

