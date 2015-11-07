Imports System.IO
Module Module1
    'U2P631 lee del fichero (nombre, apellido, edad) y muestra en pantalla. Para detectar el EOF, lo haremos utilizando: EndOfStreamException o mediante las propiedades del flujo Length y Position.
    Sub Main()
        Dim nombre, apellido As String
        Dim edad As Int16
        Dim fichero As FileStream = New FileStream("C:\prueba\prueba4.txt", FileMode.Open, FileAccess.Read)
        Dim leer As BinaryReader = New BinaryReader(fichero)

        Try
            While (True)
                nombre = leer.ReadString()
                apellido = leer.ReadString()
                edad = leer.ReadInt16()
                Console.WriteLine("Nombre: " & nombre)
                Console.WriteLine("Apellido: " & apellido)
                Console.WriteLine("Edad: " & edad)
            End While

        Catch e As EndOfStreamException
            Console.WriteLine("fin")

        Finally
            leer.Close() : fichero.Close()
        End Try
        Console.ReadKey()
    End Sub

End Module
