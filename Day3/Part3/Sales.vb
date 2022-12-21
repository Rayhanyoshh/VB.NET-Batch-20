Namespace Part3
    Public Class Sales
        Inherits Employee
        Implements ITunjangan

        Private _makan As Double
        Private _transportasi As Double
        Private _commission As Double
        Private _bonus As Double

        Public Sub New(empId As Integer, firstName As String, lastName As String, joinDate As Date, basicSalary As Double, Optional bonus As Double = Nothing, Optional commision As Double = Nothing)
            MyBase.New(empId, firstName, lastName, joinDate, "Sales", basicSalary)
            _bonus = bonus
            _commission = commision
            MyBase.TotalSalary = _bonus + _commission + MyBase.BasicSalary
        End Sub

        Public Overrides Function Nett() As Double
            Dim GajiBersih As Double
            GajiBersih = MyBase.BasicSalary
        End Function

        Public Overrides Function Gross() As Double
            Dim GajiKotor As Double
            GajiKotor = MyBase.TotalSalary
        End Function

        Public Function InItEmployee() As List(Of Employee) Implements ITunjangan.InItEmployee
            Throw New NotImplementedException
        End Function

        Public Function TTransportasi(transportasi As Double) As Double Implements ITunjangan.TTransportasi
            Dim UangJalan As Double
            UangJalan = _transportasi
            MyBase.TotalSalary += transportasi
        End Function

        Public Function TBonus(Bonus As Double) As Double Implements ITunjangan.TBonus
            Dim UangBonus = _bonus
            MyBase.TotalSalary += Bonus
        End Function

        Public Function TMakan(Makan As Double) As Double Implements ITunjangan.TMakan
            Dim UangMakan As Double
            UangMakan = _makan
            MyBase.TotalSalary += Makan
        End Function

        Private Function TCommisionBonus(Commission As Double, Bonus As Double) As Double Implements ITunjangan.TCommissionBonus
            Dim UangCommission As Double
            Dim UangBonus As Double
            If TypeName(Me) = "Sales" Then

                MyBase.TotalSalary = UangCommission + UangBonus + BasicSalary
                MyBase.TotalSalary = UangCommission

            End If
        End Function

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
                Return _commission
            End Get
            Set(value As Double)
                _commission = value
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
Bonus              : {_bonus}
Bonus Commission   : {_commission}
Total Salary       : {MyBase.TotalSalary()}"
        End Function
    End Class
End Namespace