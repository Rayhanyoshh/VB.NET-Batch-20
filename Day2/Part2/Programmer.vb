Namespace Part2
    Public Class Programmer
        Inherits EmployeeParent
        Implements ITunjangan 'inherits, untuk deklarasi parent nya si Class

        Private _transportasi As Double

        Public Sub New(empID As Integer, firstName As String, lastName As String, joinDate As Date, basicSalary As Double, Optional transportasi As Double = Nothing)
            MyBase.New(empID, firstName, lastName, joinDate, "Programmer", basicSalary)
            _transportasi = transportasi
            MyBase.TotalSalary = MyBase.TotalSalary + transportasi
        End Sub



        Public Overrides Function ToString() As String
            Return $" {MyBase.ToString()}
Bonus transportasi : {_transportasi}
Total Salary       : {MyBase.TotalSalary()}"
        End Function

        Public Function TunjanganMakan() As Double Implements ITunjangan.TunjanganMakan
            Throw New NotImplementedException()
        End Function

        Public Function TunjanganTransportasi() As Double Implements ITunjangan.TunjanganTransportasi


        End Function

        Public Function Bonus() As Double Implements ITunjangan.Bonus
            Throw New NotImplementedException()
        End Function

        Public Function Commission() As Double Implements ITunjangan.Commission
            Throw New NotImplementedException()
        End Function

        Public Property Transportasi As Double
            Get
                Return _transportasi
            End Get
            Set(value As Double)
                _transportasi = value
                TotalSalary = value + Transportasi
            End Set
        End Property

        Public Overrides Property BasicSalary As Double
            Get
                Return MyBase.BasicSalary
            End Get
            Set(value As Double)
                MyBase.BasicSalary = value
                TotalSalary = value + Transportasi
            End Set
        End Property

        Public Overrides Function Nett() As Double
            Return TotalSalary - Transportasi
        End Function

        Public Overrides Function Gross() As Double
            Return TotalSalary
        End Function

        Public Function TunjanganMakan(listEmp As List(Of EmployeeParent), makan As Double) As Double Implements ITunjangan.TunjanganMakan
            Throw New NotImplementedException()
        End Function
    End Class

End Namespace