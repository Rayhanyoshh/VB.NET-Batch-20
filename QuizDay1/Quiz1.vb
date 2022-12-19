Module Soal1
    Sub TahunHari()

        Dim hari, tahun, totalJam, totalHari, totalMenit As Integer

        Console.WriteLine("input bilangan :")
        totalMenit = Console.ReadLine()

        totalJam = totalMenit / 60 'untuk mencari total berapa jam dari menit yang diinput
        totalHari = totalJam / 24   ' lalu mencari total hari dari total jam yang di dapatkan dari membagi hasil inputan menit

        tahun = totalHari \ 365     'setelah dapat hari maka langsung bisa mencari berapa tahun dari total hari yang di cari sebelumnya
        hari = totalHari Mod 365    'mencari sisa hari yang di dapatkan dari membagi totalhari dengan 1 tahun, sisa dari pembagian tersebut yang digunakan

        Console.WriteLine(totalMenit & " = " & tahun & " tahun, " & hari & " hari")

    End Sub

End Module

Module Soal2

    Sub ShioCalender()
        Dim tahunLahir, hint As Integer
        Console.WriteLine("Enter Tahun Lahir : ")
        tahunLahir = Console.ReadLine()
        hint = tahunLahir Mod 12            'hasil modular tahun lahir yang di input di bagi dengan 12, karena shio itu setiap 12 tahun berganti

        Select Case hint                    'select case, seperti when case di SQL
            Case = 0
                Console.WriteLine("Anda Lahir di tahun monyet")
            Case = 1
                Console.WriteLine("Anda Lahir di tahun ayam")
            Case = 2
                Console.WriteLine("Anda Lahir di tahun anjing")
            Case = 3
                Console.WriteLine("Anda Lahir di tahun babi")
            Case = 4
                Console.WriteLine("Anda Lahir di tahun tikus")
            Case = 5
                Console.WriteLine("Anda Lahir di tahun kerbau")
            Case = 6
                Console.WriteLine("Anda Lahir di tahun harimau")
            Case = 7
                Console.WriteLine("Anda Lahir di tahun kelinci")
            Case = 8
                Console.WriteLine("Anda Lahir di tahun naga")
            Case = 9
                Console.WriteLine("Anda Lahir di tahun ular")
            Case = 10
                Console.WriteLine("Anda Lahir di tahun kuda")
            Case = 11
                Console.WriteLine("Anda Lahir di tahun kambing")

        End Select
    End Sub
End Module

Module Soal3
    Sub SimulasiATM()
        Dim pin = 123                   'memasukkan default password untuk password yang di input, acuan benar atau salah
        Dim chance As Integer = 3        'chance, kesempatan berapa kali, ketika nanti password di input sebelum di blokir
        Dim inputPin As Integer             'input pin yang akan di masukkan
        Do While chance >= 0                ' dilakukan ketika chance dimulai dari 0 dan harus lebih besar dari 0
            If chance > 0 Then              ' Jika chance = 3 dan lebih besar dari 0 maka perulangan bisa di lakukan
                Console.WriteLine("Masukkan pin anda : ")
                inputPin = Console.ReadLine()
                Console.Clear()

                If pin = inputPin Then         'Jika  pin default sama dengan pin input maka transaksi bisa dilakukan
                    Console.WriteLine("Masukkan jumlah uang yang ditarik : ")
                    Dim money As Integer = Console.ReadLine()
                    Dim ten = money \ 10            'mencari pembagian pecahan $10 di inputan uang yang dinput, dengan di bagi 10
                    Dim five = (money Mod 10) \ 5   'mencari sisa dari pembagian money dengan $10, lalu sisa hasil tersebut di bagi lagi 5, untuk mencari berapa lembar $5 
                    Dim one = (money Mod 10) Mod 5  'mencari sisa pembagian dari $10 dan sisa hasil pembagian tersebut di modularkan lagi dengan 5, agar dapat menemukan sisa pecahan uang yang tersisa untuk pcahan $1
                    Console.Clear()
                    Console.WriteLine("Uang yang tunai yang keluar :")
                    Console.WriteLine()
                    Console.WriteLine("$10 = " & ten & " Lembar")
                    Console.WriteLine("$5 = " & five & " Lembar")
                    Console.WriteLine("$1 = " & one & " Lembar")
                    Console.WriteLine()
                    Console.WriteLine("Transaksi Selesai")
                    Exit Do
                Else chance -= 1            'jika pin default tidak sama dengan pin input maka chance di kurangi 1, dari awal 3 dikurang 1 maka tinggal 2, bgtu seterusnya
                    Console.Clear()
                    Console.WriteLine("Kesempatan " & chance & " kali lagi untuk mencoba")
                End If
            Else                        'Jika chance sudah sama dengan 0, maka perulangan berhenti dan pin terblokir
                Console.WriteLine("Pin anda terblokir")
                Exit Sub
            End If
        Loop
    End Sub
End Module


Module soal4

    Sub BatuGuntingKertas()
game:
        Dim user As Integer
        Dim rand As New Random()            'deklarasi untuk variabel random dengan New Random
        Console.Write("Pilih : " & vbCrLf & "(1) Gunting" & vbCrLf & "(2) Batu" & vbCrLf & "(3) Kertas") 'vBCrLf untuk enter didalam input
        Console.WriteLine()
        Console.WriteLine("Pilihan anda ?")
        user = Console.ReadLine()            'inputan user 

        If (user > 3) Or (user < 1) Then     'jika inputan user lebih dari 3 atau kurang dari 1 maka
            Console.WriteLine("Pilihan anda invalid")
            GoTo game
        Else
            Dim comp As Integer = rand.NextInt64(1, 4)              'variabel baru untuk menyimpan angka random dari varibel rand, (1,4) dimulai dari 1 dan kurangdari 4
            If (user = 1) And (comp = 1) Then
                Console.WriteLine("Gunting dengan Gunting, SERI")
                GoTo game
            ElseIf (user = 2) And (comp = 2) Then
                Console.WriteLine("Batu dengan Batu, SERI")
                GoTo game
            ElseIf (user = 3) And (comp = 3) Then
                Console.WriteLine("Kertas dengan Kertas, SERI")
                GoTo game

            ElseIf (user = 1) And (comp = 2) Then
                Console.WriteLine("Gunting dengan Batu, KALAH")
                GoTo game
            ElseIf (user = 2) And (comp = 1) Then
                Console.WriteLine("Batu dengan Gunting, MENANG")
                GoTo game
            ElseIf (user = 2) And (comp = 3) Then
                Console.WriteLine("Batu dengan Kertas, KALAH")
                GoTo game
            ElseIf (user = 3) And (comp = 2) Then
                Console.WriteLine("Kertas dengan Batu, MENANG")
                GoTo game
            ElseIf (user = 1) And (comp = 3) Then
                Console.WriteLine("Gunting dengan Kertas, MENANG")
                GoTo game
            ElseIf (user = 3) And (comp = 1) Then
                Console.WriteLine("Kertas dengan Batu, KALAH")
                GoTo game
            End If
        End If
    End Sub
End Module

Module Soal5
    Sub TebakHadiah()
tebak:
        Dim user As Integer
        Dim rand As New Random()
        Console.WriteLine("User Input : ")
        user = Console.ReadLine()

        If (user < 10) Or (user > 99) Then                  'jika user input kurang dari 10 dan lebih besar dari 99 maka
            Console.WriteLine("Pilihan anda invalid")
            GoTo tebak
        Else
            Dim comp As Integer = rand.NextInt64(10, 100)   'angka random comp, dimulai dari 10 dan kurang dari 100
            Console.WriteLine("Computer Random Number : " & comp)
            Dim point = 0, angkauser1, angkauser2, angkacomp1, angkacomp2 As Integer 'deklarasi variabel dibutuhkan 

            angkauser1 = user \ 10          'mencari angka pertama dari inputan user, dengan membaginya dengan 10 agar dapat angka puluhannya
            angkacomp1 = comp \ 10          'mencari angka pertama dari inputan comp, dengan membaginya dengan 10 agar dapat angka puluhannya

            angkacomp2 = comp Mod 10        'mencari angka kedua dari inputan user, dengan mendapatkan sisa hasil bagi dengan 10 agar dapat angka satuannya
            angkauser2 = user Mod 10        'mencari angka kedua dari inputan comp, dengan mendapatkan sisa hasil bagi dengan 10 agar dapat angka satuannya

            If angkauser1 = angkacomp1 Then point += 1  'jika angka pertama user dan angka pertama comp sama, maka poin di tambah 1
            If angkauser2 = angkacomp2 Then point += 1  'jika angka kedua user dan angka pertama comp sama, maka poin di tambah 1

            If point = 2 Then                           'jika point sudah sama dengan 2 maka
                Console.WriteLine("Anda dapat 100.000")
                GoTo tebak
            ElseIf point = 1 Then                       'jika point sudah sama dengan 1 maka
                Console.WriteLine("Anda dapat 50.000")
                GoTo tebak
            Else                                        'jika point masih sama dengan 0 maka
                Console.WriteLine("Anda kalah")
                GoTo tebak
            End If
        End If
    End Sub
End Module

Module Soal6
    Sub deretAngkaDouble(n As Integer)
        For i = 1 To n - 1                          'n-1 karena untuk dapat deret terakhir itu angka input yang di kurangi 1
            Console.Write(i * -1 & " ," & i & " ,")
        Next
        Console.WriteLine(n * -1)
    End Sub
End Module

Module Soal7
    Sub PersegiAngka()
        Dim n As Integer
        Console.Write("Masukkan Panjang Deret : ")
        n = Console.ReadLine()
        For i = 1 To 5
            If i Mod 2 = 1 Then
                For j = n To 1 Step -1
                    Console.Write(j)
                Next
            Else
                For j = 1 To n
                    Console.Write(j)
                Next
            End If
            Console.WriteLine()
        Next
    End Sub
End Module

Module Soal8

    Sub SegitigaAngka()
        Dim n As Integer
        Console.Write("Masukkan Panjang Deret : ")
        n = Console.ReadLine()

        For i = 1 To n
            For j = 1 To n - i + 1
                Console.Write(j)
            Next
            Console.WriteLine()
        Next
        Console.WriteLine()
        For i = 1 To n
            For j = n - i + 1 To 1 Step -1
                Console.Write(j)
            Next
            Console.WriteLine()
        Next


    End Sub

End Module

Module Soal9
    Sub ShowPrimeNumber()
        Dim tmp, x, y, z As Double
        tmp = 0
        For x = 1 To 100
            z = 0
            For y = 1 To x
                If (x Mod y = 0) Then
                    z = z + 1
                End If
            Next
            If z = 2 Then
                Console.Write(x & ",")
                tmp = tmp + 1
            End If
            If tmp = 5 Then
                Console.WriteLine()
                tmp = 0
            End If
        Next

    End Sub

End Module

Module Soal10
    Function isCharUnique(Chars As String) As Boolean
        Dim CharSize = Len(Chars) - 1

        For outer = 0 To CharSize
            For inner = outer + 1 To CharSize
                If Chars(outer) = Chars(inner) Then
                    Return False
                    Exit For
                End If

            Next
        Next
        Return True
    End Function

    Sub CharUnique(param As String)
        Dim strArr() As Char = param.ToCharArray
        Console.WriteLine($"{param} adalah {isCharUnique(param)}")
    End Sub
End Module



Module Soal11
    Function Palindrome(chars As String) As Boolean
        Dim temp As String
        Dim strArr = chars.ToLower()
        Dim strSize = Len(chars) - 1
        For outer = 0 To strSize
            If strArr(outer) <> strArr(strSize - outer) Then
                Return False
            End If
            'temp = strArr(outer) & " " & strArr(strSize - outer)
        Next
        Return True
    End Function
    Sub isPalindrome(param As String)
        Console.WriteLine($"{Palindrome(param)}")
    End Sub
End Module

Module Soal12
    Sub MaxWordLength(param As String)
        Dim temp() As String = Split(param)
        Dim longest = temp.OrderByDescending(Function(s) s.Length).FirstOrDefault()
        Console.WriteLine(longest)
        'Console.WriteLine(Len(temp(0))
        'cara mengetahui ukuran length
        'For i = 0 To temp.Count - 1
        '    Console.WriteLine(temp(i))
        'Next
    End Sub
End Module

Module Soal13
    Sub TahunKabisat(param1 As Integer, param2 As Integer)

        If (param2 < param1) Then
            Console.Write("Invalid Input")
            Exit Sub
        End If

        Dim totalKabisat As Integer
        Dim tahunKabisat As String
        For i = param1 To param2
            If (i Mod 4 = 0) Then
                totalKabisat = totalKabisat + 1
                tahunKabisat = tahunKabisat + i.ToString + " "
            End If
        Next
        Console.WriteLine($"Total tahun kabisat : {totalKabisat} tahun = {tahunKabisat}")
    End Sub
End Module
