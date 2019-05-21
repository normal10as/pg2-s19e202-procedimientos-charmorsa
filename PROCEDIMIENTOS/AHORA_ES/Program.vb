Imports System
Imports System.DateTime
Module Program
    Sub Main(args As String())
        imprimir_fecha()
        Console.WriteLine("y la hora es " & obtener_hora())
    End Sub

    Sub imprimir_fecha()
        Console.Write(" hoy es " & Now.Date)
    End Sub

    Function obtener_hora() As String
        Return Now.Hour & ":" & Now.Minute
    End Function
End Module
