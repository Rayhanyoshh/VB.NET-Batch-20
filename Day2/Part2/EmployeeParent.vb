Imports System.Data
Imports VbAppConsole.Part2

Namespace Part2
    Public MustInherit Class EmployeeParent
        Private _empId As Integer
        Private _FirstName As String
        Private _LastName As String
        Private _JoinDate As Date
        Private _RoleJob As String
        Private _BasicSalary As Double
        Private _totalSalary As Double

        'Public MustOverride Function Nett() As Double

        Protected Sub New(empId As Integer, firstName As String, lastName As String, joinDate As Date, rolejob As String, basicSalary As Double)
            _empId = empId
            _FirstName = firstName
            _LastName = lastName
            _JoinDate = joinDate
            _RoleJob = rolejob
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

        Public Property RoleJob As String
            Get
                Return _RoleJob
            End Get
            Set(value As String)
                _RoleJob = value
            End Set
        End Property

        Public MustOverride Function Nett() As Double

        Public MustOverride Function Gross() As Double

        Public Overridable Function ToString() As String  'Me, utk memanggil atribut dalam 1 class
            Return $"                   
EmpID              : {Me.EmpId}           
FirstName          : {Me.FirstName} 
LastName           : {Me.LastName} 
JoinDate           : {Me.JoinDate} 
Role Job           : {Me.RoleJob}
Basic Salary       : {Me.BasicSalary}"

        End Function

    End Class
End Namespace
