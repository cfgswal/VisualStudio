Module Actividad42
    'Realizar un programa que lea una fecha representada por dos enteros, mes y ano, y de como resultado el numero de dıas de ese mes. 
    'Hacer el ejercicio de formas distintas (con ElseIf).
    Sub Main()
        Dim mes, anio As Integer

        Console.WriteLine("Escribe numero de mes")
        mes = Convert.ToUInt32(Console.ReadLine)

        Console.WriteLine("Escribe numero de anio")
        anio = Convert.ToUInt32(Console.ReadLine)


        If (mes Mod 2 <> 0) Then
            Console.WriteLine("Tiene 31 dias")

        ElseIf (mes Mod 2 = 0 And mes <> 2) Then
            Console.WriteLine("Tiene 30 dias")

        End If

        If (mes = 2) Then
        ElseIf (anio Mod 4 <> 0) Then
            Console.WriteLine("Tiene 28 dias")


        ElseIf (anio Mod 4 = 0) Then
            Console.WriteLine("Tiene 29 dias")

        End If
        Console.ReadLine()
    End Sub

End Module
