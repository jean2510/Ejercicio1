Module Module1
    Sub Main()
        Dim Numero, a, b, c, invertido As Integer

        Numero = LeeEntero("Ingrese numero ", "No a ingresado numero de 3 cifras ", 100, 9000)

        a = Numero / 100
        b = (Numero Mod 100) / 10
        c = (Numero Mod 100) Mod 10
        invertido = (c * 100) + (b * 10) + (a)

        Console.Clear()
        Console.WriteLine(vbCrLf & vbCrLf & "El numero ingresado es: " & Numero & vbCrLf)
        Console.WriteLine("El numero invertido es: " & invertido)
        Console.ReadLine()
    End Sub

    Public Function LeeEntero(ByVal Texto As String, ByVal Err As String, ByVal MIN As Integer, ByVal MAX As Integer) As Integer
        Dim Num As Integer
Leer:
        Console.Write(vbCrLf & vbCrLf & Texto)
        Num = CInt(Console.ReadLine)
        If Num >= MIN And Num <= MAX Then
            Return Num
        Else
            Console.WriteLine(vbCrLf & Err)
            Console.ReadLine()
            GoTo Leer
        End If
    End Function
End Module

