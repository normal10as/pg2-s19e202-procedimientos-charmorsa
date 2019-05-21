Imports System

Module Program
    Sub Main(args As String())
        Dim a As Integer

        Console.WriteLine("ingresar un valor")
        a = Console.ReadLine()

        Console.WriteLine("potencia del valor ingresado elevado a la quinta: " & potencia(a))
    End Sub
    Function potencia(x) As Double
        Dim i As Integer
        i = 0
        Do While (i <> (x ^ 5))
            If (i = (x ^ 2)) Then
                Console.WriteLine("potencia del valor ingresado elevado al cuadrado: " & i)
            End If
            If (i = (x ^ 3)) Then
                Console.WriteLine("potencia del valor ingresado elevado al cubo: " & i)
            End If
            i = i + 1
        Loop
        Return i
    End Function
End Module
