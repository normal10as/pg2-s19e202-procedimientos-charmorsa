Imports System

Module Program
    Sub Main(args As String())
        Dim ladoA, ladoB As Double

        Console.Write(" INGRESE UN VALOR: ")
        ladoA = Console.ReadLine()

        Console.Write(" INGRESE OTRO VALOR: ")
        Console.ReadLine()

        Console.WriteLine(" resultado de la hipotenusa: " & hipopotenusa(ladoA, ladoB))
    End Sub

    Function hipopotenusa(a, b) As Double
        Dim c As Double
        c = (a ^ 2) + (b ^ 2)
        Return c
    End Function
End Module
