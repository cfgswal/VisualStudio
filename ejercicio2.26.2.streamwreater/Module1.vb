Imports System.IO
Module Module1
    'Desarrolla un programa que cree un fichero, con el nombre indicado por el usuario, que guarde los datos de un conjunto de personas (nombre, dirección, teléfono y dirección de correo). 
    'Posteriormente lee los datos de este fichero y visualízalos en pantalla.
    Sub Main()
        Dim acabar, fich, nombre, direccion, correo As String
        Dim telefono As String
        Console.WriteLine("Dime nombre del fichero: ")
        fich = Console.ReadLine()
        Dim fichero As FileStream = New FileStream("c:\prueba\" & fich & ".txt", FileMode.Create, FileAccess.Write)
        Dim escribe As StreamWriter = New StreamWriter(fichero)
        Do
            Console.WriteLine("Dame el nombre:")
            nombre = Console.ReadLine()
            escribe.WriteLine(nombre)
            Console.WriteLine("Dame la direccion:")
            direccion = Console.ReadLine()
            escribe.WriteLine(direccion)
            Console.WriteLine("Dame el telefono:")
            telefono = Console.ReadLine()
            escribe.WriteLine(telefono)
            Console.WriteLine("Dame la direccion de correo:")
            correo = Console.ReadLine()
            escribe.WriteLine(correo)
            Console.WriteLine("Quieres acabar?????Pulsa s")
            acabar = Console.ReadLine().ToLower
            Console.WriteLine(vbCrLf)

        Loop Until acabar.Contains("s")

        escribe.Close() : fichero.Close()


        fichero = New FileStream("C:\prueba\" & fich & ".txt", FileMode.Open, FileAccess.Read)
        Dim leer As StreamReader = New StreamReader(fichero)

        While leer.Peek <> -1

            Console.WriteLine("Nombre:  " & leer.ReadLine)
            Console.WriteLine("Direccion: " & leer.ReadLine)
            Console.WriteLine("Telefono: " & leer.ReadLine)
            Console.WriteLine("Correo: " & leer.ReadLine)
            Console.WriteLine(vbCrLf)

        End While

        leer.Close() : fichero.Close()

        Console.ReadKey()
    End Sub

End Module
