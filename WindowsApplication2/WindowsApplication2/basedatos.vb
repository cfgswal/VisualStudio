Imports System.Data.SqlClient
Public Class basedatos
    Dim con As New SqlConnection
    Dim da As New SqlDataAdapter()
    Dim ds As New DataSet
    Dim cmd As New SqlCommand

    Public Function RecuperarDatos()
        'Crea la conexion(configurada en My Projet)
        Dim con As New SqlConnection(My.Settings.conexion)
        'Hacemos la select a la tabla
        Dim sql As String = "SELECT * FROM prueba"
        'Le pasamos la select y la conexion configurada
        Dim cmd As New SqlCommand(sql, con)
        Try
            'Crea el dataAdptader que es como si fuera una base de datos 
            da = New SqlDataAdapter(cmd)
            'Guardamos la tabla prueba en el dataAdapter
            da.Fill(ds, "prueba")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return ds
    End Function

    Public Function insertar(ByRef nombre As String, ByRef id As String) As Boolean

        Try
            'Crea la conexion configurada
            Dim con As New SqlConnection(My.Settings.conexion)
            'Le pasamos el procedimiento
            Dim cmd As SqlCommand = New SqlCommand("SP_INSERTAR_DATO", con)
            'Le pasamos el valor del id
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id
            'Le pasamos el valor del nombre
            cmd.Parameters.Add("@nombre", SqlDbType.VarChar, 50).Value = nombre
            'Revisa el tipo de comando que le pasa (procedimiento)
            cmd.CommandType = CommandType.StoredProcedure
            'Abre la conexion
            con.Open()
            'Ejecuta el procedimiento
            cmd.ExecuteNonQuery()
            'Cierra la conexion
            con.Close()
            MsgBox("Introducido")
            'Para que muestre el mensage al repetir el id
        Catch ex As SqlException
            MsgBox("ID ya introducido")
        End Try

        Return True
    End Function

    Public Function modificar(ByRef nombre As String, ByRef id As String) As Boolean
        'Igual que el insert
        Dim con As New SqlConnection(My.Settings.conexion)
        Dim cmd As SqlCommand = New SqlCommand("SP_MODIFICAR_DATO", con)

        cmd.Parameters.Add("@id", SqlDbType.Int).Value = id
        cmd.Parameters.Add("@nombre", SqlDbType.VarChar, 50).Value = nombre
        cmd.CommandType = CommandType.StoredProcedure
        con.Open()
        cmd.ExecuteNonQuery()
        con.Close()
        MsgBox("Modificado")

        Return True
    End Function

    Public Function eliminar(ByRef id As String) As Boolean
        'Igual que el insert pero solo le pasamos el id
        Dim con As New SqlConnection(My.Settings.conexion)
        Dim cmd As SqlCommand = New SqlCommand("SP_ELIMINAR_DATO", con)

        cmd.Parameters.Add("@id", SqlDbType.Int).Value = id
        cmd.CommandType = CommandType.StoredProcedure
        con.Open()
        cmd.ExecuteNonQuery()
        con.Close()
        MsgBox("Eliminado")

        Return True
    End Function

End Class
