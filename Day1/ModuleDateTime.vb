Module ModuleDateTime
    Sub ShowDate()
        Dim currentTime As Date = Date.UtcNow
        Console.WriteLine("Sekarang Jam : " & currentTime)
        Dim currentDate As Date = Date.Today
        Console.WriteLine("Tanggal sekarang : " & currentDate)
        Dim Datenow As Date
        Datenow = Now() 'method untuk waktu sekarang
        Console.WriteLine("Tanggal dan waktu sekarang : " & Datenow)


        Dim hari, bulan, tahun, jam As Integer
        hari = Day(currentDate)
        bulan = Month(currentDate)
        tahun = Year(currentDate)
        jam = Hour(currentDate)


        Console.WriteLine("Hari : " & hari & " Bulan : " & bulan & " Tahun : " & tahun & " Sekarang Jam : " & jam)


    End Sub
End Module
