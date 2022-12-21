Namespace Part2
    Friend Class Sales
        Inherits EmployeeParent

        Private _bonus As Double
        Private _commision As Double

        Public Sub New(empId As Integer, firstName As String, lastName As String, joinDate As Date, basicSalary As Double, Optional bonus As Double = Nothing, Optional commision As Double = Nothing)
            MyBase.New(empId, firstName, lastName, joinDate, "Sales", basicSalary)
            _bonus = bonus
            _commision = commision
            MyBase.TotalSalary = _bonus + _commision + MyBase.BasicSalary
        End Sub

        Public Property Bonus As Double
            Get
                Return _bonus
            End Get
            Set(value As Double)
                _bonus = value
                TotalSalary = value + Commision + BasicSalary
            End Set
        End Property

        Public Property Commision As Double
            Get
                Return _commision
            End Get
            Set(value As Double)
                _commision = value
                TotalSalary = value + Bonus + BasicSalary
            End Set
        End Property

        Public Overrides Property BasicSalary As Double
            Get
                Return MyBase.BasicSalary
            End Get
            Set(value As Double)
                MyBase.BasicSalary = value
                TotalSalary = value + Bonus + Commision
            End Set
        End Property

        Public Overrides Function ToString() As String
            Return $" {MyBase.ToString()}
Bonus Sales        : {_bonus}
Commision          : {_commision}
Total Salary       : {MyBase.TotalSalary()}"
        End Function

        Public Overrides Function Nett() As Double

            Return TotalSalary - Commision - Bonus
        End Function

        Public Overrides Function Gross() As Double
            Throw New NotImplementedException()
        End Function
    End Class
End Namespace