'P6E21 lee datos del teclado y los añade al final del fichero
Imports System.IO

Module Module1

    Sub Main()
        Dim datos As String = "Hola que tal"
        Dim fichero As FileStream = New FileStream("C:\prueba\prueba.txt", FileMode.Append, FileAccess.Write)
        Dim escritura As StreamWriter = New StreamWriter(fichero)

        escritura.WriteLine(datos)

        escritura.Close()



    End Sub

End Module
