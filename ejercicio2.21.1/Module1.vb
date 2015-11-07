Module Module1
    '1.Realizar un programa que pida dos valores y calcule la suma de todos los números comprendidos entre ellos. (el primer número debe ser menor que el segundo).
    Sub Main()

        Dim num1, num2, sumar As Integer

        EntradaDatos(num1, num2)
        VisualizarDatos(num1, num2, sumar)

        Console.ReadKey()
    End Sub

    Private Sub EntradaDatos(ByRef num1 As Integer, ByRef num2 As Integer)
        Do
            Console.WriteLine("Escribe el primer numero:")
            num1 = Convert.ToInt32(Console.ReadLine)
            Console.WriteLine("Escribe el segundo numero:")
            num2 = Convert.ToInt32(Console.ReadLine)
            If (num1 >= num2) Then Console.WriteLine("El primero tiene que ser menor que el segundo")

        Loop While (num1 >= num2)
    End Sub

    Private Function VisualizarDatos(ByRef num1 As Integer, ByRef num2 As Integer, ByRef sumar As Integer) As Integer
        num1 += 1
        num2 -= 1
        While (num1 <= num2)
            sumar = num1 + sumar
            num1 += 1
        End While

        Console.WriteLine(sumar)
        Return sumar
    End Function


End Module