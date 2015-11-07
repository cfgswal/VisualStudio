Imports System.IO
Module Module1
    'Desarrolla un programa que cree un fichero,con el nombre indicado por el usuario, que guarde los datos de un conjunto de personas (nombre, dirección, teléfono y dirección de correo).
    'Posteriormente lee los datos de este fichero y visualízalos en pantalla.
    Sub Main()
        Dim acabar, fich, nombre, direccion, correo As String
        Dim telefono As Int32
        Console.WriteLine("Dime nombre del fichero: ")
        fich = Console.ReadLine()
        Dim fichero As FileStream = New FileStream("c:\prueba\" & fich & ".txt", FileMode.Append, FileAccess.Write)
        Dim escribe As BinaryWriter = New BinaryWriter(fichero)
        Do
            Console.WriteLine("Dame el nombre:")
            nombre = Console.ReadLine()
            escribe.Write(nombre)
            Console.WriteLine("Dame la direccion:")
            direccion = Console.ReadLine()
            escribe.Write(direccion)
            Console.WriteLine("Dame el telefono:")
            telefono = Convert.ToInt32(Console.ReadLine())
            escribe.Write(telefono)
            Console.WriteLine("Dame la direccion de correo:")
            correo = Console.ReadLine()
            escribe.Write(correo)
            Console.WriteLine("Quieres acabar?????Pulsa s")
            acabar = Console.ReadLine().ToLower
            Console.WriteLine(vbCrLf)
        Loop Until acabar.Contains("s")

        fichero.Close() : escribe.Close()

        fichero = New FileStream("C:\prueba\" & fich & ".txt", FileMode.Open, FileAccess.Read)
        Dim leer As BinaryReader = New BinaryReader(fichero)

        Try
            While (True)

                Console.WriteLine("Nombre:  " & leer.ReadString())
                Console.WriteLine("Direccion: " & leer.ReadString())
                Console.WriteLine("Telefono: " & leer.ReadInt32())
                Console.WriteLine("Direccion: " & leer.ReadString())
                Console.WriteLine(vbCrLf)
            End While

        Catch e As EndOfStreamException
            Console.WriteLine()

        Finally
            leer.Close() : fichero.Close()
        End Try
        Console.ReadKey()

    End Sub

End Module
