Namespace Part2
    Public Class Employee2
        '1 row record itu 1 objek, 2 row 2 objek

        Private _empId As Integer
        Private _FirstName As String
        Private _LastName As String
        Private _JoinDate As Date
        Private _BasicSalary As Double
        Private _totalSalary As Double
        Private _id As Integer = New Random().NextInt64(1, 10)

        'create constructor, hanya 1 kali menginisial value saat create object
        'buat constructor dulu baru buat property
        'constructor untuk menyimpan parameter di Part2
        '1 class bisa buat lebih dari 1 constructor
        ' 1 row itu 1 objek



        Public Sub New(empId As Integer, firstName As String, lastName As String, joinDate As Date, basicSalary As Double)
            _empId = empId
            _FirstName = firstName
            _LastName = lastName
            _JoinDate = joinDate
            _BasicSalary = basicSalary
            _totalSalary = basicSalary
        End Sub

        Public Sub New(firstName As String, lastName As String, joinDate As Date, basicSalary As Double)
            _empId = _id
            _FirstName = firstName
            _LastName = lastName
            _JoinDate = joinDate
            _BasicSalary = basicSalary
            _totalSalary = basicSalary
        End Sub


        Public Property EmpId As Integer 'beda nya dengan constructor bisa berkali- kali inisiasi dengan syarat objek sudah sudah dibuat
            Get
                Return _empId
            End Get
            Set(value As Integer)
                _empId = value
            End Set
        End Property

        Public Property FirstName As String
            Get
                Return _FirstName
            End Get
            Set(value As String)
                _FirstName = value
            End Set
        End Property

        Public Property LastName As String
            Get
                Return _LastName
            End Get
            Set(value As String)
                _LastName = value
            End Set
        End Property

        Public Property JoinDate As Date
            Get
                Return _JoinDate
            End Get
            Set(value As Date)
                _JoinDate = value
            End Set
        End Property

        Public Overridable Property BasicSalary As Double
            Get
                Return _BasicSalary
            End Get
            Set(value As Double)
                _BasicSalary = value
            End Set
        End Property



        Public Property TotalSalary As Double
            Get
                Return _totalSalary
            End Get
            Set(value As Double)
                _totalSalary = value

            End Set
        End Property



        Public Overrides Function ToString() As String  'Me, utk memanggil atribut dalam 1 class
            Return $"                   
EmpID              : {Me.EmpId}           
FirstName          : {Me.FirstName} 
LastName           : {Me.LastName} 
JoinDate           : {Me.JoinDate} 
Basic Salary       : {Me.BasicSalary}"

        End Function
    End Class
End Namespace
