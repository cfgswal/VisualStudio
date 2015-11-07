'P6E20 lee datos del teclado y los graba en un fichero. Pide el nombre del fichero por consola.
Imports System.IO
Module Module1

    Sub Main()

        Console.WriteLine("Dime el nombre del archivo")
        Dim nombre As String = Console.ReadLine

        Dim escritura As StreamWriter = New StreamWriter("c:\prueba\" & nombre & ".txt")

        escritura.Write(Console.ReadLine())
        escritura.Close()

    End Sub

End Module
