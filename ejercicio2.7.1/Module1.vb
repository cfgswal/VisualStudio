Module Actividad1
    'Escribe un programa que reciba una cantidad en euros y la convierta a dolares. Para llevar a cabo el cambio tambien tiene que pedir el tipo de cambio.
    Sub Main()
        Dim euros, dolares, cambio As Double

        Console.WriteLine("Dame una cantidad en euros")
        euros = Convert.ToDouble(Console.ReadLine())

        Console.WriteLine("Dime tipo de cambio")
        cambio = Convert.ToDouble(Console.ReadLine)

        dolares = (euros * cambio)

        Console.WriteLine(euros & " euros son " & dolares & " dolares")
        Console.ReadKey()
    End Sub

End Module
