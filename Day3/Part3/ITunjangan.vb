Namespace Part3
    Public Interface ITunjangan

        Function InItEmployee() As List(Of Employee)

        Function TTransportasi(transportasi As Double) As Double

        Function TBonus(Bonus As Double) As Double

        Function TMakan(Makan As Double) As Double

        Function TCommissionBonus(Commission As Double, Bonus As Double) As Double
    End Interface
End Namespace