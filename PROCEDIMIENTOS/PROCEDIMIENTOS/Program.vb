Imports System

Module Program
    Sub Main(args As String())
        Dim dias As Byte
        Dim fecha As Date

        Console.WriteLine("ingrese un numero: ")
        dias = Console.ReadLine()
        Console.WriteLine("ingrese una fecha: ")
        fecha = Console.ReadLine()

        Console.WriteLine("resultado " & nueva_fecha(fecha, dias))
    End Sub

    Function nueva_fecha(a, b) As Date

        Dim suma As Date

        suma = a.adddays(b)

        Return suma

    End Function
End Module
