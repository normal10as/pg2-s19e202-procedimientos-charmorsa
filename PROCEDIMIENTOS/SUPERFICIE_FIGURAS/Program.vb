Imports System

Module Program
    Sub Main(args As String())
        Dim a, b, c As Integer
        Console.Write("ingrese un valor: ")
        a = Console.ReadLine()
        Console.Write("ingrese otro valor: ")
        b = Console.ReadLine()
        Console.Write("ingrese otra vez un valor: ")
        c = Console.ReadLine()
        Console.WriteLine(" es un cuadrado " & super(a))
        Console.WriteLine(" es un rectangulo " & super(a, b))
        Console.WriteLine(" es un trapecio " & super(a, b, c))
    End Sub
    Function super(p) As Double
        Dim resultado As Double

        resultado = p * p
        Return resultado
    End Function

    Function super(p, q) As Double
        Dim resultado As Double

        resultado = p * q
        Return resultado
    End Function

    Function super(p, q, r) As Double
        Dim resultado As Double

        resultado = (((p + r) / 2) * q)
        Return resultado
    End Function
End Module
