﻿Module Module1
    '1.Crear una matriz con el número de elementos y la dimensión indicada por el usuario(entre uno y tres).A continuación el usuario debe teclear valores para llenar la matriz y por último debemos visualizar los datos almacenados en la matriz.
    Sub Main()
        Dim d, uno, dos, tres, v As Integer
        Console.WriteLine("Introduce la dimension de la matriz: ")
        d = Convert.ToInt32(Console.ReadLine)




        Select Case d
            Case 1

                Console.WriteLine("Introduce los elementos de la matriz: ")
                uno = Convert.ToInt32(Console.ReadLine)

                Dim matriz(uno) As Integer

                For index = 0 To uno
                    Console.WriteLine("Introduce los valores: ")
                    matriz(index) = Convert.ToInt32(Console.ReadLine)
                Next

                Console.Write("Los valores de la matriz son: ")

                For index = 0 To uno
                    v = matriz(index)
                    Console.Write(v & "  ")
                Next

            Case 2

                Console.WriteLine("Introduce los elementos de la matriz: ")
                uno = Convert.ToInt32(Console.ReadLine)
                Console.WriteLine("Introduce los elementos de la matriz: ")
                dos = Convert.ToInt32(Console.ReadLine)
                Dim matriz(uno, dos) As Integer
                For index = 0 To uno

                    For indexdos = 0 To dos
                        Console.WriteLine("Introduce los valores: ")
                        matriz(index, indexdos) = Convert.ToInt32(Console.ReadLine)
                    Next
                Next
                Console.Write("Los valores de la matriz son: ")
                For index = 0 To uno
                    Console.WriteLine(vbCrLf)
                    For indexdos = 0 To dos
                        v = matriz(index, indexdos)
                        Console.Write(v & "  ")
                    Next

                Next


            Case 3
                Console.WriteLine("Introduce los elementos de la matriz: ")
                uno = Convert.ToInt32(Console.ReadLine)
                Console.WriteLine("Introduce los elementos de la matriz: ")
                dos = Convert.ToInt32(Console.ReadLine)
                Console.WriteLine("Introduce los elementos de la matriz: ")
                tres = Convert.ToInt32(Console.ReadLine)
                Dim matriz(uno, dos, tres) As Integer
                For index = 0 To uno

                    For indexdos = 0 To dos

                        For indextres = 0 To tres
                            Console.WriteLine("Introduce los valores: ")
                            matriz(index, indexdos, indextres) = Convert.ToInt32(Console.ReadLine)
                        Next
                    Next
                Next
                Console.Write("Los valores de la matriz son: ")
                For index = 0 To uno
                    Console.WriteLine(vbCrLf)
                    For indexdos = 0 To dos

                        For indextres = 0 To tres
                            v = matriz(index, indexdos, indextres)
                            Console.Write(v & "  ")
                        Next
                    Next

                Next

        End Select

        Console.ReadKey()
    End Sub

End Module
