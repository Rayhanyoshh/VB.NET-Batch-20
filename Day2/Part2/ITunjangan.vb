Namespace Part2
    Public Interface ITunjangan



        Function TunjanganTransportasi() As Double

        Function TunjanganMakan() As Double

        Function Bonus() As Double

        Function Commission() As Double
        Function TunjanganMakan(listEmp As List(Of EmployeeParent), makan As Double) As Double
    End Interface
End Namespace
