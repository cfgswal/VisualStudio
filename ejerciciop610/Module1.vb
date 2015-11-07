
Imports System.IO
    'P610 lee del teclado el contenido del fichero y escríbelo en fichero
    Module Module1

        Sub Main()
            Dim array(80) As Byte
            Dim lee, x As Integer
            Dim enter As Integer = 13
        Dim fichero As FileStream = New FileStream("c:\prueba\texto.txt", FileMode.Create, FileAccess.Write)

        lee = Console.Read()
            While (lee <> enter And x < 80)
                array(x) = Convert.ToByte(lee)
                x += 1
                lee = Console.Read()
            End While

            fichero.Write(array, 0, array.Length)

        fichero.Close()
    End Sub

    End Module
