Imports System.Data.SqlClient
Public Class basedatos
    Dim con As New SqlConnection
    Dim da As New SqlDataAdapter()
    Dim ds As New DataSet
    Dim cmd As New SqlCommand

    Public Sub New()
        con = New SqlConnection(My.Settings.conexion)
        RecuperarDatos()
    End Sub

    Public Function RecuperarDatos()
        Dim sql As String = "SELECT * FROM prueba"
        Dim cmd As New SqlCommand(sql, con)
        Try
            da = New SqlDataAdapter(cmd)
            da.Fill(ds, "prueba")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return da
    End Function

    Public Function insertar(ByRef nombre As String, ByRef id As String) As Boolean

        Try
            Dim cmd As SqlCommand = New SqlCommand("SP_INSERTAR_DATO", con)
            cmd.Parameters.Add("@id", SqlDbType.VarChar, 10).Value = id
            cmd.Parameters.Add("@nombre", SqlDbType.VarChar, 50).Value = nombre
            cmd.CommandType = CommandType.StoredProcedure
            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()
            MsgBox("Introducido")
        Catch ex As SqlException
            MsgBox("ID ya introducido")
        End Try

        Return True
    End Function

    Public Function modificar(ByRef nombre As String, ByRef id As String) As Boolean

        Dim cmd As SqlCommand = New SqlCommand("SP_MODIFICAR_DATO", con)

        cmd.Parameters.Add("@id", SqlDbType.VarChar, 10).Value = id
        cmd.Parameters.Add("@nombre", SqlDbType.VarChar, 50).Value = nombre
        cmd.CommandType = CommandType.StoredProcedure
        con.Open()
        cmd.ExecuteNonQuery()
        con.Close()
        MsgBox("Modificado")

        Return True
    End Function

    Public Function eliminar(ByRef id As String) As Boolean

        Dim cmd As SqlCommand = New SqlCommand("SP_ELIMINAR_DATO", con)

        cmd.Parameters.Add("@id", SqlDbType.VarChar, 10).Value = id
        cmd.CommandType = CommandType.StoredProcedure
        con.Open()
        cmd.ExecuteNonQuery()
        con.Close()
        MsgBox("Eliminado")

        Return True
    End Function

































End Class
