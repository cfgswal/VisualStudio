﻿Module Module1
    'Realizar un programa que lea una fecha representada por dos enteros, mes y ano, y de como resultado el numero de dıas de ese mes. 
    'Hacer el ejercicio de formas distintas (con select).
    Sub Main()
        Dim mes, anio As Integer

        Console.WriteLine("Escribe numero de mes")
        mes = Convert.ToUInt32(Console.ReadLine)

        Console.WriteLine("Escribe numero de anio")
        anio = Convert.ToUInt32(Console.ReadLine)


        Select Case mes
            Case 1, 3, 5, 7, 8, 10, 12
                Console.WriteLine("Tiene 31 dias")
            Case 4, 6, 9, 11
                Console.WriteLine("Tiene 30 dias")
            Case 2 And (anio Mod 4 = 0) And (anio Mod 100 <> 0) Or (anio Mod 400 = 0)
                Console.WriteLine("Tiene 29 dias")
            Case 2 And (anio Mod 4 <> 0) And (anio Mod 100 = 0)
                Console.WriteLine("Tiene 28 dias")


        End Select
        Console.ReadKey()

    End Sub

End Module
