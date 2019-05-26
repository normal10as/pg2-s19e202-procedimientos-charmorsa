Imports System

Module Program
    Sub Main(args As String())
        Dim a, b As Byte
        b = 2
        Console.WriteLine("ingresar un valor")
        a = Console.ReadLine()

        Console.WriteLine("potencia del valor ingresado elevado al cuadrado: " & potencia(a, b))
        Console.WriteLine("potencia del valor ingresado elevado al cubo: " & potencia(a, b))
        Console.WriteLine("potencia del valor ingresado elevado a la cuarta: " & potencia(a, b))
        Console.WriteLine("potencia del valor ingresado elevado a la quinta: " & potencia(a, b))
    End Sub
    Function potencia(ByVal x, ByRef i) As Byte
        Dim r As Byte
        r = x ^ i
        i = i + 1
        Return r
    End Function
End Module
