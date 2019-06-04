Imports System

Module Program
    Sub Main(args As String())
        Dim p, q, r, s, t As Integer

        Console.Write(" ingrese un valor ")
        p = Console.ReadLine()
        Console.Write(" ingrese un valor ")
        q = Console.ReadLine()
        Console.Write(" ingrese un valor ")
        r = Console.ReadLine()
        Console.Write(" ingrese un valor ")
        s = Console.ReadLine()
        Console.Write(" ingrese un valor ")
        t = Console.ReadLine()
        Console.WriteLine("suma de 2 elementos :" & adicion(p, q))
        Console.WriteLine("suma de 3 elementos :" & adicion(p, q, r))
        Console.WriteLine("suma de 4 elementos :" & adicion(p, q, r, s))
        Console.WriteLine("suma de 5 elementos :" & adicion(p, q, r, s, t))
    End Sub

    Function adicion(a, b) As Integer
        Return a + b
    End Function

    Function adicion(a, b, c) As Integer
        Return adicion(a, adicion(b, c))
    End Function

    Function adicion(a, b, c, d) As Integer
        Return adicion(adicion(a, b), adicion(c, d))
    End Function

    Function adicion(a, b, c, d, e) As Integer
        Return adicion(adicion(a, b), adicion(c, adicion(d, e)))
    End Function
End Module
