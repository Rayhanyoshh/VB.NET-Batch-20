Namespace Part3
    Public Class QA
        Inherits Employee
        Implements ITunjangan

        Private _makan As Double
        Private _transportasi As Double
        Private _commission As Double
        Private _bonus As Double

        Public Sub New(empId As Integer, firstName As String, lastName As String, joinDate As Date, basicSalary As Double, Optional makan As Double = Nothing)
            MyBase.New(empId, firstName, lastName, joinDate, "QA", basicSalary)
            _makan = makan
            MyBase.TotalSalary = makan + MyBase.BasicSalary
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
            Dim UangBonus As Double
            UangBonus = _bonus
            MyBase.TotalSalary += Bonus
        End Function

        Private Function TMakan(Makan As Double) As Double Implements ITunjangan.TMakan
            Dim UangMakan As Double
            If TypeName(Me) = "QA" Then

                MyBase.TotalSalary = UangMakan + BasicSalary
                MyBase.TotalSalary = UangMakan

            End If
        End Function

        Public Function TCommisionBonus(Commission As Double, Bonus As Double) As Double Implements ITunjangan.TCommissionBonus
            Dim UangCommission As Double
            Dim UangBonus As Double
            UangCommission = _commission
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
    End Class
End Namespace