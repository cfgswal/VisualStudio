
'U2P630 lee del teclado (nombre, apellido, edad) y graba através del flujo FileStream
Imports System.IO

Module Module1
    Sub Main()
        Dim nombre, apellido As String
        Dim edad As Int16
        Dim fichero As FileStream = New FileStream("c:\prueba\prueba4.txt", FileMode.Append, FileAccess.Write)
        Dim escribe As BinaryWriter = New BinaryWriter(fichero)
        Console.WriteLine("Dame el nombre:")
        nombre = Console.ReadLine()
        escribe.Write(nombre)
        Console.WriteLine("Dame el apellido:")
        apellido = Console.ReadLine()
        escribe.Write(apellido)
        Console.WriteLine("Dame la edad:")
        edad = Convert.ToInt16(Console.ReadLine())
        escribe.Write(edad)

        fichero.Close() : escribe.Close()




    End Sub

End Module
