Imports System.IO

Module Module1

    Sub Main()
        Dim datos As String = "Hola que tal"
        Dim fichero As FileStream
        Dim escritura As StreamWriter
        fichero = New FileStream("C:\prueba\prueba.txt", FileMode.Append, FileAccess.Write)
        escritura = New StreamWriter(fichero)
        escritura.WriteLine(datos)
        escritura.Close()
        fichero.Close()


    End Sub

End Module
