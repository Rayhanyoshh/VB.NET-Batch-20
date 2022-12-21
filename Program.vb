Imports System
Imports VbAppConsole.Part3
Module Program
    Sub Main(args As String())
        '    Sub Main(args As String(), InterfaceHR As I_HR)
        '        Dim listEmp = InterfaceHR.InItEmployee()
        '        InterfaceHR.DisplayEmployee(listEmp)


        '        Dim emps = InterfaceHR.FindEmployeeByID(listEmp, 3)
        '        If emps IsNot Nothing Then
        '            Consol e.Write($"

        'Employee found : {emps}")
        '        Else
        '            Console.Write($"

        'Employee is not found")
        '        End If

        '        Dim TotalSalarySemua = InterfaceHR.TotalSalaryAll(listEmp)
        '        Console.WriteLine($"

        'Total Semua Gaji Karyawan : {TotalSalarySemua}")
        '        Dim TotalBasicGaji = InterfaceHR.TotalBasic(listEmp)
        '        Console.WriteLine($"
        'Total Basic Gaji Semua Karyawan : {TotalBasicGaji}")

        '        Dim inputrole = "QA"
        '        Dim totalQA = InterfaceHR.TotalEmployeeByRole(listEmp, inputrole)
        '        Console.WriteLine($"
        'Total Karyawan {inputrole} sebanyak : {totalQA}")

        '        Dim RoleProg = "Programmer"
        '        Dim totalProg = InterfaceHR.TotalEmployeeByRole(listEmp, RoleProg)
        '        Console.WriteLine($"
        'Total Karyawan {RoleProg} sebanyak : {totalProg}")

        '        Dim RoleSales = "Sales"
        '        Dim totalSales = InterfaceHR.TotalEmployeeByRole(listEmp, RoleSales)
        '        Console.WriteLine($"
        'Total Karyawan {RoleSales} sebanyak : {totalSales}")


        '        Dim SalaryQA = "QA"
        '        Dim totalRoleSalaryQA = InterfaceHR.TotalSalaryEmployeeByRole(listEmp, SalaryQA)
        '        Console.WriteLine($"
        'Total Gaji Tiap Karyawan {SalaryQA} sebanyak : {totalRoleSalaryQA} ")

        '        Dim SalaryProg = "Programmer"
        '        Dim totalRoleSalaryProg = InterfaceHR.TotalSalaryEmployeeByRole(listEmp, SalaryProg)
        '        Console.WriteLine($"
        'Total Gaji Tiap Karyawan {SalaryProg} sebanyak : {totalRoleSalaryProg}")

        '        Dim SalarySales = "Sales"
        '        Dim totalRoleSalarySales = InterfaceHR.TotalSalaryEmployeeByRole(listEmp, SalarySales)
        '        Console.WriteLine($"
        'Total Gaji Tiap Karyawan {SalarySales} sebanyak : {totalRoleSalarySales}")

        ModuleTesting.Testing()

    End Sub


End Module
