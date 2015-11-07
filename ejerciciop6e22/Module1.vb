'P6E22 lee datos del fichero y los muestra en pantalla
Imports System.IO
Module Module1

    Sub Main()

        Dim lee As StreamReader = New StreamReader("c:\prueba\prueba.txt")
        Console.Write(lee.ReadLine())

        lee.Close()
        Console.ReadKey()

    End Sub

End Module
