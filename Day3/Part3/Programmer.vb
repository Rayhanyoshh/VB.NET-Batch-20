Namespace Part3
    Public Class Programmer
        Inherits Employee
        Implements ITunjangan

        Private _makan As Double
        Private _transportasi As Double
        Private _commission As Double
        Private _bonus As Double

        Public Sub New(empID As Integer, firstName As String, lastName As String, joinDate As Date, basicSalary As Double, Optional transportasi As Double = Nothing)
            MyBase.New(empID, firstName, lastName, joinDate, "Programmer", basicSalary)
            _transportasi = transportasi
            MyBase.TotalSalary = MyBase.TotalSalary + transportasi
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

        Private Function TTransportasi(transportasi As Double) As Double Implements ITunjangan.TTransportasi
            Dim UangJalan As Double
            If TypeName(Me) = "Programmer" Then

                MyBase.TotalSalary = UangJalan + BasicSalary
                MyBase.TotalSalary = UangJalan

            End If
        End Function

        Public Function TBonus(Bonus As Double) As Double Implements ITunjangan.TBonus
            Dim UangBonus As Double
            UangBonus = _bonus
            MyBase.TotalSalary += Bonus
        End Function

        Public Function TMakan(Makan As Double) As Double Implements ITunjangan.TMakan
            Dim UangMakan As Double
            UangMakan = _makan
            MyBase.TotalSalary += Makan
        End Function

        Public Function TCommisionBonus(Commission As Double, Bonus As Double) As Double Implements ITunjangan.TCommissionBonus
            Dim UangCommission As Double
            Dim UangBonus As Double
            UangCommission = _commission
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


        Public Overrides Function ToString() As String
            Return $" {MyBase.ToString()}
Bonus transportasi : {_transportasi}
Total Salary       : {MyBase.TotalSalary()}"
        End Function
    End Class
End Namespace
