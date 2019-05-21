Imports System
Imports System.Math
Module Program
    Sub Main(args As String())
        Dim radio, altura As Double
        Console.Write("ingrese el radio de la base del cilindro: ")
        radio = Console.ReadLine()
        Console.Write("ingrese la altura del cilindro: ")
        altura = Console.ReadLine()

        Console.WriteLine("resultado del volumen del cilindro es " & cilindro(radio, altura))
    End Sub

    Function cilindro(r, h) As Double
        Dim volumen As Double

        volumen = (PI * r ^ 2) * h
        Return volumen

    End Function
End Module
