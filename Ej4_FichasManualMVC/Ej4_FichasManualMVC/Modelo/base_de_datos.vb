Imports System.Data.SqlClient

Public Class base_de_datos
    'para crear la conexión
    Dim con As New SqlConnection(My.Settings.)

    'para crear el adaptador
    Dim cmd As New SqlCommand()
    Dim da As New SqlDataAdapter()

    'para crear el conjunto de datos, el DataSet
    Dim ds As New DataSet

    'para acceder a las filas en la tabla
    Dim MaxRows As Integer
    'indice del registro actual
    Dim inc As Integer = 0

End Class
