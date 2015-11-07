Module Actividad3
    'Escribe un programa que pida una hora en segundos y la saque por pantalla en formato hh:mm:ss.
    Sub Main()
        Dim num, hora, min, seg As Integer

        Console.WriteLine("Dame un numero en segundos")

        num = Convert.ToInt32(Console.ReadLine())

        hora = num / 3600

        min = (num Mod 3600) / 60

        seg = (num Mod 3600) Mod 60

        Console.WriteLine("Horas: " & hora & " minutos: " & min & " segundos: " & seg)
        Console.ReadKey()

    End Sub

End Module