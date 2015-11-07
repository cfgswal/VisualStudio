Imports System.IO
Module Module1
    ' P611 Lee los datos del fichero y muéstralos en pantalla
    Sub Main()

        Dim array(80) As Byte

        Dim fichero As FileStream


        fichero = New FileStream("c:\prueba\texto.txt", FileMode.Open, FileAccess.Read)

        fichero.Read(array, 0, 80)

        For x = 0 To array.Length - 1
            Console.Write(Convert.ToChar(array(x)))
        Next

        fichero.Close()

        Console.ReadKey()
    End Sub

End Module
