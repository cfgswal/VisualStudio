Imports System.IO
Module Module1
    'Desarrolla un programa que cree un fichero, con el nombre indicado por el usuario, que guarde los datos de un conjunto de personas (nombre, dirección, teléfono y dirección de correo). 
    'Posteriormente lee los datos de este fichero y visualízalos en pantalla.
    Sub Main()
        Dim array(100) As Byte


        Dim acabar, fich, nombre, direccion, correo As String
        Dim telefono, i, x As Int32
        Dim enter As Int32 = 13
        Console.WriteLine("Dime nombre del fichero: ")
        fich = Console.ReadLine()
        Dim fichero As filestream = New filestream("c:\prueba\" & fich & ".txt", FileMode.Create, FileAccess.Write)



        'Do
        Console.WriteLine("Dame el nombre:")
        array(0) = Convert.ToByte(Console.Read())
        fichero.Write(array, 0, array.Length)
        Console.WriteLine("Dame la drieccion:")
        array(1) = Convert.ToByte(Console.Read())
        fichero.Write(array, 1, array.Length)





        fichero.Close()



        array.Clear(arraynombre, 0, 20)
        array.Clear(arraydireccion, 0, 20)

        fichero = New filestream("c:\prueba\" & fich & ".txt", FileMode.Open, FileAccess.Read)

        fichero.Read(array, 0, 20)
        Console.Write("Nombre: ")
        Console.Write(vbCrLf)
        For x = 0 To arraynombre.Length - 1
            Console.Write(Convert.ToChar(arraynombre(x)))
        Next
        Console.Write(vbCrLf)


        'Console.WriteLine("Dame el telefono:")
        'telefono = Console.ReadLine()
        'escribe.WriteLine(telefono)
        'Console.WriteLine("Dame la direccion de correo:")
        'correo = Console.ReadLine()
        'escribe.WriteLine(correo)
        'Console.WriteLine("Quieres acabar?????Pulsa s")
        'acabar = Console.ReadLine().ToLower
        'Console.WriteLine(vbCrLf)

        'Loop Until acabar.Contains("s")

        fichero.Close()
        Console.ReadKey()
    End Sub

End Module
