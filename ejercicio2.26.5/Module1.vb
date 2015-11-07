Imports System.IO
Module Module1
    '2.26.5 Desarrolla un programa que nos permita ir grabando en un fichero los datos de un conjunto de personas. De cada persona se quiere guardar un código, el nombre, la dirección, el teléfono y la edad. 
    'Los códigos de las personas son consecutivos(1, 2, 3, 4, 5, etc...).
    Sub Main()
        Dim i As Int32 = 1
        Dim acabar As String
        Dim persona = New persona

        Dim fichero As FileStream = New FileStream("c:\prueba\prueba.txt", FileMode.Create, FileAccess.Write)
        Dim escribir As BinaryWriter = New BinaryWriter(fichero)
        Dim tamareg As Int32 = 100


        Do
            persona.codigo = i
            escribir.BaseStream.Seek((persona.codigo - 1) * tamareg, SeekOrigin.Begin)
            Console.WriteLine("Dame el nombre: ")
            persona.nombre = Console.ReadLine()
            Console.WriteLine("Dame el direccion: ")
            persona.direccion = Console.ReadLine()
            Console.WriteLine("Dame el telefono: ")
            persona.telefono = Convert.ToInt32(Console.ReadLine())
            Console.WriteLine("Dame el edad: ")
            persona.edad = Convert.ToInt32(Console.ReadLine())

            escribir.Write(persona.codigo)
            escribir.Write(persona.nombre)
            escribir.Write(persona.direccion)
            escribir.Write(persona.telefono)
            escribir.Write(persona.edad)


            i += 1
            Console.WriteLine("Quieres acabar?????Pulsa s")
            acabar = Console.ReadLine().ToLower
            Console.WriteLine(vbCrLf)
        Loop Until acabar.Contains("s")

        escribir.Close() : fichero.Close()

        Console.WriteLine("Que persona quieres buscar?")
        Dim res As Int32 = Convert.ToInt32(Console.ReadLine())



        fichero = New FileStream("C:\prueba\prueba.txt", FileMode.Open, FileAccess.Read)
        Dim leer As BinaryReader = New BinaryReader(fichero)
        leer.BaseStream.Seek((res - 1) * tamareg, SeekOrigin.Begin)

        If (fichero.Length <= fichero.Position) Then
            Console.WriteLine("sobrepasado")
        Else
            Console.WriteLine("Codigo:  " & leer.ReadInt32())
            Console.WriteLine("Nombre:  " & leer.ReadString())
            Console.WriteLine("Direccion: " & leer.ReadString())
            Console.WriteLine("Telefono: " & leer.ReadInt32())
            Console.WriteLine("Edad: " & leer.ReadInt32())
            Console.WriteLine(vbCrLf)

        End If

        leer.Close() : fichero.Close()

        Console.ReadKey()
    End Sub

    Structure persona

        Dim nombre, direccion As String
        Dim telefono, edad, codigo As Int32
    End Structure

End Module
