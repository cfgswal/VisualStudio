Module Actividad41
    'Realizar un programa que lea una fecha representada por dos enteros, mes y ano, y de como resultado el numero de dıas de ese mes. 
    'Hacer el ejercicio de formas distintas (con If).

    Sub Main()

        Dim mes, anio As Integer

        Console.WriteLine("Escribe numero de mes")
        mes = Convert.ToUInt32(Console.ReadLine)

        Console.WriteLine("Escribe numero de anio")
        anio = Convert.ToUInt32(Console.ReadLine)

        If (mes = 1 Or mes = 3 Or mes = 5 Or mes = 7 Or mes = 8 Or mes = 10 Or mes = 12) Then Console.WriteLine("Tiene 31 dias")

        If (mes = 4 Or mes = 6 Or mes = 9 Or mes = 11) Then Console.WriteLine("Tiene 30 dias")

        If mes = 2 Then
            If (anio Mod 4 = 0) And (anio Mod 100 <> 0) Or (anio Mod 400 = 0) Then Console.WriteLine("Tiene 29 dias")

            Console.WriteLine("Tiene 28 dias")

        End If
        Console.ReadKey()
    End Sub

End Module
