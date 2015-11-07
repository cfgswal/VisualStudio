'P6E23 lee datos del teclado y se graban en el fichero a través del flujo FileStream y lee del fichero y muestra en pantalla
Imports System.IO
Module Module1

    Sub Main()

        Dim fichero As FileStream = New FileStream("c:\prueba\prueba3.txt", FileMode.Append, FileAccess.Write)
        Dim escribir As StreamWriter = New StreamWriter(fichero)

        escribir.WriteLine(Console.ReadLine())
        escribir.Close()


        Dim leer As StreamReader = New StreamReader("c:\prueba\prueba3.txt")

        Do While leer.Peek() >= 0
            Console.WriteLine(leer.ReadLine())
        Loop

        leer.Close()

        Console.ReadKey()
    End Sub

End Module