Imports System

Module Program
    Sub Main(args As String())

        Call acumula()
    End Sub
    Sub acumula()
        Dim acumulador, a As Double
        For i = 0 To 4
            Console.Write("ingrese un valor ")
            a = Console.ReadLine()
            acumulador = acumulador + a
        Next
        Console.Write(" numeros acumulados " & acumulador)
    End Sub
End Module
